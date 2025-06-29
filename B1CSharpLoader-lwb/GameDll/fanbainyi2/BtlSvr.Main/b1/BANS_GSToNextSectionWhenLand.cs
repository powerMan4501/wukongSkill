using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("BANS GSToNextSectionWhenLand")]
[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand")]
internal class BANS_GSToNextSectionWhenLand : BANS_GSBase
{
	private static bool LineTraceStartSocket_IsValid;

	private static int LineTraceStartSocket_Offset;

	private static bool LineTraceLengthFix_IsValid;

	private static int LineTraceLengthFix_Offset;

	private static bool JumpSectionName_IsValid;

	private static int JumpSectionName_Offset;

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

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("射线起点Socket")]
	[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:LineTraceStartSocket")]
	public FName LineTraceStartSocket
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceStartSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:LineTraceStartSocket");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, LineTraceStartSocket_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceStartSocket_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:LineTraceStartSocket");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, LineTraceStartSocket_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("射线长度补偿")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:LineTraceLengthFix")]
	public float LineTraceLengthFix
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceLengthFix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:LineTraceLengthFix");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineTraceLengthFix_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceLengthFix_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:LineTraceLengthFix");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineTraceLengthFix_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("跳转Section")]
	[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:JumpSectionName")]
	public FName JumpSectionName
	{
		get
		{
			CheckDestroyed();
			if (!JumpSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:JumpSectionName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, JumpSectionName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!JumpSectionName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:JumpSectionName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, JumpSectionName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:EnableDebug")]
	public bool EnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:EnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!EnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:EnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, EnableDebug_Offset), 0, EnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		LineTraceStartSocket = B1GlobalFNames.pelvis;
		EnableDebug = false;
		JumpSectionName = B1GlobalFNames.End;
	}

	[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyBeginCS")]
	protected override void GSNotifyBeginCS_Implementation(FUStGSNotifyParam NotifyParam, float TotalDuration)
	{
	}

	[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyTickCS")]
	protected override void GSNotifyTickCS_Implementation(FUStGSNotifyParam NotifyParam, float FrameDeltaTime)
	{
		BGUCharacterCS bGUCharacterCS = NotifyParam.owner as BGUCharacterCS;
		if (bGUCharacterCS.IsNullOrDestroyed() || UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(NotifyParam.owner.World))
		{
			return;
		}
		UAnimMontage uAnimMontage = NotifyParam.Animation as UAnimMontage;
		if (!(uAnimMontage == null))
		{
			FVector socketLocation = bGUCharacterCS.Mesh.GetSocketLocation(LineTraceStartSocket);
			float scaledCapsuleHalfHeight = bGUCharacterCS.CapsuleComponent.GetScaledCapsuleHalfHeight();
			FVector endTrace = socketLocation + new FVector(0.0, 0.0, -1.0) * (scaledCapsuleHalfHeight + LineTraceLengthFix);
			if (UBGUSelectUtil.LineTraceSimple(bGUCharacterCS, socketLocation, endTrace, ETraceTypeQuery.TraceTypeQuery1, EnableDebug, out var _, null) > 0)
			{
				bGUCharacterCS.Mesh.GetAnimInstance().Montage_JumpToSection(JumpSectionName, uAnimMontage);
			}
			else if (bGUCharacterCS.CharacterMovement.CurrentFloor.BlockingHit)
			{
				bGUCharacterCS.Mesh.GetAnimInstance().Montage_JumpToSection(JumpSectionName, uAnimMontage);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyEndCS")]
	protected override void GSNotifyEndCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyEndCS")]
	private static void GSNotifyEndCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSToNextSectionWhenLand bANS_GSToNextSectionWhenLand = GCHelper.Find<b1.BANS_GSToNextSectionWhenLand>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyEndCS_NotifyParam_Offset));
		bANS_GSToNextSectionWhenLand.GSNotifyEndCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyTickCS")]
	private static void GSNotifyTickCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSToNextSectionWhenLand bANS_GSToNextSectionWhenLand = GCHelper.Find<b1.BANS_GSToNextSectionWhenLand>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_NotifyParam_Offset));
		float frameDeltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyTickCS_FrameDeltaTime_Offset));
		bANS_GSToNextSectionWhenLand.GSNotifyTickCS_Implementation(notifyParam, frameDeltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyBeginCS")]
	private static void GSNotifyBeginCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BANS_GSToNextSectionWhenLand bANS_GSToNextSectionWhenLand = GCHelper.Find<b1.BANS_GSToNextSectionWhenLand>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_NotifyParam_Offset));
		float totalDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, GSNotifyBeginCS_TotalDuration_Offset));
		bANS_GSToNextSectionWhenLand.GSNotifyBeginCS_Implementation(notifyParam, totalDuration);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BANS_GSToNextSectionWhenLand");
		LineTraceStartSocket_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceStartSocket");
		LineTraceStartSocket_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceStartSocket", Classes.FNameProperty);
		LineTraceLengthFix_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceLengthFix");
		LineTraceLengthFix_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceLengthFix", Classes.FFloatProperty);
		JumpSectionName_Offset = NativeReflection.GetPropertyOffset(intPtr, "JumpSectionName");
		JumpSectionName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "JumpSectionName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref EnableDebug_PropertyAddress, intPtr, "EnableDebug");
		EnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnableDebug");
		EnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnableDebug", Classes.FBoolProperty);
		GSNotifyEndCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyEndCS");
		GSNotifyEndCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyEndCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyEndCS_NotifyParam_PropertyAddress, GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyEndCS_FunctionAddress, "NotifyParam");
		GSNotifyEndCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyEndCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyEndCS_IsValid = GSNotifyEndCS_FunctionAddress != IntPtr.Zero && GSNotifyEndCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyEndCS", GSNotifyEndCS_IsValid);
		GSNotifyTickCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyTickCS");
		GSNotifyTickCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyTickCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyTickCS_NotifyParam_PropertyAddress, GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "NotifyParam");
		GSNotifyTickCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyTickCS_FrameDeltaTime_Offset = NativeReflection.GetPropertyOffset(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime");
		GSNotifyTickCS_FrameDeltaTime_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyTickCS_FunctionAddress, "FrameDeltaTime", Classes.FFloatProperty);
		GSNotifyTickCS_IsValid = GSNotifyTickCS_FunctionAddress != IntPtr.Zero && GSNotifyTickCS_NotifyParam_IsValid && GSNotifyTickCS_FrameDeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyTickCS", GSNotifyTickCS_IsValid);
		GSNotifyBeginCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyBeginCS");
		GSNotifyBeginCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyBeginCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyBeginCS_NotifyParam_PropertyAddress, GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "NotifyParam");
		GSNotifyBeginCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyBeginCS_TotalDuration_Offset = NativeReflection.GetPropertyOffset(GSNotifyBeginCS_FunctionAddress, "TotalDuration");
		GSNotifyBeginCS_TotalDuration_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyBeginCS_FunctionAddress, "TotalDuration", Classes.FFloatProperty);
		GSNotifyBeginCS_IsValid = GSNotifyBeginCS_FunctionAddress != IntPtr.Zero && GSNotifyBeginCS_NotifyParam_IsValid && GSNotifyBeginCS_TotalDuration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BANS_GSToNextSectionWhenLand:GSNotifyBeginCS", GSNotifyBeginCS_IsValid);
	}

	static BANS_GSToNextSectionWhenLand()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BANS_GSToNextSectionWhenLand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BANS_GSToNextSectionWhenLand));
	}
}
