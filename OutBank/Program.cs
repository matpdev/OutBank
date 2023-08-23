using System.IO;
using OutBank;

namespace Start
{
    class StartSystem
    {
        static Login login = new Login();

        private static void Main()
        {
            login.LoginUser();
        }
    }
}
