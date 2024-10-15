# Patika+ Week4 İlk Class Uygulaması
Merhaba,
Bu proje C# ile Patika+ 4.hafta ilk sınıf oluşturma için yapılmış bir uygulamadır.

## 📚 Proje Hakkında
Bu proje, aşağıdaki konuları öğrenmeye yardımcı olmak için tasarlanmıştır:
- Basit bir C# programı yazmak
- C# konsol uygulamasının yapısını anlamak
- Method kullanımı ve yapısını anlamak.
- Class yapısını anlamak
- Encapsulation yapısını öğrenmek 


## Kod
```csharp
 public class Person //sınıf oluşturduk
 {
     //Fields
     private string name;  
     private string surname;
     private DateTime birthDay;

     //encapsulation
     public string Name
     {
         get { return name; }
         set { name = value; }
     }

     public string Surname
     {
         get { return surname; }
         set { surname = value; }
     }

     public DateTime BirthDay
     {
         get { return birthDay; }
         set { birthDay = value; }
     }


     public void PersonInfo() //personel bilgi için method
     {
         Console.WriteLine($"Adı: {name}\r\nSoyadı: {surname}\r\nDoğum Tarihi: {birthDay.ToString("dd.MM.yyyy")}");
     }
 }
```
Person sınıfı oluşturuldu. Özellikler private olarak tanımlandı ve kapsülleme ile veriler alındı. Daha sonr bilgileri ekrana yazdırmak için Method oluşturuldu.

```csharp
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
```
Main method içinde sınıftan nesneler oluşturuldu ve ilgili sınıf'ın bilgileri yazdır methodu kullanılarak ekrana çıktı alındı.




