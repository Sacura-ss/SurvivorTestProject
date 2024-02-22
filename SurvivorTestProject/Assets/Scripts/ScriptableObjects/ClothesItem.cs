using DefaultNamespace;
using ScriptableObjects.Core;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "clothes_item", menuName = "ScriptableObjects/ClothesItemScriptableObject", order = 1)]
    public class ClothesItem: Item
    {
        public ClothesItemType Type;
        public int Protection;
    }
}