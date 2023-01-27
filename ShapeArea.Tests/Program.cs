using ShapeAreaLib;
using ShapeAreaLib.Shapes;

Shape s = Calculator.Calc(26);
Console.WriteLine(s.Message + ", его площадь равна " + s.Area);

Shape r = Calculator.Calc(2, 3);
Console.WriteLine(r.Message + ", его площадь равна " + r.Area);

Shape re = Calculator.Calc(2, 2);
Console.WriteLine(re.Message + ", его площадь равна " + re.Area);

Shape tr = Calculator.Calc(2, 5, 4);
Console.WriteLine(tr.Message + ", его площsdsdадь равна " + tr.Area);

Shape t = Calculator.Calc(3, 5, 4);
Console.WriteLine(t.Message + ", его площадь равна  "+t.Area);
 



