using System;
using UnityEngine;

namespace ScriptableObjects.Core
{
    [Serializable]
    public abstract class Item : ScriptableObject
    {
        public string Name;
        public Sprite Sprite;
        public float Weight;
        public int MaxStackCount;
    }
}