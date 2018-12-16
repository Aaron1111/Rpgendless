using UnityEngine;
using System.Collections;
using UnityEngine.UI;
 
public class Timer : MonoBehaviour
{
    public int timeLeft = 3;
    public Text countdownText;
 	public GameObject panel;
    // Use this for initialization
    void Start()
    {
        // panel.gameObject.SetActive(false);
        StartCoroutine("LoseTime");
    }
 
    // Update is called once per frame
    void Update()
    {
        countdownText.text = ("" + timeLeft);
 
        if (timeLeft == 0)
        {
            if (panel != null){
                Animator animator = panel.GetComponent<Animator>();
                if(animator != null){
                    bool isOpen = animator.GetBool("Open");
                    Debug.Log(isOpen);
                    animator.SetBool("Open", !isOpen);
                }
            }
            // panel.gameObject.SetActive(true);
            countdownText.text = "Go!";
        }
		if(timeLeft < 0){
            StopCoroutine("LoseTime");
			Destroy(this.gameObject);
		}
    }
 
    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}