using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/UnrealExtent.StatInfoThreshold", "UnrealExtent", UnrealModuleType.Game)]
public struct FStatInfoThreshold
{
	private static bool StatName_IsValid;

	private static int StatName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoThreshold:StatName")]
	public string StatName;

	private static bool Label_IsValid;

	private static int Label_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoThreshold:Label")]
	public string Label;

	private static bool Value_IsValid;

	private static int Value_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoThreshold:Value")]
	public float Value;

	private static bool ValueString_IsValid;

	private static int ValueString_Offset;

	[UProperty(Flags = (PropFlags)6755399441187333uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoThreshold:ValueString")]
	public string ValueString;

	private static bool MediumThreshold_IsValid;

	private static int MediumThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoThreshold:MediumThreshold")]
	public float MediumThreshold;

	private static bool HighThreshold_IsValid;

	private static int HighThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoThreshold:HighThreshold")]
	public float HighThreshold;

	private static bool SevereThreshold_IsValid;

	private static int SevereThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/UnrealExtent.StatInfoThreshold:SevereThreshold")]
	public float SevereThreshold;

	private static bool FStatInfoThreshold_IsValid;

	private static int FStatInfoThreshold_StructSize;

	public FStatInfoThreshold Copy()
	{
		return this;
	}

	public static FStatInfoThreshold FromNative(IntPtr nativeBuffer)
	{
		return new FStatInfoThreshold(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FStatInfoThreshold value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FStatInfoThreshold FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FStatInfoThreshold(nativeBuffer + arrayIndex * FStatInfoThreshold_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FStatInfoThreshold value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FStatInfoThreshold_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FStatInfoThreshold_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.StatInfoThreshold");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, StatName_Offset), StatName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Label_Offset), Label);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Value_Offset), Value);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, ValueString_Offset), ValueString);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MediumThreshold_Offset), MediumThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HighThreshold_Offset), HighThreshold);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SevereThreshold_Offset), SevereThreshold);
	}

	public FStatInfoThreshold(IntPtr nativeStruct)
	{
		if (!FStatInfoThreshold_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/UnrealExtent.StatInfoThreshold");
			StatName = FStringMarshaler.DefaultString;
			Label = FStringMarshaler.DefaultString;
			Value = 0f;
			ValueString = FStringMarshaler.DefaultString;
			MediumThreshold = 0f;
			HighThreshold = 0f;
			SevereThreshold = 0f;
		}
		else
		{
			StatName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, StatName_Offset));
			Label = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Label_Offset));
			Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Value_Offset));
			ValueString = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, ValueString_Offset));
			MediumThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MediumThreshold_Offset));
			HighThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HighThreshold_Offset));
			SevereThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SevereThreshold_Offset));
		}
	}

	static FStatInfoThreshold()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FStatInfoThreshold)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FStatInfoThreshold));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/UnrealExtent.StatInfoThreshold");
		FStatInfoThreshold_StructSize = NativeReflection.GetStructSize(intPtr);
		StatName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StatName");
		StatName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StatName", Classes.FStrProperty);
		Label_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Label");
		Label_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Label", Classes.FStrProperty);
		Value_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Value");
		Value_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Value", Classes.FFloatProperty);
		ValueString_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ValueString");
		ValueString_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ValueString", Classes.FStrProperty);
		MediumThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MediumThreshold");
		MediumThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MediumThreshold", Classes.FFloatProperty);
		HighThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HighThreshold");
		HighThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HighThreshold", Classes.FFloatProperty);
		SevereThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SevereThreshold");
		SevereThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SevereThreshold", Classes.FFloatProperty);
		FStatInfoThreshold_IsValid = intPtr != IntPtr.Zero && StatName_IsValid && Label_IsValid && Value_IsValid && ValueString_IsValid && MediumThreshold_IsValid && HighThreshold_IsValid && SevereThreshold_IsValid;
		NativeReflection.LogStructIsValid("/Script/UnrealExtent.StatInfoThreshold", FStatInfoThreshold_IsValid);
	}
}
