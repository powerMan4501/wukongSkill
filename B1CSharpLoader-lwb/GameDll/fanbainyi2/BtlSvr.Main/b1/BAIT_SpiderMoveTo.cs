using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAIT_SpiderMoveTo")]
[UClass]
[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo")]
internal class BAIT_SpiderMoveTo : BAIT_Base
{
	private static bool MaxMoveTime_IsValid;

	private static int MaxMoveTime_Offset;

	private static bool AcceptableRadius_IsValid;

	private static int AcceptableRadius_Offset;

	private static bool IncludeSelfRadius_IsValid;

	private static int IncludeSelfRadius_Offset;

	private static FFieldAddress IncludeSelfRadius_PropertyAddress;

	private static bool IncludeTargetRadius_IsValid;

	private static int IncludeTargetRadius_Offset;

	private static FFieldAddress IncludeTargetRadius_PropertyAddress;

	private static bool BTTargetType_IsValid;

	private static int BTTargetType_Offset;

	private static FFieldAddress BTTargetType_PropertyAddress;

	private static bool TargetPositionType_IsValid;

	private static int TargetPositionType_Offset;

	private static FFieldAddress TargetPositionType_PropertyAddress;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("最大移动时间")]
	[UProperty]
	[Tooltip("0表示无限制")]
	[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo:MaxMoveTime")]
	public float MaxMoveTime
	{
		get
		{
			CheckDestroyed();
			if (!MaxMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:MaxMoveTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxMoveTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxMoveTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:MaxMoveTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxMoveTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo:AcceptableRadius")]
	public float AcceptableRadius
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:AcceptableRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:AcceptableRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptableRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:IncludeSelfRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo:IncludeTargetRadius")]
	public bool IncludeTargetRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:IncludeTargetRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:IncludeTargetRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo:BTTargetType")]
	public EBTTargetType BTTargetType
	{
		get
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:BTTargetType");
				return EBTTargetType.Target;
			}
			return EnumMarshaler<EBTTargetType>.FromNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BTTargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:BTTargetType");
			}
			else
			{
				EnumMarshaler<EBTTargetType>.ToNative(IntPtr.Add(base.Address, BTTargetType_Offset), 0, BTTargetType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo:TargetPositionType")]
	public ESpiderNavPositionType TargetPositionType
	{
		get
		{
			CheckDestroyed();
			if (!TargetPositionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:TargetPositionType");
				return ESpiderNavPositionType.Ground;
			}
			return EnumMarshaler<ESpiderNavPositionType>.FromNative(IntPtr.Add(base.Address, TargetPositionType_Offset), 0, TargetPositionType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetPositionType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:TargetPositionType");
			}
			else
			{
				EnumMarshaler<ESpiderNavPositionType>.ToNative(IntPtr.Add(base.Address, TargetPositionType_Offset), 0, TargetPositionType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_SpiderMoveTo:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_SpiderMoveTo:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		MaxMoveTime = 0f;
		SpeedRateType = EAIMoveSpeedType.RUN;
		IncludeTargetRadius = false;
		IncludeSelfRadius = true;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_InitiateAINodeAction.Invoke(EAINodeActionType.SpiderMoveTo, new AINodeAction_SpiderMoveToParamInfo
				{
					MaxMoveTime = MaxMoveTime,
					AcceptableRadius = AcceptableRadius,
					IncludeSelfRadius = IncludeSelfRadius,
					IncludeTargetRadius = IncludeTargetRadius,
					BTTargetType = BTTargetType,
					TargetPositionType = TargetPositionType,
					SpeedRateType = SpeedRateType
				});
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_SpiderMoveTo");
		MaxMoveTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxMoveTime");
		MaxMoveTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxMoveTime", Classes.FFloatProperty);
		AcceptableRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRadius");
		AcceptableRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRadius", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IncludeSelfRadius_PropertyAddress, unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IncludeTargetRadius_PropertyAddress, unrealStruct, "IncludeTargetRadius");
		IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeTargetRadius");
		IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeTargetRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref BTTargetType_PropertyAddress, unrealStruct, "BTTargetType");
		BTTargetType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BTTargetType");
		BTTargetType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BTTargetType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref TargetPositionType_PropertyAddress, unrealStruct, "TargetPositionType");
		TargetPositionType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetPositionType");
		TargetPositionType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetPositionType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, unrealStruct, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateType", Classes.FEnumProperty);
	}

	static BAIT_SpiderMoveTo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_SpiderMoveTo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_SpiderMoveTo));
	}
}
