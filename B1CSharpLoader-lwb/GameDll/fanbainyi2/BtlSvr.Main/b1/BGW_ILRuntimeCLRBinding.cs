using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using ILRuntime.Runtime.CLRBinding;
using ILRuntime.Runtime.Enviorment;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_ILRuntimeCLRBinding")]
public class BGW_ILRuntimeCLRBinding : UObject
{
	private static bool GenerateClrBindingCode_AutoTest_IsValid;

	private static IntPtr GenerateClrBindingCode_AutoTest_FunctionAddress;

	private static int GenerateClrBindingCode_AutoTest_ParamsSize;

	private static bool GenerateClrBindingCode_AutoTest_bClrbinding_IsValid;

	private static int GenerateClrBindingCode_AutoTest_bClrbinding_Offset;

	public static void GenerateClrBindingCode(int bClrbinding)
	{
		ILRuntime.Runtime.Enviorment.AppDomain appDomain = new ILRuntime.Runtime.Enviorment.AppDomain();
		BGW_ILRuntimeMgr.LoadAssemblyFileForClrbinding(appDomain, bClrbinding);
		BGW_ILRuntimeMgr.RegisterCrossBinding(appDomain);
		List<string> list = new List<string>();
		list.Add("b1_EventDebugger_GSEventDebugger");
		string outputPath = USystemLibrary.GetProjectDirectory().Replace("/", "\\") + "\\Managed\\BtlSvr.Main\\Util\\ILRuntime\\AutoGenClrbinding\\";
		try
		{
			BindingCodeGenerator.GenerateBindingCode(appDomain, outputPath, null, null, 10, list);
			MarkForSuccess();
		}
		catch (Exception arg)
		{
			BGW_LogUtil.LogError($"{arg}");
		}
		appDomain = null;
	}

	public static void RefreshAndCommitCode()
	{
		string projectDir = FPaths.ProjectDir;
		using Process process = new Process();
		process.StartInfo.FileName = Path.Combine(projectDir, "Tools/ClrbindingGen/refreshProject.bat");
		process.StartInfo.UseShellExecute = false;
		process.Start();
	}

	public static void ClearClrbindingCode()
	{
		string projectDir = FPaths.ProjectDir;
		using Process process = new Process();
		process.StartInfo.FileName = Path.Combine(projectDir, "Tools/ClrbindingGen/ClearClrbinding.bat");
		process.StartInfo.UseShellExecute = false;
		process.Start();
	}

	public static void PreGenBindingCode()
	{
		string projectDir = FPaths.ProjectDir;
		using Process process = new Process();
		process.StartInfo.FileName = Path.Combine(projectDir, "Tools/ClrbindingGen/PreGen.bat");
		process.StartInfo.UseShellExecute = false;
		process.Start();
	}

	private static void MarkForSuccess()
	{
		string text = Path.Combine(Path.GetTempPath(), "clrbinding.txt");
		try
		{
			using (StreamWriter streamWriter = File.CreateText(text))
			{
				streamWriter.WriteLine("mark");
			}
			Console.WriteLine("File created successfully at: " + text);
		}
		catch (Exception ex)
		{
			Console.WriteLine("An error occurred: " + ex.Message);
		}
	}

	[UFunction]
	[BlueprintCallable]
	[Category("CLRBindingGen")]
	[USharpPath("/Script/b1-Managed.BGW_ILRuntimeCLRBinding:GenerateClrBindingCode_AutoTest")]
	public static void GenerateClrBindingCode_AutoTest(int bClrbinding)
	{
		GenerateClrBindingCode(bClrbinding);
		RefreshAndCommitCode();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_ILRuntimeCLRBinding:GenerateClrBindingCode_AutoTest")]
	private static void GenerateClrBindingCode_AutoTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		int bClrbinding = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(buffer, GenerateClrBindingCode_AutoTest_bClrbinding_Offset));
		GenerateClrBindingCode_AutoTest(bClrbinding);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGW_ILRuntimeCLRBinding");
		GenerateClrBindingCode_AutoTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GenerateClrBindingCode_AutoTest");
		GenerateClrBindingCode_AutoTest_ParamsSize = NativeReflection.GetFunctionParamsSize(GenerateClrBindingCode_AutoTest_FunctionAddress);
		GenerateClrBindingCode_AutoTest_bClrbinding_Offset = NativeReflection.GetPropertyOffset(GenerateClrBindingCode_AutoTest_FunctionAddress, "bClrbinding");
		GenerateClrBindingCode_AutoTest_bClrbinding_IsValid = NativeReflection.ValidatePropertyClass(GenerateClrBindingCode_AutoTest_FunctionAddress, "bClrbinding", Classes.FIntProperty);
		GenerateClrBindingCode_AutoTest_IsValid = GenerateClrBindingCode_AutoTest_FunctionAddress != IntPtr.Zero && GenerateClrBindingCode_AutoTest_bClrbinding_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_ILRuntimeCLRBinding:GenerateClrBindingCode_AutoTest", GenerateClrBindingCode_AutoTest_IsValid);
	}

	static BGW_ILRuntimeCLRBinding()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_ILRuntimeCLRBinding)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_ILRuntimeCLRBinding));
	}
}
