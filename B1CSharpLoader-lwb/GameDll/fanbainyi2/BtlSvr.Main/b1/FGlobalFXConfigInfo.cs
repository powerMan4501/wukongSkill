using System;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo")]
public struct FGlobalFXConfigInfo
{
	[UProperty]
	[EditAnywhere]
	[DisplayName("全局特效")]
	[Category("Disp")]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:FXTemplate")]
	public UNiagaraSystem FXTemplate;

	[EditAnywhere]
	[UProperty]
	[DisplayName("特效Tag")]
	[Category("Disp")]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:FXTag")]
	public FGameplayTag FXTag;

	[UProperty]
	[DisplayName("子弹位置参数名")]
	[Category("Disp")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:BulletPositionParamName")]
	public FName BulletPositionParamName;

	[UProperty]
	[Category("Disp")]
	[EditAnywhere]
	[DisplayName("法术场位置参数名")]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:MFSpherePosParamName")]
	public FName MFSpherePosParamName;

	[EditAnywhere]
	[DisplayName("法术场半径参数名")]
	[Category("Disp")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:MFSphereRadiusParamName")]
	public FName MFSphereRadiusParamName;

	[EditAnywhere]
	[Category("Disp")]
	[DisplayName("法术场半径参数使用数组")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:bMFSphereUseRadiusArray")]
	public bool bMFSphereUseRadiusArray;

	[DisplayName("安身术位置参数名")]
	[EditAnywhere]
	[UProperty]
	[Category("Disp")]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:AvoidanceMFSpherePosParamName")]
	public FName AvoidanceMFSpherePosParamName;

	[EditAnywhere]
	[DisplayName("安身术半径参数名")]
	[Category("Disp")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:AvoidanceMFSphereRadiusParamName")]
	public FName AvoidanceMFSphereRadiusParamName;

	[UProperty]
	[EditAnywhere]
	[DisplayName("安身术半径参数使用数组")]
	[Category("Disp")]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:bAvoidanceMFSphereUseRadiusArray")]
	public bool bAvoidanceMFSphereUseRadiusArray;

	[UProperty]
	[EditAnywhere]
	[DisplayName("特效起始位置SceneItem的Tag")]
	[Category("Disp")]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:FXStartPointTag")]
	public FName FXStartPointTag;

	[DisplayName("特效起始位置参数名")]
	[Category("Disp")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GlobalFXConfigInfo:FXStartPointParamName")]
	public FName FXStartPointParamName;

	private static int GlobalFXConfigInfo_StructSize;

	private static int GlobalFXConfigInfo_IsValid;

	private static bool FXTemplate_IsValid;

	private static int FXTemplate_Offset;

	private static bool FXTag_IsValid;

	private static int FXTag_Offset;

	private static bool BulletPositionParamName_IsValid;

	private static int BulletPositionParamName_Offset;

	private static bool MFSpherePosParamName_IsValid;

	private static int MFSpherePosParamName_Offset;

	private static bool MFSphereRadiusParamName_IsValid;

	private static int MFSphereRadiusParamName_Offset;

	private static bool bMFSphereUseRadiusArray_IsValid;

	private static int bMFSphereUseRadiusArray_Offset;

	private static FFieldAddress bMFSphereUseRadiusArray_PropertyAddress;

	private static bool AvoidanceMFSpherePosParamName_IsValid;

	private static int AvoidanceMFSpherePosParamName_Offset;

	private static bool AvoidanceMFSphereRadiusParamName_IsValid;

	private static int AvoidanceMFSphereRadiusParamName_Offset;

	private static bool bAvoidanceMFSphereUseRadiusArray_IsValid;

	private static int bAvoidanceMFSphereUseRadiusArray_Offset;

	private static FFieldAddress bAvoidanceMFSphereUseRadiusArray_PropertyAddress;

	private static bool FXStartPointTag_IsValid;

	private static int FXStartPointTag_Offset;

	private static bool FXStartPointParamName_IsValid;

	private static int FXStartPointParamName_Offset;

	public FGlobalFXConfigInfo Copy()
	{
		return this;
	}

	public static FGlobalFXConfigInfo FromNative(IntPtr nativeBuffer)
	{
		return new FGlobalFXConfigInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGlobalFXConfigInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGlobalFXConfigInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGlobalFXConfigInfo(IntPtr.Add(nativeBuffer, arrayIndex * GlobalFXConfigInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGlobalFXConfigInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * GlobalFXConfigInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (GlobalFXConfigInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GlobalFXConfigInfo");
			return;
		}
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, FXTemplate_Offset), FXTemplate);
		BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(nativeStruct, FXTag_Offset), FXTag);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BulletPositionParamName_Offset), BulletPositionParamName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MFSpherePosParamName_Offset), MFSpherePosParamName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, MFSphereRadiusParamName_Offset), MFSphereRadiusParamName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bMFSphereUseRadiusArray_Offset), 0, bMFSphereUseRadiusArray_PropertyAddress.Address, bMFSphereUseRadiusArray);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AvoidanceMFSpherePosParamName_Offset), AvoidanceMFSpherePosParamName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, AvoidanceMFSphereRadiusParamName_Offset), AvoidanceMFSphereRadiusParamName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bAvoidanceMFSphereUseRadiusArray_Offset), 0, bAvoidanceMFSphereUseRadiusArray_PropertyAddress.Address, bAvoidanceMFSphereUseRadiusArray);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, FXStartPointTag_Offset), FXStartPointTag);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, FXStartPointParamName_Offset), FXStartPointParamName);
	}

	public FGlobalFXConfigInfo(IntPtr nativeStruct)
	{
		if (GlobalFXConfigInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.GlobalFXConfigInfo");
			FXTemplate = null;
			FXTag = default(FGameplayTag);
			BulletPositionParamName = default(FName);
			MFSpherePosParamName = default(FName);
			MFSphereRadiusParamName = default(FName);
			bMFSphereUseRadiusArray = false;
			AvoidanceMFSpherePosParamName = default(FName);
			AvoidanceMFSphereRadiusParamName = default(FName);
			bAvoidanceMFSphereUseRadiusArray = false;
			FXStartPointTag = default(FName);
			FXStartPointParamName = default(FName);
		}
		else
		{
			FXTemplate = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, FXTemplate_Offset));
			FXTag = BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(nativeStruct, FXTag_Offset));
			BulletPositionParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BulletPositionParamName_Offset));
			MFSpherePosParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MFSpherePosParamName_Offset));
			MFSphereRadiusParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, MFSphereRadiusParamName_Offset));
			bMFSphereUseRadiusArray = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bMFSphereUseRadiusArray_Offset), 0, bMFSphereUseRadiusArray_PropertyAddress.Address);
			AvoidanceMFSpherePosParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AvoidanceMFSpherePosParamName_Offset));
			AvoidanceMFSphereRadiusParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, AvoidanceMFSphereRadiusParamName_Offset));
			bAvoidanceMFSphereUseRadiusArray = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bAvoidanceMFSphereUseRadiusArray_Offset), 0, bAvoidanceMFSphereUseRadiusArray_PropertyAddress.Address);
			FXStartPointTag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, FXStartPointTag_Offset));
			FXStartPointParamName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, FXStartPointParamName_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.GlobalFXConfigInfo");
		GlobalFXConfigInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		FXTemplate_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXTemplate");
		FXTemplate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXTemplate", Classes.FObjectProperty);
		FXTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXTag");
		FXTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXTag", Classes.FStructProperty);
		BulletPositionParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "BulletPositionParamName");
		BulletPositionParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BulletPositionParamName", Classes.FNameProperty);
		MFSpherePosParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "MFSpherePosParamName");
		MFSpherePosParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MFSpherePosParamName", Classes.FNameProperty);
		MFSphereRadiusParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "MFSphereRadiusParamName");
		MFSphereRadiusParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MFSphereRadiusParamName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bMFSphereUseRadiusArray_PropertyAddress, intPtr, "bMFSphereUseRadiusArray");
		bMFSphereUseRadiusArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "bMFSphereUseRadiusArray");
		bMFSphereUseRadiusArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bMFSphereUseRadiusArray", Classes.FBoolProperty);
		AvoidanceMFSpherePosParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AvoidanceMFSpherePosParamName");
		AvoidanceMFSpherePosParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AvoidanceMFSpherePosParamName", Classes.FNameProperty);
		AvoidanceMFSphereRadiusParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AvoidanceMFSphereRadiusParamName");
		AvoidanceMFSphereRadiusParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AvoidanceMFSphereRadiusParamName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref bAvoidanceMFSphereUseRadiusArray_PropertyAddress, intPtr, "bAvoidanceMFSphereUseRadiusArray");
		bAvoidanceMFSphereUseRadiusArray_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAvoidanceMFSphereUseRadiusArray");
		bAvoidanceMFSphereUseRadiusArray_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAvoidanceMFSphereUseRadiusArray", Classes.FBoolProperty);
		FXStartPointTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXStartPointTag");
		FXStartPointTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXStartPointTag", Classes.FNameProperty);
		FXStartPointParamName_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXStartPointParamName");
		FXStartPointParamName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXStartPointParamName", Classes.FNameProperty);
		GlobalFXConfigInfo_IsValid = ((intPtr != IntPtr.Zero && FXTemplate_IsValid && FXTag_IsValid && BulletPositionParamName_IsValid && MFSpherePosParamName_IsValid && MFSphereRadiusParamName_IsValid && bMFSphereUseRadiusArray_IsValid && AvoidanceMFSpherePosParamName_IsValid && AvoidanceMFSphereRadiusParamName_IsValid && bAvoidanceMFSphereUseRadiusArray_IsValid && FXStartPointTag_IsValid && FXStartPointParamName_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.GlobalFXConfigInfo", (byte)GlobalFXConfigInfo_IsValid != 0);
	}

	static FGlobalFXConfigInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FGlobalFXConfigInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGlobalFXConfigInfo));
	}
}
