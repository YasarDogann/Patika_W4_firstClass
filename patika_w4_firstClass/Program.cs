namespace patika_w4_firstClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person teacher = new Person();//Person class'ından bir nesne oluşturduk ve buna öğretmen dedik

            teacher.Name = "Okan";
            teacher.Surname = "Buruk";
            teacher.BirthDay = new DateTime(1993,02,19);

            teacher.PersonInfo();//öğretmen nesnesinin bilgilerini konsola yazdırıcaz

            Console.WriteLine("---------------------------------");

            Person student1 = new Person(); //Person class'ından bir nesne oluşturduk ve buna öğrenci1 dedik

            student1.Name = "Yaşar";
            student1.Surname = "Doğan";
            student1.BirthDay = new DateTime(2001, 04, 08);
            student1.PersonInfo(); //öğrenci1'in bilgilerini yazdıracak

            Console.WriteLine("---------------------------------");

            Person student2 = new Person();//Person class'ından bir nesne oluşturduk ve buna öğrenci2 dedik
            student2.Name = "Mauro";
            student2.Surname = "Icardi";
            student2.BirthDay = new DateTime(1993, 02, 019);
            student2.PersonInfo();//öğrenci1'in bilgilerini yazdıracak
        }
    }
}
