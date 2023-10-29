namespace Assessment3
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main( )
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (var context = new RestaurantContext())
            {
                context.Database.EnsureCreated();

                //var cust1 = new Customer { name = "Dip", email = "Dip@gmail.com", phone = 12345678, id = 123 };
                //var cust2 = new Customer { name = "Dave", email = "dave@gmail.com", phone = 123123, id = 321 };
                //var tab = new Table() { numguest = 6 };
                //context.Customers.Add(cust1);
                //context.Customers.Add(cust2);
                //context.Tables.Add(tab);
                context.SaveChanges();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
