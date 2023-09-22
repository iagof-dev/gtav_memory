using Memory;
using System.Diagnostics;

namespace aaaaaaaaaaaaaaaa
{
    public partial class Form1 : Form
    {
        public Mem MemLib = new Mem();
        string player_health = "GTA5.exe+0x01D59B88,280";
        string player_location_x = "GTA5.exe+0x01FEB698,320";
        string player_location_y = "";
        string player_location_z = "";
        public Form1()
        {
            InitializeComponent();
        }
        void verifyProcess()
        {
            int PID = MemLib.GetProcIdFromName("GTA5");
            if (PID > 0)
            {
                MemLib.OpenProcess(PID);
                lbl_gamestatus.Text = $"GTA V found! ({PID})";
                lbl_gamestatus.ForeColor = Color.Green;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            verifyProcess();
            Console.WriteLine("Vida: " + MemLib.ReadFloat(player_health));

        }

        private void btn_Suicide_Click(object sender, EventArgs e)
        {
            MemLib.WriteMemory(player_health, "float", "0");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
                t_godmode.Start();
            else
                t_godmode.Stop();
        }

        private void t_godmode_Tick(object sender, EventArgs e)
        {
            MemLib.WriteMemory(player_health, "float", "200");
        }


        private void t_playerstatus_Tick(object sender, EventArgs e)
        {
            float player_health_value = MemLib.ReadFloat(player_health);
            if (player_health_value == 200)
                lbl_player_health.ForeColor = Color.Green;
            if (player_health_value >= 125 && player_health_value < 170)
                lbl_player_health.ForeColor = Color.Orange;
            if (player_health_value < 124)
                lbl_player_health.ForeColor = Color.Red;

            lbl_player_health.Text = "Health: " + Math.Round(player_health_value);


            //LOC PLAYER
            float player_location_x_value = MemLib.ReadFloat(player_location_x);
            //float player_location_z_value = MemLib.ReadFloat(player_location_z);
            lbl_player_loc.Text = $"Location: {Math.Round(player_location_x_value)} 0 0";

        }

        private void btn_debug_Click(object sender, EventArgs e)
        {
            if (txt_debug_address.Text == null && txt_debug_address.Text == string.Empty)
                return;

            MemLib.WriteMemory(txt_debug_address.Text, "float", txt_debug_value.Text);
        }
    }
}