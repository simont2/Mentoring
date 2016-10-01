using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STDelegateSample
{
    public class STCounterClass
    {
        Label _counterOutput = null;
        int _counterValue = 1000;
        Thread _newthread = null;
        bool _stopThread = false;

        public STCounterClass(Label counterOutput)
        {
            _counterOutput = counterOutput;
        }

        public void StartCounter()
        {
            SetTxtStringThreadSafe("Start " + _counterValue);
            if (_newthread == null)
            {
                _newthread = new Thread(RunMe);
                _stopThread = false;
                _newthread.Start();
            }
        }

        protected void RunMe()
        {
            int counter = 1;
            while (!_stopThread)
            {
                Thread.Sleep(_counterValue);
                SetTxtStringThreadSafe("Running " + counter);
                if (CounterChangeHandler != null)
                {
                    STSampleEventAgs eventArgs = new STSampleEventAgs(counter);
                    CounterChangeHandler(this, eventArgs);
                }
                counter++;
            }
            _newthread = null;
        }

        public delegate void CounterActionDelegate(object actionObject, STSampleEventAgs eventArgs);
        public event CounterActionDelegate CounterChangeHandler;

        protected delegate void TextSetDelegate(string textString);

        protected void SetTxtStringThreadSafe(string textValue)
        {
            if (_counterOutput.InvokeRequired)
            {
                TextSetDelegate execThread = new TextSetDelegate(SetTxtStringThreadSafe);
                _counterOutput.Invoke(execThread, textValue);
                return;
            }
            _counterOutput.Text = textValue;
        }

        public void StopCounter()
        {
            _stopThread = true;
            SetTxtStringThreadSafe("Stop " + _counterValue);
        }

        public void SetCounter(int counterValue)
        {
            _counterValue = counterValue;
        }
    }
}
