namespace TestTSWAPI
{
    partial class Output_TB
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Refresh_B = new Button();
            Response_TB = new TextBox();
            Method_CB = new ComboBox();
            EndPoint_TB = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            APIKey_TB = new TextBox();
            SuspendLayout();
            // 
            // Refresh_B
            // 
            Refresh_B.Location = new Point(12, 581);
            Refresh_B.Name = "Refresh_B";
            Refresh_B.Size = new Size(241, 115);
            Refresh_B.TabIndex = 0;
            Refresh_B.Text = "Refresh";
            Refresh_B.UseVisualStyleBackColor = true;
            Refresh_B.Click += Refresh_B_Click;
            // 
            // Response_TB
            // 
            Response_TB.Location = new Point(12, 12);
            Response_TB.Multiline = true;
            Response_TB.Name = "Response_TB";
            Response_TB.Size = new Size(776, 563);
            Response_TB.TabIndex = 1;
            // 
            // Method_CB
            // 
            Method_CB.FormattingEnabled = true;
            Method_CB.Items.AddRange(new object[] { "List", "Get", "Set", "Info" });
            Method_CB.Location = new Point(259, 599);
            Method_CB.Name = "Method_CB";
            Method_CB.Size = new Size(95, 23);
            Method_CB.TabIndex = 2;
            Method_CB.SelectedIndexChanged += Method_CB_SelectedIndexChanged;
            // 
            // EndPoint_TB
            // 
            EndPoint_TB.Location = new Point(259, 643);
            EndPoint_TB.Name = "EndPoint_TB";
            EndPoint_TB.Size = new Size(529, 23);
            EndPoint_TB.TabIndex = 3;
            EndPoint_TB.Text = "CurrentDrivableActor";
            EndPoint_TB.TextChanged += EndPoint_TB_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(610, 684);
            label1.Name = "label1";
            label1.Size = new Size(178, 15);
            label1.TabIndex = 4;
            label1.Text = "Made by SpaceyKat with love <3";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(671, 669);
            label2.Name = "label2";
            label2.Size = new Size(136, 15);
            label2.TabIndex = 5;
            label2.Text = "TSWAPITest App V1A";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(259, 578);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 6;
            label3.Text = "Method Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 625);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 7;
            label4.Text = "End Point:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(384, 578);
            label5.Name = "label5";
            label5.Size = new Size(50, 15);
            label5.TabIndex = 8;
            label5.Text = "API Key:";
            // 
            // APIKey_TB
            // 
            APIKey_TB.Location = new Point(384, 599);
            APIKey_TB.Name = "APIKey_TB";
            APIKey_TB.Size = new Size(404, 23);
            APIKey_TB.TabIndex = 9;
            APIKey_TB.Text = "Vfrt5u42oNoHPXKuAVzTyYvUaiWU46ELlEoDaonu6Z0=";
            // 
            // Output_TB
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 708);
            Controls.Add(APIKey_TB);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EndPoint_TB);
            Controls.Add(Method_CB);
            Controls.Add(Response_TB);
            Controls.Add(Refresh_B);
            Name = "Output_TB";
            Text = "TSW API Test";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Refresh_B;
        private TextBox Response_TB;
        private ComboBox Method_CB;
        private TextBox EndPoint_TB;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox APIKey_TB;
    }
}

