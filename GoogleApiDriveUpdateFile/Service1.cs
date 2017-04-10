using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace GoogleApiDriveUpdateFile
{
    public partial class Service1 : ServiceBase
    {
        private Timer timer = null;
        public Service1()
        {
            InitializeComponent();
            
        }

        protected override void OnStart(string[] args)
        {
            System.Diagnostics.Debugger.Launch();
            GoogleApiDriveUpdateFile.GoogleAppUpdateFileDI.Autentificacion();
            //timer = new Timer();
            //this.timer.Interval = 240000;
            //this.timer.Elapsed += new System.Timers.ElapsedEventHandler(this.mailSend);
            //timer.Enabled = true;
        }

        protected override void OnStop()
        {
        }
    }
}
