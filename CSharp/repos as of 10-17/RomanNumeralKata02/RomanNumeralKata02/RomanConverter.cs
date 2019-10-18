using System;
using System.Collections.Generic;

namespace RomanNumeralKata02
{
    private List<Denomination> denominations;

    public RomanConverter()
    {
        denominations = new List<Denomination>();
        FillDenominations();
    }

    public RomanConverter(List<Denomination> denominations)
    {
        this.denominations = denomations;
    }

    private void FillDenominations()
    {
        AddDenomination(100, "C");
        AddDenomination(90, "XC");
        AddDenomination(50, "L");
        AddDenomination(40, "XL");
        AddDenomination(10, "X");
    }
}
