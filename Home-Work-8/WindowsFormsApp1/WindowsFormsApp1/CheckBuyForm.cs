using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    //Фирма продает составляющие компьютера. Первая форма отвеча-
    // ет за учет продаж, вторая за добавление и редактирование составля-
    //ющих.
    public partial class CheckBuyForm : Form
    {
        public string product;
        AddEditForm addEdit;
        List<string> baket =new List<string>() { "Monitor","Mouse","Proccesor","Keyboard"};
        public CheckBuyForm()
        {
            InitializeComponent();
            foreach (string a in baket)
            {
                comboBox1.Items.Add(a);
            }
            addEdit = new AddEditForm(this);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            product=textBox1.Text;
            addEdit.Addproduct(product);
            addEdit.Show();
            baket.Add(product);
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (baket.=="Mouse") { 
                
                }
        }
    }
}
