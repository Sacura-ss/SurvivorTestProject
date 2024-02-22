using ScriptableObjects.Core;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace.UI
{
    public class InventoryEntity: MonoBehaviour
    {
        [SerializeField] private Image _itemImage;
        [SerializeField] private TMP_Text _itemInStackText;

        private Item _item;

        public void SetItem(Item item, int itemCount)
        {
            _itemImage.sprite = item.Sprite;
            _itemInStackText.text = itemCount == 1 ? "" : itemCount.ToString();
        }

        public void Clear()
        {
            _itemImage.sprite = null;
            _itemInStackText.text = "";
        }
    }
}