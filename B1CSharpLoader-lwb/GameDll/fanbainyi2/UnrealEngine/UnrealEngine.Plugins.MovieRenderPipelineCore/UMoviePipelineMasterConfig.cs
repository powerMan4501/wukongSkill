using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineMasterConfig : UMoviePipelineConfigBase
{
	private static bool InitializeTransientSettings_IsValid;

	private static IntPtr InitializeTransientSettings_FunctionAddress;

	private static int InitializeTransientSettings_ParamsSize;

	private static bool GetTransientSettings_IsValid;

	private static IntPtr GetTransientSettings_FunctionAddress;

	private static int GetTransientSettings_ParamsSize;

	private static bool GetTransientSettings_ReturnValue_IsValid;

	private static FFieldAddress GetTransientSettings_ReturnValue_PropertyAddress;

	private static int GetTransientSettings_ReturnValue_Offset;

	private static bool GetEffectiveFrameRate_IsValid;

	private static IntPtr GetEffectiveFrameRate_FunctionAddress;

	private static int GetEffectiveFrameRate_ParamsSize;

	private static bool GetEffectiveFrameRate_InSequence_IsValid;

	private static FFieldAddress GetEffectiveFrameRate_InSequence_PropertyAddress;

	private static int GetEffectiveFrameRate_InSequence_Offset;

	private static bool GetEffectiveFrameRate_ReturnValue_IsValid;

	private static FFieldAddress GetEffectiveFrameRate_ReturnValue_PropertyAddress;

	private static int GetEffectiveFrameRate_ReturnValue_Offset;

	private static bool GetAllSettings_IsValid;

	private static IntPtr GetAllSettings_FunctionAddress;

	private static int GetAllSettings_ParamsSize;

	private static bool GetAllSettings_bIncludeDisabledSettings_IsValid;

	private static FFieldAddress GetAllSettings_bIncludeDisabledSettings_PropertyAddress;

	private static int GetAllSettings_bIncludeDisabledSettings_Offset;

	private static bool GetAllSettings_bIncludeTransientSettings_IsValid;

	private static FFieldAddress GetAllSettings_bIncludeTransientSettings_PropertyAddress;

	private static int GetAllSettings_bIncludeTransientSettings_Offset;

	private static bool GetAllSettings_ReturnValue_IsValid;

	private static FFieldAddress GetAllSettings_ReturnValue_PropertyAddress;

	private static int GetAllSettings_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:InitializeTransientSettings")]
	public unsafe void InitializeTransientSettings()
	{
		CheckDestroyed();
		if (!InitializeTransientSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:InitializeTransientSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeTransientSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeTransientSettings_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitializeTransientSettings_FunctionAddress, argsSize: InitializeTransientSettings_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetTransientSettings")]
	public unsafe List<UMoviePipelineSetting> GetTransientSettings()
	{
		CheckDestroyed();
		if (!GetTransientSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetTransientSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTransientSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTransientSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTransientSettings_FunctionAddress, intPtr, GetTransientSettings_ParamsSize);
		List<UMoviePipelineSetting> result = new TArrayCopyMarshaler<UMoviePipelineSetting>(1, GetTransientSettings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.FromNative, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.ToNative).FromNative(IntPtr.Add(intPtr, GetTransientSettings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetTransientSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetEffectiveFrameRate")]
	public unsafe FFrameRate GetEffectiveFrameRate(ULevelSequence InSequence)
	{
		CheckDestroyed();
		if (!GetEffectiveFrameRate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetEffectiveFrameRate");
			return default(FFrameRate);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEffectiveFrameRate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEffectiveFrameRate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(intPtr, GetEffectiveFrameRate_InSequence_Offset), 0, GetEffectiveFrameRate_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEffectiveFrameRate_FunctionAddress, intPtr, GetEffectiveFrameRate_ParamsSize);
		return BlittableTypeMarshaler<FFrameRate>.FromNative(IntPtr.Add(intPtr, GetEffectiveFrameRate_ReturnValue_Offset), 0, GetEffectiveFrameRate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetAllSettings")]
	public unsafe List<UMoviePipelineSetting> GetAllSettings(bool bIncludeDisabledSettings = false, bool bIncludeTransientSettings = false)
	{
		CheckDestroyed();
		if (!GetAllSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetAllSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllSettings_bIncludeDisabledSettings_Offset), 0, GetAllSettings_bIncludeDisabledSettings_PropertyAddress.Address, bIncludeDisabledSettings);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, GetAllSettings_bIncludeTransientSettings_Offset), 0, GetAllSettings_bIncludeTransientSettings_PropertyAddress.Address, bIncludeTransientSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetAllSettings_FunctionAddress, intPtr, GetAllSettings_ParamsSize);
		List<UMoviePipelineSetting> result = new TArrayCopyMarshaler<UMoviePipelineSetting>(1, GetAllSettings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.FromNative, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllSettings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMoviePipelineMasterConfig()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineMasterConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineMasterConfig));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig");
		InitializeTransientSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeTransientSettings");
		InitializeTransientSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeTransientSettings_FunctionAddress);
		InitializeTransientSettings_IsValid = InitializeTransientSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:InitializeTransientSettings", InitializeTransientSettings_IsValid);
		GetTransientSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTransientSettings");
		GetTransientSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTransientSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTransientSettings_ReturnValue_PropertyAddress, GetTransientSettings_FunctionAddress, "ReturnValue");
		GetTransientSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTransientSettings_FunctionAddress, "ReturnValue");
		GetTransientSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTransientSettings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetTransientSettings_IsValid = GetTransientSettings_FunctionAddress != IntPtr.Zero && GetTransientSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetTransientSettings", GetTransientSettings_IsValid);
		GetEffectiveFrameRate_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEffectiveFrameRate");
		GetEffectiveFrameRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEffectiveFrameRate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEffectiveFrameRate_InSequence_PropertyAddress, GetEffectiveFrameRate_FunctionAddress, "InSequence");
		GetEffectiveFrameRate_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(GetEffectiveFrameRate_FunctionAddress, "InSequence");
		GetEffectiveFrameRate_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEffectiveFrameRate_FunctionAddress, "InSequence", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetEffectiveFrameRate_ReturnValue_PropertyAddress, GetEffectiveFrameRate_FunctionAddress, "ReturnValue");
		GetEffectiveFrameRate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEffectiveFrameRate_FunctionAddress, "ReturnValue");
		GetEffectiveFrameRate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEffectiveFrameRate_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEffectiveFrameRate_IsValid = GetEffectiveFrameRate_FunctionAddress != IntPtr.Zero && GetEffectiveFrameRate_InSequence_IsValid && GetEffectiveFrameRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetEffectiveFrameRate", GetEffectiveFrameRate_IsValid);
		GetAllSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetAllSettings");
		GetAllSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllSettings_bIncludeDisabledSettings_PropertyAddress, GetAllSettings_FunctionAddress, "bIncludeDisabledSettings");
		GetAllSettings_bIncludeDisabledSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSettings_FunctionAddress, "bIncludeDisabledSettings");
		GetAllSettings_bIncludeDisabledSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSettings_FunctionAddress, "bIncludeDisabledSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllSettings_bIncludeTransientSettings_PropertyAddress, GetAllSettings_FunctionAddress, "bIncludeTransientSettings");
		GetAllSettings_bIncludeTransientSettings_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSettings_FunctionAddress, "bIncludeTransientSettings");
		GetAllSettings_bIncludeTransientSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSettings_FunctionAddress, "bIncludeTransientSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllSettings_ReturnValue_PropertyAddress, GetAllSettings_FunctionAddress, "ReturnValue");
		GetAllSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllSettings_FunctionAddress, "ReturnValue");
		GetAllSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllSettings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetAllSettings_IsValid = GetAllSettings_FunctionAddress != IntPtr.Zero && GetAllSettings_bIncludeDisabledSettings_IsValid && GetAllSettings_bIncludeTransientSettings_IsValid && GetAllSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineMasterConfig:GetAllSettings", GetAllSettings_IsValid);
	}
}
