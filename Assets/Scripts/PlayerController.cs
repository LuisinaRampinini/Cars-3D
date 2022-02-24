using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    //Propiedades
    //[HideInInspector]
   [Range(0, 20), SerializeField,
   Tooltip("Velocidad lineal máxima del coche")]
    private float speed = 10f;

    [Range(0, 90), 
     SerializeField,
     Tooltip("Velocidad de giro máxima del coche")]
    private float turnSpeed = 90f;
    
    private float horizontalInput, verticalInput;
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update ()
    { 
        //Debug.Log("Esto es el método Update del Pc del "+gameObject.name);
        //Tenemos que mover el vehículo hacia adelante.


        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");
        
        
        //S = s0 + V*t*(direccion)
        transform.Translate(translation:speed*Time.deltaTime*Vector3.forward*verticalInput);//0,0,1
        transform.Rotate(turnSpeed * Time.deltaTime* Vector3.up*horizontalInput);
    }
}
