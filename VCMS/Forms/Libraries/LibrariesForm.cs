using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using VCMS.Library.Models;

namespace VCMS.Forms.Libraries
{
    public partial class LibrariesForm : MaterialForm
    {
        public LibrariesForm()
        {
            InitializeComponent();
        }
        private void DoneButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadView(string desc, ListBox listBox)
        {
            Library.Controller.Libraries lib = new Library.Controller.Libraries();
            List<LibraryModel> libraries = lib.FinstLibrariesByCategory(desc);
            listBox.DataSource = null;
            listBox.DataSource = libraries;
            listBox.DisplayMember = "Description";
            listBox.ValueMember = "ID";
        }

        private void LibrariesForm_Load(object sender, EventArgs e)
        {
            LoadView("Species",speciesList);
            LoadView("Service",servicesList);
        }

        private void AddSpeciesButton_Click(object sender, EventArgs e)
        {
            if (speciesTextbox.Text.Trim() == string.Empty) return;
            Library.Controller.Libraries lib = new Library.Controller.Libraries();
            if (addSpeciesButton.Text == "Save")
            {
                lib.Update(new LibraryModel()
                {
                    ID = int.Parse(speciesList.SelectedValue.ToString()),
                    Category = speciesTextbox.Tag.ToString(),
                    Description = speciesTextbox.Text.ToString()
                });
            }
            else
            {
                lib.Create(new LibraryModel()
                {
                    Category = speciesTextbox.Tag.ToString(),
                    Description = speciesTextbox.Text
                });
            }
            addSpeciesButton.Text = "Add";
            speciesTextbox.Text = string.Empty;
            LoadView("Species", speciesList);
        }
        private void SpeciesList_DoubleClick(object sender, EventArgs e)
        {
            if(breedList.Items.Count > 0)
            {
                System.Windows.MessageBox.Show("Can't edit");
            } 
            else
            {
                speciesTextbox.Text = speciesList.Text;
                addSpeciesButton.Text = "Save";
            }
        }

        private void SpeciesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            breedTextbox.Enabled = true;
            addBreedButton.Enabled = true;
            LoadView(speciesList.Text,breedList);
        }
        private void SpeciesList_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Delete)
            {
                if (breedList.Items.Count > 0)
                {
                    System.Windows.MessageBox.Show("Can't edit");
                    return;
                }
                string message = $"Are you sure to delete {speciesList.Text}?";
                MessageBoxResult x = System.Windows.MessageBox.Show(message, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (x == MessageBoxResult.No) return;
                if (speciesList.SelectedItems.Count > 0)
                {
                    Library.Controller.Libraries lib = new Library.Controller.Libraries();
                    lib.Delete(int.Parse(speciesList.SelectedValue.ToString()));
                }
                LoadView("Species", speciesList);
            }
        }

        private void AddBreedButton_Click(object sender, EventArgs e)
        {
            if (breedTextbox.Text.Trim() == string.Empty) return;
            Library.Controller.Libraries lib = new Library.Controller.Libraries();
            if (addBreedButton.Text == "Save")
            {
                lib.Update(new LibraryModel()
                {
                    ID = int.Parse(breedList.SelectedValue.ToString()),
                    Category = speciesList.Text,
                    Description = breedTextbox.Text.ToString()
                });
            }
            else
            {
                lib.Create(new LibraryModel()
                {
                    Category = speciesList.Text.ToString(),
                    Description = breedTextbox.Text
                });
            }
            addBreedButton.Text = "Add";
            breedTextbox.Text = string.Empty;
            LoadView(speciesList.Text.ToString(), breedList);
        }
        private void BreedList_DoubleClick(object sender, EventArgs e)
        {
            if (speciesList.Items.Count > 0)
            {
                breedTextbox.Text = breedList.Text;
                addBreedButton.Text = "Save";
            }
        }

        private void BreedList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string message = $"Are you sure to delete {breedList.Text}?";
                MessageBoxResult x = System.Windows.MessageBox.Show(message, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (x == MessageBoxResult.No) return;
                if (breedList.SelectedItems.Count > 0)
                {
                    Library.Controller.Libraries lib = new Library.Controller.Libraries();
                    lib.Delete(int.Parse(breedList.SelectedValue.ToString()));
                }
                LoadView(speciesList.Text.ToString(), breedList);
            }
        }

        private void AddServicesButton_Click(object sender, EventArgs e)
        {
            if (servicesTextbox.Text.Trim() == string.Empty) return;
            Library.Controller.Libraries lib = new Library.Controller.Libraries();
            if (addServicesButton.Text == "Save")
            {
                lib.Update(new LibraryModel()
                {
                    ID = int.Parse(servicesList.SelectedValue.ToString()),
                    Category = "Service",
                    Description = servicesTextbox.Text
                });
            }
            else
            {
                lib.Create(new LibraryModel()
                {
                    Category = "Service",
                    Description = servicesTextbox.Text
                });
            }
            addServicesButton.Text = "Add";
            servicesTextbox.Text = string.Empty;
            LoadView("Service", servicesList);
        }

        private void ServicesList_DoubleClick(object sender, EventArgs e)
        {
            if (servicesList.Items.Count > 0)
            {
                servicesTextbox.Text = servicesList.Text;
                addServicesButton.Text = "Save";
            }
        }

        private void ServicesList_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                string message = $"Are you sure to delete {servicesList.Text}?";
                MessageBoxResult x = System.Windows.MessageBox.Show(message, "Question", MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (x == MessageBoxResult.No) return;
                if (servicesList.SelectedItems.Count > 0)
                {
                    Library.Controller.Libraries lib = new Library.Controller.Libraries();
                    lib.Delete(int.Parse(servicesList.SelectedValue.ToString()));
                }
                LoadView("Service", servicesList);
            }
        }
    }
}
