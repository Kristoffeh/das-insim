using InSimDotNet;
using InSimDotNet.Packets;
using System;
using System.IO;
using System.Windows.Forms;

namespace Das_Insim
{
    public partial class Form1 : Form
    {
        // Delegate for UI update (Example)
        delegate void dlgMSO(IS_MSO MSO);
      //  delegate void strMsg(IS_MSO MSO);

        public Form1()
        {
            InitializeComponent();
        }
        // Create new InSim object
        InSim insim = new InSim();

        public void connect_Click(object sender, EventArgs e)
        {
            insim.Bind<IS_MSO>(MessageOut);
            string value = textBox1.Text;

            textBox2.Text += "Insim Connected";
            connect.Text = "Connected!";
            connect.Enabled = false;

            //     insim.Bind<IS_MSO>(Comma);


            //  string[] StrMsg = Msg.Split(' ');

            // Initailize InSim
            insim.Initialize(new InSimSettings
            {
                Host = "127.0.0.1", // Host where LFS is runing
                Port = 30000, // Port to connect to LFS through
                Admin = "2910", // Optional game admin password
            });
        }

               public void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

    public void send_Click(object sender, EventArgs e)
        {
            string text = message.Text;
            {
                IS_MSX mst = new IS_MSX();               
                    mst.Msg = text;
                    insim.Send(mst);                         
            }
            message.Clear();
            //message.Multiline = false;
            //message.Multiline = true;
        }

        private void message_TextChanged(object sender, EventArgs e)
        {
            string val = message.Text;
            int count = val.Length;

            var sum = (95 - count);
            label3.Text = (sum.ToString());
        }

        // Method called whenever an IS_MSO packet is received.
        public void MessageOut(InSim insim, IS_MSO mso)
        {


           // string datetime = DateTime.UtcNow.Hour + ":" + DateTime.UtcNow.Minute + "." + DateTime.UtcNow.Second + " ";
            TimeZone zone = TimeZone.CurrentTimeZone;
            DateTime local = zone.ToLocalTime(DateTime.Now);

            string put = (mso.Msg);
            // Print out the message content.
            textBox2.Items.Insert(0, local + " " + put);

            StreamWriter w = File.AppendText("Log.txt");
            {
                w.WriteLine("[" + local + "] " + put);
                w.Close();
            }



            string Msg = mso.Msg.Substring(mso.TextStart, (mso.Msg.Length - mso.TextStart));
            string[] StrMsg = Msg.Split(' ');

            switch (StrMsg[0])
            {
                case "<help":

                    insim.Send(new IS_MSL { Msg = "test" });

                    break;

                default:
                    if (StrMsg[0].StartsWith("<"))
                    {

                    }
                    break;
            }
        }

        private void message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string text = message.Text;
                {
                    IS_MSX mst = new IS_MSX();

                    mst.Msg = text;
                    insim.Send(mst);
                }
                message.Clear();
                //message.Multiline = false;
                //message.Multiline = true;
            }
            else if (message.Text.Length == 95)
            {
                string text = message.Text;
                IS_MSX mst = new IS_MSX();
                mst.Msg = text;
                insim.Send(mst);
                message.Clear();
            }
        }
    }
}

    
    

    /*  #region ' Chat command ' 
          if (Msg.StartsWith(">"))
          {
              string cmp = StrMsg[0].Remove(0, 1);
              if (Conn.WaitCMD == 0)
              {
                  CL.MethodInf.Invoke(this, new object[] { Msg, StrMsg, MSO });
                  return;
              }
          }
          else
           {
              MsgPly("^´>>'7 Invalid Command. ^3!help ^7for help.", MSO.UCID);
              //Conn.WaitCMD = 4;
           }
          else
           {
              MsgPly("^6>>^7 You have to wait ^2" + Conn WaitCMD + "^7second(s) to start command", MSO.UCID);
           }
      }
      #endregion
      */


        /*  delegate void dlgMSO(IS_MSO MSO);

          public void MSO_MessageOut(IS_MSO MSO)
          {

              // Invoke method due to threading. Add this line to any receive event before updating the GUI. Just like in this example, you only have to add a new delegate with the right packet parameter and adjust this line in the new method.
              if (DoInvoke()) { object p = MSO; this.Invoke(new dlgMSO(MSO_MessageOut), p); return; }

              textBox2.Text += MSO.Msg + "\r\n";

              string Msg = MSO.Msg.Substring(MSO.TextStart, (MSO.Msg.Length - MSO.TextStart));
              string[] StrMsg = Msg.Split(' ');
          }

          private void message_KeyDown(object sender, KeyEventArgs e)
          {
              if (e.KeyCode == Keys.Enter)
              {
                  string text = message.Text;

                  if (msg.Checked)
                  {
                      IS_MST mst = new IS_MST();
                      mst.Msg = "/msg " + text;
                      insim.Send(mst);
                  }
                  else
                  {
                      IS_MST mst = new IS_MST();
                      mst.Msg = text;
                      insim.Send(mst);
                  }
                  message.Text = "";
              }
          }
          private bool DoInvoke()
          {
              foreach (Control c in this.Controls)
              {
                  if (c.InvokeRequired) return true;
                  break;  // 1 control is enough
              }
              return false;
          } */