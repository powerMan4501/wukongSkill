using System;
using System.Text.RegularExpressions;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibSceneObj")]
public class BGUFuncLibSceneObj : UBlueprintFunctionLibrary
{
	public static bool BGUCreateTriggerObjWithState(BGUTriggerObjBase TriggerObj, ESceneObjTransitionState ActiveState, out FSceneObjWithState ObjState)
	{
		ObjState = default(FSceneObjWithState);
		BUS_ActorConfigInfoComp componentByClass = TriggerObj.GetComponentByClass<BUS_ActorConfigInfoComp>();
		BUS_GuidComp componentByClass2 = TriggerObj.GetComponentByClass<BUS_GuidComp>();
		if (componentByClass2 == null || componentByClass == null)
		{
			return false;
		}
		ObjState.UnitGuid = BGUGetFinalGuid(componentByClass.GameplayTagGuid, componentByClass2.UnitRandomGuid);
		ObjState.ActiveState = ActiveState;
		return true;
	}

	public static bool BGUCreateNeedActivateObjTriggerEvent(AActor NeedActivateObj, ESceneObjTransitionEvent UnTriggerEvent, ESceneObjTransitionEvent TriggerEvent, out FSceneObjTriggerEvent ObjEvent)
	{
		ObjEvent = default(FSceneObjTriggerEvent);
		FGameplayTag FixedGuid;
		if (NeedActivateObj as BGUCharacterCS != null)
		{
			BUS_ConfigInfoComp componentByClass = NeedActivateObj.GetComponentByClass<BUS_ConfigInfoComp>();
			if (componentByClass == null)
			{
				return false;
			}
			FixedGuid = componentByClass.UnitFixedGuid.GameplayTagGuid;
		}
		else if (NeedActivateObj as BGUActorBaseCS != null)
		{
			BUS_ActorConfigInfoComp componentByClass2 = NeedActivateObj.GetComponentByClass<BUS_ActorConfigInfoComp>();
			if (componentByClass2 == null)
			{
				return false;
			}
			FixedGuid = componentByClass2.GameplayTagGuid;
		}
		else
		{
			FixedGuid = default(FGameplayTag);
		}
		BUS_GuidComp componentByClass3 = NeedActivateObj.GetComponentByClass<BUS_GuidComp>();
		if (componentByClass3 == null)
		{
			return false;
		}
		ObjEvent.UnitGuid = BGUGetFinalGuid(in FixedGuid, componentByClass3.UnitRandomGuid);
		ObjEvent.UnTriggerEvent = UnTriggerEvent;
		ObjEvent.TriggerEvent = TriggerEvent;
		return true;
	}

	public static string BGUGetFinalGuidByComponent(AActor Actor)
	{
		if (Actor == null)
		{
			return "";
		}
		FGameplayTag FixedGuid;
		if (Actor as BGUCharacterCS != null)
		{
			BUS_ConfigInfoComp componentByClass = Actor.GetComponentByClass<BUS_ConfigInfoComp>();
			if (componentByClass == null)
			{
				return "";
			}
			FixedGuid = componentByClass.UnitFixedGuid.GameplayTagGuid;
		}
		else if (Actor as ABGUActorBase != null)
		{
			BUS_ActorConfigInfoComp componentByClass2 = Actor.GetComponentByClass<BUS_ActorConfigInfoComp>();
			if (componentByClass2 == null)
			{
				return "";
			}
			FixedGuid = componentByClass2.GameplayTagGuid;
		}
		else
		{
			FixedGuid = default(FGameplayTag);
		}
		BUS_GuidComp componentByClass3 = Actor.GetComponentByClass<BUS_GuidComp>();
		if (componentByClass3 == null)
		{
			return "";
		}
		return BGUGetFinalGuid(in FixedGuid, componentByClass3.UnitRandomGuid);
	}

	public static string BGUGetFinalGuid(in FGameplayTag FixedGuid, string RandomGuid)
	{
		if (GameplayTagExtension.IsValid(FixedGuid))
		{
			return FixedGuid.TagName.ToString();
		}
		return RandomGuid;
	}

	public static string BGUGetStandardGuidStr(string InputGuidStr)
	{
		if (Regex.IsMatch(InputGuidStr, "(TagName=\".*\")"))
		{
			return Regex.Match(InputGuidStr, "(?<=TagName=\").*(?=\")").Value;
		}
		return InputGuidStr;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibSceneObj");
	}

	static BGUFuncLibSceneObj()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibSceneObj)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibSceneObj));
	}
}
