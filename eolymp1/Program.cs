//for (int i =0;i<=10; i++)
//{
//    for (int j =0;j<=10; j++)
//    {
//        if (j == 0 || j==11-1 || i == j && i <=11/2 || j==11-1-i && i<=11/2)
//            Console.Write("*");
//        else 
//            Console.Write(" ");
//    }
//    Console.WriteLine();
//}


//int n = int.Parse(Console.ReadLine());
//string s = n.ToString();
//int length = s.Length;
//int count = 0;
//for (int i = 0; i < (length + 1) / 2; i++)
//{
//    if (s[i] == s[length - 1 - i])
//    {
//        count++;
//    }
//}
//Console.WriteLine(count);



string a = Console.ReadLine();
string[] parts = a.Split(' ');
if (parts.Length < 4)
    Console.WriteLine("Saylar tam daxil edilmeyib");
else
{
    int K = int.Parse(parts[0]);
    int N = int.Parse(parts[1]);
    int M = int.Parse(parts[2]);
    int D = int.Parse(parts[3]);
    if (K <= 1000 && K > 0 && N <= 1000 && N > 0 && M <= 1000 && M > 0 && D <= 1000 && D > 0)
    {
        for (int i = 28; i <= 2000; i++)
        {
            int k=i/K;
            int n=i/N;
            int m=i/M;
            if (i == k * K && i == n * N && i == m * M)
            {
                if (i / K + i / N + i / M + D - i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            
        }
    }
    else
        Console.WriteLine("-1");
}

