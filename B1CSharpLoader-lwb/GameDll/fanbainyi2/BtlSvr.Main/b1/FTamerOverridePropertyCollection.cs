using System;
using b1.Plugins.Calliope;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.TamerOverridePropertyCollection")]
public struct FTamerOverridePropertyCollection
{
	[VisibleAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.TamerOverridePropertyCollection:Unit")]
	public FGsSmartParam Unit;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.TamerOverridePropertyCollection:BattleExtendID")]
	public int BattleExtendID;

	private static int TamerOverridePropertyCollection_StructSize;

	private static int TamerOverridePropertyCollection_IsValid;

	private static bool Unit_IsValid;

	private static int Unit_Offset;

	private static bool BattleExtendID_IsValid;

	private static int BattleExtendID_Offset;

	public FTamerOverridePropertyCollection Copy()
	{
		return this;
	}

	public static FTamerOverridePropertyCollection FromNative(IntPtr nativeBuffer)
	{
		return new FTamerOverridePropertyCollection(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FTamerOverridePropertyCollection value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FTamerOverridePropertyCollection FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FTamerOverridePropertyCollection(IntPtr.Add(nativeBuffer, arrayIndex * TamerOverridePropertyCollection_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FTamerOverridePropertyCollection value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * TamerOverridePropertyCollection_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (TamerOverridePropertyCollection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerOverridePropertyCollection");
			return;
		}
		FGsSmartParam.ToNative(IntPtr.Add(nativeStruct, Unit_Offset), Unit);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BattleExtendID_Offset), BattleExtendID);
	}

	public FTamerOverridePropertyCollection(IntPtr nativeStruct)
	{
		if (TamerOverridePropertyCollection_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.TamerOverridePropertyCollection");
			Unit = default(FGsSmartParam);
			BattleExtendID = 0;
		}
		else
		{
			Unit = FGsSmartParam.FromNative(IntPtr.Add(nativeStruct, Unit_Offset));
			BattleExtendID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BattleExtendID_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.TamerOverridePropertyCollection");
		TamerOverridePropertyCollection_StructSize = NativeReflection.GetStructSize(intPtr);
		Unit_Offset = NativeReflection.GetPropertyOffset(intPtr, "Unit");
		Unit_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Unit", Classes.FStructProperty);
		BattleExtendID_Offset = NativeReflection.GetPropertyOffset(intPtr, "BattleExtendID");
		BattleExtendID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BattleExtendID", Classes.FIntProperty);
		TamerOverridePropertyCollection_IsValid = ((intPtr != IntPtr.Zero && Unit_IsValid && BattleExtendID_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.TamerOverridePropertyCollection", (byte)TamerOverridePropertyCollection_IsValid != 0);
	}

	static FTamerOverridePropertyCollection()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FTamerOverridePropertyCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FTamerOverridePropertyCollection));
	}
}
