using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class condicionais : MonoBehaviour
{
    int moedasHeroi = 10,
        estados = 1, // 1 - coragem, 2 - meio termo, 3 - covardia
        valorVida = 100; // valor da vida  para compra
    string result;


    // Start is called before the first frame update
    void Start()
    {
        // teste de if, else if e else
        if (moedasHeroi == valorVida)
        {
            print("Posso comprar a vida mas fico sem nada");
        }
        else if (moedasHeroi > valorVida)
        {
            print("posso comprar a vida e sobra dinheiro");

        }
        else
        {
            print("Valor de moedas insuficiente");
        }

        // operadores ternarios 
        // CONDICAO?TRUE:FALSE

        result = (moedasHeroi >= valorVida) ? "Posso comprar a vida" : "Nao tenho dinheiro suficiente";
        print(result);



        //Switch 
        switch (estados)
        {
            case 1:
                print("mate o heroi");
                break;
            case 2:
                print("mate se puder");
                break;
            case 3:
                print("corra agora");
                break;
            default:
                print("nenum estado selecionado");
                break;
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
