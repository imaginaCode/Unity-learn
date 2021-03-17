using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresAritmeticos : MonoBehaviour
{
    int num1, num2, num3, resultado;
    // Start is called before the first frame update
    void Start()
    {
        num1 = 10;
        num2 = 20;
        num3 = 2;

        // operadores basicos

        //soma
        num1 = num1 + num2;

        //subtração
        num1 = num1 - num2;

        //mutiplicacao
        num1 = num1 * num2;

        //divisao
        num1 = num1 / num2;

        //modulo de divisao
        num1 = num1 % num2;
        // fim

        // operadores incremento

        //incremento
        num1++;

        //decremento
        num1--;
        //fim

        // operadores reduzidos

        num1 += 2; // soma dois ao valor da variavel

        num1 -= 2; // subtrai 2 da variavel

        num1 *= 2; // mutiplica o valor da variavel por 2

        num1 /= 2; // divide o valor da variavel por 2

        num1 %= 2; // modolo da divisão por dois do conteudo da variavel




    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
