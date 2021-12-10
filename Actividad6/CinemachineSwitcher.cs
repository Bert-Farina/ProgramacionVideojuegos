using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Cinemachine;

public class CinemachineSwitcher : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera vcam1; //RogueCam
    [SerializeField]
    private CinemachineVirtualCamera vcam2; //WizardCam
    [SerializeField]
    private CinemachineVirtualCamera vcam3; //GroupCam

    //Booleans for Cams
    private bool rogueCamera = true;
    private bool wizardCamera = false;
    private bool groupCamera = false;

    // Start is called before the first frame updat
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(rogueCamera && Input.GetKeyDown(KeyCode.Space))
        {
            vcam1.Priority = 0;
            vcam2.Priority = 1;
            wizardCamera = true;
            rogueCamera = false;
        }
        else if (wizardCamera && Input.GetKeyDown(KeyCode.Space))
        {
            vcam2.Priority = 0;
            vcam3.Priority = 1;
            wizardCamera = false;
            groupCamera = true;
        }
        else if (groupCamera && Input.GetKeyDown(KeyCode.Space))
        {
            vcam3.Priority = 0;
            vcam1.Priority = 1;
            groupCamera = false;
            rogueCamera = true;
        }
    }
}
