using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.FormIhm
{
    public partial class PIM : Form
    {
        ServiceReferencePim.ServicePimClient proxy = null;

        private PimState state = PimState.Deconnecter;
        private PimState State
        {
            get { return this.state; }
            set { OnPimStateChanged(value); }
        }

        public PIM()
        {
            InitializeComponent();
            this.PimStateChanged += PIM_PimStateChanged;
            proxy = new ServiceReferencePim.ServicePimClient();
        }

        void PIM_PimStateChanged(object sender, PimState state)
        {
            switch (State)
            {
                case PimState.AffichageBagage:
                    AffichageBagage();
                    break;
                case PimState.AttenteBagage:
                    AttenteBagage();
                    break;
                case PimState.CreationBagage:
                    CreationBagage();
                    break;
                case PimState.SelectionBagage:
                    SelectionBagage();
                    break;
                case PimState.Deconnecter:
                    Deconnecter();
                    break;
            }
        }

        public void AffichageBagage()
        {
            this.gbRecherche.Visible =
            this.gbResultat.Visible = true;
            this.tbCompagnie.Enabled =
            this.tbLigne.Enabled =
            this.tbJourExploitation.Enabled =
            this.tbItineraire.Enabled =
            this.tbClasseBagage.Enabled =
            this.cbContinuation.Enabled =
            this.cbPrioritaire.Enabled =
            this.cbRush.Enabled =
            this.btnCreer.Enabled = false;
            this.cbContinuation.Checked =
            this.cbPrioritaire.Checked =
            this.cbRush.Checked = false;
            this.btnRechercher.Enabled = true;
            this.etat.Text = "Affichage Bagage";
        }

        public void AttenteBagage()
        {
            this.tbCompagnie.Text =
            this.tbLigne.Text =
            this.tbJourExploitation.Text =
            this.tbItineraire.Text =
            this.tbClasseBagage.Text = "";
            this.cbRush.Checked =
            this.cbPrioritaire.Checked =
            this.cbContinuation.Checked = false;
            this.gbRecherche.Visible =
            this.gbResultat.Visible = true;
            this.tbCompagnie.Enabled =
            this.tbLigne.Enabled =
            this.tbJourExploitation.Enabled =
            this.tbItineraire.Enabled =
            this.tbClasseBagage.Enabled =
            this.cbContinuation.Enabled =
            this.cbPrioritaire.Enabled =
            this.cbRush.Enabled =
            this.btnCreer.Enabled = false;
            this.cbContinuation.Checked =
            this.cbPrioritaire.Checked =
            this.cbRush.Checked = false;
            this.btnRechercher.Enabled = true;
            this.etat.Text = "Attente Bagage";
        }

        public void CreationBagage()
        {
            this.tbCompagnie.Text =
            this.tbLigne.Text =
            this.tbJourExploitation.Text =
            this.tbItineraire.Text =
            this.tbClasseBagage.Text = "";
            this.cbRush.Checked =
            this.cbPrioritaire.Checked =
            this.cbContinuation.Checked = false;
            this.gbRecherche.Visible =
            this.gbResultat.Visible = true;
            this.tbCompagnie.Enabled =
            this.tbLigne.Enabled =
            this.tbJourExploitation.Enabled =
            this.tbItineraire.Enabled =
            this.tbClasseBagage.Enabled =
            this.cbContinuation.Enabled =
            this.cbPrioritaire.Enabled =
            this.cbRush.Enabled =
            this.btnCreer.Enabled = true;
            this.cbContinuation.Checked =
            this.cbPrioritaire.Checked =
            this.cbRush.Checked = false;
            this.btnRechercher.Enabled = false;
            this.etat.Text = "Creation Bagage";

        }

        public void SelectionBagage()
        {
            this.tbCompagnie.Text =
            this.tbLigne.Text =
            this.tbJourExploitation.Text =
            this.tbItineraire.Text =
            this.tbClasseBagage.Text = "";
            this.cbRush.Checked =
            this.cbPrioritaire.Checked =
            this.cbContinuation.Checked = false;
            this.gbRecherche.Visible =
            this.gbResultat.Visible = true;
            this.btnRechercher.Enabled = true;
            this.etat.Text = "Selection Bagage";
        }

        public void Deconnecter()
        {
            this.tbCompagnie.Text =
            this.tbLigne.Text =
            this.tbJourExploitation.Text =
            this.tbItineraire.Text =
            this.tbClasseBagage.Text = "";
            this.cbRush.Checked =
            this.cbPrioritaire.Checked =
            this.cbContinuation.Checked = false;
            this.gbRecherche.Visible =
            this.gbResultat.Visible = false;
            this.btnRechercher.Enabled = true;
            this.etat.Text = "Déconnecté";
        }

        public event PimStateEventHandler PimStateChanged;
        public delegate void PimStateEventHandler(object sender, PimState state);

        private void OnPimStateChanged(PimState newState)
        {
            if (newState != this.state)
            {
                this.state = newState;
                if (this.PimStateChanged != null)
                {
                    PimStateChanged(this, this.state);
                }
            }
        }

        // Menu
        private void réinitialiserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tbCompagnie.Text =
            this.tbLigne.Text =
            this.tbJourExploitation.Text =
            this.tbItineraire.Text =
            this.tbClasseBagage.Text = "";
            this.cbRush.Checked =
            this.cbPrioritaire.Checked =
            this.cbContinuation.Checked = false;
        }

        //Recherche
        private void search_Click(object sender, EventArgs e)
        {
            if (this.tbCodeIata.Text.Equals(""))
            {
                MessageBox.Show("Rentrer codeIata");
            }
            else
            {
                try
                {
                    Client.FormIhm.ServiceReferencePim.BagageDefinition Bagage = proxy.GetBagageByCodeIataAsync(this.tbCodeIata.Text).Result;
                    if (Bagage != null)
                    {
                        OnPimStateChanged(PimState.AffichageBagage);
                        this.tbCompagnie.Text = Bagage.Compagnie.ToString();
                        this.tbLigne.Text = Bagage.Ligne.ToString();
                        this.tbJourExploitation.Text = Bagage.DateVol.ToString();
                        this.tbItineraire.Text = Bagage.Itineraire.ToString();
                        this.tbClasseBagage.Text = Bagage.Classe.ToString();
                        this.cbContinuation.Checked = Bagage.EnContinuation;
                        this.cbPrioritaire.Checked = Bagage.Prioritaire;
                        this.cbRush.Checked = Bagage.Rush;
                    }
                }
                catch (AggregateException exception)
                {
                    this.listBoxLogs.Items.Clear();
                    this.listBoxLogs.Items.Add("Serveur non disponible");
                }

                catch (EndpointNotFoundException exp)
                {
                    this.listBoxLogs.Items.Clear();
                    this.listBoxLogs.Items.Add("WebService non disponible");
                }
                catch (FaultException excp)
                {
                    this.listBoxLogs.Items.Clear();
                    this.listBoxLogs.Items.Add("Une erreur s'est produite dans le traitement de votre demande");
                    this.listBoxLogs.Items.Add("\tCode: " + excp.Code.Name);
                    this.listBoxLogs.Items.Add("\tReason: " + excp.Reason);

                }
            }
        }
        

        private void affichageBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPimStateChanged(PimState.AffichageBagage);
        }

        private void attenteBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPimStateChanged(PimState.AttenteBagage);
        }

        private void créationBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPimStateChanged(PimState.CreationBagage);
        }

        private void selectionBagageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPimStateChanged(PimState.AffichageBagage);
        }

        private void deconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnPimStateChanged(PimState.Deconnecter);
        }

        private void btnCreer_Click(object sender, EventArgs e)
        {
            Client.FormIhm.ServiceReferencePim.BagageDefinition bag = new Client.FormIhm.ServiceReferencePim.BagageDefinition();

            bag.CodeIata = this.tbCodeIata.Text;
            bag.Compagnie = this.tbCompagnie.Text;
            bag.Ligne = this.tbLigne.Text;
            bag.Itineraire = this.tbItineraire.Text;
            bag.Classe = this.tbClasseBagage.Text;

            if (this.cbContinuation.Checked == true)
                bag.EnContinuation = true;
            else
                bag.EnContinuation = false;

            if (this.cbPrioritaire.Checked == true)
                bag.Prioritaire = true;
            else
                bag.Prioritaire = false;

            if (this.cbRush.Checked == true)
                bag.Rush = true;
            else
                bag.Rush = false;

            int res = proxy.CreateBagage(bag);
            this.listBoxLogs.Items.Clear();
            this.listBoxLogs.Items.Add("Bagage " + bag.CodeIata + " Crée");
            OnPimStateChanged(PimState.SelectionBagage);
        }
    }
}
