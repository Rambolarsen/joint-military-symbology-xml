/* Copyright 2014 - 2015 Esri
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*    http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*/
using JointMilitarySymbologyLibrary;
using System.Text;
using System.Xml.Serialization;
using TextBox = System.Windows.Forms.TextBox;

namespace DemoApp
{
    public partial class FormSIDCConverter : Form
    {
        private readonly Librarian _librarian;
        public Symbol Symbol;
        private readonly Symbol _badSymbol;
        private readonly char[] _trimDash = new[] { '-', '*', ' ' };

        public FormSIDCConverter()
        {
            InitializeComponent();

            _librarian = new Librarian
            {
                IsLogging = true
            };

            _badSymbol = _librarian.MakeSymbol(1001980000, 1000000000);
            Symbol = _badSymbol;
            updateControls();
        }

        private void serializer_UnknownNode(object sender, XmlNodeEventArgs e)
        {
            Console.WriteLine("Unknown Node:" + e.Name + "\t" + e.Text);
        }

        private void serializer_UnknownAttribute(object sender, XmlAttributeEventArgs e)
        {
            System.Xml.XmlAttribute attr = e.Attr;
            Console.WriteLine("Unknown attribute " +
            attr.Name + "='" + attr.Value + "'");
        }

        // Update controls on the form

        private void updateC(string s)
        {
            text2525C.Text = s;
        }

        private void updateD(string s1, string s2)
        {
            text2525D_1.Text = s1;
            text2525D_2.Text = s2;
        }

        private void updateFieldList()
        {
            listView1.Items.Clear();
            List<Dictionary<string, string>> labels = Symbol.Labels;
            foreach (Dictionary<string, string> label in labels)
            {
                ListViewItem item = new ListViewItem(label["Name"]);
                item.SubItems.Add(label["Label"]);
                item.SubItems.Add(label["Description"]);
                item.SubItems.Add(label["Remarks"]);
                item.SubItems.Add(label["X"]);
                item.SubItems.Add(label["Y"]);
                item.SubItems.Add(label["Type"]);
                item.SubItems.Add(label["Length"]);
                listView1.Items.Add(item);
            }
        }

        private void updateDrawRuleList()
        {
            listView2.Items.Clear();
            Dictionary<string, string> rule = Symbol.DrawRule;

            if (rule != null)
            {
                if (rule.Count > 0)
                {
                    ListViewItem item = new ListViewItem(rule["Name"]);
                    item.SubItems.Add(rule["AnchorPoints"]);
                    item.SubItems.Add(rule["SizeShape"]);
                    item.SubItems.Add(rule["Orientation"]);
                    listView2.Items.Add(item);
                }
            }

            label10.Text = Symbol.DrawNote;
        }

        private void updateGraphic()
        {
            // Change padding for control measures

            if (Symbol.SIDC.SymbolSetCode != "25" &&
                Symbol.SIDC.SymbolSetCode != "45" &&
                Symbol.SIDC.SymbolSetCode != "46" &&
                Symbol.SIDC.SymbolSetCode != "47")
                pictureBox1.Padding = new Padding(40, 0, 0, 0);
            else
                pictureBox1.Padding = new Padding(15, 0, 0, 0);

            pictureBox1.Image = Symbol.Bitmap(pictureBox1.Width, pictureBox1.Height);
        }

        private void updateControls()
        {
            if (Symbol != null)
            {
                updateC(Symbol.LegacySIDC);
                updateD(Symbol.SIDC.PartAString, Symbol.SIDC.PartBString);

                switch (Symbol.SymbolStatus)
                {
                    case SymbolStatusEnum.statusEnumNew:
                        toolStripStatusLabel1.Text = "Symbol is new/introduced in 2525D";
                        break;
                    case SymbolStatusEnum.statusEnumOld:
                        toolStripStatusLabel1.Text = "Symbol is old (in 2525C) and in 2525D";
                        break;
                    case SymbolStatusEnum.statusEnumRetired:
                        toolStripStatusLabel1.Text = "Symbol has been retired from 2525";
                        break;
                }

                TagsLabel.Text = Symbol.Tags;
                GeoLabel.Text = Symbol.GeometryType.ToString();

                updateFieldList();
                updateDrawRuleList();
                updateGraphic();
            }
            else
            {
                updateC("");
                updateD("", "");

                toolStripStatusLabel1.Text = "Symbol is invalid or not found in the symbol library";

                TagsLabel.Text = "";
                GeoLabel.Text = "";

                listView1.Items.Clear();
                listView2.Items.Clear();

                pictureBox1.Image = _badSymbol.Bitmap(pictureBox1.Width, pictureBox1.Height);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = listBox1.SelectedItem?.ToString() ?? string.Empty;

            string[] l = s.Split('\t');

            Symbol = _librarian.MakeSymbol("2525C", l[0]);

            updateControls();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            string s = listBox2.SelectedItem?.ToString() ?? string.Empty;

            string[] l = s.Split('\t');
            string[] ll = l[0].Split(',');

            Symbol = _librarian.MakeSymbol(new SIDC(ll[0], ll[1]));

            updateControls();
        }

        private void text2525C_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Return)
            {
                Symbol = _librarian.MakeSymbol("2525C", text2525C.Text);

                updateControls();
            }
            else
            {
                var box = (TextBox)sender;
                if (box.SelectionStart >= box.TextLength || char.IsControl(e.KeyChar)) return;

                var cacheSelectionStart = box.SelectionStart; //Cache SelectionStart as its reset when the Text property of the TextBox is set.
                var sb = new StringBuilder(box.Text)
                {
                    Capacity = 0,
                    Length = 0,
                    [box.SelectionStart] = e.KeyChar //Add the pressed key at the right position
                }; //Create a StringBuilder as Strings are immutable
                box.Text = sb.ToString(); //SelectionStart is reset after setting the text, so restore it
                box.SelectionStart = cacheSelectionStart + 1; //Advance to the next char
            }
        }

        private void text2525D_1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) return;

            Symbol = _librarian.MakeSymbol(new SIDC(text2525D_1.Text, text2525D_2.Text));
            updateControls();
        }

        private void text2525D_2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != (char)Keys.Return) return;

            Symbol = _librarian.MakeSymbol(new SIDC(text2525D_1.Text, text2525D_2.Text));
            updateControls();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            _librarian.DrawColoredOCABars = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            _librarian.DrawCivilianFrames = checkBox2.Checked;
        }

        private void text2525C_KeyUp(object sender, KeyEventArgs e)
        {
            var sidc = text2525C.Text;
            var start = text2525C.SelectionStart;
            var length = text2525C.SelectionLength;

            sidc = sidc.Replace('*', '-');
            sidc = sidc.TrimEnd(_trimDash);
            sidc = sidc.PadRight(15, '-');

            text2525C.Text = sidc.ToUpper();
            text2525C.SelectionStart = start;
            text2525C.SelectionLength = length;
        }
    }
}