namespace ClinicDesktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUpdateClients = new Button();
            listViewClients = new ListView();
            columnHeaderId = new ColumnHeader();
            columnHeaderSurName = new ColumnHeader();
            columnHeaderFirstName = new ColumnHeader();
            columnHeaderPatronymic = new ColumnHeader();
            listViewPets = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeaderName = new ColumnHeader();
            columnHeaderIdClient = new ColumnHeader();
            btnUpdatePets = new Button();
            SuspendLayout();
            // 
            // btnUpdateClients
            // 
            btnUpdateClients.BackColor = Color.FromArgb(192, 0, 192);
            btnUpdateClients.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdateClients.ForeColor = Color.White;
            btnUpdateClients.Location = new Point(577, 200);
            btnUpdateClients.Name = "btnUpdateClients";
            btnUpdateClients.Size = new Size(211, 41);
            btnUpdateClients.TabIndex = 0;
            btnUpdateClients.Text = "Update Clients";
            btnUpdateClients.UseVisualStyleBackColor = false;
            btnUpdateClients.Click += btnUpdateClient_Click;
            // 
            // listViewClients
            // 
            listViewClients.Columns.AddRange(new ColumnHeader[] { columnHeaderId, columnHeaderSurName, columnHeaderFirstName, columnHeaderPatronymic });
            listViewClients.FullRowSelect = true;
            listViewClients.GridLines = true;
            listViewClients.Location = new Point(12, 12);
            listViewClients.MultiSelect = false;
            listViewClients.Name = "listViewClients";
            listViewClients.Size = new Size(776, 173);
            listViewClients.TabIndex = 1;
            listViewClients.UseCompatibleStateImageBehavior = false;
            listViewClients.View = View.Details;
            listViewClients.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // columnHeaderId
            // 
            columnHeaderId.Text = "#";
            // 
            // columnHeaderSurName
            // 
            columnHeaderSurName.Text = "SurName";
            columnHeaderSurName.Width = 200;
            // 
            // columnHeaderFirstName
            // 
            columnHeaderFirstName.Text = "Name";
            columnHeaderFirstName.Width = 200;
            // 
            // columnHeaderPatronymic
            // 
            columnHeaderPatronymic.Text = "Patronymic";
            columnHeaderPatronymic.Width = 200;
            // 
            // listViewPets
            // 
            listViewPets.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeaderName, columnHeaderIdClient });
            listViewPets.FullRowSelect = true;
            listViewPets.GridLines = true;
            listViewPets.Location = new Point(12, 263);
            listViewPets.Name = "listViewPets";
            listViewPets.Size = new Size(776, 206);
            listViewPets.TabIndex = 3;
            listViewPets.UseCompatibleStateImageBehavior = false;
            listViewPets.View = View.Details;
            listViewPets.SelectedIndexChanged += listViewPets_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "#";
            // 
            // columnHeaderName
            // 
            columnHeaderName.Text = "Name";
            columnHeaderName.Width = 200;
            // 
            // columnHeaderIdClient
            // 
            columnHeaderIdClient.Text = "Id Client";
            columnHeaderIdClient.Width = 200;
            // 
            // btnUpdatePets
            // 
            btnUpdatePets.BackColor = Color.FromArgb(192, 0, 192);
            btnUpdatePets.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdatePets.ForeColor = Color.White;
            btnUpdatePets.Location = new Point(577, 475);
            btnUpdatePets.Name = "btnUpdatePets";
            btnUpdatePets.Size = new Size(211, 42);
            btnUpdatePets.TabIndex = 4;
            btnUpdatePets.Text = "Update Pets";
            btnUpdatePets.UseVisualStyleBackColor = false;
            btnUpdatePets.Click += btnUpdatePets_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(845, 620);
            Controls.Add(btnUpdatePets);
            Controls.Add(listViewPets);
            Controls.Add(listViewClients);
            Controls.Add(btnUpdateClients);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "My clinic";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdateClients;
        private ListView listViewClients;
        private ColumnHeader columnHeaderId;
        private ColumnHeader columnHeaderSurName;
        private ColumnHeader columnHeaderFirstName;
        private ColumnHeader columnHeaderPatronymic;
        private ListView listViewPets;
        private Button btnUpdatePets;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeaderName;
        private ColumnHeader columnHeaderIdClient;
    }
}