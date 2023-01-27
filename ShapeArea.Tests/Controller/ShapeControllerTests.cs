using Xunit;
using ShapeAreaLib.Shapes;
using ShapeAreaLib.Controllers;

namespace ShapeArea.Tests.Controller
{
	public class ShapeControllerTests
	{
		[Fact]
		public void ShapeController_Calc_Return_RightArea()
		{
			// Arrange
			Shape shape;

			// Act
			shape = ShapeController.Calc(3);

			// Assert
			Assert.Equal(28.274333882308138, shape.Area);

		}
	}
}
