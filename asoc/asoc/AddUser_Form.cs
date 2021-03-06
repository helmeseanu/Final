﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace asoc
{
    public partial class AddUser_Form : Form
    {
        private string _nume;
        private string _prenume;
        private string _numar_telefon;
        private string _email;
        private string _functie;
        private string _data_inscriere;

        public AddUser_Form()
        {
            InitializeComponent();
        }

        private void Button_AddClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ListBox_SelectPropritate_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string curItem = listBox_SelectPropritate.SelectedItem.ToString();

                int index = listBox_SelectPropritate.FindString(curItem);

                switch (curItem)
                {
                    case "Nume":
                        {
                            _nume = textBox_Data.Text;      

                            break;
                        }
                    case "Prenume":
                        {
                            _prenume = textBox_Data.Text;

                            break;
                        }
                    case "Numar Telefon":
                        {
                            _numar_telefon = textBox_Data.Text;

                            break;
                        }
                    case "Email":
                        {
                            _email = textBox_Data.Text;

                            break;
                        }
                    case "Functie":
                        {
                            _functie = textBox_Data.Text;

                            break;
                        }
                    case "Data Inscrierii":
                        {
                            _data_inscriere = textBox_Data.Text;

                            break;
                        }
                    default:
                        {
                            MessageBox.Show("Error!");
                            break;
                        }
                }

                textBox_Data.Clear();
            }
            catch
            {
                MessageBox.Show("Select an Item");
            }
        }

        private void Button_AddOk_Click(object sender, EventArgs e)
        {
            try
            {
                var context = new Asociatie_ProprietariEntities();

                var newCategory = new Membri_Asociatie()
                {
                    Nume = _nume,
                    Prenume = _prenume,
                    Numar_telefon = _numar_telefon,
                    Emai = _email,
                    Functie = _functie,
                    Data_Inscriere = DateTime.Parse(_data_inscriere)
                };

                context.Membri_Asociatie.Add(newCategory);

                context.SaveChanges();
            }
            catch (Exception ex)
            {
                File.AppendAllText("errors.txt", "Message :" + ex.Message + "<br/>" + Environment.NewLine + "StackTrace :" + ex.StackTrace + "" + Environment.NewLine + "Date :" + DateTime.Now.ToString());
                string New = Environment.NewLine + "-----------------------------------------------------------------------------" + Environment.NewLine;
                File.AppendAllText("errors.txt", New);
                MessageBox.Show("Eroare de contectare la server");
            }
        }
    }
}
