using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    [Header("移動速度"), Range(0, 10)]
    public float MovementSpeed = 3.5f;
    [Range(0, 500)]
    public int AttackDamage = 100;
    [Range(0, 5000)]
    public int HP = 350;
    [Range(0, 50)]
    public float TraceRadius = 30;
    public Vector3 v3TraceMovemoent;

    [Header("掉落道具")]
    [Range(0, 1)]
    public float DropItemAVG = 1;

    [Header("音效檔案")]
    public AudioClip DropItemSound;
    public AudioClip InjurySound;
    public AudioClip AttackSound;

    private AudioSource MonAud;
    private Rigidbody2D MonRig;
    private Animator MonAni;
}
