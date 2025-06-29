using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Cost Attr By Skill Effect")]
[USharpPath("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect")]
public class BANS_GSCostAttrBySkillEffect : BANS_GSBase
{
	private static bool SkillEffectID_IsValid;

	private static int SkillEffectID_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:SkillEffectID")]
	public int SkillEffectID
	{
		get
		{
			CheckDestroyed();
			if (!SkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:SkillEffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillEffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillEffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:SkillEffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillEffectID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owner))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (bUS_GSEventCollection != null)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, owner);
			if (skillEffectDesc != null && skillEffectDesc.EffectType == EBuffAndSkillEffectType.CostAttr)
			{
				FEffectInstReq fEffectInstReq = new FEffectInstReq(owner);
				fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
				fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(owner);
				fEffectInstReq.HitActionDir = EHitActionDir.Default;
				FEffectInstReq effectInstReq = fEffectInstReq;
				EAttrCostType attrCostType = (EAttrCostType)skillEffectDesc.EffectParamsInt[0];
				bUS_GSEventCollection.Evt_FreezeCostAttr.Invoke(attrCostType, TotalDuration, (int)GetUniqueID());
				bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(SkillEffectID, effectInstReq);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner == null || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owner))
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
		if (bUS_GSEventCollection != null)
		{
			FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(SkillEffectID, owner);
			if (skillEffectDesc != null && skillEffectDesc.EffectType == EBuffAndSkillEffectType.CostAttr)
			{
				EAttrCostType attrCostType = (EAttrCostType)skillEffectDesc.EffectParamsInt[0];
				bUS_GSEventCollection.Evt_FreezeCostAttr.Invoke(attrCostType, 0f, (int)GetUniqueID());
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSCostAttrBySkillEffect bANS_GSCostAttrBySkillEffect = GCHelper.Find<BANS_GSCostAttrBySkillEffect>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSCostAttrBySkillEffect.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BANS_GSCostAttrBySkillEffect bANS_GSCostAttrBySkillEffect = GCHelper.Find<BANS_GSCostAttrBySkillEffect>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCostAttrBySkillEffect.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect");
		SkillEffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "SkillEffectID");
		SkillEffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SkillEffectID", Classes.FIntProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCostAttrBySkillEffect:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCostAttrBySkillEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BANS_GSCostAttrBySkillEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BANS_GSCostAttrBySkillEffect));
	}
}
