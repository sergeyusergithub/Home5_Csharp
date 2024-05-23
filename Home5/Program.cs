//using Matrix;

namespace Home5 {

    internal class Program
    {
        private static void Main(string[] args)
        {
            // задача 1. Список книг для прочтения
            Console.WriteLine("Задача 1.");

            ListBook lsb = new ListBook();
            



            // задача 2. Работа с матрицами

            Console.WriteLine("Задача 2.");
            // создадим три матрицы одинакового размера
            Matrix A = new Matrix(3,3);
            Matrix B = new Matrix(3,3);
            Matrix C = new Matrix(3,3);

            // переменная для генерации случайных чисел
            Random rnd = new Random();

            // заполняем две матрицы случайными числами
            for(int i = 0; i < 3; i++){
                    for(int j = 0; j < 3; j++){
                        A[i,j] = rnd.Next(-10,10);
                        B[i,j] = rnd.Next(-10,10);
                    }
            } 
                // выводим содержимое матрицы А
                Console.WriteLine("A =  ");
                A.Print();

                // выводим содержимое матрицы В
                Console.WriteLine("\nB = ");
                B.Print();

                // выводим содержимое суммы матриц А + В
                Console.WriteLine("\nA + B =  ");
                C = A + B;
                C.Print();

                // выводим содержимое разности матриц А - В
                Console.WriteLine("\nA - B =  ");
                C = A - B;
                C.Print();

                // выводим содержимое произведения матрицы на число А * 8
                Console.WriteLine("\nA * 8 =  ");
                C = A * 8;
                C.Print();

                // выводим содержимое произведения матриц А * В
                Console.WriteLine("\nA * B =  ");
                C = A * B;
                C.Print();

                // выводим содержимое произведения числа на матрицу 2 * В
                Console.WriteLine("\n2 * B =  ");
                C = 2 * B;
                C.Print();

        }
    }

}