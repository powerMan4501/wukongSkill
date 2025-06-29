using System.Globalization;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1;

public class FInputActionValue
{
	private EInputActionValueType _valueType;

	private FVector _value;

	private ulong _frameCounter;

	private readonly APlayerController _playerController;

	private readonly UInputAction _inputAction;

	private readonly bool _isInjectValue;

	public static readonly FInputActionValue True = new FInputActionValue(EInputActionValueType.Boolean, FVector.ForwardVector);

	public static readonly FInputActionValue False = new FInputActionValue(EInputActionValueType.Boolean, FVector.ZeroVector);

	public static readonly FInputActionValue Forward = new FInputActionValue(EInputActionValueType.Axis1D, FVector.ForwardVector);

	public static readonly FInputActionValue Backward = new FInputActionValue(EInputActionValueType.Axis1D, -FVector.ForwardVector);

	public static readonly FInputActionValue Right = new FInputActionValue(EInputActionValueType.Axis1D, FVector.RightVector);

	public static readonly FInputActionValue Left = new FInputActionValue(EInputActionValueType.Axis1D, -FVector.RightVector);

	public static readonly FInputActionValue TriggeredValue = new FInputActionValue(EInputActionValueType.Axis3D, FVector.OneVector);

	public static readonly FInputActionValue CompletedValue = new FInputActionValue(EInputActionValueType.Axis3D, FVector.ZeroVector);

	public FInputActionValue(APlayerController PlayerController, UInputAction InputAction)
	{
		_playerController = PlayerController;
		_inputAction = InputAction;
		_isInjectValue = _playerController == null || _inputAction == null;
	}

	public FInputActionValue(EInputActionValueType valueType, FVector value)
	{
		_valueType = valueType;
		_value = value;
		_isInjectValue = true;
	}

	private void UpdateValue()
	{
		if (!_isInjectValue && _frameCounter < FGlobals.FrameCounter)
		{
			_frameCounter = FGlobals.FrameCounter;
			_value = InputFuncLib.GetInputActionValue(_playerController.Address, _inputAction.Address);
		}
	}

	public void UpdateValue(EInputActionValueType ValueType, FVector Value)
	{
		_frameCounter = FGlobals.FrameCounter;
		_valueType = ValueType;
		_value = Value;
	}

	public bool GetBool()
	{
		UpdateValue();
		return _value.X != 0f;
	}

	public float GetAxis1D()
	{
		UpdateValue();
		return _value.X;
	}

	public FVector2D GetAxis2D()
	{
		if ((int)_valueType < 2)
		{
			BGW_LogUtil.LogError("Enhanced Input: GetAxis2D error!");
		}
		UpdateValue();
		return _value.Conv_VectorToVector2D();
	}

	public FVector GetAxis3D()
	{
		if ((int)_valueType < 3)
		{
			BGW_LogUtil.LogError("Enhanced Input: GetAxis3D error!");
		}
		UpdateValue();
		return _value;
	}

	public FVector GetValue()
	{
		GSEUtil.Check(_isInjectValue);
		return _value;
	}

	public override string ToString()
	{
		UpdateValue();
		switch (_valueType)
		{
		case EInputActionValueType.Boolean:
			if (!GetBool())
			{
				return "False";
			}
			return "True";
		case EInputActionValueType.Axis1D:
			return GetAxis1D().ToString(CultureInfo.CurrentCulture);
		case EInputActionValueType.Axis2D:
			return $"({GetAxis2D().X}, {GetAxis2D().Y})";
		case EInputActionValueType.Axis3D:
			return $"({GetAxis3D().X}, {GetAxis3D().Y}, {GetAxis3D().Z})";
		default:
			return string.Empty;
		}
	}

	public EInputActionValueType GetValueType()
	{
		return _valueType;
	}
}
