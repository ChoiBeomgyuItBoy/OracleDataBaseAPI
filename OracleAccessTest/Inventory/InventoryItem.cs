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

       
        public static DataTable GetItemsTable()
        {
            return DataBaseManager.GetDataTable("ITEM");
        }

        public void DeleteItem()
        {
            DataBaseManager.DeleteItemWithKey("ITEM", "ITEM_ID", ITEM_ID);
            System.Windows.Forms.MessageBox.Show("Succesfully Deleted Item");
        }

        public string GetInsertionTableName()
        {
            return "ITEM";
        }

        public Dictionary<string, object> GetInsertionData()
        {
            var insertionData = new Dictionary<string, object>
            {
                { "ITEM_ID", ITEM_ID },
                { "ITEM_NAME", ITEM_NAME },
                { "ITEM_AMOUNT", ITEM_AMOUNT }
            };

            return insertionData;
        }

        public string GetInsertionWhereClause()
        {
            return "ITEM_ID = ITEM_ID";
        }

        public string GetModifyingTableName()
        {
            return "ITEM";
        }

        public Dictionary<string, object> GetDataToModify()
        {
            var dataToModify = new Dictionary<string, object>
            {
                { "ITEM_NAME", ITEM_NAME },
                { "ITEM_AMOUNT", ITEM_AMOUNT }
            };

            return dataToModify;
        }

        public string GetModifyingWhereClause()
        {
            return "ITEM_ID =: ITEM_ID";
        }
    }
}
