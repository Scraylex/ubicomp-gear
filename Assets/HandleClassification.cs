using TMPro;
using UnityEngine;

// Start is called before the first frame update
public class HandleClassification : MonoBehaviour
    {
        public TextMeshProUGUI textMeshPro ;
        public string State { get; set; }

        // Start is called before the first frame update
        void Start()
        {
            State = "None";
        }

        // Update is called once per frame
        void Update()
        {
            textMeshPro.SetText(State);
        }
    }
