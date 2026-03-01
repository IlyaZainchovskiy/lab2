using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnOrder.Click += BtnOrder_Click;
            btnCancel.Click += BtnCancel_Click;
            btnExit.Click += BtnExit_Click;
        }
        private void BtnOrder_Click(object sender, EventArgs e)
        {
            try
            {
                decimal priceLight = decimal.Parse(txtLightBeerPrice.Text);
                decimal priceDark = decimal.Parse(txtDarkBeerPrice.Text);
                decimal priceChips = decimal.Parse(txtChipsPrice.Text);
                decimal priceFish = decimal.Parse(txtFishPrice.Text);

                decimal sumLight = nudLightBeerQty.Value * priceLight;
                decimal sumDark = nudDarkBeerQty.Value * priceDark;
                decimal sumChips = nudChipsQty.Value * priceChips;
                decimal sumFish = nudFishQty.Value * priceFish;

                decimal totalSum = sumLight + sumDark + sumChips + sumFish;

                if (totalSum == 0)
                {
                    MessageBox.Show("Ви нічого не вибрали для замовлення!", "Увага", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string message = $"Загальна вартість замовлення: {totalSum} грн.\n";

                if (totalSum > 300)
                {
                    decimal discount = totalSum * 0.15m;
                    decimal finalSum = totalSum - discount;
                    message += $"Надано знижку 15% ({discount:F2} грн).\n";
                    message += $"ДО СПЛАТИ: {finalSum:F2} грн.";
                }
                else
                {
                    message += $"ДО СПЛАТИ: {totalSum:F2} грн.";
                }

                MessageBox.Show(message, "Ваш чек", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (FormatException)
            {
                MessageBox.Show("Помилка у форматі ціни! Будь ласка, введіть числові значення вартості.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            nudLightBeerQty.Value = 0;
            nudDarkBeerQty.Value = 0;
            nudChipsQty.Value = 0;
            nudFishQty.Value = 0;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabBeer_Click(object sender, EventArgs e)
        {

        }
    }
}
