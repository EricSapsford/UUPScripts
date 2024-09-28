using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TaskController : MonoBehaviour
{
    public List<Task> tasks;
    private Coroutine runTasksRoutine;

    private IEnumerator ExecuteTasksInSeries()
    {
        foreach(var task in tasks) {
            task.doSomething();
            // Delay before execute next task
            yield return new WaitForSeconds(2);
            task.doSomethingElse();
            // Other delay options
            // WaitUntil()
            // WaitWhile()
            // WaitForEndOfFrame()
            // WaitForFixedUpdate()
            // WaitForSecondsRealtime()
        }
        // Pause the game
        Time.timeScale = 0;
        yield return new WaitForSecondsRealtime(1);
        Debug.Log("I just wasted for a second, it's not affected by scaled time");
    }

    void Start()
    {
        tasks = new List<Task>();
        // Add your tasks here
        runTasksRoutine = StartCoroutine(ExecuteTasksInSeries());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            // Stop all coroutines
            StopAllCoroutines();
            // Specify the coroutine
            StopCoroutine(runTasksRoutine);
        }
    }
}
