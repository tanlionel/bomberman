using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage1 : MonoBehaviour
{
    [Header("Sprites")]
    public AnimatedSpriteRenderer spriteRendererDeath;
    private AnimatedSpriteRenderer activeSpriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("Explosion"))
        {
            //GetComponent<Rigidbody2D>().enabled = false;
            //GetComponent<Enemy>().isDisabled = true;

            DeathSequence();
        }
    }

    private void DeathSequence()
    {
        enabled = false;
        //GetComponent<BombController>().enabled = false;

        /*spriteRendererUp.enabled = false;
        spriteRendererDown.enabled = false;
        spriteRendererLeft.enabled = false;
        spriteRendererRight.enabled = false;*/
        spriteRendererDeath.enabled = true;

        GetComponent<Enemy>().enabled = false;

        Invoke(nameof(OnDeathSequenceEnded), 1.25f);
        GetComponent<Enemy>().enabled = false;
    }

    private void OnDeathSequenceEnded()
    {
        gameObject.SetActive(false);
        GameManager.Instance.CheckWinState();
    }
}
