namespace LifeLab
{
	public partial class MainForm : Form
	{
		private int gridSize = 20;
		private int generation = 0;
		private bool[,] cells;
		private int cellSize = 5; // Größe einer Zelle in Pixeln
		private Color aliveColor = Color.Black;
		private Color deadColor = Color.White;

		public MainForm()
		{
			InitializeComponent();
			typeof(Panel).GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic)
				?.SetValue(panelCanvas, true, null);
			InitializeGame();
		}

		private void InitializeGame()
		{

			cells = new bool[gridSize, gridSize];

			// Timer für die Spielschleife
			UpdateTimer(); // Geschwindigkeit des Spiels
			timer.Tick += Timer_Tick;

			UpdateCellSize();

			UpdateCanvas();

			// Zeichne das Gitter initial
			panelCanvas.Paint += PanelCanvas_Paint;
			panelCanvas.MouseClick += PanelCanvas_MouseClick;

			UpdatePanelSize();
		}

		private void UpdatePanelSize()
		{
			panelCanvas.AutoScrollMinSize = new Size(gridSize * cellSize, gridSize * cellSize);
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			//toolStripStatusLabel.Text = "";
			generation++;
			toolStripStatusLabelGenerationStat.Text = $"generation: {generation}";
			UpdateGame();
			panelCanvas.Invalidate();
		}

		private void UpdateTimer()
		{
			timer.Interval = (int)numericUpDownSpeed.Value;
		}

		private void UpdateCellSize()
		{
			cellSize = (int)numericUpDownCellSize.Value;

			panelCanvas.Width = gridSize * cellSize;
			panelCanvas.Height = gridSize * cellSize;

			UpdatePanelSize();
			panelCanvas.Invalidate();
		}

		private void UpdateCanvas()
		{
			gridSize = (int)numericUpDownGridSize.Value;
			cells = new bool[gridSize, gridSize];

			UpdatePanelSize();

			panelCanvas.Invalidate();
		}


		private void UpdateGame()
		{
			bool[,] newCells = new bool[gridSize, gridSize];

			for (int x = 0; x < gridSize; x++)
			{
				for (int y = 0; y < gridSize; y++)
				{
					int aliveNeighbors = CountAliveNeighbors(x, y);
					newCells[x, y] = cells[x, y] ? aliveNeighbors == 2 || aliveNeighbors == 3 : aliveNeighbors == 3;
				}
			}

			cells = newCells;
		}

		private int CountAliveNeighbors(int x, int y)
		{
			int count = 0;
			for (int i = -1; i <= 1; i++)
			{
				for (int j = -1; j <= 1; j++)
				{
					if (i == 0 && j == 0)
					{
						continue;
					}

					int nx = x + i;
					int ny = y + j;
					if (nx >= 0 && ny >= 0 && nx < gridSize && ny < gridSize && cells[nx, ny])
					{
						count++;
					}
				}
			}
			return count;
		}

		private void PanelCanvas_Paint(object sender, PaintEventArgs e)
		{
			//int cellSize = panelCanvas.Width / gridSize;
			e.Graphics.TranslateTransform(panelCanvas.AutoScrollPosition.X, panelCanvas.AutoScrollPosition.Y);
			for (int x = 0; x < gridSize; x++)
			{
				for (int y = 0; y < gridSize; y++)
				{
					Rectangle cellRect = new(x * cellSize, y * cellSize, cellSize, cellSize);
					e.Graphics.FillRectangle(brush: cells[x, y] ? new SolidBrush(color: aliveColor) : new SolidBrush(color: deadColor), rect: cellRect);
					if (toolStripButtonGridEnable.Checked)
					{
						e.Graphics.DrawRectangle(pen: Pens.Gray, rect: cellRect);
					}
				}
			}
		}

		private void PanelCanvas_MouseClick(object sender, MouseEventArgs e)
		{
			int x = (e.X - panelCanvas.AutoScrollPosition.X) / cellSize;
			int y = (e.Y - panelCanvas.AutoScrollPosition.Y) / cellSize;
			if (x >= 0 && y >= 0 && x < gridSize && y < gridSize)
			{
				cells[x, y] = !cells[x, y];
				panelCanvas.Invalidate();
			}
		}

		private void ButtonStart_Click(object sender, EventArgs e)
		{
			toolStripButtonStart.Enabled = false;
			toolStripButtonStop.Enabled = true;
			timer.Start();
		}

		private void ButtonStop_Click(object sender, EventArgs e)
		{
			toolStripButtonStart.Enabled = true;
			toolStripButtonStop.Enabled = false;
			timer.Stop();
		}

		private void ButtonReset_Click(object sender, EventArgs e)
		{
			timer.Stop();
			generation = 0;
			cells = new bool[gridSize, gridSize];
			panelCanvas.Invalidate();
			toolStripButtonStart.Enabled = true;
			toolStripButtonStop.Enabled = false;
		}

		private void ButtonRandomPattern_Click(object sender, EventArgs e)
		{
			Random random = new();
			for (int x = 0; x < gridSize; x++)
			{
				for (int y = 0; y < gridSize; y++)
				{
					cells[x, y] = random.Next(maxValue: 2) == 0;
				}
			}
			panelCanvas.Invalidate();
		}

		private void ButtonSave_Click(object sender, EventArgs e)
		{
			using SaveFileDialog sfd = new();
			sfd.Filter = "Text Files|*.txt";
			if (sfd.ShowDialog() == DialogResult.OK)
			{
				using StreamWriter writer = new(path: sfd.FileName);
				writer.WriteLine(value: gridSize);
				for (int x = 0; x < gridSize; x++)
				{
					for (int y = 0; y < gridSize; y++)
					{
						writer.Write(cells[x, y] ? "1" : "0");
					}
					writer.WriteLine();
				}
			}
		}

		private void ButtonLoad_Click(object sender, EventArgs e)
		{
			using OpenFileDialog ofd = new();
			ofd.Filter = "Text Files|*.txt";
			if (ofd.ShowDialog() == DialogResult.OK)
			{
				using StreamReader reader = new(path: ofd.FileName);
				gridSize = int.Parse(s: reader.ReadLine());
				cells = new bool[gridSize, gridSize];
				numericUpDownGridSize.Value = gridSize;
				for (int x = 0; x < gridSize; x++)
				{
					string line = reader.ReadLine();
					for (int y = 0; y < gridSize; y++)
					{
						cells[x, y] = line[y] == '1';
					}
				}
				panelCanvas.Invalidate();
			}
		}

		private void NumericUpDownSpeed_ValueChanged(object sender, EventArgs e)
		{
			UpdateTimer();
		}

		private void NumericUpDownCellSize_ValueChanged(object sender, EventArgs e)
		{
			UpdateCellSize();
		}

		private void NumericUpDownGridSize_ValueChanged(object sender, EventArgs e)
		{
			UpdateCanvas();
		}

		private void ClearAllCanvasThemesAsMenuEntries()
		{
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Checked = false;
			toolStripMenuItemSetCanvasThemeMatrix.Checked = false;
			toolStripMenuItemSetCanvasThemeIcyWorld.Checked = false;
			toolStripMenuItemSetCanvasThemeSolarized.Checked = false;
		}

		private void ButtonAliveColor_Click(object sender, EventArgs e)
		{
			using ColorDialog colorDialog = new();
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				ClearAllCanvasThemesAsMenuEntries();
				aliveColor = colorDialog.Color;
				panelCanvas.Invalidate();
			}
		}

		private void ButtonDeadColor_Click(object sender, EventArgs e)
		{
			using ColorDialog colorDialog = new();
			if (colorDialog.ShowDialog() == DialogResult.OK)
			{
				ClearAllCanvasThemesAsMenuEntries();
				deadColor = colorDialog.Color;
				panelCanvas.Invalidate();
			}
		}

		private void ApplyCanvasTheme(Color alive, Color dead)
		{
			aliveColor = alive;
			deadColor = dead;
			panelCanvas.Invalidate();
		}

		private void ButtonSetCanvasThemeBlackAndWhite_Click(object sender, EventArgs e)
		{
			toolStripMenuItemSetCanvasThemeMatrix.Checked = false;
			toolStripMenuItemSetCanvasThemeIcyWorld.Checked = false;
			toolStripMenuItemSetCanvasThemeSolarized.Checked = false;
			ApplyCanvasTheme(alive: Color.Black, dead: Color.White);
		}

		private void ButtonSetCanvasThemeMatrix_Click(object sender, EventArgs e)
		{
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Checked = false;
			toolStripMenuItemSetCanvasThemeIcyWorld.Checked = false;
			toolStripMenuItemSetCanvasThemeSolarized.Checked = false;
			ApplyCanvasTheme(alive: Color.Chartreuse, dead: Color.Black);
		}

		private void ButtonSetCanvasThemeIcyWorld_ButtonSetCanvasTheme(object sender, EventArgs e)
		{
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Checked = false;
			toolStripMenuItemSetCanvasThemeMatrix.Checked = false;
			toolStripMenuItemSetCanvasThemeSolarized.Checked = false;
			ApplyCanvasTheme(alive: Color.SkyBlue, dead: Color.SteelBlue);
		}

		private void ButtonSetCanvasThemeSolarized_Click(object sender, EventArgs e)
		{
			toolStripMenuItemSetCanvasThemeBlackAndWhite.Checked = false;
			toolStripMenuItemSetCanvasThemeMatrix.Checked = false;
			toolStripMenuItemSetCanvasThemeIcyWorld.Checked = false;
			ApplyCanvasTheme(alive: Color.Cornsilk, dead: Color.SlateGray);
		}

		private void ButtonExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void ButtonEnableGrid_Click(object sender, EventArgs e)
		{
			panelCanvas.Invalidate();
		}
	}
}
