using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class scheduling
    {
        int pin = 12345;
        public void ScheduleInterview(string email, DateTime interviewDate)
        {
            MessageBox.Show("Enter the pin to schedule the interview");
            TextBox textBox = new TextBox();
            textBox.Text = "Enter pin";
            Button button = new Button();
            button.Text = "Submit";
            if (pin == 12345)
            {
                MessageBox.Show($"Interview scheduled for {email} on {interviewDate}");
            }
            else
            {
                MessageBox.Show("");
            }

        }
    }
}

