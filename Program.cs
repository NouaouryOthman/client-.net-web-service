using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService_JaxWS
{
    class Program
    {
        static void Main(string[] args)
        {
            SR1.BanqueServiceClient stub = new SR1.BanqueServiceClient();
            Console.WriteLine(stub.ConversionEuroToDH(300));
            SR1.compte cp = stub.getCompte(5);
            Console.WriteLine(cp.code);
            Console.WriteLine(cp.montant);
            SR1.compte[] cptes = stub.compteList();
            foreach(var c in cptes)
            {
                Console.WriteLine("-------------");
                Console.WriteLine(cp.code);
                Console.WriteLine(cp.montant);
            }
            Console.ReadLine(); 
        }
    }
}
