using System;

namespace dz_Cs_2.HW2
{
    internal class Money
    {
        public int Uah;
        public int Kop;

        public Money(int uah, int kop)
        {
            if (uah < 0 || kop < 0) throw new BankruptException("You r bankrupt");
            Uah = uah + kop / 100;
            Kop = kop % 100;
        }

        void CheckNegative(Money m)
        {
            if (m.Uah < 0 || m.Kop < 0) throw new BankruptException("You r bankrupt");
        }

        public static Money operator +(Money a, Money b)
        {
            Money r = new Money(a.Uah + b.Uah, a.Kop + b.Kop);
            a.CheckNegative(r);
            return r;
        }

        public static Money operator -(Money a, Money b)
        {
            int totalA = a.Uah * 100 + a.Kop;
            int totalB = b.Uah * 100 + b.Kop;
            int t = totalA - totalB;
            Money r = new Money(0, t);
            a.CheckNegative(r);
            return r;
        }

        public static Money operator *(Money a, int n)
        {
            int total = (a.Uah * 100 + a.Kop) * n;
            Money r = new Money(0, total);
            a.CheckNegative(r);
            return r;
        }

        public static Money operator /(Money a, int n)
        {
            int total = (a.Uah * 100 + a.Kop) / n;
            Money r = new Money(0, total);
            a.CheckNegative(r);
            return r;
        }

        public static Money operator ++(Money a)
        {
            Money r = new Money(a.Uah, a.Kop + 1);
            a.CheckNegative(r);
            return r;
        }

        public static Money operator --(Money a)
        {
            int total = a.Uah * 100 + a.Kop - 1;
            Money r = new Money(0, total);
            a.CheckNegative(r);
            return r;
        }

        public static bool operator <(Money a, Money b)
        {
            return a.Uah * 100 + a.Kop < b.Uah * 100 + b.Kop;
        }

        public static bool operator >(Money a, Money b)
        {
            return a.Uah * 100 + a.Kop > b.Uah * 100 + b.Kop;
        }

        public static bool operator ==(Money a, Money b)
        {
            return a.Uah == b.Uah && a.Kop == b.Kop;
        }

        public static bool operator !=(Money a, Money b)
        {
            return !(a == b);
        }

        public override string ToString()
        {
            return "Money " + Uah + " UAH " + Kop + " KOP";
        }
    }
}
