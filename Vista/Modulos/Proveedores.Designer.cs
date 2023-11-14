
namespace Agm_Tools.Modulos
{
    partial class Proveedores
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
            this.toggleClientesInfo = new MaterialSkin.Controls.MaterialSwitch();
            this.descripcionProveedores = new System.Windows.Forms.Label();
            this.btnClienteEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnActualizarCliente = new MaterialSkin.Controls.MaterialButton();
            this.btnClienteRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.btnBuscarCliente = new MaterialSkin.Controls.MaterialButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.cmbTipoCons = new System.Windows.Forms.ComboBox();
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
            this.labelProveedores = new System.Windows.Forms.Label();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toggleClientesInfo
            // 
            this.toggleClientesInfo.AutoSize = true;
            this.toggleClientesInfo.Checked = true;
            this.toggleClientesInfo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toggleClientesInfo.Depth = 0;
            this.toggleClientesInfo.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleClientesInfo.Location = new System.Drawing.Point(32, 73);
            this.toggleClientesInfo.Margin = new System.Windows.Forms.Padding(0);
            this.toggleClientesInfo.MouseLocation = new System.Drawing.Point(-1, -1);
            this.toggleClientesInfo.MouseState = MaterialSkin.MouseState.HOVER;
            this.toggleClientesInfo.Name = "toggleClientesInfo";
            this.toggleClientesInfo.Ripple = true;
            this.toggleClientesInfo.Size = new System.Drawing.Size(58, 37);
            this.toggleClientesInfo.TabIndex = 62;
            this.toggleClientesInfo.UseVisualStyleBackColor = true;
            // 
            // descripcionProveedores
            // 
            this.descripcionProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.descripcionProveedores.AutoSize = true;
            this.descripcionProveedores.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descripcionProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.descripcionProveedores.Location = new System.Drawing.Point(28, 121);
            this.descripcionProveedores.Name = "descripcionProveedores";
            this.descripcionProveedores.Size = new System.Drawing.Size(365, 84);
            this.descripcionProveedores.TabIndex = 60;
            this.descripcionProveedores.Text = "En este Modulo puede realizar altas, bajas\r\ny modificaciones. Tenga en cuenta que" +
    " \r\nalgunas funciones solo pueden ser usadas\r\ncon acceso administrador.";
            this.descripcionProveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.descripcionProveedores.UseCompatibleTextRendering = true;
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
            this.btnClienteEliminar.Location = new System.Drawing.Point(873, 295);
            this.btnClienteEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClienteEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClienteEliminar.Name = "btnClienteEliminar";
            this.btnClienteEliminar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClienteEliminar.Size = new System.Drawing.Size(101, 30);
            this.btnClienteEliminar.TabIndex = 56;
            this.btnClienteEliminar.Text = "Eliminar";
            this.btnClienteEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClienteEliminar.UseAccentColor = true;
            this.btnClienteEliminar.UseVisualStyleBackColor = false;
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
            this.btnActualizarCliente.Location = new System.Drawing.Point(738, 295);
            this.btnActualizarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnActualizarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnActualizarCliente.Size = new System.Drawing.Size(101, 30);
            this.btnActualizarCliente.TabIndex = 55;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnActualizarCliente.UseAccentColor = true;
            this.btnActualizarCliente.UseVisualStyleBackColor = false;
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
            this.btnClienteRegistrar.Location = new System.Drawing.Point(603, 295);
            this.btnClienteRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnClienteRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnClienteRegistrar.Name = "btnClienteRegistrar";
            this.btnClienteRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnClienteRegistrar.Size = new System.Drawing.Size(101, 30);
            this.btnClienteRegistrar.TabIndex = 54;
            this.btnClienteRegistrar.Text = "Registrar";
            this.btnClienteRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnClienteRegistrar.UseAccentColor = true;
            this.btnClienteRegistrar.UseVisualStyleBackColor = false;
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
            this.btnBuscarCliente.Location = new System.Drawing.Point(466, 295);
            this.btnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnBuscarCliente.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnBuscarCliente.Size = new System.Drawing.Size(101, 30);
            this.btnBuscarCliente.TabIndex = 52;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnBuscarCliente.UseAccentColor = true;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(60, 296);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(391, 29);
            this.textBox1.TabIndex = 58;
            // 
            // lblApellido
            // 
            this.lblApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblApellido.Location = new System.Drawing.Point(503, 50);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(75, 22);
            this.lblApellido.TabIndex = 57;
            this.lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(607, 48);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(319, 26);
            this.txtApellido.TabIndex = 44;
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
            this.cmbTipoCons.Location = new System.Drawing.Point(607, 113);
            this.cmbTipoCons.Name = "cmbTipoCons";
            this.cmbTipoCons.Size = new System.Drawing.Size(319, 28);
            this.cmbTipoCons.TabIndex = 46;
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
            this.dgvLista.Location = new System.Drawing.Point(14, 334);
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
            this.dgvLista.TabIndex = 50;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(605, 246);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(319, 26);
            this.txtEmail.TabIndex = 51;
            // 
            // txtTel2
            // 
            this.txtTel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTel2.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel2.Location = new System.Drawing.Point(605, 213);
            this.txtTel2.Name = "txtTel2";
            this.txtTel2.Size = new System.Drawing.Size(319, 27);
            this.txtTel2.TabIndex = 49;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTel.Location = new System.Drawing.Point(605, 180);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(319, 26);
            this.txtTel.TabIndex = 48;
            // 
            // txtdirec
            // 
            this.txtdirec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtdirec.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdirec.Location = new System.Drawing.Point(605, 148);
            this.txtdirec.Name = "txtdirec";
            this.txtdirec.Size = new System.Drawing.Size(319, 26);
            this.txtdirec.TabIndex = 47;
            // 
            // txtCuit
            // 
            this.txtCuit.AcceptsTab = true;
            this.txtCuit.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCuit.Location = new System.Drawing.Point(607, 16);
            this.txtCuit.Name = "txtCuit";
            this.txtCuit.Size = new System.Drawing.Size(319, 26);
            this.txtCuit.TabIndex = 43;
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
            this.txtNombre.Location = new System.Drawing.Point(607, 81);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(319, 27);
            this.txtNombre.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(503, 248);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 22);
            this.label10.TabIndex = 41;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(503, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 22);
            this.label9.TabIndex = 40;
            this.label9.Text = "Teléfono 2";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(503, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 22);
            this.label8.TabIndex = 39;
            this.label8.Text = "Teléfono 1";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(503, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 22);
            this.label7.TabIndex = 38;
            this.label7.Text = "Dirección";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(503, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 22);
            this.label6.TabIndex = 37;
            this.label6.Text = "Tipo Cons.";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(503, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 22);
            this.label5.TabIndex = 36;
            this.label5.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(503, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 42;
            this.label4.Text = "CUIT / DNI";
            // 
            // labelProveedores
            // 
            this.labelProveedores.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelProveedores.AutoSize = true;
            this.labelProveedores.Font = new System.Drawing.Font("Montserrat Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProveedores.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelProveedores.Location = new System.Drawing.Point(121, 16);
            this.labelProveedores.Name = "labelProveedores";
            this.labelProveedores.Size = new System.Drawing.Size(138, 26);
            this.labelProveedores.TabIndex = 35;
            this.labelProveedores.Text = "Proveedores";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(19, 295);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 61;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlLightLight;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 70;
            this.iconPictureBox1.Location = new System.Drawing.Point(28, 16);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(70, 70);
            this.iconPictureBox1.TabIndex = 59;
            this.iconPictureBox1.TabStop = false;
            // 
            // Proveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(988, 591);
            this.Controls.Add(this.toggleClientesInfo);
            this.Controls.Add(this.iconPictureBox2);
            this.Controls.Add(this.descripcionProveedores);
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
            this.Controls.Add(this.labelProveedores);
            this.Name = "Proveedores";
            this.Text = "Proveedores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSwitch toggleClientesInfo;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.Label descripcionProveedores;
        private MaterialSkin.Controls.MaterialButton btnClienteEliminar;
        private MaterialSkin.Controls.MaterialButton btnActualizarCliente;
        private MaterialSkin.Controls.MaterialButton btnClienteRegistrar;
        private MaterialSkin.Controls.MaterialButton btnBuscarCliente;
        private System.Windows.Forms.TextBox textBox1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.ComboBox cmbTipoCons;
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
        private System.Windows.Forms.Label labelProveedores;
    }
}