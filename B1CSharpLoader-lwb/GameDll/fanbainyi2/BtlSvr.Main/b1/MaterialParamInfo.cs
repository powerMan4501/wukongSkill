using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class MaterialParamInfo
{
	public EMaterialParamType MaterialParamType;

	public bool IsSleep;

	public bool IsSetBlend2Default;

	public FLinearColor NormalVectorValue;

	public FLinearColor NormalVectorValue_Default;

	public float ScalarValue_Current;

	public bool NeedBlend;

	private bool IsBlendToTarget;

	private float ScalarValue_Begin;

	private float ScalarChangeSpeed;

	private bool IsForwardDirection;

	public RenderTargetType Texture2DType;

	public UTextureRenderTarget2D RT2D;

	public float ScalarValue_Target { get; private set; }

	public float ScalarValueBlendInTime { get; private set; }

	public float ScalarValueBlendOutTime { get; private set; }

	private void CalcForScaleValue(bool ToTargetValue)
	{
		ScalarChangeSpeed = -1f;
		NeedBlend = false;
		IsBlendToTarget = ToTargetValue;
		if (ToTargetValue)
		{
			if (ScalarValueBlendInTime > 0f)
			{
				NeedBlend = true;
				IsForwardDirection = ScalarValue_Target - ScalarValue_Begin >= 0f;
				ScalarChangeSpeed = FMath.Abs(ScalarValue_Target - ScalarValue_Begin) / ScalarValueBlendInTime;
			}
			else
			{
				ScalarValue_Current = ScalarValue_Target;
			}
		}
		else if (ScalarValueBlendOutTime > 0f)
		{
			NeedBlend = true;
			IsForwardDirection = ScalarValue_Begin - ScalarValue_Target >= 0f;
			ScalarChangeSpeed = FMath.Abs(ScalarValue_Begin - ScalarValue_Target) / ScalarValueBlendOutTime;
		}
		else
		{
			ScalarValue_Current = ScalarValue_Begin;
		}
	}

	public void UpdateValue(in MaterialParamInfo Other)
	{
		NormalVectorValue = Other.NormalVectorValue;
		ScalarValue_Target = Other.ScalarValue_Target;
		ScalarValueBlendInTime = Other.ScalarValueBlendInTime;
		ScalarValueBlendOutTime = Other.ScalarValueBlendOutTime;
		CalcForScaleValue(ToTargetValue: true);
		Texture2DType = Other.Texture2DType;
	}

	public void UpdateDefaultValue(in MaterialParamInfo Other)
	{
		NormalVectorValue_Default = Other.NormalVectorValue_Default;
		ScalarValue_Begin = Other.ScalarValue_Begin;
	}

	public void UpdateBlendValueForScalar(float DeltaTime)
	{
		if (!NeedBlend)
		{
			return;
		}
		float num = (IsBlendToTarget ? ScalarValue_Target : ScalarValue_Begin);
		ScalarValue_Current += DeltaTime * ScalarChangeSpeed * (float)(IsForwardDirection ? 1 : (-1));
		if (IsForwardDirection)
		{
			if (ScalarValue_Current > num)
			{
				ScalarValue_Current = num;
				NeedBlend = false;
			}
		}
		else if (ScalarValue_Current < num)
		{
			ScalarValue_Current = num;
			NeedBlend = false;
		}
	}

	public void Reset()
	{
		NormalVectorValue = NormalVectorValue_Default;
		CalcForScaleValue(ToTargetValue: false);
		if (NeedBlend)
		{
			IsSetBlend2Default = true;
			IsSleep = false;
		}
		else
		{
			IsSetBlend2Default = false;
			IsSleep = true;
		}
	}

	public MaterialParamInfo()
	{
	}

	public MaterialParamInfo(in MaterialParamInfo Other)
	{
		if (Other != null)
		{
			MaterialParamType = Other.MaterialParamType;
			IsSleep = Other.IsSleep;
			IsSetBlend2Default = Other.IsSetBlend2Default;
			NormalVectorValue = Other.NormalVectorValue;
			NormalVectorValue_Default = Other.NormalVectorValue_Default;
			ScalarValue_Target = Other.ScalarValue_Target;
			ScalarValue_Begin = Other.ScalarValue_Begin;
			ScalarValue_Current = Other.ScalarValue_Current;
			ScalarValueBlendInTime = Other.ScalarValueBlendInTime;
			ScalarValueBlendOutTime = Other.ScalarValueBlendOutTime;
			ScalarChangeSpeed = Other.ScalarChangeSpeed;
			IsForwardDirection = Other.IsForwardDirection;
			NeedBlend = Other.NeedBlend;
			IsBlendToTarget = Other.IsBlendToTarget;
			Texture2DType = Other.Texture2DType;
		}
	}

	public MaterialParamInfo(FLinearColor InNormalVectorValue, FLinearColor InNormalVectorValue_Default)
	{
		MaterialParamType = EMaterialParamType.NormalVector;
		IsSleep = false;
		IsSetBlend2Default = false;
		NormalVectorValue = InNormalVectorValue;
		NormalVectorValue_Default = InNormalVectorValue_Default;
		ScalarValue_Target = 0f;
		ScalarValue_Begin = 0f;
		ScalarValue_Current = 0f;
		ScalarValueBlendInTime = 0f;
		ScalarValueBlendOutTime = 0f;
		ScalarChangeSpeed = 0f;
		IsForwardDirection = true;
		NeedBlend = false;
		IsBlendToTarget = false;
		Texture2DType = RenderTargetType.None;
		RT2D = null;
	}

	public MaterialParamInfo(float InScalarValue_Target, float InScalarValue_Begin, float InScalarValueBlendInTime, float OutScalarValueBlendOutTime)
	{
		MaterialParamType = EMaterialParamType.Scalar;
		IsSleep = false;
		IsSetBlend2Default = false;
		NormalVectorValue = FLinearColor.White;
		NormalVectorValue_Default = FLinearColor.White;
		ScalarValue_Target = InScalarValue_Target;
		ScalarValue_Begin = InScalarValue_Begin;
		ScalarValue_Current = ScalarValue_Begin;
		ScalarValueBlendInTime = InScalarValueBlendInTime;
		ScalarValueBlendOutTime = OutScalarValueBlendOutTime;
		ScalarChangeSpeed = 0f;
		IsForwardDirection = true;
		NeedBlend = false;
		IsBlendToTarget = false;
		Texture2DType = RenderTargetType.None;
		RT2D = null;
		CalcForScaleValue(ToTargetValue: true);
	}

	public MaterialParamInfo(RenderTargetType InTexture2DType)
	{
		MaterialParamType = EMaterialParamType.Texture2DType;
		IsSleep = false;
		IsSetBlend2Default = false;
		NormalVectorValue = FLinearColor.White;
		NormalVectorValue_Default = FLinearColor.White;
		ScalarValue_Target = 0f;
		ScalarValue_Begin = 0f;
		ScalarValue_Current = 0f;
		ScalarValueBlendInTime = 0f;
		ScalarValueBlendOutTime = 0f;
		ScalarChangeSpeed = 0f;
		IsForwardDirection = true;
		NeedBlend = false;
		IsBlendToTarget = false;
		Texture2DType = InTexture2DType;
		RT2D = null;
	}

	public MaterialParamInfo(UTextureRenderTarget2D InTexture2D)
	{
		MaterialParamType = EMaterialParamType.Texture2D;
		IsSleep = false;
		IsSetBlend2Default = false;
		NormalVectorValue = FLinearColor.White;
		NormalVectorValue_Default = FLinearColor.White;
		ScalarValue_Target = 0f;
		ScalarValue_Begin = 0f;
		ScalarValue_Current = 0f;
		ScalarValueBlendInTime = 0f;
		ScalarValueBlendOutTime = 0f;
		ScalarChangeSpeed = 0f;
		IsForwardDirection = true;
		NeedBlend = false;
		IsBlendToTarget = false;
		Texture2DType = RenderTargetType.None;
		RT2D = InTexture2D;
	}
}
