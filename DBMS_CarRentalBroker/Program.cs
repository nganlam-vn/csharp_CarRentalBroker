﻿using DBMS_CarRentalBroker.Views.NguoiThue;
﻿using DBMS_CarRentalBroker.Views.ChuXe;
﻿using DBMS_CarRentalBroker.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBMS_CarRentalBroker.Views.Admin;
namespace DBMS_CarRentalBroker
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FDangNhap());
        }
    }
}
