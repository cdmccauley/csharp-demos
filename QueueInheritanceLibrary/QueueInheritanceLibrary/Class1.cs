using static LinkedListLibrary.ListNode;

namespace QueueInheritanceLibrary
{
    public class QueueInheritance : List
    {
        public QueueInheritance() : base("queue")
        {
        }

        public void Enqueue(object dataValue)
        {
            InsertAtBack(dataValue);
        }

        public object Dequeue()
        {
            return RemoveFromFront();
        }
    }
}
