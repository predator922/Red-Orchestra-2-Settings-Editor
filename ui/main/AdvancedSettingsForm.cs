using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ro2_settings_editor
{
    public partial class AdvancedSettingsForm : Form
    { 
        List<string> rollback=new List<string>();
        public AdvancedSettingsForm(List<config> dSource)
        {
            InitializeComponent();
            foreach (config item in dSource)
                rollback.Add(item.Value);
            advTable.DataSource = dSource;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 0;
            foreach (config item in (List<config>)advTable.DataSource) {
                item.Value = rollback[i];
                    i++;
           }
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
