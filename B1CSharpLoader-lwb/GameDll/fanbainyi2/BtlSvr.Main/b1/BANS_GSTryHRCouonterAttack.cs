using System;
using Diana.Common;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS GSTryHRCouonterAttack")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSTryHRCouonterAttack")]
internal class BANS_GSTryHRCouonterAttack : BANS_GSBase
{
	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	[USharpPath("/Script/b1-Managed.BANS_GSTryHRCouonterAttack:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		IBUC_ArmorData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ArmorData, BUC_ArmorData>(aActor);
		if (readOnlyData != null && readOnlyData.IsInPreHRCounterattacking())
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(aActor, EBattleInfoType.HRCounterattack, "<character>" + aActor.GetName() + "</><action>触发TryHRCouonterAttack NotifyState</>");
			}
			bUS_GSEventCollection.Evt_CastSkillToBreakHitRecover.Invoke();
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSTryHRCouonterAttack:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		IBUC_ArmorData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_ArmorData, BUC_ArmorData>(aActor);
		if (readOnlyData != null && readOnlyData.IsInPreHRCounterattacking())
		{
			if (DebugConfig.IsOpenBattleInfoTool)
			{
				BGUFunctionLibraryCS.LogBattleInfo(aActor, EBattleInfoType.HRCounterattack, "<character>" + aActor.GetName() + "</><action>触发TryHRCouonterAttack NotifyState</>");
			}
			bUS_GSEventCollection.Evt_CastSkillToBreakHitRecover.Invoke();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTryHRCouonterAttack:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSTryHRCouonterAttack bANS_GSTryHRCouonterAttack = GCHelper.Find<b1.BANS_GSTryHRCouonterAttack>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSTryHRCouonterAttack.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSTryHRCouonterAttack:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSTryHRCouonterAttack bANS_GSTryHRCouonterAttack = GCHelper.Find<b1.BANS_GSTryHRCouonterAttack>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSTryHRCouonterAttack.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSTryHRCouonterAttack");
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTryHRCouonterAttack:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSTryHRCouonterAttack:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSTryHRCouonterAttack()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSTryHRCouonterAttack)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSTryHRCouonterAttack));
	}
}
