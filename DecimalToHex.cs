using System;

namespace BaseConverterRefactor {
  public class DecimalToHex : BaseConverterRefactor {
    public DecimalToHex() {
      FromBase = "Decimal";
      ToBase = "Hexadecimal";
    }
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(Number, 16), ToBase);
    }
  }
}