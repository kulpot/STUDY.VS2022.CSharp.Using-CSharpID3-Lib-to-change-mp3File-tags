using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// ref link:https://www.youtube.com/watch?v=C305CxPCBKY&list=PLAIBPfq19p2EJ6JY0f5DyQfybwBGVglcR&index=56
// add ref link:https://sourceforge.net/projects/csid3lib/

namespace Using_CSharpID3_Lib_to_change_mp3File_tags
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Mp3Lib.Mp3File file = new Mp3Lib.Mp3File(@"C:\Users\sunny\Desktop\wahu\Blue Fields.mp3");
            //file.TagHandler.Comment = textBox.Text;
            file.TagHandler.Year = textBox.Text;
            file.Update();
        }
    }
}
