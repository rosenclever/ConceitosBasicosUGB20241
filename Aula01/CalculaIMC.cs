using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    public class CalculaIMC
    {
        public string Calcular(int peso, float altura)
        {
            float imc = peso / (altura * altura);
            // Console.WriteLine(imc);
            string resultado = "";
            if (imc <= 18.5)
            {
                resultado = "Magreza";
            }
            else if (imc <= 24.9)
            {
                resultado = "peso normal";
            }
            else if (imc <= 29.9)
            {
                resultado = "sobrepeso";
            }
            else if (imc <= 34.9)
            {
                resultado = "obesidade grau 1";
            }
            else if (imc <= 49.9)
            {
                resultado = "obesidade grau 2";
            }
            else
            {
                resultado = "obesidade grau 3";
            }
            string retorno = $"O IMC calculado para o peso {peso} e a altura {altura} foi {imc:f1} classificado como {resultado}";
            return retorno;
        }
    }
}
