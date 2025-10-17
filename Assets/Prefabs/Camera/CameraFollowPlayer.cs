using UnityEngine;

public class CameraFollowPlayer : MonoBehaviour
{
    //Utilizo SerializeField para poder modificar el offset desde el inspector de Unity
    [SerializeField]private Vector3 offSet;//agrego un offset para que la camara no quede pegada al player
    private PlayerMovement playerMovement;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offSet = new Vector3(0, 1, -5);
        //el playerMovement = FindObjectOfType<PlayerMovement>(); 
        //FUE DETECTADO COMO OBSOLETO ENTONCES USO:
        //Object.FindFirstObjectByType =>
        //=> Busca la primera instancia activa del tipo T, de forma más segura
        playerMovement = Object.FindFirstObjectByType<PlayerMovement>();
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        gameObject.transform.position = playerMovement.transform.position + offSet;
    }
}
