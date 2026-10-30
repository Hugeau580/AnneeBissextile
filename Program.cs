namespace annee_bissextile;

class Program
{
    static void Main(string[] args)
    {
        string answer;

        do
        {
            Console.WriteLine(" dit moi une année");
            int year = Convert.ToInt32(Console.ReadLine());
           

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("ton année est bisextille ");

            }
            else
            {

                Console.WriteLine("ton année n'est pas bisextille");
            }
            Console.WriteLine("veux tu une autre année ?");
            answer = Console.ReadLine();


        } while (answer == "oui");

            

        


        

        
        // Une application console qui indique si l’année (du calendrier grégorien. Par exemple, 2026) rentrée par l’utilisateur est bissextile ou non.
        // Les années bissextiles sont soit divisibles par 4 mais pas par 100, soit divisibles par 400.

    }
}