using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Text.RegularExpressions;



namespace PlantCare2._0
{
    delegate void LogEventHandler(string bericht);
    public partial class HomepageForm : Form
    {
        public HomepageForm()
        {
            InitializeComponent();
        }

       public static void BerichtNaarGebruiker(string bericht)
        {
            MessageBox.Show(bericht + LoginForm.SetWelcome);
        }

        DataClasses1DataContext db = new DataClasses1DataContext();
        List<string> takenlijst = new List<string>();
        int waterhoeveelheid = 0;

        private void btAddPlant_Click_1(object sender, EventArgs e)
        {
            int teller = 0;
            var plantname = tbPlantName.Text;
            var creationdate = DateTime.Now;
            //creationdate kan aangepast worden om de werking te controleren. 
           // var creationdate = DateTime.Now.AddDays(-15);
            var sunlight = lbSunlight.GetItemText(lbSunlight.SelectedItem);
            switch (sunlight)
            {
                case "No sunlight":
                    sunlight = "1";
                    break;
                case "Indirect sunlight":
                    sunlight = "2";
                    break;
                case "Direct sunlight":
                    sunlight = "3";
                    break;
                default:
                    sunlight = "1";
                    break;
            }
            var water = nuWaterQuantity.Value.ToString();

            var placing = lbPlacing.GetItemText(lbPlacing.SelectedItem);
            switch (placing)
            {
                case "Inside":
                    placing = "1";
                    break;
                case "Outside":
                    placing = "2";
                    break;
                default:
                    placing = "1";
                    break;
            }

            var pl = new Plant
            {
                PlantName = Regex.Replace((plantname.ToLower()).Trim(), " +", ""),
                WaterQuantity = int.Parse(water),
                Place = int.Parse(placing),
                Sunlight = int.Parse(sunlight),
                CreationDate = creationdate,
            };


            db.Plants.InsertOnSubmit(pl);
            db.SubmitChanges();
            teller++;
            MessageBox.Show("Plant submitted successfully");
            loadData();

            //hieronder wordt de Owners table opgevuld met 1. de plantid van de hierboven toegevoegde plan en 2. de userid van de ingelogde user
            int digit = 0;
            var query = from s in db.Users where s.UserName == LoginForm.SetWelcome select s.UserId;
            foreach (var item in query)
            {
                digit = item;
            }

            var own = new Owner
            {
                PlantId = pl.PlantId,
                UserId = digit,
            };


            //db.Owners.InsertOnSubmit(own);

            //db.SubmitChanges();
            //loadData2();

            tbPlantName.Clear();
            lbSunlight.ClearSelected();
            lbPlacing.ClearSelected();
            nuWaterQuantity.Value = 0;

            
        }
        private void btGoToUpdate_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
            UpdateForm updateform = new UpdateForm();
            updateform.ShowDialog();
        }
        void loadData()
        {
            var pl = from s in db.Plants select s;
            plantsDataGridView.DataSource = pl;
        }

        void loadData2()
        {
            var own = from s in db.Owners select s;
            //ownersDataGridView.DataSource = own;
        }

        private void plantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBPlantCareDataSet);

        }



        private void HomepageForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPlantCareDataSet.Owners' table. You can move, or remove it, as needed.
            this.ownersTableAdapter.Fill(this.dBPlantCareDataSet.Owners);
            // TODO: This line of code loads data into the 'dBPlantCareDataSet.Plants' table. You can move, or remove it, as needed.
            this.plantsTableAdapter.Fill(this.dBPlantCareDataSet.Plants);
            Welkomslabel.Text = "Welcome to your homepage " + LoginForm.SetWelcome;

            MessageOnLog gebeurtenis = new MessageOnLog();

            gebeurtenis.Login += new LogEventHandler(BerichtNaarGebruiker);

            gebeurtenis.PressButton();
        }

       

        private void btShow_Click_1(object sender, EventArgs e)
        {
           
            var query = from s in db.Plants select new { s.WaterQuantity, s.PlantName, s.CreationDate };
            
            foreach (var item in query)
            {
                int teller = 0;
                TimeSpan interval = DateTime.Now - item.CreationDate;
                int days = interval.Days;
                switch (days)
                {
                    case int expression when days < 7:
                        teller = 0;
                        break;
                    case int expression when days < 14:
                        teller = 1;
                        break;
                    case int expression when days < 21:
                        teller = 2;
                        break;
                    case int expression when days < 28:
                        teller = 3;
                        break;
                    case int expression when days >= 28:
                        teller = 4;
                        break;
                    default:
                        teller = 4;
                        break;
                }

                //if (item.WaterQuantity != 0 && item.CreationDate < DateTime.Now.AddDays(-7).Date)
                if (item.WaterQuantity != 0 && teller != 4 && teller !=0)
                {
                    
                    string task = item.PlantName + " needs " + (item.WaterQuantity*teller) + " cl of water";
                    takenlijst.Add(task);   
                    checkedListBox2.Items.Add(task);

                }
                else if(teller != 0)
                {
                    string task = item.PlantName + " hasn't received water in 4 or more weeks! Give your plant "+ (item.WaterQuantity * teller) + " cl of water immediately!";
                    takenlijst.Add(task);
                    checkedListBox2.Items.Add(task);
                }
                else
                {
                    MessageBox.Show("Your plants currently don't need any water");
                }
            }

            btShow.Enabled = false;
            btShow.BackColor = Color.OrangeRed;

            btComplete.Enabled = true;
            btComplete.BackColor = Color.LimeGreen;
        }

        private void btComplete_Click(object sender, EventArgs e)
        {
            checkedListBox2.Items.Clear();
            btShow.Enabled = true;
            btShow.BackColor = Color.LimeGreen;

            btComplete.Enabled = false;
            btComplete.BackColor = Color.OrangeRed;

        }
        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string item = checkedListBox2.SelectedItem.ToString();
            int index = checkedListBox2.FindString(item);
            if (index == -1)
            {
                MessageBox.Show("Item is not available in ListBox2");
            }
            else
            {
                int plaats = item.IndexOf(" ");
                string naam = item.Substring(0, plaats);
                //vind record van plant met naam
                var query = from s in db.Plants where s.PlantName == naam select s;
                //checkedListBox2.Items.RemoveAt(index);
                foreach (Plant s in query)
                {
                    s.CreationDate = DateTime.Now;
                    db.SubmitChanges();
                }
            }
            
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightGreen;
        }

        private void yellowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightYellow;

        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightBlue;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.LightPink;
        }

       
    }
}
