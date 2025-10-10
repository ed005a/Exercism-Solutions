public class SpaceAge
{
    private int _seconds;
    public SpaceAge(int seconds) => _seconds = seconds;
    private int secondsEarth = 31557600;
    private double _onEarth = -1; 

    private Dictionary<string, double> ratio = new Dictionary<string, double>()
    {
        ["Mercury"] = 0.2408467,
        ["Venus"] = 0.61519726,
        ["Earth"] = 1.0,
        ["Mars"] = 1.8808158,
        ["Jupiter"] = 11.862615,
        ["Saturn"] = 29.447498,
        ["Uranus"] = 84.016846,
        ["Neptune"] = 164.79132,
    };

    public double OnEarth()
    {
        if (_onEarth != -1) return  _onEarth;
        _onEarth = _seconds / (double)secondsEarth;
        return  _onEarth;
    }

    public double OnMercury() => OnEarth() / ratio["Mercury"];

    public double OnVenus() => OnEarth() / ratio["Venus"];

    public double OnMars() => OnEarth() / ratio["Mars"];

    public double OnJupiter() => OnEarth() / ratio["Jupiter"];

    public double OnSaturn() => OnEarth() / ratio["Saturn"];

    public double OnUranus() => OnEarth() / ratio["Uranus"];

    public double OnNeptune() => OnEarth() / ratio["Neptune"];
}