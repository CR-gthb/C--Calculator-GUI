using System;
using System.Drawing;
using System.Windows.Forms;

namespace CalcTest;
public partial class Form1 : Form
{


    public Form1()
    {
        InitializeComponent();
        InitializeCalculatorButtons();
    }


    Label display_num = new Label();
    string display_txt = "";
    string sum_num1 = "";
    string sum_num2 = "";
    string operation_sum = "";
    


    private void InitializeCalculatorButtons()
    {
        int startX = 40, startY = 100; // Starting position for the first button
        int buttonWidth = 40, buttonHeight = 40; // Button size
        int padding = 10; // Space between buttons

        int number = 1; // Starting number for the buttons

        for (int row = 0; row < 3; row++)
        {
            for (int column = 0; column < 3; column++)
            {
                // Calculate position based on row and column
                int x = startX + (column * (buttonWidth + padding));
                int y = startY + (row * (buttonHeight + padding));

                // Create and initialize the button
                Button Numpadbutton = new Button
                {
                    Text = number.ToString(),
                    Location = new Point(x, y),
                    Size = new Size(buttonWidth, buttonHeight),
                    BackColor = Color.White
                };

                // Optional: Add a click event handler for the button
                Numpadbutton.Click += NumberPress1_Click;

                // Add the button to the form's controls
                Controls.Add(Numpadbutton);

                number++; // Increment the number for the next button
            }
        }
    }
    public void NumberPress1_Click(object sender, EventArgs e)
    {
        Button button = sender as Button;
        if (button != null)
        {
            display_txt += button.Text;
            display_num.Text = display_txt;
        }
    }

    public void buttonPress_Plus_Click(object sender, EventArgs e)
    {

        //display_txt += sender.GetType().GetProperty("Text").GetValue(sender);
        display_num.Text = display_txt;
        sum_num1 = display_txt;
        display_num.Text = "0"; 
        display_txt = "";
        operation_sum = "+";
        //resetting values and defining the operation for the calculations.

    }
    
    public void buttonPress_Minus_Click(object sender, EventArgs e)
    {

        display_num.Text = display_txt;
        sum_num1 = display_txt;
        display_num.Text = "0"; 
        display_txt = "";
        operation_sum = "-";
        //operation sum will be used to signify what form of calculation is used when the final sum is being worked out.

    }

    public void buttonPress_division_Click(object sender, EventArgs e)
    {

        display_num.Text = display_txt;
        sum_num1 = display_txt;
        display_num.Text = "0"; 
        display_txt = "";
        operation_sum = "/";

    }

    public void buttonPress_Multiply_Click(object sender, EventArgs e)
    {

        display_num.Text = display_txt;
        sum_num1 = display_txt;
        ///Reseting the Display and values therefor next time it is added a value by user input
        ///it is null/empty therefore it does not add onto a persistant input from previous calculations.
        display_num.Text = "0"; 
        display_txt = "";
        operation_sum = "*";

    }

    public void buttonPress_multiplication_Click(object sender, EventArgs e)
    {

        display_num.Text = display_txt;
        sum_num1 = display_txt;
        display_num.Text = "0"; 
        display_txt = "";
        operation_sum = "*";

    }




    public void buttonPress_equals_Click(object sender, EventArgs e)
    {
        float final_Sum;
        sum_num2 = display_txt;
        ///when the "=" is clicked the code will check if the "*" or "/" or "-" or "+" was clicked
        ///if the operation_sum is equal to one of the signs, the operation sum will complete the corresponding equation.

        if (operation_sum == "+")
        {

            float s1 = float.Parse(sum_num1);
            float s2 = float.Parse(sum_num2);
            final_Sum = s1 + s2;
            

            display_num.Text = "";
            display_txt = "";

            display_num.Text = final_Sum.ToString();
            sum_num1 = "";
            sum_num2 = "";
            
            

        }
        


        if (operation_sum == "-")
        {

            float s1 = float.Parse(sum_num1);
            float s2 = float.Parse(sum_num2);
            final_Sum = s1 - s2;
            

            display_num.Text = "";
            display_txt = "";

            display_num.Text = final_Sum.ToString();
            sum_num1 = "";
            sum_num2 = "";


        }


        if (operation_sum == "/")
        {

            float s1 = float.Parse(sum_num1);
            float s2 = float.Parse(sum_num2);
            final_Sum = s1 / s2;
            

            display_num.Text = "";
            display_txt = "";

            display_num.Text = final_Sum.ToString();
            sum_num1 = "";
            sum_num2 = "";

        }

        if (operation_sum == "*")
        {

            float s1 = float.Parse(sum_num1);
            float s2 = float.Parse(sum_num2);
            final_Sum = s1 * s2;
            

            display_num.Text = "";
            display_txt = "";

            display_num.Text = final_Sum.ToString();
            sum_num1 = "";
            sum_num2 = "";

        }

        else
        {

            
        }
        
        


        

    }




}