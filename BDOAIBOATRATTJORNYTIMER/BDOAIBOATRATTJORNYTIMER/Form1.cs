using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BDOAIBOATRATTJORNYTIMER
{
    
    public partial class Form1 : Form
    {
        public float timeRealVal = 2454;
        public bool PlyingCnt = true;
        public float floatTimeSetVal;
        public float fixer;
        public float RealTime;
        public bool Showna = false;
        public Form1()
        
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void Reset()
        {
            
            timeRealVal = float.Parse(TimeValue.Text);
            lblRealTime.Text = Convert.ToString(timeRealVal);
            lblPercent.Text = Convert.ToString((((timeRealVal - floatTimeSetVal) * -1) / fixer) * 100);


        }

        private void BtnTmr1StrtStp_Click(object sender, EventArgs e)
        {
            
            if (PlyingCnt == true) {
                timer1.Enabled = true;
                PlyingCnt = false;
            }else
                 {
                        timer1.Enabled = false;
                        PlyingCnt = true; 
                     }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                    
            if (timeRealVal == 0)
            {
                Reset();

            }else{
                fixer = float.Parse(TimeValue.Text);
                timeRealVal = float.Parse(Convert.ToString(Convert.ToDouble(timeRealVal) - 0.01));
                
                floatTimeSetVal = float.Parse(TimeValue.Text);
                
                lblRealTime.Text = Convert.ToString(timeRealVal);


                lblPercent.Text = Convert.ToString((((timeRealVal - floatTimeSetVal) * -1) / fixer)* 100);



            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Showna == false) {
                TimeValue.Visible = true;
                Showna = true;


            }else{

                TimeValue.Visible = false;
                Showna = false;

            }

        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }
    }
}
