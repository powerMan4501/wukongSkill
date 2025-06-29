using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS GS Auto Check Block")]
[USharpPath("/Script/b1-Managed.BANS_GSAutoCheckBlock")]
internal class BANS_GSAutoCheckBlock : BANS_GSBase
{
	private static bool BlockInfoConfig_IsValid;

	private static int BlockInfoConfig_Offset;

	private static bool TriggerResetBlockCounterWhenEnd_IsValid;

	private static int TriggerResetBlockCounterWhenEnd_Offset;

	private static FFieldAddress TriggerResetBlockCounterWhenEnd_PropertyAddress;

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

	[Tooltip("NotifyStateEnd的时候会重置回默认的Config配置【如果没有配置，则不会在结束的时候重置回默认】")]
	[DisplayName("格挡信息")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSAutoCheckBlock:BlockInfoConfig")]
	public BGWDataAsset_BlockInfoConfig BlockInfoConfig
	{
		get
		{
			CheckDestroyed();
			if (!BlockInfoConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAutoCheckBlock:BlockInfoConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_BlockInfoConfig>.FromNative(IntPtr.Add(base.Address, BlockInfoConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlockInfoConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAutoCheckBlock:BlockInfoConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_BlockInfoConfig>.ToNative(IntPtr.Add(base.Address, BlockInfoConfig_Offset), value);
			}
		}
	}

	[Tooltip("是否触发重置默认Config的时候连带触发重置计数【需要上面的“格挡信息”有配置才会生效】")]
	[UMeta(MDProp.EditCondition, "BlockInfoConfig != nullptr")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("是否重置计数")]
	[USharpPath("/Script/b1-Managed.BANS_GSAutoCheckBlock:TriggerResetBlockCounterWhenEnd")]
	public bool TriggerResetBlockCounterWhenEnd
	{
		get
		{
			CheckDestroyed();
			if (!TriggerResetBlockCounterWhenEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAutoCheckBlock:TriggerResetBlockCounterWhenEnd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TriggerResetBlockCounterWhenEnd_Offset), 0, TriggerResetBlockCounterWhenEnd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TriggerResetBlockCounterWhenEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSAutoCheckBlock:TriggerResetBlockCounterWhenEnd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TriggerResetBlockCounterWhenEnd_Offset), 0, TriggerResetBlockCounterWhenEnd_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		TriggerResetBlockCounterWhenEnd = true;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAutoCheckBlock:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (BlockInfoConfig != null)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_SetNewBlockInfoConfig.Invoke(BlockInfoConfig, NeedUpdateDefaultValue: false);
			}
			int fromInstanceID = NotifyParam.FromInstanceID;
			int uniqueID = (int)GetUniqueID();
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_TriggerBlockInSPState.Invoke(fromInstanceID, uniqueID);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSAutoCheckBlock:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (BlockInfoConfig != null && TriggerResetBlockCounterWhenEnd)
			{
				BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_ResetBlockInfo.Invoke();
			}
			int fromInstanceID = NotifyParam.FromInstanceID;
			int uniqueID = (int)GetUniqueID();
			BUS_EventCollectionCS.Get(bGUCharacterCS).Evt_ReleaseBlockInSPState.Invoke(fromInstanceID, uniqueID);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAutoCheckBlock:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAutoCheckBlock bANS_GSAutoCheckBlock = GCHelper.Find<b1.BANS_GSAutoCheckBlock>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSAutoCheckBlock.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSAutoCheckBlock:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSAutoCheckBlock bANS_GSAutoCheckBlock = GCHelper.Find<b1.BANS_GSAutoCheckBlock>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSAutoCheckBlock.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSAutoCheckBlock");
		BlockInfoConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlockInfoConfig");
		BlockInfoConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlockInfoConfig", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref TriggerResetBlockCounterWhenEnd_PropertyAddress, intPtr, "TriggerResetBlockCounterWhenEnd");
		TriggerResetBlockCounterWhenEnd_Offset = NativeReflection.GetPropertyOffset(intPtr, "TriggerResetBlockCounterWhenEnd");
		TriggerResetBlockCounterWhenEnd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TriggerResetBlockCounterWhenEnd", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAutoCheckBlock:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSAutoCheckBlock:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSAutoCheckBlock()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSAutoCheckBlock)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSAutoCheckBlock));
	}
}
