using UnityEngine;
using TMPro;

namespace Pattern.FactoryMethod
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private TMP_Text gossiperText;
        [SerializeField] private TMP_Text sketchyHerbDealerText;
        [SerializeField] private TMP_Text storytellerText;
        [SerializeField] private TMP_Text herbalistText;
        [SerializeField] private TMP_Text famerText;
        [SerializeField] private TMP_Text beggarText;
        [SerializeField] private TMP_Text shopownerText;
        [SerializeField] private TMP_Text showNPCText;

        private static UIManager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
            }
            else
            {
                Destroy(gameObject);
            }
        }

        public static void DisplayGossiperMessage(string message)
        {
            if (instance != null && instance.gossiperText != null)
            {
                instance.gossiperText.text = message;
            }
        }

        public static void DisplaySketchyHerbDealerMessage(string message)
        {
            if (instance != null && instance.sketchyHerbDealerText != null)
            {
                instance.sketchyHerbDealerText.text = message;
            }
        }

        public static void DisplayStorytellerMessage(string message)
        {
            if (instance != null && instance.storytellerText != null)
            {
                instance.storytellerText.text = message;
            }
        }

        public static void DisplayHerbalistMessage(string message)
        {
            if (instance != null && instance.herbalistText != null)
            {
                instance.herbalistText.text = message;
            }
        }

        public static void DisplayFarmerMessage(string message)
        {
            if (instance != null && instance.famerText != null)
            {
                instance.famerText.text = message;
            }
        }

        public static void DisplayBeggarMessage(string message)
        {
            if (instance != null && instance.beggarText != null)
            {
                instance.beggarText.text = message;
            }
        }

        public static void DisplayShopownerMessage(string message)
        {
            if (instance != null && instance.shopownerText != null)
            {
                instance.shopownerText.text = message;
            }
        }

        public static void DisplayShowNPCMessage(string message)
        {
            if (instance != null && instance.showNPCText != null)
            {
                instance.showNPCText.text = message;
            }
        }
    }
}