using GeniePlugin.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeBuddy
{
    internal class PluginProgram : IPlugin
    {
        private readonly string _name = "Plugin Name";
        private readonly string _version = "1.0";
        private readonly string _description = "A short description of the program which will appear in the Genie Plugin Window.";
        private readonly string _author = "Your Name";
        private bool _enabled = true;
        static void Main(string[] args)
        {
        }

        private IHost _host;

        public void Initialize(IHost host)
        {
            _host = host;
        }

        public void Show()
        {

        }

        public void VariableChanged(string variable)
        {

        }

        public string ParseText(string text, string window)
        {
            return text;
        }

        public string ParseInput(string text)
        {
            return text;
        }

        public void ParseXML(string xml)
        {

        }

        public void ParentClosing()
        {

        }

        public string Name
        {
            get { return _name; }
        }
                
        public string Version
        {
            get { return _version; }
        }
                
        public string Description
        {
            get { return _description; }
        }
                
        public string Author
        {
            get { return _author; }
        }

        public bool Enabled
        {
            get { return _enabled; }
            set { _enabled = value; }
        }
    }
}