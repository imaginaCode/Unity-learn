using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperadoresRelacionaisELogicos : MonoBehaviour
{
    /* operadores Relacionais, Retorna verdadeiro ou falso se a condição for atendida
     * == igual
     * != diferente
     * > maior que
     * < menor que
     * >= maior ou igual a
     * <= menor ou igual a
     */

    /*
     *  Operadores Logicos
     *   && - operador E, só se as duas condições for verdadeiro retorna verdadeiro
     *   || - operador OU, se uma das condições for verdadeiro retorna verdadeiro
     *   ! - operador NAO, inverte o resultado que iria ser retornado
     */


    int numero1 = 10,
        numero2 = 20;

    // Start is called before the first frame update
    void Start()
    {
        // aplicando os operadores relacionais
        print(numero1 == numero2);
        print(numero1 != numero2);
        print(numero1 > numero2);
        print(numero1 < numero2);
        print(numero1 >= numero2);
        print(numero1 <= numero2);


        // aplicando os operadores logicos
        print(numero1 == numero2 && numero1 >= numero2);
        print(numero1 == numero2 || numero1 >= numero2);
        print(!(numero1 == numero2));



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
