using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversaoDeDados : MonoBehaviour
{
    // declarando variaveis

    int coletaMoeda = 10; // variavel inteira
    float dinheiro = 10.2f; // variavel com casa decimal
    bool duvida = false;
    string texto = "alguma coisa";  // variavel de texto
    // Start is called before the first frame update
    void Start()
    {
        coletaMoeda = (int)dinheiro;  // converte para inteiro 
        texto = dinheiro.ToString(); // converte para texto o conteudo da variavel

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
