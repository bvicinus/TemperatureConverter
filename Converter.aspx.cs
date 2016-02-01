using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Converter : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGreatorThan_Click(object sender, EventArgs e)
    {

        //adding an 'm' to the end of any number will treat it as a decimal
        decimal tempInput = 0m; //variable used to save the farhenheit degrees 
        bool isValid = true;
        decimal newTemp = 0m; //converted temp in celcius
        try //try to convert the input to a decimal value
        {
            tempInput = Decimal.Parse(tbFarhenheit.Text);
        }
        catch //if the conversion to a double/decimal was unsuccessful
        {
            isValid = false;
        }

        if (isValid) //valid input
        {
            btnGreatorThan.Enabled = false; //disable buttons and text boxs
            btnLessThan.Enabled = false;
            tbFarhenheit.Enabled = false;
            tbCelsius.Enabled = false;

            //convert tempInput from f to c
            newTemp = (tempInput - 32m) * (5m / 9m); // 5/9

            tbCelsius.Text =  Decimal.Round(newTemp, 1).ToString(); 
            //display the new answer with 1 decimal point 
        }
        else //invalid input 
        {
            btnGreatorThan.Enabled = false; //disable buttons
            btnLessThan.Enabled = false;
            lblInvalid.Visible = true; //display error message
            lblInvalid.Text = "Invalid value for Farhenheit";
            tbFarhenheit.Enabled = false;//disable text boxs
            tbCelsius.Enabled = false;
        }
    }

    protected void btnLessThan_Click(object sender, EventArgs e)
    {
        decimal tempInput = 0m;
        bool isValid = true;
        decimal newTemp = 0m;
        try //to convert the input to a decimal value 
        {
            tempInput = Decimal.Parse(tbCelsius.Text);
        }
        catch //if the conversion to a decimal was unsuccessful
        {
            isValid = false; 
        }

        if (isValid) //valid input
        {
            btnGreatorThan.Enabled = false; //disable buttons and textBoxs
            btnLessThan.Enabled = false;
            tbFarhenheit.Enabled = false;
            tbCelsius.Enabled = false;

            //convert c to f
            newTemp = tempInput * (9m / 5m) + 32m;

            //display the answer with 1 decimal place 
            tbFarhenheit.Text = Decimal.Round(newTemp, 1).ToString();//print to the other text box

        }
        else //invalid input 
        {
            btnGreatorThan.Enabled = false; //disable buttons and textboxes
            btnLessThan.Enabled = false;
            lblInvalid.Visible = true;
            tbFarhenheit.Enabled = false;
            tbCelsius.Enabled = false;
            lblInvalid.Text = "Invalid value for Celsius"; //display error message 

        }
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        tbCelsius.Text = ""; //clear text boxs
        tbFarhenheit.Text = "";
        btnGreatorThan.Enabled = true; //enable buttons 
        btnLessThan.Enabled = true;
        lblInvalid.Visible = false; //hide error message
        tbFarhenheit.Enabled = true;
        tbCelsius.Enabled = true; 
    }

    protected void tbFarhenheit_TextChanged(object sender, EventArgs e)
    {

    }

    protected void tbCelsius_TextChanged(object sender, EventArgs e)
    {

    }
}