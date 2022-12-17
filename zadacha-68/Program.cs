Console.Write("Введите число N: ");
uint n = uint.Parse(Console.ReadLine());

Console.Write("Введите число M: ");
uint m = uint.Parse(Console.ReadLine());

if(n>=0 && m>=0){
    Console.Write(Ackerman(n,m));
}
else{
    Console.Write("Числа N и M должены быть больше -1");
}

uint Ackerman(uint n, uint m){
    if(n == 0){
        return m+1;
    }
    else{
        if(m == 0){
            return Ackerman(n-1 , 1);
        }
        else{
            return Ackerman(n-1, Ackerman(n,m-1));
        }
    }
}

