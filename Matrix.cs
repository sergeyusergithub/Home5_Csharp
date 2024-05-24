using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home5_Csharp
{
    // класс матрица
    internal class Matrix
    {
        // массив содержащий элементы матрицы
        private int[,] matr_;

        // свойство количество строк матрицы
        public int Rows { get; set; }

        // свойство количество столбцов матрицы
        public int Cols { get; set; }

        // индексатор для матрицы
        public int this[int r, int c]
        {
            get
            {
                if (r >= 0 && r < matr_.Length &&
            c >= 0 && c < matr_.Length)
                {
                    return matr_[r, c];
                }
                throw new IndexOutOfRangeException();
            }
            set { matr_[r, c] = value; }
        }

        // конструктор создающий матрицу по заданным размерам
        public Matrix(int rows, int cols)
        {
            Rows = rows;
            Cols = cols;
            matr_ = new int[Rows, Cols];
        }

        // конструктор создающий матрицу по заданным размерам 
        // и содержимому матрицы
        public Matrix(int rows, int cols, int[,] matr)
        {
            Rows = rows;
            Cols = cols;
            matr_ = matr;
        }

        // перегрузка оператора + для матриц
        public static Matrix operator +(Matrix obj1, Matrix obj2)
        {
            if (obj1.Rows == obj2.Rows && obj1.Cols == obj2.Cols)
            {
                int[,] tmp = new int[obj1.Rows, obj2.Cols];

                for (int i = 0; i < obj1.Rows; i++)
                {
                    for (int j = 0; j < obj1.Cols; j++)
                    {
                        tmp[i, j] = obj1.matr_[i, j] + obj2.matr_[i, j];
                    }

                }
                return new Matrix(obj1.Rows, obj1.Cols, tmp);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        // перегрузка оператора - для матриц
        public static Matrix operator -(Matrix obj1, Matrix obj2)
        {
            if (obj1.Rows == obj2.Rows && obj1.Cols == obj2.Cols)
            {
                int[,] tmp = new int[obj1.Rows, obj2.Cols];

                for (int i = 0; i < obj1.Rows; i++)
                {
                    for (int j = 0; j < obj1.Cols; j++)
                    {
                        tmp[i, j] = obj1.matr_[i, j] - obj2.matr_[i, j];
                    }

                }
                return new Matrix(obj1.Rows, obj1.Cols, tmp);
            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }

        // перегрузка оператора * для двух матриц
        public static Matrix operator *(Matrix obj1, Matrix obj2)
        {
            if (obj1.Cols == obj2.Rows)
            {
                int[,] tmp = new int[obj1.Rows, obj2.Cols];
                int sum = 0;
                for (int i = 0; i < obj1.Rows; i++)
                {
                    for (int j = 0; j < obj2.Cols; j++)
                    {
                        sum = 0;
                        for (int k = 0; k < obj1.Cols; k++)
                        {
                            sum += obj1.matr_[i, k] * obj2.matr_[k, j];
                        }
                        tmp[i, j] = sum;
                    }

                }
                return new Matrix(obj1.Rows, obj2.Cols, tmp);


            }
            else
            {
                throw new IndexOutOfRangeException();
            }
        }


        // перегрузка оператора * матрицы и числа
        public static Matrix operator *(Matrix obj1, int values)
        {
            int[,] tmp = new int[obj1.Rows, obj1.Cols];
            for (int i = 0; i < obj1.Rows; i++)
            {
                for (int j = 0; j < obj1.Cols; j++)
                {
                    tmp[i, j] = obj1.matr_[i, j] * values;
                }

            }
            return new Matrix(obj1.Rows, obj1.Cols, tmp);
        }

        // перегрузка оператора * матрицы и числа
        public static Matrix operator *(int values, Matrix obj1)
        {
            int[,] tmp = new int[obj1.Rows, obj1.Cols];
            for (int i = 0; i < obj1.Rows; i++)
            {
                for (int j = 0; j < obj1.Cols; j++)
                {
                    tmp[i, j] = obj1.matr_[i, j] * values;
                }

            }
            return new Matrix(obj1.Rows, obj1.Cols, tmp);
        }

        // перегрузка оператора == для матриц
        public static bool operator ==(Matrix A, Matrix B)
        {
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < A.Rows; i++)
                {
                    for (int j = 0; j < A.Cols; j++)
                    {
                        if (A[i, j] != B[i, j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        // перегрузка оператора !=  для матриц
        public static bool operator !=(Matrix A, Matrix B)
        {
            if (A.Rows != B.Rows || A.Cols != B.Cols)
            {
                return true;
            }
            else
            {
                if (A == B)
                {
                    return false;
                }
            }
            return true;
        }

        // перегрузка метода Equals
        public override bool Equals(object? obj)
        {
            return base.Equals(obj);
        }

        // перегружаем метод GetHashCode
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // метод вывода содержимого матрицы
        public void Print()
        {
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    if (matr_[i, j] < 0)
                    {
                        Console.Write(String.Format("\t{0:d2} ", matr_[i, j]));
                    }
                    else
                    {
                        Console.Write(String.Format("\t {0:d2} ", matr_[i, j]));
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
