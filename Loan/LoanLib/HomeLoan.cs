namespace Loaning;

sealed class HomeLoan : Loan
{
    public override float Rate(double principle)
    {
        return principle <= 2000000 ? 0.10f:0.12f ;
    }

    public override double EMI
    {
        get{
            return principle*(1+ Rate(principle) * period/100) / (12*period);
        //emi = p * (1 + r * n / 100) / (12 * n)
        }
    }

    public double GetDiscount()
    {
        return principle > 1000000 ? 0.95 * principle : 0;
    }

    public double GetTotalDiscount()
    {
        
    }
};