namespace LongestCommonPrefix;
public class LongestCommonPrefix
{
    public string LongestCommonPrefixFunction(string[] strs)
    {
        string answer = "";
        bool equal = true;

        strs = strs.OrderBy(x => x.Length).ToArray();

        for (int i = 0; i <= strs[0].Length - 1; i++)
        {
            Console.WriteLine($"strs[i] : {strs[0][i]}");
            for (int j = 1; j <= strs.Length - 1; j++)
            {
                if (strs[0][i] == strs[j][i])
                {
                    Console.WriteLine($"Letter: {strs[0][i]}, Word: {strs[j]}, word i: {strs[j][i]} ");
                }
                else
                {
                    equal = false;
                }
            }

            if (equal)
            {
                answer += strs[0][i];
            }
        }


        return answer;
    }
}
