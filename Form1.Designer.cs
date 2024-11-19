
namespace bott
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
            this.btnbloqueia = new System.Windows.Forms.Button();
            this.btndesbloqueia = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnbloqueia
            // 
            this.btnbloqueia.Location = new System.Drawing.Point(586, 155);
            this.btnbloqueia.Name = "btnbloqueia";
            this.btnbloqueia.Size = new System.Drawing.Size(119, 51);
            this.btnbloqueia.TabIndex = 0;
            this.btnbloqueia.Text = "btnbloqueia";
            this.btnbloqueia.UseVisualStyleBackColor = true;
            this.btnbloqueia.Click += new System.EventHandler(this.btnbloqueia_Click);
            // 
            // btndesbloqueia
            // 
            this.btndesbloqueia.Location = new System.Drawing.Point(586, 230);
            this.btndesbloqueia.Name = "btndesbloqueia";
            this.btndesbloqueia.Size = new System.Drawing.Size(119, 49);
            this.btndesbloqueia.TabIndex = 1;
            this.btndesbloqueia.Text = "btndesbloqueia";
            this.btndesbloqueia.UseVisualStyleBackColor = true;
            this.btndesbloqueia.Click += new System.EventHandler(this.btndesbloqueia_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(31, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 42);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(31, 278);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(158, 41);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(31, 146);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(158, 51);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btndesbloqueia);
            this.Controls.Add(this.btnbloqueia);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnbloqueia;
        private System.Windows.Forms.Button btndesbloqueia;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

