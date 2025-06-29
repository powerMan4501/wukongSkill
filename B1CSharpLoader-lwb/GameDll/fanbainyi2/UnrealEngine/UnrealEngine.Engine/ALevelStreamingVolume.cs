using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.LevelStreamingVolume", "Engine", UnrealModuleType.Engine)]
public class ALevelStreamingVolume : AVolume
{
	private static bool StreamingLevelNames_IsValid;

	private static FFieldAddress StreamingLevelNames_PropertyAddress;

	private static int StreamingLevelNames_Offset;

	private TArrayReadOnlyMarshaler<FName> StreamingLevelNames_MarshalerCached;

	private static bool EditorPreVisOnly_IsValid;

	private static FFieldAddress EditorPreVisOnly_PropertyAddress;

	private static int EditorPreVisOnly_Offset;

	private static bool Disabled_IsValid;

	private static FFieldAddress Disabled_PropertyAddress;

	private static int Disabled_Offset;

	private static bool StreamingUsage_IsValid;

	private static FFieldAddress StreamingUsage_PropertyAddress;

	private static int StreamingUsage_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/Engine.LevelStreamingVolume:StreamingLevelNames")]
	public TArrayReadOnly<FName> StreamingLevelNames
	{
		get
		{
			CheckDestroyed();
			if (!StreamingLevelNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreamingVolume:StreamingLevelNames");
				return null;
			}
			if (StreamingLevelNames_MarshalerCached == null)
			{
				StreamingLevelNames_MarshalerCached = new TArrayReadOnlyMarshaler<FName>(1, StreamingLevelNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return StreamingLevelNames_MarshalerCached.FromNative(IntPtr.Add(base.Address, StreamingLevelNames_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.LevelStreamingVolume:bEditorPreVisOnly")]
	public bool EditorPreVisOnly
	{
		get
		{
			CheckDestroyed();
			if (!EditorPreVisOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreamingVolume:bEditorPreVisOnly");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EditorPreVisOnly_Offset), 0, EditorPreVisOnly_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EditorPreVisOnly_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreamingVolume:bEditorPreVisOnly");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EditorPreVisOnly_Offset), 0, EditorPreVisOnly_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.LevelStreamingVolume:bDisabled")]
	public bool Disabled
	{
		get
		{
			CheckDestroyed();
			if (!Disabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreamingVolume:bDisabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Disabled_Offset), 0, Disabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Disabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreamingVolume:bDisabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Disabled_Offset), 0, Disabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.LevelStreamingVolume:StreamingUsage")]
	public EStreamingVolumeUsage StreamingUsage
	{
		get
		{
			CheckDestroyed();
			if (!StreamingUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreamingVolume:StreamingUsage");
				return EStreamingVolumeUsage.SVB_Loading;
			}
			return EnumMarshaler<EStreamingVolumeUsage>.FromNative(IntPtr.Add(base.Address, StreamingUsage_Offset), 0, StreamingUsage_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StreamingUsage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.LevelStreamingVolume:StreamingUsage");
			}
			else
			{
				EnumMarshaler<EStreamingVolumeUsage>.ToNative(IntPtr.Add(base.Address, StreamingUsage_Offset), 0, StreamingUsage_PropertyAddress.Address, value);
			}
		}
	}

	static ALevelStreamingVolume()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ALevelStreamingVolume)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ALevelStreamingVolume));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.LevelStreamingVolume");
		NativeReflectionCached.GetPropertyRef(ref StreamingLevelNames_PropertyAddress, unrealStruct, "StreamingLevelNames");
		StreamingLevelNames_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StreamingLevelNames");
		StreamingLevelNames_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StreamingLevelNames", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref EditorPreVisOnly_PropertyAddress, unrealStruct, "bEditorPreVisOnly");
		EditorPreVisOnly_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bEditorPreVisOnly");
		EditorPreVisOnly_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bEditorPreVisOnly", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Disabled_PropertyAddress, unrealStruct, "bDisabled");
		Disabled_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bDisabled");
		Disabled_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bDisabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref StreamingUsage_PropertyAddress, unrealStruct, "StreamingUsage");
		StreamingUsage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StreamingUsage");
		StreamingUsage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StreamingUsage", Classes.FByteProperty);
	}
}
