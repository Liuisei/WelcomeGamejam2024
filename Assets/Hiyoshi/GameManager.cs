using UnityEngine;

public class GameManager : MonoBehaviour
{
    int _Hp;
    float _Speed;
    public int hp {  get { return _Hp; } }
    public float speed { get { return _Speed;} }

    void SetHp(int x)
    {
        _Hp += x;
    }
    void SetSpeed(float x)
    {
        _Speed += x;
    }
}
