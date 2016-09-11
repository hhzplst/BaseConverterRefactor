using System;

namespace BaseConverterRefactor {
  public class OctalToHex : BaseConverterRefactor {
    OctalToDecimal octalToDecimal;
    public override void PrintResult() {
      octalToDecimal = new OctalToDecimal();
      octalToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(octalToDecimal.GetResult(), 16), ToBase);
    }
  }
}