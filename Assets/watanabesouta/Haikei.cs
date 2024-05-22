using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Haikei : MonoBehaviour
{
    [SerializeField] List<GameObject> _haikeiList = new List<GameObject>();
    [SerializeField] int _speed;
    [SerializeField] int _minLineY;
    [SerializeField] int _range;
    private void FixedUpdate()
    {

        for (int i = _haikeiList.Count - 1; i >= 0; i--)
        {
            if (i == 2)
            {
                _haikeiList[i].transform.position += new Vector3(0, _speed / -1000f);
            }
            else
            {
                _haikeiList[i].transform.position = new Vector3(_haikeiList[2].transform.position.x, _haikeiList[2].transform.position.y - _range * (_haikeiList.Count -1 -i));
                if (_haikeiList[i].transform.position.y < _minLineY)
                {
                    var a = _haikeiList[i];
                    _haikeiList.RemoveAt(i);
                    a.transform.position = new Vector3(_haikeiList[_haikeiList.Count - 1].transform.position.x, _haikeiList[_haikeiList.Count - 1].transform.position.y + _range);
                    _haikeiList.Add(a);
                }
            }

        }
    }
}
