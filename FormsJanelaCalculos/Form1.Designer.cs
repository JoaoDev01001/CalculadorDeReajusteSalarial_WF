namespace FormsJanelaCalculos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent ()
        {
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtSalario = new TextBox();
            label2 = new Label();
            txtHoraTrabalhada = new TextBox();
            txtSituacaoSalarial = new TextBox();
            bttCalcular = new Button();
            lbxResumo = new ListBox();
            toolTip1 = new ToolTip(components);
            gbxCategoria = new GroupBox();
            rbttVeterano = new RadioButton();
            rbttCalouro = new RadioButton();
            gbxTurno = new GroupBox();
            rbttNoturno = new RadioButton();
            rbttVespertino = new RadioButton();
            rbttMatutino = new RadioButton();
            gbxCategoria.SuspendLayout();
            gbxTurno.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20 , 43);
            label1.Name = "label1";
            label1.Size = new Size(113 , 20);
            label1.TabIndex = 1;
            label1.Text = "Salário Mínimo:";
            // 
            // txtSalario
            // 
            txtSalario.Location = new Point(159 , 41);
            txtSalario.Name = "txtSalario";
            txtSalario.Size = new Size(169 , 27);
            txtSalario.TabIndex = 2;
            toolTip1.SetToolTip(txtSalario , "Informe o salário mínimo atual.\r\n");
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20 , 77);
            label2.Name = "label2";
            label2.Size = new Size(133 , 20);
            label2.TabIndex = 3;
            label2.Text = "Horas trabalhadas:";
            // 
            // txtHoraTrabalhada
            // 
            txtHoraTrabalhada.Location = new Point(159 , 74);
            txtHoraTrabalhada.Name = "txtHoraTrabalhada";
            txtHoraTrabalhada.Size = new Size(169 , 27);
            txtHoraTrabalhada.TabIndex = 4;
            // 
            // txtSituacaoSalarial
            // 
            txtSituacaoSalarial.BackColor = Color.Yellow;
            txtSituacaoSalarial.Location = new Point(12 , 435);
            txtSituacaoSalarial.Name = "txtSituacaoSalarial";
            txtSituacaoSalarial.ReadOnly = true;
            txtSituacaoSalarial.Size = new Size(346 , 27);
            txtSituacaoSalarial.TabIndex = 5;
            // 
            // bttCalcular
            // 
            bttCalcular.BackColor = SystemColors.Control;
            bttCalcular.Location = new Point(384 , 429);
            bttCalcular.Name = "bttCalcular";
            bttCalcular.Size = new Size(116 , 38);
            bttCalcular.TabIndex = 6;
            bttCalcular.Text = "Calcular";
            bttCalcular.UseVisualStyleBackColor = false;
            bttCalcular.Click += bttCalcular_Click;
            // 
            // lbxResumo
            // 
            lbxResumo.FormattingEnabled = true;
            lbxResumo.Location = new Point(12 , 204);
            lbxResumo.MultiColumn = true;
            lbxResumo.Name = "lbxResumo";
            lbxResumo.SelectionMode = SelectionMode.MultiSimple;
            lbxResumo.Size = new Size(488 , 204);
            lbxResumo.TabIndex = 7;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Ajuda";
            // 
            // gbxCategoria
            // 
            gbxCategoria.Controls.Add(rbttVeterano);
            gbxCategoria.Controls.Add(rbttCalouro);
            gbxCategoria.Location = new Point(12 , 135);
            gbxCategoria.Name = "gbxCategoria";
            gbxCategoria.Size = new Size(316 , 63);
            gbxCategoria.TabIndex = 8;
            gbxCategoria.TabStop = false;
            gbxCategoria.Text = "Categoria";
            // 
            // rbttVeterano
            // 
            rbttVeterano.AutoSize = true;
            rbttVeterano.Location = new Point(147 , 26);
            rbttVeterano.Name = "rbttVeterano";
            rbttVeterano.Size = new Size(89 , 24);
            rbttVeterano.TabIndex = 1;
            rbttVeterano.TabStop = true;
            rbttVeterano.Text = "Veterano";
            rbttVeterano.UseVisualStyleBackColor = true;
            // 
            // rbttCalouro
            // 
            rbttCalouro.AutoSize = true;
            rbttCalouro.Location = new Point(6 , 26);
            rbttCalouro.Name = "rbttCalouro";
            rbttCalouro.Size = new Size(82 , 24);
            rbttCalouro.TabIndex = 0;
            rbttCalouro.TabStop = true;
            rbttCalouro.Text = "Calouro";
            rbttCalouro.UseVisualStyleBackColor = true;
            // 
            // gbxTurno
            // 
            gbxTurno.Controls.Add(rbttNoturno);
            gbxTurno.Controls.Add(rbttVespertino);
            gbxTurno.Controls.Add(rbttMatutino);
            gbxTurno.Location = new Point(344 , 43);
            gbxTurno.Name = "gbxTurno";
            gbxTurno.Size = new Size(156 , 155);
            gbxTurno.TabIndex = 9;
            gbxTurno.TabStop = false;
            gbxTurno.Text = "Turno";
            // 
            // rbttNoturno
            // 
            rbttNoturno.AutoSize = true;
            rbttNoturno.Location = new Point(6 , 112);
            rbttNoturno.Name = "rbttNoturno";
            rbttNoturno.Size = new Size(85 , 24);
            rbttNoturno.TabIndex = 2;
            rbttNoturno.TabStop = true;
            rbttNoturno.Text = "Noturno";
            rbttNoturno.UseVisualStyleBackColor = true;
            // 
            // rbttVespertino
            // 
            rbttVespertino.AutoSize = true;
            rbttVespertino.Location = new Point(6 , 73);
            rbttVespertino.Name = "rbttVespertino";
            rbttVespertino.Size = new Size(100 , 24);
            rbttVespertino.TabIndex = 1;
            rbttVespertino.TabStop = true;
            rbttVespertino.Text = "Vespertino";
            rbttVespertino.UseVisualStyleBackColor = true;
            // 
            // rbttMatutino
            // 
            rbttMatutino.AutoSize = true;
            rbttMatutino.Location = new Point(6 , 32);
            rbttMatutino.Name = "rbttMatutino";
            rbttMatutino.Size = new Size(90 , 24);
            rbttMatutino.TabIndex = 0;
            rbttMatutino.TabStop = true;
            rbttMatutino.Text = "Matutino";
            rbttMatutino.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512 , 485);
            Controls.Add(gbxTurno);
            Controls.Add(gbxCategoria);
            Controls.Add(lbxResumo);
            Controls.Add(bttCalcular);
            Controls.Add(txtSituacaoSalarial);
            Controls.Add(txtHoraTrabalhada);
            Controls.Add(label2);
            Controls.Add(txtSalario);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Cálculo de Salário";
            gbxCategoria.ResumeLayout(false);
            gbxCategoria.PerformLayout();
            gbxTurno.ResumeLayout(false);
            gbxTurno.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox txtSalario;
        private Label label2;
        private TextBox txtHoraTrabalhada;
        private TextBox txtSituacaoSalarial;
        private Button bttCalcular;
        private ListBox lbxResumo;
        private ToolTip toolTip1;
        private GroupBox gbxCategoria;
        private RadioButton rbttVeterano;
        private RadioButton rbttCalouro;
        private GroupBox gbxTurno;
        private RadioButton rbttNoturno;
        private RadioButton rbttVespertino;
        private RadioButton rbttMatutino;
    }
}
