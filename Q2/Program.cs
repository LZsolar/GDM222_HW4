using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<List<int>> g = new List<List<int>>();
        List<int> color = new List<int>();
        for(int i=0;i<n;i++){
            List<int> temp = new List<int>();
            g.Add(temp);
            color.Add(0);
        }

        while(true){
            int a = int.Parse(Console.ReadLine());
            if(a>=n||a<0){break;}
            int b = int.Parse(Console.ReadLine());
            g[a].Add(b);
            g[b].Add(a);
        }
        
        
        Console.Write(paint(n,ref g,ref color));
    }

    public static int paint(int n,ref List<List<int>> g,ref List<int> color){
       int mxColor=0;
        for(int i=0;i<n;i++){
            foreach(int v in g[i]){
                if(color[i]==color[v]){
                    color[v]++;
                }
            }
        }
        for(int i=0;i<n;i++){
            if(color[i]>mxColor){mxColor=color[i];}
        }

        return mxColor+1;
    }
}