namespace LeetCodeProblems;


internal class Program
{
    static void Main(string[] args)
    {


    }

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2, int carry = 0)
    {
        // Caso base: se entrambe le liste sono null e non c'è riporto, la somma è completata
        if (l1 == null && l2 == null && carry == 0) return null;

        // Calcolo della somma dei valori attuali di l1, l2 e del riporto
        int total = (l1 != null ? l1.val : 0) + (l2 != null ? l2.val : 0) + carry;
        // Calcolo del nuovo riporto
        carry = total / 10;
        // Creazione di un nuovo nodo con il valore della cifra corrente e chiamata ricorsiva per i nodi successivi
        return new ListNode(total % 10, AddTwoNumbers(l1?.next, l2?.next, carry));
    }



    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
