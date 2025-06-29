using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_StealthTriggerConfigComp")]
internal class BUS_StealthTriggerConfigComp : UActorEditCompBase
{
	private static bool bAutoStealthMode_IsValid;

	private static int bAutoStealthMode_Offset;

	private static FFieldAddress bAutoStealthMode_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("StealthTrigger Config")]
	[Tooltip("是否自动切换潜行模式")]
	[USharpPath("/Script/b1-Managed.BUS_StealthTriggerConfigComp:bAutoStealthMode")]
	public bool bAutoStealthMode
	{
		get
		{
			CheckDestroyed();
			if (!bAutoStealthMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_StealthTriggerConfigComp:bAutoStealthMode");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAutoStealthMode_Offset), 0, bAutoStealthMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAutoStealthMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_StealthTriggerConfigComp:bAutoStealthMode");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAutoStealthMode_Offset), 0, bAutoStealthMode_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		bAutoStealthMode = true;
	}

	public override void OnDataConvert(AActor Owner)
	{
		RequireWritableData<b1.BUC_StealthTriggerConfigData>().bAutoStealthMode = bAutoStealthMode;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_StealthTriggerConfigComp");
		NativeReflection.GetPropertyRef(ref bAutoStealthMode_PropertyAddress, unrealStruct, "bAutoStealthMode");
		bAutoStealthMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "bAutoStealthMode");
		bAutoStealthMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "bAutoStealthMode", Classes.FBoolProperty);
	}

	static BUS_StealthTriggerConfigComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BUS_StealthTriggerConfigComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BUS_StealthTriggerConfigComp));
	}
}
