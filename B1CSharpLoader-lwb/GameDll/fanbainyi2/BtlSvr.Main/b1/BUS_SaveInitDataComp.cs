using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_SaveInitDataComp")]
public class BUS_SaveInitDataComp : UActorEditCompBase
{
	private static bool bSaveInitData_IsValid;

	private static int bSaveInitData_Offset;

	private static FFieldAddress bSaveInitData_PropertyAddress;

	private static bool ActorResetType_IsValid;

	private static int ActorResetType_Offset;

	private static FFieldAddress ActorResetType_PropertyAddress;

	private static bool PersistentDataDontResetOnNewGamePlus_IsValid;

	private static int PersistentDataDontResetOnNewGamePlus_Offset;

	private static FFieldAddress PersistentDataDontResetOnNewGamePlus_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("ResetConfig")]
	[USharpPath("/Script/b1-Managed.BUS_SaveInitDataComp:bSaveInitData")]
	public bool bSaveInitData
	{
		get
		{
			CheckDestroyed();
			if (!bSaveInitData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SaveInitDataComp:bSaveInitData");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bSaveInitData_Offset), 0, bSaveInitData_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bSaveInitData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SaveInitDataComp:bSaveInitData");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bSaveInitData_Offset), 0, bSaveInitData_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "bSaveInitData")]
	[Category("ResetConfig")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SaveInitDataComp:ActorResetType")]
	public EBGUResetType ActorResetType
	{
		get
		{
			CheckDestroyed();
			if (!ActorResetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SaveInitDataComp:ActorResetType");
				return EBGUResetType.No;
			}
			return EnumMarshaler<EBGUResetType>.FromNative(IntPtr.Add(base.Address, ActorResetType_Offset), 0, ActorResetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ActorResetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SaveInitDataComp:ActorResetType");
			}
			else
			{
				EnumMarshaler<EBGUResetType>.ToNative(IntPtr.Add(base.Address, ActorResetType_Offset), 0, ActorResetType_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("多周目数据不重置")]
	[Category("多周目")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_SaveInitDataComp:PersistentDataDontResetOnNewGamePlus")]
	public bool PersistentDataDontResetOnNewGamePlus
	{
		get
		{
			CheckDestroyed();
			if (!PersistentDataDontResetOnNewGamePlus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SaveInitDataComp:PersistentDataDontResetOnNewGamePlus");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PersistentDataDontResetOnNewGamePlus_Offset), 0, PersistentDataDontResetOnNewGamePlus_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PersistentDataDontResetOnNewGamePlus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SaveInitDataComp:PersistentDataDontResetOnNewGamePlus");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PersistentDataDontResetOnNewGamePlus_Offset), 0, PersistentDataDontResetOnNewGamePlus_PropertyAddress.Address, value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		if (!(GetOwner() is BGUCharacterCS))
		{
			BUC_ActorInitData bUC_ActorInitData = RequireWritableData<BUC_ActorInitData>();
			bUC_ActorInitData.ActorResetType = ActorResetType;
			bUC_ActorInitData.bSaveInitData = bSaveInitData;
			bUC_ActorInitData.PersistentDataDontResetOnNewGamePlusFromConfig = PersistentDataDontResetOnNewGamePlus;
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		ActorResetType = EBGUResetType.None;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_SaveInitDataComp");
		NativeReflection.GetPropertyRef(ref bSaveInitData_PropertyAddress, unrealStruct, "bSaveInitData");
		bSaveInitData_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bSaveInitData");
		bSaveInitData_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bSaveInitData", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref ActorResetType_PropertyAddress, unrealStruct, "ActorResetType");
		ActorResetType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ActorResetType");
		ActorResetType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ActorResetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref PersistentDataDontResetOnNewGamePlus_PropertyAddress, unrealStruct, "PersistentDataDontResetOnNewGamePlus");
		PersistentDataDontResetOnNewGamePlus_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PersistentDataDontResetOnNewGamePlus");
		PersistentDataDontResetOnNewGamePlus_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PersistentDataDontResetOnNewGamePlus", Classes.FBoolProperty);
	}

	static BUS_SaveInitDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SaveInitDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SaveInitDataComp));
	}
}
