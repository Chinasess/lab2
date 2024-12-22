using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_App
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void tabPage_Жанры_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet2.просмотрр". При необходимости она может быть перемещена или удалена.
            this.просмотррTableAdapter.Fill(this._5DataSet2.просмотрр);

            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Вид_деятельности". При необходимости она может быть перемещена или удалена.
            this.вид_деятельностиTableAdapter.Fill(this._5DataSet.Вид_деятельности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Страны". При необходимости она может быть перемещена или удалена.
            this.страныTableAdapter.Fill(this._5DataSet.Страны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this._5DataSet.Жанры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Фильмография". При необходимости она может быть перемещена или удалена.
            this.фильмографияTableAdapter.Fill(this._5DataSet.Фильмография);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Страны". При необходимости она может быть перемещена или удалена.
            this.страныTableAdapter.Fill(this._5DataSet.Страны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this._5DataSet.Жанры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Возрастной_рейтинг". При необходимости она может быть перемещена или удалена.
            this.возрастной_рейтингTableAdapter.Fill(this._5DataSet.Возрастной_рейтинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this._5DataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Вид_деятельности". При необходимости она может быть перемещена или удалена.
            this.вид_деятельностиTableAdapter.Fill(this._5DataSet.Вид_деятельности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Жанры". При необходимости она может быть перемещена или удалена.
            this.жанрыTableAdapter.Fill(this._5DataSet.Жанры);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Страны". При необходимости она может быть перемещена или удалена.
            this.страныTableAdapter.Fill(this._5DataSet.Страны);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Возрастной_рейтинг". При необходимости она может быть перемещена или удалена.
            this.возрастной_рейтингTableAdapter.Fill(this._5DataSet.Возрастной_рейтинг);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Фильмы". При необходимости она может быть перемещена или удалена.
            this.фильмыTableAdapter.Fill(this._5DataSet.Фильмы);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Фильмография". При необходимости она может быть перемещена или удалена.
            this.фильмографияTableAdapter.Fill(this._5DataSet.Фильмография);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Вид_деятельности". При необходимости она может быть перемещена или удалена.
            this.вид_деятельностиTableAdapter.Fill(this._5DataSet.Вид_деятельности);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_5DataSet.Участник". При необходимости она может быть перемещена или удалена.
            this.участникTableAdapter.Fill(this._5DataSet.Участник);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button_Участник_Click(object sender, EventArgs e)
        {
            this.участникTableAdapter.Update(this._5DataSet.Участник);
        }

        private void button_виддеятельности_Click(object sender, EventArgs e)
        {
            this.вид_деятельностиTableAdapter.Update(this._5DataSet.Вид_деятельности);
        }

        private void button_Фильмы_Click(object sender, EventArgs e)
        {
            this.фильмыTableAdapter.Update(this._5DataSet.Фильмы);
        }

        private void button_рейтинг_Click(object sender, EventArgs e)
        {
            this.возрастной_рейтингTableAdapter.Update(this._5DataSet.Возрастной_рейтинг);
        }

        private void button_Страны_Click(object sender, EventArgs e)
        {
            this.страныTableAdapter.Update(this._5DataSet.Страны);
        }

        private void button_Жанры_Click(object sender, EventArgs e)
        {
            this.жанрыTableAdapter.Update(this._5DataSet.Жанры);
        }

        private void tabPage_Фильмография_Click(object sender, EventArgs e)
        {

        }

        private void button_Фильмография_Click(object sender, EventArgs e)
        {
            this.фильмографияTableAdapter.Update(this._5DataSet.Фильмография);
        }

        private void button_Страна_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
