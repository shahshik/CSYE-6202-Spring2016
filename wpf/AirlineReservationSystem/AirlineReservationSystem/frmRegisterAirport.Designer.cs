namespace AirlineReservationSystem
{
    partial class frmRegisterAirport
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
            this.tagDomesticAirport = new System.Windows.Forms.TabControl();
            this.tabDomesticAirport = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gvDomestic = new System.Windows.Forms.DataGridView();
            this.txtAirportName = new System.Windows.Forms.TextBox();
            this.txtAirportCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDFrom = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnIntSave = new System.Windows.Forms.Button();
            this.btnIntClear = new System.Windows.Forms.Button();
            this.btnIntClose = new System.Windows.Forms.Button();
            this.txtIntAirportName = new System.Windows.Forms.TextBox();
            this.txtIntAirportCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tagDomesticAirport.SuspendLayout();
            this.tabDomesticAirport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDomestic)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tagDomesticAirport
            // 
            this.tagDomesticAirport.Controls.Add(this.tabDomesticAirport);
            this.tagDomesticAirport.Controls.Add(this.tabPage2);
            this.tagDomesticAirport.Location = new System.Drawing.Point(0, 0);
            this.tagDomesticAirport.Name = "tagDomesticAirport";
            this.tagDomesticAirport.SelectedIndex = 0;
            this.tagDomesticAirport.Size = new System.Drawing.Size(626, 535);
            this.tagDomesticAirport.TabIndex = 0;
            this.tagDomesticAirport.Tag = "";
            // 
            // tabDomesticAirport
            // 
            this.tabDomesticAirport.Controls.Add(this.btnSave);
            this.tabDomesticAirport.Controls.Add(this.btnClear);
            this.tabDomesticAirport.Controls.Add(this.btnClose);
            this.tabDomesticAirport.Controls.Add(this.gvDomestic);
            this.tabDomesticAirport.Controls.Add(this.txtAirportName);
            this.tabDomesticAirport.Controls.Add(this.txtAirportCode);
            this.tabDomesticAirport.Controls.Add(this.label1);
            this.tabDomesticAirport.Controls.Add(this.lblDFrom);
            this.tabDomesticAirport.Location = new System.Drawing.Point(4, 22);
            this.tabDomesticAirport.Name = "tabDomesticAirport";
            this.tabDomesticAirport.Padding = new System.Windows.Forms.Padding(3);
            this.tabDomesticAirport.Size = new System.Drawing.Size(618, 509);
            this.tabDomesticAirport.TabIndex = 0;
            this.tabDomesticAirport.Text = "Domestic";
            this.tabDomesticAirport.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(105, 115);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(102, 33);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(373, 115);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 33);
            this.btnClear.TabIndex = 29;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(239, 115);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 33);
            this.btnClose.TabIndex = 28;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // gvDomestic
            // 
            this.gvDomestic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvDomestic.Location = new System.Drawing.Point(8, 172);
            this.gvDomestic.Name = "gvDomestic";
            this.gvDomestic.Size = new System.Drawing.Size(604, 331);
            this.gvDomestic.TabIndex = 26;
            // 
            // txtAirportName
            // 
            this.txtAirportName.Location = new System.Drawing.Point(144, 66);
            this.txtAirportName.Name = "txtAirportName";
            this.txtAirportName.Size = new System.Drawing.Size(278, 20);
            this.txtAirportName.TabIndex = 25;
            // 
            // txtAirportCode
            // 
            this.txtAirportCode.Location = new System.Drawing.Point(144, 30);
            this.txtAirportCode.Name = "txtAirportCode";
            this.txtAirportCode.Size = new System.Drawing.Size(169, 20);
            this.txtAirportCode.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 23;
            this.label1.Text = "Airport Name:";
            // 
            // lblDFrom
            // 
            this.lblDFrom.AutoSize = true;
            this.lblDFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDFrom.Location = new System.Drawing.Point(40, 30);
            this.lblDFrom.Name = "lblDFrom";
            this.lblDFrom.Size = new System.Drawing.Size(99, 16);
            this.lblDFrom.TabIndex = 22;
            this.lblDFrom.Text = "Airport Code:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnIntSave);
            this.tabPage2.Controls.Add(this.btnIntClear);
            this.tabPage2.Controls.Add(this.btnIntClose);
            this.tabPage2.Controls.Add(this.txtIntAirportName);
            this.tabPage2.Controls.Add(this.txtIntAirportCode);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(618, 509);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnIntSave
            // 
            this.btnIntSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntSave.Location = new System.Drawing.Point(105, 115);
            this.btnIntSave.Name = "btnIntSave";
            this.btnIntSave.Size = new System.Drawing.Size(102, 33);
            this.btnIntSave.TabIndex = 38;
            this.btnIntSave.Text = "Save";
            this.btnIntSave.UseVisualStyleBackColor = true;
            this.btnIntSave.Click += new System.EventHandler(this.btnIntSave_Click);
            // 
            // btnIntClear
            // 
            this.btnIntClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntClear.Location = new System.Drawing.Point(373, 115);
            this.btnIntClear.Name = "btnIntClear";
            this.btnIntClear.Size = new System.Drawing.Size(102, 33);
            this.btnIntClear.TabIndex = 40;
            this.btnIntClear.Text = "Clear";
            this.btnIntClear.UseVisualStyleBackColor = true;
            // 
            // btnIntClose
            // 
            this.btnIntClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIntClose.Location = new System.Drawing.Point(239, 115);
            this.btnIntClose.Name = "btnIntClose";
            this.btnIntClose.Size = new System.Drawing.Size(102, 33);
            this.btnIntClose.TabIndex = 39;
            this.btnIntClose.Text = "Close";
            this.btnIntClose.UseVisualStyleBackColor = true;
            this.btnIntClose.Click += new System.EventHandler(this.btnIntClose_Click);
            // 
            // txtIntAirportName
            // 
            this.txtIntAirportName.Location = new System.Drawing.Point(144, 66);
            this.txtIntAirportName.Name = "txtIntAirportName";
            this.txtIntAirportName.Size = new System.Drawing.Size(278, 20);
            this.txtIntAirportName.TabIndex = 37;
            // 
            // txtIntAirportCode
            // 
            this.txtIntAirportCode.Location = new System.Drawing.Point(144, 30);
            this.txtIntAirportCode.Name = "txtIntAirportCode";
            this.txtIntAirportCode.Size = new System.Drawing.Size(169, 20);
            this.txtIntAirportCode.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 35;
            this.label2.Text = "Airport Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "Airport Code:";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 181);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(558, 150);
            this.dataGridView2.TabIndex = 30;
            // 
            // frmRegisterAirport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 547);
            this.Controls.Add(this.tagDomesticAirport);
            this.Name = "frmRegisterAirport";
            this.Text = "frmRegisterAirport";
            this.tagDomesticAirport.ResumeLayout(false);
            this.tabDomesticAirport.ResumeLayout(false);
            this.tabDomesticAirport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gvDomestic)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tagDomesticAirport;
        private System.Windows.Forms.TabPage tabDomesticAirport;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblDFrom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvDomestic;
        private System.Windows.Forms.TextBox txtAirportName;
        private System.Windows.Forms.TextBox txtAirportCode;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnIntSave;
        private System.Windows.Forms.Button btnIntClear;
        private System.Windows.Forms.Button btnIntClose;
        private System.Windows.Forms.TextBox txtIntAirportName;
        private System.Windows.Forms.TextBox txtIntAirportCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}