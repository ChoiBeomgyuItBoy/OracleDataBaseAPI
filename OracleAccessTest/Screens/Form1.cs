using OracleAccessTest.Inventory;
using System;
using System.Windows.Forms;

namespace OracleAccessTest.Screens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();    
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            ItemsView.DataSource = InventoryItem.GetItemsTable();
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            string itemID = ItemIDText.Text;
            string itemName = itemNameText.Text;
            string itemAmountString = itemAmountText.Text;

            if(itemID == "" || itemName == "" || itemAmountString == "")
            {
                return;
            }

            if(itemID.Length > InventoryItem.GetMaxIDSize())
            {
                MessageBox.Show($"ID size shall not be greater than {InventoryItem.GetMaxIDSize()}");
                return;
            }
            else if(itemName.Length > InventoryItem.GetMaxNameSize())
            {
                MessageBox.Show($"Name size shall not be greater than {InventoryItem.GetMaxNameSize()}");
                return;
            }
            else if(itemAmountString.Length > InventoryItem.GetMaxItemAmount())
            {
                MessageBox.Show($"Amount shall not be greater than {InventoryItem.GetMaxItemAmount()}");
                return;
            }

            int itemAmount;

            bool isNumber = int.TryParse(itemAmountString, out itemAmount);

            if(isNumber)
            {
                InventoryItem newItem = new InventoryItem(itemID, itemName, itemAmount);             
            }
            else
            {
                MessageBox.Show("Item Amount shall be a numeric value");
            }
        }

        private void NameSizeButton_Click(object sender, EventArgs e)
        {
            string maxIDSize = InventoryItem.GetMaxIDSize().ToString();
            string maxNameSize = InventoryItem.GetMaxNameSize().ToString();
            string maxItemsSize = InventoryItem.GetMaxItemAmount().ToString();

            MessageBox.Show($"ID: {maxIDSize}, Name: {maxNameSize}, Items: {maxItemsSize}");
        }

        private void ItemLookupButton_Click(object sender, EventArgs e)
        {
            string lookupID = ItemLookupText.Text;

            if (lookupID == "") return;

            InventoryItem item = InventoryItem.GetNewItemWithKeyInfo(lookupID);

            if(item != null)
            {
                ItemDataScreen itemDataScreen = new ItemDataScreen(item);

                itemDataScreen.Show();
            }
            else
            {
                MessageBox.Show("Item NOT found");
            }
        }
    }
}
