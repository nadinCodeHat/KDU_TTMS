using Microsoft.Office.Interop.Outlook;
using System;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class Add_Edit_Calendar_Events : Form
    {
        public Add_Edit_Calendar_Events()
        {
            InitializeComponent();
        }

        private void save_and_close_btn_Click(object sender, EventArgs e)
        {
            try
            {
                Microsoft.Office.Interop.Outlook.Application ApplicationInstance = null;
                AppointmentItem AppointmentInstance = null;
                ApplicationInstance = new Microsoft.Office.Interop.Outlook.Application();
                AppointmentInstance = (AppointmentItem)ApplicationInstance.CreateItem(OlItemType.olAppointmentItem);

                AppointmentInstance.Subject = title_textbox.Text;
                if (location_textbox.TextLength != 0)
                {
                    AppointmentInstance.Location = location_textbox.Text;
                }
                if (all_day_checkbox.Checked)
                {

                    AppointmentInstance.AllDayEvent = true;
                    AppointmentInstance.Start = start_date.Value.Date;
                    AppointmentInstance.End = end_date.Value.Date;
                }
                else
                {
                    AppointmentInstance.Start = start_date.Value.Date + start_time.Value.TimeOfDay;
                    AppointmentInstance.End = end_date.Value.Date + end_time.Value.TimeOfDay;
                }
                if (reminder_combobox.SelectedIndex == 0)
                {
                    AppointmentInstance.ReminderSet = false;

                }
                else
                {
                    AppointmentInstance.ReminderSet = true;
                    if (reminder_combobox.SelectedIndex == 1)
                    {
                        AppointmentInstance.ReminderMinutesBeforeStart = 5;
                    }
                    else if (reminder_combobox.SelectedIndex == 2)
                    {
                        AppointmentInstance.ReminderMinutesBeforeStart = 10;

                    }
                    else if (reminder_combobox.SelectedIndex == 3)
                    {
                        AppointmentInstance.ReminderMinutesBeforeStart = 15;

                    }
                    else if (reminder_combobox.SelectedIndex == 4)
                    {
                        AppointmentInstance.ReminderMinutesBeforeStart = 30;

                    }
                    else if (reminder_combobox.SelectedIndex == 5)
                    {
                        AppointmentInstance.ReminderMinutesBeforeStart = 60;

                    }
                }

                AppointmentInstance.Importance = (OlImportance)importance_combobox.SelectedIndex;
                AppointmentInstance.BusyStatus = (OlBusyStatus)busy_status_combobox.SelectedIndex;
                AppointmentInstance.Save();
                AppointmentInstance.Send();
            }
            catch
            {

            }
            finally
            {
                this.Close();
            }
        }

        private void all_day_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (all_day_checkbox.Checked)
            {
                start_time.Enabled = false;
                end_time.Enabled = false;
            }
            else
            {
                start_time.Enabled = true;
                end_time.Enabled = true;
            }
        }
    }
}
