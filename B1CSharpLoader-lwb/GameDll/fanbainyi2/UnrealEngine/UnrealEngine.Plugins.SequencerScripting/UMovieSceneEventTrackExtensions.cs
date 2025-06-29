using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieSceneEventTrackExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneEventTrackExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool GetBoundObjectPropertyClass_IsValid;

	private static IntPtr GetBoundObjectPropertyClass_FunctionAddress;

	private static int GetBoundObjectPropertyClass_ParamsSize;

	private static bool GetBoundObjectPropertyClass_EventKey_IsValid;

	private static FFieldAddress GetBoundObjectPropertyClass_EventKey_PropertyAddress;

	private static int GetBoundObjectPropertyClass_EventKey_Offset;

	private static bool GetBoundObjectPropertyClass_ReturnValue_IsValid;

	private static FFieldAddress GetBoundObjectPropertyClass_ReturnValue_PropertyAddress;

	private static int GetBoundObjectPropertyClass_ReturnValue_Offset;

	private static bool AddEventTriggerSection_IsValid;

	private static IntPtr AddEventTriggerSection_FunctionAddress;

	private static int AddEventTriggerSection_ParamsSize;

	private static bool AddEventTriggerSection_InTrack_IsValid;

	private static FFieldAddress AddEventTriggerSection_InTrack_PropertyAddress;

	private static int AddEventTriggerSection_InTrack_Offset;

	private static bool AddEventTriggerSection_ReturnValue_IsValid;

	private static FFieldAddress AddEventTriggerSection_ReturnValue_PropertyAddress;

	private static int AddEventTriggerSection_ReturnValue_Offset;

	private static bool AddEventRepeaterSection_IsValid;

	private static IntPtr AddEventRepeaterSection_FunctionAddress;

	private static int AddEventRepeaterSection_ParamsSize;

	private static bool AddEventRepeaterSection_InTrack_IsValid;

	private static FFieldAddress AddEventRepeaterSection_InTrack_PropertyAddress;

	private static int AddEventRepeaterSection_InTrack_Offset;

	private static bool AddEventRepeaterSection_ReturnValue_IsValid;

	private static FFieldAddress AddEventRepeaterSection_ReturnValue_PropertyAddress;

	private static int AddEventRepeaterSection_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneEventTrackExtensions:GetBoundObjectPropertyClass")]
	public unsafe static TSubclassOf<UObject> GetBoundObjectPropertyClass(FMovieSceneEvent EventKey)
	{
		if (!GetBoundObjectPropertyClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneEventTrackExtensions:GetBoundObjectPropertyClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundObjectPropertyClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundObjectPropertyClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBoundObjectPropertyClass_EventKey_PropertyAddress.Address, intPtr);
		FMovieSceneEvent.ToNative(IntPtr.Add(intPtr, GetBoundObjectPropertyClass_EventKey_Offset), 0, GetBoundObjectPropertyClass_EventKey_PropertyAddress.Address, EventKey);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBoundObjectPropertyClass_FunctionAddress, intPtr, GetBoundObjectPropertyClass_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBoundObjectPropertyClass_EventKey_PropertyAddress.Address, intPtr);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetBoundObjectPropertyClass_ReturnValue_Offset), 0, GetBoundObjectPropertyClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventTriggerSection")]
	public unsafe static UMovieSceneEventTriggerSection AddEventTriggerSection(UMovieSceneEventTrack InTrack)
	{
		if (!AddEventTriggerSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventTriggerSection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEventTriggerSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEventTriggerSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneEventTrack>.ToNative(IntPtr.Add(intPtr, AddEventTriggerSection_InTrack_Offset), 0, AddEventTriggerSection_InTrack_PropertyAddress.Address, InTrack);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddEventTriggerSection_FunctionAddress, intPtr, AddEventTriggerSection_ParamsSize);
		return UObjectMarshaler<UMovieSceneEventTriggerSection>.FromNative(IntPtr.Add(intPtr, AddEventTriggerSection_ReturnValue_Offset), 0, AddEventTriggerSection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventRepeaterSection")]
	public unsafe static UMovieSceneEventRepeaterSection AddEventRepeaterSection(UMovieSceneEventTrack InTrack)
	{
		if (!AddEventRepeaterSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventRepeaterSection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddEventRepeaterSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddEventRepeaterSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneEventTrack>.ToNative(IntPtr.Add(intPtr, AddEventRepeaterSection_InTrack_Offset), 0, AddEventRepeaterSection_InTrack_PropertyAddress.Address, InTrack);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddEventRepeaterSection_FunctionAddress, intPtr, AddEventRepeaterSection_ParamsSize);
		return UObjectMarshaler<UMovieSceneEventRepeaterSection>.FromNative(IntPtr.Add(intPtr, AddEventRepeaterSection_ReturnValue_Offset), 0, AddEventRepeaterSection_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneEventTrackExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneEventTrackExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneEventTrackExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneEventTrackExtensions");
		GetBoundObjectPropertyClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBoundObjectPropertyClass");
		GetBoundObjectPropertyClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundObjectPropertyClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjectPropertyClass_EventKey_PropertyAddress, GetBoundObjectPropertyClass_FunctionAddress, "EventKey");
		GetBoundObjectPropertyClass_EventKey_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjectPropertyClass_FunctionAddress, "EventKey");
		GetBoundObjectPropertyClass_EventKey_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjectPropertyClass_FunctionAddress, "EventKey", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBoundObjectPropertyClass_ReturnValue_PropertyAddress, GetBoundObjectPropertyClass_FunctionAddress, "ReturnValue");
		GetBoundObjectPropertyClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundObjectPropertyClass_FunctionAddress, "ReturnValue");
		GetBoundObjectPropertyClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundObjectPropertyClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetBoundObjectPropertyClass_IsValid = GetBoundObjectPropertyClass_FunctionAddress != IntPtr.Zero && GetBoundObjectPropertyClass_EventKey_IsValid && GetBoundObjectPropertyClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneEventTrackExtensions:GetBoundObjectPropertyClass", GetBoundObjectPropertyClass_IsValid);
		AddEventTriggerSection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddEventTriggerSection");
		AddEventTriggerSection_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEventTriggerSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEventTriggerSection_InTrack_PropertyAddress, AddEventTriggerSection_FunctionAddress, "InTrack");
		AddEventTriggerSection_InTrack_Offset = NativeReflectionCached.GetPropertyOffset(AddEventTriggerSection_FunctionAddress, "InTrack");
		AddEventTriggerSection_InTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEventTriggerSection_FunctionAddress, "InTrack", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEventTriggerSection_ReturnValue_PropertyAddress, AddEventTriggerSection_FunctionAddress, "ReturnValue");
		AddEventTriggerSection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddEventTriggerSection_FunctionAddress, "ReturnValue");
		AddEventTriggerSection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEventTriggerSection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddEventTriggerSection_IsValid = AddEventTriggerSection_FunctionAddress != IntPtr.Zero && AddEventTriggerSection_InTrack_IsValid && AddEventTriggerSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventTriggerSection", AddEventTriggerSection_IsValid);
		AddEventRepeaterSection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddEventRepeaterSection");
		AddEventRepeaterSection_ParamsSize = NativeReflection.GetFunctionParamsSize(AddEventRepeaterSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddEventRepeaterSection_InTrack_PropertyAddress, AddEventRepeaterSection_FunctionAddress, "InTrack");
		AddEventRepeaterSection_InTrack_Offset = NativeReflectionCached.GetPropertyOffset(AddEventRepeaterSection_FunctionAddress, "InTrack");
		AddEventRepeaterSection_InTrack_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEventRepeaterSection_FunctionAddress, "InTrack", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddEventRepeaterSection_ReturnValue_PropertyAddress, AddEventRepeaterSection_FunctionAddress, "ReturnValue");
		AddEventRepeaterSection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddEventRepeaterSection_FunctionAddress, "ReturnValue");
		AddEventRepeaterSection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddEventRepeaterSection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddEventRepeaterSection_IsValid = AddEventRepeaterSection_FunctionAddress != IntPtr.Zero && AddEventRepeaterSection_InTrack_IsValid && AddEventRepeaterSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneEventTrackExtensions:AddEventRepeaterSection", AddEventRepeaterSection_IsValid);
	}
}
