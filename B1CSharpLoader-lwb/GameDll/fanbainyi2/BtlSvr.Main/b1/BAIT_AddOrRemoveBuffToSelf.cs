using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf")]
internal class BAIT_AddOrRemoveBuffToSelf : BAIT_Base
{
	private static bool IsAdd_IsValid;

	private static int IsAdd_Offset;

	private static FFieldAddress IsAdd_PropertyAddress;

	private static bool BuffID_IsValid;

	private static int BuffID_Offset;

	private static bool BuffDurationTime_IsValid;

	private static int BuffDurationTime_Offset;

	private static bool BuffLayer_IsValid;

	private static int BuffLayer_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:IsAdd")]
	public bool IsAdd
	{
		get
		{
			CheckDestroyed();
			if (!IsAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:IsAdd");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsAdd_Offset), 0, IsAdd_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsAdd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:IsAdd");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsAdd_Offset), 0, IsAdd_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffID")]
	public int BuffID
	{
		get
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Tooltip("单位为毫秒，填0，则用表中的时间， -1为无限时间")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffDurationTime")]
	public float BuffDurationTime
	{
		get
		{
			CheckDestroyed();
			if (!BuffDurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffDurationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BuffDurationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffDurationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffDurationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BuffDurationTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffLayer")]
	public int BuffLayer
	{
		get
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffLayer");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BuffLayer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BuffLayer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf:BuffLayer");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BuffLayer_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		BuffLayer = 1;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (IsAdd)
			{
				for (int i = 0; i < BuffLayer; i++)
				{
					BGUFunctionLibraryCS.BGUAddBuff(bGUCharacterCS, bGUCharacterCS, BuffID, EBuffSourceType.BAIT, BuffDurationTime);
				}
			}
			else
			{
				BGUFunctionLibraryCS.BGURemoveBuff(bGUCharacterCS, BuffID, EBuffEffectTriggerType.None, BuffLayer);
			}
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_AddOrRemoveBuffToSelf");
		NativeReflection.GetPropertyRef(ref IsAdd_PropertyAddress, unrealStruct, "IsAdd");
		IsAdd_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsAdd");
		IsAdd_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsAdd", Classes.FBoolProperty);
		BuffID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffID");
		BuffID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffID", Classes.FIntProperty);
		BuffDurationTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffDurationTime");
		BuffDurationTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffDurationTime", Classes.FFloatProperty);
		BuffLayer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BuffLayer");
		BuffLayer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BuffLayer", Classes.FIntProperty);
	}

	static BAIT_AddOrRemoveBuffToSelf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_AddOrRemoveBuffToSelf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_AddOrRemoveBuffToSelf));
	}
}
