using UnityEngine;
public class Player : MonoBehaviour
{
    private Animator animator;

    // Start is called before the first frame update
    private void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 NextPosition = this.transform.position;
        NextPosition.x += horizontal * Time.deltaTime;
        NextPosition.z += vertical * Time.deltaTime;

        

        if (Mathf.Approximately(horizontal, 0.0f) && Mathf.Approximately(vertical, 0.0f))
        {
            animator.SetBool("IsRunning", false);
        }
        else
        {
            animator.SetBool("IsRunning", true);
            this.transform.LookAt(NextPosition);
        }
        this.transform.position = NextPosition;
    }
}