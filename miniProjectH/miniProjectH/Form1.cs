using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace miniProjectH
{
    public partial class Form1 : Form
    {
        private NumberButtonAdd NB;

       
        public Form1()
        {
            InitializeComponent();
            NB = new NumberButtonAdd(this.tabPage0, 0, 99);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage1, 100, 199);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage2, 200, 299);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage3, 300, 399);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage4, 400, 499);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage5, 500, 599);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage6, 600, 699);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage7, 700, 799);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage8, 800, 899);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.tabPage9, 900, 999);
            NB.GenarateButtonThreeUnit();
            NB = new NumberButtonAdd(this.PanelNumber2, 0, 99);
            NB.GenarateButtonTwoUnit();
            NB = new NumberButtonAdd(this.PanelNumber1, 0, 9);
            NB.GenarateButtonOneUnit();


            /// AddHandlerToButton
            this.AddHandlerButtonH();

            /// ProtectNumber
            this.TPnumber3.Enabled = false;
            this.PanelNumber1.Enabled = false;
            this.PanelNumber2.Enabled = false;

        }

        private void AddHandlerButtonH()
        {
            foreach (ButtonH ctl in this.GetAllCtls(typeof(ButtonH)))
            {
               ctl.AfterClicked += new ButtonH.EventHandler(btn_AfterClick);
            }
        }
        private ButtonH GetButtonH(String name)
        {
            foreach (Control ctl in this.GetAllCtls(typeof(ButtonH)))
            {
                if (ctl.Name == name)
                {
                    return (ButtonH)ctl;
                }

                
            }
            return new ButtonH();
        }
        private void btn_AfterClick(object sender, EventArgs e)
        {
            ButtonH btn = (ButtonH)sender;

            if (btn.Name.Contains("Number"))
            {

            }

            if (btn.Name.Contains("btnUpper3") || btn.Name.Contains("btnLower3"))
            {
                this.TPnumber3.Enabled = GetButtonH("btnUpper3").StateClick || GetButtonH("btnLower3").StateClick;


                Console.WriteLine("btnUpper3 : " + GetButtonH("btnUpper3").StateClick);
                Console.WriteLine("btnLower3 : " + GetButtonH("btnLower3").StateClick);

            }
            if (btn.Name.Contains("btnUpper2") || btn.Name.Contains("btnLower2"))
            {

                this.PanelNumber2.Enabled = GetButtonH("btnUpper2").StateClick || GetButtonH("btnLower2").StateClick;

                Console.WriteLine("btnUpper2 : " + GetButtonH("btnUpper2").StateClick);
                Console.WriteLine("btnLower2 : " + GetButtonH("btnLower2").StateClick);
            }
            if (btn.Name.Contains("btnUpper1") || btn.Name.Contains("btnLower1"))
            {

                this.PanelNumber1.Enabled = GetButtonH("btnUpper1").StateClick || GetButtonH("btnLower1").StateClick;

                Console.WriteLine("btnUpper1 : " + GetButtonH("btnUpper1").StateClick);
                Console.WriteLine("btnLower1 : " + GetButtonH("btnLower1").StateClick);
            }
        }


        

       
    }
}
