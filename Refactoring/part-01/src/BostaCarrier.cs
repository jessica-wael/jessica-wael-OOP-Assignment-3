namespace RefactoringLab;

public class BostaCarrier : ICarrier
{
    public string Name => "Bosta";
    public decimal CostPerKg(decimal weightKg) => weightKg * 10m;
}
