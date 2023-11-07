namespace ConsoleApp1.Services;

public class PrimeService
{
    public bool IsPrime(int value)
    {
        if (value <= 1) return false;
        if (value == 2) return true;
        if (value % 2 == 0) return false;

        var boundary = (int)Math.Floor(Math.Sqrt(value));

        for (int i = 3; i <= boundary; i += 2)
            if (value % i == 0)
                return false;

        return true;
    }

}