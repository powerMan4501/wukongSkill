using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)810025120uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MaterialExpressionFunctionInput", "Engine", UnrealModuleType.Engine)]
public class UMaterialExpressionFunctionInput : UMaterialExpression
{
	private static bool InputName_IsValid;

	private static int InputName_Offset;

	private static bool InputType_IsValid;

	private static FFieldAddress InputType_PropertyAddress;

	private static int InputType_Offset;

	private static bool PreviewValue_IsValid;

	private static int PreviewValue_Offset;

	private static bool UsePreviewValueAsDefault_IsValid;

	private static FFieldAddress UsePreviewValueAsDefault_PropertyAddress;

	private static int UsePreviewValueAsDefault_Offset;

	private static bool SortPriority_IsValid;

	private static int SortPriority_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionFunctionInput:InputName")]
	public FName InputName
	{
		get
		{
			CheckDestroyed();
			if (!InputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:InputName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, InputName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:InputName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, InputName_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionFunctionInput:InputType")]
	public EFunctionInputType InputType
	{
		get
		{
			CheckDestroyed();
			if (!InputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:InputType");
				return EFunctionInputType.FunctionInput_Scalar;
			}
			return EnumMarshaler<EFunctionInputType>.FromNative(IntPtr.Add(base.Address, InputType_Offset), 0, InputType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InputType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:InputType");
			}
			else
			{
				EnumMarshaler<EFunctionInputType>.ToNative(IntPtr.Add(base.Address, InputType_Offset), 0, InputType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionFunctionInput:PreviewValue")]
	public FVector4 PreviewValue
	{
		get
		{
			CheckDestroyed();
			if (!PreviewValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:PreviewValue");
				return default(FVector4);
			}
			return BlittableTypeMarshaler<FVector4>.FromNative(IntPtr.Add(base.Address, PreviewValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviewValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:PreviewValue");
			}
			else
			{
				BlittableTypeMarshaler<FVector4>.ToNative(IntPtr.Add(base.Address, PreviewValue_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionFunctionInput:bUsePreviewValueAsDefault")]
	public bool UsePreviewValueAsDefault
	{
		get
		{
			CheckDestroyed();
			if (!UsePreviewValueAsDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:bUsePreviewValueAsDefault");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UsePreviewValueAsDefault_Offset), 0, UsePreviewValueAsDefault_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UsePreviewValueAsDefault_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:bUsePreviewValueAsDefault");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UsePreviewValueAsDefault_Offset), 0, UsePreviewValueAsDefault_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MaterialExpressionFunctionInput:SortPriority")]
	public int SortPriority
	{
		get
		{
			CheckDestroyed();
			if (!SortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:SortPriority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SortPriority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SortPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MaterialExpressionFunctionInput:SortPriority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SortPriority_Offset), value);
			}
		}
	}

	static UMaterialExpressionFunctionInput()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMaterialExpressionFunctionInput)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMaterialExpressionFunctionInput));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/Engine.MaterialExpressionFunctionInput");
		InputName_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputName");
		InputName_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref InputType_PropertyAddress, unrealStruct, "InputType");
		InputType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "InputType");
		InputType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "InputType", Classes.FByteProperty);
		PreviewValue_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "PreviewValue");
		PreviewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "PreviewValue", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UsePreviewValueAsDefault_PropertyAddress, unrealStruct, "bUsePreviewValueAsDefault");
		UsePreviewValueAsDefault_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bUsePreviewValueAsDefault");
		UsePreviewValueAsDefault_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bUsePreviewValueAsDefault", Classes.FBoolProperty);
		SortPriority_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "SortPriority");
		SortPriority_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "SortPriority", Classes.FIntProperty);
	}
}
