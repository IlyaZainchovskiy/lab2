namespace Task
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabBeer = new System.Windows.Forms.TabPage();
            this.tabSnacks = new System.Windows.Forms.TabPage();
            this.lblLightBeer = new System.Windows.Forms.Label();
            this.lblDarkBeer = new System.Windows.Forms.Label();
            this.nudLightBeerQty = new System.Windows.Forms.NumericUpDown();
            this.nudDarkBeerQty = new System.Windows.Forms.NumericUpDown();
            this.txtLightBeerPrice = new System.Windows.Forms.TextBox();
            this.txtDarkBeerPrice = new System.Windows.Forms.TextBox();
            this.lblChips = new System.Windows.Forms.Label();
            this.lblFish = new System.Windows.Forms.Label();
            this.nudChipsQty = new System.Windows.Forms.NumericUpDown();
            this.nudFishQty = new System.Windows.Forms.NumericUpDown();
            this.txtChipsPrice = new System.Windows.Forms.TextBox();
            this.txtFishPrice = new System.Windows.Forms.TextBox();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.tabBeer.SuspendLayout();
            this.tabSnacks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLightBeerQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDarkBeerQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipsQty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFishQty)).BeginInit();
            this.flpButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabBeer);
            this.tabControl.Controls.Add(this.tabSnacks);
            this.tabControl.Location = new System.Drawing.Point(3, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(468, 436);
            this.tabControl.TabIndex = 0;
            // 
            // tabBeer
            // 
            this.tabBeer.Controls.Add(this.txtDarkBeerPrice);
            this.tabBeer.Controls.Add(this.txtLightBeerPrice);
            this.tabBeer.Controls.Add(this.nudDarkBeerQty);
            this.tabBeer.Controls.Add(this.nudLightBeerQty);
            this.tabBeer.Controls.Add(this.lblDarkBeer);
            this.tabBeer.Controls.Add(this.lblLightBeer);
            this.tabBeer.Location = new System.Drawing.Point(4, 29);
            this.tabBeer.Name = "tabBeer";
            this.tabBeer.Padding = new System.Windows.Forms.Padding(3);
            this.tabBeer.Size = new System.Drawing.Size(460, 403);
            this.tabBeer.TabIndex = 0;
            this.tabBeer.Text = "Пиво";
            this.tabBeer.UseVisualStyleBackColor = true;
            this.tabBeer.Click += new System.EventHandler(this.tabBeer_Click);
            // 
            // tabSnacks
            // 
            this.tabSnacks.Controls.Add(this.txtFishPrice);
            this.tabSnacks.Controls.Add(this.txtChipsPrice);
            this.tabSnacks.Controls.Add(this.nudFishQty);
            this.tabSnacks.Controls.Add(this.nudChipsQty);
            this.tabSnacks.Controls.Add(this.lblFish);
            this.tabSnacks.Controls.Add(this.lblChips);
            this.tabSnacks.Location = new System.Drawing.Point(4, 29);
            this.tabSnacks.Name = "tabSnacks";
            this.tabSnacks.Padding = new System.Windows.Forms.Padding(3);
            this.tabSnacks.Size = new System.Drawing.Size(460, 403);
            this.tabSnacks.TabIndex = 1;
            this.tabSnacks.Text = "Закуски";
            this.tabSnacks.UseVisualStyleBackColor = true;
            // 
            // lblLightBeer
            // 
            this.lblLightBeer.AutoSize = true;
            this.lblLightBeer.Location = new System.Drawing.Point(7, 17);
            this.lblLightBeer.Name = "lblLightBeer";
            this.lblLightBeer.Size = new System.Drawing.Size(100, 20);
            this.lblLightBeer.TabIndex = 0;
            this.lblLightBeer.Text = "Світле пиво";
            // 
            // lblDarkBeer
            // 
            this.lblDarkBeer.AutoSize = true;
            this.lblDarkBeer.Location = new System.Drawing.Point(204, 17);
            this.lblDarkBeer.Name = "lblDarkBeer";
            this.lblDarkBeer.Size = new System.Drawing.Size(96, 20);
            this.lblDarkBeer.TabIndex = 1;
            this.lblDarkBeer.Text = "Темне пиво";
            // 
            // nudLightBeerQty
            // 
            this.nudLightBeerQty.Location = new System.Drawing.Point(11, 40);
            this.nudLightBeerQty.Name = "nudLightBeerQty";
            this.nudLightBeerQty.Size = new System.Drawing.Size(120, 26);
            this.nudLightBeerQty.TabIndex = 2;
            // 
            // nudDarkBeerQty
            // 
            this.nudDarkBeerQty.Location = new System.Drawing.Point(208, 40);
            this.nudDarkBeerQty.Name = "nudDarkBeerQty";
            this.nudDarkBeerQty.Size = new System.Drawing.Size(120, 26);
            this.nudDarkBeerQty.TabIndex = 3;
            // 
            // txtLightBeerPrice
            // 
            this.txtLightBeerPrice.Location = new System.Drawing.Point(11, 86);
            this.txtLightBeerPrice.Name = "txtLightBeerPrice";
            this.txtLightBeerPrice.Size = new System.Drawing.Size(100, 26);
            this.txtLightBeerPrice.TabIndex = 4;
            this.txtLightBeerPrice.Text = "20";
            // 
            // txtDarkBeerPrice
            // 
            this.txtDarkBeerPrice.Location = new System.Drawing.Point(208, 86);
            this.txtDarkBeerPrice.Name = "txtDarkBeerPrice";
            this.txtDarkBeerPrice.Size = new System.Drawing.Size(100, 26);
            this.txtDarkBeerPrice.TabIndex = 5;
            this.txtDarkBeerPrice.Text = "25";
            // 
            // lblChips
            // 
            this.lblChips.AutoSize = true;
            this.lblChips.Location = new System.Drawing.Point(14, 17);
            this.lblChips.Name = "lblChips";
            this.lblChips.Size = new System.Drawing.Size(56, 20);
            this.lblChips.TabIndex = 0;
            this.lblChips.Text = "Чипси";
            // 
            // lblFish
            // 
            this.lblFish.AutoSize = true;
            this.lblFish.Location = new System.Drawing.Point(203, 17);
            this.lblFish.Name = "lblFish";
            this.lblFish.Size = new System.Drawing.Size(46, 20);
            this.lblFish.TabIndex = 1;
            this.lblFish.Text = "Риба";
            // 
            // nudChipsQty
            // 
            this.nudChipsQty.Location = new System.Drawing.Point(18, 40);
            this.nudChipsQty.Name = "nudChipsQty";
            this.nudChipsQty.Size = new System.Drawing.Size(120, 26);
            this.nudChipsQty.TabIndex = 2;
            // 
            // nudFishQty
            // 
            this.nudFishQty.Location = new System.Drawing.Point(207, 40);
            this.nudFishQty.Name = "nudFishQty";
            this.nudFishQty.Size = new System.Drawing.Size(120, 26);
            this.nudFishQty.TabIndex = 3;
            // 
            // txtChipsPrice
            // 
            this.txtChipsPrice.Location = new System.Drawing.Point(18, 81);
            this.txtChipsPrice.Name = "txtChipsPrice";
            this.txtChipsPrice.Size = new System.Drawing.Size(100, 26);
            this.txtChipsPrice.TabIndex = 4;
            this.txtChipsPrice.Text = "55";
            // 
            // txtFishPrice
            // 
            this.txtFishPrice.Location = new System.Drawing.Point(207, 81);
            this.txtFishPrice.Name = "txtFishPrice";
            this.txtFishPrice.Size = new System.Drawing.Size(100, 26);
            this.txtFishPrice.TabIndex = 5;
            this.txtFishPrice.Text = "70";
            // 
            // flpButtons
            // 
            this.flpButtons.Controls.Add(this.btnOrder);
            this.flpButtons.Controls.Add(this.btnCancel);
            this.flpButtons.Controls.Add(this.btnExit);
            this.flpButtons.Location = new System.Drawing.Point(548, 108);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Size = new System.Drawing.Size(123, 180);
            this.flpButtons.TabIndex = 1;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(3, 3);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 51);
            this.btnOrder.TabIndex = 0;
            this.btnOrder.Text = "Замовити";
            this.btnOrder.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(3, 60);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(113, 51);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Відмінити";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 117);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(113, 51);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabBeer.ResumeLayout(false);
            this.tabBeer.PerformLayout();
            this.tabSnacks.ResumeLayout(false);
            this.tabSnacks.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLightBeerQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDarkBeerQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChipsQty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudFishQty)).EndInit();
            this.flpButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBeer;
        private System.Windows.Forms.TabPage tabSnacks;
        private System.Windows.Forms.TextBox txtDarkBeerPrice;
        private System.Windows.Forms.TextBox txtLightBeerPrice;
        private System.Windows.Forms.NumericUpDown nudDarkBeerQty;
        private System.Windows.Forms.NumericUpDown nudLightBeerQty;
        private System.Windows.Forms.Label lblDarkBeer;
        private System.Windows.Forms.Label lblLightBeer;
        private System.Windows.Forms.Label lblFish;
        private System.Windows.Forms.Label lblChips;
        private System.Windows.Forms.TextBox txtFishPrice;
        private System.Windows.Forms.TextBox txtChipsPrice;
        private System.Windows.Forms.NumericUpDown nudFishQty;
        private System.Windows.Forms.NumericUpDown nudChipsQty;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnExit;
    }
}

