using System;

//Write your code here
public class Negative_Exception:Exception
{
    public Negative_Exception(string message)
        :base(message)
    {
        
    }
}
public class Calculator
{
    public int power(int n,int p)
    {
        int temp=1;
        if(n<0 || p<0)
        {
            throw new Negative_Exception("n and p should be non-negative");
        }
        else
        {
            for(int i=0;i<p;i++)
            {
                temp=temp*n;
            }
            return temp;
        }
    }
}

class Solution{
    static void Main(String[] args){
        Calculator myCalculator=new  Calculator();
        int T=Int32.Parse(Console.ReadLine());
        while(T-->0){
            string[] num = Console.ReadLine().Split();
            int n = int.Parse(num[0]);
            int p = int.Parse(num[1]); 
            try{
                int ans=myCalculator.power(n,p);
                Console.WriteLine(ans);
            }
            catch(Exception e){
               Console.WriteLine(e.Message);

            }
        }
        
        
        
    }
}