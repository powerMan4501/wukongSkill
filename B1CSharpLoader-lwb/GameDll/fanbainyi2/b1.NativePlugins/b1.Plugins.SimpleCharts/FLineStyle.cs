using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.LineStyle", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FLineStyle
{
	private static bool show_IsValid;

	private static FFieldAddress show_PropertyAddress;

	private static int show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.LineStyle:show")]
	public bool show;

	private static bool color_IsValid;

	private static int color_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.LineStyle:color")]
	public FColor color;

	private static bool width_IsValid;

	private static int width_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.LineStyle:width")]
	public int width;

	private static bool type_IsValid;

	private static FFieldAddress type_PropertyAddress;

	private static int type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.LineStyle:type")]
	public EAxisLineType type;

	private static bool FLineStyle_IsValid;

	private static int FLineStyle_StructSize;

	public FLineStyle Copy()
	{
		return this;
	}

	public static FLineStyle FromNative(IntPtr nativeBuffer)
	{
		return new FLineStyle(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FLineStyle value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FLineStyle FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FLineStyle(nativeBuffer + arrayIndex * FLineStyle_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FLineStyle value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FLineStyle_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FLineStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.LineStyle");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, show_Offset), 0, show_PropertyAddress.Address, show);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, color_Offset), color);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, width_Offset), width);
		EnumMarshaler<EAxisLineType>.ToNative(IntPtr.Add(nativeStruct, type_Offset), 0, type_PropertyAddress.Address, type);
	}

	public FLineStyle(IntPtr nativeStruct)
	{
		if (!FLineStyle_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.LineStyle");
			show = false;
			color = default(FColor);
			width = 0;
			type = EAxisLineType.Solid;
		}
		else
		{
			show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, show_Offset), 0, show_PropertyAddress.Address);
			color = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, color_Offset));
			width = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, width_Offset));
			type = EnumMarshaler<EAxisLineType>.FromNative(IntPtr.Add(nativeStruct, type_Offset), 0, type_PropertyAddress.Address);
		}
	}

	static FLineStyle()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FLineStyle)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FLineStyle));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.LineStyle");
		FLineStyle_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref show_PropertyAddress, intPtr, "show");
		show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "show");
		show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "show", Classes.FBoolProperty);
		color_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "color");
		color_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "color", Classes.FStructProperty);
		width_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "width");
		width_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "width", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref type_PropertyAddress, intPtr, "type");
		type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "type");
		type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "type", Classes.FEnumProperty);
		FLineStyle_IsValid = intPtr != IntPtr.Zero && show_IsValid && color_IsValid && width_IsValid && type_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.LineStyle", FLineStyle_IsValid);
	}
}
