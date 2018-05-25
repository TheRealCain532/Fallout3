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
using MetroFramework.Forms;
using Fallout3;

namespace Fallout3
{
    public partial class Form1 : MetroForm
    {
        #region startup
        public Form1()
        {
            InitializeComponent();
        }
        private void tmapi_CheckedChanged(object sender, EventArgs e)
        {
            if (tmapi.Checked)
            {
                PS3.MOD.ChangeAPI(SelectAPI.TargetManager);
            }
            else
            {
                PS3.MOD.ChangeAPI(SelectAPI.ControlConsole);
            }
        }
        #endregion
        #region Connect/Attach
        private void Connect_Click(object sender, EventArgs e)
        {
            try
            {
                if (PS3.MOD.ConnectTarget())
                {
                    PS3.MOD.CCAPI.Notify(CCAPI.NotifyIcon.FRIEND, "Fallout 3 Tool- BootlegBoxes");
                    label4.Text = "Connected";
                    label4.ForeColor = Color.DodgerBlue;
                    Settings.Default.Save();
                    PS3.MOD.AttachProcess();
                    PS3.MOD.CCAPI.Notify(CCAPI.NotifyIcon.GRAB, "Fallout 3 - Attached");
                    label2.Text = "Attached";
                    label2.ForeColor = Color.DodgerBlue;

                }

                else
                {
                    Settings.Default.Save();
                    MessageBox.Show("Can't Connect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Game Not Running");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ensure CCAPI.dll is in root folder!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Settings.Default.Save();
            }
            Firmware.Text = PS3.MOD.CCAPI.GetFirmwareVersion();
        }
        #endregion
        #region Functions
                UInt32[] Addresses = new UInt32[] { 0x12BC2B4, 0x12BC3F4, 0x12BC3B4 };
        byte[] on = { 0x01 };
        byte[] off = { 0x00 };
#endregion
        #region Cheats
        private void noclip_CheckedChanged(object sender, EventArgs e)
        {
            if (noclip.Checked)
            {
                PS3.MOD.CCAPI.Notify(CCAPI.NotifyIcon.ARROWRIGHT, "No Clip - On");
                PS3.MOD.SetMemory(0x12B7410, on);
            }
                else
            {
                PS3.MOD.CCAPI.Notify(CCAPI.NotifyIcon.ARROWRIGHT, "No Clip - OFF");
                PS3.MOD.SetMemory(0x12B7410, off);

                }
            }
        private void god_CheckedChanged(object sender, EventArgs e)
        {
            if (god.Checked)
            {
                PS3.MOD.CCAPI.Notify(CCAPI.NotifyIcon.ARROWRIGHT, "God Mode - On");
                PS3.MOD.SetMemory(0x112076C, on);
            }
            else
            {
                PS3.MOD.CCAPI.Notify(CCAPI.NotifyIcon.ARROWRIGHT, "God Mode - OFF");
                PS3.MOD.SetMemory(0x112076C, off);

            }
        }
        private void litebrite_CheckedChanged(object sender, EventArgs e)
        {
            if (litebrite.Checked)
            {
                PS3.MOD.SetMemory(0x12C88F0, on);
            }
            if (litebrite.Checked == false)
            {
                PS3.MOD.SetMemory(0x12C88F0, off);

            }
        }
        private void phyicsbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            physicsbar.Value = (Int32)PS3.MOD.Extension.ReadFloat(Addresses[physicsbox.SelectedIndex]);
            value.Text = "Current Value: " + physicsbar.Value.ToString();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            value.Text = "Current Value: " + physicsbar.Value.ToString();
            PS3.MOD.Extension.WriteFloat(Addresses[physicsbox.SelectedIndex], physicsbar.Value);
        }
        private void maxstats_CheckedChanged(object sender, EventArgs e)
        {
            if (statstoggle.Checked)
            {
                PS3.MOD.SetMemory(0x12B7624, new byte[] { 0x64 });
            }
            if (statstoggle.Checked == false)
            {
                PS3.MOD.SetMemory(0x12B7624, new byte[] { 0x34 });

            }
        }
        #endregion
    }
    }
