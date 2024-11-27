using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DataBaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crud-->Create-Read-Update-Delete

            Console.WriteLine("***** Menü Sipariş İşleme Paneli");
            Console.WriteLine();

            Console.WriteLine("----------------------");
            #region Kategory ekleme işlemi
            //Console.Write("Eklemek İstediğiniz Kategori Adı: ");
            //string categoryName=Console.ReadLine();
            //SqlConnection connection = new SqlConnection("Data Source=MSI;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();
            //SqlCommand command=new SqlCommand("insert into TblCategory (CategoryName) values(@p1)",connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Kategory Başarıyla Eklendi...");
            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;
            ////bool productStatus;

            //Console.WriteLine("Ürün adı: ");
            //productName =Console.ReadLine();
            //Console.WriteLine("Ürünün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MSI;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct (ProductName,ProductPrice,ProductStatus) values(@ProductName,@ProductPrice,@ProductStatus)", connection);

            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus",true);
            //command.ExecuteNonQuery();
            //connection.Close();
            //Console.WriteLine("Ürün eklemesi başarılı...");

            #endregion

            #region Ürün listeleme işlemi

            //SqlConnection connection = new SqlConnection("Data Source=MSI;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct",connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);//verileri sqlden c#'a çeker
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows)
            //{
            //    foreach (var item in row.ItemArray)
            //    {
            //        Console.Write(item.ToString() + " ");
            //    }
            //    Console.WriteLine();
            //}
            //connection.Close();

            #endregion

            #region Ürün silme işlemi

            //Console.WriteLine("Silinecek ürün ıd: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MSI;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı...");

            #endregion


            #region Ürün güncelleme işlemi

            //Console.Write("Güncellenecek ürünün ıd: ");
            //int productId=int.Parse(Console.ReadLine());
            //Console.Write("Güncellenecek ürünün adı: ");
            //string productName=Console.ReadLine();
            //Console.Write("Güncellenecek ürünün fiyatı: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=MSI;initial catalog=EğitimKampıDB;integrated security=true");
            //connection.Open();
            //SqlCommand command=new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice Where ProductId=@productId",connection);
            //command.Parameters.AddWithValue("@productName",productName);
            //command.Parameters.AddWithValue("@productPrice",productPrice);
            //command.Parameters.AddWithValue("@productId",productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Güncelleme başarılı...");

            #endregion

            Console.Read();
        }
    }
}
