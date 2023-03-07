
namespace OOP_Projekt2_NikitaSkakun58524
{
    partial class Prezenter
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnKreślenieFigurILinii = new System.Windows.Forms.Button();
            this.btnPrezentacjaFigurZeSlajderem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKreślenieFigurILinii
            // 
            this.btnKreślenieFigurILinii.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnKreślenieFigurILinii.Location = new System.Drawing.Point(833, 266);
            this.btnKreślenieFigurILinii.Name = "btnKreślenieFigurILinii";
            this.btnKreślenieFigurILinii.Size = new System.Drawing.Size(300, 80);
            this.btnKreślenieFigurILinii.TabIndex = 7;
            this.btnKreślenieFigurILinii.Text = "Kreślenie figur i linii";
            this.btnKreślenieFigurILinii.UseVisualStyleBackColor = true;
            this.btnKreślenieFigurILinii.Click += new System.EventHandler(this.btnKreślenieFigurILinii_Click);
            // 
            // btnPrezentacjaFigurZeSlajderem
            // 
            this.btnPrezentacjaFigurZeSlajderem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPrezentacjaFigurZeSlajderem.Location = new System.Drawing.Point(240, 266);
            this.btnPrezentacjaFigurZeSlajderem.Name = "btnPrezentacjaFigurZeSlajderem";
            this.btnPrezentacjaFigurZeSlajderem.Size = new System.Drawing.Size(300, 80);
            this.btnPrezentacjaFigurZeSlajderem.TabIndex = 6;
            this.btnPrezentacjaFigurZeSlajderem.Text = "Prezentacja figur ze slajderem";
            this.btnPrezentacjaFigurZeSlajderem.UseVisualStyleBackColor = true;
            this.btnPrezentacjaFigurZeSlajderem.Click += new System.EventHandler(this.btnPrezentacjaFigurZeSlajderem_Click);
            // 
            // Prezenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 613);
            this.Controls.Add(this.btnKreślenieFigurILinii);
            this.Controls.Add(this.btnPrezentacjaFigurZeSlajderem);
            this.Name = "Prezenter";
            this.Text = "Prezenter";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKreślenieFigurILinii;
        private System.Windows.Forms.Button btnPrezentacjaFigurZeSlajderem;
    }
}

