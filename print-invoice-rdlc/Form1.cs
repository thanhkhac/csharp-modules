using Microsoft.Reporting.WinForms;

namespace print_invoice_rdlc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string projectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            string rdlcPath = Path.Combine(projectDirectory, "report.rdlc");
            
            reportViewer.LocalReport.ReportPath = rdlcPath;

            List<Student> students = new List<Student>();
            students.Add(new Student("hehe", "Khac Thanh", "21"));
            students.Add(new Student("hehe", "Khac Thanh", "21"));
            students.Add(new Student("hehe", "Khac Thanh", "21"));
            students.Add(new Student("hehe", "Khac Thanh", "21"));
            students.Add(new Student("hehe", "Khac Thanh", "21"));
            students.Add(new Student("hehe", "Khac Thanh", "21"));
            students.Add(new Student("hehe", "Khac Thanh", "21"));
            students.Add(new Student("hehe", "Khac Thanh", "21"));

var datasource = new ReportDataSource("StudentDataSet", students);
reportViewer.LocalReport.DataSources.Add(datasource);
reportViewer.RefreshReport();
        }
    }
}
