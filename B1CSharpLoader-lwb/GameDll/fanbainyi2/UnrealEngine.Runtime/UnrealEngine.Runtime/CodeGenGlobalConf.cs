using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public class CodeGenGlobalConf
{
	public static HashSet<string> DisableClasses = new HashSet<string>
	{
		"/Script/Engine.CollisionResponseContainer", "/Script/MagicLeap.MeshTrackerComponent", "/Script/GCFSM.GCFSMState", "/Script/GCFSM.GCFSMSnapshot", "/Script/V8.JavascriptLibrary", "/Script/AnimationSharing.AnimationSharingStateProcessor", "/Script/JavascriptEditor.JavascriptPropertyCustomizationLibrary", "/Script/JavascriptUMG.JavascriptUserObjectListEntry", "/Script/JavascriptGraphEditor.JavascriptGraphEdNode", "/Script/UnrealExtent.AudioVisualizeUtil",
		"/Script/RigVMDeveloper.RigVMEnumNode", "/Script/RigVMDeveloper.RigVMPin", "/Script/Engine.SoundEffectPresetWidgetInterface"
	};

	public static HashSet<string> IgnoreAttributeClasses = new HashSet<string> { "/Script/Engine.Engine" };

	public static HashSet<string> DisableInterfaceInherite = new HashSet<string> { "SoundParameterControllerInterface", "SoundEffectPresetWidgetInterface", "UserObjectListEntry" };

	public static HashSet<string> ForceExportClasses = new HashSet<string>
	{
		"/Script/Landscape.LandscapeInfo", "/Script/UnrealEd.ActorFactory", "/Script/Engine.EdGraphSchema", "/Script/UnrealEd.EditorEngine", "/Script/Engine.AnimLinkableElement", "/Script/Engine.ObjectLibrary", "/Script/Engine.AIModule.EnvQueryTest", "/Script/Engine.BoneReference", "/Script/NavigationSystem.NavigationSystemV1", "/Script/NavigationSystem.CrowdManagerBase",
		"/Script/AssetRegistry.AssetRegistryHelpers", "/Script/Engine.UMaterialInstance", "/Script/Engine.UMaterialInstanceConstant", "/Script/UnrealEd.Transactor", "/Script/Engine.Model", "/Script/Engine.Selection", "/Script/Engine.BrushBuilder", "/Script/UMG.AsyncTaskDownloadImage", "/Script/Engine.AISystemBase", "/Script/UnrealEd.Selection",
		"/Script/StaticMeshEditor.StaticMeshEditorSubsystem", "/Script/LevelEditor.LevelEditorSubsystem", "/Script/SkeletalMeshEditor.SkeletalMeshEditorSubsystem", "/Script/LevelSequenceEditor.LevelSequenceEditorSubsystem", "/Script/Blutility.EditorUtilitySubsystem", "/Script/UnrealEd.ImportSubsystem", "/Script/UnrealEd.EditorActorSubsystem", "/Script/UnrealEd.AssetEditorSubsystem", "/Script/AssetTools.AssetToolsHelpers", "/Script/Engine.DPICustomScalingRule",
		"/Script/Engine.GameUserSettings", "/Script/Engine.NetConnection", "/Script/Engine.DeviceProfile", "/Script/Engine.ActorChannel", "/Script/Engine.OnlineSession", "/Script/OnlineSubsystemUtils.BlueprintSessionResult", "/Script/Sentry.SentrySubsystem"
	};

	public static HashSet<string> ForceExportFieldClasses = new HashSet<string> { "/Script/Engine.HitResult", "/Script/GameplayTags.GameplayTag", "/Script/Engine.AnimNotifyEvent", "/Script/Engine.AnimLinkableElement", "/Script/Engine.BoneReference", "/Script/Engine.PhysicsAsset" };

	public static HashSet<string> EnableGamePlugin = new HashSet<string>
	{
		"JavascriptConsole", "JavascriptEditor", "JavascriptGraphEditor", "JavascriptUMG", "V8", "UIParticle", "UIParticleSystem", "Niagara", "AkAudio", "WwiseSoundEngine",
		"GSEngineExtent", "GSNiagara", "HoudiniEngineRuntime", "HoudiniEngine", "GSEHoudini", "GSEArteries", "Arteries", "slua_unreal", "GCFSM", "MM",
		"CustomLightSystem", "TressFX", "CustomHairStrand", "UIPF", "VaFogOfWar", "DonAINavigation", "Calliope", "CalliopeWin64", "StriderX2", "KawaiiPhysicsX2",
		"NiagaraUIRenderer", "GSAnimationKeyBlender", "AsyncLoadingScreen", "GSAssetImportPostProcessor", "GSEditorCommandsTool", "GSInput", "Sentry", "GSReplaySystem", "GSGameSettings", "GSDynamicSDF",
		"GSSlateUtils", "ConsoleVariableManager", "SimpleCharts", "BinkMedia", "UMGSpline", "GSDisplayDebug", "GSEditorUMG"
	};

	public static HashSet<string> DisableEngineModules = new HashSet<string> { "AddContentDialog", "AITestSuite", "AugmentedReality", "HeadMountedDisplay", "VREditor" };

	public static HashSet<string> DisableEnginePlugins = new HashSet<string>
	{
		"MagicLeap", "MagicLeapAR", "MagicLeapARPin", "MagicLeapAudio", "MagicLeapSharedWorld", "MagicLeapSharedWorldLocalData", "MagicLeapSharedWorldPinData", "MagicLeapController", "MagicLeapEyeTracker", "MagicLeapHandMeshing",
		"MagicLeapHandTracking", "MagicLeapIdentity", "MagicLeapImageTracker", "MagicLeapPlanes", "MagicLeapPrivileges", "MagicLeapSecureStorage", "PythonScriptPlugin"
	};
}
