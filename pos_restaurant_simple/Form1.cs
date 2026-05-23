using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos_restaurant_simple
{
    public partial class Form1 : Form
    {
        MySqlConnection conn;
        MySqlDataAdapter adapter;
        DataTable dt;
        decimal total = 0;
        private int currentOrderId;
        private object orderID;

        public Form1()
        {
            InitializeComponent();
            string connStr = "server=localhost;user=root;database=pos_restaurant_simple;password=YOUR_PASSWORD;";
            conn = new MySqlConnection(connStr);

            InitializeOrderDataGridView2();
            LoadMenuItems();
            LoadOrders();

            comboBox1.Items.AddRange(new string[] { "Food", "Drinks", "Dessert" });
        }

        private void InitializeOrderDataGridView2()
        {
            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("item_name", "Item Name");
            dataGridView2.Columns.Add("price", "Price");
        }
        private void LoadMenuItems()
        {
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter("SELECT * FROM menu_items", conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView1.DataSource = dt;
                dataGridView5.DataSource = dt;
            }
            finally
            {
                conn.Close();
            }
        }

        private void LoadOrders()
        {
            try
            {
                conn.Open();
                string query = @"
                SELECT o.order_id, o.order_date, 
                       COALESCE(SUM(mi.price * od.quantity), 0) AS total_amount
                FROM orders o
                LEFT JOIN order_details od ON o.order_id = od.order_id
                LEFT JOIN menu_items mi ON od.item_id = mi.item_id
                GROUP BY o.order_id, o.order_date
                ORDER BY o.order_id DESC";

                adapter = new MySqlDataAdapter(query, conn);
                dt = new DataTable();
                adapter.Fill(dt);
                dataGridView3.DataSource = dt;
            }
            finally
            {
                conn.Close();
            }
        }


        private void UpdateTotalAmount()
        {
            total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.IsNewRow) continue;
                if (decimal.TryParse(row.Cells["price"].Value?.ToString(), out decimal price))
                {
                    total += price;
                }
            }
            label1.Text = total.ToString("C");
        }
        // Function to load order items into dataGridView4
        private void LoadOrderItems(int orderId)
        {
            currentOrderId = orderId; // Save current order ID for later use

            try
            {
                conn.Open();
                string query = @"
        SELECT od.order_detail_id AS 'OrderDetailID', 
               mi.item_name AS 'Item Name', 
               od.quantity AS 'Quantity', 
               mi.price AS 'Price', 
               (od.quantity * mi.price) AS 'Subtotal'
        FROM order_details od
        JOIN menu_items mi ON od.item_id = mi.item_id
        WHERE od.order_id = @orderId";

                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderId);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView3.DataSource = dt; // Set the data to DataGridView4
            }
            finally
            {
                conn.Close();
            }
        }
        void LoadOrderDetails(int orderId)
        {
            string query = "SELECT detail_id, item_id, quantity FROM order_details WHERE order_id = @id";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@id", orderId);
            MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView3.DataSource = dt;

        }




        private void Menu_Click(object sender, EventArgs e)
        {
            LoadMenuItems();
            dataGridView2.Rows.Clear();
            label1.Text = 0.ToString("C");
        }

        private void OrderDetails_Click(object sender, EventArgs e)
        {

        }

        private void ManageMenu_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dataGridView1.Rows[e.RowIndex];
                string itemName = row.Cells["item_name"].Value.ToString();
                decimal price = Convert.ToDecimal(row.Cells["price"].Value);
                dataGridView2.Rows.Add(itemName, price);
                UpdateTotalAmount();
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmdOrder = new MySqlCommand("INSERT INTO orders (order_date) VALUES (NOW())", conn);
                cmdOrder.ExecuteNonQuery();
                long orderId = cmdOrder.LastInsertedId;

                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.IsNewRow) continue;

                    string itemName = row.Cells[0].Value.ToString();
                    decimal price = Convert.ToDecimal(row.Cells[1].Value);

                    MySqlCommand cmdGetId = new MySqlCommand("SELECT item_id FROM menu_items WHERE item_name = @name", conn);
                    cmdGetId.Parameters.AddWithValue("@name", itemName);
                    int itemId = Convert.ToInt32(cmdGetId.ExecuteScalar());

                    MySqlCommand cmdDetails = new MySqlCommand("INSERT INTO order_details (order_id, item_id, quantity, price) VALUES (@orderId, @itemId, 1, @price)", conn);
                    cmdDetails.Parameters.AddWithValue("@orderId", orderId);
                    cmdDetails.Parameters.AddWithValue("@itemId", itemId);
                    cmdDetails.Parameters.AddWithValue("@price", price);
                    cmdDetails.ExecuteNonQuery();
                }

                dataGridView2.Rows.Clear();
                label1.Text = "0";
                MessageBox.Show("Order placed successfully!");
            }
            finally
            {
                conn.Close();
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            label1.Text = 0.ToString("C");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int orderId = Convert.ToInt32(dataGridView3.Rows[e.RowIndex].Cells["order_id"].Value);
                LoadOrderItems(orderId);
            }
        }
        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["order_id"].Value);
                LoadOrderItems(orderId);
            }
            foreach (DataGridViewColumn col in dataGridView3.Columns)
            {
                Console.WriteLine($"{col.Index} - {col.HeaderText}");
            }


        }






        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int detailId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value); // Assuming OrderDetailID is the first column
                string query = "DELETE FROM order_details WHERE order_detail_id = @id";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", detailId);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Order item deleted successfully.");
                LoadOrderItems(currentOrderId); // reload with current orderId
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }

        private void LoadOrderItems()
        {
            try
            {
                conn.Open();
                string query = "SELECT * FROM order_details WHERE order_id = @orderId";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@orderId", orderID);

                MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView3.DataSource = dt;  // I guess order items should go to dataGridView4, not dataGridView3
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading order details: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void LoadOrderDetails(object currentOrderId)
        {
            throw new NotImplementedException();
        }

        private void LoadOrderDetails()
        {
            throw new NotImplementedException();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void dataGridView5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand("INSERT INTO menu_items (item_name, price, category) VALUES (@name, @price, @category)", conn);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@price", decimal.Parse(textBox2.Text));
                cmd.Parameters.AddWithValue("@category", comboBox1.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Menu item added!");
            }
            finally
            {
                conn.Close();
            }
            LoadMenuItems();
            textBox1.Clear();
            textBox2.Clear();
            comboBox1.SelectedIndex = -1;
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dataGridView5.SelectedRows[0].Cells["item_id"].Value);
                string newName = textBox1.Text;
                decimal newPrice = Convert.ToDecimal(textBox2.Text);

                try
                {
                    conn.Open();
                    string query = "UPDATE menu_items SET item_name = @name, price = @price WHERE item_id = @id";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@name", newName);
                    cmd.Parameters.AddWithValue("@price", newPrice);
                    cmd.Parameters.AddWithValue("@id", itemId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item updated successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadMenuItems(); // Refresh
                }
            }
            else
            {
                MessageBox.Show("Please select an item to update.");
            }
        }



        private void button7_Click(object sender, EventArgs e)
        {
            if (dataGridView5.SelectedRows.Count > 0)
            {
                int itemId = Convert.ToInt32(dataGridView5.SelectedRows[0].Cells["item_id"].Value);

                try
                {
                    conn.Open();

                    // Delete order_details referencing this item
                    string deleteOrderDetailsQuery = "DELETE FROM order_details WHERE item_id = @id";
                    MySqlCommand cmdDeleteDetails = new MySqlCommand(deleteOrderDetailsQuery, conn);
                    cmdDeleteDetails.Parameters.AddWithValue("@id", itemId);
                    cmdDeleteDetails.ExecuteNonQuery();

                    // Then delete the menu item
                    string deleteMenuQuery = "DELETE FROM menu_items WHERE item_id = @id";
                    MySqlCommand cmdDeleteMenu = new MySqlCommand(deleteMenuQuery, conn);
                    cmdDeleteMenu.Parameters.AddWithValue("@id", itemId);
                    cmdDeleteMenu.ExecuteNonQuery();

                    MessageBox.Show("Item and related orders deleted successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                    LoadMenuItems();
                }
            }
            else
            {
                MessageBox.Show("Please select an item to delete.");
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (dataGridView3.SelectedRows.Count > 0)
            {
                int orderId = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells["order_id"].Value);
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand("UPDATE orders SET payment_status = 'Paid' WHERE order_id = @id", conn);
                    cmd.Parameters.AddWithValue("@id", orderId);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Payment processed successfully!");
                    LoadOrders(); // Refresh the orders list
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("Please select an order to proceed with payment.");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
