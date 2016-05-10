using HID;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TestForm
{
    public partial class Form1 : Form
    {
        public Hid hid;
        public Form1()
        {
            hid = new Hid();
            hid.vID = 0x0483;
            hid.pID = 0x0409;
            hid.DataReceived += Hid_DataReceived;
            hid.OnSpecifiedDeviceArrived += Hid_OnSpecifiedDeviceArrived;
            hid.OnSpecifiedDeviceRemoved += Hid_OnSpecifiedDeviceRemoved;
            InitializeComponent();
        }
        /// <summary>
        /// HID设备拔出事件触发.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hid_OnSpecifiedDeviceRemoved(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// HID设备插入事件触发.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hid_OnSpecifiedDeviceArrived(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// HID接收数据方法.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Hid_DataReceived(object sender, report e)
        {

        }

        /// <summary>
        /// 注册HID设备事件监听.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            hid.RegisterHandle(Handle);
        }
        /// <summary>
        /// HID设备事件拦截.
        /// </summary>
        /// <param name="m"></param>
        protected override void WndProc(ref Message m)
        {
            hid.ParseMessages(ref m);
            base.WndProc(ref m);
        }

    }
}
