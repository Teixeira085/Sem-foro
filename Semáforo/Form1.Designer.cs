namespace Semáforo
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
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.btnParar = new System.Windows.Forms.Button();
            this.verdePbx = new System.Windows.Forms.PictureBox();
            this.vermelhoPbx = new System.Windows.Forms.PictureBox();
            this.amareloPbx = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.verdePbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermelhoPbx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amareloPbx)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(23, 223);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(178, 54);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnParar
            // 
            this.btnParar.Location = new System.Drawing.Point(23, 298);
            this.btnParar.Name = "btnParar";
            this.btnParar.Size = new System.Drawing.Size(178, 43);
            this.btnParar.TabIndex = 2;
            this.btnParar.Text = "Parar";
            this.btnParar.UseVisualStyleBackColor = true;
            this.btnParar.Click += new System.EventHandler(this.btnParar_Click);
            // 
            // verdePbx
            // 
            this.verdePbx.Image = global::Semáforo.Properties.Resources._122504221_icono_de_semáforos_de_color_verde_estilo_realista;
            this.verdePbx.Location = new System.Drawing.Point(23, 14);
            this.verdePbx.Name = "verdePbx";
            this.verdePbx.Size = new System.Drawing.Size(167, 170);
            this.verdePbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.verdePbx.TabIndex = 3;
            this.verdePbx.TabStop = false;
            // 
            // vermelhoPbx
            // 
            this.vermelhoPbx.Image = global::Semáforo.Properties.Resources._124943359_icono_de_semáforo_de_color_rojo_ilustración_realista_de_semáforos_de_color_rojo_icono_vectoriales_pa;
            this.vermelhoPbx.Location = new System.Drawing.Point(34, 17);
            this.vermelhoPbx.Name = "vermelhoPbx";
            this.vermelhoPbx.Size = new System.Drawing.Size(156, 167);
            this.vermelhoPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.vermelhoPbx.TabIndex = 4;
            this.vermelhoPbx.TabStop = false;
            // 
            // amareloPbx
            // 
            this.amareloPbx.Image = global::Semáforo.Properties.Resources._124943363_icono_de_semáforo_de_color_amarillo_ilustración_realista_de_semáforos_de_color_amarillo_icono_vector;
            this.amareloPbx.Location = new System.Drawing.Point(34, 12);
            this.amareloPbx.Name = "amareloPbx";
            this.amareloPbx.Size = new System.Drawing.Size(156, 170);
            this.amareloPbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.amareloPbx.TabIndex = 5;
            this.amareloPbx.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 449);
            this.Controls.Add(this.vermelhoPbx);
            this.Controls.Add(this.amareloPbx);
            this.Controls.Add(this.btnParar);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.verdePbx);
            this.Name = "Form1";
            this.Text = "Semáforo";
            ((System.ComponentModel.ISupportInitialize)(this.verdePbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vermelhoPbx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amareloPbx)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.Button btnParar;
       // private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox verdePbx;
        private System.Windows.Forms.PictureBox vermelhoPbx;
        private System.Windows.Forms.PictureBox amareloPbx;
        private System.Windows.Forms.Timer timer2;
    }
}

