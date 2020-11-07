namespace Sokszögek.Views
{
    partial class SokszogForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.OldalALable = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.KeruletTextBox = new System.Windows.Forms.TextBox();
            this.TeruletTextBox = new System.Windows.Forms.TextBox();
            this.OldalATextBox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.errorPOldalA = new System.Windows.Forms.ErrorProvider(this.components);
            this.oldalBTextBox = new System.Windows.Forms.TextBox();
            this.OladlBLable = new System.Windows.Forms.Label();
            this.errorPOldalB = new System.Windows.Forms.ErrorProvider(this.components);
            this.OldalCLable = new System.Windows.Forms.Label();
            this.OldalCTextBox1 = new System.Windows.Forms.TextBox();
            this.errorPOldalC = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorPOldalA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPOldalB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPOldalC)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SokSzög";
            // 
            // OldalALable
            // 
            this.OldalALable.AutoSize = true;
            this.OldalALable.Location = new System.Drawing.Point(245, 26);
            this.OldalALable.Name = "OldalALable";
            this.OldalALable.Size = new System.Drawing.Size(41, 13);
            this.OldalALable.TabIndex = 1;
            this.OldalALable.Text = "Oldal A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kerület";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Terület";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(73, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(150, 21);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.SelectedValueChanged += new System.EventHandler(this.comboBox1_SelectedValueChanged);
            // 
            // KeruletTextBox
            // 
            this.KeruletTextBox.Location = new System.Drawing.Point(74, 71);
            this.KeruletTextBox.Name = "KeruletTextBox";
            this.KeruletTextBox.Size = new System.Drawing.Size(150, 20);
            this.KeruletTextBox.TabIndex = 5;
            // 
            // TeruletTextBox
            // 
            this.TeruletTextBox.Location = new System.Drawing.Point(74, 111);
            this.TeruletTextBox.Name = "TeruletTextBox";
            this.TeruletTextBox.Size = new System.Drawing.Size(150, 20);
            this.TeruletTextBox.TabIndex = 6;
            // 
            // OldalATextBox
            // 
            this.OldalATextBox.Location = new System.Drawing.Point(286, 26);
            this.OldalATextBox.Name = "OldalATextBox";
            this.OldalATextBox.Size = new System.Drawing.Size(150, 20);
            this.OldalATextBox.TabIndex = 7;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(35, 191);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 8;
            this.CalculateButton.Text = "Kiszámol";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // errorPOldalA
            // 
            this.errorPOldalA.ContainerControl = this;
            // 
            // oldalBTextBox
            // 
            this.oldalBTextBox.Location = new System.Drawing.Point(286, 52);
            this.oldalBTextBox.Name = "oldalBTextBox";
            this.oldalBTextBox.Size = new System.Drawing.Size(150, 20);
            this.oldalBTextBox.TabIndex = 9;
            // 
            // OladlBLable
            // 
            this.OladlBLable.AutoSize = true;
            this.OladlBLable.Location = new System.Drawing.Point(245, 55);
            this.OladlBLable.Name = "OladlBLable";
            this.OladlBLable.Size = new System.Drawing.Size(41, 13);
            this.OladlBLable.TabIndex = 10;
            this.OladlBLable.Text = "Oldal B";
            // 
            // errorPOldalB
            // 
            this.errorPOldalB.ContainerControl = this;
            // 
            // OldalCLable
            // 
            this.OldalCLable.AutoSize = true;
            this.OldalCLable.Location = new System.Drawing.Point(245, 81);
            this.OldalCLable.Name = "OldalCLable";
            this.OldalCLable.Size = new System.Drawing.Size(41, 13);
            this.OldalCLable.TabIndex = 11;
            this.OldalCLable.Text = "Oldal C";
            this.OldalCLable.Click += new System.EventHandler(this.OldalCLable_Click);
            // 
            // OldalCTextBox1
            // 
            this.OldalCTextBox1.Location = new System.Drawing.Point(286, 78);
            this.OldalCTextBox1.Name = "OldalCTextBox1";
            this.OldalCTextBox1.Size = new System.Drawing.Size(150, 20);
            this.OldalCTextBox1.TabIndex = 12;
            // 
            // errorPOldalC
            // 
            this.errorPOldalC.ContainerControl = this;
            // 
            // SokszogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 261);
            this.Controls.Add(this.OldalCTextBox1);
            this.Controls.Add(this.OldalCLable);
            this.Controls.Add(this.OladlBLable);
            this.Controls.Add(this.oldalBTextBox);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.OldalATextBox);
            this.Controls.Add(this.TeruletTextBox);
            this.Controls.Add(this.KeruletTextBox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.OldalALable);
            this.Controls.Add(this.label1);
            this.Name = "SokszogForm";
            this.Text = "SzokszogForm";
            this.Load += new System.EventHandler(this.SokszogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorPOldalA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPOldalB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorPOldalC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label OldalALable;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox KeruletTextBox;
        private System.Windows.Forms.TextBox TeruletTextBox;
        private System.Windows.Forms.TextBox OldalATextBox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.ErrorProvider errorPOldalA;
        private System.Windows.Forms.Label OladlBLable;
        private System.Windows.Forms.TextBox oldalBTextBox;
        private System.Windows.Forms.ErrorProvider errorPOldalB;
        private System.Windows.Forms.TextBox OldalCTextBox1;
        private System.Windows.Forms.Label OldalCLable;
        private System.Windows.Forms.ErrorProvider errorPOldalC;
    }
}