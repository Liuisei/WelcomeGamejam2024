using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

[DefaultExecutionOrder(-10)]
public class GameManager : MonoBehaviour
{
    [SerializeField] int                   _speed;

    [SerializeField] Text  _timerText;
    [SerializeField] bool  _isRunning;
    [SerializeField] float _timer;
    [SerializeField] int   _maxSpeed;
    [SerializeField] int   _minSpeed;


    public int MaxSpeed { get { return _maxSpeed; } set { _maxSpeed = value; } }

    public int   Speed
    {
        get { return _speed; }
        set
        {
            if (value      < _minSpeed) { value = _minSpeed; }
            else if (value > _maxSpeed) { value = _maxSpeed; }

            _speed     = value;
        }
    }

    public bool  IsRunning { get { return _isRunning; } set { _isRunning = value; } }
    public float Timer     { get { return _timer; }     set { _timer     = value; } }
    void         Awake()   { Instance = this; }

    void                         Start()
    {
        Debug.Log("Start");
        StartRun();
    }
    public static    GameManager Instance { get; private set; }


    public void AddSpeed(int x) { Speed += x; }

    void Update()
    {
        if (_isRunning == true) { _timer += Time.deltaTime; }

        _timerText.text = _timer.ToString("000.00");
    }
    public void StartTimer() { _isRunning = true; }
    public void StopTimer()  { _isRunning = false; }

    public void StartRun() { StartTimer(); }
    public void GoelRun()  { StopTimer(); }

    public void Gole()
    {
        Debug.Log("Gole");
        DataManager.Instance.Time = _timer;
        SceneManager.LoadScene(2);
    }
}