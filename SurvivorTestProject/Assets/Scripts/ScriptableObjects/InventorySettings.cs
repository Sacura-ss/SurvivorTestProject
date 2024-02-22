using DefaultNamespace.UI;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "inventory_settings", menuName = "ScriptableObjects/InventorySettingsScriptableObject", order = 5)]
    public class InventorySettings : ScriptableObject
    {
        public int ColumnCount;
        public int EntityCount;
        public InventoryEntity InventoryEntity;
    }
}