using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS Catch And Throw")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow")]
internal class BANS_GSCatchAndThrow : BANS_GSBase
{
	private static bool CatchSocketName_IsValid;

	private static int CatchSocketName_Offset;

	private static bool VictimDuringCatchMontage_IsValid;

	private static int VictimDuringCatchMontage_Offset;

	private static bool VictimBeThrownMontage_IsValid;

	private static int VictimBeThrownMontage_Offset;

	private static bool bEnablePhysicsBlending_IsValid;

	private static int bEnablePhysicsBlending_Offset;

	private static FFieldAddress bEnablePhysicsBlending_PropertyAddress;

	private static bool GSNotifyEndCS_IsValid;

	private static IntPtr GSNotifyEndCS_FunctionAddress;

	private static int GSNotifyEndCS_ParamsSize;

	private static bool GSNotifyEndCS_NotifyParam_IsValid;

	private static int GSNotifyEndCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyEndCS_NotifyParam_PropertyAddress;

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

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify State")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow:CatchSocketName")]
	public FName CatchSocketName
	{
		get
		{
			CheckDestroyed();
			if (!CatchSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:CatchSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, CatchSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CatchSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:CatchSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, CatchSocketName_Offset), value);
			}
		}
	}

	[Category("Anim Notify State")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow:VictimDuringCatchMontage")]
	public UAnimMontage VictimDuringCatchMontage
	{
		get
		{
			CheckDestroyed();
			if (!VictimDuringCatchMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:VictimDuringCatchMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, VictimDuringCatchMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VictimDuringCatchMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:VictimDuringCatchMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, VictimDuringCatchMontage_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Anim Notify State")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow:VictimBeThrownMontage")]
	public UAnimMontage VictimBeThrownMontage
	{
		get
		{
			CheckDestroyed();
			if (!VictimBeThrownMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:VictimBeThrownMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, VictimBeThrownMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VictimBeThrownMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:VictimBeThrownMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, VictimBeThrownMontage_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify State")]
	[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow:bEnablePhysicsBlending")]
	public bool bEnablePhysicsBlending
	{
		get
		{
			CheckDestroyed();
			if (!bEnablePhysicsBlending_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:bEnablePhysicsBlending");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnablePhysicsBlending_Offset), 0, bEnablePhysicsBlending_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnablePhysicsBlending_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSCatchAndThrow:bEnablePhysicsBlending");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnablePhysicsBlending_Offset), 0, bEnablePhysicsBlending_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS2 = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS) as BGUCharacterCS;
		if (bGUCharacterCS2 != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS2);
			if (BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(bGUCharacterCS2) != null)
			{
				uint uniqueID = GetUniqueID();
				bUS_GSEventCollection.Evt_SetEnumProperty.Invoke(EPropType.Movement_MovementMode, 5, 0u, uniqueID, bSetDefaultProperty: false, "BANS_GSCatchAndThrow");
				bUS_GSEventCollection.Evt_SetCollisionResponseProperty.Invoke(EPropType.Capsule_CollisionResponseToChannels, new Dictionary<ECollisionChannel, ECollisionResponseType> { 
				{
					ECollisionChannel.ECC_Pawn,
					ECollisionResponseType.ECR_Ignore
				} }, 0u, uniqueID);
			}
			bGUCharacterCS2.RootComponent.AbsoluteRotation = true;
			bGUCharacterCS2.AttachToComponent(bGUCharacterCS.Mesh, CatchSocketName, EAttachmentRule.SnapToTarget, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			if (bEnablePhysicsBlending)
			{
				bUS_GSEventCollection.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.BeCatchThrow);
			}
			if (VictimDuringCatchMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS2, VictimDuringCatchMontage, FName.None);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (!(bGUCharacterCS == null))
		{
			BGUCharacterCS bGUCharacterCS2 = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS) as BGUCharacterCS;
			if (bGUCharacterCS2 != null)
			{
				UCharacterMovementComponent obj = bGUCharacterCS2.GetMovementComponent() as UCharacterMovementComponent;
				obj.StopMovementImmediately();
				obj.ClearAccumulatedForces();
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS2 = BGUFunctionLibraryCS.BGUGetTarget(bGUCharacterCS) as BGUCharacterCS;
		if (bGUCharacterCS2 != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS2);
			bUS_GSEventCollection.Evt_ResetProperty.Invoke(0u, GetUniqueID());
			bGUCharacterCS2.DetachFromActor(EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld, EDetachmentRule.KeepWorld);
			bGUCharacterCS2.RootComponent.AbsoluteRotation = false;
			if (bEnablePhysicsBlending)
			{
				bUS_GSEventCollection.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Normal);
			}
			if (VictimBeThrownMontage != null)
			{
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUCharacterCS2, VictimBeThrownMontage, FName.None);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCatchAndThrow bANS_GSCatchAndThrow = GCHelper.Find<b1.BANS_GSCatchAndThrow>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSCatchAndThrow.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCatchAndThrow bANS_GSCatchAndThrow = GCHelper.Find<b1.BANS_GSCatchAndThrow>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSCatchAndThrow.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSCatchAndThrow bANS_GSCatchAndThrow = GCHelper.Find<b1.BANS_GSCatchAndThrow>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSCatchAndThrow.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSCatchAndThrow");
		CatchSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "CatchSocketName");
		CatchSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CatchSocketName", Classes.FNameProperty);
		VictimDuringCatchMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "VictimDuringCatchMontage");
		VictimDuringCatchMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VictimDuringCatchMontage", Classes.FObjectProperty);
		VictimBeThrownMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "VictimBeThrownMontage");
		VictimBeThrownMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "VictimBeThrownMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref bEnablePhysicsBlending_PropertyAddress, intPtr, "bEnablePhysicsBlending");
		bEnablePhysicsBlending_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnablePhysicsBlending");
		bEnablePhysicsBlending_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnablePhysicsBlending", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSCatchAndThrow:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSCatchAndThrow()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSCatchAndThrow)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSCatchAndThrow));
	}
}
