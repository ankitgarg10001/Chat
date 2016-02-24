using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace MyUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        TcpChannel tc = new TcpChannel();

        MyBl.MyBlCLass obj;
        private void Form1_Load(object sender, EventArgs e)
        {
            object o = Activator.GetObject(typeof(MyBl.MyBlCLass), "tcp://localhost:8010/RemoteClass");
           obj = (MyBl.MyBlCLass)o;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            obj.send(textBox1.Text);
            textBox1.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            textBox2.Text = obj.GetMsg();
        }
       
    }
}
