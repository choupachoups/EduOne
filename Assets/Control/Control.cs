using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Control : MonoBehaviour
{
    public Camera lessonCamera;
    public Camera playerCamera;
    public GameObject player;
    public Animator teacherAnim;
    public GameObject erwin;
    public GameObject erwinName;
    public GameObject cat;
    public GameObject box;
    public GameObject particle;
    void Start()
    {
        
    }

    void Awake()
    {
        
    }
    
    
    void Update()
    {
        
    }

    public void Click()
    {
        SceneManager.LoadScene(0);
    }

    public void StartLesson()
    {
        playerCamera.gameObject.SetActive(false);
        lessonCamera.gameObject.SetActive(true);
        teacherAnim.SetBool("isTalking", true);
        StartCoroutine(StartErwinDance());
    }

    public void LeaveLesson()
    {
        playerCamera.gameObject.SetActive(true);
        lessonCamera.gameObject.SetActive(false);
        teacherAnim.SetBool("isTalking", false);
        
    }

    IEnumerator StartErwinDance()
    {
        yield return new WaitForSeconds(5f);
        teacherAnim.gameObject.SetActive(false);
        erwin.SetActive(true);
        particle.SetActive(true);
        StartCoroutine(StartErwinTalk());
    }
    
    IEnumerator StartErwinTalk()
    {
        yield return new WaitForSeconds(3f);
        erwinName.SetActive(true);
        box.SetActive(true);
        cat.SetActive(true);
        erwin.GetComponent<Animator>().SetBool("isTalking", true);
        
    }
}
