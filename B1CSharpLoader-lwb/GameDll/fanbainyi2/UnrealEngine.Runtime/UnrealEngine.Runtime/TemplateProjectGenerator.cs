using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnrealEngine.Runtime;

internal static class TemplateProjectGenerator
{
	private const string targetStandardFramework = "netstandard2.0";

	private const string targetNetFramework = "v4.7.2";

	private static string engineVersion;

	private static string projectName;

	private static string managedProjectName;

	private static string nativeWrappersProjectName;

	private static string pluginBaseDir;

	private static string templatesDir;

	private static string projectDir;

	private static string projectManagedDir;

	private static string projectManagedSln;

	private static string projectManagedCsProjDir;

	private static string projectManagedCsProj;

	private static string projectNativeWrappersCsProj;

	private static string projectManagedPropsFile;

	public static void Generate()
	{
		if (FBuild.WithEditor && !Generate("BasicProject"))
		{
			UpdatePropsFile(firstRun: false);
		}
	}

	private static void UpdatePropsFile(bool firstRun)
	{
		if (!FBuild.WithEditor)
		{
			return;
		}
		GetPaths();
		if (File.Exists(projectManagedPropsFile))
		{
			string propsText = File.ReadAllText(projectManagedPropsFile);
			bool changed = false;
			UpdateTag(ref propsText, ref changed, "UE4Version", engineVersion);
			UpdateTag(ref propsText, ref changed, "UE4ProjectName", projectName);
			UpdateTag(ref propsText, ref changed, "UE4Defines", string.Empty);
			if (firstRun)
			{
				UpdateTag(ref propsText, ref changed, "USharpGameProjects", managedProjectName);
			}
			if (changed)
			{
				File.WriteAllText(projectManagedPropsFile, propsText);
			}
		}
	}

	private static void UpdateTag(ref string propsText, ref bool changed, string tag, string value)
	{
		string text = "<" + tag + ">";
		string value2 = "</" + tag + ">";
		int num = propsText.IndexOf(text);
		int num2 = propsText.IndexOf(value2);
		if (num >= 0 && num2 >= 0)
		{
			num += text.Length;
			int num3 = num2 - num;
			if (propsText.Substring(num, num3).Replace("\r", string.Empty).Replace("\n", string.Empty) != value)
			{
				changed = true;
				propsText = propsText.Remove(num, num3);
				propsText = propsText.Insert(num, value);
			}
		}
		else
		{
			FMessage.Log(ELogVerbosity.Warning, "Props file is missing the tag '" + tag + "'. The C# project may not compile. Props file: '" + projectManagedPropsFile + "'");
		}
	}

	private static bool Generate(string templateName)
	{
		if (!FBuild.WithEditor)
		{
			return false;
		}
		if (templateName.Equals("Shared", StringComparison.OrdinalIgnoreCase))
		{
			return false;
		}
		GetPaths();
		string text = Path.Combine(templatesDir, templateName);
		if (!Directory.Exists(text))
		{
			FMessage.Log(ELogVerbosity.Error, "Couldn't find template '" + templateName + "' to generate the managed project from.");
			return false;
		}
		if (!Directory.Exists(projectManagedDir))
		{
			Directory.CreateDirectory(projectManagedDir);
		}
		if ((File.Exists(projectManagedCsProj) && !File.Exists(projectManagedSln)) || (!File.Exists(projectManagedCsProj) && File.Exists(projectManagedSln)))
		{
			FMessage.Log(ELogVerbosity.Warning, "Found conflicting .sln/.csproj files when attempting to generate a C# project from the template '" + templateName + "'. If you were expecting project files to be generated try deleting the .sln / .csproj and reopen the editor.\nSolution: " + projectManagedSln + "\nProject: " + projectManagedCsProj);
			return false;
		}
		if (!File.Exists(projectManagedCsProj))
		{
			if (!Directory.Exists(projectManagedCsProjDir))
			{
				Directory.CreateDirectory(projectManagedCsProjDir);
			}
			string[] array = new string[2]
			{
				Path.Combine(projectManagedCsProjDir, "obj"),
				Path.Combine(projectManagedCsProjDir, "bin")
			};
			foreach (string path in array)
			{
				try
				{
					if (Directory.Exists(path))
					{
						Directory.Delete(path, recursive: true);
					}
				}
				catch
				{
				}
			}
			array = new string[2]
			{
				Path.Combine(templatesDir, "Shared"),
				text
			};
			foreach (string path2 in array)
			{
				if (!Directory.Exists(path2))
				{
					continue;
				}
				string[] directories = Directory.GetDirectories(path2);
				for (int j = 0; j < directories.Length; j++)
				{
					DirectoryInfo directoryInfo = new DirectoryInfo(directories[j]);
					if (directoryInfo.Name.Equals("Managed", StringComparison.OrdinalIgnoreCase))
					{
						CopyFilesRecursive(directoryInfo, new DirectoryInfo(projectManagedCsProjDir), overwrite: true);
					}
					else
					{
						CopyFilesRecursive(directoryInfo, new DirectoryInfo(Path.Combine(projectDir, directoryInfo.Name)), overwrite: true);
					}
				}
			}
			CopyFile(Path.Combine(templatesDir, "USharpProject.props"), projectManagedPropsFile, overwrite: true);
			Uri uri = new Uri(Path.Combine(projectManagedCsProjDir, "__relative__"), UriKind.Absolute);
			List<string> list = new List<string>();
			array = Directory.GetFiles(projectManagedCsProjDir, "*.cs", SearchOption.AllDirectories);
			foreach (string uriString in array)
			{
				string path3 = uri.MakeRelativeUri(new Uri(uriString, UriKind.Absolute)).ToString();
				list.Add(NormalizePath(path3));
			}
			bool sdkStyle = false;
			Guid solutionGuid = Guid.NewGuid();
			Guid projectGuid = Guid.NewGuid();
			GenerateProjectFile(projectGuid, sdkStyle, list.ToArray());
			GenerateSln(solutionGuid, projectGuid, sdkStyle);
			UpdatePropsFile(firstRun: true);
			return true;
		}
		return false;
	}

	private static void GetPaths()
	{
		engineVersion = FBuild.EngineMajorVersion + "." + FBuild.EngineMinorVersion;
		projectName = FApp.GetProjectName();
		managedProjectName = projectName + ".Managed";
		nativeWrappersProjectName = projectName + ".Native";
		pluginBaseDir = Path.GetFullPath(Path.Combine(Path.GetDirectoryName(FModuleManager.Instance.GetModuleFilename((FName)"USharp")), "..", ".."));
		templatesDir = Path.Combine(pluginBaseDir, "Managed", "Templates");
		projectDir = Path.GetFullPath(FPaths.ProjectDir);
		projectManagedDir = Path.Combine(projectDir, "Managed");
		projectManagedSln = Path.Combine(projectManagedDir, managedProjectName + ".sln");
		projectManagedCsProjDir = Path.Combine(projectManagedDir, managedProjectName);
		projectManagedCsProj = Path.Combine(projectManagedCsProjDir, managedProjectName + ".csproj");
		projectNativeWrappersCsProj = Path.Combine(projectManagedDir, nativeWrappersProjectName, nativeWrappersProjectName + ".csproj");
		projectManagedPropsFile = Path.Combine(projectManagedDir, "USharpProject.props");
		string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "USharp", "UE_" + engineVersion + ".txt");
		if (!File.Exists(path) || File.ReadAllText(path) != pluginBaseDir)
		{
			File.WriteAllText(path, pluginBaseDir);
		}
	}

	private static void GenerateSln(Guid solutionGuid, Guid projectGuid, bool sdkStyle)
	{
		Guid guid = (sdkStyle ? Guid.Parse("9A19103F-16F7-4668-BE54-9A1E7A4F7556") : Guid.Parse("FAE04EC0-301F-11D3-BF4B-00C04F79EFBC"));
		string text = managedProjectName + "\\" + managedProjectName + ".csproj";
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.AppendLine("Microsoft Visual Studio Solution File, Format Version 12.00");
		stringBuilder.AppendLine("# Visual Studio 15");
		stringBuilder.AppendLine("VisualStudioVersion = 15.0.28010.2046");
		stringBuilder.AppendLine("MinimumVisualStudioVersion = 10.0.40219.1");
		stringBuilder.AppendLine("Project(\"{" + GuidToString(guid) + "}\") = \"" + managedProjectName + "\", \"" + text + "\", \"{" + GuidToString(projectGuid) + "}\"");
		stringBuilder.AppendLine("EndProject");
		stringBuilder.AppendLine("Global");
		stringBuilder.AppendLine("\tGlobalSection(SolutionConfigurationPlatforms) = preSolution");
		stringBuilder.AppendLine("\t\tDebug|Any CPU = Debug|Any CPU");
		stringBuilder.AppendLine("\t\tRelease|Any CPU = Release|Any CPU");
		stringBuilder.AppendLine("\tEndGlobalSection");
		stringBuilder.AppendLine("\tGlobalSection(ProjectConfigurationPlatforms) = postSolution");
		stringBuilder.AppendLine("\t\t{" + GuidToString(projectGuid) + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU");
		stringBuilder.AppendLine("\t\t{" + GuidToString(projectGuid) + "}.Debug|Any CPU.Build.0 = Debug|Any CPU");
		stringBuilder.AppendLine("\t\t{" + GuidToString(projectGuid) + "}.Release|Any CPU.ActiveCfg = Release|Any CPU");
		stringBuilder.AppendLine("\t\t{" + GuidToString(projectGuid) + "}.Release|Any CPU.Build.0 = Release|Any CPU");
		stringBuilder.AppendLine("\tEndGlobalSection");
		stringBuilder.AppendLine("\tGlobalSection(SolutionProperties) = preSolution");
		stringBuilder.AppendLine("\t\tHideSolutionNode = FALSE");
		stringBuilder.AppendLine("\tEndGlobalSection");
		stringBuilder.AppendLine("\tGlobalSection(ExtensibilityGlobals) = postSolution");
		stringBuilder.AppendLine("\t\tSolutionGuid = {" + GuidToString(solutionGuid) + "}");
		stringBuilder.AppendLine("\tEndGlobalSection");
		stringBuilder.AppendLine("EndGlobal");
		File.WriteAllText(projectManagedSln, stringBuilder.ToString());
	}

	private static void GenerateProjectFile(Guid projectGuid, bool sdkStyle, string[] sourceFiles)
	{
		StringBuilder stringBuilder = new StringBuilder();
		if (sdkStyle)
		{
			stringBuilder.AppendLine("<Project Sdk=\"Microsoft.NET.Sdk\">");
			stringBuilder.AppendLine("  <Import Project=\"$(SolutionDir)\\USharpProject.props\"/>");
			stringBuilder.AppendLine("  <PropertyGroup>");
			stringBuilder.AppendLine("    <TargetFramework>netstandard2.0</TargetFramework>");
			stringBuilder.AppendLine("    <DebugType>pdbonly</DebugType>");
			stringBuilder.AppendLine("    <DebugSymbols>true</DebugSymbols>");
			stringBuilder.AppendLine("    <OutputPath>$(OutDir)</OutputPath>");
			stringBuilder.AppendLine("    <AssemblyName>" + managedProjectName + "</AssemblyName>");
			stringBuilder.AppendLine("  </PropertyGroup>");
			stringBuilder.AppendLine("</Project>");
		}
		else
		{
			stringBuilder.AppendLine("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
			stringBuilder.AppendLine("<Project ToolsVersion=\"15.0\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">");
			stringBuilder.AppendLine("  <Import Project=\"$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props\" Condition=\"Exists('$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props')\" />");
			stringBuilder.AppendLine("  <Import Project=\"$(SolutionDir)\\USharpProject.props\"/>");
			stringBuilder.AppendLine("  <PropertyGroup>");
			stringBuilder.AppendLine("    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>");
			stringBuilder.AppendLine("    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>");
			stringBuilder.AppendLine("    <ProjectGuid>{" + GuidToString(projectGuid) + "}</ProjectGuid>");
			stringBuilder.AppendLine("    <OutputType>Library</OutputType>");
			stringBuilder.AppendLine("    <RootNamespace>" + projectName + "</RootNamespace>");
			stringBuilder.AppendLine("    <TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>");
			stringBuilder.AppendLine("  </PropertyGroup>");
			stringBuilder.AppendLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Debug|AnyCPU' \">");
			stringBuilder.AppendLine("    <DebugSymbols>true</DebugSymbols>");
			stringBuilder.AppendLine("    <DebugType>full</DebugType>");
			stringBuilder.AppendLine("    <Optimize>false</Optimize>");
			stringBuilder.AppendLine("    <OutputPath>$(OutDir)</OutputPath>");
			stringBuilder.AppendLine("    <AssemblyName>" + managedProjectName + "</AssemblyName>");
			stringBuilder.AppendLine("    <ErrorReport>prompt</ErrorReport>");
			stringBuilder.AppendLine("    <DefineConstants>DEBUG;TRACE</DefineConstants>");
			stringBuilder.AppendLine("    <ErrorReport>prompt</ErrorReport>");
			stringBuilder.AppendLine("    <WarningLevel>4</WarningLevel>");
			stringBuilder.AppendLine("  </PropertyGroup>");
			stringBuilder.AppendLine("  <PropertyGroup Condition=\" '$(Configuration)|$(Platform)' == 'Release|AnyCPU' \">");
			stringBuilder.AppendLine("    <DebugType>pdbonly</DebugType>");
			stringBuilder.AppendLine("    <Optimize>true</Optimize>");
			stringBuilder.AppendLine("    <OutputPath>$(OutDir)</OutputPath>");
			stringBuilder.AppendLine("    <AssemblyName>" + managedProjectName + "</AssemblyName>");
			stringBuilder.AppendLine("    <DefineConstants>TRACE</DefineConstants>");
			stringBuilder.AppendLine("    <ErrorReport>prompt</ErrorReport>");
			stringBuilder.AppendLine("    <WarningLevel>4</WarningLevel>");
			stringBuilder.AppendLine("  </PropertyGroup>");
			stringBuilder.AppendLine("  <ItemGroup>");
			stringBuilder.AppendLine("    <Reference Include=\"System\" />");
			stringBuilder.AppendLine("  </ItemGroup>");
			stringBuilder.AppendLine("  <ItemGroup>");
			foreach (string text in sourceFiles)
			{
				stringBuilder.AppendLine("    <Compile Include=\"" + text + "\" />");
			}
			stringBuilder.AppendLine("  </ItemGroup>");
			stringBuilder.AppendLine("  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />");
			stringBuilder.AppendLine("</Project>");
		}
		File.WriteAllText(projectManagedCsProj, stringBuilder.ToString());
	}

	private static string NormalizePath(string path)
	{
		return path.Replace('/', '\\');
	}

	private static string GuidToString(Guid guid)
	{
		return guid.ToString().ToUpper();
	}

	internal static void CopyFiles(DirectoryInfo source, DirectoryInfo target, bool overwrite)
	{
		CopyFiles(source, target, overwrite, recursive: false);
	}

	internal static void CopyFiles(DirectoryInfo source, DirectoryInfo target, bool overwrite, bool recursive)
	{
		if (!target.Exists)
		{
			target.Create();
		}
		if (recursive)
		{
			DirectoryInfo[] directories = source.GetDirectories();
			foreach (DirectoryInfo directoryInfo in directories)
			{
				CopyFilesRecursive(directoryInfo, target.CreateSubdirectory(directoryInfo.Name), overwrite);
			}
		}
		FileInfo[] files = source.GetFiles();
		foreach (FileInfo fileInfo in files)
		{
			CopyFile(fileInfo.FullName, Path.Combine(target.FullName, fileInfo.Name), overwrite);
		}
	}

	private static void CopyFilesRecursive(DirectoryInfo source, DirectoryInfo target, bool overwrite)
	{
		CopyFiles(source, target, overwrite, recursive: true);
	}

	private static void CopyFile(string sourceFileName, string destFileName, bool overwrite)
	{
		if ((overwrite || !File.Exists(destFileName)) && File.Exists(sourceFileName))
		{
			try
			{
				File.Copy(sourceFileName, destFileName, overwrite);
			}
			catch
			{
				Console.WriteLine("Failed to copy to '{0}'", destFileName);
			}
		}
	}
}
