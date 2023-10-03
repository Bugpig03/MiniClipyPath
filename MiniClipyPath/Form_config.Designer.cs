namespace MiniClipyPath
{
    partial class Form_config
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_config));
            label_title = new Label();
            textBox_name = new TextBox();
            label_custom_name = new Label();
            label_custom_path = new Label();
            textBox_path = new TextBox();
            button_save = new Button();
            button_cancel = new Button();
            SuspendLayout();
            // 
            // label_title
            // 
            label_title.AutoSize = true;
            label_title.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label_title.Location = new Point(12, 9);
            label_title.Name = "label_title";
            label_title.Size = new Size(173, 32);
            label_title.TabIndex = 0;
            label_title.Text = "Configuration :";
            // 
            // textBox_name
            // 
            textBox_name.Location = new Point(12, 82);
            textBox_name.MaxLength = 21;
            textBox_name.Name = "textBox_name";
            textBox_name.Size = new Size(183, 27);
            textBox_name.TabIndex = 1;
            // 
            // label_custom_name
            // 
            label_custom_name.AutoSize = true;
            label_custom_name.Location = new Point(12, 59);
            label_custom_name.Name = "label_custom_name";
            label_custom_name.Size = new Size(155, 20);
            label_custom_name.TabIndex = 2;
            label_custom_name.Text = "Custom name button :";
            // 
            // label_custom_path
            // 
            label_custom_path.AutoSize = true;
            label_custom_path.Location = new Point(12, 129);
            label_custom_path.Name = "label_custom_path";
            label_custom_path.Size = new Size(155, 20);
            label_custom_path.TabIndex = 3;
            label_custom_path.Text = "Custom name button :";
            // 
            // textBox_path
            // 
            textBox_path.Location = new Point(12, 152);
            textBox_path.Name = "textBox_path";
            textBox_path.Size = new Size(758, 27);
            textBox_path.TabIndex = 4;
            // 
            // button_save
            // 
            button_save.Location = new Point(676, 202);
            button_save.Name = "button_save";
            button_save.Size = new Size(94, 39);
            button_save.TabIndex = 5;
            button_save.Text = "save";
            button_save.UseVisualStyleBackColor = true;
            button_save.Click += button_save_Click;
            // 
            // button_cancel
            // 
            button_cancel.Location = new Point(576, 202);
            button_cancel.Name = "button_cancel";
            button_cancel.Size = new Size(94, 39);
            button_cancel.TabIndex = 6;
            button_cancel.Text = "cancel";
            button_cancel.UseVisualStyleBackColor = true;
            button_cancel.Click += button_cancel_Click;
            // 
            // Form_config
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 253);
            Controls.Add(button_cancel);
            Controls.Add(button_save);
            Controls.Add(textBox_path);
            Controls.Add(label_custom_path);
            Controls.Add(label_custom_name);
            Controls.Add(textBox_name);
            Controls.Add(label_title);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(800, 300);
            MinimumSize = new Size(800, 300);
            Name = "Form_config";
            Text = "Button setup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label_title;
        public TextBox textBox_name;
        private Label label_custom_name;
        private Label label_custom_path;
        public TextBox textBox_path;
        private Button button_save;
        private Button button_cancel;
    }
}