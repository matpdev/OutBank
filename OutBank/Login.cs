using System;
using System.Collections.Generic;

namespace OutBank
{
    public class Login
    {
        DB db = new DB();
        public int LoginUser()
        {
            Console.WriteLine("Seja bem vindo ao OutBank!");
            Console.WriteLine("Por favor, digite seu email");
            String email = Console.ReadLine();
            Console.WriteLine("digite sua senha");
            String password = Console.ReadLine();

            db.ConnectToDB();

            Console.WriteLine("Logado com Sucesso");
            db.insertUser(email, password);
            db.searchUser(email, password);
            return 1;
        }

        public bool searchEmail(String email)
        {

            return false;
        }
    }
}

