using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Control_Library;

namespace ProvaClasse
{
    public partial class AdminCoordScreen : BaseForm
    {
        private Database.SqlDatabase database;
        String query;
        DataManagement.StringData StringData = new DataManagement.StringData();
        DataManagement.intData intData = new DataManagement.intData();

        Dictionary<string, string> coordenades = new Dictionary<string, string>();
        
        public AdminCoordScreen()
        {
            InitializeComponent();
            //FillLabels();

           
            //foreach (KeyValuePair<string, string> kvp in coordenades)
            //    Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);


        }

        private void AdminCoordScreen_Load(object sender, EventArgs e)
        {

        }

        private void tbl_Coord_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FillLabels()
        {
            String letra = "";   
            
            //HORIZONTAL
            for (int i = 1; i < 6; i++)
            {
                //Agregamos el Label
                Label lbl = new Label();
                //Detalles para crear el Label
                lbl.Font = new Font("Impact", 18);
                lbl.ForeColor = Color.FromArgb(248, 220, 51);
                lbl.Text = i.ToString();
                lbl.Name = "lbl_Coord" + i.ToString();
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Fill;
                tbl_Coord.Controls.Add(lbl, i, 0);
            }
            
            //VERTICAl
            for (int i = 1; i < 5; i++)
            {

                switch (i)
                {
                    case 1:
                        letra= "A";
                        break;
                    case 2:
                        letra = "B";
                        break;
                    case 3:
                        letra = "C";
                        break;
                    case 4:
                        letra = "D";
                        break;
                    default:
                        break;
                }

                //Agregamos el Label
                Label lbl = new Label();
                //Detalles para crear el Label
                lbl.Font = new Font("Impact", 18);
                lbl.ForeColor = Color.FromArgb(248, 220, 51);
                lbl.Text = letra;
                lbl.Name = "lbl_Coord" + letra;
                lbl.TextAlign = ContentAlignment.MiddleCenter;
                lbl.Dock = DockStyle.Fill;
                tbl_Coord.Controls.Add(lbl, 0, i);
            }

            
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            coordenades.Clear();
            coordenades = GenerateCoordenades(coordenades);
            //Subir las coordenadas por primera vez
            //UploadCoordinates(coordenades);


            //Update de las coordenadas
            UpdateCoordinates(coordenades);
            tbl_Coord.Controls.Clear();

        }

        private void FillContent(Dictionary <string, string > coordenades)
        {

            int contador = 0;
            for (int i = 1; i < 6; i++)
            {

                for (char ch = 'A'; ch <= 'D'; ++ch)
                {
                    //Agregamos el Label
                    Label lbl = new Label();
                    //Detalles para crear el Label
                    lbl.Font = new Font("Impact", 18);
                    lbl.ForeColor = Color.White;
                    lbl.Text = coordenades.ElementAt(contador).Value;
                    lbl.BackColor = Color.FromArgb(100, 62, 62, 66);
                    lbl.Name = "lbl_Content_" + ch.ToString() + i.ToString();
                    lbl.TextAlign = ContentAlignment.MiddleCenter;
                    lbl.Dock = DockStyle.Fill;
                    tbl_Coord.Controls.Add(lbl, i, ch-64);
                    contador++;
                }
                
            }
        }

        private void btn_Show_Click(object sender, EventArgs e)
        {
            tbl_Coord.Controls.Clear();
            FillLabels();
            if (coordenades.Count > 0)
            {
                FillContent(coordenades);
            }
        }



        private Dictionary<string, string> GenerateCoordenades(Dictionary<string, string> dic_coordenadas)
        {

            int numberRandom;
            String numberString;
            Boolean repeatednumber = false;


            for (int i = 1; i < 6; i++)
            {

                for (char ch = 'A'; ch <= 'D'; ++ch)
                {
                    
                    do
                    {
                        numberRandom = intData.GenerateRandom(0, 9999);
                        numberString = StringData.FillIntChar(numberRandom, 4, "0");
                        repeatednumber = dic_coordenadas.ContainsValue(numberString);
             
                    } while (repeatednumber);
                    
                    String _keytotal = ch.ToString() + i.ToString();
                    dic_coordenadas.Add(_keytotal, numberString);

                }

            }

            return dic_coordenadas;
        }


        private void UploadCoordinates(Dictionary<string, string> dic_coordenadas)
        {
            //Upload coordinates for the first time from the Dictionary
            
            
            this.database = new Database.SqlDatabase("DarkCore");


            for (int index = 0; index < dic_coordenadas.Count; index++)
            {
                var item = dic_coordenadas.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;

                query = "INSERT INTO AdminCoordinates(Coordinate, Value) VALUES('" + itemKey + "','" + itemValue + "');";
                database.executa(query);
            }
        }


        private void UpdateCoordinates(Dictionary<string, string> dic_coordenadas)
        {
            //UPDATE coordinates for the first time from the Dictionary
            this.database = new Database.SqlDatabase("DarkCore");


            for (int index = 0; index < dic_coordenadas.Count; index++)
            {
                var item = dic_coordenadas.ElementAt(index);
                var itemKey = item.Key;
                var itemValue = item.Value;

                query = "UPDATE AdminCoordinates SET value = '"+ itemValue + "' WHERE Coordinate = '"+ itemKey + "';";
                database.executa(query);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuAdmin menuAdmin = new MenuAdmin();
            menuAdmin.Show();
            this.Close();
        }
    }
}
