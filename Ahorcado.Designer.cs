namespace Juego_del_Ahorcado__Alberto_
{
    partial class Ahorcado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ahorcado));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnTryChar = new System.Windows.Forms.Button();
            this.txtCharacter = new System.Windows.Forms.TextBox();
            this.tbButtonsParent = new System.Windows.Forms.TableLayoutPanel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHints = new System.Windows.Forms.Label();
            this.cboxOptions = new System.Windows.Forms.ComboBox();
            this.opcionesDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetearJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelJuegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tbButtonsParent.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(272, 372);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pictureBox1.BackgroundImage = global::Juego_del_Ahorcado__Alberto_.Properties.Resources.sprite_1;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 366);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcionesDelJuegoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnTryChar
            // 
            this.btnTryChar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(87)))), ((int)(((byte)(173)))));
            this.btnTryChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTryChar.FlatAppearance.BorderSize = 0;
            this.btnTryChar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTryChar.ForeColor = System.Drawing.Color.White;
            this.btnTryChar.Location = new System.Drawing.Point(139, 3);
            this.btnTryChar.Name = "btnTryChar";
            this.btnTryChar.Size = new System.Drawing.Size(130, 45);
            this.btnTryChar.TabIndex = 1;
            this.btnTryChar.Text = "Letra";
            this.btnTryChar.UseVisualStyleBackColor = false;
            this.btnTryChar.Click += new System.EventHandler(this.btnTryChar_Click);
            // 
            // txtCharacter
            // 
            this.txtCharacter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtCharacter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCharacter.Location = new System.Drawing.Point(3, 3);
            this.txtCharacter.Name = "txtCharacter";
            this.txtCharacter.Size = new System.Drawing.Size(130, 26);
            this.txtCharacter.TabIndex = 0;
            this.txtCharacter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbButtonsParent
            // 
            this.tbButtonsParent.ColumnCount = 2;
            this.tbButtonsParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbButtonsParent.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbButtonsParent.Controls.Add(this.txtCharacter, 0, 0);
            this.tbButtonsParent.Controls.Add(this.btnTryChar, 1, 0);
            this.tbButtonsParent.Location = new System.Drawing.Point(0, 400);
            this.tbButtonsParent.Name = "tbButtonsParent";
            this.tbButtonsParent.RowCount = 1;
            this.tbButtonsParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbButtonsParent.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbButtonsParent.Size = new System.Drawing.Size(272, 51);
            this.tbButtonsParent.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(129)))), ((int)(((byte)(87)))), ((int)(((byte)(173)))));
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Location = new System.Drawing.Point(3, 3);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(330, 45);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.Text = "Jugar";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.btnPlay, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(272, 400);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(336, 51);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(272, 24);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(336, 160);
            this.tableLayoutPanel3.TabIndex = 7;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(330, 154);
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lblHints, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cboxOptions, 0, 2);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(272, 184);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(336, 208);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "¿Que quieres jugar hoy? 👀";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHints
            // 
            this.lblHints.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHints.ForeColor = System.Drawing.Color.White;
            this.lblHints.Location = new System.Drawing.Point(0, 0);
            this.lblHints.Margin = new System.Windows.Forms.Padding(0);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(336, 104);
            this.lblHints.TabIndex = 11;
            this.lblHints.Text = "_ _ _ _ _ _ _";
            this.lblHints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboxOptions
            // 
            this.cboxOptions.FormattingEnabled = true;
            this.cboxOptions.Location = new System.Drawing.Point(3, 148);
            this.cboxOptions.Name = "cboxOptions";
            this.cboxOptions.Size = new System.Drawing.Size(330, 21);
            this.cboxOptions.TabIndex = 10;
            // 
            // opcionesDelJuegoToolStripMenuItem
            // 
            this.opcionesDelJuegoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetearJuegoToolStripMenuItem,
            this.salirDelJuegoToolStripMenuItem});
            this.opcionesDelJuegoToolStripMenuItem.Name = "opcionesDelJuegoToolStripMenuItem";
            this.opcionesDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.opcionesDelJuegoToolStripMenuItem.Text = "Opciones del Juego";
            // 
            // resetearJuegoToolStripMenuItem
            // 
            this.resetearJuegoToolStripMenuItem.Name = "resetearJuegoToolStripMenuItem";
            this.resetearJuegoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetearJuegoToolStripMenuItem.Text = "Resetear Juego";
            this.resetearJuegoToolStripMenuItem.Click += new System.EventHandler(this.resetearJuegoToolStripMenuItem_Click);
            // 
            // salirDelJuegoToolStripMenuItem
            // 
            this.salirDelJuegoToolStripMenuItem.Name = "salirDelJuegoToolStripMenuItem";
            this.salirDelJuegoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.salirDelJuegoToolStripMenuItem.Text = "Salir del Juego";
            this.salirDelJuegoToolStripMenuItem.Click += new System.EventHandler(this.salirDelJuegoToolStripMenuItem_Click);
            // 
            // Ahorcado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(32)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(614, 451);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tbButtonsParent);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(630, 490);
            this.MinimumSize = new System.Drawing.Size(630, 490);
            this.Name = "Ahorcado";
            this.Text = "Juego del Ahorcado";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tbButtonsParent.ResumeLayout(false);
            this.tbButtonsParent.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTryChar;
        private System.Windows.Forms.TextBox txtCharacter;
        private System.Windows.Forms.TableLayoutPanel tbButtonsParent;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHints;
        private System.Windows.Forms.ComboBox cboxOptions;
        private System.Windows.Forms.ToolStripMenuItem opcionesDelJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetearJuegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelJuegoToolStripMenuItem;
    }
}

