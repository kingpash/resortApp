using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bautista_HW_3_Resort
{
    public partial class ResortForm : Form
    {
        public ResortForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            costGroupBox.Visible = false;

            nightsLabel.Text = "0";

            roomNumberLabel.Text = "0";


        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            costGroupBox.Visible = true;

            double stdKing = 284;
            double atKing = 325;
            double stdQueen = 290;
            double atQueen = 350;
            double onlyRoom;
            double totalRoom;
            double tax;
            double parking;
            double resortFee;
            double total;


            if (parkingCheckBox.Checked)
            {
                parking = 12.75;
            }else
            {
                parking = 0;
            }


            if (kingSize.Checked && standardViewRadioButton.Checked)
            {
                onlyRoom = stdKing;

            }
            else if (kingSize.Checked && atriumViewRadioButton.Checked)
            {
                onlyRoom = atKing;

            }
            else if (queenSize.Checked && standardViewRadioButton.Checked)
            {
                onlyRoom = stdQueen;

            }
            else
            {
                onlyRoom = atQueen;

            }

            if (roomTrackBar.Value > 1)
            {
                adultNumericUpDown.Maximum = roomTrackBar.Value * 6;
                childNumericUpDown.Maximum = roomTrackBar.Value * 6;
            }

            totalRoom = onlyRoom * nightsTrackBar.Value * roomTrackBar.Value;

            resortFee = 15 * roomTrackBar.Value * nightsTrackBar.Value;

            feeCost.Text = "$" + resortFee;

            tax = .15 * totalRoom;

            roomCost.Text = "$" + totalRoom;

            taxCost.Text = "$" + tax;

            parkingCost.Text = "$" + parking;


            total = totalRoom + resortFee + tax + parking;

            totalCost.Text = "$" + total;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();

            parkingCheckBox.Checked = false;

            americanRadioButton.Checked = false;
            visaRadioButton.Checked = false;
            discoverRadioButton.Checked = false;
            mastercardRadioButton.Checked = false;

            kingSize.Checked = false;
            queenSize.Checked = false;

            standardViewRadioButton.Checked = false;
            atriumViewRadioButton.Checked = false;

            cardDateMaskedTextBox.Clear();
            cardDateMaskedTextBox.Mask = "00/0000";

            cardNumberMaskedTextBox.Clear();
            cardNumberMaskedTextBox.Mask = "0000-0000-0000-0000";


            nightsTrackBar.Value = 0;
            nightsLabel.Text = "0";

            roomTrackBar.Value = 0;
            roomNumberLabel.Text = "0";

            adultNumericUpDown.Value = 0;
            childNumericUpDown.Value = 0;

            nameTextBox.Focus();

            costGroupBox.Visible = false;

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void nightsTrackBar_Scroll(object sender, EventArgs e)
        {
            int count;

            nightsLabel.Text = nightsTrackBar.Value.ToString("N0");

            for (count = 1; count < 7; count++) ;
                
        }

        private void roomTrackBar_Scroll(object sender, EventArgs e)
        {
            int count;

            roomNumberLabel.Text = roomTrackBar.Value.ToString("N0");

            for (count = 1; count < 10; count++) ;
        }

        private void visaRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardNumberMaskedTextBox.Mask = "4000-0000-0000-0000";
        }

        private void mastercardRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardNumberMaskedTextBox.Mask = "5000-0000-0000-0000";
        }

        private void discoverRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardNumberMaskedTextBox.Mask = "6000-0000-0000-0000";
        }

        private void americanRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            cardNumberMaskedTextBox.Mask = "3000-0000000-00000";
        }
    }
}
