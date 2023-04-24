using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        List<List<int>> g = new List<List<int>>();
        for(int i=0;i<n;i++){
            List<int> temp = new List<int>();
            g.Add(temp);
        }

        while(true){
            int a = int.Parse(Console.ReadLine());
            if(a>=n||a<0){break;}
            int b = int.Parse(Console.ReadLine());
            g[a].Add(b);
        }
        int first = int.Parse(Console.ReadLine());
        int last = int.Parse(Console.ReadLine());
       bool[] visited = new bool[n+1];
       bfs(first,last,ref visited,ref g);
       
        if(visited[last]){Console.WriteLine("Reachable");}
        else{Console.WriteLine("Uneachable");}
    }

     public static void bfs(int first,int last, ref bool[]visited,ref List<List<int>> g){
        Queue<int> q = new Queue<int>();
        q.Enqueue(first);
        while(q.Count>0){
            int u = q.Dequeue();
            if(visited[u]){continue;}
            visited[u] = true;

           
            foreach(int edge in g[u]){
                if(!visited[edge]){
                    q.Enqueue(edge);
                }
            }
        }
        return;
    }
}