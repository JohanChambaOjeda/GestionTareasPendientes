namespace GestionTareasPendientes
{
    partial class Form1
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
            this.txtTarea = new System.Windows.Forms.TextBox();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.Tareas1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnElimiarTarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtTarea
            // 
            this.txtTarea.Location = new System.Drawing.Point(40, 107);
            this.txtTarea.Margin = new System.Windows.Forms.Padding(6);
            this.txtTarea.Name = "txtTarea";
            this.txtTarea.Size = new System.Drawing.Size(368, 31);
            this.txtTarea.TabIndex = 0;
            this.txtTarea.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.Location = new System.Drawing.Point(139, 150);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(6);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(169, 35);
            this.btnAgregarTarea.TabIndex = 1;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // Tareas1
            // 
            this.Tareas1.FormattingEnabled = true;
            this.Tareas1.ItemHeight = 24;
            this.Tareas1.Location = new System.Drawing.Point(40, 224);
            this.Tareas1.Margin = new System.Windows.Forms.Padding(6);
            this.Tareas1.Name = "Tareas1";
            this.Tareas1.Size = new System.Drawing.Size(368, 148);
            this.Tareas1.TabIndex = 2;
            this.Tareas1.SelectedIndexChanged += new System.EventHandler(this.Tareas1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(108, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "GestionTareasPendientes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnElimiarTarea
            // 
            this.btnElimiarTarea.Location = new System.Drawing.Point(139, 393);
            this.btnElimiarTarea.Name = "btnElimiarTarea";
            this.btnElimiarTarea.Size = new System.Drawing.Size(169, 34);
            this.btnElimiarTarea.TabIndex = 6;
            this.btnElimiarTarea.Text = "Eliminar Tarea";
            this.btnElimiarTarea.UseVisualStyleBackColor = true;
            this.btnElimiarTarea.Click += new System.EventHandler(this.btnElimiarTarea_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 449);
            this.Controls.Add(this.btnElimiarTarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tareas1);
            this.Controls.Add(this.btnAgregarTarea);
            this.Controls.Add(this.txtTarea);
            this.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTarea;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.ListBox Tareas1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnElimiarTarea;
    }
}

