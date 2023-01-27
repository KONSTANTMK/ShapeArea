using ShapeAreaLib.Shapes;
using ShapeAreaLib.Controllers;

Shape s = ShapeController.Calc(3);
Console.WriteLine(s.Message + ", его площадь равна " + s.Area);

Shape r = ShapeController.Calc(2, 3);
Console.WriteLine(r.Message + ", его площадь равна " + r.Area);

Shape re = ShapeController.Calc(2, 2);
Console.WriteLine(re.Message + ", его площадь равна " + re.Area);

Shape tr = ShapeController.Calc(2, 5, 4);
Console.WriteLine(tr.Message + ", его площадь равна " + tr.Area);

Shape t = ShapeController.Calc(3, 5, 4);
Console.WriteLine(t.Message + ", его площадь равна  "+t.Area);
 



