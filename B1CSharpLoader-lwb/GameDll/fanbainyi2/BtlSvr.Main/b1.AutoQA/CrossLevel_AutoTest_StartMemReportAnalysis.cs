using System.Collections.Generic;

namespace b1.AutoQA;

internal class CrossLevel_AutoTest_StartMemReportAnalysis : b1.AutoQA.CrossLevel_AutoTest_Template
{
	public List<string> NeedExportClassList = new List<string>
	{
		"StaticMesh", "SkeletalMesh", "Texture2D", "MaterialInstanceConstant", "Material", "BodySetup", "NavCollision", "MaterialInstanceDynamic", "NiagaraComponent", "Class",
		"SkeletalMeshComponent", "AnimMontage", "AnimSequence", "SkeletalMeshSocket", "LevelStreamingCallbackHolder", "BAN_GSAkEvent", "GSMapAreaDetailData", "GSMapAreaBaseData"
	};

	public bool IsNeedExportMemReport;

	public override string TestLabel => "StartMemReportAnalysis";

	public override float TimeLimit => 3600f;

	protected override void RegisterTestState()
	{
		StateStack.Push(new TestState_MemReportAnalysis(base.WorldContext, "1.memreport", "2.memreport", NeedExportClassList, IsNeedNotifyFinish: true, IsNeedExportMemReport));
	}
}
