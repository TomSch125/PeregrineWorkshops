using Shapes;
using System.Reflection.Metadata;

namespace ShapeForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideAll();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chkRectangle_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkRectangle.Checked) // needed or else you uncheck the other boxes, wich casuses them to uncheck all the boxes. 
            {
                return;
            }

            if (chkCircle.Checked)
            {
                chkCircle.Checked = false;
            }

            if (chkTraingle.Checked)
            {
                chkTraingle.Checked = false;
            }

            if (!btnCalc.Visible)
            {
                btnCalc.Show();
            }
            hideAllInputs();
            lblA.Text = "Height:";
            lblA.Show();
            spinA.Show();

            lblB.Text = "Width:";
            lblB.Show();
            spinB.Show();

            if ((chkRectangle.Checked == false) && (chkTraingle.Checked == false) && (chkCircle.Checked == false))
            {
                hideAll();
            }

            hideOuts();

        }

        private void hideAllInputs() { 
            lblA.Hide();
            lblB.Hide();
            lblC.Hide();
            spinA.Hide();
            spinA.Value = 0;
            spinB.Hide();
            spinB.Value = 0;
            spinC.Hide();
            spinC.Value = 0;
        }

        private void hideAll() {
            hideAllInputs();
            btnCalc.Hide();
            lblArea.Hide();
            lblPerimeter.Hide();
        }

        private void showOutputs() {
            lblArea.Show();
            lblPerimeter.Show();
        }

        private void hideOuts() {
            lblArea.Hide();
            lblPerimeter.Hide();
        }


        private void chkCircle_CheckedChanged(object sender, EventArgs e)
        {

            if (!chkCircle.Checked)
            {
                return;
            }

            if (chkRectangle.Checked)
            {
                chkRectangle.Checked = false;
            }

            if (chkTraingle.Checked)
            {
                chkTraingle.Checked = false;
            }

            if (!btnCalc.Visible)
            {
                btnCalc.Show();
            }

            hideAllInputs();
            lblA.Text = "radius:";
            lblA.Show();
            spinA.Show();

            if ((chkRectangle.Checked == false) && (chkTraingle.Checked == false) && (chkCircle.Checked == false)) {
                hideAll();
            }

            hideOuts();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {

            double area = -1;
            double perimeter = -1;
            if (chkCircle.Checked)
            {
                int val = (int)spinA.Value;
                MyCircle c = new MyCircle(val);
                area = c.area();
                perimeter = c.perimeter();

            }
            if (chkRectangle.Checked)
            {
                int h = (int)spinA.Value;
                int w = (int)spinB.Value;
                MyRectangle r = new MyRectangle(h, w);
                area = r.area();
                perimeter = r.perimeter();

            }
            if (chkTraingle.Checked) { 
                int a = (int)spinA.Value;
                int b = (int)spinB.Value;
                int c = (int)spinC.Value;
                MyTriangle t = new MyTriangle(a, b, c);
                area = t.area();
                perimeter = t.perimeter();

            }

            if (area != -1 && perimeter != -1) {
                showOutputs();
                lblArea.Text = "Area: " + Math.Round(area, 3).ToString();
                lblPerimeter.Text = "Perimeter: " + Math.Round(perimeter, 3).ToString();
            }
            

        }

        private void chkTraingle_CheckedChanged(object sender, EventArgs e)
        {

            if (!chkTraingle.Checked)
            {
                return;
            }

            if (chkRectangle.Checked)
            {
                chkRectangle.Checked = false;
            }

            if (chkCircle.Checked)
            {
                chkCircle.Checked = false;
            }

            if (!btnCalc.Visible) { 
                btnCalc.Show();
            }

            hideAllInputs();
            lblA.Text = "a:";
            lblA.Show();
            spinA.Show();

            lblB.Text = "b:";
            lblB.Show();
            spinB.Show();

            lblC.Text = "c:";
            lblC.Show();
            spinC.Show();

            if ((chkRectangle.Checked == false) && (chkTraingle.Checked == false) && (chkCircle.Checked == false))
            {
                hideAll();
            }

            hideOuts();


        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }
    }
}
