// Hər bir konsol proqramının giriş nöqtəsi Main() metodu ilə başlayır.

// Main metodu işini bitirdikdən sonra bu metoddan geriyə şərti olaraq nəticə qaytarmaq mümkündür.

// Main metodunun qaytardığı nəticə ancaq int tipində olmalıdır.

// Bir qayda olaraq, Main() metodundan nəticənin qaytarılması proqramın normal işini görün bitirdiyini göstərir.
// Şərti olaraq Main() metodundan 0 dəyərinin qaytarılması proqramın normal işini bitirdiyinə dəlalət verir. Digər bütün cavablar isə proqramda yaranmış xətadan xəbər verir.

namespace Methods
{
    class Program
    {
        static int Main()
        {
            Console.WriteLine("Hello world!");

            // Delay.
            Console.ReadKey();

            return 0;
        }
    }
}
