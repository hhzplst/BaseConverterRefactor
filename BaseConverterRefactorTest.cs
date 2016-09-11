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

/*************************TEST OUTPUT*************************

➜  BaseConverterRefactor git:(master) ✗ dotnet run
Project BaseConverterRefactor (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling BaseConverterRefactor for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.7311015
 

Welcome to testConverter!

********************
CURRENT SETTINGS
Number: 102
From Base: Decimal
To Base: Binary
********************

102 in Decimal is 1100110 in Binary. 

********************
CURRENT SETTINGS
Number: -18
From Base: Decimal
To Base: Binary
********************

-18 in Decimal is 11111111111111111111111111101110 in Binary. 

********************
CURRENT SETTINGS
Number: 11000110
From Base: Binary
To Base: Decimal
********************

11000110 in Binary is 198 in Decimal. 

********************
CURRENT SETTINGS
Number: 19142
From Base: Decimal
To Base: Octal
********************

19142 in Decimal is 45306 in Octal. 

********************
CURRENT SETTINGS
Number: 377
From Base: Octal
To Base: Decimal
********************

377 in Octal is 255 in Decimal. 

********************
CURRENT SETTINGS
Number: 8869
From Base: Decimal
To Base: Hexadecimal
********************

8869 in Decimal is 22a5 in Hexadecimal. 

********************
CURRENT SETTINGS
Number: 368298
From Base: Hexadecimal
To Base: Decimal
********************

368298 in Hexadecimal is 3572376 in Decimal. 

********************
CURRENT SETTINGS
Number: 1101110
From Base: Binary
To Base: Octal
********************

1101110 in Binary is 156 in Octal. 

********************
CURRENT SETTINGS
Number: 725
From Base: Octal
To Base: Binary
********************

725 in Octal is 111010101 in Binary. 

********************
CURRENT SETTINGS
Number: 1101110
From Base: Binary
To Base: Hexadecimal
********************

1101110 in Binary is 6e in Hexadecimal. 

********************
CURRENT SETTINGS
Number: 725
From Base: Hexadecimal
To Base: Binary
********************

725 in Hexadecimal is 11100100101 in Binary. 

********************
CURRENT SETTINGS
Number: 645
From Base: Octal
To Base: Hexadecimal
********************

645 in Octal is 1a5 in Hexadecimal. 

********************
CURRENT SETTINGS
Number: 9876
From Base: Hexadecimal
To Base: Octal
********************

9876 in Hexadecimal is 114166 in Octal. 
Clearing the settings...

********************
CURRENT SETTINGS
Number: 0
From Base: Decimal
To Base: Binary
********************


**********************END OF TEST OUTPUT**********************/