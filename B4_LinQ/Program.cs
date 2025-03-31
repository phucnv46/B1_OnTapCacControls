using B4_LinQ.Models;
using System.Text.Json;
using System.Text.Unicode;

namespace B4_LinQ
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            using (TutorNet10212Context context = new TutorNet10212Context())
            {
                List<TraiCay> traiCays = context.TraiCays.ToList();
                /*foreach (var traiCay in traiCays)
                {
                    Console.WriteLine($"{traiCay.TenTraiCay}");
                }*/

                // linq có 2 dạng query, expression(method)
                //query
                // sql => where

                //Query
                /* List<TraiCay> taos = (from traiCay in traiCays where traiCay.TenTraiCay.
                                       Contains("Táo",StringComparison.OrdinalIgnoreCase)
                                       select traiCay
                                       ).ToList();

                 foreach (var tao in taos)
                 {
                     Console.WriteLine($"{tao.TenTraiCay}");
                 }*/

                //Expression (Method)
                //Func(Traicay,bool) <=> delegate bool Predicate(Traicay);
                List<TraiCay> taos = traiCays.
                    Where(tc=>tc.TenTraiCay.Contains("Táo",StringComparison.OrdinalIgnoreCase)).ToList();
                //Arrow function

                //First trả về phần tử đầu tiên thoả mãn điều kiện
                //Last trả về phần tử cuối cùng thoả mãn điều kiên

                TraiCay taoDau = traiCays.First(tc => tc.TenTraiCay.Contains("Táo", StringComparison.OrdinalIgnoreCase));
                TraiCay taoCuoi = traiCays.Last(tc => tc.TenTraiCay.Contains("Táo", StringComparison.OrdinalIgnoreCase));

                Console.WriteLine($"quả táo là {taoDau.TenTraiCay}\n quả táo cuối là {taoCuoi.TenTraiCay}");

                TraiCay timBangKey = context.TraiCays.Find("BER003");
                Console.WriteLine($"Mã trái cây:{timBangKey.MaTraiCay},tên: {timBangKey.TenTraiCay}");

                //Any , All,Select ...
            }
        }
    }
}
