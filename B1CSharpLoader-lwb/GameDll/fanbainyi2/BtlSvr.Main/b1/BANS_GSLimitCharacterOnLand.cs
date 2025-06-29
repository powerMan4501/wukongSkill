using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Limit Character OnLand")]
[USharpPath("/Script/b1-Managed.BANS_GSLimitCharacterOnLand")]
internal class BANS_GSLimitCharacterOnLand : BANS_GSBase
{
	private static bool RayLength_IsValid;

	private static int RayLength_Offset;

	private static bool GSNotifyTickCS_IsValid;

	private static IntPtr GSNotifyTickCS_FunctionAddress;

	private static int GSNotifyTickCS_ParamsSize;

	private static bool GSNotifyTickCS_NotifyParam_IsValid;

	private static int GSNotifyTickCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyTickCS_NotifyParam_PropertyAddress;

	private static bool GSNotifyTickCS_FrameDeltaTime_IsValid;

	private static int GSNotifyTickCS_FrameDeltaTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Tooltip("射线长度,以胶囊体中心为起始点")]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSLimitCharacterOnLand:RayLength")]
	public float RayLength
	{
		get
		{
			CheckDestroyed();
			if (!RayLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSLimitCharacterOnLand:RayLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RayLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RayLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSLimitCharacterOnLand:RayLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RayLength_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSLimitCharacterOnLand:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		UCharacterMovementComponent characterMovement = bGUCharacterCS.CharacterMovement;
		if (characterMovement == null)
		{
			return;
		}
		float num = 0f;
		if (bGUCharacterCS.CapsuleComponent != null)
		{
			num = bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
		}
		if (characterMovement.IsFalling())
		{
			UBGUSelectUtil.LineTraceForObjectsTypeSimple(bGUCharacterCS, BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS), BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) - new FVector(0.0, 0.0, RayLength), new List<EObjectTypeQuery> { EObjectTypeQuery.ObjectTypeQuery1 }, bDebug: false, out var HitResult);
			if (HitResult.HitActor != null)
			{
				BGUFuncLibActorTransformCS.BGUSetActorLocation(bGUCharacterCS, HitResult.HitLocation + new FVector(0.0, 0.0, num), bSweep: true, bTeleport: false, out var _, NeedReturnHitResult: true);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSLimitCharacterOnLand:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSLimitCharacterOnLand bANS_GSLimitCharacterOnLand = GCHelper.Find<b1.BANS_GSLimitCharacterOnLand>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSLimitCharacterOnLand.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSLimitCharacterOnLand");
		RayLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "RayLength");
		RayLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RayLength", Classes.FFloatProperty);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSLimitCharacterOnLand:GSNotifyTickCS", GSNotifyTickCS_IsValid);
	}

	static BANS_GSLimitCharacterOnLand()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSLimitCharacterOnLand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSLimitCharacterOnLand));
	}
}
