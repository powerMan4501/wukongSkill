using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/DonAINavigation.DonNavigationManager", "DonAINavigation", UnrealModuleType.GamePlugin)]
public class ADonNavigationManager : AActor
{
	private static bool IsUnbound_IsValid;

	private static FFieldAddress IsUnbound_PropertyAddress;

	private static int IsUnbound_Offset;

	private static bool SceneComponent_IsValid;

	private static int SceneComponent_Offset;

	private static bool Billboard_IsValid;

	private static int Billboard_Offset;

	private static bool VoxelSize_IsValid;

	private static int VoxelSize_Offset;

	private static bool XGridSize_IsValid;

	private static int XGridSize_Offset;

	private static bool YGridSize_IsValid;

	private static int YGridSize_Offset;

	private static bool ZGridSize_IsValid;

	private static int ZGridSize_Offset;

	private static bool ManagerDebugParams_IsValid;

	private static int ManagerDebugParams_Offset;

	private static bool ObstacleQueryChannels_IsValid;

	private static FFieldAddress ObstacleQueryChannels_PropertyAddress;

	private static int ObstacleQueryChannels_Offset;

	private TArrayReadWriteMarshaler<ECollisionChannel> ObstacleQueryChannels_MarshalerCached;

	private static bool ActorsToIgnoreForCollision_IsValid;

	private static FFieldAddress ActorsToIgnoreForCollision_PropertyAddress;

	private static int ActorsToIgnoreForCollision_Offset;

	private TArrayReadWriteMarshaler<AActor> ActorsToIgnoreForCollision_MarshalerCached;

	private static bool AutoCorrectionGuessList_IsValid;

	private static FFieldAddress AutoCorrectionGuessList_PropertyAddress;

	private static int AutoCorrectionGuessList_Offset;

	private TArrayReadWriteMarshaler<float> AutoCorrectionGuessList_MarshalerCached;

	private static bool UnrealPhyxPenetrationDepth_IsValid;

	private static int UnrealPhyxPenetrationDepth_Offset;

	private static bool PerformCollisionChecksOnStartup_IsValid;

	private static FFieldAddress PerformCollisionChecksOnStartup_PropertyAddress;

	private static int PerformCollisionChecksOnStartup_Offset;

	private static bool MultiThreadingEnabled_IsValid;

	private static FFieldAddress MultiThreadingEnabled_PropertyAddress;

	private static int MultiThreadingEnabled_Offset;

	private static bool MaxPathSolverIterationsPerTick_IsValid;

	private static int MaxPathSolverIterationsPerTick_Offset;

	private static bool MaxCollisionSolverIterationsPerTick_IsValid;

	private static int MaxCollisionSolverIterationsPerTick_Offset;

	private static bool MaxPathSolverIterationsOnThread_IsValid;

	private static int MaxPathSolverIterationsOnThread_Offset;

	private static bool MaxCollisionSolverIterationsOnThread_IsValid;

	private static int MaxCollisionSolverIterationsOnThread_Offset;

	private static bool MaxPathSolverIterationsPerTick_Unbound_IsValid;

	private static int MaxPathSolverIterationsPerTick_Unbound_Offset;

	private static bool MaxCollisionSolverIterationsPerTick_Unbound_IsValid;

	private static int MaxCollisionSolverIterationsPerTick_Unbound_Offset;

	private static bool MaxPathSolverIterationsOnThread_Unbound_IsValid;

	private static int MaxPathSolverIterationsOnThread_Unbound_Offset;

	private static bool MaxCollisionSolverIterationsOnThread_Unbound_IsValid;

	private static int MaxCollisionSolverIterationsOnThread_Unbound_Offset;

	private static bool DisplayWorldBoundary_IsValid;

	private static FFieldAddress DisplayWorldBoundary_PropertyAddress;

	private static int DisplayWorldBoundary_Offset;

	private static bool DisplayWorldBoundaryInGame_IsValid;

	private static FFieldAddress DisplayWorldBoundaryInGame_PropertyAddress;

	private static int DisplayWorldBoundaryInGame_Offset;

	private static bool DebugVoxelsLineThickness_IsValid;

	private static int DebugVoxelsLineThickness_Offset;

	private static bool RunDebugValidationsForDynamicCollisions_IsValid;

	private static FFieldAddress RunDebugValidationsForDynamicCollisions_PropertyAddress;

	private static int RunDebugValidationsForDynamicCollisions_Offset;

	private static bool VisualizeNavResult_IsValid;

	private static IntPtr VisualizeNavResult_FunctionAddress;

	private static int VisualizeNavResult_ParamsSize;

	private static bool VisualizeNavResult_PathSolution_IsValid;

	private static FFieldAddress VisualizeNavResult_PathSolution_PropertyAddress;

	private static int VisualizeNavResult_PathSolution_Offset;

	private static bool VisualizeNavResult_Source_IsValid;

	private static FFieldAddress VisualizeNavResult_Source_PropertyAddress;

	private static int VisualizeNavResult_Source_Offset;

	private static bool VisualizeNavResult_Destination_IsValid;

	private static FFieldAddress VisualizeNavResult_Destination_PropertyAddress;

	private static int VisualizeNavResult_Destination_Offset;

	private static bool VisualizeNavResult_Reset_IsValid;

	private static FFieldAddress VisualizeNavResult_Reset_PropertyAddress;

	private static int VisualizeNavResult_Reset_Offset;

	private static bool VisualizeNavResult_DebugParams_IsValid;

	private static FFieldAddress VisualizeNavResult_DebugParams_PropertyAddress;

	private static int VisualizeNavResult_DebugParams_Offset;

	private static bool VisualizeNavResult_LineColor_IsValid;

	private static FFieldAddress VisualizeNavResult_LineColor_PropertyAddress;

	private static int VisualizeNavResult_LineColor_Offset;

	private static bool VisualizeDynamicCollisionListeners_IsValid;

	private static IntPtr VisualizeDynamicCollisionListeners_FunctionAddress;

	private static int VisualizeDynamicCollisionListeners_ParamsSize;

	private static bool VisualizeDynamicCollisionListeners_Listener_IsValid;

	private static FFieldAddress VisualizeDynamicCollisionListeners_Listener_PropertyAddress;

	private static int VisualizeDynamicCollisionListeners_Listener_Offset;

	private static bool VisualizeDynamicCollisionListeners_QueryData_IsValid;

	private static FFieldAddress VisualizeDynamicCollisionListeners_QueryData_PropertyAddress;

	private static int VisualizeDynamicCollisionListeners_QueryData_Offset;

	private static bool StopListeningToDynamicCollisionsForPathIndex_IsValid;

	private static IntPtr StopListeningToDynamicCollisionsForPathIndex_FunctionAddress;

	private static int StopListeningToDynamicCollisionsForPathIndex_ParamsSize;

	private static bool StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_IsValid;

	private static FFieldAddress StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_PropertyAddress;

	private static int StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_Offset;

	private static bool StopListeningToDynamicCollisionsForPathIndex_QueryData_IsValid;

	private static FFieldAddress StopListeningToDynamicCollisionsForPathIndex_QueryData_PropertyAddress;

	private static int StopListeningToDynamicCollisionsForPathIndex_QueryData_Offset;

	private static bool StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_IsValid;

	private static FFieldAddress StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_PropertyAddress;

	private static int StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_Offset;

	private static bool StopListeningToDynamicCollisionsForPath_IsValid;

	private static IntPtr StopListeningToDynamicCollisionsForPath_FunctionAddress;

	private static int StopListeningToDynamicCollisionsForPath_ParamsSize;

	private static bool StopListeningToDynamicCollisionsForPath_ListenerToClear_IsValid;

	private static FFieldAddress StopListeningToDynamicCollisionsForPath_ListenerToClear_PropertyAddress;

	private static int StopListeningToDynamicCollisionsForPath_ListenerToClear_Offset;

	private static bool StopListeningToDynamicCollisionsForPath_QueryData_IsValid;

	private static FFieldAddress StopListeningToDynamicCollisionsForPath_QueryData_PropertyAddress;

	private static int StopListeningToDynamicCollisionsForPath_QueryData_Offset;

	private static bool SchedulePathfindingTask_IsValid;

	private static IntPtr SchedulePathfindingTask_FunctionAddress;

	private static int SchedulePathfindingTask_ParamsSize;

	private static bool SchedulePathfindingTask_Actor_IsValid;

	private static FFieldAddress SchedulePathfindingTask_Actor_PropertyAddress;

	private static int SchedulePathfindingTask_Actor_Offset;

	private static bool SchedulePathfindingTask_Destination_IsValid;

	private static FFieldAddress SchedulePathfindingTask_Destination_PropertyAddress;

	private static int SchedulePathfindingTask_Destination_Offset;

	private static bool SchedulePathfindingTask_QueryParams_IsValid;

	private static FFieldAddress SchedulePathfindingTask_QueryParams_PropertyAddress;

	private static int SchedulePathfindingTask_QueryParams_Offset;

	private static bool SchedulePathfindingTask_DebugParams_IsValid;

	private static FFieldAddress SchedulePathfindingTask_DebugParams_PropertyAddress;

	private static int SchedulePathfindingTask_DebugParams_Offset;

	private static bool SchedulePathfindingTask_ResultHandlerDelegate_IsValid;

	private static FFieldAddress SchedulePathfindingTask_ResultHandlerDelegate_PropertyAddress;

	private static int SchedulePathfindingTask_ResultHandlerDelegate_Offset;

	private static bool SchedulePathfindingTask_DynamicCollisionListener_IsValid;

	private static FFieldAddress SchedulePathfindingTask_DynamicCollisionListener_PropertyAddress;

	private static int SchedulePathfindingTask_DynamicCollisionListener_Offset;

	private static bool SchedulePathfindingTask_ReturnValue_IsValid;

	private static FFieldAddress SchedulePathfindingTask_ReturnValue_PropertyAddress;

	private static int SchedulePathfindingTask_ReturnValue_Offset;

	private static bool ScheduleDynamicCollisionUpdate_IsValid;

	private static IntPtr ScheduleDynamicCollisionUpdate_FunctionAddress;

	private static int ScheduleDynamicCollisionUpdate_ParamsSize;

	private static bool ScheduleDynamicCollisionUpdate_Mesh_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_Mesh_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_Mesh_Offset;

	private static bool ScheduleDynamicCollisionUpdate_ResultHandler_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_ResultHandler_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_ResultHandler_Offset;

	private static bool ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_Offset;

	private static bool ScheduleDynamicCollisionUpdate_bReplaceExistingTask_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_bReplaceExistingTask_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_bReplaceExistingTask_Offset;

	private static bool ScheduleDynamicCollisionUpdate_bDisableCacheUsage_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_bDisableCacheUsage_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_bDisableCacheUsage_Offset;

	private static bool ScheduleDynamicCollisionUpdate_bReloadCollisionCache_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_bReloadCollisionCache_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_bReloadCollisionCache_Offset;

	private static bool ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_Offset;

	private static bool ScheduleDynamicCollisionUpdate_BoundsScaleFactor_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_BoundsScaleFactor_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_BoundsScaleFactor_Offset;

	private static bool ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_Offset;

	private static bool ScheduleDynamicCollisionUpdate_bDrawDebug_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_bDrawDebug_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_bDrawDebug_Offset;

	private static bool ScheduleDynamicCollisionUpdate_ReturnValue_IsValid;

	private static FFieldAddress ScheduleDynamicCollisionUpdate_ReturnValue_PropertyAddress;

	private static int ScheduleDynamicCollisionUpdate_ReturnValue_Offset;

	private static bool NavPathQuery_IsValid;

	private static IntPtr NavPathQuery_FunctionAddress;

	private static int NavPathQuery_ParamsSize;

	private static bool NavPathQuery_Actor_IsValid;

	private static FFieldAddress NavPathQuery_Actor_PropertyAddress;

	private static int NavPathQuery_Actor_Offset;

	private static bool NavPathQuery_Destination_IsValid;

	private static FFieldAddress NavPathQuery_Destination_PropertyAddress;

	private static int NavPathQuery_Destination_Offset;

	private static bool NavPathQuery_MaxIterations_IsValid;

	private static FFieldAddress NavPathQuery_MaxIterations_PropertyAddress;

	private static int NavPathQuery_MaxIterations_Offset;

	private static bool NavPathQuery_OutResult_IsValid;

	private static FFieldAddress NavPathQuery_OutResult_PropertyAddress;

	private static int NavPathQuery_OutResult_Offset;

	private static bool NavPathQuery_ReturnValue_IsValid;

	private static FFieldAddress NavPathQuery_ReturnValue_PropertyAddress;

	private static int NavPathQuery_ReturnValue_Offset;

	private static bool IsMeshBoundsWithinNavigableWorld_IsValid;

	private static IntPtr IsMeshBoundsWithinNavigableWorld_FunctionAddress;

	private static int IsMeshBoundsWithinNavigableWorld_ParamsSize;

	private static bool IsMeshBoundsWithinNavigableWorld_Mesh_IsValid;

	private static FFieldAddress IsMeshBoundsWithinNavigableWorld_Mesh_PropertyAddress;

	private static int IsMeshBoundsWithinNavigableWorld_Mesh_Offset;

	private static bool IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_IsValid;

	private static FFieldAddress IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_PropertyAddress;

	private static int IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_Offset;

	private static bool IsMeshBoundsWithinNavigableWorld_ReturnValue_IsValid;

	private static FFieldAddress IsMeshBoundsWithinNavigableWorld_ReturnValue_PropertyAddress;

	private static int IsMeshBoundsWithinNavigableWorld_ReturnValue_Offset;

	private static bool IsLocationWithinNavigableWorld_IsValid;

	private static IntPtr IsLocationWithinNavigableWorld_FunctionAddress;

	private static int IsLocationWithinNavigableWorld_ParamsSize;

	private static bool IsLocationWithinNavigableWorld_DesiredLocation_IsValid;

	private static FFieldAddress IsLocationWithinNavigableWorld_DesiredLocation_PropertyAddress;

	private static int IsLocationWithinNavigableWorld_DesiredLocation_Offset;

	private static bool IsLocationWithinNavigableWorld_ReturnValue_IsValid;

	private static FFieldAddress IsLocationWithinNavigableWorld_ReturnValue_PropertyAddress;

	private static int IsLocationWithinNavigableWorld_ReturnValue_Offset;

	private static bool IsLocationBeneathLandscape_IsValid;

	private static IntPtr IsLocationBeneathLandscape_FunctionAddress;

	private static int IsLocationBeneathLandscape_ParamsSize;

	private static bool IsLocationBeneathLandscape_Location_IsValid;

	private static FFieldAddress IsLocationBeneathLandscape_Location_PropertyAddress;

	private static int IsLocationBeneathLandscape_Location_Offset;

	private static bool IsLocationBeneathLandscape_LineTraceHeight_IsValid;

	private static FFieldAddress IsLocationBeneathLandscape_LineTraceHeight_PropertyAddress;

	private static int IsLocationBeneathLandscape_LineTraceHeight_Offset;

	private static bool IsLocationBeneathLandscape_ReturnValue_IsValid;

	private static FFieldAddress IsLocationBeneathLandscape_ReturnValue_PropertyAddress;

	private static int IsLocationBeneathLandscape_ReturnValue_Offset;

	private static bool IsDirectPathSweep_IsValid;

	private static IntPtr IsDirectPathSweep_FunctionAddress;

	private static int IsDirectPathSweep_ParamsSize;

	private static bool IsDirectPathSweep_CollisionComponent_IsValid;

	private static FFieldAddress IsDirectPathSweep_CollisionComponent_PropertyAddress;

	private static int IsDirectPathSweep_CollisionComponent_Offset;

	private static bool IsDirectPathSweep_Start_IsValid;

	private static FFieldAddress IsDirectPathSweep_Start_PropertyAddress;

	private static int IsDirectPathSweep_Start_Offset;

	private static bool IsDirectPathSweep_End_IsValid;

	private static FFieldAddress IsDirectPathSweep_End_PropertyAddress;

	private static int IsDirectPathSweep_End_Offset;

	private static bool IsDirectPathSweep_OutHit_IsValid;

	private static FFieldAddress IsDirectPathSweep_OutHit_PropertyAddress;

	private static int IsDirectPathSweep_OutHit_Offset;

	private static bool IsDirectPathSweep_bFindInitialOverlaps_IsValid;

	private static FFieldAddress IsDirectPathSweep_bFindInitialOverlaps_PropertyAddress;

	private static int IsDirectPathSweep_bFindInitialOverlaps_Offset;

	private static bool IsDirectPathSweep_CollisionShapeInflation_IsValid;

	private static FFieldAddress IsDirectPathSweep_CollisionShapeInflation_PropertyAddress;

	private static int IsDirectPathSweep_CollisionShapeInflation_Offset;

	private static bool IsDirectPathSweep_ReturnValue_IsValid;

	private static FFieldAddress IsDirectPathSweep_ReturnValue_PropertyAddress;

	private static int IsDirectPathSweep_ReturnValue_Offset;

	private static bool IsDirectPathLineTrace_IsValid;

	private static IntPtr IsDirectPathLineTrace_FunctionAddress;

	private static int IsDirectPathLineTrace_ParamsSize;

	private static bool IsDirectPathLineTrace_Start_IsValid;

	private static FFieldAddress IsDirectPathLineTrace_Start_PropertyAddress;

	private static int IsDirectPathLineTrace_Start_Offset;

	private static bool IsDirectPathLineTrace_End_IsValid;

	private static FFieldAddress IsDirectPathLineTrace_End_PropertyAddress;

	private static int IsDirectPathLineTrace_End_Offset;

	private static bool IsDirectPathLineTrace_OutHit_IsValid;

	private static FFieldAddress IsDirectPathLineTrace_OutHit_PropertyAddress;

	private static int IsDirectPathLineTrace_OutHit_Offset;

	private static bool IsDirectPathLineTrace_ActorsToIgnore_IsValid;

	private static FFieldAddress IsDirectPathLineTrace_ActorsToIgnore_PropertyAddress;

	private static int IsDirectPathLineTrace_ActorsToIgnore_Offset;

	private static bool IsDirectPathLineTrace_bFindInitialOverlaps_IsValid;

	private static FFieldAddress IsDirectPathLineTrace_bFindInitialOverlaps_PropertyAddress;

	private static int IsDirectPathLineTrace_bFindInitialOverlaps_Offset;

	private static bool IsDirectPathLineTrace_ReturnValue_IsValid;

	private static FFieldAddress IsDirectPathLineTrace_ReturnValue_PropertyAddress;

	private static int IsDirectPathLineTrace_ReturnValue_Offset;

	private static bool IsDirectPathLineSweep_IsValid;

	private static IntPtr IsDirectPathLineSweep_FunctionAddress;

	private static int IsDirectPathLineSweep_ParamsSize;

	private static bool IsDirectPathLineSweep_CollisionComponent_IsValid;

	private static FFieldAddress IsDirectPathLineSweep_CollisionComponent_PropertyAddress;

	private static int IsDirectPathLineSweep_CollisionComponent_Offset;

	private static bool IsDirectPathLineSweep_Start_IsValid;

	private static FFieldAddress IsDirectPathLineSweep_Start_PropertyAddress;

	private static int IsDirectPathLineSweep_Start_Offset;

	private static bool IsDirectPathLineSweep_End_IsValid;

	private static FFieldAddress IsDirectPathLineSweep_End_PropertyAddress;

	private static int IsDirectPathLineSweep_End_Offset;

	private static bool IsDirectPathLineSweep_OutHit_IsValid;

	private static FFieldAddress IsDirectPathLineSweep_OutHit_PropertyAddress;

	private static int IsDirectPathLineSweep_OutHit_Offset;

	private static bool IsDirectPathLineSweep_bFindInitialOverlaps_IsValid;

	private static FFieldAddress IsDirectPathLineSweep_bFindInitialOverlaps_PropertyAddress;

	private static int IsDirectPathLineSweep_bFindInitialOverlaps_Offset;

	private static bool IsDirectPathLineSweep_CollisionShapeInflation_IsValid;

	private static FFieldAddress IsDirectPathLineSweep_CollisionShapeInflation_PropertyAddress;

	private static int IsDirectPathLineSweep_CollisionShapeInflation_Offset;

	private static bool IsDirectPathLineSweep_ReturnValue_IsValid;

	private static FFieldAddress IsDirectPathLineSweep_ReturnValue_PropertyAddress;

	private static int IsDirectPathLineSweep_ReturnValue_Offset;

	private static bool HasTask_IsValid;

	private static IntPtr HasTask_FunctionAddress;

	private static int HasTask_ParamsSize;

	private static bool HasTask_Actor_IsValid;

	private static FFieldAddress HasTask_Actor_PropertyAddress;

	private static int HasTask_Actor_Offset;

	private static bool HasTask_ReturnValue_IsValid;

	private static FFieldAddress HasTask_ReturnValue_PropertyAddress;

	private static int HasTask_ReturnValue_Offset;

	private static bool FindRandomPointFromActorInNavWorld_IsValid;

	private static IntPtr FindRandomPointFromActorInNavWorld_FunctionAddress;

	private static int FindRandomPointFromActorInNavWorld_ParamsSize;

	private static bool FindRandomPointFromActorInNavWorld_Actor_IsValid;

	private static FFieldAddress FindRandomPointFromActorInNavWorld_Actor_PropertyAddress;

	private static int FindRandomPointFromActorInNavWorld_Actor_Offset;

	private static bool FindRandomPointFromActorInNavWorld_Distance_IsValid;

	private static FFieldAddress FindRandomPointFromActorInNavWorld_Distance_PropertyAddress;

	private static int FindRandomPointFromActorInNavWorld_Distance_Offset;

	private static bool FindRandomPointFromActorInNavWorld_bFoundValidResult_IsValid;

	private static FFieldAddress FindRandomPointFromActorInNavWorld_bFoundValidResult_PropertyAddress;

	private static int FindRandomPointFromActorInNavWorld_bFoundValidResult_Offset;

	private static bool FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_IsValid;

	private static FFieldAddress FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_PropertyAddress;

	private static int FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_Offset;

	private static bool FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_IsValid;

	private static FFieldAddress FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_PropertyAddress;

	private static int FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_Offset;

	private static bool FindRandomPointFromActorInNavWorld_MaxAttempts_IsValid;

	private static FFieldAddress FindRandomPointFromActorInNavWorld_MaxAttempts_PropertyAddress;

	private static int FindRandomPointFromActorInNavWorld_MaxAttempts_Offset;

	private static bool FindRandomPointFromActorInNavWorld_ReturnValue_IsValid;

	private static FFieldAddress FindRandomPointFromActorInNavWorld_ReturnValue_PropertyAddress;

	private static int FindRandomPointFromActorInNavWorld_ReturnValue_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_IsValid;

	private static IntPtr FindRandomPointAroundOriginInNavWorld_FunctionAddress;

	private static int FindRandomPointAroundOriginInNavWorld_ParamsSize;

	private static bool FindRandomPointAroundOriginInNavWorld_NavigationActor_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_NavigationActor_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_NavigationActor_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_Origin_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_Origin_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_Origin_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_Distance_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_Distance_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_Distance_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_bFoundValidResult_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_bFoundValidResult_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_bFoundValidResult_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_MaxAttempts_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_MaxAttempts_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_MaxAttempts_Offset;

	private static bool FindRandomPointAroundOriginInNavWorld_ReturnValue_IsValid;

	private static FFieldAddress FindRandomPointAroundOriginInNavWorld_ReturnValue_PropertyAddress;

	private static int FindRandomPointAroundOriginInNavWorld_ReturnValue_Offset;

	private static bool FindPathSolution_StressTesting_IsValid;

	private static IntPtr FindPathSolution_StressTesting_FunctionAddress;

	private static int FindPathSolution_StressTesting_ParamsSize;

	private static bool FindPathSolution_StressTesting_Actor_IsValid;

	private static FFieldAddress FindPathSolution_StressTesting_Actor_PropertyAddress;

	private static int FindPathSolution_StressTesting_Actor_Offset;

	private static bool FindPathSolution_StressTesting_Destination_IsValid;

	private static FFieldAddress FindPathSolution_StressTesting_Destination_PropertyAddress;

	private static int FindPathSolution_StressTesting_Destination_Offset;

	private static bool FindPathSolution_StressTesting_PathSolutionRaw_IsValid;

	private static FFieldAddress FindPathSolution_StressTesting_PathSolutionRaw_PropertyAddress;

	private static int FindPathSolution_StressTesting_PathSolutionRaw_Offset;

	private static bool FindPathSolution_StressTesting_PathSolutionOptimized_IsValid;

	private static FFieldAddress FindPathSolution_StressTesting_PathSolutionOptimized_PropertyAddress;

	private static int FindPathSolution_StressTesting_PathSolutionOptimized_Offset;

	private static bool FindPathSolution_StressTesting_QueryParams_IsValid;

	private static FFieldAddress FindPathSolution_StressTesting_QueryParams_PropertyAddress;

	private static int FindPathSolution_StressTesting_QueryParams_Offset;

	private static bool FindPathSolution_StressTesting_DebugParams_IsValid;

	private static FFieldAddress FindPathSolution_StressTesting_DebugParams_PropertyAddress;

	private static int FindPathSolution_StressTesting_DebugParams_Offset;

	private static bool FindPathSolution_StressTesting_ReturnValue_IsValid;

	private static FFieldAddress FindPathSolution_StressTesting_ReturnValue_PropertyAddress;

	private static int FindPathSolution_StressTesting_ReturnValue_Offset;

	private static bool Debug_ToggleWorldBoundaryInGame_IsValid;

	private static IntPtr Debug_ToggleWorldBoundaryInGame_FunctionAddress;

	private static int Debug_ToggleWorldBoundaryInGame_ParamsSize;

	private static bool Debug_DrawVoxelCollisionProfile_IsValid;

	private static IntPtr Debug_DrawVoxelCollisionProfile_FunctionAddress;

	private static int Debug_DrawVoxelCollisionProfile_ParamsSize;

	private static bool Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_IsValid;

	private static FFieldAddress Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_PropertyAddress;

	private static int Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_Offset;

	private static bool Debug_DrawVoxelCollisionProfile_bDrawPersistent_IsValid;

	private static FFieldAddress Debug_DrawVoxelCollisionProfile_bDrawPersistent_PropertyAddress;

	private static int Debug_DrawVoxelCollisionProfile_bDrawPersistent_Offset;

	private static bool Debug_DrawVoxelCollisionProfile_Duration_IsValid;

	private static FFieldAddress Debug_DrawVoxelCollisionProfile_Duration_PropertyAddress;

	private static int Debug_DrawVoxelCollisionProfile_Duration_Offset;

	private static bool Debug_DrawVolumesAroundPoint_IsValid;

	private static IntPtr Debug_DrawVolumesAroundPoint_FunctionAddress;

	private static int Debug_DrawVolumesAroundPoint_ParamsSize;

	private static bool Debug_DrawVolumesAroundPoint_Location_IsValid;

	private static FFieldAddress Debug_DrawVolumesAroundPoint_Location_PropertyAddress;

	private static int Debug_DrawVolumesAroundPoint_Location_Offset;

	private static bool Debug_DrawVolumesAroundPoint_CubeSize_IsValid;

	private static FFieldAddress Debug_DrawVolumesAroundPoint_CubeSize_PropertyAddress;

	private static int Debug_DrawVolumesAroundPoint_CubeSize_Offset;

	private static bool Debug_DrawVolumesAroundPoint_DrawPersistentLines_IsValid;

	private static FFieldAddress Debug_DrawVolumesAroundPoint_DrawPersistentLines_PropertyAddress;

	private static int Debug_DrawVolumesAroundPoint_DrawPersistentLines_Offset;

	private static bool Debug_DrawVolumesAroundPoint_Duration_IsValid;

	private static FFieldAddress Debug_DrawVolumesAroundPoint_Duration_PropertyAddress;

	private static int Debug_DrawVolumesAroundPoint_Duration_Offset;

	private static bool Debug_DrawVolumesAroundPoint_LineThickness_IsValid;

	private static FFieldAddress Debug_DrawVolumesAroundPoint_LineThickness_PropertyAddress;

	private static int Debug_DrawVolumesAroundPoint_LineThickness_Offset;

	private static bool Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_IsValid;

	private static FFieldAddress Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_PropertyAddress;

	private static int Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_Offset;

	private static bool Debug_DrawAllVolumes_IsValid;

	private static IntPtr Debug_DrawAllVolumes_FunctionAddress;

	private static int Debug_DrawAllVolumes_ParamsSize;

	private static bool Debug_DrawAllVolumes_LineThickness_IsValid;

	private static FFieldAddress Debug_DrawAllVolumes_LineThickness_PropertyAddress;

	private static int Debug_DrawAllVolumes_LineThickness_Offset;

	private static bool Debug_ClearAllVolumes_IsValid;

	private static IntPtr Debug_ClearAllVolumes_FunctionAddress;

	private static int Debug_ClearAllVolumes_ParamsSize;

	private static bool ConstructBuilder_IsValid;

	private static IntPtr ConstructBuilder_FunctionAddress;

	private static int ConstructBuilder_ParamsSize;

	private static bool ClampLocationToNavigableWorld_IsValid;

	private static IntPtr ClampLocationToNavigableWorld_FunctionAddress;

	private static int ClampLocationToNavigableWorld_ParamsSize;

	private static bool ClampLocationToNavigableWorld_DesiredLocation_IsValid;

	private static FFieldAddress ClampLocationToNavigableWorld_DesiredLocation_PropertyAddress;

	private static int ClampLocationToNavigableWorld_DesiredLocation_Offset;

	private static bool ClampLocationToNavigableWorld_ReturnValue_IsValid;

	private static FFieldAddress ClampLocationToNavigableWorld_ReturnValue_PropertyAddress;

	private static int ClampLocationToNavigableWorld_ReturnValue_Offset;

	private static bool CanNavigate_IsValid;

	private static IntPtr CanNavigate_FunctionAddress;

	private static int CanNavigate_ParamsSize;

	private static bool CanNavigate_Location_IsValid;

	private static FFieldAddress CanNavigate_Location_PropertyAddress;

	private static int CanNavigate_Location_Offset;

	private static bool CanNavigate_ReturnValue_IsValid;

	private static FFieldAddress CanNavigate_ReturnValue_PropertyAddress;

	private static int CanNavigate_ReturnValue_Offset;

	private static bool AbortPathfindingTask_IsValid;

	private static IntPtr AbortPathfindingTask_FunctionAddress;

	private static int AbortPathfindingTask_ParamsSize;

	private static bool AbortPathfindingTask_Actor_IsValid;

	private static FFieldAddress AbortPathfindingTask_Actor_PropertyAddress;

	private static int AbortPathfindingTask_Actor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274836uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:bIsUnbound")]
	public bool IsUnbound
	{
		get
		{
			CheckDestroyed();
			if (!IsUnbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bIsUnbound");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsUnbound_Offset), 0, IsUnbound_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsUnbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bIsUnbound");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsUnbound_Offset), 0, IsUnbound_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234995741uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:SceneComponent")]
	protected USceneComponent SceneComponent
	{
		get
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:SceneComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, SceneComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:SceneComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, SceneComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234995741uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:Billboard")]
	protected UBillboardComponent Billboard
	{
		get
		{
			CheckDestroyed();
			if (!Billboard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:Billboard");
				return null;
			}
			return UObjectMarshaler<UBillboardComponent>.FromNative(IntPtr.Add(base.Address, Billboard_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Billboard_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:Billboard");
			}
			else
			{
				UObjectMarshaler<UBillboardComponent>.ToNative(IntPtr.Add(base.Address, Billboard_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:VoxelSize")]
	public float VoxelSize
	{
		get
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:VoxelSize");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, VoxelSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!VoxelSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:VoxelSize");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, VoxelSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:XGridSize")]
	public int XGridSize
	{
		get
		{
			CheckDestroyed();
			if (!XGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:XGridSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, XGridSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:XGridSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, XGridSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:YGridSize")]
	public int YGridSize
	{
		get
		{
			CheckDestroyed();
			if (!YGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:YGridSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, YGridSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:YGridSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, YGridSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:ZGridSize")]
	public int ZGridSize
	{
		get
		{
			CheckDestroyed();
			if (!ZGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:ZGridSize");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ZGridSize_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ZGridSize_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:ZGridSize");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ZGridSize_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:ManagerDebugParams")]
	public FDoNNavigationDebugParams ManagerDebugParams
	{
		get
		{
			CheckDestroyed();
			if (!ManagerDebugParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:ManagerDebugParams");
				return default(FDoNNavigationDebugParams);
			}
			return FDoNNavigationDebugParams.FromNative(IntPtr.Add(base.Address, ManagerDebugParams_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ManagerDebugParams_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:ManagerDebugParams");
			}
			else
			{
				FDoNNavigationDebugParams.ToNative(IntPtr.Add(base.Address, ManagerDebugParams_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:ObstacleQueryChannels")]
	public TArrayReadWrite<ECollisionChannel> ObstacleQueryChannels
	{
		get
		{
			CheckDestroyed();
			if (!ObstacleQueryChannels_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:ObstacleQueryChannels");
				return null;
			}
			if (ObstacleQueryChannels_MarshalerCached == null)
			{
				ObstacleQueryChannels_MarshalerCached = new TArrayReadWriteMarshaler<ECollisionChannel>(1, ObstacleQueryChannels_PropertyAddress, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.FromNative, CachedMarshalingDelegates<ECollisionChannel, EnumMarshaler<ECollisionChannel>>.ToNative);
			}
			return ObstacleQueryChannels_MarshalerCached.FromNative(IntPtr.Add(base.Address, ObstacleQueryChannels_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:ActorsToIgnoreForCollision")]
	public TArrayReadWrite<AActor> ActorsToIgnoreForCollision
	{
		get
		{
			CheckDestroyed();
			if (!ActorsToIgnoreForCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:ActorsToIgnoreForCollision");
				return null;
			}
			if (ActorsToIgnoreForCollision_MarshalerCached == null)
			{
				ActorsToIgnoreForCollision_MarshalerCached = new TArrayReadWriteMarshaler<AActor>(1, ActorsToIgnoreForCollision_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return ActorsToIgnoreForCollision_MarshalerCached.FromNative(IntPtr.Add(base.Address, ActorsToIgnoreForCollision_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:AutoCorrectionGuessList")]
	public TArrayReadWrite<float> AutoCorrectionGuessList
	{
		get
		{
			CheckDestroyed();
			if (!AutoCorrectionGuessList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:AutoCorrectionGuessList");
				return null;
			}
			if (AutoCorrectionGuessList_MarshalerCached == null)
			{
				AutoCorrectionGuessList_MarshalerCached = new TArrayReadWriteMarshaler<float>(1, AutoCorrectionGuessList_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative);
			}
			return AutoCorrectionGuessList_MarshalerCached.FromNative(IntPtr.Add(base.Address, AutoCorrectionGuessList_Offset));
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:UnrealPhyxPenetrationDepth")]
	public float UnrealPhyxPenetrationDepth
	{
		get
		{
			CheckDestroyed();
			if (!UnrealPhyxPenetrationDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:UnrealPhyxPenetrationDepth");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UnrealPhyxPenetrationDepth_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UnrealPhyxPenetrationDepth_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:UnrealPhyxPenetrationDepth");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UnrealPhyxPenetrationDepth_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:PerformCollisionChecksOnStartup")]
	public bool PerformCollisionChecksOnStartup
	{
		get
		{
			CheckDestroyed();
			if (!PerformCollisionChecksOnStartup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:PerformCollisionChecksOnStartup");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, PerformCollisionChecksOnStartup_Offset), 0, PerformCollisionChecksOnStartup_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!PerformCollisionChecksOnStartup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:PerformCollisionChecksOnStartup");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, PerformCollisionChecksOnStartup_Offset), 0, PerformCollisionChecksOnStartup_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:bMultiThreadingEnabled")]
	public bool MultiThreadingEnabled
	{
		get
		{
			CheckDestroyed();
			if (!MultiThreadingEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bMultiThreadingEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, MultiThreadingEnabled_Offset), 0, MultiThreadingEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!MultiThreadingEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bMultiThreadingEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, MultiThreadingEnabled_Offset), 0, MultiThreadingEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsPerTick")]
	public int MaxPathSolverIterationsPerTick
	{
		get
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsPerTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsPerTick");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxPathSolverIterationsPerTick_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsPerTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsPerTick");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxPathSolverIterationsPerTick_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsPerTick")]
	public int MaxCollisionSolverIterationsPerTick
	{
		get
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsPerTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsPerTick");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsPerTick_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsPerTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsPerTick");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsPerTick_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsOnThread")]
	public int MaxPathSolverIterationsOnThread
	{
		get
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsOnThread_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsOnThread");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxPathSolverIterationsOnThread_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsOnThread_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsOnThread");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxPathSolverIterationsOnThread_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsOnThread")]
	public int MaxCollisionSolverIterationsOnThread
	{
		get
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsOnThread_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsOnThread");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsOnThread_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsOnThread_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsOnThread");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsOnThread_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsPerTick_Unbound")]
	public int MaxPathSolverIterationsPerTick_Unbound
	{
		get
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsPerTick_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsPerTick_Unbound");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxPathSolverIterationsPerTick_Unbound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsPerTick_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsPerTick_Unbound");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxPathSolverIterationsPerTick_Unbound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsPerTick_Unbound")]
	public int MaxCollisionSolverIterationsPerTick_Unbound
	{
		get
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsPerTick_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsPerTick_Unbound");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsPerTick_Unbound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsPerTick_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsPerTick_Unbound");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsPerTick_Unbound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsOnThread_Unbound")]
	public int MaxPathSolverIterationsOnThread_Unbound
	{
		get
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsOnThread_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsOnThread_Unbound");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxPathSolverIterationsOnThread_Unbound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxPathSolverIterationsOnThread_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxPathSolverIterationsOnThread_Unbound");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxPathSolverIterationsOnThread_Unbound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsOnThread_Unbound")]
	public int MaxCollisionSolverIterationsOnThread_Unbound
	{
		get
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsOnThread_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsOnThread_Unbound");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsOnThread_Unbound_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCollisionSolverIterationsOnThread_Unbound_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:MaxCollisionSolverIterationsOnThread_Unbound");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxCollisionSolverIterationsOnThread_Unbound_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:bDisplayWorldBoundary")]
	public bool DisplayWorldBoundary
	{
		get
		{
			CheckDestroyed();
			if (!DisplayWorldBoundary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bDisplayWorldBoundary");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisplayWorldBoundary_Offset), 0, DisplayWorldBoundary_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisplayWorldBoundary_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bDisplayWorldBoundary");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisplayWorldBoundary_Offset), 0, DisplayWorldBoundary_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:bDisplayWorldBoundaryInGame")]
	public bool DisplayWorldBoundaryInGame
	{
		get
		{
			CheckDestroyed();
			if (!DisplayWorldBoundaryInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bDisplayWorldBoundaryInGame");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisplayWorldBoundaryInGame_Offset), 0, DisplayWorldBoundaryInGame_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisplayWorldBoundaryInGame_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bDisplayWorldBoundaryInGame");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisplayWorldBoundaryInGame_Offset), 0, DisplayWorldBoundaryInGame_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:DebugVoxelsLineThickness")]
	public float DebugVoxelsLineThickness
	{
		get
		{
			CheckDestroyed();
			if (!DebugVoxelsLineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:DebugVoxelsLineThickness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DebugVoxelsLineThickness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DebugVoxelsLineThickness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:DebugVoxelsLineThickness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DebugVoxelsLineThickness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:bRunDebugValidationsForDynamicCollisions")]
	public bool RunDebugValidationsForDynamicCollisions
	{
		get
		{
			CheckDestroyed();
			if (!RunDebugValidationsForDynamicCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bRunDebugValidationsForDynamicCollisions");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RunDebugValidationsForDynamicCollisions_Offset), 0, RunDebugValidationsForDynamicCollisions_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RunDebugValidationsForDynamicCollisions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DonAINavigation.DonNavigationManager:bRunDebugValidationsForDynamicCollisions");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RunDebugValidationsForDynamicCollisions_Offset), 0, RunDebugValidationsForDynamicCollisions_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:VisualizeNavResult")]
	public unsafe void VisualizeNavResult(List<FVector> PathSolution, FVector Source, FVector Destination, bool Reset, FDoNNavigationDebugParams DebugParams, FColor LineColor)
	{
		CheckDestroyed();
		if (!VisualizeNavResult_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:VisualizeNavResult");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VisualizeNavResult_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VisualizeNavResult_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FVector>(1, VisualizeNavResult_PathSolution_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(intPtr, VisualizeNavResult_PathSolution_Offset), PathSolution);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VisualizeNavResult_Source_Offset), 0, VisualizeNavResult_Source_PropertyAddress.Address, Source);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, VisualizeNavResult_Destination_Offset), 0, VisualizeNavResult_Destination_PropertyAddress.Address, Destination);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, VisualizeNavResult_Reset_Offset), 0, VisualizeNavResult_Reset_PropertyAddress.Address, Reset);
		NativeReflection.InitializeValue_InContainer(VisualizeNavResult_DebugParams_PropertyAddress.Address, intPtr);
		FDoNNavigationDebugParams.ToNative(IntPtr.Add(intPtr, VisualizeNavResult_DebugParams_Offset), 0, VisualizeNavResult_DebugParams_PropertyAddress.Address, DebugParams);
		BlittableTypeMarshaler<FColor>.ToNative(IntPtr.Add(intPtr, VisualizeNavResult_LineColor_Offset), 0, VisualizeNavResult_LineColor_PropertyAddress.Address, LineColor);
		NativeReflection.InvokeFunctionOptimized(base.Address, VisualizeNavResult_FunctionAddress, intPtr, VisualizeNavResult_ParamsSize);
		NativeReflection.DestroyValue_InContainer(VisualizeNavResult_PathSolution_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:VisualizeDynamicCollisionListeners")]
	public unsafe void VisualizeDynamicCollisionListeners(FDonNavigationDynamicCollisionDelegate Listener, out FDoNNavigationQueryData QueryData)
	{
		CheckDestroyed();
		if (!VisualizeDynamicCollisionListeners_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:VisualizeDynamicCollisionListeners");
			QueryData = default(FDoNNavigationQueryData);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VisualizeDynamicCollisionListeners_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VisualizeDynamicCollisionListeners_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FDonNavigationDynamicCollisionDelegate>.ToNative(IntPtr.Add(intPtr, VisualizeDynamicCollisionListeners_Listener_Offset), 0, VisualizeDynamicCollisionListeners_Listener_PropertyAddress.Address, Listener);
		NativeReflection.InitializeValue_InContainer(VisualizeDynamicCollisionListeners_QueryData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, VisualizeDynamicCollisionListeners_FunctionAddress, intPtr, VisualizeDynamicCollisionListeners_ParamsSize);
		QueryData = FDoNNavigationQueryData.FromNative(IntPtr.Add(intPtr, VisualizeDynamicCollisionListeners_QueryData_Offset), 0, VisualizeDynamicCollisionListeners_QueryData_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(VisualizeDynamicCollisionListeners_QueryData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:StopListeningToDynamicCollisionsForPathIndex")]
	public unsafe void StopListeningToDynamicCollisionsForPathIndex(FDonNavigationDynamicCollisionDelegate ListenerToClear, FDoNNavigationQueryData QueryData, int VolumeIndex)
	{
		CheckDestroyed();
		if (!StopListeningToDynamicCollisionsForPathIndex_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:StopListeningToDynamicCollisionsForPathIndex");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopListeningToDynamicCollisionsForPathIndex_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopListeningToDynamicCollisionsForPathIndex_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FDonNavigationDynamicCollisionDelegate>.ToNative(IntPtr.Add(intPtr, StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_Offset), 0, StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_PropertyAddress.Address, ListenerToClear);
		NativeReflection.InitializeValue_InContainer(StopListeningToDynamicCollisionsForPathIndex_QueryData_PropertyAddress.Address, intPtr);
		FDoNNavigationQueryData.ToNative(IntPtr.Add(intPtr, StopListeningToDynamicCollisionsForPathIndex_QueryData_Offset), 0, StopListeningToDynamicCollisionsForPathIndex_QueryData_PropertyAddress.Address, QueryData);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_Offset), 0, StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_PropertyAddress.Address, VolumeIndex);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, intPtr, StopListeningToDynamicCollisionsForPathIndex_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StopListeningToDynamicCollisionsForPathIndex_QueryData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:StopListeningToDynamicCollisionsForPath")]
	public unsafe void StopListeningToDynamicCollisionsForPath(FDonNavigationDynamicCollisionDelegate ListenerToClear, FDoNNavigationQueryData QueryData)
	{
		CheckDestroyed();
		if (!StopListeningToDynamicCollisionsForPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:StopListeningToDynamicCollisionsForPath");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopListeningToDynamicCollisionsForPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopListeningToDynamicCollisionsForPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FDonNavigationDynamicCollisionDelegate>.ToNative(IntPtr.Add(intPtr, StopListeningToDynamicCollisionsForPath_ListenerToClear_Offset), 0, StopListeningToDynamicCollisionsForPath_ListenerToClear_PropertyAddress.Address, ListenerToClear);
		NativeReflection.InitializeValue_InContainer(StopListeningToDynamicCollisionsForPath_QueryData_PropertyAddress.Address, intPtr);
		FDoNNavigationQueryData.ToNative(IntPtr.Add(intPtr, StopListeningToDynamicCollisionsForPath_QueryData_Offset), 0, StopListeningToDynamicCollisionsForPath_QueryData_PropertyAddress.Address, QueryData);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopListeningToDynamicCollisionsForPath_FunctionAddress, intPtr, StopListeningToDynamicCollisionsForPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StopListeningToDynamicCollisionsForPath_QueryData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:SchedulePathfindingTask")]
	public unsafe bool SchedulePathfindingTask(AActor Actor, FVector Destination, FDoNNavigationQueryParams QueryParams, FDoNNavigationDebugParams DebugParams, FDoNNavigationResultHandler ResultHandlerDelegate, FDonNavigationDynamicCollisionDelegate DynamicCollisionListener)
	{
		CheckDestroyed();
		if (!SchedulePathfindingTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:SchedulePathfindingTask");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SchedulePathfindingTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SchedulePathfindingTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, SchedulePathfindingTask_Actor_Offset), 0, SchedulePathfindingTask_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SchedulePathfindingTask_Destination_Offset), 0, SchedulePathfindingTask_Destination_PropertyAddress.Address, Destination);
		NativeReflection.InitializeValue_InContainer(SchedulePathfindingTask_QueryParams_PropertyAddress.Address, intPtr);
		FDoNNavigationQueryParams.ToNative(IntPtr.Add(intPtr, SchedulePathfindingTask_QueryParams_Offset), 0, SchedulePathfindingTask_QueryParams_PropertyAddress.Address, QueryParams);
		NativeReflection.InitializeValue_InContainer(SchedulePathfindingTask_DebugParams_PropertyAddress.Address, intPtr);
		FDoNNavigationDebugParams.ToNative(IntPtr.Add(intPtr, SchedulePathfindingTask_DebugParams_Offset), 0, SchedulePathfindingTask_DebugParams_PropertyAddress.Address, DebugParams);
		FDelegateMarshaler<FDoNNavigationResultHandler>.ToNative(IntPtr.Add(intPtr, SchedulePathfindingTask_ResultHandlerDelegate_Offset), 0, SchedulePathfindingTask_ResultHandlerDelegate_PropertyAddress.Address, ResultHandlerDelegate);
		FDelegateMarshaler<FDonNavigationDynamicCollisionDelegate>.ToNative(IntPtr.Add(intPtr, SchedulePathfindingTask_DynamicCollisionListener_Offset), 0, SchedulePathfindingTask_DynamicCollisionListener_PropertyAddress.Address, DynamicCollisionListener);
		NativeReflection.InvokeFunctionOptimized(base.Address, SchedulePathfindingTask_FunctionAddress, intPtr, SchedulePathfindingTask_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SchedulePathfindingTask_ReturnValue_Offset), 0, SchedulePathfindingTask_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:ScheduleDynamicCollisionUpdate")]
	public unsafe bool ScheduleDynamicCollisionUpdate(UPrimitiveComponent Mesh, FDonCollisionSamplerCallback ResultHandler, FName CustomCacheIdentifier, bool bReplaceExistingTask, bool bDisableCacheUsage, bool bReloadCollisionCache, bool bUseCheapBoundsCollision, float BoundsScaleFactor, bool bForceSynchronousExecution, bool bDrawDebug)
	{
		CheckDestroyed();
		if (!ScheduleDynamicCollisionUpdate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:ScheduleDynamicCollisionUpdate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ScheduleDynamicCollisionUpdate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ScheduleDynamicCollisionUpdate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_Mesh_Offset), 0, ScheduleDynamicCollisionUpdate_Mesh_PropertyAddress.Address, Mesh);
		FDelegateMarshaler<FDonCollisionSamplerCallback>.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_ResultHandler_Offset), 0, ScheduleDynamicCollisionUpdate_ResultHandler_PropertyAddress.Address, ResultHandler);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_Offset), 0, ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_PropertyAddress.Address, CustomCacheIdentifier);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_bReplaceExistingTask_Offset), 0, ScheduleDynamicCollisionUpdate_bReplaceExistingTask_PropertyAddress.Address, bReplaceExistingTask);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_bDisableCacheUsage_Offset), 0, ScheduleDynamicCollisionUpdate_bDisableCacheUsage_PropertyAddress.Address, bDisableCacheUsage);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_bReloadCollisionCache_Offset), 0, ScheduleDynamicCollisionUpdate_bReloadCollisionCache_PropertyAddress.Address, bReloadCollisionCache);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_Offset), 0, ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_PropertyAddress.Address, bUseCheapBoundsCollision);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_BoundsScaleFactor_Offset), 0, ScheduleDynamicCollisionUpdate_BoundsScaleFactor_PropertyAddress.Address, BoundsScaleFactor);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_Offset), 0, ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_PropertyAddress.Address, bForceSynchronousExecution);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_bDrawDebug_Offset), 0, ScheduleDynamicCollisionUpdate_bDrawDebug_PropertyAddress.Address, bDrawDebug);
		NativeReflection.InvokeFunctionOptimized(base.Address, ScheduleDynamicCollisionUpdate_FunctionAddress, intPtr, ScheduleDynamicCollisionUpdate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ScheduleDynamicCollisionUpdate_ReturnValue_Offset), 0, ScheduleDynamicCollisionUpdate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:NavPathQuery")]
	public unsafe bool NavPathQuery(AActor Actor, FVector Destination, int MaxIterations, out FDonNavigationPathFindingResult OutResult)
	{
		CheckDestroyed();
		if (!NavPathQuery_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:NavPathQuery");
			OutResult = default(FDonNavigationPathFindingResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NavPathQuery_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NavPathQuery_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, NavPathQuery_Actor_Offset), 0, NavPathQuery_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, NavPathQuery_Destination_Offset), 0, NavPathQuery_Destination_PropertyAddress.Address, Destination);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NavPathQuery_MaxIterations_Offset), 0, NavPathQuery_MaxIterations_PropertyAddress.Address, MaxIterations);
		NativeReflection.InitializeValue_InContainer(NavPathQuery_OutResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, NavPathQuery_FunctionAddress, intPtr, NavPathQuery_ParamsSize);
		OutResult = FDonNavigationPathFindingResult.FromNative(IntPtr.Add(intPtr, NavPathQuery_OutResult_Offset), 0, NavPathQuery_OutResult_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(NavPathQuery_OutResult_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, NavPathQuery_ReturnValue_Offset), 0, NavPathQuery_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:IsMeshBoundsWithinNavigableWorld")]
	public unsafe bool IsMeshBoundsWithinNavigableWorld(UPrimitiveComponent Mesh, float BoundsScaleFactor = 1f)
	{
		CheckDestroyed();
		if (!IsMeshBoundsWithinNavigableWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:IsMeshBoundsWithinNavigableWorld");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsMeshBoundsWithinNavigableWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsMeshBoundsWithinNavigableWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, IsMeshBoundsWithinNavigableWorld_Mesh_Offset), 0, IsMeshBoundsWithinNavigableWorld_Mesh_PropertyAddress.Address, Mesh);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_Offset), 0, IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_PropertyAddress.Address, BoundsScaleFactor);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsMeshBoundsWithinNavigableWorld_FunctionAddress, intPtr, IsMeshBoundsWithinNavigableWorld_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsMeshBoundsWithinNavigableWorld_ReturnValue_Offset), 0, IsMeshBoundsWithinNavigableWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:IsLocationWithinNavigableWorld")]
	public unsafe bool IsLocationWithinNavigableWorld(FVector DesiredLocation)
	{
		CheckDestroyed();
		if (!IsLocationWithinNavigableWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:IsLocationWithinNavigableWorld");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocationWithinNavigableWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocationWithinNavigableWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsLocationWithinNavigableWorld_DesiredLocation_Offset), 0, IsLocationWithinNavigableWorld_DesiredLocation_PropertyAddress.Address, DesiredLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocationWithinNavigableWorld_FunctionAddress, intPtr, IsLocationWithinNavigableWorld_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocationWithinNavigableWorld_ReturnValue_Offset), 0, IsLocationWithinNavigableWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:IsLocationBeneathLandscape")]
	public unsafe bool IsLocationBeneathLandscape(FVector Location, float LineTraceHeight = 3000f)
	{
		CheckDestroyed();
		if (!IsLocationBeneathLandscape_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:IsLocationBeneathLandscape");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLocationBeneathLandscape_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLocationBeneathLandscape_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsLocationBeneathLandscape_Location_Offset), 0, IsLocationBeneathLandscape_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsLocationBeneathLandscape_LineTraceHeight_Offset), 0, IsLocationBeneathLandscape_LineTraceHeight_PropertyAddress.Address, LineTraceHeight);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLocationBeneathLandscape_FunctionAddress, intPtr, IsLocationBeneathLandscape_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLocationBeneathLandscape_ReturnValue_Offset), 0, IsLocationBeneathLandscape_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:IsDirectPathSweep")]
	public unsafe bool IsDirectPathSweep(UPrimitiveComponent CollisionComponent, FVector Start, FVector End, out FHitResult OutHit, bool bFindInitialOverlaps = false, float CollisionShapeInflation = 0f)
	{
		CheckDestroyed();
		if (!IsDirectPathSweep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:IsDirectPathSweep");
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDirectPathSweep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDirectPathSweep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, IsDirectPathSweep_CollisionComponent_Offset), 0, IsDirectPathSweep_CollisionComponent_PropertyAddress.Address, CollisionComponent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsDirectPathSweep_Start_Offset), 0, IsDirectPathSweep_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsDirectPathSweep_End_Offset), 0, IsDirectPathSweep_End_PropertyAddress.Address, End);
		NativeReflection.InitializeValue_InContainer(IsDirectPathSweep_OutHit_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IsDirectPathSweep_bFindInitialOverlaps_Offset), 0, IsDirectPathSweep_bFindInitialOverlaps_PropertyAddress.Address, bFindInitialOverlaps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsDirectPathSweep_CollisionShapeInflation_Offset), 0, IsDirectPathSweep_CollisionShapeInflation_PropertyAddress.Address, CollisionShapeInflation);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDirectPathSweep_FunctionAddress, intPtr, IsDirectPathSweep_ParamsSize);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, IsDirectPathSweep_OutHit_Offset), 0, IsDirectPathSweep_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDirectPathSweep_ReturnValue_Offset), 0, IsDirectPathSweep_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:IsDirectPathLineTrace")]
	public unsafe bool IsDirectPathLineTrace(FVector Start, FVector End, out FHitResult OutHit, List<AActor> ActorsToIgnore, bool bFindInitialOverlaps = true)
	{
		CheckDestroyed();
		if (!IsDirectPathLineTrace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:IsDirectPathLineTrace");
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDirectPathLineTrace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDirectPathLineTrace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsDirectPathLineTrace_Start_Offset), 0, IsDirectPathLineTrace_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsDirectPathLineTrace_End_Offset), 0, IsDirectPathLineTrace_End_PropertyAddress.Address, End);
		NativeReflection.InitializeValue_InContainer(IsDirectPathLineTrace_OutHit_PropertyAddress.Address, intPtr);
		new TArrayCopyMarshaler<AActor>(1, IsDirectPathLineTrace_ActorsToIgnore_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative).ToNative(IntPtr.Add(intPtr, IsDirectPathLineTrace_ActorsToIgnore_Offset), ActorsToIgnore);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IsDirectPathLineTrace_bFindInitialOverlaps_Offset), 0, IsDirectPathLineTrace_bFindInitialOverlaps_PropertyAddress.Address, bFindInitialOverlaps);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDirectPathLineTrace_FunctionAddress, intPtr, IsDirectPathLineTrace_ParamsSize);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, IsDirectPathLineTrace_OutHit_Offset), 0, IsDirectPathLineTrace_OutHit_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(IsDirectPathLineTrace_ActorsToIgnore_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDirectPathLineTrace_ReturnValue_Offset), 0, IsDirectPathLineTrace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:IsDirectPathLineSweep")]
	public unsafe bool IsDirectPathLineSweep(UPrimitiveComponent CollisionComponent, FVector Start, FVector End, out FHitResult OutHit, bool bFindInitialOverlaps = false, float CollisionShapeInflation = 0f)
	{
		CheckDestroyed();
		if (!IsDirectPathLineSweep_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:IsDirectPathLineSweep");
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsDirectPathLineSweep_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsDirectPathLineSweep_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, IsDirectPathLineSweep_CollisionComponent_Offset), 0, IsDirectPathLineSweep_CollisionComponent_PropertyAddress.Address, CollisionComponent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsDirectPathLineSweep_Start_Offset), 0, IsDirectPathLineSweep_Start_PropertyAddress.Address, Start);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, IsDirectPathLineSweep_End_Offset), 0, IsDirectPathLineSweep_End_PropertyAddress.Address, End);
		NativeReflection.InitializeValue_InContainer(IsDirectPathLineSweep_OutHit_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, IsDirectPathLineSweep_bFindInitialOverlaps_Offset), 0, IsDirectPathLineSweep_bFindInitialOverlaps_PropertyAddress.Address, bFindInitialOverlaps);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsDirectPathLineSweep_CollisionShapeInflation_Offset), 0, IsDirectPathLineSweep_CollisionShapeInflation_PropertyAddress.Address, CollisionShapeInflation);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsDirectPathLineSweep_FunctionAddress, intPtr, IsDirectPathLineSweep_ParamsSize);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, IsDirectPathLineSweep_OutHit_Offset), 0, IsDirectPathLineSweep_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsDirectPathLineSweep_ReturnValue_Offset), 0, IsDirectPathLineSweep_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:HasTask")]
	public unsafe bool HasTask(AActor Actor)
	{
		CheckDestroyed();
		if (!HasTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:HasTask");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, HasTask_Actor_Offset), 0, HasTask_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasTask_FunctionAddress, intPtr, HasTask_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasTask_ReturnValue_Offset), 0, HasTask_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348259329u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:FindRandomPointFromActorInNavWorld")]
	public unsafe FVector FindRandomPointFromActorInNavWorld(AActor Actor, float Distance, out bool bFoundValidResult, float MaxDesiredAltitude = -1f, float MaxZAngularDispacement = 15f, int MaxAttempts = 5)
	{
		CheckDestroyed();
		if (!FindRandomPointFromActorInNavWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:FindRandomPointFromActorInNavWorld");
			bFoundValidResult = false;
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindRandomPointFromActorInNavWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindRandomPointFromActorInNavWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FindRandomPointFromActorInNavWorld_Actor_Offset), 0, FindRandomPointFromActorInNavWorld_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindRandomPointFromActorInNavWorld_Distance_Offset), 0, FindRandomPointFromActorInNavWorld_Distance_PropertyAddress.Address, Distance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_Offset), 0, FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_PropertyAddress.Address, MaxDesiredAltitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_Offset), 0, FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_PropertyAddress.Address, MaxZAngularDispacement);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FindRandomPointFromActorInNavWorld_MaxAttempts_Offset), 0, FindRandomPointFromActorInNavWorld_MaxAttempts_PropertyAddress.Address, MaxAttempts);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindRandomPointFromActorInNavWorld_FunctionAddress, intPtr, FindRandomPointFromActorInNavWorld_ParamsSize);
		bFoundValidResult = BoolMarshaler.FromNative(IntPtr.Add(intPtr, FindRandomPointFromActorInNavWorld_bFoundValidResult_Offset), 0, FindRandomPointFromActorInNavWorld_bFoundValidResult_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindRandomPointFromActorInNavWorld_ReturnValue_Offset), 0, FindRandomPointFromActorInNavWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 348259329u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:FindRandomPointAroundOriginInNavWorld")]
	public unsafe FVector FindRandomPointAroundOriginInNavWorld(AActor NavigationActor, FVector Origin, float Distance, out bool bFoundValidResult, float MaxDesiredAltitude = -1f, float MaxZAngularDispacement = 15f, int MaxAttempts = 5)
	{
		CheckDestroyed();
		if (!FindRandomPointAroundOriginInNavWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:FindRandomPointAroundOriginInNavWorld");
			bFoundValidResult = false;
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindRandomPointAroundOriginInNavWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindRandomPointAroundOriginInNavWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_NavigationActor_Offset), 0, FindRandomPointAroundOriginInNavWorld_NavigationActor_PropertyAddress.Address, NavigationActor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_Origin_Offset), 0, FindRandomPointAroundOriginInNavWorld_Origin_PropertyAddress.Address, Origin);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_Distance_Offset), 0, FindRandomPointAroundOriginInNavWorld_Distance_PropertyAddress.Address, Distance);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_Offset), 0, FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_PropertyAddress.Address, MaxDesiredAltitude);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_Offset), 0, FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_PropertyAddress.Address, MaxZAngularDispacement);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_MaxAttempts_Offset), 0, FindRandomPointAroundOriginInNavWorld_MaxAttempts_PropertyAddress.Address, MaxAttempts);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindRandomPointAroundOriginInNavWorld_FunctionAddress, intPtr, FindRandomPointAroundOriginInNavWorld_ParamsSize);
		bFoundValidResult = BoolMarshaler.FromNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_bFoundValidResult_Offset), 0, FindRandomPointAroundOriginInNavWorld_bFoundValidResult_PropertyAddress.Address);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, FindRandomPointAroundOriginInNavWorld_ReturnValue_Offset), 0, FindRandomPointAroundOriginInNavWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:FindPathSolution_StressTesting")]
	public unsafe bool FindPathSolution_StressTesting(AActor Actor, FVector Destination, out List<FVector> PathSolutionRaw, out List<FVector> PathSolutionOptimized, FDoNNavigationQueryParams QueryParams, FDoNNavigationDebugParams DebugParams)
	{
		CheckDestroyed();
		if (!FindPathSolution_StressTesting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:FindPathSolution_StressTesting");
			PathSolutionRaw = null;
			PathSolutionOptimized = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindPathSolution_StressTesting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindPathSolution_StressTesting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, FindPathSolution_StressTesting_Actor_Offset), 0, FindPathSolution_StressTesting_Actor_PropertyAddress.Address, Actor);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, FindPathSolution_StressTesting_Destination_Offset), 0, FindPathSolution_StressTesting_Destination_PropertyAddress.Address, Destination);
		NativeReflection.InitializeValue_InContainer(FindPathSolution_StressTesting_QueryParams_PropertyAddress.Address, intPtr);
		FDoNNavigationQueryParams.ToNative(IntPtr.Add(intPtr, FindPathSolution_StressTesting_QueryParams_Offset), 0, FindPathSolution_StressTesting_QueryParams_PropertyAddress.Address, QueryParams);
		NativeReflection.InitializeValue_InContainer(FindPathSolution_StressTesting_DebugParams_PropertyAddress.Address, intPtr);
		FDoNNavigationDebugParams.ToNative(IntPtr.Add(intPtr, FindPathSolution_StressTesting_DebugParams_Offset), 0, FindPathSolution_StressTesting_DebugParams_PropertyAddress.Address, DebugParams);
		NativeReflection.InvokeFunctionOptimized(base.Address, FindPathSolution_StressTesting_FunctionAddress, intPtr, FindPathSolution_StressTesting_ParamsSize);
		PathSolutionRaw = new TArrayCopyMarshaler<FVector>(1, FindPathSolution_StressTesting_PathSolutionRaw_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, FindPathSolution_StressTesting_PathSolutionRaw_Offset));
		NativeReflection.DestroyValue_InContainer(FindPathSolution_StressTesting_PathSolutionRaw_PropertyAddress.Address, intPtr);
		PathSolutionOptimized = new TArrayCopyMarshaler<FVector>(1, FindPathSolution_StressTesting_PathSolutionOptimized_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(intPtr, FindPathSolution_StressTesting_PathSolutionOptimized_Offset));
		NativeReflection.DestroyValue_InContainer(FindPathSolution_StressTesting_PathSolutionOptimized_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, FindPathSolution_StressTesting_ReturnValue_Offset), 0, FindPathSolution_StressTesting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:Debug_ToggleWorldBoundaryInGame")]
	public unsafe void Debug_ToggleWorldBoundaryInGame()
	{
		CheckDestroyed();
		if (!Debug_ToggleWorldBoundaryInGame_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:Debug_ToggleWorldBoundaryInGame");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Debug_ToggleWorldBoundaryInGame_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Debug_ToggleWorldBoundaryInGame_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Debug_ToggleWorldBoundaryInGame_FunctionAddress, argsSize: Debug_ToggleWorldBoundaryInGame_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:Debug_DrawVoxelCollisionProfile")]
	public unsafe void Debug_DrawVoxelCollisionProfile(UPrimitiveComponent MeshOrPrimitive, bool bDrawPersistent = false, float Duration = 2f)
	{
		CheckDestroyed();
		if (!Debug_DrawVoxelCollisionProfile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:Debug_DrawVoxelCollisionProfile");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Debug_DrawVoxelCollisionProfile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Debug_DrawVoxelCollisionProfile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(intPtr, Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_Offset), 0, Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_PropertyAddress.Address, MeshOrPrimitive);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Debug_DrawVoxelCollisionProfile_bDrawPersistent_Offset), 0, Debug_DrawVoxelCollisionProfile_bDrawPersistent_PropertyAddress.Address, bDrawPersistent);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Debug_DrawVoxelCollisionProfile_Duration_Offset), 0, Debug_DrawVoxelCollisionProfile_Duration_PropertyAddress.Address, Duration);
		NativeReflection.InvokeFunctionOptimized(base.Address, Debug_DrawVoxelCollisionProfile_FunctionAddress, intPtr, Debug_DrawVoxelCollisionProfile_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:Debug_DrawVolumesAroundPoint")]
	public unsafe void Debug_DrawVolumesAroundPoint(FVector Location, int CubeSize, bool DrawPersistentLines, float Duration, float LineThickness, bool bAutoInitializeVolumes = false)
	{
		CheckDestroyed();
		if (!Debug_DrawVolumesAroundPoint_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:Debug_DrawVolumesAroundPoint");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Debug_DrawVolumesAroundPoint_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Debug_DrawVolumesAroundPoint_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, Debug_DrawVolumesAroundPoint_Location_Offset), 0, Debug_DrawVolumesAroundPoint_Location_PropertyAddress.Address, Location);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, Debug_DrawVolumesAroundPoint_CubeSize_Offset), 0, Debug_DrawVolumesAroundPoint_CubeSize_PropertyAddress.Address, CubeSize);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Debug_DrawVolumesAroundPoint_DrawPersistentLines_Offset), 0, Debug_DrawVolumesAroundPoint_DrawPersistentLines_PropertyAddress.Address, DrawPersistentLines);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Debug_DrawVolumesAroundPoint_Duration_Offset), 0, Debug_DrawVolumesAroundPoint_Duration_PropertyAddress.Address, Duration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Debug_DrawVolumesAroundPoint_LineThickness_Offset), 0, Debug_DrawVolumesAroundPoint_LineThickness_PropertyAddress.Address, LineThickness);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_Offset), 0, Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_PropertyAddress.Address, bAutoInitializeVolumes);
		NativeReflection.InvokeFunctionOptimized(base.Address, Debug_DrawVolumesAroundPoint_FunctionAddress, intPtr, Debug_DrawVolumesAroundPoint_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:Debug_DrawAllVolumes")]
	public unsafe void Debug_DrawAllVolumes(float LineThickness)
	{
		CheckDestroyed();
		if (!Debug_DrawAllVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:Debug_DrawAllVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Debug_DrawAllVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Debug_DrawAllVolumes_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Debug_DrawAllVolumes_LineThickness_Offset), 0, Debug_DrawAllVolumes_LineThickness_PropertyAddress.Address, LineThickness);
		NativeReflection.InvokeFunctionOptimized(base.Address, Debug_DrawAllVolumes_FunctionAddress, intPtr, Debug_DrawAllVolumes_ParamsSize);
	}

	[UFunction(Flags = 1140982785u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:Debug_ClearAllVolumes")]
	public unsafe void Debug_ClearAllVolumes()
	{
		CheckDestroyed();
		if (!Debug_ClearAllVolumes_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:Debug_ClearAllVolumes");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Debug_ClearAllVolumes_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Debug_ClearAllVolumes_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Debug_ClearAllVolumes_FunctionAddress, argsSize: Debug_ClearAllVolumes_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:ConstructBuilder")]
	public unsafe void ConstructBuilder()
	{
		CheckDestroyed();
		if (!ConstructBuilder_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:ConstructBuilder");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstructBuilder_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstructBuilder_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ConstructBuilder_FunctionAddress, argsSize: ConstructBuilder_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:ClampLocationToNavigableWorld")]
	public unsafe FVector ClampLocationToNavigableWorld(FVector DesiredLocation)
	{
		CheckDestroyed();
		if (!ClampLocationToNavigableWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:ClampLocationToNavigableWorld");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClampLocationToNavigableWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClampLocationToNavigableWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ClampLocationToNavigableWorld_DesiredLocation_Offset), 0, ClampLocationToNavigableWorld_DesiredLocation_PropertyAddress.Address, DesiredLocation);
		NativeReflection.InvokeFunctionOptimized(base.Address, ClampLocationToNavigableWorld_FunctionAddress, intPtr, ClampLocationToNavigableWorld_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ClampLocationToNavigableWorld_ReturnValue_Offset), 0, ClampLocationToNavigableWorld_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 344065025u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:CanNavigate")]
	public unsafe bool CanNavigate(FVector Location)
	{
		CheckDestroyed();
		if (!CanNavigate_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:CanNavigate");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CanNavigate_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CanNavigate_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CanNavigate_Location_Offset), 0, CanNavigate_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeFunctionOptimized(base.Address, CanNavigate_FunctionAddress, intPtr, CanNavigate_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CanNavigate_ReturnValue_Offset), 0, CanNavigate_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationManager:AbortPathfindingTask")]
	public unsafe void AbortPathfindingTask(AActor Actor)
	{
		CheckDestroyed();
		if (!AbortPathfindingTask_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DonAINavigation.DonNavigationManager:AbortPathfindingTask");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AbortPathfindingTask_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AbortPathfindingTask_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(intPtr, AbortPathfindingTask_Actor_Offset), 0, AbortPathfindingTask_Actor_PropertyAddress.Address, Actor);
		NativeReflection.InvokeFunctionOptimized(base.Address, AbortPathfindingTask_FunctionAddress, intPtr, AbortPathfindingTask_ParamsSize);
	}

	static ADonNavigationManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ADonNavigationManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ADonNavigationManager));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/DonAINavigation.DonNavigationManager");
		NativeReflectionCached.GetPropertyRef(ref IsUnbound_PropertyAddress, intPtr, "bIsUnbound");
		IsUnbound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsUnbound");
		IsUnbound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsUnbound", Classes.FBoolProperty);
		SceneComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SceneComponent");
		SceneComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SceneComponent", Classes.FObjectProperty);
		Billboard_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Billboard");
		Billboard_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Billboard", Classes.FObjectProperty);
		VoxelSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VoxelSize");
		VoxelSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VoxelSize", Classes.FFloatProperty);
		XGridSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "XGridSize");
		XGridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "XGridSize", Classes.FIntProperty);
		YGridSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "YGridSize");
		YGridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "YGridSize", Classes.FIntProperty);
		ZGridSize_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ZGridSize");
		ZGridSize_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ZGridSize", Classes.FIntProperty);
		ManagerDebugParams_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ManagerDebugParams");
		ManagerDebugParams_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ManagerDebugParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ObstacleQueryChannels_PropertyAddress, intPtr, "ObstacleQueryChannels");
		ObstacleQueryChannels_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ObstacleQueryChannels");
		ObstacleQueryChannels_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ObstacleQueryChannels", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ActorsToIgnoreForCollision_PropertyAddress, intPtr, "ActorsToIgnoreForCollision");
		ActorsToIgnoreForCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActorsToIgnoreForCollision");
		ActorsToIgnoreForCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActorsToIgnoreForCollision", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoCorrectionGuessList_PropertyAddress, intPtr, "AutoCorrectionGuessList");
		AutoCorrectionGuessList_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AutoCorrectionGuessList");
		AutoCorrectionGuessList_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AutoCorrectionGuessList", Classes.FArrayProperty);
		UnrealPhyxPenetrationDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UnrealPhyxPenetrationDepth");
		UnrealPhyxPenetrationDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UnrealPhyxPenetrationDepth", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PerformCollisionChecksOnStartup_PropertyAddress, intPtr, "PerformCollisionChecksOnStartup");
		PerformCollisionChecksOnStartup_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PerformCollisionChecksOnStartup");
		PerformCollisionChecksOnStartup_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PerformCollisionChecksOnStartup", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MultiThreadingEnabled_PropertyAddress, intPtr, "bMultiThreadingEnabled");
		MultiThreadingEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bMultiThreadingEnabled");
		MultiThreadingEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bMultiThreadingEnabled", Classes.FBoolProperty);
		MaxPathSolverIterationsPerTick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxPathSolverIterationsPerTick");
		MaxPathSolverIterationsPerTick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxPathSolverIterationsPerTick", Classes.FIntProperty);
		MaxCollisionSolverIterationsPerTick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxCollisionSolverIterationsPerTick");
		MaxCollisionSolverIterationsPerTick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxCollisionSolverIterationsPerTick", Classes.FIntProperty);
		MaxPathSolverIterationsOnThread_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxPathSolverIterationsOnThread");
		MaxPathSolverIterationsOnThread_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxPathSolverIterationsOnThread", Classes.FIntProperty);
		MaxCollisionSolverIterationsOnThread_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxCollisionSolverIterationsOnThread");
		MaxCollisionSolverIterationsOnThread_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxCollisionSolverIterationsOnThread", Classes.FIntProperty);
		MaxPathSolverIterationsPerTick_Unbound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxPathSolverIterationsPerTick_Unbound");
		MaxPathSolverIterationsPerTick_Unbound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxPathSolverIterationsPerTick_Unbound", Classes.FIntProperty);
		MaxCollisionSolverIterationsPerTick_Unbound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxCollisionSolverIterationsPerTick_Unbound");
		MaxCollisionSolverIterationsPerTick_Unbound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxCollisionSolverIterationsPerTick_Unbound", Classes.FIntProperty);
		MaxPathSolverIterationsOnThread_Unbound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxPathSolverIterationsOnThread_Unbound");
		MaxPathSolverIterationsOnThread_Unbound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxPathSolverIterationsOnThread_Unbound", Classes.FIntProperty);
		MaxCollisionSolverIterationsOnThread_Unbound_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxCollisionSolverIterationsOnThread_Unbound");
		MaxCollisionSolverIterationsOnThread_Unbound_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxCollisionSolverIterationsOnThread_Unbound", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref DisplayWorldBoundary_PropertyAddress, intPtr, "bDisplayWorldBoundary");
		DisplayWorldBoundary_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisplayWorldBoundary");
		DisplayWorldBoundary_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisplayWorldBoundary", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisplayWorldBoundaryInGame_PropertyAddress, intPtr, "bDisplayWorldBoundaryInGame");
		DisplayWorldBoundaryInGame_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisplayWorldBoundaryInGame");
		DisplayWorldBoundaryInGame_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisplayWorldBoundaryInGame", Classes.FBoolProperty);
		DebugVoxelsLineThickness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DebugVoxelsLineThickness");
		DebugVoxelsLineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DebugVoxelsLineThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RunDebugValidationsForDynamicCollisions_PropertyAddress, intPtr, "bRunDebugValidationsForDynamicCollisions");
		RunDebugValidationsForDynamicCollisions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRunDebugValidationsForDynamicCollisions");
		RunDebugValidationsForDynamicCollisions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRunDebugValidationsForDynamicCollisions", Classes.FBoolProperty);
		VisualizeNavResult_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "VisualizeNavResult");
		VisualizeNavResult_ParamsSize = NativeReflection.GetFunctionParamsSize(VisualizeNavResult_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VisualizeNavResult_PathSolution_PropertyAddress, VisualizeNavResult_FunctionAddress, "PathSolution");
		VisualizeNavResult_PathSolution_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeNavResult_FunctionAddress, "PathSolution");
		VisualizeNavResult_PathSolution_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeNavResult_FunctionAddress, "PathSolution", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeNavResult_Source_PropertyAddress, VisualizeNavResult_FunctionAddress, "Source");
		VisualizeNavResult_Source_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeNavResult_FunctionAddress, "Source");
		VisualizeNavResult_Source_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeNavResult_FunctionAddress, "Source", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeNavResult_Destination_PropertyAddress, VisualizeNavResult_FunctionAddress, "Destination");
		VisualizeNavResult_Destination_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeNavResult_FunctionAddress, "Destination");
		VisualizeNavResult_Destination_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeNavResult_FunctionAddress, "Destination", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeNavResult_Reset_PropertyAddress, VisualizeNavResult_FunctionAddress, "Reset");
		VisualizeNavResult_Reset_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeNavResult_FunctionAddress, "Reset");
		VisualizeNavResult_Reset_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeNavResult_FunctionAddress, "Reset", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeNavResult_DebugParams_PropertyAddress, VisualizeNavResult_FunctionAddress, "DebugParams");
		VisualizeNavResult_DebugParams_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeNavResult_FunctionAddress, "DebugParams");
		VisualizeNavResult_DebugParams_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeNavResult_FunctionAddress, "DebugParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeNavResult_LineColor_PropertyAddress, VisualizeNavResult_FunctionAddress, "LineColor");
		VisualizeNavResult_LineColor_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeNavResult_FunctionAddress, "LineColor");
		VisualizeNavResult_LineColor_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeNavResult_FunctionAddress, "LineColor", Classes.FStructProperty);
		VisualizeNavResult_IsValid = VisualizeNavResult_FunctionAddress != IntPtr.Zero && VisualizeNavResult_PathSolution_IsValid && VisualizeNavResult_Source_IsValid && VisualizeNavResult_Destination_IsValid && VisualizeNavResult_Reset_IsValid && VisualizeNavResult_DebugParams_IsValid && VisualizeNavResult_LineColor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:VisualizeNavResult", VisualizeNavResult_IsValid);
		VisualizeDynamicCollisionListeners_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "VisualizeDynamicCollisionListeners");
		VisualizeDynamicCollisionListeners_ParamsSize = NativeReflection.GetFunctionParamsSize(VisualizeDynamicCollisionListeners_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref VisualizeDynamicCollisionListeners_Listener_PropertyAddress, VisualizeDynamicCollisionListeners_FunctionAddress, "Listener");
		VisualizeDynamicCollisionListeners_Listener_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeDynamicCollisionListeners_FunctionAddress, "Listener");
		VisualizeDynamicCollisionListeners_Listener_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeDynamicCollisionListeners_FunctionAddress, "Listener", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref VisualizeDynamicCollisionListeners_QueryData_PropertyAddress, VisualizeDynamicCollisionListeners_FunctionAddress, "QueryData");
		VisualizeDynamicCollisionListeners_QueryData_Offset = NativeReflectionCached.GetPropertyOffset(VisualizeDynamicCollisionListeners_FunctionAddress, "QueryData");
		VisualizeDynamicCollisionListeners_QueryData_IsValid = NativeReflectionCached.ValidatePropertyClass(VisualizeDynamicCollisionListeners_FunctionAddress, "QueryData", Classes.FStructProperty);
		VisualizeDynamicCollisionListeners_IsValid = VisualizeDynamicCollisionListeners_FunctionAddress != IntPtr.Zero && VisualizeDynamicCollisionListeners_Listener_IsValid && VisualizeDynamicCollisionListeners_QueryData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:VisualizeDynamicCollisionListeners", VisualizeDynamicCollisionListeners_IsValid);
		StopListeningToDynamicCollisionsForPathIndex_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopListeningToDynamicCollisionsForPathIndex");
		StopListeningToDynamicCollisionsForPathIndex_ParamsSize = NativeReflection.GetFunctionParamsSize(StopListeningToDynamicCollisionsForPathIndex_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_PropertyAddress, StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "ListenerToClear");
		StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_Offset = NativeReflectionCached.GetPropertyOffset(StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "ListenerToClear");
		StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_IsValid = NativeReflectionCached.ValidatePropertyClass(StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "ListenerToClear", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref StopListeningToDynamicCollisionsForPathIndex_QueryData_PropertyAddress, StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "QueryData");
		StopListeningToDynamicCollisionsForPathIndex_QueryData_Offset = NativeReflectionCached.GetPropertyOffset(StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "QueryData");
		StopListeningToDynamicCollisionsForPathIndex_QueryData_IsValid = NativeReflectionCached.ValidatePropertyClass(StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "QueryData", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_PropertyAddress, StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "VolumeIndex");
		StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_Offset = NativeReflectionCached.GetPropertyOffset(StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "VolumeIndex");
		StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(StopListeningToDynamicCollisionsForPathIndex_FunctionAddress, "VolumeIndex", Classes.FIntProperty);
		StopListeningToDynamicCollisionsForPathIndex_IsValid = StopListeningToDynamicCollisionsForPathIndex_FunctionAddress != IntPtr.Zero && StopListeningToDynamicCollisionsForPathIndex_ListenerToClear_IsValid && StopListeningToDynamicCollisionsForPathIndex_QueryData_IsValid && StopListeningToDynamicCollisionsForPathIndex_VolumeIndex_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:StopListeningToDynamicCollisionsForPathIndex", StopListeningToDynamicCollisionsForPathIndex_IsValid);
		StopListeningToDynamicCollisionsForPath_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopListeningToDynamicCollisionsForPath");
		StopListeningToDynamicCollisionsForPath_ParamsSize = NativeReflection.GetFunctionParamsSize(StopListeningToDynamicCollisionsForPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopListeningToDynamicCollisionsForPath_ListenerToClear_PropertyAddress, StopListeningToDynamicCollisionsForPath_FunctionAddress, "ListenerToClear");
		StopListeningToDynamicCollisionsForPath_ListenerToClear_Offset = NativeReflectionCached.GetPropertyOffset(StopListeningToDynamicCollisionsForPath_FunctionAddress, "ListenerToClear");
		StopListeningToDynamicCollisionsForPath_ListenerToClear_IsValid = NativeReflectionCached.ValidatePropertyClass(StopListeningToDynamicCollisionsForPath_FunctionAddress, "ListenerToClear", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref StopListeningToDynamicCollisionsForPath_QueryData_PropertyAddress, StopListeningToDynamicCollisionsForPath_FunctionAddress, "QueryData");
		StopListeningToDynamicCollisionsForPath_QueryData_Offset = NativeReflectionCached.GetPropertyOffset(StopListeningToDynamicCollisionsForPath_FunctionAddress, "QueryData");
		StopListeningToDynamicCollisionsForPath_QueryData_IsValid = NativeReflectionCached.ValidatePropertyClass(StopListeningToDynamicCollisionsForPath_FunctionAddress, "QueryData", Classes.FStructProperty);
		StopListeningToDynamicCollisionsForPath_IsValid = StopListeningToDynamicCollisionsForPath_FunctionAddress != IntPtr.Zero && StopListeningToDynamicCollisionsForPath_ListenerToClear_IsValid && StopListeningToDynamicCollisionsForPath_QueryData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:StopListeningToDynamicCollisionsForPath", StopListeningToDynamicCollisionsForPath_IsValid);
		SchedulePathfindingTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SchedulePathfindingTask");
		SchedulePathfindingTask_ParamsSize = NativeReflection.GetFunctionParamsSize(SchedulePathfindingTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SchedulePathfindingTask_Actor_PropertyAddress, SchedulePathfindingTask_FunctionAddress, "Actor");
		SchedulePathfindingTask_Actor_Offset = NativeReflectionCached.GetPropertyOffset(SchedulePathfindingTask_FunctionAddress, "Actor");
		SchedulePathfindingTask_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(SchedulePathfindingTask_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SchedulePathfindingTask_Destination_PropertyAddress, SchedulePathfindingTask_FunctionAddress, "Destination");
		SchedulePathfindingTask_Destination_Offset = NativeReflectionCached.GetPropertyOffset(SchedulePathfindingTask_FunctionAddress, "Destination");
		SchedulePathfindingTask_Destination_IsValid = NativeReflectionCached.ValidatePropertyClass(SchedulePathfindingTask_FunctionAddress, "Destination", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SchedulePathfindingTask_QueryParams_PropertyAddress, SchedulePathfindingTask_FunctionAddress, "QueryParams");
		SchedulePathfindingTask_QueryParams_Offset = NativeReflectionCached.GetPropertyOffset(SchedulePathfindingTask_FunctionAddress, "QueryParams");
		SchedulePathfindingTask_QueryParams_IsValid = NativeReflectionCached.ValidatePropertyClass(SchedulePathfindingTask_FunctionAddress, "QueryParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SchedulePathfindingTask_DebugParams_PropertyAddress, SchedulePathfindingTask_FunctionAddress, "DebugParams");
		SchedulePathfindingTask_DebugParams_Offset = NativeReflectionCached.GetPropertyOffset(SchedulePathfindingTask_FunctionAddress, "DebugParams");
		SchedulePathfindingTask_DebugParams_IsValid = NativeReflectionCached.ValidatePropertyClass(SchedulePathfindingTask_FunctionAddress, "DebugParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SchedulePathfindingTask_ResultHandlerDelegate_PropertyAddress, SchedulePathfindingTask_FunctionAddress, "ResultHandlerDelegate");
		SchedulePathfindingTask_ResultHandlerDelegate_Offset = NativeReflectionCached.GetPropertyOffset(SchedulePathfindingTask_FunctionAddress, "ResultHandlerDelegate");
		SchedulePathfindingTask_ResultHandlerDelegate_IsValid = NativeReflectionCached.ValidatePropertyClass(SchedulePathfindingTask_FunctionAddress, "ResultHandlerDelegate", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SchedulePathfindingTask_DynamicCollisionListener_PropertyAddress, SchedulePathfindingTask_FunctionAddress, "DynamicCollisionListener");
		SchedulePathfindingTask_DynamicCollisionListener_Offset = NativeReflectionCached.GetPropertyOffset(SchedulePathfindingTask_FunctionAddress, "DynamicCollisionListener");
		SchedulePathfindingTask_DynamicCollisionListener_IsValid = NativeReflectionCached.ValidatePropertyClass(SchedulePathfindingTask_FunctionAddress, "DynamicCollisionListener", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref SchedulePathfindingTask_ReturnValue_PropertyAddress, SchedulePathfindingTask_FunctionAddress, "ReturnValue");
		SchedulePathfindingTask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SchedulePathfindingTask_FunctionAddress, "ReturnValue");
		SchedulePathfindingTask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SchedulePathfindingTask_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SchedulePathfindingTask_IsValid = SchedulePathfindingTask_FunctionAddress != IntPtr.Zero && SchedulePathfindingTask_Actor_IsValid && SchedulePathfindingTask_Destination_IsValid && SchedulePathfindingTask_QueryParams_IsValid && SchedulePathfindingTask_DebugParams_IsValid && SchedulePathfindingTask_ResultHandlerDelegate_IsValid && SchedulePathfindingTask_DynamicCollisionListener_IsValid && SchedulePathfindingTask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:SchedulePathfindingTask", SchedulePathfindingTask_IsValid);
		ScheduleDynamicCollisionUpdate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ScheduleDynamicCollisionUpdate");
		ScheduleDynamicCollisionUpdate_ParamsSize = NativeReflection.GetFunctionParamsSize(ScheduleDynamicCollisionUpdate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_Mesh_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "Mesh");
		ScheduleDynamicCollisionUpdate_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "Mesh");
		ScheduleDynamicCollisionUpdate_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_ResultHandler_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "ResultHandler");
		ScheduleDynamicCollisionUpdate_ResultHandler_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "ResultHandler");
		ScheduleDynamicCollisionUpdate_ResultHandler_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "ResultHandler", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "CustomCacheIdentifier");
		ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "CustomCacheIdentifier");
		ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "CustomCacheIdentifier", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_bReplaceExistingTask_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "bReplaceExistingTask");
		ScheduleDynamicCollisionUpdate_bReplaceExistingTask_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "bReplaceExistingTask");
		ScheduleDynamicCollisionUpdate_bReplaceExistingTask_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "bReplaceExistingTask", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_bDisableCacheUsage_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "bDisableCacheUsage");
		ScheduleDynamicCollisionUpdate_bDisableCacheUsage_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "bDisableCacheUsage");
		ScheduleDynamicCollisionUpdate_bDisableCacheUsage_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "bDisableCacheUsage", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_bReloadCollisionCache_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "bReloadCollisionCache");
		ScheduleDynamicCollisionUpdate_bReloadCollisionCache_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "bReloadCollisionCache");
		ScheduleDynamicCollisionUpdate_bReloadCollisionCache_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "bReloadCollisionCache", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "bUseCheapBoundsCollision");
		ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "bUseCheapBoundsCollision");
		ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "bUseCheapBoundsCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_BoundsScaleFactor_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "BoundsScaleFactor");
		ScheduleDynamicCollisionUpdate_BoundsScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "BoundsScaleFactor");
		ScheduleDynamicCollisionUpdate_BoundsScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "BoundsScaleFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "bForceSynchronousExecution");
		ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "bForceSynchronousExecution");
		ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "bForceSynchronousExecution", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_bDrawDebug_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "bDrawDebug");
		ScheduleDynamicCollisionUpdate_bDrawDebug_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "bDrawDebug");
		ScheduleDynamicCollisionUpdate_bDrawDebug_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "bDrawDebug", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ScheduleDynamicCollisionUpdate_ReturnValue_PropertyAddress, ScheduleDynamicCollisionUpdate_FunctionAddress, "ReturnValue");
		ScheduleDynamicCollisionUpdate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ScheduleDynamicCollisionUpdate_FunctionAddress, "ReturnValue");
		ScheduleDynamicCollisionUpdate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ScheduleDynamicCollisionUpdate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ScheduleDynamicCollisionUpdate_IsValid = ScheduleDynamicCollisionUpdate_FunctionAddress != IntPtr.Zero && ScheduleDynamicCollisionUpdate_Mesh_IsValid && ScheduleDynamicCollisionUpdate_ResultHandler_IsValid && ScheduleDynamicCollisionUpdate_CustomCacheIdentifier_IsValid && ScheduleDynamicCollisionUpdate_bReplaceExistingTask_IsValid && ScheduleDynamicCollisionUpdate_bDisableCacheUsage_IsValid && ScheduleDynamicCollisionUpdate_bReloadCollisionCache_IsValid && ScheduleDynamicCollisionUpdate_bUseCheapBoundsCollision_IsValid && ScheduleDynamicCollisionUpdate_BoundsScaleFactor_IsValid && ScheduleDynamicCollisionUpdate_bForceSynchronousExecution_IsValid && ScheduleDynamicCollisionUpdate_bDrawDebug_IsValid && ScheduleDynamicCollisionUpdate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:ScheduleDynamicCollisionUpdate", ScheduleDynamicCollisionUpdate_IsValid);
		NavPathQuery_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "NavPathQuery");
		NavPathQuery_ParamsSize = NativeReflection.GetFunctionParamsSize(NavPathQuery_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NavPathQuery_Actor_PropertyAddress, NavPathQuery_FunctionAddress, "Actor");
		NavPathQuery_Actor_Offset = NativeReflectionCached.GetPropertyOffset(NavPathQuery_FunctionAddress, "Actor");
		NavPathQuery_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(NavPathQuery_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref NavPathQuery_Destination_PropertyAddress, NavPathQuery_FunctionAddress, "Destination");
		NavPathQuery_Destination_Offset = NativeReflectionCached.GetPropertyOffset(NavPathQuery_FunctionAddress, "Destination");
		NavPathQuery_Destination_IsValid = NativeReflectionCached.ValidatePropertyClass(NavPathQuery_FunctionAddress, "Destination", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NavPathQuery_MaxIterations_PropertyAddress, NavPathQuery_FunctionAddress, "MaxIterations");
		NavPathQuery_MaxIterations_Offset = NativeReflectionCached.GetPropertyOffset(NavPathQuery_FunctionAddress, "MaxIterations");
		NavPathQuery_MaxIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(NavPathQuery_FunctionAddress, "MaxIterations", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NavPathQuery_OutResult_PropertyAddress, NavPathQuery_FunctionAddress, "OutResult");
		NavPathQuery_OutResult_Offset = NativeReflectionCached.GetPropertyOffset(NavPathQuery_FunctionAddress, "OutResult");
		NavPathQuery_OutResult_IsValid = NativeReflectionCached.ValidatePropertyClass(NavPathQuery_FunctionAddress, "OutResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref NavPathQuery_ReturnValue_PropertyAddress, NavPathQuery_FunctionAddress, "ReturnValue");
		NavPathQuery_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NavPathQuery_FunctionAddress, "ReturnValue");
		NavPathQuery_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NavPathQuery_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		NavPathQuery_IsValid = NavPathQuery_FunctionAddress != IntPtr.Zero && NavPathQuery_Actor_IsValid && NavPathQuery_Destination_IsValid && NavPathQuery_MaxIterations_IsValid && NavPathQuery_OutResult_IsValid && NavPathQuery_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:NavPathQuery", NavPathQuery_IsValid);
		IsMeshBoundsWithinNavigableWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsMeshBoundsWithinNavigableWorld");
		IsMeshBoundsWithinNavigableWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(IsMeshBoundsWithinNavigableWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsMeshBoundsWithinNavigableWorld_Mesh_PropertyAddress, IsMeshBoundsWithinNavigableWorld_FunctionAddress, "Mesh");
		IsMeshBoundsWithinNavigableWorld_Mesh_Offset = NativeReflectionCached.GetPropertyOffset(IsMeshBoundsWithinNavigableWorld_FunctionAddress, "Mesh");
		IsMeshBoundsWithinNavigableWorld_Mesh_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMeshBoundsWithinNavigableWorld_FunctionAddress, "Mesh", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_PropertyAddress, IsMeshBoundsWithinNavigableWorld_FunctionAddress, "BoundsScaleFactor");
		IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_Offset = NativeReflectionCached.GetPropertyOffset(IsMeshBoundsWithinNavigableWorld_FunctionAddress, "BoundsScaleFactor");
		IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMeshBoundsWithinNavigableWorld_FunctionAddress, "BoundsScaleFactor", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsMeshBoundsWithinNavigableWorld_ReturnValue_PropertyAddress, IsMeshBoundsWithinNavigableWorld_FunctionAddress, "ReturnValue");
		IsMeshBoundsWithinNavigableWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsMeshBoundsWithinNavigableWorld_FunctionAddress, "ReturnValue");
		IsMeshBoundsWithinNavigableWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsMeshBoundsWithinNavigableWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsMeshBoundsWithinNavigableWorld_IsValid = IsMeshBoundsWithinNavigableWorld_FunctionAddress != IntPtr.Zero && IsMeshBoundsWithinNavigableWorld_Mesh_IsValid && IsMeshBoundsWithinNavigableWorld_BoundsScaleFactor_IsValid && IsMeshBoundsWithinNavigableWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:IsMeshBoundsWithinNavigableWorld", IsMeshBoundsWithinNavigableWorld_IsValid);
		IsLocationWithinNavigableWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLocationWithinNavigableWorld");
		IsLocationWithinNavigableWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocationWithinNavigableWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocationWithinNavigableWorld_DesiredLocation_PropertyAddress, IsLocationWithinNavigableWorld_FunctionAddress, "DesiredLocation");
		IsLocationWithinNavigableWorld_DesiredLocation_Offset = NativeReflectionCached.GetPropertyOffset(IsLocationWithinNavigableWorld_FunctionAddress, "DesiredLocation");
		IsLocationWithinNavigableWorld_DesiredLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocationWithinNavigableWorld_FunctionAddress, "DesiredLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLocationWithinNavigableWorld_ReturnValue_PropertyAddress, IsLocationWithinNavigableWorld_FunctionAddress, "ReturnValue");
		IsLocationWithinNavigableWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocationWithinNavigableWorld_FunctionAddress, "ReturnValue");
		IsLocationWithinNavigableWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocationWithinNavigableWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocationWithinNavigableWorld_IsValid = IsLocationWithinNavigableWorld_FunctionAddress != IntPtr.Zero && IsLocationWithinNavigableWorld_DesiredLocation_IsValid && IsLocationWithinNavigableWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:IsLocationWithinNavigableWorld", IsLocationWithinNavigableWorld_IsValid);
		IsLocationBeneathLandscape_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsLocationBeneathLandscape");
		IsLocationBeneathLandscape_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLocationBeneathLandscape_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLocationBeneathLandscape_Location_PropertyAddress, IsLocationBeneathLandscape_FunctionAddress, "Location");
		IsLocationBeneathLandscape_Location_Offset = NativeReflectionCached.GetPropertyOffset(IsLocationBeneathLandscape_FunctionAddress, "Location");
		IsLocationBeneathLandscape_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocationBeneathLandscape_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLocationBeneathLandscape_LineTraceHeight_PropertyAddress, IsLocationBeneathLandscape_FunctionAddress, "LineTraceHeight");
		IsLocationBeneathLandscape_LineTraceHeight_Offset = NativeReflectionCached.GetPropertyOffset(IsLocationBeneathLandscape_FunctionAddress, "LineTraceHeight");
		IsLocationBeneathLandscape_LineTraceHeight_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocationBeneathLandscape_FunctionAddress, "LineTraceHeight", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsLocationBeneathLandscape_ReturnValue_PropertyAddress, IsLocationBeneathLandscape_FunctionAddress, "ReturnValue");
		IsLocationBeneathLandscape_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLocationBeneathLandscape_FunctionAddress, "ReturnValue");
		IsLocationBeneathLandscape_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLocationBeneathLandscape_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLocationBeneathLandscape_IsValid = IsLocationBeneathLandscape_FunctionAddress != IntPtr.Zero && IsLocationBeneathLandscape_Location_IsValid && IsLocationBeneathLandscape_LineTraceHeight_IsValid && IsLocationBeneathLandscape_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:IsLocationBeneathLandscape", IsLocationBeneathLandscape_IsValid);
		IsDirectPathSweep_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDirectPathSweep");
		IsDirectPathSweep_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDirectPathSweep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathSweep_CollisionComponent_PropertyAddress, IsDirectPathSweep_FunctionAddress, "CollisionComponent");
		IsDirectPathSweep_CollisionComponent_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathSweep_FunctionAddress, "CollisionComponent");
		IsDirectPathSweep_CollisionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathSweep_FunctionAddress, "CollisionComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathSweep_Start_PropertyAddress, IsDirectPathSweep_FunctionAddress, "Start");
		IsDirectPathSweep_Start_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathSweep_FunctionAddress, "Start");
		IsDirectPathSweep_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathSweep_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathSweep_End_PropertyAddress, IsDirectPathSweep_FunctionAddress, "End");
		IsDirectPathSweep_End_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathSweep_FunctionAddress, "End");
		IsDirectPathSweep_End_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathSweep_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathSweep_OutHit_PropertyAddress, IsDirectPathSweep_FunctionAddress, "OutHit");
		IsDirectPathSweep_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathSweep_FunctionAddress, "OutHit");
		IsDirectPathSweep_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathSweep_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathSweep_bFindInitialOverlaps_PropertyAddress, IsDirectPathSweep_FunctionAddress, "bFindInitialOverlaps");
		IsDirectPathSweep_bFindInitialOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathSweep_FunctionAddress, "bFindInitialOverlaps");
		IsDirectPathSweep_bFindInitialOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathSweep_FunctionAddress, "bFindInitialOverlaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathSweep_CollisionShapeInflation_PropertyAddress, IsDirectPathSweep_FunctionAddress, "CollisionShapeInflation");
		IsDirectPathSweep_CollisionShapeInflation_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathSweep_FunctionAddress, "CollisionShapeInflation");
		IsDirectPathSweep_CollisionShapeInflation_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathSweep_FunctionAddress, "CollisionShapeInflation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathSweep_ReturnValue_PropertyAddress, IsDirectPathSweep_FunctionAddress, "ReturnValue");
		IsDirectPathSweep_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathSweep_FunctionAddress, "ReturnValue");
		IsDirectPathSweep_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathSweep_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDirectPathSweep_IsValid = IsDirectPathSweep_FunctionAddress != IntPtr.Zero && IsDirectPathSweep_CollisionComponent_IsValid && IsDirectPathSweep_Start_IsValid && IsDirectPathSweep_End_IsValid && IsDirectPathSweep_OutHit_IsValid && IsDirectPathSweep_bFindInitialOverlaps_IsValid && IsDirectPathSweep_CollisionShapeInflation_IsValid && IsDirectPathSweep_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:IsDirectPathSweep", IsDirectPathSweep_IsValid);
		IsDirectPathLineTrace_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDirectPathLineTrace");
		IsDirectPathLineTrace_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDirectPathLineTrace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineTrace_Start_PropertyAddress, IsDirectPathLineTrace_FunctionAddress, "Start");
		IsDirectPathLineTrace_Start_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineTrace_FunctionAddress, "Start");
		IsDirectPathLineTrace_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineTrace_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineTrace_End_PropertyAddress, IsDirectPathLineTrace_FunctionAddress, "End");
		IsDirectPathLineTrace_End_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineTrace_FunctionAddress, "End");
		IsDirectPathLineTrace_End_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineTrace_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineTrace_OutHit_PropertyAddress, IsDirectPathLineTrace_FunctionAddress, "OutHit");
		IsDirectPathLineTrace_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineTrace_FunctionAddress, "OutHit");
		IsDirectPathLineTrace_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineTrace_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineTrace_ActorsToIgnore_PropertyAddress, IsDirectPathLineTrace_FunctionAddress, "ActorsToIgnore");
		IsDirectPathLineTrace_ActorsToIgnore_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineTrace_FunctionAddress, "ActorsToIgnore");
		IsDirectPathLineTrace_ActorsToIgnore_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineTrace_FunctionAddress, "ActorsToIgnore", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineTrace_bFindInitialOverlaps_PropertyAddress, IsDirectPathLineTrace_FunctionAddress, "bFindInitialOverlaps");
		IsDirectPathLineTrace_bFindInitialOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineTrace_FunctionAddress, "bFindInitialOverlaps");
		IsDirectPathLineTrace_bFindInitialOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineTrace_FunctionAddress, "bFindInitialOverlaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineTrace_ReturnValue_PropertyAddress, IsDirectPathLineTrace_FunctionAddress, "ReturnValue");
		IsDirectPathLineTrace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineTrace_FunctionAddress, "ReturnValue");
		IsDirectPathLineTrace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineTrace_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDirectPathLineTrace_IsValid = IsDirectPathLineTrace_FunctionAddress != IntPtr.Zero && IsDirectPathLineTrace_Start_IsValid && IsDirectPathLineTrace_End_IsValid && IsDirectPathLineTrace_OutHit_IsValid && IsDirectPathLineTrace_ActorsToIgnore_IsValid && IsDirectPathLineTrace_bFindInitialOverlaps_IsValid && IsDirectPathLineTrace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:IsDirectPathLineTrace", IsDirectPathLineTrace_IsValid);
		IsDirectPathLineSweep_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsDirectPathLineSweep");
		IsDirectPathLineSweep_ParamsSize = NativeReflection.GetFunctionParamsSize(IsDirectPathLineSweep_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineSweep_CollisionComponent_PropertyAddress, IsDirectPathLineSweep_FunctionAddress, "CollisionComponent");
		IsDirectPathLineSweep_CollisionComponent_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineSweep_FunctionAddress, "CollisionComponent");
		IsDirectPathLineSweep_CollisionComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineSweep_FunctionAddress, "CollisionComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineSweep_Start_PropertyAddress, IsDirectPathLineSweep_FunctionAddress, "Start");
		IsDirectPathLineSweep_Start_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineSweep_FunctionAddress, "Start");
		IsDirectPathLineSweep_Start_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineSweep_FunctionAddress, "Start", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineSweep_End_PropertyAddress, IsDirectPathLineSweep_FunctionAddress, "End");
		IsDirectPathLineSweep_End_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineSweep_FunctionAddress, "End");
		IsDirectPathLineSweep_End_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineSweep_FunctionAddress, "End", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineSweep_OutHit_PropertyAddress, IsDirectPathLineSweep_FunctionAddress, "OutHit");
		IsDirectPathLineSweep_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineSweep_FunctionAddress, "OutHit");
		IsDirectPathLineSweep_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineSweep_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineSweep_bFindInitialOverlaps_PropertyAddress, IsDirectPathLineSweep_FunctionAddress, "bFindInitialOverlaps");
		IsDirectPathLineSweep_bFindInitialOverlaps_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineSweep_FunctionAddress, "bFindInitialOverlaps");
		IsDirectPathLineSweep_bFindInitialOverlaps_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineSweep_FunctionAddress, "bFindInitialOverlaps", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineSweep_CollisionShapeInflation_PropertyAddress, IsDirectPathLineSweep_FunctionAddress, "CollisionShapeInflation");
		IsDirectPathLineSweep_CollisionShapeInflation_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineSweep_FunctionAddress, "CollisionShapeInflation");
		IsDirectPathLineSweep_CollisionShapeInflation_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineSweep_FunctionAddress, "CollisionShapeInflation", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsDirectPathLineSweep_ReturnValue_PropertyAddress, IsDirectPathLineSweep_FunctionAddress, "ReturnValue");
		IsDirectPathLineSweep_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsDirectPathLineSweep_FunctionAddress, "ReturnValue");
		IsDirectPathLineSweep_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsDirectPathLineSweep_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsDirectPathLineSweep_IsValid = IsDirectPathLineSweep_FunctionAddress != IntPtr.Zero && IsDirectPathLineSweep_CollisionComponent_IsValid && IsDirectPathLineSweep_Start_IsValid && IsDirectPathLineSweep_End_IsValid && IsDirectPathLineSweep_OutHit_IsValid && IsDirectPathLineSweep_bFindInitialOverlaps_IsValid && IsDirectPathLineSweep_CollisionShapeInflation_IsValid && IsDirectPathLineSweep_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:IsDirectPathLineSweep", IsDirectPathLineSweep_IsValid);
		HasTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HasTask");
		HasTask_ParamsSize = NativeReflection.GetFunctionParamsSize(HasTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasTask_Actor_PropertyAddress, HasTask_FunctionAddress, "Actor");
		HasTask_Actor_Offset = NativeReflectionCached.GetPropertyOffset(HasTask_FunctionAddress, "Actor");
		HasTask_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTask_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HasTask_ReturnValue_PropertyAddress, HasTask_FunctionAddress, "ReturnValue");
		HasTask_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasTask_FunctionAddress, "ReturnValue");
		HasTask_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasTask_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasTask_IsValid = HasTask_FunctionAddress != IntPtr.Zero && HasTask_Actor_IsValid && HasTask_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:HasTask", HasTask_IsValid);
		FindRandomPointFromActorInNavWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindRandomPointFromActorInNavWorld");
		FindRandomPointFromActorInNavWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(FindRandomPointFromActorInNavWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointFromActorInNavWorld_Actor_PropertyAddress, FindRandomPointFromActorInNavWorld_FunctionAddress, "Actor");
		FindRandomPointFromActorInNavWorld_Actor_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointFromActorInNavWorld_FunctionAddress, "Actor");
		FindRandomPointFromActorInNavWorld_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointFromActorInNavWorld_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointFromActorInNavWorld_Distance_PropertyAddress, FindRandomPointFromActorInNavWorld_FunctionAddress, "Distance");
		FindRandomPointFromActorInNavWorld_Distance_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointFromActorInNavWorld_FunctionAddress, "Distance");
		FindRandomPointFromActorInNavWorld_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointFromActorInNavWorld_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointFromActorInNavWorld_bFoundValidResult_PropertyAddress, FindRandomPointFromActorInNavWorld_FunctionAddress, "bFoundValidResult");
		FindRandomPointFromActorInNavWorld_bFoundValidResult_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointFromActorInNavWorld_FunctionAddress, "bFoundValidResult");
		FindRandomPointFromActorInNavWorld_bFoundValidResult_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointFromActorInNavWorld_FunctionAddress, "bFoundValidResult", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_PropertyAddress, FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxDesiredAltitude");
		FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxDesiredAltitude");
		FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxDesiredAltitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_PropertyAddress, FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxZAngularDispacement");
		FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxZAngularDispacement");
		FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxZAngularDispacement", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointFromActorInNavWorld_MaxAttempts_PropertyAddress, FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxAttempts");
		FindRandomPointFromActorInNavWorld_MaxAttempts_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxAttempts");
		FindRandomPointFromActorInNavWorld_MaxAttempts_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointFromActorInNavWorld_FunctionAddress, "MaxAttempts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointFromActorInNavWorld_ReturnValue_PropertyAddress, FindRandomPointFromActorInNavWorld_FunctionAddress, "ReturnValue");
		FindRandomPointFromActorInNavWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointFromActorInNavWorld_FunctionAddress, "ReturnValue");
		FindRandomPointFromActorInNavWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointFromActorInNavWorld_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindRandomPointFromActorInNavWorld_IsValid = FindRandomPointFromActorInNavWorld_FunctionAddress != IntPtr.Zero && FindRandomPointFromActorInNavWorld_Actor_IsValid && FindRandomPointFromActorInNavWorld_Distance_IsValid && FindRandomPointFromActorInNavWorld_bFoundValidResult_IsValid && FindRandomPointFromActorInNavWorld_MaxDesiredAltitude_IsValid && FindRandomPointFromActorInNavWorld_MaxZAngularDispacement_IsValid && FindRandomPointFromActorInNavWorld_MaxAttempts_IsValid && FindRandomPointFromActorInNavWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:FindRandomPointFromActorInNavWorld", FindRandomPointFromActorInNavWorld_IsValid);
		FindRandomPointAroundOriginInNavWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindRandomPointAroundOriginInNavWorld");
		FindRandomPointAroundOriginInNavWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(FindRandomPointAroundOriginInNavWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_NavigationActor_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "NavigationActor");
		FindRandomPointAroundOriginInNavWorld_NavigationActor_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "NavigationActor");
		FindRandomPointAroundOriginInNavWorld_NavigationActor_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "NavigationActor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_Origin_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "Origin");
		FindRandomPointAroundOriginInNavWorld_Origin_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "Origin");
		FindRandomPointAroundOriginInNavWorld_Origin_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "Origin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_Distance_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "Distance");
		FindRandomPointAroundOriginInNavWorld_Distance_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "Distance");
		FindRandomPointAroundOriginInNavWorld_Distance_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "Distance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_bFoundValidResult_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "bFoundValidResult");
		FindRandomPointAroundOriginInNavWorld_bFoundValidResult_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "bFoundValidResult");
		FindRandomPointAroundOriginInNavWorld_bFoundValidResult_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "bFoundValidResult", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxDesiredAltitude");
		FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxDesiredAltitude");
		FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxDesiredAltitude", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxZAngularDispacement");
		FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxZAngularDispacement");
		FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxZAngularDispacement", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_MaxAttempts_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxAttempts");
		FindRandomPointAroundOriginInNavWorld_MaxAttempts_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxAttempts");
		FindRandomPointAroundOriginInNavWorld_MaxAttempts_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "MaxAttempts", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref FindRandomPointAroundOriginInNavWorld_ReturnValue_PropertyAddress, FindRandomPointAroundOriginInNavWorld_FunctionAddress, "ReturnValue");
		FindRandomPointAroundOriginInNavWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "ReturnValue");
		FindRandomPointAroundOriginInNavWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindRandomPointAroundOriginInNavWorld_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		FindRandomPointAroundOriginInNavWorld_IsValid = FindRandomPointAroundOriginInNavWorld_FunctionAddress != IntPtr.Zero && FindRandomPointAroundOriginInNavWorld_NavigationActor_IsValid && FindRandomPointAroundOriginInNavWorld_Origin_IsValid && FindRandomPointAroundOriginInNavWorld_Distance_IsValid && FindRandomPointAroundOriginInNavWorld_bFoundValidResult_IsValid && FindRandomPointAroundOriginInNavWorld_MaxDesiredAltitude_IsValid && FindRandomPointAroundOriginInNavWorld_MaxZAngularDispacement_IsValid && FindRandomPointAroundOriginInNavWorld_MaxAttempts_IsValid && FindRandomPointAroundOriginInNavWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:FindRandomPointAroundOriginInNavWorld", FindRandomPointAroundOriginInNavWorld_IsValid);
		FindPathSolution_StressTesting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "FindPathSolution_StressTesting");
		FindPathSolution_StressTesting_ParamsSize = NativeReflection.GetFunctionParamsSize(FindPathSolution_StressTesting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindPathSolution_StressTesting_Actor_PropertyAddress, FindPathSolution_StressTesting_FunctionAddress, "Actor");
		FindPathSolution_StressTesting_Actor_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSolution_StressTesting_FunctionAddress, "Actor");
		FindPathSolution_StressTesting_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSolution_StressTesting_FunctionAddress, "Actor", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSolution_StressTesting_Destination_PropertyAddress, FindPathSolution_StressTesting_FunctionAddress, "Destination");
		FindPathSolution_StressTesting_Destination_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSolution_StressTesting_FunctionAddress, "Destination");
		FindPathSolution_StressTesting_Destination_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSolution_StressTesting_FunctionAddress, "Destination", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSolution_StressTesting_PathSolutionRaw_PropertyAddress, FindPathSolution_StressTesting_FunctionAddress, "PathSolutionRaw");
		FindPathSolution_StressTesting_PathSolutionRaw_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSolution_StressTesting_FunctionAddress, "PathSolutionRaw");
		FindPathSolution_StressTesting_PathSolutionRaw_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSolution_StressTesting_FunctionAddress, "PathSolutionRaw", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSolution_StressTesting_PathSolutionOptimized_PropertyAddress, FindPathSolution_StressTesting_FunctionAddress, "PathSolutionOptimized");
		FindPathSolution_StressTesting_PathSolutionOptimized_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSolution_StressTesting_FunctionAddress, "PathSolutionOptimized");
		FindPathSolution_StressTesting_PathSolutionOptimized_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSolution_StressTesting_FunctionAddress, "PathSolutionOptimized", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSolution_StressTesting_QueryParams_PropertyAddress, FindPathSolution_StressTesting_FunctionAddress, "QueryParams");
		FindPathSolution_StressTesting_QueryParams_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSolution_StressTesting_FunctionAddress, "QueryParams");
		FindPathSolution_StressTesting_QueryParams_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSolution_StressTesting_FunctionAddress, "QueryParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSolution_StressTesting_DebugParams_PropertyAddress, FindPathSolution_StressTesting_FunctionAddress, "DebugParams");
		FindPathSolution_StressTesting_DebugParams_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSolution_StressTesting_FunctionAddress, "DebugParams");
		FindPathSolution_StressTesting_DebugParams_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSolution_StressTesting_FunctionAddress, "DebugParams", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindPathSolution_StressTesting_ReturnValue_PropertyAddress, FindPathSolution_StressTesting_FunctionAddress, "ReturnValue");
		FindPathSolution_StressTesting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindPathSolution_StressTesting_FunctionAddress, "ReturnValue");
		FindPathSolution_StressTesting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindPathSolution_StressTesting_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		FindPathSolution_StressTesting_IsValid = FindPathSolution_StressTesting_FunctionAddress != IntPtr.Zero && FindPathSolution_StressTesting_Actor_IsValid && FindPathSolution_StressTesting_Destination_IsValid && FindPathSolution_StressTesting_PathSolutionRaw_IsValid && FindPathSolution_StressTesting_PathSolutionOptimized_IsValid && FindPathSolution_StressTesting_QueryParams_IsValid && FindPathSolution_StressTesting_DebugParams_IsValid && FindPathSolution_StressTesting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:FindPathSolution_StressTesting", FindPathSolution_StressTesting_IsValid);
		Debug_ToggleWorldBoundaryInGame_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Debug_ToggleWorldBoundaryInGame");
		Debug_ToggleWorldBoundaryInGame_ParamsSize = NativeReflection.GetFunctionParamsSize(Debug_ToggleWorldBoundaryInGame_FunctionAddress);
		Debug_ToggleWorldBoundaryInGame_IsValid = Debug_ToggleWorldBoundaryInGame_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:Debug_ToggleWorldBoundaryInGame", Debug_ToggleWorldBoundaryInGame_IsValid);
		Debug_DrawVoxelCollisionProfile_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Debug_DrawVoxelCollisionProfile");
		Debug_DrawVoxelCollisionProfile_ParamsSize = NativeReflection.GetFunctionParamsSize(Debug_DrawVoxelCollisionProfile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_PropertyAddress, Debug_DrawVoxelCollisionProfile_FunctionAddress, "MeshOrPrimitive");
		Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVoxelCollisionProfile_FunctionAddress, "MeshOrPrimitive");
		Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVoxelCollisionProfile_FunctionAddress, "MeshOrPrimitive", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVoxelCollisionProfile_bDrawPersistent_PropertyAddress, Debug_DrawVoxelCollisionProfile_FunctionAddress, "bDrawPersistent");
		Debug_DrawVoxelCollisionProfile_bDrawPersistent_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVoxelCollisionProfile_FunctionAddress, "bDrawPersistent");
		Debug_DrawVoxelCollisionProfile_bDrawPersistent_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVoxelCollisionProfile_FunctionAddress, "bDrawPersistent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVoxelCollisionProfile_Duration_PropertyAddress, Debug_DrawVoxelCollisionProfile_FunctionAddress, "Duration");
		Debug_DrawVoxelCollisionProfile_Duration_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVoxelCollisionProfile_FunctionAddress, "Duration");
		Debug_DrawVoxelCollisionProfile_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVoxelCollisionProfile_FunctionAddress, "Duration", Classes.FFloatProperty);
		Debug_DrawVoxelCollisionProfile_IsValid = Debug_DrawVoxelCollisionProfile_FunctionAddress != IntPtr.Zero && Debug_DrawVoxelCollisionProfile_MeshOrPrimitive_IsValid && Debug_DrawVoxelCollisionProfile_bDrawPersistent_IsValid && Debug_DrawVoxelCollisionProfile_Duration_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:Debug_DrawVoxelCollisionProfile", Debug_DrawVoxelCollisionProfile_IsValid);
		Debug_DrawVolumesAroundPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Debug_DrawVolumesAroundPoint");
		Debug_DrawVolumesAroundPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(Debug_DrawVolumesAroundPoint_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVolumesAroundPoint_Location_PropertyAddress, Debug_DrawVolumesAroundPoint_FunctionAddress, "Location");
		Debug_DrawVolumesAroundPoint_Location_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVolumesAroundPoint_FunctionAddress, "Location");
		Debug_DrawVolumesAroundPoint_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVolumesAroundPoint_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVolumesAroundPoint_CubeSize_PropertyAddress, Debug_DrawVolumesAroundPoint_FunctionAddress, "CubeSize");
		Debug_DrawVolumesAroundPoint_CubeSize_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVolumesAroundPoint_FunctionAddress, "CubeSize");
		Debug_DrawVolumesAroundPoint_CubeSize_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVolumesAroundPoint_FunctionAddress, "CubeSize", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVolumesAroundPoint_DrawPersistentLines_PropertyAddress, Debug_DrawVolumesAroundPoint_FunctionAddress, "DrawPersistentLines");
		Debug_DrawVolumesAroundPoint_DrawPersistentLines_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVolumesAroundPoint_FunctionAddress, "DrawPersistentLines");
		Debug_DrawVolumesAroundPoint_DrawPersistentLines_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVolumesAroundPoint_FunctionAddress, "DrawPersistentLines", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVolumesAroundPoint_Duration_PropertyAddress, Debug_DrawVolumesAroundPoint_FunctionAddress, "Duration");
		Debug_DrawVolumesAroundPoint_Duration_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVolumesAroundPoint_FunctionAddress, "Duration");
		Debug_DrawVolumesAroundPoint_Duration_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVolumesAroundPoint_FunctionAddress, "Duration", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVolumesAroundPoint_LineThickness_PropertyAddress, Debug_DrawVolumesAroundPoint_FunctionAddress, "LineThickness");
		Debug_DrawVolumesAroundPoint_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVolumesAroundPoint_FunctionAddress, "LineThickness");
		Debug_DrawVolumesAroundPoint_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVolumesAroundPoint_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_PropertyAddress, Debug_DrawVolumesAroundPoint_FunctionAddress, "bAutoInitializeVolumes");
		Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawVolumesAroundPoint_FunctionAddress, "bAutoInitializeVolumes");
		Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawVolumesAroundPoint_FunctionAddress, "bAutoInitializeVolumes", Classes.FBoolProperty);
		Debug_DrawVolumesAroundPoint_IsValid = Debug_DrawVolumesAroundPoint_FunctionAddress != IntPtr.Zero && Debug_DrawVolumesAroundPoint_Location_IsValid && Debug_DrawVolumesAroundPoint_CubeSize_IsValid && Debug_DrawVolumesAroundPoint_DrawPersistentLines_IsValid && Debug_DrawVolumesAroundPoint_Duration_IsValid && Debug_DrawVolumesAroundPoint_LineThickness_IsValid && Debug_DrawVolumesAroundPoint_bAutoInitializeVolumes_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:Debug_DrawVolumesAroundPoint", Debug_DrawVolumesAroundPoint_IsValid);
		Debug_DrawAllVolumes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Debug_DrawAllVolumes");
		Debug_DrawAllVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(Debug_DrawAllVolumes_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Debug_DrawAllVolumes_LineThickness_PropertyAddress, Debug_DrawAllVolumes_FunctionAddress, "LineThickness");
		Debug_DrawAllVolumes_LineThickness_Offset = NativeReflectionCached.GetPropertyOffset(Debug_DrawAllVolumes_FunctionAddress, "LineThickness");
		Debug_DrawAllVolumes_LineThickness_IsValid = NativeReflectionCached.ValidatePropertyClass(Debug_DrawAllVolumes_FunctionAddress, "LineThickness", Classes.FFloatProperty);
		Debug_DrawAllVolumes_IsValid = Debug_DrawAllVolumes_FunctionAddress != IntPtr.Zero && Debug_DrawAllVolumes_LineThickness_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:Debug_DrawAllVolumes", Debug_DrawAllVolumes_IsValid);
		Debug_ClearAllVolumes_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Debug_ClearAllVolumes");
		Debug_ClearAllVolumes_ParamsSize = NativeReflection.GetFunctionParamsSize(Debug_ClearAllVolumes_FunctionAddress);
		Debug_ClearAllVolumes_IsValid = Debug_ClearAllVolumes_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:Debug_ClearAllVolumes", Debug_ClearAllVolumes_IsValid);
		ConstructBuilder_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstructBuilder");
		ConstructBuilder_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstructBuilder_FunctionAddress);
		ConstructBuilder_IsValid = ConstructBuilder_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:ConstructBuilder", ConstructBuilder_IsValid);
		ClampLocationToNavigableWorld_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ClampLocationToNavigableWorld");
		ClampLocationToNavigableWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(ClampLocationToNavigableWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClampLocationToNavigableWorld_DesiredLocation_PropertyAddress, ClampLocationToNavigableWorld_FunctionAddress, "DesiredLocation");
		ClampLocationToNavigableWorld_DesiredLocation_Offset = NativeReflectionCached.GetPropertyOffset(ClampLocationToNavigableWorld_FunctionAddress, "DesiredLocation");
		ClampLocationToNavigableWorld_DesiredLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(ClampLocationToNavigableWorld_FunctionAddress, "DesiredLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClampLocationToNavigableWorld_ReturnValue_PropertyAddress, ClampLocationToNavigableWorld_FunctionAddress, "ReturnValue");
		ClampLocationToNavigableWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClampLocationToNavigableWorld_FunctionAddress, "ReturnValue");
		ClampLocationToNavigableWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClampLocationToNavigableWorld_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ClampLocationToNavigableWorld_IsValid = ClampLocationToNavigableWorld_FunctionAddress != IntPtr.Zero && ClampLocationToNavigableWorld_DesiredLocation_IsValid && ClampLocationToNavigableWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:ClampLocationToNavigableWorld", ClampLocationToNavigableWorld_IsValid);
		CanNavigate_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CanNavigate");
		CanNavigate_ParamsSize = NativeReflection.GetFunctionParamsSize(CanNavigate_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CanNavigate_Location_PropertyAddress, CanNavigate_FunctionAddress, "Location");
		CanNavigate_Location_Offset = NativeReflectionCached.GetPropertyOffset(CanNavigate_FunctionAddress, "Location");
		CanNavigate_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(CanNavigate_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref CanNavigate_ReturnValue_PropertyAddress, CanNavigate_FunctionAddress, "ReturnValue");
		CanNavigate_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CanNavigate_FunctionAddress, "ReturnValue");
		CanNavigate_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CanNavigate_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CanNavigate_IsValid = CanNavigate_FunctionAddress != IntPtr.Zero && CanNavigate_Location_IsValid && CanNavigate_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:CanNavigate", CanNavigate_IsValid);
		AbortPathfindingTask_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AbortPathfindingTask");
		AbortPathfindingTask_ParamsSize = NativeReflection.GetFunctionParamsSize(AbortPathfindingTask_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AbortPathfindingTask_Actor_PropertyAddress, AbortPathfindingTask_FunctionAddress, "Actor");
		AbortPathfindingTask_Actor_Offset = NativeReflectionCached.GetPropertyOffset(AbortPathfindingTask_FunctionAddress, "Actor");
		AbortPathfindingTask_Actor_IsValid = NativeReflectionCached.ValidatePropertyClass(AbortPathfindingTask_FunctionAddress, "Actor", Classes.FObjectProperty);
		AbortPathfindingTask_IsValid = AbortPathfindingTask_FunctionAddress != IntPtr.Zero && AbortPathfindingTask_Actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DonAINavigation.DonNavigationManager:AbortPathfindingTask", AbortPathfindingTask_IsValid);
	}
}
