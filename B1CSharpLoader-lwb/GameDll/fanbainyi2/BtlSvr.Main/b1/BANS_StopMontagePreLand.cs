using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BANS StopMontagePreLand")]
[UClass]
[USharpPath("/Script/b1-Managed.BANS_StopMontagePreLand")]
internal class BANS_StopMontagePreLand : BANS_GSBase
{
	private static bool LineTraceLengthFix_IsValid;

	private static int LineTraceLengthFix_Offset;

	private static bool EnableDebug_IsValid;

	private static int EnableDebug_Offset;

	private static FFieldAddress EnableDebug_PropertyAddress;

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
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_StopMontagePreLand:LineTraceLengthFix")]
	public float LineTraceLengthFix
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceLengthFix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_StopMontagePreLand:LineTraceLengthFix");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineTraceLengthFix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceLengthFix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_StopMontagePreLand:LineTraceLengthFix");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineTraceLengthFix_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_StopMontagePreLand:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_StopMontagePreLand:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_StopMontagePreLand:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		EnableDebug = false;
	}

	[USharpPath("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		if (UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed())
		{
			return;
		}
		UAnimMontage uAnimMontage = NotifyParam.Animation as UAnimMontage;
		if (uAnimMontage == null)
		{
			return;
		}
		FVector fVector = new FVector(0.0, 0.0, LineTraceLengthFix);
		if (fVector.Size() < 1E-08f)
		{
			return;
		}
		FVector start = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
		FVector end = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS) + fVector;
		if (USystemLibrary.CapsuleTraceMultiByProfile(bGUCharacterCS, start, end, bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight(), B1GlobalFNames.Pawn, bTraceComplex: false, null, EnableDebug ? EDrawDebugTrace.ForDuration : EDrawDebugTrace.None, out var _, bIgnoreSelf: true, FLinearColor.Green, FLinearColor.Red, 0.05f))
		{
			if (EnableDebug)
			{
				USystemLibrary.DrawDebugCapsule(bGUCharacterCS, bGUCharacterCS.GetActorLocation(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius(), bGUCharacterCS.GetActorRotation(), FLinearColor.Green, 3f, 2f);
			}
			bGUCharacterCS.StopAnimMontage(uAnimMontage);
		}
		else if (bGUCharacterCS.CharacterMovement.CurrentFloor.BlockingHit)
		{
			if (EnableDebug)
			{
				USystemLibrary.DrawDebugCapsule(bGUCharacterCS, bGUCharacterCS.GetActorLocation(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight(), bGUCharacterCS.CapsuleComponent.GetScaledCapsuleRadius(), bGUCharacterCS.GetActorRotation(), FLinearColor.Blue, 3f, 2f);
			}
			bGUCharacterCS.StopAnimMontage(uAnimMontage);
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_StopMontagePreLand bANS_StopMontagePreLand = GCHelper.Find<b1.BANS_StopMontagePreLand>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_StopMontagePreLand.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_StopMontagePreLand bANS_StopMontagePreLand = GCHelper.Find<b1.BANS_StopMontagePreLand>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_StopMontagePreLand.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_StopMontagePreLand bANS_StopMontagePreLand = GCHelper.Find<b1.BANS_StopMontagePreLand>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_StopMontagePreLand.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_StopMontagePreLand");
		LineTraceLengthFix_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceLengthFix");
		LineTraceLengthFix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceLengthFix", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, intPtr, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebug", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_StopMontagePreLand:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_StopMontagePreLand()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_StopMontagePreLand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_StopMontagePreLand));
	}
}
