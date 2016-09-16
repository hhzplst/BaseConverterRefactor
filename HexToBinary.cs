using System;

namespace BaseConverterRefactor {
  public class HexToBinary : BaseConverterRefactor {
    private static HexToDecimal hexToDecimal = new HexToDecimal();
    public HexToBinary() {
      FromBase = "Hexadecimal";
      ToBase = "Binary";
    }
    public override void PrintResult() {
      hexToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(hexToDecimal.GetResult(), 2), ToBase);
    }
  }
}