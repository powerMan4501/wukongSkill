using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/b1.GSCameraSequencePlaySetting", "b1", UnrealModuleType.Game)]
public struct FGSCameraSequencePlaySetting
{
	private static bool CameraSequenceList_IsValid;

	private static FFieldAddress CameraSequenceList_PropertyAddress;

	private static int CameraSequenceList_Offset;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:CameraSequenceList")]
	public List<FGSCameraSequenceData> CameraSequenceList;

	private static bool RefRotatorType_IsValid;

	private static FFieldAddress RefRotatorType_PropertyAddress;

	private static int RefRotatorType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:RefRotatorType")]
	public ERefRotatorType RefRotatorType;

	private static bool InCameraBlendType_IsValid;

	private static FFieldAddress InCameraBlendType_PropertyAddress;

	private static int InCameraBlendType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:InCameraBlendType")]
	public ECameraBlendType InCameraBlendType;

	private static bool InCameraBlendSpeed_IsValid;

	private static int InCameraBlendSpeed_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:InCameraBlendSpeed")]
	public float InCameraBlendSpeed;

	private static bool InCameraBlendTimeUseNotifyStateLength_IsValid;

	private static FFieldAddress InCameraBlendTimeUseNotifyStateLength_PropertyAddress;

	private static int InCameraBlendTimeUseNotifyStateLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:InCameraBlendTimeUseNotifyStateLength")]
	public bool InCameraBlendTimeUseNotifyStateLength;

	private static bool InCameraBlendFuncType_IsValid;

	private static FFieldAddress InCameraBlendFuncType_PropertyAddress;

	private static int InCameraBlendFuncType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:InCameraBlendFuncType")]
	public EViewTargetBlendFunction InCameraBlendFuncType;

	private static bool InCameraBlendFuncExp_IsValid;

	private static int InCameraBlendFuncExp_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:InCameraBlendFuncExp")]
	public float InCameraBlendFuncExp;

	private static bool OutCameraBlendTime_IsValid;

	private static int OutCameraBlendTime_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:OutCameraBlendTime")]
	public float OutCameraBlendTime;

	private static bool OutCameraBlendFuncType_IsValid;

	private static FFieldAddress OutCameraBlendFuncType_PropertyAddress;

	private static int OutCameraBlendFuncType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:OutCameraBlendFuncType")]
	public EViewTargetBlendFunction OutCameraBlendFuncType;

	private static bool OutCameraBlendFuncExp_IsValid;

	private static int OutCameraBlendFuncExp_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/b1.GSCameraSequencePlaySetting:OutCameraBlendFuncExp")]
	public float OutCameraBlendFuncExp;

	private static bool FGSCameraSequencePlaySetting_IsValid;

	private static int FGSCameraSequencePlaySetting_StructSize;

	public FGSCameraSequencePlaySetting Copy()
	{
		FGSCameraSequencePlaySetting result = this;
		if (CameraSequenceList != null)
		{
			result.CameraSequenceList = new List<FGSCameraSequenceData>(CameraSequenceList);
		}
		return result;
	}

	public static FGSCameraSequencePlaySetting FromNative(IntPtr nativeBuffer)
	{
		return new FGSCameraSequencePlaySetting(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSCameraSequencePlaySetting value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSCameraSequencePlaySetting FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSCameraSequencePlaySetting(nativeBuffer + arrayIndex * FGSCameraSequencePlaySetting_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSCameraSequencePlaySetting value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSCameraSequencePlaySetting_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSCameraSequencePlaySetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSCameraSequencePlaySetting");
			return;
		}
		new TArrayCopyMarshaler<FGSCameraSequenceData>(1, CameraSequenceList_PropertyAddress, CachedMarshalingDelegates<FGSCameraSequenceData, FGSCameraSequenceData>.FromNative, CachedMarshalingDelegates<FGSCameraSequenceData, FGSCameraSequenceData>.ToNative).ToNative(IntPtr.Add(nativeStruct, CameraSequenceList_Offset), CameraSequenceList);
		EnumMarshaler<ERefRotatorType>.ToNative(IntPtr.Add(nativeStruct, RefRotatorType_Offset), 0, RefRotatorType_PropertyAddress.Address, RefRotatorType);
		EnumMarshaler<ECameraBlendType>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendType_Offset), 0, InCameraBlendType_PropertyAddress.Address, InCameraBlendType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendSpeed_Offset), InCameraBlendSpeed);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, InCameraBlendTimeUseNotifyStateLength_Offset), 0, InCameraBlendTimeUseNotifyStateLength_PropertyAddress.Address, InCameraBlendTimeUseNotifyStateLength);
		EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendFuncType_Offset), 0, InCameraBlendFuncType_PropertyAddress.Address, InCameraBlendFuncType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, InCameraBlendFuncExp_Offset), InCameraBlendFuncExp);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutCameraBlendTime_Offset), OutCameraBlendTime);
		EnumMarshaler<EViewTargetBlendFunction>.ToNative(IntPtr.Add(nativeStruct, OutCameraBlendFuncType_Offset), 0, OutCameraBlendFuncType_PropertyAddress.Address, OutCameraBlendFuncType);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OutCameraBlendFuncExp_Offset), OutCameraBlendFuncExp);
	}

	public FGSCameraSequencePlaySetting(IntPtr nativeStruct)
	{
		if (!FGSCameraSequencePlaySetting_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1.GSCameraSequencePlaySetting");
			CameraSequenceList = null;
			RefRotatorType = ERefRotatorType.Zero;
			InCameraBlendType = ECameraBlendType.None;
			InCameraBlendSpeed = 0f;
			InCameraBlendTimeUseNotifyStateLength = false;
			InCameraBlendFuncType = EViewTargetBlendFunction.VTBlend_Linear;
			InCameraBlendFuncExp = 0f;
			OutCameraBlendTime = 0f;
			OutCameraBlendFuncType = EViewTargetBlendFunction.VTBlend_Linear;
			OutCameraBlendFuncExp = 0f;
		}
		else
		{
			CameraSequenceList = new TArrayCopyMarshaler<FGSCameraSequenceData>(1, CameraSequenceList_PropertyAddress, CachedMarshalingDelegates<FGSCameraSequenceData, FGSCameraSequenceData>.FromNative, CachedMarshalingDelegates<FGSCameraSequenceData, FGSCameraSequenceData>.ToNative).FromNative(IntPtr.Add(nativeStruct, CameraSequenceList_Offset));
			RefRotatorType = EnumMarshaler<ERefRotatorType>.FromNative(IntPtr.Add(nativeStruct, RefRotatorType_Offset), 0, RefRotatorType_PropertyAddress.Address);
			InCameraBlendType = EnumMarshaler<ECameraBlendType>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendType_Offset), 0, InCameraBlendType_PropertyAddress.Address);
			InCameraBlendSpeed = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendSpeed_Offset));
			InCameraBlendTimeUseNotifyStateLength = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, InCameraBlendTimeUseNotifyStateLength_Offset), 0, InCameraBlendTimeUseNotifyStateLength_PropertyAddress.Address);
			InCameraBlendFuncType = EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendFuncType_Offset), 0, InCameraBlendFuncType_PropertyAddress.Address);
			InCameraBlendFuncExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, InCameraBlendFuncExp_Offset));
			OutCameraBlendTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutCameraBlendTime_Offset));
			OutCameraBlendFuncType = EnumMarshaler<EViewTargetBlendFunction>.FromNative(IntPtr.Add(nativeStruct, OutCameraBlendFuncType_Offset), 0, OutCameraBlendFuncType_PropertyAddress.Address);
			OutCameraBlendFuncExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OutCameraBlendFuncExp_Offset));
		}
	}

	static FGSCameraSequencePlaySetting()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSCameraSequencePlaySetting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSCameraSequencePlaySetting));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1.GSCameraSequencePlaySetting");
		FGSCameraSequencePlaySetting_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CameraSequenceList_PropertyAddress, intPtr, "CameraSequenceList");
		CameraSequenceList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CameraSequenceList");
		CameraSequenceList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CameraSequenceList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RefRotatorType_PropertyAddress, intPtr, "RefRotatorType");
		RefRotatorType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RefRotatorType");
		RefRotatorType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RefRotatorType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref InCameraBlendType_PropertyAddress, intPtr, "InCameraBlendType");
		InCameraBlendType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InCameraBlendType");
		InCameraBlendType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InCameraBlendType", Classes.FEnumProperty);
		InCameraBlendSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InCameraBlendSpeed");
		InCameraBlendSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InCameraBlendSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref InCameraBlendTimeUseNotifyStateLength_PropertyAddress, intPtr, "InCameraBlendTimeUseNotifyStateLength");
		InCameraBlendTimeUseNotifyStateLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InCameraBlendTimeUseNotifyStateLength");
		InCameraBlendTimeUseNotifyStateLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InCameraBlendTimeUseNotifyStateLength", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InCameraBlendFuncType_PropertyAddress, intPtr, "InCameraBlendFuncType");
		InCameraBlendFuncType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InCameraBlendFuncType");
		InCameraBlendFuncType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InCameraBlendFuncType", Classes.FByteProperty);
		InCameraBlendFuncExp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InCameraBlendFuncExp");
		InCameraBlendFuncExp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InCameraBlendFuncExp", Classes.FFloatProperty);
		OutCameraBlendTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutCameraBlendTime");
		OutCameraBlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutCameraBlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OutCameraBlendFuncType_PropertyAddress, intPtr, "OutCameraBlendFuncType");
		OutCameraBlendFuncType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutCameraBlendFuncType");
		OutCameraBlendFuncType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutCameraBlendFuncType", Classes.FByteProperty);
		OutCameraBlendFuncExp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OutCameraBlendFuncExp");
		OutCameraBlendFuncExp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OutCameraBlendFuncExp", Classes.FFloatProperty);
		FGSCameraSequencePlaySetting_IsValid = intPtr != IntPtr.Zero && CameraSequenceList_IsValid && RefRotatorType_IsValid && InCameraBlendType_IsValid && InCameraBlendSpeed_IsValid && InCameraBlendTimeUseNotifyStateLength_IsValid && InCameraBlendFuncType_IsValid && InCameraBlendFuncExp_IsValid && OutCameraBlendTime_IsValid && OutCameraBlendFuncType_IsValid && OutCameraBlendFuncExp_IsValid;
		NativeReflection.LogStructIsValid("/Script/b1.GSCameraSequencePlaySetting", FGSCameraSequencePlaySetting_IsValid);
	}
}
