using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProvaClasse
{
    public partial class AdminScreen : Form
    {
        String coordenada;
        User.User userData = new User.User();
        public AdminScreen()
        {
            InitializeComponent();
            GenerateTableButtons(3,4);


        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void GenerateTableButtons(int columnCount, int rowCount)
        {
            //Creem constructor per RANDOM
            Random rand = new Random();

            //Generar coordenada random
            int random_number = rand.Next(1, 6);
            char random_letter = (char)rand.Next('A', 'D');
            coordenada = random_letter.ToString() + random_number.ToString();
            lbl_codigo.Text = coordenada;

            // ==================================================================
            var lista_numeros = new ArrayList();
            Queue<int> cola_Aleatorio = new Queue<int>();

            for (int i = 0; i <= 9; i++) //Omplim array del 0 al 9 
            {
                lista_numeros.Add(i);
            }

            while (lista_numeros.Count > 0)
            {
                //Creem random del 0 al arlist.count(en aquest cas 9)
                int RandomElement = rand.Next(0, lista_numeros.Count);
                //Treiem de la array i posem a la cua
                int aleatori = (int)lista_numeros[RandomElement];
                cola_Aleatorio.Enqueue(aleatori);
                //Eliminar la posición random
                lista_numeros.RemoveAt(RandomElement);
            }

            // ==================================================================
            // Resetea los estilos
            tb_Buttons.Controls.Clear();
            tb_Buttons.ColumnStyles.Clear();
            tb_Buttons.RowStyles.Clear();

            // Crea la tabla con los numeros que hemos pasado
            tb_Buttons.ColumnCount = columnCount;
            tb_Buttons.RowCount = rowCount;

            int buttoncounter = 0;
            //Agrega columnas
            for (int x = 0; x < columnCount; x++) {
                tb_Buttons.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                //Agrega filas por cada primera columna
                for (int y = 0; y < rowCount; y++) {
                    if (x == 0) {
                        tb_Buttons.RowStyles.Add(new RowStyle(SizeType.AutoSize));
                    }

                    //Agregamos el boton
                    Button btn = new Button();
                    if (x == 0 && y == rowCount-1)
                    {
                        btn.Text = "C";
                        btn.Name = "buttonDelete";
                    } else if (x == 2 && y == rowCount - 1) 
                    {
                        btn.Text = "#";
                        btn.Name = "buttonCorrect";
                    } else
                    {   //Aqui debe ir el codigo del random num
                        //btn.Text = "b" + (buttoncounter).ToString();
                        btn.Text = cola_Aleatorio.Dequeue().ToString();
                        btn.Name = "button" + (buttoncounter).ToString();
                        buttoncounter++;
                    }

                    //Detalles para crear el boton
                    btn.Size = new Size(80, 50);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.MouseOverBackColor = Color.PaleVioletRed;
                    btn.FlatAppearance.MouseDownBackColor = Color.LightSteelBlue;
                    btn.Font = new Font("Microsoft Sans Serif", 15);
                    tb_Buttons.Controls.Add(btn, x, y);
                    btn.Click += new EventHandler(this.ButtonClick);
                    
                }
            }
        }

        void ButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
           
            //Guardo los datos de clicar en una variable de un boton.
            if (btn.Text.Equals("C") || btn.Name.Equals("buttonDelete"))
            {   //Debe permitir borrar la ultima tecla presionada
                int length = mtxt_password.Text.Length;
                if (length >= 1)
                {
                    mtxt_password.Text = mtxt_password.Text.Substring(0, length - 1);
                    
                }

            } else if (btn.Text.Equals("#") || btn.Name.Equals("buttonCorrect"))
            { //Es como el enter, hemos de comprobar si concuerda con el codigo


                //COMPROBAR HACIENDO SELECT A LA BASE DE DATOS
                string valueCoordenada = userData.getValueCoordenada(coordenada);
                if (mtxt_password.Text.Equals(valueCoordenada))
                {
                    //MessageBox.Show("CORRECTO");
                    MenuAdmin menuAdmin = new MenuAdmin();
                    menuAdmin.Show();
                    this.Hide();

                } else
                {
                    MessageBox.Show("INCORRECTO");
                }
            }
            else
            { // VA AGREGANDO AL TEXTO EL VALOR DE CADA BOTON
                mtxt_password.Text = mtxt_password.Text + btn.Text;
              
            }
            

            
        }

        private void tituloMessiAd_Click(object sender, EventArgs e)
        {

        }


        private void lbl_codigo_Click(object sender, EventArgs e)
        {

        }

        private void tb_Buttons_Paint(object sender, PaintEventArgs e)
        {

        }


        
    }
}
