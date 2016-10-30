namespace Fractal
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.click = new System.Windows.Forms.Button();
            this.NViewText = new System.Windows.Forms.Label();
            this.HViewText = new System.Windows.Forms.Label();
            this.NView = new System.Windows.Forms.NumericUpDown();
            this.title = new System.Windows.Forms.Label();
            this.HView = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HView)).BeginInit();
            this.SuspendLayout();
            // 
            // click
            // 
            this.click.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.click.Location = new System.Drawing.Point(117, 128);
            this.click.Name = "click";
            this.click.Size = new System.Drawing.Size(102, 39);
            this.click.TabIndex = 0;
            this.click.Text = "Нарисовать";
            this.click.UseVisualStyleBackColor = true;
            this.click.Click += new System.EventHandler(this.click_Click);
            // 
            // NViewText
            // 
            this.NViewText.AutoSize = true;
            this.NViewText.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NViewText.Location = new System.Drawing.Point(29, 60);
            this.NViewText.Name = "NViewText";
            this.NViewText.Size = new System.Drawing.Size(175, 22);
            this.NViewText.TabIndex = 1;
            this.NViewText.Text = "N(кол-во итераций):";
            // 
            // HViewText
            // 
            this.HViewText.AutoSize = true;
            this.HViewText.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HViewText.Location = new System.Drawing.Point(29, 98);
            this.HViewText.Name = "HViewText";
            this.HViewText.Size = new System.Drawing.Size(168, 22);
            this.HViewText.TabIndex = 2;
            this.HViewText.Text = "H(длинна отрезка):";
            // 
            // NView
            // 
            this.NView.Location = new System.Drawing.Point(210, 64);
            this.NView.Name = "NView";
            this.NView.Size = new System.Drawing.Size(120, 20);
            this.NView.TabIndex = 3;
            this.NView.ValueChanged += new System.EventHandler(this.NView_ValueChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.title.Location = new System.Drawing.Point(27, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(302, 33);
            this.title.TabIndex = 5;
            this.title.Text = "Треугольник Серпинского";
            // 
            // HView
            // 
            this.HView.Location = new System.Drawing.Point(210, 102);
            this.HView.Name = "HView";
            this.HView.Size = new System.Drawing.Size(120, 20);
            this.HView.TabIndex = 6;
            this.HView.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 179);
            this.Controls.Add(this.HView);
            this.Controls.Add(this.title);
            this.Controls.Add(this.NView);
            this.Controls.Add(this.HViewText);
            this.Controls.Add(this.NViewText);
            this.Controls.Add(this.click);
            this.Name = "Form1";
            this.Text = "Построение Фрактала";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button click;
        private System.Windows.Forms.Label NViewText;
        private System.Windows.Forms.Label HViewText;
        private System.Windows.Forms.NumericUpDown NView;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.NumericUpDown HView;
    }
}

