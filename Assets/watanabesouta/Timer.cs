using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    // Start is called before the first frame update
    [SerializeField] Text _text;
    float _timer = 0;
    bool _isRunning = false;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_isRunning == true)
        {
            _timer += Time.deltaTime;
        }
        _text.text = _timer.ToString();

    }
    public void StartTimer()
    {
        _isRunning =! _isRunning;
    }
}
