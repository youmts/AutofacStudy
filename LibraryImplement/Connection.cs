using System.Diagnostics;
using CommonServiceLocator;
using LibraryInterface;

namespace LibraryImplement
{
    public class Connection : IConnection
    {
        private string _connectionString;

        // TODO: make private
        public Connection()
        {
        }

        public Connection(string connectionString)
        {
            _connectionString = connectionString;
        }

        public void Open()
        {
            Debug.WriteLine($"Connection({GetHashCode()})#Open called : {_connectionString}");

            ServiceLocator.Current.GetInstance<Model>().ModelMethod();
        }
    }
}