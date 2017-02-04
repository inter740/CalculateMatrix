using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP;

/// <summary>
/// Summary description for AdditionMatrix
/// </summary>
public class AdditionMatrix : BaseMatrix, IOperation
{
    public AdditionMatrix(List<int> matrixA, List<int> matrixB) : base(matrixA, matrixB)
    {
    }

    public List<int> Calculate()
    {
        var matrixC = new List<int>();


        for (int i = 0; i < 9; i++)
        {
            matrixC.Add(_matrixA[i] + _matrixB[i]);
        }
        return matrixC;
    }

}