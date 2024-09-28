using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemiesController: MonoBehaviour {
    public Stack<Enemy> enemyStack;

    void Start()
    {
        enemyStack = new Stack<Enemy>();
        enemyStack.Push(new Enemy { Name = "Final boss" });
        enemyStack.Push(new Enemy { Name = "Superboss" });
        enemyStack.Push(new Enemy { Name = "Miniboss" });
    }

    public Enemy GetNextBoss()
    {
        if (enemyStack.Count > 0) {
            var enemy = enemyStack.Pop();
            // Call any method if you want
            enemy.Animate();
            return enemy;
        }
        Debug.Log("Final boss was killed");
        return null;
    }
}
