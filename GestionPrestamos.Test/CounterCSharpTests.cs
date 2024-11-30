namespace GestionPrestamos.Test;

/// <summary>
/// These tests are written entirely in C#.
/// Learn more at https://bunit.dev/docs/getting-started/writing-tests.html#creating-basic-tests-in-cs-files
/// </summary>
public class CounterCSharpTests : TestContext
{
  
    [Fact]
    public void ShouldRenderPrestamoPickerCorrectly()
    {
        // Arrange
        var prestamos = new List<Prestamos>
        {
            new Prestamos { PrestamoId = 1, Concepto = "Concepto 1", Balance = 100.0 },
            new Prestamos { PrestamoId = 2, Concepto = "Concepto 2", Balance = 200.0 }
        };

        var component = RenderComponent<PrestamoPicker>(parameters => parameters
            .Add(p => p.Prestamos, prestamos)
            .Add(p => p.PrestamoId, 0)
            .Add(p => p.Valor, 0.0)
        );

        // Act
        var selectElement = component.Find("select");
        var inputElement = component.Find("input#quantity-input");
        var buttonElement = component.Find("button");

        // Assert
        Assert.NotNull(selectElement);
        Assert.NotNull(inputElement);
        Assert.NotNull(buttonElement);
    }

}
