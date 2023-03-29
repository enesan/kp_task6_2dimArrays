using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _2dimArrays
{
    internal class MyMatrix
    {
        private int Row;
        private int Column;
        private int[,] Matrix;
        public MyMatrix(int row, int column)
        {
            Row = row;
            Column = column;
            Matrix = new int[Row, Column];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    Matrix[i, j] = 0;
        }
        public int getRow()
        {
            return Row;
        }
        public int getColumn()
        {
            return Column;
        }
        public int this[int row, int column]
        {
            get
            {
                return Matrix[row, column];
            }
            set
            {
                Matrix[row, column] = value;
            }
        }
        public void FillingAMatrixWithRandomNumbers(int minValue, int MaxValue)
        {
            Random rnd = new Random();
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    Matrix[i, j] = rnd.Next(minValue, MaxValue);
        }

        public int FindingTheMaximalElementOfAMatrix(out int OutputRow, out int OutputColumn)
        {
            OutputRow = 0;
            OutputColumn = 0;
            int result = Matrix[0, 0];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    if (Matrix[i, j] > result)
                    {
                        result = Matrix[i, j];
                        OutputRow = i;
                        OutputColumn = j;
                    }
            return result;
        }

        public void SumOfTheFirstRowAndRandomColumnOfTheMatrix(out int SumOfTheFirstRow, out int SumOfTheRandomColumn, out int ColumnNumber)
        {
            Random rnd = new Random();
            SumOfTheFirstRow = 0;
            SumOfTheRandomColumn = 0;
            ColumnNumber = rnd.Next(0, Column + 1);
            for (int i = 0; i < Column; i++)
                SumOfTheFirstRow += Matrix[0, i];
            for (int i = 0; i < Row; i++)
                SumOfTheRandomColumn += Matrix[i, ColumnNumber];
            
        }

        public List<int> FindAllOddElementsOfAMatrix()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    if (Matrix[i, j] % 2 == 1 || Matrix[i, j] % 2 == -1)
                        result.Add(Matrix[i, j]);
            return result;
        }

        public List<int> AllElementsOfTheMainDiagonalOfTheMatrix()
        {
            List<int> result = new List<int>();
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    if (i == j)
                        result.Add(Matrix[i, j]);
            return result;
        }
    
        public List<int> AllMinimumElementsOfTheMatrix()
        {
            int result = Matrix[0, 0];
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    if (Matrix[i, j] < result)
                        result = Matrix[i, j];

            List<int> resultList = new List<int>();
            resultList.Add(result);
            for (int i = 0; i < Row; i++)
                for (int j = 0; j < Column; j++)
                    if (Matrix[i, j] == result)
                    {
                        resultList.Add(i);
                        resultList.Add(j);
                    }
            return resultList;
        }
    }
}
