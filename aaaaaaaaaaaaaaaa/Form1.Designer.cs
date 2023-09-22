namespace aaaaaaaaaaaaaaaa
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
            components = new System.ComponentModel.Container();
            btn_Suicide = new Button();
            t_godmode = new System.Windows.Forms.Timer(components);
            checkBox1 = new CheckBox();
            lbl_gamestatus = new Label();
            lbl_player_health = new Label();
            t_playerstatus = new System.Windows.Forms.Timer(components);
            txt_debug_address = new TextBox();
            btn_debug = new Button();
            label1 = new Label();
            txt_debug_value = new TextBox();
            label2 = new Label();
            lbl_player_loc = new Label();
            SuspendLayout();
            // 
            // btn_Suicide
            // 
            btn_Suicide.Location = new Point(12, 98);
            btn_Suicide.Name = "btn_Suicide";
            btn_Suicide.Size = new Size(152, 60);
            btn_Suicide.TabIndex = 0;
            btn_Suicide.Text = "Suicidar";
            btn_Suicide.UseVisualStyleBackColor = true;
            btn_Suicide.Click += btn_Suicide_Click;
            // 
            // t_godmode
            // 
            t_godmode.Interval = 1;
            t_godmode.Tick += t_godmode_Tick;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 73);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(82, 19);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "God Mode";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // lbl_gamestatus
            // 
            lbl_gamestatus.AutoSize = true;
            lbl_gamestatus.ForeColor = Color.Red;
            lbl_gamestatus.Location = new Point(12, 9);
            lbl_gamestatus.Name = "lbl_gamestatus";
            lbl_gamestatus.Size = new Size(97, 15);
            lbl_gamestatus.TabIndex = 2;
            lbl_gamestatus.Text = "GTA V not found!";
            // 
            // lbl_player_health
            // 
            lbl_player_health.AutoSize = true;
            lbl_player_health.ForeColor = Color.Black;
            lbl_player_health.Location = new Point(12, 33);
            lbl_player_health.Name = "lbl_player_health";
            lbl_player_health.Size = new Size(54, 15);
            lbl_player_health.TabIndex = 3;
            lbl_player_health.Text = "Health: 0";
            // 
            // t_playerstatus
            // 
            t_playerstatus.Enabled = true;
            t_playerstatus.Interval = 1;
            t_playerstatus.Tick += t_playerstatus_Tick;
            // 
            // txt_debug_address
            // 
            txt_debug_address.Location = new Point(660, 41);
            txt_debug_address.Name = "txt_debug_address";
            txt_debug_address.Size = new Size(90, 23);
            txt_debug_address.TabIndex = 4;
            // 
            // btn_debug
            // 
            btn_debug.Location = new Point(660, 114);
            btn_debug.Name = "btn_debug";
            btn_debug.Size = new Size(94, 32);
            btn_debug.TabIndex = 5;
            btn_debug.Text = "debug";
            btn_debug.UseVisualStyleBackColor = true;
            btn_debug.Click += btn_debug_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(660, 23);
            label1.Name = "label1";
            label1.Size = new Size(49, 15);
            label1.TabIndex = 6;
            label1.Text = "Address";
            // 
            // txt_debug_value
            // 
            txt_debug_value.Location = new Point(660, 85);
            txt_debug_value.Name = "txt_debug_value";
            txt_debug_value.Size = new Size(90, 23);
            txt_debug_value.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(660, 67);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 8;
            label2.Text = "Value";
            // 
            // lbl_player_loc
            // 
            lbl_player_loc.AutoSize = true;
            lbl_player_loc.ForeColor = Color.Black;
            lbl_player_loc.Location = new Point(12, 48);
            lbl_player_loc.Name = "lbl_player_loc";
            lbl_player_loc.Size = new Size(83, 15);
            lbl_player_loc.TabIndex = 9;
            lbl_player_loc.Text = "Location: 0 0 0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lbl_player_loc);
            Controls.Add(label2);
            Controls.Add(txt_debug_value);
            Controls.Add(label1);
            Controls.Add(btn_debug);
            Controls.Add(txt_debug_address);
            Controls.Add(lbl_player_health);
            Controls.Add(lbl_gamestatus);
            Controls.Add(checkBox1);
            Controls.Add(btn_Suicide);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_Suicide;
        private System.Windows.Forms.Timer t_godmode;
        private CheckBox checkBox1;
        private Label lbl_gamestatus;
        private Label lbl_player_health;
        private System.Windows.Forms.Timer t_playerstatus;
        private TextBox txt_debug_address;
        private Button btn_debug;
        private Label label1;
        private TextBox txt_debug_value;
        private Label label2;
        private Label lbl_player_loc;
    }
}