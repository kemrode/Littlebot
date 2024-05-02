using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{

    private Animator littleBotAnimator;
    private string walk = "walk";
    private string run = "run";
    private string jump = "jump";
    [SerializeField]
    public CharacterController controller;
    private float walkSpeed = 0.1f;
    private float runSpeed = 0.2f;
    private float rotSpeed = 100f;
    private float jumpForce = 150f;
    private bool jumped;

    Rigidbody littleBotRigidBody;

    private void Awake()
    {
        littleBotAnimator = GetComponent<Animator>();
        littleBotRigidBody = GetComponent<Rigidbody>();
    }
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.jumped = true;
        }
    }

    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * x + transform.forward * z;

        if (z > 0)
        {
            if (Input.GetKey(KeyCode.LeftControl))
            {
                controller.Move(move * runSpeed);
                controller.Move(Physics.gravity);
                littleBotAnimator.SetFloat(run, z);
            }
            else
            {
                controller.Move(move * walkSpeed);
                controller.Move(Physics.gravity);
                littleBotAnimator.SetFloat(run, 0);
            }
            littleBotAnimator.SetBool(walk, true);
        }
        else
        {
            littleBotAnimator.SetBool(walk, false);
        }
        if (z != 0)
        {
            transform.Rotate(Vector3.up * rotSpeed * Time.deltaTime * x);
        }
        if (jumped)
        {
            this.jumped = false;
            littleBotRigidBody.AddForce(Vector3.up * jumpForce, ForceMode.Force);
            littleBotAnimator.SetTrigger(jump);
        }
        if (z < 0)
        {
            littleBotAnimator.SetBool("walkBack", true);
            controller.Move(move * walkSpeed);
            controller.Move(Physics.gravity);
        }
        else
        {
            littleBotAnimator.SetBool("walkBack", false);
        }
    }

    public void FinishGame()
    {
        SceneManager.LoadScene("endingScene");
    }

    public void GameOver()
    {
        SceneManager.LoadScene("gameOverScene");
        StartCoroutine(LoadLevelOne());
    }

    IEnumerator LoadLevelOne()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("niveauUn");
    }
}
