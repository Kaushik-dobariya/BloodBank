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
    public partial class frmDonors : Form
    {
        public frmDonors()
        {
            InitializeComponent();
        }
        //Create object of Donor BLL and Donor DAL
        donorBLL d = new donorBLL();
        donorDAL dal = new donorDAL();
        userDAL udal = new userDAL();

        //Global Variable for Image
        string imageName = "no-image.jpg";
        string sourcePath = "";
        string destinationPath = "";

        string rowHeaderImage;

        private void frmDonors_Load(object sender, EventArgs e)
        {
            //Display Donors in DataGrid View
            DataTable dt = dal.Select();
            dgvDonors.DataSource = dt;

            //First we need to get the image Path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

            string imagepath = path + "\\images\\no-image.jpg";

            //Display Image in PictureBox
            pictureBoxProfilePicture.Image = new Bitmap(imagepath);
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            //Close this form
            this.Hide();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input fields before proceeding
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(cmbGender.Text) ||
                string.IsNullOrWhiteSpace(cmbBloodGroup.Text) ||
                string.IsNullOrWhiteSpace(txtContact.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("Please fill out all required fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method to prevent further execution
            }

            // We will write the code to Add new Donor
            // Step 1: Get the Data from Manage Donors Form
            d.first_name = txtFirstName.Text.Trim();
            d.last_name = txtLastName.Text.Trim();
            d.email = txtEmail.Text.Trim();
            d.gender = cmbGender.Text;
            d.blood_group = cmbBloodGroup.Text;
            d.contact = txtContact.Text.Trim();
            d.address = txtAddress.Text.Trim();
            d.added_date = DateTime.Now;

            // Get the ID of Logged-In User
            string loggedInUser = frmLogin.loggedInUser;
            userBLL usr = udal.GetIDFromUsername(loggedInUser);

            d.added_by = usr.user_id;
            d.image_name = imageName;

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
            bool isSuccess = dal.Insert(d); // Insert data and check success

            if (isSuccess)
            {
                // Data inserted successfully
                MessageBox.Show("New Donor Added Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Refresh DataGridView
                DataTable dt = dal.Select();
                dgvDonors.DataSource = dt;

                // Clear all the TextBoxes
                Clear();
            }
            else
            {
                // Failed to insert data
                MessageBox.Show("Failed to add new donor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }//end of ADD


        //Create a Method to Clear all the Textboxes
        public void Clear()
        {
            //Clear all the TExtboxes
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtDonorID.Text = "";
            cmbGender.Text = "";
            cmbBloodGroup.Text = "";
            txtContact.Text = "";
            txtAddress.Text = "";
            imageName = "no-image.jpg";

            //Clear the PictureBox
            //First we need to get the image Path
            string path = Application.StartupPath.Substring(0, (Application.StartupPath.Length) - 10);

            string imagepath = path + "\\images\\no-image.jpg";

            //Display Image in PictureBox
            pictureBoxProfilePicture.Image = new Bitmap(imagepath);
        }

        private void dgvDonors_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //SElect the DAta from DAtagrid View and Display in our Form

            //1. Find the Row Selected
            int RowIndex = e.RowIndex;

            txtDonorID.Text = dgvDonors.Rows[RowIndex].Cells[0].Value.ToString();
            txtFirstName.Text = dgvDonors.Rows[RowIndex].Cells[1].Value.ToString();
            txtLastName.Text = dgvDonors.Rows[RowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dgvDonors.Rows[RowIndex].Cells[3].Value.ToString();
            txtContact.Text = dgvDonors.Rows[RowIndex].Cells[4].Value.ToString();
            cmbGender.Text = dgvDonors.Rows[RowIndex].Cells[5].Value.ToString();
            txtAddress.Text = dgvDonors.Rows[RowIndex].Cells[6].Value.ToString();
            cmbBloodGroup.Text = dgvDonors.Rows[RowIndex].Cells[7].Value.ToString();

            imageName = dgvDonors.Rows[RowIndex].Cells[9].Value.ToString();

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
        }


        // Code for updating the donor information including image update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate if required fields are filled
                if (string.IsNullOrWhiteSpace(txtDonorID.Text))
                {
                    MessageBox.Show("Donor ID is required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // 1. Get the Values from Form
                d.donor_id = int.Parse(txtDonorID.Text);
                d.first_name = txtFirstName.Text.Trim();
                d.last_name = txtLastName.Text.Trim();
                d.email = txtEmail.Text.Trim();
                d.gender = cmbGender.Text.Trim();
                d.blood_group = cmbBloodGroup.Text.Trim();
                d.contact = txtContact.Text.Trim();
                d.address = txtAddress.Text.Trim();

                // Validate if at least one field has data
                if (string.IsNullOrWhiteSpace(d.first_name) &&
                    string.IsNullOrWhiteSpace(d.last_name) &&
                    string.IsNullOrWhiteSpace(d.email) &&
                    string.IsNullOrWhiteSpace(d.gender) &&
                    string.IsNullOrWhiteSpace(d.blood_group) &&
                    string.IsNullOrWhiteSpace(d.contact) &&
                    string.IsNullOrWhiteSpace(d.address))
                {
                    MessageBox.Show("Please provide data to update.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Get The ID of Logged In User
                string loggedInUser = frmLogin.loggedInUser;
                userBLL usr = udal.GetIDFromUsername(loggedInUser);
                d.added_by = usr.user_id;

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
                        d.image_name = imageName; // Update the image name after copying
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
                    d.image_name = rowHeaderImage; // Keep previous image name
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
                bool isSuccess = dal.Update(d);

                if (isSuccess)
                {
                    // Donor Updated Successfully
                    MessageBox.Show("Donor updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();

                    // Refresh DataGridView
                    DataTable dt = dal.Select();
                    dgvDonors.DataSource = dt;
                }
                else
                {
                    // Failed to Update
                    MessageBox.Show("Failed to update donor. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            if (string.IsNullOrEmpty(txtDonorID.Text) || !int.TryParse(txtDonorID.Text, out int donorId))
            {
                MessageBox.Show("Please select a valid Donor ID to erase.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the method if the Donor ID is invalid
            }

            // Show a confirmation dialog before proceeding
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to erase this donor?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            // If the user clicks "Yes", proceed with the deletion
            if (dialogResult == DialogResult.Yes)
            {
                // Set the donor ID for deletion
                d.donor_id = donorId;

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
                bool isSuccess = dal.Delete(d);

                if (isSuccess)
                {
                    // Donor Deleted Successfully
                    MessageBox.Show("Donor Deleted Successfully.");

                    Clear();

                    // Refresh DataGrid View
                    DataTable dt = dal.Select();
                    dgvDonors.DataSource = dt;
                }
                else
                {
                    // Failed to Delete Donor
                    MessageBox.Show("Failed to Delete Donor");
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
            //Clear the TExtboxes
            Clear();
        }

        // Code for selecting an image
        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            try
            {
                // Code to Select Image and Upload
                OpenFileDialog open = new OpenFileDialog
                {
                    // Allow only image files
                    Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif)|*.jpg;*.jpeg;*.png;*.gif"
                };

                if (open.ShowDialog() == DialogResult.OK)
                {
                    if (open.CheckFileExists)
                    {
                        // Display the selected image in PictureBox
                        pictureBoxProfilePicture.Image = new Bitmap(open.FileName);

                        // Generate a unique name for the image
                        string ext = Path.GetExtension(open.FileName);
                        Guid g = Guid.NewGuid();
                        imageName = "Blood_Bank_MS_" + g + ext;

                        // Define source and destination paths
                        sourcePath = open.FileName;
                        string paths = Application.StartupPath.Substring(0, Application.StartupPath.Length - 10);
                        destinationPath = Path.Combine(paths, "images", imageName);

                        // Inform user that the image is ready for upload but only upload during update
                        MessageBox.Show("Image selected successfully.",
                                        "Image Selected",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                // Log or display any error that occurs
                MessageBox.Show("An error occurred while selecting the image: " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            // Get the keywords typed in the search text box
            string keywords = txtSearch.Text;

            // Check if the keywords are not empty
            if (!string.IsNullOrEmpty(keywords))
            {
                // Call the DAL Search method to search the donors based on the keywords
                DataTable dt = dal.Search(keywords);
                dgvDonors.DataSource = dt; // Update the DataGridView with search results
            }
            else
            {
                // If the search box is empty, display all donors
                DataTable dt = dal.Select(); // Fetch all records
                dgvDonors.DataSource = dt; // Display in the DataGridView
            }
        }


        private void pictureBoxProfilePicture_Click(object sender, EventArgs e)
        {

        }

        private void lblBloodGroup_Click(object sender, EventArgs e)
        {

        }
    }
}
