using System;

namespace BaseConverterRefactor {
  public class BinaryToDecimal : BaseConverterRefactor {
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToInt32(Convert.ToString(Number), 2), ToBase);
    }
  }
}