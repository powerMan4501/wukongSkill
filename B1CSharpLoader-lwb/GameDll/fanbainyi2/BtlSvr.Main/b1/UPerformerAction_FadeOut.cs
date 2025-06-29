using System;
using b1.Plugins.Calliope;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[DisplayName("隐藏演员")]
[USharpPath("/Script/b1-Managed.PerformerAction_FadeOut")]
public class UPerformerAction_FadeOut : UPerformerActionBase
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

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeOut:Performer")]
	public FGsSmartParam Performer
	{
		get
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:Performer");
				return default(FGsSmartParam);
			}
			return FGsSmartParam.FromNative(IntPtr.Add(base.Address, Performer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Performer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:Performer");
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
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeOut:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:Time");
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
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeOut:MatParamName")]
	public FName MatParamName
	{
		get
		{
			CheckDestroyed();
			if (!MatParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:MatParamName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, MatParamName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MatParamName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:MatParamName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, MatParamName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeOut:OpacityCurve")]
	public UCurveFloat OpacityCurve
	{
		get
		{
			CheckDestroyed();
			if (!OpacityCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:OpacityCurve");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, OpacityCurve_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OpacityCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:OpacityCurve");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, OpacityCurve_Offset), value);
			}
		}
	}

	[UProperty(PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.PerformerAction_FadeOut:PerformerActor")]
	public BGUPerformerActorCS PerformerActor
	{
		get
		{
			CheckDestroyed();
			if (!PerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:PerformerActor");
				return null;
			}
			return UObjectMarshaler<BGUPerformerActorCS>.FromNative(IntPtr.Add(base.Address, PerformerActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerformerActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PerformerAction_FadeOut:PerformerActor");
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
				PerformerActor.SetActorHiddenInGame(bNewHidden: true);
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
			PerformerActor.SetActorHiddenInGame(bNewHidden: true);
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
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PerformerAction_FadeOut");
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

	static UPerformerAction_FadeOut()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UPerformerAction_FadeOut)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UPerformerAction_FadeOut));
	}
}
