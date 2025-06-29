using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1.Plugins.Calliope;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Calliope.CalliopeFunctionLibrary", "Calliope", UnrealModuleType.GamePlugin)]
public class UCalliopeFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool MarkDirtyAllCalliopeTrack_IsValid;

	private static IntPtr MarkDirtyAllCalliopeTrack_FunctionAddress;

	private static int MarkDirtyAllCalliopeTrack_ParamsSize;

	private static bool MarkDirtyAllCalliopeTrack_InSequence_IsValid;

	private static FFieldAddress MarkDirtyAllCalliopeTrack_InSequence_PropertyAddress;

	private static int MarkDirtyAllCalliopeTrack_InSequence_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/Calliope.CalliopeFunctionLibrary:MarkDirtyAllCalliopeTrack")]
	public unsafe static void MarkDirtyAllCalliopeTrack(UMovieScene InSequence)
	{
		if (!MarkDirtyAllCalliopeTrack_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Calliope.CalliopeFunctionLibrary:MarkDirtyAllCalliopeTrack");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MarkDirtyAllCalliopeTrack_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MarkDirtyAllCalliopeTrack_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UMovieScene>.ToNative(IntPtr.Add(intPtr, MarkDirtyAllCalliopeTrack_InSequence_Offset), 0, MarkDirtyAllCalliopeTrack_InSequence_PropertyAddress.Address, InSequence);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, MarkDirtyAllCalliopeTrack_FunctionAddress, intPtr, MarkDirtyAllCalliopeTrack_ParamsSize);
	}

	static UCalliopeFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UCalliopeFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UCalliopeFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/Calliope.CalliopeFunctionLibrary");
		MarkDirtyAllCalliopeTrack_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "MarkDirtyAllCalliopeTrack");
		MarkDirtyAllCalliopeTrack_ParamsSize = NativeReflection.GetFunctionParamsSize(MarkDirtyAllCalliopeTrack_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MarkDirtyAllCalliopeTrack_InSequence_PropertyAddress, MarkDirtyAllCalliopeTrack_FunctionAddress, "InSequence");
		MarkDirtyAllCalliopeTrack_InSequence_Offset = NativeReflectionCached.GetPropertyOffset(MarkDirtyAllCalliopeTrack_FunctionAddress, "InSequence");
		MarkDirtyAllCalliopeTrack_InSequence_IsValid = NativeReflectionCached.ValidatePropertyClass(MarkDirtyAllCalliopeTrack_FunctionAddress, "InSequence", Classes.FObjectProperty);
		MarkDirtyAllCalliopeTrack_IsValid = MarkDirtyAllCalliopeTrack_FunctionAddress != IntPtr.Zero && MarkDirtyAllCalliopeTrack_InSequence_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Calliope.CalliopeFunctionLibrary:MarkDirtyAllCalliopeTrack", MarkDirtyAllCalliopeTrack_IsValid);
	}
}
