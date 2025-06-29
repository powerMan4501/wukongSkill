using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BAN GSMagicallyChange")]
[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChange")]
internal class BAN_GSMagicallyChange : BAN_GSBase
{
	private static bool MagicallyChangeConfig_IsValid;

	private static int MagicallyChangeConfig_Offset;

	private static bool MagicallyChangeSkillID_IsValid;

	private static int MagicallyChangeSkillID_Offset;

	private static bool RecoverySkillID_IsValid;

	private static int RecoverySkillID_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Anim Notify")]
	[DisplayName("幻化配置")]
	[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChange:MagicallyChangeConfig")]
	public BGWDataAsset_MagicallyChangeConfig MagicallyChangeConfig
	{
		get
		{
			CheckDestroyed();
			if (!MagicallyChangeConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMagicallyChange:MagicallyChangeConfig");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_MagicallyChangeConfig>.FromNative(IntPtr.Add(base.Address, MagicallyChangeConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MagicallyChangeConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMagicallyChange:MagicallyChangeConfig");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_MagicallyChangeConfig>.ToNative(IntPtr.Add(base.Address, MagicallyChangeConfig_Offset), value);
			}
		}
	}

	[Category("Anim Notify")]
	[UProperty]
	[DisplayName("幻化出来使用的技能ID")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChange:MagicallyChangeSkillID")]
	public int MagicallyChangeSkillID
	{
		get
		{
			CheckDestroyed();
			if (!MagicallyChangeSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMagicallyChange:MagicallyChangeSkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MagicallyChangeSkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MagicallyChangeSkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMagicallyChange:MagicallyChangeSkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MagicallyChangeSkillID_Offset), value);
			}
		}
	}

	[DisplayName("恢复时释放的技能ID")]
	[Tooltip("幻化技能结束变回原型后需要释放的技能，可以不填")]
	[Category("Anim Notify")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChange:RecoverySkillID")]
	public int RecoverySkillID
	{
		get
		{
			CheckDestroyed();
			if (!RecoverySkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMagicallyChange:RecoverySkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RecoverySkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RecoverySkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSMagicallyChange:RecoverySkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RecoverySkillID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChange:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSMagicallyChange:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null) && !UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(owner))
		{
			BUS_EventCollectionCS.Get(owner)?.Evt_OnCastMagicallyChangeSkill.Invoke(MagicallyChangeConfig, MagicallyChangeSkillID, RecoverySkillID);
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMagicallyChange:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMagicallyChange bAN_GSMagicallyChange = GCHelper.Find<b1.BAN_GSMagicallyChange>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSMagicallyChange.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSMagicallyChange:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSMagicallyChange bAN_GSMagicallyChange = GCHelper.Find<b1.BAN_GSMagicallyChange>(obj);
		bool value = bAN_GSMagicallyChange.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSMagicallyChange");
		MagicallyChangeConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "MagicallyChangeConfig");
		MagicallyChangeConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MagicallyChangeConfig", Classes.FObjectProperty);
		MagicallyChangeSkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "MagicallyChangeSkillID");
		MagicallyChangeSkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MagicallyChangeSkillID", Classes.FIntProperty);
		RecoverySkillID_Offset = NativeReflection.GetPropertyOffset(intPtr, "RecoverySkillID");
		RecoverySkillID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RecoverySkillID", Classes.FIntProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMagicallyChange:GSNotifyCS", GSNotifyCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSMagicallyChange:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSMagicallyChange()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSMagicallyChange)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSMagicallyChange));
	}
}
