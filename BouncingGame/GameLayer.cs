using System;
using System.Collections.Generic;
using CocosSharp;
namespace BouncingGame{
	public class GameLayer : CCLayerColor
	{
		public GameLayer() : base (CCColor4B.Black)
		{
		}

		void RunGameLogic(float frameTimeInSeconds)
		{
		}

		protected override void AddedToScene()
		{
		}

		void OnTouchesEnded(List<CCTouch> touches, CCEvent touchEvent)
		{
		}

		void HandleTouchesMoved(List<CCTouch> touches, CCEvent touchEvent)
		{
		}
	}
}
