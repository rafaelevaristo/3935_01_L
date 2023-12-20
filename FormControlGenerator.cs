

namespace TrabalhoDois
{
    public static class FormControlGenerator
    {

        public static Button CreateMyButton(int posX, int posY, int width, int height, string text)
        {
            Button newButton = new Button();
            newButton.Location = new Point(posX, posY);
            newButton.Size = new Size(width, height);
            newButton.Text = text;

            return newButton;
        }

        public static Button CreateMyButton(int posX, int posY, int height, string text)
        {
            return CreateMyButton(posX, posY, 150, height, text);
        }


        public static Label CreateMyLabel(int posX, int posY, string text)
        {            
            return CreateMyLabel (posX,posY, 250, 25, text);
        }


        public static Label CreateMyLabel(int posX, int posY, int width, int height, string text)
        {
            Label newLabel = new Label();

            newLabel.Size = new Size(width, height);
            newLabel.Location = new Point(posX, posY);
            newLabel.Text = text;
            newLabel.TextAlign = ContentAlignment.MiddleCenter; // Center text alignment
            newLabel.AutoSize = false;

            return newLabel;
        }

        internal static ComboBox CreateMyComboBox(int posX, int posY, string[] comboOptions)
        {
            ComboBox newComboBox = new ComboBox();

            // Set its location and size
            newComboBox.Location = new System.Drawing.Point(posX, posY);
            newComboBox.Size = new System.Drawing.Size(150, 25);

            newComboBox.Items.AddRange(comboOptions);

            //// Add items to the ComboBox
            //foreach (var comboOption in comboOptions)
            //{
            //    newComboBox.Items.Add(comboOption);
            //}

            // Set the default selected item 
            newComboBox.SelectedIndex = 0;


            return newComboBox;

        }

        internal static TextBox CreateMyTextBox(int posX, int posY)
        {
            TextBox newTextBox = new TextBox();

            newTextBox.Location = new System.Drawing.Point(posX, posY + 7);
            newTextBox.Size = new Size(120, 60);
            //newTextBox.Font = new Font("Arial", 12, FontStyle.Regular);

            //newTextBox.BackColor = Color.FromArgb(255, 255, 255); // Dark textbox background color
            //newTextBox.ForeColor = Color.Black; // Set textbox text color
            //newTextBox.Font = new Font("Segoe UI", 12, FontStyle.Regular); // Regular font style
            //newTextBox.BorderStyle = BorderStyle.FixedSingle; // Fixed Single border style


            return newTextBox;
        }
    }
}
