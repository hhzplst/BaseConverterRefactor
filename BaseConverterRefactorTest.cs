using System;

namespace BaseConverterRefactor {
  public class BaseConverterRefactorTest {
    public static void Main (string[] args) {
      BaseConverterRefactor testConverter = new DecimalToBinary();
      
      Console.WriteLine("Welcome to testConverter!");
      testConverter.ShowSettings();
      testConverter.Number = -18;
      testConverter.ShowSettings();

      testConverter.PrintResult();
      
    }
  }
}