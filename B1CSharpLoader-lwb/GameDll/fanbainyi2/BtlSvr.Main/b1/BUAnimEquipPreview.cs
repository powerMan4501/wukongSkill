using System;
using b1.BGU.BUAnim;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUAnimEquipPreview")]
internal class BUAnimEquipPreview : UAnimInstance, b1.BGU.BUAnim.IBUEnityAnim
{
	private static bool AnimIdle_IsValid;

	private static int AnimIdle_Offset;

	private static bool BlueprintBeginPlay_IsValid;

	private static IntPtr BlueprintBeginPlay_FunctionAddress;

	private static int BlueprintBeginPlay_ParamsSize;

	private static bool BlueprintUpdateAnimation_IsValid;

	private static IntPtr BlueprintUpdateAnimation_FunctionAddress;

	private static int BlueprintUpdateAnimation_ParamsSize;

	private static bool BlueprintUpdateAnimation_DeltaTimeX_IsValid;

	private static int BlueprintUpdateAnimation_DeltaTimeX_Offset;

	private static bool BlueprintInitializeAnimation_IsValid;

	private static IntPtr BlueprintInitializeAnimation_FunctionAddress;

	private static int BlueprintInitializeAnimation_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Equip Preview Actor Animation")]
	[USharpPath("/Script/b1-Managed.BUAnimEquipPreview:AnimIdle")]
	public UAnimSequence AnimIdle
	{
		get
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimEquipPreview:AnimIdle");
				return null;
			}
			return UObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AnimIdle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AnimIdle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUAnimEquipPreview:AnimIdle");
			}
			else
			{
				UObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AnimIdle_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUAnimEquipPreview:BlueprintInitializeAnimation")]
	protected override void BlueprintInitializeAnimation_Implementation()
	{
	}

	[USharpPath("/Script/b1-Managed.BUAnimEquipPreview:BlueprintBeginPlay")]
	protected override void BlueprintBeginPlay_Implementation()
	{
	}

	[USharpPath("/Script/b1-Managed.BUAnimEquipPreview:BlueprintUpdateAnimation")]
	protected override void BlueprintUpdateAnimation_Implementation(float DeltaTimeX)
	{
	}

	public void OnEntityInitFinish()
	{
	}

	public void OnEntityEndPlay(EEndPlayReason EndPlayReason)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimEquipPreview:BlueprintBeginPlay")]
	private static void BlueprintBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimEquipPreview bUAnimEquipPreview = GCHelper.Find<b1.BUAnimEquipPreview>(obj);
		bUAnimEquipPreview.BlueprintBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimEquipPreview:BlueprintUpdateAnimation")]
	private static void BlueprintUpdateAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimEquipPreview bUAnimEquipPreview = GCHelper.Find<b1.BUAnimEquipPreview>(obj);
		float deltaTimeX = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, BlueprintUpdateAnimation_DeltaTimeX_Offset));
		bUAnimEquipPreview.BlueprintUpdateAnimation_Implementation(deltaTimeX);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUAnimEquipPreview:BlueprintInitializeAnimation")]
	private static void BlueprintInitializeAnimation__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BUAnimEquipPreview bUAnimEquipPreview = GCHelper.Find<b1.BUAnimEquipPreview>(obj);
		bUAnimEquipPreview.BlueprintInitializeAnimation_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUAnimEquipPreview");
		AnimIdle_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimIdle");
		AnimIdle_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimIdle", Classes.FObjectProperty);
		BlueprintBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintBeginPlay");
		BlueprintBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintBeginPlay_FunctionAddress);
		BlueprintBeginPlay_IsValid = BlueprintBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimEquipPreview:BlueprintBeginPlay", BlueprintBeginPlay_IsValid);
		BlueprintUpdateAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintUpdateAnimation");
		BlueprintUpdateAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintUpdateAnimation_FunctionAddress);
		BlueprintUpdateAnimation_DeltaTimeX_Offset = NativeReflection.GetPropertyOffset(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX");
		BlueprintUpdateAnimation_DeltaTimeX_IsValid = NativeReflection.ValidatePropertyClass(BlueprintUpdateAnimation_FunctionAddress, "DeltaTimeX", Classes.FFloatProperty);
		BlueprintUpdateAnimation_IsValid = BlueprintUpdateAnimation_FunctionAddress != IntPtr.Zero && BlueprintUpdateAnimation_DeltaTimeX_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimEquipPreview:BlueprintUpdateAnimation", BlueprintUpdateAnimation_IsValid);
		BlueprintInitializeAnimation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BlueprintInitializeAnimation");
		BlueprintInitializeAnimation_ParamsSize = NativeReflection.GetFunctionParamsSize(BlueprintInitializeAnimation_FunctionAddress);
		BlueprintInitializeAnimation_IsValid = BlueprintInitializeAnimation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUAnimEquipPreview:BlueprintInitializeAnimation", BlueprintInitializeAnimation_IsValid);
	}

	static BUAnimEquipPreview()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUAnimEquipPreview)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUAnimEquipPreview));
	}
}
