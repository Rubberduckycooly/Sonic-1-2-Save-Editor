namespace HedgeModManager
{
    partial class SLWSaveForm
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
            this.label = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Button_Install = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.label.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label.Location = new System.Drawing.Point(71, 11);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(332, 40);
            this.label.TabIndex = 3;
            this.label.Text = "Please select an account ";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listView1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.listView1.Location = new System.Drawing.Point(16, 53);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(489, 303);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.DrawItem += new System.Windows.Forms.DrawListViewItemEventHandler(this.ListView1_DrawItem);
            // 
            // Button_Install
            // 
            this.Button_Install.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button_Install.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Button_Install.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Button_Install.Location = new System.Drawing.Point(16, 364);
            this.Button_Install.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_Install.Name = "Button_Install";
            this.Button_Install.Size = new System.Drawing.Size(491, 43);
            this.Button_Install.TabIndex = 5;
            this.Button_Install.Text = "OK";
            this.Button_Install.UseVisualStyleBackColor = true;
            this.Button_Install.Click += new System.EventHandler(this.Button_Install_Click);
            // 
            // SLWSaveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(523, 422);
            this.Controls.Add(this.Button_Install);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SLWSaveForm";
            this.Text = "Select Steam Account";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SLWSaveForm_FormClosing);
            this.Load += new System.EventHandler(this.SLWSaveForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button Button_Install;
    }
}