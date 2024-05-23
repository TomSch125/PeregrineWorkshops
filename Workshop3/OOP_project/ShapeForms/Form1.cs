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
            if (!chkRectangle.Checked)
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

        }

        private void hideAllInputs() { 
            lblA.Hide();
            lblB.Hide();
            lblC.Hide();
            spinA.Hide();
            spinB.Hide();   
            spinC.Hide();
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
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            if (chkCircle.Checked)
            {
                int val = (int)spinA.Value;
                MyCircle c = new MyCircle(val);
                double area = c.area();
                double perimeter = c.perimeter();
                showOutputs();
                lblArea.Text = "Area: " + area.ToString();
                lblPerimeter.Text = "Perimeter: " + perimeter.ToString();
            }
            if (chkRectangle.Checked)
            {
                int h = (int)spinA.Value;
                int w = (int)spinB.Value;
                MyRectangle r = new MyRectangle(h, w);
                double area = r.area();
                double perimeter = r.perimeter();
                showOutputs();
                lblArea.Text = "Area: " + area.ToString();
                lblPerimeter.Text = "Perimeter: " + perimeter.ToString();
            }
            if (chkTraingle.Checked) { 
                int a = (int)spinA.Value;
                int b = (int)spinB.Value;
                int c = (int)spinC.Value;
                MyTriangle t = new MyTriangle(a, b, c);
                double area = t.area();
                double perimeter = t.perimeter();
                showOutputs();
                lblArea.Text = "Area: " + area.ToString();
                lblPerimeter.Text = "Perimeter: " + perimeter.ToString();
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
        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }
    }
}
