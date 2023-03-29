using System;

namespace ImcCalculator;

public static class Calculator
{
    public static (double, string) CalculateIMC(double height, double weigh)
    {
        var imc = Math.Round(weigh / Math.Pow(height, 2), 2);
        
        return imc switch
        {
            < 18.5 => (imc, "Abaixo do peso normal") ,
            >= 18.5 and < 25 => (imc, "Peso normal") ,
            >= 25 and < 30 => (imc, "Excesso de peso"),
            >= 30 and < 35 => (imc, "Obesidade classe I"),
            >= 35 and < 40 => (imc, "Obesidade classe II"),
            >= 40 => (imc, "Obesidade classe III"),
            _ => (0, "Não foi possível calcular")
        };
    }
}
