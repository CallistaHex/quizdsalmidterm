using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace quizdsalmidterm
{
    public partial class Form1 : Form
    {
        // Change Data Source if your SQL Server instance is different (e.g. localhost or .\SQLEXPRESS)
        private const string ConnectionString =

    @"Data Source=.\SQLEXPRESS;Initial Catalog=MidtermDb;Integrated Security=True";

        // Monthly HDMF contribution from the instructions
        private const decimal HdmfContribution = 100.00m;

        private const string InsertSql = @"
            INSERT INTO quizTbl
                (CompanyName, Department, EmployeeCode, CutOff, EmployeeName, PayPeriod,
                 BasicPay, Overtime, Absences, Honorarium, Tardy, GrossEarnings,
                 SSSContribution, PhilHealthContribution, HDMFContribution,
                 TotalDeductions, NetPay)
            VALUES
                (@CompanyName, @Department, @EmployeeCode, @CutOff, @EmployeeName, @PayPeriod,
                 @BasicPay, @Overtime, @Absences, @Honorarium, @Tardy, @GrossEarnings,
                 @SSS, @PhilHealth, @HDMF, @TotalDeductions, @NetPay);";

        private class PayrollResult
        {
            public decimal BasicPay, Overtime, Absences, Honorarium, Tardy;
            public decimal Gross, SSS, PhilHealth, HDMF, TotalDeductions, NetPay;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Instruction e: the cut-off is also displayed as the Pay Period
        private void txtCutOff_TextChanged(object sender, EventArgs e)
        {
            lblPayPeriodValue.Text = txtCutOff.Text.Trim();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            PayrollResult result;
            if (TryCompute(out result))
                ShowResult(result);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!RequireText(txtCompany, "Company name") ||
                !RequireText(txtDepartment, "Department") ||
                !RequireText(txtEmployeeCode, "Employee code") ||
                !RequireText(txtEmployeeName, "Employee name") ||
                !RequireText(txtCutOff, "Cut-off"))
                return;

            PayrollResult r;
            if (!TryCompute(out r))
                return;

            ShowResult(r);

            try
            {
                using (var conn = new SqlConnection(ConnectionString))
                using (var cmd = new SqlCommand(InsertSql, conn))
                {
                    cmd.Parameters.AddWithValue("@CompanyName", txtCompany.Text.Trim());
                    cmd.Parameters.AddWithValue("@Department", txtDepartment.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmployeeCode", txtEmployeeCode.Text.Trim());
                    cmd.Parameters.AddWithValue("@CutOff", txtCutOff.Text.Trim());
                    cmd.Parameters.AddWithValue("@EmployeeName", txtEmployeeName.Text.Trim());
                    cmd.Parameters.AddWithValue("@PayPeriod", txtCutOff.Text.Trim());
                    cmd.Parameters.AddWithValue("@BasicPay", r.BasicPay);
                    cmd.Parameters.AddWithValue("@Overtime", r.Overtime);
                    cmd.Parameters.AddWithValue("@Absences", r.Absences);
                    cmd.Parameters.AddWithValue("@Honorarium", r.Honorarium);
                    cmd.Parameters.AddWithValue("@Tardy", r.Tardy);
                    cmd.Parameters.AddWithValue("@GrossEarnings", r.Gross);
                    cmd.Parameters.AddWithValue("@SSS", r.SSS);
                    cmd.Parameters.AddWithValue("@PhilHealth", r.PhilHealth);
                    cmd.Parameters.AddWithValue("@HDMF", r.HDMF);
                    cmd.Parameters.AddWithValue("@TotalDeductions", r.TotalDeductions);
                    cmd.Parameters.AddWithValue("@NetPay", r.NetPay);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record saved to MidtermDb.quizTbl.", "Saved",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error:\n" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ---------- Computation ----------

        private bool TryCompute(out PayrollResult r)
        {
            r = new PayrollResult();

            decimal rate, basicHrs, otHrs, absHrs, tardyHrs, honorarium;
            if (!TryReadDecimal(txtRate, "Rate per hour", out rate) ||
                !TryReadDecimal(txtBasicHrs, "Basic Pay days/hours", out basicHrs) ||
                !TryReadDecimal(txtOtHrs, "Overtime hours", out otHrs) ||
                !TryReadDecimal(txtAbsHrs, "Absence hours", out absHrs) ||
                !TryReadDecimal(txtTardyHrs, "Tardy hours", out tardyHrs) ||
                !TryReadDecimal(txtHonAmt, "Honorarium", out honorarium))
                return false;

            // Earnings
            r.BasicPay = rate * basicHrs;     // rate per hour x hours per payday
            r.Overtime = rate * otHrs;        // rate per hour x overtime hours
            r.Honorarium = honorarium;
            r.Absences = rate * absHrs;       // rate per hour x absent hours
            r.Tardy = rate * tardyHrs;     // rate per hour x tardy hours

            // Gross earnings = Basic Pay + Overtime + Honorarium
            r.Gross = r.BasicPay + r.Overtime + r.Honorarium;

            // Government contributions
            r.SSS = GetSSS(r.Gross);
            r.PhilHealth = GetPhilHealth(r.Gross);
            r.HDMF = HdmfContribution;

            // Deductions = Absences + Tardy + SSS + PhilHealth + HDMF (no tax per instructions)
            r.TotalDeductions = r.Absences + r.Tardy + r.SSS + r.PhilHealth + r.HDMF;

            // Net pay = Gross earnings - Deductions
            r.NetPay = r.Gross - r.TotalDeductions;

            return true;
        }

        // SSS table: 0-20,000 | 20,001-50,000 | 50,001-75,000 | 75,001 up
        private static decimal GetSSS(decimal gross)
        {
            if (gross <= 20000m) return 125.75m;
            if (gross <= 50000m) return 2200.50m;
            if (gross <= 75000m) return 4800.00m;
            return 5800.00m;
        }

        // PhilHealth table: 0-20,000 | 20,001-50,000 | 50,001-75,000 | 75,001 up
        private static decimal GetPhilHealth(decimal gross)
        {
            if (gross <= 20000m) return 100.00m;
            if (gross <= 50000m) return 1200.00m;
            if (gross <= 75000m) return 6800.00m;
            return 8800.00m;
        }

        private void ShowResult(PayrollResult r)
        {
            txtBasicAmt.Text = r.BasicPay.ToString("N2");
            txtOtAmt.Text = r.Overtime.ToString("N2");
            txtOTPanel.Text = r.Overtime.ToString("N2");
            txtAbsAmt.Text = r.Absences.ToString("N2");
            txtTardyAmt.Text = r.Tardy.ToString("N2");

            txtSSS.Text = r.SSS.ToString("N2");
            txtHDMF.Text = r.HDMF.ToString("N2");
            txtPhilHealth.Text = r.PhilHealth.ToString("N2");

            txtGross.Text = r.Gross.ToString("N2");
            txtTotalDed.Text = r.TotalDeductions.ToString("N2");
            txtNetPay.Text = r.NetPay.ToString("N2");
        }

        // ---------- Input helpers ----------

        private bool RequireText(TextBox box, string fieldName)
        {
            if (string.IsNullOrWhiteSpace(box.Text))
            {
                MessageBox.Show("Please enter " + fieldName + ".", "Missing input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box.Focus();
                return false;
            }
            return true;
        }

        private bool TryReadDecimal(TextBox box, string fieldName, out decimal value)
        {
            if (!decimal.TryParse(box.Text.Trim(), out value) || value < 0)
            {
                MessageBox.Show("Please enter a valid, non-negative number for " + fieldName + ".",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                box.Focus();
                return false;
            }
            return true;
        }
    }
}