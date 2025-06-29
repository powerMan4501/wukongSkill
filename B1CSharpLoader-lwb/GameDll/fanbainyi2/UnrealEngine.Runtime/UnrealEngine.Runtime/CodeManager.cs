using System;
using System.Collections.Generic;
using System.IO;

namespace UnrealEngine.Runtime;

internal abstract class CodeManager
{
	public CodeGenerator CodeGenerator { get; private set; }

	public CodeGeneratorSettings Settings => CodeGenerator.Settings;

	public string GameSlnPath { get; private set; }

	public string GameProjPath { get; private set; }

	public string GameNativeGenerationProjPath { get; private set; }

	public string GamePluginGenerationProjPath { get; private set; }

	protected virtual string LogCategory => "CodeManager";

	public static CodeManager Create(CodeGenerator codeGenerator)
	{
		CodeManager codeManager = null;
		FPlatformProperties.GetPlatform();
		_ = 1;
		codeManager = new FileWriterCodeManager();
		if (codeManager != null)
		{
			codeManager.CodeGenerator = codeGenerator;
		}
		return codeManager;
	}

	public void OnBeginGenerateModules()
	{
		Settings.GetProjectName();
		string projectName = Settings.GetProjectName();
		GameSlnPath = Path.Combine(Settings.GetManagedDir(), projectName + ".Managed.sln");
		GameProjPath = Path.Combine(Settings.GetManagedDir(), projectName + ".Managed", projectName + ".Managed.csproj");
		GameNativeGenerationProjPath = Path.Combine(Settings.GetManagedDir(), projectName + ".Native", projectName + ".Native.csproj");
		GamePluginGenerationProjPath = Path.Combine(Settings.GetManagedDir(), projectName + ".NativePlugins", projectName + ".NativePlugins.csproj");
		OnBegin();
	}

	public void OnEndGenerateModules()
	{
		OnEnd();
	}

	protected virtual void OnBegin()
	{
	}

	protected virtual void OnEnd()
	{
	}

	public void OnCodeGenerated(CodeGenerator.UnrealModuleInfo module, UnrealModuleType moduleAssetType, string typeName, string path, string code)
	{
		FPackageName.GetPathInfo(path, out var pathRoot, out var directory, out var _, out var objectName, out var _);
		string rootFolderName = GetRootFolderName(path, pathRoot, module.Type, moduleAssetType);
		if (string.IsNullOrEmpty(rootFolderName) && !string.IsNullOrEmpty(path))
		{
			Log(ELogVerbosity.Error, "Unknown asset root '{0}' ModuleType:'{1}' ModuleAssetType:'{2}' Path:'{3}'", pathRoot, module.Type, moduleAssetType, path);
			return;
		}
		string text = ((Settings.UseTypeNameAsSourceFileName || string.IsNullOrEmpty(objectName)) ? typeName : objectName);
		string text2 = null;
		string text3 = null;
		string text4 = null;
		switch (module.Type)
		{
		case UnrealModuleType.Game:
		{
			string text6 = null;
			text6 = ((!EmulateGameFolderStructure(moduleAssetType)) ? (text + ".cs") : Path.Combine(directory, text + ".cs"));
			text2 = ((moduleAssetType != UnrealModuleType.Unknown) ? Path.Combine(Settings.GetGeneratedCodeDir(isPlugin: false), rootFolderName, text6) : Path.Combine(Settings.GetGeneratedCodeDir(isPlugin: false), text6));
			text4 = GameSlnPath;
			text3 = GameNativeGenerationProjPath;
			break;
		}
		case UnrealModuleType.Engine:
		case UnrealModuleType.EnginePlugin:
		{
			bool flag = false;
			bool flag2 = false;
			switch (Settings.EngineProjMerge)
			{
			case CodeGeneratorSettings.ManagedEngineProjMerge.Engine:
				if (module.Type == UnrealModuleType.Engine)
				{
					flag2 = true;
				}
				break;
			case CodeGeneratorSettings.ManagedEngineProjMerge.Plugins:
				if (module.Type == UnrealModuleType.EnginePlugin)
				{
					flag = true;
				}
				break;
			case CodeGeneratorSettings.ManagedEngineProjMerge.EngineAndPlugins:
				if (module.Type == UnrealModuleType.EnginePlugin)
				{
					flag = true;
				}
				else
				{
					flag2 = true;
				}
				break;
			case CodeGeneratorSettings.ManagedEngineProjMerge.EngineAndPluginsCombined:
				flag2 = true;
				break;
			}
			if (flag || flag2)
			{
				string text5 = (flag2 ? "UnrealEngine.csproj" : "UnrealEngine.Plugins.csproj");
				text3 = ((Settings.EngineProjMerge != CodeGeneratorSettings.ManagedEngineProjMerge.EngineAndPluginsCombined) ? Path.Combine(Settings.GetManagedModulesDir(), rootFolderName, text5) : Path.Combine(Settings.GetManagedModulesDir(), text5));
			}
			else
			{
				text3 = Path.Combine(Settings.GetManagedModulesDir(), rootFolderName, module.Name, module.Name + ".csproj");
			}
			text2 = Path.Combine(Settings.GetManagedModulesDir(), rootFolderName, module.Name, text + ".cs");
			if (Settings.ModulesLocation == CodeGeneratorSettings.ManagedModulesLocation.GameFolderCombineSln)
			{
				text4 = GameSlnPath;
			}
			else if (Settings.ModulesLocation == CodeGeneratorSettings.ManagedModulesLocation.GameFolderCombineSlnProj)
			{
				text4 = GameSlnPath;
				text3 = GameProjPath;
			}
			else
			{
				text4 = Path.Combine(Settings.GetManagedModulesDir(), "UnrealEngine.sln");
			}
			break;
		}
		case UnrealModuleType.GamePlugin:
			text2 = ((moduleAssetType != UnrealModuleType.Unknown) ? Path.Combine(Settings.GetGeneratedCodeDir(isPlugin: true), rootFolderName, module.Name, text + ".cs") : Path.Combine(Settings.GetGeneratedCodeDir(isPlugin: true), module.Name, text + ".cs"));
			text4 = GameSlnPath;
			text3 = ((Settings.GameProjMerge != CodeGeneratorSettings.ManagedGameProjMerge.GameAndPlugins) ? ((Settings.GameProjMerge != CodeGeneratorSettings.ManagedGameProjMerge.Plugins) ? Path.Combine(Settings.GetManagedDir(), rootFolderName, module.Name, module.Name + ".csproj") : GamePluginGenerationProjPath) : GameNativeGenerationProjPath);
			break;
		}
		if (!string.IsNullOrWhiteSpace(text2))
		{
			text2 = Path.GetFullPath(text2);
		}
		if (!string.IsNullOrWhiteSpace(text3))
		{
			text3 = Path.GetFullPath(text3);
		}
		if (!string.IsNullOrWhiteSpace(text4))
		{
			text4 = Path.GetFullPath(text4);
		}
		if (string.IsNullOrWhiteSpace(text2) || string.IsNullOrWhiteSpace(text3) || string.IsNullOrWhiteSpace(text4))
		{
			Log(ELogVerbosity.Error, "Unknown output location for '{0}' '{1}'", typeName, path);
			return;
		}
		if (!ValidateOutputPath(text2) || !ValidateOutputPath(text3) || !ValidateOutputPath(text4))
		{
			Log(ELogVerbosity.Error, "Invalid output path '{0}'", text2);
			return;
		}
		try
		{
			if (UpdateSolutionAndProject(text4, text3))
			{
				if (!AddSourceFile(text4, text3, text2, code))
				{
					Log(ELogVerbosity.Error, "Failed to add source file '{0}'", text2);
				}
			}
			else
			{
				Log(ELogVerbosity.Error, "Failed to create sln/csproj '{0}' '{1}'", text4, text3);
			}
		}
		catch (Exception ex)
		{
			Log(ELogVerbosity.Error, "Exception when adding source file '{0}' {1}", text2, ex);
		}
	}

	protected string GetRootFolderName(string path, string root, UnrealModuleType moduleType, UnrealModuleType moduleAssetType)
	{
		switch (moduleType)
		{
		case UnrealModuleType.Game:
			return moduleAssetType switch
			{
				UnrealModuleType.Game => "Game", 
				UnrealModuleType.Engine => Path.Combine("EngineAssets"), 
				UnrealModuleType.EnginePlugin => Path.Combine("EnginePluginAssets", root), 
				UnrealModuleType.GamePlugin => Path.Combine("GamePluginAssets", root), 
				_ => "Game", 
			};
		case UnrealModuleType.Engine:
			return "Engine";
		case UnrealModuleType.EnginePlugin:
			if (Settings.ModulesLocation == CodeGeneratorSettings.ManagedModulesLocation.ModulesFolder)
			{
				return "Plugins";
			}
			return "EnginePlugins";
		case UnrealModuleType.GamePlugin:
			return "GamePlugins";
		default:
			return null;
		}
	}

	private bool EmulateGameFolderStructure(UnrealModuleType moduleAssetType)
	{
		return moduleAssetType switch
		{
			UnrealModuleType.Game => Settings.FolderEmulation.Game, 
			UnrealModuleType.GamePlugin => Settings.FolderEmulation.GamePluginAssets, 
			UnrealModuleType.Engine => Settings.FolderEmulation.EngineAssets, 
			UnrealModuleType.EnginePlugin => Settings.FolderEmulation.EnginePluginAssets, 
			_ => false, 
		};
	}

	public virtual bool CreateSolutionFile(string slnPath)
	{
		return true;
	}

	public virtual bool AddProjectFile(string slnPath, string projPath)
	{
		return true;
	}

	public virtual bool AddSourceFile(string slnPath, string projPath, string sourceFilePath, string code)
	{
		return true;
	}

	protected virtual bool UpdateSolutionAndProject(string slnPath, string projPath)
	{
		if (!File.Exists(slnPath) && !CreateSolutionFile(slnPath))
		{
			return false;
		}
		if (!File.Exists(projPath) && !AddProjectFile(slnPath, projPath))
		{
			return false;
		}
		return true;
	}

	protected void CreateFileDirectoryIfNotExists(string path)
	{
		string directoryName = Path.GetDirectoryName(path);
		try
		{
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
		}
		catch
		{
		}
	}

	protected bool CreateFileIfNotExists(string path)
	{
		if (!File.Exists(path))
		{
			CreateFileDirectoryIfNotExists(path);
			try
			{
				File.CreateText(path).Close();
			}
			catch
			{
				return false;
			}
		}
		return true;
	}

	private bool ValidateOutputPath(string path)
	{
		if (FPaths.IsFileInDirectoryOrSubDirectory(path, Settings.GetManagedDir()))
		{
			return true;
		}
		if (FPaths.IsFileInDirectoryOrSubDirectory(path, Settings.GetManagedModulesDir()))
		{
			return true;
		}
		return false;
	}

	protected virtual string[] GetProjectFileContents(string projectName, out Guid projectGuid)
	{
		string text = ((Settings.EngineProjMerge == CodeGeneratorSettings.ManagedEngineProjMerge.EngineAndPluginsCombined) ? "..\\UnrealEngine.Runtime.dll" : "..\\..\\..\\UnrealEngine.Runtime.dll");
		bool flag = projectName == Path.GetFileNameWithoutExtension(GameProjPath) || projectName == Path.GetFileNameWithoutExtension(GameNativeGenerationProjPath) || projectName == Path.GetFileNameWithoutExtension(GamePluginGenerationProjPath);
		projectGuid = Guid.NewGuid();
		List<string> list = new List<string> { "<?xml version=\"1.0\" encoding=\"utf-8\"?>", "<Project ToolsVersion=\"15.0\" DefaultTargets=\"Build\" xmlns=\"http://schemas.microsoft.com/developer/msbuild/2003\">", "  <Import Project=\"$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props\" Condition=\"Exists('$(MSBuildExtensionsPath)\\$(MSBuildToolsVersion)\\Microsoft.Common.props')\" />" };
		if (flag)
		{
			list.Add("  <Import Project=\"$(SolutionDir)\\USharpProject.props\"/>");
		}
		list.AddRange(new string[14]
		{
			"  <PropertyGroup>",
			"    <Configuration Condition=\" '$(Configuration)' == '' \">Debug</Configuration>",
			"    <Platform Condition=\" '$(Platform)' == '' \">AnyCPU</Platform>",
			"    <ProjectGuid>{" + GuidToString(projectGuid) + "}</ProjectGuid>",
			"    <OutputType>Library</OutputType>",
			"    <OutputPath>bin\\$(Configuration)\\</OutputPath>",
			"    <RootNamespace>" + projectName + "</RootNamespace>",
			"    <AssemblyName>" + projectName + "</AssemblyName>",
			"    <TargetFrameworkVersion>v4.7.2</TargetFrameworkVersion>",
			"    <AllowUnsafeBlocks>true</AllowUnsafeBlocks>",
			"    <Optimize>true</Optimize>",
			"  </PropertyGroup>",
			"  <ItemGroup>",
			"    <Reference Include=\"System\" />"
		});
		if (!flag)
		{
			list.AddRange(new string[4]
			{
				"    <PackageReference Include=\"System.Memory\" Version=\"4.5.4\" />",
				"    <Reference Include=\"UnrealEngine.Runtime\">",
				"      <HintPath>" + text + "</HintPath>",
				"    </Reference>"
			});
		}
		list.AddRange(new string[3] { "  </ItemGroup>", "  <Import Project=\"$(MSBuildToolsPath)\\Microsoft.CSharp.targets\" />", "</Project>" });
		return list.ToArray();
	}

	protected string[] GetSolutionContents(string slnPath, string projName, string projPath, Guid projectGuid)
	{
		string text = NormalizePath(FPaths.MakePathRelativeTo(projPath, slnPath));
		Guid guid = new Guid("FAE04EC0-301F-11D3-BF4B-00C04F79EFBC");
		Guid guid2 = Guid.NewGuid();
		return new string[21]
		{
			"Microsoft Visual Studio Solution File, Format Version 12.00",
			"# Visual Studio 15",
			"VisualStudioVersion = 15.0.28010.2041",
			"MinimumVisualStudioVersion = 10.0.40219.1",
			"Project(\"{" + GuidToString(guid) + "}\") = \"" + projName + "\", \"" + text + "\", \"{" + GuidToString(projectGuid) + "}\"",
			"EndProject",
			"Global",
			"\tGlobalSection(SolutionConfigurationPlatforms) = preSolution",
			"\t\tDebug|Any CPU = Debug|Any CPU",
			"\tEndGlobalSection",
			"\tGlobalSection(ProjectConfigurationPlatforms) = postSolution",
			"\t\t{" + GuidToString(projectGuid) + "}.Debug|Any CPU.ActiveCfg = Debug|Any CPU",
			"\t\t{" + GuidToString(projectGuid) + "}.Debug|Any CPU.Build.0 = Debug|Any CPU",
			"\tEndGlobalSection",
			"\tGlobalSection(SolutionProperties) = preSolution",
			"\t\tHideSolutionNode = FALSE",
			"\tEndGlobalSection",
			"\tGlobalSection(ExtensibilityGlobals) = postSolution",
			"\t\tSolutionGuid = {" + GuidToString(guid2) + "}",
			"\tEndGlobalSection",
			"EndGlobal"
		};
	}

	protected string NormalizePath(string path)
	{
		return path.Replace('/', '\\');
	}

	protected static string GuidToString(Guid guid)
	{
		return guid.ToString().ToUpper();
	}

	protected void Log(string value, params object[] args)
	{
		Log(ELogVerbosity.Log, value, args);
	}

	protected void Log(ELogVerbosity verbosity, string value, params object[] args)
	{
		FMessage.Log(LogCategory, verbosity, string.Format(value, args));
	}
}
