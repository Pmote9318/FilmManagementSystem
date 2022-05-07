using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMSBuisnessLayer;
using FMSEntityLayer;
using FMSExceptionLayer;

namespace FilmManagementSystem
{
    internal class Program
    {
        enum LogInCredentialMenu
        {
            LogIn,
            SignUp,
            GoToMainMenu
        }
        enum Menu
        { 
            
            Film,
            Category,
            Actor,
            FilmLangauage,
            Exit

        }
        enum FilmMenu
        {
            abcd,
            CreateFilm,
            ModifyFilm,
            DeleteFilm,
            DisplayFilm,
            SaveFilm,
            SearchFilm,
            GoToMainMenu

        }
        enum CategoryMenu
        {

            CreateCategory,
            SearchbyCategory,
            GoToMainMenu

        }
        enum ActorMenu
        {

            CreateActor,
            SearchbyActor,
            GoToMainMenu

        }
        //enum FilmActorMenu
        //{
        //    CreateFilmActor,
        //    SearchFilmActor,
        //    GoToMainMenu
        //}
        enum FilmLanguageMenu
        {

            CreateFilmLanguage,
            SearchbyFilmLanguage,
            GoToMainMenu

        }
        //enum FilmDubbedLangMenu
        //{
        //    CreateFilmDubbedLang,
        //    SearchFilmDubbedLang,
        //    GoToMainMenu
        //}
        public static void Main()
        {
            new Program();
        }
        public Program()
        {
            string ans = "ÿ";
            do
            {
                MainMenu();
                Console.WriteLine("do you wanna continue(y/n)?");
                ans = Console.ReadLine();

            } while (ans == "y");

        }
        public void MainMenu()
        {
            string[] names = Enum.GetNames(typeof(Menu));

            string ans = "y";

            do
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{names[i]}");
                }
                Console.Write("Enter Your Choice::");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        UserCredentialsMenu();
                        break;


                    case 2:
                        //Film_Menu();
                        break;


                    case 3:
                       // Category_Menu();
                        break;


                    case 4:
                       // Actor_Menu();
                        break;

                    case 5:
                       // FilmActor_Menu();
                        break;


                    case 6:
                       // FilmLanguage_Menu();
                        break;


                    case 7:
                       // FilmDubbedLang_Menu();
                        

                        return;

                }
                Console.WriteLine("do you wanna continue(y/n)?");
                ans = Console.ReadLine();

            } while (ans == "y");

        }

        public void UserCredentialsMenu()
        {
            string[] names = Enum.GetNames(typeof(LogInCredentialMenu));

            string ans = "y";

            do
            {
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine($"{i + 1}.{names[i]}");
                }
                Console.Write("Enter Your Choice::");
                int ch = Convert.ToInt32(Console.ReadLine());

                switch (ch)
                {
                    case 1:
                        Login();
                        break;


                    case 2:
                        SignUp();
                        break;


                    case 3:
                        MainMenu();
                        break;


                }
                Console.WriteLine("do you wanna continue(y/n)?");

            } while (ans == "y");
        }

        public void Login()
        {

            try
            {
                Console.Write("Enter Type of User: ");
                string usertype = Console.ReadLine();

                Console.Write("Enter a Username: ");
                string username = Console.ReadLine();


                Console.Write("Enter Password: ");
                string password = Console.ReadLine();


                LoginCredentials newLoginCredentials = new LoginCredentials()
                {
                    TypeOfUser = usertype,
                    Username = username,
                    PasswordForLogin = password
                };
                LoginCredentialBL loginCredentialBL = new LoginCredentialBL();
                if (loginCredentialBL.Login(newLoginCredentials))
                    Console.WriteLine("Loged In Successfully");
                else
                    Console.WriteLine("Sorry!!!LogIn Failed ");
            }
            catch (PasswordException pe)
            {
                Console.WriteLine(pe.Message);
            }
        }
        public void SignUp()
        {
            try
            {
                Console.Write("Enter Type of User: ");
                string usertype = Console.ReadLine();


                Console.Write("Enter a Username: ");
                string username = Console.ReadLine();


                Console.Write("Enter a Password: ");
                string password = Console.ReadLine();


                Console.Write("Confirm Your Password: ");
                string cpassword = Console.ReadLine();

                LoginCredentials newLoginCredentials = new LoginCredentials()
                {
                    TypeOfUser = usertype,
                    Username = username,
                    PasswordForLogin = password
                   
                };
                LoginCredentialBL loginCredentialBL = new LoginCredentialBL();
                if (password==cpassword)
                    Console.WriteLine("Password Created Successfully");
                else if (loginCredentialBL.SignUp(newLoginCredentials))
                    Console.WriteLine("Signed Up Successfully");
                else
                    Console.WriteLine("Sorry!!!SignUp failed ");
            }
            catch (PasswordException pe)
            {
                Console.WriteLine(pe.Message);
            }

        }

    }

}
