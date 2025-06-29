using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)819986596uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BUS_EventCollection", "b1", UnrealModuleType.Game)]
public class UBUS_EventCollection : UActorComponent
{
	private static bool FBUE_BounceCheck_IsValid;

	private static int FBUE_BounceCheck_Offset;

	private FBUE_BounceCheck FBUE_BounceCheck_DelegateCached;

	private static bool FBUE_BP_UnitDie_IsValid;

	private static int FBUE_BP_UnitDie_Offset;

	private FBUE_BP_UnitDie FBUE_BP_UnitDie_DelegateCached;

	private static bool FBUE_BP_ClearCameraLock_IsValid;

	private static int FBUE_BP_ClearCameraLock_Offset;

	private FBUE_BP_ClearCameraLock FBUE_BP_ClearCameraLock_DelegateCached;

	private static bool FBUE_BP_AI_FSMEventTrigger_IsValid;

	private static int FBUE_BP_AI_FSMEventTrigger_Offset;

	private FBUE_BP_AI_FSMEventTrigger FBUE_BP_AI_FSMEventTrigger_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BUS_EventCollection:FBUE_BounceCheck")]
	public FBUE_BounceCheck FBUE_BounceCheck
	{
		get
		{
			CheckDestroyed();
			if (!FBUE_BounceCheck_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUS_EventCollection:FBUE_BounceCheck");
				return new FBUE_BounceCheck();
			}
			if (FBUE_BounceCheck_DelegateCached == null)
			{
				FBUE_BounceCheck_DelegateCached = new FBUE_BounceCheck();
				FBUE_BounceCheck_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBUE_BounceCheck_Offset));
			}
			return FBUE_BounceCheck_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BUS_EventCollection:FBUE_BP_UnitDie")]
	public FBUE_BP_UnitDie FBUE_BP_UnitDie
	{
		get
		{
			CheckDestroyed();
			if (!FBUE_BP_UnitDie_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUS_EventCollection:FBUE_BP_UnitDie");
				return new FBUE_BP_UnitDie();
			}
			if (FBUE_BP_UnitDie_DelegateCached == null)
			{
				FBUE_BP_UnitDie_DelegateCached = new FBUE_BP_UnitDie();
				FBUE_BP_UnitDie_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBUE_BP_UnitDie_Offset));
			}
			return FBUE_BP_UnitDie_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BUS_EventCollection:FBUE_BP_ClearCameraLock")]
	public FBUE_BP_ClearCameraLock FBUE_BP_ClearCameraLock
	{
		get
		{
			CheckDestroyed();
			if (!FBUE_BP_ClearCameraLock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUS_EventCollection:FBUE_BP_ClearCameraLock");
				return new FBUE_BP_ClearCameraLock();
			}
			if (FBUE_BP_ClearCameraLock_DelegateCached == null)
			{
				FBUE_BP_ClearCameraLock_DelegateCached = new FBUE_BP_ClearCameraLock();
				FBUE_BP_ClearCameraLock_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBUE_BP_ClearCameraLock_Offset));
			}
			return FBUE_BP_ClearCameraLock_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/b1.BUS_EventCollection:FBUE_BP_AI_FSMEventTrigger")]
	public FBUE_BP_AI_FSMEventTrigger FBUE_BP_AI_FSMEventTrigger
	{
		get
		{
			CheckDestroyed();
			if (!FBUE_BP_AI_FSMEventTrigger_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUS_EventCollection:FBUE_BP_AI_FSMEventTrigger");
				return new FBUE_BP_AI_FSMEventTrigger();
			}
			if (FBUE_BP_AI_FSMEventTrigger_DelegateCached == null)
			{
				FBUE_BP_AI_FSMEventTrigger_DelegateCached = new FBUE_BP_AI_FSMEventTrigger();
				FBUE_BP_AI_FSMEventTrigger_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBUE_BP_AI_FSMEventTrigger_Offset));
			}
			return FBUE_BP_AI_FSMEventTrigger_DelegateCached;
		}
	}

	static UBUS_EventCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBUS_EventCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBUS_EventCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BUS_EventCollection");
		FBUE_BounceCheck_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBUE_BounceCheck");
		FBUE_BounceCheck_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBUE_BounceCheck", Classes.FMulticastDelegateProperty);
		FBUE_BP_UnitDie_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBUE_BP_UnitDie");
		FBUE_BP_UnitDie_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBUE_BP_UnitDie", Classes.FMulticastDelegateProperty);
		FBUE_BP_ClearCameraLock_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBUE_BP_ClearCameraLock");
		FBUE_BP_ClearCameraLock_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBUE_BP_ClearCameraLock", Classes.FMulticastDelegateProperty);
		FBUE_BP_AI_FSMEventTrigger_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBUE_BP_AI_FSMEventTrigger");
		FBUE_BP_AI_FSMEventTrigger_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBUE_BP_AI_FSMEventTrigger", Classes.FMulticastDelegateProperty);
	}
}
