namespace Pattern.FactoryMethod
{
    public class Herbalist : INPC
    {
        public void Speak()
        {
            UIManager.DisplayHerbalistMessage("Herbalist: “Step right up, my friend! As a dedicated herbalist, " +
                "I offer you remedies crafted with care straight from my garden. " +
                "Let’s start with my sapphire sage, a powerful herb known for its efficacy in alleviating headaches. " +
                "A pinch in your tea, and you’ll experience relief in no time!”");
            ImageManager.DisplayHerbalistImage();
        }
    }
}