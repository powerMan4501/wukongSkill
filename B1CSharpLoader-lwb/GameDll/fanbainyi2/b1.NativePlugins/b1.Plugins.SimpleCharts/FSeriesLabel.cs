using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.SeriesLabel", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FSeriesLabel
{
	private static bool rotate_IsValid;

	private static int rotate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.SeriesLabel:rotate")]
	public int rotate;

	private static bool Textcolor_IsValid;

	private static int Textcolor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.SeriesLabel:Textcolor")]
	public FColor Textcolor;

	private static bool fontSize_IsValid;

	private static int fontSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.SeriesLabel:fontSize")]
	public int fontSize;

	private static bool show_IsValid;

	private static FFieldAddress show_PropertyAddress;

	private static int show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.SeriesLabel:show")]
	public bool show;

	private static bool Position_IsValid;

	private static FFieldAddress Position_PropertyAddress;

	private static int Position_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.SeriesLabel:Position")]
	public ESeriesLabelPosition Position;

	private static bool FSeriesLabel_IsValid;

	private static int FSeriesLabel_StructSize;

	public FSeriesLabel Copy()
	{
		return this;
	}

	public static FSeriesLabel FromNative(IntPtr nativeBuffer)
	{
		return new FSeriesLabel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FSeriesLabel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FSeriesLabel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSeriesLabel(nativeBuffer + arrayIndex * FSeriesLabel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSeriesLabel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FSeriesLabel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FSeriesLabel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.SeriesLabel");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, rotate_Offset), rotate);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, Textcolor_Offset), Textcolor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, fontSize_Offset), fontSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, show_Offset), 0, show_PropertyAddress.Address, show);
		EnumMarshaler<ESeriesLabelPosition>.ToNative(IntPtr.Add(nativeStruct, Position_Offset), 0, Position_PropertyAddress.Address, Position);
	}

	public FSeriesLabel(IntPtr nativeStruct)
	{
		if (!FSeriesLabel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.SeriesLabel");
			rotate = 0;
			Textcolor = default(FColor);
			fontSize = 0;
			show = false;
			Position = ESeriesLabelPosition.Inside;
		}
		else
		{
			rotate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, rotate_Offset));
			Textcolor = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, Textcolor_Offset));
			fontSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, fontSize_Offset));
			show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, show_Offset), 0, show_PropertyAddress.Address);
			Position = EnumMarshaler<ESeriesLabelPosition>.FromNative(IntPtr.Add(nativeStruct, Position_Offset), 0, Position_PropertyAddress.Address);
		}
	}

	static FSeriesLabel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FSeriesLabel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FSeriesLabel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.SeriesLabel");
		FSeriesLabel_StructSize = NativeReflection.GetStructSize(intPtr);
		rotate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "rotate");
		rotate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "rotate", Classes.FIntProperty);
		Textcolor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Textcolor");
		Textcolor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Textcolor", Classes.FStructProperty);
		fontSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "fontSize");
		fontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "fontSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref show_PropertyAddress, intPtr, "show");
		show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "show");
		show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "show", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Position_PropertyAddress, intPtr, "Position");
		Position_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Position");
		Position_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Position", Classes.FEnumProperty);
		FSeriesLabel_IsValid = intPtr != IntPtr.Zero && rotate_IsValid && Textcolor_IsValid && fontSize_IsValid && show_IsValid && Position_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.SeriesLabel", FSeriesLabel_IsValid);
	}
}
