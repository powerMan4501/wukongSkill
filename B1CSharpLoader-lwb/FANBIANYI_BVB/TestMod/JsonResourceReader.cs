using System;
using System.Collections.Generic;
using System.IO;
using TinyJson;

namespace TestMod;

public class JsonResourceReader
{
	public static List<BossConfig> LoadBossConfigs()
	{
		string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
		string text = Path.Combine(baseDirectory, "CSharpLoader\\Mods\\BvBMod\\BossConfig.json");
		if (!File.Exists(text))
		{
			throw new FileNotFoundException("File Not Found: " + text);
		}
		string text2 = File.ReadAllText(text);
		Console.WriteLine(text2.Length);
		List<BossConfig> list = text2.FromJson<List<BossConfig>>();
		Console.WriteLine(list.Count + " -------- ");
		return list;
	}
}
