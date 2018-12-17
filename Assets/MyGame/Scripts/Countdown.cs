using UnityEngine;

public class Countdown : MonoBehaviour {

    public int duration = 30;
    public int timeRemaining;
    public bool isCountingDown = false;

    public void StartCountDown()
    {
        //Debug.Log("start countdown");
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            Invoke("CountingDown", 1f);
        }
    }

    private void CountingDown()
    {
        //Debug.Log("In counting down");
        timeRemaining--;
        if (timeRemaining > 0)
        {
            //Debug.Log(timeRemaining + " " + isCountingDown );
            Invoke("CountingDown", 1f);
        }
        else
        {
            isCountingDown = false;
            //Debug.Log(timeRemaining + " " + isCountingDown);
        }
    }

}
