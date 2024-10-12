using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace WebApplication5
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        static string connString = ConfigurationManager.ConnectionStrings["EmpDBConnectionString"].ConnectionString;

        DataClasses1DataContext context = new DataClasses1DataContext(connString);
        void LoadGrid()
        {
            var data = from p in context.Employees
                       where p.EmpSalary > 20000
                       select p;
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            var data = from p in context.Employees
                       where p.EmpSalary > 20000
                       select p;
            GridView1.DataSource = data;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Employee em = new Employee();
            em.EmpId = int.Parse(TextBox1.Text);
            em.EmpName = TextBox2.Text;
            em.EmpSalary = int.Parse(TextBox3.Text);
            em.DeptId = int.Parse(TextBox4.Text);
            context.Employees.InsertOnSubmit(em);
            context.SubmitChanges();
            LoadGrid();



        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Employee emp = context.Employees.First(p => p.EmpId == int.Parse(TextBox1.Text));
            
            context.Employees.DeleteOnSubmit(emp);
            context.SubmitChanges();
            LoadGrid();




        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            var data = context.Employees.Where(p => p.EmpId == int.Parse(TextBox1.Text)).ToList();
            data[0].EmpName = TextBox2.Text;
            data[0].EmpSalary = int.Parse(TextBox3.Text);
            data[0].DeptId = int.Parse(TextBox4.Text);
            context.SubmitChanges();
            LoadGrid();




        }
       
    }
}