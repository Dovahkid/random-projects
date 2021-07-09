using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class PongBall
    {
        public Texture2D texture { get; private set; }
        public Vector2 position;
        public Vector2 velocity;
        
        public float speed = 10f;

        public Rectangle CollisionBox
        {
            get
            {
                return new Rectangle((int)position.X, (int)position.Y, texture.Width, texture.Height);
            }
        }

        public PongBall(Texture2D texture)
        {
            this.texture = texture;

            velocity.Y = speed;
            velocity.X = speed;
        }

        public void Update()
        {
            position.Y -= velocity.Y;
            position.X -= velocity.X;

            if (position.Y < 0)
            {
                velocity.Y *= -1;
            }

            if (position.X > 800)
            {
                velocity.X *= -1;
            }

            if (position.X < 0)
            {
                velocity.X *= -1;
            }

            if (position.Y > 480)
            {
                velocity.Y *= -1;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }
    }
}
