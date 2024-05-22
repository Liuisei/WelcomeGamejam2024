using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnityEngine;

public class GameData : MonoBehaviour
{
    public static GameData Instance { get; private set; }
    protected void Awake()
    {
        Instance = this;
    }
    List<Ranking> rankings = new List<Ranking>(11);
    public List<Ranking> rankings_ { get { return rankings; } }

    float        _score;
    public float Score { get { return _score; } set { _score = value; } }

    void Start()
    {
        LoadRankings();
    }

    void OnDestroy()
    {
        SaveRankings();
    }

    void LoadRankings()
    {
        string json = PlayerPrefs.GetString("a");
        rankings = JsonUtility.FromJson<List<Ranking>>(json);
    }

    void SaveRankings()
    {
        string json = JsonUtility.ToJson(rankings);
        PlayerPrefs.SetString("a", json);
    }

    void SortRanking()
    {
        rankings.OrderBy(e => e.score);
    }
    private void AddRanking(float _score, string _name)
    {
        rankings[11].score = _score;
        rankings[11].name = _name;
        SortRanking();
    }
    
    
    
    
}
[Serializable]
public class Ranking
{
    public float score;
    public string name;
}
