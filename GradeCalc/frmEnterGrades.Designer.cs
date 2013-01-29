namespace GradeCalc
{
    partial class frmEnterGrades
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDLType = new System.Windows.Forms.RadioButton();
            this.btnLabType = new System.Windows.Forms.RadioButton();
            this.btnTestType = new System.Windows.Forms.RadioButton();
            this.gradeList = new System.Windows.Forms.ListBox();
            this.btnEnterGrade = new System.Windows.Forms.Button();
            this.btnCalcFinal = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAvgGrade = new System.Windows.Forms.TextBox();
            this.txtWeighted = new System.Windows.Forms.TextBox();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.lblFinalGrade = new System.Windows.Forms.Label();
            this.btnSaveGrade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDLType);
            this.groupBox1.Controls.Add(this.btnLabType);
            this.groupBox1.Controls.Add(this.btnTestType);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(81, 95);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "&Grade Type";
            // 
            // btnDLType
            // 
            this.btnDLType.AutoCheck = false;
            this.btnDLType.AutoSize = true;
            this.btnDLType.Location = new System.Drawing.Point(6, 65);
            this.btnDLType.Name = "btnDLType";
            this.btnDLType.Size = new System.Drawing.Size(39, 17);
            this.btnDLType.TabIndex = 2;
            this.btnDLType.TabStop = true;
            this.btnDLType.Text = "DL";
            this.btnDLType.UseVisualStyleBackColor = true;
            this.btnDLType.Click += new System.EventHandler(this.btnDLType_Click);
            // 
            // btnLabType
            // 
            this.btnLabType.AutoCheck = false;
            this.btnLabType.AutoSize = true;
            this.btnLabType.Location = new System.Drawing.Point(6, 42);
            this.btnLabType.Name = "btnLabType";
            this.btnLabType.Size = new System.Drawing.Size(43, 17);
            this.btnLabType.TabIndex = 1;
            this.btnLabType.TabStop = true;
            this.btnLabType.Text = "Lab";
            this.btnLabType.UseVisualStyleBackColor = true;
            this.btnLabType.Click += new System.EventHandler(this.btnLabType_Click);
            // 
            // btnTestType
            // 
            this.btnTestType.AutoCheck = false;
            this.btnTestType.AutoSize = true;
            this.btnTestType.Location = new System.Drawing.Point(6, 19);
            this.btnTestType.Name = "btnTestType";
            this.btnTestType.Size = new System.Drawing.Size(46, 17);
            this.btnTestType.TabIndex = 0;
            this.btnTestType.TabStop = true;
            this.btnTestType.Text = "Test";
            this.btnTestType.UseVisualStyleBackColor = true;
            this.btnTestType.Click += new System.EventHandler(this.btnTestType_Click);
            // 
            // gradeList
            // 
            this.gradeList.FormattingEnabled = true;
            this.gradeList.Location = new System.Drawing.Point(99, 12);
            this.gradeList.Name = "gradeList";
            this.gradeList.Size = new System.Drawing.Size(62, 95);
            this.gradeList.TabIndex = 1;
            // 
            // btnEnterGrade
            // 
            this.btnEnterGrade.Enabled = false;
            this.btnEnterGrade.Location = new System.Drawing.Point(12, 136);
            this.btnEnterGrade.Name = "btnEnterGrade";
            this.btnEnterGrade.Size = new System.Drawing.Size(81, 23);
            this.btnEnterGrade.TabIndex = 1;
            this.btnEnterGrade.Text = "Enter Grade";
            this.btnEnterGrade.UseVisualStyleBackColor = true;
            this.btnEnterGrade.Click += new System.EventHandler(this.btnEnterGrade_Click);
            // 
            // btnCalcFinal
            // 
            this.btnCalcFinal.Enabled = false;
            this.btnCalcFinal.Location = new System.Drawing.Point(182, 84);
            this.btnCalcFinal.Name = "btnCalcFinal";
            this.btnCalcFinal.Size = new System.Drawing.Size(124, 23);
            this.btnCalcFinal.TabIndex = 3;
            this.btnCalcFinal.Text = "Calculate &Final Grade";
            this.btnCalcFinal.UseVisualStyleBackColor = true;
            this.btnCalcFinal.Click += new System.EventHandler(this.btnCalcFinal_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(13, 110);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(80, 20);
            this.txtGrade.TabIndex = 0;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Avg Grade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(198, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Weighted:";
            // 
            // txtAvgGrade
            // 
            this.txtAvgGrade.Location = new System.Drawing.Point(264, 22);
            this.txtAvgGrade.Name = "txtAvgGrade";
            this.txtAvgGrade.ReadOnly = true;
            this.txtAvgGrade.Size = new System.Drawing.Size(42, 20);
            this.txtAvgGrade.TabIndex = 7;
            // 
            // txtWeighted
            // 
            this.txtWeighted.Location = new System.Drawing.Point(264, 53);
            this.txtWeighted.Name = "txtWeighted";
            this.txtWeighted.ReadOnly = true;
            this.txtWeighted.Size = new System.Drawing.Size(42, 20);
            this.txtWeighted.TabIndex = 8;
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(99, 111);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(61, 20);
            this.txtSum.TabIndex = 9;
            // 
            // lblFinalGrade
            // 
            this.lblFinalGrade.AutoSize = true;
            this.lblFinalGrade.Location = new System.Drawing.Point(193, 118);
            this.lblFinalGrade.Name = "lblFinalGrade";
            this.lblFinalGrade.Size = new System.Drawing.Size(91, 13);
            this.lblFinalGrade.TabIndex = 10;
            this.lblFinalGrade.Text = "-Final Grade Calc-";
            this.lblFinalGrade.TextChanged += new System.EventHandler(this.lblFinalGrade_TextChanged);
            // 
            // btnSaveGrade
            // 
            this.btnSaveGrade.Location = new System.Drawing.Point(201, 141);
            this.btnSaveGrade.Name = "btnSaveGrade";
            this.btnSaveGrade.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGrade.TabIndex = 11;
            this.btnSaveGrade.Text = "&Save";
            this.btnSaveGrade.UseVisualStyleBackColor = true;
            this.btnSaveGrade.Click += new System.EventHandler(this.btnSaveGrade_Click);
            // 
            // frmEnterGrades
            // 
            this.AcceptButton = this.btnEnterGrade;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 176);
            this.Controls.Add(this.btnSaveGrade);
            this.Controls.Add(this.lblFinalGrade);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.txtWeighted);
            this.Controls.Add(this.txtAvgGrade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.btnCalcFinal);
            this.Controls.Add(this.btnEnterGrade);
            this.Controls.Add(this.gradeList);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmEnterGrades";
            this.Text = "Calculate Final Grade";
            this.Load += new System.EventHandler(this.frmEnterGrades_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton btnDLType;
        private System.Windows.Forms.RadioButton btnLabType;
        private System.Windows.Forms.RadioButton btnTestType;
        private System.Windows.Forms.ListBox gradeList;
        private System.Windows.Forms.Button btnEnterGrade;
        private System.Windows.Forms.Button btnCalcFinal;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAvgGrade;
        private System.Windows.Forms.TextBox txtWeighted;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Label lblFinalGrade;
        private System.Windows.Forms.Button btnSaveGrade;
    }
}

