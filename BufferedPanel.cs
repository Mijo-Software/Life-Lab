namespace LifeLab
{
	/// <summary>
	/// 
	/// </summary>
	public class BufferedPanel : Panel
	{
		/// <summary>
		/// 
		/// </summary>
		public BufferedPanel()
		{
			DoubleBuffered = true;
			SetStyle(flag: ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.OptimizedDoubleBuffer, value: true);
			UpdateStyles();
		}
	}
}