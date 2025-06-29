using b1.EventDelDefine;
using b1.UI;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class BUS_DebugInfoComp : UActorCompBaseCS
{
	private BUC_DebugInfoData DebugInfoData { get; set; }

	public override void OnAttach()
	{
		base.OnAttach();
		DebugInfoData = RequireWritableData<BUC_DebugInfoData>();
		if (DebugInfoData != null)
		{
			if (DebugConfig.DebugWidget)
			{
				CreateWidgetComp();
			}
			base.BUSEventCollection.Evt_SwitchDebugWidgetState += new Del_Void(OnSwitchDebugWidgetState);
			base.BUSEventCollection.Evt_SetDebugWidgetState += new Del_Void_Bool(SetDebugWidgetState);
		}
	}

	private void CreateWidgetComp()
	{
		if (DebugInfoData.IsDebugWidgetShown())
		{
			return;
		}
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(Owner.World))
		{
			DebugInfoData.DebugInfoComp = UGSE_ActorFuncLib.AddComponentByClass(Owner, UClass.GetClass<UWidgetComponent>(), bManualAttachment: false, FTransform.Identity, bDeferredFinish: false) as UWidgetComponent;
			DebugInfoData.DebugInfoComp.SetCollisionProfileName(B1GlobalFNames.NoCollision);
			DebugInfoData.DebugInfoComp.AttachToComponent(Owner.RootComponent, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
		}
		if (DebugInfoData.DebugInfoComp != null)
		{
			UUserWidget widget = UGSE_UMGFuncLib.CreateUserWidget(GetOwner(), "WidgetBlueprint'/Game/00Main/UI/BluePrintsV3/Debug/BP_CharacterDebug.BP_CharacterDebug_C'");
			if (Owner is BGU_QuestActor)
			{
				DebugInfoData.DebugInfoComp.AttachToComponent(Owner.RootComponent, FName.None, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
			}
			else
			{
				DebugInfoData.DebugInfoComp.AttachToComponent(GetOwner().GetComponentByClass<USceneComponent>(), new FName("Mesh"), EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, EAttachmentRule.SnapToTarget, bWeldSimulatedBodies: false);
			}
			DebugInfoData.DebugInfoComp.SetWidget(widget);
			DebugInfoData.DebugInfoComp.SetPivot(new FVector2D(-0.30000001192092896, 0.5));
			DebugInfoData.DebugInfoComp.SetWidgetSpace(EWidgetSpace.Screen);
			DebugInfoData.DebugInfoComp.SetVisibility(bNewVisibility: true);
			b1.UI.BUI_DebugComm bUI_DebugComm = DebugInfoData.DebugInfoComp.GetUserWidgetObject() as b1.UI.BUI_DebugComm;
			if (bUI_DebugComm != null)
			{
				bUI_DebugComm.InitValue(GetOwner());
			}
		}
	}

	private void SetDebugWidgetState(bool bInShow)
	{
		if (DebugInfoData.IsDebugWidgetShown() != bInShow)
		{
			if (bInShow)
			{
				CreateWidgetComp();
				return;
			}
			DebugInfoData.DebugInfoComp.GetWidget().Destruct();
			DebugInfoData.DebugInfoComp.DestroyComponent(GetOwner());
			DebugInfoData.DebugInfoComp = null;
		}
	}

	private void OnSwitchDebugWidgetState()
	{
		SetDebugWidgetState(!DebugInfoData.IsDebugWidgetShown());
	}
}
