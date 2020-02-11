using System;
using System.Drawing;
using System.Windows.Forms;
using MultiLib;

namespace Fallout3
{
    public partial class Form1 : Form
    {
        public MultiConsoleAPI PS3 = new MultiConsoleAPI();
        public Form1()
        {
            InitializeComponent();
        }
        bool WriteCheat_BOOL(uint address)
        {
            bool current = PS3.Extension.ReadBool(address);
            PS3.Extension.WriteBool(address, !current);
            return current;
        }
        private void Connect_Click(object sender, EventArgs e)
        {
            PS3.ChangeAPI(tmapi.Checked ? SelectAPI.TargetManager : SelectAPI.ControlConsole);
            try
            {
                bool state = PS3.ConnectTarget();
                label4.Text = state ? "Connected" : "Not Connected";
                label4.ForeColor = state ? Color.DodgerBlue : Color.Red;
                if (state)
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, "Fallout 3 Tool - Cain532 + GamePwnzer");
                state = PS3.AttachProcess();
                    label2.Text = state ? "Attached" : "Not Attached";
                    label2.ForeColor = state ? Color.DodgerBlue : Color.Red;
                    Connect.ForeColor = state ? Color.DodgerBlue : Color.Red;
                if (state)
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.GRAB, "Fallout 3 - Attached");
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong! Notify your Vault Technician", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void phyicsbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (physicsbox.Text == "Jump Height")
                physicsbar.Maximum = 1000;
            physicsbar.Value = (Int32)PS3.Extension.ReadFloat(Addresses.Physics[physicsbox.SelectedIndex]);
            physvalue.Text = "Current Value: " + physicsbar.Value;
        }
        private void physicsbar_Scroll(object sender, EventArgs e)
        {
            if (physicsbox.Text =="Jump Height")
                physicsbar.Maximum = 1000;
            PS3.Extension.WriteFloat(Addresses.Physics[physicsbox.SelectedIndex], physicsbar.Value);
            physvalue.Text = "Current Value: " + physicsbar.Value;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = PS3.Extension.ReadByte(Addresses.multiplier[multibox.SelectedIndex]);
            if (multibox.Text == "HP Per Level")
            {
                if (check == 61)
                {
                    multivalue.Value = 1;
                    multvalue.Text = "Current Value: " + multivalue.Value;
                }
                else
                {
                    multivalue.Value = (Int32)PS3.Extension.ReadFloat(Addresses.multiplier[multibox.SelectedIndex]);
                    multvalue.Text = "Current Value: " + multivalue.Value;
                }
            }
                else if (multibox.Text == "AR Dmg/Fire Rate")
                {
                    if (check == 63)
                    {
                        multivalue.Value = 1;
                        multvalue.Text = "Current Value: " + multivalue.Value;
                    }
                    else
                    {
                        multivalue.Value = (Int32)PS3.Extension.ReadFloat(Addresses.multiplier[multibox.SelectedIndex]);
                        multvalue.Text = "Current Value: " + multivalue.Value;
                    }
                }
            else if (multibox.Text == "Melee Damage")
            {
                multivalue.Value = 2;
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            else if (multibox.Text == "Unarmed Damage")
            {
                if (check == 61)
                {
                    multivalue.Value = 1;
                    multvalue.Text = "Current Value: " + multivalue.Value;
                }
                else
                {
                    multivalue.Value = (Int32)PS3.Extension.ReadFloat(Addresses.multiplier[multibox.SelectedIndex]);
                    multvalue.Text = "Current Value: " + multivalue.Value;
                }
            }
            else
            {
                multivalue.Value = PS3.Extension.ReadInt32(Addresses.multiplier[multibox.SelectedIndex]);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            }
        private void multivalue_Scroll(object sender, EventArgs e)
        {
            if (multibox.Text == "AR Dmg/Fire Rate")
            {
                PS3.Extension.WriteFloat(Addresses.multiplier[multibox.SelectedIndex], (Byte)multivalue.Value);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            else if (multibox.Text == "Melee Damage")
            {
                PS3.Extension.WriteFloat(Addresses.multiplier[multibox.SelectedIndex], multivalue.Value);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            else if (multibox.Text == "Unarmed Damage")
            {
                PS3.Extension.WriteFloat(Addresses.multiplier[multibox.SelectedIndex], multivalue.Value);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            else
            {
                PS3.Extension.WriteInt32(Addresses.multiplier[multibox.SelectedIndex], multivalue.Value);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            bool current = PS3.Extension.ReadByte(0x004140d9) == 0x83; //orig
            PS3.Extension.WriteByte(0x004140d9, current ? (byte)0x63 : (byte)0x83);

        }
        private void mrr_Click(object sender, EventArgs e)
        {
            uint[] ToSet = { 0x012B74E4, 0x012BAEF4, 0x012B7894, };
            bool current = PS3.Extension.ReadFloat(ToSet[0]) == 5.0f;
            foreach (uint item in ToSet)
                PS3.Extension.WriteFloat(item, current ? 20000 : 5);
        }
        private void mstats_Click(object sender, EventArgs e)
        {
            bool current = PS3.Extension.ReadByte(0x12B7624) == 0x34; //orig
            PS3.Extension.WriteByte(0x12B7624, current ? (byte)0x64 : (byte)0x34);
        }
        private void rfire_Click(object sender, EventArgs e)
        {
            uint[] ToSet = { 0x12B9B34, 0x12B9B44, 0x12B9B54, 0x12B9B64, 0x12B9B74, 0x12B9B84, 0x12B9B94, 0x12B9BA4, 0x12B9BB4, 0x12B9BC4, };
            bool current = PS3.Extension.ReadFloat(ToSet[0]) == 1.0f; //off
            foreach (uint item in ToSet)
                PS3.Extension.WriteFloat(item, current ? 20 : 1);
        }
        private void Cheat_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (button.Name == "god")       button.ForeColor = !WriteCheat_BOOL(0x112076C) ? Color.DodgerBlue : Color.Black;
            if (button.Name == "ufo")       button.ForeColor = !WriteCheat_BOOL(0x12B7410) ? Color.DodgerBlue : Color.Black;
            if (button.Name == "lbrte")     button.ForeColor = !WriteCheat_BOOL(0x12C88F0) ? Color.DodgerBlue : Color.Black;
        }

    }
    }
