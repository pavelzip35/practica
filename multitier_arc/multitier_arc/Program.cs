using System;

namespace Prog
{
    class User
    {
        public Guid id;
        public string Nickname;
    }



    class Program
    {

        static User GetUser()
        {
            User user = new User();

            user.id = Guid.NewGuid();

            while (true)
            {

                user.Nickname = "@" + Console.ReadLine();
                if (!user.Nickname.Contains(' '))
                {
                    break;
                }


            }

            return user;

        }

        /*static void adding(string[] arg,)
        {
            args.Add();
        }*/

        static void Main(string[] args)
        {
            var Iuser = GetUser();

            private List<string> users = new List<string>() { };
            users.Add(Iuser);
        }

            
    }
}




