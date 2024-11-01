using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Genn5
{

    class PhoneNumber
    {
        public string Number { get; set; }

        public string _name;
        public string Name 
        { 
            get { return _name.ToLower(); }
            set {
                _name = value;
            }
        }

        public PhoneNumber(string num, string name)
        {
            Number = num;
            Name = name;
        }
    }

    class Friend:PhoneNumber
    {
        public bool IsWorking { get; private set; }
        public Friend(string num,string n, bool wk):base(num,n)
        {
            IsWorking = wk;
        }
    }
    class IsSUpplier : PhoneNumber
    {
        public IsSUpplier(string num, string name) : base(num, name)
        {

        }
    }

    class PhoneList<T> where T : PhoneNumber
    {
        T[] phList;
        int end ;

        public PhoneList()
        {
            phList = new T[10];
            end = 0;
        }
        public bool Add(T newEntry)
        {
            if (end == 10) return false;

            phList[end] = newEntry;
            end++;
            return true;
        }
        public T FindName(string name)
        {
            for (int i = 0; i < end; i++)
            {
                if (phList[i].Name == name.ToLower())
                {
                    return phList[i];
                }
                                                
            }
            throw new NotFoundException("The name does not exists!");
        }
        public T FindNumber(string num)
        {
            for (int i = 0; i < end; i++)
            {
                if (phList[i].Number == num)
                {
                    return phList[i];
                }
            }
            throw new NotFoundException("The name does not exists!");
        }
    }
    class EmailFriend
    {

    }

    

    class NotFoundException : Exception
    {
        public NotFoundException():base()
        {

        }

        public NotFoundException(string message):base(message)
        {

        }
        public NotFoundException(string message, Exception innerException):base(message,innerException)
        {

        }
        public NotFoundException(SerializationInfo info, StreamingContext context):base(info,context)
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

            Friend f = new Friend("9547653633", "CHANDAN",false);
            Friend f1 = new Friend("844531", "XYZ",true);
            Friend f2 = new Friend("31312", "ABC",false);
            Friend f3 = new Friend("2151561", "FGD",true);
            Friend f4 = new Friend("68468468", "TYR",false);
            IsSUpplier isU = new IsSUpplier("9959027716", "SADASIVUNI");

            EmailFriend ef = new EmailFriend();


            PhoneList<Friend> plFriend = new PhoneList<Friend>();
            PhoneList<IsSUpplier> plSupplier = new PhoneList<IsSUpplier>();
            PhoneList<EmailFriend> pleFriend = new PhoneList<EmailFriend>();

            plFriend.Add(f);
            plFriend.Add(f1);
            plFriend.Add(f2);
            plFriend.Add(f3);
            plFriend.Add(f4);
            plSupplier.Add(isU);


            try
            {
                //Friend ft = plFriend.FindName("sdfssdf");
                Friend ft = plFriend.FindNumber("68468468");
                Console.WriteLine(ft.Name);
                Console.WriteLine(ft.Number);
                Console.WriteLine(ft.IsWorking);
            }
            catch (NotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
