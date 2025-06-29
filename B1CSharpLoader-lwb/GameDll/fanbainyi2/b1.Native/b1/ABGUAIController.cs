using System;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)817889956uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGUAIController", "b1", UnrealModuleType.Game)]
public class ABGUAIController : AIController
{
	private static bool AIPerceptionComp_IsValid;

	private static int AIPerceptionComp_Offset;

	[UProperty(Flags = (PropFlags)6755469234799117uL)]
	[UMetaPath("/Script/b1.BGUAIController:AIPerceptionComp")]
	public UAIPerceptionComponent AIPerceptionComp
	{
		get
		{
			CheckDestroyed();
			if (!AIPerceptionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUAIController:AIPerceptionComp");
				return null;
			}
			return UObjectMarshaler<UAIPerceptionComponent>.FromNative(IntPtr.Add(base.Address, AIPerceptionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIPerceptionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGUAIController:AIPerceptionComp");
			}
			else
			{
				UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(base.Address, AIPerceptionComp_Offset), value);
			}
		}
	}

	static ABGUAIController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGUAIController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGUAIController));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BGUAIController");
		AIPerceptionComp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AIPerceptionComp");
		AIPerceptionComp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AIPerceptionComp", Classes.FObjectProperty);
	}
}
