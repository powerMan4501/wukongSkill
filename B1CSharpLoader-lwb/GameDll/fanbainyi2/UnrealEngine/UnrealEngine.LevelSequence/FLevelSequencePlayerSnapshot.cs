using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot", "LevelSequence", UnrealModuleType.Engine)]
public struct FLevelSequencePlayerSnapshot
{
	private static bool MasterName_IsValid;

	private static int MasterName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:MasterName")]
	public string MasterName;

	private static bool MasterTime_IsValid;

	private static int MasterTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160663573uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:MasterTime")]
	public FQualifiedTime MasterTime;

	private static bool SourceTime_IsValid;

	private static int SourceTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160663573uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:SourceTime")]
	public FQualifiedTime SourceTime;

	private static bool CurrentShotName_IsValid;

	private static int CurrentShotName_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:CurrentShotName")]
	public string CurrentShotName;

	private static bool CurrentShotLocalTime_IsValid;

	private static int CurrentShotLocalTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160663573uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:CurrentShotLocalTime")]
	public FQualifiedTime CurrentShotLocalTime;

	private static bool CurrentShotSourceTime_IsValid;

	private static int CurrentShotSourceTime_Offset;

	[UProperty(Flags = (PropFlags)6755468160663573uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:CurrentShotSourceTime")]
	public FQualifiedTime CurrentShotSourceTime;

	private static bool SourceTimecode_IsValid;

	private static int SourceTimecode_Offset;

	[UProperty(Flags = (PropFlags)6755399441187349uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:SourceTimecode")]
	public string SourceTimecode;

	private static bool CameraComponent_IsValid;

	private static int CameraComponent_Offset;

	[UProperty(Flags = (PropFlags)7881299348553757uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:CameraComponent")]
	public TSoftObject<UCameraComponent> CameraComponent;

	private static bool ActiveShot_IsValid;

	private static int ActiveShot_Offset;

	[UProperty(Flags = (PropFlags)7881369141248533uL)]
	[UMetaPath("/Script/LevelSequence.LevelSequencePlayerSnapshot:ActiveShot")]
	public ULevelSequence ActiveShot;

	private static bool FLevelSequencePlayerSnapshot_IsValid;

	private static int FLevelSequencePlayerSnapshot_StructSize;

	public FLevelSequencePlayerSnapshot Copy()
	{
		return this;
	}

	public static FLevelSequencePlayerSnapshot FromNative(IntPtr nativeBuffer)
	{
		return new FLevelSequencePlayerSnapshot(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLevelSequencePlayerSnapshot value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLevelSequencePlayerSnapshot FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLevelSequencePlayerSnapshot(nativeBuffer + arrayIndex * FLevelSequencePlayerSnapshot_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLevelSequencePlayerSnapshot value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLevelSequencePlayerSnapshot_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLevelSequencePlayerSnapshot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequence.LevelSequencePlayerSnapshot");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, MasterName_Offset), MasterName);
		FQualifiedTime.ToNative(IntPtr.Add(nativeStruct, MasterTime_Offset), MasterTime);
		FQualifiedTime.ToNative(IntPtr.Add(nativeStruct, SourceTime_Offset), SourceTime);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CurrentShotName_Offset), CurrentShotName);
		FQualifiedTime.ToNative(IntPtr.Add(nativeStruct, CurrentShotLocalTime_Offset), CurrentShotLocalTime);
		FQualifiedTime.ToNative(IntPtr.Add(nativeStruct, CurrentShotSourceTime_Offset), CurrentShotSourceTime);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, SourceTimecode_Offset), SourceTimecode);
		TSoftObjectMarshaler<UCameraComponent>.ToNative(IntPtr.Add(nativeStruct, CameraComponent_Offset), CameraComponent);
		UObjectMarshaler<ULevelSequence>.ToNative(IntPtr.Add(nativeStruct, ActiveShot_Offset), ActiveShot);
	}

	public FLevelSequencePlayerSnapshot(IntPtr nativeStruct)
	{
		if (!FLevelSequencePlayerSnapshot_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/LevelSequence.LevelSequencePlayerSnapshot");
			MasterName = FStringMarshaler.DefaultString;
			MasterTime = default(FQualifiedTime);
			SourceTime = default(FQualifiedTime);
			CurrentShotName = FStringMarshaler.DefaultString;
			CurrentShotLocalTime = default(FQualifiedTime);
			CurrentShotSourceTime = default(FQualifiedTime);
			SourceTimecode = FStringMarshaler.DefaultString;
			CameraComponent = default(TSoftObject<UCameraComponent>);
			ActiveShot = null;
		}
		else
		{
			MasterName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, MasterName_Offset));
			MasterTime = FQualifiedTime.FromNative(IntPtr.Add(nativeStruct, MasterTime_Offset));
			SourceTime = FQualifiedTime.FromNative(IntPtr.Add(nativeStruct, SourceTime_Offset));
			CurrentShotName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CurrentShotName_Offset));
			CurrentShotLocalTime = FQualifiedTime.FromNative(IntPtr.Add(nativeStruct, CurrentShotLocalTime_Offset));
			CurrentShotSourceTime = FQualifiedTime.FromNative(IntPtr.Add(nativeStruct, CurrentShotSourceTime_Offset));
			SourceTimecode = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, SourceTimecode_Offset));
			CameraComponent = TSoftObjectMarshaler<UCameraComponent>.FromNative(IntPtr.Add(nativeStruct, CameraComponent_Offset));
			ActiveShot = UObjectMarshaler<ULevelSequence>.FromNative(IntPtr.Add(nativeStruct, ActiveShot_Offset));
		}
	}

	static FLevelSequencePlayerSnapshot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLevelSequencePlayerSnapshot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLevelSequencePlayerSnapshot));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/LevelSequence.LevelSequencePlayerSnapshot");
		FLevelSequencePlayerSnapshot_StructSize = NativeReflection.GetStructSize(intPtr);
		MasterName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MasterName");
		MasterName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MasterName", Classes.FStrProperty);
		MasterTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MasterTime");
		MasterTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MasterTime", Classes.FStructProperty);
		SourceTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceTime");
		SourceTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceTime", Classes.FStructProperty);
		CurrentShotName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentShotName");
		CurrentShotName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentShotName", Classes.FStrProperty);
		CurrentShotLocalTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentShotLocalTime");
		CurrentShotLocalTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentShotLocalTime", Classes.FStructProperty);
		CurrentShotSourceTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurrentShotSourceTime");
		CurrentShotSourceTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurrentShotSourceTime", Classes.FStructProperty);
		SourceTimecode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SourceTimecode");
		SourceTimecode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SourceTimecode", Classes.FStrProperty);
		CameraComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraComponent");
		CameraComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraComponent", Classes.FSoftObjectProperty);
		ActiveShot_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActiveShot");
		ActiveShot_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActiveShot", Classes.FObjectProperty);
		FLevelSequencePlayerSnapshot_IsValid = intPtr != IntPtr.Zero && MasterName_IsValid && MasterTime_IsValid && SourceTime_IsValid && CurrentShotName_IsValid && CurrentShotLocalTime_IsValid && CurrentShotSourceTime_IsValid && SourceTimecode_IsValid && CameraComponent_IsValid && ActiveShot_IsValid;
		NativeReflection.LogStructIsValid("/Script/LevelSequence.LevelSequencePlayerSnapshot", FLevelSequencePlayerSnapshot_IsValid);
	}
}
