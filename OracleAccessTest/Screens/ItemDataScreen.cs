using System;
using OracleAccessTest.Inventory;
using System.Windows.Forms;
using OracleAccessTest.DataBase;

namespace OracleAccessTest.Screens
{
    public partial class ItemDataScreen : Form
    {
        InventoryItem item;

        public ItemDataScreen(InventoryItem item)
        {
            this.item = item;

            InitializeComponent();
        }

        private void ItemDataScreen_Load(object sender, EventArgs e)
        {
            LoadItemData();
        }

        private void ToggleTextFields(bool state)
        {
            itemNameText.Enabled = state;
            itemAmountText.Enabled = state;
        }

        private void LoadItemData()
        {
            itemIDText.Text = item.ITEM_ID;
            itemNameText.Text = item.ITEM_NAME;
            itemAmountText.Text = item.ITEM_AMOUNT.ToString();
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            ToggleTextFields(true);
            ModifyButton.Visible = false;
            ApplyChangesButton.Visible = true;
        }

        private void ApplyChangesButton_Click(object sender, EventArgs e)
        {
            string itemID = itemIDText.Text;
            string itemName = itemNameText.Text;
            string itemAmountString = itemAmountText.Text;

            if (itemID == "" || itemName == "" || itemAmountString == "")
            {
                return;
            }

            if (itemID.Length > InventoryItem.GetMaxIDSize())
            {
                MessageBox.Show($"ID size shall not be greater than {InventoryItem.GetMaxIDSize()}");
                return;
            }
            else if (itemName.Length > InventoryItem.GetMaxNameSize())
            {
                MessageBox.Show($"Name size shall not be greater than {InventoryItem.GetMaxNameSize()}");
                return;
            }
            else if (itemAmountString.Length > InventoryItem.GetMaxItemAmount())
            {
                MessageBox.Show($"Amount shall not be greater than {InventoryItem.GetMaxItemAmount()}");
                return;
            }

            int itemAmount;

            bool isNumber = int.TryParse(itemAmountString, out itemAmount);

            if (isNumber)
            {
                item.ITEM_ID = itemID;
                item.ITEM_NAME = itemName;
                item.ITEM_AMOUNT = itemAmount;

                DataBaseManager.ModifyData(item);
                MessageBox.Show("Succesfully Updated Data");
            }
            else
            {
                MessageBox.Show("Item Amount shall be a numeric value");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            item.DeleteItem();
            this.Close();
        }
    }
}
