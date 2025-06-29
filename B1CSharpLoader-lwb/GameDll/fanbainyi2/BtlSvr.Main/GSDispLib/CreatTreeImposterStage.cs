namespace GSDispLib;

public enum CreatTreeImposterStage
{
	CleanLastMeshMemoryResource,
	SetCurrentTask,
	CreateHDAInstance,
	WaitHDABuildOver,
	CreateSceneShotToolActor,
	RenderPBRTexture,
	RenderShadowMask,
	ImportSceneShot,
	WaitAfterImportSceneShotOver,
	CombineFinalTex,
	CreatImposterMat,
	ShowCompare,
	SaveImposterCardMesh,
	SetLOD,
	SetLastMeshInfo,
	CleanToolAssets,
	PostOneTaskOver,
	PostAllTaskComplete
}
