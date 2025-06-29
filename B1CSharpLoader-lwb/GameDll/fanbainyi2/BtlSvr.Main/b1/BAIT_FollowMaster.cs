using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_FollowMaster")]
internal class BAIT_FollowMaster : BAIT_Base
{
	private static bool AcceptableRaidus_IsValid;

	private static int AcceptableRaidus_Offset;

	private static bool IncludeSelfRadius_IsValid;

	private static int IncludeSelfRadius_Offset;

	private static FFieldAddress IncludeSelfRadius_PropertyAddress;

	private static bool IncludeTargetRadius_IsValid;

	private static int IncludeTargetRadius_Offset;

	private static FFieldAddress IncludeTargetRadius_PropertyAddress;

	private static bool MoveAIType_IsValid;

	private static int MoveAIType_Offset;

	private static FFieldAddress MoveAIType_PropertyAddress;

	private static bool SpeedRateType_IsValid;

	private static int SpeedRateType_Offset;

	private static FFieldAddress SpeedRateType_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_FollowMaster:AcceptableRaidus")]
	public float AcceptableRaidus
	{
		get
		{
			CheckDestroyed();
			if (!AcceptableRaidus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:AcceptableRaidus");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, AcceptableRaidus_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AcceptableRaidus_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:AcceptableRaidus");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, AcceptableRaidus_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_FollowMaster:IncludeSelfRadius")]
	public bool IncludeSelfRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:IncludeSelfRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeSelfRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:IncludeSelfRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeSelfRadius_Offset), 0, IncludeSelfRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_FollowMaster:IncludeTargetRadius")]
	public bool IncludeTargetRadius
	{
		get
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:IncludeTargetRadius");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IncludeTargetRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:IncludeTargetRadius");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IncludeTargetRadius_Offset), 0, IncludeTargetRadius_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_FollowMaster:MoveAIType")]
	public EBGUMoveAIType MoveAIType
	{
		get
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:MoveAIType");
				return EBGUMoveAIType.None;
			}
			return EnumMarshaler<EBGUMoveAIType>.FromNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MoveAIType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:MoveAIType");
			}
			else
			{
				EnumMarshaler<EBGUMoveAIType>.ToNative(IntPtr.Add(base.Address, MoveAIType_Offset), 0, MoveAIType_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_FollowMaster:SpeedRateType")]
	public EAIMoveSpeedType SpeedRateType
	{
		get
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:SpeedRateType");
				return EAIMoveSpeedType.JOG;
			}
			return EnumMarshaler<EAIMoveSpeedType>.FromNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SpeedRateType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FollowMaster:SpeedRateType");
			}
			else
			{
				EnumMarshaler<EAIMoveSpeedType>.ToNative(IntPtr.Add(base.Address, SpeedRateType_Offset), 0, SpeedRateType_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		IncludeSelfRadius = true;
		IncludeTargetRadius = false;
		SpeedRateType = EAIMoveSpeedType.RUN;
	}

	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(OwnerActor);
		if (readOnlyData == null || readOnlyData.GetMasterActor() == null)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		ACharacter aCharacter = readOnlyData.GetMasterActor() as ACharacter;
		ACharacter aCharacter2 = OwnerActor as ACharacter;
		if (aCharacter == null || aCharacter2 == null)
		{
			FinishExecute(bSuccess: false);
			return;
		}
		float num = MathLib.Abs((BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter) - BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter2)).Size());
		float acceptableRaidus = AcceptableRaidus;
		acceptableRaidus += (IncludeSelfRadius ? aCharacter2.CapsuleComponent.GetScaledCapsuleRadius() : 0f);
		acceptableRaidus += (IncludeTargetRadius ? aCharacter.CapsuleComponent.GetScaledCapsuleRadius() : 0f);
		int RequestIdx;
		if (num <= acceptableRaidus)
		{
			BGUFuncLibForMove.CancelMove(aCharacter2);
			FinishExecute(bSuccess: true);
		}
		else if (!BGUFuncLibForMove.IsMoveActive(aCharacter2) && !BGUFuncLibForMove.BeginMoveToTarget(aCharacter2, aCharacter, AcceptableRaidus, SpeedRateType, MoveAIType, IncludeSelfRadius, IncludeTargetRadius, out RequestIdx))
		{
			FinishExecute(bSuccess: false);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_FollowMaster");
		AcceptableRaidus_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AcceptableRaidus");
		AcceptableRaidus_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AcceptableRaidus", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IncludeSelfRadius_PropertyAddress, unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeSelfRadius");
		IncludeSelfRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeSelfRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref IncludeTargetRadius_PropertyAddress, unrealStruct, "IncludeTargetRadius");
		IncludeTargetRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IncludeTargetRadius");
		IncludeTargetRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IncludeTargetRadius", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref MoveAIType_PropertyAddress, unrealStruct, "MoveAIType");
		MoveAIType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MoveAIType");
		MoveAIType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MoveAIType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref SpeedRateType_PropertyAddress, unrealStruct, "SpeedRateType");
		SpeedRateType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpeedRateType");
		SpeedRateType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpeedRateType", Classes.FEnumProperty);
	}

	static BAIT_FollowMaster()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_FollowMaster)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_FollowMaster));
	}
}
