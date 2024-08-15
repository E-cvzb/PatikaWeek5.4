// See https://aka.ms/new-console-template for more informationwhile()
using PatikaWeek5._4;

bool control=false;// döngü için control false tanımladım 

while (!control)// control true olduğunda döngüden çıkar 
{
    try
    {
        Console.WriteLine("Lütfen bir sayı giriniz.");
        int number = Convert.ToInt16(Console.ReadLine());
        Console.WriteLine(Math.Pow(number,2));//sayının karesi alınma işlemi 
        control = true;
    }

    catch (FormatException ex )
    {

        Console.WriteLine("Hatalı giriş yaptınız lütfen sayı giriniz");// metin ve ya sembol girdiğinde verilecek uyarı
    }
    catch(OverflowException ex)
    {
        throw new MyException("Lütfen daha büyük ya da daha küçük bir sayı giriniz ");// int 16 ın değer aralığının dışındaki değerler için verilecek uyarı
    } 
    // Her koşulda verilecek mesaj
    finally
    {
        Console.WriteLine("İşlemleriniz tamamlandı");
    }
}
