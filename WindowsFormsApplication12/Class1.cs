using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;

namespace WindowsFormsApplication12
{
    class ReadAd
    {
        /*
        public DirectoryEntry AD;
        private string _path;
        private string _filterAttribute;

        public void getBranch(string path)

        {
            _path = path;

        }

        public bool IsAuthenticated(string domain, string username, string pwd)
        {
            string domainAndUsername = domain + @"\" + username;
            DirectoryEntry entry = new DirectoryEntry(_path, domainAndUsername, pwd);
            try
            {
                Object obj = entry.NativeObject;
                DirectorySearcher search = new DirectorySearcher(entry);
                search.Filter = "(SAMAccountName=" + username + ")";
                search.PropertiesToLoad.Add("cn");
                SearchResult result = search.FindOne();
                if (null == result)
                {
                    Console.WriteLine("не верный логин или пароль");
                    return false;

                }
                _path = result.Path;
                _filterAttribute = (String)result.Properties["cn"][0];
            }
            catch
            {
                Console.WriteLine("не верный логин или пароль");
                return false;
            }
            Console.WriteLine("успешная авторизация");
            return true;
        }
        */
    }
}

