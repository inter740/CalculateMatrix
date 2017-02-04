using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ASP;

/// <summary>
/// Summary description for Service
/// </summary>
public static class Service
{
    public static List<int> Compute(Func<List<int>> operation)
    {
        return operation.Invoke();
    }

    public static List<int> PerformOperation(IOperation operation)
    {
        return Compute(operation.Calculate);
    }
}