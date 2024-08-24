using ReaLTaiizor.Controls;
using System.Drawing;
using System.Windows.Forms;

namespace EventManager.Config
{
    public static class MaterialListViewCustomizations
    {
        public static void ApplyCustomizations(MaterialListView listView)
        {
            listView.FullRowSelect = true;
            listView.GridLines = false;
            listView.View = View.Details;

            // Configurações Gerais
            listView.ForeColor = Color.White; // Texto branco
            listView.Font = new Font("Segoe UI", 10);

            // Linhas Alternadas
            listView.OwnerDraw = true;
            listView.DrawItem += (sender, e) =>
            {
                bool isSelected = e.Item.Selected;
                Color backgroundColor = isSelected ? Color.FromArgb(50, 50, 50) : (e.ItemIndex % 2 == 0 ? Color.FromArgb(30, 30, 30) : Color.FromArgb(40, 40, 40));

                // Desenho do fundo das linhas
                e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);

                // Desenho do texto
                TextRenderer.DrawText(e.Graphics, e.Item.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);

                // Adiciona uma borda inferior branca
                e.Graphics.DrawLine(new Pen(Color.White, 1), e.Bounds.Left, e.Bounds.Bottom - 1, e.Bounds.Right, e.Bounds.Bottom - 1);
            };

            listView.DrawSubItem += (sender, e) =>
            {
                var subItem = e.SubItem;
                if (e.Item.Selected)
                {
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(50, 50, 50)), e.Bounds);
                    TextRenderer.DrawText(e.Graphics, subItem.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.White, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                    e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(92, 173, 255)), e.Bounds);
                    TextRenderer.DrawText(e.Graphics, subItem.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                }
                else
                {
                    Color backgroundColor = e.ItemIndex % 2 == 0 ? Color.FromArgb(245, 245, 245) : Color.FromArgb(230, 230, 230);
                    e.Graphics.FillRectangle(new SolidBrush(backgroundColor), e.Bounds);
                    TextRenderer.DrawText(e.Graphics, subItem.Text, listView.Font, new Rectangle(e.Bounds.X + 5, e.Bounds.Y, e.Bounds.Width - 10, e.Bounds.Height), Color.Black, TextFormatFlags.VerticalCenter | TextFormatFlags.Left);
                }
            };
        }
    }
}