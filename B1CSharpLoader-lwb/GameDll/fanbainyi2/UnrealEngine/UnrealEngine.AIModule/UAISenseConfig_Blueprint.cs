using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[Abstract]
[UClass(Flags = (ClassFlags)877662373uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AIModule.AISenseConfig_Blueprint", "AIModule", UnrealModuleType.Engine)]
public class UAISenseConfig_Blueprint : UAISenseConfig
{
	private static bool Implementation_IsValid;

	private static int Implementation_Offset;

	[UProperty(Flags = (PropFlags)7881369174753813uL)]
	[UMetaPath("/Script/AIModule.AISenseConfig_Blueprint:Implementation")]
	protected TSubclassOf<UAISense_Blueprint> Implementation
	{
		get
		{
			CheckDestroyed();
			if (!Implementation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig_Blueprint:Implementation");
				return default(TSubclassOf<UAISense_Blueprint>);
			}
			return TSubclassOfMarshaler<UAISense_Blueprint>.FromNative(IntPtr.Add(base.Address, Implementation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Implementation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AIModule.AISenseConfig_Blueprint:Implementation");
			}
			else
			{
				TSubclassOfMarshaler<UAISense_Blueprint>.ToNative(IntPtr.Add(base.Address, Implementation_Offset), value);
			}
		}
	}

	static UAISenseConfig_Blueprint()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAISenseConfig_Blueprint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAISenseConfig_Blueprint));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AIModule.AISenseConfig_Blueprint");
		Implementation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Implementation");
		Implementation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Implementation", Classes.FClassProperty);
	}
}
