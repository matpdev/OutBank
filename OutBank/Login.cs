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

            if (email== "matheus2ep@gmail.com" && password== "Matheu123th@")
            {
                Console.WriteLine("Logado com Sucesso");
                return 1;
            } else
            {
                return 0;
            }
		}

        public bool searchEmail(String email)
        {

            return false;
        }
	}
}

