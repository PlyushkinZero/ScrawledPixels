using System.Collections.Generic;
using System.Runtime.InteropServices;
using ScrawledPixels.OdinSerializer;
using UnityEngine;

namespace ScrawledPixels.BattleLogic.SpellCast
{
    [CreateAssetMenu(fileName = "New SpellData", menuName = "Spell", order = 51)]
    public class SpellData : ScriptableObject
    {
        [Range(1, 5)] [SerializeField] private int _castCount = 1;
        [SerializeField] private int _id;
        
        public string Name => _name;
        [SerializeField] private string _name;  
        
        public List<SpellAction> Actions => _actions;
        [SerializeField] private List<SpellAction> _actions;

        public string Key => _key;
        [SerializeField] private string _key;
        
        public bool IsAble => _isAble;
        [SerializeField] private bool _isAble;
    }
}
