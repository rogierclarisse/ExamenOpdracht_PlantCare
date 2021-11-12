using PlantCare2._0.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PlantCare2._0
{
    public partial class UpdateForm : Form
    {
        public UpdateForm()
        {
            InitializeComponent();
        }
        

        DataClasses1DataContext db = new DataClasses1DataContext();
        private void btUpdatePlant_Click(object sender, EventArgs e)
        {
            var query = from s in db.Plants where s.PlantId == int.Parse(tbPlantToUpdate.Text) select s;

            //var query2 = db.Users.First(i => i.UserId == int.Parse(tbPlantToUpdate.Text));
            var plantname = tbPlantName2.Text;

            var sunlight = lbSunlight2.GetItemText(lbSunlight2.SelectedItem);
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
            var water = nuWaterQuantity2.Value.ToString();

            var placing = lbPlacing2.GetItemText(lbPlacing2.SelectedItem);
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

            if (query != null)
            {
                foreach (Plant s in query)
            {
                s.PlantName = Regex.Replace((plantname.ToLower()).Trim(), " +", "");
                s.WaterQuantity = int.Parse(water);
                s.Place = int.Parse(placing);
                s.Sunlight = int.Parse(sunlight);

                db.SubmitChanges();
                MessageBox.Show("Plant successfully updated");
            }
            }
            else
            {
                MessageBox.Show("No plant was found, please enter a correct PlantId");
            }

            
            HomepageForm newOpen = new HomepageForm();
            newOpen.Show();
            
            

        }

        private void plantsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.plantsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dBPlantCareDataSet);

        }

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBPlantCareDataSet.Plants' table. You can move, or remove it, as needed.
            this.plantsTableAdapter.Fill(this.dBPlantCareDataSet.Plants);

        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            var query = from s in db.Plants where s.PlantId == int.Parse(tbPlantToUpdate.Text) select s;

            if (query != null)
            {

                foreach (var item in query)
                {
                    db.Plants.DeleteOnSubmit(item);
                }
                db.SubmitChanges();
                this.Close();
                //HomepageForm newOpen = new HomepageForm();
                //newOpen.ShowDialog();

            }
            else
            {
                MessageBox.Show("No plant with id " + tbPlantToUpdate.Text + " was found");
            }
        }
    }
}
