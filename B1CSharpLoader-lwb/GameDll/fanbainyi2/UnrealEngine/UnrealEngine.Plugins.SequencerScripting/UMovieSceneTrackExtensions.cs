using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.SequencerScripting;

[UClass(Flags = (ClassFlags)809500832uL, Config = "Engine")]
[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions", "SequencerScripting", UnrealModuleType.EnginePlugin)]
public class UMovieSceneTrackExtensions : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetTrackRowDisplayName_IsValid;

	private static IntPtr SetTrackRowDisplayName_FunctionAddress;

	private static int SetTrackRowDisplayName_ParamsSize;

	private static bool SetTrackRowDisplayName_Track_IsValid;

	private static FFieldAddress SetTrackRowDisplayName_Track_PropertyAddress;

	private static int SetTrackRowDisplayName_Track_Offset;

	private static bool SetTrackRowDisplayName_InName_IsValid;

	private static FFieldAddress SetTrackRowDisplayName_InName_PropertyAddress;

	private static int SetTrackRowDisplayName_InName_Offset;

	private static bool SetTrackRowDisplayName_RowIndex_IsValid;

	private static FFieldAddress SetTrackRowDisplayName_RowIndex_PropertyAddress;

	private static int SetTrackRowDisplayName_RowIndex_Offset;

	private static bool SetSortingOrder_IsValid;

	private static IntPtr SetSortingOrder_FunctionAddress;

	private static int SetSortingOrder_ParamsSize;

	private static bool SetSortingOrder_Track_IsValid;

	private static FFieldAddress SetSortingOrder_Track_PropertyAddress;

	private static int SetSortingOrder_Track_Offset;

	private static bool SetSortingOrder_SortingOrder_IsValid;

	private static FFieldAddress SetSortingOrder_SortingOrder_PropertyAddress;

	private static int SetSortingOrder_SortingOrder_Offset;

	private static bool SetSectionToKey_IsValid;

	private static IntPtr SetSectionToKey_FunctionAddress;

	private static int SetSectionToKey_ParamsSize;

	private static bool SetSectionToKey_Track_IsValid;

	private static FFieldAddress SetSectionToKey_Track_PropertyAddress;

	private static int SetSectionToKey_Track_Offset;

	private static bool SetSectionToKey_Section_IsValid;

	private static FFieldAddress SetSectionToKey_Section_PropertyAddress;

	private static int SetSectionToKey_Section_Offset;

	private static bool SetDisplayName_IsValid;

	private static IntPtr SetDisplayName_FunctionAddress;

	private static int SetDisplayName_ParamsSize;

	private static bool SetDisplayName_Track_IsValid;

	private static FFieldAddress SetDisplayName_Track_PropertyAddress;

	private static int SetDisplayName_Track_Offset;

	private static bool SetDisplayName_InName_IsValid;

	private static FFieldAddress SetDisplayName_InName_PropertyAddress;

	private static int SetDisplayName_InName_Offset;

	private static bool SetColorTint_IsValid;

	private static IntPtr SetColorTint_FunctionAddress;

	private static int SetColorTint_ParamsSize;

	private static bool SetColorTint_Track_IsValid;

	private static FFieldAddress SetColorTint_Track_PropertyAddress;

	private static int SetColorTint_Track_Offset;

	private static bool SetColorTint_ColorTint_IsValid;

	private static FFieldAddress SetColorTint_ColorTint_PropertyAddress;

	private static int SetColorTint_ColorTint_Offset;

	private static bool RemoveSection_IsValid;

	private static IntPtr RemoveSection_FunctionAddress;

	private static int RemoveSection_ParamsSize;

	private static bool RemoveSection_Track_IsValid;

	private static FFieldAddress RemoveSection_Track_PropertyAddress;

	private static int RemoveSection_Track_Offset;

	private static bool RemoveSection_Section_IsValid;

	private static FFieldAddress RemoveSection_Section_PropertyAddress;

	private static int RemoveSection_Section_Offset;

	private static bool GetTrackRowDisplayName_IsValid;

	private static IntPtr GetTrackRowDisplayName_FunctionAddress;

	private static int GetTrackRowDisplayName_ParamsSize;

	private static bool GetTrackRowDisplayName_Track_IsValid;

	private static FFieldAddress GetTrackRowDisplayName_Track_PropertyAddress;

	private static int GetTrackRowDisplayName_Track_Offset;

	private static bool GetTrackRowDisplayName_RowIndex_IsValid;

	private static FFieldAddress GetTrackRowDisplayName_RowIndex_PropertyAddress;

	private static int GetTrackRowDisplayName_RowIndex_Offset;

	private static bool GetTrackRowDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetTrackRowDisplayName_ReturnValue_PropertyAddress;

	private static int GetTrackRowDisplayName_ReturnValue_Offset;

	private static bool GetSortingOrder_IsValid;

	private static IntPtr GetSortingOrder_FunctionAddress;

	private static int GetSortingOrder_ParamsSize;

	private static bool GetSortingOrder_Track_IsValid;

	private static FFieldAddress GetSortingOrder_Track_PropertyAddress;

	private static int GetSortingOrder_Track_Offset;

	private static bool GetSortingOrder_ReturnValue_IsValid;

	private static FFieldAddress GetSortingOrder_ReturnValue_PropertyAddress;

	private static int GetSortingOrder_ReturnValue_Offset;

	private static bool GetSectionToKey_IsValid;

	private static IntPtr GetSectionToKey_FunctionAddress;

	private static int GetSectionToKey_ParamsSize;

	private static bool GetSectionToKey_Track_IsValid;

	private static FFieldAddress GetSectionToKey_Track_PropertyAddress;

	private static int GetSectionToKey_Track_Offset;

	private static bool GetSectionToKey_ReturnValue_IsValid;

	private static FFieldAddress GetSectionToKey_ReturnValue_PropertyAddress;

	private static int GetSectionToKey_ReturnValue_Offset;

	private static bool GetSections_IsValid;

	private static IntPtr GetSections_FunctionAddress;

	private static int GetSections_ParamsSize;

	private static bool GetSections_Track_IsValid;

	private static FFieldAddress GetSections_Track_PropertyAddress;

	private static int GetSections_Track_Offset;

	private static bool GetSections_ReturnValue_IsValid;

	private static FFieldAddress GetSections_ReturnValue_PropertyAddress;

	private static int GetSections_ReturnValue_Offset;

	private static bool GetDisplayName_IsValid;

	private static IntPtr GetDisplayName_FunctionAddress;

	private static int GetDisplayName_ParamsSize;

	private static bool GetDisplayName_Track_IsValid;

	private static FFieldAddress GetDisplayName_Track_PropertyAddress;

	private static int GetDisplayName_Track_Offset;

	private static bool GetDisplayName_ReturnValue_IsValid;

	private static FFieldAddress GetDisplayName_ReturnValue_PropertyAddress;

	private static int GetDisplayName_ReturnValue_Offset;

	private static bool GetColorTint_IsValid;

	private static IntPtr GetColorTint_FunctionAddress;

	private static int GetColorTint_ParamsSize;

	private static bool GetColorTint_Track_IsValid;

	private static FFieldAddress GetColorTint_Track_PropertyAddress;

	private static int GetColorTint_Track_Offset;

	private static bool GetColorTint_ReturnValue_IsValid;

	private static FFieldAddress GetColorTint_ReturnValue_PropertyAddress;

	private static int GetColorTint_ReturnValue_Offset;

	private static bool AddSection_IsValid;

	private static IntPtr AddSection_FunctionAddress;

	private static int AddSection_ParamsSize;

	private static bool AddSection_Track_IsValid;

	private static FFieldAddress AddSection_Track_PropertyAddress;

	private static int AddSection_Track_Offset;

	private static bool AddSection_ReturnValue_IsValid;

	private static FFieldAddress AddSection_ReturnValue_PropertyAddress;

	private static int AddSection_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:SetTrackRowDisplayName")]
	public unsafe static void SetTrackRowDisplayName(UMovieSceneTrack Track, FText InName, int RowIndex)
	{
		if (!SetTrackRowDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:SetTrackRowDisplayName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetTrackRowDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetTrackRowDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, SetTrackRowDisplayName_Track_Offset), 0, SetTrackRowDisplayName_Track_PropertyAddress.Address, Track);
		NativeReflection.InitializeValue_InContainer(SetTrackRowDisplayName_InName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetTrackRowDisplayName_InName_Offset), 0, SetTrackRowDisplayName_InName_PropertyAddress.Address, InName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetTrackRowDisplayName_RowIndex_Offset), 0, SetTrackRowDisplayName_RowIndex_PropertyAddress.Address, RowIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetTrackRowDisplayName_FunctionAddress, intPtr, SetTrackRowDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetTrackRowDisplayName_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:SetSortingOrder")]
	public unsafe static void SetSortingOrder(UMovieSceneTrack Track, int SortingOrder)
	{
		if (!SetSortingOrder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:SetSortingOrder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSortingOrder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSortingOrder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, SetSortingOrder_Track_Offset), 0, SetSortingOrder_Track_PropertyAddress.Address, Track);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetSortingOrder_SortingOrder_Offset), 0, SetSortingOrder_SortingOrder_PropertyAddress.Address, SortingOrder);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSortingOrder_FunctionAddress, intPtr, SetSortingOrder_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:SetSectionToKey")]
	public unsafe static void SetSectionToKey(UMovieSceneTrack Track, UMovieSceneSection Section)
	{
		if (!SetSectionToKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:SetSectionToKey");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSectionToKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSectionToKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, SetSectionToKey_Track_Offset), 0, SetSectionToKey_Track_PropertyAddress.Address, Track);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, SetSectionToKey_Section_Offset), 0, SetSectionToKey_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetSectionToKey_FunctionAddress, intPtr, SetSectionToKey_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:SetDisplayName")]
	public unsafe static void SetDisplayName(UMovieSceneTrack Track, FText InName)
	{
		if (!SetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:SetDisplayName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, SetDisplayName_Track_Offset), 0, SetDisplayName_Track_PropertyAddress.Address, Track);
		NativeReflection.InitializeValue_InContainer(SetDisplayName_InName_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, SetDisplayName_InName_Offset), 0, SetDisplayName_InName_PropertyAddress.Address, InName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetDisplayName_FunctionAddress, intPtr, SetDisplayName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDisplayName_InName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79832065u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:SetColorTint")]
	public unsafe static void SetColorTint(UMovieSceneTrack Track, FColor ColorTint)
	{
		if (!SetColorTint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:SetColorTint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetColorTint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetColorTint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, SetColorTint_Track_Offset), 0, SetColorTint_Track_PropertyAddress.Address, Track);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, SetColorTint_ColorTint_Offset), 0, SetColorTint_ColorTint_PropertyAddress.Address, ColorTint);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetColorTint_FunctionAddress, intPtr, SetColorTint_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:RemoveSection")]
	public unsafe static void RemoveSection(UMovieSceneTrack Track, UMovieSceneSection Section)
	{
		if (!RemoveSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:RemoveSection");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, RemoveSection_Track_Offset), 0, RemoveSection_Track_PropertyAddress.Address, Track);
		UObjectMarshaler<UMovieSceneSection>.ToNative(IntPtr.Add(intPtr, RemoveSection_Section_Offset), 0, RemoveSection_Section_PropertyAddress.Address, Section);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveSection_FunctionAddress, intPtr, RemoveSection_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:GetTrackRowDisplayName")]
	public unsafe static string GetTrackRowDisplayName(UMovieSceneTrack Track, int RowIndex)
	{
		if (!GetTrackRowDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:GetTrackRowDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTrackRowDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTrackRowDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, GetTrackRowDisplayName_Track_Offset), 0, GetTrackRowDisplayName_Track_PropertyAddress.Address, Track);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTrackRowDisplayName_RowIndex_Offset), 0, GetTrackRowDisplayName_RowIndex_PropertyAddress.Address, RowIndex);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTrackRowDisplayName_FunctionAddress, intPtr, GetTrackRowDisplayName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetTrackRowDisplayName_ReturnValue_Offset), 0, GetTrackRowDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetTrackRowDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSortingOrder")]
	public unsafe static int GetSortingOrder(UMovieSceneTrack Track)
	{
		if (!GetSortingOrder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSortingOrder");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSortingOrder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSortingOrder_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, GetSortingOrder_Track_Offset), 0, GetSortingOrder_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSortingOrder_FunctionAddress, intPtr, GetSortingOrder_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetSortingOrder_ReturnValue_Offset), 0, GetSortingOrder_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSectionToKey")]
	public unsafe static UMovieSceneSection GetSectionToKey(UMovieSceneTrack Track)
	{
		if (!GetSectionToKey_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSectionToKey");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSectionToKey_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSectionToKey_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, GetSectionToKey_Track_Offset), 0, GetSectionToKey_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSectionToKey_FunctionAddress, intPtr, GetSectionToKey_ParamsSize);
		return UObjectMarshaler<UMovieSceneSection>.FromNative(IntPtr.Add(intPtr, GetSectionToKey_ReturnValue_Offset), 0, GetSectionToKey_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSections")]
	public unsafe static List<UMovieSceneSection> GetSections(UMovieSceneTrack Track)
	{
		if (!GetSections_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSections");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSections_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSections_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, GetSections_Track_Offset), 0, GetSections_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSections_FunctionAddress, intPtr, GetSections_ParamsSize);
		List<UMovieSceneSection> result = new TArrayCopyMarshaler<UMovieSceneSection>(1, GetSections_ReturnValue_PropertyAddress, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.FromNative, CachedMarshalingDelegates<UMovieSceneSection, UObjectMarshaler<UMovieSceneSection>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSections_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSections_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:GetDisplayName")]
	public unsafe static string GetDisplayName(UMovieSceneTrack Track)
	{
		if (!GetDisplayName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:GetDisplayName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDisplayName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDisplayName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, GetDisplayName_Track_Offset), 0, GetDisplayName_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDisplayName_FunctionAddress, intPtr, GetDisplayName_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDisplayName_ReturnValue_Offset), 0, GetDisplayName_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDisplayName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 75637761u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:GetColorTint")]
	public unsafe static FColor GetColorTint(UMovieSceneTrack Track)
	{
		if (!GetColorTint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:GetColorTint");
			return default(FColor);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetColorTint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetColorTint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, GetColorTint_Track_Offset), 0, GetColorTint_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetColorTint_FunctionAddress, intPtr, GetColorTint_ParamsSize);
		return BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(intPtr, GetColorTint_ReturnValue_Offset), 0, GetColorTint_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/SequencerScripting.MovieSceneTrackExtensions:AddSection")]
	public unsafe static UMovieSceneSection AddSection(UMovieSceneTrack Track)
	{
		if (!AddSection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/SequencerScripting.MovieSceneTrackExtensions:AddSection");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddSection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddSection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieSceneTrack>.ToNative(IntPtr.Add(intPtr, AddSection_Track_Offset), 0, AddSection_Track_PropertyAddress.Address, Track);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddSection_FunctionAddress, intPtr, AddSection_ParamsSize);
		return UObjectMarshaler<UMovieSceneSection>.FromNative(IntPtr.Add(intPtr, AddSection_ReturnValue_Offset), 0, AddSection_ReturnValue_PropertyAddress.Address);
	}

	static UMovieSceneTrackExtensions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovieSceneTrackExtensions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovieSceneTrackExtensions));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/SequencerScripting.MovieSceneTrackExtensions");
		SetTrackRowDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetTrackRowDisplayName");
		SetTrackRowDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetTrackRowDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetTrackRowDisplayName_Track_PropertyAddress, SetTrackRowDisplayName_FunctionAddress, "Track");
		SetTrackRowDisplayName_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackRowDisplayName_FunctionAddress, "Track");
		SetTrackRowDisplayName_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackRowDisplayName_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrackRowDisplayName_InName_PropertyAddress, SetTrackRowDisplayName_FunctionAddress, "InName");
		SetTrackRowDisplayName_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackRowDisplayName_FunctionAddress, "InName");
		SetTrackRowDisplayName_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackRowDisplayName_FunctionAddress, "InName", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref SetTrackRowDisplayName_RowIndex_PropertyAddress, SetTrackRowDisplayName_FunctionAddress, "RowIndex");
		SetTrackRowDisplayName_RowIndex_Offset = NativeReflectionCached.GetPropertyOffset(SetTrackRowDisplayName_FunctionAddress, "RowIndex");
		SetTrackRowDisplayName_RowIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(SetTrackRowDisplayName_FunctionAddress, "RowIndex", Classes.FIntProperty);
		SetTrackRowDisplayName_IsValid = SetTrackRowDisplayName_FunctionAddress != IntPtr.Zero && SetTrackRowDisplayName_Track_IsValid && SetTrackRowDisplayName_InName_IsValid && SetTrackRowDisplayName_RowIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:SetTrackRowDisplayName", SetTrackRowDisplayName_IsValid);
		SetSortingOrder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSortingOrder");
		SetSortingOrder_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSortingOrder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSortingOrder_Track_PropertyAddress, SetSortingOrder_FunctionAddress, "Track");
		SetSortingOrder_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetSortingOrder_FunctionAddress, "Track");
		SetSortingOrder_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSortingOrder_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSortingOrder_SortingOrder_PropertyAddress, SetSortingOrder_FunctionAddress, "SortingOrder");
		SetSortingOrder_SortingOrder_Offset = NativeReflectionCached.GetPropertyOffset(SetSortingOrder_FunctionAddress, "SortingOrder");
		SetSortingOrder_SortingOrder_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSortingOrder_FunctionAddress, "SortingOrder", Classes.FIntProperty);
		SetSortingOrder_IsValid = SetSortingOrder_FunctionAddress != IntPtr.Zero && SetSortingOrder_Track_IsValid && SetSortingOrder_SortingOrder_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:SetSortingOrder", SetSortingOrder_IsValid);
		SetSectionToKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetSectionToKey");
		SetSectionToKey_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSectionToKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSectionToKey_Track_PropertyAddress, SetSectionToKey_FunctionAddress, "Track");
		SetSectionToKey_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetSectionToKey_FunctionAddress, "Track");
		SetSectionToKey_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSectionToKey_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSectionToKey_Section_PropertyAddress, SetSectionToKey_FunctionAddress, "Section");
		SetSectionToKey_Section_Offset = NativeReflectionCached.GetPropertyOffset(SetSectionToKey_FunctionAddress, "Section");
		SetSectionToKey_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSectionToKey_FunctionAddress, "Section", Classes.FObjectProperty);
		SetSectionToKey_IsValid = SetSectionToKey_FunctionAddress != IntPtr.Zero && SetSectionToKey_Track_IsValid && SetSectionToKey_Section_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:SetSectionToKey", SetSectionToKey_IsValid);
		SetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetDisplayName");
		SetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_Track_PropertyAddress, SetDisplayName_FunctionAddress, "Track");
		SetDisplayName_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "Track");
		SetDisplayName_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetDisplayName_InName_PropertyAddress, SetDisplayName_FunctionAddress, "InName");
		SetDisplayName_InName_Offset = NativeReflectionCached.GetPropertyOffset(SetDisplayName_FunctionAddress, "InName");
		SetDisplayName_InName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDisplayName_FunctionAddress, "InName", Classes.FTextProperty);
		SetDisplayName_IsValid = SetDisplayName_FunctionAddress != IntPtr.Zero && SetDisplayName_Track_IsValid && SetDisplayName_InName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:SetDisplayName", SetDisplayName_IsValid);
		SetColorTint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetColorTint");
		SetColorTint_ParamsSize = NativeReflection.GetFunctionParamsSize(SetColorTint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetColorTint_Track_PropertyAddress, SetColorTint_FunctionAddress, "Track");
		SetColorTint_Track_Offset = NativeReflectionCached.GetPropertyOffset(SetColorTint_FunctionAddress, "Track");
		SetColorTint_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorTint_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SetColorTint_ColorTint_PropertyAddress, SetColorTint_FunctionAddress, "ColorTint");
		SetColorTint_ColorTint_Offset = NativeReflectionCached.GetPropertyOffset(SetColorTint_FunctionAddress, "ColorTint");
		SetColorTint_ColorTint_IsValid = NativeReflectionCached.ValidatePropertyClass(SetColorTint_FunctionAddress, "ColorTint", Classes.FStructProperty);
		SetColorTint_IsValid = SetColorTint_FunctionAddress != IntPtr.Zero && SetColorTint_Track_IsValid && SetColorTint_ColorTint_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:SetColorTint", SetColorTint_IsValid);
		RemoveSection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveSection");
		RemoveSection_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveSection_Track_PropertyAddress, RemoveSection_FunctionAddress, "Track");
		RemoveSection_Track_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSection_FunctionAddress, "Track");
		RemoveSection_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSection_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveSection_Section_PropertyAddress, RemoveSection_FunctionAddress, "Section");
		RemoveSection_Section_Offset = NativeReflectionCached.GetPropertyOffset(RemoveSection_FunctionAddress, "Section");
		RemoveSection_Section_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveSection_FunctionAddress, "Section", Classes.FObjectProperty);
		RemoveSection_IsValid = RemoveSection_FunctionAddress != IntPtr.Zero && RemoveSection_Track_IsValid && RemoveSection_Section_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:RemoveSection", RemoveSection_IsValid);
		GetTrackRowDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTrackRowDisplayName");
		GetTrackRowDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTrackRowDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTrackRowDisplayName_Track_PropertyAddress, GetTrackRowDisplayName_FunctionAddress, "Track");
		GetTrackRowDisplayName_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackRowDisplayName_FunctionAddress, "Track");
		GetTrackRowDisplayName_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackRowDisplayName_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackRowDisplayName_RowIndex_PropertyAddress, GetTrackRowDisplayName_FunctionAddress, "RowIndex");
		GetTrackRowDisplayName_RowIndex_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackRowDisplayName_FunctionAddress, "RowIndex");
		GetTrackRowDisplayName_RowIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackRowDisplayName_FunctionAddress, "RowIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTrackRowDisplayName_ReturnValue_PropertyAddress, GetTrackRowDisplayName_FunctionAddress, "ReturnValue");
		GetTrackRowDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTrackRowDisplayName_FunctionAddress, "ReturnValue");
		GetTrackRowDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTrackRowDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetTrackRowDisplayName_IsValid = GetTrackRowDisplayName_FunctionAddress != IntPtr.Zero && GetTrackRowDisplayName_Track_IsValid && GetTrackRowDisplayName_RowIndex_IsValid && GetTrackRowDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:GetTrackRowDisplayName", GetTrackRowDisplayName_IsValid);
		GetSortingOrder_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSortingOrder");
		GetSortingOrder_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSortingOrder_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSortingOrder_Track_PropertyAddress, GetSortingOrder_FunctionAddress, "Track");
		GetSortingOrder_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetSortingOrder_FunctionAddress, "Track");
		GetSortingOrder_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSortingOrder_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSortingOrder_ReturnValue_PropertyAddress, GetSortingOrder_FunctionAddress, "ReturnValue");
		GetSortingOrder_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSortingOrder_FunctionAddress, "ReturnValue");
		GetSortingOrder_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSortingOrder_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetSortingOrder_IsValid = GetSortingOrder_FunctionAddress != IntPtr.Zero && GetSortingOrder_Track_IsValid && GetSortingOrder_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSortingOrder", GetSortingOrder_IsValid);
		GetSectionToKey_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSectionToKey");
		GetSectionToKey_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSectionToKey_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSectionToKey_Track_PropertyAddress, GetSectionToKey_FunctionAddress, "Track");
		GetSectionToKey_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionToKey_FunctionAddress, "Track");
		GetSectionToKey_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionToKey_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSectionToKey_ReturnValue_PropertyAddress, GetSectionToKey_FunctionAddress, "ReturnValue");
		GetSectionToKey_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSectionToKey_FunctionAddress, "ReturnValue");
		GetSectionToKey_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSectionToKey_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetSectionToKey_IsValid = GetSectionToKey_FunctionAddress != IntPtr.Zero && GetSectionToKey_Track_IsValid && GetSectionToKey_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSectionToKey", GetSectionToKey_IsValid);
		GetSections_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSections");
		GetSections_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSections_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSections_Track_PropertyAddress, GetSections_FunctionAddress, "Track");
		GetSections_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetSections_FunctionAddress, "Track");
		GetSections_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSections_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetSections_ReturnValue_PropertyAddress, GetSections_FunctionAddress, "ReturnValue");
		GetSections_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSections_FunctionAddress, "ReturnValue");
		GetSections_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSections_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSections_IsValid = GetSections_FunctionAddress != IntPtr.Zero && GetSections_Track_IsValid && GetSections_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:GetSections", GetSections_IsValid);
		GetDisplayName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDisplayName");
		GetDisplayName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDisplayName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_Track_PropertyAddress, GetDisplayName_FunctionAddress, "Track");
		GetDisplayName_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "Track");
		GetDisplayName_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDisplayName_ReturnValue_PropertyAddress, GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDisplayName_FunctionAddress, "ReturnValue");
		GetDisplayName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDisplayName_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDisplayName_IsValid = GetDisplayName_FunctionAddress != IntPtr.Zero && GetDisplayName_Track_IsValid && GetDisplayName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:GetDisplayName", GetDisplayName_IsValid);
		GetColorTint_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetColorTint");
		GetColorTint_ParamsSize = NativeReflection.GetFunctionParamsSize(GetColorTint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetColorTint_Track_PropertyAddress, GetColorTint_FunctionAddress, "Track");
		GetColorTint_Track_Offset = NativeReflectionCached.GetPropertyOffset(GetColorTint_FunctionAddress, "Track");
		GetColorTint_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorTint_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetColorTint_ReturnValue_PropertyAddress, GetColorTint_FunctionAddress, "ReturnValue");
		GetColorTint_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetColorTint_FunctionAddress, "ReturnValue");
		GetColorTint_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetColorTint_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetColorTint_IsValid = GetColorTint_FunctionAddress != IntPtr.Zero && GetColorTint_Track_IsValid && GetColorTint_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:GetColorTint", GetColorTint_IsValid);
		AddSection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddSection");
		AddSection_ParamsSize = NativeReflection.GetFunctionParamsSize(AddSection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddSection_Track_PropertyAddress, AddSection_FunctionAddress, "Track");
		AddSection_Track_Offset = NativeReflectionCached.GetPropertyOffset(AddSection_FunctionAddress, "Track");
		AddSection_Track_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSection_FunctionAddress, "Track", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref AddSection_ReturnValue_PropertyAddress, AddSection_FunctionAddress, "ReturnValue");
		AddSection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddSection_FunctionAddress, "ReturnValue");
		AddSection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddSection_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		AddSection_IsValid = AddSection_FunctionAddress != IntPtr.Zero && AddSection_Track_IsValid && AddSection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/SequencerScripting.MovieSceneTrackExtensions:AddSection", AddSection_IsValid);
	}
}
