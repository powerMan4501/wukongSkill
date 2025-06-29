using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Set AM SpeedRate")]
[USharpPath("/Script/b1-Managed.BANS_GSSetAMSpeedRate")]
internal class BANS_GSSetAMSpeedRate : BANS_GSBase
{
	private static bool SectionSpeedRate_IsValid;

	private static int SectionSpeedRate_Offset;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

	private static bool GetAnimNSType_IsValid;

	private static IntPtr GetAnimNSType_FunctionAddress;

	private static int GetAnimNSType_ParamsSize;

	private static bool GetAnimNSType_ReturnValue_IsValid;

	private static int GetAnimNSType_ReturnValue_Offset;

	private static FFieldAddress GetAnimNSType_ReturnValue_PropertyAddress;

	private static bool GSNotifyBeginCS_IsValid;

	private static IntPtr GSNotifyBeginCS_FunctionAddress;

	private static int GSNotifyBeginCS_ParamsSize;

	private static bool GSNotifyBeginCS_NotifyParam_IsValid;

	private static int GSNotifyBeginCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyBeginCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyBeginCS_TotalDuration_IsValid;

	private static int GSNotifyBeginCS_TotalDuration_Offset;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	private static bool GetModifySpeedRate_IsValid;

	private static IntPtr GetModifySpeedRate_FunctionAddress;

	private static int GetModifySpeedRate_ParamsSize;

	private static bool GetModifySpeedRate_ReturnValue_IsValid;

	private static int GetModifySpeedRate_ReturnValue_Offset;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("SetAttackRotation")]
	[Tooltip("Set Montage Section SpeedRate")]
	[USharpPath("/Script/b1-Managed.BANS_GSSetAMSpeedRate:SectionSpeedRate")]
	public float SectionSpeedRate
	{
		get
		{
			CheckDestroyed();
			if (!SectionSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetAMSpeedRate:SectionSpeedRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, SectionSpeedRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SectionSpeedRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSetAMSpeedRate:SectionSpeedRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, SectionSpeedRate_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		SectionSpeedRate = 1f;
		base.AnimNSType = EGsEnAnimNS.AMSpeedRate;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner) && !bGUCharacterCS.IsInGuestSyncMontage())
		{
			int uniqueID = (int)GetUniqueID();
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetAMSectionSpeedRate.Invoke(uniqueID, SectionSpeedRate, TotalDuration / SectionSpeedRate);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner) && !bGUCharacterCS.IsInGuestSyncMontage())
		{
			int uniqueID = (int)GetUniqueID();
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetAMSectionSpeedRate.Invoke(uniqueID, 1f, -1f);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
		if (!(actor == null))
		{
			BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
			if (bGUCharacterCS != null && !bGUCharacterCS.HasAnyRootMotion())
			{
				string pathName = GetOuter().GetPathName();
				string logStr = "Montage（" + pathName + "）, 没有开启RootMotion，不能计算时间缩放";
				BGW_ValiDateMgr.Get(actor.World).ShowValidateWindow(logStr);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GetModifySpeedRate")]
	protected override float GetModifySpeedRate_Implementation()
	{
		return SectionSpeedRate;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GetAnimNSType")]
	protected override EGsEnAnimNS GetAnimNSType_Implementation()
	{
		return EGsEnAnimNS.AMSpeedRate;
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetAMSpeedRate bANS_GSSetAMSpeedRate = GCHelper.Find<b1.BANS_GSSetAMSpeedRate>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSetAMSpeedRate.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GetAnimNSType")]
	private static void GetAnimNSType__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetAMSpeedRate bANS_GSSetAMSpeedRate = GCHelper.Find<b1.BANS_GSSetAMSpeedRate>(obj);
		EGsEnAnimNS animNSType_Implementation = bANS_GSSetAMSpeedRate.GetAnimNSType_Implementation();
		EnumMarshaler<EGsEnAnimNS>.ToNative(IntPtr.Add(buffer, GetAnimNSType_ReturnValue_Offset), 0, GetAnimNSType_ReturnValue_PropertyAddress.Address, animNSType_Implementation);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetAMSpeedRate bANS_GSSetAMSpeedRate = GCHelper.Find<b1.BANS_GSSetAMSpeedRate>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSetAMSpeedRate.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetAMSpeedRate bANS_GSSetAMSpeedRate = GCHelper.Find<b1.BANS_GSSetAMSpeedRate>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bANS_GSSetAMSpeedRate.GSValidateInputCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GetModifySpeedRate")]
	private static void GetModifySpeedRate__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSetAMSpeedRate bANS_GSSetAMSpeedRate = GCHelper.Find<b1.BANS_GSSetAMSpeedRate>(obj);
		float modifySpeedRate_Implementation = bANS_GSSetAMSpeedRate.GetModifySpeedRate_Implementation();
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(buffer, GetModifySpeedRate_ReturnValue_Offset), modifySpeedRate_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSetAMSpeedRate");
		SectionSpeedRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "SectionSpeedRate");
		SectionSpeedRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SectionSpeedRate", Classes.FFloatProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GetAnimNSType_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetAnimNSType");
		GetAnimNSType_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAnimNSType_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetAnimNSType_ReturnValue_PropertyAddress, GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetAnimNSType_FunctionAddress, "ReturnValue");
		GetAnimNSType_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetAnimNSType_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAnimNSType_IsValid = GetAnimNSType_FunctionAddress != IntPtr.Zero && GetAnimNSType_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GetAnimNSType", GetAnimNSType_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GSValidateInputCS", GSValidateInputCS_IsValid);
		GetModifySpeedRate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetModifySpeedRate");
		GetModifySpeedRate_ParamsSize = NativeReflection.GetFunctionParamsSize(GetModifySpeedRate_FunctionAddress);
		GetModifySpeedRate_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetModifySpeedRate_FunctionAddress, "ReturnValue");
		GetModifySpeedRate_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetModifySpeedRate_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetModifySpeedRate_IsValid = GetModifySpeedRate_FunctionAddress != IntPtr.Zero && GetModifySpeedRate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSetAMSpeedRate:GetModifySpeedRate", GetModifySpeedRate_IsValid);
	}

	static BANS_GSSetAMSpeedRate()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSetAMSpeedRate)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSetAMSpeedRate));
	}
}
