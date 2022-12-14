using Particle.Maui.Particles;
using SkiaSharp;

namespace Particle.Maui.Sample.Demo2
{
    public class GoogleLogoParticle : ParticleBase
    {
        private SKPaint _r = new SKPaint
        {
            Style = SKPaintStyle.Fill,
            Color = SKColor.Parse("#ea4335")
        };

        private SKPaint _g = new SKPaint
        {
            Style = SKPaintStyle.Fill,
            Color = SKColor.Parse("#34a853")
        };

        private SKPaint _b = new SKPaint
        {
            Style = SKPaintStyle.Fill,
            Color = SKColor.Parse("#4285f4")
        };

        private SKPaint _y = new SKPaint
        {
            Style = SKPaintStyle.Fill,
            Color = SKColor.Parse("#fbbc04")
        };

        public GoogleLogoParticle(SKPoint3 rotationSpeed, float translationSpeed, float direction, SKPoint3 orientation, SKPoint position, SKSize size) : base(rotationSpeed, translationSpeed, direction, orientation, position, size)
        {
        }

        protected override void Draw(SKCanvas canvas)
        {
            var transformationMatrix = SKMatrix.CreateTranslation(Position.X - 266.75f, Position.Y - 272.15f);
            var scale = Size.Width / 200.0f;
            transformationMatrix = transformationMatrix.PostConcat(SKMatrix.CreateScale(scale, scale, Position.X, Position.Y));

            var red = SKPath.ParseSvgPathData("M272.1 107.7c38.8-.6 76.3 14 104.4 40.8l77.7-77.7C405 24.6 339.7-.8 272.1 0 169.2 0 75.1 58 28.9 150l90.4 70.1c21.5-64.5 81.8-112.4 152.8-112.4z");
            red.Transform(transformationMatrix);
            
            var green = SKPath.ParseSvgPathData("M272.1 544.3c73.4 0 135.3-24.1 180.4-65.7l-87.7-68c-24.4 16.6-55.9 26-92.6 26-71 0-131.2-47.9-152.8-112.3H28.9v70.1c46.2 91.9 140.3 149.9 243.2 149.9z");
            green.Transform(transformationMatrix);
            
            var blue = SKPath.ParseSvgPathData("M533.5 278.4c0-18.5-1.5-37.1-4.7-55.3H272.1v104.8h147c-6.1 33.8-25.7 63.7-54.4 82.7v68h87.7c51.5-47.4 81.1-117.4 81.1-200.2z");
            blue.Transform(transformationMatrix);
            
            var yellow = SKPath.ParseSvgPathData("M119.3 324.3c-11.4-33.8-11.4-70.4 0-104.2V150H28.9c-38.6 76.9-38.6 167.5 0 244.4l90.4-70.1z");
            yellow.Transform(transformationMatrix);
            
            canvas.DrawPath(red, _r);
            canvas.DrawPath(green, _g);
            canvas.DrawPath(blue, _b);
            canvas.DrawPath(yellow, _y);
        }
    }
}