using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private Transform respawnPoint;

    [SerializeField]
    private GameObject player;

    [SerializeField]
    private float respawnTime;

    private CinemachineVirtualCamera CVC;

    private void Start()
    {
        CVC = GameObject.Find("Player Camera").GetComponent<CinemachineVirtualCamera>();
    }

    public void Respawn()
    {
        StartCoroutine(InstantiatePlayer());
    }

    IEnumerator InstantiatePlayer()
    {
        yield return new WaitForSeconds(respawnTime);

        var playerTemp = Instantiate(player, respawnPoint);

        CVC.m_Follow = playerTemp.transform;
    }

}
