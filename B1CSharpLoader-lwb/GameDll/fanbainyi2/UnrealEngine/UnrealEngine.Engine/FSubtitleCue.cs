using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.SubtitleCue", "Engine", UnrealModuleType.Engine)]
public struct FSubtitleCue
{
	private static bool Text_IsValid;

	private static int Text_Offset;

	[UProperty(Flags = (PropFlags)4503599627370517uL)]
	[UMetaPath("/Script/Engine.SubtitleCue:Text")]
	public FText Text;

	private static bool Time_IsValid;

	private static int Time_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/Engine.SubtitleCue:Time")]
	public float Time;

	private static bool FSubtitleCue_IsValid;

	private static int FSubtitleCue_StructSize;

	public FSubtitleCue Copy()
	{
		return this;
	}

	public static FSubtitleCue FromNative(IntPtr nativeBuffer)
	{
		return new FSubtitleCue(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSubtitleCue value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSubtitleCue FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSubtitleCue(nativeBuffer + arrayIndex * FSubtitleCue_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSubtitleCue value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSubtitleCue_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSubtitleCue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SubtitleCue");
			return;
		}
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Text_Offset), Text);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Time_Offset), Time);
	}

	public FSubtitleCue(IntPtr nativeStruct)
	{
		if (!FSubtitleCue_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.SubtitleCue");
			Text = null;
			Time = 0f;
		}
		else
		{
			Text = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Text_Offset));
			Time = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Time_Offset));
		}
	}

	static FSubtitleCue()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSubtitleCue)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSubtitleCue));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.SubtitleCue");
		FSubtitleCue_StructSize = NativeReflection.GetStructSize(intPtr);
		Text_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Text");
		Text_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Text", Classes.FTextProperty);
		Time_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Time");
		Time_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Time", Classes.FFloatProperty);
		FSubtitleCue_IsValid = intPtr != IntPtr.Zero && Text_IsValid && Time_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.SubtitleCue", FSubtitleCue_IsValid);
	}
}
