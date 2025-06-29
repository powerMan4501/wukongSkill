using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_RenderTargetMgrComp : UActorCompBaseCS
{
	private BUC_RenderTargetMgrData RenderTargetMgrData;

	public override void OnAttach()
	{
		RenderTargetMgrData = RequireWritableData<BUC_RenderTargetMgrData>();
		base.BUSEventCollection.Evt_PushRenderTargetValuesToGroup += new Del_PushRenderTargetValuesToGroup(PushRenderTargetValuesToGroup);
		base.BUSEventCollection.Evt_ClearRenderTargetValuesForGroup += new Del_ClearRenderTargetValuesForGroup(ClearRenderTargetValuesForGroup);
		base.BUSEventCollection.Evt_ClearAllRenderTargetValues += new Del_ClearAllRenderTargetValues(ClearAllRenderTargetValues);
	}

	public override void PreBeginPlay()
	{
		RenderTargetMgrData.InitParamNames();
	}

	private void PushRenderTargetValuesToGroup(RenderTargetType RTType, int GroupIndex, List<FLinearColor> ColorValues, List<float> FloatValues)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		UTextureRenderTarget2D textureRenderTarget = RenderTargetMgrData.GetTextureRenderTarget(RTType);
		if (textureRenderTarget == null && !RenderTargetMgrData.Exist(RTType))
		{
			UTextureRenderTarget2D uTextureRenderTarget2D = URenderingLibrary.CreateRenderTarget2D(GetOwner(), 8, 8, ETextureRenderTargetFormat.RTF_RGBA16f, FLinearColor.Black, bAutoGenerateMipMaps: false);
			uTextureRenderTarget2D.AutoGenerateMips = false;
			uTextureRenderTarget2D.LODGroup = ETextureGroup.TEXTUREGROUP_Pixels2D;
			RenderTargetMgrData.InitData(RTType, uTextureRenderTarget2D);
		}
		textureRenderTarget = RenderTargetMgrData.GetTextureRenderTarget(RTType);
		if (textureRenderTarget == null)
		{
			return;
		}
		RenderTargetMgrData.InitDrawPosition(GroupIndex);
		URenderingLibrary.BeginDrawCanvasToRenderTarget(owner, textureRenderTarget, out var Canvas, out var _, out var Context);
		foreach (FLinearColor ColorValue in ColorValues)
		{
			FVector2D drawPosition = RenderTargetMgrData.GetDrawPosition();
			Canvas.DrawTexture(null, drawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), ColorValue, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
			RenderTargetMgrData.SetDrawPositionToNextPixel();
		}
		FLinearColor renderColor = default(FLinearColor);
		for (int i = 0; i < FloatValues.Count; i++)
		{
			bool flag = false;
			switch (i % 4)
			{
			case 0:
				renderColor.R = FloatValues[i];
				break;
			case 1:
				renderColor.G = FloatValues[i];
				break;
			case 2:
				renderColor.B = FloatValues[i];
				break;
			case 3:
				renderColor.A = FloatValues[i];
				flag = true;
				break;
			}
			bool flag2 = i == FloatValues.Count - 1;
			if (flag2 || flag)
			{
				FVector2D drawPosition2 = RenderTargetMgrData.GetDrawPosition();
				Canvas.DrawTexture(null, drawPosition2, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), renderColor, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
				if (!flag2)
				{
					RenderTargetMgrData.SetDrawPositionToNextPixel();
				}
			}
		}
		URenderingLibrary.EndDrawCanvasToRenderTarget(owner, Context);
	}

	private void ClearRenderTargetValuesForGroup(RenderTargetType RTType, int GroupIndex)
	{
		AActor owner = GetOwner();
		if (owner == null)
		{
			return;
		}
		UTextureRenderTarget2D textureRenderTarget = RenderTargetMgrData.GetTextureRenderTarget(RTType);
		if (!(textureRenderTarget == null))
		{
			RenderTargetMgrData.InitDrawPosition(GroupIndex);
			URenderingLibrary.BeginDrawCanvasToRenderTarget(owner, textureRenderTarget, out var Canvas, out var _, out var Context);
			for (int i = 0; i < RenderTargetMgrData.GetRTSize(); i++)
			{
				FVector2D drawPosition = RenderTargetMgrData.GetDrawPosition();
				Canvas.DrawTexture(null, drawPosition, new FVector2D(1.0, 1.0), new FVector2D(0.0, 0.0), new FVector2D(1.0, 1.0), FLinearColor.Black, EBlendMode.BLEND_Masked, 0f, new FVector2D(0.5, 0.5));
				RenderTargetMgrData.SetDrawPositionToNextPixel();
			}
			URenderingLibrary.EndDrawCanvasToRenderTarget(owner, Context);
		}
	}

	private void ClearAllRenderTargetValues(RenderTargetType RTType)
	{
		for (int i = 0; i < RenderTargetMgrData.GetRTSize(); i++)
		{
			ClearRenderTargetValuesForGroup(RTType, 0);
		}
	}
}
