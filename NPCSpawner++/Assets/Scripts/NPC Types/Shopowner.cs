namespace Pattern.FactoryMethod
{
    public class Shopowner : INPC
    {
        public void Speak()
        {
            UIManager.DisplayShopownerMessage("Shopowner: Do you wish to purchase something?");
            ImageManager.DisplayShopownerImage();
        }
    }
}