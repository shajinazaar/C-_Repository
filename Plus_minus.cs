using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void plusMinus(List<int> arr,int n)
    {
        decimal i=0;
        decimal j=0;
        decimal k=0;
        foreach(int num in arr){
            
            if (num>0)
            {
                i+=1;

            }
            else if (num<0)
            {
               j+=1;
         
            }
            else
            {
                k+=1;
          
            }

        }
        
        decimal pos_val = Math.Round(i/n,6);
        decimal nav_val = Math.Round(j/n,6);
        decimal zero_val = Math.Round(k/n,6);
        
        Console.WriteLine(pos_val);
        Console.WriteLine(nav_val);
        Console.WriteLine(zero_val);
 
        
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList(); 

        Result.plusMinus(arr,n);
    }
}
