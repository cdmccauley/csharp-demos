using static LinkedListLibrary.ListNode;

namespace StackInheritanceLibrary
{
    public class StackInheritance : List
    {
        public StackInheritance() : base("stack")
        {
        }

        public void Push(object dataValue)
        {
            InsertAtFront(dataValue);
        }

        public object Pop()
        {
            return RemoveFromFront();
        }
    }
}
