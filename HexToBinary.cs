using System;

namespace BaseConverterRefactor {
  public class HexToBinary : BaseConverterRefactor {
    HexToDecimal hexToDecimal = new HexToDecimal();
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(hexToDecimal.GetResult(), 2), ToBase);
    }
  }
}