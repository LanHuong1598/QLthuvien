using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace QLthuvien.GUI
{
    public partial class FormMuonSach : Form
    {
        int id;
        SqlConnection conn;
        ConnectString cnn = new ConnectString();
        SqlDataAdapter adap;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private ComboBox cb_Cuonsach;
        private Guna.UI.WinForms.GunaTextBox txt_MaDG;
        private Label label3;
        private Label label2;
        private Label label1;
        string query = "";
        public FormMuonSach()
        {
            InitializeComponent();
        }
        public void setMaDG(int _id)
        {
            _id = id;
        }

        void load()
        {
            conn = new SqlConnection(cnn.getConnectionString(1));
            query = "select *from TuaSach";
            adap = new SqlDataAdapter(query, conn);
            DataTable data_TuaSach = new DataTable();
            adap.Fill(data_TuaSach);
            cb_Cuonsach.ValueMember = "MaTS";
            cb_Cuonsach.DisplayMember = "TenTS";
            cb_Cuonsach.DataSource = data_TuaSach;
            txt_MaDG.Text = id.ToString();
        }
        private void FormMuonSach_Load(object sender, EventArgs e)
        {
            load();
        }

        private void InitializeComponent()
        {
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_MaDG = new Guna.UI.WinForms.GunaTextBox();
            this.cb_Cuonsach = new System.Windows.Forms.ComboBox();
            this.gunaPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.Controls.Add(this.cb_Cuonsach);
            this.gunaPanel1.Controls.Add(this.txt_MaDG);
            this.gunaPanel1.Controls.Add(this.label3);
            this.gunaPanel1.Controls.Add(this.label2);
            this.gunaPanel1.Controls.Add(this.label1);
            this.gunaPanel1.Location = new System.Drawing.Point(13, 13);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(611, 370);
            this.gunaPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "label3";
            // 
            // txt_MaDG
            // 
            this.txt_MaDG.BaseColor = System.Drawing.Color.White;
            this.txt_MaDG.BorderColor = System.Drawing.Color.Silver;
            this.txt_MaDG.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_MaDG.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_MaDG.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_MaDG.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_MaDG.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_MaDG.Location = new System.Drawing.Point(159, 33);
            this.txt_MaDG.Name = "txt_MaDG";
            this.txt_MaDG.PasswordChar = '\0';
            this.txt_MaDG.Size = new System.Drawing.Size(160, 32);
            this.txt_MaDG.TabIndex = 3;
            this.txt_MaDG.Text = "gunaTextBox1";
            // 
            // cb_Cuonsach
            // 
            this.cb_Cuonsach.FormattingEnabled = true;
            this.cb_Cuonsach.Location = new System.Drawing.Point(159, 72);
            this.cb_Cuonsach.Name = "cb_Cuonsach";
            this.cb_Cuonsach.Size = new System.Drawing.Size(160, 24);
            this.cb_Cuonsach.TabIndex = 4;
            // 
            // FormMuonSach
            // 
            this.ClientSize = new System.Drawing.Size(636, 395);
            this.Controls.Add(this.gunaPanel1);
            this.Name = "FormMuonSach";
            this.Text = "Mượn sách";
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
    }
}
