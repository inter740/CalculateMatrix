using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP;

/// <summary>
/// Summary description for MultiplicationMatrix
/// </summary>
public class MultiplicationMatrix : BaseMatrix, IOperation
{
    public MultiplicationMatrix(List<int> matrixA, List<int> matrixB) : base(matrixA, matrixB)
    {
    }

    public List<int> Calculate()
    {
        var matrixC = new List<int>();
        var positionRow = 0;

        for (int row = 0; row < 3; row++)
        {
            var multiplication = new List<int>();
            multiplication.Clear();
            var summ = 0;

            for (int i = 0; i < 3; i++)
            {
                int index = 0;
                var columnIndex = i;
                for (int column = 0; column < 3; column++)
                {
                    multiplication.Add(_matrixA[positionRow + index] * _matrixB[column + columnIndex]);
                    columnIndex = (columnIndex + 3) - 1;
                    index++;
                }

                for (int j = 0; j < multiplication.Count; j++)
                {
                    summ += multiplication[j];
                }

                matrixC.Add(summ);
                multiplication.Clear();
                summ = 0;
            }
            positionRow = (positionRow + 3);
        }
        return matrixC;
    }

    private static List<int> Multiplication(List<int> matrixA, List<int> matrixB)
    {
        var matrixC = new List<int>();
        var positionRow = 0;

        for (int row = 0; row < 3; row++)
        {
            var multiplication = new List<int>();
            multiplication.Clear();
            var summ = 0;

            for (int i = 0; i < 3; i++)
            {
                int index = 0;
                var columnIndex = i;
                for (int column = 0; column < 3; column++)
                {
                    multiplication.Add(matrixA[positionRow + index] * matrixB[column + columnIndex]);
                    columnIndex = (columnIndex + 3) - 1;
                    index++;
                }

                for (int j = 0; j < multiplication.Count; j++)
                {
                    summ += multiplication[j];
                }

                matrixC.Add(summ);
                multiplication.Clear();
                summ = 0;
            }
            positionRow = (positionRow + 3);
        }
        return matrixC;
    }
}