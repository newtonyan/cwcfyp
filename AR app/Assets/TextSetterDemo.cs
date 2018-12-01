namespace Mapbox.Examples
{
    using Mapbox.Unity.MeshGeneration.Interfaces;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class TextSetterDemo : MonoBehaviour, IFeaturePropertySettable
    {
        private string Name;

        public void Set(Dictionary<string, object> props)
        {
            if (props.ContainsKey("name_en"))
            {
                Name = props["name_en"].ToString();
            }
           
        }

        private void OnMouseDown()
        {
            Debug.Log(Name);
            this.gameObject.SetActive(false);
        }
    }
}