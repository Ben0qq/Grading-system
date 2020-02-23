namespace DamianBednarzlab3zadanie
{
    partial class FormAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewAdmin = new System.Windows.Forms.DataGridView();
            this.labelAdmin = new System.Windows.Forms.Label();
            this.buttonInsert = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxDelete = new System.Windows.Forms.TextBox();
            this.labelDelete = new System.Windows.Forms.Label();
            this.textBoxInsertId = new System.Windows.Forms.TextBox();
            this.textBoxInsertGrade = new System.Windows.Forms.TextBox();
            this.textBoxInsertText = new System.Windows.Forms.TextBox();
            this.labelInsertId = new System.Windows.Forms.Label();
            this.labelInsertGrade = new System.Windows.Forms.Label();
            this.labelInsertText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAdmin
            // 
            this.dataGridViewAdmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdmin.Location = new System.Drawing.Point(12, 57);
            this.dataGridViewAdmin.Name = "dataGridViewAdmin";
            this.dataGridViewAdmin.RowTemplate.Height = 24;
            this.dataGridViewAdmin.Size = new System.Drawing.Size(600, 381);
            this.dataGridViewAdmin.TabIndex = 0;
            // 
            // labelAdmin
            // 
            this.labelAdmin.AutoSize = true;
            this.labelAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelAdmin.Location = new System.Drawing.Point(154, 9);
            this.labelAdmin.Name = "labelAdmin";
            this.labelAdmin.Size = new System.Drawing.Size(282, 32);
            this.labelAdmin.TabIndex = 1;
            this.labelAdmin.Text = "Widok administratora";
            // 
            // buttonInsert
            // 
            this.buttonInsert.AutoSize = true;
            this.buttonInsert.Location = new System.Drawing.Point(658, 67);
            this.buttonInsert.Name = "buttonInsert";
            this.buttonInsert.Size = new System.Drawing.Size(98, 27);
            this.buttonInsert.TabIndex = 2;
            this.buttonInsert.Text = "Dodaj ocenę";
            this.buttonInsert.UseVisualStyleBackColor = true;
            this.buttonInsert.Click += new System.EventHandler(this.buttonInsert_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.AutoSize = true;
            this.buttonDelete.Location = new System.Drawing.Point(662, 312);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(94, 27);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Usuń ocenę";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // textBoxDelete
            // 
            this.textBoxDelete.Location = new System.Drawing.Point(658, 396);
            this.textBoxDelete.Name = "textBoxDelete";
            this.textBoxDelete.Size = new System.Drawing.Size(100, 22);
            this.textBoxDelete.TabIndex = 4;
            // 
            // labelDelete
            // 
            this.labelDelete.AutoSize = true;
            this.labelDelete.Location = new System.Drawing.Point(655, 358);
            this.labelDelete.Name = "labelDelete";
            this.labelDelete.Size = new System.Drawing.Size(107, 17);
            this.labelDelete.TabIndex = 5;
            this.labelDelete.Text = "Podaj ID oceny:";
            // 
            // textBoxInsertId
            // 
            this.textBoxInsertId.Location = new System.Drawing.Point(732, 141);
            this.textBoxInsertId.Name = "textBoxInsertId";
            this.textBoxInsertId.Size = new System.Drawing.Size(56, 22);
            this.textBoxInsertId.TabIndex = 7;
            // 
            // textBoxInsertGrade
            // 
            this.textBoxInsertGrade.Location = new System.Drawing.Point(732, 192);
            this.textBoxInsertGrade.Name = "textBoxInsertGrade";
            this.textBoxInsertGrade.Size = new System.Drawing.Size(56, 22);
            this.textBoxInsertGrade.TabIndex = 8;
            // 
            // textBoxInsertText
            // 
            this.textBoxInsertText.Location = new System.Drawing.Point(732, 240);
            this.textBoxInsertText.Name = "textBoxInsertText";
            this.textBoxInsertText.Size = new System.Drawing.Size(56, 22);
            this.textBoxInsertText.TabIndex = 9;
            // 
            // labelInsertId
            // 
            this.labelInsertId.AutoSize = true;
            this.labelInsertId.Location = new System.Drawing.Point(623, 144);
            this.labelInsertId.Name = "labelInsertId";
            this.labelInsertId.Size = new System.Drawing.Size(103, 17);
            this.labelInsertId.TabIndex = 10;
            this.labelInsertId.Text = "Id użytkownika:";
            // 
            // labelInsertGrade
            // 
            this.labelInsertGrade.AutoSize = true;
            this.labelInsertGrade.Location = new System.Drawing.Point(623, 192);
            this.labelInsertGrade.Name = "labelInsertGrade";
            this.labelInsertGrade.Size = new System.Drawing.Size(54, 17);
            this.labelInsertGrade.TabIndex = 11;
            this.labelInsertGrade.Text = "Ocena:";
            // 
            // labelInsertText
            // 
            this.labelInsertText.AutoSize = true;
            this.labelInsertText.Location = new System.Drawing.Point(623, 243);
            this.labelInsertText.Name = "labelInsertText";
            this.labelInsertText.Size = new System.Drawing.Size(78, 17);
            this.labelInsertText.TabIndex = 12;
            this.labelInsertText.Text = "Podaj opis:";
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInsertText);
            this.Controls.Add(this.labelInsertGrade);
            this.Controls.Add(this.labelInsertId);
            this.Controls.Add(this.textBoxInsertText);
            this.Controls.Add(this.textBoxInsertGrade);
            this.Controls.Add(this.textBoxInsertId);
            this.Controls.Add(this.labelDelete);
            this.Controls.Add(this.textBoxDelete);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonInsert);
            this.Controls.Add(this.labelAdmin);
            this.Controls.Add(this.dataGridViewAdmin);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdmin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAdmin;
        private System.Windows.Forms.Label labelAdmin;
        private System.Windows.Forms.Button buttonInsert;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxDelete;
        private System.Windows.Forms.Label labelDelete;
        private System.Windows.Forms.TextBox textBoxInsertId;
        private System.Windows.Forms.TextBox textBoxInsertGrade;
        private System.Windows.Forms.TextBox textBoxInsertText;
        private System.Windows.Forms.Label labelInsertId;
        private System.Windows.Forms.Label labelInsertGrade;
        private System.Windows.Forms.Label labelInsertText;
    }
}