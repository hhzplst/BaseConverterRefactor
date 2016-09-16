using System;

namespace BaseConverterRefactor {
  public class HexToDecimal : BaseConverterRefactor {
    public HexToDecimal() {
      FromBase = "Hexadecimal";
      ToBase = "Decimal";
    }
    public int GetResult() {
      return Convert.ToInt32(Convert.ToString(Number), 16);
    }
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, GetResult(), ToBase);
    }
  }
}