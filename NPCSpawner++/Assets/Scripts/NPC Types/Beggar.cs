namespace Pattern.FactoryMethod
{
    public class Beggar : INPC
    {
        public void Speak()
        {
            UIManager.DisplayBeggarMessage("Beggar: Do you have some change to spare?");
            ImageManager.DisplayBeggarImage();
        }
    }
}