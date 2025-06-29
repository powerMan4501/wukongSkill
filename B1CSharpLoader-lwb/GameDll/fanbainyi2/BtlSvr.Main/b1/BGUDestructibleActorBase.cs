using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.BGUDestructibleActorBase")]
public class BGUDestructibleActorBase : BGUFXActorBase
{
	private static bool RootScaleFactor_IsValid;

	private static int RootScaleFactor_Offset;

	private static bool DisableCollision_IsValid;

	private static IntPtr DisableCollision_FunctionAddress;

	private static int DisableCollision_ParamsSize;

	private static bool InitDestructedEffect_IsValid;

	private static IntPtr InitDestructedEffect_FunctionAddress;

	private static int InitDestructedEffect_ParamsSize;

	private IntPtr InitDestructedEffect_InstanceFunctionAddressInstance;

	private static bool PlayDestructedEffect_IsValid;

	private static IntPtr PlayDestructedEffect_FunctionAddress;

	private static int PlayDestructedEffect_ParamsSize;

	private static bool PlayDestructedEffect_SinkDelay_IsValid;

	private static int PlayDestructedEffect_SinkDelay_Offset;

	private static bool PlayDestructedEffect_SinkVelocity_IsValid;

	private static int PlayDestructedEffect_SinkVelocity_Offset;

	private static bool PlayDestructedEffect_AtkActor_IsValid;

	private static int PlayDestructedEffect_AtkActor_Offset;

	private IntPtr PlayDestructedEffect_InstanceFunctionAddressInstance;

	private static bool ResetDestructedEffect_IsValid;

	private static IntPtr ResetDestructedEffect_FunctionAddress;

	private static int ResetDestructedEffect_ParamsSize;

	private IntPtr ResetDestructedEffect_InstanceFunctionAddressInstance;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[Category("Destructible")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUDestructibleActorBase:RootScaleFactor")]
	public float RootScaleFactor
	{
		get
		{
			CheckDestroyed();
			if (!RootScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDestructibleActorBase:RootScaleFactor");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RootScaleFactor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RootScaleFactor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUDestructibleActorBase:RootScaleFactor");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RootScaleFactor_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[Category("Destructible")]
	[USharpPath("/Script/b1-Managed.BGUDestructibleActorBase:InitDestructedEffect")]
	public unsafe void InitDestructedEffect()
	{
		CheckDestroyed();
		if (!InitDestructedEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUDestructibleActorBase:InitDestructedEffect");
			return;
		}
		if (InitDestructedEffect_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			InitDestructedEffect_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "InitDestructedEffect");
		}
		byte* value = stackalloc byte[(int)(uint)InitDestructedEffect_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, InitDestructedEffect_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, InitDestructedEffect_InstanceFunctionAddressInstance, intPtr, InitDestructedEffect_ParamsSize);
	}

	[Category("Destructible")]
	[BlueprintImplementedEvent]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUDestructibleActorBase:PlayDestructedEffect")]
	public unsafe void PlayDestructedEffect(float SinkDelay = 0f, float SinkVelocity = 1f, AActor AtkActor = null)
	{
		CheckDestroyed();
		if (!PlayDestructedEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUDestructibleActorBase:PlayDestructedEffect");
			return;
		}
		if (PlayDestructedEffect_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			PlayDestructedEffect_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "PlayDestructedEffect");
		}
		byte* value = stackalloc byte[(int)(uint)PlayDestructedEffect_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, PlayDestructedEffect_ParamsSize);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayDestructedEffect_SinkDelay_Offset), SinkDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, PlayDestructedEffect_SinkVelocity_Offset), SinkVelocity);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, PlayDestructedEffect_AtkActor_Offset), AtkActor);
		NativeReflection.InvokeFunction(base.Address, PlayDestructedEffect_InstanceFunctionAddressInstance, intPtr, PlayDestructedEffect_ParamsSize);
	}

	[BlueprintImplementedEvent]
	[BlueprintCallable]
	[Category("Destructible")]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUDestructibleActorBase:ResetDestructedEffect")]
	public unsafe void ResetDestructedEffect()
	{
		CheckDestroyed();
		if (!ResetDestructedEffect_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1-Managed.BGUDestructibleActorBase:ResetDestructedEffect");
			return;
		}
		if (ResetDestructedEffect_InstanceFunctionAddressInstance == IntPtr.Zero)
		{
			ResetDestructedEffect_InstanceFunctionAddressInstance = NativeReflection.GetFunctionFromInstance(base.Address, "ResetDestructedEffect");
		}
		byte* value = stackalloc byte[(int)(uint)ResetDestructedEffect_ParamsSize];
		IntPtr intPtr = new IntPtr(value);
		FMemory.Memzero(intPtr, ResetDestructedEffect_ParamsSize);
		NativeReflection.InvokeFunction(base.Address, ResetDestructedEffect_InstanceFunctionAddressInstance, intPtr, ResetDestructedEffect_ParamsSize);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("Destructible")]
	[USharpPath("/Script/b1-Managed.BGUDestructibleActorBase:DisableCollision")]
	public void DisableCollision()
	{
		UStaticMeshComponent componentByClass = GetComponentByClass<UStaticMeshComponent>();
		if (componentByClass != null)
		{
			componentByClass.SetCollisionEnabled(ECollisionEnabled.NoCollision);
		}
	}

	[USharpPath("/Script/b1-Managed.BGUDestructibleActorBase:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDestructibleActorBase:DisableCollision")]
	private static void DisableCollision__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUDestructibleActorBase bGUDestructibleActorBase = GCHelper.Find<BGUDestructibleActorBase>(obj);
		bGUDestructibleActorBase.DisableCollision();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUDestructibleActorBase:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUDestructibleActorBase bGUDestructibleActorBase = GCHelper.Find<BGUDestructibleActorBase>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUDestructibleActorBase.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUDestructibleActorBase");
		RootScaleFactor_Offset = NativeReflection.GetPropertyOffset(intPtr, "RootScaleFactor");
		RootScaleFactor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RootScaleFactor", Classes.FFloatProperty);
		DisableCollision_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DisableCollision");
		DisableCollision_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableCollision_FunctionAddress);
		DisableCollision_IsValid = DisableCollision_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDestructibleActorBase:DisableCollision", DisableCollision_IsValid);
		InitDestructedEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "InitDestructedEffect");
		InitDestructedEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(InitDestructedEffect_FunctionAddress);
		InitDestructedEffect_IsValid = InitDestructedEffect_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDestructibleActorBase:InitDestructedEffect", InitDestructedEffect_IsValid);
		PlayDestructedEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PlayDestructedEffect");
		PlayDestructedEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(PlayDestructedEffect_FunctionAddress);
		PlayDestructedEffect_SinkDelay_Offset = NativeReflection.GetPropertyOffset(PlayDestructedEffect_FunctionAddress, "SinkDelay");
		PlayDestructedEffect_SinkDelay_IsValid = NativeReflection.ValidatePropertyClass(PlayDestructedEffect_FunctionAddress, "SinkDelay", Classes.FFloatProperty);
		PlayDestructedEffect_SinkVelocity_Offset = NativeReflection.GetPropertyOffset(PlayDestructedEffect_FunctionAddress, "SinkVelocity");
		PlayDestructedEffect_SinkVelocity_IsValid = NativeReflection.ValidatePropertyClass(PlayDestructedEffect_FunctionAddress, "SinkVelocity", Classes.FFloatProperty);
		PlayDestructedEffect_AtkActor_Offset = NativeReflection.GetPropertyOffset(PlayDestructedEffect_FunctionAddress, "AtkActor");
		PlayDestructedEffect_AtkActor_IsValid = NativeReflection.ValidatePropertyClass(PlayDestructedEffect_FunctionAddress, "AtkActor", Classes.FObjectProperty);
		PlayDestructedEffect_IsValid = PlayDestructedEffect_FunctionAddress != IntPtr.Zero && PlayDestructedEffect_SinkDelay_IsValid && PlayDestructedEffect_SinkVelocity_IsValid && PlayDestructedEffect_AtkActor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDestructibleActorBase:PlayDestructedEffect", PlayDestructedEffect_IsValid);
		ResetDestructedEffect_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetDestructedEffect");
		ResetDestructedEffect_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetDestructedEffect_FunctionAddress);
		ResetDestructedEffect_IsValid = ResetDestructedEffect_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDestructibleActorBase:ResetDestructedEffect", ResetDestructedEffect_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUDestructibleActorBase:ReceiveTick", ReceiveTick_IsValid);
	}

	static BGUDestructibleActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUDestructibleActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUDestructibleActorBase));
	}
}
