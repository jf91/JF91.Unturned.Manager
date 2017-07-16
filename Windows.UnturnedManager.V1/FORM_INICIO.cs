using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Collections;
using System.Reflection;

namespace Windows.UnturnedManager.V1
{
    public partial class FORM_INICIO : Form
    {
        #region DATABASE PROPERTIES

        public static string Servidor = "datasource=" + Properties.Settings.Default.ip + ";port=" + Properties.Settings.Default.port + ";username=" + Properties.Settings.Default.user + ";password=" + Properties.Settings.Default.pass + "";

        public static string BD = Properties.Settings.Default.db;
        public static string Items = Properties.Settings.Default.itemtable;
        public static string Vehicles = Properties.Settings.Default.vehicletable;

        #endregion

        #region DATABASE OBJECTS

        MySqlConnection LigacaoDB = new MySqlConnection(Servidor);

        MySqlDataAdapter Adapter = new MySqlDataAdapter();

        DataTable TabelaDadosItems = new DataTable();
        DataTable TabelaDadosVehicles = new DataTable();

        #endregion

        #region ITEM PROPERTIES

        public static int RowItem_OldID;
        public static int Item_OldID;
        public static string Item_OldName = "";
        public static string Item_OldCost = "";

        public static int RowItem_ID;
        public static int Item_ID;
        public static string Item_Name = "";
        public static string Item_Cost = "";

        public static bool NewItem = false;
        public static bool EditItem = false;

        #endregion

        #region VEHICLE PROPERTIES

        public static int RowVehicle_OldID;
        public static int Vehicle_OldID;
        public static string Vehicle_OldName = "";
        public static string Vehicle_OldCost = "";

        public static int RowVehicle_ID;
        public static int Vehicle_ID;
        public static string Vehicle_Name = "";
        public static string Vehicle_Cost = "";

        public static bool NewVehicle = false;
        public static bool EditVehicle = false;

        #endregion

        #region APPLICATION START

        public FORM_INICIO()
        {
            InitializeComponent();

            if (Properties.Settings.Default.ip == null || Properties.Settings.Default.ip == "")
            {
                DialogResult DR = MessageBox.Show("You have not set a host yet, you need to add one to proceed", "Not Configured", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (DR == DialogResult.Yes)
                {
                    FORM_SETTINGS Settings = new FORM_SETTINGS();
                    Settings.ShowDialog();
                }

                else
                {
                    this.Close();
                }
            }

            else
            {
                FillDataGridView_Items();
                FillDataGridView_Vehicles();
            }
        }

        #endregion

        #region GLOBAL EVENTS

        private void BUTTON_SETTINGS_Click(object sender, EventArgs e)
        {
            FORM_SETTINGS Settings = new FORM_SETTINGS();
            Settings.ShowDialog();
        }

        private void BUTTON_EXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        #region GLOBAL FUNCTIONS

        public void FillDataGridView_Items()
        {
            try
            {
                LigacaoDB.Open();

                string Query = "SELECT * FROM " + BD + "." + Items + "";

                MySqlCommand ComandoFill = new MySqlCommand(Query, LigacaoDB);

                Adapter.SelectCommand = ComandoFill;

                Adapter.Fill(TabelaDadosItems);

                BindingSource ColecaoDados = new BindingSource();

                ColecaoDados.DataSource = TabelaDadosItems;

                DATAGRIDVIEW_ITEMS.DataSource = ColecaoDados;

                Adapter.Update(TabelaDadosItems);

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
            }
        }

        public void FillDataGridView_Vehicles()
        {
            try
            {
                LigacaoDB.Open();

                string Query = "SELECT * FROM " + BD + "." + Vehicles + "";

                MySqlCommand ComandoFill = new MySqlCommand(Query, LigacaoDB);

                Adapter.SelectCommand = ComandoFill;

                Adapter.Fill(TabelaDadosVehicles);

                BindingSource ColecaoDados = new BindingSource();

                ColecaoDados.DataSource = TabelaDadosVehicles;

                DATAGRIDVIEW_VEHICLES.DataSource = ColecaoDados;

                Adapter.Update(TabelaDadosVehicles);

                LigacaoDB.Close();
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
            }
        }

        public void CreateConfigFile()
        {
            
        }

        #endregion

        #region ITEM SHOP MANAGER

        private void BUTTON_DELETE_ITEM_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList ItemsList = new ArrayList();

                foreach (DataGridViewRow ROW in DATAGRIDVIEW_ITEMS.Rows)
                {
                    if (ROW.Selected == true)
                    {
                        ItemsList.Add(ROW.Cells["ItemID"].Value);
                    }
                }

                foreach (int Item in ItemsList)
                {
                    string Query = "DELETE FROM " + BD + "." + Items + " WHERE id = " + Item + "";

                    MySqlCommand DeleteItem = new MySqlCommand(Query, LigacaoDB);

                    LigacaoDB.Open();

                    DeleteItem.ExecuteNonQuery();

                    LigacaoDB.Close();

                    TabelaDadosItems.Clear();
                    FillDataGridView_Items();
                }
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
            }
        }

        private void DATAGRIDVIEW_ITEMS_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //try
            //{
            //    ArrayList ItemsList = new ArrayList();

            //    foreach (DataGridViewRow ROW in DATAGRIDVIEW_ITEMS.Rows)
            //    {
            //        if (ROW.Selected == true)
            //        {
            //            ItemsList.Add(ROW.Cells["ItemID"].Value);
            //        }
            //    }

            //    foreach (int Item in ItemsList)
            //    {
            //        string Query = "DELETE FROM " + BD + "." + Items + " WHERE id = " + Item + "";

            //        MySqlCommand DeleteItem = new MySqlCommand(Query, LigacaoDB);

            //        LigacaoDB.Open();

            //        DeleteItem.ExecuteNonQuery();

            //        LigacaoDB.Close();

            //        TabelaDadosItems.Clear();
            //        FillDataGridView_Items();
            //    }
            //}

            //catch (Exception EX)
            //{
            //    //MessageBox.Show(EX.Message);
            //}
        }

        private void DATAGRIDVIEW_ITEMS_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DATAGRIDVIEW_ITEMS.SelectedCells.Count != -1 && DATAGRIDVIEW_ITEMS.SelectedCells.Count != 0)
                {
                    bool rowIsEmpty = true;
                    DataGridViewRow currentRow = DATAGRIDVIEW_ITEMS.SelectedRows[0];

                    if (currentRow.Cells.Count > 0)
                    {
                        foreach (DataGridViewCell cell in currentRow.Cells)
                        {
                            if (cell.Value == null || cell.Value.ToString() == "")
                            {
                                rowIsEmpty = true;
                            }

                            else
                            {
                                rowIsEmpty = false;
                                break;
                            }
                        }
                    }

                    if (rowIsEmpty == true)
                    {
                        NewItem = true;
                        EditItem = false;

                        Item_ID = 0;
                        Item_Name = "";
                        Item_Cost = "";
                    }

                    if (rowIsEmpty == false)
                    {
                        NewItem = false;
                        EditItem = true;

                        Item_OldID = Convert.ToInt32(DATAGRIDVIEW_ITEMS.SelectedCells[0].Value);
                        Item_OldName = DATAGRIDVIEW_ITEMS.SelectedCells[1].Value.ToString();
                        Item_OldCost = DATAGRIDVIEW_ITEMS.SelectedCells[2].Value.ToString();

                        Item_ID = Convert.ToInt32(DATAGRIDVIEW_ITEMS.SelectedCells[0].Value);
                        Item_Name = DATAGRIDVIEW_ITEMS.SelectedCells[1].Value.ToString();
                        Item_Cost = DATAGRIDVIEW_ITEMS.SelectedCells[2].Value.ToString();

                        RowItem_ID = DATAGRIDVIEW_ITEMS.SelectedRows[0].Index;
                        RowItem_OldID = DATAGRIDVIEW_ITEMS.SelectedRows[0].Index;
                    }
                }
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
                //NewVehicle = false;
                //EditVehicle = false;
            }
        }        
        
        private void DATAGRIDVIEW_ITEMS_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    Item_ID = int.Parse(DATAGRIDVIEW_ITEMS.Rows[e.RowIndex]
                .Cells["ItemID"].Value.ToString());
                }

                if (e.ColumnIndex == 1)
                {
                    Item_Name = string.Copy(DATAGRIDVIEW_ITEMS.Rows[e.RowIndex]
                .Cells["ItemName"].Value.ToString());
                }

                if (e.ColumnIndex == 2)
                {
                    Item_Cost = string.Copy(DATAGRIDVIEW_ITEMS.Rows[e.RowIndex]
                .Cells["ItemCost"].Value.ToString());
                }

                if (EditItem == true)
                {
                    Manage_Item(Item_ID, Item_Name, Item_Cost);
                }

                if(NewItem == true)
                {
                    Manage_Item(Item_ID, Item_Name, Item_Cost);
                }

                DATAGRIDVIEW_ITEMS_SelectionChanged(sender, e);
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
                //NewVehicle = false;
                //EditVehicle = false;
            }
        }

        private void TEXTBOX_SEARCH_ITEMS_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_SEARCH_ITEMS.Text == "Search...")
                return;
            if (TEXTBOX_SEARCH_ITEMS.Text == "")
                return;
            else
                SearchItem(TEXTBOX_SEARCH_ITEMS.Text);
        }

        private void TEXTBOX_SEARCH_ITEMS_Enter(object sender, EventArgs e)
        {
            if (TEXTBOX_SEARCH_ITEMS.Text == "Search...")
                TEXTBOX_SEARCH_ITEMS.Text = "";
        }

        private void TEXTBOX_SEARCH_ITEMS_Leave(object sender, EventArgs e)
        {
            if (TEXTBOX_SEARCH_ITEMS.Text == "")
                TEXTBOX_SEARCH_ITEMS.Text = "Search...";
        }
 
        public void Manage_Item(int ID, string Name, string Cost)
        {
            if (LigacaoDB.State == ConnectionState.Open)
                LigacaoDB.Close();

            try
            {
                if (NewItem == true)
                {
                    string Query = "INSERT INTO " + BD + "." + Items + " (id, itemname, cost) VALUES(" + ID + ",'" + Name + "', '" + Cost + "')";

                    MySqlCommand InsertItem = new MySqlCommand(Query, LigacaoDB);

                    LigacaoDB.Open();

                    InsertItem.ExecuteNonQuery();

                    LigacaoDB.Close();

                    NewItem = false;

                    TabelaDadosItems.Clear();
                    FillDataGridView_Items();

                    return;
                }

                if(EditItem == true)
                {
                    string Query = "UPDATE " + BD + "." + Items + " SET id = " + ID + ", itemname = '" + Name + "', cost = '" + Cost + "' WHERE id = " + Item_OldID + "";

                    MySqlCommand InsertItem = new MySqlCommand(Query, LigacaoDB);

                    LigacaoDB.Open();

                    InsertItem.ExecuteNonQuery();

                    LigacaoDB.Close();

                    EditItem = false;

                    TabelaDadosItems.Clear();
                    FillDataGridView_Items();

                    return;
                }
            }

            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                NewItem = false;
                EditItem = false;
            }
        }

        public void SearchItem(string Name)
        {
            DataView DV = new DataView(TabelaDadosItems);

            DV.RowFilter = string.Format("ItemName LIKE '%{0}%'", TEXTBOX_SEARCH_ITEMS.Text);

            DATAGRIDVIEW_ITEMS.DataSource = DV;
        }

        #endregion

        #region VEHICLE SHOP MANAGER

        private void BUTTON_DELETE_VEHICLE_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayList VehiclesList = new ArrayList();

                foreach (DataGridViewRow ROW in DATAGRIDVIEW_VEHICLES.Rows)
                {
                    if (ROW.Selected == true)
                    {
                        VehiclesList.Add(ROW.Cells["VehicleID"].Value);
                    }
                }

                foreach (int Vehicle in VehiclesList)
                {
                    string Query = "DELETE FROM " + BD + "." + Vehicles + " WHERE id = " + Vehicle + "";

                    MySqlCommand DeleteVehicle = new MySqlCommand(Query, LigacaoDB);

                    LigacaoDB.Open();

                    DeleteVehicle.ExecuteNonQuery();

                    LigacaoDB.Close();

                    TabelaDadosVehicles.Clear();
                    FillDataGridView_Vehicles();
                }
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
            }
        }

        private void DATAGRIDVIEW_VEHICLES_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            //try
            //{
            //    ArrayList VehiclesList = new ArrayList();

            //    foreach (DataGridViewRow ROW in DATAGRIDVIEW_VEHICLES.Rows)
            //    {
            //        if (ROW.Selected == true)
            //        {
            //            VehiclesList.Add(ROW.Cells["VehicleID"].Value);
            //        }
            //    }

            //    foreach (int Vehicle in VehiclesList)
            //    {
            //        string Query = "DELETE FROM " + BD + "." + Vehicles + " WHERE id = " + Vehicle + "";

            //        MySqlCommand DeleteVehicle = new MySqlCommand(Query, LigacaoDB);

            //        LigacaoDB.Open();

            //        DeleteVehicle.ExecuteNonQuery();

            //        LigacaoDB.Close();

            //        TabelaDadosVehicles.Clear();
            //        FillDataGridView_Vehicles();
            //    }

            //    return;
            //}

            //catch (Exception EX)
            //{
            //    //MessageBox.Show(EX.Message);
            //}
        }

        private void DATAGRIDVIEW_VEHICLES_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (DATAGRIDVIEW_VEHICLES.SelectedCells.Count != -1 && DATAGRIDVIEW_VEHICLES.SelectedCells.Count != 0)
                {
                    bool rowIsEmpty = true;
                    DataGridViewRow currentRow = DATAGRIDVIEW_VEHICLES.SelectedRows[0];

                    if (currentRow.Cells.Count > 0)
                    {
                        foreach (DataGridViewCell cell in currentRow.Cells)
                        {
                            if (cell.Value == null || cell.Value.ToString() == "")
                            {
                                rowIsEmpty = true;
                            }

                            else
                            {
                                rowIsEmpty = false;
                                break;
                            }
                        }
                    }

                    if (rowIsEmpty == true)
                    {
                        NewVehicle = true;
                        EditVehicle = false;

                        Vehicle_ID = 0;
                        Vehicle_Name = "";
                        Vehicle_Cost = "";
                    }

                    if (rowIsEmpty == false)
                    {
                        NewVehicle = false;
                        EditVehicle = true;

                        Vehicle_OldID = Convert.ToInt32(DATAGRIDVIEW_VEHICLES.SelectedCells[0].Value);
                        Vehicle_OldName = DATAGRIDVIEW_VEHICLES.SelectedCells[1].Value.ToString();
                        Vehicle_OldCost = DATAGRIDVIEW_VEHICLES.SelectedCells[2].Value.ToString();

                        Vehicle_ID = Convert.ToInt32(DATAGRIDVIEW_VEHICLES.SelectedCells[0].Value);
                        Vehicle_Name = DATAGRIDVIEW_VEHICLES.SelectedCells[1].Value.ToString();
                        Vehicle_Cost = DATAGRIDVIEW_VEHICLES.SelectedCells[2].Value.ToString();

                        RowVehicle_ID = DATAGRIDVIEW_VEHICLES.SelectedRows[0].Index;
                        RowVehicle_OldID = DATAGRIDVIEW_VEHICLES.SelectedRows[0].Index;
                    }
                }
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
                //NewVehicle = false;
                //EditVehicle = false;
            }
        }

        private void DATAGRIDVIEW_VEHICLES_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 0)
                {
                    Vehicle_ID = int.Parse(DATAGRIDVIEW_VEHICLES.Rows[e.RowIndex]
                .Cells["VehicleID"].Value.ToString());
                }

                if (e.ColumnIndex == 1)
                {
                    Vehicle_Name = string.Copy(DATAGRIDVIEW_VEHICLES.Rows[e.RowIndex]
                .Cells["VehicleName"].Value.ToString());
                }

                if (e.ColumnIndex == 2)
                {
                    Vehicle_Cost = string.Copy(DATAGRIDVIEW_VEHICLES.Rows[e.RowIndex]
                .Cells["VehicleCost"].Value.ToString());
                }

                if (EditVehicle == true)
                {
                    Manage_Vehicle(Vehicle_ID, Vehicle_Name, Vehicle_Cost);
                }

                if (NewVehicle == true)
                {
                    Manage_Vehicle(Vehicle_ID, Vehicle_Name, Vehicle_Cost);
                }

                DATAGRIDVIEW_VEHICLES_SelectionChanged(sender, e);
            }

            catch (Exception EX)
            {
                //MessageBox.Show(EX.Message);
                //EditVehicle = false;
                //NewVehicle = false;
            }
        }

        private void TEXTBOX_SEARCH_VEHICLES_TextChanged(object sender, EventArgs e)
        {
            if (TEXTBOX_SEARCH_VEHICLES.Text == "Search...")
                return;
            if (TEXTBOX_SEARCH_VEHICLES.Text == "")
                return;
            else
                SearchVehicle(TEXTBOX_SEARCH_VEHICLES.Text);
        }

        private void TEXTBOX_SEARCH_VEHICLES_Enter(object sender, EventArgs e)
        {
            if (TEXTBOX_SEARCH_VEHICLES.Text == "Search...")
                TEXTBOX_SEARCH_VEHICLES.Text = "";
        }

        private void TEXTBOX_SEARCH_VEHICLES_Leave(object sender, EventArgs e)
        {
            if (TEXTBOX_SEARCH_VEHICLES.Text == "")
                TEXTBOX_SEARCH_VEHICLES.Text = "Search...";
        }

        public void Manage_Vehicle(int ID, string Name, string Cost)
        {
            if (LigacaoDB.State == ConnectionState.Open)
                LigacaoDB.Close();

            try
            {
                if (NewVehicle == true)
                {
                    string Query = "INSERT INTO " + BD + "." + Vehicles + " (id, vehiclename, cost) VALUES(" + ID + ",'" + Name + "', '" + Cost + "')";

                    MySqlCommand InsertVehicle = new MySqlCommand(Query, LigacaoDB);

                    LigacaoDB.Open();

                    InsertVehicle.ExecuteNonQuery();

                    LigacaoDB.Close();

                    NewVehicle = false;

                    TabelaDadosVehicles.Clear();
                    FillDataGridView_Vehicles();

                    return;
                }

                if (EditVehicle == true)
                {
                    string Query = "UPDATE " + BD + "." + Vehicles + " SET id = " + ID + ", vehiclename = '" + Name + "', cost = '" + Cost + "' WHERE id = " + Vehicle_OldID + "";

                    MySqlCommand InsertVehicle = new MySqlCommand(Query, LigacaoDB);

                    LigacaoDB.Open();

                    InsertVehicle.ExecuteNonQuery();

                    LigacaoDB.Close();

                    EditVehicle = false;

                    TabelaDadosVehicles.Clear();
                    FillDataGridView_Vehicles();

                    return;
                }
            }

            catch (MySqlException EX)
            {
                MessageBox.Show(EX.Message);
                NewVehicle = false;
                EditVehicle = false;
            }
        }

        public void SearchVehicle(string Name)
        {
            DataView DV = new DataView(TabelaDadosVehicles);

            DV.RowFilter = string.Format("VehicleName LIKE '%{0}%'", TEXTBOX_SEARCH_VEHICLES.Text);

            DATAGRIDVIEW_VEHICLES.DataSource = DV;
        }

        #endregion
    }    
}
