using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS Jump To Ceiling")]
[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling")]
internal class BANS_GSJumpToCeiling : BANS_GSBase
{
	private float TimeScale;

	private float HeightScale;

	private FVector OrignalLocation;

	private FRotator TargetRotator;

	private float LastTickAddPitch;

	private float Timer;

	private static bool HeightCurve_IsValid;

	private static int HeightCurve_Offset;

	private static bool PitchCurve_IsValid;

	private static int PitchCurve_Offset;

	private static bool MaxHeight_IsValid;

	private static int MaxHeight_Offset;

	private static bool bJumpUp_IsValid;

	private static int bJumpUp_Offset;

	private static FFieldAddress bJumpUp_PropertyAddress;

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

	[Category("Anim Notify")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling:HeightCurve")]
	public UCurveFloat HeightCurve
	{
		get
		{
			CheckDestroyed();
			if (!HeightCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:HeightCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, HeightCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HeightCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:HeightCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, HeightCurve_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling:PitchCurve")]
	public UCurveFloat PitchCurve
	{
		get
		{
			CheckDestroyed();
			if (!PitchCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:PitchCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, PitchCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PitchCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:PitchCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, PitchCurve_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling:MaxHeight")]
	public float MaxHeight
	{
		get
		{
			CheckDestroyed();
			if (!MaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:MaxHeight");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxHeight_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxHeight_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:MaxHeight");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxHeight_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Anim Notify")]
	[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling:bJumpUp")]
	public bool bJumpUp
	{
		get
		{
			CheckDestroyed();
			if (!bJumpUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:bJumpUp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bJumpUp_Offset), 0, bJumpUp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bJumpUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSJumpToCeiling:bJumpUp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bJumpUp_Offset), 0, bJumpUp_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (TimeScale == 0f || HeightScale == 0f)
		{
			return;
		}
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			Timer += FrameDeltaTime;
			float inTime = Timer / TimeScale;
			if (HeightCurve != null)
			{
				float num = HeightCurve.GetFloatValue(inTime) * HeightScale;
				FVector newLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(owner);
				newLocation.Z = (bJumpUp ? (OrignalLocation.Z + num) : (OrignalLocation.Z - num));
				BGUFuncLibActorTransformCS.BGUSetActorLocation(owner, newLocation, bSweep: true, bTeleport: false, out var _);
			}
			if (PitchCurve != null)
			{
				float num2 = PitchCurve.GetFloatValue(inTime) * 180f;
				float pitch = num2 - LastTickAddPitch;
				LastTickAddPitch = num2;
				FRotator newRotation = UMathLibrary.TransformRotation(Rotation: new FRotator
				{
					Pitch = pitch
				}, T: BGUFuncLibActorTransformCS.BGUGetActorTransform(owner));
				BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, newRotation, bTeleportPhysics: false);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor owner = NotifyParam.owner;
		if (!(owner == null))
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(owner, TargetRotator, bTeleportPhysics: false);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
		ACharacter aCharacter = NotifyParam.owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		TargetRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(aCharacter);
		UCapsuleComponent uCapsuleComponent = aCharacter.GetRootComponent() as UCapsuleComponent;
		if (!(uCapsuleComponent == null))
		{
			float scaledCapsuleHalfHeight = uCapsuleComponent.GetScaledCapsuleHalfHeight();
			FVector worldLocation = uCapsuleComponent.GetWorldLocation();
			FVector endTrace = worldLocation;
			endTrace.Z = (bJumpUp ? (endTrace.Z + MaxHeight - scaledCapsuleHalfHeight) : (endTrace.Z - MaxHeight + scaledCapsuleHalfHeight));
			if (UBGUSelectUtil.LineTraceSimple(aCharacter, worldLocation, endTrace, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out var HitResult, null) > 0)
			{
				OrignalLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aCharacter);
				TargetRotator = UMathLibrary.TransformRotation(Rotation: new FRotator
				{
					Pitch = 180f
				}, T: BGUFuncLibActorTransformCS.BGUGetActorTransform(aCharacter));
				FVector hitLocation = HitResult.HitLocation;
				float heightScale = (bJumpUp ? (hitLocation.Z - worldLocation.Z - scaledCapsuleHalfHeight) : (worldLocation.Z - hitLocation.Z + scaledCapsuleHalfHeight));
				TimeScale = TotalDuration;
				HeightScale = heightScale;
				LastTickAddPitch = 0f;
				Timer = 0f;
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSJumpToCeiling bANS_GSJumpToCeiling = GCHelper.Find<b1.BANS_GSJumpToCeiling>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSJumpToCeiling.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSJumpToCeiling bANS_GSJumpToCeiling = GCHelper.Find<b1.BANS_GSJumpToCeiling>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSJumpToCeiling.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSJumpToCeiling bANS_GSJumpToCeiling = GCHelper.Find<b1.BANS_GSJumpToCeiling>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSJumpToCeiling.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSJumpToCeiling");
		HeightCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "HeightCurve");
		HeightCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "HeightCurve", Classes.FObjectProperty);
		PitchCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "PitchCurve");
		PitchCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PitchCurve", Classes.FObjectProperty);
		MaxHeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxHeight");
		MaxHeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxHeight", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bJumpUp_PropertyAddress, intPtr, "bJumpUp");
		bJumpUp_Offset = NativeReflection.GetPropertyOffset(intPtr, "bJumpUp");
		bJumpUp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bJumpUp", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSJumpToCeiling:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSJumpToCeiling()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSJumpToCeiling)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSJumpToCeiling));
	}
}
