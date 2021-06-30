using System.Threading;

namespace WPCSharp.CreationalPatterns.ObjectPool
{
    public class Item
    {
        private bool isCollected;

        public Item()
        {
            Thread.Sleep(10);
        }

        public bool IsVisible { get; set; }
        public bool IsCollected
        {
            get => isCollected;
            set
            {
                if (isCollected = value)
                    IsVisible = false;
            }
        }

        public byte[] Content { get; } = new byte[1024];
    }
}
