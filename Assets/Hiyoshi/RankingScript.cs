using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingScript : MonoBehaviour
{
    [SerializeField] Text _rankText;
    string _rankString;
    public void RankToString()
    {
        if(GameData.Instance.rankings_ != null)
            _rankString = string.Join(",", GameData.Instance.rankings_);
    }
}
