public struct Coord
{
    public Coord(ushort x, ushort y)
    {
        X = x;
        Y = y;
    }

    public ushort X { get; }
    public ushort Y { get; }

    public override bool Equals(object obj) => obj is Coord other && X == other.X && Y == other.Y;
    public override int GetHashCode() => HashCode.Combine(X, Y);
}

public struct Plot
{
    public Coord A { get; }
    public Coord B { get; }
    public Coord C { get; }
    public Coord D { get; }

    public Plot(Coord cord1, Coord cord2, Coord cord3, Coord cord4)
    {
       A = cord1;
       B = cord2;
       C = cord3;
       D = cord4;
    }

    public double GetLongestSideLength()
    {
        double side1 = Distance(A, B);
        double side2 = Distance(B, C);
        double side3 = Distance(C, D);
        double side4 = Distance(D, A);
        return Math.Max(Math.Max(side1, side2), Math.Max(side3, side4));
    }

    private static double Distance(Coord a, Coord b)
    {
        double dx = a.X - b.X;
        double dy = a.Y - b.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

    public override bool Equals(object? obj) => obj is Plot other && A.Equals(other.A) && B.Equals(other.B)
                                                && C.Equals(other.C) && D.Equals(other.D);

    public override int GetHashCode() => HashCode.Combine(A, B, C, D);
}


public class ClaimsHandler
{
    private readonly List<Plot> _claims = new List<Plot>();
    private Plot? _lastClaim;
    public void StakeClaim(Plot plot)
    {
        _claims.Add(plot);
        _lastClaim = plot;
    }

    public bool IsClaimStaked(Plot plot) => _claims.Contains(plot);

    public bool IsLastClaim(Plot plot) => _lastClaim.HasValue && _lastClaim.Value.Equals(plot);

    public Plot GetClaimWithLongestSide()
    {
        Plot longest = _claims[0];
        double longestSide = longest.GetLongestSideLength();

        foreach (var claim in _claims)
        {
            double len = claim.GetLongestSideLength();
            if (len > longestSide)
            {
                longest = claim;
                len = longestSide;
            }
        }

        return longest;
    }
}
