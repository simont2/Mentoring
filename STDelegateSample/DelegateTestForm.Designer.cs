namespace STDelegateSample
{
    partial class DelegateTestForm
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
            this.CounterLabel = new System.Windows.Forms.Label();
            this.CounterValueTxt = new System.Windows.Forms.TextBox();
            this.CounterOutput = new System.Windows.Forms.Label();
            this.StartActionButton = new System.Windows.Forms.Button();
            this.StopActionButton = new System.Windows.Forms.Button();
            this.event1Label = new System.Windows.Forms.Label();
            this.event2Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CounterLabel
            // 
            this.CounterLabel.AutoSize = true;
            this.CounterLabel.Location = new System.Drawing.Point(72, 61);
            this.CounterLabel.Name = "CounterLabel";
            this.CounterLabel.Size = new System.Drawing.Size(98, 17);
            this.CounterLabel.TabIndex = 0;
            this.CounterLabel.Text = "Counter Value";
            // 
            // CounterValueTxt
            // 
            this.CounterValueTxt.Location = new System.Drawing.Point(219, 61);
            this.CounterValueTxt.Name = "CounterValueTxt";
            this.CounterValueTxt.Size = new System.Drawing.Size(165, 22);
            this.CounterValueTxt.TabIndex = 1;
            this.CounterValueTxt.Text = "1000";
            this.CounterValueTxt.TextChanged += new System.EventHandler(this.CounterValueTxt_TextChanged);
            // 
            // CounterOutput
            // 
            this.CounterOutput.AutoSize = true;
            this.CounterOutput.Location = new System.Drawing.Point(195, 158);
            this.CounterOutput.Name = "CounterOutput";
            this.CounterOutput.Size = new System.Drawing.Size(16, 17);
            this.CounterOutput.TabIndex = 2;
            this.CounterOutput.Text = "0";
            // 
            // StartActionButton
            // 
            this.StartActionButton.Location = new System.Drawing.Point(406, 56);
            this.StartActionButton.Name = "StartActionButton";
            this.StartActionButton.Size = new System.Drawing.Size(75, 32);
            this.StartActionButton.TabIndex = 3;
            this.StartActionButton.Text = "Start";
            this.StartActionButton.UseVisualStyleBackColor = true;
            this.StartActionButton.Click += new System.EventHandler(this.StartActionButton_Click);
            // 
            // StopActionButton
            // 
            this.StopActionButton.Location = new System.Drawing.Point(502, 56);
            this.StopActionButton.Name = "StopActionButton";
            this.StopActionButton.Size = new System.Drawing.Size(75, 32);
            this.StopActionButton.TabIndex = 4;
            this.StopActionButton.Text = "Stop";
            this.StopActionButton.UseVisualStyleBackColor = true;
            this.StopActionButton.Click += new System.EventHandler(this.StopActionButton_Click);
            // 
            // event1Label
            // 
            this.event1Label.AutoSize = true;
            this.event1Label.Location = new System.Drawing.Point(403, 114);
            this.event1Label.Name = "event1Label";
            this.event1Label.Size = new System.Drawing.Size(56, 17);
            this.event1Label.TabIndex = 5;
            this.event1Label.Text = "Event 1";
            // 
            // event2Label
            // 
            this.event2Label.AutoSize = true;
            this.event2Label.Location = new System.Drawing.Point(403, 147);
            this.event2Label.Name = "event2Label";
            this.event2Label.Size = new System.Drawing.Size(56, 17);
            this.event2Label.TabIndex = 6;
            this.event2Label.Text = "Event 2";
            // 
            // DelegateTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 241);
            this.Controls.Add(this.event2Label);
            this.Controls.Add(this.event1Label);
            this.Controls.Add(this.StopActionButton);
            this.Controls.Add(this.StartActionButton);
            this.Controls.Add(this.CounterOutput);
            this.Controls.Add(this.CounterValueTxt);
            this.Controls.Add(this.CounterLabel);
            this.Name = "DelegateTestForm";
            this.Text = "Delegate Test Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CounterLabel;
        private System.Windows.Forms.TextBox CounterValueTxt;
        private System.Windows.Forms.Label CounterOutput;
        private System.Windows.Forms.Button StartActionButton;
        private System.Windows.Forms.Button StopActionButton;
        private System.Windows.Forms.Label event1Label;
        private System.Windows.Forms.Label event2Label;
    }
}

