using System;

namespace BaseConverterRefactor {
  public class OctalToBinary : BaseConverterRefactor {
    OctalToDecimal octalToDecimal = new OctalToDecimal();
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(octalToDecimal.GetResult(), 8), ToBase);
    }
  }
}