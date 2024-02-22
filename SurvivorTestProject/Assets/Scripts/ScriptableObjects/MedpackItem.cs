using DefaultNamespace;
using ScriptableObjects.Core;
using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "medpack_item", menuName = "ScriptableObjects/MedpackItemScriptableObject", order = 2)]
    public class MedpackItem : Item
    {
        public int HealthPointsRestoreCount;
    }
}