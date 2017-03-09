using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyRoster
{
    static class Program
    {
        public static List<Hero> HeroesD = new List<Hero>();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyRoster());
            Seed();
        }

        private static void Seed()
        {
            for (int i = 0; i < HeroesD.Count; i++)
            {

            }


            foreach (var h in HeroesD)
            {
                
            }

            List<Friend> Douchebags = new List<Friend>();
            Douchebags.Add(new Friend { Name = "Eugene" });
            Douchebags.Add(new Friend { Name = "Joey" });
            Douchebags.Add(new Friend { Name = "Sherry" });
            Douchebags.Where(friend => friend.Name == "Joey").FirstOrDefault();
        }
    }

    public class Friend
    {
        public string Name { get; set; }
    }
}
