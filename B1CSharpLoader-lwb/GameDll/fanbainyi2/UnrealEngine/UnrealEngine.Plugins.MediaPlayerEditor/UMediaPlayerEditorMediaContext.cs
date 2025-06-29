using System;
using UnrealEngine.Runtime;
using UnrealEngine.ToolMenus;

namespace UnrealEngine.Plugins.MediaPlayerEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext", "MediaPlayerEditor", UnrealModuleType.EnginePlugin)]
public class UMediaPlayerEditorMediaContext : UToolMenuContextBase
{
	private static bool SelectedAsset_IsValid;

	private static int SelectedAsset_Offset;

	private static bool StyleSetName_IsValid;

	private static int StyleSetName_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext:SelectedAsset")]
	public UObject SelectedAsset
	{
		get
		{
			CheckDestroyed();
			if (!SelectedAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext:SelectedAsset");
				return null;
			}
			return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(base.Address, SelectedAsset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SelectedAsset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext:SelectedAsset");
			}
			else
			{
				UObjectMarshaler<UObject>.ToNative(IntPtr.Add(base.Address, SelectedAsset_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext:StyleSetName")]
	public FName StyleSetName
	{
		get
		{
			CheckDestroyed();
			if (!StyleSetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext:StyleSetName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StyleSetName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StyleSetName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext:StyleSetName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StyleSetName_Offset), value);
			}
		}
	}

	static UMediaPlayerEditorMediaContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMediaPlayerEditorMediaContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMediaPlayerEditorMediaContext));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/MediaPlayerEditor.MediaPlayerEditorMediaContext");
		SelectedAsset_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SelectedAsset");
		SelectedAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SelectedAsset", Classes.FObjectProperty);
		StyleSetName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "StyleSetName");
		StyleSetName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "StyleSetName", Classes.FNameProperty);
	}
}
