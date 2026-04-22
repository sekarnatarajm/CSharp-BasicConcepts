namespace CompositePattern
{
    public class FileData : IFileSystem
    {
        string _name = "";
        public FileData(string name)
        {
            _name = name;
        }
        public void Display()
        {
            Console.WriteLine(_name);
        }
    }
}
