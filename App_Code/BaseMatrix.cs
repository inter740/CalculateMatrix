using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for BaseMatrix
/// </summary>
public abstract class BaseMatrix
{
    protected readonly List<int> _matrixA;
    protected readonly List<int> _matrixB;

    public BaseMatrix(List<int> matrixA, List<int> matrixB)
    {
        _matrixA = matrixA;
        _matrixB = matrixB;
    }
}