using System;
using b1.BGU.BUAnim;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimInteractiveActor")]
public class BUAnimInteractiveActor : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	private static bool ABPSetting_IsValid;

	private static int ABPSetting_Offset;

	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[Category("Setting")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUAnimInteractiveActor:ABPSetting")]
	public BGWDataAsset_AnimInteractiveActorSetting ABPSetting
	{
		get
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimInteractiveActor:ABPSetting");
				return null;
			}
			return UObjectMarshaler<BGWDataAsset_AnimInteractiveActorSetting>.FromNative(IntPtr.Add(base.Address, ABPSetting_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ABPSetting_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimInteractiveActor:ABPSetting");
			}
			else
			{
				UObjectMarshaler<BGWDataAsset_AnimInteractiveActorSetting>.ToNative(IntPtr.Add(base.Address, ABPSetting_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("Interactive Actor Animation")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUAnimInteractiveActor:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimInteractiveActor:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimInteractiveActor:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimInteractiveActor:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
		base.SkipBlueprintUpdateAnimation = 1;
		InitData();
	}

	public void OnEntityInitFinish()
	{
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	private void InitData()
	{
		if (!(ABPSetting == null))
		{
			AnimIdle = ABPSetting.AnimIdle;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimInteractiveActor:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUAnimInteractiveActor bUAnimInteractiveActor = GCHelper.Find<BUAnimInteractiveActor>(obj);
		bUAnimInteractiveActor.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimInteractiveActor");
		ABPSetting_Offset = NativeReflection.GetPropertyOffset(intPtr, "ABPSetting");
		ABPSetting_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ABPSetting", Classes.FObjectProperty);
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimInteractiveActor:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnimInteractiveActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUAnimInteractiveActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUAnimInteractiveActor));
	}
}
