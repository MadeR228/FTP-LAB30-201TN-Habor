namespace WindowsFormsApp3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbHost = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbDeleteFile = new System.Windows.Forms.TextBox();
            this.tbDelete = new System.Windows.Forms.TextBox();
            this.tbNewDir = new System.Windows.Forms.TextBox();
            this.tbUploadFile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDeleteFile = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbWay = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Хост";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(72, 25);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(281, 20);
            this.tbHost.TabIndex = 3;
            this.tbHost.Text = "ftp://";
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(71, 47);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(282, 20);
            this.tbUser.TabIndex = 4;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(72, 71);
            this.tbPass.Name = "tbPass";
            this.tbPass.Size = new System.Drawing.Size(281, 20);
            this.tbPass.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 70);
            this.button1.TabIndex = 6;
            this.button1.Text = "Підключитися";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbDeleteFile);
            this.groupBox1.Controls.Add(this.tbDelete);
            this.groupBox1.Controls.Add(this.tbNewDir);
            this.groupBox1.Controls.Add(this.tbUploadFile);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnDeleteFile);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.btnCreateFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 236);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Операції з FTP";
            // 
            // tbDeleteFile
            // 
            this.tbDeleteFile.Location = new System.Drawing.Point(144, 182);
            this.tbDeleteFile.Name = "tbDeleteFile";
            this.tbDeleteFile.Size = new System.Drawing.Size(264, 20);
            this.tbDeleteFile.TabIndex = 18;
            // 
            // tbDelete
            // 
            this.tbDelete.Location = new System.Drawing.Point(146, 133);
            this.tbDelete.Name = "tbDelete";
            this.tbDelete.Size = new System.Drawing.Size(264, 20);
            this.tbDelete.TabIndex = 17;
            // 
            // tbNewDir
            // 
            this.tbNewDir.Location = new System.Drawing.Point(146, 84);
            this.tbNewDir.Name = "tbNewDir";
            this.tbNewDir.Size = new System.Drawing.Size(264, 20);
            this.tbNewDir.TabIndex = 16;
            // 
            // tbUploadFile
            // 
            this.tbUploadFile.Location = new System.Drawing.Point(144, 45);
            this.tbUploadFile.Name = "tbUploadFile";
            this.tbUploadFile.Size = new System.Drawing.Size(264, 20);
            this.tbUploadFile.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 185);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Файл:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(89, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Каталог:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(89, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Каталог:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(89, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Файл:";
            // 
            // btnDeleteFile
            // 
            this.btnDeleteFile.Location = new System.Drawing.Point(8, 169);
            this.btnDeleteFile.Name = "btnDeleteFile";
            this.btnDeleteFile.Size = new System.Drawing.Size(75, 45);
            this.btnDeleteFile.TabIndex = 3;
            this.btnDeleteFile.Text = "Видалити файл";
            this.btnDeleteFile.UseVisualStyleBackColor = true;
            this.btnDeleteFile.Click += new System.EventHandler(this.btnDeleteFile_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(8, 78);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 38);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Створити каталог";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(8, 37);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(75, 35);
            this.btnCreateFile.TabIndex = 0;
            this.btnCreateFile.Text = "Створити файл";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шлях:";
            // 
            // tbWay
            // 
            this.tbWay.Location = new System.Drawing.Point(67, 359);
            this.tbWay.Name = "tbWay";
            this.tbWay.Size = new System.Drawing.Size(377, 20);
            this.tbWay.TabIndex = 10;
            this.tbWay.Text = "/";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(450, 25);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(338, 354);
            this.treeView1.TabIndex = 11;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(8, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 41);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Видалити каталог";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 395);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.tbWay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.tbHost);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbHost;
        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteFile;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbDeleteFile;
        private System.Windows.Forms.TextBox tbDelete;
        private System.Windows.Forms.TextBox tbNewDir;
        private System.Windows.Forms.TextBox tbUploadFile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbWay;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnDelete;
    }
}

