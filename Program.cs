using IDF_Operation.Models;

namespace IDF_Operation.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            F16 f16_1 = new F16(120, "israel");
            f16_1.FuelUsing( 20);
            f16_1.DataPriting();
        }
    }

}