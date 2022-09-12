using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968_PerformanceAssessment
{
  
    public class Product
    {
        public BindingList<Part> AssociatedParts = new BindingList<Part>();

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int InStock { get; set; }
        public decimal Price { get; set; }
        public int Max { get; set; }
        public int Min { get; set; }

        public void addAssociatedPart(Part part)
        {
            AssociatedParts.Add(part);
        }

        public bool removeAssociatedPart(int index)
        {
            AssociatedParts.RemoveAt(index);
            return true;
        }
        public Part lookUpAssociatedPart(int partId)
        {
            foreach (Part part in AssociatedParts)
            {
                if (part.PartId == partId)
                {
                    return part;
                }
            }
            return null;
        }
    }
}
