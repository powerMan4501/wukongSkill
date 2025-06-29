using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTortoiseMoveMgrActor")]
internal class BGUTortoiseMoveMgrActor : BGUActorBaseCS
{
	private static bool TortoiseMoveMgrActorConfigComp_IsValid;

	private static int TortoiseMoveMgrActorConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTortoiseMoveMgrActor:TortoiseMoveMgrActorConfigComp")]
	public b1.BUS_TortoiseMoveMgrActorConfigComp TortoiseMoveMgrActorConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!TortoiseMoveMgrActorConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTortoiseMoveMgrActor:TortoiseMoveMgrActorConfigComp");
				return null;
			}
			return UObjectMarshaler<b1.BUS_TortoiseMoveMgrActorConfigComp>.FromNative(IntPtr.Add(base.Address, TortoiseMoveMgrActorConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TortoiseMoveMgrActorConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTortoiseMoveMgrActor:TortoiseMoveMgrActorConfigComp");
			}
			else
			{
				UObjectMarshaler<b1.BUS_TortoiseMoveMgrActorConfigComp>.ToNative(IntPtr.Add(base.Address, TortoiseMoveMgrActorConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		TortoiseMoveMgrActorConfigComp = initializer.CreateDefaultSubobject<b1.BUS_TortoiseMoveMgrActorConfigComp>(this, B1GlobalFNames.TortoiseMoveConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<b1.BUS_TortoiseMoveMgrComp>();
		base.ActorCompContainerCS.AddComp(new BUS_QuestTortoiseCtrlComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_TortoiseMoveMgrActorDataComp>(this, B1GlobalFNames.LevelMoveMgrActorDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUTortoiseMoveMgrActor");
		TortoiseMoveMgrActorConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TortoiseMoveMgrActorConfigComp");
		TortoiseMoveMgrActorConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TortoiseMoveMgrActorConfigComp", Classes.FObjectProperty);
	}

	static BGUTortoiseMoveMgrActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUTortoiseMoveMgrActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUTortoiseMoveMgrActor));
	}
}
