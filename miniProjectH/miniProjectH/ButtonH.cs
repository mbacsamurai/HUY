using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace miniProjectH
{
   

    class ButtonH : Button
    {


        public event EventHandler AfterClicked;
        public EventArgs e = null;
        public delegate void EventHandler(ButtonH b, EventArgs e);

        private Boolean _StateClick;
        public Boolean StateClick
        {
            get { return _StateClick; }
            set
            {
                if (value == false)
                {
                    this.UnClick();
                }
                else
                {
                    this.Clicked();
                }
                this._StateClick = value;

                if (AfterClicked != null)
                    AfterClicked(this, e);

                ///Console.WriteLine(this.StateClick);
                ///Console.WriteLine(this.Name);
            }
        }
        public ButtonH()
        {
            this.FlatStyle = FlatStyle.Flat;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
            
        }
        private void Clicked()
        {
            this.BackColor = System.Drawing.Color.Silver;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12,System.Drawing.FontStyle.Bold);
        }
        private void UnClick()
        {
            this.BackColor = System.Drawing.Color.Transparent;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12);
        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.StateClick = !this.StateClick;
            
        }
        //protected override void onc
        
        
    }

}
