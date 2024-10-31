//Escreva um programa que leia uma matriz (3x5 ou 5x3) de 15 números inteiros e exiba ao final a soma dos valores de cada linha que estão armazenados nesta matriz.

using System;


class Program{
    static void SomaMatriz (int[,] matriz) //inicia o valor da matriz com int
    {

        for(int i = 0 ; i < matriz.GetLength(0) ; i++)//int i é igual a , int i recebe a matriz e adiciona +1 para variável i
        {
            for(int j = 0 ; j < matriz.GetLength(1) ; j++)//int j = 0, j é igual a matriz 1, j recebe +1
            {
                Console.WriteLine($"Soma dos Valores | {matriz[i,j]}+{matriz[i,j]} = {matriz[i,j] + matriz[i,j]}  ");//mostra na tela "soma dos valores" e mostra os valores
                // da matriz i e j somando com elas mesmas

            }

        }
        
    }

    static int[,] LerMatriz (int[,] matriz) // inicia uma matriz ler matriz 
    {

        for(int i = 0 ; i < matriz.GetLength(0) ; i++)// int i é igual a 0, i é igual a matriz, e adiciona +1 para i
            for(int j = 0 ; j < matriz.GetLength(1) ; j++)//int j é igual a 0, j recebe matriz 1, e adiciona +1 para j
            {
                Console.WriteLine($"Digite Um Valor :   {i+1,12}/{j+1} | {matriz.GetLength(0)} / {matriz.GetLength(1)}");// mostra uma mensagem"digite um valor e pega os valores
                // de i e j e adiciona +1 para ambas
                matriz[i,j] = Convert.ToInt32(Console.ReadLine());// converte os ints para string
            }

        }
        return matriz; // interrompe o loop dos for

    }

    public static void Main(string[] args)
    {
        int[,] matriz = new int[3,5]; // as matrizes recebem 3 colunas e 5 linhas 

        LerMatriz(matriz);// é lido a matriz LerMatriz
        SomaMatriz(matriz);// é lido a matriz SomaMatriz


    }

}
