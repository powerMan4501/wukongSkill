using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieSceneTracks;
using UnrealEngine.Runtime;

namespace UnrealEngine.LevelSequence;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/LevelSequence.DefaultLevelSequenceInstanceData", "LevelSequence", UnrealModuleType.Engine)]
public class UDefaultLevelSequenceInstanceData : UObject, IMovieSceneTransformOrigin, IInterface
{
	private static bool TransformOriginActor_IsValid;

	private static int TransformOriginActor_Offset;

	private static bool TransformOrigin_IsValid;

	private static int TransformOrigin_Offset;

	private static bool BP_GetTransformOrigin_IsValid;

	private IntPtr BP_GetTransformOrigin_InstanceFunctionAddress;

	private static IntPtr BP_GetTransformOrigin_FunctionAddress;

	private static int BP_GetTransformOrigin_ParamsSize;

	private static bool BP_GetTransformOrigin_ReturnValue_IsValid;

	private static FFieldAddress BP_GetTransformOrigin_ReturnValue_PropertyAddress;

	private static int BP_GetTransformOrigin_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/LevelSequence.DefaultLevelSequenceInstanceData:TransformOriginActor")]
	public AActor TransformOriginActor
	{
		get
		{
			CheckDestroyed();
			if (!TransformOriginActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.DefaultLevelSequenceInstanceData:TransformOriginActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, TransformOriginActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransformOriginActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.DefaultLevelSequenceInstanceData:TransformOriginActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, TransformOriginActor_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503669420589061uL)]
	[UMetaPath("/Script/LevelSequence.DefaultLevelSequenceInstanceData:TransformOrigin")]
	public FTransform TransformOrigin
	{
		get
		{
			CheckDestroyed();
			if (!TransformOrigin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.DefaultLevelSequenceInstanceData:TransformOrigin");
				return default(FTransform);
			}
			return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(base.Address, TransformOrigin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TransformOrigin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/LevelSequence.DefaultLevelSequenceInstanceData:TransformOrigin");
			}
			else
			{
				BlittableTypeMarshaler<FTransform>.ToNative(IntPtr.Add(base.Address, TransformOrigin_Offset), value);
			}
		}
	}

	[UFunction(Flags = 1552418816u)]
	[UMetaPath("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin")]
	public unsafe FTransform BP_GetTransformOrigin()
	{
		CheckDestroyed();
		if (!BP_GetTransformOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin");
			return default(FTransform);
		}
		if (BP_GetTransformOrigin_InstanceFunctionAddress == IntPtr.Zero)
		{
			BP_GetTransformOrigin_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BP_GetTransformOrigin");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_GetTransformOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_GetTransformOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_GetTransformOrigin_InstanceFunctionAddress, intPtr, BP_GetTransformOrigin_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, BP_GetTransformOrigin_ReturnValue_Offset), 0, BP_GetTransformOrigin_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe FTransform BP_GetTransformOrigin_Implementation()
	{
		CheckDestroyed();
		if (!BP_GetTransformOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin");
			return default(FTransform);
		}
		byte* ptr = stackalloc byte[(int)(uint)(BP_GetTransformOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BP_GetTransformOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, BP_GetTransformOrigin_FunctionAddress, intPtr, BP_GetTransformOrigin_ParamsSize);
		return BlittableTypeMarshaler<FTransform>.FromNative(IntPtr.Add(intPtr, BP_GetTransformOrigin_ReturnValue_Offset), 0, BP_GetTransformOrigin_ReturnValue_PropertyAddress.Address);
	}

	static UDefaultLevelSequenceInstanceData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDefaultLevelSequenceInstanceData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDefaultLevelSequenceInstanceData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/LevelSequence.DefaultLevelSequenceInstanceData");
		TransformOriginActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformOriginActor");
		TransformOriginActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformOriginActor", Classes.FObjectProperty);
		TransformOrigin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TransformOrigin");
		TransformOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TransformOrigin", Classes.FStructProperty);
		BP_GetTransformOrigin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BP_GetTransformOrigin");
		BP_GetTransformOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(BP_GetTransformOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BP_GetTransformOrigin_ReturnValue_PropertyAddress, BP_GetTransformOrigin_FunctionAddress, "ReturnValue");
		BP_GetTransformOrigin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BP_GetTransformOrigin_FunctionAddress, "ReturnValue");
		BP_GetTransformOrigin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BP_GetTransformOrigin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		BP_GetTransformOrigin_IsValid = BP_GetTransformOrigin_FunctionAddress != IntPtr.Zero && BP_GetTransformOrigin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MovieSceneTracks.MovieSceneTransformOrigin:BP_GetTransformOrigin", BP_GetTransformOrigin_IsValid);
	}
}
