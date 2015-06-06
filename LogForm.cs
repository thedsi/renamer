using System.Windows.Forms;

namespace kurs
{
    public partial class LogForm : Form
    {
        public string LogText
        {
            get
            {
                return tbLog.Text;
            }
            set
            {
                tbLog.Text = value;
            }
        }

        public LogForm()
        {
            InitializeComponent();
        }

        public LogForm(string logText) : this()
        {
            LogText = logText;
        }

        public void Log(string s)
        {
            tbLog.AppendText(s);
            tbLog.AppendText("\r\n");
        }

    }
}
