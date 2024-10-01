

namespace PolymorphismExample;

public abstract class BasePayment
{
    public decimal Amount { get; set; }

    public abstract void Payment();
}
