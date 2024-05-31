public class LCS
{
    public const int ARROW_CORNER = 0;
    public const int ARROW_UP = 1;
    public const int ARROW_LEFT = 2;

    public static int LongestCommonSubsequence(string X, string Y)
    {
        int m = X.Length;
        int n = Y.Length;

        // Initialize the arrays
        int[,] c = new int[m + 1, n + 1];
        int[,] b = new int[m + 1, n + 1];

        for (int i = 1; i <= m; i++)
        {
            c[i, 0] = 0;
        }

        for (int j = 1; j <= n; j++)
        {
            c[0, j] = 0;
        }

        // Calculate LCS length
        for (int i = 1; i <= m; i++)
        {
            for (int j = 1; j <= n; j++)
            {
                if (X[i - 1] == Y[j - 1])
                {
                    c[i, j] = c[i - 1, j - 1] + 1;
                    b[i, j] = ARROW_CORNER;
                }
                else if (c[i - 1, j] >= c[i, j - 1])
                {
                    c[i, j] = c[i - 1, j];
                    b[i, j] = ARROW_UP;
                }
                else
                {
                    c[i, j] = c[i, j - 1];
                    b[i, j] = ARROW_LEFT;
                }
            }
        }

        return c[m, n];
    }
}