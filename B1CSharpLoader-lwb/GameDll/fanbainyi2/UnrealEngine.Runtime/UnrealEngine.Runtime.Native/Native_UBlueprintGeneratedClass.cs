using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UBlueprintGeneratedClass
{
	[MonoNativeFunctionWrapper]
	public delegate int Del_Get_NumReplicatedProperties(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_NumReplicatedProperties(IntPtr instance, int value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_DynamicBindingObjects(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_ComponentTemplates(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_Timelines(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_SimpleConstructionScript(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_SimpleConstructionScript(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_InheritableComponentHandler(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_InheritableComponentHandler(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_UberGraphFramePointerProperty(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_UberGraphFramePointerProperty(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_UberGraphFunction(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_UberGraphFunction(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_OverridenArchetypeForCDO(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_OverridenArchetypeForCDO(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_PropertyGuids(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_CookedComponentInstancingData(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_GetGeneratedClassesHierarchy(IntPtr inClass, IntPtr outBPGClasses);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetInheritableComponentHandler(IntPtr instance, csbool createIfNecessary);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindComponentTemplateByName(IntPtr instance, ref FName templatedName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CreateComponentsForActor(IntPtr thisClass, IntPtr actor);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CreateTimelineComponent(IntPtr actor, IntPtr timelineTemplate);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UpdateCustomPropertyListForPostConstruction(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddReferencedObjectsInUbergraphFrame(IntPtr inThis, IntPtr collector);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetUberGraphFrameName(out FName result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_UsePersistentUberGraphFrame();

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_Get_DebugData(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Set_DebugData(IntPtr instance, IntPtr value);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetDebugData(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BindDynamicDelegates(IntPtr thisClass, IntPtr inInstance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDynamicBindingObject(IntPtr thisClass, IntPtr bindingClass);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UnbindDynamicDelegates(IntPtr thisClass, IntPtr inInstance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UnbindDynamicDelegatesForProperty(IntPtr instance, IntPtr inInstance, IntPtr inObjectProperty);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetLifetimeBlueprintReplicationList(IntPtr instance, IntPtr outLifetimeProps);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InstancePreReplication(IntPtr instance, IntPtr obj, IntPtr changedPropertyTracker);

	public static Del_Get_NumReplicatedProperties Get_NumReplicatedProperties;

	public static Del_Set_NumReplicatedProperties Set_NumReplicatedProperties;

	public static Del_Get_DynamicBindingObjects Get_DynamicBindingObjects;

	public static Del_Get_ComponentTemplates Get_ComponentTemplates;

	public static Del_Get_Timelines Get_Timelines;

	public static Del_Get_SimpleConstructionScript Get_SimpleConstructionScript;

	public static Del_Set_SimpleConstructionScript Set_SimpleConstructionScript;

	public static Del_Get_InheritableComponentHandler Get_InheritableComponentHandler;

	public static Del_Set_InheritableComponentHandler Set_InheritableComponentHandler;

	public static Del_Get_UberGraphFramePointerProperty Get_UberGraphFramePointerProperty;

	public static Del_Set_UberGraphFramePointerProperty Set_UberGraphFramePointerProperty;

	public static Del_Get_UberGraphFunction Get_UberGraphFunction;

	public static Del_Set_UberGraphFunction Set_UberGraphFunction;

	public static Del_Get_OverridenArchetypeForCDO Get_OverridenArchetypeForCDO;

	public static Del_Set_OverridenArchetypeForCDO Set_OverridenArchetypeForCDO;

	public static Del_Get_PropertyGuids Get_PropertyGuids;

	public static Del_Get_CookedComponentInstancingData Get_CookedComponentInstancingData;

	public static Del_GetGeneratedClassesHierarchy GetGeneratedClassesHierarchy;

	public static Del_GetInheritableComponentHandler GetInheritableComponentHandler;

	public static Del_FindComponentTemplateByName FindComponentTemplateByName;

	public static Del_CreateComponentsForActor CreateComponentsForActor;

	public static Del_CreateTimelineComponent CreateTimelineComponent;

	public static Del_UpdateCustomPropertyListForPostConstruction UpdateCustomPropertyListForPostConstruction;

	public static Del_AddReferencedObjectsInUbergraphFrame AddReferencedObjectsInUbergraphFrame;

	public static Del_GetUberGraphFrameName GetUberGraphFrameName;

	public static Del_UsePersistentUberGraphFrame UsePersistentUberGraphFrame;

	public static Del_Get_DebugData Get_DebugData;

	public static Del_Set_DebugData Set_DebugData;

	public static Del_GetDebugData GetDebugData;

	public static Del_BindDynamicDelegates BindDynamicDelegates;

	public static Del_GetDynamicBindingObject GetDynamicBindingObject;

	public static Del_UnbindDynamicDelegates UnbindDynamicDelegates;

	public static Del_UnbindDynamicDelegatesForProperty UnbindDynamicDelegatesForProperty;

	public static Del_GetLifetimeBlueprintReplicationList GetLifetimeBlueprintReplicationList;

	public static Del_InstancePreReplication InstancePreReplication;
}
