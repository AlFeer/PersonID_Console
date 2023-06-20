using System;

namespace PersonTask
{
    public class Person
    {
        private string name;
        private int age;
        private string serialNumber;


        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Value cannot be null");
                }

                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Value cannot be less than 0");
                }

                age = value;
            }
        }
        public string SerialNumber
        {
            get
            {
                return serialNumber;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Value cannot be null");
                }

                value = value.Trim().ToLower();

                if (value.Length != 9)
                {
                    throw new ArgumentException("Value length must be 9!");
                }

                if (value.StartsWith("aze"))
                {

                    for (int i = 3; i < value.Length; i++)
                    {
                        if (!char.IsDigit(value[i]))
                        {
                            throw new ArgumentException("After AZE serial number can contains only numbers");

                        }
                    }
                }

                else if (value.StartsWith("aa"))
                {
                    for (int i = 2; i < value.Length; i++)
                    {
                        if (!char.IsDigit(value[i]))
                        {
                            throw new ArgumentException("After AA serial number can contains only numbers");
                        }
                    }

                }
                else
                {
                    throw new ArgumentException("Serial number should start with AZE or AA");
                }


                serialNumber = value;
            }
        }

        public Person(string name, int age, string serialNumber)
        {
            Name = name;
            Age = age;
            SerialNumber = serialNumber;
        }
    }
}