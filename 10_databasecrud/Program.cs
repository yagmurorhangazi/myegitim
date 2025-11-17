using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_databasecrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** MENÜ İŞLEM PANELİ *****");
            Console.WriteLine();

            #region
            /* Console.WriteLine("-------------------------------");
            Console.WriteLine("GİRMEK İSTEDİĞİNİZ KATEGORİ ADI NEDİR:");
            String categoriadi = Console.ReadLine();

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-S23DBBK\\SQLEXPRESS; initial catalog=EgitimkampiDb;integrated security=true ");

            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblcategory (CategoryName) values (@p1)" ,  connection);
            command.Parameters.AddWithValue("@p1", categoriadi);
            command.ExecuteNonQuery();
            connection.Close();

            Console.Write("kategori başarıyla eklendi");*/
            #endregion

            #region
            /*string productname;
            decimal productprice;
            //bool status;

            Console.Write("ürün adı:");
            productname = Console.ReadLine();
            Console.Write("fiyatını giriniz:");
            productprice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-S23DBBK\\SQLEXPRESS; initial catalog=EgitimkampiDb;integrated security=true ");

            connection.Open();
            SqlCommand command = new SqlCommand("insert into tblproduct (ProductName,ProductPrice,ProductStatus) values (@p1,@p2,@p3)" ,  connection);
            command.Parameters.AddWithValue("@p1", productname);
            command.Parameters.AddWithValue("@p2", productprice);
            command.ExecuteNonQuery();
            connection.Close();


             

            Console.WriteLine("ürün eklemesi başarılı");*/
            #endregion

            #region
            /*
             SqlConnection connection = new SqlConnection("Data Source= DESKTOP-S23DBBK\\SQLEXPRESS;Initial Catalog= EgitimkampiDb; Integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From tblproduct", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
           
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.WriteLine(item.ToString());
                }
            }

            connection.Close();
            */
            #endregion

            #region
            /* Console.Write("silinecek olan satırı gir");
             int sayi=int.Parse(Console.ReadLine());

             SqlConnection connection = new SqlConnection("Data Source = DESKTOP-S23DBBK\\SQLEXPRESS; initial catalog=EgitimkampiDb;integrated security=true ");

             connection.Open();
             SqlCommand command = new SqlCommand("Delete From tblproduct Where ProductId=@ProductId", connection);
             command.Parameters.AddWithValue("@productId",sayi);
             command.ExecuteNonQuery();
             connection.Close();

             Console.WriteLine("sİLME İŞLEMİ YAPILDI");
            */








            #endregion

            #region

#region
            Console.Write("GÜNCELLEMEK İSTEDİĞİNİZ ÜRÜN ID:");
            int productıd = int.Parse(Console.ReadLine());

            Console.WriteLine("GÜNCELLEMEK İSTEDİĞİNİZ ÜRÜN ADI:");
            String productname = Console.ReadLine();

            Console.Write("GÜNCELLENECEK ÜRÜN FİYATI:");
            decimal productprice = decimal.Parse(Console.ReadLine());

            SqlConnection connection = new SqlConnection("Data Source = DESKTOP-S23DBBK\\SQLEXPRESS; initial catalog=EgitimkampiDb;integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Update tblproduct Set ProductName=@productName,ProductPrice=@productPrice where ProductId=@productId", connection);
            command.Parameters.AddWithValue("@productName", productname);
            command.Parameters.AddWithValue("@productPrice", productprice);
            command.Parameters.AddWithValue("@productId", productıd);
            command.ExecuteNonQuery();
            connection.Close();

            Console.WriteLine("güncelleme başarılı");

            #endregion


















        }
    }
}
