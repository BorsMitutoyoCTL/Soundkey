namespace Soundkey
{
    partial class Hauptfenster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Hauptfenster));
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MenuAnzeigen = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonVerstecken = new System.Windows.Forms.Button();
            this.verzeichnisAuswahl = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonAuswahl = new System.Windows.Forms.Button();
            this.Beschreibung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "Soundkey";
            this.trayIcon.Visible = true;
            // 
            // trayMenu
            // 
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAnzeigen,
            this.MenuBeenden});
            this.trayMenu.Name = "trayMenu";
            this.trayMenu.Size = new System.Drawing.Size(124, 48);
            // 
            // MenuAnzeigen
            // 
            this.MenuAnzeigen.Name = "MenuAnzeigen";
            this.MenuAnzeigen.Size = new System.Drawing.Size(123, 22);
            this.MenuAnzeigen.Text = "Anzeigen";
            this.MenuAnzeigen.Click += new System.EventHandler(this.MenuAnzeigen_Click);
            // 
            // MenuBeenden
            // 
            this.MenuBeenden.Image = global::Soundkey.Properties.Resources.exit;
            this.MenuBeenden.Name = "MenuBeenden";
            this.MenuBeenden.Size = new System.Drawing.Size(123, 22);
            this.MenuBeenden.Text = "Beenden";
            this.MenuBeenden.Click += new System.EventHandler(this.MenuBeenden_Click);
            // 
            // buttonVerstecken
            // 
            this.buttonVerstecken.Location = new System.Drawing.Point(12, 150);
            this.buttonVerstecken.Name = "buttonVerstecken";
            this.buttonVerstecken.Size = new System.Drawing.Size(250, 23);
            this.buttonVerstecken.TabIndex = 0;
            this.buttonVerstecken.Text = "Verkleinern";
            this.buttonVerstecken.UseVisualStyleBackColor = true;
            this.buttonVerstecken.Click += new System.EventHandler(this.buttonVerstecken_Click);
            // 
            // verzeichnisAuswahl
            // 
            this.verzeichnisAuswahl.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.verzeichnisAuswahl.SelectedPath = "D:\\Projekte\\BORS\\github\\sounds";
            this.verzeichnisAuswahl.ShowNewFolderButton = false;
            // 
            // buttonAuswahl
            // 
            this.buttonAuswahl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAuswahl.Location = new System.Drawing.Point(12, 83);
            this.buttonAuswahl.Name = "buttonAuswahl";
            this.buttonAuswahl.Size = new System.Drawing.Size(250, 23);
            this.buttonAuswahl.TabIndex = 4;
            this.buttonAuswahl.Text = "Verzeichnis auswählen ...";
            this.buttonAuswahl.UseVisualStyleBackColor = true;
            this.buttonAuswahl.Click += new System.EventHandler(this.buttonAuswahl_Click);
            // 
            // Beschreibung
            // 
            this.Beschreibung.Location = new System.Drawing.Point(12, 9);
            this.Beschreibung.Name = "Beschreibung";
            this.Beschreibung.Size = new System.Drawing.Size(253, 71);
            this.Beschreibung.TabIndex = 5;
            this.Beschreibung.Text = "Bitte wählen Sie ein Verzeichnis aus, in dem sich MP3 Dateien befinden, die beim " +
    "Drücken einer Taste abgespielt werden sollen.\r\nDie MP3s müssen so heißen wie die" +
    " Tasten, also a.mp3, b.mp3, usw.";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(250, 28);
            this.label1.TabIndex = 6;
            this.label1.Text = "Damit das Fenster nicht im Weg ist, kannst Du es zum Symbol verkleinern";
            // 
            // Hauptfenster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Beschreibung);
            this.Controls.Add(this.buttonAuswahl);
            this.Controls.Add(this.buttonVerstecken);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(290, 217);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(290, 217);
            this.Name = "Hauptfenster";
            this.Text = "Soundkey";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.Button buttonVerstecken;
        private System.Windows.Forms.ContextMenuStrip trayMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuAnzeigen;
        private System.Windows.Forms.ToolStripMenuItem MenuBeenden;
        private System.Windows.Forms.FolderBrowserDialog verzeichnisAuswahl;
        private System.Windows.Forms.Button buttonAuswahl;
        private System.Windows.Forms.Label Beschreibung;
        private System.Windows.Forms.Label label1;
    }
}

