using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Blutility;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSLevelUtilActor", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSLevelUtilActor : AEditorUtilityActor
{
	private static bool GetLevelStreamingBoundingBox_IsValid;

	private static IntPtr GetLevelStreamingBoundingBox_FunctionAddress;

	private static int GetLevelStreamingBoundingBox_ParamsSize;

	private static bool GetLevelStreamingBoundingBox_LevelStreaming_IsValid;

	private static FFieldAddress GetLevelStreamingBoundingBox_LevelStreaming_PropertyAddress;

	private static int GetLevelStreamingBoundingBox_LevelStreaming_Offset;

	private static bool GetLevelStreamingBoundingBox_Center_IsValid;

	private static FFieldAddress GetLevelStreamingBoundingBox_Center_PropertyAddress;

	private static int GetLevelStreamingBoundingBox_Center_Offset;

	private static bool GetLevelStreamingBoundingBox_BoxExtent_IsValid;

	private static FFieldAddress GetLevelStreamingBoundingBox_BoxExtent_PropertyAddress;

	private static int GetLevelStreamingBoundingBox_BoxExtent_Offset;

	private static bool CreateStreamingLevelVolume_IsValid;

	private static IntPtr CreateStreamingLevelVolume_FunctionAddress;

	private static int CreateStreamingLevelVolume_ParamsSize;

	private static bool CreateStreamingLevelVolume_VolumeScale_IsValid;

	private static FFieldAddress CreateStreamingLevelVolume_VolumeScale_PropertyAddress;

	private static int CreateStreamingLevelVolume_VolumeScale_Offset;

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelUtilActor:GetLevelStreamingBoundingBox")]
	public unsafe void GetLevelStreamingBoundingBox(ULevelStreaming LevelStreaming, out FVector Center, out FVector BoxExtent)
	{
		CheckDestroyed();
		if (!GetLevelStreamingBoundingBox_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLevelUtilActor:GetLevelStreamingBoundingBox");
			Center = default(FVector);
			BoxExtent = default(FVector);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLevelStreamingBoundingBox_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLevelStreamingBoundingBox_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<ULevelStreaming>.ToNative(IntPtr.Add(intPtr, GetLevelStreamingBoundingBox_LevelStreaming_Offset), 0, GetLevelStreamingBoundingBox_LevelStreaming_PropertyAddress.Address, LevelStreaming);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLevelStreamingBoundingBox_FunctionAddress, intPtr, GetLevelStreamingBoundingBox_ParamsSize);
		Center = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLevelStreamingBoundingBox_Center_Offset), 0, GetLevelStreamingBoundingBox_Center_PropertyAddress.Address);
		BoxExtent = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetLevelStreamingBoundingBox_BoxExtent_Offset), 0, GetLevelStreamingBoundingBox_BoxExtent_PropertyAddress.Address);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/FuncLibEditor.GSLevelUtilActor:CreateStreamingLevelVolume")]
	public unsafe void CreateStreamingLevelVolume(FVector VolumeScale)
	{
		CheckDestroyed();
		if (!CreateStreamingLevelVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSLevelUtilActor:CreateStreamingLevelVolume");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateStreamingLevelVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateStreamingLevelVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, CreateStreamingLevelVolume_VolumeScale_Offset), 0, CreateStreamingLevelVolume_VolumeScale_PropertyAddress.Address, VolumeScale);
		NativeReflection.InvokeFunctionOptimized(base.Address, CreateStreamingLevelVolume_FunctionAddress, intPtr, CreateStreamingLevelVolume_ParamsSize);
	}

	static AGSLevelUtilActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSLevelUtilActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSLevelUtilActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/FuncLibEditor.GSLevelUtilActor");
		GetLevelStreamingBoundingBox_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLevelStreamingBoundingBox");
		GetLevelStreamingBoundingBox_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLevelStreamingBoundingBox_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingBoundingBox_LevelStreaming_PropertyAddress, GetLevelStreamingBoundingBox_FunctionAddress, "LevelStreaming");
		GetLevelStreamingBoundingBox_LevelStreaming_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingBoundingBox_FunctionAddress, "LevelStreaming");
		GetLevelStreamingBoundingBox_LevelStreaming_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingBoundingBox_FunctionAddress, "LevelStreaming", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingBoundingBox_Center_PropertyAddress, GetLevelStreamingBoundingBox_FunctionAddress, "Center");
		GetLevelStreamingBoundingBox_Center_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingBoundingBox_FunctionAddress, "Center");
		GetLevelStreamingBoundingBox_Center_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingBoundingBox_FunctionAddress, "Center", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLevelStreamingBoundingBox_BoxExtent_PropertyAddress, GetLevelStreamingBoundingBox_FunctionAddress, "BoxExtent");
		GetLevelStreamingBoundingBox_BoxExtent_Offset = NativeReflectionCached.GetPropertyOffset(GetLevelStreamingBoundingBox_FunctionAddress, "BoxExtent");
		GetLevelStreamingBoundingBox_BoxExtent_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLevelStreamingBoundingBox_FunctionAddress, "BoxExtent", Classes.FStructProperty);
		GetLevelStreamingBoundingBox_IsValid = GetLevelStreamingBoundingBox_FunctionAddress != IntPtr.Zero && GetLevelStreamingBoundingBox_LevelStreaming_IsValid && GetLevelStreamingBoundingBox_Center_IsValid && GetLevelStreamingBoundingBox_BoxExtent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLevelUtilActor:GetLevelStreamingBoundingBox", GetLevelStreamingBoundingBox_IsValid);
		CreateStreamingLevelVolume_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "CreateStreamingLevelVolume");
		CreateStreamingLevelVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateStreamingLevelVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateStreamingLevelVolume_VolumeScale_PropertyAddress, CreateStreamingLevelVolume_FunctionAddress, "VolumeScale");
		CreateStreamingLevelVolume_VolumeScale_Offset = NativeReflectionCached.GetPropertyOffset(CreateStreamingLevelVolume_FunctionAddress, "VolumeScale");
		CreateStreamingLevelVolume_VolumeScale_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateStreamingLevelVolume_FunctionAddress, "VolumeScale", Classes.FStructProperty);
		CreateStreamingLevelVolume_IsValid = CreateStreamingLevelVolume_FunctionAddress != IntPtr.Zero && CreateStreamingLevelVolume_VolumeScale_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSLevelUtilActor:CreateStreamingLevelVolume", CreateStreamingLevelVolume_IsValid);
	}
}
