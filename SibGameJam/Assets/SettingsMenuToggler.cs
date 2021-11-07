using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenuToggler : MonoBehaviour
{
    [SerializeField] private GameObject settings;
    [SerializeField] private Button playButton;
    
    public void ToggleSettings()
    {
        settings.SetActive(!settings.activeSelf);
    }

    public void TurnOffPlayButton()
    {
        playButton.interactable = !playButton.interactable;
    }
}
