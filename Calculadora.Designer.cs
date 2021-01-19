namespace Calculadora
{
    partial class Calculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculadora));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox1Segundos = new System.Windows.Forms.TextBox();
            this.tbox1Minutos = new System.Windows.Forms.TextBox();
            this.tbox1Grau = new System.Windows.Forms.TextBox();
            this.tbox1TotalSegundos = new System.Windows.Forms.TextBox();
            this.limpar1 = new System.Windows.Forms.Button();
            this.calcular1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.tbox2Total = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbox2Segundos = new System.Windows.Forms.TextBox();
            this.tbox2Minuto = new System.Windows.Forms.TextBox();
            this.tbox2Grau = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            resources.ApplyResources(this.tabControl1, "tabControl1");
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.tbox1Segundos);
            this.tabPage1.Controls.Add(this.tbox1Minutos);
            this.tabPage1.Controls.Add(this.tbox1Grau);
            this.tabPage1.Controls.Add(this.tbox1TotalSegundos);
            this.tabPage1.Controls.Add(this.limpar1);
            this.tabPage1.Controls.Add(this.calcular1);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbox1Segundos
            // 
            resources.ApplyResources(this.tbox1Segundos, "tbox1Segundos");
            this.tbox1Segundos.Name = "tbox1Segundos";
            // 
            // tbox1Minutos
            // 
            resources.ApplyResources(this.tbox1Minutos, "tbox1Minutos");
            this.tbox1Minutos.Name = "tbox1Minutos";
            // 
            // tbox1Grau
            // 
            resources.ApplyResources(this.tbox1Grau, "tbox1Grau");
            this.tbox1Grau.Name = "tbox1Grau";
            // 
            // tbox1TotalSegundos
            // 
            resources.ApplyResources(this.tbox1TotalSegundos, "tbox1TotalSegundos");
            this.tbox1TotalSegundos.Name = "tbox1TotalSegundos";
            // 
            // limpar1
            // 
            resources.ApplyResources(this.limpar1, "limpar1");
            this.limpar1.Name = "limpar1";
            this.limpar1.UseVisualStyleBackColor = true;
            this.limpar1.Click += new System.EventHandler(this.limpar1_Click);
            // 
            // calcular1
            // 
            resources.ApplyResources(this.calcular1, "calcular1");
            this.calcular1.Name = "calcular1";
            this.calcular1.UseVisualStyleBackColor = true;
            this.calcular1.Click += new System.EventHandler(this.calcular1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbox2Total);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.tbox2Segundos);
            this.tabPage2.Controls.Add(this.tbox2Minuto);
            this.tabPage2.Controls.Add(this.tbox2Grau);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // tbox2Total
            // 
            resources.ApplyResources(this.tbox2Total, "tbox2Total");
            this.tbox2Total.Name = "tbox2Total";
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.limpar1_Click);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.calcular2_Click);
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // tbox2Segundos
            // 
            resources.ApplyResources(this.tbox2Segundos, "tbox2Segundos");
            this.tbox2Segundos.Name = "tbox2Segundos";
            // 
            // tbox2Minuto
            // 
            resources.ApplyResources(this.tbox2Minuto, "tbox2Minuto");
            this.tbox2Minuto.Name = "tbox2Minuto";
            // 
            // tbox2Grau
            // 
            resources.ApplyResources(this.tbox2Grau, "tbox2Grau");
            this.tbox2Grau.Name = "tbox2Grau";
            // 
            // Calculadora
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculadora";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox1Segundos;
        private System.Windows.Forms.TextBox tbox1Minutos;
        private System.Windows.Forms.TextBox tbox1Grau;
        private System.Windows.Forms.TextBox tbox1TotalSegundos;
        private System.Windows.Forms.Button limpar1;
        private System.Windows.Forms.Button calcular1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbox2Segundos;
        private System.Windows.Forms.TextBox tbox2Minuto;
        private System.Windows.Forms.TextBox tbox2Grau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbox2Total;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}

