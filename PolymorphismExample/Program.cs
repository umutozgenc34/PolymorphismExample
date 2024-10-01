using PolymorphismExample;

//BasePayment Pay = new IbanPayment()
//{
//    Amount = 100,
//    FullName = "Umut ÖZGENÇ",
//    IbanNo = "TR53 0000 0002 0212 0424 0332"
//};

//BasePayment Pay = new CreditCardPayment()
//{
//    FullName = "Umut Özgenç",
//    Amount = 100,
//    CardNumber = "2123 3212 3213",
//    CVV = "242",
//    EndDate = "07 / 27"
//};

BasePayment Pay = new PaypalPayment()
{
    Email = "umutozgenc34@gmail.com",
    Amount = 100
};


if (Pay.GetType() == typeof(CreditCardPayment))
{
    Console.WriteLine("Kredi kartı ile ödendi");
    Pay.Payment();
}
else if (Pay.GetType() == typeof(PaypalPayment))
{
    Console.WriteLine("Paypal ile ödendi");
    Pay.Payment();
}
else
{
    Console.WriteLine("Iban ile ödendi");
    Pay.Payment();
}

