﻿namespace LoginÖvining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AppRun();
        }
        static void AppRun()
        {
            LoginManager login = new LoginManager();
            //Kom ihåg antal loginförsök
            bool isSucsess;
            int attempts = 0;
            do
            {
                Console.WriteLine("Användarnamn");
                string userName = Console.ReadLine();
                Console.WriteLine("Lösenord");
                string passWord = Console.ReadLine();

                isSucsess = login.Login(userName, passWord);
                if (isSucsess)
                {
                    Console.WriteLine("Du loggade in");
                }
                else
                {
                    Console.WriteLine("Fel användarnamn eller lösenord");
                    attempts++;
                }
                if(attempts >= 3)
                {
                    Console.WriteLine("För många försök. Försök igen senare");
                    Environment.Exit(0);
                }
            } while (!isSucsess);
        }
    }
}