using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    Damageable damage;
    Transform rootObject;
    UnityEngine.UI.Slider hSlider;
    // Start is called before the first frame update
    void Start()
    {
        rootObject = gameObject.transform.root;
        damage = rootObject.gameObject.GetComponent<Damageable>();
        hSlider = GetComponent<UnityEngine.UI.Slider>();
        hSlider.value = damage.Health;
    }

    // Update is called once per frame
    void Update()
    {
        hSlider.value = damage.Health;
    }
}
