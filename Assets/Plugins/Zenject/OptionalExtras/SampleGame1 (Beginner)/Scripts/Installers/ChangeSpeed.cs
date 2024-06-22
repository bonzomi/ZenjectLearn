using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Zenject.Asteroids
{
    public class ChangeSpeed : MonoBehaviour
    {
        public GameSettingsInstaller gameSettings;
        public float targetSpeed;

        [ContextMenu("ChangeSpeed")]
        public void ChangeSpeedNew()
        {
            gameSettings.Ship.StateMoving.moveSpeed = targetSpeed;
            Debug.Log(gameSettings.Ship.StateMoving.moveSpeed);
        }
    }
}