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

class Solution {



    static void Main(string[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        int temp=n,count=0;
        int temp1=0;
        string rem;
        string bin="";
        while(temp!=0)
        {
            rem=Convert.ToString(temp%2);
            bin=rem+bin;
            temp=temp/2;
        }
        Console.WriteLine(bin);
        for(int i=0;i<bin.Length;i++)
        {
            if(bin[i].Equals('1'))
            {
                count+=1;
                //temp1=count;
            }
            else
            {
                if(count>1)
                {
                    if(count>1 && count%2!=0 && count!=2)
                    {
                        temp1=count+temp1-1;
                        count=0;
                    }
                    else
                    {
                        temp1=temp1+count;
                        count=0;
                    }
                    
                }
                else
                {
                    count=0;
                }
            }
        }
        
        if(count>1 && count%2!=0)
        {
            temp1-=1;
        }
        if(count>0)
        {
            if(count%2==0)
            {
                temp1+=1;
            }
        }
        
        
        if(count>temp1)
        {
            Console.WriteLine(count);
        }
        else
        {
            
            Console.WriteLine(temp1);
        }
    }
}
