/*static class Program
{
    static public void Main(string[] args)
    {
        Console.WriteLine("test");
        foreach (var arg in args)
        {
            Console.WriteLine(arg);
        }
    }
}*/

using System.Runtime.InteropServices;

Console.WriteLine(1);
Console.WriteLine(TestConstructor.testField);
Console.WriteLine(TestConstructor.testField);
(new TestLocal()).Action();
TestLocal.LocalClass local = new TestLocal.LocalClass();
Console.WriteLine(local.localField);
Console.WriteLine(TestLocal.GraphicQuality.Common);

TestSingleton testSingleton1 = TestSingleton.GetInstance();
TestSingleton testSingleton2 = TestSingleton.GetInstance();
TestSingleton testSingleton3 = TestSingleton.GetInstance();
TestSingleton testSingleton4 = TestSingleton.GetInstance();
testSingleton1.name = "IsSingleton";
Console.WriteLine(testSingleton2.name);
Console.WriteLine(testSingleton3.name);
Console.WriteLine(testSingleton4.name);

class TestSingleton
{
    public static TestSingleton instance;
    private TestSingleton()
    {

    }
    public static TestSingleton GetInstance() 
    {
        if( instance == null)
        {
            instance = new TestSingleton();
        }
        return instance;
    }
    public string name = "none";
    public void Action()
    {
        Console.WriteLine(" I am singleton");
    }
}
static class TestConstructor
{
    static TestConstructor()
    {
        Console.WriteLine("static");
    }
    public static string testField = "test1";
}
public class TestLocal
{
    public static string testField;
    public enum GraphicQuality
    {
        High,
        Common, 
        Low,
    }
    public void Action()
    {
        Console.WriteLine("test");
        LocalClass localClass = new LocalClass();
        Console.WriteLine(localClass.localField);
    }
    public class LocalClass
    {
        public string localField = "localField";
    }
}
