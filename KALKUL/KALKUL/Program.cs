using System;
/*
 *i - строка k - столбец 
 */
namespace KALKUL
{
    class Program
    {
        static public int matOSTATOK()
        {
            Console.WriteLine("Введите первое число");
            int matOSTATOK1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int matOSTATOK2 = Convert.ToInt32(Console.ReadLine());

            matOSTATOK1 %= matOSTATOK2;
            return matOSTATOK1;
        }
        static public int matDELCHISLO()
        {
            Console.WriteLine("Введите первое число");
            int matDELCHISLO1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int matDELCHISLO2 = Convert.ToInt32(Console.ReadLine());

            matDELCHISLO1 /= matDELCHISLO2;
            return matDELCHISLO1;
        }
        static public int matUMNCHISLO()
        {
            Console.WriteLine("Введите первое число");
            int matUMNCHISLO1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int matUMNCHISLO2 = Convert.ToInt32(Console.ReadLine());

            matUMNCHISLO1 *= matUMNCHISLO2;
            return matUMNCHISLO1;
        }
        static public int matMINUS()
        {
            Console.WriteLine("Введите первое число");
            int matMINUS1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int matMINUS2 = Convert.ToInt32(Console.ReadLine());

            matMINUS1 -= matMINUS2;
            return matMINUS1;
        }
        static public int matSLOCH()
        {
            Console.WriteLine("Введите первое число");
            int matSLOCH1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            int matSLOCH2 = Convert.ToInt32(Console.ReadLine());

            matSLOCH1 += matSLOCH2;
            return matSLOCH1;
        }
        static public int matVICH()
        {
            Console.WriteLine("Сложение - 1");
            Console.WriteLine("Вычитание - 2");
            Console.WriteLine("Умножение - 3");
            Console.WriteLine("Деление - 4");
            Console.WriteLine("Остаток - 5");

            int matVICH1 = 0;

            while (true)
            {
                try
                {
                    matVICH1 = Convert.ToInt32(Console.ReadLine());

                    break;
                }
                catch
                {
                    Console.WriteLine("Введите цифру, а не букву");
                }
            }

       
            int matVICHRES = 0;
            
            switch (matVICH1)
            {
                case 1:
                    matVICHRES = matSLOCH();
                        return matVICHRES;
                case 2:
                    matVICHRES = matMINUS();
                        return matVICHRES;
                case 3:
                    matVICHRES = matUMNCHISLO();
                        return matVICHRES;
                case 4:
                    matVICHRES = matDELCHISLO();
                        return matVICHRES;
                case 5:
                    matVICHRES = matOSTATOK();
                        return matVICHRES;

            }
            int error = 10100101;
            return error;
        }
        static public int matUMN2x2()
        {
            int[,] matUMN2x21 = new int[2, 2];
            int[,] matUMN2x22 = new int[2, 2];

            Console.WriteLine("Введите сначала строки, потом стобцы ПЕРВОЙ МАТРИЦЫ");
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matUMN2x21[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("Введите сначала строки, потом стобцы ВТОРОЙ МАТРИЦЫ");
            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    matUMN2x22[k, i] = Convert.ToInt32(Console.ReadLine());
                }
            }
            int[,] matUMN2x2RES = new int[2, 2];
            matUMN2x2RES[0, 0] = ((matUMN2x21[0, 0] * matUMN2x22[0, 0]) + (matUMN2x21[1, 0] * matUMN2x22[0, 1]));
            matUMN2x2RES[1, 0] = ((matUMN2x21[0, 0] * matUMN2x22[1, 0]) + (matUMN2x21[1, 0] * matUMN2x22[1, 1]));
            matUMN2x2RES[0, 1] = ((matUMN2x21[0, 1] * matUMN2x22[0, 0]) + (matUMN2x21[1, 1] * matUMN2x22[0, 1]));
            matUMN2x2RES[1, 1] = ((matUMN2x21[0, 1] * matUMN2x22[1, 0]) + (matUMN2x21[1, 1] * matUMN2x22[1, 1]));

            Console.WriteLine("Результат");

            for (int i = 0; i < 2; i++)
            {
                for (int k = 0; k < 2; k++)
                {
                    Console.Write(matUMN2x2RES[k, i] + "   ");
                    if (k == 1)
                    {
                        Console.WriteLine("");
                    }
                }
            }

            int error = 10100101;
            return error;
        }
        static public int matUMN3x3()
        {


            int error = 10100101;
            return error;
        }
        static public int matUMN()
        {
            Console.WriteLine("Умножение 2x2 - 1");
            Console.WriteLine("Умножение 3x3 - 2  НЕ РЕАЛИЗОВАНО");
            int vibMATUMN = 0;
            int vibMATUNM1 = 0;

            while (true)
            {
                try
                {
                    vibMATUMN = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите цифру, а не букву");
                }
            }

            switch (vibMATUMN)
            {
                case 1:
                    vibMATUNM1 = matUMN2x2();
                        return vibMATUNM1;
                case 2:
                    vibMATUNM1 = matUMN3x3();
                        return vibMATUNM1;
                    

            }
            int error = 10100101;
            return error;
        } 
            
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
            int vibPLUS = 0;

            while (true)
            {
                try
                {
                    vibPLUS = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите цифру, а не букву");
                }
            }

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
            Console.WriteLine("Результат");
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
            Console.WriteLine("Результат");
            int resMATOPR2x2 = dioPLUS2x2 - dioMINUS2x2;
            return resMATOPR2x2;

            
        }
        static public int matOPR()
        {
            Console.WriteLine("Матрица 2x2 - 1");
            Console.WriteLine("Матрица 3x3 - 2");
            int matOPRVIB = 0;
            while (true)
            {
                try
                {
                    matOPRVIB = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Введите цифру, а не букву");
                }
            }

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
                    matVIB1res = matUMN();
                    return matVIB1res;
                    
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
                    Console.WriteLine(matVICH());
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
