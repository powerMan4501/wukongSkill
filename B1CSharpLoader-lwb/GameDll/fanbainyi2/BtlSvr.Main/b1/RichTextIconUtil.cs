using System;
using System.IO;
using System.Text;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class RichTextIconUtil
{
	public const string RichTextIconJsonDataPath = "/00Main/UI/Data/RichTextIconConfig.json";

	public static void ExportData()
	{
		StringBuilder stringBuilder = new StringBuilder("[");
		foreach (FUStRichTextIconDesc value in BGW_GameDB.GetAllRichTextIconDesc().Values)
		{
			stringBuilder.Append(new RichTextIconData(value.Name, new FVector2D(value.SizeX, value.SizeY), value.ResourceObject).ToJson());
		}
		stringBuilder.Append("]");
		try
		{
			string projectContentDirectory = USystemLibrary.GetProjectContentDirectory();
			string path = FPaths.Combine(projectContentDirectory, "/00Main/UI/Data/RichTextIconConfig.json");
			FileMode mode = FileMode.Create;
			FileStream fileStream = new FileStream(path, mode, FileAccess.ReadWrite);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			streamWriter.Write(stringBuilder.ToString());
			streamWriter.Close();
			fileStream.Close();
			fileStream.Dispose();
		}
		catch (Exception ex)
		{
			BGW_LogUtil.LogError("[RichTextIcon] Export Fail, " + ex.Message);
		}
	}
}
