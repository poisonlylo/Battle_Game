using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_change : MonoBehaviour
{

    public GameObject Fp_camera;
    public GameObject Third_camera;
    public int Cam_mode;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (Cam_mode == 1)
            {
                Cam_mode = 0;
            }
            else
            {
                Cam_mode += 1;
            }
            StartCoroutine(Cam_change());
        }
    }
    IEnumerator Cam_change()
    {
        yield return new WaitForSeconds(0.01f);
        if (Cam_mode == 0)
        {
            Third_camera.SetActive(true);
            Fp_camera.SetActive(false);
        }
        if (Cam_mode == 1)
        {
            Third_camera.SetActive(false);
            Fp_camera.SetActive(true);
        }

    }
}
