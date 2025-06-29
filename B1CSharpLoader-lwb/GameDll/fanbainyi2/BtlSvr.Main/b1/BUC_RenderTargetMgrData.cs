using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_RenderTargetMgrData : IBUC_RenderTargetMgrData
{
	private const int RTSize = 8;

	private Dictionary<RenderTargetType, TStrongObjectPtr<UTextureRenderTarget2D>> RTMap;

	private Dictionary<RenderTargetType, FName> ParamNameMap;

	private FVector2D DrawPosition;

	public int GetRTSize()
	{
		return 8;
	}

	public BUC_RenderTargetMgrData()
	{
		RTMap = new Dictionary<RenderTargetType, TStrongObjectPtr<UTextureRenderTarget2D>>();
		ParamNameMap = new Dictionary<RenderTargetType, FName>();
		DrawPosition = default(FVector2D);
	}

	public void InitParamNames()
	{
		ParamNameMap.Clear();
		ParamNameMap.Add(RenderTargetType.BeAttacked, B1GlobalFNames.HitDeform_DataTexture);
		ParamNameMap.Add(RenderTargetType.TTTB, B1GlobalFNames.Tongtoutiebi_DataTexture);
		ParamNameMap.Add(RenderTargetType.Shelter, B1GlobalFNames.HitDataTexture);
	}

	public void InitData(RenderTargetType RTType, UTextureRenderTarget2D RT)
	{
		if (Exist(RTType))
		{
			RTMap.Remove(RTType);
		}
		TStrongObjectPtr<UTextureRenderTarget2D> tStrongObjectPtr = new TStrongObjectPtr<UTextureRenderTarget2D>();
		tStrongObjectPtr.Set(RT);
		RTMap.Add(RTType, tStrongObjectPtr);
	}

	public void InitDrawPosition(int GroupIndex)
	{
		DrawPosition.Set(0, GroupIndex);
	}

	public bool Exist(RenderTargetType RTType)
	{
		return RTMap.ContainsKey(RTType);
	}

	public UTextureRenderTarget2D GetTextureRenderTarget(RenderTargetType RTType)
	{
		if (!RTMap.ContainsKey(RTType))
		{
			return null;
		}
		return RTMap[RTType].Get();
	}

	public FName GetParamName(RenderTargetType RTType)
	{
		return ParamNameMap[RTType];
	}

	public FVector2D GetDrawPosition()
	{
		return DrawPosition;
	}

	public bool SetDrawPositionToNextPixel()
	{
		if (DrawPosition.X + 1f >= 8f && DrawPosition.Y + 1f >= 8f)
		{
			return false;
		}
		float y;
		if (DrawPosition.X + 1f >= 8f)
		{
			DrawPosition.X = 0f;
			ref FVector2D drawPosition = ref DrawPosition;
			y = drawPosition.Y + 1f;
			drawPosition.Y = y;
			return true;
		}
		ref FVector2D drawPosition2 = ref DrawPosition;
		y = drawPosition2.X + 1f;
		drawPosition2.X = y;
		return true;
	}
}
