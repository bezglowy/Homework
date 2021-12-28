using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domowe_1
{
    public class User
    {
        private string name;
        private string surname;
        private byte age;
        private char sex;
        private ulong id;
        private ulong userNumber;
        private string email;
        private float weight;
        private uint phoneNumber;

        public string Name
        {
            get => name;
            set => name = value;
        }
        public string Surname { get => surname; set => surname = value; }
        public byte Age
        {
            get => age;
            set
            {
                if ((value > 1) && (value < 150))
                {
                    age = value;
                }
            }
        }
        public char Sex
        {
            get => sex;
            set
            {
                if ((value == 'm') | (value == 'k'))
                {
                    sex = value;
                }
                else
                {
                    sex = 'u';
                }
            }

        }

        public ulong Id
        {
            get => id;
            set => id=value;
        }

        public ulong UserNumber { get => userNumber; set => userNumber = value; }
        public string Email { get => email; set => email = value; }
        public float Weight { get => weight; set => weight = value; }
        public uint PhoneNumber { get => phoneNumber; set => phoneNumber = value; }
    }
}

