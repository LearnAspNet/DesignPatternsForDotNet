using DesignPatterns.Strategy.ConcreteService;
using DesignPatterns.Strategy;

namespace DesignPatterns.ConsoleUI;

public class Program
{
    static void Main(string[] args)
    {
        #region Strategy

        CompressionContext ctx = new CompressionContext(new ZipCompression());
        ctx.CreateArchive("DotNetDesignPattern");
        ctx.SetStrategy(new RarCompression());
        ctx.CreateArchive("DotNetDesignPattern");
        Console.Read();

        #endregion
    }
}