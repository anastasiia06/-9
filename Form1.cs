namespace WinFormsApp9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            int n, m;
            try
            {
                n = Convert.ToInt32(textBox1.Text);
                m = Convert.ToInt32(textBox2.Text);

                DataGridViewTextBoxColumn dgvAge;
                for (int i = 0; i < m; i++)
                {
                    dgvAge = new DataGridViewTextBoxColumn();
                    dgvAge.Width = 40;
                    dataGridView1.Columns.Add(dgvAge);
                }

                dataGridView1.Rows.Clear();
                dataGridView1.ColumnCount = m + 1;
                dataGridView1.RowCount = n;

                TwoArray a = new TwoArray(n, m + 1);
                for (int i = 0; i < n; i++)
                {
                    a[i, 0] = i + 1;
                    dataGridView1.Rows[i].Cells[0].Value = a[i, 0].ToString();
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = 1; j <= m; j++)
                    {
                        a[i, j] = ran.Next(0, 100);
                        dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                    }
                }

                if (a.error)
                {
                    MessageBox.Show("Помилка");
                }

                int zeh = a.Min[0] + 1;
                label3.Text = "Цех з мінімальною кількістю ресурсів: " + zeh.ToString();

                int[] massiv = a.Min;
                dataGridView1.Rows[a.Min[0]].DefaultCellStyle.BackColor = Color.Yellow;
            }
            catch
            {
                MessageBox.Show("Помилка");
            }
        }
    }
    
}
