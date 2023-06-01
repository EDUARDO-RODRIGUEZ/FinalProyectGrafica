
namespace AppGrafica
{
    partial class Main
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxObjeto = new System.Windows.Forms.ComboBox();
            this.comboBoxFace = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTransform = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trackBarX = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.trackBarY = new System.Windows.Forms.TrackBar();
            this.label6 = new System.Windows.Forms.Label();
            this.trackBarZ = new System.Windows.Forms.TrackBar();
            this.buttonPlayAnimate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Objetos";
            // 
            // comboBoxObjeto
            // 
            this.comboBoxObjeto.FormattingEnabled = true;
            this.comboBoxObjeto.Location = new System.Drawing.Point(121, 33);
            this.comboBoxObjeto.Name = "comboBoxObjeto";
            this.comboBoxObjeto.Size = new System.Drawing.Size(249, 21);
            this.comboBoxObjeto.TabIndex = 1;
            this.comboBoxObjeto.SelectedValueChanged += new System.EventHandler(this.comboBoxObjeto_SelectedValueChanged);
            // 
            // comboBoxFace
            // 
            this.comboBoxFace.FormattingEnabled = true;
            this.comboBoxFace.Location = new System.Drawing.Point(121, 79);
            this.comboBoxFace.Name = "comboBoxFace";
            this.comboBoxFace.Size = new System.Drawing.Size(249, 21);
            this.comboBoxFace.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Caras";
            // 
            // comboBoxTransform
            // 
            this.comboBoxTransform.FormattingEnabled = true;
            this.comboBoxTransform.Location = new System.Drawing.Point(121, 128);
            this.comboBoxTransform.Name = "comboBoxTransform";
            this.comboBoxTransform.Size = new System.Drawing.Size(249, 21);
            this.comboBoxTransform.TabIndex = 5;
            this.comboBoxTransform.SelectedValueChanged += new System.EventHandler(this.comboBoxTransform_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tranformacion";
            // 
            // trackBarX
            // 
            this.trackBarX.Location = new System.Drawing.Point(121, 186);
            this.trackBarX.Name = "trackBarX";
            this.trackBarX.Size = new System.Drawing.Size(249, 45);
            this.trackBarX.TabIndex = 6;
            this.trackBarX.ValueChanged += new System.EventHandler(this.trackBarX_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Y";
            // 
            // trackBarY
            // 
            this.trackBarY.Location = new System.Drawing.Point(121, 246);
            this.trackBarY.Name = "trackBarY";
            this.trackBarY.Size = new System.Drawing.Size(249, 45);
            this.trackBarY.TabIndex = 8;
            this.trackBarY.ValueChanged += new System.EventHandler(this.trackBarY_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Z";
            // 
            // trackBarZ
            // 
            this.trackBarZ.Location = new System.Drawing.Point(121, 308);
            this.trackBarZ.Name = "trackBarZ";
            this.trackBarZ.Size = new System.Drawing.Size(249, 45);
            this.trackBarZ.TabIndex = 10;
            this.trackBarZ.ValueChanged += new System.EventHandler(this.trackBarZ_ValueChanged);
            // 
            // buttonPlayAnimate
            // 
            this.buttonPlayAnimate.Location = new System.Drawing.Point(15, 378);
            this.buttonPlayAnimate.Name = "buttonPlayAnimate";
            this.buttonPlayAnimate.Size = new System.Drawing.Size(72, 23);
            this.buttonPlayAnimate.TabIndex = 12;
            this.buttonPlayAnimate.Text = "Play";
            this.buttonPlayAnimate.UseVisualStyleBackColor = true;
            this.buttonPlayAnimate.Click += new System.EventHandler(this.buttonPlayAnimate_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 450);
            this.Controls.Add(this.buttonPlayAnimate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.trackBarZ);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBarY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.trackBarX);
            this.Controls.Add(this.comboBoxTransform);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxFace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxObjeto);
            this.Controls.Add(this.label1);
            this.Name = "Main";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarZ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxObjeto;
        private System.Windows.Forms.ComboBox comboBoxFace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxTransform;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar trackBarX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar trackBarY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar trackBarZ;
        private System.Windows.Forms.Button buttonPlayAnimate;
    }
}

