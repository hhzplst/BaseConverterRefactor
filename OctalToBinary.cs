using System;

namespace BaseConverterRefactor {
  public class OctalToBinary : BaseConverterRefactor {
    private static OctalToDecimal octalToDecimal = new OctalToDecimal();
    public OctalToBinary() {
      FromBase = "Octal";
      ToBase = "Binary";
    }
    public override void PrintResult() {
      octalToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(octalToDecimal.GetResult(), 2), ToBase);
    }
  }
}