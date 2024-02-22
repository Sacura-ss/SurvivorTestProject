using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class PlayerAvatar : MonoBehaviour
    {
        [SerializeField] private Image _torsoImage;
        [SerializeField] private Image _headImage;
        
        public void SetTorsoImage(Sprite torsoSprite)
        {
            _torsoImage.sprite = torsoSprite;
        }

        public void SetHeadImage(Sprite headSprite)
        {
            _headImage.sprite = headSprite;
        }
    }
}