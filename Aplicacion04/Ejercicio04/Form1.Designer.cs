namespace Ejercicio04
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnAsc = new System.Windows.Forms.RadioButton();
            this.rbtnDesc = new System.Windows.Forms.RadioButton();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.listNum = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.txtNumero);
            this.groupBox1.Location = new System.Drawing.Point(31, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(248, 75);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingresar un nuevo número";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(20, 30);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 0;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(153, 27);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOrdenar);
            this.groupBox2.Controls.Add(this.rbtnDesc);
            this.groupBox2.Controls.Add(this.rbtnAsc);
            this.groupBox2.Location = new System.Drawing.Point(31, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(248, 131);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Orden";
            // 
            // rbtnAsc
            // 
            this.rbtnAsc.AutoSize = true;
            this.rbtnAsc.Location = new System.Drawing.Point(20, 46);
            this.rbtnAsc.Name = "rbtnAsc";
            this.rbtnAsc.Size = new System.Drawing.Size(82, 17);
            this.rbtnAsc.TabIndex = 0;
            this.rbtnAsc.TabStop = true;
            this.rbtnAsc.Text = "Ascendente";
            this.rbtnAsc.UseVisualStyleBackColor = true;
            // 
            // rbtnDesc
            // 
            this.rbtnDesc.AutoSize = true;
            this.rbtnDesc.Location = new System.Drawing.Point(20, 80);
            this.rbtnDesc.Name = "rbtnDesc";
            this.rbtnDesc.Size = new System.Drawing.Size(89, 17);
            this.rbtnDesc.TabIndex = 1;
            this.rbtnDesc.TabStop = true;
            this.rbtnDesc.Text = "Descendente";
            this.rbtnDesc.UseVisualStyleBackColor = true;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(153, 59);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.listNum);
            this.groupBox3.Location = new System.Drawing.Point(301, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(201, 221);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lista de Números";
            // 
            // listNum
            // 
            this.listNum.FormattingEnabled = true;
            this.listNum.Location = new System.Drawing.Point(6, 27);
            this.listNum.Name = "listNum";
            this.listNum.Size = new System.Drawing.Size(189, 186);
            this.listNum.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 303);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Ordenamiento por Burbujeo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.RadioButton rbtnDesc;
        private System.Windows.Forms.RadioButton rbtnAsc;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox listNum;
    }
}

