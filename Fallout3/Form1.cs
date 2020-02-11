using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MultiLib;
using Fallout3.Properties;

namespace Fallout3
{
    public partial class Form1 : Form
    {
        public MultiConsoleAPI PS3 = new MultiConsoleAPI();
        public Form1()
        {
            InitializeComponent();
        }
        private void tmapi_CheckedChanged(object sender, EventArgs e)
        {
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
                if (state)
                    PS3.CCAPI.Notify(CCAPI.NotifyIcon.GRAB, "Fallout 3 - Attached");
            }
            catch (Exception)
            {
                MessageBox.Show("Something Went Wrong! Notify your Vault Technician", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        byte[] on = { 0x01 };
        byte[] off = { 0x00 };
        bool[] Cheats = new bool[20];
        private void phyicsbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (physicsbox.Text == "Jump Height")
                physicsbar.Maximum = 1000;
            physicsbar.Value = (Int32)PS3.Extension.ReadFloat(Addresses.Physics()[physicsbox.SelectedIndex]);
            physvalue.Text = "Current Value: " + physicsbar.Value;
        }
        private void physicsbar_Scroll(object sender, EventArgs e)
        {
            if (physicsbox.Text =="Jump Height")
            {
                physicsbar.Maximum = 1000;
            }
            PS3.Extension.WriteFloat(Addresses.Physics()[physicsbox.SelectedIndex], physicsbar.Value);
            physvalue.Text = "Current Value: " + physicsbar.Value;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check = PS3.Extension.ReadByte(Addresses.multiplier()[multibox.SelectedIndex]);
            if (multibox.Text == "HP Per Level")
            {
                if (check == 61)
                {
                    multivalue.Value = 1;
                    multvalue.Text = "Current Value: " + multivalue.Value;
                }
                else
                {
                    multivalue.Value = (Int32)PS3.Extension.ReadFloat(Addresses.multiplier()[multibox.SelectedIndex]);
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
                        multivalue.Value = (Int32)PS3.Extension.ReadFloat(Addresses.multiplier()[multibox.SelectedIndex]);
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
                    multivalue.Value = (Int32)PS3.Extension.ReadFloat(Addresses.multiplier()[multibox.SelectedIndex]);
                    multvalue.Text = "Current Value: " + multivalue.Value;
                }
            }
            else
            {
                multivalue.Value = PS3.Extension.ReadInt32(Addresses.multiplier()[multibox.SelectedIndex]);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            }
        private void multivalue_Scroll(object sender, EventArgs e)
        {
            if (multibox.Text == "AR Dmg/Fire Rate")
            {
                PS3.Extension.WriteFloat(Addresses.multiplier()[multibox.SelectedIndex], (Byte)multivalue.Value);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            else if (multibox.Text == "Melee Damage")
            {
                PS3.Extension.WriteFloat(Addresses.multiplier()[multibox.SelectedIndex], (Byte)multivalue.Value);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            else if (multibox.Text == "Unarmed Damage")
            {
                PS3.Extension.WriteFloat(Addresses.multiplier()[multibox.SelectedIndex], (Byte)multivalue.Value);
                multvalue.Text = "Current Value: " + multivalue.Value;
            }
            else
            {
                PS3.Extension.WriteInt32(Addresses.multiplier()[multibox.SelectedIndex], multivalue.Value);
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
            byte[] on = { 0x46, 0x9C, 0x40, 0x00 };
            byte[] off = { 0x40, 0xA0, 0x00, 0x00 };
            PS3.SetMemory(0x012B74E4, Cheats[5] ? on : off);
            PS3.SetMemory(0x012BAEF4, Cheats[5] ? on : off);
            PS3.SetMemory(0x012B7894, Cheats[5] ? on : off);
        }
        private void mstats_Click(object sender, EventArgs e)
        {
            byte[] on = { 0x64 };
            byte[] off = { 0x34 };
            bool current = PS3.Extension.ReadByte(0x12B7624) == 0x34; //orig
            PS3.SetMemory(0x12B7624, Cheats[4] ? on : off);
        }
        private void god_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x112076C, Cheats[3] ? on : off);
        }
        private void rfire_Click(object sender, EventArgs e)
        {
            byte[] on = { 0x41, 0xA0, 0x00, 0x00 };
            byte[] off = { 0x3F, 0x80, 0x00, 0x00 };

            PS3.SetMemory(0x12B9B34, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9B44, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9B54, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9B64, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9B74, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9B84, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9B94, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9BA4, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9BB4, Cheats[2] ? on : off);
            PS3.SetMemory(0x12B9BC4, Cheats[2] ? on : off);
        }
        private void lbrte_Click(object sender, EventArgs e)
        {
            PS3.SetMemory(0x12C88F0, Cheats[1] ? on : off);
        }
        bool toggle;
        private void ufo_Click(object sender, EventArgs e)
        {
            bool current = PS3.Extension.ReadBool(0x12B7410);
            PS3.Extension.WriteBool(0x12B7410, !current);
        }

        private void Cain532_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCkcwOVXVTKP1pEoiFgA-bFQ");
        }
    }
    }
