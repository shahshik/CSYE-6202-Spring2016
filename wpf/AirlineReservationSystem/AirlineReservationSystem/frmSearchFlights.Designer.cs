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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.airlineReservationSystemDataSet = new AirlineReservationSystem.AirlineReservationSystemDataSet();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.domesticAirportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.domesticAirportsTableAdapter = new AirlineReservationSystem.AirlineReservationSystemDataSetTableAdapters.DomesticAirportsTableAdapter();
            this.airlineReservationSystemDataSet1 = new AirlineReservationSystem.AirlineReservationSystemDataSet1();
            this.internationalAirportsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.internationalAirportsTableAdapter = new AirlineReservationSystem.AirlineReservationSystemDataSet1TableAdapters.InternationalAirportsTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesticAirportsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalAirportsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(11, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(612, 430);
            this.tabControl1.TabIndex = 18;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.comboBox8);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.comboBox7);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.comboBox6);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.comboBox5);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.lblDReturn);
            this.tabPage1.Controls.Add(this.lblDDepart);
            this.tabPage1.Controls.Add(this.dtpDReturn);
            this.tabPage1.Controls.Add(this.dtpDDepart);
            this.tabPage1.Controls.Add(this.txtDTo);
            this.tabPage1.Controls.Add(this.txtDFrom);
            this.tabPage1.Controls.Add(this.lblDTo);
            this.tabPage1.Controls.Add(this.lblDFrom);
            this.tabPage1.Controls.Add(this.rdoTrip1);
            this.tabPage1.Controls.Add(this.rdoTrip);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(604, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Domestic";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(28, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(172, 38);
            this.button2.TabIndex = 51;
            this.button2.Text = "Search Flights";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(29, 277);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(171, 24);
            this.comboBox8.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(26, 254);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 16);
            this.label12.TabIndex = 49;
            this.label12.Text = "Class:";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(498, 185);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(52, 24);
            this.comboBox7.TabIndex = 48;
            this.comboBox7.SelectedIndexChanged += new System.EventHandler(this.comboBox7_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(495, 162);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 16);
            this.label11.TabIndex = 47;
            this.label11.Text = "Infants:";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(410, 185);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(52, 24);
            this.comboBox6.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(407, 162);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 16);
            this.label10.TabIndex = 45;
            this.label10.Text = "Children:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(322, 185);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(52, 24);
            this.comboBox5.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(319, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "Adults:";
            // 
            // lblDReturn
            // 
            this.lblDReturn.AutoSize = true;
            this.lblDReturn.Location = new System.Drawing.Point(147, 162);
            this.lblDReturn.Name = "lblDReturn";
            this.lblDReturn.Size = new System.Drawing.Size(53, 16);
            this.lblDReturn.TabIndex = 28;
            this.lblDReturn.Text = "Return";
            // 
            // lblDDepart
            // 
            this.lblDDepart.AutoSize = true;
            this.lblDDepart.Location = new System.Drawing.Point(26, 162);
            this.lblDDepart.Name = "lblDDepart";
            this.lblDDepart.Size = new System.Drawing.Size(77, 16);
            this.lblDDepart.TabIndex = 27;
            this.lblDDepart.Text = "Departure";
            // 
            // dtpDReturn
            // 
            this.dtpDReturn.CustomFormat = "MM-dd-yyyy";
            this.dtpDReturn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDReturn.Location = new System.Drawing.Point(146, 187);
            this.dtpDReturn.Name = "dtpDReturn";
            this.dtpDReturn.Size = new System.Drawing.Size(111, 22);
            this.dtpDReturn.TabIndex = 26;
            // 
            // dtpDDepart
            // 
            this.dtpDDepart.CustomFormat = "MM-dd-yyyy";
            this.dtpDDepart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDDepart.Location = new System.Drawing.Point(29, 187);
            this.dtpDDepart.Name = "dtpDDepart";
            this.dtpDDepart.Size = new System.Drawing.Size(111, 22);
            this.dtpDDepart.TabIndex = 25;
            // 
            // txtDTo
            // 
            this.txtDTo.Location = new System.Drawing.Point(257, 113);
            this.txtDTo.Name = "txtDTo";
            this.txtDTo.Size = new System.Drawing.Size(219, 22);
            this.txtDTo.TabIndex = 24;
            // 
            // txtDFrom
            // 
            this.txtDFrom.Location = new System.Drawing.Point(29, 113);
            this.txtDFrom.Name = "txtDFrom";
            this.txtDFrom.Size = new System.Drawing.Size(219, 22);
            this.txtDFrom.TabIndex = 23;
            // 
            // lblDTo
            // 
            this.lblDTo.AutoSize = true;
            this.lblDTo.Location = new System.Drawing.Point(257, 90);
            this.lblDTo.Name = "lblDTo";
            this.lblDTo.Size = new System.Drawing.Size(27, 16);
            this.lblDTo.TabIndex = 22;
            this.lblDTo.Text = "To";
            // 
            // lblDFrom
            // 
            this.lblDFrom.AutoSize = true;
            this.lblDFrom.Location = new System.Drawing.Point(25, 90);
            this.lblDFrom.Name = "lblDFrom";
            this.lblDFrom.Size = new System.Drawing.Size(43, 16);
            this.lblDFrom.TabIndex = 21;
            this.lblDFrom.Text = "From";
            // 
            // rdoTrip1
            // 
            this.rdoTrip1.AutoSize = true;
            this.rdoTrip1.Location = new System.Drawing.Point(123, 26);
            this.rdoTrip1.Name = "rdoTrip1";
            this.rdoTrip1.Size = new System.Drawing.Size(103, 20);
            this.rdoTrip1.TabIndex = 20;
            this.rdoTrip1.Text = "Round Trip";
            this.rdoTrip1.UseVisualStyleBackColor = true;
            // 
            // rdoTrip
            // 
            this.rdoTrip.AutoSize = true;
            this.rdoTrip.Checked = true;
            this.rdoTrip.Location = new System.Drawing.Point(28, 26);
            this.rdoTrip.Name = "rdoTrip";
            this.rdoTrip.Size = new System.Drawing.Size(89, 20);
            this.rdoTrip.TabIndex = 19;
            this.rdoTrip.TabStop = true;
            this.rdoTrip.Text = "One Way";
            this.rdoTrip.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.comboBox9);
            this.tabPage2.Controls.Add(this.comboBox4);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.comboBox3);
            this.tabPage2.Controls.Add(this.comboBox2);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dateTimePicker1);
            this.tabPage2.Controls.Add(this.dateTimePicker2);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.radioButton1);
            this.tabPage2.Controls.Add(this.radioButton2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(604, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(29, 277);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(169, 24);
            this.comboBox4.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Class:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(498, 185);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(52, 24);
            this.comboBox3.TabIndex = 44;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(410, 185);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(52, 24);
            this.comboBox2.TabIndex = 43;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(322, 185);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(52, 24);
            this.comboBox1.TabIndex = 42;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(495, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 16);
            this.label7.TabIndex = 41;
            this.label7.Text = "Infants:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Children:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(319, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 39;
            this.label5.Text = "Adults:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(147, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 38;
            this.label1.Text = "Return";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 37;
            this.label2.Text = "Departure";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(146, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker1.TabIndex = 36;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "MM-dd-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(29, 187);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(111, 22);
            this.dateTimePicker2.TabIndex = 35;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(257, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(219, 22);
            this.textBox1.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(257, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 32;
            this.label3.Text = "To";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 31;
            this.label4.Text = "From";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(123, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 20);
            this.radioButton1.TabIndex = 30;
            this.radioButton1.Text = "Round Trip";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Checked = true;
            this.radioButton2.Location = new System.Drawing.Point(28, 26);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 20);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "One Way";
            this.radioButton2.UseVisualStyleBackColor = true;
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
            // comboBox9
            // 
            this.comboBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox9.DataSource = this.internationalAirportsBindingSource;
            this.comboBox9.DisplayMember = "Airport_Name";
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(29, 113);
            this.comboBox9.MaxDropDownItems = 10;
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(218, 24);
            this.comboBox9.TabIndex = 48;
            this.comboBox9.ValueMember = "Airport_Id";
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
            // airlineReservationSystemDataSet1
            // 
            this.airlineReservationSystemDataSet1.DataSetName = "AirlineReservationSystemDataSet1";
            this.airlineReservationSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // internationalAirportsBindingSource
            // 
            this.internationalAirportsBindingSource.DataMember = "InternationalAirports";
            this.internationalAirportsBindingSource.DataSource = this.airlineReservationSystemDataSet1;
            // 
            // internationalAirportsTableAdapter
            // 
            this.internationalAirportsTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(28, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 38);
            this.button1.TabIndex = 52;
            this.button1.Text = "Search Flights";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmSearchFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 455);
            this.Controls.Add(this.tabControl1);
            this.KeyPreview = true;
            this.Name = "frmSearchFlights";
            this.Text = "frmSearchFlights";
            this.Load += new System.EventHandler(this.frmSearchFlights_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.domesticAirportsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.airlineReservationSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalAirportsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RadioButton rdoTrip1;
        private System.Windows.Forms.RadioButton rdoTrip;
        private System.Windows.Forms.TextBox txtDFrom;
        private System.Windows.Forms.Label lblDTo;
        private System.Windows.Forms.Label lblDFrom;
        private System.Windows.Forms.TextBox txtDTo;
        private System.Windows.Forms.Label lblDDepart;
        private System.Windows.Forms.DateTimePicker dtpDReturn;
        private System.Windows.Forms.DateTimePicker dtpDDepart;
        private System.Windows.Forms.Label lblDReturn;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.BindingSource bindingSource1;
        private AirlineReservationSystemDataSet airlineReservationSystemDataSet;
        private System.Windows.Forms.ComboBox comboBox9;
        private System.Windows.Forms.BindingSource domesticAirportsBindingSource;
        private AirlineReservationSystemDataSetTableAdapters.DomesticAirportsTableAdapter domesticAirportsTableAdapter;
        private AirlineReservationSystemDataSet1 airlineReservationSystemDataSet1;
        private System.Windows.Forms.BindingSource internationalAirportsBindingSource;
        private AirlineReservationSystemDataSet1TableAdapters.InternationalAirportsTableAdapter internationalAirportsTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}