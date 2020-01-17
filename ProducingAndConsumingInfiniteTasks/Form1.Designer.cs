namespace ProducingAndConsumingInfiniteTasks
{
    partial class Form1
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
            this.BtnStartInfinityLoop = new System.Windows.Forms.Button();
            this.BtnStopInfinityLoop = new System.Windows.Forms.Button();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnStartInfinityLoop
            // 
            this.BtnStartInfinityLoop.Location = new System.Drawing.Point(33, 21);
            this.BtnStartInfinityLoop.Name = "BtnStartInfinityLoop";
            this.BtnStartInfinityLoop.Size = new System.Drawing.Size(102, 23);
            this.BtnStartInfinityLoop.TabIndex = 0;
            this.BtnStartInfinityLoop.Text = "Start Infinity Loop";
            this.BtnStartInfinityLoop.UseVisualStyleBackColor = true;
            this.BtnStartInfinityLoop.Click += new System.EventHandler(this.BtnStartInfinityLoop_Click);
            // 
            // BtnStopInfinityLoop
            // 
            this.BtnStopInfinityLoop.Enabled = false;
            this.BtnStopInfinityLoop.Location = new System.Drawing.Point(163, 21);
            this.BtnStopInfinityLoop.Name = "BtnStopInfinityLoop";
            this.BtnStopInfinityLoop.Size = new System.Drawing.Size(102, 23);
            this.BtnStopInfinityLoop.TabIndex = 1;
            this.BtnStopInfinityLoop.Text = "Stop Infinity Loop";
            this.BtnStopInfinityLoop.UseVisualStyleBackColor = true;
            this.BtnStopInfinityLoop.Click += new System.EventHandler(this.BtnStopInfinityLoop_Click);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(33, 71);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.ReadOnly = true;
            this.TxtResult.Size = new System.Drawing.Size(232, 20);
            this.TxtResult.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 120);
            this.Controls.Add(this.TxtResult);
            this.Controls.Add(this.BtnStopInfinityLoop);
            this.Controls.Add(this.BtnStartInfinityLoop);
            this.Name = "Form1";
            this.Text = "Producing and consuming infinite Tasks in C#";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnStartInfinityLoop;
        private System.Windows.Forms.Button BtnStopInfinityLoop;
        private System.Windows.Forms.TextBox TxtResult;
    }
}

