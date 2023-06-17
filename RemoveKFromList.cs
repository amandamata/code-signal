namespace code_signal;

public static class RemoveKFromList
{
    public class ListNode<T>
    {
        public T? value { get; set; }
        public ListNode<T>? next { get; set; }
    }

    public static ListNode<int> solution(ListNode<int> l, int k)
    {
        if (l?.value == k)
        {
            l = solution(l?.next, k);
        }
        if (l?.next != null)
        {
            l.next = solution(l?.next, k);
        }
        return l;
    }
}
