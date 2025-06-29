using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUAudioTriggerActor")]
internal class BGUAudioTriggerActor : BGUActorBaseCS
{
	private static bool AudioTriggerComp_IsValid;

	private static int AudioTriggerComp_Offset;

	private static bool AudioTriggerConfigComp_IsValid;

	private static int AudioTriggerConfigComp_Offset;

	[UProperty(Flags = PropFlags.Transient)]
	[USharpPath("/Script/b1-Managed.BGUAudioTriggerActor:AudioTriggerComp")]
	public b1.BUS_AudioTriggerComp AudioTriggerComp
	{
		get
		{
			CheckDestroyed();
			if (!AudioTriggerComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioTriggerActor:AudioTriggerComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_AudioTriggerComp>.FromNative(IntPtr.Add(base.Address, AudioTriggerComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioTriggerComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioTriggerActor:AudioTriggerComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_AudioTriggerComp>.ToNative(IntPtr.Add(base.Address, AudioTriggerComp_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUAudioTriggerActor:AudioTriggerConfigComp")]
	public b1.BUS_AudioTriggerConfigComp AudioTriggerConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!AudioTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioTriggerActor:AudioTriggerConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_AudioTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, AudioTriggerConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AudioTriggerConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUAudioTriggerActor:AudioTriggerConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_AudioTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, AudioTriggerConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		AudioTriggerComp = initializer.CreateDefaultSubobject<b1.BUS_AudioTriggerComp>(this, B1GlobalFNames.AudioTriggerComp);
		AudioTriggerConfigComp = initializer.CreateDefaultSubobject<b1.BUS_AudioTriggerConfigComp>(this, B1GlobalFNames.AudioTriggerConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new b1.BUS_AudioTriggerCompImpl());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_AudioTriggerDataComp>(this, B1GlobalFNames.AudioTriggerDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUAudioTriggerActor");
		AudioTriggerComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AudioTriggerComp");
		AudioTriggerComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AudioTriggerComp", Classes.FObjectProperty);
		AudioTriggerConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AudioTriggerConfigComp");
		AudioTriggerConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AudioTriggerConfigComp", Classes.FObjectProperty);
	}

	static BGUAudioTriggerActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUAudioTriggerActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUAudioTriggerActor));
	}
}
