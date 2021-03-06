using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace Pong
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player player1;
        Player player2;

        PongBall ball;
        
        private int _windowHeight = 480;
        private int _windowWidth = 800;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            
            //_windowHeight = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Height;
            //_windowWidth = GraphicsAdapter.DefaultAdapter.CurrentDisplayMode.Width;
            
            //graphics.ToggleFullScreen();
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);

            player1 = new Player(Content.Load<Texture2D>("paddle"))
            {
                Input = new Input
                {
                    Up = Keys.W,
                    Down = Keys.S
                }
            };

            player2 = new Player(Content.Load<Texture2D>("paddle"))
            {
                Input = new Input
                {
                    Up = Keys.Up,
                    Down = Keys.Down
                }
            };
            
            ball = new PongBall(Content.Load<Texture2D>("pongBall"));

            ball.position = new Vector2(_windowWidth / 2, _windowHeight / 2);
            player1.position = new Vector2(0, 0);
            player2.position = new Vector2(_windowWidth - 10, 0);

            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {

            ball.Update();
            player1.Update();
            player2.Update();
            
            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            
            ball.Draw(spriteBatch);
            player1.Draw(spriteBatch);
            player2.Draw(spriteBatch);

            spriteBatch.End();

            // TODO: Add your drawing code here

            base.Draw(gameTime);
        }
    }
}
