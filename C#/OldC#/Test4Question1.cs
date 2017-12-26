/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4Question1{
    
    class Program{
        public struct contactInfo{
            public string firstName, lastName;
            public string address, city, state;
            //public contactInfo next;
        }
        static void Main(string[] args){
            LinkedList<contactInfo> info = new LinkedList<contactInfo>();
            contactInfo data = new contactInfo();
            bool result = true;
            while (result){
                contactInfo data2 = new contactInfo();
                data = askForContactInfo(data2);
                info.AddLast(data);
                Console.WriteLine("Would you like to quit? If so enter: quit else press any button to enter more info");
                String answer = Console.ReadLine();
                result = answer.Equals("quit");
                if (result)
                {
                    displayContacts(info);
                    result = false;
                }
                else
                    result = true;
            }
        }

        private static void displayContacts(LinkedList<contactInfo> info)
        {
            LinkedListNode<contactInfo> node = info.First;
            
            for(int i = 0; i <= info.Count; i++)
            {
                Console.WriteLine("The first name: {0}",node.Value.firstName);
                Console.WriteLine("The last name: {0}", node.Value.lastName);
                Console.WriteLine("The address: {0}", node.Value.address);
                Console.WriteLine("The city: {0}", node.Value.city);
                Console.WriteLine("The state: {0}", node.Value.state);
                Console.WriteLine();
                info.RemoveFirst();
                node = info.First;
            }
            
        }

        private static contactInfo askForContactInfo(contactInfo data2)
        {
            Console.WriteLine("Enter your First Name");
            data2.firstName = Console.ReadLine();

            Console.WriteLine("Enter your Last Name");
            data2.lastName = Console.ReadLine();

            Console.WriteLine("Enter your Address");
            data2.address = Console.ReadLine();

            Console.WriteLine("Enter your City");
            data2.city = Console.ReadLine();

            Console.WriteLine("Enter your State");
            data2.state = Console.ReadLine();

            return data2;
        }
    }
}
*/