using System;


namespace Unit05.Game.Casting
{

    public class Score : Actor
    {
        private int points = 0;

        public Score(int xaxis, int yaxis)
        {
            SetPosition(new Point(xaxis,yaxis));
            AddPoints(0);
        }
        /// <summary>
        /// Adds the given points to the score.
        /// </summary>
        /// <param name="points">The points to add.</param>
        public void AddPoints(int points)
        {
            this.points += points;
            SetText($"Score: {this.points}");
        }
    }
}