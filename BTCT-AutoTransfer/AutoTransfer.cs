using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace BTCTC
{
    class TransferRule
    {
        public string Input { get; set; }
        public string Output { get; set; }

        public int MinInput { get; set; }
        public bool FeeInput { get; set; }

        public int Multiplier { get; set; }
        public bool MultInput { get; set; }
    }

    class AutoTransfer
    {
        private System.Timers.Timer _timer;
        private int _interval;

        private List<TransferRule> _transferRules;
        public bool Active { get; }
        public bool ReadOnly { get; set; }
        public bool SingleUser { get; set; }
        public string SingleUserName { get; set; }
       
        public int Interval
        {
            get
            {
                return _interval;
            }
            set
            {
                if (Active)
                {
                    StopTimer();
                    _interval = value;
                    StartTimer();
                }
                else
                {
                    _interval = value;
                }
            }
        }

        public BTCTLink InLink { get; }
        public BTCTLink OutLink { get; }

        public void Initialize()
        {
        }

        public void StartTimer()
        {
        }

        public void StopTimer()
        {
        }

        private void DoUpdate()
        {
        }


    }
}
