using System;

namespace BaseConverterRefactor {
  public class BaseConverterRefactorTest {
    public static void Main (string[] args) {
      
      Console.WriteLine("Welcome to testConverter!");

      BaseConverterRefactor testConverter = new DecimalToBinary();
      testConverter.Number = 102;
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter.Number = -18;
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new BinaryToDecimal();
      testConverter.Number = 11000110;
      testConverter.FromBase = "Binary";
      testConverter.ToBase = "Decimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new DecimalToOctal();
      testConverter.Number = 19142;
      testConverter.FromBase = "Decimal";
      testConverter.ToBase = "Octal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new OctalToDecimal();
      testConverter.Number = 377;
      testConverter.FromBase = "Octal";
      testConverter.ToBase = "Decimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new DecimalToHex();
      testConverter.Number = 8869;
      testConverter.FromBase = "Decimal";
      testConverter.ToBase = "Hexadecimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new HexToDecimal();
      testConverter.Number = 368298;
      testConverter.FromBase = "Hexadecimal";
      testConverter.ToBase = "Decimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new BinaryToOctal();
      testConverter.Number = 1101110;
      testConverter.FromBase = "Binary";
      testConverter.ToBase = "Octal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new OctalToBinary();
      testConverter.Number = 725;
      testConverter.FromBase = "Octal";
      testConverter.ToBase = "Binary";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new BinaryToHex();
      testConverter.Number = 1101110;
      testConverter.FromBase = "Binary";
      testConverter.ToBase = "Hexadecimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new HexToBinary();
      testConverter.Number = 725;
      testConverter.FromBase = "Hexadecimal";
      testConverter.ToBase = "Binary";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new OctalToHex();
      testConverter.Number = 645;
      testConverter.FromBase = "Octal";
      testConverter.ToBase = "Hexadecimal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      testConverter = new HexToOctal();
      testConverter.Number = 9876;
      testConverter.FromBase = "Hexadecimal";
      testConverter.ToBase = "Octal";
      testConverter.ShowSettings();
      testConverter.PrintResult();

      Console.WriteLine("\nClearing the settings...");
      testConverter.ResetBaseConverterRefactor();
      testConverter.ShowSettings();
    }
  }
}