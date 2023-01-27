using Xunit;
using ShapeAreaLib.Shapes;
using ShapeAreaLib.Controllers;

namespace ShapeArea.Tests.Controller
{
	public class ShapeControllerTests
	{
		[Fact]
		public void ShapeController_Calc_Return_Right_Circle_Area()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(3);

			// Assert
			Assert.Equal(28.274333882308138, shape.Area);

		}
		[Fact]
		public void ShapeController_Calc_Return_Right_Rectangle_Area()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(2,3);

			// Assert
			Assert.Equal(6, shape.Area);

		}
		[Fact]
		public void ShapeController_Calc_Return_Right_Square_Area()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(2, 2);

			// Assert
			Assert.Equal(4, shape.Area);

		}
		[Fact]
		public void ShapeController_Calc_Return_Right_Triangle_Area()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(2, 5, 4);

			// Assert
			Assert.Equal(3.799671038392666, shape.Area);
		}
		[Fact]
		public void ShapeController_Calc_Return_Right_Rectangular_Triangle_Area()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(3, 5, 4);

			// Assert
			Assert.Equal(6, shape.Area);
		}
		[Fact]
		public void ShapeController_Calc_Return_Square_Name()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(2, 2);

			// Assert
			Assert.Equal("Это квадрат", shape.Message);
		}
		[Fact]
		public void ShapeController_Calc_Return_Rectangular_Triangle_Name()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(3, 5, 4);

			// Assert
			Assert.Equal("Это треугольник, он прямоугольный", shape.Message);
		}

		[Fact]
		public void ShapeController_Calc_Return_Exception_Negative_Value()
		{
			//act
			Action act = () => ShapeController.Calc(3, -5);

			// Arrange
			ArgumentException exception = Assert.Throws<ArgumentException>(act);

			//assert
			Assert.Equal("The value of the side cannot be negative", exception.Message);
		}
		[Fact]
		public void ShapeController_Calc_Return_Exception_No_Such_Shape()
		{
			//act
			Action act = () => ShapeController.Calc(3, 5, 4, 6, 7);

			// Arrange
			ArgumentException exception = Assert.Throws<ArgumentException>(act);

			//assert
			Assert.Equal("There is no such shape in this library", exception.Message);
		}
		[Fact]
		public void ShapeController_Calc_Return_Exception_No_Value_Entered()
		{
			//act
			Action act = () => ShapeController.Calc();

			// Arrange
			ArgumentException exception = Assert.Throws<ArgumentException>(act);

			//assert
			Assert.Equal("No value entered", exception.Message);
		}
		[Fact]
		public void ShapeController_Calc_Return_Exception_Shape_Couldnt_Exist()
		{
			//act
			Action act = () => ShapeController.Calc(3,3,6);

			// Arrange
			ArgumentException exception = Assert.Throws<ArgumentException>(act);

			//assert
			Assert.Equal("Shape couldn't exist", exception.Message);
		}
	}
}
