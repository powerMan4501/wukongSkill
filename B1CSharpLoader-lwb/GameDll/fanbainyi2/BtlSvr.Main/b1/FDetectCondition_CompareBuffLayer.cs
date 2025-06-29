using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.DetectCondition_CompareBuffLayer")]
public struct FDetectCondition_CompareBuffLayer
{
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_CompareBuffLayer:BuffId")]
	public int BuffId;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.DetectCondition_CompareBuffLayer:BuffLayer")]
	public int BuffLayer;

	[UProperty]
	[EditAnywhere]
	[DisplayName("比较方式")]
	[USharpPath("/Script/b1-Managed.DetectCondition_CompareBuffLayer:OperationType")]
	public EValueCompareOperationType OperationType;

	private static int DetectCondition_CompareBuffLayer_StructSize;

	private static int DetectCondition_CompareBuffLayer_IsValid;

	private static bool BuffId_IsValid;

	private static int BuffId_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	private static bool OperationType_IsValid;

	private static int OperationType_Offset;

	private static FFieldAddress OperationType_PropertyAddress;

	public FDetectCondition_CompareBuffLayer Copy()
	{
		return this;
	}

	public static FDetectCondition_CompareBuffLayer FromNative(IntPtr nativeBuffer)
	{
		return new FDetectCondition_CompareBuffLayer(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDetectCondition_CompareBuffLayer value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDetectCondition_CompareBuffLayer FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDetectCondition_CompareBuffLayer(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_CompareBuffLayer_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDetectCondition_CompareBuffLayer value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * DetectCondition_CompareBuffLayer_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (DetectCondition_CompareBuffLayer_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_CompareBuffLayer");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffId_Offset), BuffId);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BuffLayer_Offset), BuffLayer);
		EnumMarshaler<EValueCompareOperationType>.ToNative(IntPtr.Add(nativeStruct, OperationType_Offset), 0, OperationType_PropertyAddress.Address, OperationType);
	}

	public FDetectCondition_CompareBuffLayer(IntPtr nativeStruct)
	{
		if (DetectCondition_CompareBuffLayer_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.DetectCondition_CompareBuffLayer");
			BuffId = 0;
			BuffLayer = 0;
			OperationType = EValueCompareOperationType.EqualTo;
		}
		else
		{
			BuffId = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffId_Offset));
			BuffLayer = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BuffLayer_Offset));
			OperationType = EnumMarshaler<EValueCompareOperationType>.FromNative(IntPtr.Add(nativeStruct, OperationType_Offset), 0, OperationType_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.DetectCondition_CompareBuffLayer");
		DetectCondition_CompareBuffLayer_StructSize = NativeReflection.GetStructSize(intPtr);
		BuffId_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffId");
		BuffId_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffId", Classes.FIntProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(intPtr, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BuffLayer", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref OperationType_PropertyAddress, intPtr, "OperationType");
		OperationType_Offset = NativeReflection.GetPropertyOffset(intPtr, "OperationType");
		OperationType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OperationType", Classes.FEnumProperty);
		DetectCondition_CompareBuffLayer_IsValid = ((intPtr != IntPtr.Zero && BuffId_IsValid && BuffLayer_IsValid && OperationType_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.DetectCondition_CompareBuffLayer", (byte)DetectCondition_CompareBuffLayer_IsValid != 0);
	}

	static FDetectCondition_CompareBuffLayer()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FDetectCondition_CompareBuffLayer)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDetectCondition_CompareBuffLayer));
	}
}
