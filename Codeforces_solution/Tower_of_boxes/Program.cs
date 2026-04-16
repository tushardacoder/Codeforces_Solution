
int t=int.Parse(Console.ReadLine());


while (t > 0)
{

    string s=Console.ReadLine();
    string[] sarr = s.Split();

    int n=int.Parse(sarr[0]);
    int m=int.Parse(sarr[1]);
    int d=int.Parse(sarr[2]);

    int unit = d / m + 1;

    int cnt = 0;

    if (m <= d)
    {
        while (n > 0)
        {
            n -= unit;
            cnt++;
        }

        Console.WriteLine(cnt);

    }

    else
    {
        Console.WriteLine(n);
    }



    t--;
}