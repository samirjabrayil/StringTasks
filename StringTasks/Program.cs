
namespace StringTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Task 1 (Sezar sifrelenmesini ve desifrelenmesini eden metodlar) 
            //Console.WriteLine(Ceaser.CeaserMethods());
            #endregion

            #region Task 2 (Vaxtlar arasinda ferq)
            var time = new TimeDifference();

            Console.Write("Ilkin vaxti daxil edin:");
            string time1 = Console.ReadLine();
           
            Console.Write("Sonuncu vaxtini daxil edin:");
            string time2 = Console.ReadLine();

            var tdiff = time.DiffTime(time1, time2);
            



            #endregion



        }
    }
}