using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.LimbIKData")]
public struct LimbIKData
{
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[DisplayName("肢体起始骨骼")]
	[USharpPath("/Script/b1-Managed.LimbIKData:LimbRootBoneName")]
	public FName LimbRootBoneName;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadOnly]
	[DisplayName("肢体末端骨骼")]
	[USharpPath("/Script/b1-Managed.LimbIKData:LimbEndBoneName")]
	public List<FName> LimbEndBoneName;

	[EditAnywhere]
	[BlueprintReadOnly]
	[UProperty]
	[DisplayName("向上检测高度")]
	[USharpPath("/Script/b1-Managed.LimbIKData:LimbTraceUP")]
	public float LimbTraceUP;

	[DisplayName("向下检测距离")]
	[BlueprintReadOnly]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.LimbIKData:LimbTraceDown")]
	public float LimbTraceDown;

	[BlueprintReadOnly]
	[EditAnywhere]
	[UProperty]
	[DisplayName("混合曲线名")]
	[USharpPath("/Script/b1-Managed.LimbIKData:LimbCurveName")]
	public FName LimbCurveName;

	private static int LimbIKData_StructSize;

	private static int LimbIKData_IsValid;

	private static bool LimbRootBoneName_IsValid;

	private static int LimbRootBoneName_Offset;

	private static bool LimbEndBoneName_IsValid;

	private static int LimbEndBoneName_Offset;

	private static FFieldAddress LimbEndBoneName_PropertyAddress;

	private static bool LimbTraceUP_IsValid;

	private static int LimbTraceUP_Offset;

	private static bool LimbTraceDown_IsValid;

	private static int LimbTraceDown_Offset;

	private static bool LimbCurveName_IsValid;

	private static int LimbCurveName_Offset;

	public LimbIKData Copy()
	{
		LimbIKData result = this;
		if (LimbEndBoneName != null)
		{
			result.LimbEndBoneName = new List<FName>(LimbEndBoneName);
		}
		return result;
	}

	public static LimbIKData FromNative(IntPtr nativeBuffer)
	{
		return new LimbIKData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, LimbIKData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static LimbIKData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new LimbIKData(IntPtr.Add(nativeBuffer, arrayIndex * LimbIKData_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, LimbIKData value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * LimbIKData_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (LimbIKData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LimbIKData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, LimbRootBoneName_Offset), LimbRootBoneName);
		new TArrayCopyMarshaler<FName>(1, LimbEndBoneName_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(nativeStruct, LimbEndBoneName_Offset), LimbEndBoneName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LimbTraceUP_Offset), LimbTraceUP);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LimbTraceDown_Offset), LimbTraceDown);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, LimbCurveName_Offset), LimbCurveName);
	}

	public LimbIKData(IntPtr nativeStruct)
	{
		if (LimbIKData_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.LimbIKData");
			LimbRootBoneName = default(FName);
			LimbEndBoneName = null;
			LimbTraceUP = 0f;
			LimbTraceDown = 0f;
			LimbCurveName = default(FName);
		}
		else
		{
			LimbRootBoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, LimbRootBoneName_Offset));
			LimbEndBoneName = new TArrayCopyMarshaler<FName>(1, LimbEndBoneName_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(nativeStruct, LimbEndBoneName_Offset));
			LimbTraceUP = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LimbTraceUP_Offset));
			LimbTraceDown = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LimbTraceDown_Offset));
			LimbCurveName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, LimbCurveName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.LimbIKData");
		LimbIKData_StructSize = NativeReflection.GetStructSize(intPtr);
		LimbRootBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbRootBoneName");
		LimbRootBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbRootBoneName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref LimbEndBoneName_PropertyAddress, intPtr, "LimbEndBoneName");
		LimbEndBoneName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbEndBoneName");
		LimbEndBoneName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbEndBoneName", Classes.FArrayProperty);
		LimbTraceUP_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbTraceUP");
		LimbTraceUP_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbTraceUP", Classes.FFloatProperty);
		LimbTraceDown_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbTraceDown");
		LimbTraceDown_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbTraceDown", Classes.FFloatProperty);
		LimbCurveName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LimbCurveName");
		LimbCurveName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LimbCurveName", Classes.FNameProperty);
		LimbIKData_IsValid = ((intPtr != IntPtr.Zero && LimbRootBoneName_IsValid && LimbEndBoneName_IsValid && LimbTraceUP_IsValid && LimbTraceDown_IsValid && LimbCurveName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.LimbIKData", (byte)LimbIKData_IsValid != 0);
	}

	static LimbIKData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(LimbIKData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(LimbIKData));
	}
}
