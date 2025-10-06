class WeighingMachine
{
    // TODO: define the 'Precision' property
    private int _precision;
    public WeighingMachine(int precision)
    {
        Precision = precision; 
    }

    public int Precision
    {
        get
        {
            return _precision;
        }
        private set
        {
            _precision = value;
        }
    }

    // TODO: define the 'Weight' property
    private double _weight;
    public double Weight
    {
        get => _weight; 
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException();
            _weight = value;
        }
    }

    // TODO: define the 'TareAdjustment' property
    private double _tareAdjustment = 5.0;

    public double TareAdjustment
    {
        private get => _tareAdjustment;
        set => _tareAdjustment = value;
    }
    // TODO: define the 'DisplayWeight' property

    public string DisplayWeight
    {
        get => $"{(Weight - TareAdjustment).ToString($"F{_precision}")} kg";
    }
}
