namespace ReplicateExecutableFilesDownloadIssue
{
    public class Solution
    {
        public void TrimBracketsFromBase64FileName(ref string fileName)
        {
            if (fileName[^5] != ')')
                return;

            int index = fileName.Length - 6;
            while (index >= 0)
            {
                if (Char.IsDigit(fileName[index]))
                {
                    index--;
                    continue;
                }

                if (fileName[index] == '(')
                    break;
            }

            Span<char> chars = stackalloc char[index + 4];
            for (int i = index - 1; i >= 0; i--)
            {
                chars[i] = fileName[i];
            }

            chars[index] = '.';
            chars[index + 1] = 'e';
            chars[index + 2] = 'x';
            chars[index + 3] = 'e';

            fileName = new string(chars);
        }
    }
}
