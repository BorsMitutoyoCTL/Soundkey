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
            this.buttonVerstecken = new System.Windows.Forms.Button();
            this.verzeichnisAuswahl = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonAuswahl = new System.Windows.Forms.Button();
            this.Beschreibung = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Auswahl = new System.Windows.Forms.Label();
            this.Ordner = new System.Windows.Forms.Label();
            this.MenuBeenden = new System.Windows.Forms.ToolStripMenuItem();
            this.trayMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // trayIcon
            // 
            resources.ApplyResources(this.trayIcon, "trayIcon");
            this.trayIcon.ContextMenuStrip = this.trayMenu;
            // 
            // trayMenu
            // 
            resources.ApplyResources(this.trayMenu, "trayMenu");
            this.trayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuAnzeigen,
            this.MenuBeenden});
            this.trayMenu.Name = "trayMenu";
            // 
            // MenuAnzeigen
            // 
            resources.ApplyResources(this.MenuAnzeigen, "MenuAnzeigen");
            this.MenuAnzeigen.Name = "MenuAnzeigen";
            this.MenuAnzeigen.Click += new System.EventHandler(this.MenuAnzeigen_Click);
            // 
            // buttonVerstecken
            // 
            resources.ApplyResources(this.buttonVerstecken, "buttonVerstecken");
            this.buttonVerstecken.Name = "buttonVerstecken";
            this.buttonVerstecken.UseVisualStyleBackColor = true;
            this.buttonVerstecken.Click += new System.EventHandler(this.buttonVerstecken_Click);
            // 
            // verzeichnisAuswahl
            // 
            resources.ApplyResources(this.verzeichnisAuswahl, "verzeichnisAuswahl");
            this.verzeichnisAuswahl.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.verzeichnisAuswahl.ShowNewFolderButton = false;
            // 
            // buttonAuswahl
            // 
            resources.ApplyResources(this.buttonAuswahl, "buttonAuswahl");
            this.buttonAuswahl.Name = "buttonAuswahl";
            this.buttonAuswahl.UseVisualStyleBackColor = true;
            this.buttonAuswahl.Click += new System.EventHandler(this.buttonAuswahl_Click);
            // 
            // Beschreibung
            // 
            resources.ApplyResources(this.Beschreibung, "Beschreibung");
            this.Beschreibung.Name = "Beschreibung";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // Auswahl
            // 
            resources.ApplyResources(this.Auswahl, "Auswahl");
            this.Auswahl.Name = "Auswahl";
            // 
            // Ordner
            // 
            resources.ApplyResources(this.Ordner, "Ordner");
            this.Ordner.ForeColor = System.Drawing.Color.Red;
            this.Ordner.Name = "Ordner";
            // 
            // MenuBeenden
            // 
            resources.ApplyResources(this.MenuBeenden, "MenuBeenden");
            this.MenuBeenden.Image = global::Soundkey.Properties.Resources.exit;
            this.MenuBeenden.Name = "MenuBeenden";
            this.MenuBeenden.Click += new System.EventHandler(this.MenuBeenden_Click);
            // 
            // Hauptfenster
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Ordner);
            this.Controls.Add(this.Auswahl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Beschreibung);
            this.Controls.Add(this.buttonAuswahl);
            this.Controls.Add(this.buttonVerstecken);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Hauptfenster";
            this.Load += new System.EventHandler(this.Hauptfenster_Load);
            this.trayMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label Auswahl;
        private System.Windows.Forms.Label Ordner;
    }
}

