using ReplicateExecutableFilesDownloadIssue;

var solution = new Solution();
var unitTests = new string[]
{
    "aHR0cHM6Ly93d3cuYmFzZTY0ZGVjb2RlLm9yZy8=.exe",
    "aHR0cHM6Ly93d3cuYmFzZTY0ZGVjb2RlLm9yZy8=(1).exe",
    "aHR0cHM6Ly93d3cuZ29vZ2xlLmNvbS8=.exe",
    "aHR0cHM6Ly93d3cuZ29vZ2xlLmNvbS8=(999).exe",
    "aHR0cHM6Ly93d3cubGlua2VkaW4uY29tL2luL25pb24tbGVlLThiMzk0YTExYi8=.exe",
    "aHR0cHM6Ly93d3cubGlua2VkaW4uY29tL2luL25pb24tbGVlLThiMzk0YTExYi8=(12345678900).exe",
};

var encodedUrls = unitTests.Select(url =>
{
    solution.TrimBracketsFromBase64FileName(ref url);
    Console.WriteLine(url);
    return url;
});

encodedUrls.Count();