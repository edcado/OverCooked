using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaitingForPlayersUI : MonoBehaviour
{

    private void Start()
    {
        KitchenGameManager.Instance.OnLocalPlayerReadyChanged += KitchenGameManager_OnLocalPlayerReadyChanged;
        KitchenGameManager.Instance.OnStateChanged += KitchenGameManager_OnStateChanged;
        Hide();
    }

    private void KitchenGameManager_OnStateChanged(object sender, System.EventArgs e)
    {
        if (KitchenGameManager.Instance.isCountingDown())
        {
            Hide();
        }
    }

    private void KitchenGameManager_OnLocalPlayerReadyChanged(object sender, System.EventArgs e)
    {
        if (KitchenGameManager.Instance.PlayerLocalReady())
        Show();
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}
