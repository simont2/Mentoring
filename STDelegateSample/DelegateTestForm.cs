using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STDelegateSample
{
    public partial class DelegateTestForm : Form
    {
        STCounterClass _counterClass = null;
        public DelegateTestForm()
        {
            InitializeComponent();
            _counterClass = new STCounterClass(CounterOutput);

            _counterClass.CounterChangeHandler += new STCounterClass.CounterActionDelegate(Update1);
            _counterClass.CounterChangeHandler += new STCounterClass.CounterActionDelegate(Update2);
        }

        public delegate void EventUpdateDelegate(object obj, STSampleEventAgs args);

        public void Update1(object obj, STSampleEventAgs args)
        {
            if (event1Label.InvokeRequired)
            {
                EventUpdateDelegate updateMe = new EventUpdateDelegate(Update1);
                event1Label.Invoke(updateMe, new Object[] { obj, args } );
                return;
            }
            event1Label.Text = "Label 1 " + args.CounterValue;
        }

        public void Update2(object obj, STSampleEventAgs args)
        {
            if (event2Label.InvokeRequired)
            {
                EventUpdateDelegate updateMe = new EventUpdateDelegate(Update2);
                event2Label.Invoke(updateMe, new Object[] { obj, args });
                return;
            }
            event2Label.Text = "Label 2 " + args.CounterValue;
        }

        private void StartActionButton_Click(object sender, EventArgs e)
        {
            _counterClass.StartCounter();
        }

        private void StopActionButton_Click(object sender, EventArgs e)
        {
            _counterClass.StopCounter();
        }

        private void CounterValueTxt_TextChanged(object sender, EventArgs e)
        {
            _counterClass.SetCounter(int.Parse(CounterValueTxt.Text));
        }
    }
}
