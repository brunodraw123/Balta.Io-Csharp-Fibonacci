using System;

namespace _Fibonacci
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Quantos números da sequência de fibonacci deseja ver?");
            int tamanhoArray = int.Parse(Console.ReadLine());// quantidade de numeros que sera mostrado
            if (tamanhoArray >= 2)
            {
                SequenciaFIbocciExtensa(tamanhoArray);
            }
            else
            {
                SequenciaFIbocciCurta(tamanhoArray);
            }

        }
        public static void SequenciaFIbocciCurta(int tamanhoArray)
        {
            if (tamanhoArray == 0) { Console.WriteLine("Inválido"); }//caso numero seja 0
            else
            { Console.WriteLine("0"); }//caso numero seja 1
        }
        public static void SequenciaFIbocciExtensa(int tamanhoArray)
        {
            int arrayUltimoIndice = tamanhoArray - 1;// numero do ultimo indice que tera o array.
            int[] fibonacci = new int[tamanhoArray];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i <= arrayUltimoIndice; i++)//calcula;
            {
                fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
            }

            for (int i = 0; i < fibonacci.Length; i++)//printa;
            {
                Console.Write(fibonacci[i] + " ");
            }
        }


    }
}
