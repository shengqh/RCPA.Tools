# TODO: Add comment
# 
# Author: sqh

DisplayComparison<-function(screenIndex, g, indexs, mybreaks, legends, colors, title){
  screen(screenIndex);
  
  gFilter1<-subset(g, g[,indexs[1]] > 0.1 & g[,indexs[2]] > 0.1);
  g1<-log(gFilter1[,indexs[1]]/gFilter1[,indexs[2]]);
  
  gFilter2<-subset(g, g[,indexs[3]] > 0.1 & g[,indexs[4]] > 0.1);
  g2<-log(gFilter2[,indexs[3]]/gFilter2[,indexs[4]]);
  
  h1<-hist(g1,breaks=mybreaks,plot=FALSE);
  h2<-hist(g2,breaks=mybreaks,plot=FALSE);
  
  maxCount<-max(h1$counts,h2$counts);
  plot(0,xlim=c(-3,3),ylim=c(0,maxCount),type="n",xlab="ln(Ratio)",ylab="Count",main=title);
  
  lines(h1$breaks[2:length(h1$breaks)],h1$counts,col=colors[1]);
  lines(h2$breaks[2:length(h2$breaks)],h2$counts,col=colors[2]);
  lines(c(0,0), c(0,maxCount),col="green");

  legs<-c( sprintf("%s\n[%.3f;%.3f]\n",legends[1], mean(g1),sd(g1)), sprintf("%s\n[%.3f;%.3f]\n",legends[2], mean(g2),sd(g2)));
  legend(1,maxCount,legend=legs,lty=4,col=colors);
}

ITraqDistribution<-function(inputfilename, title, outfilename){
  g<-read.table(inputfilename ,header=T,sep="\t");
  
  jpeg(file=outfilename, width=480*3, height=640);
  
  split.screen(c(1, 3));
  
  mybreaks<-c(-100,0.1*-50:50,100);
  
  DisplayComparison(1, g, c(4,3,6,5), mybreaks, c("115VS114", "117VS116"), c("red","blue"), title);
  DisplayComparison(2, g, c(5,3,6,4), mybreaks, c("116VS114", "117VS115"), c("red","blue"), title);
  DisplayComparison(3, g, c(6,3,5,4), mybreaks, c("117VS114", "116VS115"), c("red","blue"), title);
  
  dev.off();
}
