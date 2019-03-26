using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace thisismedieval
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D rectangleBlock;
        GameConstant gameConstant;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

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
            gameConstant = new GameConstant(GraphicsDevice.Viewport.Width, GraphicsDevice.Viewport.Height);
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
            rectangleBlock = new Texture2D(GraphicsDevice, 1, 1);
            Microsoft.Xna.Framework.Color xnaColorBorder = new Microsoft.Xna.Framework.Color(128, 128, 128); // default color gray 
            rectangleBlock.SetData(new[] { xnaColorBorder });
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
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            DrawMainMenu();

            base.Draw(gameTime);
        }

        protected void DrawMainMenu()
        {
            float wel =(float) 0.25*(3 + 5 * Menu.NumButtonElemMenu);
            int widthElem = (int)(gameConstant.ScreenWidth / wel);
            int heightEelem = (int)(0.5 * widthElem);
            int xMargin = (int) widthElem / 2;
            int yMargin =(int) (gameConstant.ScreenHeight - 1.5*heightEelem) ;
            int step = (int) widthElem + widthElem / 4;

            for (int i = 0; i < Menu.NumButtonElemMenu; i++)
            {
                Menu.buttonElem(rectangleBlock, spriteBatch, step * i + xMargin, yMargin, widthElem, heightEelem);
            }
        }

    }
}
