Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine());

Console.Write(Sum(n,m));

int Sum(int n, int m){
    if(n <= m){
        return n + Sum(n+1,m);
    }
    else{
        return 0;
    }
}