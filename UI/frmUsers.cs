using BloodBankManagementSystem.BLL;
using BloodBankManagementSystem.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodBankManagementSystem.UI
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }

        //Create Objects of userBLL and userDAL
        userBLL u = new userBLL();
        userDAL dal = new userDAL();

        string imageName = "no-image.jpg";
        string sourcePath = "";
        string destinationPath = "";

        //Global Variabel for the image to delete
        string rowHeaderImage;

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Add functionality to close this form
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input fields before proceeding
            if (string.IsNullOrWhiteSpace(txtFullName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method to prevent further execution
            }

            // We will write the code to Add new Donor
            // Step 1: Get the Data from Manage Donors Form
            u.full_name = txtFullName.Text;
            u.email = txtEmail.Text;
            u.username = txtUsername.Text;
            u.password = txtPassword.Text;
            u.contact = txtContact.Text;
            u.address = txtAddress.Text;
            u.added_date = DateTime.Now;
            u.image_name = imageName;


            // Upload image
            if (imageName != "no-image.jpg" && !string.IsNullOrEmpty(sourcePath))
            {
                try
                {
                    // Upload the image
                    File.Copy(sourcePath, destinationPath, overwrite: true);
                }
                catch (IOException ex)
                {
                    MessageBox.Show($"Failed to upload the image: {ex.Message}", "Image Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method if the image upload fails
                }
            }

            // Step 2: Insert Data into Database
            bool isSuccess = dal.Insert(u); // Insert data and check success

            if (isSuccess)
            {
                // Data inserted successfully
                MessageBox.Show("New User Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;

                // Clear all the TextBoxes
                Clear();
            }
            else
            {
                // Failed to insert data
                MessageBox.Show("Failed to Add New User.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end of ADD


        //Method or Function to Clear TextBoxes
        public void Clear()
        {
            txtFullName.Text = "";
            txtEmail.Text = "";
            txtUsername.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            txtPassword.Text = "";
            txtUserID.Text = "";
            //Path to Destination Folder
            //Get the Image path
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string imagePath = paths + "\\images\\no-image.jpg";
            //Diplay in Picture Box
            pictureBoxProfilePicture.Image = new Bitmap(imagePath);
        }

        private void dgvUsers_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //Find the Row Index of the Row Clicked on Users Data Frid View
            int RowIndex = e.RowIndex;
            txtUserID.Text = dgvUsers.Rows[RowIndex].Cells[0].Value.ToString();
            txtUsername.Text = dgvUsers.Rows[RowIndex].Cells[1].Value.ToString();
            txtEmail.Text = dgvUsers.Rows[RowIndex].Cells[2].Value.ToString();
            txtPassword.Text = dgvUsers.Rows[RowIndex].Cells[3].Value.ToString();
            txtFullName.Text = dgvUsers.Rows[RowIndex].Cells[4].Value.ToString();
            txtContact.Text = dgvUsers.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvUsers.Rows[RowIndex].Cells[6].Value.ToString();
            imageName = dgvUsers.Rows[RowIndex].Cells[8].Value.ToString();

            //Update the VAlue of rowHeaderImage
            rowHeaderImage = imageName;

            //Display The image of Selected Donor
            // Get the image path
            string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);
            string imagePath = paths + "\\images\\" + imageName;

            try
            {
                if (!string.IsNullOrEmpty(imageName))
                {
                    if (File.Exists(imagePath))
                    {
                        // Dispose of the current image if already loaded
                        if (pictureBoxProfilePicture.Image != null)
                        {
                            pictureBoxProfilePicture.Image.Dispose();
                        }

                        // Load the new image
                        pictureBoxProfilePicture.Image = new Bitmap(imagePath);
                    }
                    else
                    {
                        MessageBox.Show("The specified image file does not exist: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pictureBoxProfilePicture.Image = null; // Clear the PictureBox
                    }
                }
                else
                {
                    MessageBox.Show("No data associated with the selected donor.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pictureBoxProfilePicture.Image = null; // Clear the PictureBox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading the image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end of frmUsers=no data available

        private void frmUsers_Load(object sender, EventArgs e)
        {
            //Display the Users in DAtagrid View When the Form is Loaded
            DataTable dt = dal.Select();
            dgvUsers.DataSource = dt;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate if required fields are filled
                if (string.IsNullOrWhiteSpace(txtUserID.Text))
                {
                    MessageBox.Show("User ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 1. Get the Values from Form
                u.user_id = int.Parse(txtUserID.Text);
                u.full_name = txtFullName.Text;
                u.email = txtEmail.Text;
                u.username = txtUsername.Text;
                u.password = txtPassword.Text;
                u.contact = txtContact.Text;
                u.address = txtAddress.Text;
                u.added_date = DateTime.Now;
                u.image_name = imageName;


                // Validate if at least one field has data
                if (
                   string.IsNullOrWhiteSpace(u.full_name) &&
                    string.IsNullOrWhiteSpace(u.email) &&
                    string.IsNullOrWhiteSpace(u.username) &&
                    string.IsNullOrWhiteSpace(u.password) &&
                    string.IsNullOrWhiteSpace(u.contact) &&
                    string.IsNullOrWhiteSpace(u.address))
                {
                    MessageBox.Show("Please provide data to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                

                // Check if the image was updated
                if (!string.IsNullOrEmpty(sourcePath) && sourcePath != destinationPath)
                {
                    // Process the image only if it's new or updated
                    try
                    {
                        // Ensure the destination folder exists
                        string destinationFolder = Path.GetDirectoryName(destinationPath);
                        if (!Directory.Exists(destinationFolder))
                        {
                            Directory.CreateDirectory(destinationFolder);
                        }

                        // Dispose of the image from PictureBox to release the lock
                        if (pictureBoxProfilePicture.Image != null)
                        {
                            pictureBoxProfilePicture.Image.Dispose();
                            pictureBoxProfilePicture.Image = null;
                        }

                        // Ensure the file is not being used by another process before copying
                        using (FileStream fs = new FileStream(sourcePath, FileMode.Open, FileAccess.Read, FileShare.None))
                        {
                            // Only copy the file if it's accessible
                            if (!File.Exists(destinationPath))
                            {
                                File.Copy(sourcePath, destinationPath);
                            }
                            else
                            {
                                File.Copy(sourcePath, destinationPath, overwrite: true);
                            }
                        }
                        u.image_name = imageName; // Update the image name after copying
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error while copying image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    // If the image was not updated, retain the existing image name
                    u.image_name = rowHeaderImage; // Keep previous image name
                }

                // Remove the previous image if necessary
                if (!string.IsNullOrEmpty(rowHeaderImage) && rowHeaderImage != "no-name.jpg")
                {
                    try
                    {
                        string path = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                        string imagePath = Path.Combine(path, "images", rowHeaderImage);

                        // Dispose of the image from PictureBox to release any file lock
                        if (pictureBoxProfilePicture.Image != null)
                        {
                            pictureBoxProfilePicture.Image.Dispose();
                            pictureBoxProfilePicture.Image = null;
                        }

                        // Ensure the file is not locked before attempting to delete
                        using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.ReadWrite, FileShare.None))
                        {
                            // If the file is accessible, delete it
                            if (File.Exists(imagePath))
                            {
                                File.Delete(imagePath);
                            }
                        }
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show($"Error deleting old image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                // 2. Update data in the database
                bool isSuccess = dal.Update(u);

                if (isSuccess)
                {
                    // User Updated Successfully
                    MessageBox.Show("User updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                    // Refresh DataGridView
                    DataTable dt = dal.Select();
                    dgvUsers.DataSource = dt;
                }
                else
                {
                    // Failed to Update
                    MessageBox.Show("Failed to update user. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please ensure all fields have correct data types.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if the Donor ID is provided and is valid
            if (string.IsNullOrEmpty(txtUserID.Text) || !int.TryParse(txtUserID.Text, out int userId))
            {
                MessageBox.Show("Please select a valid USER ID to erase.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the Donor ID is invalid
            }

            // Show a confirmation dialog before proceeding
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to erase this user?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // If the user clicks "Yes", proceed with the deletion
            if (dialogResult == DialogResult.Yes)
            {
                // Set the donor ID for deletion
                u.user_id = userId;

                // Check whether the donor has a profile picture or not
                if (rowHeaderImage != "no-image.jpg")
                {
                    try
                    {
                        // Only runs if the user has a custom image
                        // Get the path to the root folder of the project
                        string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

                        // Get the full path of the image
                        string imagePath = path + "\\images\\" + rowHeaderImage;

                        // Clear the PictureBox to release the image
                        if (pictureBoxProfilePicture.Image != null)
                        {
                            pictureBoxProfilePicture.Image.Dispose(); // Dispose of the image
                            pictureBoxProfilePicture.Image = null;    // Clear the PictureBox
                        }

                        // Call Garbage Collection to finalize the disposal
                        GC.Collect();
                        GC.WaitForPendingFinalizers();

                        // Delete the physical image file of the donor
                        File.Delete(imagePath);

                        // Call Clear function to reset the UI
                        Clear();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error deleting the image file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    // If the image is "no-image.jpg", skip deletion
                    //MessageBox.Show("Cannot delete default image: no-image.jpg", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                // Create a Boolean Variable to Check whether the donor deleted or not
                bool isSuccess = dal.Delete(u);

                if (isSuccess)
                {
                    // Donor Deleted Successfully
                    MessageBox.Show("User Erased Successfully.");

                    Clear();

                    // Refresh DataGrid View
                    DataTable dt = dal.Select();
                    dgvUsers.DataSource = dt;
                }
                else
                {
                    // Failed to Delete Donor
                    MessageBox.Show("Failed to Erase User");
                }
            }
            else
            {
                // If the user clicks "No", do nothing and return
                return;
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Call the user Function
            Clear();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            //Write the Code to Upload the Image of User
            //Open Dialog Box t Select Image
            OpenFileDialog open = new OpenFileDialog();

            //Filter the File Type, Only Allow Image File Types
            open.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.PNG; *.gif;)|*.jpg; *.jpeg; *.png; *.PNG; *.gif;";

            //Check if the file is selected or Not
            if(open.ShowDialog()==DialogResult.OK)
            {
                //Check if the file exists or not
                if(open.CheckFileExists)
                {
                    //DIsplay the Selected File on Picture Box
                    pictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                    //Rename the Image we selected
                    //1. Get the Extension of Image
                    string ext = Path.GetExtension(open.FileName);

                    //2. Generate Random Integer
                    Random random = new Random();
                    int RandInt = random.Next(0, 1000);

                    //3. REname the Image
                    imageName = "Blood_Bank_MS_" + RandInt + ext;

                    //4. Get the path of SElected Image
                    sourcePath = open.FileName;

                    //5. Get the Path of Destination
                    string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                    //Paths to Destination Folder
                    destinationPath = paths + "\\images\\" + imageName;

                    //6. Copy image to the Destination Folder
                    //File.Copy(sourcePath, destinationPath);

                    //7. Display Message
                    //MessageBox.Show("Image Successfully Uploaded.");
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //Write the Code to Get the users BAsed on Keywords
            //1. Get the Keywords from the TExtBox
            String keywords = txtSearch.Text;

            //Check whether the textbox is empty or not
            if(keywords!=null)
            {
                //TextBox is not empty, display users on DAta Grid View based on the keywords
                DataTable dt = dal.Search(keywords);
                dgvUsers.DataSource = dt;
            }
            else
            {
                //TExtbox is Empty and display all the users on DAta Grid View
                DataTable dt = dal.Select();
                dgvUsers.DataSource = dt;
            }
        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
