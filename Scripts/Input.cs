using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Input : MonoBehaviour {
    [Header("ID")]
    [SerializeField]
    public int id = 00;

    [Header("Colors")]
    [SerializeField]
    public Color OnColor;
    public Color OffColor;

    private bool state = false;
    private Image output;

    private void Awake(){
        output = gameObject.GetComponent<Image>();
        setColor();
    }

    public void button(){
        state = !state;
        setColor();
    }

    private void setColor(){
        if (state){
            output.color = OnColor;
        }else{
            output.color = OffColor;
        }
    }

    public double get(){
        if (state){
            return 1d;
        }
        return 0d;
    }
}
