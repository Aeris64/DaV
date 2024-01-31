using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Entity : MonoBehaviour
{
    #region Fields

    [SerializeField]
    protected List<Character> _team;
    public List<Character> Team
    {
        get
        {
            return this._team;
        }
        set
        {
            this._team = value;
        }
    }

    #endregion Fields

    #region Public methods
    public Spell Attack(int spellNumber, int characTurn)
    {
        Debug.Log($"HERE <<>< {characTurn}");
        // No attack TODO
        if(Team[characTurn].Spells.Length <= 0) return null;

        return _team[characTurn].Attack(spellNumber);
    }

    public void GetDamage(Spell spell)
    {
        for(int i = 0; i < spell.TargetEnemy.Length; i++)
        {
            if(Team[i].IsDead()) continue;

            Team[i].GetDamage(spell.Damage);
        }
    }

    public string IsInTeam(string character) { return ""; }

    #endregion Public methods

    #region Private methods

    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        
    }

    #endregion Private methods
}