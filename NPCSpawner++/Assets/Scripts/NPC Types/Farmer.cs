namespace Pattern.FactoryMethod
{
    public class Farmer : INPC
    {
        public void Speak()
        {
            UIManager.DisplayFarmerMessage("Farmer: You reap what you sow!");
            ImageManager.DisplayFarmerImage();
        }
    }
}