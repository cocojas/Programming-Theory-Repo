using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class TitleScreenUI : MonoBehaviour
{
    [SerializeField] private VisualElement titleScreen;

    private void Awake()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;
        titleScreen = root.Q<VisualElement>("title-screen");
    }

    private void OnEnable()
    {
        titleScreen.style.display = DisplayStyle.Flex;
        var startButton = titleScreen.Q<Button>("title-screen-start-button");
        if (startButton == null)
        {
            Debug.LogError("Start button not found in title screen.");
            return;
        }
        startButton.clicked += OnStartButtonClicked;
    }

    private void OnDisable()
    {
        var startButton = titleScreen.Q<Button>("title-screen-start-button");
        if (startButton != null)
        {
            startButton.clicked -= OnStartButtonClicked;
        }
        titleScreen.style.display = DisplayStyle.None;
    }

    private void OnStartButtonClicked()
    {
        SceneManager.LoadScene(1);
    }
}
