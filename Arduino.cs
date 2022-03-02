using System.Collections;
using UnityEngine;
using System.IO.Ports;

public class Arduino : MonoBehaviour
{
    SerialPort serialPort = new SerialPort("COM3", 9600);
    [SerializeField] float speed = 0.1f;
    void Start()
    {
        serialPort.Open();
    }

    
    void Update()
    {
        if(serialPort.IsOpen)
        {
            string[] data = serialPort.ReadLine().Split(',');

            float xThrow;
            float.TryParse(data[0], out xThrow);

            float yThrow;
            float.TryParse(data[1], out yThrow);

            transform.Translate(new Vector3(xThrow, -yThrow, 0f) * speed, Space.World);

            int buttonPressed;
            int.TryParse(data[2], out buttonPressed);

            transform.Rotate(0f, buttonPressed, 0f);
            
        }
    }
}
