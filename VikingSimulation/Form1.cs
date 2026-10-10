using VikingKozos;

namespace VikingSimulation
{
    public partial class Form1 : Form
    {
        private List<int> tippek = new List<int>();
        private VikingContext context = new VikingContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSorsol.Enabled = false;
            lblInfo.Text = "";

            for (int i = 0; i < 6; i++)
                for (int j = 0; j < 8; j++)
                {
                    CheckBox box = new CheckBox();
                    box.AutoSize = true;
                    box.Location = new Point(20 + j * 70, 20 + i * 50);
                    box.Text = (i * 8 + j + 1).ToString();
                    box.CheckedChanged += checkBox1_CheckedChanged;
                    panel.Controls.Add(box);


                }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Checked)
            {
                tippek.Add(Convert.ToInt32(box.Text));
                if (tippek.Count() == 6)
                {
                    btnSorsol.Enabled = true;
                    foreach (var item in panel.Controls)
                    {
                        CheckBox cBox = (CheckBox)item;
                        if (!cBox.Checked) cBox.Enabled = false;
                    }
                }
            }
            else
            {
                tippek.Remove(Convert.ToInt32(box.Text));
                if (tippek.Count() == 5)
                {
                    btnSorsol.Enabled = false;
                    foreach (var item in panel.Controls)
                    {
                        CheckBox cBox = (CheckBox)item;
                        cBox.Enabled = true;
                    }
                }
            }
        }
        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            context.Dispose();
            base.OnFormClosed(e);
        }

        private void btnSorsol_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sorsolás");
            Random rnd = new Random();
            HashSet<int> huzas = new HashSet<int>();
            do {
                huzas.Add(rnd.Next(1, 49));
                //lblInfo.Text = string.Join(", ", huzas.OrderBy(x => x));
            } while (huzas.Count != 6);

            context.Huzasok.Add(new Huzas(string.Join(";", huzas.OrderBy(x => x))));
            context.SaveChanges();

            lblInfo.Text = string.Join(", ", huzas.OrderBy(x => x))+"\n";
            lblInfo.Text += string.Join(", ", tippek.OrderBy(x => x))+"\n";
            lblInfo.Text += string.Join(", ", tippek.Intersect(huzas).OrderBy(x => x));
        }
    }
}
