
namespace ExamenSegundoParcial
{
    partial class FRM_EMPLEADO
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
            this.CMB_EMPLEADO = new System.Windows.Forms.GroupBox();
            this.BTN_GUARDAR = new System.Windows.Forms.Button();
            this.TXT_CEDULA = new System.Windows.Forms.TextBox();
            this.TXT_NUMSEGSO = new System.Windows.Forms.TextBox();
            this.TXT_NOMBRES = new System.Windows.Forms.TextBox();
            this.TXT_APMATERNO = new System.Windows.Forms.TextBox();
            this.TXT_APPATERNO = new System.Windows.Forms.TextBox();
            this.CMB_SEXO = new System.Windows.Forms.ComboBox();
            this.LBL_TIPCONTRATO = new System.Windows.Forms.Label();
            this.LBL_CEDULA = new System.Windows.Forms.Label();
            this.LBL_SEXO = new System.Windows.Forms.Label();
            this.LBL_NUMSEGSO = new System.Windows.Forms.Label();
            this.CMB_TIPCONTRATO = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_APMATERNO = new System.Windows.Forms.Label();
            this.LBL_APPATERNO = new System.Windows.Forms.Label();
            this.DGV_EMPLEADOS = new System.Windows.Forms.DataGridView();
            this.CEDULA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APPATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APMATERNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOMBRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUMSEGSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEXO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIPCONTRATO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUELDO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMB_EMPLEADO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EMPLEADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // CMB_EMPLEADO
            // 
            this.CMB_EMPLEADO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(211)))), ((int)(((byte)(132)))));
            this.CMB_EMPLEADO.Controls.Add(this.BTN_GUARDAR);
            this.CMB_EMPLEADO.Controls.Add(this.TXT_CEDULA);
            this.CMB_EMPLEADO.Controls.Add(this.TXT_NUMSEGSO);
            this.CMB_EMPLEADO.Controls.Add(this.TXT_NOMBRES);
            this.CMB_EMPLEADO.Controls.Add(this.TXT_APMATERNO);
            this.CMB_EMPLEADO.Controls.Add(this.TXT_APPATERNO);
            this.CMB_EMPLEADO.Controls.Add(this.CMB_SEXO);
            this.CMB_EMPLEADO.Controls.Add(this.LBL_TIPCONTRATO);
            this.CMB_EMPLEADO.Controls.Add(this.LBL_CEDULA);
            this.CMB_EMPLEADO.Controls.Add(this.LBL_SEXO);
            this.CMB_EMPLEADO.Controls.Add(this.LBL_NUMSEGSO);
            this.CMB_EMPLEADO.Controls.Add(this.CMB_TIPCONTRATO);
            this.CMB_EMPLEADO.Controls.Add(this.label3);
            this.CMB_EMPLEADO.Controls.Add(this.LBL_APMATERNO);
            this.CMB_EMPLEADO.Controls.Add(this.LBL_APPATERNO);
            this.CMB_EMPLEADO.Location = new System.Drawing.Point(43, 31);
            this.CMB_EMPLEADO.Name = "CMB_EMPLEADO";
            this.CMB_EMPLEADO.Size = new System.Drawing.Size(1149, 156);
            this.CMB_EMPLEADO.TabIndex = 0;
            this.CMB_EMPLEADO.TabStop = false;
            this.CMB_EMPLEADO.Text = "EMPLEADO";
            this.CMB_EMPLEADO.Enter += new System.EventHandler(this.CMB_EMPLEADO_Enter);
            // 
            // BTN_GUARDAR
            // 
            this.BTN_GUARDAR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            this.BTN_GUARDAR.Location = new System.Drawing.Point(979, 110);
            this.BTN_GUARDAR.Name = "BTN_GUARDAR";
            this.BTN_GUARDAR.Size = new System.Drawing.Size(128, 40);
            this.BTN_GUARDAR.TabIndex = 16;
            this.BTN_GUARDAR.Text = "GUARDAR";
            this.BTN_GUARDAR.UseVisualStyleBackColor = false;
            this.BTN_GUARDAR.Click += new System.EventHandler(this.BTN_GUARDAR_Click);
            // 
            // TXT_CEDULA
            // 
            this.TXT_CEDULA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(176)))));
            this.TXT_CEDULA.Location = new System.Drawing.Point(301, 113);
            this.TXT_CEDULA.Name = "TXT_CEDULA";
            this.TXT_CEDULA.Size = new System.Drawing.Size(164, 20);
            this.TXT_CEDULA.TabIndex = 15;
            // 
            // TXT_NUMSEGSO
            // 
            this.TXT_NUMSEGSO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(176)))));
            this.TXT_NUMSEGSO.Location = new System.Drawing.Point(943, 48);
            this.TXT_NUMSEGSO.Name = "TXT_NUMSEGSO";
            this.TXT_NUMSEGSO.Size = new System.Drawing.Size(164, 20);
            this.TXT_NUMSEGSO.TabIndex = 14;
            // 
            // TXT_NOMBRES
            // 
            this.TXT_NOMBRES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(176)))));
            this.TXT_NOMBRES.Location = new System.Drawing.Point(630, 44);
            this.TXT_NOMBRES.Name = "TXT_NOMBRES";
            this.TXT_NOMBRES.Size = new System.Drawing.Size(164, 20);
            this.TXT_NOMBRES.TabIndex = 13;
            // 
            // TXT_APMATERNO
            // 
            this.TXT_APMATERNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(176)))));
            this.TXT_APMATERNO.Location = new System.Drawing.Point(301, 44);
            this.TXT_APMATERNO.Name = "TXT_APMATERNO";
            this.TXT_APMATERNO.Size = new System.Drawing.Size(164, 20);
            this.TXT_APMATERNO.TabIndex = 12;
            // 
            // TXT_APPATERNO
            // 
            this.TXT_APPATERNO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(176)))));
            this.TXT_APPATERNO.Location = new System.Drawing.Point(27, 55);
            this.TXT_APPATERNO.Name = "TXT_APPATERNO";
            this.TXT_APPATERNO.Size = new System.Drawing.Size(164, 20);
            this.TXT_APPATERNO.TabIndex = 11;
            // 
            // CMB_SEXO
            // 
            this.CMB_SEXO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(176)))));
            this.CMB_SEXO.FormattingEnabled = true;
            this.CMB_SEXO.Items.AddRange(new object[] {
            "MASCULINO",
            "FEMENINO",
            "OTRO"});
            this.CMB_SEXO.Location = new System.Drawing.Point(27, 113);
            this.CMB_SEXO.Name = "CMB_SEXO";
            this.CMB_SEXO.Size = new System.Drawing.Size(164, 22);
            this.CMB_SEXO.TabIndex = 10;
            this.CMB_SEXO.Text = "OTRO()";
            // 
            // LBL_TIPCONTRATO
            // 
            this.LBL_TIPCONTRATO.AutoSize = true;
            this.LBL_TIPCONTRATO.Location = new System.Drawing.Point(647, 85);
            this.LBL_TIPCONTRATO.Name = "LBL_TIPCONTRATO";
            this.LBL_TIPCONTRATO.Size = new System.Drawing.Size(112, 14);
            this.LBL_TIPCONTRATO.TabIndex = 8;
            this.LBL_TIPCONTRATO.Text = "TIPO DE CONTRATO";
            // 
            // LBL_CEDULA
            // 
            this.LBL_CEDULA.AutoSize = true;
            this.LBL_CEDULA.Location = new System.Drawing.Point(360, 95);
            this.LBL_CEDULA.Name = "LBL_CEDULA";
            this.LBL_CEDULA.Size = new System.Drawing.Size(51, 14);
            this.LBL_CEDULA.TabIndex = 7;
            this.LBL_CEDULA.Text = "CEDULA";
            // 
            // LBL_SEXO
            // 
            this.LBL_SEXO.AutoSize = true;
            this.LBL_SEXO.Location = new System.Drawing.Point(24, 95);
            this.LBL_SEXO.Name = "LBL_SEXO";
            this.LBL_SEXO.Size = new System.Drawing.Size(35, 14);
            this.LBL_SEXO.TabIndex = 6;
            this.LBL_SEXO.Text = "SEXO";
            // 
            // LBL_NUMSEGSO
            // 
            this.LBL_NUMSEGSO.AutoSize = true;
            this.LBL_NUMSEGSO.Location = new System.Drawing.Point(944, 31);
            this.LBL_NUMSEGSO.Name = "LBL_NUMSEGSO";
            this.LBL_NUMSEGSO.Size = new System.Drawing.Size(162, 14);
            this.LBL_NUMSEGSO.TabIndex = 5;
            this.LBL_NUMSEGSO.Text = "NUMERO DE SEGURO SOCIAL";
            // 
            // CMB_TIPCONTRATO
            // 
            this.CMB_TIPCONTRATO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(249)))), ((int)(((byte)(176)))));
            this.CMB_TIPCONTRATO.FormattingEnabled = true;
            this.CMB_TIPCONTRATO.Items.AddRange(new object[] {
            "NUEVO",
            "LONGEVO"});
            this.CMB_TIPCONTRATO.Location = new System.Drawing.Point(630, 113);
            this.CMB_TIPCONTRATO.Name = "CMB_TIPCONTRATO";
            this.CMB_TIPCONTRATO.Size = new System.Drawing.Size(164, 22);
            this.CMB_TIPCONTRATO.TabIndex = 4;
            this.CMB_TIPCONTRATO.Text = "NUEVO()";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(688, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOMBRES";
            // 
            // LBL_APMATERNO
            // 
            this.LBL_APMATERNO.AutoSize = true;
            this.LBL_APMATERNO.Location = new System.Drawing.Point(328, 27);
            this.LBL_APMATERNO.Name = "LBL_APMATERNO";
            this.LBL_APMATERNO.Size = new System.Drawing.Size(118, 14);
            this.LBL_APMATERNO.TabIndex = 2;
            this.LBL_APMATERNO.Text = "APELLIDO MATERNO";
            // 
            // LBL_APPATERNO
            // 
            this.LBL_APPATERNO.AutoSize = true;
            this.LBL_APPATERNO.Location = new System.Drawing.Point(54, 27);
            this.LBL_APPATERNO.Name = "LBL_APPATERNO";
            this.LBL_APPATERNO.Size = new System.Drawing.Size(114, 14);
            this.LBL_APPATERNO.TabIndex = 0;
            this.LBL_APPATERNO.Text = "APELLIDO PATERNO";
            // 
            // DGV_EMPLEADOS
            // 
            this.DGV_EMPLEADOS.AllowUserToAddRows = false;
            this.DGV_EMPLEADOS.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(174)))), ((int)(((byte)(192)))));
            this.DGV_EMPLEADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_EMPLEADOS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CEDULA,
            this.APPATERNO,
            this.APMATERNO,
            this.NOMBRES,
            this.NUMSEGSO,
            this.SEXO,
            this.TIPCONTRATO,
            this.SUELDO});
            this.DGV_EMPLEADOS.Location = new System.Drawing.Point(43, 220);
            this.DGV_EMPLEADOS.Name = "DGV_EMPLEADOS";
            this.DGV_EMPLEADOS.Size = new System.Drawing.Size(1149, 242);
            this.DGV_EMPLEADOS.TabIndex = 1;
            // 
            // CEDULA
            // 
            this.CEDULA.HeaderText = "CEDULA";
            this.CEDULA.Name = "CEDULA";
            this.CEDULA.Width = 135;
            // 
            // APPATERNO
            // 
            this.APPATERNO.HeaderText = "APELLIDO PATERNO";
            this.APPATERNO.Name = "APPATERNO";
            this.APPATERNO.Width = 150;
            // 
            // APMATERNO
            // 
            this.APMATERNO.HeaderText = "APELLIDO MATERNO";
            this.APMATERNO.Name = "APMATERNO";
            this.APMATERNO.Width = 150;
            // 
            // NOMBRES
            // 
            this.NOMBRES.HeaderText = "NOMBRES";
            this.NOMBRES.Name = "NOMBRES";
            this.NOMBRES.Width = 150;
            // 
            // NUMSEGSO
            // 
            this.NUMSEGSO.HeaderText = "NUMERO DE SEGURIDAD SOCIAL";
            this.NUMSEGSO.Name = "NUMSEGSO";
            this.NUMSEGSO.Width = 150;
            // 
            // SEXO
            // 
            this.SEXO.HeaderText = "SEXO";
            this.SEXO.Name = "SEXO";
            this.SEXO.Width = 120;
            // 
            // TIPCONTRATO
            // 
            this.TIPCONTRATO.HeaderText = "TIPO DE CONTRATO";
            this.TIPCONTRATO.Name = "TIPCONTRATO";
            this.TIPCONTRATO.Width = 150;
            // 
            // SUELDO
            // 
            this.SUELDO.HeaderText = "SUELDO";
            this.SUELDO.Name = "SUELDO";
            // 
            // FRM_EMPLEADO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(115)))));
            this.ClientSize = new System.Drawing.Size(1228, 485);
            this.Controls.Add(this.DGV_EMPLEADOS);
            this.Controls.Add(this.CMB_EMPLEADO);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_EMPLEADO";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_EMPLEADO";
            this.CMB_EMPLEADO.ResumeLayout(false);
            this.CMB_EMPLEADO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_EMPLEADOS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox CMB_EMPLEADO;
        private System.Windows.Forms.DataGridView DGV_EMPLEADOS;
        private System.Windows.Forms.Label LBL_CEDULA;
        private System.Windows.Forms.Label LBL_SEXO;
        private System.Windows.Forms.Label LBL_NUMSEGSO;
        private System.Windows.Forms.ComboBox CMB_TIPCONTRATO;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_APMATERNO;
        private System.Windows.Forms.Label LBL_APPATERNO;
        private System.Windows.Forms.Button BTN_GUARDAR;
        private System.Windows.Forms.TextBox TXT_CEDULA;
        private System.Windows.Forms.TextBox TXT_NUMSEGSO;
        private System.Windows.Forms.TextBox TXT_NOMBRES;
        private System.Windows.Forms.TextBox TXT_APMATERNO;
        private System.Windows.Forms.TextBox TXT_APPATERNO;
        private System.Windows.Forms.ComboBox CMB_SEXO;
        private System.Windows.Forms.Label LBL_TIPCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn CEDULA;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn APMATERNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOMBRES;
        private System.Windows.Forms.DataGridViewTextBoxColumn NUMSEGSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEXO;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIPCONTRATO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUELDO;
    }
}