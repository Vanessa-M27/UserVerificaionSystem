using UserVerficationSystem_DL;
using UserVerificaionSystem_Model;
using UserVerificationSystem_BL;
namespace UserVerificationSystem_UI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Username: ");
            string username = Console.ReadLine();

            Userbl userBl = new Userbl();
            bool result = userBl.VerifyUser(username);


            if (result)
            {
                Console.WriteLine("Log In Successfully");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

        }
    }
}
