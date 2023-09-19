namespace Resources
{
    public class Resource
    {
        public string Name { get; }
        public float Amount { get; private set; }

        private ResourceManager _resourceManager;

        public Resource(string name, float defaultAmount, ResourceManager resourceManager)
        {
            Name = name;
            Amount = defaultAmount;
            _resourceManager = resourceManager;
        }

        public void AddAmount(float amount)
        {
            if (amount < 0)
                return;

            Amount += amount;

            SendEventOnDataChanged();
        }

        public void SubtractAmount(float amount)
        {
            if (amount < 0)
                return;

            Amount -= amount;

            SendEventOnDataChanged();
        }

        private void SendEventOnDataChanged()
        {
            _resourceManager.OnResourceDataChanged(this);
        }
    }
}
