
namespace Project_2
{
    partial class Main_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.gameMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newGame = new System.Windows.Forms.ToolStripMenuItem();
            this.exitGame = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.smallSize = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumSize = new System.Windows.Forms.ToolStripMenuItem();
            this.largeSize = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.march2Rule = new System.Windows.Forms.ToolStripMenuItem();
            this.march3Rule = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.largeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ruleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.match2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.match3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.mainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.BackColor = System.Drawing.SystemColors.HighlightText;
            this.mainMenu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenu,
            this.sizeMenu,
            this.ruleMenu,
            this.aboutMenu});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(768, 31);
            this.mainMenu.TabIndex = 0;
            this.mainMenu.Text = "mainMenuStrip";
            // 
            // gameMenu
            // 
            this.gameMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGame,
            this.exitGame});
            this.gameMenu.Name = "gameMenu";
            this.gameMenu.Size = new System.Drawing.Size(69, 27);
            this.gameMenu.Text = "Game";
            // 
            // newGame
            // 
            this.newGame.Name = "newGame";
            this.newGame.Size = new System.Drawing.Size(178, 28);
            this.newGame.Text = "New Game";
            // 
            // exitGame
            // 
            this.exitGame.Name = "exitGame";
            this.exitGame.Size = new System.Drawing.Size(178, 28);
            this.exitGame.Text = "Exit";
            this.exitGame.Click += new System.EventHandler(this.exitGame_Click);
            // 
            // sizeMenu
            // 
            this.sizeMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallSize,
            this.mediumSize,
            this.largeSize});
            this.sizeMenu.Name = "sizeMenu";
            this.sizeMenu.Size = new System.Drawing.Size(54, 27);
            this.sizeMenu.Text = "Size";
            // 
            // smallSize
            // 
            this.smallSize.CheckOnClick = true;
            this.smallSize.Name = "smallSize";
            this.smallSize.Size = new System.Drawing.Size(224, 28);
            this.smallSize.Text = "Small";
            this.smallSize.Click += new System.EventHandler(this.smallSize_Click);
            // 
            // mediumSize
            // 
            this.mediumSize.CheckOnClick = true;
            this.mediumSize.Name = "mediumSize";
            this.mediumSize.Size = new System.Drawing.Size(224, 28);
            this.mediumSize.Text = "Medium";
            this.mediumSize.Click += new System.EventHandler(this.mediumSize_Click);
            // 
            // largeSize
            // 
            this.largeSize.CheckOnClick = true;
            this.largeSize.Name = "largeSize";
            this.largeSize.Size = new System.Drawing.Size(224, 28);
            this.largeSize.Text = "Large";
            this.largeSize.Click += new System.EventHandler(this.largeSize_Click);
            // 
            // ruleMenu
            // 
            this.ruleMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.march2Rule,
            this.march3Rule});
            this.ruleMenu.Name = "ruleMenu";
            this.ruleMenu.Size = new System.Drawing.Size(57, 27);
            this.ruleMenu.Text = "Rule";
            // 
            // march2Rule
            // 
            this.march2Rule.CheckOnClick = true;
            this.march2Rule.Name = "march2Rule";
            this.march2Rule.Size = new System.Drawing.Size(156, 28);
            this.march2Rule.Text = "March 2";
            this.march2Rule.Click += new System.EventHandler(this.march2Rule_Click);
            // 
            // march3Rule
            // 
            this.march3Rule.CheckOnClick = true;
            this.march3Rule.Name = "march3Rule";
            this.march3Rule.Size = new System.Drawing.Size(156, 28);
            this.march3Rule.Text = "March 3";
            this.march3Rule.Click += new System.EventHandler(this.march3Rule_Click);
            // 
            // aboutMenu
            // 
            this.aboutMenu.Name = "aboutMenu";
            this.aboutMenu.Size = new System.Drawing.Size(71, 27);
            this.aboutMenu.Text = "About";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // sizeToolStripMenuItem
            // 
            this.sizeToolStripMenuItem.CheckOnClick = true;
            this.sizeToolStripMenuItem.Name = "sizeToolStripMenuItem";
            this.sizeToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.sizeToolStripMenuItem.Text = "Size";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.CheckOnClick = true;
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.smallToolStripMenuItem.Text = "Small";
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.CheckOnClick = true;
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.mediumToolStripMenuItem.Text = "Medium";
            // 
            // largeToolStripMenuItem
            // 
            this.largeToolStripMenuItem.CheckOnClick = true;
            this.largeToolStripMenuItem.Name = "largeToolStripMenuItem";
            this.largeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.largeToolStripMenuItem.Text = "Large";
            // 
            // ruleToolStripMenuItem
            // 
            this.ruleToolStripMenuItem.Name = "ruleToolStripMenuItem";
            this.ruleToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            this.ruleToolStripMenuItem.Text = "Rule";
            // 
            // match2ToolStripMenuItem
            // 
            this.match2ToolStripMenuItem.CheckOnClick = true;
            this.match2ToolStripMenuItem.Name = "match2ToolStripMenuItem";
            this.match2ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.match2ToolStripMenuItem.Text = "Match 2";
            // 
            // match3ToolStripMenuItem
            // 
            this.match3ToolStripMenuItem.Name = "match3ToolStripMenuItem";
            this.match3ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.match3ToolStripMenuItem.Text = "Match 3";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // MainFlowLayoutPanel
            // 
            this.MainFlowLayoutPanel.AutoScroll = true;
            this.MainFlowLayoutPanel.Location = new System.Drawing.Point(12, 34);
            this.MainFlowLayoutPanel.Name = "MainFlowLayoutPanel";
            this.MainFlowLayoutPanel.Size = new System.Drawing.Size(744, 416);
            this.MainFlowLayoutPanel.TabIndex = 1;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "image0.jpg");
            this.imageList.Images.SetKeyName(1, "image1.jpg");
            this.imageList.Images.SetKeyName(2, "image2.jpg");
            this.imageList.Images.SetKeyName(3, "image3.jpg");
            this.imageList.Images.SetKeyName(4, "image4.jpg");
            this.imageList.Images.SetKeyName(5, "image5.jpg");
            this.imageList.Images.SetKeyName(6, "image6.jpg");
            this.imageList.Images.SetKeyName(7, "image7.jpg");
            this.imageList.Images.SetKeyName(8, "image8.jpg");
            this.imageList.Images.SetKeyName(9, "image9.jpg");
            this.imageList.Images.SetKeyName(10, "image10.jpg");
            this.imageList.Images.SetKeyName(11, "image11.jpg");
            this.imageList.Images.SetKeyName(12, "image12.jpg");
            this.imageList.Images.SetKeyName(13, "image13.jpg");
            this.imageList.Images.SetKeyName(14, "image14.jpg");
            this.imageList.Images.SetKeyName(15, "image15.jpg");
            this.imageList.Images.SetKeyName(16, "image16.jpg");
            // 
            // Main_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.MainFlowLayoutPanel);
            this.Controls.Add(this.mainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mainMenu;
            this.Name = "Main_Form";
            this.Text = "Concentration Game";
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem largeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ruleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem match2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem match3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameMenu;
        private System.Windows.Forms.ToolStripMenuItem newGame;
        private System.Windows.Forms.ToolStripMenuItem exitGame;
        private System.Windows.Forms.ToolStripMenuItem sizeMenu;
        private System.Windows.Forms.ToolStripMenuItem mediumSize;
        private System.Windows.Forms.ToolStripMenuItem largeSize;
        private System.Windows.Forms.ToolStripMenuItem ruleMenu;
        private System.Windows.Forms.ToolStripMenuItem march2Rule;
        private System.Windows.Forms.ToolStripMenuItem march3Rule;
        private System.Windows.Forms.ToolStripMenuItem aboutMenu;
        private System.Windows.Forms.ToolStripMenuItem smallSize;
        private System.Windows.Forms.FlowLayoutPanel MainFlowLayoutPanel;
        private System.Windows.Forms.ImageList imageList;
    }
}

