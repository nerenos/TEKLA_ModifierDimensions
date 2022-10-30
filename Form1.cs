using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tekla.Structures.Model;
using TSG3D = Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.UI;
using Tekla.Structures.Geometry3d;
using Tekla.Structures.Model.Operations;


namespace TEKLA_ModifierDimensions
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void MyChecked(object sender, EventArgs e)
        {
            if (cbHauteur.Checked == true)
            {
                cbHauteur.Checked = false;
                cbLargeur.Checked = false;
            }
            else
            {
                cbHauteur.Checked = true;
                cbLargeur.Checked = true;
            }
        }
        private void MyDimModify(object sender, EventArgs e)
        {
            Tekla.Structures.Model.UI.ModelObjectSelector selector = new Tekla.Structures.Model.UI.ModelObjectSelector();
            ModelObjectEnumerator objects = selector.GetSelectedObjects();
            string nObjects = objects.GetSize().ToString();
            Operation.DisplayPrompt(nObjects);
            objects.Reset();
            while (objects.MoveNext())
            {
                Part myPart = objects.Current as Part;
                if (myPart != null)
                {
                    string oldProfil = myPart.Profile.ProfileString;
                    string[] tabProfil = oldProfil.Split('*');
                    if (tabProfil.Length > 1 && cbHauteur.Checked == true && this.txbHauteur.Text != "0")
                    {
                        string myProfil = this.txbHauteur.Text + '*' + tabProfil[1];
                        myPart.Profile.ProfileString = myProfil;
                        myPart.Modify();
                    }
                    if (tabProfil.Length > 0 && cbLargeur.Checked == true && this.txbLargeur.Text != "0")
                    {
                        string myProfil = tabProfil[0] + '*' + this.txbLargeur.Text;
                        myPart.Profile.ProfileString = myProfil;
                        myPart.Modify();
                    }

                }
            }

            Model myModel = new Model();
            myModel.CommitChanges();


        }

        private void ButAnnuler_Click(object sender, EventArgs e)
        {
            closeAPP();
        }

        public void closeAPP()
        {
            if (!this.Created)
            {
                Timer oTimer = new Timer();
                oTimer.Tick += delegate { this.closeAPP(); };
                oTimer.Interval = 500;
                oTimer.Start();
                return;
            }
            this.Dispose();
            this.Close();
            Application.ExitThread();
            Application.Exit();
        }

        private void ButOk_Click(object sender, EventArgs e)
        {
            closeAPP();
        }
    }
}
