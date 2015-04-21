using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RCPA.Gui.Command;
using RCPA.Utils;
using RCPA.Commandline;
using ProteomicsTools;
using RCPA.Tools.Summary;

namespace CQS
{
  internal static class Program
  {
    private const int AttachParentProcess = -1;

    [DllImport("kernel32.dll")]
    private static extern bool AttachConsole(int dwProcessId);

    /// <summary>
    ///   The main entry point for the application.
    /// </summary>
    [STAThread]
    private static void Main(string[] args)
    {
      var commands = new ICommandLineCommand[]
      {
        new UniformSummaryBuilderUI.Command()
      }.ToDictionary(m => m.Name.ToLower());

      if (!SystemUtils.IsLinux && args.Length == 0)
      {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var mainForm = new MainForm();
        foreach (var command in commands.Values)
        {
          if (command is IToolCommand)
          {
            mainForm.AddCommand(command as IToolCommand);
          }
        }

        Application.Run(mainForm);
      }
      else
      {
        if (!SystemUtils.IsLinux)
        {
          AttachConsole(AttachParentProcess);
        }

        ICommandLineCommand command;
        if (args.Length == 0)
        {
          ShowUsage(commands);
        }
        else if (commands.TryGetValue(args[0].ToLower(), out command))
        {
          if (command.Process(args.Skip(1).ToArray()))
          {
            Console.WriteLine("Done!");
          }
        }
        else
        {
          Console.WriteLine("Error command " + args[0] + ".");
          ShowUsage(commands);
        }
      }
    }

    private static void ShowUsage(Dictionary<string, ICommandLineCommand> commands)
    {
      Console.WriteLine(Constants.GetSQHTitle(RcpaToolsAssembly.Title, RcpaToolsAssembly.Version));
      Console.WriteLine("Those commands are available :");
      (from c in commands.Values
       orderby c.Name
       select "\t" + c.Name + "\t" + c.Description).ToList().ForEach(Console.WriteLine);
    }
  }
}