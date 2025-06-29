using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.PointsRegisterReq")]
public struct FPointsRegisterReq
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.PointsRegisterReq:RegistID")]
	public int RegistID;

	[Category("Anim Notify")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PointsRegisterReq:GenType")]
	public PointsGenType GenType;

	[Category("Anim Notify")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PointsRegisterReq:ExtParam")]
	public PointsGenExtParam ExtParam;

	private static int PointsRegisterReq_StructSize;

	private static int PointsRegisterReq_IsValid;

	private static bool RegistID_IsValid;

	private static int RegistID_Offset;

	private static bool GenType_IsValid;

	private static int GenType_Offset;

	private static FFieldAddress GenType_PropertyAddress;

	private static bool ExtParam_IsValid;

	private static int ExtParam_Offset;

	public FPointsRegisterReq Copy()
	{
		return this;
	}

	public static FPointsRegisterReq FromNative(IntPtr nativeBuffer)
	{
		return new FPointsRegisterReq(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPointsRegisterReq value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPointsRegisterReq FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPointsRegisterReq(IntPtr.Add(nativeBuffer, arrayIndex * PointsRegisterReq_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPointsRegisterReq value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * PointsRegisterReq_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (PointsRegisterReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PointsRegisterReq");
			return;
		}
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RegistID_Offset), RegistID);
		EnumMarshaler<PointsGenType>.ToNative(IntPtr.Add(nativeStruct, GenType_Offset), 0, GenType_PropertyAddress.Address, GenType);
		PointsGenExtParam.ToNative(IntPtr.Add(nativeStruct, ExtParam_Offset), ExtParam);
	}

	public FPointsRegisterReq(IntPtr nativeStruct)
	{
		if (PointsRegisterReq_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.PointsRegisterReq");
			RegistID = 0;
			GenType = PointsGenType.ByEQS_Async;
			ExtParam = default(PointsGenExtParam);
		}
		else
		{
			RegistID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RegistID_Offset));
			GenType = EnumMarshaler<PointsGenType>.FromNative(IntPtr.Add(nativeStruct, GenType_Offset), 0, GenType_PropertyAddress.Address);
			ExtParam = PointsGenExtParam.FromNative(IntPtr.Add(nativeStruct, ExtParam_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.PointsRegisterReq");
		PointsRegisterReq_StructSize = NativeReflection.GetStructSize(intPtr);
		RegistID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RegistID");
		RegistID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RegistID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref GenType_PropertyAddress, intPtr, "GenType");
		GenType_Offset = NativeReflection.GetPropertyOffset(intPtr, "GenType");
		GenType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "GenType", Classes.FEnumProperty);
		ExtParam_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtParam");
		ExtParam_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtParam", Classes.FStructProperty);
		PointsRegisterReq_IsValid = ((intPtr != IntPtr.Zero && RegistID_IsValid && GenType_IsValid && ExtParam_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.PointsRegisterReq", (byte)PointsRegisterReq_IsValid != 0);
	}

	static FPointsRegisterReq()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FPointsRegisterReq)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPointsRegisterReq));
	}
}
