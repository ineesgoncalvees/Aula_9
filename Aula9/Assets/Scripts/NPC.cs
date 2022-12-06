using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    private IAnimateBeahviour beahviour;

    private void Awake()
    {
        beahviour = GetComponent<IAnimateBeahviour>();
    }

    // Update is called once per frame
    void Update()
    {
        beahviour?.Animate();
    }
}
