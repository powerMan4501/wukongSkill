using System;
using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_UObject
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_PostInitProperties(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_PreSaveRoot(IntPtr instance, ref FScriptArray filename);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostSaveRoot(IntPtr instance, csbool cleanupIsRequired);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PreSave(IntPtr instance, IntPtr targetPlatform);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Modify(IntPtr instance, csbool alwaysMarkDirty);

	[MonoNativeFunctionWrapper]
	public delegate void Del_LoadedFromAnotherClass(IntPtr instance, ref FName oldClassName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostLoad(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostLoadSubobjects(IntPtr instance, IntPtr outerInstanceGraph);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BeginDestroy(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsReadyForFinishDestroy(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostLinkerChange(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_FinishDestroy(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_Serialize(IntPtr instance, IntPtr ar);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ShutdownAfterError(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostInterpChange(IntPtr instance, IntPtr propertyThatChanged);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PreEditChange(IntPtr instance, IntPtr propertyAboutToChange);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PreEditChangeChain(IntPtr instance, IntPtr propertyAboutToChange);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CanEditChange(IntPtr instance, IntPtr inProperty);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostEditChange(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostEditChangeProperty(IntPtr instance, IntPtr propertyChangedEvent);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostEditChangeChainProperty(IntPtr instance, IntPtr propertyChangedEvent);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PreEditUndo(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostEditUndo(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostRename(IntPtr instance, IntPtr oldOuter, ref FName oldName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostDuplicate(IntPtr instance, csbool duplicateForPIE);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_NeedsLoadForClient(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_NeedsLoadForServer(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_NeedsLoadForEditorGame(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CanCreateInCurrentContext(IntPtr template);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ExportCustomProperties(IntPtr instance, IntPtr outputDevice, uint indent);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ImportCustomProperties(IntPtr instance, ref FScriptArray sourceText, IntPtr warn);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostEditImport(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostReloadConfig(IntPtr instance, IntPtr propertyThatWasLoaded);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_Rename(IntPtr instance, ref FScriptArray newName, IntPtr newOuter, ERenameFlags flags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDesc(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorld(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetWorldChecked(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ImplementsGetWorld(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_GetNativePropertyValues(IntPtr instance, IntPtr out_PropertyValues, uint exportFlags);

	[MonoNativeFunctionWrapper]
	public delegate long Del_GetResourceSizeBytes(IntPtr instance, int mode);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetExporterName(IntPtr instance, out FName result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsLocalizedResource(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_AddReferencedObjects(IntPtr inThis, IntPtr collector);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallAddReferencedObjects(IntPtr instance, IntPtr collector);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetRestoreForUObjectOverwrite(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_AreNativePropertiesIdenticalTo(IntPtr instance, IntPtr other);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetAssetRegistryTagsFromSearchableProperties(IntPtr obj, IntPtr outTags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetAssetRegistryTags(IntPtr instance, IntPtr outTags);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsAsset(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsSafeForRootSet(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_TagSubobjects(IntPtr instance, EObjectFlags newFlags);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetLifetimeReplicatedProps(IntPtr instance, IntPtr outLifetimeProps);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsNameStableForNetworking(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsFullNameStableForNetworking(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsSupportedForNetworking(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_GetSubobjectsWithStableNamesForNetworking(IntPtr instance, IntPtr objList);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PreNetReceive(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PostNetReceive(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_IsSelected(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PropagatePreEditChange(IntPtr instance, IntPtr affectedObjects, IntPtr propertyAboutToChange);

	[MonoNativeFunctionWrapper]
	public delegate void Del_PropagatePostEditChange(IntPtr instance, IntPtr affectedObjects, IntPtr propertyChangedEvent);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SerializeScriptProperties(IntPtr instance, IntPtr ar);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ReinitializeProperties(IntPtr instance, IntPtr sourceObject, IntPtr instanceGraph);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDetailedInfo(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ConditionalBeginDestroy(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ConditionalFinishDestroy(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ConditionalPostLoad(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ConditionalPostLoadSubobjects(IntPtr instance, IntPtr outerInstanceGraph);

	[MonoNativeFunctionWrapper]
	public delegate void Del_BeginCacheForCookedPlatformData(IntPtr instance, IntPtr targetPlatform);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearCachedCookedPlatformData(IntPtr instance, IntPtr targetPlatform);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ClearAllCachedCookedPlatformData(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsCachedCookedPlatformDataLoaded(IntPtr instance, IntPtr targetPlatform);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsBasedOnArchetype(IntPtr instance, IntPtr someObject);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindFunction(IntPtr instance, ref FName inName);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_FindFunctionChecked(IntPtr instance, ref FName inName);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CollectDefaultSubobjects(IntPtr instance, IntPtr outDefaultSubobjects, csbool includeNestedSubobjects);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CheckDefaultSubobjects(IntPtr instance, csbool forceCheck);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SaveConfig(IntPtr instance, long flags, ref FScriptArray filename, IntPtr config);

	[MonoNativeFunctionWrapper]
	public delegate void Del_UpdateDefaultConfigFile(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetDefaultConfigFilename(IntPtr instance, ref FScriptArray result);

	[MonoNativeFunctionWrapper]
	public delegate void Del_LoadConfig(IntPtr instance, IntPtr ConfigClass, ref FScriptArray filename, int propagationFlags, IntPtr propertyToLoad);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ReloadConfig(IntPtr instance, IntPtr ConfigClass, ref FScriptArray filename, int propagationFlags, IntPtr propertyToLoad);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ParseParms(IntPtr instance, ref FScriptArray parms);

	[MonoNativeFunctionWrapper]
	public delegate void Del_OutputReferencers(IntPtr instance, IntPtr ar, IntPtr referencers);

	[MonoNativeFunctionWrapper]
	public delegate void Del_RetrieveReferencers(IntPtr instance, IntPtr outInternalReferencers, IntPtr outExternalReferencers);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SetLinker(IntPtr instance, IntPtr linkerLoad, int linkerIndex, csbool shouldDetachExisting);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetArchetypeFromRequiredInfo(IntPtr uClass, IntPtr outer, ref FName name, EObjectFlags objectFlags);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_GetArchetype(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_GetArchetypeInstances(IntPtr instance, IntPtr instances);

	[MonoNativeFunctionWrapper]
	public delegate void Del_InstanceSubobjectTemplates(IntPtr instance, IntPtr instanceGraph);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProcessEvent(IntPtr instance, IntPtr function, IntPtr parms);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetFunctionCallspace(IntPtr instance, IntPtr function, IntPtr stack);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CallRemoteFunction(IntPtr instance, IntPtr function, IntPtr parms, IntPtr outParms, IntPtr stack);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_CallFunctionByNameWithArguments(IntPtr instance, ref FScriptArray cmd, IntPtr ar, IntPtr executor, csbool forceCallWithNonExec);

	[MonoNativeFunctionWrapper]
	public delegate void Del_CallFunction(IntPtr instance, IntPtr stack, IntPtr result, IntPtr function);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ProcessInternal(IntPtr instance, IntPtr context, IntPtr stack, IntPtr result);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_ProcessConsoleExec(IntPtr instance, ref FScriptArray cmd, IntPtr ar, IntPtr executor);

	[MonoNativeFunctionWrapper]
	public delegate void Del_SkipFunction(IntPtr instance, IntPtr stack, IntPtr result, IntPtr function);

	[MonoNativeFunctionWrapper]
	public delegate IntPtr Del_RegenerateClass(IntPtr instance, IntPtr classToRegenerate, IntPtr previousCDO);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsInBlueprint(IntPtr instance);

	[MonoNativeFunctionWrapper]
	public delegate void Del_DestroyNonNativeProperties(IntPtr instance);

	public static Del_PostInitProperties PostInitProperties;

	public static Del_PreSaveRoot PreSaveRoot;

	public static Del_PostSaveRoot PostSaveRoot;

	public static Del_PreSave PreSave;

	public static Del_Modify Modify;

	public static Del_LoadedFromAnotherClass LoadedFromAnotherClass;

	public static Del_PostLoad PostLoad;

	public static Del_PostLoadSubobjects PostLoadSubobjects;

	public static Del_BeginDestroy BeginDestroy;

	public static Del_IsReadyForFinishDestroy IsReadyForFinishDestroy;

	public static Del_PostLinkerChange PostLinkerChange;

	public static Del_FinishDestroy FinishDestroy;

	public static Del_Serialize Serialize;

	public static Del_ShutdownAfterError ShutdownAfterError;

	public static Del_PostInterpChange PostInterpChange;

	public static Del_PreEditChange PreEditChange;

	public static Del_PreEditChangeChain PreEditChangeChain;

	public static Del_CanEditChange CanEditChange;

	public static Del_PostEditChange PostEditChange;

	public static Del_PostEditChangeProperty PostEditChangeProperty;

	public static Del_PostEditChangeChainProperty PostEditChangeChainProperty;

	public static Del_PreEditUndo PreEditUndo;

	public static Del_PostEditUndo PostEditUndo;

	public static Del_PostRename PostRename;

	public static Del_PostDuplicate PostDuplicate;

	public static Del_NeedsLoadForClient NeedsLoadForClient;

	public static Del_NeedsLoadForServer NeedsLoadForServer;

	public static Del_NeedsLoadForEditorGame NeedsLoadForEditorGame;

	public static Del_CanCreateInCurrentContext CanCreateInCurrentContext;

	public static Del_ExportCustomProperties ExportCustomProperties;

	public static Del_ImportCustomProperties ImportCustomProperties;

	public static Del_PostEditImport PostEditImport;

	public static Del_PostReloadConfig PostReloadConfig;

	public static Del_Rename Rename;

	public static Del_GetDesc GetDesc;

	public static Del_GetWorld GetWorld;

	public static Del_GetWorldChecked GetWorldChecked;

	public static Del_ImplementsGetWorld ImplementsGetWorld;

	public static Del_GetNativePropertyValues GetNativePropertyValues;

	public static Del_GetResourceSizeBytes GetResourceSizeBytes;

	public static Del_GetExporterName GetExporterName;

	public static Del_IsLocalizedResource IsLocalizedResource;

	public static Del_AddReferencedObjects AddReferencedObjects;

	public static Del_CallAddReferencedObjects CallAddReferencedObjects;

	public static Del_GetRestoreForUObjectOverwrite GetRestoreForUObjectOverwrite;

	public static Del_AreNativePropertiesIdenticalTo AreNativePropertiesIdenticalTo;

	public static Del_GetAssetRegistryTagsFromSearchableProperties GetAssetRegistryTagsFromSearchableProperties;

	public static Del_GetAssetRegistryTags GetAssetRegistryTags;

	public static Del_IsAsset IsAsset;

	public static Del_IsSafeForRootSet IsSafeForRootSet;

	public static Del_TagSubobjects TagSubobjects;

	public static Del_GetLifetimeReplicatedProps GetLifetimeReplicatedProps;

	public static Del_IsNameStableForNetworking IsNameStableForNetworking;

	public static Del_IsFullNameStableForNetworking IsFullNameStableForNetworking;

	public static Del_IsSupportedForNetworking IsSupportedForNetworking;

	public static Del_GetSubobjectsWithStableNamesForNetworking GetSubobjectsWithStableNamesForNetworking;

	public static Del_PreNetReceive PreNetReceive;

	public static Del_PostNetReceive PostNetReceive;

	public static Del_IsSelected IsSelected;

	public static Del_PropagatePreEditChange PropagatePreEditChange;

	public static Del_PropagatePostEditChange PropagatePostEditChange;

	public static Del_SerializeScriptProperties SerializeScriptProperties;

	public static Del_ReinitializeProperties ReinitializeProperties;

	public static Del_GetDetailedInfo GetDetailedInfo;

	public static Del_ConditionalBeginDestroy ConditionalBeginDestroy;

	public static Del_ConditionalFinishDestroy ConditionalFinishDestroy;

	public static Del_ConditionalPostLoad ConditionalPostLoad;

	public static Del_ConditionalPostLoadSubobjects ConditionalPostLoadSubobjects;

	public static Del_BeginCacheForCookedPlatformData BeginCacheForCookedPlatformData;

	public static Del_ClearCachedCookedPlatformData ClearCachedCookedPlatformData;

	public static Del_ClearAllCachedCookedPlatformData ClearAllCachedCookedPlatformData;

	public static Del_IsCachedCookedPlatformDataLoaded IsCachedCookedPlatformDataLoaded;

	public static Del_IsBasedOnArchetype IsBasedOnArchetype;

	public static Del_FindFunction FindFunction;

	public static Del_FindFunctionChecked FindFunctionChecked;

	public static Del_CollectDefaultSubobjects CollectDefaultSubobjects;

	public static Del_CheckDefaultSubobjects CheckDefaultSubobjects;

	public static Del_SaveConfig SaveConfig;

	public static Del_UpdateDefaultConfigFile UpdateDefaultConfigFile;

	public static Del_GetDefaultConfigFilename GetDefaultConfigFilename;

	public static Del_LoadConfig LoadConfig;

	public static Del_ReloadConfig ReloadConfig;

	public static Del_ParseParms ParseParms;

	public static Del_OutputReferencers OutputReferencers;

	public static Del_RetrieveReferencers RetrieveReferencers;

	public static Del_SetLinker SetLinker;

	public static Del_GetArchetypeFromRequiredInfo GetArchetypeFromRequiredInfo;

	public static Del_GetArchetype GetArchetype;

	public static Del_GetArchetypeInstances GetArchetypeInstances;

	public static Del_InstanceSubobjectTemplates InstanceSubobjectTemplates;

	public static Del_ProcessEvent ProcessEvent;

	public static Del_GetFunctionCallspace GetFunctionCallspace;

	public static Del_CallRemoteFunction CallRemoteFunction;

	public static Del_CallFunctionByNameWithArguments CallFunctionByNameWithArguments;

	public static Del_CallFunction CallFunction;

	public static Del_ProcessInternal ProcessInternal;

	public static Del_ProcessConsoleExec ProcessConsoleExec;

	public static Del_SkipFunction SkipFunction;

	public static Del_RegenerateClass RegenerateClass;

	public static Del_IsInBlueprint IsInBlueprint;

	public static Del_DestroyNonNativeProperties DestroyNonNativeProperties;
}
