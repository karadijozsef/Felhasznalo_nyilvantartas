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

namespace Felhasznalo_nyilvantartas
{
    public partial class Form1 : Form
    {
        MySqlConnection conn = null;
        MySqlCommand cmd = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "felhasznalonyilvantartas";
            conn = new MySqlConnection(builder.ConnectionString);

            try
            {
                conn.Open();
                cmd = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "A program le fog állni!!!!!");
                Environment.Exit(0);
            }
            finally
            {
                conn.Close();
            }
        }
        private void felhasznalo_update()
        {
            listBox_felhasznalok.Items.Clear();
            cmd.CommandText = "SELECT `id`,`nev`,`szuletesidatum`,`profilkepnev` FROM `felhasznalo` WHERE 1";
            conn.Open();
            using (MySqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    felhasznalok uj = new felhasznalok(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDateTime("szuletesidatum"), dr.GetString("profilkepnev"));
                    listBox_felhasznalok.Items.Add(uj);
                }
            }
            conn.Close();
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (nincs_adat())
            {
                return;
            }
            cmd.CommandText = "INSERT INTO `felhasznalo` (`id`,`nev`,`szuletesidatum`,`profilkepnev`) VALUES (NULL, @nev, @szuletesidatum, @profilkepnev)";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@szuletesidatum", dateTimePicker_szuletes.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@profilkepnev", textBox_profilnev.Text);
            conn.Open();
            try
            {
                if (cmd.ExecuteNonQuery()==1)
                {
                    MessageBox.Show("Sikeres volt az adatok rögzítése!!!!");
                    textBox_id.Text = "";
                    textBox_nev.Text = "";
                    dateTimePicker_szuletes.ResetText();
                    textBox_profilnev.Text = "";
                    pictureBox_profilkep.Image = null;
                }
                else
                {
                    MessageBox.Show("Sikertelen volt az adatok rögzítése!!!!");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "Sikertelen!!!!");
            }
            conn.Close();
            felhasznalo_update();
        }

        private bool nincs_adat()
        {
            if (string.IsNullOrEmpty(textBox_nev.Text))
            {
                MessageBox.Show("Nem adaott meg nevet!!!");
                textBox_nev.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(textBox_profilnev.Text))
            {
                MessageBox.Show("Nem adta meg a profilkép nevét!!!!");
                textBox_profilnev.Focus();
                return true;
            }
            if (pictureBox_profilkep.Image = )
            {

            }
            return false;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (listBox_felhasznalok.SelectedIndex < 0)
            {
                return;
            }
            felhasznalok kivalasztottfelhasznalo = (felhasznalok)listBox_felhasznalok.SelectedItem;
            cmd.CommandText = "UPDATE `felhasznalo` SET `nev` = @nev, `szuletesidatum` = @szuletesidatum, `profilkepnev`= @profilkepnev WHERE `id` = @id";
            cmd.Parameters.Clear();
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            cmd.Parameters.AddWithValue("@nev", textBox_nev.Text);
            cmd.Parameters.AddWithValue("@szuletesidatum", dateTimePicker_szuletes.Value.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@profilkepnev", textBox_profilnev.Text);
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Az adatok módosítása sikeres volt!!!!");
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                dateTimePicker_szuletes.ResetText();
                textBox_profilnev.Text = "";
                pictureBox_profilkep.Image = null;
                felhasznalo_update();
            }
            else
            {
                MessageBox.Show("Az adatok törlése sikertelen volt!!!!!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (listBox_felhasznalok.SelectedIndex < 0)
            {
                return;
            }
            cmd.CommandText = "DELETE FROM `felhasznalo` WHERE `id` = @id;";
            cmd.Parameters.AddWithValue("@id", textBox_id.Text);
            conn.Open();

            if (cmd.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Az adatok törlése sikeres volt!", "Sikeres!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                conn.Close();
                textBox_id.Text = "";
                textBox_nev.Text = "";
                dateTimePicker_szuletes.ResetText();
                textBox_profilnev.Text = "";
                felhasznalo_update();
            }
            else
            {
                MessageBox.Show("Az adatok törlése sikertelen volt!!!!!!");
            }
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

    }
}
