using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[DefaultExecutionOrder(-10)]
public class GameData : BaseSingleton<GameData>
{
    protected override void     AwakeFunction() {  }

    List<Ranking> _rankings = new List<Ranking>();
    public List<Ranking> rankings_ { get { return _rankings; } }

    public void Start()
    {
        LoadRankings();
    }

    public void OnDestroy()
    {
        SaveRankings();
    }

    public void LoadRankings()
    {
        string json = PlayerPrefs.GetString("a");
        _rankings = JsonUtility.FromJson<List<Ranking>>(json);
    }

    public void SaveRankings()
    {
        string json = JsonUtility.ToJson(_rankings);
        PlayerPrefs.SetString("a", json);
    }
    public void Clear()
    {
        _rankings = new List<Ranking>();
        string json = JsonUtility.ToJson(_rankings);
        PlayerPrefs.SetString("a", json);
    }

    public void SortRanking()
    {
        _rankings.OrderBy(e => e.score);
    }
    public void AddRanking(float _score, string _name)
    {
        var ranking = new Ranking();
        ranking.score = _score;
        ranking.name = _name;
        _rankings.Add(ranking);
        SortRanking();
    }

}
[Serializable]
public class Ranking
{
    public float score;
    public string name;
}
