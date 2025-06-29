using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCricketMgrActor")]
public class BGUCricketMgrActor : BGUActorBaseCS
{
	private static bool CricketMgrConfigComp_IsValid;

	private static int CricketMgrConfigComp_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUCricketMgrActor:CricketMgrConfigComp")]
	public BUS_CricketMgrConfigComp CricketMgrConfigComp
	{
		get
		{
			CheckDestroyed();
			if (!CricketMgrConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCricketMgrActor:CricketMgrConfigComp");
				return null;
			}
			return UObjectMarshaler<BUS_CricketMgrConfigComp>.FromNative(IntPtr.Add(base.Address, CricketMgrConfigComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CricketMgrConfigComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUCricketMgrActor:CricketMgrConfigComp");
			}
			else
			{
				UObjectMarshaler<BUS_CricketMgrConfigComp>.ToNative(IntPtr.Add(base.Address, CricketMgrConfigComp_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		CricketMgrConfigComp = initializer.CreateDefaultSubobject<BUS_CricketMgrConfigComp>(this, B1GlobalFNames.CricketMgrConfigComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_CricketMgrComp(), 128);
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_CricketMgrDataComp>(this, B1GlobalFNames.CricketMgrDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUCricketMgrActor");
		CricketMgrConfigComp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CricketMgrConfigComp");
		CricketMgrConfigComp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CricketMgrConfigComp", Classes.FObjectProperty);
	}

	static BGUCricketMgrActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCricketMgrActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCricketMgrActor));
	}
}
