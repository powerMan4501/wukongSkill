using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MovieRenderPipelineCore;

[Abstract]
[UClass(Flags = (ClassFlags)818938017uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase", "MovieRenderPipelineCore", UnrealModuleType.EnginePlugin)]
public class UMoviePipelineConfigBase : UObject
{
	private static bool RemoveSetting_IsValid;

	private static IntPtr RemoveSetting_FunctionAddress;

	private static int RemoveSetting_ParamsSize;

	private static bool RemoveSetting_InSetting_IsValid;

	private static FFieldAddress RemoveSetting_InSetting_PropertyAddress;

	private static int RemoveSetting_InSetting_Offset;

	private static bool GetUserSettings_IsValid;

	private static IntPtr GetUserSettings_FunctionAddress;

	private static int GetUserSettings_ParamsSize;

	private static bool GetUserSettings_ReturnValue_IsValid;

	private static FFieldAddress GetUserSettings_ReturnValue_PropertyAddress;

	private static int GetUserSettings_ReturnValue_Offset;

	private static bool FindSettingsByClass_IsValid;

	private static IntPtr FindSettingsByClass_FunctionAddress;

	private static int FindSettingsByClass_ParamsSize;

	private static bool FindSettingsByClass_InClass_IsValid;

	private static FFieldAddress FindSettingsByClass_InClass_PropertyAddress;

	private static int FindSettingsByClass_InClass_Offset;

	private static bool FindSettingsByClass_bIncludeDisabledSettings_IsValid;

	private static FFieldAddress FindSettingsByClass_bIncludeDisabledSettings_PropertyAddress;

	private static int FindSettingsByClass_bIncludeDisabledSettings_Offset;

	private static bool FindSettingsByClass_ReturnValue_IsValid;

	private static FFieldAddress FindSettingsByClass_ReturnValue_PropertyAddress;

	private static int FindSettingsByClass_ReturnValue_Offset;

	private static bool FindSettingByClass_IsValid;

	private static IntPtr FindSettingByClass_FunctionAddress;

	private static int FindSettingByClass_ParamsSize;

	private static bool FindSettingByClass_InClass_IsValid;

	private static FFieldAddress FindSettingByClass_InClass_PropertyAddress;

	private static int FindSettingByClass_InClass_Offset;

	private static bool FindSettingByClass_bIncludeDisabledSettings_IsValid;

	private static FFieldAddress FindSettingByClass_bIncludeDisabledSettings_PropertyAddress;

	private static int FindSettingByClass_bIncludeDisabledSettings_Offset;

	private static bool FindSettingByClass_ReturnValue_IsValid;

	private static FFieldAddress FindSettingByClass_ReturnValue_PropertyAddress;

	private static int FindSettingByClass_ReturnValue_Offset;

	private static bool FindOrAddSettingByClass_IsValid;

	private static IntPtr FindOrAddSettingByClass_FunctionAddress;

	private static int FindOrAddSettingByClass_ParamsSize;

	private static bool FindOrAddSettingByClass_InClass_IsValid;

	private static FFieldAddress FindOrAddSettingByClass_InClass_PropertyAddress;

	private static int FindOrAddSettingByClass_InClass_Offset;

	private static bool FindOrAddSettingByClass_bIncludeDisabledSettings_IsValid;

	private static FFieldAddress FindOrAddSettingByClass_bIncludeDisabledSettings_PropertyAddress;

	private static int FindOrAddSettingByClass_bIncludeDisabledSettings_Offset;

	private static bool FindOrAddSettingByClass_ReturnValue_IsValid;

	private static FFieldAddress FindOrAddSettingByClass_ReturnValue_PropertyAddress;

	private static int FindOrAddSettingByClass_ReturnValue_Offset;

	private static bool CopyFrom_IsValid;

	private static IntPtr CopyFrom_FunctionAddress;

	private static int CopyFrom_ParamsSize;

	private static bool CopyFrom_InConfig_IsValid;

	private static FFieldAddress CopyFrom_InConfig_PropertyAddress;

	private static int CopyFrom_InConfig_Offset;

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:RemoveSetting")]
	public unsafe void RemoveSetting(UMoviePipelineSetting InSetting)
	{
		CheckDestroyed();
		if (!RemoveSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:RemoveSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineSetting>.ToNative(IntPtr.Add(intPtr, RemoveSetting_InSetting_Offset), 0, RemoveSetting_InSetting_PropertyAddress.Address, InSetting);
		NativeReflection.InvokeFunctionOptimized(base.Address, RemoveSetting_FunctionAddress, intPtr, RemoveSetting_ParamsSize);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:GetUserSettings")]
	public unsafe List<UMoviePipelineSetting> GetUserSettings()
	{
		CheckDestroyed();
		if (!GetUserSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:GetUserSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUserSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUserSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetUserSettings_FunctionAddress, intPtr, GetUserSettings_ParamsSize);
		List<UMoviePipelineSetting> result = new TArrayCopyMarshaler<UMoviePipelineSetting>(1, GetUserSettings_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.FromNative, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.ToNative).FromNative(IntPtr.Add(intPtr, GetUserSettings_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetUserSettings_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindSettingsByClass")]
	public unsafe List<UMoviePipelineSetting> FindSettingsByClass(TSubclassOf<UMoviePipelineSetting> InClass, bool bIncludeDisabledSettings = false)
	{
		CheckDestroyed();
		if (!FindSettingsByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindSettingsByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSettingsByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSettingsByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMoviePipelineSetting>.ToNative(IntPtr.Add(intPtr, FindSettingsByClass_InClass_Offset), 0, FindSettingsByClass_InClass_PropertyAddress.Address, InClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindSettingsByClass_bIncludeDisabledSettings_Offset), 0, FindSettingsByClass_bIncludeDisabledSettings_PropertyAddress.Address, bIncludeDisabledSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSettingsByClass_FunctionAddress, intPtr, FindSettingsByClass_ParamsSize);
		List<UMoviePipelineSetting> result = new TArrayCopyMarshaler<UMoviePipelineSetting>(1, FindSettingsByClass_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.FromNative, CachedMarshalingDelegates<UMoviePipelineSetting, UObjectMarshaler<UMoviePipelineSetting>>.ToNative).FromNative(IntPtr.Add(intPtr, FindSettingsByClass_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(FindSettingsByClass_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindSettingByClass")]
	public unsafe UMoviePipelineSetting FindSettingByClass(TSubclassOf<UMoviePipelineSetting> InClass, bool bIncludeDisabledSettings = false)
	{
		CheckDestroyed();
		if (!FindSettingByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindSettingByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindSettingByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindSettingByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMoviePipelineSetting>.ToNative(IntPtr.Add(intPtr, FindSettingByClass_InClass_Offset), 0, FindSettingByClass_InClass_PropertyAddress.Address, InClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindSettingByClass_bIncludeDisabledSettings_Offset), 0, FindSettingByClass_bIncludeDisabledSettings_PropertyAddress.Address, bIncludeDisabledSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindSettingByClass_FunctionAddress, intPtr, FindSettingByClass_ParamsSize);
		return UObjectMarshaler<UMoviePipelineSetting>.FromNative(IntPtr.Add(intPtr, FindSettingByClass_ReturnValue_Offset), 0, FindSettingByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindOrAddSettingByClass")]
	public unsafe UMoviePipelineSetting FindOrAddSettingByClass(TSubclassOf<UMoviePipelineSetting> InClass, bool bIncludeDisabledSettings = false)
	{
		CheckDestroyed();
		if (!FindOrAddSettingByClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindOrAddSettingByClass");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindOrAddSettingByClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindOrAddSettingByClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UMoviePipelineSetting>.ToNative(IntPtr.Add(intPtr, FindOrAddSettingByClass_InClass_Offset), 0, FindOrAddSettingByClass_InClass_PropertyAddress.Address, InClass);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, FindOrAddSettingByClass_bIncludeDisabledSettings_Offset), 0, FindOrAddSettingByClass_bIncludeDisabledSettings_PropertyAddress.Address, bIncludeDisabledSettings);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindOrAddSettingByClass_FunctionAddress, intPtr, FindOrAddSettingByClass_ParamsSize);
		return UObjectMarshaler<UMoviePipelineSetting>.FromNative(IntPtr.Add(intPtr, FindOrAddSettingByClass_ReturnValue_Offset), 0, FindOrAddSettingByClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:CopyFrom")]
	public unsafe void CopyFrom(UMoviePipelineConfigBase InConfig)
	{
		CheckDestroyed();
		if (!CopyFrom_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:CopyFrom");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyFrom_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyFrom_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMoviePipelineConfigBase>.ToNative(IntPtr.Add(intPtr, CopyFrom_InConfig_Offset), 0, CopyFrom_InConfig_PropertyAddress.Address, InConfig);
		NativeReflection.InvokeFunctionOptimized(base.Address, CopyFrom_FunctionAddress, intPtr, CopyFrom_ParamsSize);
	}

	static UMoviePipelineConfigBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMoviePipelineConfigBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMoviePipelineConfigBase));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase");
		RemoveSetting_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "RemoveSetting");
		RemoveSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSetting_InSetting_PropertyAddress, RemoveSetting_FunctionAddress, "InSetting");
		RemoveSetting_InSetting_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSetting_FunctionAddress, "InSetting");
		RemoveSetting_InSetting_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSetting_FunctionAddress, "InSetting", Classes.FObjectProperty);
		RemoveSetting_IsValid = RemoveSetting_FunctionAddress != IntPtr.Zero && RemoveSetting_InSetting_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:RemoveSetting", RemoveSetting_IsValid);
		GetUserSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetUserSettings");
		GetUserSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUserSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUserSettings_ReturnValue_PropertyAddress, GetUserSettings_FunctionAddress, "ReturnValue");
		GetUserSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUserSettings_FunctionAddress, "ReturnValue");
		GetUserSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUserSettings_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetUserSettings_IsValid = GetUserSettings_FunctionAddress != IntPtr.Zero && GetUserSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:GetUserSettings", GetUserSettings_IsValid);
		FindSettingsByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindSettingsByClass");
		FindSettingsByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSettingsByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSettingsByClass_InClass_PropertyAddress, FindSettingsByClass_FunctionAddress, "InClass");
		FindSettingsByClass_InClass_Offset = NativeReflectionCached.GetPropertyOffset(FindSettingsByClass_FunctionAddress, "InClass");
		FindSettingsByClass_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSettingsByClass_FunctionAddress, "InClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSettingsByClass_bIncludeDisabledSettings_PropertyAddress, FindSettingsByClass_FunctionAddress, "bIncludeDisabledSettings");
		FindSettingsByClass_bIncludeDisabledSettings_Offset = NativeReflectionCached.GetPropertyOffset(FindSettingsByClass_FunctionAddress, "bIncludeDisabledSettings");
		FindSettingsByClass_bIncludeDisabledSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSettingsByClass_FunctionAddress, "bIncludeDisabledSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSettingsByClass_ReturnValue_PropertyAddress, FindSettingsByClass_FunctionAddress, "ReturnValue");
		FindSettingsByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindSettingsByClass_FunctionAddress, "ReturnValue");
		FindSettingsByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSettingsByClass_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		FindSettingsByClass_IsValid = FindSettingsByClass_FunctionAddress != IntPtr.Zero && FindSettingsByClass_InClass_IsValid && FindSettingsByClass_bIncludeDisabledSettings_IsValid && FindSettingsByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindSettingsByClass", FindSettingsByClass_IsValid);
		FindSettingByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindSettingByClass");
		FindSettingByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindSettingByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindSettingByClass_InClass_PropertyAddress, FindSettingByClass_FunctionAddress, "InClass");
		FindSettingByClass_InClass_Offset = NativeReflectionCached.GetPropertyOffset(FindSettingByClass_FunctionAddress, "InClass");
		FindSettingByClass_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSettingByClass_FunctionAddress, "InClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSettingByClass_bIncludeDisabledSettings_PropertyAddress, FindSettingByClass_FunctionAddress, "bIncludeDisabledSettings");
		FindSettingByClass_bIncludeDisabledSettings_Offset = NativeReflectionCached.GetPropertyOffset(FindSettingByClass_FunctionAddress, "bIncludeDisabledSettings");
		FindSettingByClass_bIncludeDisabledSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSettingByClass_FunctionAddress, "bIncludeDisabledSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindSettingByClass_ReturnValue_PropertyAddress, FindSettingByClass_FunctionAddress, "ReturnValue");
		FindSettingByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindSettingByClass_FunctionAddress, "ReturnValue");
		FindSettingByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindSettingByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindSettingByClass_IsValid = FindSettingByClass_FunctionAddress != IntPtr.Zero && FindSettingByClass_InClass_IsValid && FindSettingByClass_bIncludeDisabledSettings_IsValid && FindSettingByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindSettingByClass", FindSettingByClass_IsValid);
		FindOrAddSettingByClass_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "FindOrAddSettingByClass");
		FindOrAddSettingByClass_ParamsSize = NativeReflection.GetFunctionParamsSize(FindOrAddSettingByClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddSettingByClass_InClass_PropertyAddress, FindOrAddSettingByClass_FunctionAddress, "InClass");
		FindOrAddSettingByClass_InClass_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddSettingByClass_FunctionAddress, "InClass");
		FindOrAddSettingByClass_InClass_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddSettingByClass_FunctionAddress, "InClass", Classes.FClassProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddSettingByClass_bIncludeDisabledSettings_PropertyAddress, FindOrAddSettingByClass_FunctionAddress, "bIncludeDisabledSettings");
		FindOrAddSettingByClass_bIncludeDisabledSettings_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddSettingByClass_FunctionAddress, "bIncludeDisabledSettings");
		FindOrAddSettingByClass_bIncludeDisabledSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddSettingByClass_FunctionAddress, "bIncludeDisabledSettings", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindOrAddSettingByClass_ReturnValue_PropertyAddress, FindOrAddSettingByClass_FunctionAddress, "ReturnValue");
		FindOrAddSettingByClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindOrAddSettingByClass_FunctionAddress, "ReturnValue");
		FindOrAddSettingByClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindOrAddSettingByClass_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindOrAddSettingByClass_IsValid = FindOrAddSettingByClass_FunctionAddress != IntPtr.Zero && FindOrAddSettingByClass_InClass_IsValid && FindOrAddSettingByClass_bIncludeDisabledSettings_IsValid && FindOrAddSettingByClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:FindOrAddSettingByClass", FindOrAddSettingByClass_IsValid);
		CopyFrom_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CopyFrom");
		CopyFrom_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyFrom_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyFrom_InConfig_PropertyAddress, CopyFrom_FunctionAddress, "InConfig");
		CopyFrom_InConfig_Offset = NativeReflectionCached.GetPropertyOffset(CopyFrom_FunctionAddress, "InConfig");
		CopyFrom_InConfig_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyFrom_FunctionAddress, "InConfig", Classes.FObjectProperty);
		CopyFrom_IsValid = CopyFrom_FunctionAddress != IntPtr.Zero && CopyFrom_InConfig_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieRenderPipelineCore.MoviePipelineConfigBase:CopyFrom", CopyFrom_IsValid);
	}
}
