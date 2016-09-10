using System;

namespace BaseConverterRefactor {
  public class HexToOctal : BaseConverterRefactor {
    HexToDecimal hexToDecimal = new HexToDecimal();
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(hexToDecimal.GetResult(), 8), ToBase);
    }
  }
}