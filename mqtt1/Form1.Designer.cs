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
            this.MQtt_subscribe_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.mqtt_msg_box = new System.Windows.Forms.TextBox();
            this.mqtt_msg_cnt_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // MQtt_subscribe_button
            // 
            this.MQtt_subscribe_button.Location = new System.Drawing.Point(62, 134);
            this.MQtt_subscribe_button.Name = "MQtt_subscribe_button";
            this.MQtt_subscribe_button.Size = new System.Drawing.Size(135, 35);
            this.MQtt_subscribe_button.TabIndex = 1;
            this.MQtt_subscribe_button.Text = "Subsribe to Mqtt";
            this.MQtt_subscribe_button.UseVisualStyleBackColor = true;
            this.MQtt_subscribe_button.Click += new System.EventHandler(this.MQtt_button2_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(62, 345);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(155, 66);
            this.exit_button.TabIndex = 2;
            this.exit_button.Text = "exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // mqtt_msg_box
            // 
            this.mqtt_msg_box.Location = new System.Drawing.Point(710, 21);
            this.mqtt_msg_box.Name = "mqtt_msg_box";
            this.mqtt_msg_box.Size = new System.Drawing.Size(57, 20);
            this.mqtt_msg_box.TabIndex = 3;
            // 
            // mqtt_msg_cnt_box
            // 
            this.mqtt_msg_cnt_box.Location = new System.Drawing.Point(710, 57);
            this.mqtt_msg_cnt_box.Name = "mqtt_msg_cnt_box";
            this.mqtt_msg_cnt_box.Size = new System.Drawing.Size(57, 20);
            this.mqtt_msg_cnt_box.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mqtt message";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(572, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Mqtt messages counter";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mqtt_msg_cnt_box);
            this.Controls.Add(this.mqtt_msg_box);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.MQtt_subscribe_button);
            this.Controls.Add(this.startMqtt_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startMqtt_button;
        private System.Windows.Forms.Button MQtt_subscribe_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox mqtt_msg_box;
        private System.Windows.Forms.TextBox mqtt_msg_cnt_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

