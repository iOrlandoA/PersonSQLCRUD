using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

namespace PersonSQLCRUD
{
    class DataCRUD
    {
        PersonAPIEntities db;

        public void Create(Person newPerson)
        {
            
            try {
                using (db = new PersonAPIEntities())
                {
                    db.Person.Add(newPerson);
                    db.SaveChanges();

                }

            } catch (Exception ex) {
                    MessageBox.Show(ex.Message);
            }
        }

        public void Update(Person uPerson)
        {

            try
            {
                using (db = new PersonAPIEntities())
                {
                    db.Entry(uPerson).State = EntityState.Modified;
                    db.SaveChanges();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }



        }

        public List<Person> Read()
        {
            try
            {
                using (db=new PersonAPIEntities())
                {
                    return db.Person.ToList();
                }

            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return null;
            }


        }

        public void Delete(int personId)
        {
            try
            {
                using (db= new PersonAPIEntities()){
                    db.Person.Remove(db.Person.Single
                        (p => p.Id == personId));
                    db.SaveChanges();
                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        public Person searchId(int personId)
        {
            try 
            {
                using (db = new PersonAPIEntities())
                {
                    return db.Person.Where(p => p.Id == personId).Single();
                }
            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }


    }
}
