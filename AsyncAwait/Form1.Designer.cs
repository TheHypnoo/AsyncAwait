
namespace AsyncAwait
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_sequencial = new System.Windows.Forms.Button();
            this.btn_Async = new System.Windows.Forms.Button();
            this.btn_horaLocal = new System.Windows.Forms.Button();
            this.listBoxSequencial = new System.Windows.Forms.ListBox();
            this.listBoxAsync = new System.Windows.Forms.ListBox();
            this.textBoxSequencial = new System.Windows.Forms.TextBox();
            this.textBoxHoraLocal = new System.Windows.Forms.TextBox();
            this.textBoxAsync = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_sequencial
            // 
            this.btn_sequencial.Location = new System.Drawing.Point(116, 12);
            this.btn_sequencial.Name = "btn_sequencial";
            this.btn_sequencial.Size = new System.Drawing.Size(75, 23);
            this.btn_sequencial.TabIndex = 0;
            this.btn_sequencial.Text = "Sequencial";
            this.btn_sequencial.UseVisualStyleBackColor = true;
            this.btn_sequencial.Click += new System.EventHandler(this.btn_sequencial_Click);
            // 
            // btn_Async
            // 
            this.btn_Async.Location = new System.Drawing.Point(490, 12);
            this.btn_Async.Name = "btn_Async";
            this.btn_Async.Size = new System.Drawing.Size(75, 23);
            this.btn_Async.TabIndex = 1;
            this.btn_Async.Text = "Asyncrono";
            this.btn_Async.UseVisualStyleBackColor = true;
            this.btn_Async.Click += new System.EventHandler(this.btn_Async_Click);
            // 
            // btn_horaLocal
            // 
            this.btn_horaLocal.Location = new System.Drawing.Point(184, 338);
            this.btn_horaLocal.Name = "btn_horaLocal";
            this.btn_horaLocal.Size = new System.Drawing.Size(75, 23);
            this.btn_horaLocal.TabIndex = 2;
            this.btn_horaLocal.Text = "Hora Local:";
            this.btn_horaLocal.UseVisualStyleBackColor = true;
            this.btn_horaLocal.Click += new System.EventHandler(this.btn_horaLocal_Click);
            // 
            // listBoxSequencial
            // 
            this.listBoxSequencial.FormattingEnabled = true;
            this.listBoxSequencial.Location = new System.Drawing.Point(12, 50);
            this.listBoxSequencial.Name = "listBoxSequencial";
            this.listBoxSequencial.Size = new System.Drawing.Size(299, 199);
            this.listBoxSequencial.TabIndex = 3;
            // 
            // listBoxAsync
            // 
            this.listBoxAsync.FormattingEnabled = true;
            this.listBoxAsync.Location = new System.Drawing.Point(362, 50);
            this.listBoxAsync.Name = "listBoxAsync";
            this.listBoxAsync.Size = new System.Drawing.Size(299, 199);
            this.listBoxAsync.TabIndex = 4;
            // 
            // textBoxSequencial
            // 
            this.textBoxSequencial.Location = new System.Drawing.Point(116, 272);
            this.textBoxSequencial.Name = "textBoxSequencial";
            this.textBoxSequencial.ReadOnly = true;
            this.textBoxSequencial.Size = new System.Drawing.Size(160, 20);
            this.textBoxSequencial.TabIndex = 5;
            // 
            // textBoxHoraLocal
            // 
            this.textBoxHoraLocal.Location = new System.Drawing.Point(283, 341);
            this.textBoxHoraLocal.Name = "textBoxHoraLocal";
            this.textBoxHoraLocal.ReadOnly = true;
            this.textBoxHoraLocal.Size = new System.Drawing.Size(100, 20);
            this.textBoxHoraLocal.TabIndex = 6;
            this.textBoxHoraLocal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxAsync
            // 
            this.textBoxAsync.Location = new System.Drawing.Point(405, 272);
            this.textBoxAsync.Name = "textBoxAsync";
            this.textBoxAsync.ReadOnly = true;
            this.textBoxAsync.Size = new System.Drawing.Size(160, 20);
            this.textBoxAsync.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 407);
            this.Controls.Add(this.textBoxAsync);
            this.Controls.Add(this.textBoxHoraLocal);
            this.Controls.Add(this.textBoxSequencial);
            this.Controls.Add(this.listBoxAsync);
            this.Controls.Add(this.listBoxSequencial);
            this.Controls.Add(this.btn_horaLocal);
            this.Controls.Add(this.btn_Async);
            this.Controls.Add(this.btn_sequencial);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Sequencial&Async";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_sequencial;
        private System.Windows.Forms.Button btn_Async;
        private System.Windows.Forms.Button btn_horaLocal;
        private System.Windows.Forms.ListBox listBoxSequencial;
        private System.Windows.Forms.ListBox listBoxAsync;
        private System.Windows.Forms.TextBox textBoxSequencial;
        private System.Windows.Forms.TextBox textBoxHoraLocal;
        private System.Windows.Forms.TextBox textBoxAsync;
    }
}

