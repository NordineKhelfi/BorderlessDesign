namespace BorderlessTest
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bMinimize = new System.Windows.Forms.Button();
            this.bMaximize = new System.Windows.Forms.Button();
            this.bQuit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(52)))), ((int)(((byte)(127)))));
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Controls.Add(this.bMinimize);
            this.panelTop.Controls.Add(this.bMaximize);
            this.panelTop.Controls.Add(this.bQuit);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(955, 40);
            this.panelTop.TabIndex = 0;
            this.panelTop.DoubleClick += new System.EventHandler(this.panelTop_DoubleClick);
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(408, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Borderless Design";
            this.label1.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            this.label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label1_MouseDown);
            this.label1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label1_MouseMove);
            this.label1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.label1_MouseUp);
            // 
            // bMinimize
            // 
            this.bMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bMinimize.FlatAppearance.BorderSize = 0;
            this.bMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.bMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMinimize.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMinimize.ForeColor = System.Drawing.Color.White;
            this.bMinimize.Image = global::BorderlessTest.Properties.Resources.BTctrlReduire;
            this.bMinimize.Location = new System.Drawing.Point(826, 0);
            this.bMinimize.Name = "bMinimize";
            this.bMinimize.Size = new System.Drawing.Size(43, 40);
            this.bMinimize.TabIndex = 3;
            this.bMinimize.UseVisualStyleBackColor = true;
            this.bMinimize.Click += new System.EventHandler(this.bMinimize_Click);
            // 
            // bMaximize
            // 
            this.bMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.bMaximize.FlatAppearance.BorderSize = 0;
            this.bMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(180)))), ((int)(((byte)(255)))));
            this.bMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bMaximize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bMaximize.ForeColor = System.Drawing.Color.White;
            this.bMaximize.Image = global::BorderlessTest.Properties.Resources.BTctrlAgrandir;
            this.bMaximize.Location = new System.Drawing.Point(869, 0);
            this.bMaximize.Name = "bMaximize";
            this.bMaximize.Size = new System.Drawing.Size(43, 40);
            this.bMaximize.TabIndex = 2;
            this.bMaximize.UseVisualStyleBackColor = true;
            this.bMaximize.Click += new System.EventHandler(this.bMaximise_Click);
            // 
            // bQuit
            // 
            this.bQuit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bQuit.FlatAppearance.BorderSize = 0;
            this.bQuit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.bQuit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bQuit.ForeColor = System.Drawing.Color.White;
            this.bQuit.Location = new System.Drawing.Point(912, 0);
            this.bQuit.Name = "bQuit";
            this.bQuit.Size = new System.Drawing.Size(43, 40);
            this.bQuit.TabIndex = 1;
            this.bQuit.Text = "X";
            this.bQuit.UseVisualStyleBackColor = true;
            this.bQuit.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(83)))), ((int)(((byte)(204)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(190, 515);
            this.panel1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(90)))), ((int)(((byte)(127)))));
            this.ClientSize = new System.Drawing.Size(955, 555);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Button bQuit;
        private System.Windows.Forms.Button bMaximize;
        private System.Windows.Forms.Button bMinimize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}

