using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Output : MonoBehaviour {
    public double dCircle = 1;
    public double dCross = 0;

    private Text output;

    private void Awake(){
        output = gameObject.GetComponentInChildren<Text>();
        set(dCircle, dCross);
    }

    public void set(double circle, double cross)
    {
        output.text = "Circle:\n" + circle.ToString() + "\n\n Cross:\n" + cross.ToString();
    }
}
