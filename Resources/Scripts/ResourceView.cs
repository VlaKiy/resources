using TMPro;
using UnityEngine;

namespace Resources
{
    public class ResourceView : MonoBehaviour
    {
        [SerializeField] private string _resourceName;

        private TextMeshProUGUI _textMeshPro;
        private ResourceManager _resourceManager;

        private void Awake()
        {
            _resourceManager = GameObject.Find("ResourceManager").GetComponent<ResourceManager>();
            _textMeshPro = GetComponent<TextMeshProUGUI>();

            _resourceManager.ResourceDataChanged += Show;
        }

        private void Show(Resource resource)
        {
            _textMeshPro.text = resource.Amount.ToString();
        }
    }
}