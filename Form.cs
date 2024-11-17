using System.Windows.Forms;

public class Form
{
    private List myList = new List();

    public Form1()
    {
        InitializeComponent();
    }

    private void btnAddFirst(object sender, EventArgs e)
    {
        if (int.TryParse(txtInput.Text, out int value))
        {
            myList.AddFirst(value);
            UpdateListDisplay();
        }
        else
        {
            MessageBox.Show("Proszę podać poprawną liczbę.");
        }
    }

    private void btnAddLast(object sender, EventArgs e)
    {
        if (int.TryParse(txtInput.Text, out int value))
        {
            myList.AddLast(value);
            UpdateListDisplay();
        }
        else
        {
            MessageBox.Show("Proszę podać poprawną liczbę.");
        }
    }

    private void btnRemoveFirst(object sender, EventArgs e)
    {
        NodeL removed = myList.RemoveFirst();
        if (removed != null)
        {
            MessageBox.Show($"Usunięto: {removed.data}");
        }
        else
        {
            MessageBox.Show("Lista jest pusta.");
        }
        UpdateListDisplay();
    }

    private void btnRemoveLast(object sender, EventArgs e)
    {
        NodeL removed = myList.RemoveLast();
        if (removed != null)
        {
            MessageBox.Show($"Usunięto: {removed.data}");
        }
        else
        {
            MessageBox.Show("Lista jest pusta.");
        }
        UpdateListDisplay();
    }

    private void UpdateListDisplay()
    {
        lblListDisplay.Text = myList.ToString();
    }
}