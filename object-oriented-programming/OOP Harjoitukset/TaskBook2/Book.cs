using System;

namespace TaskBook2

{
    class Book

    {
        private string _name;
        private readonly string _author;
        private string _publisher;
        private double _price;
        private static string _category;

        /// <summary>
        /// Constructor
        /// </summary>

        public Book()

        {
            Name = "unknown";
            _author = "unknown";
            Publisher = "unknown";
            Price = 0;
            _category = "unknown";
        }

        public Book(string name, string author, string publisher, double price, string category)

        {
            Name = name;
            _author = author;
            Publisher = publisher;
            Price = price;
            _category = category;

        }

        /// <summary>
        /// Encapsulated properties
        /// </summary>

        public string Name

        {
            get { return _name; }
            set { _name = value; }
        }

        public string Author

        {
            get { return _author; }
            //set { _author = value; }
        }

        public string Publisher

        {
            get { return _publisher; }
            set { _publisher = value; }
        }

        public double Price

        {
            get { return _price; }
            set

            {
                _price = value;
                if (value > 30)
                    _price = value * 0.9;
            }
        }

        public static string Category

        {
            get { return _category; }
            //set { _category = value; }
        }

        public void GetBook(string name)

        {
            if (Name == name)
            {
                Console.WriteLine($"Kirja löytyi!\n" +
                                  $"---------------------\n" +
                                  $"Kirja: {Name}\n" +
                                  $"Kirjailija: {Author}\n" +
                                  $"Julkaisija: {Publisher}\n" +
                                  $"Hinta: {Price}\n" +
                                  $"----------------------\n");
            }
            else
            {
                Console.WriteLine($"{name} kirjaa ei löydy!\n" +
                                  $"----------------------\n");
            }

        }

        public static void ChangeCategory(string category)

        {
            _category = category;
        }

        public override string ToString()

        {
            return ($"Kirja: {Name}\n" +
                    $"Kirjailija: {Author}\n" +
                    $"Julkaisija: {Publisher}\n" +
                    $"Hinta: {Price}\n" +
                    $"----------------------\n");
        }
    }
}

