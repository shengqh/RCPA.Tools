using System;
using System.Collections.Generic;
using System.Windows.Forms;
using RCPA.Proteomics.Quantification.Labelfree;
using System.Threading;
using System.Globalization;
using RCPA.Proteomics.Image;

namespace ProteomicsTools
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
      //Application.Run(new IdentifiedPeptideValidatatorUI());
      Application.Run(new MainForm());
      Console.WriteLine();
    }
  }
}