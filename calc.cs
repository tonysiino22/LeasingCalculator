public static class Calc
{
    public static decimal LoanPayment(decimal amount, decimal ratePerYear, int months)
    {
        double i = (double) ratePerYear / 100 / 12;
        if (i == 0) return Math.Round(amount / months, 2);
        double pay = (double)amount * i / (1 - Math.Pow(1 + i, -months));
        return Math.Round((decimal)pay, 2);
    }
    public static decimal LeasePayment(decimal price, decimal downPayment, decimal residual, decimal ratePerYear, int months)
    {
    double i = (double)ratePerYear / 100 / 12;
    if (i == 0) return Math.Round((price - downPayment - residual) / months, 2);
    double pv = (double)(price - downPayment) - (double)residual / Math.Pow(1 + i, months);
    double pay = pv * i / (1 - Math.Pow(1 + i, -months));
    return Math.Round((decimal)pay, 2);
    }
}

    