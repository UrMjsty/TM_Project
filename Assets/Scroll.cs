using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(RectTransform))]

public class Scroll : MonoBehaviour
{
    
    private float _speed = 100f;
    private RectTransform _myTransform;
    [SerializeField] private Text text;
    // Start is called before the first frame update
    void Start()
    {
        _myTransform = gameObject.GetComponent<RectTransform>();
        StartCoroutine(Wait(2));
    }

    // Update is called once per frame
    void Update()
    {
    }

    IEnumerator Wait(int sec)
    {
        yield return new WaitForSeconds(sec);
        StartCoroutine(AutoScroll());

    }
    IEnumerator AutoScroll()
    {
        while (_myTransform.localPosition.y < 1000)
        {
            _myTransform.Translate(Vector3.up * (_speed * Time.deltaTime));
            yield return null;

        }

    }
}
