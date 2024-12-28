var input = File.ReadAllText("input.txt");

var disk = input.Select(x => long.Parse(x.ToString())).ToArray();
var diskMap = new List<string>();
var fileId = 0;

for (int i = 0; i < disk.Length; i++)
{
    if (i % 2 == 0)
    {
        for (int j = 0; j < disk[i]; j++)
        {
            diskMap.Add(fileId.ToString());
        }
        fileId++;
    }
    else
    {
        for (int j = 0; j < disk[i]; j++)
        {
            diskMap.Add(".");
        }
    }

}

var compactDiskMap = diskMap.ToArray();
var sortedMap = compactDiskMap.ToArray();
var fileSize = 0;
var spaceCount = 0;
var movedFiles = new HashSet<string>();

for (int i = compactDiskMap.Length - 1; i > 0; i--)
{
    if (compactDiskMap[i] == ".")
    {
        continue;
    }

    fileSize++;
    if (compactDiskMap[i - 1] != compactDiskMap[i])
    {            
        for (int j = 0; j < compactDiskMap.Length; j++)
        {
            if (compactDiskMap[j] == ".")
            {
                spaceCount++;

                if (fileSize == spaceCount & i > j)
                {
                    movedFiles.Add(compactDiskMap[i]);
                    for (var k = 0; k < fileSize; k++)
                    {
                        compactDiskMap[j - k] = compactDiskMap[i + k];
                        compactDiskMap[i + k] = ".";
                    }                   
                    fileSize = 0;
                    spaceCount = 0;
                }
            }
            else
            {
                spaceCount = 0;
            }
        }
        fileSize = 0;
    }
}

long checksum = 0;

for (int i = 0; i < compactDiskMap.Length; i++)
{
    if (compactDiskMap[i] == ".")
    {
        continue;
    }

    checksum += i * long.Parse(compactDiskMap[i]);
}

Console.WriteLine(checksum);
