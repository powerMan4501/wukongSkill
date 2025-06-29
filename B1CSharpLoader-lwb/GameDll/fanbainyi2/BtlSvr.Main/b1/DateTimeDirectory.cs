using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace b1;

public class DateTimeDirectory
{
	public string FolderPath;

	public string FolderName;

	public DateTime FileDataTime;

	public DateTimeDirectory(string FolderPath, string DateTimePattern)
	{
		this.FolderPath = FolderPath;
		FolderName = Path.GetFileName(FolderPath);
		FileDataTime = GetDateTimeFromFolderName(FolderPath, DateTimePattern);
	}

	public static bool IsSameYear(DateTime Left, DateTime Right)
	{
		return Left.Year == Right.Year;
	}

	public static bool IsSameMonth(DateTime Left, DateTime Right)
	{
		if (IsSameYear(Left, Right))
		{
			return Left.Month == Right.Month;
		}
		return false;
	}

	public static bool IsSameDay(DateTime Left, DateTime Right)
	{
		if (IsSameMonth(Left, Right))
		{
			return Left.Day == Right.Day;
		}
		return false;
	}

	public static bool IsSameHour(DateTime Left, DateTime Right)
	{
		if (IsSameDay(Left, Right))
		{
			return Left.Hour == Right.Hour;
		}
		return false;
	}

	private static bool IsDateTimeFolder(string folderName, string DataTimePattern)
	{
		DateTime result;
		return DateTime.TryParseExact(Path.GetFileName(folderName), DataTimePattern, null, DateTimeStyles.None, out result);
	}

	private static DateTime GetDateTimeFromFolderName(string folderName, string DataTimePattern)
	{
		return DateTime.ParseExact(Path.GetFileName(folderName), DataTimePattern, null);
	}

	public static string GenDateTimeFolder(string ParentPath, DateTime FolderTime, string DateTimePattern)
	{
		return Path.Combine(ParentPath, FolderTime.ToString(DateTimePattern));
	}

	public static List<DateTimeDirectory> MatchDataTimeDirectory(string MatchFolder, string DataTimePattern)
	{
		IEnumerable<string> enumerable = from dir in Directory.GetDirectories(MatchFolder)
			where IsDateTimeFolder(dir, DataTimePattern)
			select dir;
		List<DateTimeDirectory> list = new List<DateTimeDirectory>();
		foreach (string item in enumerable)
		{
			list.Add(new DateTimeDirectory(item, DataTimePattern));
		}
		list.Sort((DateTimeDirectory dir1, DateTimeDirectory dir2) => dir2.FileDataTime.CompareTo(dir1.FileDataTime));
		return list;
	}
}
