using System;

namespace BaseConverterRefactor {
  public class HexToBinary : BaseConverterRefactor {
    HexToDecimal hexToDecimal;
    public override void PrintResult() {
      hexToDecimal = new HexToDecimal();
      hexToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(hexToDecimal.GetResult(), 2), ToBase);
    }
  }
}