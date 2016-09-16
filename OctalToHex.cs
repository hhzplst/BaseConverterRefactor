using System;

namespace BaseConverterRefactor {
  public class OctalToHex : BaseConverterRefactor {
    private static OctalToDecimal octalToDecimal = new OctalToDecimal();
    public OctalToHex() {
      FromBase = "Octal";
      ToBase = "Hexadecimal";
    }
    public override void PrintResult() {
      octalToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(octalToDecimal.GetResult(), 16), ToBase);
    }
  }
}