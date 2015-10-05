using System;
using System.Text;

namespace InheritanceEx1BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private double price;

        public Book(string title, string author, double price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Title","title must not be null or empty");
                }
                this.title = value;
            }
        }
        public string Author
        {
            get
            {
                return this.author;
            }
            protected set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Author","author must not be null or empty");
                }
                this.author = value;
            }
        }
        public virtual double Price
        {
            get
            {
                return this.price;
            }
            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price","price must be positive number");
                }
                this.price = value;
            }
        }

        public override string ToString()
        {
            StringBuilder bookInfo = new StringBuilder();

            bookInfo.AppendFormat("Type: {0}{1}", this.GetType().Name, Environment.NewLine);
            bookInfo.AppendFormat("Title: {0}{1}", this.Title, Environment.NewLine);
            bookInfo.AppendFormat("Author: {0}{1}", this.Author, Environment.NewLine);
            bookInfo.AppendFormat("Price: {0}", this.Price);

            return bookInfo.ToString();
        }
    }
}
