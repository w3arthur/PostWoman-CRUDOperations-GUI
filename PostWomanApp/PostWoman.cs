using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PostWomanLibrary.Classes;
using PostWomanLibrary.Enums;
using PostWomanLibrary.Models;

namespace PostWomanApp
{
    public partial class PostWoman : Form
    {
        public PostWoman()
        {
            InitializeComponent();

            txtMessage.Text = Data.EmptyMesage;
            txtResult.Text = Data.EmptyMesage;
            upState();
            txtAddress.Focus();

            txtAddress.Text = Configuration.ExampleUrl.Get; //Delete
        }

        private void lblCredit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => LinkClicked(Configuration.Creator.Url);
        private void lnlWebApp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  => LinkClicked(Configuration.Creator.WebApp); 
        private void btnSend_Click(object sender, EventArgs e) => setResultsAsync();
        private void txtAddress_KeyDown(object sender, KeyEventArgs e) => PressedEnter(e);
        private void chkGet_KeyDown(object sender, KeyEventArgs e) => PressedEnter(e);
        private void chkPost_KeyDown(object sender, KeyEventArgs e) => PressedEnter(e);
        private void chkPut_KeyDown(object sender, KeyEventArgs e) => PressedEnter(e);
        private void chkDelete_KeyDown(object sender, KeyEventArgs e) => PressedEnter(e);
        private void btnGetAnd_Click(object sender, EventArgs e) => AddAddressArg();
        private void clrMessage_Click(object sender, EventArgs e) => txtMessage.Text = Data.EmptyMesage;
        private void clrResult_Click(object sender, EventArgs e) => txtResult.Text = Data.EmptyMesage;


        private Data upState()
        {
            return new Data()
            {
                HTTPClient = Configuration.HTTPClient,
                Type = chkGet.Checked ? Method.Get
                    : chkPost.Checked ? Method.Post
                    : chkPut.Checked ? Method.Put
                    : chkDelete.Checked ? Method.Delete
                    : Method.Error,
                Action = txtAddress.Text,
                Message = txtMessage.Text,
            };
        }

        private async Task setResultsAsync()
        {
            txtResult.Text = Data.EmptyMesage;
            Data data = upState();
            string result = await data.SentAsync();
            if (result == null) return;
            txtResult.Text = result;
        }

        private void PressedEnter(KeyEventArgs e) { if (e.KeyCode == Keys.Enter) btnSend.PerformClick(); }
        private void LinkClicked(string url) { try { HTTPClient.OpenUrl(url); } catch (Exception ex) { MessageBox.Show(ex.Message); } }
        private void AddAddressArg() { txtAddress.Text += (txtAddress.Text).Contains("?") ? "&" : "?"; }

    }
}
