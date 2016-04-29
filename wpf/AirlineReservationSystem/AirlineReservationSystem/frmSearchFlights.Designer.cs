namespace AirlineReservationSystem
{
    partial class frmSearchFlights
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
            this.components = new System.ComponentModel.Container();
            this.internationalAirportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.airlineReservationSystemDataSet1 = new AirlineReservationSystem.AirlineReservationSystemDataSet1();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineReservationSystemDataSet = new AirlineReservationSystem.AirlineReservationSystemDataSet();
            this.domesticAirportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesticAirportsTableAdapter = new AirlineReservationSystem.AirlineReservationSystemDataSetTableAdapters.DomesticAirportsTableAdapter();
            this.internationalAirportsTableAdapter = new AirlineReservationSystem.AirlineReservationSystemDataSet1TableAdapters.InternationalAirportsTableAdapter();
            this.btnSearchFlight = new System.Windows.Forms.Button();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblDReturn = new System.Windows.Forms.Label();
            this.lblDDepart = new System.Windows.Forms.Label();
            this.dtpDReturn = new System.Windows.Forms.DateTimePicker();
            this.dtpDDepart = new System.Windows.Forms.DateTimePicker();
            this.txtDTo = new System.Windows.Forms.TextBox();
            this.txtDFrom = new System.Windows.Forms.TextBox();
            this.lblDTo = new System.Windows.Forms.Label();
            this.lblDFrom = new System.Windows.Forms.Label();
            this.rdoTrip1 = new System.Windows.Forms.RadioButton();
            this.rdoTrip = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.internationalAirportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesticAirportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // internationalAirportsBindingSource
            // 
            this.internationalAirportsBindingSource.DataMember = "InternationalAirports";
            this.internationalAirportsBindingSource.DataSource = this.airlineReservationSystemDataSet1;
            // 
            // airlineReservationSystemDataSet1
            // 
            this.airlineReservationSystemDataSet1.DataSetName = "AirlineReservationSystemDataSet1";
            this.airlineReservationSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.airlineReservationSystemDataSet;
            this.bindingSource1.Position = 0;
            // 
            // airlineReservationSystemDataSet
            // 
            this.airlineReservationSystemDataSet.DataSetName = "AirlineReservationSystemDataSet";
            this.airlineReservationSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // domesticAirportsBindingSource
            // 
            this.domesticAirportsBindingSource.DataMember = "DomesticAirports";
            this.domesticAirportsBindingSource.DataSource = this.bindingSource1;
            // 
            // domesticAirportsTableAdapter
            // 
            this.domesticAirportsTableAdapter.ClearBeforeFill = true;
            // 
            // internationalAirportsTableAdapter
            // 
            this.internationalAirportsTableAdapter.ClearBeforeFill = true;
            // 
            // btnSearchFlight
            // 
            this.btnSearchFlight.Location = new System.Drawing.Point(333, 299);
            this.btnSearchFlight.Name = "btnSearchFlight";
            this.btnSearchFlight.Size = new System.Drawing.Size(172, 38);
            this.btnSearchFlight.TabIndex = 70;
            this.btnSearchFlight.Text = "Search Flights";
            this.btnSearchFlight.UseVisualStyleBackColor = true;
            this.btnSearchFlight.Click += new System.EventHandler(this.btnSearchFlight_Click);
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(105, 316);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(171, 21);
            this.comboBox8.TabIndex = 69;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(102, 293);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 68;
            this.label12.Text = "Class:";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(574, 224);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(52, 21);
            this.comboBox7.TabIndex = 67;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(571, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 66;
            this.label11.Text = "Infants:";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(486, 224);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(52, 21);
            this.comboBox6.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(483, 201);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "Children:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(398, 224);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(52, 21);
            this.comboBox5.TabIndex = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(395, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 62;
            this.label9.Text = "Adults:";
            // 
            // lblDReturn
            // 
            this.lblDReturn.AutoSize = true;
            this.lblDReturn.Location = new System.Drawing.Point(223, 201);
            this.lblDReturn.Name = "lblDReturn";
            this.lblDReturn.Size = new System.Drawing.Size(39, 13);
            this.lblDReturn.TabIndex = 61;
            this.lblDReturn.Text = "Return";
            // 
            // lblDDepart
            // 
            this.lblDDepart.AutoSize = true;
            this.lblDDepart.Location = new System.Drawing.Point(102, 201);
            this.lblDDepart.Name = "lblDDepart";
            this.lblDDepart.Size = new System.Drawing.Size(54, 13);
            this.lblDDepart.TabIndex = 60;
            this.lblDDepart.Text = "Departure";
            // 
            // dtpDReturn
            // 
            this.dtpDReturn.CustomFormat = "MM-dd-yyyy";
            this.dtpDReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDReturn.Location = new System.Drawing.Point(222, 226);
            this.dtpDReturn.Name = "dtpDReturn";
            this.dtpDReturn.Size = new System.Drawing.Size(111, 20);
            this.dtpDReturn.TabIndex = 59;
            // 
            // dtpDDepart
            // 
            this.dtpDDepart.CustomFormat = "MM-dd-yyyy";
            this.dtpDDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDDepart.Location = new System.Drawing.Point(105, 226);
            this.dtpDDepart.Name = "dtpDDepart";
            this.dtpDDepart.Size = new System.Drawing.Size(111, 20);
            this.dtpDDepart.TabIndex = 58;
            // 
            // txtDTo
            // 
            this.txtDTo.Location = new System.Drawing.Point(333, 152);
            this.txtDTo.Name = "txtDTo";
            this.txtDTo.Size = new System.Drawing.Size(219, 20);
            this.txtDTo.TabIndex = 57;
            // 
            // txtDFrom
            // 
            this.txtDFrom.Location = new System.Drawing.Point(105, 152);
            this.txtDFrom.Name = "txtDFrom";
            this.txtDFrom.Size = new System.Drawing.Size(219, 20);
            this.txtDFrom.TabIndex = 56;
            // 
            // lblDTo
            // 
            this.lblDTo.AutoSize = true;
            this.lblDTo.Location = new System.Drawing.Point(333, 129);
            this.lblDTo.Name = "lblDTo";
            this.lblDTo.Size = new System.Drawing.Size(20, 13);
            this.lblDTo.TabIndex = 55;
            this.lblDTo.Text = "To";
            // 
            // lblDFrom
            // 
            this.lblDFrom.AutoSize = true;
            this.lblDFrom.Location = new System.Drawing.Point(101, 129);
            this.lblDFrom.Name = "lblDFrom";
            this.lblDFrom.Size = new System.Drawing.Size(30, 13);
            this.lblDFrom.TabIndex = 54;
            this.lblDFrom.Text = "From";
            // 
            // rdoTrip1
            // 
            this.rdoTrip1.AutoSize = true;
            this.rdoTrip1.Location = new System.Drawing.Point(199, 65);
            this.rdoTrip1.Name = "rdoTrip1";
            this.rdoTrip1.Size = new System.Drawing.Size(78, 17);
            this.rdoTrip1.TabIndex = 53;
            this.rdoTrip1.Text = "Round Trip";
            this.rdoTrip1.UseVisualStyleBackColor = true;
            // 
            // rdoTrip
            // 
            this.rdoTrip.AutoSize = true;
            this.rdoTrip.Checked = true;
            this.rdoTrip.Location = new System.Drawing.Point(104, 65);
            this.rdoTrip.Name = "rdoTrip";
            this.rdoTrip.Size = new System.Drawing.Size(70, 17);
            this.rdoTrip.TabIndex = 52;
            this.rdoTrip.TabStop = true;
            this.rdoTrip.Text = "One Way";
            this.rdoTrip.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 378);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(722, 150);
            this.dataGridView1.TabIndex = 71;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(530, 299);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(172, 38);
            this.btnCancel.TabIndex = 72;
            this.btnCancel.Text = "Booking";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSearchFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 549);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnSearchFlight);
            this.Controls.Add(this.comboBox8);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.comboBox7);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.comboBox6);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblDReturn);
            this.Controls.Add(this.lblDDepart);
            this.Controls.Add(this.dtpDReturn);
            this.Controls.Add(this.dtpDDepart);
            this.Controls.Add(this.txtDTo);
            this.Controls.Add(this.txtDFrom);
            this.Controls.Add(this.lblDTo);
            this.Controls.Add(this.lblDFrom);
            this.Controls.Add(this.rdoTrip1);
            this.Controls.Add(this.rdoTrip);
            this.KeyPreview = true;
            this.Name = "frmSearchFlights";
            this.Text = "frmSearchFlights";
            this.Load += new System.EventHandler(this.frmSearchFlights_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internationalAirportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesticAirportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private AirlineReservationSystemDataSet airlineReservationSystemDataSet;
        private System.Windows.Forms.BindingSource domesticAirportsBindingSource;
        private AirlineReservationSystemDataSetTableAdapters.DomesticAirportsTableAdapter domesticAirportsTableAdapter;
        private AirlineReservationSystemDataSet1 airlineReservationSystemDataSet1;
        private System.Windows.Forms.BindingSource internationalAirportsBindingSource;
        private AirlineReservationSystemDataSet1TableAdapters.InternationalAirportsTableAdapter internationalAirportsTableAdapter;
        private System.Windows.Forms.Button btnSearchFlight;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblDReturn;
        private System.Windows.Forms.Label lblDDepart;
        private System.Windows.Forms.DateTimePicker dtpDReturn;
        private System.Windows.Forms.DateTimePicker dtpDDepart;
        private System.Windows.Forms.TextBox txtDTo;
        private System.Windows.Forms.TextBox txtDFrom;
        private System.Windows.Forms.Label lblDTo;
        private System.Windows.Forms.Label lblDFrom;
        private System.Windows.Forms.RadioButton rdoTrip1;
        private System.Windows.Forms.RadioButton rdoTrip;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancel;
    }
}