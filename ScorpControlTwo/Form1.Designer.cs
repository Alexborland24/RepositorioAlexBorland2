namespace ScorpControlTwo
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblHoraChamada = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LblDirigirFat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LblHoraAtual = new System.Windows.Forms.Label();
            this.LblDataEntrada = new System.Windows.Forms.Label();
            this.LblPlaca = new System.Windows.Forms.Label();
            this.LblNomeMotorista = new System.Windows.Forms.Label();
            this.LblMotorista = new System.Windows.Forms.Label();
            this.GridChamados = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.LblHora1 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.LblPlaca1 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.LblNome1 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.LblHora2 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.LblPlaca2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.LblNome2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.LblHora3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LblPlaca3 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LblNome3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.LblHora4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblPlaca4 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LblNome4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.LblHora5 = new System.Windows.Forms.Label();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.LblPlaca5 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.LblNome5 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.LblUltimasChamadas = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridChamados)).BeginInit();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            this.splitContainer1.Panel1.Controls.Add(this.panel3);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridChamados);
            this.splitContainer1.Panel2.Controls.Add(this.panel8);
            this.splitContainer1.Panel2.Controls.Add(this.panel7);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.Controls.Add(this.panel5);
            this.splitContainer1.Panel2.Controls.Add(this.panel4);
            this.splitContainer1.Size = new System.Drawing.Size(1264, 853);
            this.splitContainer1.SplitterDistance = 849;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Brown;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.LblHoraChamada);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 663);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(849, 190);
            this.panel2.TabIndex = 4;
            // 
            // LblHoraChamada
            // 
            this.LblHoraChamada.AutoSize = true;
            this.LblHoraChamada.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraChamada.ForeColor = System.Drawing.Color.White;
            this.LblHoraChamada.Location = new System.Drawing.Point(33, 71);
            this.LblHoraChamada.Name = "LblHoraChamada";
            this.LblHoraChamada.Size = new System.Drawing.Size(599, 61);
            this.LblHoraChamada.TabIndex = 0;
            this.LblHoraChamada.Text = "Data Hora da Chamada";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Coral;
            this.panel3.Controls.Add(this.LblDirigirFat);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 461);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(849, 202);
            this.panel3.TabIndex = 3;
            // 
            // LblDirigirFat
            // 
            this.LblDirigirFat.AutoSize = true;
            this.LblDirigirFat.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirigirFat.ForeColor = System.Drawing.Color.Yellow;
            this.LblDirigirFat.Location = new System.Drawing.Point(35, 64);
            this.LblDirigirFat.Name = "LblDirigirFat";
            this.LblDirigirFat.Size = new System.Drawing.Size(801, 61);
            this.LblDirigirFat.TabIndex = 1;
            this.LblDirigirFat.Text = "Favor Dirigir-se ao Faturamento";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Controls.Add(this.LblHoraAtual);
            this.panel1.Controls.Add(this.LblDataEntrada);
            this.panel1.Controls.Add(this.LblPlaca);
            this.panel1.Controls.Add(this.LblNomeMotorista);
            this.panel1.Controls.Add(this.LblMotorista);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 461);
            this.panel1.TabIndex = 1;
            // 
            // LblHoraAtual
            // 
            this.LblHoraAtual.AutoSize = true;
            this.LblHoraAtual.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHoraAtual.ForeColor = System.Drawing.Color.Beige;
            this.LblHoraAtual.Location = new System.Drawing.Point(737, 0);
            this.LblHoraAtual.Name = "LblHoraAtual";
            this.LblHoraAtual.Size = new System.Drawing.Size(134, 38);
            this.LblHoraAtual.TabIndex = 5;
            this.LblHoraAtual.Text = "Relogio";
            // 
            // LblDataEntrada
            // 
            this.LblDataEntrada.AutoSize = true;
            this.LblDataEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDataEntrada.ForeColor = System.Drawing.SystemColors.Info;
            this.LblDataEntrada.Location = new System.Drawing.Point(42, 389);
            this.LblDataEntrada.Name = "LblDataEntrada";
            this.LblDataEntrada.Size = new System.Drawing.Size(363, 46);
            this.LblDataEntrada.TabIndex = 4;
            this.LblDataEntrada.Text = "Data Hora Entrada:";
            // 
            // LblPlaca
            // 
            this.LblPlaca.AutoSize = true;
            this.LblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca.ForeColor = System.Drawing.SystemColors.Info;
            this.LblPlaca.Location = new System.Drawing.Point(38, 274);
            this.LblPlaca.Name = "LblPlaca";
            this.LblPlaca.Size = new System.Drawing.Size(143, 46);
            this.LblPlaca.TabIndex = 3;
            this.LblPlaca.Text = "Placa: ";
            // 
            // LblNomeMotorista
            // 
            this.LblNomeMotorista.AutoSize = true;
            this.LblNomeMotorista.Font = new System.Drawing.Font("Tahoma", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNomeMotorista.ForeColor = System.Drawing.SystemColors.Info;
            this.LblNomeMotorista.Location = new System.Drawing.Point(29, 108);
            this.LblNomeMotorista.Name = "LblNomeMotorista";
            this.LblNomeMotorista.Size = new System.Drawing.Size(110, 97);
            this.LblNomeMotorista.TabIndex = 2;
            this.LblNomeMotorista.Text = "--";
            // 
            // LblMotorista
            // 
            this.LblMotorista.AutoSize = true;
            this.LblMotorista.Font = new System.Drawing.Font("Microsoft Sans Serif", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMotorista.ForeColor = System.Drawing.Color.Yellow;
            this.LblMotorista.Location = new System.Drawing.Point(12, 20);
            this.LblMotorista.Name = "LblMotorista";
            this.LblMotorista.Size = new System.Drawing.Size(276, 61);
            this.LblMotorista.TabIndex = 0;
            this.LblMotorista.Text = "Senhor(A)";
            // 
            // GridChamados
            // 
            this.GridChamados.AllowUserToAddRows = false;
            this.GridChamados.AllowUserToDeleteRows = false;
            this.GridChamados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridChamados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.GridChamados.BackgroundColor = System.Drawing.Color.MistyRose;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Brown;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridChamados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.GridChamados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridChamados.DefaultCellStyle = dataGridViewCellStyle5;
            this.GridChamados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridChamados.Location = new System.Drawing.Point(0, 0);
            this.GridChamados.Name = "GridChamados";
            this.GridChamados.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridChamados.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.GridChamados.RowHeadersWidth = 5;
            this.GridChamados.Size = new System.Drawing.Size(411, 853);
            this.GridChamados.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.LblHora1);
            this.panel8.Controls.Add(this.label20);
            this.panel8.Controls.Add(this.LblPlaca1);
            this.panel8.Controls.Add(this.label22);
            this.panel8.Controls.Add(this.LblNome1);
            this.panel8.Controls.Add(this.label24);
            this.panel8.Location = new System.Drawing.Point(3, 497);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(435, 102);
            this.panel8.TabIndex = 4;
            // 
            // LblHora1
            // 
            this.LblHora1.AutoSize = true;
            this.LblHora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora1.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblHora1.Location = new System.Drawing.Point(130, 64);
            this.LblHora1.Name = "LblHora1";
            this.LblHora1.Size = new System.Drawing.Size(82, 29);
            this.LblHora1.TabIndex = 6;
            this.LblHora1.Text = "Horas";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.Tomato;
            this.label20.Location = new System.Drawing.Point(2, 64);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(89, 29);
            this.label20.TabIndex = 5;
            this.label20.Text = "Horas:";
            // 
            // LblPlaca1
            // 
            this.LblPlaca1.AutoSize = true;
            this.LblPlaca1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca1.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblPlaca1.Location = new System.Drawing.Point(130, 35);
            this.LblPlaca1.Name = "LblPlaca1";
            this.LblPlaca1.Size = new System.Drawing.Size(178, 29);
            this.LblPlaca1.TabIndex = 4;
            this.LblPlaca1.Text = "Numero Placa";
            // 
            // label22
            // 
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.Tomato;
            this.label22.Location = new System.Drawing.Point(3, 35);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(121, 29);
            this.label22.TabIndex = 3;
            this.label22.Text = "Placa:";
            // 
            // LblNome1
            // 
            this.LblNome1.AutoSize = true;
            this.LblNome1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome1.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblNome1.Location = new System.Drawing.Point(130, 6);
            this.LblNome1.Name = "LblNome1";
            this.LblNome1.Size = new System.Drawing.Size(198, 29);
            this.LblNome1.TabIndex = 2;
            this.LblNome1.Text = "Nome Motorista";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.Tomato;
            this.label24.Location = new System.Drawing.Point(3, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(128, 29);
            this.label24.TabIndex = 1;
            this.label24.Text = "Motorista:";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.LblHora2);
            this.panel7.Controls.Add(this.label14);
            this.panel7.Controls.Add(this.LblPlaca2);
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.LblNome2);
            this.panel7.Controls.Add(this.label18);
            this.panel7.Location = new System.Drawing.Point(3, 384);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(435, 107);
            this.panel7.TabIndex = 3;
            // 
            // LblHora2
            // 
            this.LblHora2.AutoSize = true;
            this.LblHora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora2.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblHora2.Location = new System.Drawing.Point(130, 64);
            this.LblHora2.Name = "LblHora2";
            this.LblHora2.Size = new System.Drawing.Size(82, 29);
            this.LblHora2.TabIndex = 6;
            this.LblHora2.Text = "Horas";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Tomato;
            this.label14.Location = new System.Drawing.Point(2, 64);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 29);
            this.label14.TabIndex = 5;
            this.label14.Text = "Horas:";
            // 
            // LblPlaca2
            // 
            this.LblPlaca2.AutoSize = true;
            this.LblPlaca2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca2.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblPlaca2.Location = new System.Drawing.Point(130, 35);
            this.LblPlaca2.Name = "LblPlaca2";
            this.LblPlaca2.Size = new System.Drawing.Size(178, 29);
            this.LblPlaca2.TabIndex = 4;
            this.LblPlaca2.Text = "Numero Placa";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.Tomato;
            this.label16.Location = new System.Drawing.Point(3, 35);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(121, 29);
            this.label16.TabIndex = 3;
            this.label16.Text = "Placa:";
            // 
            // LblNome2
            // 
            this.LblNome2.AutoSize = true;
            this.LblNome2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome2.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblNome2.Location = new System.Drawing.Point(130, 6);
            this.LblNome2.Name = "LblNome2";
            this.LblNome2.Size = new System.Drawing.Size(198, 29);
            this.LblNome2.TabIndex = 2;
            this.LblNome2.Text = "Nome Motorista";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Tomato;
            this.label18.Location = new System.Drawing.Point(3, 6);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(128, 29);
            this.label18.TabIndex = 1;
            this.label18.Text = "Motorista:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.LblHora3);
            this.panel6.Controls.Add(this.label8);
            this.panel6.Controls.Add(this.LblPlaca3);
            this.panel6.Controls.Add(this.label10);
            this.panel6.Controls.Add(this.LblNome3);
            this.panel6.Controls.Add(this.label12);
            this.panel6.Location = new System.Drawing.Point(3, 272);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(435, 95);
            this.panel6.TabIndex = 2;
            // 
            // LblHora3
            // 
            this.LblHora3.AutoSize = true;
            this.LblHora3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora3.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblHora3.Location = new System.Drawing.Point(130, 64);
            this.LblHora3.Name = "LblHora3";
            this.LblHora3.Size = new System.Drawing.Size(82, 29);
            this.LblHora3.TabIndex = 6;
            this.LblHora3.Text = "Horas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(2, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 29);
            this.label8.TabIndex = 5;
            this.label8.Text = "Horas:";
            // 
            // LblPlaca3
            // 
            this.LblPlaca3.AutoSize = true;
            this.LblPlaca3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca3.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblPlaca3.Location = new System.Drawing.Point(130, 35);
            this.LblPlaca3.Name = "LblPlaca3";
            this.LblPlaca3.Size = new System.Drawing.Size(178, 29);
            this.LblPlaca3.TabIndex = 4;
            this.LblPlaca3.Text = "Numero Placa";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Tomato;
            this.label10.Location = new System.Drawing.Point(3, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 29);
            this.label10.TabIndex = 3;
            this.label10.Text = "Placa:";
            // 
            // LblNome3
            // 
            this.LblNome3.AutoSize = true;
            this.LblNome3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome3.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblNome3.Location = new System.Drawing.Point(130, 6);
            this.LblNome3.Name = "LblNome3";
            this.LblNome3.Size = new System.Drawing.Size(198, 29);
            this.LblNome3.TabIndex = 2;
            this.LblNome3.Text = "Nome Motorista";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Tomato;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 29);
            this.label12.TabIndex = 1;
            this.label12.Text = "Motorista:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.LblHora4);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.LblPlaca4);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.LblNome4);
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(3, 161);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(435, 96);
            this.panel5.TabIndex = 1;
            // 
            // LblHora4
            // 
            this.LblHora4.AutoSize = true;
            this.LblHora4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora4.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblHora4.Location = new System.Drawing.Point(130, 64);
            this.LblHora4.Name = "LblHora4";
            this.LblHora4.Size = new System.Drawing.Size(82, 29);
            this.LblHora4.TabIndex = 6;
            this.LblHora4.Text = "Horas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Tomato;
            this.label2.Location = new System.Drawing.Point(2, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Horas:";
            // 
            // LblPlaca4
            // 
            this.LblPlaca4.AutoSize = true;
            this.LblPlaca4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca4.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblPlaca4.Location = new System.Drawing.Point(130, 35);
            this.LblPlaca4.Name = "LblPlaca4";
            this.LblPlaca4.Size = new System.Drawing.Size(178, 29);
            this.LblPlaca4.TabIndex = 4;
            this.LblPlaca4.Text = "Numero Placa";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Tomato;
            this.label4.Location = new System.Drawing.Point(3, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Placa:";
            // 
            // LblNome4
            // 
            this.LblNome4.AutoSize = true;
            this.LblNome4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome4.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblNome4.Location = new System.Drawing.Point(130, 6);
            this.LblNome4.Name = "LblNome4";
            this.LblNome4.Size = new System.Drawing.Size(198, 29);
            this.LblNome4.TabIndex = 2;
            this.LblNome4.Text = "Nome Motorista";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Tomato;
            this.label6.Location = new System.Drawing.Point(3, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 29);
            this.label6.TabIndex = 1;
            this.label6.Text = "Motorista:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.LblHora5);
            this.panel4.Controls.Add(this.Lbl3);
            this.panel4.Controls.Add(this.LblPlaca5);
            this.panel4.Controls.Add(this.Lbl2);
            this.panel4.Controls.Add(this.LblNome5);
            this.panel4.Controls.Add(this.Lbl1);
            this.panel4.Controls.Add(this.LblUltimasChamadas);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(435, 152);
            this.panel4.TabIndex = 0;
            // 
            // LblHora5
            // 
            this.LblHora5.AutoSize = true;
            this.LblHora5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHora5.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblHora5.Location = new System.Drawing.Point(130, 114);
            this.LblHora5.Name = "LblHora5";
            this.LblHora5.Size = new System.Drawing.Size(82, 29);
            this.LblHora5.TabIndex = 6;
            this.LblHora5.Text = "Horas";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.ForeColor = System.Drawing.Color.Tomato;
            this.Lbl3.Location = new System.Drawing.Point(2, 114);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(89, 29);
            this.Lbl3.TabIndex = 5;
            this.Lbl3.Text = "Horas:";
            // 
            // LblPlaca5
            // 
            this.LblPlaca5.AutoSize = true;
            this.LblPlaca5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPlaca5.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblPlaca5.Location = new System.Drawing.Point(130, 85);
            this.LblPlaca5.Name = "LblPlaca5";
            this.LblPlaca5.Size = new System.Drawing.Size(178, 29);
            this.LblPlaca5.TabIndex = 4;
            this.LblPlaca5.Text = "Numero Placa";
            // 
            // Lbl2
            // 
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.ForeColor = System.Drawing.Color.Tomato;
            this.Lbl2.Location = new System.Drawing.Point(3, 85);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(121, 29);
            this.Lbl2.TabIndex = 3;
            this.Lbl2.Text = "Placa:";
            // 
            // LblNome5
            // 
            this.LblNome5.AutoSize = true;
            this.LblNome5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome5.ForeColor = System.Drawing.Color.SlateBlue;
            this.LblNome5.Location = new System.Drawing.Point(130, 56);
            this.LblNome5.Name = "LblNome5";
            this.LblNome5.Size = new System.Drawing.Size(198, 29);
            this.LblNome5.TabIndex = 2;
            this.LblNome5.Text = "Nome Motorista";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.ForeColor = System.Drawing.Color.Tomato;
            this.Lbl1.Location = new System.Drawing.Point(3, 56);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(128, 29);
            this.Lbl1.TabIndex = 1;
            this.Lbl1.Text = "Motorista:";
            // 
            // LblUltimasChamadas
            // 
            this.LblUltimasChamadas.AutoSize = true;
            this.LblUltimasChamadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUltimasChamadas.ForeColor = System.Drawing.Color.DarkRed;
            this.LblUltimasChamadas.Location = new System.Drawing.Point(65, 8);
            this.LblUltimasChamadas.Name = "LblUltimasChamadas";
            this.LblUltimasChamadas.Size = new System.Drawing.Size(305, 37);
            this.LblUltimasChamadas.TabIndex = 0;
            this.LblUltimasChamadas.Text = "Ultimas Chamadas";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 853);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ScorpControlTwo";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridChamados)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label LblHoraChamada;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblDirigirFat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label LblHoraAtual;
        private System.Windows.Forms.Label LblDataEntrada;
        private System.Windows.Forms.Label LblPlaca;
        private System.Windows.Forms.Label LblNomeMotorista;
        private System.Windows.Forms.Label LblMotorista;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label LblUltimasChamadas;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Label LblNome5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label LblHora4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblPlaca4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblNome4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label LblHora5;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label LblPlaca5;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label LblHora1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label LblPlaca1;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label LblNome1;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label LblHora2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblPlaca2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label LblNome2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label LblHora3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label LblPlaca3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblNome3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView GridChamados;
    }
}

