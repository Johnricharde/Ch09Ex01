namespace Ch09Ex01
{
    /// <summary>
    /// This class contains my program!
    /// </summary>
    internal class Program
    {
        public abstract class MyBase {}
        internal class MyClass : MyBase {}
        public interface IMyBaseInterface {}
        internal interface IMyBaseInterface2 {}
        internal interface IMyInterface : IMyBaseInterface, IMyBaseInterface2 {}
        internal sealed class MyComplexClass : MyClass, IMyInterface {}
        static void Main(string[] args)
        {
            MyComplexClass myObj = new MyComplexClass();
            Console.WriteLine(myObj.ToString());
            Console.ReadKey();
        }
    }
}
