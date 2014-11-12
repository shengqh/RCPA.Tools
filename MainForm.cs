using RCPA.Gui;
using RCPA.Gui.Command;
using RCPA.Proteomics.Analysis;
using RCPA.Proteomics.Distiller;
using RCPA.Proteomics.Mascot;
using RCPA.Proteomics.Quantification;
using RCPA.Proteomics.Quantification.Labelfree;
using RCPA.Proteomics.Quantification.SILAC;
using RCPA.Proteomics.Raw;
using RCPA.Tools;
using RCPA.Tools.Database;
using RCPA.Tools.Distiller;
using RCPA.Tools.Format;
using RCPA.Tools.Glycan;
using RCPA.Tools.Isotopic;
using RCPA.Tools.Mascot;
using RCPA.Tools.Misc;
using RCPA.Tools.Modification;
using RCPA.Tools.Quantification;
using RCPA.Tools.Quantification.Lipid;
using RCPA.Tools.Raw;
using RCPA.Tools.Sequest;
using RCPA.Tools.Summary;
using TICDistiller;
using RCPA.Proteomics.Isotopic;
using RCPA.Tools.Utils;
using RCPA.Proteomics.MaxQuant;
using RCPA.Proteomics.Format;
using RCPA.Proteomics.Database;
using RCPA.Proteomics.Quantification.Srm;
using RCPA.Seq;
using RCPA.Proteomics.Snp;
using RCPA.Proteomics.Quantification.ITraq;
using RCPA.Proteomics.Image;
using RCPA.Proteomics.Summary.Uniform;
using RCPA.Proteomics.Statistic;
using RCPA.Proteomics.Quantification.O18;
using RCPA;
using RCPA.Proteomics.Quantification.IsobaricLabelling;
using RCPA.Proteomics.ProteomeDiscoverer;
using RCPA.Proteomics.Percolator;

namespace ProteomicsTools
{
  public partial class MainForm : RCPA.Gui.Command.CommandForm
  {
    public static readonly string version = RcpaToolsAssembly.Version;

    public static bool PublishVersion { get; set; }

    public MainForm()
    {
      InitializeComponent();

      this.Text = Constants.GetSQHTitle(RcpaToolsAssembly.Title, version);

      //Summary
      AddCommand(new UniformBuildSummaryUI.Command());

      //AddCommand(new SequestSummaryBuilderUI.Command());
      //AddCommand(new MascotDatSummaryBuilderUI.Command());

      //AddCommand(new XTandemXmlSummaryBuilderUI.Command());
      //AddCommand(new pFindSummaryBuilderUI.Command());
      //AddCommand(new pFindSummaryBuilder2UI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Summary));

      AddCommand(new IdentifiedPeptidesMergerUI.Command());

      AddCommand(new SummaryBuilderFromPeptidesUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Summary));

      AddCommand(new BuildSummaryResultParserUI.Command());

      AddCommand(new BatchUniformIdentifiedResultBuilderUI.Command());

      //Format
      //20110306, 1.0.0
      AddCommand(new MultipleRaw2MgfProcessor3UI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Format));

      AddCommand(new TurboRaw2MzXmlProcessorUI.Command());
      AddCommand(new MultipleRaw2DtaProcessorUI.Command());

      //20120213, 1.0.0
      AddCommand(new MultipleMgfPrecursorCorrectionProcessorUI.Command());

      //20111010, 1.0.0
      AddCommand(new MergeMgfFileProcessorUI.Command());

      AddCommand(new TripleTOFTextToMGFMainProcessorUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Format));

      AddCommand(new TurboOuts2PepXmlConverterUI.Command());
      AddCommand(new IdentifiedResult2DtaSelectProcessorCommand());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Format));

      //AddCommand(new MsfFileToNoredundantProcessorUI.Command());

      //20110214
      AddCommand(new ProteinProphetToSummaryProcessorUI.Command());

      //20110321
      AddCommand(new BuildSummaryWebFormatConverterUI.Command());

      //20140808
      AddCommand(new MultipleMgf2Ms2ProcessorUI.Command());

      //20141014
      AddCommand(new MsfFastaDistillerUI.Command());

      //Distiller
      AddCommand(new DistinctResultDistillerUI.Command());
      AddCommand(new LabelledResultDistillerUI.Command());
      AddCommand(new SimpleProteinGroupBuilderUI.Command());
      AddCommand(new ExtractProteinByIdProcessorUI.Command());
      AddCommand(new ExtractProteinOnlyProcessorUI.Command());
      AddCommand(new SnpPeptideDistillerUI.Command());
      AddCommand(new TargetPeptideDistillerUI.Command());

      AddCommand(new MultiplePercolatorPeptideDistillerUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Distiller));

      AddCommand(new IdentifiedPeptidesDistillerUI.Command());
      AddCommand(new ProteinXPeptideDistillerUI.Command());
      AddCommand(new ValidatedPeptideDistillerUI.Command());
      AddCommand(new AmbigiousModifiedPeptideRemoverUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Distiller));

      AddCommand(new TurboMsLevelDistillerUI.Command());
      AddCommand(new TICDistillerUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Distiller));

      AddCommand(new UniquePeptideDistillerUI.Command());
      AddCommand(new UniquePeptideProteinDistillerUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Distiller));

      //AddCommand(new ChineseFileName2PinYingProcessorCommand());

      //Quantification
      AddCommand(new O18QuantificationFileProcessorUI.Command());
      //AddCommand(new O18QuantificationUserProcessorUI.Command());
      AddCommand(new O18QuantificationSummaryViewerUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));

      AddCommand(new SilacQuantificationProteinFileProcessorUI.Command());
      AddCommand(new SilacQuantificationSummaryViewerUI.Command());
      //AddCommand(new SilacResultSplitterUI.Command());
      //AddCommand(new ExtendSilacQuantificationProteinFileProcessorUI.Command());
      //AddCommand(new ExtendSilacQuantificationSummaryViewerUI.Command());

      AddCommand(new ProteinLabelFreeQuantificationBuilderUI.Command());
      AddCommand(new ProteinChromotographProcessorUI.Command());
      AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));

      AddCommand(new DtaselectFileSplitterCommand());
      AddCommand(new TurboCensusMs1BuilderUI.Command());
      AddCommand(new TurboCensusMs1IndexBuilderUI.Command());
      AddCommand(new CensusChroFileSplitterUI.Command());
      AddCommand(new CensusResultFileMergerCommand());
      AddCommand(new CensusResultFileMerger2UI.Command());
      AddCommand(new CensusResultUniquePeptideCountFilterCommand());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));

      AddCommand(new ITraqResultMultipleFileDistillerUI.Command());
      //AddCommand(new ITraqResultImageBuilderUI.Command());
      AddCommand(new ITraqPeptideStatisticBuilderUI.Command());
      //AddCommand(new ITraqPhosphoPeptideStatisticBuilderUI.Command());
      //AddCommand(new ITraqPeptideRsdFilterUI.Command());
      AddCommand(new ITraqUniquePeptideStatisticBuilderUI.Command());
      AddCommand(new ITraqProteinStatisticBuilderUI.Command());

      AddCommand(new IsobaricLabelingEfficiencyCalculatorUI.Command());
      AddCommand(new IsobaricResultMultipleFileDistillerUI.Command());
      AddCommand(new IsobaricProteinStatisticBuilderUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));
      AddCommand(new LipidQuantificationProcessorUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));

      //20110314, 1.0.8
      //AddCommand(new AgilentMRMFileProcessorUI.Command());
      AddCommand(new SrmDistillerUI.Command());
      //AddCommand(new SrmBrowserUI.Command());
      //AddCommand(new MRMMultipleFileBrowserUI.Command());
      //AddCommand(new SrmValidatorUI.Command());
      AddCommand(new SrmValidatorUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));

      //AddCommand(new AgilentToMS1BuilderUI.Command());

#if (!PublicVersion)
      AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));

      //AddCommand(new SmallMoleculeDataPreparationProcessorUI.Command());
      //AddCommand(new SmallMoleculeDataMostIntensityBuilderUI.Command());
      //AddCommand(new SmallMoleculeSignificantPeakFinderUI.Command());
      //AddCommand(new SmallMoleculeQuantificationViewerUI.Command());
      //AddCommand(new SmallMoleculeDataImageBuilderUI.Command());

      //AddCommand(new ToolCommandSeparator(MenuCommandType.Quantification));
      AddCommand(new ForwardReverseRatioCalibratorUI.Command());

      AddCommand(new ProteinChromotographViewer.Command());
#endif

      //Statistic
      AddCommand(new ProteinDistributionUI.Command());
      AddCommand(new PeptideDistributionUI.Command());
      AddCommand(new ScoreDistributionBuilderUI.Command());
      AddCommand(new ScoreComparisonBuilderUI.Command());
      AddCommand(new RawIonStatisticMainBuilderUI.Command());
      AddCommand(new PrecursorOffsetCalculatorUI.Command());
      AddCommand(new MassOffsetCalculatorUI.Command());
      AddCommand(new ScanCountCalculatorUI.Command());
      AddCommand(new ProteinPeptideCorrelationCalculatorUI.Command());

      //Modification
      AddCommand(new IdentifiedResultModificationSeparatorUI.Command());
      AddCommand(new IdentifiedResultMultipleLabellingSeparatorUI.Command());
      AddCommand(new IdentifiedSpectrumMultipleLabellingSeparatorUI.Command());

      //Mascot
      AddCommand(new MascotResultHtmlDownloaderCommand(false));
      AddCommand(new MascotResultHtml2TextProcessorCommand());
      AddCommand(new TurboMascotGenericFormatShift10ProcessorUI.Command());
      AddCommand(new MascotGenericFormatSplitterUI.Command());

      AddCommand(new ToolCommandSeparator(MenuCommandType.Mascot));

      //20110126
      AddCommand(new UpdateMascotDatTitleFormatProcessorUI.Command());

      //20110127
      AddCommand(new UpdateMascotMGFTitleFormatProcessorUI.Command());
      AddCommand(new ReplaceMascotGenericFormatProcessorUI.Command());

      //Sequest
      AddCommand(new One2AllProcessorCommand());
      AddCommand(new AtomCompositionIsotopicProfileBuilderCommand());
      //AddCommand(new NGlycanPeptideMassCalculatorCommand());

      //Database
      AddCommand(new ReversedDatabaseBuilderCommand());
      AddCommand(new ShuffleDatabaseBuilderUI.Command());
      AddCommand(new FastaDatabaseDistillerUI.Command());
      //AddCommand(new TheoreticalDigestionStatisticCalculatorUI.Command());
      //20110310
      AddCommand(new ExtractFastaFromDatFileProcessorUI.Command());
      //20110919
      //AddCommand(new RemoveNTerminalMBuilderUI.Command());
      //20110928
      AddCommand(new ExtractFastaByAccessNumberProcessorUI.Command());

      //Misc
      AddCommand(new MassCalculatorUI.Command());
      AddCommand(new IdentifiedPeptideSubtractorUI.Command());
      AddCommand(new RawFileViewerUI.Command());
      //AddCommand(new AgilentFileViewerUI.Command());
      AddCommand(new GenerateIsotopicFileUI.Command());

#if (!PublicVersion)
      AddCommand(new ToolCommandSeparator(MenuCommandType.Misc));
      AddCommand(new PNovoSnpValidatorUI.Command());
      AddCommand(new MascotSnpValidatorUI.Command());
      AddCommand(new CombineQuantificationResultProcessorUI.Command());
      AddCommand(new SpectrumSnpValidatorUI.Command());
      AddCommand(new IdentifiedPeptideValidatatorUI.Command());
#endif

      //20111017
      AddCommand(new DatabaseSnpValidatorUI.Command());
      //AddCommand(new RcpaGrouperUI.Command());

      AddCommand(new SrmTransitionDefinitionForm.Command());

      AddCommand(new ITraqQuantificationSummaryViewerUI.Command());

      //20110119
      AddCommand(new MaxQuantPeptidesMergerUI.Command());
      AddCommand(new MaxQuantMgfDistillerUI.Command());

      //20110121, 1.0.0
      //20110216, 1.0.1
      AddCommand(new MaxQuantFileDistillerUI.Command());
      AddCommand(new MaxQuantPeptideRatioDistillerUI.Command());

      //20110930
      AddCommand(new MaxQuantToMgfProcessorUI.Command());
      //20110221, 1.0.1
      AddCommand(new MaxQuantSiteToPeptideProcessorUI.Command());
      AddCommand(new MaxQuantEvidenceToPeptideProcessorUI.Command());

      //20131113
      AddCommand(new RawScanParentChildDistillerUI.Command());

      //Setup
      AddCommand(new ExternalProgramConfigUI.Command());

      //Help
      AddCommand(new HelpCommand());

      LoadOption();
    }
  }
}

