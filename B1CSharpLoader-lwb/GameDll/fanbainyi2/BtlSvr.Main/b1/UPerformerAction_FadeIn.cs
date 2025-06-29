using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("显示演员")]
[USharpPath("/Script/b1-Managed.PerformerAction_FadeIn")]
public class UPerformerAction_FadeIn : UPerformerActionBase
{
	private static bool Performer_IsValid;

	private static int Performer_Offset;

	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool MatParamName_IsValid;

	private static int MatParamName_Offset;

	private static bool OpacityCurve_IsValid;

	private static int OpacityCurve_Offset;

	private static bool PerformerActor_IsValid;

	private static int PerformerActor_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeIn:Performer")]
	public FGsSmartParam Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:Performer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:Performer");
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
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeIn:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeIn:MatParamName")]
	public FName MatParamName
	{
		get
		{
			CheckDestroyed();
			if (!MatParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:MatParamName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MatParamName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:MatParamName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MatParamName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeIn:OpacityCurve")]
	public UCurveFloat OpacityCurve
	{
		get
		{
			CheckDestroyed();
			if (!OpacityCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:OpacityCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, OpacityCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OpacityCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:OpacityCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, OpacityCurve_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeIn:PerformerActor")]
	public BGUPerformerActorCS PerformerActor
	{
		get
		{
			CheckDestroyed();
			if (!PerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:PerformerActor");
				return null;
			}
			return UObjectMarshaler<BGUPerformerActorCS>.FromNative(IntPtr.Add(base.Address, PerformerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeIn:PerformerActor");
			}
			else
			{
				UObjectMarshaler<BGUPerformerActorCS>.ToNative(IntPtr.Add(base.Address, PerformerActor_Offset), value);
			}
		}
	}

	public float CurrentTime { get; set; }

	protected override bool DoAction()
	{
		if (base.ControlComp.GetParamActorGuid(Performer.ConfigGuid, out var OutActorGuid))
		{
			PerformerActor = BGU_DataUtil.GetActorByGuid(this, OutActorGuid) as BGUPerformerActorCS;
		}
		if (Time <= 1E-08f || PerformerActor == null)
		{
			if (PerformerActor != null)
			{
				PerformerActor.SetActorHiddenInGame(bNewHidden: false);
			}
			PerformerActor = null;
			return true;
		}
		CurrentTime = 0f;
		UpdatePerformerOpacity();
		return CurrentTime >= Time;
	}

	protected override bool OnTick(float InDeltaTime)
	{
		CurrentTime += InDeltaTime;
		UpdatePerformerOpacity();
		if (CurrentTime >= Time)
		{
			PerformerActor.SetActorHiddenInGame(bNewHidden: false);
			PerformerActor = null;
			return true;
		}
		return false;
	}

	private void UpdatePerformerOpacity()
	{
		foreach (UActorComponent item in PerformerActor.GetComponentsByClass(UClass.GetClass<USkeletalMeshComponent>()))
		{
			if (item is USkeletalMeshComponent uSkeletalMeshComponent)
			{
				uSkeletalMeshComponent.SetScalarParameterValueOnMaterials(MatParamName, OpacityCurve.GetFloatValue(CurrentTime));
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerAction_FadeIn");
		Performer_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Performer");
		Performer_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Performer", Classes.FStructProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time", Classes.FFloatProperty);
		MatParamName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MatParamName");
		MatParamName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MatParamName", Classes.FNameProperty);
		OpacityCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OpacityCurve");
		OpacityCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OpacityCurve", Classes.FObjectProperty);
		PerformerActor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PerformerActor");
		PerformerActor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PerformerActor", Classes.FObjectProperty);
	}

	static UPerformerAction_FadeIn()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerAction_FadeIn)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerAction_FadeIn));
	}
}
