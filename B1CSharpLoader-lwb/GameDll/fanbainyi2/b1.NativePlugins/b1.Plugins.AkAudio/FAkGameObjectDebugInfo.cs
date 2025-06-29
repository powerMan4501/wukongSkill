using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.AkAudio;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo", "AkAudio", UnrealModuleType.GamePlugin)]
public struct FAkGameObjectDebugInfo
{
	private static bool ObjectName_IsValid;

	private static int ObjectName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:ObjectName")]
	public string ObjectName;

	private static bool MaxRadius_IsValid;

	private static int MaxRadius_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:MaxRadius")]
	public float MaxRadius;

	private static bool SoundPosition_IsValid;

	private static int SoundPosition_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:SoundPosition")]
	public FVector SoundPosition;

	private static bool OrientationFront_IsValid;

	private static int OrientationFront_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:OrientationFront")]
	public FVector OrientationFront;

	private static bool OrientationTop_IsValid;

	private static int OrientationTop_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:OrientationTop")]
	public FVector OrientationTop;

	private static bool OrientationRight_IsValid;

	private static int OrientationRight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:OrientationRight")]
	public FVector OrientationRight;

	private static bool PlayingID2EventNames_IsValid;

	private static FFieldAddress PlayingID2EventNames_PropertyAddress;

	private static int PlayingID2EventNames_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:PlayingID2EventNames")]
	public Dictionary<int, string> PlayingID2EventNames;

	private static bool GameObjectID_IsValid;

	private static int GameObjectID_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:GameObjectID")]
	public long GameObjectID;

	private static bool DefaultListener_IsValid;

	private static FFieldAddress DefaultListener_PropertyAddress;

	private static int DefaultListener_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AkAudio.AkGameObjectDebugInfo:bDefaultListener")]
	public bool DefaultListener;

	private static bool FAkGameObjectDebugInfo_IsValid;

	private static int FAkGameObjectDebugInfo_StructSize;

	public FAkGameObjectDebugInfo Copy()
	{
		FAkGameObjectDebugInfo result = this;
		if (PlayingID2EventNames != null)
		{
			result.PlayingID2EventNames = new Dictionary<int, string>(PlayingID2EventNames);
		}
		return result;
	}

	public static FAkGameObjectDebugInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAkGameObjectDebugInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAkGameObjectDebugInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAkGameObjectDebugInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAkGameObjectDebugInfo(nativeBuffer + arrayIndex * FAkGameObjectDebugInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAkGameObjectDebugInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAkGameObjectDebugInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAkGameObjectDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkGameObjectDebugInfo");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ObjectName_Offset), ObjectName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxRadius_Offset), MaxRadius);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, SoundPosition_Offset), SoundPosition);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, OrientationFront_Offset), OrientationFront);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, OrientationTop_Offset), OrientationTop);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, OrientationRight_Offset), OrientationRight);
		new TMapCopyMarshaler<int, string>(1, PlayingID2EventNames_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(nativeStruct, PlayingID2EventNames_Offset), PlayingID2EventNames);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(nativeStruct, GameObjectID_Offset), GameObjectID);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DefaultListener_Offset), 0, DefaultListener_PropertyAddress.Address, DefaultListener);
	}

	public FAkGameObjectDebugInfo(IntPtr nativeStruct)
	{
		if (!FAkGameObjectDebugInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AkAudio.AkGameObjectDebugInfo");
			ObjectName = FStringMarshaler.DefaultString;
			MaxRadius = 0f;
			SoundPosition = default(FVector);
			OrientationFront = default(FVector);
			OrientationTop = default(FVector);
			OrientationRight = default(FVector);
			PlayingID2EventNames = null;
			GameObjectID = 0L;
			DefaultListener = false;
		}
		else
		{
			ObjectName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ObjectName_Offset));
			MaxRadius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxRadius_Offset));
			SoundPosition = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, SoundPosition_Offset));
			OrientationFront = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, OrientationFront_Offset));
			OrientationTop = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, OrientationTop_Offset));
			OrientationRight = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, OrientationRight_Offset));
			PlayingID2EventNames = new TMapCopyMarshaler<int, string>(1, PlayingID2EventNames_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(nativeStruct, PlayingID2EventNames_Offset));
			GameObjectID = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(nativeStruct, GameObjectID_Offset));
			DefaultListener = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DefaultListener_Offset), 0, DefaultListener_PropertyAddress.Address);
		}
	}

	static FAkGameObjectDebugInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAkGameObjectDebugInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAkGameObjectDebugInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AkAudio.AkGameObjectDebugInfo");
		FAkGameObjectDebugInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		ObjectName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObjectName");
		ObjectName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObjectName", Classes.FStrProperty);
		MaxRadius_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxRadius");
		MaxRadius_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxRadius", Classes.FFloatProperty);
		SoundPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SoundPosition");
		SoundPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SoundPosition", Classes.FStructProperty);
		OrientationFront_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrientationFront");
		OrientationFront_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrientationFront", Classes.FStructProperty);
		OrientationTop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrientationTop");
		OrientationTop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrientationTop", Classes.FStructProperty);
		OrientationRight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OrientationRight");
		OrientationRight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OrientationRight", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref PlayingID2EventNames_PropertyAddress, intPtr, "PlayingID2EventNames");
		PlayingID2EventNames_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlayingID2EventNames");
		PlayingID2EventNames_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlayingID2EventNames", Classes.FMapProperty);
		GameObjectID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GameObjectID");
		GameObjectID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GameObjectID", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref DefaultListener_PropertyAddress, intPtr, "bDefaultListener");
		DefaultListener_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDefaultListener");
		DefaultListener_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDefaultListener", Classes.FBoolProperty);
		FAkGameObjectDebugInfo_IsValid = intPtr != IntPtr.Zero && ObjectName_IsValid && MaxRadius_IsValid && SoundPosition_IsValid && OrientationFront_IsValid && OrientationTop_IsValid && OrientationRight_IsValid && PlayingID2EventNames_IsValid && GameObjectID_IsValid && DefaultListener_IsValid;
		NativeReflection.LogStructIsValid("/Script/AkAudio.AkGameObjectDebugInfo", FAkGameObjectDebugInfo_IsValid);
	}
}
