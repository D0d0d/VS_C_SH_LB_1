using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Text.RegularExpressions;

using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace VS_C_SH_LB_N_1
{
    public partial class Form1 : Form
    {

        private void Discover(List<BluetoothDeviceInfo> d)
        {
            lbx.Items.Clear();
            lbx_prop.Items.Clear();
            BluetoothClient bc = new BluetoothClient();
            BluetoothDeviceInfo[] DevList = bc.DiscoverDevices(4);

            string maclist="";
            StreamReader sr = new StreamReader("mac_list.txt");
            maclist += sr.ReadToEnd();
            sr.Close();

            MatchCollection manufacture = Regex.Matches(maclist, @"([0-9A-F])([0-9A-F])([0-9A-F])([0-9A-F])([0-9A-F])([0-9A-F]).*[^\d]\n", RegexOptions.IgnoreCase);
            string[] mac = new string[manufacture.Count];
            for (int i =0; i<manufacture.Count; i++)
            {
                MatchCollection temp = Regex.Matches(manufacture[i].ToString(), @"([0-9A-F])([0-9A-F])([0-9A-F])([0-9A-F])([0-9A-F])([0-9A-F]).*[^\d]\n", RegexOptions.IgnoreCase);
                mac[i] = temp[0].ToString();
            }

            foreach (BluetoothDeviceInfo device in DevList)
            {
                lbx.Items.Add(device.DeviceName);
                lbx.Items.Add("");
                lbx.Items.Add("");
                lbx.Items.Add("");
                lbx.Items.Add("");
                lbx.Items.Add("");
                lbx.Items.Add("");

                lbx_prop.Items.Add("Адрес: " + device.DeviceAddress);
                int k=0;
                for (int i=0; i<manufacture.Count; i++)
                {
                if (mac[i][0] ==  device.DeviceAddress.ToString()[0] &&
                    mac[i][1] ==  device.DeviceAddress.ToString()[1] &&
                    mac[i][2] ==  device.DeviceAddress.ToString()[2] &&
                    mac[i][3] ==  device.DeviceAddress.ToString()[3] &&
                    mac[i][4] ==  device.DeviceAddress.ToString()[4] &&
                    mac[i][5] ==  device.DeviceAddress.ToString()[5]
                    )
                    {
                        k = i;
                        break;
                    }
                }
                lbx_prop.Items.Add("Производитель:" + manufacture[k]);
                lbx_prop.Items.Add("Тип:          " + manufacture[k]);
                lbx_prop.Items.Add("Сопряжен:     " + manufacture[k]);
                lbx_prop.Items.Add("Подключен:    " + manufacture[k]);
                lbx_prop.Items.Add("Сервисы:      " + manufacture[k]);
                lbx_prop.Items.Add("");
            }

            btn_discover.Text = "Искать устройства";
            btn_discover.Enabled = true;
            this.Cursor = Cursors.Default;


        }

        List<BluetoothDeviceInfo> DevList = new List<BluetoothDeviceInfo>();
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DevList.Clear();
            this.Cursor = Cursors.WaitCursor;
            btn_discover.Text = "Сканировкание";
            btn_discover.Enabled = false;
            Discover(null);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BluetoothRadio.PrimaryRadio.Mode = RadioMode.Discoverable;
            BluetoothRadio myRadio = BluetoothRadio.PrimaryRadio;
            var mode = myRadio.Mode;
            String str = "";
            str += "Локальная информация \n";
            str += "Имя:               " + myRadio.Name + "\n";
            str += "Локальный адрес:   " + myRadio.LocalAddress + "\n";
            str += "Тип устройства:    " + myRadio.ClassOfDevice.Device + "\n";
            str += "Производитель:     " + myRadio.Manufacturer + "\n";
            str += "Статус:            " + myRadio.HardwareStatus + "\n";
            str += "Состояние:         " + myRadio.Mode.ToString() + "\n";
            str += "Версия Link Management Protocol:    " + myRadio.LmpVersion + "\n";
            str += "Версия Host Controller Interface:   " + myRadio.HciRevision + "\n";
            str += "Host Controller Interface Revision  " + myRadio.HciRevision + "\n";
            str += "Поставщик Soft'a:  " + myRadio.SoftwareManufacturer + "\n";
            str += "Профили:           " + myRadio.ClassOfDevice.Service + "\n";
            System.Windows.Forms.MessageBox.Show(str);
        }
    }
}
