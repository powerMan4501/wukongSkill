using System;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGUAudioEmitter")]
public class BGUAudioEmitter : BGUActorBaseCS
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool Spline_IsValid;

	private static int Spline_Offset;

	private static bool AkComponent_IsValid;

	private static int AkComponent_Offset;

	private static bool AudioEmitterEditComp_IsValid;

	private static int AudioEmitterEditComp_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUAudioEmitter:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUAudioEmitter:Spline")]
	public USplineComponent Spline
	{
		get
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:Spline");
				return null;
			}
			return UObjectMarshaler<USplineComponent>.FromNative(IntPtr.Add(base.Address, Spline_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Spline_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:Spline");
			}
			else
			{
				UObjectMarshaler<USplineComponent>.ToNative(IntPtr.Add(base.Address, Spline_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUAudioEmitter:AkComponent")]
	public UAkComponent AkComponent
	{
		get
		{
			CheckDestroyed();
			if (!AkComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:AkComponent");
				return null;
			}
			return UObjectMarshaler<UAkComponent>.FromNative(IntPtr.Add(base.Address, AkComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AkComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:AkComponent");
			}
			else
			{
				UObjectMarshaler<UAkComponent>.ToNative(IntPtr.Add(base.Address, AkComponent_Offset), value);
			}
		}
	}

	[Category("Audio Emitter")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUAudioEmitter:AudioEmitterEditComp")]
	public BUS_AudioEmitterEditComp AudioEmitterEditComp
	{
		get
		{
			CheckDestroyed();
			if (!AudioEmitterEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:AudioEmitterEditComp");
				return null;
			}
			return UObjectMarshaler<BUS_AudioEmitterEditComp>.FromNative(IntPtr.Add(base.Address, AudioEmitterEditComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioEmitterEditComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioEmitter:AudioEmitterEditComp");
			}
			else
			{
				UObjectMarshaler<BUS_AudioEmitterEditComp>.ToNative(IntPtr.Add(base.Address, AudioEmitterEditComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		Root = Initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
		Spline = Initializer.CreateDefaultSubobject<USplineComponent>(this, B1GlobalFNames.SplineComp);
		AkComponent = Initializer.CreateDefaultSubobject<UAkComponent>(this, B1GlobalFNames.Ak);
		AudioEmitterEditComp = Initializer.CreateDefaultSubobject<BUS_AudioEmitterEditComp>(this, B1GlobalFNames.AudioEmitterEditComp);
		Spline.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		AkComponent.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_AudioEmitterDataComp>(this, B1GlobalFNames.AudioEmitterDataComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_AudioEmitterComp());
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUAudioEmitter");
		Root_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Root", Classes.FObjectProperty);
		Spline_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Spline");
		Spline_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Spline", Classes.FObjectProperty);
		AkComponent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AkComponent");
		AkComponent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AkComponent", Classes.FObjectProperty);
		AudioEmitterEditComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AudioEmitterEditComp");
		AudioEmitterEditComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AudioEmitterEditComp", Classes.FObjectProperty);
	}

	static BGUAudioEmitter()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUAudioEmitter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUAudioEmitter));
	}
}
