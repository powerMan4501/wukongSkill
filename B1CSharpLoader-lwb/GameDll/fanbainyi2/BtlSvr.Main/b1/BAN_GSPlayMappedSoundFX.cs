using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Play Mapped SoundFX")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSPlayMappedSoundFX")]
internal class BAN_GSPlayMappedSoundFX : BAN_GSBase
{
	private static bool EquipPosition_IsValid;

	private static int EquipPosition_Offset;

	private static FFieldAddress EquipPosition_PropertyAddress;

	private static bool ActionTypeID_IsValid;

	private static int ActionTypeID_Offset;

	private static bool bIsFollow_IsValid;

	private static int bIsFollow_Offset;

	private static FFieldAddress bIsFollow_PropertyAddress;

	private static bool SocketName_IsValid;

	private static int SocketName_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:EquipPosition")]
	public EquipPosition EquipPosition
	{
		get
		{
			CheckDestroyed();
			if (!EquipPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:EquipPosition");
				return EquipPosition.Head;
			}
			return EnumMarshaler<EquipPosition>.FromNative(IntPtr.Add(base.Address, EquipPosition_Offset), 0, EquipPosition_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EquipPosition_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:EquipPosition");
			}
			else
			{
				EnumMarshaler<EquipPosition>.ToNative(IntPtr.Add(base.Address, EquipPosition_Offset), 0, EquipPosition_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:ActionTypeID")]
	public int ActionTypeID
	{
		get
		{
			CheckDestroyed();
			if (!ActionTypeID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:ActionTypeID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ActionTypeID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActionTypeID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:ActionTypeID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ActionTypeID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("音效为Follow还是AtLocation")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:bIsFollow")]
	public bool bIsFollow
	{
		get
		{
			CheckDestroyed();
			if (!bIsFollow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:bIsFollow");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bIsFollow_Offset), 0, bIsFollow_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bIsFollow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:bIsFollow");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bIsFollow_Offset), 0, bIsFollow_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("当音效为Follow时，mesh上的插槽名")]
	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "bIsFollow")]
	[USharpPath("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:SocketName")]
	public FName SocketName
	{
		get
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:SocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:SocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SocketName_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (owner != null)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_PlayMappedSoundFX.Invoke(EquipPosition, ActionTypeID, bIsFollow, SocketName);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BAN_GSPlayMappedSoundFX bAN_GSPlayMappedSoundFX = GCHelper.Find<b1.BAN_GSPlayMappedSoundFX>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSPlayMappedSoundFX.GSNotifyCS_Implementation(notifyParam);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSPlayMappedSoundFX");
		NativeReflection.GetPropertyRef(ref EquipPosition_PropertyAddress, intPtr, "EquipPosition");
		EquipPosition_Offset = NativeReflection.GetPropertyOffset(intPtr, "EquipPosition");
		EquipPosition_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EquipPosition", Classes.FEnumProperty);
		ActionTypeID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActionTypeID");
		ActionTypeID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActionTypeID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bIsFollow_PropertyAddress, intPtr, "bIsFollow");
		bIsFollow_Offset = NativeReflection.GetPropertyOffset(intPtr, "bIsFollow");
		bIsFollow_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bIsFollow", Classes.FBoolProperty);
		SocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "SocketName");
		SocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SocketName", Classes.FNameProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSPlayMappedSoundFX:GSNotifyCS", GSNotifyCS_IsValid);
	}

	static BAN_GSPlayMappedSoundFX()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAN_GSPlayMappedSoundFX)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAN_GSPlayMappedSoundFX));
	}
}
