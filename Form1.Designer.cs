namespace UATassignment2._1._1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            Simple = new RadioButton();
            Compound = new RadioButton();
            DepositAmount = new TextBox();
            todaysDate = new DateTimePicker();
            maturityDate = new MonthCalendar();
            button1 = new Button();
            ReturnAmount = new RichTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            InterestRate = new NumericUpDown();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)InterestRate).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Simple);
            groupBox1.Controls.Add(Compound);
            groupBox1.Location = new Point(21, 260);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(137, 102);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Interest"; //changes text to interest
            groupBox1.Enter += GroupBox1_Enter;
            // 
            // Simple
            // 
            Simple.AutoSize = true;
            Simple.Location = new Point(6, 59);
            Simple.Name = "Simple"; // changes radiobutton 1 to simple
            Simple.Size = new Size(61, 19);
            Simple.TabIndex = 6;
            Simple.TabStop = true;
            Simple.Text = "Simple"; //changes the text for radio button to simple
            Simple.UseVisualStyleBackColor = true;
            Simple.CheckedChanged += RadioButton2_CheckedChanged;
            // 
            // Compound
            // 
            Compound.AutoSize = true;
            Compound.Location = new Point(6, 34);
            Compound.Name = "Compound"; // changes Radiobutton2 to Compound
            Compound.Size = new Size(86, 19);
            Compound.TabIndex = 5;
            Compound.TabStop = true;
            Compound.Text = "Compound"; //Changes the text for Radio button
            Compound.UseVisualStyleBackColor = true;
            Compound.CheckedChanged += RadioButton1_CheckedChanged;
            // 
            // DepositAmount
            // 
            DepositAmount.Location = new Point(29, 49);
            DepositAmount.Name = "DepositAmount"; //Changes Textbox1 to DepositAmount
            DepositAmount.Size = new Size(135, 23);
            DepositAmount.TabIndex = 1;
            DepositAmount.TextChanged += TextBox1_TextChanged;
            // 
            // todaysDate
            // 
            todaysDate.Location = new Point(281, 49);
            todaysDate.Name = "todaysDate"; //Changes datepicker to todaysDate
            todaysDate.Size = new Size(227, 23);
            todaysDate.TabIndex = 3;
            todaysDate.ValueChanged += DateTimePicker1_ValueChanged;
            // 
            // maturityDate
            // 
            maturityDate.Location = new Point(281, 113);
            maturityDate.MaxSelectionCount = 1;
            maturityDate.Name = "maturityDate"; //MonthCalendar1 to maturityDate
            maturityDate.TabIndex = 4;
            maturityDate.DateChanged += MonthCalendar1_DateChanged;
            // 
            // button1
            // 
            button1.Location = new Point(571, 382);
            button1.Name = "button1";
            button1.Size = new Size(137, 23);
            button1.TabIndex = 5;
            button1.Text = "Show Me the Money"; //Changes text inside the button to this
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // ReturnAmount
            // 
            ReturnAmount.Location = new Point(264, 309);
            ReturnAmount.Name = "ReturnAmount"; // changes the variable name to ReturnAmount
            ReturnAmount.ReadOnly = true;
            ReturnAmount.Size = new Size(244, 96);
            ReturnAmount.TabIndex = 6;
            ReturnAmount.Text = "";
            ReturnAmount.TextChanged += RichTextBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(281, 29);
            label1.Name = "label1";
            label1.Size = new Size(74, 15);
            label1.TabIndex = 7;
            label1.Text = "Today's Date"; //Changes label1 text
            label1.Click += Label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 29);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 8;
            label2.Text = "Principal amount"; //Changes label2 text
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(32, 95);
            label3.Name = "label3";
            label3.Size = new Size(72, 15);
            label3.TabIndex = 9;
            label3.Text = "Interest Rate"; //Changes label3 text
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(264, 294);
            label4.Name = "label4";
            label4.Size = new Size(91, 15);
            label4.TabIndex = 10;
            label4.Text = "Return Message"; //Changes label4 text
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(281, 95);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 11;
            label5.Text = "Maturity Date"; //Changes label5 text
            // 
            // InterestRate
            // 
            InterestRate.DecimalPlaces = 1;
            InterestRate.Increment = new decimal(new int[] { 1, 0, 0, 65536 }); //changes the amount of increment to 0.1
            InterestRate.Location = new Point(32, 122);
            InterestRate.Name = "InterestRate"; //Changes numericdown to InterestRate
            InterestRate.Size = new Size(120, 23);
            InterestRate.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(InterestRate);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(ReturnAmount);
            Controls.Add(button1);
            Controls.Add(maturityDate);
            Controls.Add(todaysDate);
            Controls.Add(DepositAmount);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)InterestRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton Simple;
        private RadioButton Compound;
        private TextBox DepositAmount;
        private DateTimePicker todaysDate;
        private MonthCalendar maturityDate;
        private Button button1;
        private RichTextBox ReturnAmount;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private NumericUpDown InterestRate;
    }
}
