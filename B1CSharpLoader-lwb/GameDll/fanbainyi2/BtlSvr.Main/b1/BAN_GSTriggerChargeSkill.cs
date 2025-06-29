using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN Trigger ChargeSkill X2")]
[USharpPath("/Script/b1-Managed.BAN_GSTriggerChargeSkill")]
internal class BAN_GSTriggerChargeSkill : BAN_GSBase
{
	private static bool ChargeTimeMax_IsValid;

	private static int ChargeTimeMax_Offset;

	private static bool ChargeTimeMin_IsValid;

	private static int ChargeTimeMin_Offset;

	private static bool Command_IsValid;

	private static int Command_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerChargeSkill:ChargeTimeMax")]
	public float ChargeTimeMax
	{
		get
		{
			CheckDestroyed();
			if (!ChargeTimeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerChargeSkill:ChargeTimeMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ChargeTimeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChargeTimeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerChargeSkill:ChargeTimeMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ChargeTimeMax_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerChargeSkill:ChargeTimeMin")]
	public float ChargeTimeMin
	{
		get
		{
			CheckDestroyed();
			if (!ChargeTimeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerChargeSkill:ChargeTimeMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ChargeTimeMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChargeTimeMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerChargeSkill:ChargeTimeMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ChargeTimeMin_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerChargeSkill:Command")]
	public string Command
	{
		get
		{
			CheckDestroyed();
			if (!Command_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerChargeSkill:Command");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Command_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Command_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerChargeSkill:Command");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Command_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerChargeSkill:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerChargeSkill:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (aActor != null && aActor as ABGUCharacter != null && aActor.World != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_TriggerChargeSkill.Invoke(ChargeTimeMax, ChargeTimeMin);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerChargeSkill:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerChargeSkill:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerChargeSkill bAN_GSTriggerChargeSkill = GCHelper.Find<b1.BAN_GSTriggerChargeSkill>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSTriggerChargeSkill.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerChargeSkill:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerChargeSkill bAN_GSTriggerChargeSkill = GCHelper.Find<b1.BAN_GSTriggerChargeSkill>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bAN_GSTriggerChargeSkill.GSValidateInputCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerChargeSkill:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSTriggerChargeSkill bAN_GSTriggerChargeSkill = GCHelper.Find<b1.BAN_GSTriggerChargeSkill>(obj);
		bool value = bAN_GSTriggerChargeSkill.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSTriggerChargeSkill");
		ChargeTimeMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChargeTimeMax");
		ChargeTimeMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChargeTimeMax", Classes.FFloatProperty);
		ChargeTimeMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "ChargeTimeMin");
		ChargeTimeMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ChargeTimeMin", Classes.FFloatProperty);
		Command_Offset = NativeReflection.GetPropertyOffset(intPtr, "Command");
		Command_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Command", Classes.FStrProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerChargeSkill:GSNotifyCS", GSNotifyCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerChargeSkill:GSValidateInputCS", GSValidateInputCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerChargeSkill:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSTriggerChargeSkill()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSTriggerChargeSkill)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSTriggerChargeSkill));
	}
}
