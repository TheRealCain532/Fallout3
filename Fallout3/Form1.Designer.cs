namespace Fallout3
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Connect = new System.Windows.Forms.Button();
            this.statbox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.connectbox = new System.Windows.Forms.GroupBox();
            this.tmapi = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.button7 = new System.Windows.Forms.Button();
            this.multvalue = new System.Windows.Forms.Label();
            this.physvalue = new System.Windows.Forms.Label();
            this.multivalue = new System.Windows.Forms.TrackBar();
            this.multibox = new System.Windows.Forms.ComboBox();
            this.physicsbar = new System.Windows.Forms.TrackBar();
            this.physicsbox = new System.Windows.Forms.ComboBox();
            this.mrr = new System.Windows.Forms.Button();
            this.mstats = new System.Windows.Forms.Button();
            this.god = new System.Windows.Forms.Button();
            this.lbrte = new System.Windows.Forms.Button();
            this.ufo = new System.Windows.Forms.Button();
            this.rfire = new System.Windows.Forms.Button();
            this.statbox2.SuspendLayout();
            this.connectbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.multivalue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicsbar)).BeginInit();
            this.SuspendLayout();
            // 
            // Connect
            // 
            resources.ApplyResources(this.Connect, "Connect");
            this.Connect.ForeColor = System.Drawing.Color.Red;
            this.Connect.Name = "Connect";
            this.Connect.UseVisualStyleBackColor = true;
            this.Connect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // statbox2
            // 
            this.statbox2.Controls.Add(this.label2);
            this.statbox2.Controls.Add(this.label4);
            resources.ApplyResources(this.statbox2, "statbox2");
            this.statbox2.ForeColor = System.Drawing.Color.DimGray;
            this.statbox2.Name = "statbox2";
            this.statbox2.TabStop = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Name = "label4";
            this.label4.UseMnemonic = false;
            // 
            // connectbox
            // 
            this.connectbox.BackColor = System.Drawing.Color.Transparent;
            this.connectbox.Controls.Add(this.Connect);
            resources.ApplyResources(this.connectbox, "connectbox");
            this.connectbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.connectbox.ForeColor = System.Drawing.Color.DimGray;
            this.connectbox.Name = "connectbox";
            this.connectbox.TabStop = false;
            // 
            // tmapi
            // 
            resources.ApplyResources(this.tmapi, "tmapi");
            this.tmapi.Checked = true;
            this.tmapi.Name = "tmapi";
            this.tmapi.TabStop = true;
            this.tmapi.UseVisualStyleBackColor = true;
            this.tmapi.CheckedChanged += new System.EventHandler(this.tmapi_CheckedChanged);
            // 
            // radioButton1
            // 
            resources.ApplyResources(this.radioButton1, "radioButton1");
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            resources.ApplyResources(this.button7, "button7");
            this.button7.Name = "button7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // multvalue
            // 
            resources.ApplyResources(this.multvalue, "multvalue");
            this.multvalue.BackColor = System.Drawing.SystemColors.Control;
            this.multvalue.Name = "multvalue";
            // 
            // physvalue
            // 
            resources.ApplyResources(this.physvalue, "physvalue");
            this.physvalue.BackColor = System.Drawing.SystemColors.Control;
            this.physvalue.Name = "physvalue";
            // 
            // multivalue
            // 
            this.multivalue.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.multivalue, "multivalue");
            this.multivalue.Name = "multivalue";
            this.multivalue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.multivalue.Scroll += new System.EventHandler(this.multivalue_Scroll);
            // 
            // multibox
            // 
            this.multibox.BackColor = System.Drawing.SystemColors.Window;
            this.multibox.FormattingEnabled = true;
            this.multibox.Items.AddRange(new object[] {
            resources.GetString("multibox.Items"),
            resources.GetString("multibox.Items1"),
            resources.GetString("multibox.Items2"),
            resources.GetString("multibox.Items3"),
            resources.GetString("multibox.Items4"),
            resources.GetString("multibox.Items5"),
            resources.GetString("multibox.Items6"),
            resources.GetString("multibox.Items7"),
            resources.GetString("multibox.Items8"),
            resources.GetString("multibox.Items9")});
            resources.ApplyResources(this.multibox, "multibox");
            this.multibox.Name = "multibox";
            this.multibox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // physicsbar
            // 
            this.physicsbar.BackColor = System.Drawing.SystemColors.Control;
            resources.ApplyResources(this.physicsbar, "physicsbar");
            this.physicsbar.Name = "physicsbar";
            this.physicsbar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.physicsbar.Scroll += new System.EventHandler(this.physicsbar_Scroll);
            // 
            // physicsbox
            // 
            this.physicsbox.BackColor = System.Drawing.SystemColors.Window;
            this.physicsbox.FormattingEnabled = true;
            this.physicsbox.Items.AddRange(new object[] {
            resources.GetString("physicsbox.Items"),
            resources.GetString("physicsbox.Items1"),
            resources.GetString("physicsbox.Items2"),
            resources.GetString("physicsbox.Items3")});
            resources.ApplyResources(this.physicsbox, "physicsbox");
            this.physicsbox.Name = "physicsbox";
            this.physicsbox.SelectedIndexChanged += new System.EventHandler(this.phyicsbox_SelectedIndexChanged);
            // 
            // mrr
            // 
            resources.ApplyResources(this.mrr, "mrr");
            this.mrr.Name = "mrr";
            this.mrr.UseVisualStyleBackColor = true;
            this.mrr.Click += new System.EventHandler(this.mrr_Click);
            // 
            // mstats
            // 
            resources.ApplyResources(this.mstats, "mstats");
            this.mstats.Name = "mstats";
            this.mstats.UseVisualStyleBackColor = true;
            this.mstats.Click += new System.EventHandler(this.mstats_Click);
            // 
            // god
            // 
            resources.ApplyResources(this.god, "god");
            this.god.Name = "god";
            this.god.UseVisualStyleBackColor = true;
            this.god.Click += new System.EventHandler(this.god_Click);
            // 
            // lbrte
            // 
            resources.ApplyResources(this.lbrte, "lbrte");
            this.lbrte.Name = "lbrte";
            this.lbrte.UseVisualStyleBackColor = true;
            this.lbrte.Click += new System.EventHandler(this.lbrte_Click);
            // 
            // ufo
            // 
            resources.ApplyResources(this.ufo, "ufo");
            this.ufo.Name = "ufo";
            this.ufo.UseVisualStyleBackColor = true;
            this.ufo.Click += new System.EventHandler(this.ufo_Click);
            // 
            // rfire
            // 
            resources.ApplyResources(this.rfire, "rfire");
            this.rfire.Name = "rfire";
            this.rfire.UseVisualStyleBackColor = true;
            this.rfire.Click += new System.EventHandler(this.rfire_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statbox2);
            this.Controls.Add(this.connectbox);
            this.Controls.Add(this.tmapi);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.multvalue);
            this.Controls.Add(this.physvalue);
            this.Controls.Add(this.multivalue);
            this.Controls.Add(this.multibox);
            this.Controls.Add(this.physicsbar);
            this.Controls.Add(this.physicsbox);
            this.Controls.Add(this.mrr);
            this.Controls.Add(this.mstats);
            this.Controls.Add(this.god);
            this.Controls.Add(this.lbrte);
            this.Controls.Add(this.ufo);
            this.Controls.Add(this.rfire);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.statbox2.ResumeLayout(false);
            this.statbox2.PerformLayout();
            this.connectbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.multivalue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.physicsbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect;
        private System.Windows.Forms.GroupBox statbox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox connectbox;
        private System.Windows.Forms.RadioButton tmapi;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label multvalue;
        private System.Windows.Forms.Label physvalue;
        private System.Windows.Forms.TrackBar multivalue;
        private System.Windows.Forms.ComboBox multibox;
        private System.Windows.Forms.TrackBar physicsbar;
        private System.Windows.Forms.ComboBox physicsbox;
        private System.Windows.Forms.Button mrr;
        private System.Windows.Forms.Button mstats;
        private System.Windows.Forms.Button god;
        private System.Windows.Forms.Button lbrte;
        private System.Windows.Forms.Button ufo;
        private System.Windows.Forms.Button rfire;

    }
}

