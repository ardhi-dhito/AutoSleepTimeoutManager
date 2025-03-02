using AutoSleepTimeoutManager.Services;

class Program
{
    static void Main()
    {
        Console.WriteLine("Masukkan nilai sleep timeout (dalam menit):");
        if (int.TryParse(Console.ReadLine(), out int timeout) && timeout >= 0)
        {
            SleepTimeoutConfigurationService.SetSleepTimeout(timeout);
            Console.WriteLine($"Sleep timeout berhasil diubah menjadi {timeout} menit.");
        }
        else
        {
            Console.WriteLine("Input tidak valid. Masukkan angka yang benar.");
        }
    }
}
