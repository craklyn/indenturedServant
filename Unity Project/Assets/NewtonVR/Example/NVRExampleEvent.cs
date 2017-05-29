using UnityEngine;
using System.Collections;

namespace NewtonVR.Example
{
    public class NVRExampleEvent : MonoBehaviour
    {
		public GameObject spawnPoint;
        public void Duplicate()
        {
            GameObject duplicate = GameObject.Instantiate(this.gameObject);
        //    duplicate.transform.Translate(0, Random.value, 0, Space.World);
			duplicate.transform.position = spawnPoint.transform.position ;
            duplicate.GetComponent<NVRInteractableItem>().ResetInteractable();
        }
    }
}