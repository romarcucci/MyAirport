using System;
using System.Windows.Forms;

namespace Client.FormIhm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        private void idBagage_Click(object sender, EventArgs e)
        {
            /*Int32 id = 24454118;
            var bagage = MyAirport.Pim.Models.Factory.Model.GetBagage(id);
            if (bagage == null)
            {
                MessageBox.Show("fail");
            }
            else
            {
                MessageBox.Show("IdBagage: " + bagage.IdBagage + "\nCode Iata: " + bagage.CodeIata);
            }*/
        }
        private void iataCode_Click(object sender, EventArgs e)
        {
            /*String id = "015730437700";
            var bagage = MyAirport.Pim.Models.Factory.Model.GetBagage(id);
            if (bagage == null)
            {
                MessageBox.Show("fail");
            }
            else
            {
                MessageBox.Show("IdBagage: " + bagage[0].IdBagage + "\nCode Iata: " + bagage[0].CodeIata);
            }*/
        }
    }
}
