using System.Diagnostics;
using LibraryInterface;

namespace LibraryImplement
{
    public class Connection : IConnection
    {
        public void Open()
        {
            Debug.WriteLine($"Connection#Open called");
        }
    }
}