using OlympiadSystem.Domain;
using OlympiadSystem.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OlympiadSystem
{
    public partial class formTypeOlympiad : Form
    {
        public formTypeOlympiad()
        {
            typeOlympiadManager = new TypeOlimpiadManager();
            InitializeComponent();
        }

        private readonly ITypeOlympiadManager typeOlympiadManager;

        private void button1_Click(object sender, EventArgs e)
        {
            typeOlympiadManager.AddTypeOlympiad(new TypeOlympiad() {Name = textBoxTypeOlympiad.Text});
            typeOlympiadManager.WriteTypeOlympiads();
        }
    }
}
