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



//string a = Console.ReadLine();
//string[] parts = a.Split(' ');
//if (parts.Length < 4)
//    Console.WriteLine("Saylar tam daxil edilmeyib");
//else
//{
//    double K = double.Parse(parts[0]);
//    double N = double.Parse(parts[1]);
//    double M = double.Parse(parts[2]);
//    double D = double.Parse(parts[3]);
//    double S = 1;
//    if (K <= 1000 && K >= 0 && N <= 1000 && N >= 0 && M <= 1000 && M >= 0 && D <= 1000 && D >= 0)
//    {
//        S = K + N + M + D;
//        if (K == N + M + D && N == S * 1 / 4 && M == S * 1 / 7 && D == S - K - N - M)
//            Console.WriteLine(S);
//        else
//            Console.WriteLine("-1");
//    }
//    else
//        Console.WriteLine("-1");
//}

