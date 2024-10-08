namespace Pattern.FactoryMethod
{
    public class Gossiper : INPC
    {
        public void Speak()
        {
            UIManager.DisplayGossiperMessage("Gossiper: “Have you heard about the ruckus at the village fair? " +
                "It all started with Merrym setting up her bright blue stall right next to Craneak’s quaint little green one. " +
                "Craneak was furious, claiming the blue was too loud and would scare away people from his handcrafted wooden toys! " +
                "Merrym, equally indignant, argued that her colorful displays attracted attention to their stalls, not drove it away. " +
                "Just yesterday, they held a color showdown, with folks debating the merits of blue versus green as if it were a matter of life and death!”");
            ImageManager.DisplayGossiperImage();
        }
    }
}