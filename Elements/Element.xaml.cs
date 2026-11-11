using System.Windows.Controls;

namespace Book_Egorov.Elements
{
    public partial class Element : UserControl
    {
        public Element(Classes.Book Book)
        {
            InitializeComponent();
            tbName.Text = $"Наименование: {Book.Name} ({Book.Year} г.)";
            tbGenre.Text = $"Жанр: {Book.ToGenres()}";
            tbAuthor.Text = $"Автор: {Book.ToAuthors()}";
        }
    }
}
