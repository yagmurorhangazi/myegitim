using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_database
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** C# Veri Tabanlı Ürün-Kategori Sistemi ****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış yap");
            Console.Write("Lütfen girmek istediğiniz tablo numarını giriniz:");
            String tablenumber = Console.ReadLine();
            Console.WriteLine("---------------------------------------");

            SqlConnection connection = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog= EgitimkampiDb; Integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From tblcategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }



                 


        }
    }
}
