using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.ActorComp;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.BGUAudioSystem")]
public class BGUAudioSystem : UActorComponent
{
	private static bool StateGroup_IsValid;

	private static int StateGroup_Offset;

	private static bool AliveStateName_IsValid;

	private static int AliveStateName_Offset;

	private static bool DeadStateName_IsValid;

	private static int DeadStateName_Offset;

	private static bool OnDead_IsValid;

	private static IntPtr OnDead_FunctionAddress;

	private static int OnDead_ParamsSize;

	private static bool OnDead_Attacker_IsValid;

	private static int OnDead_Attacker_Offset;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUAudioSystem:StateGroup")]
	public FName StateGroup
	{
		get
		{
			CheckDestroyed();
			if (!StateGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioSystem:StateGroup");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, StateGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StateGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioSystem:StateGroup");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, StateGroup_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUAudioSystem:AliveStateName")]
	public FName AliveStateName
	{
		get
		{
			CheckDestroyed();
			if (!AliveStateName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioSystem:AliveStateName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AliveStateName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AliveStateName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioSystem:AliveStateName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AliveStateName_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUAudioSystem:DeadStateName")]
	public FName DeadStateName
	{
		get
		{
			CheckDestroyed();
			if (!DeadStateName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioSystem:DeadStateName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, DeadStateName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DeadStateName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioSystem:DeadStateName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, DeadStateName_Offset), value);
			}
		}
	}

	private void SetAkState(FName StateName)
	{
		string plainName = StateName.PlainName;
		if (plainName.Length > 0 && plainName != "None")
		{
			UAkGameplayStatics.SetState(null, StateGroup, StateName);
		}
	}

	[USharpPath("/Script/b1-Managed.BGUAudioSystem:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		SetAkState(AliveStateName);
		ABGUCharacter aBGUCharacter = GetOwner() as ABGUCharacter;
		if (aBGUCharacter != null)
		{
			aBGUCharacter.GetBUSEventCollection().FBUE_BP_UnitDie.Bind(this, B1GlobalFNames.OnDead);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUAudioSystem:OnDead")]
	public void OnDead(AActor Attacker)
	{
		SetAkState(DeadStateName);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUAudioSystem:OnDead")]
	private static void OnDead__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUAudioSystem bGUAudioSystem = GCHelper.Find<BGUAudioSystem>(obj);
		AActor attacker = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnDead_Attacker_Offset));
		bGUAudioSystem.OnDead(attacker);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUAudioSystem:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUAudioSystem bGUAudioSystem = GCHelper.Find<BGUAudioSystem>(obj);
		bGUAudioSystem.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUAudioSystem");
		StateGroup_Offset = NativeReflection.GetPropertyOffset(intPtr, "StateGroup");
		StateGroup_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StateGroup", Classes.FNameProperty);
		AliveStateName_Offset = NativeReflection.GetPropertyOffset(intPtr, "AliveStateName");
		AliveStateName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AliveStateName", Classes.FNameProperty);
		DeadStateName_Offset = NativeReflection.GetPropertyOffset(intPtr, "DeadStateName");
		DeadStateName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DeadStateName", Classes.FNameProperty);
		OnDead_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnDead");
		OnDead_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDead_FunctionAddress);
		OnDead_Attacker_Offset = NativeReflection.GetPropertyOffset(OnDead_FunctionAddress, "Attacker");
		OnDead_Attacker_IsValid = NativeReflection.ValidatePropertyClass(OnDead_FunctionAddress, "Attacker", Classes.FObjectProperty);
		OnDead_IsValid = OnDead_FunctionAddress != IntPtr.Zero && OnDead_Attacker_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUAudioSystem:OnDead", OnDead_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUAudioSystem:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BGUAudioSystem()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUAudioSystem)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUAudioSystem));
	}
}
