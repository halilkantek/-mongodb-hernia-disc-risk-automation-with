using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
            
    static class Program
    {
        static public MongoClientSettings settings = MongoClientSettings.FromConnectionString("mongodb+srv://Trial:admin@cluster0.qlq09.mongodb.net/*?retryWrites=true&w=majority");
        static public MongoClient client = new MongoClient(settings);
        static public IMongoDatabase db = client.GetDatabase("user");


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new girisfrm());
        }
    }
}
