namespace RefactoringLab;

public interface ICarrier
{
    string Name { get; }
    decimal CostPerKg(decimal weightKg);
}

public class AramexCarrier : ICarrier
{
    public string Name => "Aramex";
    public decimal CostPerKg(decimal weightKg) => weightKg * 12m;
}

public class FedExCarrier : ICarrier
{
    public string Name => "FedEx";
    public decimal CostPerKg(decimal weightKg) => weightKg * 15m;
}

public class DhlCarrier : ICarrier
{
    public string Name => "DHL";
    public decimal CostPerKg(decimal weightKg) => weightKg * 18m;
}

public class ShippingCostCalculator
{
    private readonly Dictionary<string, ICarrier> _carriers;

    public ShippingCostCalculator(IEnumerable<ICarrier> carriers)
    {
        _carriers = new Dictionary<string, ICarrier>();
        foreach (var c in carriers)
        {
            _carriers.Add(c.Name, c);
        }
    }

    public decimal Calculate(string carrier, decimal weightKg)
    {
        if (!_carriers.ContainsKey(carrier))
            throw new ArgumentException($"Unknown carrier: {carrier}");

        return _carriers[carrier].CostPerKg(weightKg);
    }
}