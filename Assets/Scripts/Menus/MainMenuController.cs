using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace TMG.LD53
{
    public class MainMenuController : MonoBehaviour
    {
        [SerializeField] private Button _playButton;
        [SerializeField] private GameObject _optionsPanel;
        
        private void OnEnable()
        {
            _playButton.onClick.AddListener(PlayGame);
            EventSystem.current.SetSelectedGameObject(_playButton.gameObject);
        }
        
        private void OnDisable()
        {
            _playButton.onClick.RemoveAllListeners();
        }

        private void PlayGame()
        {
            SceneManager.LoadScene(1);
        }

        private void QuitGame()
        {
            Application.Quit();
        }
    }
}