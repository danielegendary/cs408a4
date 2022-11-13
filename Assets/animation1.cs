using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations.Rigging;

namespace DapperDino.Tutorials.AnimationRigging
{
public class animation1 : MonoBehaviour
{   
    [Header("References")]
    [SerializeField] Rig rig= null;
    [Header("Settings")]
    [SerializeField] private float pointspeed = 1f;
    private int targetValue;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            targetValue = targetValue == 0 ? 1 : 0;
        }
        rig.weight= Mathf.MoveTowards(rig.weight,targetValue, pointspeed* Time.deltaTime);
    }
}
}