using UnityEngine;

namespace Pattern.FactoryMethod
{
    public class NPCSpawner : MonoBehaviour
    {
        public NPCFactory m_Factory;

        private INPC m_Farmer;
        private INPC m_Beggar;
        private INPC m_Shopowner;
        private INPC m_SketchyHerbDealer;
        private INPC m_Storyteller;
        private INPC m_Herbalist;
        private INPC m_Gossiper;

        public void SpawnVillagers()
        {
            /** 
            We don't want to specify the class to instiate for each type of villager.
            Instead, we ask the factory to "manufacture" it for us.
            **/

            m_Beggar = m_Factory.GetNPC(NPCType.Beggar);
            m_Farmer = m_Factory.GetNPC(NPCType.Farmer);
            m_Shopowner = m_Factory.GetNPC(NPCType.Shopowner);
            m_SketchyHerbDealer = m_Factory.GetNPC(NPCType.SketchyHerbDealer);
            m_Storyteller = m_Factory.GetNPC(NPCType.Storyteller);
            m_Herbalist = m_Factory.GetNPC(NPCType.Herbalist);
            m_Gossiper = m_Factory.GetNPC(NPCType.Gossiper);

            m_Beggar.Speak();
            m_Farmer.Speak();
            m_Shopowner.Speak();
            m_SketchyHerbDealer.Speak();
            m_Storyteller.Speak();
            m_Herbalist.Speak();
            m_Gossiper.Speak();
        }
    }
}