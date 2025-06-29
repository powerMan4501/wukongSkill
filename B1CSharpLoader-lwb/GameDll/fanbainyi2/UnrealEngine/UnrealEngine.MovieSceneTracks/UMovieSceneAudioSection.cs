using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.MovieSceneTracks;

[UClass(Flags = (ClassFlags)821035168uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MovieSceneTracks.MovieSceneAudioSection", "MovieSceneTracks", UnrealModuleType.Engine)]
public class UMovieSceneAudioSection : UMovieSceneSection
{
	private static bool SetStartOffset_IsValid;

	private static IntPtr SetStartOffset_FunctionAddress;

	private static int SetStartOffset_ParamsSize;

	private static bool SetStartOffset_InStartOffset_IsValid;

	private static FFieldAddress SetStartOffset_InStartOffset_PropertyAddress;

	private static int SetStartOffset_InStartOffset_Offset;

	private static bool SetSound_IsValid;

	private static IntPtr SetSound_FunctionAddress;

	private static int SetSound_ParamsSize;

	private static bool SetSound_InSound_IsValid;

	private static FFieldAddress SetSound_InSound_PropertyAddress;

	private static int SetSound_InSound_Offset;

	private static bool GetStartOffset_IsValid;

	private static IntPtr GetStartOffset_FunctionAddress;

	private static int GetStartOffset_ParamsSize;

	private static bool GetStartOffset_ReturnValue_IsValid;

	private static FFieldAddress GetStartOffset_ReturnValue_PropertyAddress;

	private static int GetStartOffset_ReturnValue_Offset;

	private static bool GetSound_IsValid;

	private static IntPtr GetSound_FunctionAddress;

	private static int GetSound_ParamsSize;

	private static bool GetSound_ReturnValue_IsValid;

	private static FFieldAddress GetSound_ReturnValue_PropertyAddress;

	private static int GetSound_ReturnValue_Offset;

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAudioSection:SetStartOffset")]
	public unsafe void SetStartOffset(FFrameNumber InStartOffset)
	{
		CheckDestroyed();
		if (!SetStartOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAudioSection:SetStartOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetStartOffset_InStartOffset_PropertyAddress.Address, intPtr);
		FFrameNumber.ToNative(IntPtr.Add(intPtr, SetStartOffset_InStartOffset_Offset), 0, SetStartOffset_InStartOffset_PropertyAddress.Address, InStartOffset);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartOffset_FunctionAddress, intPtr, SetStartOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAudioSection:SetSound")]
	public unsafe void SetSound(USoundBase InSound)
	{
		CheckDestroyed();
		if (!SetSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAudioSection:SetSound");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USoundBase>.ToNative(IntPtr.Add(intPtr, SetSound_InSound_Offset), 0, SetSound_InSound_PropertyAddress.Address, InSound);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSound_FunctionAddress, intPtr, SetSound_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAudioSection:GetStartOffset")]
	public unsafe FFrameNumber GetStartOffset()
	{
		CheckDestroyed();
		if (!GetStartOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAudioSection:GetStartOffset");
			return default(FFrameNumber);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartOffset_FunctionAddress, intPtr, GetStartOffset_ParamsSize);
		return FFrameNumber.FromNative(IntPtr.Add(intPtr, GetStartOffset_ReturnValue_Offset), 0, GetStartOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneAudioSection:GetSound")]
	public unsafe USoundBase GetSound()
	{
		CheckDestroyed();
		if (!GetSound_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneAudioSection:GetSound");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSound_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSound_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSound_FunctionAddress, intPtr, GetSound_ParamsSize);
		return UObjectMarshaler<USoundBase>.FromNative(IntPtr.Add(intPtr, GetSound_ReturnValue_Offset), 0, GetSound_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneAudioSection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneAudioSection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneAudioSection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MovieSceneTracks.MovieSceneAudioSection");
		SetStartOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartOffset");
		SetStartOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartOffset_InStartOffset_PropertyAddress, SetStartOffset_FunctionAddress, "InStartOffset");
		SetStartOffset_InStartOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetStartOffset_FunctionAddress, "InStartOffset");
		SetStartOffset_InStartOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartOffset_FunctionAddress, "InStartOffset", Classes.FStructProperty);
		SetStartOffset_IsValid = SetStartOffset_FunctionAddress != IntPtr.Zero && SetStartOffset_InStartOffset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAudioSection:SetStartOffset", SetStartOffset_IsValid);
		SetSound_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSound");
		SetSound_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSound_InSound_PropertyAddress, SetSound_FunctionAddress, "InSound");
		SetSound_InSound_Offset = NativeReflectionCached.GetPropertyOffset(SetSound_FunctionAddress, "InSound");
		SetSound_InSound_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSound_FunctionAddress, "InSound", Classes.FObjectProperty);
		SetSound_IsValid = SetSound_FunctionAddress != IntPtr.Zero && SetSound_InSound_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAudioSection:SetSound", SetSound_IsValid);
		GetStartOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartOffset");
		GetStartOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartOffset_ReturnValue_PropertyAddress, GetStartOffset_FunctionAddress, "ReturnValue");
		GetStartOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartOffset_FunctionAddress, "ReturnValue");
		GetStartOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStartOffset_IsValid = GetStartOffset_FunctionAddress != IntPtr.Zero && GetStartOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAudioSection:GetStartOffset", GetStartOffset_IsValid);
		GetSound_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSound");
		GetSound_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSound_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSound_ReturnValue_PropertyAddress, GetSound_FunctionAddress, "ReturnValue");
		GetSound_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSound_FunctionAddress, "ReturnValue");
		GetSound_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSound_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSound_IsValid = GetSound_FunctionAddress != IntPtr.Zero && GetSound_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneAudioSection:GetSound", GetSound_IsValid);
	}
}
