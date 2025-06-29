using System.Collections.Generic;

namespace b1;

public static class BGU_UMGUtil
{
	public static List<string> StringtoListLinebyLine(string str)
	{
		List<string> list = new List<string>();
		string text = "";
		for (int i = 0; i < str.Length; i++)
		{
			if (str[i] != '\r')
			{
				if (str[i] == ',' || str[i] == '\n')
				{
					list.Add(text);
					text = "";
				}
				else
				{
					text += str[i];
				}
				if (i == str.Length - 1 && str[i] != ',' && str[i] != '\n')
				{
					list.Add(text);
				}
			}
		}
		return list;
	}
}
