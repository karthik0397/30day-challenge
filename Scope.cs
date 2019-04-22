using System;

class sort 
{
    public static void Main(string[] args)
    {
        int[] a={1,4,3,5,6};
        int temp;
        for(int i=0;i<a.Length-1;i++)
        {
            for(int j=i+1;j<a.Length;j++)
            {
                if(a[i]<a[j])
                {
                    temp=a[i];
                    a[i]=a[j];
                    a[j]=temp;
                }
            }
        }
        foreach(int i in a)
        {
            Console.WriteLine(i);
        }
    }
}