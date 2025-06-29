using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.SlateCore;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/SlateCore.CharacterEvent", "SlateCore", UnrealModuleType.Engine)]
public class FCharacterEvent : StructAsClass
{
	private static bool FCharacterEvent_IsValid;

	private static IntPtr FCharacterEvent_StructAddress;

	protected override IntPtr GetStructAddress()
	{
		return FCharacterEvent_StructAddress;
	}

	static FCharacterEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCharacterEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCharacterEvent));
	}

	private static void LoadNativeType()
	{
		FCharacterEvent_IsValid = (FCharacterEvent_StructAddress = NativeReflection.GetStruct("/Script/SlateCore.CharacterEvent")) != IntPtr.Zero;
		NativeReflection.LogStructIsValid("/Script/SlateCore.CharacterEvent", FCharacterEvent_IsValid);
	}
}
