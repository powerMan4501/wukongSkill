using System.Collections.Generic;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

internal static class FModulesPaths
{
	public static Dictionary<FName, string> FindModulePaths(string namePattern, bool canUseCache = true)
	{
		Dictionary<FName, string> dictionary = new Dictionary<FName, string>();
		using (FStringUnsafe fStringUnsafe = new FStringUnsafe(namePattern))
		{
			using TArrayUnsafe<FName> tArrayUnsafe = new TArrayUnsafe<FName>();
			using TArrayUnsafe<string> tArrayUnsafe2 = new TArrayUnsafe<string>();
			Native_FModulePaths.FindModulePaths(ref fStringUnsafe.Array, canUseCache, tArrayUnsafe.Address, tArrayUnsafe2.Address);
			if (tArrayUnsafe.Count == tArrayUnsafe2.Count)
			{
				int count = tArrayUnsafe.Count;
				for (int i = 0; i < count; i++)
				{
					dictionary[tArrayUnsafe[i]] = tArrayUnsafe2[i];
				}
			}
		}
		return dictionary;
	}
}
