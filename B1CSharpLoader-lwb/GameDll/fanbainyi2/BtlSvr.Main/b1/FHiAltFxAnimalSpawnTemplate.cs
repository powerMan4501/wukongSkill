using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate")]
public struct FHiAltFxAnimalSpawnTemplate
{
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("随机特效生物列表")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate:FXAnimalTemplateList")]
	public List<TSubclassOf<BGUFXAnimalActor>> FXAnimalTemplateList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("随机EQS列表")]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate:EQSTemplateList")]
	public List<UEnvQuery> EQSTemplateList;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("生成点Z轴上下随机浮动")]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate:ZOffset")]
	public FFloatRange ZOffset;

	[EditAnywhere]
	[Tooltip("false:在得到的点集中随机选择")]
	[UProperty]
	[DisplayName("使用得分最高的点")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate:bUseHighestScorePoint")]
	public bool bUseHighestScorePoint;

	[UProperty]
	[EditAnywhere]
	[DisplayName("生成朝向信息")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate:RotInfo")]
	public FHiAltFxAnimalRotInfo RotInfo;

	[UProperty]
	[DisplayName("上一轮消失后再次刷新的CD")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate:ReSpawnCoolDown")]
	public float ReSpawnCoolDown;

	private static int HiAltFxAnimalSpawnTemplate_StructSize;

	private static int HiAltFxAnimalSpawnTemplate_IsValid;

	private static bool FXAnimalTemplateList_IsValid;

	private static int FXAnimalTemplateList_Offset;

	private static FFieldAddress FXAnimalTemplateList_PropertyAddress;

	private static bool EQSTemplateList_IsValid;

	private static int EQSTemplateList_Offset;

	private static FFieldAddress EQSTemplateList_PropertyAddress;

	private static bool ZOffset_IsValid;

	private static int ZOffset_Offset;

	private static bool bUseHighestScorePoint_IsValid;

	private static int bUseHighestScorePoint_Offset;

	private static FFieldAddress bUseHighestScorePoint_PropertyAddress;

	private static bool RotInfo_IsValid;

	private static int RotInfo_Offset;

	private static bool ReSpawnCoolDown_IsValid;

	private static int ReSpawnCoolDown_Offset;

	public bool IsValid()
	{
		if (FXAnimalTemplateList.Count < 1 || EQSTemplateList.Count < 1)
		{
			return false;
		}
		foreach (TSubclassOf<BGUFXAnimalActor> fXAnimalTemplate in FXAnimalTemplateList)
		{
			if (fXAnimalTemplate == null)
			{
				return false;
			}
		}
		return true;
	}

	public FHiAltFxAnimalSpawnTemplate Copy()
	{
		FHiAltFxAnimalSpawnTemplate result = this;
		if (FXAnimalTemplateList != null)
		{
			result.FXAnimalTemplateList = new List<TSubclassOf<BGUFXAnimalActor>>(FXAnimalTemplateList);
		}
		if (EQSTemplateList != null)
		{
			result.EQSTemplateList = new List<UEnvQuery>(EQSTemplateList);
		}
		return result;
	}

	public static FHiAltFxAnimalSpawnTemplate FromNative(IntPtr nativeBuffer)
	{
		return new FHiAltFxAnimalSpawnTemplate(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FHiAltFxAnimalSpawnTemplate value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FHiAltFxAnimalSpawnTemplate FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FHiAltFxAnimalSpawnTemplate(IntPtr.Add(nativeBuffer, arrayIndex * HiAltFxAnimalSpawnTemplate_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FHiAltFxAnimalSpawnTemplate value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * HiAltFxAnimalSpawnTemplate_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (HiAltFxAnimalSpawnTemplate_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate");
			return;
		}
		new TArrayCopyMarshaler<TSubclassOf<BGUFXAnimalActor>>(1, FXAnimalTemplateList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.ToNative).ToNative(IntPtr.Add(nativeStruct, FXAnimalTemplateList_Offset), FXAnimalTemplateList);
		new TArrayCopyMarshaler<UEnvQuery>(1, EQSTemplateList_PropertyAddress, CachedMarshalingDelegates<UEnvQuery, UObjectMarshaler<UEnvQuery>>.FromNative, CachedMarshalingDelegates<UEnvQuery, UObjectMarshaler<UEnvQuery>>.ToNative).ToNative(IntPtr.Add(nativeStruct, EQSTemplateList_Offset), EQSTemplateList);
		BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(nativeStruct, ZOffset_Offset), ZOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, bUseHighestScorePoint_Offset), 0, bUseHighestScorePoint_PropertyAddress.Address, bUseHighestScorePoint);
		FHiAltFxAnimalRotInfo.ToNative(IntPtr.Add(nativeStruct, RotInfo_Offset), RotInfo);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ReSpawnCoolDown_Offset), ReSpawnCoolDown);
	}

	public FHiAltFxAnimalSpawnTemplate(IntPtr nativeStruct)
	{
		if (HiAltFxAnimalSpawnTemplate_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate");
			FXAnimalTemplateList = null;
			EQSTemplateList = null;
			ZOffset = default(FFloatRange);
			bUseHighestScorePoint = false;
			RotInfo = default(FHiAltFxAnimalRotInfo);
			ReSpawnCoolDown = 0f;
		}
		else
		{
			FXAnimalTemplateList = new TArrayCopyMarshaler<TSubclassOf<BGUFXAnimalActor>>(1, FXAnimalTemplateList_PropertyAddress, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.FromNative, CachedMarshalingDelegates<TSubclassOf<BGUFXAnimalActor>, TSubclassOfMarshaler<BGUFXAnimalActor>>.ToNative).FromNative(IntPtr.Add(nativeStruct, FXAnimalTemplateList_Offset));
			EQSTemplateList = new TArrayCopyMarshaler<UEnvQuery>(1, EQSTemplateList_PropertyAddress, CachedMarshalingDelegates<UEnvQuery, UObjectMarshaler<UEnvQuery>>.FromNative, CachedMarshalingDelegates<UEnvQuery, UObjectMarshaler<UEnvQuery>>.ToNative).FromNative(IntPtr.Add(nativeStruct, EQSTemplateList_Offset));
			ZOffset = BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(nativeStruct, ZOffset_Offset));
			bUseHighestScorePoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, bUseHighestScorePoint_Offset), 0, bUseHighestScorePoint_PropertyAddress.Address);
			RotInfo = FHiAltFxAnimalRotInfo.FromNative(IntPtr.Add(nativeStruct, RotInfo_Offset));
			ReSpawnCoolDown = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ReSpawnCoolDown_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate");
		HiAltFxAnimalSpawnTemplate_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref FXAnimalTemplateList_PropertyAddress, intPtr, "FXAnimalTemplateList");
		FXAnimalTemplateList_Offset = NativeReflection.GetPropertyOffset(intPtr, "FXAnimalTemplateList");
		FXAnimalTemplateList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FXAnimalTemplateList", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref EQSTemplateList_PropertyAddress, intPtr, "EQSTemplateList");
		EQSTemplateList_Offset = NativeReflection.GetPropertyOffset(intPtr, "EQSTemplateList");
		EQSTemplateList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EQSTemplateList", Classes.FArrayProperty);
		ZOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZOffset");
		ZOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref bUseHighestScorePoint_PropertyAddress, intPtr, "bUseHighestScorePoint");
		bUseHighestScorePoint_Offset = NativeReflection.GetPropertyOffset(intPtr, "bUseHighestScorePoint");
		bUseHighestScorePoint_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bUseHighestScorePoint", Classes.FBoolProperty);
		RotInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "RotInfo");
		RotInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RotInfo", Classes.FStructProperty);
		ReSpawnCoolDown_Offset = NativeReflection.GetPropertyOffset(intPtr, "ReSpawnCoolDown");
		ReSpawnCoolDown_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ReSpawnCoolDown", Classes.FFloatProperty);
		HiAltFxAnimalSpawnTemplate_IsValid = ((intPtr != IntPtr.Zero && FXAnimalTemplateList_IsValid && EQSTemplateList_IsValid && ZOffset_IsValid && bUseHighestScorePoint_IsValid && RotInfo_IsValid && ReSpawnCoolDown_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.HiAltFxAnimalSpawnTemplate", (byte)HiAltFxAnimalSpawnTemplate_IsValid != 0);
	}

	static FHiAltFxAnimalSpawnTemplate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FHiAltFxAnimalSpawnTemplate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FHiAltFxAnimalSpawnTemplate));
	}
}
