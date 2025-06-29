using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)812646560uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneLevelVisibilitySection : UMovieSceneSection, IMovieSceneEntityProvider, IInterface
{
	private static bool SetVisibility_IsValid;

	private static IntPtr SetVisibility_FunctionAddress;

	private static int SetVisibility_ParamsSize;

	private static bool SetVisibility_InVisibility_IsValid;

	private static FFieldAddress SetVisibility_InVisibility_PropertyAddress;

	private static int SetVisibility_InVisibility_Offset;

	private static bool SetLevelNames_IsValid;

	private static IntPtr SetLevelNames_FunctionAddress;

	private static int SetLevelNames_ParamsSize;

	private static bool SetLevelNames_InLevelNames_IsValid;

	private static FFieldAddress SetLevelNames_InLevelNames_PropertyAddress;

	private static int SetLevelNames_InLevelNames_Offset;

	private static bool GetVisibility_IsValid;

	private static IntPtr GetVisibility_FunctionAddress;

	private static int GetVisibility_ParamsSize;

	private static bool GetVisibility_ReturnValue_IsValid;

	private static FFieldAddress GetVisibility_ReturnValue_PropertyAddress;

	private static int GetVisibility_ReturnValue_Offset;

	private static bool GetLevelNames_IsValid;

	private static IntPtr GetLevelNames_FunctionAddress;

	private static int GetLevelNames_ParamsSize;

	private static bool GetLevelNames_ReturnValue_IsValid;

	private static FFieldAddress GetLevelNames_ReturnValue_PropertyAddress;

	private static int GetLevelNames_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:SetVisibility")]
	public unsafe void SetVisibility(ELevelVisibility InVisibility)
	{
		CheckDestroyed();
		if (!SetVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:SetVisibility");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ELevelVisibility>.ToNative(IntPtr.Add(intPtr, SetVisibility_InVisibility_Offset), 0, SetVisibility_InVisibility_PropertyAddress.Address, InVisibility);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVisibility_FunctionAddress, intPtr, SetVisibility_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:SetLevelNames")]
	public unsafe void SetLevelNames(List<FName> InLevelNames)
	{
		CheckDestroyed();
		if (!SetLevelNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:SetLevelNames");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetLevelNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetLevelNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, SetLevelNames_InLevelNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, SetLevelNames_InLevelNames_Offset), InLevelNames);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetLevelNames_FunctionAddress, intPtr, SetLevelNames_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetLevelNames_InLevelNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:GetVisibility")]
	public unsafe ELevelVisibility GetVisibility()
	{
		CheckDestroyed();
		if (!GetVisibility_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:GetVisibility");
			return ELevelVisibility.Visible;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetVisibility_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetVisibility_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetVisibility_FunctionAddress, intPtr, GetVisibility_ParamsSize);
		return EnumMarshaler<ELevelVisibility>.FromNative(IntPtr.Add(intPtr, GetVisibility_ReturnValue_Offset), 0, GetVisibility_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:GetLevelNames")]
	public unsafe List<FName> GetLevelNames()
	{
		CheckDestroyed();
		if (!GetLevelNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:GetLevelNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLevelNames_FunctionAddress, intPtr, GetLevelNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetLevelNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLevelNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetLevelNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMovieSceneLevelVisibilitySection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneLevelVisibilitySection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneLevelVisibilitySection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection");
		SetVisibility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetVisibility");
		SetVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVisibility_InVisibility_PropertyAddress, SetVisibility_FunctionAddress, "InVisibility");
		SetVisibility_InVisibility_Offset = NativeReflectionCached.GetPropertyOffset(SetVisibility_FunctionAddress, "InVisibility");
		SetVisibility_InVisibility_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVisibility_FunctionAddress, "InVisibility", Classes.FEnumProperty);
		SetVisibility_IsValid = SetVisibility_FunctionAddress != IntPtr.Zero && SetVisibility_InVisibility_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:SetVisibility", SetVisibility_IsValid);
		SetLevelNames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetLevelNames");
		SetLevelNames_ParamsSize = NativeReflection.GetFunctionParamsSize(SetLevelNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetLevelNames_InLevelNames_PropertyAddress, SetLevelNames_FunctionAddress, "InLevelNames");
		SetLevelNames_InLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(SetLevelNames_FunctionAddress, "InLevelNames");
		SetLevelNames_InLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetLevelNames_FunctionAddress, "InLevelNames", Classes.FArrayProperty);
		SetLevelNames_IsValid = SetLevelNames_FunctionAddress != IntPtr.Zero && SetLevelNames_InLevelNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:SetLevelNames", SetLevelNames_IsValid);
		GetVisibility_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetVisibility");
		GetVisibility_ParamsSize = NativeReflection.GetFunctionParamsSize(GetVisibility_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetVisibility_ReturnValue_PropertyAddress, GetVisibility_FunctionAddress, "ReturnValue");
		GetVisibility_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetVisibility_FunctionAddress, "ReturnValue");
		GetVisibility_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetVisibility_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetVisibility_IsValid = GetVisibility_FunctionAddress != IntPtr.Zero && GetVisibility_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:GetVisibility", GetVisibility_IsValid);
		GetLevelNames_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLevelNames");
		GetLevelNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelNames_ReturnValue_PropertyAddress, GetLevelNames_FunctionAddress, "ReturnValue");
		GetLevelNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelNames_FunctionAddress, "ReturnValue");
		GetLevelNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetLevelNames_IsValid = GetLevelNames_FunctionAddress != IntPtr.Zero && GetLevelNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneLevelVisibilitySection:GetLevelNames", GetLevelNames_IsValid);
	}
}
