using Microsoft.VisualBasic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;

namespace Monogamw_1___Adding_Content
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        Texture2D dinoTexture;
        Texture2D dougTexture;
        Texture2D spaceTexture;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here
            _graphics.PreferredBackBufferWidth = 1100;
            _graphics.PreferredBackBufferHeight = 800;
            _graphics.ApplyChanges();

            this.Window.Title = "Monogame is the BEST";

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);


            // TODO: use this.Content to load your game content here

            dinoTexture = Content.Load<Texture2D>("dino");
            dougTexture = Content.Load<Texture2D>("doug");
            spaceTexture = Content.Load<Texture2D>("SpaceBackground");
            


        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            else if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Enter))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.DarkOrange);

            // TODO: Add your drawing code here

            _spriteBatch.Begin();
            _spriteBatch.Draw(spaceTexture, new Vector2(15, 0), Color.White);
            _spriteBatch.Draw(dinoTexture, new Vector2(15,0), Color.White);
            _spriteBatch.Draw(dougTexture, new Vector2(608, 250), Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}