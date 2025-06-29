using System;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSEQSExParam", "b1", UnrealModuleType.Game)]
public struct FGSEQSExParam
{
	private static bool RunEQSObjReason_IsValid;

	private static FFieldAddress RunEQSObjReason_PropertyAddress;

	private static int RunEQSObjReason_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQSExParam:RunEQSObjReason")]
	public EBGURunEQSObjReason RunEQSObjReason;

	private static bool ExParam_Bool_IsValid;

	private static FFieldAddress ExParam_Bool_PropertyAddress;

	private static int ExParam_Bool_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQSExParam:ExParam_Bool")]
	public bool ExParam_Bool;

	private static bool ExParam_Int_IsValid;

	private static int ExParam_Int_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQSExParam:ExParam_Int")]
	public int ExParam_Int;

	private static bool ExParam_Int2_IsValid;

	private static int ExParam_Int2_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSEQSExParam:ExParam_Int2")]
	public int ExParam_Int2;

	private static bool FGSEQSExParam_IsValid;

	private static int FGSEQSExParam_StructSize;

	public FGSEQSExParam Copy()
	{
		return this;
	}

	public static FGSEQSExParam FromNative(IntPtr nativeBuffer)
	{
		return new FGSEQSExParam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSEQSExParam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSEQSExParam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSEQSExParam(nativeBuffer + arrayIndex * FGSEQSExParam_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSEQSExParam value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSEQSExParam_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSEQSExParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSEQSExParam");
			return;
		}
		EnumMarshaler<EBGURunEQSObjReason>.ToNative(IntPtr.Add(nativeStruct, RunEQSObjReason_Offset), 0, RunEQSObjReason_PropertyAddress.Address, RunEQSObjReason);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ExParam_Bool_Offset), 0, ExParam_Bool_PropertyAddress.Address, ExParam_Bool);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExParam_Int_Offset), ExParam_Int);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ExParam_Int2_Offset), ExParam_Int2);
	}

	public FGSEQSExParam(IntPtr nativeStruct)
	{
		if (!FGSEQSExParam_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSEQSExParam");
			RunEQSObjReason = EBGURunEQSObjReason.None;
			ExParam_Bool = false;
			ExParam_Int = 0;
			ExParam_Int2 = 0;
		}
		else
		{
			RunEQSObjReason = EnumMarshaler<EBGURunEQSObjReason>.FromNative(IntPtr.Add(nativeStruct, RunEQSObjReason_Offset), 0, RunEQSObjReason_PropertyAddress.Address);
			ExParam_Bool = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ExParam_Bool_Offset), 0, ExParam_Bool_PropertyAddress.Address);
			ExParam_Int = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExParam_Int_Offset));
			ExParam_Int2 = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ExParam_Int2_Offset));
		}
	}

	static FGSEQSExParam()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSEQSExParam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSEQSExParam));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSEQSExParam");
		FGSEQSExParam_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref RunEQSObjReason_PropertyAddress, intPtr, "RunEQSObjReason");
		RunEQSObjReason_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RunEQSObjReason");
		RunEQSObjReason_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RunEQSObjReason", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref ExParam_Bool_PropertyAddress, intPtr, "ExParam_Bool");
		ExParam_Bool_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExParam_Bool");
		ExParam_Bool_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExParam_Bool", Classes.FBoolProperty);
		ExParam_Int_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExParam_Int");
		ExParam_Int_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExParam_Int", Classes.FIntProperty);
		ExParam_Int2_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExParam_Int2");
		ExParam_Int2_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExParam_Int2", Classes.FIntProperty);
		FGSEQSExParam_IsValid = intPtr != IntPtr.Zero && RunEQSObjReason_IsValid && ExParam_Bool_IsValid && ExParam_Int_IsValid && ExParam_Int2_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSEQSExParam", FGSEQSExParam_IsValid);
	}
}
