using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.EaseFuncParams")]
public struct FEaseFuncParams
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EaseFuncParams:AnimEaseFunc")]
	public ENGSEasingFunc AnimEaseFunc;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EaseFuncParams:Param")]
	public float Param;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EaseFuncParams:BlendExp")]
	public float BlendExp;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.EaseFuncParams:Steps")]
	public int Steps;

	private static int EaseFuncParams_StructSize;

	private static int EaseFuncParams_IsValid;

	private static bool AnimEaseFunc_IsValid;

	private static int AnimEaseFunc_Offset;

	private static FFieldAddress AnimEaseFunc_PropertyAddress;

	private static bool Param_IsValid;

	private static int Param_Offset;

	private static bool BlendExp_IsValid;

	private static int BlendExp_Offset;

	private static bool Steps_IsValid;

	private static int Steps_Offset;

	public FEaseFuncParams(ENGSEasingFunc InAnimEaseFunc = ENGSEasingFunc.EaseOut, float InParam = 1.70158f, float InBlendExp = 2f, int InSteps = 2)
	{
		AnimEaseFunc = InAnimEaseFunc;
		Param = InParam;
		BlendExp = InBlendExp;
		Steps = InSteps;
	}

	public FEaseFuncParams Copy()
	{
		return this;
	}

	public static FEaseFuncParams FromNative(IntPtr nativeBuffer)
	{
		return new FEaseFuncParams(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEaseFuncParams value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEaseFuncParams FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEaseFuncParams(IntPtr.Add(nativeBuffer, arrayIndex * EaseFuncParams_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEaseFuncParams value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * EaseFuncParams_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (EaseFuncParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EaseFuncParams");
			return;
		}
		EnumMarshaler<ENGSEasingFunc>.ToNative(IntPtr.Add(nativeStruct, AnimEaseFunc_Offset), 0, AnimEaseFunc_PropertyAddress.Address, AnimEaseFunc);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Param_Offset), Param);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlendExp_Offset), BlendExp);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Steps_Offset), Steps);
	}

	public FEaseFuncParams(IntPtr nativeStruct)
	{
		if (EaseFuncParams_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.EaseFuncParams");
			AnimEaseFunc = ENGSEasingFunc.Linear;
			Param = 0f;
			BlendExp = 0f;
			Steps = 0;
		}
		else
		{
			AnimEaseFunc = EnumMarshaler<ENGSEasingFunc>.FromNative(IntPtr.Add(nativeStruct, AnimEaseFunc_Offset), 0, AnimEaseFunc_PropertyAddress.Address);
			Param = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Param_Offset));
			BlendExp = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlendExp_Offset));
			Steps = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Steps_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.EaseFuncParams");
		EaseFuncParams_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref AnimEaseFunc_PropertyAddress, intPtr, "AnimEaseFunc");
		AnimEaseFunc_Offset = NativeReflection.GetPropertyOffset(intPtr, "AnimEaseFunc");
		AnimEaseFunc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AnimEaseFunc", Classes.FEnumProperty);
		Param_Offset = NativeReflection.GetPropertyOffset(intPtr, "Param");
		Param_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Param", Classes.FFloatProperty);
		BlendExp_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlendExp");
		BlendExp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlendExp", Classes.FFloatProperty);
		Steps_Offset = NativeReflection.GetPropertyOffset(intPtr, "Steps");
		Steps_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Steps", Classes.FIntProperty);
		EaseFuncParams_IsValid = ((intPtr != IntPtr.Zero && AnimEaseFunc_IsValid && Param_IsValid && BlendExp_IsValid && Steps_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.EaseFuncParams", (byte)EaseFuncParams_IsValid != 0);
	}

	static FEaseFuncParams()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FEaseFuncParams)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEaseFuncParams));
	}
}
