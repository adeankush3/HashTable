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

            MyMapNode<string, string> hashTable = new MyMapNode<string, string>(18);

            hashTable.Add("f0", "“Paranoids");
            hashTable.Add("f1", "are");
            hashTable.Add("f2", "but");
            hashTable.Add("f3", "paranoid");
            hashTable.Add("f4", "because");
            hashTable.Add("f5", "they");
            hashTable.Add("f6", "are");
            hashTable.Add("f7", "paranoid");
            hashTable.Add("f8", "but");
            hashTable.Add("f9", "because");
            hashTable.Add("f10", "they");
            hashTable.Add("f11", "keep");
            hashTable.Add("f12", "putting");
            hashTable.Add("f13", "themselves");
            hashTable.Add("f14", "deliberately");
            hashTable.Add("f15", "into");
            hashTable.Add("f16", "paranoid");
            hashTable.Add("f17", "avoidable");
            hashTable.Add("f18", "situations”");

            string strHold = hashTable.Get("f8");
            System.Console.WriteLine("8th index word in the paragraph is  :" + strHold);
        }
    }
}
