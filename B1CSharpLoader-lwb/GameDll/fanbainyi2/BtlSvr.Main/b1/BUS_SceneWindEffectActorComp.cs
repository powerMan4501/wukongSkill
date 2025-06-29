using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BUS_SceneWindEffectActorComp")]
public class BUS_SceneWindEffectActorComp : UBaseActorCompTickable
{
	private List<USkeletalMeshComponent> SkeletalMeshComps;

	private List<float> WindStrengthForPerBody;

	private AActor Owner;

	private static bool WindEffectStrength_IsValid;

	private static int WindEffectStrength_Offset;

	private static bool WindEffectCompTag_IsValid;

	private static int WindEffectCompTag_Offset;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("配置信息")]
	[DisplayName("风吹晃动幅度")]
	[USharpPath("/Script/b1-Managed.BUS_SceneWindEffectActorComp:WindEffectStrength")]
	public float WindEffectStrength
	{
		get
		{
			CheckDestroyed();
			if (!WindEffectStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneWindEffectActorComp:WindEffectStrength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, WindEffectStrength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindEffectStrength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneWindEffectActorComp:WindEffectStrength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, WindEffectStrength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("影响组件Tag")]
	[BlueprintReadWrite]
	[Category("配置信息")]
	[USharpPath("/Script/b1-Managed.BUS_SceneWindEffectActorComp:WindEffectCompTag")]
	public FName WindEffectCompTag
	{
		get
		{
			CheckDestroyed();
			if (!WindEffectCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneWindEffectActorComp:WindEffectCompTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, WindEffectCompTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!WindEffectCompTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneWindEffectActorComp:WindEffectCompTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, WindEffectCompTag_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.IsEditorOnly = false;
	}

	[USharpPath("/Script/b1-Managed.BUS_SceneWindEffectActorComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		Owner = GetOwner();
		List<UActorComponent> list = ((!(WindEffectCompTag == FName.None)) ? Owner.GetComponentsByTag(UClass.GetClass<USkeletalMeshComponent>(), WindEffectCompTag) : Owner.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()));
		SkeletalMeshComps = new List<USkeletalMeshComponent>();
		WindStrengthForPerBody = new List<float>();
		foreach (UActorComponent item in list)
		{
			USkeletalMeshComponent uSkeletalMeshComponent = item as USkeletalMeshComponent;
			int num = UBGUFunctionLibrary.BGUGetSkeletalMeshSimulatedBodiesBelowNum(uSkeletalMeshComponent, uSkeletalMeshComponent.GetBoneName(0), bIncludeSelf: false);
			if (uSkeletalMeshComponent != null && num != 0)
			{
				SkeletalMeshComps.Add(uSkeletalMeshComponent);
				WindStrengthForPerBody.Add(WindEffectStrength / (float)num);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_SceneWindEffectActorComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		bool IsValid;
		float num = UBGUFunctionLibraryForCS.BGUGetCurrentTime(GetOwner(), out IsValid);
		UBGUFunctionLibrary.BGUGetWindParameters_GameThread(GetOwner(), out var Position, out var OutDirection, out var OutSpeed, out var _, out var _);
		float num2 = (UBGUFunctionLibrary.BGUPerlinNoise1D((GetOwner().GetActorLocation() - Position).Size() + num) + 1f) / 2f;
		FVector fVector = OutDirection * OutSpeed * num2;
		for (int i = 0; i < SkeletalMeshComps.Count; i++)
		{
			SkeletalMeshComps[i].AddForceToAllBodiesBelow(WindStrengthForPerBody[i] * fVector, SkeletalMeshComps[i].GetBoneName(0), bAccelChange: false, bIncludeSelf: false);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneWindEffectActorComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneWindEffectActorComp bUS_SceneWindEffectActorComp = GCHelper.Find<BUS_SceneWindEffectActorComp>(obj);
		bUS_SceneWindEffectActorComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneWindEffectActorComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneWindEffectActorComp bUS_SceneWindEffectActorComp = GCHelper.Find<BUS_SceneWindEffectActorComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bUS_SceneWindEffectActorComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SceneWindEffectActorComp");
		WindEffectStrength_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindEffectStrength");
		WindEffectStrength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindEffectStrength", Classes.FFloatProperty);
		WindEffectCompTag_Offset = NativeReflection.GetPropertyOffset(intPtr, "WindEffectCompTag");
		WindEffectCompTag_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WindEffectCompTag", Classes.FNameProperty);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneWindEffectActorComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneWindEffectActorComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static BUS_SceneWindEffectActorComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SceneWindEffectActorComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SceneWindEffectActorComp));
	}
}
