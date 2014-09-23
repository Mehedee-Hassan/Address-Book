using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSVLib;

namespace Address_Book
{
    public partial class AddressBookForm : Form
    {
        public AddressBookForm()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        string fileLocation = @"personData.csv";
        private void showButton_Click(object sender, EventArgs e)
        {
            FileStream aStream = new FileStream(fileLocation, FileMode.OpenOrCreate);
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aPeronRecord = new List<string>();


            personListView.Items.Clear();



            while (aReader.ReadRow(aPeronRecord))
            {
                ListViewItem listViewItem = new ListViewItem(new string[]
                {
                    aPeronRecord[0],
                    aPeronRecord[1],
                    aPeronRecord[2],
                    aPeronRecord[3],
                    aPeronRecord[4]
                
                }
            );
                personListView.Items.Add(listViewItem);
            }
            aStream.Close();
        }



        private void saveButton_Click(object sender, EventArgs e)
        {

            if(nameTextBox.Text =="" || personalCnTextBox.Text == "" ||
                homeAddressTextBox.Text == "" || 
                homeAddressTextBox.Text == ""
                )
            {
                MessageBox.Show("Entries Cannot Be Empty");
                return;
            }


            FileStream aStream = new FileStream(fileLocation, FileMode.OpenOrCreate);
           
            CsvFileReader aReader = new CsvFileReader(aStream);
            List<string> aPeronRecord = new List<string>();


            //personListView.Items.Clear();

            //checking for the first time

            if (new FileInfo(fileLocation).Length != 0)
            {
                while (aReader.ReadRow(aPeronRecord))
                {
                    if (aPeronRecord[2] == personalCnTextBox.Text)
                    {
                        MessageBox.Show("conflict");

                        aStream.Close();
                        return;
                    }
                }
                aStream.Close();

            }
            

            aStream.Close();



            FileStream aStream2 = new FileStream(fileLocation, FileMode.Append);
            CsvFileWriter aWriter = new CsvFileWriter(aStream2);
            List<string> aPersonRecod = new List<string>();

            aPersonRecod.Add(nameTextBox.Text);
            aPersonRecod.Add(emailTextBox.Text);
            aPersonRecod.Add(personalCnTextBox.Text);
            aPersonRecod.Add(homeCnTextBox.Text);
            aPersonRecod.Add(homeAddressTextBox.Text);

            aWriter.WriteRow(aPersonRecod);

            aStream2.Close();

            
                    


        }

        private void searchButton_Click(object sender, EventArgs e)
        {

           // personListView
            ListViewItem listViewItem = new ListViewItem();
            //ListViewItem[] listViewItems = personListView.Items.Find(searchTextBox.Text,false);

            //if (listViewItems.Length != 0)
            //{

            //}



            listViewItem = personListView.FindItemWithText(searchTextBox.Text);

            


            if(listViewItem != null)
            {
                MessageBox.Show("Item Found !!! \n\n---------\n"
                 +"Name :"+listViewItem.Text+" \n"+
                 "Email :"+listViewItem.SubItems[1].Text+"\n"+
                 "Personal Contac No :"+listViewItem.SubItems[2].Text+"\n"+
                 "Home Contact No :"+listViewItem.SubItems[3].Text+"\n"+
                 "Address :"+listViewItem.SubItems[4].Text);
            }
            else
            {
                MessageBox.Show("Sorry,\nItem Not Found\nOn\nAddress Book   ");
            }


        }

        private void searchByComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchButton.Enabled = true;
            searchTextBox.Enabled = true;
            enterValueLabel.Text = searchByComboBox.SelectedItem.ToString()+" :" ;

            
        }

        private void AddressBookForm_Load(object sender, EventArgs e)
        {
            searchButton.Enabled = false;
            searchTextBox.Enabled = false;
            enterValueLabel.Text = "";
        }

   

     

     
    }
}
