using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using UnrealEngine.Runtime.Utilities;

namespace UnrealEngine.Runtime;

internal class FileWriterCodeManager : CodeManager
{
	private string modulesSlnPath = "";

	private string modulesProjPath = "";

	private List<string> sourceFileContentList = new List<string>();

	protected override string LogCategory => "FileWriterCodeManager";

	protected override bool UpdateSolutionAndProject(string slnPath, string projPath)
	{
		modulesSlnPath = slnPath;
		modulesProjPath = projPath;
		return base.UpdateSolutionAndProject(slnPath, projPath);
	}

	public override bool CreateSolutionFile(string slnPath)
	{
		return true;
	}

	protected bool CreateSolutionFileFromProjectFile(string slnPath, string projPath, string projName, Guid projectGuid)
	{
		try
		{
			CreateFileDirectoryIfNotExists(slnPath);
			File.WriteAllLines(slnPath, GetSolutionContents(slnPath, projName, projPath, projectGuid));
		}
		catch
		{
			return false;
		}
		return true;
	}

	public override bool AddProjectFile(string slnPath, string projPath)
	{
		new DirectoryInfo(slnPath);
		if (projPath == base.GameProjPath)
		{
			return true;
		}
		try
		{
			CreateFileDirectoryIfNotExists(projPath);
			string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(projPath);
			File.WriteAllLines(projPath, GetProjectFileContents(fileNameWithoutExtension, out var projectGuid));
			string[] solutionContent;
			bool bProjectRefExists;
			if (!File.Exists(slnPath))
			{
				CreateSolutionFileFromProjectFile(slnPath, projPath, fileNameWithoutExtension, projectGuid);
			}
			else if (ReadyToAddNewProjectRef(slnPath, projPath, fileNameWithoutExtension, projectGuid, out solutionContent, out bProjectRefExists))
			{
				UpdateSolutionWithNewProjectFile(slnPath, projPath, fileNameWithoutExtension, projectGuid, solutionContent, bProjectRefExists);
				UpdateGameProjectWithGenReference(projPath, fileNameWithoutExtension, projectGuid);
			}
		}
		catch
		{
			return false;
		}
		return true;
	}

	public override bool AddSourceFile(string slnPath, string projPath, string sourceFilePath, string code)
	{
		if (!File.Exists(slnPath) || !File.Exists(projPath))
		{
			return false;
		}
		CreateFileDirectoryIfNotExists(sourceFilePath);
		File.WriteAllText(sourceFilePath, code);
		try
		{
			if (sourceFileContentList.Count <= 0)
			{
				sourceFileContentList = File.ReadAllLines(projPath).ToList();
			}
			string value = "<ItemGroup>";
			string text = "</Project>";
			int num = -1;
			int num2 = -1;
			int num3 = -1;
			string text2 = "    <Compile Include=\"" + NormalizePath(FPaths.MakePathRelativeTo(sourceFilePath, projPath)) + "\" />";
			for (int i = 0; i < sourceFileContentList.Count; i++)
			{
				if (sourceFileContentList[i].Contains(value))
				{
					num = i;
				}
				if (sourceFileContentList[i].Contains(text2))
				{
					num2 = i;
				}
				if (sourceFileContentList[i].Contains(text) && i > 1)
				{
					num3 = i;
				}
				if (num != -1 && num2 != -1)
				{
					break;
				}
			}
			if (num == -1 && num2 == -1 && num3 != -1 && text.Contains("/") && num3 > 1)
			{
				sourceFileContentList.InsertRange(num3, new string[3] { "  <ItemGroup>", "", "  </ItemGroup>" });
				for (int j = 0; j < sourceFileContentList.Count; j++)
				{
					if (sourceFileContentList[j].Contains(value))
					{
						num = j;
						break;
					}
				}
			}
			if (num != -1 && num2 == -1)
			{
				sourceFileContentList.Insert(num + 1, text2);
			}
		}
		catch (Exception ex)
		{
			Log(ELogVerbosity.Error, ex.Message, ex);
			return false;
		}
		return true;
	}

	protected override void OnBegin()
	{
	}

	protected override void OnEnd()
	{
		if (!File.Exists(modulesProjPath) || !File.Exists(modulesSlnPath) || sourceFileContentList.Count <= 0)
		{
			return;
		}
		try
		{
			Log("Writing To Project File: " + modulesProjPath);
			File.WriteAllLines(modulesProjPath, sourceFileContentList.ToArray());
		}
		catch (Exception ex)
		{
			Log(ELogVerbosity.Error, ex.Message, ex);
		}
		finally
		{
			Log("Done Generating Modules, Solution is at " + modulesSlnPath);
		}
	}

	private bool ReadyToAddNewProjectRef(string slnPath, string projPath, string projectName, Guid projectGUID, out string[] solutionContent, out bool bProjectRefExists)
	{
		bProjectRefExists = false;
		bool flag = false;
		if (!File.Exists(slnPath) || !File.Exists(projPath))
		{
			solutionContent = new string[0];
			return false;
		}
		solutionContent = File.ReadAllLines(slnPath);
		string value = CodeManager.GuidToString(projectGUID);
		string fileNameWithoutExtension = Path.GetFileNameWithoutExtension(base.GameProjPath);
		string[] array = solutionContent;
		foreach (string text in array)
		{
			if (text.Contains(projectName) || text.Contains(value))
			{
				bProjectRefExists = true;
			}
			if (text.Contains(fileNameWithoutExtension))
			{
				flag = true;
			}
		}
		if (flag)
		{
			if (!(projectName == Path.GetFileNameWithoutExtension(base.GameNativeGenerationProjPath)))
			{
				return projectName == Path.GetFileNameWithoutExtension(base.GamePluginGenerationProjPath);
			}
			return true;
		}
		return false;
	}

	private void UpdateGameProjectWithGenReference(string projPath, string projectName, Guid projectGuid)
	{
		if (!File.Exists(base.GameProjPath))
		{
			return;
		}
		List<string> list = File.ReadAllLines(base.GameProjPath).ToList();
		string value = "</Project>";
		int num = -1;
		int num2 = -1;
		string text = NormalizePath(FPaths.MakePathRelativeTo(projPath, base.GameProjPath));
		string text2 = "    <ProjectReference Include=\"" + text + "\">";
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Contains(value) && i > 1)
			{
				num = i;
			}
			if (list[i].Contains(text2))
			{
				num2 = i;
			}
		}
		if (num != -1 && num2 == -1)
		{
			list.InsertRange(num, new string[6]
			{
				"  <ItemGroup>",
				text2,
				"      <Project>{" + CodeManager.GuidToString(projectGuid) + "}</Project>",
				"      <Name>" + Path.GetFileNameWithoutExtension(text) + "</Name>",
				"    </ProjectReference>",
				"  </ItemGroup>"
			});
			File.WriteAllLines(base.GameProjPath, list.ToArray());
		}
	}

	private void UpdateSolutionWithNewProjectFile(string slnPath, string projPath, string projectName, Guid projectGUID, string[] solutionContent, bool bProjectRefExists)
	{
		if (solutionContent.Length == 0)
		{
			return;
		}
		List<string> list = solutionContent.ToList();
		Guid guid = new Guid("FAE04EC0-301F-11D3-BF4B-00C04F79EFBC");
		string text = NormalizePath(FPaths.MakePathRelativeTo(projPath, slnPath));
		string text2 = "Project(\"{" + CodeManager.GuidToString(guid) + "}\") = \"" + projectName + "\", \"" + text + "\", \"{" + CodeManager.GuidToString(projectGUID) + "}\"";
		int num = -1;
		int num2 = -1;
		int num3 = -1;
		if (bProjectRefExists)
		{
			list = ObtainSolutionWithAllOldProjRefsRemoved(list, projectName, projectGUID);
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i].Contains("EndProject"))
			{
				num = i;
			}
			else if (list[i].Contains("EndGlobalSection"))
			{
				num2 = i;
			}
			else if (list[i].Contains(text2))
			{
				num3 = i;
			}
		}
		if (num != -1 && num2 != -1 && num3 == -1)
		{
			string[] collection = new string[2] { text2, "EndProject" };
			list.InsertRange(num + 1, collection);
			File.WriteAllLines(slnPath, list.ToArray());
		}
	}

	private List<string> ObtainSolutionWithAllOldProjRefsRemoved(List<string> slnContent, string projectName, Guid projectGUID)
	{
		string item = CodeManager.GuidToString(projectGUID);
		List<string> list = new List<string>();
		list.Add(item);
		bool flag;
		do
		{
			flag = false;
			string value = null;
			int num = -1;
			bool flag2 = false;
			for (int i = 0; i < slnContent.Count; i++)
			{
				bool flag3 = false;
				foreach (string item2 in list)
				{
					if (slnContent[i].Equals(item2, StringComparison.OrdinalIgnoreCase))
					{
						flag3 = true;
					}
				}
				if (!(slnContent[i].Contains(projectName) || flag3))
				{
					continue;
				}
				value = slnContent[i];
				flag = true;
				num = i;
				if (slnContent[i].Contains(projectName))
				{
					flag2 = false;
					int num2 = slnContent[i].IndexOf("csproj");
					if (num2 != -1)
					{
						string text = SimpleFileParserUtility.ObtainStringFromLine('{', '}', slnContent[i], num2);
						if (!string.IsNullOrEmpty(text))
						{
							list.Add(text);
						}
					}
				}
				else if (flag3)
				{
					flag2 = true;
				}
				break;
			}
			if (flag && !string.IsNullOrEmpty(value) && num != -1)
			{
				if (flag2)
				{
					slnContent.RemoveRange(num, 1);
				}
				else
				{
					slnContent.RemoveRange(num, 2);
				}
			}
		}
		while (flag);
		return slnContent;
	}
}
