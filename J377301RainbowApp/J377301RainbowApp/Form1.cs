using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;


namespace J377301RainbowApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<rainbow> myFavouriteColorList = new List<rainbow>();
        private void btn_Favourite_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();



            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                string colorName = null;
                string colorCode = null;

                colorName = colorDlg.Color.Name;
                colorCode = (colorDlg.Color.ToArgb() & 0x00FFFFFF).ToString("X6");

                rainbow myFavouriteColor = new rainbow();
                myFavouriteColor.name = colorDlg.Color.Name;
                myFavouriteColor.hexcode = (colorDlg.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                myFavouriteColorList.Add(myFavouriteColor);


                favColorList.Items.Add(myFavouriteColor.name);

                // Display colours in a Listbox on the screen
                ListBox lb = new ListBox();
                foreach (var items in myFavouriteColorList) // implicitly defined datatype for variable dic
                {
                    System.Diagnostics.Debug.WriteLine("colour key is " + items.name);
                    System.Diagnostics.Debug.WriteLine("colour hexcode is " + items.hexcode);
                    string hex = "#" + items.hexcode;

                    lb.Items.Add(items.name);
                    Color dicColor = ColorTranslator.FromHtml(hex);
                    lb.BackColor = dicColor;
                }
                flowLayoutPanelColors.Controls.Add(lb);

            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //Convert To Json
            string output = JsonConvert.SerializeObject(myFavouriteColorList);
            labelJsonString.Text = output;

            //write list to file
            System.IO.File.WriteAllText(@"C:\Users\Shermayne\Desktop\J377301RainbowApp\path.txt", output);

            rainbow[] myColours = JsonConvert.DeserializeObject<rainbow[]>(output);
        }
    }
}
