namespace TareaPatronDecorador
{
    partial class frmVenta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.lblPizzaDe = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnBGrueso = new System.Windows.Forms.Button();
            this.btnBDelgado = new System.Windows.Forms.Button();
            this.btnBMixto = new System.Windows.Forms.Button();
            this.btnBRelleno = new System.Windows.Forms.Button();
            this.lblSelectBorde = new System.Windows.Forms.Label();
            this.lblSelccCondmt = new System.Windows.Forms.Label();
            this.btnQueso = new System.Windows.Forms.Button();
            this.btnPeperoni = new System.Windows.Forms.Button();
            this.btnAnchoas = new System.Windows.Forms.Button();
            this.btnSalchicha = new System.Windows.Forms.Button();
            this.btnJamon = new System.Windows.Forms.Button();
            this.btnPina = new System.Windows.Forms.Button();
            this.lblCondimento6 = new System.Windows.Forms.Label();
            this.lblVistaPrecio = new System.Windows.Forms.Label();
            this.lblVistaBorde = new System.Windows.Forms.Label();
            this.dgvPizza = new System.Windows.Forms.DataGridView();
            this.BordePizza = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Condimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnTerminar = new System.Windows.Forms.Button();
            this.lblCondimentos = new System.Windows.Forms.Label();
            this.lblVistaCondimento = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblVistaFecha = new System.Windows.Forms.Label();
            this.tmrFecha = new System.Windows.Forms.Timer(this.components);
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPizzaDe
            // 
            this.lblPizzaDe.AutoSize = true;
            this.lblPizzaDe.BackColor = System.Drawing.Color.White;
            this.lblPizzaDe.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPizzaDe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPizzaDe.Location = new System.Drawing.Point(9, 14);
            this.lblPizzaDe.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPizzaDe.Name = "lblPizzaDe";
            this.lblPizzaDe.Size = new System.Drawing.Size(153, 33);
            this.lblPizzaDe.TabIndex = 2;
            this.lblPizzaDe.Text = "Borde Pizza:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.White;
            this.lblPrecio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblPrecio.Location = new System.Drawing.Point(9, 65);
            this.lblPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(91, 33);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio:";
            // 
            // btnBGrueso
            // 
            this.btnBGrueso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBGrueso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBGrueso.Location = new System.Drawing.Point(12, 317);
            this.btnBGrueso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBGrueso.Name = "btnBGrueso";
            this.btnBGrueso.Size = new System.Drawing.Size(120, 46);
            this.btnBGrueso.TabIndex = 4;
            this.btnBGrueso.Text = "Grueso";
            this.btnBGrueso.UseVisualStyleBackColor = true;
            this.btnBGrueso.Click += new System.EventHandler(this.btnBGrueso_Click);
            // 
            // btnBDelgado
            // 
            this.btnBDelgado.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBDelgado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBDelgado.Location = new System.Drawing.Point(141, 315);
            this.btnBDelgado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBDelgado.Name = "btnBDelgado";
            this.btnBDelgado.Size = new System.Drawing.Size(117, 46);
            this.btnBDelgado.TabIndex = 5;
            this.btnBDelgado.Text = "Delgado";
            this.btnBDelgado.UseVisualStyleBackColor = true;
            this.btnBDelgado.Click += new System.EventHandler(this.btnBDelgado_Click);
            // 
            // btnBMixto
            // 
            this.btnBMixto.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBMixto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBMixto.Location = new System.Drawing.Point(267, 315);
            this.btnBMixto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBMixto.Name = "btnBMixto";
            this.btnBMixto.Size = new System.Drawing.Size(120, 46);
            this.btnBMixto.TabIndex = 6;
            this.btnBMixto.Text = "Mixto";
            this.btnBMixto.UseVisualStyleBackColor = true;
            this.btnBMixto.Click += new System.EventHandler(this.btnBMixto_Click);
            // 
            // btnBRelleno
            // 
            this.btnBRelleno.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBRelleno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnBRelleno.Location = new System.Drawing.Point(396, 315);
            this.btnBRelleno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBRelleno.Name = "btnBRelleno";
            this.btnBRelleno.Size = new System.Drawing.Size(120, 46);
            this.btnBRelleno.TabIndex = 7;
            this.btnBRelleno.Text = "Relleno";
            this.btnBRelleno.UseVisualStyleBackColor = true;
            this.btnBRelleno.Click += new System.EventHandler(this.btnBRelleno_Click);
            // 
            // lblSelectBorde
            // 
            this.lblSelectBorde.AutoSize = true;
            this.lblSelectBorde.BackColor = System.Drawing.Color.White;
            this.lblSelectBorde.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectBorde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSelectBorde.Location = new System.Drawing.Point(6, 275);
            this.lblSelectBorde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectBorde.Name = "lblSelectBorde";
            this.lblSelectBorde.Size = new System.Drawing.Size(346, 33);
            this.lblSelectBorde.TabIndex = 8;
            this.lblSelectBorde.Text = "Seleccione un Borde de Pizza:";
            // 
            // lblSelccCondmt
            // 
            this.lblSelccCondmt.AutoSize = true;
            this.lblSelccCondmt.BackColor = System.Drawing.Color.White;
            this.lblSelccCondmt.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelccCondmt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSelccCondmt.Location = new System.Drawing.Point(9, 402);
            this.lblSelccCondmt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelccCondmt.Name = "lblSelccCondmt";
            this.lblSelccCondmt.Size = new System.Drawing.Size(289, 33);
            this.lblSelccCondmt.TabIndex = 9;
            this.lblSelccCondmt.Text = "Seleccione Condimentos:";
            // 
            // btnQueso
            // 
            this.btnQueso.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQueso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnQueso.Location = new System.Drawing.Point(12, 442);
            this.btnQueso.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQueso.Name = "btnQueso";
            this.btnQueso.Size = new System.Drawing.Size(195, 46);
            this.btnQueso.TabIndex = 10;
            this.btnQueso.Text = "Queso $40";
            this.btnQueso.UseVisualStyleBackColor = true;
            this.btnQueso.Click += new System.EventHandler(this.btnQueso_Click);
            // 
            // btnPeperoni
            // 
            this.btnPeperoni.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeperoni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPeperoni.Location = new System.Drawing.Point(216, 442);
            this.btnPeperoni.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPeperoni.Name = "btnPeperoni";
            this.btnPeperoni.Size = new System.Drawing.Size(195, 46);
            this.btnPeperoni.TabIndex = 11;
            this.btnPeperoni.Text = "Peperoni $20";
            this.btnPeperoni.UseVisualStyleBackColor = true;
            this.btnPeperoni.Click += new System.EventHandler(this.btnPeperoni_Click);
            // 
            // btnAnchoas
            // 
            this.btnAnchoas.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnchoas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAnchoas.Location = new System.Drawing.Point(12, 552);
            this.btnAnchoas.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAnchoas.Name = "btnAnchoas";
            this.btnAnchoas.Size = new System.Drawing.Size(195, 46);
            this.btnAnchoas.TabIndex = 12;
            this.btnAnchoas.Text = "Anchoas $10";
            this.btnAnchoas.UseVisualStyleBackColor = true;
            this.btnAnchoas.Click += new System.EventHandler(this.btnAnchoas_Click);
            // 
            // btnSalchicha
            // 
            this.btnSalchicha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalchicha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSalchicha.Location = new System.Drawing.Point(216, 497);
            this.btnSalchicha.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalchicha.Name = "btnSalchicha";
            this.btnSalchicha.Size = new System.Drawing.Size(195, 46);
            this.btnSalchicha.TabIndex = 13;
            this.btnSalchicha.Text = "Salchicha $20";
            this.btnSalchicha.UseVisualStyleBackColor = true;
            this.btnSalchicha.Click += new System.EventHandler(this.btnSalchicha_Click);
            // 
            // btnJamon
            // 
            this.btnJamon.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnJamon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnJamon.Location = new System.Drawing.Point(12, 497);
            this.btnJamon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnJamon.Name = "btnJamon";
            this.btnJamon.Size = new System.Drawing.Size(195, 46);
            this.btnJamon.TabIndex = 14;
            this.btnJamon.Text = "Jamón $15";
            this.btnJamon.UseVisualStyleBackColor = true;
            this.btnJamon.Click += new System.EventHandler(this.btnJamon_Click);
            // 
            // btnPina
            // 
            this.btnPina.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPina.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnPina.Location = new System.Drawing.Point(216, 552);
            this.btnPina.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPina.Name = "btnPina";
            this.btnPina.Size = new System.Drawing.Size(195, 46);
            this.btnPina.TabIndex = 15;
            this.btnPina.Text = "Piña $15";
            this.btnPina.UseVisualStyleBackColor = true;
            this.btnPina.Click += new System.EventHandler(this.btnPina_Click);
            // 
            // lblCondimento6
            // 
            this.lblCondimento6.AutoSize = true;
            this.lblCondimento6.BackColor = System.Drawing.Color.White;
            this.lblCondimento6.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondimento6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCondimento6.Location = new System.Drawing.Point(180, 366);
            this.lblCondimento6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondimento6.Name = "lblCondimento6";
            this.lblCondimento6.Size = new System.Drawing.Size(0, 33);
            this.lblCondimento6.TabIndex = 22;
            // 
            // lblVistaPrecio
            // 
            this.lblVistaPrecio.AutoSize = true;
            this.lblVistaPrecio.BackColor = System.Drawing.Color.White;
            this.lblVistaPrecio.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVistaPrecio.Location = new System.Drawing.Point(180, 65);
            this.lblVistaPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVistaPrecio.Name = "lblVistaPrecio";
            this.lblVistaPrecio.Size = new System.Drawing.Size(33, 33);
            this.lblVistaPrecio.TabIndex = 23;
            this.lblVistaPrecio.Text = "...";
            // 
            // lblVistaBorde
            // 
            this.lblVistaBorde.AutoSize = true;
            this.lblVistaBorde.BackColor = System.Drawing.Color.White;
            this.lblVistaBorde.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaBorde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVistaBorde.Location = new System.Drawing.Point(180, 18);
            this.lblVistaBorde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVistaBorde.Name = "lblVistaBorde";
            this.lblVistaBorde.Size = new System.Drawing.Size(33, 33);
            this.lblVistaBorde.TabIndex = 24;
            this.lblVistaBorde.Text = "...";
            // 
            // dgvPizza
            // 
            this.dgvPizza.AllowUserToAddRows = false;
            this.dgvPizza.AllowUserToDeleteRows = false;
            this.dgvPizza.BackgroundColor = System.Drawing.Color.White;
            this.dgvPizza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPizza.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BordePizza,
            this.Precio,
            this.Condimento,
            this.Fecha});
            this.dgvPizza.Location = new System.Drawing.Point(525, 18);
            this.dgvPizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvPizza.Name = "dgvPizza";
            this.dgvPizza.ReadOnly = true;
            this.dgvPizza.Size = new System.Drawing.Size(543, 657);
            this.dgvPizza.TabIndex = 25;
            // 
            // BordePizza
            // 
            this.BordePizza.HeaderText = "Borde";
            this.BordePizza.Name = "BordePizza";
            this.BordePizza.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Condimento
            // 
            this.Condimento.HeaderText = "Condimento";
            this.Condimento.Name = "Condimento";
            this.Condimento.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnCancelar.Location = new System.Drawing.Point(12, 629);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(150, 46);
            this.btnCancelar.TabIndex = 26;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnTerminar
            // 
            this.btnTerminar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnTerminar.Location = new System.Drawing.Point(330, 629);
            this.btnTerminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTerminar.Name = "btnTerminar";
            this.btnTerminar.Size = new System.Drawing.Size(150, 46);
            this.btnTerminar.TabIndex = 27;
            this.btnTerminar.Text = "Terminar";
            this.btnTerminar.UseVisualStyleBackColor = true;
            this.btnTerminar.Click += new System.EventHandler(this.btnTerminar_Click);
            // 
            // lblCondimentos
            // 
            this.lblCondimentos.AutoSize = true;
            this.lblCondimentos.BackColor = System.Drawing.Color.White;
            this.lblCondimentos.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondimentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblCondimentos.Location = new System.Drawing.Point(9, 120);
            this.lblCondimentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCondimentos.Name = "lblCondimentos";
            this.lblCondimentos.Size = new System.Drawing.Size(162, 33);
            this.lblCondimentos.TabIndex = 28;
            this.lblCondimentos.Text = "Condimentos:";
            // 
            // lblVistaCondimento
            // 
            this.lblVistaCondimento.AutoSize = true;
            this.lblVistaCondimento.BackColor = System.Drawing.Color.White;
            this.lblVistaCondimento.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaCondimento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVistaCondimento.Location = new System.Drawing.Point(180, 120);
            this.lblVistaCondimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVistaCondimento.Name = "lblVistaCondimento";
            this.lblVistaCondimento.Size = new System.Drawing.Size(33, 33);
            this.lblVistaCondimento.TabIndex = 29;
            this.lblVistaCondimento.Text = "...";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnAgregar.Location = new System.Drawing.Point(171, 629);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(150, 46);
            this.btnAgregar.TabIndex = 30;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.White;
            this.lblFecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblFecha.Location = new System.Drawing.Point(9, 169);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(88, 33);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "Fecha:";
            // 
            // lblVistaFecha
            // 
            this.lblVistaFecha.AutoSize = true;
            this.lblVistaFecha.BackColor = System.Drawing.Color.White;
            this.lblVistaFecha.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblVistaFecha.Location = new System.Drawing.Point(104, 169);
            this.lblVistaFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVistaFecha.Name = "lblVistaFecha";
            this.lblVistaFecha.Size = new System.Drawing.Size(33, 33);
            this.lblVistaFecha.TabIndex = 32;
            this.lblVistaFecha.Text = "...";
            // 
            // tmrFecha
            // 
            this.tmrFecha.Enabled = true;
            this.tmrFecha.Tick += new System.EventHandler(this.tmrFecha_Tick);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(292, 126);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 33;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1086, 694);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.lblVistaFecha);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblVistaCondimento);
            this.Controls.Add(this.lblCondimentos);
            this.Controls.Add(this.btnTerminar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dgvPizza);
            this.Controls.Add(this.lblVistaBorde);
            this.Controls.Add(this.lblVistaPrecio);
            this.Controls.Add(this.lblCondimento6);
            this.Controls.Add(this.btnPina);
            this.Controls.Add(this.btnJamon);
            this.Controls.Add(this.btnSalchicha);
            this.Controls.Add(this.btnAnchoas);
            this.Controls.Add(this.btnPeperoni);
            this.Controls.Add(this.btnQueso);
            this.Controls.Add(this.lblSelccCondmt);
            this.Controls.Add(this.lblSelectBorde);
            this.Controls.Add(this.btnBRelleno);
            this.Controls.Add(this.btnBMixto);
            this.Controls.Add(this.btnBDelgado);
            this.Controls.Add(this.btnBGrueso);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblPizzaDe);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pizzeria";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPizzaDe;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnBGrueso;
        private System.Windows.Forms.Button btnBDelgado;
        private System.Windows.Forms.Button btnBMixto;
        private System.Windows.Forms.Button btnBRelleno;
        private System.Windows.Forms.Label lblSelectBorde;
        private System.Windows.Forms.Label lblSelccCondmt;
        private System.Windows.Forms.Button btnQueso;
        private System.Windows.Forms.Button btnPeperoni;
        private System.Windows.Forms.Button btnAnchoas;
        private System.Windows.Forms.Button btnSalchicha;
        private System.Windows.Forms.Button btnJamon;
        private System.Windows.Forms.Button btnPina;
        private System.Windows.Forms.Label lblCondimento6;
        private System.Windows.Forms.Label lblVistaPrecio;
        private System.Windows.Forms.Label lblVistaBorde;
        private System.Windows.Forms.DataGridView dgvPizza;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnTerminar;
        private System.Windows.Forms.Label lblCondimentos;
        private System.Windows.Forms.Label lblVistaCondimento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblVistaFecha;
        private System.Windows.Forms.Timer tmrFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn BordePizza;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Condimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}