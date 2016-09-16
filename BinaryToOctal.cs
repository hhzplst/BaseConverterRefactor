using System;

namespace BaseConverterRefactor {
  public class BinaryToOctal : BaseConverterRefactor {
    private static BinaryToDecimal binaryToDecimal = new BinaryToDecimal();
    public BinaryToOctal() {
      FromBase = "Binary";
      ToBase = "Octal";
    }
    public override void PrintResult() {
      binaryToDecimal.Number = this.Number;
      Console.WriteLine("{0} in {1} is {2} in {3}. ", Number, FromBase, Convert.ToString(binaryToDecimal.GetResult(), 8), ToBase);
    }
  }
}