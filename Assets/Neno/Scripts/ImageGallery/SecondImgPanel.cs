using System.Collections;
using System.Collections.Generic;
using HoloToolkit.Unity.InputModule;
using UnityEngine;

namespace Neno.Scripts
{
    public class SecondImgPanel : MonoBehaviour,IInputClickHandler
    {
        [SerializeField]
        private GameObject photoPanel2Create;

        public void OnInputClicked(InputClickedEventData eventData)
        {
            GameObject photoPanelObj = Instantiate(photoPanel2Create, Camera.main.transform.position + new Vector3(0, 0, 1f),
                Quaternion.LookRotation(-Camera.main.transform.forward));
            photoPanelObj.GetComponent<Renderer>().material = gameObject.GetComponent<Renderer>().material;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
