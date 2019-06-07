
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Assign3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();   //to begin the application
            Load += new EventHandler(Form1_Load);
        }

        private void Form1_Load(object sender, EventArgs e) //to connect to MySql and read files, process query and display results
        {
            String s = "server=10.158.56.53;uid=csci473g01;pwd=wordpass01;database=csci473g01;"; //source to connect to the database
            MySqlConnection Con;     
            using (Con = new MySqlConnection(s))
            {
                Con.Open(); MySqlCommand c;  //establishes new connection
                string file, l, query;
 //-----------------------------------------------------------------------------------------------------------------------------------------
                file = "Room.txt"; l = ""; //first file is read
                int column1, column2;
                string[] entry; char position;
                c = new MySqlCommand("drop table if exists RoomTable, OfficeTable, ClassTable;", Con); c.ExecuteNonQuery();  //creates new table if the same table doesn't exist
                c = new MySqlCommand("create table ClassTable(Course integer,Section integer, Teacher char(20),Room integer,Time char(5),Days char(5),Enrollment integer);", Con); c.ExecuteNonQuery();
                c = new MySqlCommand("create table RoomTable(Room integer,Capacity integer,Smart char(1));", Con); c.ExecuteNonQuery();
                c = new MySqlCommand("create table OfficeTable(Teacher char(20),Office integer);", Con); c.ExecuteNonQuery();
                    System.IO.StreamReader read = new System.IO.StreamReader(file); //object to read the input file
                    l = read.ReadLine(); //every text is copied from the text file
                    while ((System.IO.File.Exists(file)==true) && ((read.ReadLine()) != null)) //if the file exists and untill we reach the end of the file, the values are read
                    {
                        entry = l.Split(','); //since the values are split by ',' we are using this function
                        string position1 = entry[0]; 
                        string position2 = entry[1];
                        position = entry[2][0];
                        column1 = Convert.ToInt32(position1); column2 = Convert.ToInt32(position2);
                        query = "insert into RoomTable values (" + column1 + ", " + column2 + ", '" + position + "');"; //values read are copied to the table
                        c = new MySqlCommand(query, Con); c.ExecuteNonQuery(); //the command is passed and executed through the MySqlCommand object
                    }
                    read.Close(); //after reading text from the file, it is closed
// -------------------------------------------------------------------------------------------------------------------------------------------
                    file = "Office.txt"; //second file is read
                    System.IO.StreamReader read1 = new System.IO.StreamReader(file); //Object used to read the file line by line
                    string temp = read1.ReadLine();
                    String columnn1; int columnn2;
                    while (((System.IO.File.Exists(file)==true) && (read1.ReadLine()) != null))
                    {
                        entry = l.Split(',');
                        string positionn;
                        columnn1 = entry[0];
                        positionn = entry[1];
                        columnn2 = Convert.ToInt32(positionn); //the read value is converted to string
                        query = "insert into OfficeTable values ('" + columnn1 + "', " + columnn2 + ");";
                        c = new MySqlCommand(query, Con);  c.ExecuteNonQuery(); //Command is executed my establishing the connection
                    }
                    read1.Close();
                //------------------------------------------------------------------------------------------------------------------------------------------
                file = "Class.txt"; // reading the class file
                System.IO.StreamReader read2 = new System.IO.StreamReader(file);
                l = read2.ReadLine();
                int len = (read2.ReadLine()).Length;
                int colum1, colum2,colum4, colum7;
                while (((l=read2.ReadLine()).Length>0) && (System.IO.File.Exists(file)==true))
                {
                    entry = l.Split(','); 
                    string pos = entry[0]; //each entry is read and as per their datatype they are stored 
                    string pos1 = entry[1];
                    string pos2 = entry[2];
                    string pos3 = entry[2];
                    string pos4 = entry[3];
                    string pos5 = entry[4];
                    string pos6 = entry[5];
                    string pos7 = entry[6];
                    colum1 = Convert.ToInt32(pos);
                    colum2 = Convert.ToInt32(pos1);
                    colum7 = Convert.ToInt32(pos7);
                if (pos4 == "null")  //since the fourth column has null values, we check for it
                {
                    colum4 = 0;
                }
                else
                {
                    colum4 = Convert.ToInt32(pos4);
                }
                query = "INSERT into ClassTable values (" + colum1 + ", " + colum2 + ",'" + pos3 + "'," + colum4 + ",'" + pos5 + "','" + pos6 + "'," + colum7 + ");";
                c = new MySqlCommand(query, Con); c.ExecuteNonQuery();
            }
            read2.Close();
                //------------------------------------------------------------------------------------------------------------------------
                

                DataTable t;
                t = Con.GetSchema("Tables"); // The DB Schema is retrieved and tables are displayed in the listbox
                string s1 = "pg";
                string s2 = "sql";
                foreach (DataRow row in t.Rows)
                {
                    string r = row[2].ToString();
                    if (r.Substring(0, 2) != s1 && r.Substring(0, 3) != s2)
                        RESULTS.Items.Add(r);
                }

            }
        }
        private void Ok_Click( object sender, EventArgs e)
        {
            RESULTS.Items.Add(" ");
            string queryEntered, Conn;
            MySqlConnection Con; MySqlCommand c;
            queryEntered = t3.Text;
            Conn = "server=10.158.56.53;uid=csci473g01;pwd=wordpass01;database=csci473g01;";
            using (Con = new MySqlConnection(Conn))  //establishes connection 
            {
                Con.Open();   //opens the connection
                MySqlDataReader d; int count;
                string temp1, temp2;
                temp1 = temp2 = "";
                c = new MySqlCommand(queryEntered, Con);
                try         //if the query entered doesn't exist, we need to throw an exceptio
                {
                    using ( d = c.ExecuteReader())
                    {
                        count = d.FieldCount; var v = d.GetSchemaTable();
                        string Add; string b = " "; string value;
                        foreach (DataRow row in v.Rows)
                        {
                            Add = row.Field<string>("ColumnName");
                            int length = Add.Length;
                            for (int i = length; i < 20; i++)
                            {
                                Add = Add + b;
                            }
                            temp2 = temp2 + (Add + "\t");
                        }
                        RESULTS.Items.Add(temp2);  //displays the values in the listbox
                        while (d.Read()==true)
                        {
                            for (int i = 0; i < count; i++)
                            {
                                value = d[i].ToString();
                                int len1 = value.Length;
                                for (int j = len1; j < 20; j++)
                                {
                                    value = value + b;
                                }

                                temp1 = temp1 + (value + "\t");
                            }
                            RESULTS.Items.Add(temp1); temp1 = b;
                        }

                    }

                }
                catch (MySqlException)
                {
                    MessageBox.Show("Invalid query: Please enter a valid query");
                }
            }
        }

        private void clear_Click(object sender, EventArgs e)  //clears the textbox
        {
            string clear = "";
            t3.Text = clear;
            RESULTS.Items.Clear();
        }
        private void cancel_Click(object sender, EventArgs e) //closes the application
        {
            Application.Exit();
        }
    }
}

