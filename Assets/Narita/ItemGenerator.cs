using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ItemGenerator : MonoBehaviour
{
    [SerializeField] List<GameObject> _prefubs = new List<GameObject>();
    [SerializeField] List<Transform> _transforms = new List<Transform>();
    [SerializeField] float spawnrange = 1f;



    void Spawn()
    {
       int randumint = Random.Range(0, _prefubs.Count);
        int randumtransforms = Random.Range(0, _transforms.Count);
        Instantiate(_prefubs[randumint], _transforms[randumtransforms]);
    }

    private void Start()
    {
        StartCoroutine(nameof(CoolTime));
    }
    IEnumerator CoolTime()
    {
        yield return new WaitForSeconds(spawnrange);
        CoolTime();
    }


}
