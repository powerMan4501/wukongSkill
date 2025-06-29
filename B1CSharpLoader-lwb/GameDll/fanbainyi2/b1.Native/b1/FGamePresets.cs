using System;
using System.Runtime.InteropServices;
using UnrealEngine.Runtime;

namespace b1;

[StructLayout(LayoutKind.Sequential, Size = 32)]
[UStruct(Flags = 57345)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.GamePresets", "UnrealExtent", UnrealModuleType.Game)]
public struct FGamePresets
{
	private static bool difficulty_IsValid;

	private static int difficulty_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:difficulty")]
	public int difficulty;

	private static bool priority_IsValid;

	private static int priority_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:priority")]
	public int priority;

	private static bool invertVerticalViewFor1stPersonView_IsValid;

	private static int invertVerticalViewFor1stPersonView_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:invertVerticalViewFor1stPersonView")]
	public int invertVerticalViewFor1stPersonView;

	private static bool invertHorizontalViewFor1stPersonView_IsValid;

	private static int invertHorizontalViewFor1stPersonView_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:invertHorizontalViewFor1stPersonView")]
	public int invertHorizontalViewFor1stPersonView;

	private static bool invertVerticalViewFor3rdPersonView_IsValid;

	private static int invertVerticalViewFor3rdPersonView_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:invertVerticalViewFor3rdPersonView")]
	public int invertVerticalViewFor3rdPersonView;

	private static bool invertHorizontalViewFor3rdPersonView_IsValid;

	private static int invertHorizontalViewFor3rdPersonView_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:invertHorizontalViewFor3rdPersonView")]
	public int invertHorizontalViewFor3rdPersonView;

	private static bool displaySubtitles_IsValid;

	private static int displaySubtitles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:displaySubtitles")]
	public int displaySubtitles;

	private static bool audioLanguage_IsValid;

	private static int audioLanguage_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/UnrealExtent.GamePresets:audioLanguage")]
	public int audioLanguage;

	private static int FGamePresets_StructSize;

	public FGamePresets Copy()
	{
		return this;
	}

	static FGamePresets()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGamePresets)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGamePresets));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetStruct("/Script/UnrealExtent.GamePresets");
		FGamePresets_StructSize = NativeReflection.GetStructSize(unrealStruct);
		difficulty_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "difficulty");
		difficulty_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "difficulty", Classes.FIntProperty);
		priority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "priority");
		priority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "priority", Classes.FIntProperty);
		invertVerticalViewFor1stPersonView_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "invertVerticalViewFor1stPersonView");
		invertVerticalViewFor1stPersonView_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "invertVerticalViewFor1stPersonView", Classes.FIntProperty);
		invertHorizontalViewFor1stPersonView_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "invertHorizontalViewFor1stPersonView");
		invertHorizontalViewFor1stPersonView_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "invertHorizontalViewFor1stPersonView", Classes.FIntProperty);
		invertVerticalViewFor3rdPersonView_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "invertVerticalViewFor3rdPersonView");
		invertVerticalViewFor3rdPersonView_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "invertVerticalViewFor3rdPersonView", Classes.FIntProperty);
		invertHorizontalViewFor3rdPersonView_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "invertHorizontalViewFor3rdPersonView");
		invertHorizontalViewFor3rdPersonView_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "invertHorizontalViewFor3rdPersonView", Classes.FIntProperty);
		displaySubtitles_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "displaySubtitles");
		displaySubtitles_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "displaySubtitles", Classes.FIntProperty);
		audioLanguage_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "audioLanguage");
		audioLanguage_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "audioLanguage", Classes.FIntProperty);
		NativeReflection.ValidateBlittableStructSize(unrealStruct, typeof(FGamePresets));
	}
}
