  using HR_admenstration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;


namespace School_HR_ManagementSystem
{
  public enum EmpType
    {
        Teacher,
        Head_of_department,
        Head_of_master
    }
   
    class Program
    {
     public static   List<EmployeeInterface> Employee = new List<EmployeeInterface>();



        static void Main(string[] args)
        {
          
            screen_interface();
        }
        public static decimal Get_Total_Salary()
        {
            decimal total_salary=0;
            foreach (EmployeeInterface emp in Employee)
                total_salary += emp.Salary;
            return total_salary;
        }

        public static void screen_interface()
        {
            Regex reg = new Regex("(^[أ-ي]+(\\s[أ-ي]*$)|(^[a-z A-Z]+(\\s[a-z A-Z]+)*$))");
          
        // form container desigen;
        Form system_screen = new Form();
            system_screen.Size = new Size(640, 506);
            system_screen.Text = "School human Rsource system";
            system_screen.StartPosition = FormStartPosition.CenterScreen;
            system_screen.MinimizeBox = false;
            system_screen.MaximizeBox = false;
            system_screen.BackColor = Color.Aqua;
           // system_screen.ForeColor = Color.AliceBlue;
            #region Labels
            // ID label
            Label id_lbl = new Label();
            id_lbl.AutoSize = true;
            id_lbl.Location = new Point(29, 41);
            id_lbl.Size = new Size(51, 19);
            id_lbl.TabIndex = 0;
            id_lbl.Text = "Employee Id:";

            //first name lable
            Label fst_name_lbl = new Label();
          fst_name_lbl.AutoSize = true;
           fst_name_lbl.Location = new Point(29, 72);
           fst_name_lbl.Size = new Size(51, 19);
           fst_name_lbl.TabIndex = 1;
           fst_name_lbl.Text = "First Name:";

            //last name label
            Label lst_name_lbl = new Label();
            lst_name_lbl.AutoSize = true;
            lst_name_lbl.Location = new Point(29, 102);
            lst_name_lbl.Size = new Size(51, 19);
            lst_name_lbl.TabIndex = 2;
            lst_name_lbl.Text = "last Name:";
            // salary lable
            Label salary_lbl = new Label();
            salary_lbl.AutoSize = true;
            salary_lbl.Location = new Point(20, 135);
            salary_lbl.Size = new Size(51, 19);
           salary_lbl.TabIndex = 3;
            salary_lbl.Text = "Employee Salary:";
            //emploee number lbl
            Label empnum_lbl = new Label();
            empnum_lbl.AutoSize = true;
            empnum_lbl.Font = new Font(FontFamily.GenericMonospace, 10, FontStyle.Italic);
            empnum_lbl.Location = new Point(29, 335);
            empnum_lbl.Size = new Size(51, 19);
            empnum_lbl.TabIndex = 10;
            empnum_lbl.Text = "The aemployees are:";

            // employees conter
            Label empcount_lbl = new Label();
            empcount_lbl.Location = new Point(400, 335);
            empcount_lbl.AutoSize = true;
            empcount_lbl.Font = new Font(FontFamily.GenericMonospace, 14, FontStyle.Italic);
            empcount_lbl.Size = new Size(51, 19);
            empcount_lbl.TabIndex = 11;
            empcount_lbl.Text = " ";
            // salary avg label
            Label salavg_lbl = new Label();
            salavg_lbl.Font = new Font(FontFamily.GenericMonospace, 10, FontStyle.Italic);
            salavg_lbl.AutoSize = true;
            salavg_lbl.Location = new Point(29, 400);
            salavg_lbl.Size = new Size(51, 19);
            salavg_lbl.TabIndex = 12;
            salavg_lbl.Text = "The average  total salary is : ";

            // Average lable
            Label average_lbl = new Label();
            average_lbl.Font = new Font(FontFamily.GenericMonospace, 14, FontStyle.Italic);
            average_lbl.AutoSize = true;
            average_lbl.Location = new Point(400, 400);
            average_lbl.Size = new Size(51, 19);
            average_lbl.TabIndex = 13;
            average_lbl.Text = " ";
            #endregion
            #region TextBoxes
            // ID text box
            TextBox id_txtbx = new TextBox();
           id_txtbx.Location = new Point(115, 41);
            id_txtbx.BorderStyle = BorderStyle.FixedSingle;
            id_txtbx.Size = new Size(292, 27);
           id_txtbx.TabIndex = 4;
           // id_txtbx.Text = " ";
            // first name txtbox
            TextBox FirstNmae_txtbx = new TextBox();
            FirstNmae_txtbx.Location = new Point(115, 72);
            FirstNmae_txtbx.BorderStyle = BorderStyle.FixedSingle;
            FirstNmae_txtbx.Size = new Size(292, 27);
            FirstNmae_txtbx.TabIndex = 5;
            //last name text box
            TextBox LastnName_txtbx = new TextBox();
            LastnName_txtbx.Location = new Point(115, 102);
            LastnName_txtbx.BorderStyle = BorderStyle.FixedSingle;
            LastnName_txtbx.Size = new Size(292, 27);
            LastnName_txtbx.TabIndex = 6;
            // Salary textbox 
            TextBox salary_txtbx = new TextBox();
            salary_txtbx.Location = new Point(115, 135);
            salary_txtbx.BorderStyle = BorderStyle.FixedSingle;
            salary_txtbx.Size = new Size(292, 27);
            salary_txtbx.TabIndex = 7;
            #endregion



            #region Buttons
            // Add button
            Button Add_btn = new Button();
           Add_btn.Location = new Point(382, 201);
            Add_btn.Size = new Size(100, 34);
            Add_btn.FlatStyle = FlatStyle.Popup;
            Add_btn.TabIndex = 8;
            Add_btn.Text = "Add";
            Add_btn.UseVisualStyleBackColor = true;
            Add_btn.BackColor = Color.DarkBlue;
            Add_btn.ForeColor = Color.White;
            Add_btn.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Italic);
            // Remove button
            Button remove_btn = new Button();
            remove_btn.Location = new Point(499, 201);
            remove_btn.Size = new Size(100, 34);
            remove_btn.FlatStyle = FlatStyle.Popup;
            remove_btn.TabIndex = 9;
            remove_btn.Text = "Rrmove";
            remove_btn.UseVisualStyleBackColor = true;
            remove_btn.BackColor = Color.DarkBlue;
            remove_btn.ForeColor = Color.White;
            remove_btn.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Italic);
            // search button
            Button Search_btn = new Button();
            Search_btn.Location = new Point(50, 201);
            Search_btn.FlatStyle = FlatStyle.Popup;
            Search_btn.Size = new Size(100, 34);
            Search_btn.TabIndex = 14;
            Search_btn.Text = "Search";
            Search_btn.UseVisualStyleBackColor = true;
            Search_btn.BackColor = Color.DarkBlue;
            Search_btn.ForeColor = Color.White;
            Search_btn.Font = new Font(FontFamily.GenericSansSerif, 14, FontStyle.Italic);

            #endregion


            // combo box 
            ComboBox EmployeeType = new ComboBox();
            EmployeeType.Location = new Point(id_lbl.Width + id_txtbx.Width + 100, 60);
            EmployeeType.Items.AddRange(Enum.GetNames(typeof(EmpType)));
            EmployeeType.SelectedIndex = 0;
            #region events
            Add_btn.Click += delegate
            {
                if (id_txtbx.Text == "" || FirstNmae_txtbx.Text == "" || LastnName_txtbx.Text == "" || salary_txtbx.Text == "")
                {
                    MessageBox.Show("One of the feilds is empty!", " empty feild", MessageBoxButtons.OK
                        , MessageBoxIcon.Warning);

                }
                else
                {
                    EmployeeInterface employees = new EmployeeTEmplate();
                    
                    if (Employee.Count == 0)
                    {
                        
                        employees.id = Convert.ToInt32(id_txtbx.Text);
                        employees.FstName = FirstNmae_txtbx.Text;
                        employees.lstName = LastnName_txtbx.Text;

                        switch (EmployeeType.SelectedItem)
                        {
                            case "Teacher":
                                employees.Salary = Convert.ToDecimal(salary_txtbx.Text) + (Convert.ToInt32(salary_txtbx.Text)) * 0.02m;
                                break;
                            case "Head_of_department":
                                employees.Salary = Convert.ToDecimal(salary_txtbx.Text) + (Convert.ToInt32(salary_txtbx.Text)) * 0.03m;
                                break;
                            case "Head_of_master":
                                employees.Salary = Convert.ToDecimal(salary_txtbx.Text) + (Convert.ToInt32(salary_txtbx.Text)) * 0.04m;
                                break;
                        }
                    }
                    else
                    {
                        foreach(EmployeeInterface employ in Employee)
                        {
                            if (id_txtbx.Text == employ.id.ToString())
                            {
                                MessageBox.Show("the employee is realy exist!");
                                
                                return;
                            }
                        }
                        employees.id = Convert.ToInt32(id_txtbx.Text);
                        employees.FstName = FirstNmae_txtbx.Text;
                        employees.lstName = LastnName_txtbx.Text;

                        switch (EmployeeType.SelectedItem)
                        {
                            case "Teacher":
                                employees.Salary = Convert.ToDecimal(salary_txtbx.Text) + (Convert.ToInt32(salary_txtbx.Text)) * 0.02m;
                                break;
                            case "Head_of_department":
                                employees.Salary = Convert.ToDecimal(salary_txtbx.Text) + (Convert.ToInt32(salary_txtbx.Text)) * 0.03m;
                                break;
                            case "Head_of_master":
                                employees.Salary = Convert.ToDecimal(salary_txtbx.Text) + (Convert.ToInt32(salary_txtbx.Text)) * 0.04m;
                                break;
                        }
                    }

                    Employee.Add(employees);
                    empcount_lbl.Text = Employee.Count.ToString();
                    average_lbl.Text = Get_Total_Salary().ToString();
                    id_txtbx.Clear();
                    FirstNmae_txtbx.Clear();
                    LastnName_txtbx.Clear();
                    salary_txtbx.Clear();
                    id_txtbx.Focus();

                }


            };
            Search_btn.Click += delegate
            {
                foreach(EmployeeInterface employ in Employee)
                {
                    if (id_txtbx.Text == employ.id.ToString())
                    {
                        MessageBox.Show("the employee is realy exist!");
                        FirstNmae_txtbx.Text = employ.FstName;
                        LastnName_txtbx.Text = employ.lstName;
                        salary_txtbx.Text = employ.Salary.ToString();
                        return;
                    }
                
               


                 }
                MessageBox.Show("item is not exist!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            };
            remove_btn.Click += delegate
            {
                int index;
                foreach (EmployeeInterface employ in Employee)
                {
                    if (id_txtbx.Text == employ.id.ToString())
                    {
                        Employee.Remove(employ);
                        MessageBox.Show("Item removed successfull", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        empcount_lbl.Text = Employee.Count.ToString();
                        average_lbl.Text = Get_Total_Salary().ToString();
                        id_txtbx.Clear();
                        FirstNmae_txtbx.Clear();
                        LastnName_txtbx.Clear();
                        salary_txtbx.Clear();
                        id_txtbx.Focus();
                        return;
                    }
                    
                    
                      
                    
                    




                }
                MessageBox.Show("item is not exist!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            };
            id_txtbx.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                e.Handled = !char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar);
            };
            salary_txtbx.KeyPress += delegate (object sender, KeyPressEventArgs e)
              {
                  if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                      (e.KeyChar != '.'))
                  {
                      e.Handled = true;
                      MessageBox.Show("error only numbers");
                  }

                  // only allow one decimal point
                  if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                  {
                      e.Handled = true;
                  }
              };
            FirstNmae_txtbx.KeyPress += delegate (object sender, KeyPressEventArgs e)
              {
                  if(reg.IsMatch(e.KeyChar.ToString())|| char.IsControl(e.KeyChar))
                      {
                      e.Handled = false;
                  }
                 
                  else
                  {
                      e.Handled = true;
                      MessageBox.Show("only characters go here ", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  }

              };
            LastnName_txtbx.KeyPress += delegate (object sender, KeyPressEventArgs e)
            {
                if (reg.IsMatch(e.KeyChar.ToString()) || char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }

                else
                {
                    e.Handled = true;
                    MessageBox.Show("only characters go here ", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            };
            remove_btn.MouseHover += delegate
            {
                remove_btn.BackColor = Color.Red;

            };
            remove_btn.MouseLeave += delegate
            {
                remove_btn.BackColor = Color.DarkBlue;
            };
            #endregion

            #region Add controls area

            system_screen.Controls.Add(fst_name_lbl);
            system_screen.Controls.Add(id_lbl);
            system_screen.Controls.Add(id_txtbx);
            system_screen.Controls.Add(FirstNmae_txtbx);
            system_screen.Controls.Add(lst_name_lbl);
            system_screen.Controls.Add(LastnName_txtbx);
            system_screen.Controls.Add(salary_lbl);
            system_screen.Controls.Add(salary_txtbx);
            system_screen.Controls.Add(Add_btn);
            system_screen.Controls.Add(remove_btn);
            system_screen.Controls.Add(Search_btn);
            system_screen.Controls.Add(empcount_lbl);
            system_screen.Controls.Add(empnum_lbl);
            system_screen.Controls.Add(average_lbl);
            system_screen.Controls.Add(salavg_lbl);
            system_screen.Controls.Add(EmployeeType);
            #endregion
            system_screen.ShowDialog();

        }
    }
  

}
