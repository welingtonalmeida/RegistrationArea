using RegistrationArea.Business;
using RegistrationArea.Business.Interfaces;
using RegistrationArea.Business.Model;
using RegistrationArea.Repository;
using RegistrationArea.Repository.Entiess;
using System;


namespace RegistrationArea.ConsoleApplication
{
    class Program
    {
        private static IAgeCalculator ageCalculator;
        private static ISignCalculator signCalculator;
        private static ILegalAge legalAge;
        private static IIdentifierNationality identifierNationality;

        static Program()
        {
            ageCalculator = new AgeCalculator();

            signCalculator = new SignCalculator();

            legalAge = new LegalAge();

            identifierNationality = new IdentifierNationality();
        }

        static void Main(string[] args)
        {
            string menuPrimario = "0";
            while (menuPrimario != "5")
            {
                Console.WriteLine("Is it an individual, or a legal Person, or consult what you already have in the database?");

                Console.WriteLine("\n");
                Console.WriteLine("Type 1 to physical Person ");
                Console.WriteLine("Type 2 to legal Person ");
                Console.WriteLine("Type 3 to see what is already in the database? ");
                Console.WriteLine("Type 5 to Exit ");

                menuPrimario = Console.ReadLine();

                if (menuPrimario == "1")
                {

                    ReturnPhysicalPerson();
                }
                else if (menuPrimario == "2")
                {

                    ReturnLegalPerson();
                }
                else if (menuPrimario == "3")
                {
                    string menuSecundario = "0";

                    while (menuSecundario != "5")
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Type 1 list Sign ");
                        Console.WriteLine("Type 2 list Client ");
                        Console.WriteLine("Type 3 list Festival ");
                        Console.WriteLine("Type 4 list Tickets ");
                        Console.WriteLine("Type 5 to Exit ");
                        Console.WriteLine("Type 6 to insert Sign ");
                        Console.WriteLine("Type 7 to update Sign ");
                        Console.WriteLine("Type 8 to delete Sign ");
                        Console.WriteLine("Type 9 to read all sign names? ");

                        menuSecundario = Console.ReadLine();

                        if (menuSecundario == "1")
                        {
                            SignRepository signRepositoryGetSigns = new SignRepository();

                            var list = signRepositoryGetSigns.GetSigns();

                            foreach (var sign in list)
                            {
                                Console.WriteLine("\n");
                               
                                Console.WriteLine("Sign name : " + sign.SignName);
                            }
                        }
                        else if (menuSecundario == "2")
                        {
                            ClientRepository clientRepository = new ClientRepository();

                            var list = clientRepository.GetSigns();



                            foreach (var client in list)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("Client Name is : " + client.ClientName);
                                Console.WriteLine("Client Cpf is : " + client.ClientCpf);
                                Console.WriteLine("Client Birth Date Is : " + client.ClientBirthDate);
                                Console.WriteLine("Client Coutry Origin is : " + client.ClientCoutryOrigin);
                            }

                        }
                        else if (menuSecundario == "3")
                        {

                        }
                        else if (menuSecundario == "4")
                        {

                        }
                        else if (menuSecundario == "5")
                        {
                            break;
                        }
                        else if (menuSecundario == "6")
                        {
                            SignRepository signRepositoryNew = new SignRepository();
                            string sigNew = Console.ReadLine();
                            bool success = signRepositoryNew.InsertSingn(new Repository.Entiess.HoroscopeSign { SignName = sigNew });

                        }
                        else if (menuSecundario == "7")
                        {
                            SignRepository signRepositoryListSignUpdate = new SignRepository();

                            var list = signRepositoryListSignUpdate.GetSigns();

                            HoroscopeSign horoscopeSign = new HoroscopeSign();

                            foreach (var sign in list)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("Sign id : " + sign.Id);
                                Console.WriteLine("Sign name : " + sign.SignName);
                            }
                            SignRepository signRepositoryUpdate = new SignRepository();

                            Console.WriteLine("Which id do you want to edit?");
                            string signIdUpdate = Console.ReadLine();

                            Console.WriteLine("Which sign name new ?");
                            string signNameUpdate = Console.ReadLine();
                            
                            int idUpdate = Convert.ToInt32(signIdUpdate);

                            bool success = signRepositoryUpdate.Update(new Repository.Entiess.HoroscopeSign { SignName = signNameUpdate, Id = idUpdate });

                        }
                        else if (menuSecundario == "8")
                        {
                            SignRepository signRepositoryListSignDelete = new SignRepository();

                            var list = signRepositoryListSignDelete.GetSigns();

                            HoroscopeSign horoscopeSign = new HoroscopeSign();

                            foreach (var sign in list)
                            {
                                Console.WriteLine("\n");
                                Console.WriteLine("Sign id : " + sign.Id);
                                Console.WriteLine("Sign name : " + sign.SignName);
                            }

                            SignRepository signRepositoryDelete = new SignRepository();

                            Console.WriteLine("Which id do you want to Delete?");
                            string signIdDelete = Console.ReadLine();
                            int idDelete = Convert.ToInt32(signIdDelete);

                            bool success = signRepositoryDelete.Delete(new Repository.Entiess.HoroscopeSign { Id = idDelete });

                        }
                       
                    }

                }

            }
        }

        private static void ReturnPhysicalPerson()
        {
            Person user = new User();
            string name, dateBirthDay, dateBirthMonth, dataBirthYear, countryOrigin, cadastroPessoaFisica;


            Console.WriteLine("type your name.");
            name = Console.ReadLine();
            Console.WriteLine("type your Cpf.");
            cadastroPessoaFisica = Console.ReadLine();
            Console.WriteLine("Enter date of birth.");

            Console.WriteLine("Day");
            dateBirthDay = Console.ReadLine();
            Console.WriteLine("Month");
            dateBirthMonth = Console.ReadLine();
            Console.WriteLine("Yaer");
            dataBirthYear = Console.ReadLine();
            Console.WriteLine("which country of origin.");
            countryOrigin = Console.ReadLine();

            int numeroDigitadoDateDay = Convert.ToInt32(dateBirthDay);
            int numeroDigitadoDateMonth = Convert.ToInt32(dateBirthMonth);
            int numeroDigitadoDateYear = Convert.ToInt32(dataBirthYear);

            user.Name = name;

            user.BirthDate = new DateTime(numeroDigitadoDateYear, numeroDigitadoDateMonth, numeroDigitadoDateDay);

            user.CoutryOrigin = countryOrigin;
            //Polimorfismo
            ((User)user).Cpf = cadastroPessoaFisica;


            Console.WriteLine(user.GetInfo());

            string menu = "0";

            while (menu != "5")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Type 1 For See my age");
                Console.WriteLine("Type 2 For See my sign");
                Console.WriteLine("Type 3 For See if i'm foreign");
                Console.WriteLine("Type 4 For See if i'm of legal age");
                Console.WriteLine("Type 5 to Exit ");

                menu = Console.ReadLine();

                if (menu == "1")
                {
                    int age = ageCalculator.ReturnAge(user);

                    Console.WriteLine("The user id " + cadastroPessoaFisica + " age is :" + age);
                }

                else if (menu == "2")
                {
                    string sig = signCalculator.ReturnSign(user);

                    Console.WriteLine("The sign is :" + sig);
                }
                else if (menu == "3")
                {
                    string nationality = identifierNationality.ReturnIndentifier(user);

                    Console.WriteLine(nationality);
                }
                else if (menu == "4")
                {
                    String legal = legalAge.ReturnLegalAge(user);

                    Console.WriteLine(legal);
                }

                else if (menu != "5")
                {
                    Console.WriteLine("Non existent Option");
                }

            }
        }

        private static void ReturnLegalPerson()
        {
            Person company = new Company();
            string name, dateBirthDay, dateBirthMonth, dataBirthYear, countryOrigin, cadastroPessoaJuridica;

            Console.WriteLine("type your name.");
            name = Console.ReadLine();
            Console.WriteLine("type your Cpf.");
            cadastroPessoaJuridica = Console.ReadLine();
            Console.WriteLine("Enter date of birth.");

            Console.WriteLine("Day");
            dateBirthDay = Console.ReadLine();
            Console.WriteLine("Month");
            dateBirthMonth = Console.ReadLine();
            Console.WriteLine("Yaer");
            dataBirthYear = Console.ReadLine();
            Console.WriteLine("which country of origin.");
            countryOrigin = Console.ReadLine();

            int numeroDigitadoDateDay = Convert.ToInt32(dateBirthDay);
            int numeroDigitadoDateMonth = Convert.ToInt32(dateBirthMonth);
            int numeroDigitadoDateYear = Convert.ToInt32(dataBirthYear);

            company.Name = name;

            company.BirthDate = new DateTime(numeroDigitadoDateYear, numeroDigitadoDateMonth, numeroDigitadoDateDay);

            company.CoutryOrigin = countryOrigin;

            // Polimorfismo
            ((Company)company).Cnpj = cadastroPessoaJuridica;

            Console.WriteLine(company.GetInfo());

            string menu = "0";

            while (menu != "5")
            {
                Console.WriteLine("\n");
                Console.WriteLine("Type 1 For See my age");
                Console.WriteLine("Type 2 For See my sign");
                Console.WriteLine("Type 3 For See if i'm foreign");
                Console.WriteLine("Type 4 For See if i'm of legal age");
                Console.WriteLine("Type 5 to Exit ");

                menu = Console.ReadLine();

                if (menu == "1")
                {
                    int age = ageCalculator.ReturnAge(company);


                    Console.WriteLine("The user id : " + cadastroPessoaJuridica + " age is :" + age);
                }

                else if (menu == "2")
                {
                    string sig = signCalculator.ReturnSign(company);

                    Console.WriteLine("The sign is :" + sig);
                }
                else if (menu == "3")
                {
                    string nationality = identifierNationality.ReturnIndentifier(company);

                    Console.WriteLine(nationality);
                }
                else if (menu == "4")
                {
                    String legal = legalAge.ReturnLegalAge(company);

                    Console.WriteLine(legal);
                }

                else if (menu != "5")
                {
                    Console.WriteLine("Non existent Option");
                }

            }
        }
    }
}

