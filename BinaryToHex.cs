using System;

namespace BaseConverterRefactor {
  public class BinaryToHex : BaseConverterRefactor {
    private static BinaryToDecimal binaryToDecimal = new BinaryToDecimal();
    public BinaryToHex() {
      FromBase = "Binary";
      ToBase = "Hexadecimal";
    }
    public override void PrintResult() {
      binaryToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(binaryToDecimal.GetResult(), 16), ToBase);
    }
  }
}