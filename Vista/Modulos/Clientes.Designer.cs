
namespace Agm_Tools
{
    partial class Cliente
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel2 = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtdirec = new System.Windows.Forms.TextBox();
            this.txtCuit = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.LabelCliente = new System.Windows.Forms.Label();
            this.cmbTipoCons = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnClienteRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnClienteEliminar = new MaterialSkin.Controls.MaterialButton();
            this.descripcionClientes = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Menu;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            this.dgvLista.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLista.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLista.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLista.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvLista.BackgroundColor = System.Drawing.SystemColors.WindowFrame;
            this.dgvLista.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLista.Location = new System.Drawing.Point(15, 338);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.RowHeadersVisible = false;
            this.dgvLista.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvLista.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvLista.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvLista.RowTemplate.ReadOnly = true;
            this.dgvLista.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLista.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLista.Size = new System.Drawing.Size(961, 241);
            this.dgvLista.StandardTab = true;
            this.dgvLista.TabIndex = 22;
            this.dgvLista.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLista_CellDoubleClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(606, 253);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 26);
            this.txtEmail.TabIndex = 22;
            // 
            // txtTel2
            // 
            this.txtTel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTel2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel2.Location = new System.Drawing.Point(606, 219);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(319, 27);
            this.txtTel2.TabIndex = 21;
            this.txtTel2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel2_KeyPress);
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(606, 186);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(319, 26);
            this.txtTel.TabIndex = 20;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTel_KeyPress);
            // 
            // txtdirec
            // 
            this.txtdirec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdirec.Location = new System.Drawing.Point(606, 153);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(319, 26);
            this.txtdirec.TabIndex = 19;
            // 
            // txtCuit
            // 
            this.txtCuit.AcceptsTab = true;
            this.txtCuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.Location = new System.Drawing.Point(608, 20);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(319, 26);
            this.txtCuit.TabIndex = 15;
            this.txtCuit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCuit_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.AutoCompleteCustomSource.AddRange(new string[] {
            "santiago",
            "marcelo",
            "fernando"});
            this.txtNombre.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.txtNombre.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(608, 85);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 27);
            this.txtNombre.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(504, 255);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(504, 221);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Teléfono 2";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(504, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 10;
            this.label8.Text = "Teléfono 1";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(504, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 9;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(504, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Cons.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(504, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(504, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 13;
            this.label4.Text = "CUIT / DNI";
            // 
            // LabelCliente
            // 
            this.LabelCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LabelCliente.AutoSize = true;
            this.LabelCliente.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelCliente.Location = new System.Drawing.Point(122, 20);
            this.LabelCliente.Name = "LabelCliente";
            this.LabelCliente.Size = new System.Drawing.Size(93, 26);
            this.LabelCliente.TabIndex = 6;
            this.LabelCliente.Text = "Clientes";
            // 
            // cmbTipoCons
            // 
            this.cmbTipoCons.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmbTipoCons.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoCons.FormattingEnabled = true;
            this.cmbTipoCons.ItemHeight = 20;
            this.cmbTipoCons.Items.AddRange(new object[] {
            "Consumidor Final",
            "Responsable Monotributo",
            "IVA Sujeto Excento",
            "IVA Responsable Inscripto",
            "Monotributista Social",
            "IVA No Alcanzado",
            "Proveedor del Exterior",
            "Iva Liberado Ley 19640"});
            this.cmbTipoCons.Location = new System.Drawing.Point(608, 118);
            this.cmbTipoCons.Name = "cmbTipoCons";
            this.cmbTipoCons.Size = new System.Drawing.Size(319, 28);
            this.cmbTipoCons.TabIndex = 18;
            
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(608, 52);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(319, 26);
            this.txtApellido.TabIndex = 16;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(504, 54);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 22);
            this.lblApellido.TabIndex = 27;
            this.lblApellido.Text = "Apellido";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(61, 300);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 29);
            this.textBox1.TabIndex = 27;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnBuscarCliente.AutoSize = false;
            this.btnBuscarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnBuscarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBuscarCliente.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnBuscarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnBuscarCliente.Depth = 0;
            this.btnBuscarCliente.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.HighEmphasis = true;
            this.btnBuscarCliente.Icon = null;
            this.btnBuscarCliente.Location = new System.Drawing.Point(467, 299);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarCliente.Size = new System.Drawing.Size(101, 30);
            this.btnBuscarCliente.TabIndex = 23;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarCliente.UseAccentColor = true;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // btnClienteRegistrar
            // 
            this.btnClienteRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClienteRegistrar.AutoSize = false;
            this.btnClienteRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClienteRegistrar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClienteRegistrar.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnClienteRegistrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClienteRegistrar.Depth = 0;
            this.btnClienteRegistrar.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteRegistrar.HighEmphasis = true;
            this.btnClienteRegistrar.Icon = null;
            this.btnClienteRegistrar.Location = new System.Drawing.Point(604, 299);
            this.btnClienteRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClienteRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClienteRegistrar.Name = "btnClienteRegistrar";
            this.btnClienteRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClienteRegistrar.Size = new System.Drawing.Size(101, 30);
            this.btnClienteRegistrar.TabIndex = 24;
            this.btnClienteRegistrar.Text = "Registrar";
            this.btnClienteRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClienteRegistrar.UseAccentColor = true;
            this.btnClienteRegistrar.UseVisualStyleBackColor = false;
            this.btnClienteRegistrar.Click += new System.EventHandler(this.btnClienteRegistrar_Click);
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnActualizarCliente.AutoSize = false;
            this.btnActualizarCliente.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarCliente.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnActualizarCliente.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnActualizarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizarCliente.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnActualizarCliente.Depth = 0;
            this.btnActualizarCliente.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarCliente.HighEmphasis = true;
            this.btnActualizarCliente.Icon = null;
            this.btnActualizarCliente.Location = new System.Drawing.Point(739, 299);
            this.btnActualizarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarCliente.Size = new System.Drawing.Size(101, 30);
            this.btnActualizarCliente.TabIndex = 25;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarCliente.UseAccentColor = true;
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnClienteEliminar
            // 
            this.btnClienteEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClienteEliminar.AutoSize = false;
            this.btnClienteEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClienteEliminar.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClienteEliminar.CharacterCasing = MaterialSkin.Controls.MaterialButton.CharacterCasingEnum.Title;
            this.btnClienteEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClienteEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnClienteEliminar.Depth = 0;
            this.btnClienteEliminar.Font = new System.Drawing.Font("Montserrat", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteEliminar.HighEmphasis = true;
            this.btnClienteEliminar.Icon = null;
            this.btnClienteEliminar.Location = new System.Drawing.Point(874, 299);
            this.btnClienteEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClienteEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClienteEliminar.Name = "btnClienteEliminar";
            this.btnClienteEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClienteEliminar.Size = new System.Drawing.Size(101, 30);
            this.btnClienteEliminar.TabIndex = 26;
            this.btnClienteEliminar.Text = "Eliminar";
            this.btnClienteEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClienteEliminar.UseAccentColor = true;
            this.btnClienteEliminar.UseVisualStyleBackColor = false;
            this.btnClienteEliminar.Click += new System.EventHandler(this.btnClienteEliminar_Click);
            // 
            // descripcionClientes
            // 
            this.descripcionClientes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descripcionClientes.AutoSize = true;
            this.descripcionClientes.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionClientes.Location = new System.Drawing.Point(29, 125);
            this.descripcionClientes.Name = "descripcionClientes";
            this.descripcionClientes.Size = new System.Drawing.Size(365, 84);
            this.descripcionClientes.TabIndex = 32;
            this.descripcionClientes.Text = "En este Modulo puede realizar altas, bajas\r\ny modificaciones. Tenga en cuenta que" +
    " \r\nalgunas funciones solo pueden ser usadas\r\ncon acceso administrador.";
            this.descripcionClientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.descripcionClientes.UseCompatibleTextRendering = true;
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(20, 299);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 33;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 70;
            this.iconPictureBox1.Location = new System.Drawing.Point(29, 20);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.iconPictureBox1.TabIndex = 28;
            this.iconPictureBox1.TabStop = false;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(988, 591);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.descripcionClientes);
            this.Controls.Add(this.btnClienteEliminar);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.btnClienteRegistrar);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.cmbTipoCons);
            this.Controls.Add(this.dgvLista);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTel2);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.txtdirec);
            this.Controls.Add(this.txtCuit);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LabelCliente);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Name = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel2;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtdirec;
        private System.Windows.Forms.TextBox txtCuit;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LabelCliente;
        private System.Windows.Forms.ComboBox cmbTipoCons;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private MaterialSkin.Controls.MaterialButton btnBuscarCliente;
        private MaterialSkin.Controls.MaterialButton btnClienteRegistrar;
        private MaterialSkin.Controls.MaterialButton btnActualizarCliente;
        private MaterialSkin.Controls.MaterialButton btnClienteEliminar;
        private System.Windows.Forms.Label descripcionClientes;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
    }
}