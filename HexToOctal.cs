using System;

namespace BaseConverterRefactor {
  public class HexToOctal : BaseConverterRefactor {
    private static HexToDecimal hexToDecimal = new HexToDecimal();
    public HexToOctal() {
      FromBase = "Hexadecimal";
      ToBase = "Octal";
    }
    public override void PrintResult() {
      hexToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(hexToDecimal.GetResult(), 8), ToBase);
    }
  }
}