using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("演员播放BeginLoop动画")]
[USharpPath("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage")]
public class UPerformerAction_PlayBeginLoopMontage : UPerformerActionBase
{
	private static bool Performer_IsValid;

	private static int Performer_Offset;

	private static bool BeginMontage_IsValid;

	private static int BeginMontage_Offset;

	private static bool LoopMontage_IsValid;

	private static int LoopMontage_Offset;

	private static bool OnMontageBlendingOut_IsValid;

	private static IntPtr OnMontageBlendingOut_FunctionAddress;

	private static int OnMontageBlendingOut_ParamsSize;

	private static bool OnMontageBlendingOut_InMontage_IsValid;

	private static int OnMontageBlendingOut_InMontage_Offset;

	private static bool OnMontageBlendingOut_bInterrupted_IsValid;

	private static int OnMontageBlendingOut_bInterrupted_Offset;

	private static FFieldAddress OnMontageBlendingOut_bInterrupted_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:Performer")]
	public FGsSmartParam Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:Performer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:Performer");
			}
			else
			{
				FGsSmartParam.ToNative(IntPtr.Add(base.Address, Performer_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:BeginMontage")]
	public UAnimMontage BeginMontage
	{
		get
		{
			CheckDestroyed();
			if (!BeginMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:BeginMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, BeginMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:BeginMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, BeginMontage_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:LoopMontage")]
	public UAnimMontage LoopMontage
	{
		get
		{
			CheckDestroyed();
			if (!LoopMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:LoopMontage");
				return null;
			}
			return UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(base.Address, LoopMontage_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LoopMontage_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:LoopMontage");
			}
			else
			{
				UObjectMarshaler<UAnimMontage>.ToNative(IntPtr.Add(base.Address, LoopMontage_Offset), value);
			}
		}
	}

	protected override bool DoAction()
	{
		if (base.ControlComp.GetParamActorGuid(Performer.ConfigGuid, out var OutActorGuid))
		{
			BGUPerformerActorCS bGUPerformerActorCS = BGU_DataUtil.GetActorByGuid(this, OutActorGuid) as BGUPerformerActorCS;
			if (bGUPerformerActorCS != null)
			{
				UAnimInstance animInstance = bGUPerformerActorCS.Mesh.GetAnimInstance();
				if (animInstance != null)
				{
					if (BeginMontage != null)
					{
						BGUFuncLibAnim.BGUActorTryPlayMontage(bGUPerformerActorCS, BeginMontage, FName.None);
						animInstance.OnMontageBlendingOut.Bind(this, B1GlobalFNames.OnMontageBlendingOut);
						return false;
					}
					if (LoopMontage != null)
					{
						BGUFuncLibAnim.BGUActorTryPlayMontage(bGUPerformerActorCS, LoopMontage, FName.None);
					}
				}
			}
		}
		return true;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:OnMontageBlendingOut")]
	public void OnMontageBlendingOut(UAnimMontage InMontage, bool bInterrupted)
	{
		if (!base.ControlComp.GetParamActorGuid(Performer.ConfigGuid, out var OutActorGuid))
		{
			return;
		}
		BGUPerformerActorCS bGUPerformerActorCS = BGU_DataUtil.GetActorByGuid(this, OutActorGuid) as BGUPerformerActorCS;
		if (bGUPerformerActorCS != null)
		{
			UAnimInstance animInstance = bGUPerformerActorCS.Mesh.GetAnimInstance();
			if (animInstance != null)
			{
				animInstance.OnMontageBlendingOut.Unbind(this, B1GlobalFNames.OnMontageBlendingOut);
				BGUFuncLibAnim.BGUActorTryPlayMontage(bGUPerformerActorCS, LoopMontage, FName.None);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:OnMontageBlendingOut")]
	private static void OnMontageBlendingOut__Invoker(IntPtr buffer, IntPtr obj)
	{
		UPerformerAction_PlayBeginLoopMontage uPerformerAction_PlayBeginLoopMontage = GCHelper.Find<UPerformerAction_PlayBeginLoopMontage>(obj);
		UAnimMontage inMontage = UObjectMarshaler<UAnimMontage>.FromNative(IntPtr.Add(buffer, OnMontageBlendingOut_InMontage_Offset));
		bool bInterrupted = BoolMarshaler.FromNative(IntPtr.Add(buffer, OnMontageBlendingOut_bInterrupted_Offset), 0, OnMontageBlendingOut_bInterrupted_PropertyAddress.Address);
		uPerformerAction_PlayBeginLoopMontage.OnMontageBlendingOut(inMontage, bInterrupted);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage");
		Performer_Offset = NativeReflection.GetPropertyOffset(intPtr, "Performer");
		Performer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Performer", Classes.FStructProperty);
		BeginMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginMontage");
		BeginMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginMontage", Classes.FObjectProperty);
		LoopMontage_Offset = NativeReflection.GetPropertyOffset(intPtr, "LoopMontage");
		LoopMontage_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LoopMontage", Classes.FObjectProperty);
		OnMontageBlendingOut_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnMontageBlendingOut");
		OnMontageBlendingOut_ParamsSize = NativeReflection.GetFunctionParamsSize(OnMontageBlendingOut_FunctionAddress);
		OnMontageBlendingOut_InMontage_Offset = NativeReflection.GetPropertyOffset(OnMontageBlendingOut_FunctionAddress, "InMontage");
		OnMontageBlendingOut_InMontage_IsValid = NativeReflection.ValidatePropertyClass(OnMontageBlendingOut_FunctionAddress, "InMontage", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnMontageBlendingOut_bInterrupted_PropertyAddress, OnMontageBlendingOut_FunctionAddress, "bInterrupted");
		OnMontageBlendingOut_bInterrupted_Offset = NativeReflection.GetPropertyOffset(OnMontageBlendingOut_FunctionAddress, "bInterrupted");
		OnMontageBlendingOut_bInterrupted_IsValid = NativeReflection.ValidatePropertyClass(OnMontageBlendingOut_FunctionAddress, "bInterrupted", Classes.FBoolProperty);
		OnMontageBlendingOut_IsValid = OnMontageBlendingOut_FunctionAddress != IntPtr.Zero && OnMontageBlendingOut_InMontage_IsValid && OnMontageBlendingOut_bInterrupted_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.PerformerAction_PlayBeginLoopMontage:OnMontageBlendingOut", OnMontageBlendingOut_IsValid);
	}

	static UPerformerAction_PlayBeginLoopMontage()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerAction_PlayBeginLoopMontage)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerAction_PlayBeginLoopMontage));
	}
}
