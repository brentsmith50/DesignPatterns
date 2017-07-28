namespace SingletonPattern.Interfaces
{
    public interface INumbersToTextFile
    {
        int MaxIntegerToWrite { set; }
        void WriteNumbersToFile();
    }
}
