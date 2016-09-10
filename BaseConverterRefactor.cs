using System;

namespace BaseConverterRefactor {
  public class BaseConverterRefactor {
    public int Number {get; set; }
        public string FromBase {get; set; }
        public string ToBase {get; set; }
        public void Init() {
            Number = 0;
            FromBase = "Decimal";
            ToBase = "Binary";
        }
        public BaseConverterRefactor() {
            Init();
        }
        public void ResetBaseConverterRefactor() {
            Init();
        }
        public void ShowSettings() {
            Console.WriteLine("\n********************");
            Console.WriteLine("CURRENT SETTINGS\nNumber: {0}\nFrom Base: {1}\nTo Base: {2}", Number, FromBase, ToBase);
            Console.WriteLine("********************\n");
        }
        public virtual void PrintResult() {}
  }
}