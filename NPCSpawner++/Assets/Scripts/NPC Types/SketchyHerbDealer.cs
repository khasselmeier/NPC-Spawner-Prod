namespace Pattern.FactoryMethod
{
    public class SketchyHerbDealer : INPC
    {
        public void Speak()
        {
            UIManager.DisplaySketchyHerbDealerMessage("Sketchy Herb Dealer: “Listen, friend. You want the stuff they don’t sell at any other stall? " +
                "The real deal, cuts through the noise, if you know what I mean... This here is not your average run-of-the-mill herb. " +
                "One dose, and you’ll feel your world lighten up.”");
            ImageManager.DisplaySketchyHerbDealerImage();
        }
    }
}