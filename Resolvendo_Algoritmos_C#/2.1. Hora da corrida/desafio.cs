using System;
class Desafio {
    static void Main() {
        string[] texto = Console.ReadLine().Split(" ");
        int A = int.Parse(texto[0]), N = int.Parse(texto[1]);

        int toltalDePlacas = A * N;

        for (int i = 10; i <= 90; i += 10){
            double result = (double)toltalDePlacas / 100 * i;
            Console.Write(Math.Ceiling(result) + " ");
        }
    }
}