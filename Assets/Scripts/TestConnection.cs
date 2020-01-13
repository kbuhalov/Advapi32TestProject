using System;
using System.Net.WebSockets;
using System.Threading;
using System.Threading.Tasks;
using UnityEngine;

public class TestConnection : MonoBehaviour
{
    private void Start()
    {
        Connect();
    }

    private async void Connect()
    {
        var host = new Uri("wss://echo.websocket.org");

        Debug.Log($"!!!!!Create new client web socket");

        var s = new ClientWebSocket();

        Debug.Log($"!!!!!Socket created");

        Debug.Log($"!!!!!Establishing Connection to {host}");

        await s.ConnectAsync(host, CancellationToken.None);

        Debug.Log($"!!!!!Connection established with state: {s.State}");
    }
}
