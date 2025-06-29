using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_CustomDepthStencilComp : UActorCompBaseCS
{
	public override void OnAttach()
	{
		base.BUSEventCollection.Evt_SetCustomDepthStencilByComp += new Del_SetCustomDepthStencilByComp(OnSetCustomDepthStencilByComp);
		base.BUSEventCollection.Evt_SetCustomDepthStencilByClass += new Del_SetCustomDepthStencilByClass(OnSetCustomDepthStencilByClass);
	}

	public override void OnBeginPlay()
	{
		OnSetCustomDepthStencilByClass(UClass.GetClass<UPrimitiveComponent>(), bEnable: false, 0);
	}

	private void OnSetCustomDepthStencilByComp(FName CompTag, bool bEnable, int Stencil)
	{
		foreach (UActorComponent item in Owner.GetComponentsByTag(UClass.GetClass<UPrimitiveComponent>(), CompTag))
		{
			UPrimitiveComponent uPrimitiveComponent = item as UPrimitiveComponent;
			if (uPrimitiveComponent != null)
			{
				uPrimitiveComponent.RenderCustomDepth = bEnable;
				uPrimitiveComponent.SetCustomDepthStencilValue(Stencil);
			}
		}
	}

	private void OnSetCustomDepthStencilByClass(UClass TargetCompClass, bool bEnable, int Stencil)
	{
		foreach (UActorComponent item in Owner.GetComponentsByClass(TargetCompClass))
		{
			UPrimitiveComponent uPrimitiveComponent = item as UPrimitiveComponent;
			if (uPrimitiveComponent != null)
			{
				uPrimitiveComponent.RenderCustomDepth = bEnable;
				uPrimitiveComponent.SetCustomDepthStencilValue(Stencil);
			}
		}
	}
}
