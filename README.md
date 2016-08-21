ProteomicsTools Software Suite
==
* [Introduction](#Introduction)
  * [BuildSummary](#BuildSummary) [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/BuildSummary)]
  * [SRMBuilder](#SRMBuilder) [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/SRMBuilder)]
  * [O18Quant](#O18Quant) [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/O18Quant)]
  * [TurboRaw2MGF](#TurboRaw2MGF) [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/TurboRaw2MGF)]
  * [DeuteriumCalculator](#DeuteriumCalculator) [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/DeuteriumCalculator)] 
  * [Isobaric Labeling Quantification Suite](https://github.com/shengqh/RCPA.Tools/wiki/IsobaricQuant)
* [Prerequisites](#Prerequisites)
* [Installation](#Installation)
* [Citation](#Citation)
* [Changes](#changes)

<a name="Introduction"/>
#Introduction

ProteomicsTools software suite contains a bunch of tools used in proteomics research, from identification result parsing to quantification, modification, et. al.

Currently, there are few major softwares with full documents, please cite corresponding paper if you use ProteomicsTools in your project:

<a name="BuildSummary"/>
- **BuildSummary** [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/BuildSummary)] : The target-decoy database search strategy is widely accepted as a standard method for estimating the false discovery rate (FDR) of peptide identification, based on which peptide-spectrum matches (PSMs) from the target database are filtered. To improve the sensitivity of protein identification given a fixed accuracy (frequently defined by a protein FDR threshold), a post-processing procedure is often used that integrates results from different peptide search engines that had assayed the same dataset. In this work, we show that PSMs that are grouped by the precursor charge, the number of missed internal cleavage sites, the modification state, the numbers of protease termini and the proteins grouped by their unique peptide count should be filtered separately according to the given FDR. We also develop an iterative procedure to filter the PSMs and proteins simultaneously, according to the given FDR. Finally, we present a general framework to integrate the results from different peptide search engines using the same FDR threshold. Our method was tested with several shotgun proteomics datasets that were acquired by multiple LC/MS instruments from two different biological samples. The results showed a satisfactory performance. 

<a name="SRMBuilder" />
- **SRMBuilder** [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/SRMBuilder)] :
With high sensitivity and reproducibility, selected reaction monitoring (SRM) has become increasingly popular in proteome research for targeted quantification of low abundance proteins and post translational modification. SRM is also well accepted in other mass-spectrometry based research areas such as lipidomics and metabolomics, which necessitates the development of easy-to-use software for both post-acquisition SRM data analysis and quantification result validation. Here, we introduce a software tool SRMBuilder, which can automatically parse SRM data in multiple file formats, assign transitions to compounds, match light/heavy transition/compound pairs and provide a user-friendly graphic interface to manually validate the quantification result at transition/compound/sample level. SRMBuilder will greatly facilitate processing of the post-acquisition data files and validation of quantification result for SRM. 

<a name="O18Quant" />
- **O18Quant** [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/O18Quant)] : Proteolytic 18O-labeling has been widely used in quantitative proteomics since it can uniformly label all peptides from different kind of proteins. There have been multiple algorithms and tools developed over the last few years to analyze high-resolution proteolytic 16O/18O labeled mass spectraanalyze high-resolution proteolytic 18O-labeled mass spectra. We have developed a software tool: O18Quant, which addresses two major issues in the previous developed tools.  First, O18Quant uses robust linear model (RLM) for peptide-to-protein ratio estimation. RLM can minimize the effect of outliers instead of iteratively removing them which is a common practice in other approaches. Second, the existing approaches lack applicable implementation which O18Quant is implemented using C# under Microsoft .net framework and R. It automatically calculates the peptide/protein relative ratio and provides a friendly graphic user interface (GUI) which allows the user to manually validate the quantification result at scan, peptide and protein levels. The intuitive GUI O18Quant can greatly enhance the user’s visualization and understanding of the data analysis. 

<a name="TurboRaw2MGF" />
- **TurboRaw2MGF** [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/TurboRaw2MGF)] : Isobaric labelling technique coupled with high resolution mass spectrometry has been widely employed in proteomic workflows requiring relative quantification. For each high resolution tandem mass spectrum (MS/MS), it can be used not only to quantify the peptide from different samples by reporter ions，but also to identify the peptide it derived from. Since the ions related to isobaric labeling may act as noise in database searching, the MS/MS spectrum should be preprocessed before peptide/protein identification. In this paper, we demonstrate that there are a lot of high frequency, high abundance isobaric related ions in MS/MS spectrum, and combining removing isobaric related ions with deisotoping and deconvolution in MS/MS preprocessing procedure improves the peptide/protein identification sensitivity significantly. 

<a name="DeuteriumCalculator" />
- **DeuteriumCalculator** [[Full documents](https://github.com/shengqh/RCPA.Tools/wiki/DeuteriumCalculator)] : A promising strategy that is available for quantifying rates of protein synthesis is the administration of heavy water (deuterium oxide, D2O) to living organisms. In this strategy, mass spectrometry is used to monitor the kinetics of deuterium incorporation into the newly synthesized protein molecules, and the kinetics of deuterium enrichment are calculated over a time-course experiment. Currently, however, there are few freely available software for deuterium enrichment analysis based on high resolution mass spectrometry data.
We have developed a user friendly software, DeuteriumCalculator, that efficiently extracts the chromatograph information of identified peptides from high resolution mass spectrometry data and calculates the extent of deuterium enrichment based on isotopomer distribution. A real data example is given to demonstrate the effectiveness and output format of the software.
DeuteriumCalculator is designed to facilitate D2O-based protein turnover research by automating the most time-consuming step in the data analysis: calculation of the extent of deuterium enrichment from the mass spectrometry data. DeuteriumCalculator is expected to substantially expedite the process of deuterium enrichment analysis.


<a name="Prerequisites" />
#Prerequisites
Two libraries are required for executing the software:	
- [MSFileReader library](http://sjsupport.thermofinnigan.com/public/detail.asp?id=703)
- [dotNET Platform 4.0] (http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=17718)

<a name="Installation"/>
#Installation
###Binary File
Both 64bit version and 32bit version are provided in [github](https://github.com/shengqh/RCPA.Tools/releases). Download the file and decompress it to any folder you want, run ProteomicsTools.exe and have fun.

###Source
The c# source code is also provided at following repositories. Visual Studio 2015 is recommended for compilation.

- [SQH.Lib](https://github.com/shengqh/SQH.Lib/) : Third part C# libraries required by other modules.
- [RCPA.Core](https://github.com/shengqh/RCPA.Core/) : Core library of GUI and utilities.
- [RCPA.Proteomics](https://github.com/shengqh/RCPA.Proteomics/) : Proteomics library including a lot of proteomics related utilities and tools.
- [RCPA.Tools](https://github.com/shengqh/RCPA.Tools/) : Proteomics Tool Suite interface.

<a name="Citation"/>
#Citation
- SILAC Quantification : Vukoti K, Yu X, Sheng Q, Saha S, Feng Z, Hsu AL, Miyagi M: Monitoring newly synthesized proteins over the adult life span of Caenorhabditis elegans. J Proteome Res 2015, 14(3):1483-1494.
- TurboRAW2MGF : Sheng Q, Li R, Dai J, Li Q, Su Z, Guo Y, Li C, Shyr Y, Zeng R: Preprocessing significantly improves the peptide/protein identification sensitivity of high-resolution isobarically labeled tandem mass spectrometry data. Mol Cell Proteomics 2015, 14(2):405-417.
- O18 Quantification : Guo Y, Miyagi M, Zeng R, Sheng Q: O18Quant: A Semiautomatic Strategy for Quantitative Analysis of High-Resolution 16O/18O Labeled Data. BioMed research international 2014, 2014:971857.
- BuildSummary : Sheng Q, Dai J, Wu Y, Tang H, Zeng R: BuildSummary: using a group-based approach to improve the sensitivity of peptide/protein identification in shotgun proteomics. J Proteome Res 2012, 11(3):1494-1502.
- SRMBuilder : Sheng Q, Wu C, Su Z, Zeng R: SRMBuilder: a user-friendly tool for selected reaction monitoring data analysis. Journal of bioinformatics and computational biology 2011, 9 Suppl 1:51-62.

<a name="Changes"/>
#Changes
- 2016/08/14 Version 4.1.0
 1. Enhanced: Deuterium Calculator. Calculate ratio consistant at protein level.
- 2016/08/02 Version 4.0.18
 1. Enhanced: Deuterium Calculator. Support both peptide and protein level calculation based on time point definition. Median value will be used for each time point.
- 2016/07/26 Version 4.0.17
 1. Enhanced: Deuterium Calculator. Report theoretical enrichment of deuterium, observed enrichment of deuterium and number of deuterium incorporated in final result. Move intermediate result into detail directory.
- 2016/07/20 Version 4.0.16
 1. Enhanced: Deuterium Calculator. Add option for calculate number of deuterium using different formula.
- 2016/07/19 Version 4.0.15
 1. Bug fix: Deuterium Calculator. Support the new label free quantification format.
- 2016/03/08 Version 4.0.14
 1. Enhanced: Deuterium Calculator. Throw exception when R is not found in system registration.
- 2016/03/07 Version 4.0.13
 1. Enhanced: Deuterium Calculator. Updated the R code for calculation which will install packages properly.
- 2016/03/01 Version 4.0.12
 1. New feature: Deuterium Calculator.
- 2016/01/14 Version 4.0.11
 1. Bugfix: Reversed database builder, error when no contamination file assigned.
- 2015/11/23 Version 4.0.10
 1. Bugfix: MS3 Peptide Variants Interpreter 1.0.8, SingleAminoacidPolymorphism is saved with error format in fasta file
- 2015/11/12 Version 4.0.9
 1. Enhanced: MS3 Library Builder/MS3 Peptide Variants Interpreter 1.0.7, restore excluding peptide file as optional parameter.
- 2015/11/11 Version 4.0.8
 1. Enhanced: MS3 Library Builder/MS3 Peptide Variants Interpreter 1.0.6
 2. Enhanced: Add about page with homepage and email links.
- 2015/10/14 Version 4.0.7
 1. Enhanced: BuildSummary 7.1.8： support to group spectrum by protein tag for FDR estimation.
- 2015/10/12 Version 4.0.6
 1. Enhanced: Multiple Raw To MGF: add overwrite option.
 2. Enhanced: Silac Quantification Summary Viewer 1.2.0: Filter protein and peptide by correlation seprately.
 3. Enhanced: BuildSummary speed up and support target-decoy-spectrum searching strategy.
- 2015/10/01 Version 4.0.5
 1. Bugfix: Mascot Generic Format File Precursor Shifting Precessor 1.2.0: add unnecessary (hydrogen mass * precursor charge) to the shift mass in previous version. Now fixed.
- 2015/09/24 Version 4.0.4
 1. Enhanced: MS3 Library Builder/MS2 SAP Predictor 1.0.4: output library ms2 score, expect value and proteins.
- 2015/09/22 Version 4.0.3
 1. Enhanced: MS3 Library Builder/MS2 SAP Predictor 1.0.3: consider modification at terminal loss, add options for max terminal loss and min terminal lossed sequence length.
- 2015/09/18 Version 4.0.2
 1. Enhanced: BuildSummary 7.1.7: filter single wonder by spectrum count for SimpleProtein/Peptide/UniquePeptide FDR mode, filter spectra with maximum miss cleavage sites (default 2).
- 2015/09/17 Version 4.0.1
 1. Enhanced: MS3 Library Builder/MS2 SAP Predictor 1.0.2: allow C-terminal loss in prediction, output interval data.
- 2015/09/15 Version 4.0.0
 1. Enhanced: MS3 SAP Predictor 1.0.1: allow N-terminal loss in prediction.
- 2015/09/04 Version 3.9.9
 1. Enhanced: SILAC Quantification Summary Viewer 1.1.0: the R sqaure only worked when user click the "Update" button, then the result saved can be displayed properly.
- 2015/08/24 Version 3.9.8
 1. New feature: MS3 Library Builder / MS3 SAP Predictor : predict single aminoacid polymorphism using MS2/MS3 data.
- 2015/08/06 Version 3.9.7
 1. Enhanced: mzXML format file generated by TurboRaw2MGF now is compatible with TPP (without nested scans).
- 2015/08/03 Version 3.9.6
 1. Enhanced: mzXML format file generated by TurboRaw2MGF now is compatible with MaxQuant.
- 2015/06/15 Version 3.9.5
 1. Bugfix: SILAC Quantification Calculator: compatible with atom composition file containing line with tab characters only.
- 2015/06/12 Version 3.9.4
 1. Enhanced: Turbo Mascot MGF Precursor Shift Processor: allow to input the shift mass.
- 2015/03/30 Version 3.9.3
 1. Enhanced: TurboRaw2MGF: allow to extract MS3 without any filtering while extract MS2 with filtering.
 2. Enhanced: BuildSummary: export retention time for each peptide-spectrum-match
- 2015/03/25 Version 3.9.2
 1. Enhanced: BuildSummary: the sequence with only I/L difference will be treated as identical sequence when calculating unique peptide count of protein.
 2. Enhanced: BuildSummary: the protein groups without any distinct peptide will be removed.
- 2015/03/10 Version 3.9.1
 1. Bugfix: pNovo SAP validator: compatible with pNovo sequences with unknown amino acid.
 2. Enhanced: Mascot SAP validator: throw exception when no mutation type information in protein name.
- 2015/02/26 Version 3.9.0
 1. Enhanced: MaxQuant Evidence To Peptide Converter: remove the PSM from decoy and contaminant proteins.
- 2015/02/16 Version 3.8.9
 1. Enhanced: BuildSummary: extract phosphorylation site probability from ProteomeDiscoverer MSF file.
 2. Enhanced: Isobaric Labelling Peptide Statistic Builder: Filter phosphorylation peptides by site probability.
 3. New: Aminoacid Insertion Builder
- 2015/02/13 Version 3.8.8
 1. Bugfix: Null reference exception of Mascot SAP Validator.
- 2015/01/21 Version 3.8.7
 1. Enhanced: BuildSummary: XTandem, Comet and MSGF+ supports using either Score or ExpectValue for false discovery rate filtering.
 2. Bugfix: Isobaric Labeling Peptide Statistic Builder: R code error when there is missing value.
 3. Bugfix: OMSSA parser: theoretical mass parsing error.
- 2015/01/13 Version 3.8.6
 1. Enhanced: Isobaric Labeling Peptide Statistic Builder: quantify peptides with/without modification.
 2. Bugfix: OMSSA parser: trust charge information in title.
- 2015/01/05 Version 3.8.5
 1. Enhanced: MaxQuant Site To Peptide Converter 1.0.3: parsing of modification site based on msms.txt for SILAC data.
- 2015/01/05 Version 3.8.4
 1. New: Isobaric Labeling Experimental Design Builder: Setup experimental category information and refernce channels which will be used in quantification.
 2. New: Isobaric Labeling Peptide Statistic Builder: Quantify peptides.
 3. Enhanced: Isobaric Labeling Protein Statistic Builder: The protein intensity of sample channels in final resuult will be normalized by refernece channel.
- 2014/12/30 Version 3.8.3
 1. Bugfix: BuildSummary 7.1.2: Theoretical mass and experimental mass parsing error in MzIdent format, MSGF and MyriMatch will be affected.
- 2014/12/30 Version 3.8.2
 1. Bugfix: MaxQuant Site To Peptide Converter 1.0.2: parsing of modification site
- 2014/12/29 Version 3.8.1
 1. Enhanced: O18 Quantification Suite: filter outliers before linear regression.
 2. Enhanced: SILAC Quantification Viewer: filter protein/peptide quantification result using R square. Only protein/peptide passed R square filter will be exported.
- 2014/12/23 Version 3.8.0 (IMPORTANT)
 1. Bugfix: Isobaric Labelling Protein Statistic Builder 1.2.2 : R code error for quantify protein using Sum method. If you used 1.2.0, you need to rerun the analysis.
- 2014/12/22 Version 3.7.9 (IMPORTANT)
 1. Bugfix: Isobaric Labelling Protein Statistic Builder 1.2.1 : R code error for quantify peptides. If you used 1.2.0, you need to rerun the analysis.
- 2014/12/18 Version 3.7.8
 1. Enhanced: Isobaric Labelling Protein Statistic Builder 1.2.0 : Export more protein information with final result.
- 2014/12/17 Version 3.7.7
 1. Enhanced: Isobaric labelling quantification tool supports both Sum and Median methods to calculate protein ratio from peptide intensities.
- 2014/12/17 Version 3.7.6
 1. New feature: Isobaric labelling quantification tool 
- 2014/12/14 Version 3.7.5
 1. Enhanced: Extract peptide information from percolator input.xml and output.xml : export more informations
 2. Enhanced: BuildSummary : can use pre-generated peptides as input file.
 3. Enhanced: BuildSummary : support MS Amanda.
- 2014/12/09 Version 3.7.4
 1. New feature: TurboRaw2MGF : remove precursor, -1 charge precursor and precursor isotipic ions
- 2014/12/02 Version 3.7.3
 1. Bugfix: BuildSummary : compatible with title format generated by proteomwizard/msconvert
- 2014/12/02 Version 3.7.2
 1. Enhanced: TurboRaw2MGF: Remove charge information of ion from MGF file; BuildSummary : compatible with title format generated by proteomwizard/msconvert
- 2014/12/02 Version 3.7.1
 1. Enhanced: TurboRaw2MGF: Export ProteomeDiscoverer1.4 compatible MGF.
- 2014/11/26 Version 3.7.0
 1. Enhanced: TurboRaw2MGF: 1) Export with Proteome Discoverer title format. 2) Export mzXml format
- 2014/11/12 Version 3.6.9
 1. New feature: Extract peptide information from percolator input.xml and output.xml.
- 2014/10/16 Version 3.6.8
 1. Bugfixed: Compatible with Mascot dat file with decoy searching.
- 2014/10/16 Version 3.6.7
 1. Bugfixed: Modification parse error for mascot MSF file.
- 2014/10/15 Version 3.6.6
 1. Bugfixed: Modification parse error for decoy entry in MSF file.
- 2014/10/14 Version 3.6.5
 1. Bugfixed: Error 'bad format' when parsing xtandem xml file.
- 2014/10/12 Version 3.6.4
 1. Enhanced: BuildSummary is compatible with the search result from MyriMatch, OMSSA and MSGF+.
- 2014/10/10 Version 3.6.3
 1. Enhanced: Improve the accuracy of isobaric labelling data extraction.
- 2014/09/30 Version 3.6.2
 1. Enhanced: Compatible with MSAmanda msf file generated by ProteomeDiscoverer
- 2014/09/30 Version 3.6.1
 1. Bugfix: Parsing miss cleavage site from ProteomeDiscoverer msf file.
 2. Enhanced: Add spectrum fdr and peptide fdr in BuildSummary Result Parser. 
- 2014/09/28 Version 3.6.0
 1. Enhanced: Sequest/Comet/ProteomeDiscoverer Identification Summary Builder
 2. And other improvements. 
- 2014/04/14 Version 3.5.1
 1. Enhanced: O18 Quantification Calculator v1.1.6, O18 Quantification Summary Viewer v1.4.6: generating temporary files into 'detailed' directory other than with final summary file. 
- 2014/04/09 Version 3.5.0
 1. Enhanced: O18 Quantification Calculator v1.1.5.
 2. Enhanced: O18 Quantification Summary Viewer v1.4.5.
- 2014/02/28 Version 3.4.9
 1. Enhanced: O18 quantification summary viewer.
- 2014/02/04 Version 3.4.8
 1. Enhanced: O18 quantification summary viewer.
- 2014/01/15 Version 3.4.7
 1. Enhanced: SILAC quantification summary viewer.
- 2014/01/08 Version 3.4.6
 1. Enhanced: SILAC quantification summary viewer.
- 2014/01/07 Version 3.4.5
 1. Enhanced: O18 quantification summary viewer.
- 2013/01/02 Version 3.4.3
 1. Enhanced: SILAC/O18 quantification summary viewer.
- 2013/01/02 Version 3.3.9
 1. Enhanced: Compatible with some thermo raw file with bad scan which cannot be read out. A xxx.baddatascan will be generated once such scans are found and those scans will be ignored in some tools, currently in SILAC quantification tools.
- 2012/12/20 Version 3.3.8
 1. Enhanced: BuildSummary, compatible with protein whose reference contains character '\t' or '/'.
 2. Bug fixed: SILAC Protein Quantification Builder, emass calculator initialized.
- 2012/12/19 Version 3.3.7
 1. Enhanced: BuildSummary, mascot dat parser compatible with protein whose name contains character '/'.
- 2012/12/17 Version 3.3.6
 1. Enhanced: Isobaric Labelling Protein Quantification
- 2012/06/13 Version 3.3.5
 1. New feature:Identified Peptide Chromatograph Extractor & Viewer
- 2012/06/06 Version 3.3.4
 1. Bug fixed: MSF To BuildSummary, key not found error.
 2. Enhanced: Isobaric Labelling Multiple File Distiller, compatible with the raw file contains wrong isolation window information.  
- 2012/05/25 Version 3.3.3
 1. New feature: Replace Precursor Information Processor
- 2012/05/10 Version 3.3.2
 1. Enhanced: Identified Unique Peptide iTRAQ Statistic Builder : get protein information from database.
 2. New feature: Isobaric Labeling Efficiency Calculator
- 2012/05/07 Version 3.3.1
 1. Bug fixed: MaxQuant Evidence To Peptide Converter : compatible with non-labelling data.
- 2012/05/04 Version 3.3.0
 1. Bug fixed: BuildSummary for XTandem.
- 2012/05/03 Version 3.2.9
 1. Enhanced : TurboRawToMGF, compatible with LysC protease with Isobaric Ion Deduction.
 2. New feature: MaxQuant Evidence To Peptide Converter.
- 2012/04/19 Version 3.2.8
 1. Enhanced : Access number parser updated for MaxQuant format of NCBI database.
- 2012/04/12 Version 3.2.7
 1. Bug fixed : The same transitions in different files will be wrong classified as different transitions in SRMValidator which introduced in latest update.
- 2012/04/11 Version 3.2.6
 1. Enhanced : BuildSummary 7.0.0, default filter for one-hit-wonder will ask for at least two peptide-spectrum-matches.
- 2012/04/10 Version 3.2.5
 1. Enhanced : SRMBuilder, can process the transition from same peptide but different charge.
- 2012/04/01 Version 3.2.4
 1. Enhanced : TurboRawToMgf, can remove isobaric ions at low and/or high mass range.
 2. Enhanced : Isobaric Labelling Multiple File Distiller, for 'out of memory exception'
- 2012/03/23 Version 3.2.3
 1. Enhanced : Interface adjustment.
- 2012/03/19 Version 3.2.2
 1. New feature : Combination of mutation and quantification builder, for SAP.
- 2012/03/16 Version 3.2.1
 1. Bug fixed : TurboRawToMgf, may do isobaric type ion removement automatically, check mgf file if you find ###RemoveIsobaricIon and you don't want to do it, download new version and regenerate mgf. Sorry for that.
- 2012/03/07 Version 3.2.0
 1. Bug fixed : TurboRawToMgf, throw exception when converting multiple raw files.
- 2012/03/07 Version 3.1.9
 1. New : Precursor offset calculator
 2. Enhanced : TurboRawToMgf, isobaric labeling, precursor/product ion shift by offset file.
- 2012/03/02 Version 3.1.8
 1. Enhanced : pNovoValidator, add statistic result
 2. Enhanced : TurboRawToMgf, add compatible with isobaric type ion removement.
- 2012/02/28 Version 3.1.7
 1. Bug fixed : BuildSummary, throw null reference exception when parsing mascot dat file.
- 2012/02/24 Version 3.1.6
 1. Enhanced : BuildSummary, the peptide-spectrum-match that contains multiple different pure sequences will be removed automatically.
- 2012/02/23 Version 3.1.5
 1. Enhanced : BuildSummary, can keep all spectra with same identified peptide but from different dataset by uncheck 'Merge result from same engine but different search parameters'.
 2. Enhanced : ProteinDistribution/PeptideDistribution compatible with BuildSummary result with same spectrum, multiple identification from different datasets, by check 'Classify by tag name'
- 2012/02/22 Version 3.1.4
 1. New : Score comparison builder, generate comparison table from two peptide files to be used in other tools.
 2. Enhanced : TurboRaw2MGF, can remove special mz range (for example, 113.5-117.5 for itraq plex 4)
- 2012/02/17 Version 3.1.3
 1. Enhanced : pNovoSapValidator, Export pNovo Sap Peptides.
 2. Enhanced : MascotSapValidator, Validate mascot result by pNovo peptides.
- 2012/02/15 Version 3.1.2
 1. Enhanced : TurboRaw2MGF, Can remove the ions whose mass is larger than the precursor ion.
- 2012/02/14 Version 3.1.1
 1. Bug fixed : BuildSummary, parsing mascot dat file error when 'Mr' was set as default precursor charge.
- 2012/02/13 Version 3.1.0
 1. New feature : Multiple MGF Precursor Correction Processor: correct precursor of mgf files based on identified peptides.
- 2012/02/13 Version 3.0.9
 1. Enhanced : TurboRaw2MGF, Can remove precursor and neutral loss peaks, deisotopic, deconvolution and keep top x ions.
 2. Bug fixed : MascotSapValidator, index out of range exception.
- 2012/02/07 Version 3.0.8
 1. Bug fixed : MascotSapValidator, null reference point error when doing Uniprot annotation.
- 2012/02/07 Version 3.0.7
 1. Enhanced : MaxQuant title parser in MiscOptions.xml
 2. Enhanced : PNovoSapValidator, can keep single nucleotide mutation only.
 3. Enhanced : MascotSapValidator, add new annotation informations such like amino acid modification, rna editing
- 2012/02/01 Version 3.0.6
 1. Enhanced : Reversed Database Builder - Add 'CON_' before contaminant sequence name.
 2. Enhanced : Convert Thermo MSF database to BuildSummary noredundant format.
- 2012/01/12 Version 3.0.5
 1. Enhanced : TMT Plex6 has been supported by isobaric label data analysis workflow.
- 2012/01/09 Version 3.0.4
 1. Enhanced : BuildSummary - Can build individual summary.
 2. New : TripleTOF Peak List Text To Mascot Generic Format Converter. 
- 2011/12/30 Version 3.0.3
 1. Enhanced : BuildSummary - Add minimum engine agreement criteria for the data searched by multiple engines.
- 2011/12/23 Version 3.0.2
 1. Enhanced : Implemented parallel mode for BuildSummary Mascot Dat Summary Builder, Multiple Raw To Mascot Generic Format, Multiple Raw To Dta.
- 2011/12/12 Version 3.0.1
 1. Bug fixed : Read peak list error using IXRawFile5 interface.
- 2011/12/03 Version 3.0.0
 1. Enhanced : SRM Distiller & SRM Validator.
- 2011/12/01 Version 2.9.9
 1. Enhanced : iTRAQ Quantification Result Viewer.
- 2011/12/01 Version 2.9.8
 1. Enhanced : pNovo Mascot Validator 2.0.3, can remove N-Terminal mutation and Deamidated mutation (N->D, Q->E).
- 2011/11/30 Version 2.9.7
 1. Bug fixed : iTRAQ protein/unique peptide quantification builder, quantify protein by median of peptide ratio didn't work.
- 2011/11/30 Version 2.9.6
 1. Bug fixed : pNovo SAP Validator 2.1.2, remove N-Terminal mutation didn't work.
- 2011/11/25 Version 2.9.5
 1. Enhanced : iTRAQ distiller, out of memory fixed.
- 2011/11/21 Version 2.9.4
 1. Enhanced : iTRAQ distiller.
 2. New feature : iTRAQ summary viewer.
- 2011/11/16 Version 2.9.3
 1. Bug fixed : Exception thrown of iTRAQ protein quantification builder.
- 2011/11/10 Version 2.9.2
 1. Multiple improvements on ITRAQ Quantification...
- 2011/10/10 Version 2.8.9
 1. Bug fixed : Normalization method of iTRAQ distiller when ion injection time used.
 2. New feature : MaxQuant APL format to Mascot Generic Format converter.
- 2011/09/29 Version 2.8.8
 1. Bug fixed : Extract fasta file from database based on access numbers 1.0.1
- 2011/09/28 Version 2.8.7
 1. New feacure : Extract fasta file from database based on access numbers 1.0.0
- 2011/09/22 Version 2.8.6
 1. Enhanced : Identified Peptide iTRAQ Statistic Builder 1.1.0
 2. Enhanced : Identified Protein iTRAQ Statistic Builder 1.1.0
- 2011/09/15 Version 2.8.5
 1. Bug fixed : iTRAQ Result Multiple File Distiller 1.2.4, reading new format iTRAQ result error.
 2. Bug fixed : iTRAQ Peptide Statistic Builder 1.0.1, matching between itraq information and identified peptide failed.
 3. Enhanced : Turbo Raw To MGF, including retention time in annotation.
- 2011/09/13 Version 2.8.4
 1. Enhanced : BuildSummary 6.1.0, added two new title formats to parse for mascot results, also support title format detection automatically.
- 2011/09/02 Version 2.8.3
 1. Enhanced : SRMValidator 1.2.0
- 2011/08/23 Version 2.8.2
 1. New feature : Identified protein iTRAQ statistic calculator.
- 2011/08/22 Version 2.8.1
 1. Enhanced : iTRAQ Result Multiple File Distiller, compatible with HCD data.
- 2011/08/19 Version 2.8.0
 1. Bug fixed : mascot SAP Validator, I/L will not be considered as mutation. 
- 2011/08/17 Version 2.7.9
 1. Enhanced : pNovo SAP Validator, bug fixed.
 2. Enhanced : mascot SAP Validator, compatible with K/R mutation. 
- 2011/08/10 Version 2.7.8
 1. Enhanced : pNovo SAP Validator, parallel version.
- 2011/07/20 Version 2.7.7
 1. Enhanced : pNovo SAP Validator, compatible with K/R mutation.
- 2011/07/15 Version 2.7.6
 1. Enhanced : SRMDistiller 1.2.0, SRMValidator 1.1.0
- 2011/06/22 Version 2.7.5
 1. Bug fixed: Protein Distribution Builder 1.0.1, can export unique peptide count and peptide count now.
- 2011/06/01 Version 2.7.4
 1. Enhanced: MRM Distiller
- 2011/05/31 Version 2.7.3
 1. Bug fixed: Mascot SAP Validator, result format error.
- 2011/05/31 Version 2.7.2
 1. New feature: Identified Spectrum Multiple Labelling Separator.
- 2011/05/30 Version 2.7.1
 1. Enhanced: Mascot SAP Validator 
- 2011/05/27 Version 2.7.0
 1. Enhanced: Mascot SAP Validator 
- 2011/05/26 Version 2.6.9
 1. Enhanced: Mascot SAP Validator, Spectrum SAP Validator. 
- 2011/05/25 Version 2.6.8
 1. New feature: Mascot SAP Validator. Validate pNovo-based database search result.
 2. New feature: Spectrum SAP Validator. Read peptides result from Mascot SAP Validator and visualize corresponding spectrum images for manual check.
- 2011/05/24 Version 2.6.7
 1. New feature: pNovo SAP Validator. Read pNovo (de novo, HCD) results and compare with protein sequence database, find full-digested, no miss-cleavage site, 
 2. one mutation site peptides. The peptides will be combined those peptides with protein sequence database for following database search validation.
- 2011/05/17 Version 2.6.6
 1. Bug fixed: BuildSummary : parsing error for result from SEQUEST version 28 rev 12.
- 2011/05/04 Version 2.6.5
 1. Bug fixed: BuildSummary : Cannot match identified protein ( with long access number(>30)) with the entry in database in some special cases.
- 2011/04/20 Version 2.6.4
 1. New feature: BuildSummary : Contamination filter by description (such like term 'Keratin', case insensitive)
 2. New feature: BuildSummary : If one spectrum is matched with both target and decoy entries, can consider this PSM as target entry or decoy entry (default is decoy entry)
- 2011/04/06 Version 2.6.3
 1. Bug fixed: MRM Distiller 1.1.4 for mzXml/mzData/Thermo Raw : base line calculation error.
 2. new: MaxQuantPeptideRatioDistiller : extract peptide and all experiment normalized ratio from maxquant peptide file.
- 2011/03/31 Version 2.6.2
 1. Bug fixed: MRM Distiller 1.1.3 for mzXml/mzData/Thermo Raw : correlation calculation error in privious version.
- 2011/03/31 Version 2.6.1
 1. Enhanced: MRM Distiller 1.1.2 for mzXml/mzData/Thermo Raw
 2. Enhanced: MRM Validator 1.1.2
- 2011/03/28 Version 2.6.0
 1. Enhanced: MaxQuant file distiller, improved speed for large data processing.
- 2011/03/21 Version 2.5.9
 1. New: BuildSummary Web Format Converter 1.0.0 : convert new format of buildsummary to old sequest format to compatible with web publishing.
- 2011/03/18 Version 2.5.8
 1. Enhanced : Agilent MRM Processor 1.1.1
 2. New : Target Peptide Distiller 1.0.0
- 2011/03/17 Version 2.5.7
 1. Enhanced : Agilent MRM Validator 1.1.1
- 2011/03/17 Version 2.5.6
 1. Enhanced : Agilent MRM Distiller 1.1.0, Agilent MRM Validator 1.1.0
- 2011/03/16 Version 2.5.5
 1. Enhanced : 'Agilent MRM Processor' was splited to 'Agilent MRM Distiller (1.0.9) and 'Agilent MRM Validator' (1.0.9)
- 2011/03/14 Version 2.5.4
 1. Enhanced : Agilent MRM Processor 1.0.8
- 2011/03/10 Version 2.5.3
 1. New : Extract Fasta From SwissProt Dat File 1.0.0
- 2011/03/06 Version 2.5.2
 1. New : Multiple Raw/mzData/mzXml to Mascot Generic Format Converter 1.0.0
- 2011/02/22 Version 2.5.1
 1. Bug fix: BuildSummary - MASCOT : Compatible with static iTRAQ modification on K with dynamic modification on KR.
- 2011/02/21 Version 2.5.0
 1. Bug fix: MaxQuant Sites to mascot peptide format converter.
- 2011/02/16 Version 2.4.9
 1. New : MaxQuant file distiller based on column map definitions.
- 2011/02/14 Version 2.4.8
 1. Enhanced : BuildSummary - Uniform summary builder : Compatible with peptideprophet.
- 2011/01/26 Version 2.4.7
 1. Enhanced : BuildSummary from peptides file, compatible with new format of buildsummary.
 2.   
- 2011/01/13 Version 2.4.6
 1. Enhanced : Extract maxquant msm files to single mgf file. (For drawing spectrum image by RcpaBioSolution).
- 2010/12/28 Version 2.4.5
 1. New : Label free quantification builder (based on spectra count).
- 2010/12/28 Version 2.4.4
 1. Enhanced : SILAC Quantification Viewer : calculate protein ratio based on scan level.
- 2010/12/10 Version 2.4.3
 1. New : Extended SILAC Quantification Calculator : quantify protein based on dataset definition and raw pair definition.
 2. New : Extract protein only distiller
- 2010/12/07 Version 2.4.2
 1. Enhanced : Protein/Peptide Distribution Calculator : Can collapse individual node (reset will collapse all nodes).
 2. Enhanced : Access number parser add new ipi definition.
- 2010/12/03 Version 2.4.1
 1. Enhanced : SilacQuantificationSummaryViewer : Can export individual scan information at final result.
- 2010/11/02 Version 2.4.0
 1. Enhanced : BuildSummary - Uniform summary builder : Compatible with old version of search engine pFind.
 2. Bugfix : BuildSummary - Mascot : compatible with old version of mascot, fixed a bug introduced by version 2.3.9.
- 2010/11/01 Version 2.3.9
 1. Enhanced : BuildSummary - Uniform summary builder : Compatible with search engine pFind.
- 2010/10/28 Version 2.3.8
 1. Bugfix : BuildSummary - Uniform summary builder : Error when writing temp file at driver e.
- 2010/10/09 Version 2.3.7
 1. Bugfix : O18Quantification - Index out of bound.
 2. Enhanced : O18Quantification - Additional graph illustrates the linear regression result of protein based on all scan informations.
- 2010/10/08 Version 2.3.6
 1. Enhanced : O18Quantification - Improved individual scan information at exported summary file.
 2. Enhanced : BuildSummary - Uniform summary builder : Can filter high-resolution result with mono/second/third isotopic peak of precursor ion.
- 2010/09/25 Version 2.3.5
 1. Enhanced : O18Quantification - Can export individual scan information at final result.
 2. Enhanced : BuildSummary - Uniform summary builder : Can filter high-resolution result with second isotopic peak of precursor ion.
- 2010/08/18 Version 2.3.4
 1. Enhanced : Mgf2DtaProcessor - Add option to extract file to individual directory.
- 2010/08/17 Version 2.3.3
 1. New : Add Extract Protein By Access Number Processor : read noredundant file and extract corresponding protein group based on access number file.
 2. Enhanced : BuildSummary - Uniform summary builder for SEQUEST/MASCOT/XTandem search result. Protein fdr supported.
- 2010/07/20 Version 2.3.2
 1. New : Add Score Distribution Builder : read peptides file and build score distribution based on charge/misscleavage/modification and target/decoy entries.
- 2010/07/05 Version 2.3.1
 1. Enhanced : SEQUEST BuildSummary : Support zip compressed dtas/outs files or dta/out directory.
 2. Enhanced : Identified iTRAQ Statistic Builder : Improved speed for large iTRAQ data. 
- 2010/06/29 Version 2.3.0
 1. Bug fixed : SEQUEST BuildSummary : protein sequence cannot be found when protein name contains '/'.
- 2010/06/29 Version 2.2.9
 1. Bug fixed : Exception when buildsummary : cannot compare two items.
- 2010/06/23 Version 2.2.8
 1. Enhanced : Can define profile length used in SILAC quantification.
- 2010/06/17 Version 2.2.7
 1. Enhanced : Compatible with TurboSEQUEST v.28 (rev. 13).
- 2010/06/11 Version 2.2.6
 1. Enhanced : Convert MSF File To BuildSummary Result File : can convert the text format of MSF (Excel->Text).
- 2010/06/11 Version 2.2.5
 1. New : Thermo Protein Discover MSF Excel File to BuildSummary Converter.
- 2010/06/03 Version 2.2.4
 1. Bugfix : Exception thrown when loading old buildsummary parameter file.
 2. New : BuildSummary - Uniform summary builder for SEQUEST/MASCOT/XTandem search result. But, protein fdr is not supported now. :-(
- 2010/05/31 Version 2.2.3
 1. New : Peptide Distribution Builder : As same function as RcpaBioSolution.
- 2010/05/10 Version 2.2.2
 1. New : Add MaxQuant MGF File Distiller : Extract peptides and MGF file based on identification result and MaxQuant MSM file. Those result files can be used to generate spectrum images using RcpaBioSolution.
- 2010/05/07 Version 2.2.1
 1. Enhanced : Reversed database builder : option to switch protease termini with previous/next aminoacid.
 2. Bugfix : iTRAQ result multiple file distiller : limit each peak with minimum intensity 0.1.
- 2010/05/07 Version 2.2.0
 1. Bugfix : iTRAQ result multiple file distiller : exception thrown when parsing small data.
- 2010/05/06 Version 2.1.9
 1. Bugfix : iTRAQ result multiple file distiller : exception thrown when parsing CID only data.
 2. New : pFind result summary builder (beta version).
- 2010/04/26 Version 2.1.8
 1. Enhanced : BuildSummary - SEQUEST : Parse matched ion count from out file.
- 2010/04/21 Version 2.1.7
 1. Bug fixed : Exception thrown when Mascot Html Result Downloader starts.
- 2010/04/15 Version 2.1.6
 1. Enhanced : O18/SILAC Quantification Processor. At least 5 full ms will be used in each peptide quantification.
- 2010/04/09 Version 2.1.5
 1. Enhanced : O18/SILAC Quantification Summary Viewer. Add all peptides linear regression result view.
- 2010/04/02 Version 2.1.4
 1. Enhanced : O18/SILAC Quantification Summary Viewer. Export result will includes all protein/peptide columns.
- 2010/04/01 Version 2.1.3
 1. Enhanced : O18/SILAC Quantification Summary Viewer. Add confidence presentation at protein and peptide level.
- 2010/03/30 Version 2.1.2
 1. Bugfix : O18 Quantification Summary Viewer.
- 2010/03/28 Version 2.1.1
 1. Enhanced : O18 Quantification Summary Viewer.
- 2010/03/18 Version 2.1.0
 1. Bugfix : O18 Quantification Summary Viewer couldn't save/export result.
 2. Enhanced : Add SEQUEST access number parser for BuildSummary.
- 2010/01/22 Version 2.0.9
 1. New : Add unique peptide distiller for protein file. It's used to remove redundant peptide identification for building spectrum/peptide image.
- 2010/01/13 Version 2.0.8
 1. Enhanced : Update tools for small molecule data analysis from ESI-TOF/Q-TOF full mass scan result.
- 2010/01/12 Version 2.0.7
 1. Enhanced : Update tools for small molecule data analysis from ESI-TOF/Q-TOF full mass scan result.
- 2010/01/05 Version 2.0.6
 1. Enhanced : SILAC quantification processor is compatible with dynamic modificaition result from mascot.
 2. New: A few tools for small molecule data analysis from ESI-TOF/Q-TOF full mass scan result.
- 2009/12/14 Version 2.0.5
 1. Enhanced : Extract dta/out from dtas/outs files : add new information when dtas/outs file missed.
- 2009/12/14 Version 2.0.4
 1. Bugfix : ITraqResultMultipleFileDistiller : compatible with QTOF mzData.xml result;
- 2009/12/08 Version 2.0.3
 1. Bugfix : Census result merger. Error export 'AREA_RATIO' and 'PROFILE_SCORE' as '0:0.00';
- 2009/12/07 Version 2.0.2
 1. Enhanced : Export area information for Agilent MRM Viewer. 
- 2009/12/07 Version 2.0.1
 1. Enhanced : Add minmum peptide seqneuce length filter for sequest/mascot/x!tandem summary builder. 
- 2009/12/01 Version 2.0.0
 1. Enhanced : Silac Relative Quantification Summary Viewer. Add export function : a protein file and a peptide file will be exported. 
- 2009/11/25 Version 1.9.9
 1. Enhanced : Silac Relative Quantification Calculator. Validate SILAC configuration file in quantification.
- 2009/11/23 Version 1.9.8
 1. Enhanced : Using MSFileReader library (not XCalibur) to read the thermo raw file.
 2. Bug fix : Agilent MRM result distiller. Exception will be thrown when light and heavy product ion were not crosslinked.
- 2009/11/20 Version 1.9.7
 1. Enhanced feature : Census result merger compatible with Census 1.57.
- 2009/11/20 Version 1.9.6
 1. Enhanced feature : Correct itraq result based on 'Isotope Impurity Correction Table'.
- 2009/11/17 Version 1.9.5
 1. New feature : MSn Total Ion Count Distiller.
- 2009/11/16 Version 1.9.4
 1. Bug fixed : Agilent MRM result distiller.Compatible with the file whose scan contains multiple production ions.
- 2009/11/06 Version 1.9.3
 1. Enhanced : Agilent MRM result distiller.
- 2009/11/06 Version 1.9.2
 1. New feature : Extract MS1 file from Agilent '*.d' directory.
 2. New feature : Agilent MRM result previewer beta version.
- 2009/10/28 Version 1.9.1
 1. Bug fix : iTRAQ multiple file distiller - Supporting minmum itraq peak count of scan.
 2. New feature : Agilent '*.d' directory previewer.
- 2009/10/26 Version 1.9.0
 1. Enhanced : iTRAQ multiple file distiller - Supporting minmum itraq peak count of scan.
- 2009/10/15 Version 1.8.9
 1. New : MaxQuant Sites To Mascot Peptide Converter - Transfer the PTM peptide file of maxquant to buildsummary format which can be used to generate 
 2. peptide-spectrum-match images only.
- 2009/08/18 Version 1.8.8
 1. Bug fix : BuildSummary Suite - No peptides will pass the creteria with contaminant filter in previouse version.
- 2009/08/12 Version 1.8.7
 1. Enhanced : BuildSummary Suite - Add contaminant filter. The filter will remove contaminant proteins before FDR calculation / grouping proteins.
- 2009/08/03 Version 1.8.6
 1. New : Liqid Quantification - Find corresponding precursor ion based on product ion and quantify the precursor ion.
- 2009/07/21 Version 1.8.5
 1. New : iTRAQ Modified Peptide Rsd Filter
 2. Enhanced : Turbo Census MS1 Builder - Compatible with new Census version.
- 2009/07/13 Version 1.8.4 beta1
 1. Enhanced : IPI parsing definition in MiscOptions.xml.
- 2009/07/10 Version 1.8.3 beta3
 1. Bugfix : Dtaselect File Splitter - Error when reading dtaselect file.
- 2009/07/08 Version 1.8.3 beta2
 1. Enhanced : Summary Builder - Compatible to large dataset (more than 500 raw files), testing now!
- 2009/07/01 Version 1.8.3 beta
 1. Enhanced : iTRAQ Result Multiple File Distiller - Assign the iTRAQ information of CID spectrum from previous PQD spectrum.
 2. Enhanced : Identified Peptide Phosphorylation Ratio Builder - Only the iTRAQ with all corresponding phosphorylation peaks (such like both 116 and 117 exist) will be used.
- 2009/06/30 Version 1.8.2
 1. Bugfix : Census Result Merger for Chro File Splitter - Missed the first protein group in each file.
- 2009/06/29 Version 1.8.1
 1. New : Census Result Merger for Chro File Splitter - Compatible with new census version.
- 2009/06/29 Version 1.8.0
 1. Enhanced : Census Chro File Splitter - Compatible with new census version.
- 2009/06/29 Version 1.7.9
 1. Enhanced : iTRAQ Result Multiple File Distiller - Extract almost all itraq information from raw file.Previous version will extract the itraq information from the scan which contains at least three iTRAQ peaks.
- 2009/06/26 Version 1.7.8
 1. Enhanced : Add new database definition for swissprot which will be used in BuildSummary. 
 2. Bugfix : Minimum Ion Intensity filter doesn't work in TurboRaw2Mgf/TurboRaw2Dta.
- 2009/06/16 Version 1.7.7
 1. New feature : Identified Peptide Phosphorylation Ratio Builder
- 2009/06/13 Version 1.7.6
 1. Enhanced : SILAC Quantification Tools. Using precursor similarity tolerance to get correct elution window of the ion.
- 2009/06/12 Version 1.7.5
 1. Bug fix : BuildSummary Suite - generate empty result when using protein fdr.
 2. New feature : distribution builder for sequest/mascot/xtandem result
- 2009/06/05 Version 1.7.4
 1. New feature : Ambigious Modified Peptide Remover - remove ambigious modified peptides, and keep the top score spectrum only for different peptide sequence and charge.
- 2009/05/25 Version 1.7.3
 1. New feature : ValidatedPeptideDistiller - extract validated peptides based on spectra images.
 2. Enhanced : Identified Peptides ITraq Calculator, calculating mean/stand_deviation for log(ratio) insteed of ratio.
 3. Bug fix : Exception thrown when reading old configuration file from SequestSummaryBuilder/MascotSummaryBuilder/XTandemSummaryBuilder
- 2009/05/15 Version 1.7.2
 1. Enhanced : Identified Peptides ITraq Calculator, add header for result file
 2. Adjusted : File list format saved by summary builders.
- 2009/05/13 Version 1.7.1
 1. Enhanced : Identified Peptides ITraq Calculator, group the result by peptide sequence
- 2009/05/12 Version 1.7.0
 1. Enhanced : One2All supports the directory list file generated by buildsummary.
- 2009/05/11 Version 1.6.9
 1. New feature : Multiple itraq result distiller - extract itraq information from multiple raw files and save to one file.
 2. New feature : identified result itraq statistic calculator - extract itraq information based on identified peptide file and calculate mean/sigma.
 3. Enhanced : Add new title definition for mzData generated by agilent which is used to parse mascot dat file.
- 2009/05/04 Version 1.6.8
 1. Bug fix : Unique Peptide Distiller - missed the peptide which is unique already.
- 2009/05/04 Version 1.6.7
 1. New feature : Unique Peptide Distiller - For peptides with same sequence and charge, keep the one with highest score only.
- 2009/05/03 Version 1.6.6
 1. New feature : Identified ITraq Statistic Builder - calculate mean and sigma of 115/114, 116/114, 117/114 based on identified peptides.
 2. Bug fix : TurboRaw2Mgf generate only one spectrum in mgf file.
- 2009/04/29 Version 1.6.5
 1. Bug fix : CensusResultMerger compatible to file with singleton score (label data).
 2. Bug fix : TurboRaw2Mgf throw exception when processing raw file with profile mode.
- 2009/04/27 Version 1.6.4
 1. Bug fix : CensusChroFileSplitter generates empty files.
- 2009/04/27 Version 1.6.3
 1. Bug fix : BuildSummary will throw exception using previous 1.6.2 version.
- 2009/04/27 Version 1.6.2
 1. New feature : Simple protein group builder - keep only one protein in each protein group and generate unduplicated file.
- 2009/04/24 Version 1.6.1
 1. New feature : Labeled result distiller - which will extract labeled peptides and corresponding protein group from noredundant file.
 2. Enhanced: MiscOptions.xml updated to compatible with MascotGenericFormat file generated by MaxQuant
- 2009/04/20 Version 1.6.0
 1. New feature : ExtractDistinctResultProcessor - which will extract distinct peptide and corresponding group from noredundant file.
- 2009/04/10 Version 1.5.9
 1. New feature : ITraqFilePreview - which will extract all possible ITraq information from thermo raw file.
 2. Enhanced : Census result merger is compatible to label free data and can be used at peptide level.
- 2009/03/30 Version 1.5.8
 1. New feature : BuildSummary - XTandem XML Summary Builder 1.0.0
- 2009/03/27 Version 1.5.7
 1. Enhanced : silac result viewer, supporting save/export the result after manual checking.
- 2009/03/24 Version 1.5.6
 1. New feature : add silac quantification processor.
 2. Enhanced : silac result viewer.
 3. Enhanced : BuildSummary (both SEQUEST and MASCOT version), add database access number parser definition (MiscOptions.xml should be put in execute directory).
- 2009/03/21 Version 1.5.5
 1. New feature : add silac result viewer(silac processor will be available at next version)
- 2009/02/26 Version 1.5.4
 1. New feature : add access number parser definition for mascot dat summary builder.
- 2009/02/26 Version 1.5.3
 1. New feature : substract peptides files, used to compare the results from different search conditions for same dataset.
- 2009/02/25 Version 1.5.2
 1. New feature : extract peptides from protein file (more effective than the one in RcpaBioSolution).
- 2009/02/23 Version 1.5.1
 1. BuildSummary - SEQUEST Summary Builder 5.0.8
 2. BuildSummary - Mascot Dat Summary Builder 1.0.9
 3. Bug fix : The bug when filtering unique 1 protein using Protein FDR function. Correct the statistic information in optimal file with final result.
- 2009/02/20 Version 1.5.0
 1. Bug fix : Correct the statistic information in optimal file with final result.
- 2009/02/20 Version 1.4.9
 1. Bug fix : Sometimes, program will be terminated when adding directories using 'add subdirs' button. (BuildSummary - SEQUEST Summary Builder).
- 2009/02/19 Version 1.4.8
 1. Bug fix : Exception thrown when parsing dta/out filename with more than 10+ charge. (BuildSummary - SEQUEST Summary Builder).
- 2009/02/19 Version 1.4.7
 1. Bug fix : Program terminated when adding too many directories into BuildSummary - SEQUEST Summary Builder out/outs directory list.
- 2009/02/13 Version 1.4.6
 1. Bug fix : K0R0/K4R6/K8R10 separator doesn't work in previous version.
- 2009/02/13 Version 1.4.5
 1. New feature : Separator identified result based on modification. Can be used to separate large file. There are two modes:
  - Input modified aminoacids, separate identified result to MODIFIED and UNMODIFIED result.
  - Input modified aminoacid pattern, separate identified result to multiple result. (Designed for K0R0/K4R6/K8R10 labelling, can also be used for other type data)
- 2009/02/10 Version 1.4.4
 1. Enhanced : SEQUEST/MASCOT Summary Builder : Compatible to large dataset. (Passed the test on more than 240 raw files)
- 2009/02/09 Version 1.4.3
 1. Bug Fix : SEQUEST/MASCOT Summary Builder : The QValues of spectra with same score in previous version were related to the rank, now fixed.
- 2009/02/05 Version 1.4.2
 1. Enhanced Tool - MascotResult Dat Summary Builder:
  - Allow for building summary based on assigned protein fdr.
  - Allow for classify dat files before building summary.
 2. New Tool - SEQUEST Summary Builder : similar to standalone version (BuildSummary)
- 2009/01/04 Version 1.4.1
 1. Bug Fix: MascotResult Dat Summary Builder : Error infomation - Error when parsing modification from mascot searching result
- 2008/12/15 Version 1.4.0
 1. New feature - Turbo Mascot Generic Format Precursor Shift 10Da Processor
- 2008/12/15 Version 1.3.9
 1. Enhanced Tool - MascotResult Dat Summary Builder:
  - Support loading/saving dat file list
  - Support loading/saving parameter file
  - Support parsing source mgf/mzData file names from dat files which makes it easy to choose correct dat files
  - Ask for directory to store result data like BuildSummary does  
- 2008/12/12 Version 1.3.8
 1. Bug Fix: MascotResult Dat Summary Builder : Error infomation - Parsing error for mascot searching result without modification
- 2008/12/11 Version 1.3.7
 1. New feature: A tool used to add additional 10da to precursorMz in mascot generic format file
- 2008/12/11 Version 1.3.6
 1. New feature: MascotResult Dat Summary Builder supports filtering by score and/or expect value now.
- 2008/12/11 Version 1.3.5
 1. Bug fix: After generating dtaselect file using 'identified result to dtaselect converter', some peptides containing two or more peptide sequences are not quantifiable using Census. Now only one peptide will be kept in final entry when converting from noredundant file to dtaselect file
 2. New feature: split dtaselect format file into small files.
 3. New feature: build ms1 file (including index file) from raw file.
- 2008/12/04 Version 1.3.4
 1. New feature: Extract MS2/MS3 from raw file to different directories.
 2. Bug fixed: Census result merger is compatible to new format.
- 2008/12/03 Version 1.3.3
 1. New feature: Convert identified result(noredundant file) to dtaselect. It is compatible with both sequest and mascot result.
- 2008/11/10
 1. Fixed : error when parsing modification of mascot dat file
