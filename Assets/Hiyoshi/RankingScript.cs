using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RankingScript : MonoBehaviour
{
    [SerializeField] Text _rankText;
    string _rankString;
    private void Start()
    {
        GameData.Instance.SaveRankings();
        RankToString();
    }
    public void RankToString()
    {
        _rankString = null;
        for (int i = 0; i < 10; i++)
        {
            if (GameData.Instance.rankings_[i] != null)
            {
                _rankString = (i + "ˆÊ" + GameData.Instance.rankings_[i].name + ":" + GameData.Instance.rankings_[i].score).ToString();
                _rankText.text += _rankString + "\n";
            }
            else return;
        }
    }
}
