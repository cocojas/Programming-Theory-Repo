using UnityEngine;
using UnityEngine.UIElements;

public class PopUpUI : MonoBehaviour
{
    private VisualElement popUp;
    private Label popUpUILabel;

    [SerializeField] private float popUpSeconds = 2f;
    [SerializeField] private float fadeOutSeconds = 1.8f;
    private float popUpTimer = 0f;
    private float fadeOutTimer = 0f;
    private bool shouldFadeOut = false;

    private void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        popUp = root.Q<VisualElement>("popup-ui");
        popUp.style.display = DisplayStyle.None;

        popUpUILabel = root.Q<Label>("popup-ui-label");
        popUpUILabel.text = "";
    }

    private void Update()
    {
        if (popUp.style.display == DisplayStyle.Flex && shouldFadeOut)
        {
            fadeOutTimer += Time.deltaTime;
            if (fadeOutTimer <= fadeOutSeconds)
            {
                float opacity = 1 - (fadeOutTimer / fadeOutSeconds);
                if (opacity <= 0)
                {
                    popUp.style.display = DisplayStyle.None;
                    popUp.style.opacity = 1f;
                    shouldFadeOut = false;
                    fadeOutTimer = 0f;
                }
                else
                {
                    popUp.style.opacity = opacity;
                }
            }
            else
            {
                popUp.style.display = DisplayStyle.None;
                popUp.style.opacity = 1f;
                shouldFadeOut = false;
                fadeOutTimer = 0f;
            }
        }
        else if (popUp.style.display == DisplayStyle.Flex)
        {
            popUpTimer += Time.deltaTime;
            if (popUpTimer >= popUpSeconds)
            {
                HidePopUp();
            }
        }
    }

    public void HidePopUp()
    {
        shouldFadeOut = true;
        popUpTimer = 0f;
    }

    public void ShowPopUp(string text)
    {
        popUpUILabel.text = text;
        popUp.style.display = DisplayStyle.Flex;
        popUp.style.opacity = 1f;
        popUpTimer = 0f;
        fadeOutTimer = 0f;
        shouldFadeOut = false;
    }

    private void FadeOutPopUp()
    {
    
        popUp.style.opacity = 0f;
    }

    public void Onable()
    {
        popUp.style.display = DisplayStyle.None;       
    }

    public void Osable()
    {
        popUp.style.display = DisplayStyle.None;      
    }
}
