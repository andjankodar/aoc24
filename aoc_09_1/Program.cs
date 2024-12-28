var input = File.ReadAllText("input.txt");

var disk = input.Select(x => long.Parse(x.ToString())).ToArray();
var diskMap = new List<string>();
var fileId = 0;

for (int i = 0; i < disk.Length; i++)
{
    if(i % 2 == 0)
    {
        for (int j = 0; j < disk[i]; j++)
        {
            diskMap.Add(fileId.ToString());
        }
        fileId++;
    } else
    {
        for (int j = 0; j < disk[i]; j++)
        {
            diskMap.Add(".");
        }
    }
    
}

//Console.WriteLine(string.Join("", diskMap));

var compactDiskMap = diskMap.ToArray();

for (int i = 0; i < compactDiskMap.Length; i++)
{
    if (compactDiskMap[i] == ".")
    {
        for (int j = compactDiskMap.Length - 1; j > i; j--)
        {
            if (compactDiskMap[j] != ".")
            {
                compactDiskMap[i] = compactDiskMap[j];
                compactDiskMap[j] = ".";
                break;
            }
        }
    }
}

//Console.WriteLine(string.Join("", compactDiskMap));
long checksum = 0;

for (int i = 0;i < compactDiskMap.Length; i++)
{
    if(compactDiskMap[i] == ".")
    {
        break;
    }

    checksum += i * long.Parse(compactDiskMap[i]);
}

Console.WriteLine(checksum);
