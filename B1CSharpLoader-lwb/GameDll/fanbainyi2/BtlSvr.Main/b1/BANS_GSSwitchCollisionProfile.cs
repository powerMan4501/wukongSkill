using System;
using b1.EventDelDefine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("Switch Collision Profile")]
[USharpPath("/Script/b1-Managed.BANS_GSSwitchCollisionProfile")]
internal class BANS_GSSwitchCollisionProfile : BANS_GSBase
{
	private static bool ProfileList_IsValid;

	private static int ProfileList_Offset;

	private static FFieldAddress ProfileList_PropertyAddress;

	private TArrayReadWriteMarshaler<CollisionProfileInfo> ProfileList_Marshaler;

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

	[BlueprintReadWrite]
	[UProperty]
	[Category("Anim Notify")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:ProfileList")]
	public TArrayReadWrite<CollisionProfileInfo> ProfileList
	{
		get
		{
			CheckDestroyed();
			if (!ProfileList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:ProfileList");
				return null;
			}
			if (ProfileList_Marshaler == null)
			{
				ProfileList_Marshaler = new TArrayReadWriteMarshaler<CollisionProfileInfo>(1, ProfileList_PropertyAddress, CachedMarshalingDelegates<CollisionProfileInfo, CollisionProfileInfo>.FromNative, CachedMarshalingDelegates<CollisionProfileInfo, CollisionProfileInfo>.ToNative);
			}
			return ProfileList_Marshaler.FromNative(IntPtr.Add(base.Address, ProfileList_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS != null) || BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(bGUCharacterCS) == null)
		{
			return;
		}
		uint uniqueID = GetUniqueID();
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
		if (!(bUS_GSEventCollection != null))
		{
			return;
		}
		foreach (CollisionProfileInfo profile in ProfileList)
		{
			switch (profile.Type)
			{
			case ECollisionBodyType.CollisionBody_CapsuleComp:
			{
				GSDel_SetStringProperty evt_SetStringProperty2 = bUS_GSEventCollection.Evt_SetStringProperty;
				FName profileName = profile.ProfileName;
				evt_SetStringProperty2.Invoke(EPropType.Capsule_CollisionProfileName, profileName.ToString(), 0u, uniqueID);
				break;
			}
			case ECollisionBodyType.CollisionBody_SkeletalMeshComp:
			{
				GSDel_SetStringProperty evt_SetStringProperty = bUS_GSEventCollection.Evt_SetStringProperty;
				FName profileName = profile.ProfileName;
				evt_SetStringProperty.Invoke(EPropType.Mesh_CollisionProfileName, profileName.ToString(), 0u, uniqueID);
				break;
			}
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.MeshComp.GetOwner() as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			uint uniqueID = GetUniqueID();
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_ResetProperty.Invoke(0u, uniqueID);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSwitchCollisionProfile bANS_GSSwitchCollisionProfile = GCHelper.Find<b1.BANS_GSSwitchCollisionProfile>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSSwitchCollisionProfile.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSSwitchCollisionProfile bANS_GSSwitchCollisionProfile = GCHelper.Find<b1.BANS_GSSwitchCollisionProfile>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSSwitchCollisionProfile.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSSwitchCollisionProfile");
		NativeReflection.GetPropertyRef(ref ProfileList_PropertyAddress, intPtr, "ProfileList");
		ProfileList_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProfileList");
		ProfileList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProfileList", Classes.FArrayProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSSwitchCollisionProfile:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSSwitchCollisionProfile()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSSwitchCollisionProfile)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSSwitchCollisionProfile));
	}
}
