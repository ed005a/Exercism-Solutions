using System.Linq.Expressions;
using System.Runtime.InteropServices.Marshalling;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        long ans;
        try
        {
            ans = checked(@base * multiplier);
        }
        catch (OverflowException)
        {
            return "*** Too Big ***";
        }

        return ans.ToString();
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        float ans;
        ans =  @base * multiplier;
        if (float.IsInfinity(ans))
            return "*** Too Big ***";
        return ans.ToString();
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        decimal ans;
        try
        {
            ans = checked(@salaryBase * multiplier);
        }
        catch (OverflowException)
        {
            return "*** Much Too Big ***";
        }

        return ans.ToString();
    }
}
