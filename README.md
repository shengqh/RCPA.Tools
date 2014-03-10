ProteomicsTools Software Suite
==========
IMPORTANT : MSFileReader library can be downloaded from : http://sjsupport.thermofinnigan.com/public/detail.asp?id=703
IMPORTANT : .NET Platform 4.0 is needed since Version 2.9.2: http://www.microsoft.com/download/en/details.aspx?displaylang=en&id=17718
Citation: Sheng, Q., et al. (2012) BuildSummary: using a group-based approach to improve the sensitivity of peptide/protein identification in shotgun proteomics, J. Proteome Res., 11, 1494-1502.

2014/02/28 Version 3.4.9
Enhanced: O18 quantification summary viewer.

2014/02/04 Version 3.4.8
Enhanced: O18 quantification summary viewer.

2014/01/15 Version 3.4.7
Enhanced: SILAC quantification summary viewer.

2014/01/08 Version 3.4.6
Enhanced: SILAC quantification summary viewer.

2014/01/07 Version 3.4.5
Enhanced: O18 quantification summary viewer.

2013/01/02 Version 3.4.3
Enhanced: SILAC/O18 quantification summary viewer.

2013/01/02 Version 3.3.9
Enhanced: Compatible with some thermo raw file with bad scan which cannot be read out. A xxx.baddatascan will be generated once such scans are found and those scans will be ignored in some tools, currently in SILAC quantification tools.

2012/12/20 Version 3.3.8
Enhanced: BuildSummary, compatible with protein whose reference contains character '\t' or '/'.
Bug fixed: SILAC Protein Quantification Builder, emass calculator initialized.

2012/12/19 Version 3.3.7
Enhanced: BuildSummary, mascot dat parser compatible with protein whose name contains character '/'.

2012/12/17 Version 3.3.6
Enhanced: Isobaric Labelling Protein Quantification

2012/06/13 Version 3.3.5
New feature:Identified Peptide Chromatograph Extractor & Viewer

2012/06/06 Version 3.3.4
Bug fixed: MSF To BuildSummary, key not found error.
Enhanced: Isobaric Labelling Multiple File Distiller, compatible with the raw file contains wrong isolation window information.  

2012/05/25 Version 3.3.3
New feature: Replace Precursor Information Processor

2012/05/10 Version 3.3.2
Enhanced: Identified Unique Peptide iTRAQ Statistic Builder : get protein information from database.
New feature: Isobaric Labeling Efficiency Calculator

2012/05/07 Version 3.3.1
Bug fixed: MaxQuant Evidence To Peptide Converter : compatible with non-labelling data.

2012/05/04 Version 3.3.0
Bug fixed: BuildSummary for XTandem.

2012/05/03 Version 3.2.9
Enhanced : TurboRawToMGF, compatible with LysC protease with Isobaric Ion Deduction.
New feature: MaxQuant Evidence To Peptide Converter.

2012/04/19 Version 3.2.8
Enhanced : Access number parser updated for MaxQuant format of NCBI database.

2012/04/12 Version 3.2.7
Bug fixed : The same transitions in different files will be wrong classified as different transitions in SRMValidator which introduced in latest update.

2012/04/11 Version 3.2.6
Enhanced : BuildSummary 7.0.0, default filter for one-hit-wonder will ask for at least two peptide-spectrum-matches.

2012/04/10 Version 3.2.5
Enhanced : SRMBuilder, can process the transition from same peptide but different charge.

2012/04/01 Version 3.2.4
Enhanced : TurboRawToMgf, can remove isobaric ions at low and/or high mass range.
Enhanced : Isobaric Labelling Multiple File Distiller, for "out of memory exception".

2012/03/23 Version 3.2.3
Enhanced : Interface adjustment.

2012/03/19 Version 3.2.2
New feature : Combination of mutation and quantification builder, for SAP.

2012/03/16 Version 3.2.1
Bug fixed : TurboRawToMgf, may do isobaric type ion removement automatically, check mgf file if you find ###RemoveIsobaricIon and you don't want to do it, download new version and regenerate mgf. Sorry for that.

2012/03/07 Version 3.2.0
Bug fixed : TurboRawToMgf, throw exception when converting multiple raw files.

2012/03/07 Version 3.1.9
New : Precursor offset calculator
Enhanced : TurboRawToMgf, isobaric labeling, precursor/product ion shift by offset file.

2012/03/02 Version 3.1.8
Enhanced : pNovoValidator, add statistic result
Enhanced : TurboRawToMgf, add compatible with isobaric type ion removement.

2012/02/28 Version 3.1.7
Bug fixed : BuildSummary, throw null reference exception when parsing mascot dat file.

2012/02/24 Version 3.1.6
Enhanced : BuildSummary, the peptide-spectrum-match that contains multiple different pure sequences will be removed automatically.

2012/02/23 Version 3.1.5
Enhanced : BuildSummary, can keep all spectra with same identified peptide but from different dataset by uncheck "Merge result from same engine but different search parameters".
Enhanced : ProteinDistribution/PeptideDistribution compatible with BuildSummary result with same spectrum, multiple identification from different datasets, by check "Classify by tag name"

2012/02/22 Version 3.1.4
New : Score comparison builder, generate comparison table from two peptide files to be used in other tools.
Enhanced : TurboRaw2MGF, can remove special mz range (for example, 113.5-117.5 for itraq plex 4)

2012/02/17 Version 3.1.3
Enhanced : pNovoSapValidator, Export pNovo Sap Peptides.
Enhanced : MascotSapValidator, Validate mascot result by pNovo peptides.

2012/02/15 Version 3.1.2
Enhanced : TurboRaw2MGF, Can remove the ions whose mass is larger than the precursor ion.

2012/02/14 Version 3.1.1
Bug fixed : BuildSummary, parsing mascot dat file error when "Mr" was set as default precursor charge.

2012/02/13 Version 3.1.0
New feature : Multiple MGF Precursor Correction Processor: correct precursor of mgf files based on identified peptides.

2012/02/13 Version 3.0.9
Enhanced : TurboRaw2MGF, Can remove precursor and neutral loss peaks, deisotopic, deconvolution and keep top x ions.
Bug fixed : MascotSapValidator, index out of range exception.

2012/02/07 Version 3.0.8
Bug fixed : MascotSapValidator, null reference point error when doing Uniprot annotation.

2012/02/07 Version 3.0.7
Enhanced : MaxQuant title parser in MiscOptions.xml
Enhanced : PNovoSapValidator, can keep single nucleotide mutation only.
Enhanced : MascotSapValidator, add new annotation informations such like amino acid modification, rna editing

2012/02/01 Version 3.0.6
Enhanced : Reversed Database Builder - Add "CON_" before contaminant sequence name.
Enhanced : Convert Thermo MSF database to BuildSummary noredundant format.

2012/01/12 Version 3.0.5
Enhanced : TMT Plex6 has been supported by isobaric label data analysis workflow.

2012/01/09 Version 3.0.4
Enhanced : BuildSummary - Can build individual summary.
New : TripleTOF Peak List Text To Mascot Generic Format Converter. 

2011/12/30 Version 3.0.3
Enhanced : BuildSummary - Add minimum engine agreement criteria for the data searched by multiple engines.

2011/12/23 Version 3.0.2
Enhanced : Implemented parallel mode for BuildSummary Mascot Dat Summary Builder, Multiple Raw To Mascot Generic Format, Multiple Raw To Dta.

2011/12/12 Version 3.0.1
Bug fixed : Read peak list error using IXRawFile5 interface.

2011/12/03 Version 3.0.0
Enhanced : SRM Distiller & SRM Validator.

2011/12/01 Version 2.9.9
Enhanced : iTRAQ Quantification Result Viewer.

2011/12/01 Version 2.9.8
Enhanced : pNovo Mascot Validator 2.0.3, can remove N-Terminal mutation and Deamidated mutation (N->D, Q->E).

2011/11/30 Version 2.9.7
Bug fixed : iTRAQ protein/unique peptide quantification builder, quantify protein by median of peptide ratio didn't work.

2011/11/30 Version 2.9.6
Bug fixed : pNovo SAP Validator 2.1.2, remove N-Terminal mutation didn't work.

2011/11/25 Version 2.9.5
Enhanced : iTRAQ distiller, out of memory fixed.

2011/11/21 Version 2.9.4
Enhanced : iTRAQ distiller.
New feature : iTRAQ summary viewer.

2011/11/16 Version 2.9.3
Bug fixed : Exception thrown of iTRAQ protein quantification builder.

2011/11/10 Version 2.9.2
Multiple improvements on ITRAQ Quantification...

2011/10/10 Version 2.8.9
Bug fixed : Normalization method of iTRAQ distiller when ion injection time used.
New feature : MaxQuant APL format to Mascot Generic Format converter.

2011/09/29 Version 2.8.8
Bug fixed : Extract fasta file from database based on access numbers 1.0.1

2011/09/28 Version 2.8.7
New feacure : Extract fasta file from database based on access numbers 1.0.0

2011/09/22 Version 2.8.6
Enhanced : Identified Peptide iTRAQ Statistic Builder 1.1.0
Enhanced : Identified Protein iTRAQ Statistic Builder 1.1.0

2011/09/15 Version 2.8.5
Bug fixed : iTRAQ Result Multiple File Distiller 1.2.4, reading new format iTRAQ result error.
Bug fixed : iTRAQ Peptide Statistic Builder 1.0.1, matching between itraq information and identified peptide failed.
Enhanced : Turbo Raw To MGF, including retention time in annotation.

2011/09/13 Version 2.8.4
Enhanced : BuildSummary 6.1.0, added two new title formats to parse for mascot results, also support title format detection automatically.

2011/09/02 Version 2.8.3
Enhanced : SRMValidator 1.2.0

2011/08/23 Version 2.8.2
New feature : Identified protein iTRAQ statistic calculator.

2011/08/22 Version 2.8.1
Enhanced : iTRAQ Result Multiple File Distiller, compatible with HCD data.

2011/08/19 Version 2.8.0
Bug fixed : mascot SAP Validator, I/L will not be considered as mutation. 

2011/08/17 Version 2.7.9
Enhanced : pNovo SAP Validator, bug fixed.
Enhanced : mascot SAP Validator, compatible with K/R mutation. 

2011/08/10 Version 2.7.8
Enhanced : pNovo SAP Validator, parallel version.

2011/07/20 Version 2.7.7
Enhanced : pNovo SAP Validator, compatible with K/R mutation.

2011/07/15 Version 2.7.6
Enhanced : SRMDistiller 1.2.0, SRMValidator 1.1.0

2011/06/22 Version 2.7.5
Bug fixed: Protein Distribution Builder 1.0.1, can export unique peptide count and peptide count now.

2011/06/01 Version 2.7.4
Enhanced: MRM Distiller

2011/05/31 Version 2.7.3
Bug fixed: Mascot SAP Validator, result format error.

2011/05/31 Version 2.7.2
New feature: Identified Spectrum Multiple Labelling Separator.

2011/05/30 Version 2.7.1
Enhanced: Mascot SAP Validator 

2011/05/27 Version 2.7.0
Enhanced: Mascot SAP Validator 

2011/05/26 Version 2.6.9
Enhanced: Mascot SAP Validator, Spectrum SAP Validator. 

2011/05/25 Version 2.6.8
New feature: Mascot SAP Validator. Validate pNovo-based database search result.
New feature: Spectrum SAP Validator. Read peptides result from Mascot SAP Validator and visualize corresponding spectrum images for manual check.

2011/05/24 Version 2.6.7
New feature: pNovo SAP Validator. Read pNovo (de novo, HCD) results and compare with protein sequence database, find full-digested, no miss-cleavage site, 
one mutation site peptides. The peptides will be combined those peptides with protein sequence database for following database search validation.

2011/05/17 Version 2.6.6
Bug fixed: BuildSummary : parsing error for result from SEQUEST version 28 rev 12.

2011/05/04 Version 2.6.5
Bug fixed: BuildSummary : Cannot match identified protein ( with long access number(>30)) with the entry in database in some special cases.

2011/04/20 Version 2.6.4
New feature: BuildSummary : Contamination filter by description (such like term "Keratin", case insensitive)
New feature: BuildSummary : If one spectrum is matched with both target and decoy entries, can consider this PSM as target entry or decoy entry (default is decoy entry)

2011/04/06 Version 2.6.3
Bug fixed: MRM Distiller 1.1.4 for mzXml/mzData/Thermo Raw : base line calculation error.
new: MaxQuantPeptideRatioDistiller : extract peptide and all experiment normalized ratio from maxquant peptide file.

2011/03/31 Version 2.6.2
Bug fixed: MRM Distiller 1.1.3 for mzXml/mzData/Thermo Raw : correlation calculation error in privious version.

2011/03/31 Version 2.6.1
Enhanced: MRM Distiller 1.1.2 for mzXml/mzData/Thermo Raw
Enhanced: MRM Validator 1.1.2

2011/03/28 Version 2.6.0
Enhanced: MaxQuant file distiller, improved speed for large data processing.

2011/03/21 Version 2.5.9
New: BuildSummary Web Format Converter 1.0.0 : convert new format of buildsummary to old sequest format to compatible with web publishing.

2011/03/18 Version 2.5.8
Enhanced : Agilent MRM Processor 1.1.1
New : Target Peptide Distiller 1.0.0

2011/03/17 Version 2.5.7
Enhanced : Agilent MRM Validator 1.1.1

2011/03/17 Version 2.5.6
Enhanced : Agilent MRM Distiller 1.1.0, Agilent MRM Validator 1.1.0

2011/03/16 Version 2.5.5
Enhanced : "Agilent MRM Processor" was splited to "Agilent MRM Distiller" (1.0.9) and "Agilent MRM Validator" (1.0.9)

2011/03/14 Version 2.5.4
Enhanced : Agilent MRM Processor 1.0.8

2011/03/10 Version 2.5.3
New : Extract Fasta From SwissProt Dat File 1.0.0

2011/03/06 Version 2.5.2
New : Multiple Raw/mzData/mzXml to Mascot Generic Format Converter 1.0.0

2011/02/22 Version 2.5.1
Bug fix: BuildSummary - MASCOT : Compatible with static iTRAQ modification on K with dynamic modification on KR.

2011/02/21 Version 2.5.0
Bug fix: MaxQuant Sites to mascot peptide format converter.

2011/02/16 Version 2.4.9
New : MaxQuant file distiller based on column map definitions.

2011/02/14 Version 2.4.8
Enhanced : BuildSummary - Uniform summary builder : Compatible with peptideprophet.

2011/01/26 Version 2.4.7
Enhanced : BuildSummary from peptides file, compatible with new format of buildsummary.
  
2011/01/13 Version 2.4.6
Enhanced : Extract maxquant msm files to single mgf file. (For drawing spectrum image by RcpaBioSolution).

2010/12/28 Version 2.4.5
New : Label free quantification builder (based on spectra count).

2010/12/28 Version 2.4.4
Enhanced : SILAC Quantification Viewer : calculate protein ratio based on scan level.

2010/12/10 Version 2.4.3
New : Extended SILAC Quantification Calculator : quantify protein based on dataset definition and raw pair definition.
New : Extract protein only distiller

2010/12/07 Version 2.4.2
Enhanced : Protein/Peptide Distribution Calculator : Can collapse individual node (reset will collapse all nodes).
Enhanced : Access number parser add new ipi definition.

2010/12/03 Version 2.4.1
Enhanced : SilacQuantificationSummaryViewer : Can export individual scan information at final result.

2010/11/02 Version 2.4.0
Enhanced : BuildSummary - Uniform summary builder : Compatible with old version of search engine pFind.
Bugfix : BuildSummary - Mascot : compatible with old version of mascot, fixed a bug introduced by version 2.3.9.

2010/11/01 Version 2.3.9
Enhanced : BuildSummary - Uniform summary builder : Compatible with search engine pFind.

2010/10/28 Version 2.3.8
Bugfix : BuildSummary - Uniform summary builder : Error when writing temp file at driver e.

2010/10/09 Version 2.3.7
Bugfix : O18Quantification - Index out of bound.
Enhanced : O18Quantification - Additional graph illustrates the linear regression result of protein based on all scan informations.

2010/10/08 Version 2.3.6
Enhanced : O18Quantification - Improved individual scan information at exported summary file.
Enhanced : BuildSummary - Uniform summary builder : Can filter high-resolution result with mono/second/third isotopic peak of precursor ion.

2010/09/25 Version 2.3.5
Enhanced : O18Quantification - Can export individual scan information at final result.
Enhanced : BuildSummary - Uniform summary builder : Can filter high-resolution result with second isotopic peak of precursor ion.

2010/08/18 Version 2.3.4
Enhanced : Mgf2DtaProcessor - Add option to extract file to individual directory.

2010/08/17 Version 2.3.3
New : Add Extract Protein By Access Number Processor : read noredundant file and extract corresponding protein group based on access number file.
Enhanced : BuildSummary - Uniform summary builder for SEQUEST/MASCOT/XTandem search result. Protein fdr supported.

2010/07/20 Version 2.3.2
New : Add Score Distribution Builder : read peptides file and build score distribution based on charge/misscleavage/modification and target/decoy entries.

2010/07/05 Version 2.3.1
Enhanced : SEQUEST BuildSummary : Support zip compressed dtas/outs files or dta/out directory.
Enhanced : Identified iTRAQ Statistic Builder : Improved speed for large iTRAQ data. 

2010/06/29 Version 2.3.0
Bug fixed : SEQUEST BuildSummary : protein sequence cannot be found when protein name contains '/'.

2010/06/29 Version 2.2.9
Bug fixed : Exception when buildsummary : cannot compare two items.

2010/06/23 Version 2.2.8
Enhanced : Can define profile length used in SILAC quantification.

2010/06/17 Version 2.2.7
Enhanced : Compatible with TurboSEQUEST v.28 (rev. 13).

2010/06/11 Version 2.2.6
Enhanced : Convert MSF File To BuildSummary Result File : can convert the text format of MSF (Excel->Text).

2010/06/11 Version 2.2.5
New : Thermo Protein Discover MSF Excel File to BuildSummary Converter.

2010/06/03 Version 2.2.4
Bugfix : Exception thrown when loading old buildsummary parameter file.
New : BuildSummary - Uniform summary builder for SEQUEST/MASCOT/XTandem search result. But, protein fdr is not supported now. :-(

2010/05/31 Version 2.2.3
New : Peptide Distribution Builder : As same function as RcpaBioSolution.

2010/05/10 Version 2.2.2
New : Add MaxQuant MGF File Distiller : Extract peptides and MGF file based on identification result and MaxQuant MSM file. 
      Those result files can be used to generate spectrum images using RcpaBioSolution.

2010/05/07 Version 2.2.1
Enhanced : Reversed database builder : option to switch protease termini with previous/next aminoacid.
Bugfix : iTRAQ result multiple file distiller : limit each peak with minimum intensity 0.1.

2010/05/07 Version 2.2.0
Bugfix : iTRAQ result multiple file distiller : exception thrown when parsing small data.

2010/05/06 Version 2.1.9
Bugfix : iTRAQ result multiple file distiller : exception thrown when parsing CID only data.
New : pFind result summary builder (beta version).

2010/04/26 Version 2.1.8
Enhanced : BuildSummary - SEQUEST : Parse matched ion count from out file.

2010/04/21 Version 2.1.7
Bug fixed : Exception thrown when Mascot Html Result Downloader starts.

2010/04/15 Version 2.1.6
Enhanced : O18/SILAC Quantification Processor. At least 5 full ms will be used in each peptide quantification.

2010/04/09 Version 2.1.5
Enhanced : O18/SILAC Quantification Summary Viewer. Add all peptides linear regression result view.

2010/04/02 Version 2.1.4
Enhanced : O18/SILAC Quantification Summary Viewer. Export result will includes all protein/peptide columns.

2010/04/01 Version 2.1.3
Enhanced : O18/SILAC Quantification Summary Viewer. Add confidence presentation at protein and peptide level.

2010/03/30 Version 2.1.2
Bugfix : O18 Quantification Summary Viewer.

2010/03/28 Version 2.1.1
Enhanced : O18 Quantification Summary Viewer.

2010/03/18 Version 2.1.0
Bugfix : O18 Quantification Summary Viewer couldn't save/export result.
Enhanced : Add SEQUEST access number parser for BuildSummary.

2010/01/22 Version 2.0.9
New : Add unique peptide distiller for protein file. It's used to remove redundant peptide identification for building spectrum/peptide image.

2010/01/13 Version 2.0.8
Enhanced : Update tools for small molecule data analysis from ESI-TOF/Q-TOF full mass scan result.

2010/01/12 Version 2.0.7
Enhanced : Update tools for small molecule data analysis from ESI-TOF/Q-TOF full mass scan result.

2010/01/05 Version 2.0.6
Enhanced : SILAC quantification processor is compatible with dynamic modificaition result from mascot.
New: A few tools for small molecule data analysis from ESI-TOF/Q-TOF full mass scan result.

2009/12/14 Version 2.0.5
Enhanced : Extract dta/out from dtas/outs files : add new information when dtas/outs file missed.

2009/12/14 Version 2.0.4
Bugfix : ITraqResultMultipleFileDistiller : compatible with QTOF mzData.xml result;

2009/12/08 Version 2.0.3
Bugfix : Census result merger. Error export "AREA_RATIO" and "PROFILE_SCORE" as "0:0.00";

2009/12/07 Version 2.0.2
Enhanced : Export area information for Agilent MRM Viewer. 

2009/12/07 Version 2.0.1
Enhanced : Add minmum peptide seqneuce length filter for sequest/mascot/x!tandem summary builder. 

2009/12/01 Version 2.0.0
Enhanced : Silac Relative Quantification Summary Viewer. Add export function : a protein file and a peptide file will be exported. 

2009/11/25 Version 1.9.9
Enhanced : Silac Relative Quantification Calculator. Validate SILAC configuration file in quantification.

2009/11/23 Version 1.9.8
Enhanced : Using MSFileReader library (not XCalibur) to read the thermo raw file.
Bug fix : Agilent MRM result distiller. Exception will be thrown when light and heavy product ion were not crosslinked.

2009/11/20 Version 1.9.7
Enhanced feature : Census result merger compatible with Census 1.57.

2009/11/20 Version 1.9.6
Enhanced feature : Correct itraq result based on "Isotope Impurity Correction Table".

2009/11/17 Version 1.9.5
New feature : MSn Total Ion Count Distiller.

2009/11/16 Version 1.9.4
Bug fixed : Agilent MRM result distiller.Compatible with the file whose scan contains multiple production ions.

2009/11/06 Version 1.9.3
Enhanced : Agilent MRM result distiller.

2009/11/06 Version 1.9.2
New feature : Extract MS1 file from Agilent "*.d" directory.
New feature : Agilent MRM result previewer beta version.

2009/10/28 Version 1.9.1
Bug fix : iTRAQ multiple file distiller - Supporting minmum itraq peak count of scan.
New feature : Agilent "*.d" directory previewer.

2009/10/26 Version 1.9.0
Enhanced : iTRAQ multiple file distiller - Supporting minmum itraq peak count of scan.

2009/10/15 Version 1.8.9
New : MaxQuant Sites To Mascot Peptide Converter - Transfer the PTM peptide file of maxquant to buildsummary format which can be used to generate 
peptide-spectrum-match images only.

2009/08/18 Version 1.8.8
Bug fix : BuildSummary Suite - No peptides will pass the creteria with contaminant filter in previouse version.

2009/08/12 Version 1.8.7
Enhanced : BuildSummary Suite - Add contaminant filter. The filter will remove contaminant proteins before FDR calculation / grouping proteins.

2009/08/03 Version 1.8.6
New : Liqid Quantification - Find corresponding precursor ion based on product ion and quantify the precursor ion.

2009/07/21 Version 1.8.5
New : iTRAQ Modified Peptide Rsd Filter
Enhanced : Turbo Census MS1 Builder - Compatible with new Census version.

2009/07/13 Version 1.8.4 beta1
Enhanced : IPI parsing definition in MiscOptions.xml.

2009/07/10 Version 1.8.3 beta3
Bugfix : Dtaselect File Splitter - Error when reading dtaselect file.

2009/07/08 Version 1.8.3 beta2
Enhanced : Summary Builder - Compatible to large dataset (more than 500 raw files), testing now!

2009/07/01 Version 1.8.3 beta
Enhanced : iTRAQ Result Multiple File Distiller - Assign the iTRAQ information of CID spectrum from previous PQD spectrum.
Enhanced : Identified Peptide Phosphorylation Ratio Builder - Only the iTRAQ with all corresponding phosphorylation peaks (such like both 116 and 117 exist) will be used.

2009/06/30 Version 1.8.2
Bugfix : Census Result Merger for Chro File Splitter - Missed the first protein group in each file.

2009/06/29 Version 1.8.1
New : Census Result Merger for Chro File Splitter - Compatible with new census version.

2009/06/29 Version 1.8.0
Enhanced : Census Chro File Splitter - Compatible with new census version.

2009/06/29 Version 1.7.9
Enhanced : iTRAQ Result Multiple File Distiller - Extract almost all itraq information from raw file.Previous version will extract the itraq information from the scan which contains at least three iTRAQ peaks.

2009/06/26 Version 1.7.8
Enhanced : Add new database definition for swissprot which will be used in BuildSummary. 
Bugfix : Minimum Ion Intensity filter doesn't work in TurboRaw2Mgf/TurboRaw2Dta.

2009/06/16 Version 1.7.7
New feature : Identified Peptide Phosphorylation Ratio Builder

2009/06/13 Version 1.7.6
Enhanced : SILAC Quantification Tools. Using precursor similarity tolerance to get correct elution window of the ion.

2009/06/12 Version 1.7.5
Bug fix : BuildSummary Suite - generate empty result when using protein fdr.
New feature : distribution builder for sequest/mascot/xtandem result

2009/06/05 Version 1.7.4
New feature : Ambigious Modified Peptide Remover - remove ambigious modified peptides, and keep the top score spectrum only for different peptide sequence and charge.

2009/05/25 Version 1.7.3
New feature : ValidatedPeptideDistiller - extract validated peptides based on spectra images.
Enhanced : Identified Peptides ITraq Calculator, calculating mean/stand_deviation for log(ratio) insteed of ratio.
Bug fix : Exception thrown when reading old configuration file from SequestSummaryBuilder/MascotSummaryBuilder/XTandemSummaryBuilder

2009/05/15 Version 1.7.2
Enhanced : Identified Peptides ITraq Calculator, add header for result file
Adjusted : File list format saved by summary builders.

2009/05/13 Version 1.7.1
Enhanced : Identified Peptides ITraq Calculator, group the result by peptide sequence

2009/05/12 Version 1.7.0
Enhanced : One2All supports the directory list file generated by buildsummary.

2009/05/11 Version 1.6.9
New feature : Multiple itraq result distiller - extract itraq information from multiple raw files and save to one file.
New feature : identified result itraq statistic calculator - extract itraq information based on identified peptide file and calculate mean/sigma.
Enhanced : Add new title definition for mzData generated by agilent which is used to parse mascot dat file.

2009/05/04 Version 1.6.8
Bug fix : Unique Peptide Distiller - missed the peptide which is unique already.

2009/05/04 Version 1.6.7
New feature : Unique Peptide Distiller - For peptides with same sequence and charge, keep the one with highest score only.

2009/05/03 Version 1.6.6
New feature : Identified ITraq Statistic Builder - calculate mean and sigma of 115/114, 116/114, 117/114 based on identified peptides.
Bug fix : TurboRaw2Mgf generate only one spectrum in mgf file.

2009/04/29 Version 1.6.5
Bug fix : CensusResultMerger compatible to file with singleton score (label data).
Bug fix : TurboRaw2Mgf throw exception when processing raw file with profile mode.

2009/04/27 Version 1.6.4
Bug fix : CensusChroFileSplitter generates empty files.

2009/04/27 Version 1.6.3
Bug fix : BuildSummary will throw exception using previous 1.6.2 version.

2009/04/27 Version 1.6.2
New feature : Simple protein group builder - keep only one protein in each protein group and generate unduplicated file.

2009/04/24 Version 1.6.1
New feature : Labeled result distiller - which will extract labeled peptides and corresponding protein group from noredundant file.
Enhanced: MiscOptions.xml updated to compatible with MascotGenericFormat file generated by MaxQuant

2009/04/20 Version 1.6.0
New feature : ExtractDistinctResultProcessor - which will extract distinct peptide and corresponding group from noredundant file.

2009/04/10 Version 1.5.9
New feature : ITraqFilePreview - which will extract all possible ITraq information from thermo raw file.
Enhanced : Census result merger is compatible to label free data and can be used at peptide level.

2009/03/30 Version 1.5.8
New feature : BuildSummary - XTandem XML Summary Builder 1.0.0

2009/03/27 Version 1.5.7
Enhanced : silac result viewer, supporting save/export the result after manual checking.

2009/03/24 Version 1.5.6
New feature : add silac quantification processor.
Enhanced : silac result viewer.
Enhanced : BuildSummary (both SEQUEST and MASCOT version), add database access number parser definition (MiscOptions.xml should be put in execute directory).

2009/03/21 Version 1.5.5
New feature : add silac result viewer(silac processor will be available at next version)

2009/02/26 Version 1.5.4
New feature : add access number parser definition for mascot dat summary builder.

2009/02/26 Version 1.5.3
New feature : substract peptides files, used to compare the results from different search conditions for same dataset.

2009/02/25 Version 1.5.2
New feature : extract peptides from protein file (more effective than the one in RcpaBioSolution).

2009/02/23 Version 1.5.1
BuildSummary - SEQUEST Summary Builder 5.0.8
BuildSummary - Mascot Dat Summary Builder 1.0.9
Bug fix : The bug when filtering unique 1 protein using Protein FDR function. Correct the statistic information in optimal file with final result.

2009/02/20 Version 1.5.0
Bug fix : Correct the statistic information in optimal file with final result.

2009/02/20 Version 1.4.9
Bug fix : Sometimes, program will be terminated when adding directories using "add subdirs" button. (BuildSummary - SEQUEST Summary Builder).

2009/02/19 Version 1.4.8
Bug fix : Exception thrown when parsing dta/out filename with more than 10+ charge. (BuildSummary - SEQUEST Summary Builder).

2009/02/19 Version 1.4.7
Bug fix : Program terminated when adding too many directories into BuildSummary - SEQUEST Summary Builder out/outs directory list.

2009/02/13 Version 1.4.6
Bug fix : K0R0/K4R6/K8R10 separator doesn't work in previous version.

2009/02/13 Version 1.4.5
New feature : Separator identified result based on modification. Can be used to separate large file. There are two modes:
1) Input modified aminoacids, separate identified result to MODIFIED and UNMODIFIED result.
2) Input modified aminoacid pattern, separate identified result to multiple result. (Designed for K0R0/K4R6/K8R10 labelling, can also be used for other type data)

2009/02/10 Version 1.4.4
Enhanced Tool : SEQUEST/MASCOT Summary Builder
1) Compatible to large dataset. (Passed the test on more than 240 raw files)

2009/02/09 Version 1.4.3
Bug Fix : SEQUEST/MASCOT Summary Builder
1) The QValues of spectra with same score in previous version were related to the rank, now fixed.

2009/02/05 Version 1.4.2
Enhanced Tool - MascotResult Dat Summary Builder:
1) Allow for building summary based on assigned protein fdr.
2) Allow for classify dat files before building summary.
New Tool - SEQUEST Summary Builder : similar to standalone version (BuildSummary)

2009/01/04 Version 1.4.1
Bug Fix:
  Tool - MascotResult Dat Summary Builder
  Error infomation - Error when parsing modification from mascot searching result

2008/12/15 Version 1.4.0
New feature - Turbo Mascot Generic Format Precursor Shift 10Da Processor

2008/12/15 Version 1.3.9
Enhanced Tool - MascotResult Dat Summary Builder:
  1) Support loading/saving dat file list
  2) Support loading/saving parameter file
  3) Support parsing source mgf/mzData file names from dat files which makes it easy to choose correct dat files
  4) Ask for directory to store result data like BuildSummary does  

2008/12/12 Version 1.3.8
Bug Fix: 
  Tool - MascotResult Dat Summary Builder
  Error infomation - Parsing error for mascot searching result without modification

2008/12/11 Version 1.3.7
New feature: A tool used to add additional 10da to precursorMz in mascot generic format file

2008/12/11 Version 1.3.6
New feature: MascotResult Dat Summary Builder supports filtering by score and/or expect value now.

2008/12/11 Version 1.3.5
Bug fix: After generating dtaselect file using "identified result to dtaselect converter", some peptides containing two or more peptide sequences are not quantifiable using Census.
         Now only one peptide will be kept in final entry when converting from noredundant file to dtaselect file
New feature: split dtaselect format file into small files.
New feature: build ms1 file (including index file) from raw file.

2008/12/04 Version 1.3.4
New feature: Extract MS2/MS3 from raw file to different directories.
Bug fixed: Census result merger is compatible to new format.

2008/12/03 Version 1.3.3
New feature: Convert identified result(noredundant file) to dtaselect. It is compatible with both sequest and mascot result.

2008/11/10
Fixed : error when parsing modification of mascot dat file