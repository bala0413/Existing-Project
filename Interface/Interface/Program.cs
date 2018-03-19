using System;

namespace Social
{
    public interface ISocialNetwork
    {
        int Id { get; set; }
        string EmailAddress { get; set; }
        void Login();
        void Post();
    }

    class SocialNetwork
    {
        public int Id { get; set; }
        public string EmailAddress { get; set; }
        public string UserMail { get; set; }
        public string Message { get; set; }
        public string Url { get; set; }
    }
      
        class Facebook:SocialNetwork, ISocialNetwork
    {
            public void Login()
            {
                UserMail = "balachandran@fb.com";
                Console.WriteLine("\nFacebook");
                if (UserMail == EmailAddress)
                {
                    Console.WriteLine("\nLogin Successful");
                    Console.WriteLine("Facebook Login Mail Id is:" + EmailAddress);
                }
                else
                {
                    Console.WriteLine("User Invalid");
                }
            }
            public void Post()
            {
                Console.WriteLine("User Facebook messaage is: " + Message);
            }
        }


        class Twitter : SocialNetwork, ISocialNetwork
    {
            public void Login()
            {
                UserMail = "balachandran@tw.com";
                Console.WriteLine("\nTwitter");
                if (UserMail == EmailAddress)
                {
                    Console.WriteLine("\nLogin Successful");
                    Console.WriteLine("Twitter Login Mail Id is:" + EmailAddress);
                }
                else
                {
                    Console.WriteLine("User Invalid");
                }
            }
            public void Post()
            {
                Console.WriteLine("User Twitter messaage is: " + Message);
            }
        }


        class GooglePlus : SocialNetwork, ISocialNetwork
    {
            public void Login()
            {
                UserMail = "balachandran@gp.com";
                Console.WriteLine("\nGoogle+");
                if (UserMail == EmailAddress)
                {
                    Console.WriteLine("\nLogin Successful");
                    Console.WriteLine("Google+ Login Mail Id is:" + EmailAddress);
                }
                else
                {
                    Console.WriteLine("User Invalid");
                }
            }
            public void Post()
            {
                Console.WriteLine("User Google+ messaage is: " + Message);
            }
        }

        class program
        {
            static void Main(string[] args)
            {
                           
                Facebook  objFb = new Facebook ();
                Console.WriteLine("\nEnter the Email Address");
                objFb.EmailAddress = (Console.ReadLine());
                objFb.Login();
                Console.WriteLine("Enter the Message");
                objFb.Message = (Console.ReadLine());
                objFb.Post();

                Twitter  objTw = new Twitter ();
                Console.WriteLine("\nEnter the Email Address");
                objTw.EmailAddress = (Console.ReadLine());
                objTw.Login();
                Console.WriteLine("Enter the Message");
                objTw.Message = (Console.ReadLine());
                objTw.Post();

                GooglePlus  objGs = new GooglePlus ();
                Console.WriteLine("\nEnter the Email Address");
                objGs.EmailAddress = (Console.ReadLine());
                objGs.Login();
                Console.WriteLine("Enter the Message");
                objGs.Message = (Console.ReadLine());
                objGs.Post();               

                Console.ReadLine();
            }

        }
    }
