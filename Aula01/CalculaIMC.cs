using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula01
{
    public class CalculaIMC
    {
        //retorna apenas o IMC calculado
        public float Calcular(int peso, float altura)
        {
            return peso / (altura * altura);
        }

        // obter a classificação do IMC fornecendo o IMC
        public string ObterClassificacao(float imc)
        {
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
            return resultado;
        }
        // obter a classificação do IMC fornecendo peso e altura
        public string ObterClassificacao(int peso, float altura)
        {
           return ObterClassificacao(Calcular(peso, altura)); 
        }
    }
}
