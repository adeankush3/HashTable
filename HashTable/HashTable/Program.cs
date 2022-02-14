using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Hash Table Programming");
            MyMapNode<string, string> myMapNode = new MyMapNode<string, string>(5);
            myMapNode.Add("0", "To");
            myMapNode.Add( "1","be");
            myMapNode.Add( "2","or");
            myMapNode.Add( "3","not");
            myMapNode.Add( "4","To");
            myMapNode.Add( "5","be");
            
            
            string hash5 = myMapNode.Get("5");
            Console.WriteLine("5th Index Value " + hash5);

            myMapNode.Remove("2");
            string hash2 = myMapNode.Get("2");
            Console.WriteLine("2nd index Value " + hash2);
        }
    }
}
