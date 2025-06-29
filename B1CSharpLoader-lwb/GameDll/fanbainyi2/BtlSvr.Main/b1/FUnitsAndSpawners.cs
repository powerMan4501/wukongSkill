using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.UnitsAndSpawners")]
public struct FUnitsAndSpawners
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("怪物列表")]
	[USharpPath("/Script/b1-Managed.UnitsAndSpawners:UnitList")]
	public FGsSmartParamArray UnitList;

	[DisplayName("刷怪器列表")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitsAndSpawners:SpawnerList")]
	public FGsSmartParamArray SpawnerList;

	[EditAnywhere]
	[DisplayName("群体单位列表")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UnitsAndSpawners:GroupUnitList")]
	public FGsSmartParamArray GroupUnitList;

	private static int UnitsAndSpawners_StructSize;

	private static int UnitsAndSpawners_IsValid;

	private static bool UnitList_IsValid;

	private static int UnitList_Offset;

	private static bool SpawnerList_IsValid;

	private static int SpawnerList_Offset;

	private static bool GroupUnitList_IsValid;

	private static int GroupUnitList_Offset;

	public FUnitsAndSpawners Copy()
	{
		return this;
	}

	public static FUnitsAndSpawners FromNative(IntPtr nativeBuffer)
	{
		return new FUnitsAndSpawners(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitsAndSpawners value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitsAndSpawners FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitsAndSpawners(IntPtr.Add(nativeBuffer, arrayIndex * UnitsAndSpawners_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitsAndSpawners value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitsAndSpawners_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitsAndSpawners_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitsAndSpawners");
			return;
		}
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, UnitList_Offset), UnitList);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, SpawnerList_Offset), SpawnerList);
		FGsSmartParamArray.ToNative(IntPtr.Add(nativeStruct, GroupUnitList_Offset), GroupUnitList);
	}

	public FUnitsAndSpawners(IntPtr nativeStruct)
	{
		if (UnitsAndSpawners_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitsAndSpawners");
			UnitList = default(FGsSmartParamArray);
			SpawnerList = default(FGsSmartParamArray);
			GroupUnitList = default(FGsSmartParamArray);
		}
		else
		{
			UnitList = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, UnitList_Offset));
			SpawnerList = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, SpawnerList_Offset));
			GroupUnitList = FGsSmartParamArray.FromNative(IntPtr.Add(nativeStruct, GroupUnitList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitsAndSpawners");
		UnitsAndSpawners_StructSize = NativeReflection.GetStructSize(intPtr);
		UnitList_Offset = NativeReflection.GetPropertyOffset(intPtr, "UnitList");
		UnitList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UnitList", Classes.FStructProperty);
		SpawnerList_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnerList");
		SpawnerList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnerList", Classes.FStructProperty);
		GroupUnitList_Offset = NativeReflection.GetPropertyOffset(intPtr, "GroupUnitList");
		GroupUnitList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GroupUnitList", Classes.FStructProperty);
		UnitsAndSpawners_IsValid = ((intPtr != IntPtr.Zero && UnitList_IsValid && SpawnerList_IsValid && GroupUnitList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitsAndSpawners", (byte)UnitsAndSpawners_IsValid != 0);
	}

	static FUnitsAndSpawners()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitsAndSpawners)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitsAndSpawners));
	}
}
