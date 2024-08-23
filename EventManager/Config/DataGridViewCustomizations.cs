using System.Drawing;
using System.Windows.Forms;

namespace EventManager.Config
{
    public static class DataGridViewCustomizations
    {
        public static void ApplyCustomizations(DataGridView dataGridView)
        {
            // Linhas alternadas
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(234, 234, 234);
            dataGridView.AlternatingRowsDefaultCellStyle.ForeColor = Color.Black;

            // Linha selecionada
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(230, 125, 33);
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.White;

            // Cor da fonte padrão
            dataGridView.DefaultCellStyle.ForeColor = Color.FromArgb(75, 75, 75);

            // Bordas
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;

            // Cabeçalho
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Century Gothic", 8, FontStyle.Bold);

            dataGridView.EnableHeadersVisualStyles = false; // Habilita a edição do cabeçalho

            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(211, 84, 21);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }
    }
}
