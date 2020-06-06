namespace mqtt1
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
            this.startMqtt_button = new System.Windows.Forms.Button();
            this.MQtt_button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startMqtt_button
            // 
            this.startMqtt_button.Location = new System.Drawing.Point(62, 36);
            this.startMqtt_button.Name = "startMqtt_button";
            this.startMqtt_button.Size = new System.Drawing.Size(135, 42);
            this.startMqtt_button.TabIndex = 0;
            this.startMqtt_button.Text = "startMqtt";
            this.startMqtt_button.UseVisualStyleBackColor = true;
            this.startMqtt_button.Click += new System.EventHandler(this.startMqtt_button_Click);
            // 
            // MQtt_button2
            // 
            this.MQtt_button2.Location = new System.Drawing.Point(62, 134);
            this.MQtt_button2.Name = "MQtt_button2";
            this.MQtt_button2.Size = new System.Drawing.Size(135, 35);
            this.MQtt_button2.TabIndex = 1;
            this.MQtt_button2.Text = "start2";
            this.MQtt_button2.UseVisualStyleBackColor = true;
            this.MQtt_button2.Click += new System.EventHandler(this.MQtt_button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MQtt_button2);
            this.Controls.Add(this.startMqtt_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startMqtt_button;
        private System.Windows.Forms.Button MQtt_button2;
    }
}

