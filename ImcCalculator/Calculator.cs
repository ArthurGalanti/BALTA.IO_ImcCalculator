using System;

namespace ImcCalculator;

public static class Calculator
{
///<summary>Este método retorna o resultado do IMC, uma descrição e o grau de obesidade.</summary>
/// <param name="height">Altura da pessoa em centímetros</param>
/// <param name="weigh">Peso da pessoa em quilogramas</param>
    public static (double, string, int) CalculateIMC(double height, double weigh)
    {
        var imc = Math.Round(weigh / Math.Pow(height, 2), 2);
        
        return imc switch
        {
            < 18.5 => (imc, "Abaixo do peso normal",0) ,
            >= 18.5 and < 25 => (imc, "Peso normal",0) ,
            >= 25 and < 30 => (imc, "Excesso de peso",1),
            >= 30 and < 35 => (imc, "Obesidade classe I",2),
            >= 35 and < 40 => (imc, "Obesidade classe II",2),
            >= 40 => (imc, "Obesidade classe III",3),
            _ => (0, "Não foi possível calcular",0)
        };
    }
}
