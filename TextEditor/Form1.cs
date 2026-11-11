using System.Diagnostics;
using System.Text;

namespace TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtCode.Text = _SampleCode();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();

            txtOutput.Text = "يتم تشغيل المترجم . . .";


            // 1. Full path to your Java executable
            string javaExe = @"C:\Program Files\Eclipse Adoptium\jdk-17.0.18.8-hotspot\bin\java.exe";

            // 2. Classpath and arguments
            string classPath = @"C:\Ahmed Bakri\university\Compilers\lab8\src";
            string arguments = $"-Dfile.encoding=UTF-8 -classpath \"{classPath}\" MyParser";

            // Create UTF-8 WITHOUT BOM (false)
            var utf8WithoutBom = new UTF8Encoding(false);

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = javaExe,
                Arguments = arguments,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                StandardInputEncoding = utf8WithoutBom,  
                StandardOutputEncoding = utf8WithoutBom,
                StandardErrorEncoding = utf8WithoutBom
            };

            txtOutput.Text += "\nجار ترجمة الكود المدخل. . .";

            try
            {
                using (Process process = Process.Start(psi))
                {
                    string codeToSend = txtCode.Text.TrimStart('\uFEFF');

                    process.StandardInput.Write(codeToSend);
                    process.StandardInput.Close();

                    // Read output and error
                    string output = process.StandardOutput.ReadToEnd();
                    string error = process.StandardError.ReadToEnd();

                    process.WaitForExit();

                    // Display result
                    if (!string.IsNullOrWhiteSpace(error))
                    {
                        txtOutput.Text = "خطأ (Error):\r\n" + error;
                    }
                    else
                    {
                        txtOutput.Text = output;
                    }
                }
            }
            catch (Exception ex)
            {
                txtOutput.Text = "System Error:\r\n" + ex.Message;
            }
        }

        private string _SampleCode()
        {
            return @"

//تعليق
متغير س = 10؛
متغير ص = 5؛
متغير ناتج = (س + ص) * 2 - 4 / 2؛
اطبع(""الناتج = "")؛
اطبع(ناتج)؛
";
        }

    }


    
}
