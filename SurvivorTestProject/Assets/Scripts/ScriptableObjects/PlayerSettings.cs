using UnityEngine;

namespace ScriptableObjects
{
    [CreateAssetMenu(fileName = "player_settings", menuName = "ScriptableObjects/PlayerSettingsScriptableObject", order = 4)]
    public class PlayerSettings: ScriptableObject
    {
        public int HealthPointsCount;
    }
}