using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace drug_store.Invoices
{
    public class ReportDAO
    {
        private ReportDAO() { }
        private static ReportDAO instance;

        public static ReportDAO Instance { get => instance ?? (instance = new ReportDAO()); private set => instance = value; }
    }
}
