using UnrealEngine.InputCore;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;
using UnrealEngine.Slate;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035180uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/Engine.InputComponent", "Engine", UnrealModuleType.Engine)]
public class UInputComponent : UActorComponent
{
	public int Priority
	{
		get
		{
			return Native_UInputComponent.Get_Priority(base.Address);
		}
		set
		{
			Native_UInputComponent.Set_Priority(base.Address, value);
		}
	}

	public bool BlockInput
	{
		get
		{
			return Native_UInputComponent.Get_bBlockInput(base.Address);
		}
		set
		{
			Native_UInputComponent.Set_bBlockInput(base.Address, value);
		}
	}

	public float GetAxisValue(string axisName)
	{
		return GetAxisValue((FName)axisName);
	}

	public float GetAxisValue(FName axisName)
	{
		return Native_UInputComponent.GetAxisValue(base.Address, ref axisName);
	}

	public float GetAxisKeyValue(FKey axisKey)
	{
		return Native_UInputComponent.GetAxisKeyValue(base.Address, ref axisKey);
	}

	public FVector GetVectorAxisValue(FKey axisKey)
	{
		Native_UInputComponent.GetVectorAxisValue(base.Address, ref axisKey, out var result);
		return result;
	}

	public bool HasBindings()
	{
		return Native_UInputComponent.HasBindings(base.Address);
	}

	public FInputActionBindingHandle AddActionBinding(FInputActionBindingHandle binding)
	{
		return (FInputActionBindingHandle)Native_UInputComponent.AddActionBinding(base.Address, binding.Address);
	}

	public void ClearActionBindings()
	{
		Native_UInputComponent.ClearActionBindings(base.Address);
	}

	public FInputActionBindingHandle GetActionBinding(int bindingIndex)
	{
		return (FInputActionBindingHandle)Native_UInputComponent.GetActionBinding(base.Address, bindingIndex);
	}

	public int GetNumActionBindings()
	{
		return Native_UInputComponent.GetNumActionBindings(base.Address);
	}

	public void RemoveActionBinding(int bindingIndex)
	{
		Native_UInputComponent.RemoveActionBinding(base.Address, bindingIndex);
	}

	public void RemoveActionBinding(string name)
	{
		RemoveActionBinding((FName)name);
	}

	public void RemoveActionBinding(FName name)
	{
		Native_UInputComponent.RemoveActionBindingByName(base.Address, ref name);
	}

	public void RemoveActionBinding(FInputActionBindingHandle binding)
	{
		Native_UInputComponent.RemoveActionBindingByHandle(base.Address, binding.Address);
	}

	public void ClearBindingValues()
	{
		Native_UInputComponent.ClearBindingValues(base.Address);
	}

	public FInputActionBindingHandle BindAction(string actionName, EInputEventType keyEvent, FInputActionHandler handler)
	{
		if (NativeReflection.LookupTable.GetFunctionAddress(handler, out var functionAddress, out var target))
		{
			FName actionName2 = (FName)actionName;
			return (FInputActionBindingHandle)Native_UInputComponent.BindAction(base.Address, ref actionName2, (byte)keyEvent, target.Address, functionAddress);
		}
		return default(FInputActionBindingHandle);
	}

	public FInputAxisBindingHandle BindAxis(string axisName, FInputAxisHandler handler)
	{
		if (NativeReflection.LookupTable.GetFunctionAddress(handler, out var functionAddress, out var target))
		{
			FName axisName2 = (FName)axisName;
			return (FInputAxisBindingHandle)Native_UInputComponent.BindAxis(base.Address, ref axisName2, target.Address, functionAddress);
		}
		return default(FInputAxisBindingHandle);
	}

	public FInputAxisBindingHandle BindAxis(string axisName)
	{
		FName axisName2 = (FName)axisName;
		return (FInputAxisBindingHandle)Native_UInputComponent.BindAxisName(base.Address, ref axisName2);
	}

	public FInputVectorAxisBindingHandle BindVectorAxis(FKey axisKey, FInputVectorAxisHandler handler)
	{
		if (NativeReflection.LookupTable.GetFunctionAddress(handler, out var functionAddress, out var target))
		{
			return (FInputVectorAxisBindingHandle)Native_UInputComponent.BindVectorAxis(base.Address, ref axisKey, target.Address, functionAddress);
		}
		return default(FInputVectorAxisBindingHandle);
	}

	public FInputVectorAxisBindingHandle BindVectorAxis(FKey axisKey)
	{
		return (FInputVectorAxisBindingHandle)Native_UInputComponent.BindVectorAxisKey(base.Address, ref axisKey);
	}

	public FInputKeyBindingHandle BindKey(FKey key, EInputEventType keyEvent, FInputActionHandler handler)
	{
		if (NativeReflection.LookupTable.GetFunctionAddress(handler, out var functionAddress, out var target))
		{
			return (FInputKeyBindingHandle)Native_UInputComponent.BindKey(base.Address, ref key, (byte)keyEvent, target.Address, functionAddress);
		}
		return default(FInputKeyBindingHandle);
	}

	public FInputKeyBindingHandle BindKey(FInputChord inputChord, EInputEventType keyEvent, FInputActionHandler handler)
	{
		if (NativeReflection.LookupTable.GetFunctionAddress(handler, out var functionAddress, out var target))
		{
			return (FInputKeyBindingHandle)Native_UInputComponent.BindKeyChord(base.Address, ref inputChord.Key, inputChord.Shift, inputChord.Ctrl, inputChord.Alt, inputChord.Cmd, (byte)keyEvent, target.Address, functionAddress);
		}
		return default(FInputKeyBindingHandle);
	}

	public FInputTouchBindingHandle BindTouch(EInputEventType keyEvent, FInputTouchHandler handler)
	{
		if (NativeReflection.LookupTable.GetFunctionAddress(handler, out var functionAddress, out var target))
		{
			return (FInputTouchBindingHandle)Native_UInputComponent.BindTouch(base.Address, (byte)keyEvent, target.Address, functionAddress);
		}
		return default(FInputTouchBindingHandle);
	}

	public FInputGestureBindingHandle BindGesture(FKey gestureKey, FInputGestureHandler handler)
	{
		if (NativeReflection.LookupTable.GetFunctionAddress(handler, out var functionAddress, out var target))
		{
			return (FInputGestureBindingHandle)Native_UInputComponent.BindGesture(base.Address, ref gestureKey, target.Address, functionAddress);
		}
		return default(FInputGestureBindingHandle);
	}
}
