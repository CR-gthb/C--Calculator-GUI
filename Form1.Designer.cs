namespace CalcTest;

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
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(250, 300);
        this.Text = "Calculator (By C.R)";


        display_num = new Label()
        {
            Location = new Point(40, 5),
            Text = "0",
            BorderStyle = BorderStyle.FixedSingle,
            //BackColor = Color.Gray,
            Width = 150,
            Height = 40,
            BackColor = Color.White,
            TextAlign = ContentAlignment.BottomRight,
            Font = new Font("Microsoft Sans Serif", 20, FontStyle.Regular) // Setting the font size to 20
        };
        
        Controls.Add(display_num);


        Button button_num_Plus_Symbol = new Button()
        {
        Text = "+", 
        Location = new Point(190, 100),
        Width = 40,
        Height= 40,
        BackColor = Color.White
        };

        Controls.Add(button_num_Plus_Symbol);

        Button button_num_Minus_Symbol = new Button()
        {
        Text = "-", 
        Location = new Point(190, 50),
        Width = 40,
        Height= 40,
        BackColor = Color.White
        };

        Controls.Add(button_num_Minus_Symbol);

       Button button_num_Equals = new Button()
       {

        Text = "=", 
        Location = new Point(190, 150),
        Width = 40,
        Height= 90,
        BackColor = Color.White,
        
        };

        Controls.Add(button_num_Equals);

        Button button_num_Division = new Button()
        {
        Text = "/", 
        Location = new Point(90, 50),
        Width = 40,
        Height= 40,
        BackColor = Color.White
        };
        Controls.Add(button_num_Division);


        Button button_num_Multiply = new Button(){Text = "*", 
        
        Location = new Point(140, 50),
        Width = 40,
        Height= 40,
        BackColor = Color.White

        };
        Controls.Add(button_num_Multiply);


        button_num_Division.Click += new System.EventHandler(buttonPress_division_Click);
        button_num_Minus_Symbol.Click += new System.EventHandler(buttonPress_Minus_Click);
        button_num_Plus_Symbol.Click += new System.EventHandler(buttonPress_Plus_Click);
        button_num_Equals.Click += new System.EventHandler(buttonPress_equals_Click);
        button_num_Multiply.Click += new System.EventHandler(buttonPress_multiplication_Click);


    }







    #endregion
}
