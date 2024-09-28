using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemiesController: MonoBehaviour {
    public Queue<Enemy> enemyQueue;

    void Start()
    {
        enemyQueue = new Queue<Enemy>();
        enemyQueue.Enqueue(new Enemy { Name = "Boss1" });
        enemyQueue.Enqueue(new Enemy { Name = "Boss2" });
        enemyQueue.Enqueue(new Enemy { Name = "Boss3" });
    }

    public Enemy GetFirstEnemy()
    {
        if (enemyQueue.Count > 0) {
            var enemy = enemyQueue.Dequeue();
            // Call any method if you want
            enemy.Animate();
            return enemy;
        }
        Debug.Log("Enemy queue is empty");
        return null;
    }
}
