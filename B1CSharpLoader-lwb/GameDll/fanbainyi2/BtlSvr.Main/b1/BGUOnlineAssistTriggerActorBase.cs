using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUOnlineAssistTriggerActorBase")]
public class BGUOnlineAssistTriggerActorBase : BGUActorBaseCS
{
	private static bool OnlineAssistTriggerConfig_IsValid;

	private static int OnlineAssistTriggerConfig_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUOnlineAssistTriggerActorBase:OnlineAssistTriggerConfig")]
	public BUS_OnlineAssistTriggerConfigComp OnlineAssistTriggerConfig
	{
		get
		{
			CheckDestroyed();
			if (!OnlineAssistTriggerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUOnlineAssistTriggerActorBase:OnlineAssistTriggerConfig");
				return null;
			}
			return UObjectMarshaler<BUS_OnlineAssistTriggerConfigComp>.FromNative(IntPtr.Add(base.Address, OnlineAssistTriggerConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnlineAssistTriggerConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUOnlineAssistTriggerActorBase:OnlineAssistTriggerConfig");
			}
			else
			{
				UObjectMarshaler<BUS_OnlineAssistTriggerConfigComp>.ToNative(IntPtr.Add(base.Address, OnlineAssistTriggerConfig_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		OnlineAssistTriggerConfig = initializer.CreateDefaultSubobject<BUS_OnlineAssistTriggerConfigComp>(this, new FName("OnlineAssistTriggerConfig"));
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_OnlineAssistTriggerComp());
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_OnlineAssistTriggerDataComp>(this, new FName("OnlineAssistTriggerDataComp"));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUOnlineAssistTriggerActorBase");
		OnlineAssistTriggerConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnlineAssistTriggerConfig");
		OnlineAssistTriggerConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnlineAssistTriggerConfig", Classes.FObjectProperty);
	}

	static BGUOnlineAssistTriggerActorBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUOnlineAssistTriggerActorBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUOnlineAssistTriggerActorBase));
	}
}
