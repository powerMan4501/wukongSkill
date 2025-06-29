using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)817889440uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGW_EventCollection", "b1", UnrealModuleType.Game)]
public class UBGW_EventCollection : UObject
{
	private static bool TestWorldEvent_IsValid;

	private static int TestWorldEvent_Offset;

	private FBWE_TestWorldEvent TestWorldEvent_DelegateCached;

	private static bool FBWE_OldMKBorn_IsValid;

	private static int FBWE_OldMKBorn_Offset;

	private FBWE_OldMKBorn FBWE_OldMKBorn_DelegateCached;

	private static bool FBWE_TianBing04Dead_IsValid;

	private static int FBWE_TianBing04Dead_Offset;

	private FBWE_TianBing04Dead FBWE_TianBing04Dead_DelegateCached;

	private static bool FBWE_UnitBeAttack_IsValid;

	private static int FBWE_UnitBeAttack_Offset;

	private FBWE_UnitBeAttack FBWE_UnitBeAttack_DelegateCached;

	private static bool FBWE_TianJiangQTEEnd_IsValid;

	private static int FBWE_TianJiangQTEEnd_Offset;

	private FBWE_TianJiangQTEEnd FBWE_TianJiangQTEEnd_DelegateCached;

	private static bool FBWE_DemoTianJiangBorn_IsValid;

	private static int FBWE_DemoTianJiangBorn_Offset;

	private FBWE_DemoTianJiangBorn FBWE_DemoTianJiangBorn_DelegateCached;

	private static bool FBWE_DemoEnterCloudPlatform_IsValid;

	private static int FBWE_DemoEnterCloudPlatform_Offset;

	private FBWE_DemoEnterCloudPlatform FBWE_DemoEnterCloudPlatform_DelegateCached;

	[UProperty(Flags = (PropFlags)4521192082375168uL)]
	[UMetaPath("/Script/b1.BGW_EventCollection:TestWorldEvent")]
	public FBWE_TestWorldEvent TestWorldEvent
	{
		get
		{
			CheckDestroyed();
			if (!TestWorldEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGW_EventCollection:TestWorldEvent");
				return new FBWE_TestWorldEvent();
			}
			if (TestWorldEvent_DelegateCached == null)
			{
				TestWorldEvent_DelegateCached = new FBWE_TestWorldEvent();
				TestWorldEvent_DelegateCached.SetAddress(IntPtr.Add(base.Address, TestWorldEvent_Offset));
			}
			return TestWorldEvent_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4521192082375168uL)]
	[UMetaPath("/Script/b1.BGW_EventCollection:FBWE_OldMKBorn")]
	public FBWE_OldMKBorn FBWE_OldMKBorn
	{
		get
		{
			CheckDestroyed();
			if (!FBWE_OldMKBorn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGW_EventCollection:FBWE_OldMKBorn");
				return new FBWE_OldMKBorn();
			}
			if (FBWE_OldMKBorn_DelegateCached == null)
			{
				FBWE_OldMKBorn_DelegateCached = new FBWE_OldMKBorn();
				FBWE_OldMKBorn_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBWE_OldMKBorn_Offset));
			}
			return FBWE_OldMKBorn_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4521192082375168uL)]
	[UMetaPath("/Script/b1.BGW_EventCollection:FBWE_TianBing04Dead")]
	public FBWE_TianBing04Dead FBWE_TianBing04Dead
	{
		get
		{
			CheckDestroyed();
			if (!FBWE_TianBing04Dead_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGW_EventCollection:FBWE_TianBing04Dead");
				return new FBWE_TianBing04Dead();
			}
			if (FBWE_TianBing04Dead_DelegateCached == null)
			{
				FBWE_TianBing04Dead_DelegateCached = new FBWE_TianBing04Dead();
				FBWE_TianBing04Dead_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBWE_TianBing04Dead_Offset));
			}
			return FBWE_TianBing04Dead_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4521192082375168uL)]
	[UMetaPath("/Script/b1.BGW_EventCollection:FBWE_UnitBeAttack")]
	public FBWE_UnitBeAttack FBWE_UnitBeAttack
	{
		get
		{
			CheckDestroyed();
			if (!FBWE_UnitBeAttack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGW_EventCollection:FBWE_UnitBeAttack");
				return new FBWE_UnitBeAttack();
			}
			if (FBWE_UnitBeAttack_DelegateCached == null)
			{
				FBWE_UnitBeAttack_DelegateCached = new FBWE_UnitBeAttack();
				FBWE_UnitBeAttack_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBWE_UnitBeAttack_Offset));
			}
			return FBWE_UnitBeAttack_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4521192082375168uL)]
	[UMetaPath("/Script/b1.BGW_EventCollection:FBWE_TianJiangQTEEnd")]
	public FBWE_TianJiangQTEEnd FBWE_TianJiangQTEEnd
	{
		get
		{
			CheckDestroyed();
			if (!FBWE_TianJiangQTEEnd_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGW_EventCollection:FBWE_TianJiangQTEEnd");
				return new FBWE_TianJiangQTEEnd();
			}
			if (FBWE_TianJiangQTEEnd_DelegateCached == null)
			{
				FBWE_TianJiangQTEEnd_DelegateCached = new FBWE_TianJiangQTEEnd();
				FBWE_TianJiangQTEEnd_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBWE_TianJiangQTEEnd_Offset));
			}
			return FBWE_TianJiangQTEEnd_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4521192082375168uL)]
	[UMetaPath("/Script/b1.BGW_EventCollection:FBWE_DemoTianJiangBorn")]
	public FBWE_DemoTianJiangBorn FBWE_DemoTianJiangBorn
	{
		get
		{
			CheckDestroyed();
			if (!FBWE_DemoTianJiangBorn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGW_EventCollection:FBWE_DemoTianJiangBorn");
				return new FBWE_DemoTianJiangBorn();
			}
			if (FBWE_DemoTianJiangBorn_DelegateCached == null)
			{
				FBWE_DemoTianJiangBorn_DelegateCached = new FBWE_DemoTianJiangBorn();
				FBWE_DemoTianJiangBorn_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBWE_DemoTianJiangBorn_Offset));
			}
			return FBWE_DemoTianJiangBorn_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4521192082375168uL)]
	[UMetaPath("/Script/b1.BGW_EventCollection:FBWE_DemoEnterCloudPlatform")]
	public FBWE_DemoEnterCloudPlatform FBWE_DemoEnterCloudPlatform
	{
		get
		{
			CheckDestroyed();
			if (!FBWE_DemoEnterCloudPlatform_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGW_EventCollection:FBWE_DemoEnterCloudPlatform");
				return new FBWE_DemoEnterCloudPlatform();
			}
			if (FBWE_DemoEnterCloudPlatform_DelegateCached == null)
			{
				FBWE_DemoEnterCloudPlatform_DelegateCached = new FBWE_DemoEnterCloudPlatform();
				FBWE_DemoEnterCloudPlatform_DelegateCached.SetAddress(IntPtr.Add(base.Address, FBWE_DemoEnterCloudPlatform_Offset));
			}
			return FBWE_DemoEnterCloudPlatform_DelegateCached;
		}
	}

	static UBGW_EventCollection()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGW_EventCollection)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGW_EventCollection));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGW_EventCollection");
		TestWorldEvent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "TestWorldEvent");
		TestWorldEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "TestWorldEvent", Classes.FMulticastDelegateProperty);
		FBWE_OldMKBorn_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBWE_OldMKBorn");
		FBWE_OldMKBorn_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBWE_OldMKBorn", Classes.FMulticastDelegateProperty);
		FBWE_TianBing04Dead_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBWE_TianBing04Dead");
		FBWE_TianBing04Dead_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBWE_TianBing04Dead", Classes.FMulticastDelegateProperty);
		FBWE_UnitBeAttack_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBWE_UnitBeAttack");
		FBWE_UnitBeAttack_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBWE_UnitBeAttack", Classes.FMulticastDelegateProperty);
		FBWE_TianJiangQTEEnd_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBWE_TianJiangQTEEnd");
		FBWE_TianJiangQTEEnd_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBWE_TianJiangQTEEnd", Classes.FMulticastDelegateProperty);
		FBWE_DemoTianJiangBorn_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBWE_DemoTianJiangBorn");
		FBWE_DemoTianJiangBorn_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBWE_DemoTianJiangBorn", Classes.FMulticastDelegateProperty);
		FBWE_DemoEnterCloudPlatform_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FBWE_DemoEnterCloudPlatform");
		FBWE_DemoEnterCloudPlatform_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FBWE_DemoEnterCloudPlatform", Classes.FMulticastDelegateProperty);
	}
}
