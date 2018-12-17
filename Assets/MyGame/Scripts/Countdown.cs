using UnityEngine;

public class Countdown : MonoBehaviour {

    public const int duration = 30;
    public int timeRemaining;
    public bool isCountingDown = false;

    public void StartCountDown()
    {
        if (!isCountingDown)
        {
            isCountingDown = true;
            timeRemaining = duration;
            Invoke("CountingDown", 1f);
        }
    }

    private void CountingDown()
    {
        timeRemaining--;
        if (timeRemaining > 0)
        {
            Invoke("CountingDown", 1f);
        }
        else
        {
            isCountingDown = false;
        }
    }

}
