using System;
using System.Collections.Generic;

namespace UnrealEngine;

internal class Args
{
	private Dictionary<string, string> args = new Dictionary<string, string>();

	public string this[string key] => GetString(key);

	public Args(string arg)
	{
		if (arg == null)
		{
			return;
		}
		string[] array = arg.Split(new char[1] { '|' }, StringSplitOptions.RemoveEmptyEntries);
		foreach (string text in array)
		{
			int num = text.IndexOf('=');
			if (num > 0)
			{
				string text2 = text.Substring(0, num).Trim();
				string value = text.Substring(num + 1).Trim();
				if (!string.IsNullOrEmpty(text2) && !string.IsNullOrEmpty(value))
				{
					args[text2] = value;
				}
			}
		}
	}

	public bool Contains(string key)
	{
		return args.ContainsKey(key);
	}

	public string GetString(string key)
	{
		args.TryGetValue(key, out var value);
		return value;
	}

	public bool GetBool(string key)
	{
		if (args.TryGetValue(key, out var value) && bool.TryParse(value, out var result))
		{
			return result;
		}
		return false;
	}

	public int GetInt32(string key)
	{
		if (args.TryGetValue(key, out var value) && int.TryParse(value, out var result))
		{
			return result;
		}
		return 0;
	}

	public long GetInt64(string key)
	{
		if (args.TryGetValue(key, out var value) && long.TryParse(value, out var result))
		{
			return result;
		}
		return 0L;
	}
}
