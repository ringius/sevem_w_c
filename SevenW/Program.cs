using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore;


namespace SevenW.Models
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();

            /*
            Player pelle = new Player(@"Pelle");
            Player olle = new Player("Olle");
            Player kalle = new Player("Kalle");

            pelle.EastPlayer = olle;
            pelle.WestPlayer = kalle;

            Playcard card = Playcard.ReadTest();

			Wonder wonder1 = new Wonder("Göteborg", true, 1, new Playcard());
			Wonder wonder2 = new Wonder("Kungälv", false, 1, new Playcard());
			System.Console.WriteLine(wonder1);
			System.Console.WriteLine(wonder2);

			Console.ReadKey();
            */

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) => 
            WebHost.CreateDefaultBuilder(args).UseStartup<Startup>();
    }

}

