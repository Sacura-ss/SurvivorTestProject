using System;
using System.Collections.Generic;
using ScriptableObjects;
using ScriptableObjects.Core;
using UnityEngine;

namespace Gameplay
{
    public class Player : MonoBehaviour
    {
       
        
        // потом убрать [SerializeField], когда будут сохранения 
        [SerializeField] private List<PlayerItem> _items = new ();

        public List<PlayerItem> Items
        {
            get => _items;
            set => _items = value;
        }


        private int _currentHealthCount;
        [SerializeField] private PlayerAvatar _playerAvatar;
        [SerializeField] private PlayerSettings _playerSettings;

        private void Start()
        {
            // havent saving
            _currentHealthCount = _playerSettings.HealthPointsCount;
            
            // have savings
            // заполняем items
        }
    }
}