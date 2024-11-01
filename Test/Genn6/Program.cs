using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Genn6
{
    interface iPhoneNumber
    {
        string Name { get; set; }

        string Number { get; set; }

    }

    class Friend : iPhoneNumber
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public bool IsWorking;

        public Friend(string n, string name, bool iw)
        {
            Name = name;
            Number = n;
            IsWorking = iw;
        }
    }

    class EmailFriend
    {
        public string Name { get; set; }
        public string Number { get; set; }

    }
    class IsSUpplier : iPhoneNumber
    {
        public string Name { get; set; }
        public string Number { get; set; }

        public IsSUpplier(string n, string name)
        {
            Number = n;
            Name = name;
        }
    }

    class PhoneList<T> where T:iPhoneNumber
        {

        T[] pList;
        int end;
        public PhoneList()
        {
            pList = new T[10];
            end = 0;
        }
        public void Add(T o)
        {
            for (int i = 0; i < 10; i++)
            {
                pList[i] = o;
                end++;
            }
        }

        public T FindName(string n)
        {
            for (int i = 0; i < pList.Length; i++)
            {
                if (pList[i].Name == n)
                {
                    return pList[i];
                }
            }
            throw new NotFoundException("The name is not present in the list");
        }

        public T FindNumber(string num)
        {
            for (int i = 0; i < pList.Length; i++)
            {
                if (pList[i].Number == num)
                {
                    return pList[i];
                }
            }
            throw new NotFoundException("The number is not present in the list");
        }
    }

    class NotFoundException : Exception
    {
        public NotFoundException() : base()
        {

        }

        public NotFoundException(string message) : base(message)
        {

        }
        public NotFoundException(string message, Exception innerException) : base(message, innerException)
        {

        }
        public NotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
        public override string ToString()
        {
            return Message; ;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Friend f = new Friend("9547653633", "CHANDAN", false);
            Friend f1 = new Friend("844531", "XYZ", true);
            Friend f2 = new Friend("31312", "ABC", false);
            Friend f3 = new Friend("2151561", "FGD", true);
            Friend f4 = new Friend("68468468", "TYR", false);
            IsSUpplier isU = new IsSUpplier("9959027716", "SADASIVUNI");

            EmailFriend ef = new EmailFriend();

            PhoneList<Friend> plFriend = new PhoneList<Friend>();

            plFriend.Add(f);
            plFriend.Add(f1);
            plFriend.Add(f2);
            plFriend.Add(f3);
            plFriend.Add(f4);


            Friend ft = plFriend.FindNumber("68468468");

            PhoneList<IsSUpplier> plISU = new PhoneList<IsSUpplier>();

            plISU.Add(isU);

            plISU.FindName("SADASIVUNI");

            Console.WriteLine(plISU.FindName("SADASIVUNI").Name);
            Console.WriteLine(plISU.FindName("SADASIVUNI").Number);
            //Console.WriteLine(plISU.FindName("SADASIVUNI").IsWorking);


            //Console.WriteLine(ft.Name);
            //Console.WriteLine(ft.Number);
            //Console.WriteLine(ft.IsWorking);

        }
    }
}
