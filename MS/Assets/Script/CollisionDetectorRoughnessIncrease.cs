using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System;
using System.Text;

public class CollisionDetectorRoughnessIncrease : MonoBehaviour
{
    SerialController serialController;
    UdpClient client;

    public int port = 9999;

    public string messagePython;

    public string messageArduino;

    void Start()
    {
        client = new UdpClient(0);
        client.Connect("127.0.0.1", port);
        serialController = GameObject.Find("SerialController").GetComponent<SerialController>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Right IndexTip")
        {
            byte[] sendBytes = Encoding.ASCII.GetBytes(messagePython);
            client.Send(sendBytes, sendBytes.Length);
            Debug.Log($"Rougher material triggered: {other.gameObject.name} {Time.time}");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.name == "Right IndexTip")
        {
            byte[] sendBytes = Encoding.ASCII.GetBytes("0");
            client.Send(sendBytes, sendBytes.Length);
            Debug.Log($"Rougher material exited: {other.gameObject.name} {Time.time}");
        }
    }
}
