using System;
using UnrealEngine.AIModule;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BUC_AIComponent", "b1", UnrealModuleType.Game)]
public class UBUC_AIComponent : UObject
{
	private static bool AIController_IsValid;

	private static int AIController_Offset;

	private static bool PerceptionComp_IsValid;

	private static int PerceptionComp_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/b1.BUC_AIComponent:AIController")]
	public ABGUAIController AIController
	{
		get
		{
			CheckDestroyed();
			if (!AIController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_AIComponent:AIController");
				return null;
			}
			return UObjectMarshaler<ABGUAIController>.FromNative(IntPtr.Add(base.Address, AIController_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AIController_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_AIComponent:AIController");
			}
			else
			{
				UObjectMarshaler<ABGUAIController>.ToNative(IntPtr.Add(base.Address, AIController_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234799116uL)]
	[UMetaPath("/Script/b1.BUC_AIComponent:PerceptionComp")]
	public UAIPerceptionComponent PerceptionComp
	{
		get
		{
			CheckDestroyed();
			if (!PerceptionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_AIComponent:PerceptionComp");
				return null;
			}
			return UObjectMarshaler<UAIPerceptionComponent>.FromNative(IntPtr.Add(base.Address, PerceptionComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PerceptionComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BUC_AIComponent:PerceptionComp");
			}
			else
			{
				UObjectMarshaler<UAIPerceptionComponent>.ToNative(IntPtr.Add(base.Address, PerceptionComp_Offset), value);
			}
		}
	}

	static UBUC_AIComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBUC_AIComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBUC_AIComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.BUC_AIComponent");
		AIController_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AIController");
		AIController_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AIController", Classes.FObjectProperty);
		PerceptionComp_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PerceptionComp");
		PerceptionComp_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PerceptionComp", Classes.FObjectProperty);
	}
}
