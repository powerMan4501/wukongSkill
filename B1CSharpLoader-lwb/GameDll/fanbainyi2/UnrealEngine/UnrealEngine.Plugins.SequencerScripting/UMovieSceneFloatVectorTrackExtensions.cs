using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneFloatVectorTrackExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetNumChannelsUsed_IsValid;

	private static IntPtr SetNumChannelsUsed_FunctionAddress;

	private static int SetNumChannelsUsed_ParamsSize;

	private static bool SetNumChannelsUsed_Track_IsValid;

	private static FFieldAddress SetNumChannelsUsed_Track_PropertyAddress;

	private static int SetNumChannelsUsed_Track_Offset;

	private static bool SetNumChannelsUsed_InNumChannelsUsed_IsValid;

	private static FFieldAddress SetNumChannelsUsed_InNumChannelsUsed_PropertyAddress;

	private static int SetNumChannelsUsed_InNumChannelsUsed_Offset;

	private static bool GetNumChannelsUsed_IsValid;

	private static IntPtr GetNumChannelsUsed_FunctionAddress;

	private static int GetNumChannelsUsed_ParamsSize;

	private static bool GetNumChannelsUsed_Track_IsValid;

	private static FFieldAddress GetNumChannelsUsed_Track_PropertyAddress;

	private static int GetNumChannelsUsed_Track_Offset;

	private static bool GetNumChannelsUsed_ReturnValue_IsValid;

	private static FFieldAddress GetNumChannelsUsed_ReturnValue_PropertyAddress;

	private static int GetNumChannelsUsed_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:SetNumChannelsUsed")]
	public unsafe static void SetNumChannelsUsed(UMovieSceneFloatVectorTrack Track, int InNumChannelsUsed)
	{
		if (!SetNumChannelsUsed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:SetNumChannelsUsed");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNumChannelsUsed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNumChannelsUsed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFloatVectorTrack>.ToNative(IntPtr.Add(intPtr, SetNumChannelsUsed_Track_Offset), 0, SetNumChannelsUsed_Track_PropertyAddress.Address, Track);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetNumChannelsUsed_InNumChannelsUsed_Offset), 0, SetNumChannelsUsed_InNumChannelsUsed_PropertyAddress.Address, InNumChannelsUsed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNumChannelsUsed_FunctionAddress, intPtr, SetNumChannelsUsed_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:GetNumChannelsUsed")]
	public unsafe static int GetNumChannelsUsed(UMovieSceneFloatVectorTrack Track)
	{
		if (!GetNumChannelsUsed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:GetNumChannelsUsed");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNumChannelsUsed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNumChannelsUsed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneFloatVectorTrack>.ToNative(IntPtr.Add(intPtr, GetNumChannelsUsed_Track_Offset), 0, GetNumChannelsUsed_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNumChannelsUsed_FunctionAddress, intPtr, GetNumChannelsUsed_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetNumChannelsUsed_ReturnValue_Offset), 0, GetNumChannelsUsed_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneFloatVectorTrackExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneFloatVectorTrackExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneFloatVectorTrackExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions");
		SetNumChannelsUsed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNumChannelsUsed");
		SetNumChannelsUsed_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNumChannelsUsed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNumChannelsUsed_Track_PropertyAddress, SetNumChannelsUsed_FunctionAddress, "Track");
		SetNumChannelsUsed_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetNumChannelsUsed_FunctionAddress, "Track");
		SetNumChannelsUsed_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumChannelsUsed_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetNumChannelsUsed_InNumChannelsUsed_PropertyAddress, SetNumChannelsUsed_FunctionAddress, "InNumChannelsUsed");
		SetNumChannelsUsed_InNumChannelsUsed_Offset = NativeReflectionCached.GetPropertyOffset(SetNumChannelsUsed_FunctionAddress, "InNumChannelsUsed");
		SetNumChannelsUsed_InNumChannelsUsed_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNumChannelsUsed_FunctionAddress, "InNumChannelsUsed", Classes.FIntProperty);
		SetNumChannelsUsed_IsValid = SetNumChannelsUsed_FunctionAddress != IntPtr.Zero && SetNumChannelsUsed_Track_IsValid && SetNumChannelsUsed_InNumChannelsUsed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:SetNumChannelsUsed", SetNumChannelsUsed_IsValid);
		GetNumChannelsUsed_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNumChannelsUsed");
		GetNumChannelsUsed_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNumChannelsUsed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNumChannelsUsed_Track_PropertyAddress, GetNumChannelsUsed_FunctionAddress, "Track");
		GetNumChannelsUsed_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetNumChannelsUsed_FunctionAddress, "Track");
		GetNumChannelsUsed_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumChannelsUsed_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetNumChannelsUsed_ReturnValue_PropertyAddress, GetNumChannelsUsed_FunctionAddress, "ReturnValue");
		GetNumChannelsUsed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNumChannelsUsed_FunctionAddress, "ReturnValue");
		GetNumChannelsUsed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNumChannelsUsed_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetNumChannelsUsed_IsValid = GetNumChannelsUsed_FunctionAddress != IntPtr.Zero && GetNumChannelsUsed_Track_IsValid && GetNumChannelsUsed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneFloatVectorTrackExtensions:GetNumChannelsUsed", GetNumChannelsUsed_IsValid);
	}
}
