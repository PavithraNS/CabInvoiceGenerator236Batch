using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGeneratorDemo183Batch
{
    public class InvoiceSummary
    {
        public double totalFare;
        public int numbOfRaides;
        public double average;

        public InvoiceSummary(double totalFare, int numbOfRaides)
        {
            this.totalFare = totalFare;
            this.numbOfRaides = numbOfRaides;
            this.average = totalFare/numbOfRaides;
        }

        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is InvoiceSummary))
            {
                return false;
            }
            InvoiceSummary invoiceSummary = (InvoiceSummary)obj;
            return numbOfRaides == invoiceSummary.numbOfRaides && totalFare == invoiceSummary.totalFare && average == invoiceSummary.average;
        }
    }
}
