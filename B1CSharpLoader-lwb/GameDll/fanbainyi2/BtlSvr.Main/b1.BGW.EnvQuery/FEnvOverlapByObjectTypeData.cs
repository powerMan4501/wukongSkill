using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UStruct]
[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData")]
public struct FEnvOverlapByObjectTypeData
{
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.UIMin, 0)]
	[Category("Trace")]
	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData:ExtentX")]
	public float ExtentX;

	[UMeta(MDProp.UIMin, 0)]
	[EditDefaultsOnly]
	[Category("Trace")]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData:ExtentY")]
	public float ExtentY;

	[UProperty]
	[EditDefaultsOnly]
	[UMeta(MDProp.UIMin, 0)]
	[UMeta(MDProp.ClampMin, 0)]
	[Category("Trace")]
	[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData:ExtentZ")]
	public float ExtentZ;

	[UProperty]
	[EditDefaultsOnly]
	[Category("Trace")]
	[UMeta(MD.ToolTip, "Offset from the item location at which to test the overlap.  For example, you may need to offset vertically to avoid overlaps with flat ground.")]
	[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData:ShapeOffset")]
	public FVector ShapeOffset;

	[Category("Overlap")]
	[UProperty]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData:OverlapObjectTypes")]
	public List<EObjectTypeQuery> OverlapObjectTypes;

	[UProperty]
	[Category("Overlap")]
	[EditDefaultsOnly]
	[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData:OverlapShape")]
	public EGSSweepCheckShapeType OverlapShape;

	[UProperty]
	[EditDefaultsOnly]
	[Category("Overlap")]
	[USharpPath("/Script/b1-Managed.EnvOverlapByObjectTypeData:bSkipOverlapQuerier")]
	public bool bSkipOverlapQuerier;

	private static int EnvOverlapByObjectTypeData_StructSize;

	private static int EnvOverlapByObjectTypeData_IsValid;

	private static bool ExtentX_IsValid;

	private static int ExtentX_Offset;

	private static bool ExtentY_IsValid;

	private static int ExtentY_Offset;

	private static bool ExtentZ_IsValid;

	private static int ExtentZ_Offset;

	private static bool ShapeOffset_IsValid;

	private static int ShapeOffset_Offset;

	private static bool OverlapObjectTypes_IsValid;

	private static int OverlapObjectTypes_Offset;

	private static FFieldAddress OverlapObjectTypes_PropertyAddress;

	private static bool OverlapShape_IsValid;

	private static int OverlapShape_Offset;

	private static FFieldAddress OverlapShape_PropertyAddress;

	private static bool bSkipOverlapQuerier_IsValid;

	private static int bSkipOverlapQuerier_Offset;

	private static FFieldAddress bSkipOverlapQuerier_PropertyAddress;

	public FEnvOverlapByObjectTypeData Copy()
	{
		FEnvOverlapByObjectTypeData result = this;
		if (OverlapObjectTypes != null)
		{
			result.OverlapObjectTypes = new List<EObjectTypeQuery>(OverlapObjectTypes);
		}
		return result;
	}

	public static FEnvOverlapByObjectTypeData FromNative(IntPtr nativeBuffer)
	{
		return new FEnvOverlapByObjectTypeData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEnvOverlapByObjectTypeData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEnvOverlapByObjectTypeData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEnvOverlapByObjectTypeData(IntPtr.Add(nativeBuffer, arrayIndex * EnvOverlapByObjectTypeData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEnvOverlapByObjectTypeData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EnvOverlapByObjectTypeData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EnvOverlapByObjectTypeData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvOverlapByObjectTypeData");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExtentX_Offset), ExtentX);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExtentY_Offset), ExtentY);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExtentZ_Offset), ExtentZ);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ShapeOffset_Offset), ShapeOffset);
		new TArrayCopyMarshaler<EObjectTypeQuery>(1, OverlapObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).ToNative(IntPtr.Add(nativeStruct, OverlapObjectTypes_Offset), OverlapObjectTypes);
		EnumMarshaler<EGSSweepCheckShapeType>.ToNative(IntPtr.Add(nativeStruct, OverlapShape_Offset), 0, OverlapShape_PropertyAddress.Address, OverlapShape);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bSkipOverlapQuerier_Offset), 0, bSkipOverlapQuerier_PropertyAddress.Address, bSkipOverlapQuerier);
	}

	public FEnvOverlapByObjectTypeData(IntPtr nativeStruct)
	{
		if (EnvOverlapByObjectTypeData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EnvOverlapByObjectTypeData");
			ExtentX = 0f;
			ExtentY = 0f;
			ExtentZ = 0f;
			ShapeOffset = default(FVector);
			OverlapObjectTypes = null;
			OverlapShape = EGSSweepCheckShapeType.Zero;
			bSkipOverlapQuerier = false;
		}
		else
		{
			ExtentX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExtentX_Offset));
			ExtentY = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExtentY_Offset));
			ExtentZ = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExtentZ_Offset));
			ShapeOffset = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ShapeOffset_Offset));
			OverlapObjectTypes = new TArrayCopyMarshaler<EObjectTypeQuery>(1, OverlapObjectTypes_PropertyAddress, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.FromNative, CachedMarshalingDelegates<EObjectTypeQuery, EnumMarshaler<EObjectTypeQuery>>.ToNative).FromNative(IntPtr.Add(nativeStruct, OverlapObjectTypes_Offset));
			OverlapShape = EnumMarshaler<EGSSweepCheckShapeType>.FromNative(IntPtr.Add(nativeStruct, OverlapShape_Offset), 0, OverlapShape_PropertyAddress.Address);
			bSkipOverlapQuerier = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bSkipOverlapQuerier_Offset), 0, bSkipOverlapQuerier_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EnvOverlapByObjectTypeData");
		EnvOverlapByObjectTypeData_StructSize = NativeReflection.GetStructSize(intPtr);
		ExtentX_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtentX");
		ExtentX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtentX", Classes.FFloatProperty);
		ExtentY_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtentY");
		ExtentY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtentY", Classes.FFloatProperty);
		ExtentZ_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtentZ");
		ExtentZ_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtentZ", Classes.FFloatProperty);
		ShapeOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShapeOffset");
		ShapeOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShapeOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OverlapObjectTypes_PropertyAddress, intPtr, "OverlapObjectTypes");
		OverlapObjectTypes_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlapObjectTypes");
		OverlapObjectTypes_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlapObjectTypes", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref OverlapShape_PropertyAddress, intPtr, "OverlapShape");
		OverlapShape_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlapShape");
		OverlapShape_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlapShape", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref bSkipOverlapQuerier_PropertyAddress, intPtr, "bSkipOverlapQuerier");
		bSkipOverlapQuerier_Offset = NativeReflection.GetPropertyOffset(intPtr, "bSkipOverlapQuerier");
		bSkipOverlapQuerier_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bSkipOverlapQuerier", Classes.FBoolProperty);
		EnvOverlapByObjectTypeData_IsValid = ((intPtr != IntPtr.Zero && ExtentX_IsValid && ExtentY_IsValid && ExtentZ_IsValid && ShapeOffset_IsValid && OverlapObjectTypes_IsValid && OverlapShape_IsValid && bSkipOverlapQuerier_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EnvOverlapByObjectTypeData", (byte)EnvOverlapByObjectTypeData_IsValid != 0);
	}

	static FEnvOverlapByObjectTypeData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEnvOverlapByObjectTypeData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEnvOverlapByObjectTypeData));
	}
}
