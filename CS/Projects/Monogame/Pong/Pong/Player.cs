using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Pong
{
    class Player
    {
        public Texture2D texture { get; private set; }
        public Vector2 position;

        public Input Input;

        public int speed = 5;

        public Player(Texture2D texture)
        {
            this.texture = texture;
        }

        public void Update()
        {
            Move();
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(texture, position, Color.White);
        }

        public void Move()
        {
            if (Input == null)
                return;

            if (Keyboard.GetState().IsKeyDown(Input.Up))
            {
                //up
                position.Y -= speed;

                if (position.Y < 0)
                {
                    position.Y += speed;
                }

            }

            if (Keyboard.GetState().IsKeyDown(Input.Down))
            {
                //down
                position.Y += speed;

                if (position.Y > 430)
                {
                    position.Y -= speed;
                }
            }
        }
    }
}
