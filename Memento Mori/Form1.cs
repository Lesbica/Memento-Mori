using Memento_Mori.Memento;

namespace Memento_Mori
{
    public partial class Form1 : Form
    {

        private Originator _originator = new Originator(string.Empty);
        private Caretaker _caretaker = new Caretaker();

        public Form1()
        {
            InitializeComponent();
            InitializeFontComboBox();
            InitializeColorComboBox();
        }

        private void InitializeFontComboBox()
        {
            var fonts = new string[] { "Arial", "Times New Roman", "Courier New", "Verdana" };
            cbFonts.Items.AddRange(fonts);
            cbFonts.SelectedIndex = 0;
        }

        private void InitializeColorComboBox()
        {
            var colors = Enum.GetValues(typeof(KnownColor));
            foreach (var color in colors)
            {
                cbColors.Items.Add(color);
            }
            cbColors.SelectedIndex = 0;
        }

        private void btnChangeText_Click(object sender, EventArgs e)
        {
            _originator.State = txtEditor.Text;
            UpdateTextEditor();
            MessageBox.Show("Текст змінено!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnChangeText_Click(sender, e);
            _caretaker.Backup(_originator.Save());
            MessageBox.Show("Стан редактора збережено!");
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            var memento = _caretaker.Undo();
            if (memento != null)
            {
                _originator.Restore(memento);
                UpdateTextEditor2();
                MessageBox.Show("Попередній стан редактора відновлено!");
            }
            else
            {
                MessageBox.Show("Історія порожня, немає станів для відновлення!");
            }
        }

        private void btnShowHistory_Click(object sender, EventArgs e)
        {
            var history = _caretaker.ShowHistory();
            MessageBox.Show(history, "Історія змін редактора");
        }

        private void UpdateTextEditor2()
        {
            var selectionStart = txtEditor.SelectionStart;
            var selectionLength = txtEditor.SelectionLength;

            txtEditor.Clear(); // Очищаємо текстове поле перед оновленням тексту

            txtEditor.Text = _originator.State;
            txtEditor.Font = _originator.Font;
            txtEditor.ForeColor = _originator.ForeColor;

            txtEditor.Select(selectionStart, selectionLength);
        }


        private void UpdateTextEditor()
        {
            var selectionStart = txtEditor.SelectionStart;
            var selectionLength = txtEditor.SelectionLength;

            var currentText = txtEditor.Text;

            txtEditor.Text = _originator.State;
            txtEditor.Font = _originator.Font;
            txtEditor.ForeColor = _originator.ForeColor;

            txtEditor.Select(selectionStart, selectionLength);

            if (currentText.Length > _originator.State.Length)
            {
                txtEditor.Text += currentText.Substring(_originator.State.Length);
            }
        }

        private void ChangeFont(object sender, EventArgs e)
        {
            var font = new Font(cbFonts.SelectedItem.ToString(), 12);
            _originator.Font = font;
            UpdateTextEditor();
        }

        private void ChangeColor(object sender, EventArgs e)
        {
            var color = Color.FromName(cbColors.SelectedItem.ToString());
            _originator.ForeColor = color;
            UpdateTextEditor();
        }
    }
}
