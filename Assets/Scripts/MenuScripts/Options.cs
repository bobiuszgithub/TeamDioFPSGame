using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{


    [SerializeField] private TMP_Dropdown resolutionDropDown;

    private Resolution[] resolutions;

    private List<Resolution> FilteredResolutionList;

    private float CurrentRefreshRate;
    private int currentResolutionIndex = 0;

    
    

    void Start()
    {
        
        resolutions = Screen.resolutions;
        FilteredResolutionList = new List<Resolution>();


        resolutionDropDown.ClearOptions();

        CurrentRefreshRate = Screen.currentResolution.refreshRate;



        for (int i = 0; i < resolutions.Length; i++)
        {
            if (resolutions[i].refreshRate == CurrentRefreshRate)
            {
                FilteredResolutionList.Add(resolutions[i]);
            }


        }


        List<string> options = new List<string>();
        for (int i = 0; i < FilteredResolutionList.Count; i++)
        {


            string resulotionOption = FilteredResolutionList[i].width + "x" + FilteredResolutionList[i].height + " " + FilteredResolutionList[i].refreshRate + "Hz";
            options.Add(resulotionOption);
            if (FilteredResolutionList[i].width == Screen.width && FilteredResolutionList[i].height == Screen.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropDown.AddOptions(options);
        resolutionDropDown.value = currentResolutionIndex;
        resolutionDropDown.RefreshShownValue();

       
    }

    public void SetResolution(int resolutionIndex)
    {
        Resolution resolution = FilteredResolutionList[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, true);
    }


    public void Update()
    {
       
    }

 


}
