
namespace higherANDlowerGame
{
    partial class Form1
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
            this.introMessage = new System.Windows.Forms.Label();
            this.askGuessLabel = new System.Windows.Forms.Label();
            this.inputGuessBox = new System.Windows.Forms.TextBox();
            this.guessNumberButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.newGameButton = new System.Windows.Forms.Button();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.amountGuessed = new System.Windows.Forms.Label();
            this.gameFinish = new System.Windows.Forms.Label();
            this.finishOptions = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // introMessage
            // 
            this.introMessage.AutoSize = true;
            this.introMessage.Location = new System.Drawing.Point(13, 37);
            this.introMessage.Name = "introMessage";
            this.introMessage.Size = new System.Drawing.Size(221, 13);
            this.introMessage.TabIndex = 0;
            this.introMessage.Text = "I am thinking of a number between 1 and 100";
            this.introMessage.Click += new System.EventHandler(this.introMessage_Click);
            // 
            // askGuessLabel
            // 
            this.askGuessLabel.AutoSize = true;
            this.askGuessLabel.Location = new System.Drawing.Point(13, 56);
            this.askGuessLabel.Name = "askGuessLabel";
            this.askGuessLabel.Size = new System.Drawing.Size(103, 13);
            this.askGuessLabel.TabIndex = 1;
            this.askGuessLabel.Text = "What is your guess?";
            this.askGuessLabel.Click += new System.EventHandler(this.askGuessLabel_Click);
            // 
            // inputGuessBox
            // 
            this.inputGuessBox.Location = new System.Drawing.Point(125, 56);
            this.inputGuessBox.Name = "inputGuessBox";
            this.inputGuessBox.Size = new System.Drawing.Size(109, 20);
            this.inputGuessBox.TabIndex = 2;
            this.inputGuessBox.TextChanged += new System.EventHandler(this.inputGuessBox_TextChanged);
            // 
            // guessNumberButton
            // 
            this.guessNumberButton.Location = new System.Drawing.Point(281, 37);
            this.guessNumberButton.Name = "guessNumberButton";
            this.guessNumberButton.Size = new System.Drawing.Size(108, 23);
            this.guessNumberButton.TabIndex = 3;
            this.guessNumberButton.Text = "Guess the Nmber";
            this.guessNumberButton.UseVisualStyleBackColor = true;
            this.guessNumberButton.Click += new System.EventHandler(this.guessNumberButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(281, 95);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(108, 23);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.Location = new System.Drawing.Point(13, 76);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(0, 13);
            this.labelHint.TabIndex = 6;
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(281, 66);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(108, 23);
            this.newGameButton.TabIndex = 4;
            this.newGameButton.Text = "New Game";
            this.newGameButton.UseVisualStyleBackColor = true;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            this.gameToolStripMenuItem.Click += new System.EventHandler(this.gameToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(411, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // amountGuessed
            // 
            this.amountGuessed.AutoSize = true;
            this.amountGuessed.Location = new System.Drawing.Point(13, 95);
            this.amountGuessed.Name = "amountGuessed";
            this.amountGuessed.Size = new System.Drawing.Size(0, 13);
            this.amountGuessed.TabIndex = 8;
            this.amountGuessed.Click += new System.EventHandler(this.amountGuessed_Click);
            // 
            // gameFinish
            // 
            this.gameFinish.AutoSize = true;
            this.gameFinish.Location = new System.Drawing.Point(13, 116);
            this.gameFinish.Name = "gameFinish";
            this.gameFinish.Size = new System.Drawing.Size(0, 13);
            this.gameFinish.TabIndex = 9;
            this.gameFinish.Click += new System.EventHandler(this.gameFinish_Click);
            // 
            // finishOptions
            // 
            this.finishOptions.AutoSize = true;
            this.finishOptions.Location = new System.Drawing.Point(13, 138);
            this.finishOptions.Name = "finishOptions";
            this.finishOptions.Size = new System.Drawing.Size(0, 13);
            this.finishOptions.TabIndex = 10;
            this.finishOptions.Click += new System.EventHandler(this.finishOptions_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 219);
            this.Controls.Add(this.finishOptions);
            this.Controls.Add(this.gameFinish);
            this.Controls.Add(this.amountGuessed);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.guessNumberButton);
            this.Controls.Add(this.inputGuessBox);
            this.Controls.Add(this.askGuessLabel);
            this.Controls.Add(this.introMessage);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Higher and Lower";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label introMessage;
        private System.Windows.Forms.Label askGuessLabel;
        private System.Windows.Forms.TextBox inputGuessBox;
        private System.Windows.Forms.Button guessNumberButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label amountGuessed;
        private System.Windows.Forms.Label gameFinish;
        private System.Windows.Forms.Label finishOptions;
    }
}

