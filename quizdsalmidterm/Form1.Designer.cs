namespace quizdsalmidterm
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblEmployeeCode;
        private System.Windows.Forms.Label lblCutOff;
        private System.Windows.Forms.Label lblEmployeeName;
        private System.Windows.Forms.Label lblPayPeriod;
        private System.Windows.Forms.Label lblPayPeriodValue;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblEarnings;
        private System.Windows.Forms.Label lblColDays;
        private System.Windows.Forms.Label lblColAmount;
        private System.Windows.Forms.Label lblBasic;
        private System.Windows.Forms.Label lblOvertime;
        private System.Windows.Forms.Label lblAbsences;
        private System.Windows.Forms.Label lblHonorarium;
        private System.Windows.Forms.Label lblTardy;
        private System.Windows.Forms.Label lblDeductions;
        private System.Windows.Forms.Label lblColDedAmount;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSSS;
        private System.Windows.Forms.Label lblHDMF;
        private System.Windows.Forms.Label lblPhilHealth;
        private System.Windows.Forms.Label lblOTHeader;
        private System.Windows.Forms.Label lblOvertimePanel;
        private System.Windows.Forms.Label lblGross;
        private System.Windows.Forms.Label lblTotalDed;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.TextBox txtCompany;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.TextBox txtCutOff;
        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.TextBox txtBasicHrs;
        private System.Windows.Forms.TextBox txtBasicAmt;
        private System.Windows.Forms.TextBox txtOtHrs;
        private System.Windows.Forms.TextBox txtOtAmt;
        private System.Windows.Forms.TextBox txtOTPanel;
        private System.Windows.Forms.TextBox txtAbsHrs;
        private System.Windows.Forms.TextBox txtAbsAmt;
        private System.Windows.Forms.TextBox txtHonAmt;
        private System.Windows.Forms.TextBox txtTardyHrs;
        private System.Windows.Forms.TextBox txtTardyAmt;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSSS;
        private System.Windows.Forms.TextBox txtHDMF;
        private System.Windows.Forms.TextBox txtPhilHealth;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtTotalDed;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.Button btnCompute;
        private System.Windows.Forms.Button btnSave;

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
            this.lblCompany = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblEmployeeCode = new System.Windows.Forms.Label();
            this.lblCutOff = new System.Windows.Forms.Label();
            this.lblEmployeeName = new System.Windows.Forms.Label();
            this.lblPayPeriod = new System.Windows.Forms.Label();
            this.lblPayPeriodValue = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblEarnings = new System.Windows.Forms.Label();
            this.lblColDays = new System.Windows.Forms.Label();
            this.lblColAmount = new System.Windows.Forms.Label();
            this.lblBasic = new System.Windows.Forms.Label();
            this.lblOvertime = new System.Windows.Forms.Label();
            this.lblAbsences = new System.Windows.Forms.Label();
            this.lblHonorarium = new System.Windows.Forms.Label();
            this.lblTardy = new System.Windows.Forms.Label();
            this.lblDeductions = new System.Windows.Forms.Label();
            this.lblColDedAmount = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSSS = new System.Windows.Forms.Label();
            this.lblHDMF = new System.Windows.Forms.Label();
            this.lblPhilHealth = new System.Windows.Forms.Label();
            this.lblOTHeader = new System.Windows.Forms.Label();
            this.lblOvertimePanel = new System.Windows.Forms.Label();
            this.lblGross = new System.Windows.Forms.Label();
            this.lblTotalDed = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.txtCompany = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.txtCutOff = new System.Windows.Forms.TextBox();
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.txtBasicHrs = new System.Windows.Forms.TextBox();
            this.txtBasicAmt = new System.Windows.Forms.TextBox();
            this.txtOtHrs = new System.Windows.Forms.TextBox();
            this.txtOtAmt = new System.Windows.Forms.TextBox();
            this.txtOTPanel = new System.Windows.Forms.TextBox();
            this.txtAbsHrs = new System.Windows.Forms.TextBox();
            this.txtAbsAmt = new System.Windows.Forms.TextBox();
            this.txtHonAmt = new System.Windows.Forms.TextBox();
            this.txtTardyHrs = new System.Windows.Forms.TextBox();
            this.txtTardyAmt = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSSS = new System.Windows.Forms.TextBox();
            this.txtHDMF = new System.Windows.Forms.TextBox();
            this.txtPhilHealth = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtTotalDed = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.btnCompute = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // ----- Header fields -----
            this.lblCompany.AutoSize = false;
            this.lblCompany.Location = new System.Drawing.Point(20, 22);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(100, 23);
            this.lblCompany.Text = "Company:";
            this.lblCompany.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblCompany);

            this.txtCompany.Location = new System.Drawing.Point(125, 19);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(260, 23);
            this.Controls.Add(this.txtCompany);

            this.lblDepartment.AutoSize = false;
            this.lblDepartment.Location = new System.Drawing.Point(410, 22);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(110, 23);
            this.lblDepartment.Text = "Department:";
            this.lblDepartment.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblDepartment);

            this.txtDepartment.Location = new System.Drawing.Point(520, 19);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(250, 23);
            this.Controls.Add(this.txtDepartment);

            this.lblEmployeeCode.AutoSize = false;
            this.lblEmployeeCode.Location = new System.Drawing.Point(20, 60);
            this.lblEmployeeCode.Name = "lblEmployeeCode";
            this.lblEmployeeCode.Size = new System.Drawing.Size(100, 23);
            this.lblEmployeeCode.Text = "Employee Code:";
            this.lblEmployeeCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblEmployeeCode);

            this.txtEmployeeCode.Location = new System.Drawing.Point(125, 57);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(260, 23);
            this.Controls.Add(this.txtEmployeeCode);

            this.lblCutOff.AutoSize = false;
            this.lblCutOff.Location = new System.Drawing.Point(410, 60);
            this.lblCutOff.Name = "lblCutOff";
            this.lblCutOff.Size = new System.Drawing.Size(110, 23);
            this.lblCutOff.Text = "Cut-Off:";
            this.lblCutOff.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblCutOff);

            this.txtCutOff.Location = new System.Drawing.Point(520, 57);
            this.txtCutOff.Name = "txtCutOff";
            this.txtCutOff.Size = new System.Drawing.Size(250, 23);
            this.Controls.Add(this.txtCutOff);

            this.lblEmployeeName.AutoSize = false;
            this.lblEmployeeName.Location = new System.Drawing.Point(20, 98);
            this.lblEmployeeName.Name = "lblEmployeeName";
            this.lblEmployeeName.Size = new System.Drawing.Size(100, 23);
            this.lblEmployeeName.Text = "Employee Name:";
            this.lblEmployeeName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblEmployeeName);

            this.txtEmployeeName.Location = new System.Drawing.Point(125, 95);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(260, 23);
            this.Controls.Add(this.txtEmployeeName);

            this.lblPayPeriod.AutoSize = false;
            this.lblPayPeriod.Location = new System.Drawing.Point(410, 98);
            this.lblPayPeriod.Name = "lblPayPeriod";
            this.lblPayPeriod.Size = new System.Drawing.Size(110, 23);
            this.lblPayPeriod.Text = "Pay Period:";
            this.lblPayPeriod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblPayPeriod);

            this.lblPayPeriodValue.AutoSize = false;
            this.lblPayPeriodValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPayPeriodValue.Location = new System.Drawing.Point(520, 98);
            this.lblPayPeriodValue.Name = "lblPayPeriodValue";
            this.lblPayPeriodValue.Size = new System.Drawing.Size(250, 23);
            this.lblPayPeriodValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblPayPeriodValue);

            this.lblRate.AutoSize = false;
            this.lblRate.Location = new System.Drawing.Point(20, 136);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(100, 23);
            this.lblRate.Text = "Rate per Hour:";
            this.lblRate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblRate);

            this.txtRate.Location = new System.Drawing.Point(125, 133);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(120, 23);
            this.Controls.Add(this.txtRate);

            // ----- EARNINGS section -----
            this.lblEarnings.AutoSize = false;
            this.lblEarnings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblEarnings.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblEarnings.Location = new System.Drawing.Point(20, 170);
            this.lblEarnings.Name = "lblEarnings";
            this.lblEarnings.Size = new System.Drawing.Size(365, 24);
            this.lblEarnings.Text = "EARNINGS";
            this.lblEarnings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblEarnings);

            this.lblColDays.AutoSize = false;
            this.lblColDays.Location = new System.Drawing.Point(125, 198);
            this.lblColDays.Name = "lblColDays";
            this.lblColDays.Size = new System.Drawing.Size(110, 23);
            this.lblColDays.Text = "Days/Hrs";
            this.lblColDays.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblColDays);

            this.lblColAmount.AutoSize = false;
            this.lblColAmount.Location = new System.Drawing.Point(245, 198);
            this.lblColAmount.Name = "lblColAmount";
            this.lblColAmount.Size = new System.Drawing.Size(140, 23);
            this.lblColAmount.Text = "Amount";
            this.lblColAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblColAmount);

            this.lblBasic.AutoSize = false;
            this.lblBasic.Location = new System.Drawing.Point(20, 225);
            this.lblBasic.Name = "lblBasic";
            this.lblBasic.Size = new System.Drawing.Size(100, 23);
            this.lblBasic.Text = "Basic Pay";
            this.lblBasic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblBasic);

            this.txtBasicHrs.Location = new System.Drawing.Point(125, 225);
            this.txtBasicHrs.Name = "txtBasicHrs";
            this.txtBasicHrs.Size = new System.Drawing.Size(110, 23);
            this.Controls.Add(this.txtBasicHrs);

            this.txtBasicAmt.Location = new System.Drawing.Point(245, 225);
            this.txtBasicAmt.Name = "txtBasicAmt";
            this.txtBasicAmt.ReadOnly = true;
            this.txtBasicAmt.Size = new System.Drawing.Size(140, 23);
            this.Controls.Add(this.txtBasicAmt);

            this.lblOvertime.AutoSize = false;
            this.lblOvertime.Location = new System.Drawing.Point(20, 255);
            this.lblOvertime.Name = "lblOvertime";
            this.lblOvertime.Size = new System.Drawing.Size(100, 23);
            this.lblOvertime.Text = "Overtime";
            this.lblOvertime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblOvertime);

            this.txtOtHrs.Location = new System.Drawing.Point(125, 255);
            this.txtOtHrs.Name = "txtOtHrs";
            this.txtOtHrs.Size = new System.Drawing.Size(110, 23);
            this.Controls.Add(this.txtOtHrs);

            this.txtOtAmt.Location = new System.Drawing.Point(245, 255);
            this.txtOtAmt.Name = "txtOtAmt";
            this.txtOtAmt.ReadOnly = true;
            this.txtOtAmt.Size = new System.Drawing.Size(140, 23);
            this.Controls.Add(this.txtOtAmt);

            this.lblAbsences.AutoSize = false;
            this.lblAbsences.Location = new System.Drawing.Point(20, 285);
            this.lblAbsences.Name = "lblAbsences";
            this.lblAbsences.Size = new System.Drawing.Size(100, 23);
            this.lblAbsences.Text = "Absences";
            this.lblAbsences.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblAbsences);

            this.txtAbsHrs.Location = new System.Drawing.Point(125, 285);
            this.txtAbsHrs.Name = "txtAbsHrs";
            this.txtAbsHrs.Size = new System.Drawing.Size(110, 23);
            this.Controls.Add(this.txtAbsHrs);

            this.txtAbsAmt.Location = new System.Drawing.Point(245, 285);
            this.txtAbsAmt.Name = "txtAbsAmt";
            this.txtAbsAmt.ReadOnly = true;
            this.txtAbsAmt.Size = new System.Drawing.Size(140, 23);
            this.Controls.Add(this.txtAbsAmt);

            this.lblHonorarium.AutoSize = false;
            this.lblHonorarium.Location = new System.Drawing.Point(20, 315);
            this.lblHonorarium.Name = "lblHonorarium";
            this.lblHonorarium.Size = new System.Drawing.Size(100, 23);
            this.lblHonorarium.Text = "Honorarium";
            this.lblHonorarium.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblHonorarium);

            this.txtHonAmt.Location = new System.Drawing.Point(245, 315);
            this.txtHonAmt.Name = "txtHonAmt";
            this.txtHonAmt.Size = new System.Drawing.Size(140, 23);
            this.Controls.Add(this.txtHonAmt);

            this.lblTardy.AutoSize = false;
            this.lblTardy.Location = new System.Drawing.Point(20, 345);
            this.lblTardy.Name = "lblTardy";
            this.lblTardy.Size = new System.Drawing.Size(100, 23);
            this.lblTardy.Text = "Tardy";
            this.lblTardy.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblTardy);

            this.txtTardyHrs.Location = new System.Drawing.Point(125, 345);
            this.txtTardyHrs.Name = "txtTardyHrs";
            this.txtTardyHrs.Size = new System.Drawing.Size(110, 23);
            this.Controls.Add(this.txtTardyHrs);

            this.txtTardyAmt.Location = new System.Drawing.Point(245, 345);
            this.txtTardyAmt.Name = "txtTardyAmt";
            this.txtTardyAmt.ReadOnly = true;
            this.txtTardyAmt.Size = new System.Drawing.Size(140, 23);
            this.Controls.Add(this.txtTardyAmt);

            // ----- DEDUCTIONS section -----
            this.lblDeductions.AutoSize = false;
            this.lblDeductions.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDeductions.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblDeductions.Location = new System.Drawing.Point(410, 170);
            this.lblDeductions.Name = "lblDeductions";
            this.lblDeductions.Size = new System.Drawing.Size(340, 24);
            this.lblDeductions.Text = "DEDUCTIONS";
            this.lblDeductions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblDeductions);

            this.lblColDedAmount.AutoSize = false;
            this.lblColDedAmount.Location = new System.Drawing.Point(600, 198);
            this.lblColDedAmount.Name = "lblColDedAmount";
            this.lblColDedAmount.Size = new System.Drawing.Size(150, 23);
            this.lblColDedAmount.Text = "Amount";
            this.lblColDedAmount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblColDedAmount);

            this.lblTax.AutoSize = false;
            this.lblTax.Location = new System.Drawing.Point(410, 225);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(180, 23);
            this.lblTax.Text = "Withholding Tax";
            this.lblTax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblTax);

            this.txtTax.Location = new System.Drawing.Point(600, 225);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(150, 23);
            this.txtTax.Text = "0.00";
            this.Controls.Add(this.txtTax);

            this.lblSSS.AutoSize = false;
            this.lblSSS.Location = new System.Drawing.Point(410, 255);
            this.lblSSS.Name = "lblSSS";
            this.lblSSS.Size = new System.Drawing.Size(180, 23);
            this.lblSSS.Text = "SSS Contribution";
            this.lblSSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblSSS);

            this.txtSSS.Location = new System.Drawing.Point(600, 255);
            this.txtSSS.Name = "txtSSS";
            this.txtSSS.ReadOnly = true;
            this.txtSSS.Size = new System.Drawing.Size(150, 23);
            this.Controls.Add(this.txtSSS);

            this.lblHDMF.AutoSize = false;
            this.lblHDMF.Location = new System.Drawing.Point(410, 285);
            this.lblHDMF.Name = "lblHDMF";
            this.lblHDMF.Size = new System.Drawing.Size(180, 23);
            this.lblHDMF.Text = "HDMF Contribution";
            this.lblHDMF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblHDMF);

            this.txtHDMF.Location = new System.Drawing.Point(600, 285);
            this.txtHDMF.Name = "txtHDMF";
            this.txtHDMF.ReadOnly = true;
            this.txtHDMF.Size = new System.Drawing.Size(150, 23);
            this.Controls.Add(this.txtHDMF);

            this.lblPhilHealth.AutoSize = false;
            this.lblPhilHealth.Location = new System.Drawing.Point(410, 315);
            this.lblPhilHealth.Name = "lblPhilHealth";
            this.lblPhilHealth.Size = new System.Drawing.Size(180, 23);
            this.lblPhilHealth.Text = "PhilHealth Contribution";
            this.lblPhilHealth.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblPhilHealth);

            this.txtPhilHealth.Location = new System.Drawing.Point(600, 315);
            this.txtPhilHealth.Name = "txtPhilHealth";
            this.txtPhilHealth.ReadOnly = true;
            this.txtPhilHealth.Size = new System.Drawing.Size(150, 23);
            this.Controls.Add(this.txtPhilHealth);

            // ----- OVERTIME & NIGHT DIFF. panel (right side) -----
            this.lblOTHeader.AutoSize = false;
            this.lblOTHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblOTHeader.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblOTHeader.Location = new System.Drawing.Point(780, 170);
            this.lblOTHeader.Name = "lblOTHeader";
            this.lblOTHeader.Size = new System.Drawing.Size(220, 24);
            this.lblOTHeader.Text = "OVERTIME & NIGHT DIFF.";
            this.lblOTHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Controls.Add(this.lblOTHeader);

            this.lblOvertimePanel.AutoSize = false;
            this.lblOvertimePanel.Location = new System.Drawing.Point(780, 225);
            this.lblOvertimePanel.Name = "lblOvertimePanel";
            this.lblOvertimePanel.Size = new System.Drawing.Size(120, 23);
            this.lblOvertimePanel.Text = "Overtime:";
            this.lblOvertimePanel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblOvertimePanel);

            this.txtOTPanel.Location = new System.Drawing.Point(900, 225);
            this.txtOTPanel.Name = "txtOTPanel";
            this.txtOTPanel.ReadOnly = true;
            this.txtOTPanel.Size = new System.Drawing.Size(100, 23);
            this.Controls.Add(this.txtOTPanel);

            this.lblGross.AutoSize = false;
            this.lblGross.Location = new System.Drawing.Point(780, 390);
            this.lblGross.Name = "lblGross";
            this.lblGross.Size = new System.Drawing.Size(120, 23);
            this.lblGross.Text = "Gross Earnings:";
            this.lblGross.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblGross);

            this.txtGross.Location = new System.Drawing.Point(900, 387);
            this.txtGross.Name = "txtGross";
            this.txtGross.ReadOnly = true;
            this.txtGross.Size = new System.Drawing.Size(100, 23);
            this.Controls.Add(this.txtGross);

            this.lblTotalDed.AutoSize = false;
            this.lblTotalDed.Location = new System.Drawing.Point(780, 420);
            this.lblTotalDed.Name = "lblTotalDed";
            this.lblTotalDed.Size = new System.Drawing.Size(120, 23);
            this.lblTotalDed.Text = "Deductions:";
            this.lblTotalDed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblTotalDed);

            this.txtTotalDed.Location = new System.Drawing.Point(900, 417);
            this.txtTotalDed.Name = "txtTotalDed";
            this.txtTotalDed.ReadOnly = true;
            this.txtTotalDed.Size = new System.Drawing.Size(100, 23);
            this.Controls.Add(this.txtTotalDed);

            this.lblNet.AutoSize = false;
            this.lblNet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblNet.Location = new System.Drawing.Point(780, 450);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(120, 23);
            this.lblNet.Text = "Net Pay:";
            this.lblNet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Controls.Add(this.lblNet);

            this.txtNetPay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.txtNetPay.Location = new System.Drawing.Point(900, 447);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(100, 23);
            this.Controls.Add(this.txtNetPay);

            // ----- Buttons (bottom left) -----
            this.btnCompute.Location = new System.Drawing.Point(20, 420);
            this.btnCompute.Name = "btnCompute";
            this.btnCompute.Size = new System.Drawing.Size(150, 36);
            this.btnCompute.Text = "Compute";
            this.btnCompute.UseVisualStyleBackColor = true;
            this.btnCompute.Click += new System.EventHandler(this.btnCompute_Click);
            this.Controls.Add(this.btnCompute);

            this.btnSave.Location = new System.Drawing.Point(180, 420);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 36);
            this.btnSave.Text = "Save to Database";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            this.Controls.Add(this.btnSave);

            // ----- Form -----
            this.txtCutOff.TextChanged += new System.EventHandler(this.txtCutOff_TextChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 490);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name = "Form1";
            this.Text = "Salary Computation";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
        }

        #endregion
    }
}