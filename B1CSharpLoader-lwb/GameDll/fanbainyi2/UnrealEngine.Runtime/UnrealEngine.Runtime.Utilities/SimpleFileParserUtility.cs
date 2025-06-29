using System.Collections.Generic;
using System.IO;

namespace UnrealEngine.Runtime.Utilities;

internal class SimpleFileParserUtility
{
	public static string ObtainStringFromSharedFileContent(string filePath, string lineContentLookFor, string columnContentLookFrom, char openParseRef, char closeParseRef)
	{
		return ObtainStringFromContentArray(ObtainContentFromSharedFile(filePath), lineContentLookFor, columnContentLookFrom, openParseRef, closeParseRef);
	}

	public static string ObtainStringFromContentArray(string[] content, string lineContentLookFor, string columnContentLookFrom, char openParseRef, char closeParseRef)
	{
		string result = "";
		if (content == null || content.Length == 0 || string.IsNullOrEmpty(lineContentLookFor) || string.IsNullOrEmpty(columnContentLookFrom))
		{
			LogFromSimpleFileParser("Couldn't Obtain String From Content Array Due To Parameters Being Invalid For Checking");
			return result;
		}
		int num = ObtainLastIndexInAllLineContains(content, lineContentLookFor);
		if (num != -1)
		{
			string text = content[num];
			int num2 = text.IndexOf(columnContentLookFrom);
			if (num2 != -1)
			{
				result = ObtainStringFromLine(openParseRef, closeParseRef, text, num2);
			}
			else
			{
				LogFromSimpleFileParser("Didn't find ColumnContentLookFrom: " + columnContentLookFrom + " in Line: " + text);
			}
		}
		else
		{
			LogFromSimpleFileParser("Couldn't Find Instance of LineContentLookFor: " + lineContentLookFor);
		}
		return result;
	}

	public static string ObtainStringFromLine(char openParseRef, char closeParseRef, string lineToObtainCharsFrom, int columnToStartFromIndex)
	{
		List<char> list = ObtainCharactersFromLine(openParseRef, closeParseRef, lineToObtainCharsFrom, columnToStartFromIndex);
		if (list.Count > 0)
		{
			return new string(list.ToArray());
		}
		return null;
	}

	public static List<char> ObtainCharactersFromLine(char openParseRef, char closeParseRef, string lineToObtainCharsFrom, int columnToStartFromIndex)
	{
		int num = FindFirstIndexOfGivenCharacter(lineToObtainCharsFrom, columnToStartFromIndex, openParseRef);
		List<char> list = new List<char>();
		if (num != -1)
		{
			for (int i = num; i < lineToObtainCharsFrom.Length && lineToObtainCharsFrom[i + 1] != closeParseRef; i++)
			{
				list.Add(lineToObtainCharsFrom[i + 1]);
			}
		}
		else
		{
			LogFromSimpleFileParser("Couldn't Find Instance of OpenParseRef: " + openParseRef + " Inside found Line: " + lineToObtainCharsFrom);
		}
		return list;
	}

	public static string[] ObtainContentFromSharedFile(string filePath)
	{
		if (!string.IsNullOrEmpty(filePath) && filePath.Length > 2 && File.Exists(filePath))
		{
			List<string> list = new List<string>();
			using (FileStream stream = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				using StreamReader streamReader = new StreamReader(stream);
				string item;
				while ((item = streamReader.ReadLine()) != null)
				{
					list.Add(item);
				}
			}
			return list.ToArray();
		}
		return new string[0];
	}

	public static int ObtainFirstIndexIfContains(string[] content, string contains)
	{
		for (int i = 0; i < content.Length; i++)
		{
			if (content[i].Contains(contains))
			{
				return i;
			}
		}
		return -1;
	}

	public static List<int> ObtainAllLineIndexsIfContains(string[] content, string contains)
	{
		List<int> list = new List<int>();
		for (int i = 0; i < content.Length; i++)
		{
			if (content[i].Contains(contains))
			{
				list.Add(i);
			}
		}
		return list;
	}

	public static int ObtainLastIndexInAllLineContains(string[] content, string contains)
	{
		List<int> list = ObtainAllLineIndexsIfContains(content, contains);
		int num = -1;
		foreach (int item in list)
		{
			if (item > num)
			{
				num = item;
			}
		}
		return num;
	}

	public static int FindFirstIndexOfGivenCharacter(string line, int startIndex, char contains)
	{
		if (startIndex < line.Length)
		{
			for (int i = startIndex; i < line.Length; i++)
			{
				if (line[i] == contains)
				{
					return i;
				}
			}
		}
		return -1;
	}

	private static void LogFromSimpleFileParser(string msg)
	{
		FMessage.Log(ELogVerbosity.Log, "SimpleFileParser: " + msg);
	}
}
