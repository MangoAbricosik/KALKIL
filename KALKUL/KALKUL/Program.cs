using System;
/*
 *i - строка k - столбец 
 */
namespace KALKUL
{
    class Program
    {
        static public int matPLUS3x3()
        {
            int[,] matPLUS3x311 = new int[3, 3];
            int[,] matPLUS3x322 = new int[3, 3];
            int[,] matPLUS3x333 = new int[3, 3];

            Console.WriteLine("Введите сначала строки, потом стобцы ПЕРВОЙ МАТРИЦЫ");
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    matPLUS3x311[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите сначала строки, потом стобцы ВТОРОЙ МАТРИЦЫ");
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    matPLUS3x322[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Результат");
            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    matPLUS3x333[k, i] = matPLUS3x311[k, i] + matPLUS3x322[k, i];
                    Console.Write(matPLUS3x333[k, i] + "   ");
                    if (k == 2)
                    {
                        Console.WriteLine("");
                    }
                }
            }
            int error = 10100101;
            return error;

        }
        static public int matPLUS2x2()
        {
            int[,] matPLUS2x211 = new int[2, 2];
            int[,] matPLUS2x222 = new int[2, 2];
            int[,] matPLUS2x233 = new int[2, 2];

            Console.WriteLine("Введите сначала строки, потом стобцы ПЕРВОЙ МАТРИЦЫ");
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matPLUS2x211[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите сначала строки, потом стобцы ВТОРОЙ МАТРИЦЫ");
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matPLUS2x222[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Результат");
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matPLUS2x233[k, i] = matPLUS2x211[k,i] + matPLUS2x222[k,i];                    
                    Console.Write(matPLUS2x233[k, i] + "   ");
                    if (k == 1)
                    {
                        Console.WriteLine("");
                    }
                }
            }
            int error = 10100101;
            return error;
        }
        static public int matPLUS()
        {
            Console.WriteLine("Матрицы 2x2 - 1");
            Console.WriteLine("Матрицы 3x3 - 2");
            int vibPLUS = Convert.ToInt32(Console.ReadLine());

            switch (vibPLUS)
            {
                case 1:
                    int vibPLUS1 = matPLUS2x2();
                        return vibPLUS1;
                case 2:
                    int vibPLUS2 = matPLUS3x3();
                    return vibPLUS2;
            }
            int error = 10100101;
            return error;
        }
        static public int matOPR3x3()
        {
            Console.WriteLine("Введите сначала строки, потом стобцы");
            int[,] matOPR3x31 = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    matOPR3x31[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int dioPLUS3x3 = (matOPR3x31[0, 0] * matOPR3x31[1, 1] * matOPR3x31[2,2]) + (matOPR3x31[0,1] * matOPR3x31[1,2] * matOPR3x31[2,0]) + (matOPR3x31[0,2] * matOPR3x31[1,0] * matOPR3x31[2,1]);
            int dioMINUS3x3 = (matOPR3x31[0,2] * matOPR3x31[1,1] * matOPR3x31[2,0]) + (matOPR3x31[0,1] * matOPR3x31[1,0] * matOPR3x31[2,2]) + (matOPR3x31[0,0] * matOPR3x31[1,2] * matOPR3x31[2,1]);

            int resMATOPR3x3 = dioPLUS3x3 - dioMINUS3x3;
            return resMATOPR3x3;

        }
        static public int matOPR2x2()
        {
            Console.WriteLine("Введите сначала строки, потом стобцы");
            int[,] matOPR2x21 = new int[2, 2];
            
            for (int i = 0; i<2; i++)
            {
                for(int k = 0; k < 2; k++)
                {
                    matOPR2x21[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }

            int dioPLUS2x2 = matOPR2x21[0, 0] * matOPR2x21[1, 1];
            int dioMINUS2x2 = matOPR2x21[1, 0] * matOPR2x21[0, 1];

            int resMATOPR2x2 = dioPLUS2x2 - dioMINUS2x2;
            return resMATOPR2x2;

            
        }
        static public int matOPR()
        {
            Console.WriteLine("Матрица 2x2 - 1");
            Console.WriteLine("Матрица 3x3 - 2");
            int matOPRVIB = Convert.ToInt32(Console.ReadLine());

            switch (matOPRVIB)
            {
                case 1:                   
                    int matOPR2x2res = matOPR2x2();
                    return matOPR2x2res;                   
                case 2:
                    int matOPR3x3res = matOPR3x3();
                    return matOPR3x3res;
                default:
                    int Error = 1010101010;
                    return Error;
            }
            
        }
        static public int matricVIB()
        {
            Console.WriteLine("Определитель - 1");
            Console.WriteLine("Сложение - 2");
            Console.WriteLine("Умножение - 3");
            int matricVIB1 = 0;
            while (true) { 
            try
            {
                matricVIB1 = Convert.ToInt32(Console.ReadLine());
                    break;
            }
            catch
            {
                Console.WriteLine("Введите цифру, а не букву");
            }
                         }
            int matVIB1res;
            switch (matricVIB1)
            {
                case 1:
                    matVIB1res = matOPR();
                    return matVIB1res;
                case 2:
                    matVIB1res = matPLUS();
                    return matVIB1res;                   
                case 3:
                   /* Console.WriteLine();
                    break;*/
                default:
                    int Error = 1010101010;
                    return Error;
            }
       
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1010101010 - Все плохо");
            Console.WriteLine("Стандартные вычисления - 1");
            Console.WriteLine("Матрицы - 2");
            int VIB = 0;
            while(true){ 
            try
            {
                VIB = Convert.ToInt32(Console.ReadLine());
                   break;
            }
            catch
            {
                Console.WriteLine("Введите цифру, а не букву");                    
            }
            }
            switch (VIB)
            {
                case 1:
                    Console.WriteLine();
                    break;
                case 2:
                    Console.WriteLine(matricVIB());
                    break;
                default:
                    Console.WriteLine("1010101010");
                    break;
            }

        }
    }
}
