using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IO_Tester : MonoBehaviour {

    [SerializeField]
    public Input input;
    public Output output;

	// Update is called once per frame
	void Update () {
        // double data = input.get();  // OUT OF DATE!
        //if(data < .5f){
        //    output.set('L');
        //}else{
        //    output.set('H');
        //}
	}
}
