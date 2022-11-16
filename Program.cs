
internal class Program
{
    static int depth = 1;
    static int maxDepth = 1;

    private static void Main(string[] args)
    {
        var tree = new Branch();
        tree.branches = new List<Branch> { new Branch(), new Branch() };
        tree.branches[0].branches = new List<Branch> { new Branch() };
        tree.branches[1].branches = new List<Branch> { new Branch(), new Branch(), new Branch() };
        tree.branches[1].branches[0].branches = new List<Branch> { new Branch() };
        tree.branches[1].branches[1].branches = new List<Branch> { new Branch(), new Branch() };
        tree.branches[1].branches[1].branches[0].branches = new List<Branch> { new Branch() };

        CalculateTreeDepth(tree);
        Console.WriteLine(maxDepth);
    }

    static void CalculateTreeDepth(Branch tree)
    {
        if (tree == null)
        {
            maxDepth--;
            return;
        }

        if (tree.branches != null)
        {
            depth++;
            foreach (var branch in tree.branches)
                CalculateTreeDepth(branch);
        }
        else
        {
            if (depth > maxDepth)
            {
                maxDepth = depth;
                depth--;
            }
        }
    }
}
    
public class Branch
{
    public List<Branch>? branches;
}
    
    
