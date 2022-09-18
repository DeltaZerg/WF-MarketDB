using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace C_Project
{
    public partial class Form1 : Form
    {
        DB db = new DB();
        protected List<Customer> customers = new List<Customer>();
        static DirectoryInfo directory = new DirectoryInfo(@"C_Project\Check");
        FileInfo file = new FileInfo($@"{directory.FullName}\check.txt");
        private ColorDialog ColorDialog = new ColorDialog();
        public int red, green, blue;
        public Form1()
        {
            InitializeComponent();

            db.Customers.Load();
            db.Products.Load();
            db.Goods.Load();
            db.Managers.Load();
            db.Orders.Load();
            db.Users.Load();
            dataCustomers.DataSource = db.Customers.Local.ToBindingList();
            dataUsers.DataSource = db.Users.Local.ToBindingList();
            dataManagers.DataSource = db.Managers.Local.ToBindingList();
            dataOrders.DataSource = db.Orders.Local.ToBindingList();
            dataOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataOrders.ReadOnly = true;
            dataProducts.DataSource = db.Products.Local.ToBindingList();
            dataGoods.DataSource = db.Goods.Local.ToBindingList();
            dataGoods.ReadOnly = true;
            CheckButton.Hide();
            ReadSettings();

        }
        public void IC()
        {
            Product p1 = new Product() { Name = "Стремянка бытовая", Price = 276.0 };
            Product p2 = new Product() { Name = "Ведро малярованное", Price = 17.54 };
            Product p3 = new Product() { Name = "Хлебопечь", Price = 3201.0 };
            Product p4 = new Product() { Name = "Лампа - Энергосберегающая", Price = 7.0 };
            var c1 = new Customer() { Name = "ЧП Цветочек" };
            var c2 = new Customer() { Name = "ЧП Василёчек" };
            var c3 = new Customer() { Name = "ИП Бондарев" };
            var m1 = new Manager() { Name = "Иванов" };
            var m2 = new Manager() { Name = "Петров" };
            var m3 = new Manager() { Name = "Сидоров" };
            var o1 = new Order(c1, m1) { Id = 1, Date = new DateTime(2002, 12, 14) };
            var o2 = new Order(c2, m2) { Id = 2, Date = new DateTime(2012, 07, 15) };
            db.Users.Add(new User() { UserName = "Emik", Password = "qwerty" });
            db.Users.Add(new User() { UserName = "PartoC", Password = "12345" });
            db.Customers.Add(c1);
            db.Customers.Add(c2);
            db.Customers.Add(c3);
            db.Managers.Add(m1);
            db.Managers.Add(m2);
            db.Managers.Add(m3);
            db.Products.Add(p1);
            db.Products.Add(p2);
            db.Products.Add(p3);
            db.Products.Add(p4);
            db.Orders.Add(o1);
            db.Orders.Add(o2);
            db.Goods.Add(new Good(p1, o1) { Count = 5, Price = 276.0 });
            db.Goods.Add(new Good(p2, o2) { Count = 24, Price = 17.54 });

            db.SaveChanges();

        }
        private void CTU_Click(object sender, EventArgs e)
        {
            IC();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {

            switch (TabsControl.SelectedTab.Name)
            {
                case "CustomerTab": CreateCustomer createCustomer = new CreateCustomer(dataCustomers); createCustomer.Show(); break;
                case "ManagersTab": CreateManager createManager = new CreateManager(dataManagers); createManager.Show(); break;
                case "ProductsTab": CreateProduct createProduct = new CreateProduct(dataProducts); createProduct.Show(); break;
                case "OrdersTab":
                    CreateOrders createOrders = new CreateOrders(dataOrders);
                    createOrders.Show();
                    break;
                default: MessageBox.Show("Нельзя ничего создать"); break;
            } 
            //CreateCustomer form = new CreateCustomer(dataCustomers);
            //form.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            switch (TabsControl.SelectedTab.Name)
            {
                case "CustomerTab":
                    if (dataCustomers.CurrentRow == null) { return; }
                    var item = dataCustomers.CurrentRow.DataBoundItem as Customer;
                    bool IsDeletiable = true;
                    foreach (var staff in db.Orders)
                    {
                        if (item == staff.GetCustomer())
                        {
                            IsDeletiable = false;
                            break;
                        }
                    }

                    if (item == null) { return; }
                    if (IsDeletiable)
                    {
                        db.Customers.Remove(item);
                        db.SaveChanges();
                        db.Customers.Load();
                        dataCustomers.DataSource = db.Customers.Local.ToBindingList();
                    }
                    break;
                case "ManagersTab":
                    if (dataManagers.CurrentRow == null) { return; }
                    var item1 = dataManagers.CurrentRow.DataBoundItem as Manager;
                    bool IsDeletiable1 = true;
                    foreach (var staff in db.Orders)
                    {
                        if (item1 == staff.GetManager())
                        {
                            IsDeletiable1 = false;
                            break;
                        }
                    }

                    if (item1 == null) { return; }
                    if (IsDeletiable1)
                    {
                        db.Managers.Remove(item1);
                        db.SaveChanges();
                        db.Managers.Load();
                        dataCustomers.DataSource = db.Managers.Local.ToBindingList();
                    }
                    break;
                case "ProductsTab":
                    if (dataProducts.CurrentRow == null) { return; }
                    var item2 = dataProducts.CurrentRow.DataBoundItem as Product;
                    bool IsDeletiable2 = true;
                    foreach (var staff in db.Goods)
                    {
                        if (item2 == staff.GetProduct())
                        {
                            IsDeletiable2 = false;
                            break;
                        }
                    }

                    if (item2 == null) { return; }
                    if (IsDeletiable2)
                    {
                        db.Products.Remove(item2);
                        db.SaveChanges();
                        db.Products.Load();
                        dataProducts.DataSource = db.Products.Local.ToBindingList();
                    }
                    break;
                default: MessageBox.Show("Нельзя ничего создать"); break;
            }
            //if (dataCustomers.CurrentRow == null) { return; }
            //var item = dataCustomers.CurrentRow.DataBoundItem as Customer;
            //bool IsDeletiable = true;
            //foreach (var staff in db.Orders)
            //{
            //    if (item == staff.GetCustomer())
            //    {
            //        IsDeletiable = false;
            //        break;
            //    }         
            //}

            //if (item == null) { return; }
            //if (IsDeletiable)
            //{
            //    db.Customers.Remove(item);
            //    db.SaveChanges();
            //    db.Customers.Load();
            //    dataCustomers.DataSource = db.Customers.Local.ToBindingList();
            //}

        }

        private void ReductButton_Click(object sender, EventArgs e)
        {
            switch (TabsControl.SelectedTab.Name)
            {
                case "CustomerTab":
                    if (dataCustomers.CurrentRow == null) { return; }
                    var item = dataCustomers.CurrentRow.DataBoundItem as Customer;
                    if (item == null) { return; }
                    int id = item.Id;
                    string Name = item.Name;
                    ReductCustomer reductCustomer = new ReductCustomer(id, Name, dataCustomers);
                    reductCustomer.Show();
                    break;
                case "ManagersTab":
                    if (dataManagers.CurrentRow == null) { return; }
                    var item1 = dataManagers.CurrentRow.DataBoundItem as Manager;
                    if (item1 == null) { return; }
                    int id1 = item1.Id;
                    string Name1 = item1.Name;
                    ReductManager reductManager = new ReductManager(id1, Name1, dataManagers);
                    reductManager.Show();
                    break;
                case "OrdersTab":
                    if (dataOrders.CurrentRow == null) { return; }
                    var item2 = dataOrders.CurrentRow.DataBoundItem as Order;
                    if (item2 == null) { return; }
                    int id2 = item2.Id;
                    Manager manager = item2.GetManager();
                    Customer customer = item2.GetCustomer();
                    DateTime date = item2.Date;


                    ReductOrders reductOrders = new ReductOrders(id2, manager, customer, date, dataOrders, dataGoods);
                    reductOrders.Show();
                    break;
                case "ProductsTab":
                    if (dataProducts.CurrentRow == null) { return; }
                    var item3 = dataProducts.CurrentRow.DataBoundItem as Product;
                    if (item3 == null) { return; }
                    int id3 = item3.Id;
                    string Name3 = item3.Name;
                    double price = item3.Price;
                    ReductProduct reductProduct = new ReductProduct(id3, Name3, price, dataProducts);
                    reductProduct.Show();
                    break;
                default: MessageBox.Show("Нельзя ничего создать"); break;
            }
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {

            //!= dataGoods.Rows.Count)
            //if (directory.Exists)
            //{
            //    int orderId;
            //    try
            //    {
            //        orderId = Convert.ToInt32(dataOrders.SelectedRows[0].Cells[0].Value);
            //    }
            //    catch (IndexOutOfRangeException)
            //    {
            //        orderId = 1;
            //    }
            //    catch (ArgumentOutOfRangeException)
            //    {
            //        orderId = 2;
            //    }

            //        int totalsum = 0;

            //    using (StreamWriter writer = new StreamWriter(directory.FullName + @"\\check.txt", false))
            //    {
            //        writer.Write($"Поставщик: {dataOrders.SelectedRows[0].Cells[2].Value}\t\t\t\n"
            //            + $"Покупатель: {dataOrders.SelectedRows[0].Cells[3].Value}\n");
            //        foreach (var good in db.Goods.Where(p => p.Order == orderId))
            //        {
            //            writer.WriteLine($"Id {good.Id}\t Количество {good.Count}\t Цена {good.Price} \t Сумма {good.Sum}");
            //            totalsum += (int)(good.Price * good.Count);
            //        }
            //        writer.WriteLine("Итог:\t"+totalsum);
            //        MessageBox.Show("Чек был успешно создан");
            //    };

            //}
            //else
            //{
            //    Directory.CreateDirectory($@"{directory.FullName}");;

            //    if (directory.Exists)
            //    {
            //        MessageBox.Show("Директория создана");
            //    }


            //}
            db.Customers.Load();
            db.Products.Load();
            db.Goods.Load();
            db.Managers.Load();
            db.Orders.Load();
            db.Users.Load();
            dataCustomers.DataSource = db.Customers.Local.ToBindingList();
            dataUsers.DataSource = db.Users.Local.ToBindingList();
            dataManagers.DataSource = db.Managers.Local.ToBindingList();
            dataOrders.DataSource = db.Orders.Local.ToBindingList();
            dataProducts.DataSource = db.Products.Local.ToBindingList();
            dataGoods.DataSource = db.Goods.Local.ToBindingList();
            dataCustomers.Refresh();
            dataUsers.Refresh();
            dataManagers.Refresh();
            dataOrders.Refresh();
            dataProducts.Refresh();
            dataGoods.Refresh();

        }

        

        

        private void TabsControl_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (TabsControl.SelectedTab.Name == "OrdersTab")
            {
                DeleteButton.Hide();
                CheckButton.Show();
            }
            else
            {
                DeleteButton.Show();
                CheckButton.Hide();
            }
        }

        private void CheckButton_Click(object sender, EventArgs e)
        {
            if (directory.Exists)
            {
                int orderId;
                int totalsum = 0;
                try
                {
                    orderId = Convert.ToInt32(dataOrders.SelectedRows[0].Cells[0].Value);
                    using (StreamWriter writer = new StreamWriter(directory.FullName + @"\\check.txt", false))
                    {
                        writer.Write($"#{dataOrders.SelectedRows[0].Cells[0].Value} от {dataOrders.SelectedRows[0].Cells[1].Value}\n"
                            + $"Поставщик: Vadim inc.\n"
                            + $"Покупатель: {dataOrders.SelectedRows[0].Cells[3].Value}\n");
                        foreach (var good in db.Goods.Where(p => p.Order == orderId))
                        {
                            writer.WriteLine($"Id {good.Id}\t Количество {good.Count}\t Цена {good.Price} \t Сумма {good.Sum}");
                            totalsum += (int)(good.Price * good.Count);
                        }
                        writer.WriteLine("Итог:\t" + totalsum);
                        MessageBox.Show($"Чек был успешно создан за заданным каталогом {directory.FullName}" + @"\\check.txt");
                        
                    };
                }
                catch (ArgumentOutOfRangeException)
                {
                    MessageBox.Show("Выберите строку");
                }

                

                
            }

            else
            {
                Directory.CreateDirectory($@"{directory.FullName}"); ;

                if (directory.Exists)
                {
                    MessageBox.Show("Директория создана");
                }


            }
        }

        private void ChangeCol_Click(object sender, EventArgs e)
        {
            if (ColorDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = ColorDialog.Color;
               red = BackColor.R;
               green = BackColor.G;
               blue = BackColor.B;
            };
        }
        bool ReadSettings()
        {
            NameValueCollection allAppSettings = ConfigurationManager.AppSettings;
            if (allAppSettings.Count < 1) { return (false); }
            int red = Convert.ToInt32(allAppSettings["BackGroundColor.R"]);
            int green = Convert.ToInt32(allAppSettings["BackGroundColor.G"]);
            int blue = Convert.ToInt32(allAppSettings["BackGroundColor.B"]);
            this.BackColor = Color.FromArgb(red, green, blue);
            return (true);
        }
        void SaveSettings()
        {
            XmlDocument doc = loadConfigDocument();

            XmlNode node = doc.SelectSingleNode("//appSettings");
            string[] keys = new string[] { "BackGroundColor.R",
                                           "BackGroundColor.G",
                                           "BackGroundColor.B"
                                           };

            string[] values = new string[] { BackColor.R.ToString(),
                                             BackColor.G.ToString(),
                                             BackColor.B.ToString()
            };
            for (int i = 0; i < keys.Length; i++)
            {
                // Обращаемся к конкретной строке по ключу.
                XmlElement element = node.SelectSingleNode(string.Format("//add[@key='{0}']", keys[i])) as XmlElement;

                // Если строка с таким ключем существует - записываем значение.
                if (element != null) { element.SetAttribute("value", values[i]); }
                else
                {
                    // Иначе: создаем строку и формируем в ней пару [ключ]-[значение].
                    element = doc.CreateElement("add");
                    element.SetAttribute("key", keys[i]);
                    element.SetAttribute("value", values[i]);
                    node.AppendChild(element);
                }
            }

            // Сохраняем результат модификации.
            doc.Save(Assembly.GetExecutingAssembly().Location + ".config");
        }

        private XmlDocument loadConfigDocument()
        {
            XmlDocument doc = null;
            try
            {
                doc = new XmlDocument();
                doc.Load(Assembly.GetExecutingAssembly().Location + ".config");
                return doc;
            }
            catch (System.IO.FileNotFoundException e)
            {

                throw new Exception("No conf", e);
            }


        }
    }
}
