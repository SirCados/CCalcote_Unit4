using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody _playerRigidbody;
    public GameObject FocalPoint;
    public float speed = 5.0f;
    private Renderer _renderer;
    
    // Start is called before the first frame update
    void Start()
    {       
        _playerRigidbody = GetComponent<Rigidbody>();
        _renderer = GetComponent<Renderer>();
        FocalPoint = GameObject.Find("Focal Point");
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float magnitude = forwardInput * speed * Time.deltaTime;
        _playerRigidbody.AddForce(FocalPoint.transform.forward * magnitude, ForceMode.Impulse);

        _renderer.material.color = new Color(1 * Mathf.Abs(forwardInput), .5f * Mathf.Abs(forwardInput), 1* Mathf.Abs(forwardInput));
    }
}
