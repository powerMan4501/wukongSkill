using System;
using System.Runtime.InteropServices;
using UnrealEngine.Engine;
using UnrealEngine.InputCore;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

internal class StructValidator
{
	internal static void ValidateStructs()
	{
		ValidateStructSize<FSoftObjectPtrUnsafe>(Native_SizeOfStruct.SizeOf_FSoftObjectPtr);
		ValidateStructSize<FWeakObjectPtr>(Native_SizeOfStruct.SizeOf_FWeakObjectPtr);
		ValidateStructSize<FLazyObjectPtr>(Native_SizeOfStruct.SizeOf_FLazyObjectPtr);
		ValidateStructSize<FSharedPtr>(Native_SizeOfStruct.SizeOf_FSharedPtr);
		ValidateStructSize<FRefCountPtr>(Native_SizeOfStruct.SizeOf_TRefCountPtr);
		ValidateStructSize<FSoftObjectPathUnsafe>(Native_SizeOfStruct.SizeOf_FSoftObjectPath);
		ValidateStructSize<FUniqueObjectGuid>(Native_SizeOfStruct.SizeOf_FUniqueObjectGuid);
		ValidateStructSize<FAssetDataNative>(Native_SizeOfStruct.SizeOf_FAssetData);
		ValidateStructSize<FName>(Native_SizeOfStruct.SizeOf_FName);
		ValidateStructSize<FMinimalName>(Native_SizeOfStruct.SizeOf_FMinimalName);
		ValidateStructSize<FScriptName>(Native_SizeOfStruct.SizeOf_FScriptName);
		ValidateStructSize<FScriptDelegate>(Native_SizeOfStruct.SizeOf_FScriptDelegate);
		ValidateStructSize<FMulticastScriptDelegate>(Native_SizeOfStruct.SizeOf_FMulticastScriptDelegate);
		ValidateStructSize<FScriptArray>(Native_SizeOfStruct.SizeOf_FScriptArray);
		ValidateStructSize<FScriptMap>(Native_SizeOfStruct.SizeOf_FScriptMap);
		ValidateStructSize<FScriptMapLayout>(Native_SizeOfStruct.SizeOf_FScriptMapLayout);
		ValidateStructSize<FScriptSetLayout>(Native_SizeOfStruct.SizeOf_FScriptSetLayout);
		ValidateStructSize<FScriptSparseArrayLayout>(Native_SizeOfStruct.SizeOf_FScriptSparseArrayLayout);
		ValidateStructSize<FDefaultBitArrayAllocator>(Native_SizeOfStruct.SizeOf_FDefaultBitArrayAllocator);
		ValidateStructSize<FScriptBitArray>(Native_SizeOfStruct.SizeOf_FScriptBitArray);
		ValidateStructSize<FScriptSparseArray>(Native_SizeOfStruct.SizeOf_FScriptSparseArray);
		ValidateStructSize<FBitReference>(Native_SizeOfStruct.SizeOf_FBitReference);
		ValidateStructSize<FHashAllocator>(Native_SizeOfStruct.SizeOf_FHashAllocator);
		ValidateStructSize<FSetElementId>(Native_SizeOfStruct.SizeOf_FSetElementId);
		ValidateStructSize<FScriptSet>(Native_SizeOfStruct.SizeOf_FScriptSet);
		ValidateStructSize<FImplementedInterface>(Native_SizeOfStruct.SizeOf_FImplementedInterfaceInterop);
		ValidateStructSize<FNativeFunctionLookup>(Native_SizeOfStruct.SizeOf_FNativeFunctionLookup);
		ValidateStructSize<FDelegateHandle>(Native_SizeOfStruct.SizeOf_FDelegateHandle);
		ValidateStructSize<FText.FTextNative>(Native_SizeOfStruct.SizeOf_FText);
		ValidateStructSize<Guid>(Native_SizeOfStruct.SizeOf_FGuid);
		ValidateStructSize<FActorSpawnParametersInterop>(Native_SizeOfStruct.SizeOf_FActorSpawnParameters);
		ValidateStructSize<FTickPrerequisite>(Native_SizeOfStruct.SizeOf_FTickPrerequisite);
		ValidateStructSize<FKey>(Native_SizeOfStruct.SizeOf_FKey);
		ValidateStructSize<FLifetimeProperty>(Native_SizeOfStruct.SizeOf_FLifetimeProperty);
		ValidateStructSize<FInterpCurvePointFloat>(Native_SizeOfStruct.SizeOf_FInterpCurvePointFloat);
		ValidateStructSize<FInterpCurvePointLinearColor>(Native_SizeOfStruct.SizeOf_FInterpCurvePointLinearColor);
		ValidateStructSize<FInterpCurvePointQuat>(Native_SizeOfStruct.SizeOf_FInterpCurvePointQuat);
		ValidateStructSize<FInterpCurvePointTwoVectors>(Native_SizeOfStruct.SizeOf_FInterpCurvePointTwoVectors);
		ValidateStructSize<FInterpCurvePointVector>(Native_SizeOfStruct.SizeOf_FInterpCurvePointVector);
		ValidateStructSize<FInterpCurvePointVector2D>(Native_SizeOfStruct.SizeOf_FInterpCurvePointVector2D);
		ValidateStructSize<FFloatInterval>(Native_SizeOfStruct.SizeOf_FFloatInterval);
		ValidateStructSize<FInt32Interval>(Native_SizeOfStruct.SizeOf_FInt32Interval);
		ValidateStructSize<FFloatRange>(Native_SizeOfStruct.SizeOf_FFloatRange);
		ValidateStructSize<FInt32Range>(Native_SizeOfStruct.SizeOf_FInt32Range);
		ValidateStructSize<FFloatRangeBound>(Native_SizeOfStruct.SizeOf_FFloatRangeBound);
		ValidateStructSize<FInt32RangeBound>(Native_SizeOfStruct.SizeOf_FInt32RangeBound);
		ValidateStructSize<FBox>(Native_SizeOfStruct.SizeOf_FBox);
		ValidateStructSize<FBox2D>(Native_SizeOfStruct.SizeOf_FBox2D);
		ValidateStructSize<FBoxSphereBounds>(Native_SizeOfStruct.SizeOf_FBoxSphereBounds);
		ValidateStructSize<FColor>(Native_SizeOfStruct.SizeOf_FColor);
		ValidateStructSize<FIntPoint>(Native_SizeOfStruct.SizeOf_FIntPoint);
		ValidateStructSize<FIntRect>(Native_SizeOfStruct.SizeOf_FIntRect);
		ValidateStructSize<FIntVector>(Native_SizeOfStruct.SizeOf_FIntVector);
		ValidateStructSize<FIntVector4>(Native_SizeOfStruct.SizeOf_FIntVector4);
		ValidateStructSize<FLinearColor>(Native_SizeOfStruct.SizeOf_FLinearColor);
		ValidateStructSize<FMatrix>(Native_SizeOfStruct.SizeOf_FMatrix);
		ValidateStructSize<FOrientedBox>(Native_SizeOfStruct.SizeOf_FOrientedBox);
		ValidateStructSize<FPlane>(Native_SizeOfStruct.SizeOf_FPlane);
		ValidateStructSize<FQuat>(Native_SizeOfStruct.SizeOf_FQuat);
		ValidateStructSize<FRandomStream>(Native_SizeOfStruct.SizeOf_FRandomStream);
		ValidateStructSize<FRotator>(Native_SizeOfStruct.SizeOf_FRotator);
		ValidateStructSize<FSphere>(Native_SizeOfStruct.SizeOf_FSphere);
		ValidateStructSize<FTwoVectors>(Native_SizeOfStruct.SizeOf_FTwoVectors);
		ValidateStructSize<FVector>(Native_SizeOfStruct.SizeOf_FVector);
		ValidateStructSize<FVector2D>(Native_SizeOfStruct.SizeOf_FVector2D);
		ValidateStructSize<FVector4>(Native_SizeOfStruct.SizeOf_FVector4);
		int num = Marshal.SizeOf<FTransform>();
		int num2 = Native_SizeOfStruct.SizeOf_FTransform();
		Native_SizeOfStruct.SizeOf_FTransform_IsVectorized();
		if (num != num2 && (num + 8 != num2 || Native_SizeOfStruct.SizeOf_FTransform_IsVectorized() == 0))
		{
			ValidateStructSize<FTransform>(Native_SizeOfStruct.SizeOf_FTransform);
		}
		ValidateFTickFunctionStructSize();
	}

	private static void ValidateFTickFunctionStructSize()
	{
		int fTickFunction_StructSize = FTickFunction.FTickFunction_StructSize;
		fTickFunction_StructSize += IntPtr.Size;
		Native_SizeOfStruct.Del_SizeOf[] array = new Native_SizeOfStruct.Del_SizeOf[7]
		{
			Native_SizeOfStruct.SizeOf_FActorComponentTickFunction,
			Native_SizeOfStruct.SizeOf_FActorTickFunction,
			Native_SizeOfStruct.SizeOf_FCharacterMovementComponentPostPhysicsTickFunction,
			Native_SizeOfStruct.SizeOf_FEndPhysicsTickFunction,
			Native_SizeOfStruct.SizeOf_FSkeletalMeshComponentClothTickFunction,
			Native_SizeOfStruct.SizeOf_FSkeletalMeshComponentEndPhysicsTickFunction,
			Native_SizeOfStruct.SizeOf_FStartPhysicsTickFunction
		};
		for (int i = 0; i < array.Length; i++)
		{
			ValidateStructSize<FTickFunction>(array[i], fTickFunction_StructSize);
		}
	}

	private static void ValidateStructSize<T>(Native_SizeOfStruct.Del_SizeOf func) where T : struct
	{
		if (func != null)
		{
			ValidateStructSize<T>(func, Marshal.SizeOf<T>());
		}
	}

	private static void ValidateStructSize<T>(Native_SizeOfStruct.Del_SizeOf func, int managedSize) where T : struct
	{
		int num = func();
		if (managedSize != num)
		{
			string message = $"Struct size mismatch on '{typeof(T)}' ({func}) managed:{managedSize} native:{num}";
			FMessage.Log(ELogVerbosity.Error, message);
			FMessage.OpenDialog(message);
		}
	}
}
