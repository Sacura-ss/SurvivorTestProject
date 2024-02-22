using DefaultNamespace;
using ScriptableObjects.Core;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "ammunition_item", menuName = "ScriptableObjects/AmmunitionItemScriptableObject", order = 3)]
    public class АmmunitionItem : Item
    {
        public int DMG;
        public int CostPerAction;
    }
}