using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP;

/// <summary>
/// Summary description for ProductMatrixAndInt
/// </summary>
public class ProductMatrixAndInt : BaseMatrix, IOperation
{

    public ProductMatrixAndInt(List<int> matrixA, List<int> matrixB) : base(matrixA, matrixB)
    {
    }

    public List<int> Calculate()
    {
        var matrixC = new List<int>();

        for (int i = 0; i < 9; i++)
        {
            matrixC.Add(_matrixA[i] * _matrixB[0]);
        }
        return matrixC;
    }
}