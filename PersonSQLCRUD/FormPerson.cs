using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonSQLCRUD
{
    public partial class FormPerson : Form
    {
        public FormPerson()
        {
            InitializeComponent();
        }

        DataCRUD data = new DataCRUD();
        Person person = new Person();
        int id;
       
        
        private void listOfPerson()
        {
            var Lst = data.Read();
            dataGridPersons.DataSource= Lst;
        }

        private void searchPerson()

        {
            try {
                this.id = Int32.Parse(tBoxId.Text);
                person = data.searchId(id);
                tBoxName.Text = person.First_Name;
                tBoxLastname.Text = person.Last_Name;
                tBoxAge.Text = "" + person.Age;
                showSecretsButtons();
            } catch (Exception ex) {}
            
        }

      
        private void savePerson()
        {
            person.First_Name = tBoxName.Text;
            person.Last_Name = tBoxLastname.Text;
            person.Age = Int32.Parse(tBoxAge.Text);
            data.Create(person);
            clean();
            listOfPerson();
        }
        private void updatePerson()
        {
            person.First_Name = tBoxName.Text;
            person.Last_Name = tBoxLastname.Text;
            person.Age = Int32.Parse(tBoxAge.Text);
            data.Update(person);
            clean();
            showSecretsButtons();
            listOfPerson();

        }

        private void deletePerson()
        {
            data.Delete(this.id);
            showSecretsButtons();
            listOfPerson();
            clean();
        }


        //System Methods
        private void clean()
        {
            tBoxName.Text = "";
            tBoxLastname.Text = "";
            tBoxAge.Text = "";
            tBoxId.Text = "";
            person = new Person();
        }
        private void showSecretsButtons()
        {
            btnSavePerson.Visible = !(btnSavePerson.Visible);
            btnUpdate.Visible = !(btnUpdate.Visible);
            btnDelete.Visible = !(btnDelete.Visible);

        }
        private void btnSavePerson_Click(object sender, EventArgs e)
        { 
            savePerson(); 
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updatePerson();
        }
        private void btnSearchPerson_Click(object sender, EventArgs e)
        {
            searchPerson();
        }
        private void FormPerson_Load(object sender, EventArgs e)
        {
            listOfPerson();
        }
        private void tBoxId_TextChanged(object sender, EventArgs e)
        {
            searchPerson();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            deletePerson();
        }
        private void dataGridPersons_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
