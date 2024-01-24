
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarMove1 : MonoBehaviour
{
    public Joystick joystick;
    public float Speed;
    public float TurnSpeed;
    public float Acceleration;
    void Update()
    {
        var y = joystick.Vertical/100;
        var x = joystick.Horizontal/1;
        transform.Rotate(0, x * TurnSpeed * Time.deltaTime, 0);
        //var x = inputHorizontal;
        //var y = inputVertical;
        //var z = 0;


        transform.Translate(0,0,y);
        if (Input.GetKey("r"))
            SceneManager.LoadScene(0);

    }
}
