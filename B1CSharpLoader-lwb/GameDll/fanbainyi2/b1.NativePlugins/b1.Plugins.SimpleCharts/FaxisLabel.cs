using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.SimpleCharts;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SimpleCharts.axisLabel", "SimpleCharts", UnrealModuleType.GamePlugin)]
public struct FaxisLabel
{
	private static bool interval_IsValid;

	private static int interval_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.axisLabel:interval")]
	public int interval;

	private static bool rotate_IsValid;

	private static int rotate_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.axisLabel:rotate")]
	public int rotate;

	private static bool Textcolor_IsValid;

	private static int Textcolor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.axisLabel:Textcolor")]
	public FColor Textcolor;

	private static bool fontSize_IsValid;

	private static int fontSize_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.axisLabel:fontSize")]
	public int fontSize;

	private static bool show_IsValid;

	private static FFieldAddress show_PropertyAddress;

	private static int show_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/SimpleCharts.axisLabel:show")]
	public bool show;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/SimpleCharts.axisLabel:Unit")]
	public string Unit;

	private static bool FaxisLabel_IsValid;

	private static int FaxisLabel_StructSize;

	public FaxisLabel Copy()
	{
		return this;
	}

	public static FaxisLabel FromNative(IntPtr nativeBuffer)
	{
		return new FaxisLabel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FaxisLabel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FaxisLabel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FaxisLabel(nativeBuffer + arrayIndex * FaxisLabel_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FaxisLabel value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FaxisLabel_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FaxisLabel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.axisLabel");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, interval_Offset), interval);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, rotate_Offset), rotate);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(nativeStruct, Textcolor_Offset), Textcolor);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, fontSize_Offset), fontSize);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, show_Offset), 0, show_PropertyAddress.Address, show);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
	}

	public FaxisLabel(IntPtr nativeStruct)
	{
		if (!FaxisLabel_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/SimpleCharts.axisLabel");
			interval = 0;
			rotate = 0;
			Textcolor = default(FColor);
			fontSize = 0;
			show = false;
			Unit = FStringMarshaler.DefaultString;
		}
		else
		{
			interval = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, interval_Offset));
			rotate = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, rotate_Offset));
			Textcolor = BlittableTypeMarshaler<FColor>.FromNative(IntPtr.Add(nativeStruct, Textcolor_Offset));
			fontSize = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, fontSize_Offset));
			show = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, show_Offset), 0, show_PropertyAddress.Address);
			Unit = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
		}
	}

	static FaxisLabel()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FaxisLabel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FaxisLabel));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/SimpleCharts.axisLabel");
		FaxisLabel_StructSize = NativeReflection.GetStructSize(intPtr);
		interval_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "interval");
		interval_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "interval", Classes.FIntProperty);
		rotate_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "rotate");
		rotate_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "rotate", Classes.FIntProperty);
		Textcolor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Textcolor");
		Textcolor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Textcolor", Classes.FStructProperty);
		fontSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "fontSize");
		fontSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "fontSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref show_PropertyAddress, intPtr, "show");
		show_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "show");
		show_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "show", Classes.FBoolProperty);
		Unit_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Unit", Classes.FStrProperty);
		FaxisLabel_IsValid = intPtr != IntPtr.Zero && interval_IsValid && rotate_IsValid && Textcolor_IsValid && fontSize_IsValid && show_IsValid && Unit_IsValid;
		NativeReflection.LogStructIsValid("/Script/SimpleCharts.axisLabel", FaxisLabel_IsValid);
	}
}
