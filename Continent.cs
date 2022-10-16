using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Continent : MonoBehaviour
{
    public string nome;
    public int resources;
    public float cashGenerated;
    public float resourcesUsed;

    public Animator animator;

    public bool present;

    public Image infectedFill;

    private bool started;
}
