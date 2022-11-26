using System.ComponentModel;

namespace HW4._2
{

    public partial class MainForm : Form
    {

        public BindingList<Item> Items = new BindingList<Item>();
        public BindingList<GroceryItem> Groceries = new BindingList<GroceryItem>();
        public BindingList<Book> Books = new BindingList<Book>();
        public MainForm()
        {
            InitializeComponent();
            Item bike = new Item(1000, "Bianchi E-Bike", "Italy", DateTime.Now, "A Luxury Class Electronic Bicycle");
            Item coat = new Item(449.99, "Vetements Logo Print Trench Coat", "France", new DateTime(2021, 12, 1), "VTMNTSCOAT");
            Items.Add(bike);
            Items.Add(coat);

            GroceryItem baguette = new GroceryItem(20, "Le Baguette", "France (duh)", DateTime.Now, "Baguette", DateTime.Today.AddDays(1), 23, "Pcs");

            Book aliceInWonderland = new Book(94.99, "Alice in Wonderland", "USA", DateTime.Today, "Great Book For Kids", 462, "Whatever", "Lewis Carroll");
            
            Groceries.Add(baguette);

            Books.Add(aliceInWonderland);

            ItemsDataSheet.DataSource = Items;
            GroceriesDataSheet.DataSource = Groceries;
            BooksDataSheet.DataSource = Books;

            /*for (int i = 0; i < Books[Books.Count - 1].listOfAuthors.Count; i++)
            {
                BooksDataSheet.Columns.Add(Books[Books.Count - 1].listOfAuthors[i], String.Format("Author No.{0}", i + 1));
                BooksDataSheet[0, i + 7] = Books[Books.Count - 1].listOfAuthors[i];
            }
            */
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addRowButton_Click(object sender, EventArgs e)
        {
            ItemInput inputForm = new ItemInput(this);
            inputForm.ShowDialog();

        }

        /*

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ItemsDataSheet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        */
         
        private void ItemsDeleteRowButton_Click(object sender, EventArgs e)
        {
            if (Items.Count >= 1)
            {
                Items.RemoveAt(Items.Count - 1);
            }
        }

        private void GroceriesAddRowButton_Click(object sender, EventArgs e)
        {
            GroceriesInput groceriesInput = new GroceriesInput(this);
            groceriesInput.ShowDialog();
        }

        private void GroceriesDeleteRowButton_Click(object sender, EventArgs e)
        {
            if (Groceries.Count >= 1)
            {
                Groceries.RemoveAt(Groceries.Count - 1);
            }
        }

        private void BooksAddRowButton_Click(object sender, EventArgs e)
        {
            BooksInput booksInput = new BooksInput(this);  
            booksInput.ShowDialog();
            /*for (int i = 0; i < Books[Books.Count - 1].listOfAuthors.Count; i++)
            {
                BooksDataSheet.Columns.Add(String.Format("Author No.{0}", i + 1), Books[Books.Count - 1].listOfAuthors[i]);
            }
            */
        }

        private void BooksDeleteRowButton_Click(object sender, EventArgs e)
        {
            if (Books.Count >= 1)
            {
                Books.RemoveAt(Books.Count - 1);
            }
        }

        
    }
}