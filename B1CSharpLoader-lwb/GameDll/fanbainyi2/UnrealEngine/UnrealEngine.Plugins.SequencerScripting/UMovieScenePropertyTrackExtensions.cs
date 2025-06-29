using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieScenePropertyTrackExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieScenePropertyTrackExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetPropertyNameAndPath_IsValid;

	private static IntPtr SetPropertyNameAndPath_FunctionAddress;

	private static int SetPropertyNameAndPath_ParamsSize;

	private static bool SetPropertyNameAndPath_Track_IsValid;

	private static FFieldAddress SetPropertyNameAndPath_Track_PropertyAddress;

	private static int SetPropertyNameAndPath_Track_Offset;

	private static bool SetPropertyNameAndPath_InPropertyName_IsValid;

	private static FFieldAddress SetPropertyNameAndPath_InPropertyName_PropertyAddress;

	private static int SetPropertyNameAndPath_InPropertyName_Offset;

	private static bool SetPropertyNameAndPath_InPropertyPath_IsValid;

	private static FFieldAddress SetPropertyNameAndPath_InPropertyPath_PropertyAddress;

	private static int SetPropertyNameAndPath_InPropertyPath_Offset;

	private static bool SetObjectPropertyClass_IsValid;

	private static IntPtr SetObjectPropertyClass_FunctionAddress;

	private static int SetObjectPropertyClass_ParamsSize;

	private static bool SetObjectPropertyClass_Track_IsValid;

	private static FFieldAddress SetObjectPropertyClass_Track_PropertyAddress;

	private static int SetObjectPropertyClass_Track_Offset;

	private static bool SetObjectPropertyClass_PropertyClass_IsValid;

	private static FFieldAddress SetObjectPropertyClass_PropertyClass_PropertyAddress;

	private static int SetObjectPropertyClass_PropertyClass_Offset;

	private static bool GetUniqueTrackName_IsValid;

	private static IntPtr GetUniqueTrackName_FunctionAddress;

	private static int GetUniqueTrackName_ParamsSize;

	private static bool GetUniqueTrackName_Track_IsValid;

	private static FFieldAddress GetUniqueTrackName_Track_PropertyAddress;

	private static int GetUniqueTrackName_Track_Offset;

	private static bool GetUniqueTrackName_ReturnValue_IsValid;

	private static FFieldAddress GetUniqueTrackName_ReturnValue_PropertyAddress;

	private static int GetUniqueTrackName_ReturnValue_Offset;

	private static bool GetPropertyPath_IsValid;

	private static IntPtr GetPropertyPath_FunctionAddress;

	private static int GetPropertyPath_ParamsSize;

	private static bool GetPropertyPath_Track_IsValid;

	private static FFieldAddress GetPropertyPath_Track_PropertyAddress;

	private static int GetPropertyPath_Track_Offset;

	private static bool GetPropertyPath_ReturnValue_IsValid;

	private static FFieldAddress GetPropertyPath_ReturnValue_PropertyAddress;

	private static int GetPropertyPath_ReturnValue_Offset;

	private static bool GetPropertyName_IsValid;

	private static IntPtr GetPropertyName_FunctionAddress;

	private static int GetPropertyName_ParamsSize;

	private static bool GetPropertyName_Track_IsValid;

	private static FFieldAddress GetPropertyName_Track_PropertyAddress;

	private static int GetPropertyName_Track_Offset;

	private static bool GetPropertyName_ReturnValue_IsValid;

	private static FFieldAddress GetPropertyName_ReturnValue_PropertyAddress;

	private static int GetPropertyName_ReturnValue_Offset;

	private static bool GetObjectPropertyClass_IsValid;

	private static IntPtr GetObjectPropertyClass_FunctionAddress;

	private static int GetObjectPropertyClass_ParamsSize;

	private static bool GetObjectPropertyClass_Track_IsValid;

	private static FFieldAddress GetObjectPropertyClass_Track_PropertyAddress;

	private static int GetObjectPropertyClass_Track_Offset;

	private static bool GetObjectPropertyClass_ReturnValue_IsValid;

	private static FFieldAddress GetObjectPropertyClass_ReturnValue_PropertyAddress;

	private static int GetObjectPropertyClass_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetPropertyNameAndPath")]
	public unsafe static void SetPropertyNameAndPath(UMovieScenePropertyTrack Track, FName InPropertyName, string InPropertyPath)
	{
		if (!SetPropertyNameAndPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetPropertyNameAndPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPropertyNameAndPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPropertyNameAndPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieScenePropertyTrack>.ToNative(IntPtr.Add(intPtr, SetPropertyNameAndPath_Track_Offset), 0, SetPropertyNameAndPath_Track_PropertyAddress.Address, Track);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, SetPropertyNameAndPath_InPropertyName_Offset), 0, SetPropertyNameAndPath_InPropertyName_PropertyAddress.Address, InPropertyName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetPropertyNameAndPath_InPropertyPath_Offset), 0, SetPropertyNameAndPath_InPropertyPath_PropertyAddress.Address, InPropertyPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPropertyNameAndPath_FunctionAddress, intPtr, SetPropertyNameAndPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetPropertyNameAndPath_InPropertyPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetObjectPropertyClass")]
	public unsafe static void SetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track, TSubclassOf<UObject> PropertyClass)
	{
		if (!SetObjectPropertyClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetObjectPropertyClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetObjectPropertyClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetObjectPropertyClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneObjectPropertyTrack>.ToNative(IntPtr.Add(intPtr, SetObjectPropertyClass_Track_Offset), 0, SetObjectPropertyClass_Track_PropertyAddress.Address, Track);
		TSubclassOfMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, SetObjectPropertyClass_PropertyClass_Offset), 0, SetObjectPropertyClass_PropertyClass_PropertyAddress.Address, PropertyClass);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetObjectPropertyClass_FunctionAddress, intPtr, SetObjectPropertyClass_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetUniqueTrackName")]
	public unsafe static FName GetUniqueTrackName(UMovieScenePropertyTrack Track)
	{
		if (!GetUniqueTrackName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetUniqueTrackName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUniqueTrackName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUniqueTrackName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieScenePropertyTrack>.ToNative(IntPtr.Add(intPtr, GetUniqueTrackName_Track_Offset), 0, GetUniqueTrackName_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUniqueTrackName_FunctionAddress, intPtr, GetUniqueTrackName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetUniqueTrackName_ReturnValue_Offset), 0, GetUniqueTrackName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyPath")]
	public unsafe static string GetPropertyPath(UMovieScenePropertyTrack Track)
	{
		if (!GetPropertyPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPropertyPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPropertyPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieScenePropertyTrack>.ToNative(IntPtr.Add(intPtr, GetPropertyPath_Track_Offset), 0, GetPropertyPath_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPropertyPath_FunctionAddress, intPtr, GetPropertyPath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPropertyPath_ReturnValue_Offset), 0, GetPropertyPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPropertyPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyName")]
	public unsafe static FName GetPropertyName(UMovieScenePropertyTrack Track)
	{
		if (!GetPropertyName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyName");
			return default(FName);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPropertyName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPropertyName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieScenePropertyTrack>.ToNative(IntPtr.Add(intPtr, GetPropertyName_Track_Offset), 0, GetPropertyName_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPropertyName_FunctionAddress, intPtr, GetPropertyName_ParamsSize);
		return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(intPtr, GetPropertyName_ReturnValue_Offset), 0, GetPropertyName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetObjectPropertyClass")]
	public unsafe static TSubclassOf<UObject> GetObjectPropertyClass(UMovieSceneObjectPropertyTrack Track)
	{
		if (!GetObjectPropertyClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetObjectPropertyClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetObjectPropertyClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetObjectPropertyClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneObjectPropertyTrack>.ToNative(IntPtr.Add(intPtr, GetObjectPropertyClass_Track_Offset), 0, GetObjectPropertyClass_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetObjectPropertyClass_FunctionAddress, intPtr, GetObjectPropertyClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, GetObjectPropertyClass_ReturnValue_Offset), 0, GetObjectPropertyClass_ReturnValue_PropertyAddress.Address);
	}

	static UMovieScenePropertyTrackExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieScenePropertyTrackExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieScenePropertyTrackExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieScenePropertyTrackExtensions");
		SetPropertyNameAndPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPropertyNameAndPath");
		SetPropertyNameAndPath_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPropertyNameAndPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPropertyNameAndPath_Track_PropertyAddress, SetPropertyNameAndPath_FunctionAddress, "Track");
		SetPropertyNameAndPath_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetPropertyNameAndPath_FunctionAddress, "Track");
		SetPropertyNameAndPath_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPropertyNameAndPath_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPropertyNameAndPath_InPropertyName_PropertyAddress, SetPropertyNameAndPath_FunctionAddress, "InPropertyName");
		SetPropertyNameAndPath_InPropertyName_Offset = NativeReflectionCached.GetPropertyOffset(SetPropertyNameAndPath_FunctionAddress, "InPropertyName");
		SetPropertyNameAndPath_InPropertyName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPropertyNameAndPath_FunctionAddress, "InPropertyName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPropertyNameAndPath_InPropertyPath_PropertyAddress, SetPropertyNameAndPath_FunctionAddress, "InPropertyPath");
		SetPropertyNameAndPath_InPropertyPath_Offset = NativeReflectionCached.GetPropertyOffset(SetPropertyNameAndPath_FunctionAddress, "InPropertyPath");
		SetPropertyNameAndPath_InPropertyPath_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPropertyNameAndPath_FunctionAddress, "InPropertyPath", Classes.FStrProperty);
		SetPropertyNameAndPath_IsValid = SetPropertyNameAndPath_FunctionAddress != IntPtr.Zero && SetPropertyNameAndPath_Track_IsValid && SetPropertyNameAndPath_InPropertyName_IsValid && SetPropertyNameAndPath_InPropertyPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetPropertyNameAndPath", SetPropertyNameAndPath_IsValid);
		SetObjectPropertyClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetObjectPropertyClass");
		SetObjectPropertyClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetObjectPropertyClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetObjectPropertyClass_Track_PropertyAddress, SetObjectPropertyClass_FunctionAddress, "Track");
		SetObjectPropertyClass_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectPropertyClass_FunctionAddress, "Track");
		SetObjectPropertyClass_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectPropertyClass_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetObjectPropertyClass_PropertyClass_PropertyAddress, SetObjectPropertyClass_FunctionAddress, "PropertyClass");
		SetObjectPropertyClass_PropertyClass_Offset = NativeReflectionCached.GetPropertyOffset(SetObjectPropertyClass_FunctionAddress, "PropertyClass");
		SetObjectPropertyClass_PropertyClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetObjectPropertyClass_FunctionAddress, "PropertyClass", Classes.FClassProperty);
		SetObjectPropertyClass_IsValid = SetObjectPropertyClass_FunctionAddress != IntPtr.Zero && SetObjectPropertyClass_Track_IsValid && SetObjectPropertyClass_PropertyClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:SetObjectPropertyClass", SetObjectPropertyClass_IsValid);
		GetUniqueTrackName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUniqueTrackName");
		GetUniqueTrackName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUniqueTrackName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueTrackName_Track_PropertyAddress, GetUniqueTrackName_FunctionAddress, "Track");
		GetUniqueTrackName_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueTrackName_FunctionAddress, "Track");
		GetUniqueTrackName_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueTrackName_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUniqueTrackName_ReturnValue_PropertyAddress, GetUniqueTrackName_FunctionAddress, "ReturnValue");
		GetUniqueTrackName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUniqueTrackName_FunctionAddress, "ReturnValue");
		GetUniqueTrackName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUniqueTrackName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetUniqueTrackName_IsValid = GetUniqueTrackName_FunctionAddress != IntPtr.Zero && GetUniqueTrackName_Track_IsValid && GetUniqueTrackName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetUniqueTrackName", GetUniqueTrackName_IsValid);
		GetPropertyPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPropertyPath");
		GetPropertyPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPropertyPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPropertyPath_Track_PropertyAddress, GetPropertyPath_FunctionAddress, "Track");
		GetPropertyPath_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetPropertyPath_FunctionAddress, "Track");
		GetPropertyPath_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPropertyPath_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPropertyPath_ReturnValue_PropertyAddress, GetPropertyPath_FunctionAddress, "ReturnValue");
		GetPropertyPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPropertyPath_FunctionAddress, "ReturnValue");
		GetPropertyPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPropertyPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPropertyPath_IsValid = GetPropertyPath_FunctionAddress != IntPtr.Zero && GetPropertyPath_Track_IsValid && GetPropertyPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyPath", GetPropertyPath_IsValid);
		GetPropertyName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPropertyName");
		GetPropertyName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPropertyName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPropertyName_Track_PropertyAddress, GetPropertyName_FunctionAddress, "Track");
		GetPropertyName_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetPropertyName_FunctionAddress, "Track");
		GetPropertyName_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPropertyName_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPropertyName_ReturnValue_PropertyAddress, GetPropertyName_FunctionAddress, "ReturnValue");
		GetPropertyName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPropertyName_FunctionAddress, "ReturnValue");
		GetPropertyName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPropertyName_FunctionAddress, "ReturnValue", Classes.FNameProperty);
		GetPropertyName_IsValid = GetPropertyName_FunctionAddress != IntPtr.Zero && GetPropertyName_Track_IsValid && GetPropertyName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetPropertyName", GetPropertyName_IsValid);
		GetObjectPropertyClass_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetObjectPropertyClass");
		GetObjectPropertyClass_ParamsSize = NativeReflection.GetFunctionParamsSize(GetObjectPropertyClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetObjectPropertyClass_Track_PropertyAddress, GetObjectPropertyClass_FunctionAddress, "Track");
		GetObjectPropertyClass_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectPropertyClass_FunctionAddress, "Track");
		GetObjectPropertyClass_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectPropertyClass_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetObjectPropertyClass_ReturnValue_PropertyAddress, GetObjectPropertyClass_FunctionAddress, "ReturnValue");
		GetObjectPropertyClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetObjectPropertyClass_FunctionAddress, "ReturnValue");
		GetObjectPropertyClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetObjectPropertyClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		GetObjectPropertyClass_IsValid = GetObjectPropertyClass_FunctionAddress != IntPtr.Zero && GetObjectPropertyClass_Track_IsValid && GetObjectPropertyClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieScenePropertyTrackExtensions:GetObjectPropertyClass", GetObjectPropertyClass_IsValid);
	}
}
