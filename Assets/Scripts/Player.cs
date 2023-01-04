using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Rigidbody _rigidbody;
    public Score score;
    [SerializeField] private float Speed = 0.02f;
    [SerializeField] private GameObject TargetPrefab;

    void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        _rigidbody.AddForce(Input.GetAxis("Horizontal")*Speed, 0.0f, Input.GetAxis("Vertical")*Speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Target"))
        {
            score.UpScore(other.gameObject.GetComponent<Target>().Value);
            StartCoroutine(DelayBeforeSpawn(other.gameObject.transform.position));

            Destroy(other.gameObject);
        }
    }
    
    IEnumerator DelayBeforeSpawn(Vector3 position)
    {
        yield return new WaitForSeconds(2f);

        GameObject temp = Instantiate(TargetPrefab, position, Quaternion.identity);
    }

}
