namespace Essentials2.Library
{
    public static class CollectionSamples
    {
        public static void Queue()
        {
            System.Collections.Specialized.NameValueCollection
            var q = new System.Collections.Queue();
            q.Enqueue("firstItem");
            q.Enqueue("secondItem");

            string? item = null;

            Console.WriteLine("Using a Queue");
            while ((item = (string?)q.Dequeue()) != null)
            {
                Console.WriteLine(item);
                if (q.Count <= 0)
                    break;
            }
        }

        public static void Stack()
        {
            var stk = new System.Collections.Stack();
            stk.Push("firstItem");
            stk.Push("secondItem");

            string? stkItem = null;
            Console.WriteLine();
            Console.WriteLine("Using a stack");

            while ((stkItem = (string?)stk.Pop()) != null)
            {
                Console.WriteLine(stkItem);
                if (stk.Count <= 0)
                    break;
            }
        }
    }
}