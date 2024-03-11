using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class configSO : MonoBehaviour
{
}

[CreateAssetMenu(menuName = "Config/PlayerConfig")]
public class PlayerConfig : ScriptableObject
{
    float turnRate;
}
