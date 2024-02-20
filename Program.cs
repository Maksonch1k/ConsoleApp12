namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Пример использования
            AbstractHandler xmlHandler = new HMLHandler();
            xmlHandler.Open();
            xmlHandler.Create();
            xmlHandler.Change();
            xmlHandler.Save();

            AbstractHandler txtHandler = new TXTHandler();
            txtHandler.Open();
            txtHandler.Create();
            txtHandler.Change();
            txtHandler.Save();

            AbstractHandler docHandler = new DOCHandler();
            docHandler.Open();
            docHandler.Create();
            docHandler.Change();
            docHandler.Save();
        }
    }
}
    
