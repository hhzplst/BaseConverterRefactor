using System;

namespace BaseConverterRefactor {
  public class OctalToDecimal : BaseConverterRefactor {
    public OctalToDecimal() {
      FromBase = "Octal";
      ToBase = "Decimal";
    }
    public int GetResult() {
      return Convert.ToInt32(Convert.ToString(Number), 8);
    }
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, GetResult(), ToBase);
    }
  }
}