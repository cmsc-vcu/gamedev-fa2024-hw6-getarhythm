using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoteObject : MonoBehaviour
{
    public bool canBePressed;
    public bool noteMissed; // Track whether the note was already missed
    public bool noteHit;    // Track whether the note was already hit

    public KeyCode keyToPress;

    public GameObject hitEffect, goodEffect, perfectEffect, missEffect;

    // Start is called before the first frame update
    void Start()
    {
        noteMissed = false; // Initialize as not missed
        noteHit = false;    // Initialize as not hit
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(keyToPress) && canBePressed && !noteHit)
        {
            noteHit = true; // Mark the note as hit, preventing future miss registration
            gameObject.SetActive(false); // Disable the note after it is hit

            // Check hit timing and apply the correct hit type
            if (Mathf.Abs(transform.position.y) > 0.25f)
            {
                Debug.Log("Hit");
                GameManager.instance.NormalHit();
                Instantiate(hitEffect, transform.position, hitEffect.transform.rotation);
            }
            else if (Mathf.Abs(transform.position.y) > 0.05f)
            {
                Debug.Log("Good");
                GameManager.instance.GoodHit();
                Instantiate(goodEffect, transform.position, goodEffect.transform.rotation);
            }
            else
            {
                Debug.Log("Perfect");
                GameManager.instance.PerfectHit();
                Instantiate(perfectEffect, transform.position, perfectEffect.transform.rotation);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Activator")
        {
            canBePressed = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Activator" && !noteMissed && !noteHit) // Only trigger if the note hasn't been hit or missed already
        {
            canBePressed = false;
            noteMissed = true; // Mark note as missed

            // Register miss and instantiate miss effect
            GameManager.instance.NoteMissed();
            Instantiate(missEffect, transform.position, missEffect.transform.rotation);

            // Optionally disable or destroy the note to prevent further interaction
            gameObject.SetActive(false); // You can also use Destroy(gameObject) if you prefer
        }
    }
}
