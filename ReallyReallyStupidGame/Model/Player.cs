using System;

namespace ReallyReallyStupidGame.Model
{
	public class Player
	{
		private int score;
		private bool active;

		// Animation representing the player
		public Texture2D PlayerTexture;

		// Position of the Player relative to the upper left side of the screen
		public Vector2 Position;

		// State of the player
		public bool Active;
		{

		}

		// Amount of hit points that player has
		public int Health;

		// Get the width of the player ship
		public int Width
		{
			get { return PlayerTexture.Width; }
		}

		// Get the height of the player ship
		public int Height
		{
			get { return PlayerTexture.Height; }
		}

		public void Initialize
		{
			get { return score; }
			set { score = value; }
		}

		public void Update()
		{
			
		}

		public void Draw()
		{

		}

	}
}

