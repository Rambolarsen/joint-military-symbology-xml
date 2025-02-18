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
namespace DemoApp
{
    partial class FormSIDCConverter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBox1 = new ListBox();
            listBox2 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            toolStripStatusLabel2 = new ToolStripStatusLabel();
            groupBox1 = new GroupBox();
            checkBox2 = new CheckBox();
            label10 = new Label();
            label9 = new Label();
            listView2 = new ListView();
            colID = new ColumnHeader();
            colAnchorPoints = new ColumnHeader();
            colSizeShape = new ColumnHeader();
            colOrientation = new ColumnHeader();
            label8 = new Label();
            label7 = new Label();
            listView1 = new ListView();
            colName = new ColumnHeader();
            colLabel = new ColumnHeader();
            colDescription = new ColumnHeader();
            colRemarks = new ColumnHeader();
            colX = new ColumnHeader();
            colY = new ColumnHeader();
            colType = new ColumnHeader();
            colLength = new ColumnHeader();
            TagsLabel = new TextBox();
            GeoLabel = new Label();
            label6 = new Label();
            label5 = new Label();
            text2525D_2 = new TextBox();
            label2525D = new Label();
            text2525D_1 = new TextBox();
            label2525C = new Label();
            text2525C = new TextBox();
            pictureBox1 = new PictureBox();
            checkBox1 = new CheckBox();
            statusStrip1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 13;
            listBox1.Items.AddRange(new object[] { "YXHTXXX--------\tInvalid Symbol", "SFPPV----------\tCrewed Space Vehicle", "SFPPS----------\tSpace Satellite", "SHPAT----------\tSpace Station", "SNAPMFKB-------\tBoom-Only Tanker", "SUAPMFCL-------\tLight Cargo Airlift", "SNGPUCAT-------\tArmored/Tracked", "SFGPUCI--------\tInfantry", "SUGPEWR--------\tRifle/Automatic Weapon", "SSGPIMS---H----\tShip Construction (Installation)", "SPSPCLLLSU-----\tLittoral Combat, SUW", "SHUPWT---------\tTorpedo", "SASACUS--------\tASW USV", "SFAPMFQRZ------\tRPV ES", "SFAP-----------\tAir", "EHIPF----------\tMarine Incident", "OFOPYT---------\tRadio and TV Propaganda", "GFTPUS--------X\tScreen Task", "GHGPGAF-------X\tFortified Area", "WOS-IITM--P----\tIce Thickness (Observed)", "WA-DPFC-FY-L---\tCold Frontolysis", "WO-DHDDA----A--\tDepth Area" });
            listBox1.Location = new Point(18, 469);
            listBox1.Name = "listBox1";
            listBox1.ScrollAlwaysVisible = true;
            listBox1.Size = new Size(398, 95);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // listBox2
            // 
            listBox2.Font = new Font("Microsoft Sans Serif", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 13;
            listBox2.Items.AddRange(new object[] { "1000600000,1010101010\tAn Invalid Symbol", "1000980000,1000000000\tInvalid Data Symbol", "1000980000,1100000000\tRetired Data Symbol", "1006050000,1208000000\tMiniaturized Civilian Satellite", "1004050000,1119000000\tSpace Launch Vehicle", "1014010000,1101040000\tFighter/Bomber (Ex Neutral)", "1005010000,1102000701\tHeavy Utility Helicopter", "1001011000,1204000000\tCivilian, Lighter than Air", "1006100000,1205000000\tArmored Unit", "1003150000,1201000000\tArmored Vehicle (Equipment)", "1002200000,1101000000\tAircraft Production Installation", "1003301000,1204020000\tMinesweeper", "1002300000,1401040000\tCivilian Merchant, RORO", "1004350000,1101000000\tSubmarine", "1004400000,1604001600\tVehicle Accident", "1005400000,1315130000\tInternal Security Force", "1003250000,2501000000\tFiring Point" });
            listBox2.Location = new Point(18, 585);
            listBox2.Name = "listBox2";
            listBox2.ScrollAlwaysVisible = true;
            listBox2.Size = new Size(398, 95);
            listBox2.TabIndex = 9;
            listBox2.SelectedIndexChanged += listBox2_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 450);
            label2.Name = "label2";
            label2.Size = new Size(198, 15);
            label2.TabIndex = 10;
            label2.Text = "Choose an example 2525C Symbol...";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 567);
            label3.Name = "label3";
            label3.Size = new Size(210, 15);
            label3.TabIndex = 11;
            label3.Text = "...or choose an example 2525D Symbol";
            // 
            // statusStrip1
            // 
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1, toolStripStatusLabel2 });
            statusStrip1.Location = new Point(0, 698);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(664, 22);
            statusStrip1.TabIndex = 12;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            toolStripStatusLabel2.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            toolStripStatusLabel2.Size = new Size(0, 17);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(checkBox2);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(listView2);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(listView1);
            groupBox1.Controls.Add(TagsLabel);
            groupBox1.Controls.Add(GeoLabel);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(text2525D_2);
            groupBox1.Controls.Add(label2525D);
            groupBox1.Controls.Add(text2525D_1);
            groupBox1.Controls.Add(label2525C);
            groupBox1.Controls.Add(text2525C);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(18, 11);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(634, 423);
            groupBox1.TabIndex = 14;
            groupBox1.TabStop = false;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(404, 404);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(124, 19);
            checkBox2.TabIndex = 17;
            checkBox2.Text = "Use civilian frames";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(94, 404);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 22;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(7, 404);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 21;
            label9.Text = "Drawing Note:";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { colID, colAnchorPoints, colSizeShape, colOrientation });
            listView2.Location = new Point(10, 328);
            listView2.Name = "listView2";
            listView2.Size = new Size(618, 65);
            listView2.TabIndex = 20;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // colID
            // 
            colID.Text = "Name";
            // 
            // colAnchorPoints
            // 
            colAnchorPoints.Text = "Anchor Points";
            colAnchorPoints.Width = 130;
            // 
            // colSizeShape
            // 
            colSizeShape.Text = "Size/Shape";
            colSizeShape.Width = 154;
            // 
            // colOrientation
            // 
            colOrientation.Text = "Orientation";
            colOrientation.Width = 245;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(7, 309);
            label8.Name = "label8";
            label8.Size = new Size(80, 15);
            label8.TabIndex = 19;
            label8.Text = "Drawing Rule:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 178);
            label7.Name = "label7";
            label7.Size = new Size(102, 15);
            label7.TabIndex = 18;
            label7.Text = "Amplifiers/Labels:";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colName, colLabel, colDescription, colRemarks, colX, colY, colType, colLength });
            listView1.Location = new Point(10, 197);
            listView1.Name = "listView1";
            listView1.Size = new Size(618, 99);
            listView1.TabIndex = 17;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 106;
            // 
            // colLabel
            // 
            colLabel.Text = "Label";
            colLabel.Width = 100;
            // 
            // colDescription
            // 
            colDescription.Text = "Description";
            // 
            // colRemarks
            // 
            colRemarks.Text = "Remarks";
            // 
            // colX
            // 
            colX.Text = "X";
            // 
            // colY
            // 
            colY.Text = "Y";
            // 
            // colType
            // 
            colType.Text = "Type";
            // 
            // colLength
            // 
            colLength.Text = "Length";
            // 
            // TagsLabel
            // 
            TagsLabel.BorderStyle = BorderStyle.None;
            TagsLabel.Location = new Point(80, 128);
            TagsLabel.Multiline = true;
            TagsLabel.Name = "TagsLabel";
            TagsLabel.ReadOnly = true;
            TagsLabel.Size = new Size(459, 47);
            TagsLabel.TabIndex = 13;
            // 
            // GeoLabel
            // 
            GeoLabel.AutoSize = true;
            GeoLabel.Location = new Point(78, 101);
            GeoLabel.Name = "GeoLabel";
            GeoLabel.Size = new Size(0, 15);
            GeoLabel.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(7, 127);
            label6.Name = "label6";
            label6.Size = new Size(33, 15);
            label6.TabIndex = 11;
            label6.Text = "Tags:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(7, 101);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 10;
            label5.Text = "Geometry:";
            // 
            // text2525D_2
            // 
            text2525D_2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text2525D_2.Location = new Point(385, 67);
            text2525D_2.Name = "text2525D_2";
            text2525D_2.Size = new Size(243, 26);
            text2525D_2.TabIndex = 9;
            text2525D_2.KeyPress += text2525D_2_KeyPress;
            // 
            // label2525D
            // 
            label2525D.AutoSize = true;
            label2525D.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2525D.Location = new Point(314, 47);
            label2525D.Name = "label2525D";
            label2525D.Size = new Size(61, 20);
            label2525D.TabIndex = 8;
            label2525D.Text = "2525D:";
            // 
            // text2525D_1
            // 
            text2525D_1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text2525D_1.Location = new Point(385, 24);
            text2525D_1.MaxLength = 10;
            text2525D_1.Name = "text2525D_1";
            text2525D_1.Size = new Size(243, 26);
            text2525D_1.TabIndex = 7;
            text2525D_1.KeyPress += text2525D_1_KeyPress;
            // 
            // label2525C
            // 
            label2525C.AutoSize = true;
            label2525C.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2525C.Location = new Point(5, 47);
            label2525C.Name = "label2525C";
            label2525C.Size = new Size(60, 20);
            label2525C.TabIndex = 6;
            label2525C.Text = "2525C:";
            // 
            // text2525C
            // 
            text2525C.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            text2525C.Location = new Point(74, 45);
            text2525C.MaxLength = 15;
            text2525C.Name = "text2525C";
            text2525C.Size = new Size(234, 26);
            text2525C.TabIndex = 5;
            text2525C.KeyPress += text2525C_KeyPress;
            text2525C.KeyUp += text2525C_KeyUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(422, 469);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Padding = new Padding(35, 0, 0, 0);
            pictureBox1.Size = new Size(230, 211);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(422, 440);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(159, 19);
            checkBox1.TabIndex = 16;
            checkBox1.Text = "Use colored bars for OCA";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // FormSIDCConverter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 720);
            Controls.Add(checkBox1);
            Controls.Add(pictureBox1);
            Controls.Add(groupBox1);
            Controls.Add(statusStrip1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "FormSIDCConverter";
            Text = "Joint Military Symbology XML Demo";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label GeoLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox text2525D_2;
        private System.Windows.Forms.Label label2525D;
        private System.Windows.Forms.TextBox text2525D_1;
        private System.Windows.Forms.Label label2525C;
        private System.Windows.Forms.TextBox text2525C;
        private System.Windows.Forms.TextBox TagsLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colLabel;
        private System.Windows.Forms.ColumnHeader colDescription;
        private System.Windows.Forms.ColumnHeader colRemarks;
        private System.Windows.Forms.ColumnHeader colX;
        private System.Windows.Forms.ColumnHeader colY;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colLength;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader colID;
        private System.Windows.Forms.ColumnHeader colAnchorPoints;
        private System.Windows.Forms.ColumnHeader colOrientation;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ColumnHeader colSizeShape;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}