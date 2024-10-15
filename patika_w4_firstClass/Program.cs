namespace patika_w4_firstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person teacher = new Person();

            teacher.Name = "Okan";
            teacher.Surname = "Buruk";
            teacher.BirthDay = new DateTime(1993,02,19);

            teacher.PersonInfo();

            Console.WriteLine("---------------------------------");

            Person student1 = new Person();

            student1.Name = "Yaşar";
            student1.Surname = "Doğan";
            student1.BirthDay = new DateTime(2001, 04, 08);
            student1.PersonInfo();

            Console.WriteLine("---------------------------------");

            Person student2 = new Person();
            student2.Name = "Mauro";
            student2.Surname = "Icardi";
            student2.BirthDay = new DateTime(1993, 02, 019);
            student2.PersonInfo();
        }
    }
}
