using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject.Backend
{
    public class UserInputValidator
    {
        private TextBox[] textboxes;
        private ComboBox[] comboboxes;

        public UserInputValidator(ComboBox automobileType, TextBox carsID, ComboBox carsColor, ComboBox carsBrand, TextBox carOwner)
        {
            this.comboboxes = new ComboBox[3];
            this.textboxes = new TextBox[2];
            this.textboxes[0] = carsID;
            this.textboxes[1] = carOwner;
            this.comboboxes[0] = automobileType;
            this.comboboxes[1] = carsColor;
            this.comboboxes[2] = carsBrand;
        }
        public UserInputValidator(TextBox motorID, ComboBox motorColor, ComboBox motorBrand, TextBox motorOwner)
        {
            this.comboboxes = new ComboBox[2];
            this.textboxes = new TextBox[2];
            this.textboxes[0] = motorID;
            this.textboxes[1] = motorOwner;
            this.comboboxes[0] = motorColor;
            this.comboboxes[1] = motorBrand;
        }

        public bool ValidateInput()
        {
            foreach (var textbox in textboxes)
            {
                if (textbox.Text.Length == 0)
                {
                    MessageBox.Show("Invalid input, Please check again.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            
            
            foreach (var combobox in comboboxes)
            {
                if (!IsEmpty(combobox))
                {
                    MessageBox.Show("Invalid value in the combobox.", "Invalid Input",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }

            return true;
        }

        private bool IsValueWithinOptions(ComboBox combobox)
        {
            return combobox.SelectedItem != null && combobox.Items.Contains(combobox.SelectedItem);
        }
        private bool IsEmpty(ComboBox combobox)
        {
            if(combobox.SelectedItem==null|| combobox.SelectedItem.ToString() == "")
            {
                return false;
            }
            return true;
        }
    }
}
