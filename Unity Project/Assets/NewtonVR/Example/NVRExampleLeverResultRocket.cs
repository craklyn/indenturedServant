using UnityEngine;
using System.Collections;

namespace NewtonVR.Example
{
    public class NVRExampleLeverResultRocket : MonoBehaviour
    {
        public GameObject RocketPrefab0;
		public GameObject RocketPrefab1;
		public GameObject RocketPrefab2;
		public GameObject RocketPrefab3;

        public NVRLever Control;

        private GameObject RocketInstance;
        
	    private void Awake()
        {
            StartCoroutine(DoSpawnShip());
        }
	
	    private void Update()
        {
            if (Control.LeverEngaged == true)
            {
                StartCoroutine(DoBlastOff());
            }
	    }

        public IEnumerator DoBlastOff()
        {
            Rigidbody rb = RocketInstance.GetComponent<Rigidbody>();
			rb.velocity = new Vector3(0,-10,0);

            yield return new WaitForSeconds(0.5f);

            StartCoroutine(DoSpawnShip());
        }

        private IEnumerator DoSpawnShip()
        {
			int randomGen = Random.Range (1, 5);


			if  (randomGen == 1) {
				RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab0, this.transform.position, this.transform.rotation);
			}
			else if  (randomGen == 2)  {
				RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab1, this.transform.position, this.transform.rotation);
			}
			else if  (randomGen == 3)  {
				RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab2, this.transform.position, this.transform.rotation);
			}
			else {
				RocketInstance = (GameObject)GameObject.Instantiate(RocketPrefab0, this.transform.position, this.transform.rotation);
			}
            RocketInstance.GetComponent<Rigidbody>().isKinematic = true;
            RocketInstance.GetComponent<NVRInteractableItem>().CanAttach = false;

            Vector3 startScale = Vector3.one * 0.1f;
            Vector3 endScale = Vector3.one;

            float startTime = Time.time;
            float overTime = 0.5f;
            float stopTime = startTime + overTime;

            while (Time.time < stopTime)
            {
                RocketInstance.transform.localScale = Vector3.Lerp(startScale, endScale, (Time.time - startTime) / overTime);
                yield return null;
            }

            RocketInstance.GetComponent<Rigidbody>().isKinematic = false;
            RocketInstance.GetComponent<NVRInteractableItem>().CanAttach = true;
        }
    }
}

