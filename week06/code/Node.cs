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
        if (value < Data)
        {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else if (value > Data)
        {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
        // If value == Data, do nothing (don't insert duplicates)
    }

    public bool Contains(int value)
    {
        if (value == Data)
            return true;
        else if (value < Data)
        {
            // Search on the left side
            if (Left is null)
                return false;
            else
                return Left.Contains(value);
        }
        else
        {
            // Search on the right side
            if (Right is null)
                return false;
            else
                return Right.Contains(value);
        }
    }

    public int GetHeight()
    {
        // Get height of left and right subtrees
        int leftHeight = Left?.GetHeight() ?? 0;
        int rightHeight = Right?.GetHeight() ?? 0;

        // Return 1 plus the maximum height of either subtree
        return 1 + Math.Max(leftHeight, rightHeight);
    }
}