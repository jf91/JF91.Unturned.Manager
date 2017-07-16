namespace Windows.UnturnedManager.V1
{
    partial class FORM_SETTINGS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FORM_SETTINGS));
            this.LABEL_IP = new System.Windows.Forms.Label();
            this.TEXTBOX_IP = new System.Windows.Forms.TextBox();
            this.TEXTBOX_PORT = new System.Windows.Forms.TextBox();
            this.LABEL_PORT = new System.Windows.Forms.Label();
            this.TEXTBOX_USER = new System.Windows.Forms.TextBox();
            this.LABEL_USER = new System.Windows.Forms.Label();
            this.TEXTBOX_PASS = new System.Windows.Forms.TextBox();
            this.LABEL_PASS = new System.Windows.Forms.Label();
            this.TEXTBOX_DB = new System.Windows.Forms.TextBox();
            this.LABEL_DB = new System.Windows.Forms.Label();
            this.BUTTON_SAVE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LABEL_IP
            // 
            this.LABEL_IP.AutoSize = true;
            this.LABEL_IP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_IP.Location = new System.Drawing.Point(6, 18);
            this.LABEL_IP.Name = "LABEL_IP";
            this.LABEL_IP.Size = new System.Drawing.Size(85, 18);
            this.LABEL_IP.TabIndex = 0;
            this.LABEL_IP.Text = "IP or Address";
            // 
            // TEXTBOX_IP
            // 
            this.TEXTBOX_IP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_IP.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_IP.Location = new System.Drawing.Point(93, 16);
            this.TEXTBOX_IP.Name = "TEXTBOX_IP";
            this.TEXTBOX_IP.Size = new System.Drawing.Size(154, 23);
            this.TEXTBOX_IP.TabIndex = 1;
            // 
            // TEXTBOX_PORT
            // 
            this.TEXTBOX_PORT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PORT.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_PORT.Location = new System.Drawing.Point(93, 42);
            this.TEXTBOX_PORT.Name = "TEXTBOX_PORT";
            this.TEXTBOX_PORT.Size = new System.Drawing.Size(154, 23);
            this.TEXTBOX_PORT.TabIndex = 2;
            this.TEXTBOX_PORT.Text = "3306";
            // 
            // LABEL_PORT
            // 
            this.LABEL_PORT.AutoSize = true;
            this.LABEL_PORT.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_PORT.Location = new System.Drawing.Point(16, 44);
            this.LABEL_PORT.Name = "LABEL_PORT";
            this.LABEL_PORT.Size = new System.Drawing.Size(75, 18);
            this.LABEL_PORT.TabIndex = 2;
            this.LABEL_PORT.Text = "MySQL Port";
            // 
            // TEXTBOX_USER
            // 
            this.TEXTBOX_USER.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_USER.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_USER.Location = new System.Drawing.Point(93, 94);
            this.TEXTBOX_USER.Name = "TEXTBOX_USER";
            this.TEXTBOX_USER.Size = new System.Drawing.Size(154, 23);
            this.TEXTBOX_USER.TabIndex = 4;
            // 
            // LABEL_USER
            // 
            this.LABEL_USER.AutoSize = true;
            this.LABEL_USER.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_USER.Location = new System.Drawing.Point(25, 96);
            this.LABEL_USER.Name = "LABEL_USER";
            this.LABEL_USER.Size = new System.Drawing.Size(66, 18);
            this.LABEL_USER.TabIndex = 4;
            this.LABEL_USER.Text = "Username";
            // 
            // TEXTBOX_PASS
            // 
            this.TEXTBOX_PASS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_PASS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_PASS.Location = new System.Drawing.Point(93, 120);
            this.TEXTBOX_PASS.Name = "TEXTBOX_PASS";
            this.TEXTBOX_PASS.Size = new System.Drawing.Size(154, 23);
            this.TEXTBOX_PASS.TabIndex = 5;
            this.TEXTBOX_PASS.UseSystemPasswordChar = true;
            // 
            // LABEL_PASS
            // 
            this.LABEL_PASS.AutoSize = true;
            this.LABEL_PASS.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_PASS.Location = new System.Drawing.Point(29, 122);
            this.LABEL_PASS.Name = "LABEL_PASS";
            this.LABEL_PASS.Size = new System.Drawing.Size(62, 18);
            this.LABEL_PASS.TabIndex = 6;
            this.LABEL_PASS.Text = "Password";
            // 
            // TEXTBOX_DB
            // 
            this.TEXTBOX_DB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TEXTBOX_DB.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TEXTBOX_DB.Location = new System.Drawing.Point(93, 68);
            this.TEXTBOX_DB.Name = "TEXTBOX_DB";
            this.TEXTBOX_DB.Size = new System.Drawing.Size(154, 23);
            this.TEXTBOX_DB.TabIndex = 3;
            // 
            // LABEL_DB
            // 
            this.LABEL_DB.AutoSize = true;
            this.LABEL_DB.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LABEL_DB.Location = new System.Drawing.Point(29, 70);
            this.LABEL_DB.Name = "LABEL_DB";
            this.LABEL_DB.Size = new System.Drawing.Size(62, 18);
            this.LABEL_DB.TabIndex = 8;
            this.LABEL_DB.Text = "Database";
            // 
            // BUTTON_SAVE
            // 
            this.BUTTON_SAVE.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BUTTON_SAVE.Location = new System.Drawing.Point(12, 146);
            this.BUTTON_SAVE.Name = "BUTTON_SAVE";
            this.BUTTON_SAVE.Size = new System.Drawing.Size(235, 27);
            this.BUTTON_SAVE.TabIndex = 6;
            this.BUTTON_SAVE.Text = "Save";
            this.BUTTON_SAVE.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BUTTON_SAVE.UseVisualStyleBackColor = true;
            this.BUTTON_SAVE.Click += new System.EventHandler(this.BUTTON_SAVE_Click);
            // 
            // FORM_SETTINGS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 178);
            this.Controls.Add(this.BUTTON_SAVE);
            this.Controls.Add(this.TEXTBOX_DB);
            this.Controls.Add(this.LABEL_DB);
            this.Controls.Add(this.TEXTBOX_PASS);
            this.Controls.Add(this.LABEL_PASS);
            this.Controls.Add(this.TEXTBOX_USER);
            this.Controls.Add(this.LABEL_USER);
            this.Controls.Add(this.TEXTBOX_PORT);
            this.Controls.Add(this.LABEL_PORT);
            this.Controls.Add(this.TEXTBOX_IP);
            this.Controls.Add(this.LABEL_IP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(275, 216);
            this.Name = "FORM_SETTINGS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FORM_SETTINGS_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LABEL_IP;
        private System.Windows.Forms.TextBox TEXTBOX_IP;
        private System.Windows.Forms.TextBox TEXTBOX_PORT;
        private System.Windows.Forms.Label LABEL_PORT;
        private System.Windows.Forms.TextBox TEXTBOX_USER;
        private System.Windows.Forms.Label LABEL_USER;
        private System.Windows.Forms.TextBox TEXTBOX_PASS;
        private System.Windows.Forms.Label LABEL_PASS;
        private System.Windows.Forms.TextBox TEXTBOX_DB;
        private System.Windows.Forms.Label LABEL_DB;
        private System.Windows.Forms.Button BUTTON_SAVE;
    }
}