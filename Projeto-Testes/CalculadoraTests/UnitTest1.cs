using System;
using Xunit;
using CalculadoraCentral.Classes;

namespace CalculadoraTests;

public class UnitTest1
{
    [Fact]
    public void DeveSomarDoisNumeros()
    {
        // Arrange
        var calculadora = new Calculadora();
        int x = 5;
        int y = 3;

        // Act
        calculadora.Somar(x, y);

    }

    [Fact]
    public void DeveSubtrairDoisNumeros()
    {
        // Arrange
        var calculadora = new Calculadora();
        int x = 10;
        int y = 4;

        // Act
        calculadora.Subtrair(x, y);

    }

    [Fact]
    public void DeveMultiplicarDoisNumeros()
    {
        // Arrange
        var calculadora = new Calculadora();
        int x = 6;
        int y = 7;

        // Act
        calculadora.Multiplicar(x, y);

    }

    [Fact]
    public void DeveDividirDoisNumeros()
    {
        // Arrange
        var calculadora = new Calculadora();
        int x = 20;
        int y = 4;

        // Act
        calculadora.Dividir(x, y);

    }

}