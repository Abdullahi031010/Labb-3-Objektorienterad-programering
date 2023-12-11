namespace Labb_3_Objektorienterad_programering
{
    public class Program
    {
        static void Main(string[] args)
        {

            Hair HAIR = new Hair { hairLength = "25 cm ", hairColor = "Blond" };
            Gender gender = Gender.Women;
            string eyeColor = new string("Blue");
            DateTime Birthday = new DateTime(2003, 10, 10);

            Person person = new Person(Birthday, eyeColor, gender, HAIR);
            Console.WriteLine(person.ToString());   
        }
    }
}