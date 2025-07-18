namespace LifeLab
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			panelCanvas = new Panel();
			timer = new System.Windows.Forms.Timer(components);
			numericUpDownGridSize = new NumericUpDown();
			labelGridSize = new Label();
			labelSpeed = new Label();
			numericUpDownSpeed = new NumericUpDown();
			labelCellSize = new Label();
			numericUpDownCellSize = new NumericUpDown();
			toolStripContainer1 = new ToolStripContainer();
			statusStrip = new StatusStrip();
			toolStripStatusLabelGenerationStat = new ToolStripStatusLabel();
			toolStripStatusLabelAliveCellsStat = new ToolStripStatusLabel();
			toolStripStatusLabelDeadCellsStat = new ToolStripStatusLabel();
			toolStripStatusLabelMaxAliveCellsStat = new ToolStripStatusLabel();
			toolStripStatusLabelMinDeadCellsStat = new ToolStripStatusLabel();
			menuStrip = new MenuStrip();
			toolStripMenuItemFile = new ToolStripMenuItem();
			toolStripMenuItemLoad = new ToolStripMenuItem();
			toolStripMenuItemSave = new ToolStripMenuItem();
			toolStripSeparator7 = new ToolStripSeparator();
			toolStripMenuItemExit = new ToolStripMenuItem();
			toolsToolStripMenuItem = new ToolStripMenuItem();
			toolStripMenuItemSetDefaultValues = new ToolStripMenuItem();
			toolStripSeparator8 = new ToolStripSeparator();
			toolStripMenuItemColors = new ToolStripMenuItem();
			toolStripMenuItemSetColorOfAliveCells = new ToolStripMenuItem();
			toolStripMenuItemSetColorOfDeadCells = new ToolStripMenuItem();
			toolStrip = new ToolStrip();
			toolStripButtonStart = new ToolStripButton();
			toolStripButtonStop = new ToolStripButton();
			toolStripButtonReset = new ToolStripButton();
			toolStripButtonRandomPattern = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStripButtonLoad = new ToolStripButton();
			toolStripButtonSave = new ToolStripButton();
			toolStripSeparator2 = new ToolStripSeparator();
			toolStripButtonInfo = new ToolStripButton();
			toolStripButtonExit = new ToolStripButton();
			toolStripControls = new ToolStrip();
			toolStripLabelCellSize = new ToolStripLabel();
			toolStripButtonCellSizeIncrease = new ToolStripButton();
			toolStripButtonCellSizeDecrease = new ToolStripButton();
			toolStripSeparator5 = new ToolStripSeparator();
			toolStripButtonGridSize = new ToolStripLabel();
			toolStripButtonGridSizeIncrease = new ToolStripButton();
			toolStripButtonGridSizeDecrease = new ToolStripButton();
			toolStripSeparator4 = new ToolStripSeparator();
			toolStripButtonSpeed = new ToolStripLabel();
			toolStripButtonSpeedIncrease = new ToolStripButton();
			toolStripButtonSpeedDecrease = new ToolStripButton();
			toolStripSeparator3 = new ToolStripSeparator();
			toolStripDropDownButtonColors = new ToolStripDropDownButton();
			toolStripMenuItemColorCellsAlive = new ToolStripMenuItem();
			toolStripMenuItemColorCellsDead = new ToolStripMenuItem();
			toolStripSeparator6 = new ToolStripSeparator();
			toolStripMenuItemSetCanvasThemeBlackAndWhite = new ToolStripMenuItem();
			toolStripMenuItemSetCanvasThemeMatrix = new ToolStripMenuItem();
			toolStripMenuItemSetCanvasThemeIcyWorld = new ToolStripMenuItem();
			toolStripMenuItemSetCanvasThemeSolarized = new ToolStripMenuItem();
			toolStripButtonGridEnable = new ToolStripButton();
			toolTip = new ToolTip(components);
			((System.ComponentModel.ISupportInitialize)numericUpDownGridSize).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).BeginInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownCellSize).BeginInit();
			toolStripContainer1.BottomToolStripPanel.SuspendLayout();
			toolStripContainer1.ContentPanel.SuspendLayout();
			toolStripContainer1.TopToolStripPanel.SuspendLayout();
			toolStripContainer1.SuspendLayout();
			statusStrip.SuspendLayout();
			menuStrip.SuspendLayout();
			toolStrip.SuspendLayout();
			toolStripControls.SuspendLayout();
			SuspendLayout();
			// 
			// panelCanvas
			// 
			panelCanvas.AutoScroll = true;
			panelCanvas.BorderStyle = BorderStyle.FixedSingle;
			panelCanvas.Location = new Point(0, 0);
			panelCanvas.Name = "panelCanvas";
			panelCanvas.Size = new Size(119, 89);
			panelCanvas.TabIndex = 0;
			// 
			// numericUpDownGridSize
			// 
			numericUpDownGridSize.Location = new Point(263, 32);
			numericUpDownGridSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownGridSize.Name = "numericUpDownGridSize";
			numericUpDownGridSize.RightToLeft = RightToLeft.No;
			numericUpDownGridSize.Size = new Size(57, 23);
			numericUpDownGridSize.TabIndex = 4;
			numericUpDownGridSize.TextAlign = HorizontalAlignment.Center;
			numericUpDownGridSize.Value = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDownGridSize.ValueChanged += NumericUpDownGridSize_ValueChanged;
			// 
			// labelGridSize
			// 
			labelGridSize.AutoSize = true;
			labelGridSize.Location = new Point(204, 34);
			labelGridSize.Name = "labelGridSize";
			labelGridSize.Size = new Size(53, 15);
			labelGridSize.TabIndex = 3;
			labelGridSize.Text = "grid size:";
			// 
			// labelSpeed
			// 
			labelSpeed.AutoSize = true;
			labelSpeed.Location = new Point(216, 63);
			labelSpeed.Name = "labelSpeed";
			labelSpeed.Size = new Size(41, 15);
			labelSpeed.TabIndex = 5;
			labelSpeed.Text = "speed:";
			// 
			// numericUpDownSpeed
			// 
			numericUpDownSpeed.Location = new Point(263, 61);
			numericUpDownSpeed.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			numericUpDownSpeed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownSpeed.Name = "numericUpDownSpeed";
			numericUpDownSpeed.RightToLeft = RightToLeft.No;
			numericUpDownSpeed.Size = new Size(57, 23);
			numericUpDownSpeed.TabIndex = 6;
			numericUpDownSpeed.TextAlign = HorizontalAlignment.Center;
			numericUpDownSpeed.Value = new decimal(new int[] { 100, 0, 0, 0 });
			numericUpDownSpeed.ValueChanged += NumericUpDownSpeed_ValueChanged;
			// 
			// labelCellSize
			// 
			labelCellSize.AutoSize = true;
			labelCellSize.Location = new Point(207, 5);
			labelCellSize.Name = "labelCellSize";
			labelCellSize.Size = new Size(50, 15);
			labelCellSize.TabIndex = 1;
			labelCellSize.Text = "cell size:";
			// 
			// numericUpDownCellSize
			// 
			numericUpDownCellSize.Location = new Point(263, 3);
			numericUpDownCellSize.Maximum = new decimal(new int[] { 20, 0, 0, 0 });
			numericUpDownCellSize.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownCellSize.Name = "numericUpDownCellSize";
			numericUpDownCellSize.RightToLeft = RightToLeft.No;
			numericUpDownCellSize.Size = new Size(57, 23);
			numericUpDownCellSize.TabIndex = 2;
			numericUpDownCellSize.TextAlign = HorizontalAlignment.Center;
			numericUpDownCellSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
			numericUpDownCellSize.ValueChanged += NumericUpDownCellSize_ValueChanged;
			// 
			// toolStripContainer1
			// 
			// 
			// toolStripContainer1.BottomToolStripPanel
			// 
			toolStripContainer1.BottomToolStripPanel.Controls.Add(statusStrip);
			// 
			// toolStripContainer1.ContentPanel
			// 
			toolStripContainer1.ContentPanel.Controls.Add(panelCanvas);
			toolStripContainer1.ContentPanel.Controls.Add(labelCellSize);
			toolStripContainer1.ContentPanel.Controls.Add(numericUpDownCellSize);
			toolStripContainer1.ContentPanel.Controls.Add(labelSpeed);
			toolStripContainer1.ContentPanel.Controls.Add(numericUpDownSpeed);
			toolStripContainer1.ContentPanel.Controls.Add(labelGridSize);
			toolStripContainer1.ContentPanel.Controls.Add(numericUpDownGridSize);
			toolStripContainer1.ContentPanel.Size = new Size(382, 324);
			toolStripContainer1.Dock = DockStyle.Fill;
			toolStripContainer1.Location = new Point(0, 0);
			toolStripContainer1.Name = "toolStripContainer1";
			toolStripContainer1.Size = new Size(382, 420);
			toolStripContainer1.TabIndex = 0;
			toolStripContainer1.Text = "toolStripContainer1";
			// 
			// toolStripContainer1.TopToolStripPanel
			// 
			toolStripContainer1.TopToolStripPanel.Controls.Add(menuStrip);
			toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip);
			toolStripContainer1.TopToolStripPanel.Controls.Add(toolStripControls);
			// 
			// statusStrip
			// 
			statusStrip.AllowClickThrough = true;
			statusStrip.AllowItemReorder = true;
			statusStrip.Dock = DockStyle.None;
			statusStrip.Items.AddRange(new ToolStripItem[] { toolStripStatusLabelGenerationStat, toolStripStatusLabelAliveCellsStat, toolStripStatusLabelDeadCellsStat, toolStripStatusLabelMaxAliveCellsStat, toolStripStatusLabelMinDeadCellsStat });
			statusStrip.Location = new Point(0, 0);
			statusStrip.Name = "statusStrip";
			statusStrip.ShowItemToolTips = true;
			statusStrip.Size = new Size(382, 22);
			statusStrip.TabIndex = 0;
			statusStrip.TabStop = true;
			// 
			// toolStripStatusLabelGenerationStat
			// 
			toolStripStatusLabelGenerationStat.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelGenerationStat.BorderStyle = Border3DStyle.Etched;
			toolStripStatusLabelGenerationStat.Font = new Font("Segoe UI", 6.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
			toolStripStatusLabelGenerationStat.Name = "toolStripStatusLabelGenerationStat";
			toolStripStatusLabelGenerationStat.Size = new Size(52, 17);
			toolStripStatusLabelGenerationStat.Text = "generation";
			// 
			// toolStripStatusLabelAliveCellsStat
			// 
			toolStripStatusLabelAliveCellsStat.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelAliveCellsStat.BorderStyle = Border3DStyle.Etched;
			toolStripStatusLabelAliveCellsStat.Font = new Font("Segoe UI", 6.75F);
			toolStripStatusLabelAliveCellsStat.Name = "toolStripStatusLabelAliveCellsStat";
			toolStripStatusLabelAliveCellsStat.Size = new Size(46, 17);
			toolStripStatusLabelAliveCellsStat.Text = "alive cells";
			// 
			// toolStripStatusLabelDeadCellsStat
			// 
			toolStripStatusLabelDeadCellsStat.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelDeadCellsStat.BorderStyle = Border3DStyle.Etched;
			toolStripStatusLabelDeadCellsStat.Font = new Font("Segoe UI", 6.75F);
			toolStripStatusLabelDeadCellsStat.Name = "toolStripStatusLabelDeadCellsStat";
			toolStripStatusLabelDeadCellsStat.Size = new Size(51, 17);
			toolStripStatusLabelDeadCellsStat.Text = "death cells";
			// 
			// toolStripStatusLabelMaxAliveCellsStat
			// 
			toolStripStatusLabelMaxAliveCellsStat.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelMaxAliveCellsStat.BorderStyle = Border3DStyle.Etched;
			toolStripStatusLabelMaxAliveCellsStat.Font = new Font("Segoe UI", 6.75F);
			toolStripStatusLabelMaxAliveCellsStat.Name = "toolStripStatusLabelMaxAliveCellsStat";
			toolStripStatusLabelMaxAliveCellsStat.Size = new Size(67, 17);
			toolStripStatusLabelMaxAliveCellsStat.Text = "max. alive cells";
			// 
			// toolStripStatusLabelMinDeadCellsStat
			// 
			toolStripStatusLabelMinDeadCellsStat.BorderSides = ToolStripStatusLabelBorderSides.Left | ToolStripStatusLabelBorderSides.Top | ToolStripStatusLabelBorderSides.Right | ToolStripStatusLabelBorderSides.Bottom;
			toolStripStatusLabelMinDeadCellsStat.BorderStyle = Border3DStyle.Etched;
			toolStripStatusLabelMinDeadCellsStat.Font = new Font("Segoe UI", 6.75F);
			toolStripStatusLabelMinDeadCellsStat.Name = "toolStripStatusLabelMinDeadCellsStat";
			toolStripStatusLabelMinDeadCellsStat.Size = new Size(69, 17);
			toolStripStatusLabelMinDeadCellsStat.Text = "max. dead cells";
			// 
			// menuStrip
			// 
			menuStrip.Dock = DockStyle.None;
			menuStrip.Items.AddRange(new ToolStripItem[] { toolStripMenuItemFile, toolsToolStripMenuItem });
			menuStrip.Location = new Point(0, 0);
			menuStrip.Name = "menuStrip";
			menuStrip.RenderMode = ToolStripRenderMode.System;
			menuStrip.Size = new Size(382, 24);
			menuStrip.TabIndex = 2;
			menuStrip.Text = "menu";
			// 
			// toolStripMenuItemFile
			// 
			toolStripMenuItemFile.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemLoad, toolStripMenuItemSave, toolStripSeparator7, toolStripMenuItemExit });
			toolStripMenuItemFile.Name = "toolStripMenuItemFile";
			toolStripMenuItemFile.ShortcutKeyDisplayString = "Alt+F";
			toolStripMenuItemFile.ShortcutKeys = Keys.Alt | Keys.F;
			toolStripMenuItemFile.Size = new Size(37, 20);
			toolStripMenuItemFile.Text = "&File";
			// 
			// toolStripMenuItemLoad
			// 
			toolStripMenuItemLoad.Image = (Image)resources.GetObject("toolStripMenuItemLoad.Image");
			toolStripMenuItemLoad.Name = "toolStripMenuItemLoad";
			toolStripMenuItemLoad.ShortcutKeyDisplayString = "Alt+L";
			toolStripMenuItemLoad.ShortcutKeys = Keys.Alt | Keys.L;
			toolStripMenuItemLoad.Size = new Size(136, 22);
			toolStripMenuItemLoad.Text = "Load";
			toolStripMenuItemLoad.Click += ButtonLoad_Click;
			// 
			// toolStripMenuItemSave
			// 
			toolStripMenuItemSave.Image = (Image)resources.GetObject("toolStripMenuItemSave.Image");
			toolStripMenuItemSave.Name = "toolStripMenuItemSave";
			toolStripMenuItemSave.ShortcutKeyDisplayString = "Alt+S";
			toolStripMenuItemSave.ShortcutKeys = Keys.Alt | Keys.S;
			toolStripMenuItemSave.Size = new Size(136, 22);
			toolStripMenuItemSave.Text = "Save";
			toolStripMenuItemSave.Click += ButtonSave_Click;
			// 
			// toolStripSeparator7
			// 
			toolStripSeparator7.Name = "toolStripSeparator7";
			toolStripSeparator7.Size = new Size(133, 6);
			// 
			// toolStripMenuItemExit
			// 
			toolStripMenuItemExit.Image = (Image)resources.GetObject("toolStripMenuItemExit.Image");
			toolStripMenuItemExit.Name = "toolStripMenuItemExit";
			toolStripMenuItemExit.ShortcutKeyDisplayString = "Alt+X";
			toolStripMenuItemExit.ShortcutKeys = Keys.Alt | Keys.X;
			toolStripMenuItemExit.Size = new Size(136, 22);
			toolStripMenuItemExit.Text = "&Exit";
			toolStripMenuItemExit.Click += ButtonExit_Click;
			// 
			// toolsToolStripMenuItem
			// 
			toolsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemSetDefaultValues, toolStripSeparator8, toolStripMenuItemColors });
			toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			toolsToolStripMenuItem.ShortcutKeyDisplayString = "Alt+T";
			toolsToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.T;
			toolsToolStripMenuItem.Size = new Size(46, 20);
			toolsToolStripMenuItem.Text = "&Tools";
			// 
			// toolStripMenuItemSetDefaultValues
			// 
			toolStripMenuItemSetDefaultValues.Name = "toolStripMenuItemSetDefaultValues";
			toolStripMenuItemSetDefaultValues.ShortcutKeyDisplayString = "Alt+D";
			toolStripMenuItemSetDefaultValues.ShortcutKeys = Keys.Alt | Keys.T;
			toolStripMenuItemSetDefaultValues.Size = new Size(204, 22);
			toolStripMenuItemSetDefaultValues.Text = "Set default values";
			// 
			// toolStripSeparator8
			// 
			toolStripSeparator8.Name = "toolStripSeparator8";
			toolStripSeparator8.Size = new Size(201, 6);
			// 
			// toolStripMenuItemColors
			// 
			toolStripMenuItemColors.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemSetColorOfAliveCells, toolStripMenuItemSetColorOfDeadCells });
			toolStripMenuItemColors.Image = (Image)resources.GetObject("toolStripMenuItemColors.Image");
			toolStripMenuItemColors.Name = "toolStripMenuItemColors";
			toolStripMenuItemColors.ShortcutKeyDisplayString = "Alt+C";
			toolStripMenuItemColors.ShortcutKeys = Keys.Alt | Keys.C;
			toolStripMenuItemColors.Size = new Size(204, 22);
			toolStripMenuItemColors.Text = "&Colors";
			// 
			// toolStripMenuItemSetColorOfAliveCells
			// 
			toolStripMenuItemSetColorOfAliveCells.Name = "toolStripMenuItemSetColorOfAliveCells";
			toolStripMenuItemSetColorOfAliveCells.Size = new Size(170, 22);
			toolStripMenuItemSetColorOfAliveCells.Text = "color of alive cells";
			toolStripMenuItemSetColorOfAliveCells.Click += ButtonAliveColor_Click;
			// 
			// toolStripMenuItemSetColorOfDeadCells
			// 
			toolStripMenuItemSetColorOfDeadCells.Name = "toolStripMenuItemSetColorOfDeadCells";
			toolStripMenuItemSetColorOfDeadCells.Size = new Size(170, 22);
			toolStripMenuItemSetColorOfDeadCells.Text = "color of dead cells";
			toolStripMenuItemSetColorOfDeadCells.Click += ButtonDeadColor_Click;
			// 
			// toolStrip
			// 
			toolStrip.Dock = DockStyle.None;
			toolStrip.Items.AddRange(new ToolStripItem[] { toolStripButtonStart, toolStripButtonStop, toolStripButtonReset, toolStripButtonRandomPattern, toolStripSeparator1, toolStripButtonLoad, toolStripButtonSave, toolStripSeparator2, toolStripButtonInfo, toolStripButtonExit });
			toolStrip.Location = new Point(3, 24);
			toolStrip.Name = "toolStrip";
			toolStrip.RenderMode = ToolStripRenderMode.System;
			toolStrip.Size = new Size(208, 25);
			toolStrip.TabIndex = 0;
			// 
			// toolStripButtonStart
			// 
			toolStripButtonStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonStart.Image = (Image)resources.GetObject("toolStripButtonStart.Image");
			toolStripButtonStart.ImageTransparentColor = Color.Magenta;
			toolStripButtonStart.Name = "toolStripButtonStart";
			toolStripButtonStart.Size = new Size(23, 22);
			toolStripButtonStart.Text = "Start";
			toolStripButtonStart.Click += ButtonStart_Click;
			// 
			// toolStripButtonStop
			// 
			toolStripButtonStop.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonStop.Enabled = false;
			toolStripButtonStop.Image = (Image)resources.GetObject("toolStripButtonStop.Image");
			toolStripButtonStop.ImageTransparentColor = Color.Magenta;
			toolStripButtonStop.Name = "toolStripButtonStop";
			toolStripButtonStop.Size = new Size(23, 22);
			toolStripButtonStop.Text = "Stop";
			toolStripButtonStop.Click += ButtonStop_Click;
			// 
			// toolStripButtonReset
			// 
			toolStripButtonReset.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonReset.Image = (Image)resources.GetObject("toolStripButtonReset.Image");
			toolStripButtonReset.ImageTransparentColor = Color.Magenta;
			toolStripButtonReset.Name = "toolStripButtonReset";
			toolStripButtonReset.Size = new Size(23, 22);
			toolStripButtonReset.Text = "Reset";
			toolStripButtonReset.Click += ButtonReset_Click;
			// 
			// toolStripButtonRandomPattern
			// 
			toolStripButtonRandomPattern.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonRandomPattern.Image = (Image)resources.GetObject("toolStripButtonRandomPattern.Image");
			toolStripButtonRandomPattern.ImageTransparentColor = Color.Magenta;
			toolStripButtonRandomPattern.Name = "toolStripButtonRandomPattern";
			toolStripButtonRandomPattern.Size = new Size(23, 22);
			toolStripButtonRandomPattern.Text = "Random Pattern";
			toolStripButtonRandomPattern.Click += ButtonRandomPattern_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			// 
			// toolStripButtonLoad
			// 
			toolStripButtonLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonLoad.Image = (Image)resources.GetObject("toolStripButtonLoad.Image");
			toolStripButtonLoad.ImageTransparentColor = Color.Magenta;
			toolStripButtonLoad.Name = "toolStripButtonLoad";
			toolStripButtonLoad.Size = new Size(23, 22);
			toolStripButtonLoad.Text = "Load";
			toolStripButtonLoad.Click += ButtonLoad_Click;
			// 
			// toolStripButtonSave
			// 
			toolStripButtonSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonSave.Image = (Image)resources.GetObject("toolStripButtonSave.Image");
			toolStripButtonSave.ImageTransparentColor = Color.Magenta;
			toolStripButtonSave.Name = "toolStripButtonSave";
			toolStripButtonSave.Size = new Size(23, 22);
			toolStripButtonSave.Text = "Save";
			toolStripButtonSave.Click += ButtonSave_Click;
			// 
			// toolStripSeparator2
			// 
			toolStripSeparator2.Name = "toolStripSeparator2";
			toolStripSeparator2.Size = new Size(6, 25);
			// 
			// toolStripButtonInfo
			// 
			toolStripButtonInfo.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonInfo.Image = (Image)resources.GetObject("toolStripButtonInfo.Image");
			toolStripButtonInfo.ImageTransparentColor = Color.Magenta;
			toolStripButtonInfo.Name = "toolStripButtonInfo";
			toolStripButtonInfo.Size = new Size(23, 22);
			toolStripButtonInfo.Text = "Info";
			// 
			// toolStripButtonExit
			// 
			toolStripButtonExit.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonExit.Image = (Image)resources.GetObject("toolStripButtonExit.Image");
			toolStripButtonExit.ImageTransparentColor = Color.Magenta;
			toolStripButtonExit.Name = "toolStripButtonExit";
			toolStripButtonExit.Size = new Size(23, 22);
			toolStripButtonExit.Text = "Exit";
			toolStripButtonExit.Click += ButtonExit_Click;
			// 
			// toolStripControls
			// 
			toolStripControls.Dock = DockStyle.None;
			toolStripControls.Items.AddRange(new ToolStripItem[] { toolStripLabelCellSize, toolStripButtonCellSizeIncrease, toolStripButtonCellSizeDecrease, toolStripSeparator5, toolStripButtonGridSize, toolStripButtonGridSizeIncrease, toolStripButtonGridSizeDecrease, toolStripSeparator4, toolStripButtonSpeed, toolStripButtonSpeedIncrease, toolStripButtonSpeedDecrease, toolStripSeparator3, toolStripDropDownButtonColors, toolStripButtonGridEnable });
			toolStripControls.Location = new Point(3, 49);
			toolStripControls.Name = "toolStripControls";
			toolStripControls.RenderMode = ToolStripRenderMode.System;
			toolStripControls.Size = new Size(379, 25);
			toolStripControls.TabIndex = 1;
			toolStripControls.Text = "Controls";
			// 
			// toolStripLabelCellSize
			// 
			toolStripLabelCellSize.Name = "toolStripLabelCellSize";
			toolStripLabelCellSize.Size = new Size(50, 22);
			toolStripLabelCellSize.Text = "cell size:";
			// 
			// toolStripButtonCellSizeIncrease
			// 
			toolStripButtonCellSizeIncrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonCellSizeIncrease.Image = (Image)resources.GetObject("toolStripButtonCellSizeIncrease.Image");
			toolStripButtonCellSizeIncrease.ImageTransparentColor = Color.Magenta;
			toolStripButtonCellSizeIncrease.Name = "toolStripButtonCellSizeIncrease";
			toolStripButtonCellSizeIncrease.Size = new Size(23, 22);
			toolStripButtonCellSizeIncrease.Text = "Increase the cell size";
			// 
			// toolStripButtonCellSizeDecrease
			// 
			toolStripButtonCellSizeDecrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonCellSizeDecrease.Image = (Image)resources.GetObject("toolStripButtonCellSizeDecrease.Image");
			toolStripButtonCellSizeDecrease.ImageTransparentColor = Color.Magenta;
			toolStripButtonCellSizeDecrease.Name = "toolStripButtonCellSizeDecrease";
			toolStripButtonCellSizeDecrease.Size = new Size(23, 22);
			toolStripButtonCellSizeDecrease.Text = "Decrease the cell size";
			// 
			// toolStripSeparator5
			// 
			toolStripSeparator5.Name = "toolStripSeparator5";
			toolStripSeparator5.Size = new Size(6, 25);
			// 
			// toolStripButtonGridSize
			// 
			toolStripButtonGridSize.Name = "toolStripButtonGridSize";
			toolStripButtonGridSize.Size = new Size(53, 22);
			toolStripButtonGridSize.Text = "grid size:";
			// 
			// toolStripButtonGridSizeIncrease
			// 
			toolStripButtonGridSizeIncrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonGridSizeIncrease.Image = (Image)resources.GetObject("toolStripButtonGridSizeIncrease.Image");
			toolStripButtonGridSizeIncrease.ImageTransparentColor = Color.Magenta;
			toolStripButtonGridSizeIncrease.Name = "toolStripButtonGridSizeIncrease";
			toolStripButtonGridSizeIncrease.Size = new Size(23, 22);
			toolStripButtonGridSizeIncrease.Text = "Increase the grid size";
			// 
			// toolStripButtonGridSizeDecrease
			// 
			toolStripButtonGridSizeDecrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonGridSizeDecrease.Image = (Image)resources.GetObject("toolStripButtonGridSizeDecrease.Image");
			toolStripButtonGridSizeDecrease.ImageTransparentColor = Color.Magenta;
			toolStripButtonGridSizeDecrease.Name = "toolStripButtonGridSizeDecrease";
			toolStripButtonGridSizeDecrease.Size = new Size(23, 22);
			toolStripButtonGridSizeDecrease.Text = "Decrease the grid size";
			// 
			// toolStripSeparator4
			// 
			toolStripSeparator4.Name = "toolStripSeparator4";
			toolStripSeparator4.Size = new Size(6, 25);
			// 
			// toolStripButtonSpeed
			// 
			toolStripButtonSpeed.Name = "toolStripButtonSpeed";
			toolStripButtonSpeed.Size = new Size(41, 22);
			toolStripButtonSpeed.Text = "speed:";
			// 
			// toolStripButtonSpeedIncrease
			// 
			toolStripButtonSpeedIncrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonSpeedIncrease.Image = (Image)resources.GetObject("toolStripButtonSpeedIncrease.Image");
			toolStripButtonSpeedIncrease.ImageTransparentColor = Color.Magenta;
			toolStripButtonSpeedIncrease.Name = "toolStripButtonSpeedIncrease";
			toolStripButtonSpeedIncrease.Size = new Size(23, 22);
			toolStripButtonSpeedIncrease.Text = "Increase the speed";
			// 
			// toolStripButtonSpeedDecrease
			// 
			toolStripButtonSpeedDecrease.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonSpeedDecrease.Image = (Image)resources.GetObject("toolStripButtonSpeedDecrease.Image");
			toolStripButtonSpeedDecrease.ImageTransparentColor = Color.Magenta;
			toolStripButtonSpeedDecrease.Name = "toolStripButtonSpeedDecrease";
			toolStripButtonSpeedDecrease.Size = new Size(23, 22);
			toolStripButtonSpeedDecrease.Text = "Decrease the speed";
			// 
			// toolStripSeparator3
			// 
			toolStripSeparator3.Name = "toolStripSeparator3";
			toolStripSeparator3.Size = new Size(6, 25);
			// 
			// toolStripDropDownButtonColors
			// 
			toolStripDropDownButtonColors.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripDropDownButtonColors.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItemColorCellsAlive, toolStripMenuItemColorCellsDead, toolStripSeparator6, toolStripMenuItemSetCanvasThemeBlackAndWhite, toolStripMenuItemSetCanvasThemeMatrix, toolStripMenuItemSetCanvasThemeIcyWorld, toolStripMenuItemSetCanvasThemeSolarized });
			toolStripDropDownButtonColors.Image = (Image)resources.GetObject("toolStripDropDownButtonColors.Image");
			toolStripDropDownButtonColors.ImageTransparentColor = Color.Magenta;
			toolStripDropDownButtonColors.Name = "toolStripDropDownButtonColors";
			toolStripDropDownButtonColors.Size = new Size(29, 22);
			toolStripDropDownButtonColors.Text = "Colors";
			// 
			// toolStripMenuItemColorCellsAlive
			// 
			toolStripMenuItemColorCellsAlive.Name = "toolStripMenuItemColorCellsAlive";
			toolStripMenuItemColorCellsAlive.Size = new Size(180, 22);
			toolStripMenuItemColorCellsAlive.Text = "color of alive cells";
			toolStripMenuItemColorCellsAlive.Click += ButtonAliveColor_Click;
			// 
			// toolStripMenuItemColorCellsDead
			// 
			toolStripMenuItemColorCellsDead.Name = "toolStripMenuItemColorCellsDead";
			toolStripMenuItemColorCellsDead.Size = new Size(180, 22);
			toolStripMenuItemColorCellsDead.Text = "color of dead cells";
			toolStripMenuItemColorCellsDead.Click += ButtonDeadColor_Click;
			// 
			// toolStripSeparator6
			// 
			toolStripSeparator6.Name = "toolStripSeparator6";
			toolStripSeparator6.Size = new Size(177, 6);
			// 
			// toolStripMenuItemSetCanvasThemeBlackAndWhite
			// 
			toolStripMenuItemSetCanvasThemeBlackAndWhite.CheckOnClick = true;
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Name = "toolStripMenuItemSetCanvasThemeBlackAndWhite";
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Size = new Size(180, 22);
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Text = "black and white";
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Click += ButtonSetCanvasThemeBlackAndWhite_Click;
			// 
			// toolStripMenuItemSetCanvasThemeMatrix
			// 
			toolStripMenuItemSetCanvasThemeMatrix.CheckOnClick = true;
			toolStripMenuItemSetCanvasThemeMatrix.Name = "toolStripMenuItemSetCanvasThemeMatrix";
			toolStripMenuItemSetCanvasThemeMatrix.Size = new Size(180, 22);
			toolStripMenuItemSetCanvasThemeMatrix.Text = "matrix";
			toolStripMenuItemSetCanvasThemeMatrix.Click += ButtonSetCanvasThemeMatrix_Click;
			// 
			// toolStripMenuItemSetCanvasThemeIcyWorld
			// 
			toolStripMenuItemSetCanvasThemeIcyWorld.CheckOnClick = true;
			toolStripMenuItemSetCanvasThemeIcyWorld.Name = "toolStripMenuItemSetCanvasThemeIcyWorld";
			toolStripMenuItemSetCanvasThemeIcyWorld.Size = new Size(180, 22);
			toolStripMenuItemSetCanvasThemeIcyWorld.Text = "icy world";
			toolStripMenuItemSetCanvasThemeIcyWorld.Click += ButtonSetCanvasThemeIcyWorld_ButtonSetCanvasTheme;
			// 
			// toolStripMenuItemSetCanvasThemeSolarized
			// 
			toolStripMenuItemSetCanvasThemeSolarized.CheckOnClick = true;
			toolStripMenuItemSetCanvasThemeSolarized.Name = "toolStripMenuItemSetCanvasThemeSolarized";
			toolStripMenuItemSetCanvasThemeSolarized.Size = new Size(180, 22);
			toolStripMenuItemSetCanvasThemeSolarized.Text = "solarized";
			toolStripMenuItemSetCanvasThemeSolarized.Click += ButtonSetCanvasThemeSolarized_Click;
			// 
			// toolStripButtonGridEnable
			// 
			toolStripButtonGridEnable.Checked = true;
			toolStripButtonGridEnable.CheckOnClick = true;
			toolStripButtonGridEnable.CheckState = CheckState.Checked;
			toolStripButtonGridEnable.DisplayStyle = ToolStripItemDisplayStyle.Image;
			toolStripButtonGridEnable.Image = (Image)resources.GetObject("toolStripButtonGridEnable.Image");
			toolStripButtonGridEnable.ImageTransparentColor = Color.Magenta;
			toolStripButtonGridEnable.Name = "toolStripButtonGridEnable";
			toolStripButtonGridEnable.Size = new Size(23, 22);
			toolStripButtonGridEnable.Text = "Enable/disable the grid";
			toolStripButtonGridEnable.Click += ButtonEnableGrid_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(382, 420);
			Controls.Add(toolStripContainer1);
			MainMenuStrip = menuStrip;
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Life Lab";
			((System.ComponentModel.ISupportInitialize)numericUpDownGridSize).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownSpeed).EndInit();
			((System.ComponentModel.ISupportInitialize)numericUpDownCellSize).EndInit();
			toolStripContainer1.BottomToolStripPanel.ResumeLayout(false);
			toolStripContainer1.BottomToolStripPanel.PerformLayout();
			toolStripContainer1.ContentPanel.ResumeLayout(false);
			toolStripContainer1.ContentPanel.PerformLayout();
			toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
			toolStripContainer1.TopToolStripPanel.PerformLayout();
			toolStripContainer1.ResumeLayout(false);
			toolStripContainer1.PerformLayout();
			statusStrip.ResumeLayout(false);
			statusStrip.PerformLayout();
			menuStrip.ResumeLayout(false);
			menuStrip.PerformLayout();
			toolStrip.ResumeLayout(false);
			toolStrip.PerformLayout();
			toolStripControls.ResumeLayout(false);
			toolStripControls.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Panel panelCanvas;
		private System.Windows.Forms.Timer timer;
		private NumericUpDown numericUpDownGridSize;
		private Label labelGridSize;
		private Label labelSpeed;
		private NumericUpDown numericUpDownSpeed;
		private Label labelCellSize;
		private NumericUpDown numericUpDownCellSize;
		private ToolStripContainer toolStripContainer1;
		private StatusStrip statusStrip;
		private ToolStrip toolStrip;
		private ToolTip toolTip;
		private ToolStripButton toolStripButtonStart;
		private ToolStripButton toolStripButtonStop;
		private ToolStripButton toolStripButtonReset;
		private ToolStripStatusLabel toolStripStatusLabelGenerationStat;
		private ToolStripSeparator toolStripSeparator1;
		private ToolStripButton toolStripButtonLoad;
		private ToolStripButton toolStripButtonSave;
		private ToolStripSeparator toolStripSeparator2;
		private ToolStripButton toolStripButtonInfo;
		private ToolStripButton toolStripButtonExit;
		private ToolStrip toolStripControls;
		private ToolStripLabel toolStripButtonSpeed;
		private ToolStripButton toolStripButtonSpeedIncrease;
		private ToolStripLabel toolStripLabelCellSize;
		private ToolStripButton toolStripButtonCellSizeIncrease;
		private ToolStripButton toolStripButtonCellSizeDecrease;
		private ToolStripSeparator toolStripSeparator5;
		private ToolStripLabel toolStripButtonGridSize;
		private ToolStripButton toolStripButtonGridSizeIncrease;
		private ToolStripButton toolStripButtonGridSizeDecrease;
		private ToolStripSeparator toolStripSeparator4;
		private ToolStripButton toolStripButtonSpeedDecrease;
		private ToolStripButton toolStripButtonRandomPattern;
		private ToolStripStatusLabel toolStripStatusLabelMaxAliveCellsStat;
		private ToolStripStatusLabel toolStripStatusLabelMinDeadCellsStat;
		private ToolStripStatusLabel toolStripStatusLabelAliveCellsStat;
		private ToolStripStatusLabel toolStripStatusLabelDeadCellsStat;
		private ToolStripSeparator toolStripSeparator3;
		private ToolStripDropDownButton toolStripDropDownButtonColors;
		private ToolStripMenuItem toolStripMenuItemColorCellsAlive;
		private ToolStripMenuItem toolStripMenuItemColorCellsDead;
		private ToolStripSeparator toolStripSeparator6;
		private ToolStripMenuItem toolStripMenuItemSetCanvasThemeBlackAndWhite;
		private ToolStripMenuItem toolStripMenuItemSetCanvasThemeMatrix;
		private ToolStripMenuItem toolStripMenuItemSetCanvasThemeIcyWorld;
		private ToolStripMenuItem toolStripMenuItemSetCanvasThemeSolarized;
		private ToolStripButton toolStripButtonGridEnable;
		private MenuStrip menuStrip;
		private ToolStripMenuItem toolStripMenuItemFile;
		private ToolStripMenuItem toolStripMenuItemLoad;
		private ToolStripMenuItem toolStripMenuItemSave;
		private ToolStripSeparator toolStripSeparator7;
		private ToolStripMenuItem toolStripMenuItemExit;
		private ToolStripMenuItem toolsToolStripMenuItem;
		private ToolStripMenuItem toolStripMenuItemSetDefaultValues;
		private ToolStripMenuItem toolStripMenuItemColors;
		private ToolStripMenuItem toolStripMenuItemSetColorOfAliveCells;
		private ToolStripMenuItem toolStripMenuItemSetColorOfDeadCells;
		private ToolStripSeparator toolStripSeparator8;
	}
}
