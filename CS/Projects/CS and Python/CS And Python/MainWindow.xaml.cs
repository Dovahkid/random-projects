using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CS_And_Python
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        public void IronPython(string input)
        {
            #region old_stuff
            //var engine = Python.CreateEngine();

            //var script = @"F:\Projects\CS\Projects\CS and Python\IronPythonProj\IronPythonProj.py";

            //var source = engine.CreateScriptSourceFromFile(script);

            //var argv = new List<string>();

            //argv.Add("");
            //argv.Add(name);

            //engine.GetSysModule().SetVariable("argv", argv);

            //var eIO = engine.Runtime.IO;

            //var errors = new MemoryStream();
            //eIO.SetErrorOutput(errors, Encoding.Default);

            //var output = new MemoryStream();
            //eIO.SetOutput(output, Encoding.Default);

            //var scope = engine.CreateScope();
            //source.Execute(scope);

            //string str(byte[] x) => Encoding.Default.GetString(x);

            //MessageBox.Show(str(errors.ToArray()));
            //MessageBox.Show(str(output.ToArray()));
            #endregion old_stuff

            // Creates an engine, source, and scope for the script to run in
            ScriptEngine engine = Python.CreateEngine();
            ScriptSource source = engine.CreateScriptSourceFromFile(@"F:\Projects\CS\Projects\CS and Python\IronPythonProj\IronPythonProj.py");
            ScriptScope scope = engine.CreateScope();

            // This will allow us to run methods from the script later
            ObjectOperations operations = engine.Operations;

            //sets a value
            var argv = new List<string>(); // As far as I can tell values have to be set through the argv list
            argv.Add("");
            argv.Add(input);
            engine.GetSysModule().SetVariable("argv", argv);

            source.Execute(scope); // Limited testing shows that variables need to be set before they are used later
            // This also has to be before using any methods

            // Runs a method in the python script
            object classObject = scope.GetVariable("TestClass");
            object instance = operations.Invoke(classObject);
            object method = operations.GetMember(instance, "TestMethod");

            // This is the output from the script
            string result = operations.Invoke(method);

            lblOutput.Content = result;
        }

        private void btnName_Click(object sender, RoutedEventArgs e)
        {
            IronPython(txtInput.Text);
        }
    }
}
