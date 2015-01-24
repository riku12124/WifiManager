namespace ExampleForm
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
				if(disposing && (components != null))
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
				this.ssidNameLabel = new System.Windows.Forms.Label();
				this.placeholder = new System.Windows.Forms.Label();
				this.detectedNetworksLabel = new System.Windows.Forms.Label();
				this.settingsButton = new System.Windows.Forms.Button();
				this.networkManagerButton = new System.Windows.Forms.Button();
				this.keepAliveCheckSetting = new System.Windows.Forms.CheckBox();
				this.helpButton = new System.Windows.Forms.Button();
				this.label1 = new System.Windows.Forms.Label();
				this.checkBox1 = new System.Windows.Forms.CheckBox();
				this.checkBox2 = new System.Windows.Forms.CheckBox();
				this.detectedNetworks = new System.Windows.Forms.ListBox();
				this.SuspendLayout();
				// 
				// ssidNameLabel
				// 
				this.ssidNameLabel.AutoSize = true;
				this.ssidNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
				this.ssidNameLabel.Location = new System.Drawing.Point(12, 9);
				this.ssidNameLabel.Name = "ssidNameLabel";
				this.ssidNameLabel.Size = new System.Drawing.Size(116, 25);
				this.ssidNameLabel.TabIndex = 1;
				this.ssidNameLabel.Text = "SSID Name";
				// 
				// placeholder
				// 
				this.placeholder.AutoSize = true;
				this.placeholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
				this.placeholder.Location = new System.Drawing.Point(134, 9);
				this.placeholder.Name = "placeholder";
				this.placeholder.Size = new System.Drawing.Size(119, 50);
				this.placeholder.TabIndex = 2;
				this.placeholder.Text = "<connection\r\nimage>";
				// 
				// detectedNetworksLabel
				// 
				this.detectedNetworksLabel.AutoSize = true;
				this.detectedNetworksLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
				this.detectedNetworksLabel.Location = new System.Drawing.Point(13, 70);
				this.detectedNetworksLabel.Name = "detectedNetworksLabel";
				this.detectedNetworksLabel.Size = new System.Drawing.Size(147, 20);
				this.detectedNetworksLabel.TabIndex = 4;
				this.detectedNetworksLabel.Text = "Detected networks:";
				// 
				// settingsButton
				// 
				this.settingsButton.Location = new System.Drawing.Point(378, 221);
				this.settingsButton.Name = "settingsButton";
				this.settingsButton.Size = new System.Drawing.Size(75, 23);
				this.settingsButton.TabIndex = 5;
				this.settingsButton.Text = "Settings";
				this.settingsButton.UseVisualStyleBackColor = true;
				// 
				// networkManagerButton
				// 
				this.networkManagerButton.Location = new System.Drawing.Point(346, 64);
				this.networkManagerButton.Name = "networkManagerButton";
				this.networkManagerButton.Size = new System.Drawing.Size(107, 23);
				this.networkManagerButton.TabIndex = 6;
				this.networkManagerButton.Text = "Network Manager";
				this.networkManagerButton.UseVisualStyleBackColor = true;
				// 
				// keepAliveCheckSetting
				// 
				this.keepAliveCheckSetting.AutoSize = true;
				this.keepAliveCheckSetting.Location = new System.Drawing.Point(17, 225);
				this.keepAliveCheckSetting.Name = "keepAliveCheckSetting";
				this.keepAliveCheckSetting.Size = new System.Drawing.Size(99, 17);
				this.keepAliveCheckSetting.TabIndex = 7;
				this.keepAliveCheckSetting.Text = "Quick Setting 1";
				this.keepAliveCheckSetting.UseVisualStyleBackColor = true;
				// 
				// helpButton
				// 
				this.helpButton.Location = new System.Drawing.Point(378, 9);
				this.helpButton.Name = "helpButton";
				this.helpButton.Size = new System.Drawing.Size(75, 25);
				this.helpButton.TabIndex = 8;
				this.helpButton.Text = "Display Help";
				this.helpButton.UseVisualStyleBackColor = true;
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
				this.label1.Location = new System.Drawing.Point(13, 39);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(73, 20);
				this.label1.TabIndex = 9;
				this.label1.Text = "dBm: -15";
				// 
				// checkBox1
				// 
				this.checkBox1.AutoSize = true;
				this.checkBox1.Location = new System.Drawing.Point(122, 225);
				this.checkBox1.Name = "checkBox1";
				this.checkBox1.Size = new System.Drawing.Size(99, 17);
				this.checkBox1.TabIndex = 10;
				this.checkBox1.Text = "Quick Setting 2";
				this.checkBox1.UseVisualStyleBackColor = true;
				// 
				// checkBox2
				// 
				this.checkBox2.AutoSize = true;
				this.checkBox2.Location = new System.Drawing.Point(227, 225);
				this.checkBox2.Name = "checkBox2";
				this.checkBox2.Size = new System.Drawing.Size(99, 17);
				this.checkBox2.TabIndex = 11;
				this.checkBox2.Text = "Quick Setting 3";
				this.checkBox2.UseVisualStyleBackColor = true;
				// 
				// detectedNetworks
				// 
				this.detectedNetworks.FormattingEnabled = true;
				this.detectedNetworks.Location = new System.Drawing.Point(17, 94);
				this.detectedNetworks.Name = "detectedNetworks";
				this.detectedNetworks.Size = new System.Drawing.Size(436, 121);
				this.detectedNetworks.TabIndex = 12;
				// 
				// Form1
				// 
				this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(465, 256);
				this.Controls.Add(this.detectedNetworks);
				this.Controls.Add(this.checkBox2);
				this.Controls.Add(this.checkBox1);
				this.Controls.Add(this.label1);
				this.Controls.Add(this.helpButton);
				this.Controls.Add(this.keepAliveCheckSetting);
				this.Controls.Add(this.networkManagerButton);
				this.Controls.Add(this.settingsButton);
				this.Controls.Add(this.detectedNetworksLabel);
				this.Controls.Add(this.placeholder);
				this.Controls.Add(this.ssidNameLabel);
				this.MaximizeBox = false;
				this.Name = "Form1";
				this.Text = "WiFi Connection Manager";
				this.Load += new System.EventHandler(this.Form1_Load);
				this.ResumeLayout(false);
				this.PerformLayout();

		  }

		  #endregion

		  private System.Windows.Forms.Label ssidNameLabel;
		  private System.Windows.Forms.Label placeholder;
		  private System.Windows.Forms.Label detectedNetworksLabel;
		  private System.Windows.Forms.Button settingsButton;
		  private System.Windows.Forms.Button networkManagerButton;
		  private System.Windows.Forms.CheckBox keepAliveCheckSetting;
		  private System.Windows.Forms.Button helpButton;
		  private System.Windows.Forms.Label label1;
		  private System.Windows.Forms.CheckBox checkBox1;
		  private System.Windows.Forms.CheckBox checkBox2;
		  private System.Windows.Forms.ListBox detectedNetworks;

	 }
}

