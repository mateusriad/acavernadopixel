open System
open Microsoft.Xna.Framework
open Microsoft.Xna.Framework.Graphics
open Microsoft.Xna.Framework.Input
 
type Game1() as this =
    inherit Game()
    let graphics = new GraphicsDeviceManager(this)
 
    let mutable spriteBatch = null
    let mutable texture = null
 
    override Game.LoadContent() =
        spriteBatch <- new SpriteBatch(this.GraphicsDevice)
 
    override Game.Update gameTime =
        base.Update gameTime
 
    override Game.Draw gameTime =
        this.GraphicsDevice.Clear(Color.CornflowerBlue)
        base.Draw gameTime
 
let g = new Game1()
try g.Run()
finally g.Dispose()