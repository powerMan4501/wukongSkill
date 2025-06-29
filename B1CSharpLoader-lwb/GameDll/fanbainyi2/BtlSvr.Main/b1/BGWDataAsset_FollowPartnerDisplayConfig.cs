using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig")]
public class BGWDataAsset_FollowPartnerDisplayConfig : UBGWDataAsset
{
	private static bool WeakAiInteractConversationCD_IsValid;

	private static int WeakAiInteractConversationCD_Offset;

	private static bool BreakInteractionConversationInfoList_IsValid;

	private static int BreakInteractionConversationInfoList_Offset;

	private static FFieldAddress BreakInteractionConversationInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<FAiBreakInteractionConversationInfo> BreakInteractionConversationInfoList_Marshaler;

	private static bool IdleDodgeInfo_IsValid;

	private static int IdleDodgeInfo_Offset;

	private static bool IdleWaitingInfo_IsValid;

	private static int IdleWaitingInfo_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("弱交互语音触发CD（秒）")]
	[UMeta(MDProp.ClampMin, "0")]
	[Category("AiWeakInteract")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:WeakAiInteractConversationCD")]
	public int WeakAiInteractConversationCD
	{
		get
		{
			CheckDestroyed();
			if (!WeakAiInteractConversationCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:WeakAiInteractConversationCD");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, WeakAiInteractConversationCD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WeakAiInteractConversationCD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:WeakAiInteractConversationCD");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, WeakAiInteractConversationCD_Offset), value);
			}
		}
	}

	[DisplayName("交互中断行为后播放语音信息")]
	[Category("BreakInteraction")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:BreakInteractionConversationInfoList")]
	public TArrayReadWrite<FAiBreakInteractionConversationInfo> BreakInteractionConversationInfoList
	{
		get
		{
			CheckDestroyed();
			if (!BreakInteractionConversationInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:BreakInteractionConversationInfoList");
				return null;
			}
			if (BreakInteractionConversationInfoList_Marshaler == null)
			{
				BreakInteractionConversationInfoList_Marshaler = new TArrayReadWriteMarshaler<FAiBreakInteractionConversationInfo>(1, BreakInteractionConversationInfoList_PropertyAddress, CachedMarshalingDelegates<FAiBreakInteractionConversationInfo, FAiBreakInteractionConversationInfo>.FromNative, CachedMarshalingDelegates<FAiBreakInteractionConversationInfo, FAiBreakInteractionConversationInfo>.ToNative);
			}
			return BreakInteractionConversationInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, BreakInteractionConversationInfoList_Offset));
		}
	}

	[Category("IdleDodge")]
	[BlueprintReadWrite]
	[DisplayName("待机躲闪配置")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:IdleDodgeInfo")]
	public FFollowPartnerDodgeInfo IdleDodgeInfo
	{
		get
		{
			CheckDestroyed();
			if (!IdleDodgeInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:IdleDodgeInfo");
				return default(FFollowPartnerDodgeInfo);
			}
			return FFollowPartnerDodgeInfo.FromNative(IntPtr.Add(base.Address, IdleDodgeInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IdleDodgeInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:IdleDodgeInfo");
			}
			else
			{
				FFollowPartnerDodgeInfo.ToNative(IntPtr.Add(base.Address, IdleDodgeInfo_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("待机等待随机动画配置")]
	[Category("IdleWait")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:IdleWaitingInfo")]
	public FFollowPartnerIdleWaitingInfo IdleWaitingInfo
	{
		get
		{
			CheckDestroyed();
			if (!IdleWaitingInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:IdleWaitingInfo");
				return default(FFollowPartnerIdleWaitingInfo);
			}
			return FFollowPartnerIdleWaitingInfo.FromNative(IntPtr.Add(base.Address, IdleWaitingInfo_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IdleWaitingInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig:IdleWaitingInfo");
			}
			else
			{
				FFollowPartnerIdleWaitingInfo.ToNative(IntPtr.Add(base.Address, IdleWaitingInfo_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_FollowPartnerDisplayConfig");
		WeakAiInteractConversationCD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "WeakAiInteractConversationCD");
		WeakAiInteractConversationCD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "WeakAiInteractConversationCD", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref BreakInteractionConversationInfoList_PropertyAddress, unrealStruct, "BreakInteractionConversationInfoList");
		BreakInteractionConversationInfoList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BreakInteractionConversationInfoList");
		BreakInteractionConversationInfoList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BreakInteractionConversationInfoList", Classes.FArrayProperty);
		IdleDodgeInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IdleDodgeInfo");
		IdleDodgeInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IdleDodgeInfo", Classes.FStructProperty);
		IdleWaitingInfo_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IdleWaitingInfo");
		IdleWaitingInfo_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IdleWaitingInfo", Classes.FStructProperty);
	}

	static BGWDataAsset_FollowPartnerDisplayConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_FollowPartnerDisplayConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_FollowPartnerDisplayConfig));
	}
}
