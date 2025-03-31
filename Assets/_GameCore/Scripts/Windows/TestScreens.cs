using System;
using AppCoreModule.Scripts.Services;
using AppCoreModule.Scripts.UI.Screens;
using UnityEngine;
using UnityEngine.Serialization;

namespace _GameCore.Scripts.Windows
{
    public class TestScreens : MonoBehaviour
    {
        [SerializeField] private BaseScreen _screen1;
        [SerializeField] private Canvas _screenCanvas;
        
        private void Awake()
        {
            var windowService = new ScreenService();
            windowService.Init(_screenCanvas);
            windowService.OpenWindow(_screen1);
        }
    }
}