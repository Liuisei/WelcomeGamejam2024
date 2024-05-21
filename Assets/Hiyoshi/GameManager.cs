using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }
    protected void Awake()
    {
        Instance = this;
    }
    int _Hp;
    float _Speed;
    public int hp {  get { return _Hp; } }
    public float speed { get { return _Speed;} }

    public void SetHp(int x)
    {
        _Hp += x;
    }
    public void SetSpeed(float x)
    {
        _Speed += x;
    }
}
