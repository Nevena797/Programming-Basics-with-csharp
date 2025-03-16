double nylonSquardMeter = 1.50;
double paintLiter = 14.50;
double thinnerLiter = 5.00;
double bags = 0.40;

int neededNylon = int.Parse(Console.ReadLine());
int neededPaintLiter = int.Parse(Console.ReadLine());
int neededThinnerLiter = int.Parse(Console.ReadLine());
int hoursToWork = int.Parse(Console.ReadLine());

double extraAmountPaint = neededPaintLiter * 0.10;
double totalNeededPaint = neededPaintLiter  + extraAmountPaint;
double extraNylon = 2.0;
double totalNeededNylon = neededNylon + extraNylon;

double sumeNylon = totalNeededNylon * nylonSquardMeter;
double sumePainting = totalNeededPaint * paintLiter;
double sumeThinner = neededThinnerLiter * thinnerLiter;
double sumeMaterials = sumeNylon + sumePainting + sumeThinner + bags;
double sumeWorkingHours = sumeMaterials * 0.30;
double totalSumeWorkingHours = sumeWorkingHours * hoursToWork;
double sum = sumeMaterials + totalSumeWorkingHours;
Console.WriteLine(sum);


