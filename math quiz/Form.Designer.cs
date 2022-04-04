
namespace math_quiz
{
    partial class Form
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
            this.components = new System.ComponentModel.Container();
            this.timeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.firstExample = new System.Windows.Forms.Label();
            this.secondExample = new System.Windows.Forms.Label();
            this.thirdExample = new System.Windows.Forms.Label();
            this.fourthExample = new System.Windows.Forms.Label();
            this.firstOut = new System.Windows.Forms.NumericUpDown();
            this.secondOut = new System.Windows.Forms.NumericUpDown();
            this.thirdOut = new System.Windows.Forms.NumericUpDown();
            this.fourthOut = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.firstOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthOut)).BeginInit();
            this.SuspendLayout();
            // 
            // timeLabel
            // 
            this.timeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(272, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(200, 30);
            this.timeLabel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Оставшееся время";
            // 
            // firstExample
            // 
            this.firstExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstExample.Location = new System.Drawing.Point(50, 75);
            this.firstExample.Name = "firstExample";
            this.firstExample.Size = new System.Drawing.Size(210, 34);
            this.firstExample.TabIndex = 2;
            this.firstExample.Text = "?";
            // 
            // secondExample
            // 
            this.secondExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondExample.Location = new System.Drawing.Point(50, 116);
            this.secondExample.Name = "secondExample";
            this.secondExample.Size = new System.Drawing.Size(210, 34);
            this.secondExample.TabIndex = 3;
            this.secondExample.Text = "?";
            // 
            // thirdExample
            // 
            this.thirdExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdExample.Location = new System.Drawing.Point(50, 157);
            this.thirdExample.Name = "thirdExample";
            this.thirdExample.Size = new System.Drawing.Size(210, 34);
            this.thirdExample.TabIndex = 4;
            this.thirdExample.Text = "?";
            // 
            // fourthExample
            // 
            this.fourthExample.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthExample.Location = new System.Drawing.Point(50, 197);
            this.fourthExample.Name = "fourthExample";
            this.fourthExample.Size = new System.Drawing.Size(210, 34);
            this.fourthExample.TabIndex = 5;
            this.fourthExample.Text = "?";
            // 
            // firstOut
            // 
            this.firstOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstOut.Location = new System.Drawing.Point(350, 73);
            this.firstOut.Name = "firstOut";
            this.firstOut.Size = new System.Drawing.Size(100, 35);
            this.firstOut.TabIndex = 1;
            // 
            // secondOut
            // 
            this.secondOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secondOut.Location = new System.Drawing.Point(350, 114);
            this.secondOut.Name = "secondOut";
            this.secondOut.Size = new System.Drawing.Size(100, 35);
            this.secondOut.TabIndex = 2;
            // 
            // thirdOut
            // 
            this.thirdOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.thirdOut.Location = new System.Drawing.Point(350, 155);
            this.thirdOut.Name = "thirdOut";
            this.thirdOut.Size = new System.Drawing.Size(100, 35);
            this.thirdOut.TabIndex = 3;
            // 
            // fourthOut
            // 
            this.fourthOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fourthOut.Location = new System.Drawing.Point(350, 196);
            this.fourthOut.Name = "fourthOut";
            this.fourthOut.Size = new System.Drawing.Size(100, 35);
            this.fourthOut.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(177, 262);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать тест";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 308);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fourthOut);
            this.Controls.Add(this.thirdOut);
            this.Controls.Add(this.secondOut);
            this.Controls.Add(this.firstOut);
            this.Controls.Add(this.fourthExample);
            this.Controls.Add(this.thirdExample);
            this.Controls.Add(this.secondExample);
            this.Controls.Add(this.firstExample);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "Form";
            this.Text = "Математический тест";
            ((System.ComponentModel.ISupportInitialize)(this.firstOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.secondOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thirdOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fourthOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label firstExample;
        private System.Windows.Forms.Label secondExample;
        private System.Windows.Forms.Label thirdExample;
        private System.Windows.Forms.Label fourthExample;
        private System.Windows.Forms.NumericUpDown firstOut;
        private System.Windows.Forms.NumericUpDown secondOut;
        private System.Windows.Forms.NumericUpDown thirdOut;
        private System.Windows.Forms.NumericUpDown fourthOut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}

