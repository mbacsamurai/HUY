using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace miniProjectH
{
    class NumberButtonAdd
    {
        private Control objParent;
        private Int32 minButton;
        private Int32 maxButton;

        public NumberButtonAdd(Control cont,Int32 min,Int32 max)
        {
            this.objParent = cont;
            this.minButton = min;
            this.maxButton = max;
        }
        public void GenarateButtonOneUnit()
        {
            this.LoopCreateButton(minButton, maxButton, "0");
        }
        public void GenarateButtonTwoUnit()
        {
            this.LoopCreateButton(minButton, maxButton, "00");
        }
        public void GenarateButtonThreeUnit()
        {
            this.LoopCreateButton(minButton, maxButton, "000");
        }
        private void LoopCreateButton(Int32 min, Int32 max, String format)
        {
            FlowLayoutPanel flp1 = new FlowLayoutPanel();
            flp1.Size = objParent.Size;

            for (Int32 i = min; i <= max; i++)
            {
                ButtonH btn = new ButtonH();
                btn.Size = new System.Drawing.Size(70, 35);
                btn.Name = objParent.Name + ".Number." + i.ToString(format);
                btn.Text = Convert.ToString(i.ToString(format));
                flp1.Controls.Add(btn);
                //Console.WriteLine(i);
            }
            objParent.Controls.Add(flp1);
        }


    }
}
