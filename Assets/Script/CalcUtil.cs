using System;
using System.Collections.Generic;

public static class CalcUtil
{
    public static T FindObjective<T>(List<T> list, Func<T,T,T> func)
    {
        T result = default(T);
        foreach(var t in list)
        {
            if(result == null)
            {
                result = t;
                continue;
            }
            result = func(result,t);
        }
        return result;
    }
}