namespace ro2_settings_editor
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.videotab = new System.Windows.Forms.TabPage();
            this.videoPanel = new System.Windows.Forms.Panel();
            this.a2 = new System.Windows.Forms.Button();
            this.a1 = new System.Windows.Forms.Button();
            this.a0 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.anisocombo = new System.Windows.Forms.ComboBox();
            this.fullCheck = new System.Windows.Forms.CheckBox();
            this.vsyncCheck = new System.Windows.Forms.CheckBox();
            this.postbox = new System.Windows.Forms.GroupBox();
            this.dofcheck = new System.Windows.Forms.CheckBox();
            this.blurcheck = new System.Windows.Forms.CheckBox();
            this.lshaftcheck = new System.Windows.Forms.CheckBox();
            this.bloomcheck = new System.Windows.Forms.CheckBox();
            this.aocheck = new System.Windows.Forms.CheckBox();
            this.physCheck = new System.Windows.Forms.CheckBox();
            this.smoothCheck = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ppCombo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resY = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.resX = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.discardBtn = new System.Windows.Forms.Button();
            this.saveSet = new System.Windows.Forms.Button();
            this.occbox = new System.Windows.Forms.CheckBox();
            this.fxcombo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lightcombo = new System.Windows.Forms.ComboBox();
            this.aacombo = new System.Windows.Forms.ComboBox();
            this.shadowcombo = new System.Windows.Forms.ComboBox();
            this.chacombo = new System.Windows.Forms.ComboBox();
            this.detailcombo = new System.Windows.Forms.ComboBox();
            this.greencombo = new System.Windows.Forms.ComboBox();
            this.postcombo = new System.Windows.Forms.ComboBox();
            this.texcombo = new System.Windows.Forms.ComboBox();
            this.presetcombo = new System.Windows.Forms.ComboBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.configBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.videotab.SuspendLayout();
            this.videoPanel.SuspendLayout();
            this.postbox.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // videotab
            // 
            this.videotab.AutoScroll = true;
            this.videotab.Controls.Add(this.videoPanel);
            this.videotab.Location = new System.Drawing.Point(4, 22);
            this.videotab.Name = "videotab";
            this.videotab.Padding = new System.Windows.Forms.Padding(3);
            this.videotab.Size = new System.Drawing.Size(657, 414);
            this.videotab.TabIndex = 0;
            this.videotab.Text = "Video Settings";
            this.videotab.UseVisualStyleBackColor = true;
            // 
            // videoPanel
            // 
            this.videoPanel.BackColor = System.Drawing.Color.White;
            this.videoPanel.Controls.Add(this.a2);
            this.videoPanel.Controls.Add(this.a1);
            this.videoPanel.Controls.Add(this.a0);
            this.videoPanel.Controls.Add(this.label14);
            this.videoPanel.Controls.Add(this.anisocombo);
            this.videoPanel.Controls.Add(this.fullCheck);
            this.videoPanel.Controls.Add(this.vsyncCheck);
            this.videoPanel.Controls.Add(this.postbox);
            this.videoPanel.Controls.Add(this.physCheck);
            this.videoPanel.Controls.Add(this.smoothCheck);
            this.videoPanel.Controls.Add(this.label2);
            this.videoPanel.Controls.Add(this.ppCombo);
            this.videoPanel.Controls.Add(this.label1);
            this.videoPanel.Controls.Add(this.resY);
            this.videoPanel.Controls.Add(this.label13);
            this.videoPanel.Controls.Add(this.resX);
            this.videoPanel.Controls.Add(this.label12);
            this.videoPanel.Controls.Add(this.discardBtn);
            this.videoPanel.Controls.Add(this.saveSet);
            this.videoPanel.Controls.Add(this.occbox);
            this.videoPanel.Controls.Add(this.fxcombo);
            this.videoPanel.Controls.Add(this.label11);
            this.videoPanel.Controls.Add(this.label10);
            this.videoPanel.Controls.Add(this.label9);
            this.videoPanel.Controls.Add(this.label8);
            this.videoPanel.Controls.Add(this.label7);
            this.videoPanel.Controls.Add(this.label6);
            this.videoPanel.Controls.Add(this.label5);
            this.videoPanel.Controls.Add(this.label4);
            this.videoPanel.Controls.Add(this.label3);
            this.videoPanel.Controls.Add(this.lightcombo);
            this.videoPanel.Controls.Add(this.aacombo);
            this.videoPanel.Controls.Add(this.shadowcombo);
            this.videoPanel.Controls.Add(this.chacombo);
            this.videoPanel.Controls.Add(this.detailcombo);
            this.videoPanel.Controls.Add(this.greencombo);
            this.videoPanel.Controls.Add(this.postcombo);
            this.videoPanel.Controls.Add(this.texcombo);
            this.videoPanel.Controls.Add(this.presetcombo);
            this.videoPanel.Location = new System.Drawing.Point(0, 0);
            this.videoPanel.Name = "videoPanel";
            this.videoPanel.Size = new System.Drawing.Size(651, 408);
            this.videoPanel.TabIndex = 7;
            // 
            // a2
            // 
            this.a2.Location = new System.Drawing.Point(569, 237);
            this.a2.Name = "a2";
            this.a2.Size = new System.Drawing.Size(30, 23);
            this.a2.TabIndex = 48;
            this.a2.Text = "+";
            this.a2.UseVisualStyleBackColor = true;
            this.a2.Click += new System.EventHandler(this.advanced_Click);
            // 
            // a1
            // 
            this.a1.Location = new System.Drawing.Point(569, 128);
            this.a1.Name = "a1";
            this.a1.Size = new System.Drawing.Size(30, 23);
            this.a1.TabIndex = 47;
            this.a1.Text = "+";
            this.a1.UseVisualStyleBackColor = true;
            this.a1.Click += new System.EventHandler(this.advanced_Click);
            // 
            // a0
            // 
            this.a0.Location = new System.Drawing.Point(569, 74);
            this.a0.Name = "a0";
            this.a0.Size = new System.Drawing.Size(30, 23);
            this.a0.TabIndex = 46;
            this.a0.Text = "+";
            this.a0.UseVisualStyleBackColor = true;
            this.a0.Click += new System.EventHandler(this.advanced_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 13);
            this.label14.TabIndex = 45;
            this.label14.Text = "Anisotropic Filtering";
            // 
            // anisocombo
            // 
            this.anisocombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.anisocombo.FormattingEnabled = true;
            this.anisocombo.Location = new System.Drawing.Point(442, 102);
            this.anisocombo.Name = "anisocombo";
            this.anisocombo.Size = new System.Drawing.Size(121, 21);
            this.anisocombo.TabIndex = 44;
            // 
            // fullCheck
            // 
            this.fullCheck.AutoSize = true;
            this.fullCheck.Location = new System.Drawing.Point(159, 130);
            this.fullCheck.Name = "fullCheck";
            this.fullCheck.Size = new System.Drawing.Size(74, 17);
            this.fullCheck.TabIndex = 43;
            this.fullCheck.Text = "Fullscreen";
            this.fullCheck.UseVisualStyleBackColor = true;
            // 
            // vsyncCheck
            // 
            this.vsyncCheck.AutoSize = true;
            this.vsyncCheck.Location = new System.Drawing.Point(54, 156);
            this.vsyncCheck.Name = "vsyncCheck";
            this.vsyncCheck.Size = new System.Drawing.Size(55, 17);
            this.vsyncCheck.TabIndex = 42;
            this.vsyncCheck.Text = "Vsync";
            this.vsyncCheck.UseVisualStyleBackColor = true;
            // 
            // postbox
            // 
            this.postbox.Controls.Add(this.dofcheck);
            this.postbox.Controls.Add(this.blurcheck);
            this.postbox.Controls.Add(this.lshaftcheck);
            this.postbox.Controls.Add(this.bloomcheck);
            this.postbox.Controls.Add(this.aocheck);
            this.postbox.Location = new System.Drawing.Point(53, 248);
            this.postbox.Name = "postbox";
            this.postbox.Size = new System.Drawing.Size(139, 138);
            this.postbox.TabIndex = 41;
            this.postbox.TabStop = false;
            this.postbox.Text = "Post-Processing Effects";
            // 
            // dofcheck
            // 
            this.dofcheck.AutoSize = true;
            this.dofcheck.Location = new System.Drawing.Point(6, 111);
            this.dofcheck.Name = "dofcheck";
            this.dofcheck.Size = new System.Drawing.Size(92, 17);
            this.dofcheck.TabIndex = 29;
            this.dofcheck.Text = "Depth of Field";
            this.dofcheck.UseVisualStyleBackColor = true;
            // 
            // blurcheck
            // 
            this.blurcheck.AutoSize = true;
            this.blurcheck.Location = new System.Drawing.Point(6, 88);
            this.blurcheck.Name = "blurcheck";
            this.blurcheck.Size = new System.Drawing.Size(79, 17);
            this.blurcheck.TabIndex = 28;
            this.blurcheck.Text = "Motion Blur";
            this.blurcheck.UseVisualStyleBackColor = true;
            // 
            // lshaftcheck
            // 
            this.lshaftcheck.AutoSize = true;
            this.lshaftcheck.Location = new System.Drawing.Point(6, 65);
            this.lshaftcheck.Name = "lshaftcheck";
            this.lshaftcheck.Size = new System.Drawing.Size(82, 17);
            this.lshaftcheck.TabIndex = 8;
            this.lshaftcheck.Text = "Light Shafts";
            this.lshaftcheck.UseVisualStyleBackColor = true;
            // 
            // bloomcheck
            // 
            this.bloomcheck.AutoSize = true;
            this.bloomcheck.Location = new System.Drawing.Point(6, 42);
            this.bloomcheck.Name = "bloomcheck";
            this.bloomcheck.Size = new System.Drawing.Size(55, 17);
            this.bloomcheck.TabIndex = 7;
            this.bloomcheck.Text = "Bloom";
            this.bloomcheck.UseVisualStyleBackColor = true;
            // 
            // aocheck
            // 
            this.aocheck.AutoSize = true;
            this.aocheck.Location = new System.Drawing.Point(6, 19);
            this.aocheck.Name = "aocheck";
            this.aocheck.Size = new System.Drawing.Size(114, 17);
            this.aocheck.TabIndex = 6;
            this.aocheck.Text = "Ambient Occlusion";
            this.aocheck.UseVisualStyleBackColor = true;
            // 
            // physCheck
            // 
            this.physCheck.AutoSize = true;
            this.physCheck.Location = new System.Drawing.Point(53, 179);
            this.physCheck.Name = "physCheck";
            this.physCheck.Size = new System.Drawing.Size(133, 17);
            this.physCheck.TabIndex = 40;
            this.physCheck.Text = "Use Hardware Physics";
            this.physCheck.UseVisualStyleBackColor = true;
            // 
            // smoothCheck
            // 
            this.smoothCheck.AutoSize = true;
            this.smoothCheck.Location = new System.Drawing.Point(53, 200);
            this.smoothCheck.Name = "smoothCheck";
            this.smoothCheck.Size = new System.Drawing.Size(100, 17);
            this.smoothCheck.TabIndex = 39;
            this.smoothCheck.Text = "Lock Framerate";
            this.smoothCheck.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Post-Processing Preset";
            // 
            // ppCombo
            // 
            this.ppCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ppCombo.FormattingEnabled = true;
            this.ppCombo.Location = new System.Drawing.Point(53, 80);
            this.ppCombo.Name = "ppCombo";
            this.ppCombo.Size = new System.Drawing.Size(121, 21);
            this.ppCombo.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Video preset";
            // 
            // resY
            // 
            this.resY.Location = new System.Drawing.Point(115, 128);
            this.resY.MaxLength = 4;
            this.resY.Name = "resY";
            this.resY.Size = new System.Drawing.Size(38, 20);
            this.resY.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(95, 130);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "X";
            // 
            // resX
            // 
            this.resX.Location = new System.Drawing.Point(51, 127);
            this.resX.MaxLength = 4;
            this.resX.Name = "resX";
            this.resX.Size = new System.Drawing.Size(38, 20);
            this.resX.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(49, 111);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Display resolution";
            // 
            // discardBtn
            // 
            this.discardBtn.Location = new System.Drawing.Point(400, 363);
            this.discardBtn.Name = "discardBtn";
            this.discardBtn.Size = new System.Drawing.Size(107, 23);
            this.discardBtn.TabIndex = 27;
            this.discardBtn.Text = "Discard Changes";
            this.discardBtn.UseVisualStyleBackColor = true;
            this.discardBtn.Click += new System.EventHandler(this.discardBtn_Click);
            // 
            // saveSet
            // 
            this.saveSet.BackColor = System.Drawing.Color.Transparent;
            this.saveSet.Location = new System.Drawing.Point(532, 363);
            this.saveSet.Name = "saveSet";
            this.saveSet.Size = new System.Drawing.Size(75, 23);
            this.saveSet.TabIndex = 26;
            this.saveSet.Text = "Save";
            this.saveSet.UseVisualStyleBackColor = false;
            this.saveSet.Click += new System.EventHandler(this.saveSet_Click);
            // 
            // occbox
            // 
            this.occbox.AutoSize = true;
            this.occbox.Location = new System.Drawing.Point(53, 222);
            this.occbox.Name = "occbox";
            this.occbox.Size = new System.Drawing.Size(167, 17);
            this.occbox.TabIndex = 25;
            this.occbox.Text = "High Quality Occlusion Culling";
            this.occbox.UseVisualStyleBackColor = true;
            // 
            // fxcombo
            // 
            this.fxcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fxcombo.FormattingEnabled = true;
            this.fxcombo.Location = new System.Drawing.Point(442, 156);
            this.fxcombo.Name = "fxcombo";
            this.fxcombo.Size = new System.Drawing.Size(121, 21);
            this.fxcombo.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(360, 270);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Foliage Quality";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(355, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Lighting Quality";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(318, 216);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Post-Processing Quality";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Anti-Aliasing";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(381, 159);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "FX Quality";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(355, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Shadow Quality";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(358, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Texture Quality";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(353, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Character Detail";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(372, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Detail Mode";
            // 
            // lightcombo
            // 
            this.lightcombo.BackColor = System.Drawing.SystemColors.Window;
            this.lightcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lightcombo.FormattingEnabled = true;
            this.lightcombo.Location = new System.Drawing.Point(442, 238);
            this.lightcombo.Name = "lightcombo";
            this.lightcombo.Size = new System.Drawing.Size(121, 21);
            this.lightcombo.TabIndex = 12;
            this.lightcombo.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // aacombo
            // 
            this.aacombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.aacombo.FormattingEnabled = true;
            this.aacombo.Location = new System.Drawing.Point(442, 183);
            this.aacombo.Name = "aacombo";
            this.aacombo.Size = new System.Drawing.Size(121, 21);
            this.aacombo.TabIndex = 11;
            // 
            // shadowcombo
            // 
            this.shadowcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shadowcombo.FormattingEnabled = true;
            this.shadowcombo.Location = new System.Drawing.Point(442, 129);
            this.shadowcombo.Name = "shadowcombo";
            this.shadowcombo.Size = new System.Drawing.Size(121, 21);
            this.shadowcombo.TabIndex = 10;
            this.shadowcombo.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // chacombo
            // 
            this.chacombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chacombo.FormattingEnabled = true;
            this.chacombo.Location = new System.Drawing.Point(442, 48);
            this.chacombo.Name = "chacombo";
            this.chacombo.Size = new System.Drawing.Size(121, 21);
            this.chacombo.TabIndex = 9;
            // 
            // detailcombo
            // 
            this.detailcombo.BackColor = System.Drawing.SystemColors.Control;
            this.detailcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.detailcombo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.detailcombo.FormattingEnabled = true;
            this.detailcombo.Location = new System.Drawing.Point(442, 21);
            this.detailcombo.Name = "detailcombo";
            this.detailcombo.Size = new System.Drawing.Size(121, 21);
            this.detailcombo.TabIndex = 5;
            // 
            // greencombo
            // 
            this.greencombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.greencombo.FormattingEnabled = true;
            this.greencombo.Location = new System.Drawing.Point(442, 266);
            this.greencombo.Name = "greencombo";
            this.greencombo.Size = new System.Drawing.Size(121, 21);
            this.greencombo.TabIndex = 4;
            // 
            // postcombo
            // 
            this.postcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.postcombo.FormattingEnabled = true;
            this.postcombo.Location = new System.Drawing.Point(442, 210);
            this.postcombo.Name = "postcombo";
            this.postcombo.Size = new System.Drawing.Size(121, 21);
            this.postcombo.TabIndex = 3;
            // 
            // texcombo
            // 
            this.texcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.texcombo.FormattingEnabled = true;
            this.texcombo.Location = new System.Drawing.Point(442, 75);
            this.texcombo.Name = "texcombo";
            this.texcombo.Size = new System.Drawing.Size(121, 21);
            this.texcombo.TabIndex = 2;
            this.texcombo.SelectedIndexChanged += new System.EventHandler(this.SelectedIndexChanged);
            // 
            // presetcombo
            // 
            this.presetcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.presetcombo.FormattingEnabled = true;
            this.presetcombo.Location = new System.Drawing.Point(54, 34);
            this.presetcombo.Name = "presetcombo";
            this.presetcombo.Size = new System.Drawing.Size(121, 21);
            this.presetcombo.TabIndex = 1;
            this.presetcombo.SelectedIndexChanged += new System.EventHandler(this.presetcombo_SelectedIndexChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.videotab);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(665, 440);
            this.tabControl1.TabIndex = 12;
            // 
            // configBindingSource
            // 
            this.configBindingSource.DataSource = typeof(config);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 442);
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(683, 480);
            this.MinimumSize = new System.Drawing.Size(683, 480);
            this.Name = "Form1";
            this.Text = "RO2 Settings Editor v0.0004";
            this.videotab.ResumeLayout(false);
            this.videoPanel.ResumeLayout(false);
            this.videoPanel.PerformLayout();
            this.postbox.ResumeLayout(false);
            this.postbox.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.configBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource configBindingSource;
        private System.Windows.Forms.TabPage videotab;
        private System.Windows.Forms.Panel videoPanel;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox anisocombo;
        private System.Windows.Forms.CheckBox fullCheck;
        private System.Windows.Forms.CheckBox vsyncCheck;
        private System.Windows.Forms.GroupBox postbox;
        private System.Windows.Forms.CheckBox dofcheck;
        private System.Windows.Forms.CheckBox blurcheck;
        private System.Windows.Forms.CheckBox lshaftcheck;
        private System.Windows.Forms.CheckBox bloomcheck;
        private System.Windows.Forms.CheckBox aocheck;
        private System.Windows.Forms.CheckBox physCheck;
        private System.Windows.Forms.CheckBox smoothCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ppCombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox resY;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox resX;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button discardBtn;
        private System.Windows.Forms.Button saveSet;
        private System.Windows.Forms.CheckBox occbox;
        private System.Windows.Forms.ComboBox fxcombo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox lightcombo;
        private System.Windows.Forms.ComboBox aacombo;
        private System.Windows.Forms.ComboBox shadowcombo;
        private System.Windows.Forms.ComboBox chacombo;
        private System.Windows.Forms.ComboBox detailcombo;
        private System.Windows.Forms.ComboBox greencombo;
        private System.Windows.Forms.ComboBox postcombo;
        private System.Windows.Forms.ComboBox texcombo;
        private System.Windows.Forms.ComboBox presetcombo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button a0;
        private System.Windows.Forms.Button a2;
        private System.Windows.Forms.Button a1;
    }
}

