using System;

namespace BaseConverterRefactor {
  public class BinaryToHex : BaseConverterRefactor {
    BinaryToDecimal binaryToDecimal;
    public override void PrintResult() {
      binaryToDecimal = new BinaryToDecimal();
      binaryToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(binaryToDecimal.GetResult(), 16), ToBase);
    }
  }
}