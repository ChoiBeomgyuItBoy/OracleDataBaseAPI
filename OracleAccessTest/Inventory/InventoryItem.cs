using OracleAccessTest.DataBase;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OracleClient;

namespace OracleAccessTest.Inventory
{
    public class InventoryItem : IDataInserter, IDataModifier
    {
        public string ITEM_ID { get; set; } = "";
        public string ITEM_NAME { get; set; } = "";
        public int ITEM_AMOUNT { get; set; } = 0;

        public InventoryItem() { }

        public InventoryItem(string itemID, string itemName, int itemAmount)
        {
            this.ITEM_ID = itemID;
            this.ITEM_NAME = itemName;
            this.ITEM_AMOUNT = itemAmount;

            if (DataBaseManager.AlreadyHasKey("ITEM", "ITEM_ID", itemID))
            {
                System.Windows.Forms.MessageBox.Show("ID already in use");
            }
            else
            {
                DataBaseManager.InsertData(this);
                System.Windows.Forms.MessageBox.Show("Succesfully Created Item");
            }
        }

        public static InventoryItem GetNewItemWithKeyInfo(string key)
        {
            return DataBaseManager.GetItemWithKey<InventoryItem>("ITEM", "ITEM_ID", key);
        }

        public static int GetMaxNameSize()
        {
            return DataBaseManager.GetMaxAttributeSize("ITEM", "ITEM_NAME");
        }

        public static int GetMaxIDSize()
        {
            return DataBaseManager.GetMaxAttributeSize("ITEM", "ITEM_ID");
        }

        public static int GetMaxItemAmount()
        {
            return DataBaseManager.GetMaxAttributeSize("ITEM", "ITEM_AMOUNT");
        }

        // Query from SQL developer
        string IDataInserter.GetInsertionQuery()
        {
            return "InsertItem";
        }

        IEnumerable<Parameter> IDataInserter.GetParameters()
        {
            yield return new Parameter("itemID", ITEM_ID, OracleType.Char);
            yield return new Parameter("itemName", ITEM_NAME, OracleType.Char);
            yield return new Parameter("itemAmount", ITEM_AMOUNT, OracleType.Number);
        }

        // Query from SQL developer
        string IDataModifier.GetModifierQuery()
        {
            return "ModifyItem";
        }

        IEnumerable<Parameter> IDataModifier.GetModifiers()
        {
            yield return new Parameter("newItemID", ITEM_ID, OracleType.Char);
            yield return new Parameter("newItemName", ITEM_NAME, OracleType.Char);
            yield return new Parameter("newItemAmount", ITEM_AMOUNT, OracleType.Number);
        }

        public static DataTable GetItemsTable()
        {
            return DataBaseManager.GetDataTable("ITEM");
        }

        public void DeleteItem()
        {
            DataBaseManager.DeleteItemWithKey("ITEM", "ITEM_ID", ITEM_ID);
            System.Windows.Forms.MessageBox.Show("Succesfully Deleted Item");
        }
    }
}
