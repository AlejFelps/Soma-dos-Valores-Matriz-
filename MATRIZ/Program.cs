//Escreva um programa que leia uma matriz (3x5 ou 5x3) de 15 números inteiros e exiba ao final a soma dos valores de cada linha que estão armazenados nesta matriz.

using System;


class Program{
    static void SomaMatriz (int[,] matriz){

        for(int i = 0 ; i < matriz.GetLength(0) ; i++){
            for(int j = 0 ; j < matriz.GetLength(1) ; j++){
                Console.WriteLine($"Soma dos Valores | {matriz[i,j]}+{matriz[i,j]} = {matriz[i,j] + matriz[i,j]}  ");

            }

        }
        
    }

    static int[,] LerMatriz (int[,] matriz){

        for(int i = 0 ; i < matriz.GetLength(0) ; i++){
            for(int j = 0 ; j < matriz.GetLength(1) ; j++){
                Console.WriteLine($"Digite Um Valor :   {i+1,12}/{j+1} | {matriz.GetLength(0)} / {matriz.GetLength(1)}");
                matriz[i,j] = Convert.ToInt32(Console.ReadLine());
            }

        }
        return matriz;

    }

    public static void Main(string[] args)
    {
        int[,] matriz = new int[3,5];

        LerMatriz(matriz);
        SomaMatriz(matriz);


    }

}