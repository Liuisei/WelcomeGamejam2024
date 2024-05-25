using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class RankingScript : MonoBehaviour
{
    [SerializeField] Text _rankText;
    string                _rankString;
    private void Start()
    {
        RankToString();
    }
    public void RankToString()
    {
        Debug.Log(GameData.Instance.Rankings.Count);
        for (int i = 0;  i < GameData.Instance.Rankings.Count || i > 10       ; i++)
        {
            if (GameData.Instance.Rankings[i] != null)
            {
                _rankString    =  (i + "位" + GameData.Instance.Rankings[i].name + ":" + GameData.Instance.Rankings[i].score.ToString("000.00"));
                _rankText.text += _rankString + "\n";
            }
            else return;
        }
    }
}