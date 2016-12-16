namespace ESASelection
{
    partial class View
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.easymemoryRB = new System.Windows.Forms.RadioButton();
            this.groupBoxPerception = new System.Windows.Forms.GroupBox();
            this.memory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.hardmemoryRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxAttention = new System.Windows.Forms.GroupBox();
            this.attention = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hardattentionRB = new System.Windows.Forms.RadioButton();
            this.easyattentionRB = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxCalcul = new System.Windows.Forms.GroupBox();
            this.calcul = new System.Windows.Forms.Button();
            this.hardcalculRB = new System.Windows.Forms.RadioButton();
            this.easycalculRB = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBoxPbMaths = new System.Windows.Forms.GroupBox();
            this.mathematics = new System.Windows.Forms.Button();
            this.hardmathematicsRB = new System.Windows.Forms.RadioButton();
            this.eaysmathematicsRB = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBoxPbPhys = new System.Windows.Forms.GroupBox();
            this.physics = new System.Windows.Forms.Button();
            this.hardphysicsRB = new System.Windows.Forms.RadioButton();
            this.easyphysicsRB = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resPerceptionF = new System.Windows.Forms.Label();
            this.resPerceptionD = new System.Windows.Forms.Label();
            this.resAttentionD = new System.Windows.Forms.Label();
            this.resAttentionF = new System.Windows.Forms.Label();
            this.resCalculD = new System.Windows.Forms.Label();
            this.resCalculF = new System.Windows.Forms.Label();
            this.resMathsD = new System.Windows.Forms.Label();
            this.resMathsF = new System.Windows.Forms.Label();
            this.resPhysiqueD = new System.Windows.Forms.Label();
            this.resPhysiqueF = new System.Windows.Forms.Label();
            this.groupBoxPerception.SuspendLayout();
            this.groupBoxAttention.SuspendLayout();
            this.groupBoxCalcul.SuspendLayout();
            this.groupBoxPbMaths.SuspendLayout();
            this.groupBoxPbPhys.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(266, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "ESA SELECTION";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 52);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // easymemoryRB
            // 
            this.easymemoryRB.AutoSize = true;
            this.easymemoryRB.Checked = true;
            this.easymemoryRB.Location = new System.Drawing.Point(70, 18);
            this.easymemoryRB.Name = "easymemoryRB";
            this.easymemoryRB.Size = new System.Drawing.Size(53, 17);
            this.easymemoryRB.TabIndex = 2;
            this.easymemoryRB.TabStop = true;
            this.easymemoryRB.Text = "Facile";
            this.easymemoryRB.UseVisualStyleBackColor = true;
            // 
            // groupBoxPerception
            // 
            this.groupBoxPerception.Controls.Add(this.memory);
            this.groupBoxPerception.Controls.Add(this.button1);
            this.groupBoxPerception.Controls.Add(this.hardmemoryRB);
            this.groupBoxPerception.Controls.Add(this.easymemoryRB);
            this.groupBoxPerception.Location = new System.Drawing.Point(401, 273);
            this.groupBoxPerception.Name = "groupBoxPerception";
            this.groupBoxPerception.Size = new System.Drawing.Size(258, 75);
            this.groupBoxPerception.TabIndex = 3;
            this.groupBoxPerception.TabStop = false;
            this.groupBoxPerception.Text = "Difficulté";
            // 
            // memory
            // 
            this.memory.Location = new System.Drawing.Point(172, 30);
            this.memory.Name = "memory";
            this.memory.Size = new System.Drawing.Size(75, 21);
            this.memory.TabIndex = 5;
            this.memory.Text = "Lancer test";
            this.memory.UseVisualStyleBackColor = true;
            this.memory.Click += new System.EventHandler(this.launchTestClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(311, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // hardmemoryRB
            // 
            this.hardmemoryRB.AutoSize = true;
            this.hardmemoryRB.Location = new System.Drawing.Point(70, 50);
            this.hardmemoryRB.Name = "hardmemoryRB";
            this.hardmemoryRB.Size = new System.Drawing.Size(74, 17);
            this.hardmemoryRB.TabIndex = 3;
            this.hardmemoryRB.TabStop = true;
            this.hardmemoryRB.Text = "Compliqué";
            this.hardmemoryRB.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Perception et mémoire associative";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(248, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Attention et concentration";
            // 
            // groupBoxAttention
            // 
            this.groupBoxAttention.Controls.Add(this.attention);
            this.groupBoxAttention.Controls.Add(this.button2);
            this.groupBoxAttention.Controls.Add(this.hardattentionRB);
            this.groupBoxAttention.Controls.Add(this.easyattentionRB);
            this.groupBoxAttention.Location = new System.Drawing.Point(401, 366);
            this.groupBoxAttention.Name = "groupBoxAttention";
            this.groupBoxAttention.Size = new System.Drawing.Size(258, 75);
            this.groupBoxAttention.TabIndex = 5;
            this.groupBoxAttention.TabStop = false;
            this.groupBoxAttention.Text = "Difficulté";
            // 
            // attention
            // 
            this.attention.Location = new System.Drawing.Point(172, 30);
            this.attention.Name = "attention";
            this.attention.Size = new System.Drawing.Size(75, 21);
            this.attention.TabIndex = 6;
            this.attention.Text = "Lancer test";
            this.attention.UseVisualStyleBackColor = true;
            this.attention.Click += new System.EventHandler(this.launchTestClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(469, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // hardattentionRB
            // 
            this.hardattentionRB.AutoSize = true;
            this.hardattentionRB.Location = new System.Drawing.Point(70, 50);
            this.hardattentionRB.Name = "hardattentionRB";
            this.hardattentionRB.Size = new System.Drawing.Size(74, 17);
            this.hardattentionRB.TabIndex = 3;
            this.hardattentionRB.TabStop = true;
            this.hardattentionRB.Text = "Compliqué";
            this.hardattentionRB.UseVisualStyleBackColor = true;
            // 
            // easyattentionRB
            // 
            this.easyattentionRB.AutoSize = true;
            this.easyattentionRB.Checked = true;
            this.easyattentionRB.Location = new System.Drawing.Point(70, 18);
            this.easyattentionRB.Name = "easyattentionRB";
            this.easyattentionRB.Size = new System.Drawing.Size(53, 17);
            this.easyattentionRB.TabIndex = 2;
            this.easyattentionRB.TabStop = true;
            this.easyattentionRB.Text = "Facile";
            this.easyattentionRB.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 488);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 24);
            this.label5.TabIndex = 6;
            this.label5.Text = "Calcul mental";
            // 
            // groupBoxCalcul
            // 
            this.groupBoxCalcul.Controls.Add(this.calcul);
            this.groupBoxCalcul.Controls.Add(this.hardcalculRB);
            this.groupBoxCalcul.Controls.Add(this.easycalculRB);
            this.groupBoxCalcul.Location = new System.Drawing.Point(401, 457);
            this.groupBoxCalcul.Name = "groupBoxCalcul";
            this.groupBoxCalcul.Size = new System.Drawing.Size(258, 75);
            this.groupBoxCalcul.TabIndex = 5;
            this.groupBoxCalcul.TabStop = false;
            this.groupBoxCalcul.Text = "Difficulté";
            // 
            // calcul
            // 
            this.calcul.Location = new System.Drawing.Point(172, 30);
            this.calcul.Name = "calcul";
            this.calcul.Size = new System.Drawing.Size(75, 21);
            this.calcul.TabIndex = 4;
            this.calcul.Text = "Lancer test";
            this.calcul.UseVisualStyleBackColor = true;
            this.calcul.Click += new System.EventHandler(this.launchTestClick);
            // 
            // hardcalculRB
            // 
            this.hardcalculRB.AutoSize = true;
            this.hardcalculRB.Location = new System.Drawing.Point(70, 50);
            this.hardcalculRB.Name = "hardcalculRB";
            this.hardcalculRB.Size = new System.Drawing.Size(74, 17);
            this.hardcalculRB.TabIndex = 3;
            this.hardcalculRB.TabStop = true;
            this.hardcalculRB.Text = "Compliqué";
            this.hardcalculRB.UseVisualStyleBackColor = true;
            // 
            // easycalculRB
            // 
            this.easycalculRB.AutoSize = true;
            this.easycalculRB.Checked = true;
            this.easycalculRB.Location = new System.Drawing.Point(70, 18);
            this.easycalculRB.Name = "easycalculRB";
            this.easycalculRB.Size = new System.Drawing.Size(53, 17);
            this.easycalculRB.TabIndex = 2;
            this.easycalculRB.TabStop = true;
            this.easycalculRB.Text = "Facile";
            this.easycalculRB.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 581);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(257, 24);
            this.label6.TabIndex = 8;
            this.label6.Text = "Problèmes mathématiques";
            // 
            // groupBoxPbMaths
            // 
            this.groupBoxPbMaths.Controls.Add(this.mathematics);
            this.groupBoxPbMaths.Controls.Add(this.hardmathematicsRB);
            this.groupBoxPbMaths.Controls.Add(this.eaysmathematicsRB);
            this.groupBoxPbMaths.Location = new System.Drawing.Point(401, 550);
            this.groupBoxPbMaths.Name = "groupBoxPbMaths";
            this.groupBoxPbMaths.Size = new System.Drawing.Size(258, 75);
            this.groupBoxPbMaths.TabIndex = 7;
            this.groupBoxPbMaths.TabStop = false;
            this.groupBoxPbMaths.Text = "Difficulté";
            // 
            // mathematics
            // 
            this.mathematics.Location = new System.Drawing.Point(172, 30);
            this.mathematics.Name = "mathematics";
            this.mathematics.Size = new System.Drawing.Size(75, 21);
            this.mathematics.TabIndex = 4;
            this.mathematics.Text = "Lancer test";
            this.mathematics.UseVisualStyleBackColor = true;
            this.mathematics.Click += new System.EventHandler(this.launchTestClick);
            // 
            // hardmathematicsRB
            // 
            this.hardmathematicsRB.AutoSize = true;
            this.hardmathematicsRB.Location = new System.Drawing.Point(70, 50);
            this.hardmathematicsRB.Name = "hardmathematicsRB";
            this.hardmathematicsRB.Size = new System.Drawing.Size(74, 17);
            this.hardmathematicsRB.TabIndex = 3;
            this.hardmathematicsRB.TabStop = true;
            this.hardmathematicsRB.Text = "Compliqué";
            this.hardmathematicsRB.UseVisualStyleBackColor = true;
            // 
            // eaysmathematicsRB
            // 
            this.eaysmathematicsRB.AutoSize = true;
            this.eaysmathematicsRB.Checked = true;
            this.eaysmathematicsRB.Location = new System.Drawing.Point(70, 18);
            this.eaysmathematicsRB.Name = "eaysmathematicsRB";
            this.eaysmathematicsRB.Size = new System.Drawing.Size(53, 17);
            this.eaysmathematicsRB.TabIndex = 2;
            this.eaysmathematicsRB.TabStop = true;
            this.eaysmathematicsRB.Text = "Facile";
            this.eaysmathematicsRB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(65, 676);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(211, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "Problèmes physiques";
            // 
            // groupBoxPbPhys
            // 
            this.groupBoxPbPhys.Controls.Add(this.physics);
            this.groupBoxPbPhys.Controls.Add(this.hardphysicsRB);
            this.groupBoxPbPhys.Controls.Add(this.easyphysicsRB);
            this.groupBoxPbPhys.Location = new System.Drawing.Point(401, 645);
            this.groupBoxPbPhys.Name = "groupBoxPbPhys";
            this.groupBoxPbPhys.Size = new System.Drawing.Size(258, 75);
            this.groupBoxPbPhys.TabIndex = 5;
            this.groupBoxPbPhys.TabStop = false;
            this.groupBoxPbPhys.Text = "Difficulté";
            // 
            // physics
            // 
            this.physics.Location = new System.Drawing.Point(172, 30);
            this.physics.Name = "physics";
            this.physics.Size = new System.Drawing.Size(75, 21);
            this.physics.TabIndex = 4;
            this.physics.Text = "Lancer test";
            this.physics.UseVisualStyleBackColor = true;
            this.physics.Click += new System.EventHandler(this.launchTestClick);
            // 
            // hardphysicsRB
            // 
            this.hardphysicsRB.AutoSize = true;
            this.hardphysicsRB.Location = new System.Drawing.Point(70, 50);
            this.hardphysicsRB.Name = "hardphysicsRB";
            this.hardphysicsRB.Size = new System.Drawing.Size(74, 17);
            this.hardphysicsRB.TabIndex = 3;
            this.hardphysicsRB.Text = "Compliqué";
            this.hardphysicsRB.UseVisualStyleBackColor = true;
            // 
            // easyphysicsRB
            // 
            this.easyphysicsRB.AutoSize = true;
            this.easyphysicsRB.Checked = true;
            this.easyphysicsRB.Location = new System.Drawing.Point(70, 18);
            this.easyphysicsRB.Name = "easyphysicsRB";
            this.easyphysicsRB.Size = new System.Drawing.Size(53, 17);
            this.easyphysicsRB.TabIndex = 2;
            this.easyphysicsRB.TabStop = true;
            this.easyphysicsRB.Text = "Facile";
            this.easyphysicsRB.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(311, 167);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(54, 12);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(504, 160);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMenu.TabIndex = 9;
            this.pictureBoxMenu.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(749, 255);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Dernier résultat";
            // 
            // resPerceptionF
            // 
            this.resPerceptionF.AutoSize = true;
            this.resPerceptionF.Location = new System.Drawing.Point(770, 288);
            this.resPerceptionF.Name = "resPerceptionF";
            this.resPerceptionF.Size = new System.Drawing.Size(22, 13);
            this.resPerceptionF.TabIndex = 11;
            this.resPerceptionF.Text = "NA";
            // 
            // resPerceptionD
            // 
            this.resPerceptionD.AutoSize = true;
            this.resPerceptionD.Location = new System.Drawing.Point(770, 318);
            this.resPerceptionD.Name = "resPerceptionD";
            this.resPerceptionD.Size = new System.Drawing.Size(22, 13);
            this.resPerceptionD.TabIndex = 12;
            this.resPerceptionD.Text = "NA";
            // 
            // resAttentionD
            // 
            this.resAttentionD.AutoSize = true;
            this.resAttentionD.Location = new System.Drawing.Point(774, 414);
            this.resAttentionD.Name = "resAttentionD";
            this.resAttentionD.Size = new System.Drawing.Size(22, 13);
            this.resAttentionD.TabIndex = 14;
            this.resAttentionD.Text = "NA";
            // 
            // resAttentionF
            // 
            this.resAttentionF.AutoSize = true;
            this.resAttentionF.Location = new System.Drawing.Point(774, 384);
            this.resAttentionF.Name = "resAttentionF";
            this.resAttentionF.Size = new System.Drawing.Size(22, 13);
            this.resAttentionF.TabIndex = 13;
            this.resAttentionF.Text = "NA";
            // 
            // resCalculD
            // 
            this.resCalculD.AutoSize = true;
            this.resCalculD.Location = new System.Drawing.Point(774, 507);
            this.resCalculD.Name = "resCalculD";
            this.resCalculD.Size = new System.Drawing.Size(22, 13);
            this.resCalculD.TabIndex = 16;
            this.resCalculD.Text = "NA";
            // 
            // resCalculF
            // 
            this.resCalculF.AutoSize = true;
            this.resCalculF.Location = new System.Drawing.Point(774, 475);
            this.resCalculF.Name = "resCalculF";
            this.resCalculF.Size = new System.Drawing.Size(22, 13);
            this.resCalculF.TabIndex = 15;
            this.resCalculF.Text = "NA";
            // 
            // resMathsD
            // 
            this.resMathsD.AutoSize = true;
            this.resMathsD.Location = new System.Drawing.Point(774, 598);
            this.resMathsD.Name = "resMathsD";
            this.resMathsD.Size = new System.Drawing.Size(22, 13);
            this.resMathsD.TabIndex = 18;
            this.resMathsD.Text = "NA";
            // 
            // resMathsF
            // 
            this.resMathsF.AutoSize = true;
            this.resMathsF.Location = new System.Drawing.Point(774, 568);
            this.resMathsF.Name = "resMathsF";
            this.resMathsF.Size = new System.Drawing.Size(22, 13);
            this.resMathsF.TabIndex = 17;
            this.resMathsF.Text = "NA";
            // 
            // resPhysiqueD
            // 
            this.resPhysiqueD.AutoSize = true;
            this.resPhysiqueD.Location = new System.Drawing.Point(774, 693);
            this.resPhysiqueD.Name = "resPhysiqueD";
            this.resPhysiqueD.Size = new System.Drawing.Size(22, 13);
            this.resPhysiqueD.TabIndex = 20;
            this.resPhysiqueD.Text = "NA";
            // 
            // resPhysiqueF
            // 
            this.resPhysiqueF.AutoSize = true;
            this.resPhysiqueF.Location = new System.Drawing.Point(774, 663);
            this.resPhysiqueF.Name = "resPhysiqueF";
            this.resPhysiqueF.Size = new System.Drawing.Size(22, 13);
            this.resPhysiqueF.TabIndex = 19;
            this.resPhysiqueF.Text = "NA";
            // 
            // View
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(873, 718);
            this.Controls.Add(this.resPhysiqueD);
            this.Controls.Add(this.resPhysiqueF);
            this.Controls.Add(this.resMathsD);
            this.Controls.Add(this.resMathsF);
            this.Controls.Add(this.resCalculD);
            this.Controls.Add(this.resCalculF);
            this.Controls.Add(this.resAttentionD);
            this.Controls.Add(this.resAttentionF);
            this.Controls.Add(this.resPerceptionD);
            this.Controls.Add(this.resPerceptionF);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pictureBoxMenu);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBoxPbPhys);
            this.Controls.Add(this.groupBoxPbMaths);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxCalcul);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBoxAttention);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBoxPerception);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "View";
            this.Text = "View";
            this.groupBoxPerception.ResumeLayout(false);
            this.groupBoxPerception.PerformLayout();
            this.groupBoxAttention.ResumeLayout(false);
            this.groupBoxAttention.PerformLayout();
            this.groupBoxCalcul.ResumeLayout(false);
            this.groupBoxCalcul.PerformLayout();
            this.groupBoxPbMaths.ResumeLayout(false);
            this.groupBoxPbMaths.PerformLayout();
            this.groupBoxPbPhys.ResumeLayout(false);
            this.groupBoxPbPhys.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBoxPerception;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxAttention;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxCalcul;
        private System.Windows.Forms.Button calcul;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBoxPbMaths;
        private System.Windows.Forms.Button mathematics;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBoxPbPhys;
        private System.Windows.Forms.Button physics;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button memory;
        private System.Windows.Forms.Button attention;
        public System.Windows.Forms.RadioButton easyphysicsRB;
        public System.Windows.Forms.RadioButton hardphysicsRB;
        public System.Windows.Forms.RadioButton hardmathematicsRB;
        public System.Windows.Forms.RadioButton easycalculRB;
        public System.Windows.Forms.RadioButton hardcalculRB;
        public System.Windows.Forms.RadioButton easyattentionRB;
        public System.Windows.Forms.RadioButton hardattentionRB;
        public System.Windows.Forms.RadioButton hardmemoryRB;
        public System.Windows.Forms.RadioButton easymemoryRB;
        public System.Windows.Forms.RadioButton eaysmathematicsRB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label resPerceptionF;
        private System.Windows.Forms.Label resPerceptionD;
        private System.Windows.Forms.Label resAttentionD;
        private System.Windows.Forms.Label resAttentionF;
        private System.Windows.Forms.Label resCalculD;
        private System.Windows.Forms.Label resCalculF;
        private System.Windows.Forms.Label resMathsD;
        private System.Windows.Forms.Label resMathsF;
        private System.Windows.Forms.Label resPhysiqueD;
        private System.Windows.Forms.Label resPhysiqueF;
    }
}