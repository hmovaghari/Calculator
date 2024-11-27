// Generated Windows form code by JIT.Dev

namespace Calculator.Windows
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}

namespace Calculator.Windows
{
    internal partial class MainForm : Form
    {
        private double result;
        private string operation;
        private double operand;
        private bool operationPerformed;

        public MainForm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((displayTextBox.Text == "0") || operationPerformed)
                displayTextBox.Clear();

            operationPerformed = false;
            Button button = (Button)sender;
            displayTextBox.Text += button.Text;
        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (result != 0)
            {
                equalButton.PerformClick();
                operationPerformed = true;
                operation = button.Text;
            }
            else
            {
                operation = button.Text;
                operand = double.Parse(displayTextBox.Text);
                result = operand;
                operationPerformed = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
            result = 0;
            operand = 0;
            operation = string.Empty;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    displayTextBox.Text = (result + double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "-":
                    displayTextBox.Text = (result - double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "*":
                    displayTextBox.Text = (result * double.Parse(displayTextBox.Text)).ToString();
                    break;
                case "/":
                    displayTextBox.Text = (result / double.Parse(displayTextBox.Text)).ToString();
                    break;
                default:
                    break;
            }
            result = double.Parse(displayTextBox.Text);
            operation = string.Empty;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            displayTextBox.Text = "0";
        }
    }
}

namespace Calculator.Windows
{
    internal partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.equalButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.subButton = new System.Windows.Forms.Button();
            this.mulButton = new System.Windows.Forms.Button();
            this.divButton = new System.Windows.Forms.Button();
            this.SuspendLayout();

            this.displayTextBox.Location = new System.Drawing.Point(12, 12);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.ReadOnly = true;
            this.displayTextBox.Size = new System.Drawing.Size(260, 20);
            this.displayTextBox.TabIndex = 0;
            this.displayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;

            // Button Configuration
            this.clearButton.Location = new System.Drawing.Point(12, 38);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(60, 60);
            this.clearButton.Text = "C";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);

            this.equalButton.Location = new System.Drawing.Point(212, 38);
            this.equalButton.Name = "equalButton";
            this.equalButton.Size = new System.Drawing.Size(60, 60);
            this.equalButton.Text = "=";
            this.equalButton.UseVisualStyleBackColor = true;
            this.equalButton.Click += new System.EventHandler(this.equalButton_Click);

            this.button1.Location = new System.Drawing.Point(12, 104);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 60);
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Click);

            this.button2.Location = new System.Drawing.Point(78, 104);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(60, 60);
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button_Click);

            this.button3.Location = new System.Drawing.Point(144, 104);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 60);
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_Click);

            this.button4.Location = new System.Drawing.Point(12, 170);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(60, 60);
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button_Click);

            this.button5.Location = new System.Drawing.Point(78, 170);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 60);
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button_Click);

            this.button6.Location = new System.Drawing.Point(144, 170);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(60, 60);
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button_Click);

            this.button7.Location = new System.Drawing.Point(12, 236);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(60, 60);
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button_Click);

            this.button8.Location = new System.Drawing.Point(78, 236);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(60, 60);
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button_Click);

            this.button9.Location = new System.Drawing.Point(144, 236);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(60, 60);
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button_Click);

            this.button0.Location = new System.Drawing.Point(78, 302);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(60, 60);
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.button_Click);

            this.addButton.Location = new System.Drawing.Point(212, 104);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(60, 60);
            this.addButton.Text = "+";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.operator_Click);

            this.subButton.Location = new System.Drawing.Point(212, 170);
            this.subButton.Name = "subButton";
            this.subButton.Size = new System.Drawing.Size(60, 60);
            this.subButton.Text = "-";
            this.subButton.UseVisualStyleBackColor = true;
            this.subButton.Click += new System.EventHandler(this.operator_Click);

            this.mulButton.Location = new System.Drawing.Point(212, 236);
            this.mulButton.Name = "mulButton";
            this.mulButton.Size = new System.Drawing.Size(60, 60);
            this.mulButton.Text = "*";
            this.mulButton.UseVisualStyleBackColor = true;
            this.mulButton.Click += new System.EventHandler(this.operator_Click);

            this.divButton.Location = new System.Drawing.Point(212, 302);
            this.divButton.Name = "divButton";
            this.divButton.Size = new System.Drawing.Size(60, 60);
            this.divButton.Text = "/";
            this.divButton.UseVisualStyleBackColor = true;
            this.divButton.Click += new System.EventHandler(this.operator_Click);

            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.equalButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.subButton);
            this.Controls.Add(this.mulButton);
            this.Controls.Add(this.divButton);
            this.Name = "MainForm";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button equalButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button subButton;
        private System.Windows.Forms.Button mulButton;
        private System.Windows.Forms.Button divButton;
    }
}