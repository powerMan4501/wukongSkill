using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SingleAnimationPlayData", "Engine", UnrealModuleType.Engine)]
public struct FSingleAnimationPlayData
{
	private static bool AnimToPlay_IsValid;

	private static int AnimToPlay_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.SingleAnimationPlayData:AnimToPlay")]
	public UAnimationAsset AnimToPlay;

	private static bool SavedLooping_IsValid;

	private static FFieldAddress SavedLooping_PropertyAddress;

	private static int SavedLooping_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SingleAnimationPlayData:bSavedLooping")]
	public bool SavedLooping;

	private static bool SavedPlaying_IsValid;

	private static FFieldAddress SavedPlaying_PropertyAddress;

	private static int SavedPlaying_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.SingleAnimationPlayData:bSavedPlaying")]
	public bool SavedPlaying;

	private static bool SavedPosition_IsValid;

	private static int SavedPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.SingleAnimationPlayData:SavedPosition")]
	public float SavedPosition;

	private static bool SavedPlayRate_IsValid;

	private static int SavedPlayRate_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.SingleAnimationPlayData:SavedPlayRate")]
	public float SavedPlayRate;

	private static bool FSingleAnimationPlayData_IsValid;

	private static int FSingleAnimationPlayData_StructSize;

	public FSingleAnimationPlayData Copy()
	{
		return this;
	}

	public static FSingleAnimationPlayData FromNative(IntPtr nativeBuffer)
	{
		return new FSingleAnimationPlayData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSingleAnimationPlayData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSingleAnimationPlayData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSingleAnimationPlayData(nativeBuffer + arrayIndex * FSingleAnimationPlayData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSingleAnimationPlayData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSingleAnimationPlayData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSingleAnimationPlayData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SingleAnimationPlayData");
			return;
		}
		UObjectMarshaler<UAnimationAsset>.ToNative(IntPtr.Add(nativeStruct, AnimToPlay_Offset), AnimToPlay);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SavedLooping_Offset), 0, SavedLooping_PropertyAddress.Address, SavedLooping);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SavedPlaying_Offset), 0, SavedPlaying_PropertyAddress.Address, SavedPlaying);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SavedPosition_Offset), SavedPosition);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SavedPlayRate_Offset), SavedPlayRate);
	}

	public FSingleAnimationPlayData(IntPtr nativeStruct)
	{
		if (!FSingleAnimationPlayData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SingleAnimationPlayData");
			AnimToPlay = null;
			SavedLooping = false;
			SavedPlaying = false;
			SavedPosition = 0f;
			SavedPlayRate = 0f;
		}
		else
		{
			AnimToPlay = UObjectMarshaler<UAnimationAsset>.FromNative(IntPtr.Add(nativeStruct, AnimToPlay_Offset));
			SavedLooping = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SavedLooping_Offset), 0, SavedLooping_PropertyAddress.Address);
			SavedPlaying = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SavedPlaying_Offset), 0, SavedPlaying_PropertyAddress.Address);
			SavedPosition = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SavedPosition_Offset));
			SavedPlayRate = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SavedPlayRate_Offset));
		}
	}

	static FSingleAnimationPlayData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSingleAnimationPlayData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSingleAnimationPlayData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SingleAnimationPlayData");
		FSingleAnimationPlayData_StructSize = NativeReflection.GetStructSize(intPtr);
		AnimToPlay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AnimToPlay");
		AnimToPlay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AnimToPlay", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SavedLooping_PropertyAddress, intPtr, "bSavedLooping");
		SavedLooping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSavedLooping");
		SavedLooping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSavedLooping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SavedPlaying_PropertyAddress, intPtr, "bSavedPlaying");
		SavedPlaying_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSavedPlaying");
		SavedPlaying_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSavedPlaying", Classes.FBoolProperty);
		SavedPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SavedPosition");
		SavedPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SavedPosition", Classes.FFloatProperty);
		SavedPlayRate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SavedPlayRate");
		SavedPlayRate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SavedPlayRate", Classes.FFloatProperty);
		FSingleAnimationPlayData_IsValid = intPtr != IntPtr.Zero && AnimToPlay_IsValid && SavedLooping_IsValid && SavedPlaying_IsValid && SavedPosition_IsValid && SavedPlayRate_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SingleAnimationPlayData", FSingleAnimationPlayData_IsValid);
	}
}
