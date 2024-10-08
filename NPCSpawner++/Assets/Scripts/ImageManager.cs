using UnityEngine;
using UnityEngine.UI;

namespace Pattern.FactoryMethod
{
    public class ImageManager : MonoBehaviour
    {
        [SerializeField] private Image beggarImage;
        [SerializeField] private Image gossiperImage;
        [SerializeField] private Image sketchyHerbDealerImage;
        [SerializeField] private Image farmerImage;
        [SerializeField] private Image herbalistImage;
        [SerializeField] private Image shopownerImage;
        [SerializeField] private Image storytellerImage;

        private static ImageManager instance;

        private void Awake()
        {
            if (instance == null)
            {
                instance = this;
                SetImageTransparency(beggarImage, 0); // sets transparency to 0%
                SetImageTransparency(gossiperImage, 0);
                SetImageTransparency(sketchyHerbDealerImage, 0);
                SetImageTransparency(farmerImage, 0);
                SetImageTransparency(herbalistImage, 0);
                SetImageTransparency(shopownerImage, 0);
                SetImageTransparency(storytellerImage, 0);
            }
            else
            {
                Destroy(gameObject);
            }
        }

        private void SetImageTransparency(Image image, float alpha) // sets transparency to 100%
        {
            if (image != null)
            {
                Color color = image.color;
                color.a = alpha;
                image.color = color;
            }
        }


        public static void DisplayBeggarImage()
        {
            if (instance != null && instance.beggarImage != null)
            {
                instance.SetImageTransparency(instance.beggarImage, 1); // sets transparency to 100%
                instance.beggarImage.enabled = true; // enables image
            }
        }

        public static void DisplayGossiperImage()
        {
            if (instance != null && instance.gossiperImage != null)
            {
                instance.SetImageTransparency(instance.gossiperImage, 1);
                instance.gossiperImage.enabled = true;
            }
        }

        public static void DisplaySketchyHerbDealerImage()
        {
            if (instance != null && instance.sketchyHerbDealerImage != null)
            {
                instance.SetImageTransparency(instance.sketchyHerbDealerImage, 1);
                instance.sketchyHerbDealerImage.enabled = true;
            }
        }

        public static void DisplayFarmerImage()
        {
            if (instance != null && instance.farmerImage != null)
            {
                instance.SetImageTransparency(instance.farmerImage, 1);
                instance.farmerImage.enabled = true;
            }
        }

        public static void DisplayHerbalistImage()
        {
            if (instance != null && instance.herbalistImage != null)
            {
                instance.SetImageTransparency(instance.herbalistImage, 1);
                instance.herbalistImage.enabled = true;
            }
        }

        public static void DisplayShopownerImage()
        {
            if (instance != null && instance.shopownerImage != null)
            {
                instance.SetImageTransparency(instance.shopownerImage, 1);
                instance.shopownerImage.enabled = true;
            }
        }

        public static void DisplayStorytellerImage()
        {
            if (instance != null && instance.storytellerImage != null)
            {
                instance.SetImageTransparency(instance.storytellerImage, 1);
                instance.storytellerImage.enabled = true;
            }
        }
    }
}