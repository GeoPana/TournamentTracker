namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.selectExitingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.selectExistingTournamentLabel = new System.Windows.Forms.Label();
            this.tournamentDashboardLabel = new System.Windows.Forms.Label();
            this.loadTournamentButton = new System.Windows.Forms.Button();
            this.createNewTournamentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // selectExitingTournamentDropDown
            // 
            this.selectExitingTournamentDropDown.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectExitingTournamentDropDown.FormattingEnabled = true;
            this.selectExitingTournamentDropDown.Location = new System.Drawing.Point(65, 154);
            this.selectExitingTournamentDropDown.Name = "selectExitingTournamentDropDown";
            this.selectExitingTournamentDropDown.Size = new System.Drawing.Size(348, 38);
            this.selectExitingTournamentDropDown.TabIndex = 51;
            // 
            // selectExistingTournamentLabel
            // 
            this.selectExistingTournamentLabel.AutoSize = true;
            this.selectExistingTournamentLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectExistingTournamentLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.selectExistingTournamentLabel.Location = new System.Drawing.Point(65, 121);
            this.selectExistingTournamentLabel.Name = "selectExistingTournamentLabel";
            this.selectExistingTournamentLabel.Size = new System.Drawing.Size(185, 30);
            this.selectExistingTournamentLabel.TabIndex = 50;
            this.selectExistingTournamentLabel.Text = "Select Tournament";
            // 
            // tournamentDashboardLabel
            // 
            this.tournamentDashboardLabel.AutoSize = true;
            this.tournamentDashboardLabel.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tournamentDashboardLabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.tournamentDashboardLabel.Location = new System.Drawing.Point(35, 30);
            this.tournamentDashboardLabel.Name = "tournamentDashboardLabel";
            this.tournamentDashboardLabel.Size = new System.Drawing.Size(408, 50);
            this.tournamentDashboardLabel.TabIndex = 52;
            this.tournamentDashboardLabel.Text = "Tournament Dashboard";
            // 
            // loadTournamentButton
            // 
            this.loadTournamentButton.BackColor = System.Drawing.Color.Silver;
            this.loadTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.loadTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.loadTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.loadTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loadTournamentButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.loadTournamentButton.Location = new System.Drawing.Point(164, 198);
            this.loadTournamentButton.Name = "loadTournamentButton";
            this.loadTournamentButton.Size = new System.Drawing.Size(151, 42);
            this.loadTournamentButton.TabIndex = 61;
            this.loadTournamentButton.Text = "Load Tournament";
            this.loadTournamentButton.UseVisualStyleBackColor = false;
            // 
            // createNewTournamentButton
            // 
            this.createNewTournamentButton.BackColor = System.Drawing.Color.Silver;
            this.createNewTournamentButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.createNewTournamentButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.createNewTournamentButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.createNewTournamentButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createNewTournamentButton.ForeColor = System.Drawing.Color.SteelBlue;
            this.createNewTournamentButton.Location = new System.Drawing.Point(96, 288);
            this.createNewTournamentButton.Name = "createNewTournamentButton";
            this.createNewTournamentButton.Size = new System.Drawing.Size(287, 67);
            this.createNewTournamentButton.TabIndex = 62;
            this.createNewTournamentButton.Text = "Create New Tournament";
            this.createNewTournamentButton.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 391);
            this.Controls.Add(this.createNewTournamentButton);
            this.Controls.Add(this.loadTournamentButton);
            this.Controls.Add(this.tournamentDashboardLabel);
            this.Controls.Add(this.selectExitingTournamentDropDown);
            this.Controls.Add(this.selectExistingTournamentLabel);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.Load += new System.EventHandler(this.TournamentDashboardForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox selectExitingTournamentDropDown;
        private Label selectExistingTournamentLabel;
        private Label tournamentDashboardLabel;
        private Button loadTournamentButton;
        private Button createNewTournamentButton;
    }
}