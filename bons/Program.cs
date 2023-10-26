

  string s = " salam salam necesen qaqa";
    List<string> fsfs = s.Split(' ').ToList();

    Dictionary<string, int> dictionary = fsfs.GroupBy(x => x)
        .ToDictionary(x => x.Key, x => x.Count());

    foreach (var kvp in dictionary)
        Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
        