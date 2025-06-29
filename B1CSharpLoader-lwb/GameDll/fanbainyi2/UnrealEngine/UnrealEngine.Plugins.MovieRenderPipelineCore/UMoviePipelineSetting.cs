using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[Abstract]
[UClass(Flags = (ClassFlags)810549409uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineSetting : UObject
{
	private static bool BuildNewProcessCommandLineArgs_IsValid;

	private static IntPtr BuildNewProcessCommandLineArgs_FunctionAddress;

	private static int BuildNewProcessCommandLineArgs_ParamsSize;

	private static bool BuildNewProcessCommandLineArgs_InOutUnrealURLParams_IsValid;

	private static FFieldAddress BuildNewProcessCommandLineArgs_InOutUnrealURLParams_PropertyAddress;

	private static int BuildNewProcessCommandLineArgs_InOutUnrealURLParams_Offset;

	private static bool BuildNewProcessCommandLineArgs_InOutCommandLineArgs_IsValid;

	private static FFieldAddress BuildNewProcessCommandLineArgs_InOutCommandLineArgs_PropertyAddress;

	private static int BuildNewProcessCommandLineArgs_InOutCommandLineArgs_Offset;

	private static bool BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_IsValid;

	private static FFieldAddress BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_PropertyAddress;

	private static int BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_Offset;

	private static bool BuildNewProcessCommandLineArgs_InOutExecCmds_IsValid;

	private static FFieldAddress BuildNewProcessCommandLineArgs_InOutExecCmds_PropertyAddress;

	private static int BuildNewProcessCommandLineArgs_InOutExecCmds_Offset;

	private static bool BuildNewProcessCommandLine_IsValid;

	private static IntPtr BuildNewProcessCommandLine_FunctionAddress;

	private static int BuildNewProcessCommandLine_ParamsSize;

	private static bool BuildNewProcessCommandLine_InOutUnrealURLParams_IsValid;

	private static FFieldAddress BuildNewProcessCommandLine_InOutUnrealURLParams_PropertyAddress;

	private static int BuildNewProcessCommandLine_InOutUnrealURLParams_Offset;

	private static bool BuildNewProcessCommandLine_InOutCommandLineArgs_IsValid;

	private static FFieldAddress BuildNewProcessCommandLine_InOutCommandLineArgs_PropertyAddress;

	private static int BuildNewProcessCommandLine_InOutCommandLineArgs_Offset;

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting:BuildNewProcessCommandLineArgs")]
	public unsafe void BuildNewProcessCommandLineArgs(ref List<string> InOutUnrealURLParams, ref List<string> InOutCommandLineArgs, ref List<string> InOutDeviceProfileCvars, ref List<string> InOutExecCmds)
	{
		CheckDestroyed();
		if (!BuildNewProcessCommandLineArgs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting:BuildNewProcessCommandLineArgs");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildNewProcessCommandLineArgs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildNewProcessCommandLineArgs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler = new TArrayCopyMarshaler<string>(1, BuildNewProcessCommandLineArgs_InOutUnrealURLParams_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		tArrayCopyMarshaler.ToNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutUnrealURLParams_Offset), InOutUnrealURLParams);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler2 = new TArrayCopyMarshaler<string>(1, BuildNewProcessCommandLineArgs_InOutCommandLineArgs_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		tArrayCopyMarshaler2.ToNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutCommandLineArgs_Offset), InOutCommandLineArgs);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler3 = new TArrayCopyMarshaler<string>(1, BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		tArrayCopyMarshaler3.ToNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_Offset), InOutDeviceProfileCvars);
		TArrayCopyMarshaler<string> tArrayCopyMarshaler4 = new TArrayCopyMarshaler<string>(1, BuildNewProcessCommandLineArgs_InOutExecCmds_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
		tArrayCopyMarshaler4.ToNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutExecCmds_Offset), InOutExecCmds);
		NativeReflection.InvokeFunctionOptimized(base.Address, BuildNewProcessCommandLineArgs_FunctionAddress, intPtr, BuildNewProcessCommandLineArgs_ParamsSize);
		InOutUnrealURLParams = tArrayCopyMarshaler.FromNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutUnrealURLParams_Offset));
		NativeReflection.DestroyValue_InContainer(BuildNewProcessCommandLineArgs_InOutUnrealURLParams_PropertyAddress.Address, intPtr);
		InOutCommandLineArgs = tArrayCopyMarshaler2.FromNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutCommandLineArgs_Offset));
		NativeReflection.DestroyValue_InContainer(BuildNewProcessCommandLineArgs_InOutCommandLineArgs_PropertyAddress.Address, intPtr);
		InOutDeviceProfileCvars = tArrayCopyMarshaler3.FromNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_Offset));
		NativeReflection.DestroyValue_InContainer(BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_PropertyAddress.Address, intPtr);
		InOutExecCmds = tArrayCopyMarshaler4.FromNative(IntPtr.Add(intPtr, BuildNewProcessCommandLineArgs_InOutExecCmds_Offset));
		NativeReflection.DestroyValue_InContainer(BuildNewProcessCommandLineArgs_InOutExecCmds_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineSetting:BuildNewProcessCommandLine")]
	public unsafe void BuildNewProcessCommandLine(ref string InOutUnrealURLParams, ref string InOutCommandLineArgs)
	{
		CheckDestroyed();
		if (!BuildNewProcessCommandLine_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineSetting:BuildNewProcessCommandLine");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BuildNewProcessCommandLine_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BuildNewProcessCommandLine_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildNewProcessCommandLine_InOutUnrealURLParams_Offset), 0, BuildNewProcessCommandLine_InOutUnrealURLParams_PropertyAddress.Address, InOutUnrealURLParams);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, BuildNewProcessCommandLine_InOutCommandLineArgs_Offset), 0, BuildNewProcessCommandLine_InOutCommandLineArgs_PropertyAddress.Address, InOutCommandLineArgs);
		NativeReflection.InvokeFunctionOptimized(base.Address, BuildNewProcessCommandLine_FunctionAddress, intPtr, BuildNewProcessCommandLine_ParamsSize);
		InOutUnrealURLParams = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildNewProcessCommandLine_InOutUnrealURLParams_Offset), 0, BuildNewProcessCommandLine_InOutUnrealURLParams_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildNewProcessCommandLine_InOutUnrealURLParams_PropertyAddress.Address, intPtr);
		InOutCommandLineArgs = FStringMarshaler.FromNative(IntPtr.Add(intPtr, BuildNewProcessCommandLine_InOutCommandLineArgs_Offset), 0, BuildNewProcessCommandLine_InOutCommandLineArgs_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(BuildNewProcessCommandLine_InOutCommandLineArgs_PropertyAddress.Address, intPtr);
	}

	static UMoviePipelineSetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineSetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineSetting));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineSetting");
		BuildNewProcessCommandLineArgs_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BuildNewProcessCommandLineArgs");
		BuildNewProcessCommandLineArgs_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildNewProcessCommandLineArgs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildNewProcessCommandLineArgs_InOutUnrealURLParams_PropertyAddress, BuildNewProcessCommandLineArgs_FunctionAddress, "InOutUnrealURLParams");
		BuildNewProcessCommandLineArgs_InOutUnrealURLParams_Offset = NativeReflectionCached.GetPropertyOffset(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutUnrealURLParams");
		BuildNewProcessCommandLineArgs_InOutUnrealURLParams_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutUnrealURLParams", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNewProcessCommandLineArgs_InOutCommandLineArgs_PropertyAddress, BuildNewProcessCommandLineArgs_FunctionAddress, "InOutCommandLineArgs");
		BuildNewProcessCommandLineArgs_InOutCommandLineArgs_Offset = NativeReflectionCached.GetPropertyOffset(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutCommandLineArgs");
		BuildNewProcessCommandLineArgs_InOutCommandLineArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutCommandLineArgs", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_PropertyAddress, BuildNewProcessCommandLineArgs_FunctionAddress, "InOutDeviceProfileCvars");
		BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_Offset = NativeReflectionCached.GetPropertyOffset(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutDeviceProfileCvars");
		BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutDeviceProfileCvars", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNewProcessCommandLineArgs_InOutExecCmds_PropertyAddress, BuildNewProcessCommandLineArgs_FunctionAddress, "InOutExecCmds");
		BuildNewProcessCommandLineArgs_InOutExecCmds_Offset = NativeReflectionCached.GetPropertyOffset(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutExecCmds");
		BuildNewProcessCommandLineArgs_InOutExecCmds_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNewProcessCommandLineArgs_FunctionAddress, "InOutExecCmds", Classes.FArrayProperty);
		BuildNewProcessCommandLineArgs_IsValid = BuildNewProcessCommandLineArgs_FunctionAddress != IntPtr.Zero && BuildNewProcessCommandLineArgs_InOutUnrealURLParams_IsValid && BuildNewProcessCommandLineArgs_InOutCommandLineArgs_IsValid && BuildNewProcessCommandLineArgs_InOutDeviceProfileCvars_IsValid && BuildNewProcessCommandLineArgs_InOutExecCmds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSetting:BuildNewProcessCommandLineArgs", BuildNewProcessCommandLineArgs_IsValid);
		BuildNewProcessCommandLine_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BuildNewProcessCommandLine");
		BuildNewProcessCommandLine_ParamsSize = NativeReflection.GetFunctionParamsSize(BuildNewProcessCommandLine_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BuildNewProcessCommandLine_InOutUnrealURLParams_PropertyAddress, BuildNewProcessCommandLine_FunctionAddress, "InOutUnrealURLParams");
		BuildNewProcessCommandLine_InOutUnrealURLParams_Offset = NativeReflectionCached.GetPropertyOffset(BuildNewProcessCommandLine_FunctionAddress, "InOutUnrealURLParams");
		BuildNewProcessCommandLine_InOutUnrealURLParams_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNewProcessCommandLine_FunctionAddress, "InOutUnrealURLParams", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref BuildNewProcessCommandLine_InOutCommandLineArgs_PropertyAddress, BuildNewProcessCommandLine_FunctionAddress, "InOutCommandLineArgs");
		BuildNewProcessCommandLine_InOutCommandLineArgs_Offset = NativeReflectionCached.GetPropertyOffset(BuildNewProcessCommandLine_FunctionAddress, "InOutCommandLineArgs");
		BuildNewProcessCommandLine_InOutCommandLineArgs_IsValid = NativeReflectionCached.ValidatePropertyClass(BuildNewProcessCommandLine_FunctionAddress, "InOutCommandLineArgs", Classes.FStrProperty);
		BuildNewProcessCommandLine_IsValid = BuildNewProcessCommandLine_FunctionAddress != IntPtr.Zero && BuildNewProcessCommandLine_InOutUnrealURLParams_IsValid && BuildNewProcessCommandLine_InOutCommandLineArgs_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineSetting:BuildNewProcessCommandLine", BuildNewProcessCommandLine_IsValid);
	}
}
