using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class snowCameraFollow : MonoBehaviour
{
    [SerializeField]
    RenderTexture rt;
    [SerializeField]
    Transform target;
    int resolution = 1024;
    RenderTexture tempTex;
    Camera camToDrawWith;
    [SerializeField] bool RealTimeDiffuse;
    int repeatRate = 5;
    // Start is called before the first frame update
    private void OnEnable()
    {
        tempTex = new RenderTexture(resolution, resolution, 24);
        DrawDiffuseMap();
    }

    void Awake()
    {
        Shader.SetGlobalTexture("_GlobalEffectRT", rt);
        camToDrawWith = GetComponent<Camera>();
        Shader.SetGlobalFloat("_OrthographicCamSize", GetComponent<Camera>().orthographicSize);
    }

    private void Update()
    {
        transform.position = new Vector3(target.transform.position.x, transform.position.y, target.transform.position.z);
        Shader.SetGlobalVector("_Position", transform.position);
    }

    private void Start()
    {
        DrawDiffuseMap();
        if (RealTimeDiffuse)
        {
            InvokeRepeating("UpdateTex", 1f, repeatRate);
        }
    }

    void UpdateTex()
    {
        camToDrawWith.enabled = true;
        camToDrawWith.targetTexture = tempTex;
        Shader.SetGlobalTexture("_GlobalEffectRT", tempTex);
    }

    public void DrawDiffuseMap()
    {
        DrawToMap("_GlobalEffectRT");
    }

    void DrawToMap(string _target)
    {
        camToDrawWith.enabled = true;
        camToDrawWith.targetTexture = tempTex;
        camToDrawWith.depthTextureMode = DepthTextureMode.Depth;

        Shader.SetGlobalFloat("_OrthographicCamSize", camToDrawWith.orthographicSize);
        Shader.SetGlobalVector("_Position", transform.position);
        camToDrawWith.Render();
        Shader.SetGlobalTexture(_target, tempTex);

        camToDrawWith.enabled = false;
    }

}
