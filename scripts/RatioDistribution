pepfiles<-c('peptides.txt.ratio','peptides.txt.norm.ratio');
titles<-c('MaxQuant Ratio','MaxQuant Normalized Ratio');

mycolors=c("red","green","blue","brown","pink","black");
mybreaks<-c(-100,0.1*-50:50,100);

for (j in 1:length(pepfiles)){
  pepfile<-pepfiles[j];
  readcounts<-read.table(pepfile,header=T,row.names=1,sep='\t');
  counts<-log(readcounts);

  #calculate sd of ratio
  countssd<-apply(counts,1,function(x)  sd(x, na.rm=TRUE));

  #calculate mean of ratio and attach to array
  ratiolength = length(counts);
  countsmean<-apply(counts,1,function(x)  mean(x[!is.na(x)]));
  counts[ratiolength+1]<-countsmean;
  colnames(counts)[ratiolength+1] = 'Mean';

  #calculate calibrated ratio
  calibratedfile <- paste(pepfile,".calibrated",sep="");
  calcounts <- read.table(calibratedfile,header=T,row.names=1,sep='\t');
  counts[ratiolength+2] <- log(calcounts[1]);
  colnames(counts)[ratiolength+2] = 'Calibrated';

  ratiolength<-ratiolength+2;

  outfilename=paste(pepfile, ".png", sep="");
  png(file=outfilename, width=600, height=480*2);

  split.screen(c(2, 1));

  #draw ratio distribution
  screen(1);

  maxcount<-0;
  legs<-c();

  for (i in 1:ratiolength) {
    ci <- counts[i];
    cci<-ci[!is.na(ci)];
    hi<-hist(cci, breaks=mybreaks, plot=FALSE);
    maxcount<-max(maxcount,hi$counts);
    legs<-c(legs, sprintf("%s - [%.3f ; %.3f]",colnames(counts)[i],mean(cci),sd(cci)));
  }

  plot(0,xlim=c(-3,3),ylim=c(0,maxcount), type="n",xlab="log(L/H)",ylab="Count",main=titles[j]);

  for (i in 1:ratiolength) {
    ci <- counts[i];
    cci<-ci[!is.na(ci)];
    hi<-hist(cci, breaks=mybreaks, plot=FALSE);
    lines(hi$breaks[2:length(hi$breaks)],hi$counts, col=mycolors[i]);
  }
  legend(0.5, maxcount* 0.9,legend=legs,lty=4,col=mycolors);

  #draw sd of ratio
  screen(2);
  mybreaks2<-c(0.01*0:60);

  cci<-countssd[!is.na(countssd)];
  cci<-cci[cci < 0.6];
  hi<-hist(cci, breaks=mybreaks2,plot=FALSE);
  maxcount<-max(hi$counts);
  hist(cci, breaks=mybreaks2, main="", xlim=c(0,0.6), ylim=c(0, maxcount), xlab="stdev(mean(log(L/H)))");

  dev.off();
}


