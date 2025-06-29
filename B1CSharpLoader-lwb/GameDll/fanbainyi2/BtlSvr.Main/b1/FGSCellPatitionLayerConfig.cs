using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.FGSCellPatitionLayerConfig")]
public struct FGSCellPatitionLayerConfig
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionLayerConfig:CellPartionInstanceName")]
	public string CellPartionInstanceName;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionLayerConfig:Radius")]
	public float Radius;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionLayerConfig:UnitFilter")]
	public int UnitFilter;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionLayerConfig:TeamFilter")]
	public int TeamFilter;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionLayerConfig:Priority")]
	public int Priority;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.FGSCellPatitionLayerConfig:FilterAnd")]
	public bool FilterAnd;

	private static int FGSCellPatitionLayerConfig_StructSize;

	private static int FGSCellPatitionLayerConfig_IsValid;

	private static bool CellPartionInstanceName_IsValid;

	private static int CellPartionInstanceName_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool UnitFilter_IsValid;

	private static int UnitFilter_Offset;

	private static bool TeamFilter_IsValid;

	private static int TeamFilter_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool FilterAnd_IsValid;

	private static int FilterAnd_Offset;

	private static FFieldAddress FilterAnd_PropertyAddress;

	public FGSCellPatitionLayerConfig Copy()
	{
		return this;
	}

	public static FGSCellPatitionLayerConfig FromNative(IntPtr nativeBuffer)
	{
		return new FGSCellPatitionLayerConfig(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSCellPatitionLayerConfig value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSCellPatitionLayerConfig FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSCellPatitionLayerConfig(IntPtr.Add(nativeBuffer, arrayIndex * FGSCellPatitionLayerConfig_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSCellPatitionLayerConfig value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * FGSCellPatitionLayerConfig_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (FGSCellPatitionLayerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSCellPatitionLayerConfig");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, CellPartionInstanceName_Offset), CellPartionInstanceName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Radius_Offset), Radius);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, UnitFilter_Offset), UnitFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, TeamFilter_Offset), TeamFilter);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Priority_Offset), Priority);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FilterAnd_Offset), 0, FilterAnd_PropertyAddress.Address, FilterAnd);
	}

	public FGSCellPatitionLayerConfig(IntPtr nativeStruct)
	{
		if (FGSCellPatitionLayerConfig_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.FGSCellPatitionLayerConfig");
			CellPartionInstanceName = null;
			Radius = 0f;
			UnitFilter = 0;
			TeamFilter = 0;
			Priority = 0;
			FilterAnd = false;
		}
		else
		{
			CellPartionInstanceName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, CellPartionInstanceName_Offset));
			Radius = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Radius_Offset));
			UnitFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, UnitFilter_Offset));
			TeamFilter = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, TeamFilter_Offset));
			Priority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Priority_Offset));
			FilterAnd = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FilterAnd_Offset), 0, FilterAnd_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.FGSCellPatitionLayerConfig");
		FGSCellPatitionLayerConfig_StructSize = NativeReflection.GetStructSize(intPtr);
		CellPartionInstanceName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CellPartionInstanceName");
		CellPartionInstanceName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CellPartionInstanceName", Classes.FStrProperty);
		Radius_Offset = NativeReflection.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		UnitFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitFilter");
		UnitFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitFilter", Classes.FIntProperty);
		TeamFilter_Offset = NativeReflection.GetPropertyOffset(intPtr, "TeamFilter");
		TeamFilter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TeamFilter", Classes.FIntProperty);
		Priority_Offset = NativeReflection.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref FilterAnd_PropertyAddress, intPtr, "FilterAnd");
		FilterAnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterAnd");
		FilterAnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterAnd", Classes.FBoolProperty);
		FGSCellPatitionLayerConfig_IsValid = ((intPtr != IntPtr.Zero && CellPartionInstanceName_IsValid && Radius_IsValid && UnitFilter_IsValid && TeamFilter_IsValid && Priority_IsValid && FilterAnd_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.FGSCellPatitionLayerConfig", (byte)FGSCellPatitionLayerConfig_IsValid != 0);
	}

	static FGSCellPatitionLayerConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGSCellPatitionLayerConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCellPatitionLayerConfig));
	}
}
