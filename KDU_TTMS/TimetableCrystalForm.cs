using CrystalDecisions.CrystalReports.Engine;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KDU_Time_Table_Management_System
{
    public partial class TimetableCrystalForm : Form
    {
        MySqlConnection databaseConnection = new MySqlConnection("datasource=127.0.0.1;port=3306;username=root;password=;database=ttms_db");

        ReportDocument crypt = new ReportDocument();

        private string intakeval;
        private string degree_prog, semester, week;
        private string validity_period_start, validity_period_end;

        private void CrystalReportForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                string message = "Please save your work before closing this window" + Environment.NewLine + "Confirm close?";
                string title = "Close Window";
                DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        public TimetableCrystalForm()
        {
            InitializeComponent();
        }

        public TimetableCrystalForm(string intakeval, string week, string degree_prog, string semester, string validity_period_start, string validity_period_end)
        {
            this.intakeval = intakeval;
            this.week = week;
            this.degree_prog = degree_prog;
            this.semester = semester;
            this.validity_period_start = validity_period_start;
            this.validity_period_end = validity_period_end;
            InitializeComponent();
        }

        private void allocateTimetable(CrystalReport1 cr1, DataRow dr, string lectureAbbr, string strength, string lectureHall)
        {
            (cr1.ReportDefinition.ReportObjects[lectureAbbr] as TextObject).Text = dr["lecture_abbr"].ToString();

            (cr1.ReportDefinition.ReportObjects[strength] as TextObject).Text = dr["strength"].ToString();

            (cr1.ReportDefinition.ReportObjects[lectureHall] as TextObject).Text = dr["lecture_hall"].ToString();
        }

        private void TimetableCrystalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Dispose();
        }

        private void adjustLocations(CrystalReport1 cr1, int top, int left, string object_name)
        {
            (cr1.ReportDefinition.ReportObjects[object_name] as TextObject).Left = left;
            (cr1.ReportDefinition.ReportObjects[object_name] as TextObject).Top = top;
        }


        private void loadTimetableInfo()
        {
            databaseConnection.Open();

            MySqlCommand cmmd = new MySqlCommand("SELECT MAX(timetable_id) FROM ttms_timetable_main", databaseConnection);
            string maxID = cmmd.ExecuteScalar().ToString();

            string s = "select ttms_lecture_module.lecture_abbr,ttms_lecture_module.day,ttms_lecture_module.lecture_hall,ttms_lecture_module.strength,ttms_lecture_module.time_slot from ttms_timetable_main inner join ttms_lecture_module on ttms_lecture_module.timetable_id = ttms_timetable_main.timetable_id where ttms_timetable_main.timetable_id ='" + maxID + "'";// And ttms_timetable_main.validity_period_start = '" + validity_period_start + "'";

            //string s = "select ttms_timetable_initiate_table.timetable_id,ttms_lecture_module_table.lecture_abbr,ttms_lecture_module_table.day,ttms_lecture_module_table.lecture_hall,ttms_lecture_module_table.strength,ttms_lecture_module_table.time_slot from ttms_timetable_initiate_table inner join ttms_degree_programme_table on ttms_degree_programme_table.degree_programme_id = ttms_timetable_initiate_table.degree_programme_id inner join ttms_lecture_module_table on ttms_lecture_module_table.timetable_id = ttms_timetable_initiate_table.timetable_id where ttms_timetable_initiate_table.intake ='" + intakeval + "' And ttms_timetable_initiate_table.validity_period_start = '" + validity_period_start + "'";

            //           MySqlCommand sda = new MySqlCommand("SELECT lecture_code, lecture_abbr, lecture_module, lecturer_name, credit, gpatype, module_type FROM module_info WHERE semester = '" + 3 + "'",databaseConnection);
            //           MySqlDataAdapter adap1 = new MySqlDataAdapter(sda);
            //           DataSet ds1 = new DataSet();
            //           adap1.Fill(ds1, "module_info");

            //CrystalReport1 objRpt = new CrystalReport1();
            //cr1.SetDataSource(ds1);
            //crystalReportViewer1.ReportSource = cr1;
            //crystalReportViewer1.Refresh();

            CrystalReport1 cr1 = new CrystalReport1();
            MySqlCommand cmd = new MySqlCommand(s, databaseConnection);
            MySqlDataAdapter adap = new MySqlDataAdapter(cmd);

            DataSet_getTT_module_info ds = new DataSet_getTT_module_info();
            DataTable dt = new DataTable();
            adap.Fill(ds, "getTimetableInfo");


            dt = ds.Tables["getTimetableInfo"];

            foreach (DataRow dr in dt.Rows)
            {
                //MessageBox.Show(dr["time_slot"].ToString());
                if (dr["day"].ToString() == "Monday")
                {
                    if (dr["time_slot"].ToString() == "0800 - 0900")
                    {
                        allocateTimetable(cr1, dr, "Text30", "Text67", "Text71");
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text30", "Text67", "Text71");
                        adjustLocations(cr1, 2160, 1680, "Text30");
                        adjustLocations(cr1, 2160, 3360, "Text67");
                        adjustLocations(cr1, 2160, 4200, "Text71");
                        (cr1.ReportDefinition.ReportObjects["Line1"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text31", "Text68", "Text72");
                        (cr1.ReportDefinition.ReportObjects["Line1"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line24"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;

                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text31", "Text68", "Text72");
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text31", "Text68", "Text72");
                        adjustLocations(cr1, 2640, 1680, "Text31");
                        adjustLocations(cr1, 2640, 3360, "Text68");
                        adjustLocations(cr1, 2640, 4200, "Text72");
                        (cr1.ReportDefinition.ReportObjects["Line24"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1000 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text32", "Text69", "Text70");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1215")
                    {
                        allocateTimetable(cr1, dr, "Text5", "Text73", "Text76");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text5", "Text73", "Text76");
                        adjustLocations(cr1, 3960, 1680, "Text31");
                        adjustLocations(cr1, 3960, 3360, "Text68");
                        adjustLocations(cr1, 3960, 4200, "Text72");
                        (cr1.ReportDefinition.ReportObjects["Line25"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text29", "Text74", "Text77");
                        (cr1.ReportDefinition.ReportObjects["Line25"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line31"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text29", "Text74", "Text77");
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text29", "Text74", "Text77");
                        adjustLocations(cr1, 4440, 1680, "Text31");
                        adjustLocations(cr1, 4440, 3360, "Text68");
                        adjustLocations(cr1, 4440, 4200, "Text72");
                        (cr1.ReportDefinition.ReportObjects["Line31"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1315 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text42", "Text75", "Text78");
                    }
                    else if (dr["time_slot"].ToString() == "1430 - 1615")
                    {
                        allocateTimetable(cr1, dr, "Text128", "Text134", "Text135");
                    }
                }
                else if (dr["day"].ToString() == "Tuesday")
                {
                    if (dr["time_slot"].ToString() == "0800 - 0900")
                    {
                        allocateTimetable(cr1, dr, "Text43", "Text65", "Text84");
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text43", "Text65", "Text84");
                        adjustLocations(cr1, 2160, 5160, "Text43");
                        adjustLocations(cr1, 2160, 6720, "Text65");
                        adjustLocations(cr1, 2160, 7560, "Text84");
                        (cr1.ReportDefinition.ReportObjects["Line2"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text45", "Text66", "Text85");
                        (cr1.ReportDefinition.ReportObjects["Line2"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line4"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text45", "Text66", "Text85");
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text45", "Text66", "Text85");
                        adjustLocations(cr1, 2640, 5160, "Text45");
                        adjustLocations(cr1, 2640, 6720, "Text66");
                        adjustLocations(cr1, 2640, 7560, "Text85");
                        (cr1.ReportDefinition.ReportObjects["Line4"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;

                    }
                    else if (dr["time_slot"].ToString() == "1000 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text44", "Text79", "Text83");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1215")
                    {
                        allocateTimetable(cr1, dr, "Text46", "Text81", "Text87");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text46", "Text81", "Text87");
                        adjustLocations(cr1, 3960, 5160, "Text46");
                        adjustLocations(cr1, 3960, 6720, "Text81");
                        adjustLocations(cr1, 3960, 7560, "Text87");
                        (cr1.ReportDefinition.ReportObjects["Line8"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;

                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text47", "Text82", "Text88");
                        (cr1.ReportDefinition.ReportObjects["Line8"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line11"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text47", "Text82", "Text88");
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text47", "Text82", "Text88");
                        adjustLocations(cr1, 4440, 5160, "Text47");
                        adjustLocations(cr1, 4440, 6720, "Text82");
                        adjustLocations(cr1, 4440, 7560, "Text88");
                        (cr1.ReportDefinition.ReportObjects["Line11"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;

                    }
                    else if (dr["time_slot"].ToString() == "1315 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text48", "Text80", "Text86");
                    }
                    else if (dr["time_slot"].ToString() == "1430 - 1615")
                    {
                        allocateTimetable(cr1, dr, "Text129", "Text103", "Text104");
                    }
                }
                else if (dr["day"].ToString() == "Wednesday")
                {
                    if (dr["time_slot"].ToString() == "0800 - 0900")
                    {
                        allocateTimetable(cr1, dr, "Text22", "Text91", "Text94");
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text22", "Text91", "Text94");
                        adjustLocations(cr1, 2160, 8520, "Text22");
                        adjustLocations(cr1, 2160, 10080, "Text91");
                        adjustLocations(cr1, 2160, 10800, "Text94");
                        (cr1.ReportDefinition.ReportObjects["Line5"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text20", "Text92", "Text95");
                        (cr1.ReportDefinition.ReportObjects["Line5"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line12"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text20", "Text92", "Text95");
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text20", "Text92", "Text95");
                        adjustLocations(cr1, 2640, 8520, "Text20");
                        adjustLocations(cr1, 2640, 10080, "Text92");
                        adjustLocations(cr1, 2640, 10800, "Text95");
                        (cr1.ReportDefinition.ReportObjects["Line12"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1000 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text21", "Text93", "Text96");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1215")
                    {
                        allocateTimetable(cr1, dr, "Text25", "Text116", "Text100");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text25", "Text116", "Text100");
                        adjustLocations(cr1, 3960, 8520, "Text25");
                        adjustLocations(cr1, 3960, 10080, "Text116");
                        adjustLocations(cr1, 3960, 10800, "Text100");
                        (cr1.ReportDefinition.ReportObjects["Line32"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text23", "Text117", "Text101");
                        (cr1.ReportDefinition.ReportObjects["Line32"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line33"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text23", "Text117", "Text101");
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text23", "Text117", "Text101");
                        adjustLocations(cr1, 4440, 8520, "Text23");
                        adjustLocations(cr1, 4440, 10080, "Text117");
                        adjustLocations(cr1, 4440, 10800, "Text101");
                        (cr1.ReportDefinition.ReportObjects["Line33"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1315 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text24", "Text118", "Text102");
                    }
                    else if (dr["time_slot"].ToString() == "1430 - 1615")
                    {
                        allocateTimetable(cr1, dr, "Text55", "Text105", "Text106");
                    }
                }
                else if (dr["day"].ToString() == "Thursday")
                {
                    if (dr["time_slot"].ToString() == "0800 - 0900")
                    {
                        allocateTimetable(cr1, dr, "Text51", "Text108", "Text111");
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text51", "Text108", "Text111");
                        adjustLocations(cr1, 2160, 11760, "Text51");
                        adjustLocations(cr1, 2160, 13440, "Text108");
                        adjustLocations(cr1, 2160, 14280, "Text111");
                        (cr1.ReportDefinition.ReportObjects["Line17"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text49", "Text109", "Text112");
                        (cr1.ReportDefinition.ReportObjects["Line17"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line35"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text49", "Text109", "Text112");
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text49", "Text109", "Text112");
                        adjustLocations(cr1, 2640, 11760, "Text49");
                        adjustLocations(cr1, 2640, 13440, "Text109");
                        adjustLocations(cr1, 2640, 14280, "Text112");
                        (cr1.ReportDefinition.ReportObjects["Line35"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1000 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text50", "Text110", "Text113");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1215")
                    {
                        allocateTimetable(cr1, dr, "Text54", "Text97", "Text119");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text54", "Text97", "Text119");
                        adjustLocations(cr1, 3960, 11760, "Text54");
                        adjustLocations(cr1, 3960, 13440, "Text97");
                        adjustLocations(cr1, 3960, 14280, "Text119");
                        (cr1.ReportDefinition.ReportObjects["Line36"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text52", "Text98", "Text120");
                        (cr1.ReportDefinition.ReportObjects["Line36"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line37"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text52", "Text98", "Text120");
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text52", "Text98", "Text120");
                        adjustLocations(cr1, 4440, 11760, "Text52");
                        adjustLocations(cr1, 4440, 13440, "Text98");
                        adjustLocations(cr1, 4440, 14280, "Text120");
                        (cr1.ReportDefinition.ReportObjects["Line37"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1315 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text53", "Text99", "Text121");
                    }
                    else if (dr["time_slot"].ToString() == "1430 - 1615")
                    {
                        allocateTimetable(cr1, dr, "Text26", "Text122", "Text123");
                    }
                }
                else if (dr["day"].ToString() == "Friday")
                {
                    if (dr["time_slot"].ToString() == "0800 - 0900")
                    {
                        allocateTimetable(cr1, dr, "Text62", "Text126", "Text131");
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text62", "Text126", "Text131");
                        adjustLocations(cr1, 2160, 15360, "Text62");
                        adjustLocations(cr1, 2160, 17040, "Text126");
                        adjustLocations(cr1, 2160, 18000, "Text131");
                        (cr1.ReportDefinition.ReportObjects["Line16"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0800 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text60", "Text127", "Text132");
                        (cr1.ReportDefinition.ReportObjects["Line16"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line41"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1000")
                    {
                        allocateTimetable(cr1, dr, "Text60", "Text127", "Text132");
                    }
                    else if (dr["time_slot"].ToString() == "0900 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text60", "Text127", "Text132");
                        adjustLocations(cr1, 2640, 15360, "Text60");
                        adjustLocations(cr1, 2640, 17040, "Text127");
                        adjustLocations(cr1, 2640, 18000, "Text132");
                        (cr1.ReportDefinition.ReportObjects["Line41"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1000 - 1100")
                    {
                        allocateTimetable(cr1, dr, "Text61", "Text130", "Text133");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1215")
                    {
                        allocateTimetable(cr1, dr, "Text59", "Text136", "Text139");
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text59", "Text136", "Text139");
                        adjustLocations(cr1, 3960, 15360, "Text59");
                        adjustLocations(cr1, 3960, 17040, "Text136");
                        adjustLocations(cr1, 3960, 18000, "Text139");
                        (cr1.ReportDefinition.ReportObjects["Line21"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1115 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text57", "Text137", "Text140");
                        (cr1.ReportDefinition.ReportObjects["Line21"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                        (cr1.ReportDefinition.ReportObjects["Line43"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1315")
                    {
                        allocateTimetable(cr1, dr, "Text57", "Text137", "Text140");
                    }
                    else if (dr["time_slot"].ToString() == "1215 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text57", "Text137", "Text140");
                        adjustLocations(cr1, 4440, 15360, "Text57");
                        adjustLocations(cr1, 4440, 17040, "Text137");
                        adjustLocations(cr1, 4440, 18000, "Text140");
                        (cr1.ReportDefinition.ReportObjects["Line43"] as LineObject).LineStyle = CrystalDecisions.Shared.LineStyle.NoLine;
                    }
                    else if (dr["time_slot"].ToString() == "1315 - 1415")
                    {
                        allocateTimetable(cr1, dr, "Text58", "Text138", "Text141");
                    }
                    else if (dr["time_slot"].ToString() == "1430 - 1615")
                    {
                        allocateTimetable(cr1, dr, "Text56", "Text142", "Text143");
                    }
                }
            }

            (cr1.ReportDefinition.ReportObjects["Text8"] as TextObject).Text = degree_prog + " - Intake " + intakeval + " - " + "Timetable - " + " Semester - " + semester;

            (cr1.ReportDefinition.ReportObjects["Text3"] as TextObject).Text = week;

            (cr1.ReportDefinition.ReportObjects["Text9"] as TextObject).Text = validity_period_start;

            (cr1.ReportDefinition.ReportObjects["Text10"] as TextObject).Text = validity_period_end;

            MySqlDataAdapter sda = new MySqlDataAdapter("SELECT lecture_code, lecture_abbr, lecture_module, lecturer, credit, gpatype, module_type FROM module_info WHERE semester = '" + semester + "'", databaseConnection);
            sda.Fill(ds, "module_info");

            cr1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();

        }


        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            loadTimetableInfo();
            //CrystalReport1 cr1 = new CrystalReport1();
            //DataSet2 ds = new DataSet2();
            //MySqlDataAdapter sda = new MySqlDataAdapter("SELECT lecture_code, lecture_abbr, lecture_module, lecturer_name, credit, gpatype, module_type FROM module_info WHERE semester = '" + 3 + "'", databaseConnection);
            //sda.Fill(ds, "module_info");
            //cr1.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = cr1;
            //crystalReportViewer1.Refresh();
        }
    }
}
