using UnityEngine;

public class enemyhealth : MonoBehaviour
{
    public int health=5;
    bool isDead = false;

    public void TakeDamage()
    {
        if (isDead) return;

        isDead = true;

        // دشمن روی زمین بیفتد
        transform.rotation = Quaternion.Euler(75, transform.rotation.eulerAngles.y, 0);
         transform.position += new Vector3 (0,0.5f,0);

        // حرکت دشمن خاموش شود
        enemypatrol patrol = GetComponent<enemypatrol>();
        if (patrol != null)
        {
            patrol.enabled = false;
        }

        // انیمیشن دشمن خاموش شود
        Animator anim = GetComponent<Animator>();
        if (anim != null)
        {
            anim.enabled = false;
        }

        // کولایدر خاموش شود که دوباره تیر نخورد
        Collider col = GetComponent<Collider>();
        if (col != null)
        {
            col.enabled = false;
        }
    }
}
