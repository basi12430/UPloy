namespace UPloy
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        private TabControl navigationTabs;

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
            this.components = new System.ComponentModel.Container();
            this.navigationTabs = new TabControl();
            this.SuspendLayout();
            // 
            // navigationTabs
            // 
            this.navigationTabs.Alignment = TabAlignment.Left;
            this.navigationTabs.Dock = DockStyle.Fill;
            this.navigationTabs.Multiline = true;
            this.navigationTabs.SizeMode = TabSizeMode.Fixed;
            this.navigationTabs.ItemSize = new Size(40, 120);
            // 
            // Form1
            // 
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.navigationTabs);
            this.Text = "UPloy";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
