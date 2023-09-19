using System;
using System.Collections.Generic;
using UnityEngine;

namespace Resources
{
    public class ResourceManager : MonoBehaviour
    {
        public event Action<Resource> ResourceDataChanged;

        public Dictionary<string, Resource> ResourcesMap => _resourcesMap;

        private Dictionary<string, Resource> _resourcesMap = new Dictionary<string, Resource>();

        private void Awake()
        {
            InitializeResources();
        }

        // � ���� ������� ���������������� �������.
        private void InitializeResources()
        {
            AddResource("Energy", 0f);
        }

        public void AddResource(string name, float defaultAmount)
        {
            _resourcesMap.Add(name, new Resource(name, defaultAmount, this));

            ResourcesMap[name].AddAmount(defaultAmount);
        }

        public void OnResourceDataChanged(Resource resource)
        {
            ResourceDataChanged?.Invoke(resource);
        }
    }
}