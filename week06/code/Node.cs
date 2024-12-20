public class Node
{
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data)
    {
        this.Data = data;
    }

    public void Insert(int value)
    {
        // TODO Start Problem 1
        if (value == Data) return;

        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value)
    {
        // TODO Start Problem 2
        if (Data == value) return true;

        if (Left is not null && Left.Contains(value)) return true;

        if (Right is not null && Right.Contains(value)) return true;

        return false;
    }

    public int GetHeight()
    {
        if (this == null) return 0;

        int leftHeight = 0;
        int rightHeight = 0;
        // TODO Start Problem 4
        if (Left is not null) {
            leftHeight += Left.GetHeight();
        }

        if (Right is not null) {
            rightHeight += Right.GetHeight();
        }

        return Math.Max(leftHeight, rightHeight) + 1;
    }
}