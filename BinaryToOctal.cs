using System;

namespace BaseConverterRefactor {
  public class BinaryToOctal : BaseConverterRefactor {
    BinaryToDecimal binaryToDecimal = new BinaryToDecimal();
    public override void PrintResult() {
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(binaryToDecimal.GetResult(), 8), ToBase);
    }
  }
}