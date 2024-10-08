using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCFactory : MonoBehaviour
    {
        public INPC GetNPC(NPCType type)
        {
            switch (type)
            {
                case NPCType.Beggar:
                    INPC beggar = new Beggar();
                    return beggar;
                case NPCType.Farmer:
                    INPC farmer = new Farmer();
                    return farmer;
                case NPCType.Shopowner:
                    INPC shopowner = new Shopowner();
                    return shopowner;
                case NPCType.SketchyHerbDealer:
                    INPC sketchyherbdealer = new SketchyHerbDealer();
                    return sketchyherbdealer;
                case NPCType.Storyteller:
                    INPC storyteller = new Storyteller();
                    return storyteller;
                case NPCType.Herbalist:
                    INPC herbalist = new Herbalist();
                    return herbalist;
                case NPCType.Gossiper:
                    INPC gossiper = new Gossiper();
                    return gossiper;
            }
            return null;
        }
    }
}