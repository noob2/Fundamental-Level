using CompanyHyerarchy.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyHyerarchy.SalesAndProjects
{
    class Project : IProject
    {
        private string productName;
        private string details;

        public string ProductName
        {
            get
            {
                return productName;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("productName", "product name must not be empty");
                }
                this.productName = value;
            }
        }

        public DateTime Date { get; set; }

        public string Details
        {
            get
            {
                return details;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentOutOfRangeException("details", "ther must be some details");
                }
                this.details = value;
            }
        }

        public ProjectState State { get; set; }

        public Project(string productName, DateTime date, string details)
        {
            this.ProductName = productName;
            this.Date = date;
            this.Details = details;
            this.State = ProjectState.Open;
        }

        public void CloseProject()
        {
            this.State = ProjectState.Closed;
        }
    }
}
