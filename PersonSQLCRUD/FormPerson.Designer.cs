
namespace PersonSQLCRUD
{
    partial class FormPerson
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxAge = new System.Windows.Forms.TextBox();
            this.btnSavePerson = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.tBoxLastname = new System.Windows.Forms.TextBox();
            this.lbLastname = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.btnSearchPerson = new System.Windows.Forms.Button();
            this.tBoxId = new System.Windows.Forms.TextBox();
            this.tBoxName = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dataGridPersons = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersons)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxAge
            // 
            this.tBoxAge.Location = new System.Drawing.Point(82, 141);
            this.tBoxAge.Name = "tBoxAge";
            this.tBoxAge.Size = new System.Drawing.Size(100, 20);
            this.tBoxAge.TabIndex = 6;
            // 
            // btnSavePerson
            // 
            this.btnSavePerson.Location = new System.Drawing.Point(213, 141);
            this.btnSavePerson.Name = "btnSavePerson";
            this.btnSavePerson.Size = new System.Drawing.Size(75, 23);
            this.btnSavePerson.TabIndex = 5;
            this.btnSavePerson.Text = "Save";
            this.btnSavePerson.UseVisualStyleBackColor = true;
            this.btnSavePerson.Click += new System.EventHandler(this.btnSavePerson_Click);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Location = new System.Drawing.Point(13, 64);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(35, 13);
            this.Name.TabIndex = 7;
            this.Name.Text = "Name";
            // 
            // tBoxLastname
            // 
            this.tBoxLastname.Location = new System.Drawing.Point(82, 103);
            this.tBoxLastname.Name = "tBoxLastname";
            this.tBoxLastname.Size = new System.Drawing.Size(100, 20);
            this.tBoxLastname.TabIndex = 8;
            // 
            // lbLastname
            // 
            this.lbLastname.AutoSize = true;
            this.lbLastname.Location = new System.Drawing.Point(13, 103);
            this.lbLastname.Name = "lbLastname";
            this.lbLastname.Size = new System.Drawing.Size(53, 13);
            this.lbLastname.TabIndex = 9;
            this.lbLastname.Text = "Lastname";
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Location = new System.Drawing.Point(22, 148);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(26, 13);
            this.lbAge.TabIndex = 10;
            this.lbAge.Text = "Age";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(12, 190);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(81, 13);
            this.lbId.TabIndex = 14;
            this.lbId.Text = "Identity Number";
            // 
            // btnSearchPerson
            // 
            this.btnSearchPerson.Location = new System.Drawing.Point(213, 190);
            this.btnSearchPerson.Name = "btnSearchPerson";
            this.btnSearchPerson.Size = new System.Drawing.Size(75, 23);
            this.btnSearchPerson.TabIndex = 15;
            this.btnSearchPerson.Text = "Search";
            this.btnSearchPerson.UseVisualStyleBackColor = true;
            this.btnSearchPerson.Click += new System.EventHandler(this.btnSearchPerson_Click);
            // 
            // tBoxId
            // 
            this.tBoxId.Location = new System.Drawing.Point(99, 187);
            this.tBoxId.Name = "tBoxId";
            this.tBoxId.Size = new System.Drawing.Size(83, 20);
            this.tBoxId.TabIndex = 16;
            this.tBoxId.TextChanged += new System.EventHandler(this.tBoxId_TextChanged);
            // 
            // tBoxName
            // 
            this.tBoxName.Location = new System.Drawing.Point(82, 64);
            this.tBoxName.Name = "tBoxName";
            this.tBoxName.Size = new System.Drawing.Size(100, 20);
            this.tBoxName.TabIndex = 17;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(213, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Visible = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 161);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dataGridPersons
            // 
            this.dataGridPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridPersons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridPersons.Location = new System.Drawing.Point(464, 141);
            this.dataGridPersons.Name = "dataGridPersons";
            this.dataGridPersons.Size = new System.Drawing.Size(305, 150);
            this.dataGridPersons.TabIndex = 20;
            // 
            // FormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridPersons);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tBoxName);
            this.Controls.Add(this.tBoxId);
            this.Controls.Add(this.btnSearchPerson);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbLastname);
            this.Controls.Add(this.tBoxLastname);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.tBoxAge);
            this.Controls.Add(this.btnSavePerson);
            this.Text = "API Persons";
            this.Load += new System.EventHandler(this.FormPerson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPersons)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBoxAge;
        private System.Windows.Forms.Button btnSavePerson;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TextBox tBoxLastname;
        private System.Windows.Forms.Label lbLastname;
        private System.Windows.Forms.Label lbAge;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Button btnSearchPerson;
        private System.Windows.Forms.TextBox tBoxId;
        private System.Windows.Forms.TextBox tBoxName;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dataGridPersons;
    }
}

