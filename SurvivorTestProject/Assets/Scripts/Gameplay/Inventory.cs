using System;
using System.Collections.Generic;
using DefaultNamespace.UI;
using ScriptableObjects;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private Player _inventoryOwner;
        [SerializeField] private InventorySettings _inventorySettings;
        [SerializeField] private GridLayoutGroup _inventoryGridLayout;

        private List<InventoryEntity> _inventoryEntities = new();

        private void Awake()
        {
            CreateInventory();
            AddItems();
        }

        private void AddItems()
        {
            var items = _inventoryOwner.Items;
            int i = 0;
            foreach (var item in items)
            {
                _inventoryEntities[i].SetItem(item.Item, item.Count);
                i++;
            }
        }

        private void CreateInventory()
        {
            _inventoryGridLayout.constraint = GridLayoutGroup.Constraint.FixedColumnCount;
            _inventoryGridLayout.constraintCount = _inventorySettings.ColumnCount;
            for(var i = 0; i < _inventorySettings.EntityCount; i++)
            {
                var inventoryEntity = Instantiate(_inventorySettings.InventoryEntity, _inventoryGridLayout.transform);
                _inventoryEntities.Add(inventoryEntity);
            }
        }
    }
}