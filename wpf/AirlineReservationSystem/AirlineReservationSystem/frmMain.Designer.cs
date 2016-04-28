namespace AirlineReservationSystem
{
    partial class frmMain
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.mastersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airportMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rateMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transactionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchForFlightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelBookingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mastersToolStripMenuItem,
            this.transactionToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(605, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // mastersToolStripMenuItem
            // 
            this.mastersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.airportMasterToolStripMenuItem,
            this.flightMasterToolStripMenuItem,
            this.userMasterToolStripMenuItem,
            this.rateMasterToolStripMenuItem});
            this.mastersToolStripMenuItem.Name = "mastersToolStripMenuItem";
            this.mastersToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.mastersToolStripMenuItem.Text = "Masters";
            // 
            // airportMasterToolStripMenuItem
            // 
            this.airportMasterToolStripMenuItem.Name = "airportMasterToolStripMenuItem";
            this.airportMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.airportMasterToolStripMenuItem.Text = "AirportMaster";
            this.airportMasterToolStripMenuItem.Click += new System.EventHandler(this.airportMasterToolStripMenuItem_Click);
            // 
            // flightMasterToolStripMenuItem
            // 
            this.flightMasterToolStripMenuItem.Name = "flightMasterToolStripMenuItem";
            this.flightMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.flightMasterToolStripMenuItem.Text = "FlightMaster";
            this.flightMasterToolStripMenuItem.Click += new System.EventHandler(this.flightMasterToolStripMenuItem_Click);
            // 
            // userMasterToolStripMenuItem
            // 
            this.userMasterToolStripMenuItem.Name = "userMasterToolStripMenuItem";
            this.userMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userMasterToolStripMenuItem.Text = "UserMaster";
            // 
            // rateMasterToolStripMenuItem
            // 
            this.rateMasterToolStripMenuItem.Name = "rateMasterToolStripMenuItem";
            this.rateMasterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rateMasterToolStripMenuItem.Text = "RateMaster";
            this.rateMasterToolStripMenuItem.Click += new System.EventHandler(this.rateMasterToolStripMenuItem_Click);
            // 
            // transactionToolStripMenuItem
            // 
            this.transactionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchForFlightsToolStripMenuItem,
            this.cancelBookingToolStripMenuItem});
            this.transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            this.transactionToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.transactionToolStripMenuItem.Text = "Book";
            // 
            // searchForFlightsToolStripMenuItem
            // 
            this.searchForFlightsToolStripMenuItem.Name = "searchForFlightsToolStripMenuItem";
            this.searchForFlightsToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.searchForFlightsToolStripMenuItem.Text = "Search For Flights";
            this.searchForFlightsToolStripMenuItem.Click += new System.EventHandler(this.searchForFlightsToolStripMenuItem_Click);
            // 
            // cancelBookingToolStripMenuItem
            // 
            this.cancelBookingToolStripMenuItem.Name = "cancelBookingToolStripMenuItem";
            this.cancelBookingToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
            this.cancelBookingToolStripMenuItem.Text = "Cancel Booking";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitApplicationToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            // 
            // exitApplicationToolStripMenuItem
            // 
            this.exitApplicationToolStripMenuItem.Name = "exitApplicationToolStripMenuItem";
            this.exitApplicationToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.exitApplicationToolStripMenuItem.Text = "Exit Application";
            this.exitApplicationToolStripMenuItem.Click += new System.EventHandler(this.exitApplicationToolStripMenuItem_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 389);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem mastersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transactionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchForFlightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelBookingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airportMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userMasterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rateMasterToolStripMenuItem;
    }
}