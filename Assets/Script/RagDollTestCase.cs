using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagDollTestCase : MonoBehaviour
{
    public Animator ragdollAnim;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }
    [ContextMenu("testRagdoll")]
    public void TestRagDoll()
    {
        ragdollAnim.enabled = !ragdollAnim.enabled;
    }
}
