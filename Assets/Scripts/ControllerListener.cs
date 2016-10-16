using UnityEngine;
using System.Collections;

public class ControllerListener : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        Debug.ClearDeveloperConsole(); 
         
        KeyCode[] keys = new KeyCode[]
            {
                KeyCode.Joystick1Button0, KeyCode.Joystick1Button1, KeyCode.Joystick1Button2,
                KeyCode.Joystick1Button3, KeyCode.Joystick1Button4, KeyCode.Joystick1Button5,
                KeyCode.Joystick1Button6, KeyCode.Joystick1Button7, KeyCode.Joystick1Button8,
                KeyCode.Joystick1Button9,
                KeyCode.Joystick1Button10, KeyCode.Joystick1Button11, KeyCode.Joystick1Button12,
                KeyCode.Joystick1Button13, KeyCode.Joystick1Button14, KeyCode.Joystick1Button15,
                KeyCode.Joystick1Button16, KeyCode.Joystick1Button17, KeyCode.Joystick1Button18,
                KeyCode.Joystick1Button19,
            }; 
       
        foreach (KeyCode key in keys )
        {
            if (Input.GetKeyDown(key))
                Debug.Log("Key:"  + key.ToString()); 
        }

        string[] axii = new string[]
        {
            "DPad_XAxis_1",
            "DPad_YAxis_1",
            "Triggers_1",
            "R_YAxis_1" ,
            "R_XAxis_1" ,
            "L_YAxis_1" ,
            "L_XAxis_1" ,
        }; 


        foreach ( string axis in axii )
        {
            float f = Input.GetAxisRaw(axis);
            if ( Mathf.Abs(f) > 0.1 )
            Debug.Log( "Trigger" + axis + ":" + f.ToString() ); 
        }

        string[] buttons = new string[]
        {
            "Start",
            "A_1",
            //"B",
            //"X"
        }; 

        foreach ( string button in buttons )
        {
            if ( Input.GetButton(button))
            {
                Debug.Log("Button:" + button); 
            }
        }
	}
}
