namespace UPloy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Example: add two initial pages
            AddPage("Home", new Label { Text = "Willkommen", AutoSize = true, Anchor = AnchorStyles.Top | AnchorStyles.Left });
            AddPage("Einstellungen", new Label { Text = "Einstellungen", AutoSize = true, Anchor = AnchorStyles.Top | AnchorStyles.Left });
        }

        /// <summary>
        /// Adds a new page to the navigation tabs.
        /// </summary>
        /// <param name="title">The tab title to display.</param>
        /// <param name="content">The control to display when the tab is selected.</param>
        public void AddPage(string title, Control content)
        {
            var page = new TabPage(title);
            content.Dock = DockStyle.Fill;
            page.Controls.Add(content);
            navigationTabs.TabPages.Add(page);
        }
    }
}
