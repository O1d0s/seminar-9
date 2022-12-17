Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine());

Console.Write(Print(n));

String Print(int n){
    if (n>0){
        return $"{n} " +Print(n-1);
    }
    else{
        return String.Empty;
    }
}

