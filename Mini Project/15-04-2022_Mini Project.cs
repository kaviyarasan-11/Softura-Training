using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Linq;

namespace SimpleActivity
{
    class Bill
    {
        SqlConnection con = new SqlConnection("Data source = DESKTOP-R2O6G8R; database = trail; integrated security = true ");
        public void Customers()
        {
            Console.WriteLine("Enter the CustomerID:");
            int CustID = Convert.ToInt32(Console.ReadLine());
            //SqlConnection con = new SqlConnection("Data source = DESKTOP-R2O6G8R; database = trail; user id = sa; password = P@ssw0rd");
            string oldcustomer = "select * from Customers_table where CustomerID =" + CustID + "";
            SqlCommand cmd2 = new SqlCommand(oldcustomer, con);
            con.Open();
            SqlDataReader Sqldr = cmd2.ExecuteReader();
            while (Sqldr.Read())
            {
                Console.WriteLine("CustomerID : " + Sqldr[0] + " " + "CustomerName : " + Sqldr[1] + " " + "Gender :" + Sqldr[2] + " " + "DateOfBirth: " + Sqldr[3] + " " + "ContactNO: " + Sqldr[4] + " " + "EmailId: " + Sqldr[5] + "  " + "City" + Sqldr[6]);
            }
            Bill obj = new Bill();
             obj.Products();
            con.Close();

        }
        public void Products()
        {
            string Product = "Select *from Product_table";
            SqlCommand cmd = new SqlCommand(Product, con);
            con.Open();
            SqlDataReader Sqldr = cmd.ExecuteReader();
            while (Sqldr.Read())
            {
                Console.WriteLine("ProductID : " + Sqldr[0] + " " + "ProductName : " + Sqldr[1] + "  " + "Price : " + Sqldr[2] + "  " + "DateOfManfacture : " + Sqldr[3] + "  " + "ExpiryDate : " + Sqldr[4]);
            }
            con.Close();
        }

        public void NewCustomer()
        {
            Console.WriteLine(" Please Enter Your name:");
            string CustomerName = Console.ReadLine();
            Console.WriteLine("Please Enter your Gender:");
            string Gender = Console.ReadLine();
            Console.WriteLine("Please Enter Your DateOfBirth:");
            string DateOfBirth = Console.ReadLine();
            Console.WriteLine("Please Enter Your ContactNo:");
            string ContactNo = Console.ReadLine();
            Console.WriteLine("Please Enter Your EMailID:");
            string EmailID = Console.ReadLine();
            Console.WriteLine("Please Enter your City:");
            string City = Console.ReadLine();
            string CustomerDetails = "insert Customers_table(CustomerName,Gender,DateOfBirth,ContactNo,EmailID,City) values('" + CustomerName + "','" + Gender + "','" + DateOfBirth + "','" + ContactNo + "','" + EmailID + "','" + City + "')";
            SqlCommand cmd = new SqlCommand(CustomerDetails, con);
            con.Open();
            cmd.ExecuteNonQuery();
            Console.WriteLine("Thanks And Your Details inserted Successfully");
            SqlDataReader Sqldr = cmd.ExecuteReader();
            while (Sqldr.Read())
            {
                SqlConnection con1 = new SqlConnection("Data source = DESKTOP-R2O6G8R; database = trail; user id = sa; password = P@ssw0rd");
                SqlCommand cmd4 = new SqlCommand("select *  from Customers_table", con);
                con1.Open();
                SqlDataReader dr1 = cmd4.ExecuteReader();
                while (Sqldr.Read())
                {
                    Console.WriteLine("Your new CustomerID is: " + dr1[0]);
                }
                con1.Close();
            }
            Console.WriteLine();
            Bill obj1 = new Bill();
            obj1.Products();
            con.Close();
        }
        public void purchases()
        {
            Console.WriteLine("Enter Your CustomerID:");
            string customer = Console.ReadLine();
            Console.WriteLine("Enter the ProductID:");
            string purchase = Console.ReadLine();
            Console.WriteLine("Enter the Quantity:");
            int Qn = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = new SqlConnection("Data source = DESKTOP-R2O6G8R; database = trail; user id = sa; password = P@ssw0rd");
            SqlCommand cmd5 = new SqlCommand("select Price* " + Qn + " from Product_table where ProductID = " + purchase + "", con);
            con.Open();
            SqlDataReader dr2 = cmd5.ExecuteReader();
            while (dr2.Read())
            {

                int Total = Convert.ToInt32(dr2[0]);
                Console.WriteLine("Total Amount :  " + Total);
                string purins = "insert Purchases_table (CustomerID,ProductID,Quantity,TotalAmount) values (" + customer + "," + purchase + "," + Qn + "," + Total + ")";
                SqlConnection con1 = new SqlConnection("Data source = DESKTOP-R2O6G8R; database = trail; user id = sa; password = P@ssw0rd");
                SqlCommand cmd6 = new SqlCommand(purins, con1);
                con1.Open();
                cmd6.ExecuteNonQuery();
                Console.WriteLine("Your Purchase details Inserted Successfully");
                con1.Close();
            }
            con.Close();
        }
        public void PurchaseShow()
        {
            Console.WriteLine();
            Console.WriteLine("Enter your CustomerID:");
            string customer = Console.ReadLine();
            SqlConnection con = new SqlConnection("Data source = DESKTOP-R2O6G8R; database = trail; user id = sa; password = P@ssw0rd");
            string purchase = "select  CustomerID,Purtab.ProductID,ProductName,Price,Quantity,TotalAmount from Product_table Pt join Purchases_table Purtab on pt.ProductID = Purtab.ProductID where CustomerID=" + customer + "";
            SqlCommand cmd7 = new SqlCommand(purchase, con);
            con.Open();
            SqlDataReader dr = cmd7.ExecuteReader();

            while (dr.Read())
            {
                Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
        public void Date()
        {
            Console.WriteLine("Enter the Date:");
            var Date = Convert.ToString(Console.ReadLine());
            SqlConnection con = new SqlConnection("Data source = DESKTOP-R2O6G8R; database = trail; user id = sa; password = P@ssw0rd");
            string purch = "select  CustomerID,Purtab.ProductID,ProductName,Price,Quantity,TotalAmount,purdate from Product_table pt join Purchases_table Purtab on pt.ProductID = Purtab.ProductID where purdate='" + Date + "'";
            SqlCommand cmd = new SqlCommand(purch, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("                                  PURCHASE INFORMATION By Using Date");
            while (dr.Read())
            {
                //Console.WriteLine("                                        PURCHASE INFORMATION ");
                Console.WriteLine("CustomerID : " + dr[0] + " " + "ProductID : " + dr[1] + " " + "ProductName : " + dr[2] + " " + "Price : " + dr[3] + " " + "Quantity : " + dr[4] + " " + "TotalAmount : " + dr[5]);
            }
            con.Close();
        }
        public static void Main()
        {
            Bill obj = new Bill();
            Console.WriteLine("If Your Already Customer Enter (Yes/No) OR Are You Want your Details Enter Click");
            string Ma = Console.ReadLine();
            //obj.NewCustomer();
            //obj.Customers();
            switch (Ma)
            {
                case "Click":
                    obj.Customers();
                    break;
                case "Yes":
                    obj.Products();
                    break;
                case "No":
                    obj.NewCustomer();
                    break;
            }

            obj.purchases();
            obj.PurchaseShow();
            obj.Date();
        }
    }
}
