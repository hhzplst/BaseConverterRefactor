using System;

namespace BaseConverterRefactor {
  public class DecimalToOctal : BaseConverterRefactor {
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(Number, 8), ToBase);
    }
  }
}