using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.AnimGraphRuntime;
using UnrealEngine.Runtime;

namespace UnrealEngine.AnimGraph;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver", "AnimGraph", UnrealModuleType.Engine)]
public class UAnimGraphNode_PoseDriver : UAnimGraphNode_PoseHandler
{
	private static bool Node_IsValid;

	private static int Node_Offset;

	private static bool SetSourceBones_IsValid;

	private static IntPtr SetSourceBones_FunctionAddress;

	private static int SetSourceBones_ParamsSize;

	private static bool SetSourceBones_BoneNames_IsValid;

	private static FFieldAddress SetSourceBones_BoneNames_PropertyAddress;

	private static int SetSourceBones_BoneNames_Offset;

	private static bool SetRBFParameters_IsValid;

	private static IntPtr SetRBFParameters_FunctionAddress;

	private static int SetRBFParameters_ParamsSize;

	private static bool SetRBFParameters_Parameters_IsValid;

	private static FFieldAddress SetRBFParameters_Parameters_PropertyAddress;

	private static int SetRBFParameters_Parameters_Offset;

	private static bool SetPoseDriverSource_IsValid;

	private static IntPtr SetPoseDriverSource_FunctionAddress;

	private static int SetPoseDriverSource_ParamsSize;

	private static bool SetPoseDriverSource_DriverSource_IsValid;

	private static FFieldAddress SetPoseDriverSource_DriverSource_PropertyAddress;

	private static int SetPoseDriverSource_DriverSource_Offset;

	private static bool SetPoseDriverOutput_IsValid;

	private static IntPtr SetPoseDriverOutput_FunctionAddress;

	private static int SetPoseDriverOutput_ParamsSize;

	private static bool SetPoseDriverOutput_DriverOutput_IsValid;

	private static FFieldAddress SetPoseDriverOutput_DriverOutput_PropertyAddress;

	private static int SetPoseDriverOutput_DriverOutput_Offset;

	private static bool SetOnlyDriveSelectedBones_IsValid;

	private static IntPtr SetOnlyDriveSelectedBones_FunctionAddress;

	private static int SetOnlyDriveSelectedBones_ParamsSize;

	private static bool SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_IsValid;

	private static FFieldAddress SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_PropertyAddress;

	private static int SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_Offset;

	private static bool SetDrivingBones_IsValid;

	private static IntPtr SetDrivingBones_FunctionAddress;

	private static int SetDrivingBones_ParamsSize;

	private static bool SetDrivingBones_BoneNames_IsValid;

	private static FFieldAddress SetDrivingBones_BoneNames_PropertyAddress;

	private static int SetDrivingBones_BoneNames_Offset;

	private static bool GetSourceBoneNames_IsValid;

	private static IntPtr GetSourceBoneNames_FunctionAddress;

	private static int GetSourceBoneNames_ParamsSize;

	private static bool GetSourceBoneNames_BoneNames_IsValid;

	private static FFieldAddress GetSourceBoneNames_BoneNames_PropertyAddress;

	private static int GetSourceBoneNames_BoneNames_Offset;

	private static bool GetRBFParameters_IsValid;

	private static IntPtr GetRBFParameters_FunctionAddress;

	private static int GetRBFParameters_ParamsSize;

	private static bool GetRBFParameters_ReturnValue_IsValid;

	private static FFieldAddress GetRBFParameters_ReturnValue_PropertyAddress;

	private static int GetRBFParameters_ReturnValue_Offset;

	private static bool GetPoseDriverSource_IsValid;

	private static IntPtr GetPoseDriverSource_FunctionAddress;

	private static int GetPoseDriverSource_ParamsSize;

	private static bool GetPoseDriverSource_ReturnValue_IsValid;

	private static FFieldAddress GetPoseDriverSource_ReturnValue_PropertyAddress;

	private static int GetPoseDriverSource_ReturnValue_Offset;

	private static bool GetPoseDriverOutput_IsValid;

	private static IntPtr GetPoseDriverOutput_FunctionAddress;

	private static int GetPoseDriverOutput_ParamsSize;

	private static bool GetPoseDriverOutput_ReturnValue_IsValid;

	private static FFieldAddress GetPoseDriverOutput_ReturnValue_PropertyAddress;

	private static int GetPoseDriverOutput_ReturnValue_Offset;

	private static bool GetOnlyDriveSelectedBones_IsValid;

	private static IntPtr GetOnlyDriveSelectedBones_FunctionAddress;

	private static int GetOnlyDriveSelectedBones_ParamsSize;

	private static bool GetOnlyDriveSelectedBones_ReturnValue_IsValid;

	private static FFieldAddress GetOnlyDriveSelectedBones_ReturnValue_PropertyAddress;

	private static int GetOnlyDriveSelectedBones_ReturnValue_Offset;

	private static bool GetDrivingBoneNames_IsValid;

	private static IntPtr GetDrivingBoneNames_FunctionAddress;

	private static int GetDrivingBoneNames_ParamsSize;

	private static bool GetDrivingBoneNames_BoneNames_IsValid;

	private static FFieldAddress GetDrivingBoneNames_BoneNames_PropertyAddress;

	private static int GetDrivingBoneNames_BoneNames_Offset;

	private static bool CopyTargetsFromPoseAsset_IsValid;

	private static IntPtr CopyTargetsFromPoseAsset_FunctionAddress;

	private static int CopyTargetsFromPoseAsset_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:Node")]
	public FAnimNode_PoseDriver Node
	{
		get
		{
			CheckDestroyed();
			if (!Node_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:Node");
				return default(FAnimNode_PoseDriver);
			}
			return FAnimNode_PoseDriver.FromNative(IntPtr.Add(base.Address, Node_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Node_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:Node");
			}
			else
			{
				FAnimNode_PoseDriver.ToNative(IntPtr.Add(base.Address, Node_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetSourceBones")]
	public unsafe void SetSourceBones(List<FName> BoneNames)
	{
		CheckDestroyed();
		if (!SetSourceBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetSourceBones");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSourceBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSourceBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, SetSourceBones_BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, SetSourceBones_BoneNames_Offset), BoneNames);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSourceBones_FunctionAddress, intPtr, SetSourceBones_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetSourceBones_BoneNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetRBFParameters")]
	public unsafe void SetRBFParameters(FRBFParams Parameters)
	{
		CheckDestroyed();
		if (!SetRBFParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetRBFParameters");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetRBFParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetRBFParameters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetRBFParameters_Parameters_PropertyAddress.Address, intPtr);
		FRBFParams.ToNative(IntPtr.Add(intPtr, SetRBFParameters_Parameters_Offset), 0, SetRBFParameters_Parameters_PropertyAddress.Address, Parameters);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetRBFParameters_FunctionAddress, intPtr, SetRBFParameters_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverSource")]
	public unsafe void SetPoseDriverSource(EPoseDriverSource DriverSource)
	{
		CheckDestroyed();
		if (!SetPoseDriverSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverSource");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPoseDriverSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPoseDriverSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPoseDriverSource>.ToNative(IntPtr.Add(intPtr, SetPoseDriverSource_DriverSource_Offset), 0, SetPoseDriverSource_DriverSource_PropertyAddress.Address, DriverSource);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPoseDriverSource_FunctionAddress, intPtr, SetPoseDriverSource_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverOutput")]
	public unsafe void SetPoseDriverOutput(EPoseDriverOutput DriverOutput)
	{
		CheckDestroyed();
		if (!SetPoseDriverOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverOutput");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPoseDriverOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPoseDriverOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPoseDriverOutput>.ToNative(IntPtr.Add(intPtr, SetPoseDriverOutput_DriverOutput_Offset), 0, SetPoseDriverOutput_DriverOutput_PropertyAddress.Address, DriverOutput);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPoseDriverOutput_FunctionAddress, intPtr, SetPoseDriverOutput_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetOnlyDriveSelectedBones")]
	public unsafe void SetOnlyDriveSelectedBones(bool bOnlyDriveSelectedBones)
	{
		CheckDestroyed();
		if (!SetOnlyDriveSelectedBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetOnlyDriveSelectedBones");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOnlyDriveSelectedBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOnlyDriveSelectedBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_Offset), 0, SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_PropertyAddress.Address, bOnlyDriveSelectedBones);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetOnlyDriveSelectedBones_FunctionAddress, intPtr, SetOnlyDriveSelectedBones_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetDrivingBones")]
	public unsafe void SetDrivingBones(List<FName> BoneNames)
	{
		CheckDestroyed();
		if (!SetDrivingBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetDrivingBones");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetDrivingBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetDrivingBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<FName>(1, SetDrivingBones_BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).ToNative(IntPtr.Add(intPtr, SetDrivingBones_BoneNames_Offset), BoneNames);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetDrivingBones_FunctionAddress, intPtr, SetDrivingBones_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetDrivingBones_BoneNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 339870721u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetSourceBoneNames")]
	public unsafe void GetSourceBoneNames(out List<FName> BoneNames)
	{
		CheckDestroyed();
		if (!GetSourceBoneNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetSourceBoneNames");
			BoneNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSourceBoneNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSourceBoneNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSourceBoneNames_FunctionAddress, intPtr, GetSourceBoneNames_ParamsSize);
		BoneNames = new TArrayCopyMarshaler<FName>(1, GetSourceBoneNames_BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetSourceBoneNames_BoneNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetSourceBoneNames_BoneNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetRBFParameters")]
	public unsafe FRBFParams GetRBFParameters()
	{
		CheckDestroyed();
		if (!GetRBFParameters_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetRBFParameters");
			return default(FRBFParams);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRBFParameters_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRBFParameters_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRBFParameters_FunctionAddress, intPtr, GetRBFParameters_ParamsSize);
		return FRBFParams.FromNative(IntPtr.Add(intPtr, GetRBFParameters_ReturnValue_Offset), 0, GetRBFParameters_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverSource")]
	public unsafe EPoseDriverSource GetPoseDriverSource()
	{
		CheckDestroyed();
		if (!GetPoseDriverSource_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverSource");
			return EPoseDriverSource.Rotation;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPoseDriverSource_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPoseDriverSource_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPoseDriverSource_FunctionAddress, intPtr, GetPoseDriverSource_ParamsSize);
		return EnumMarshaler<EPoseDriverSource>.FromNative(IntPtr.Add(intPtr, GetPoseDriverSource_ReturnValue_Offset), 0, GetPoseDriverSource_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverOutput")]
	public unsafe EPoseDriverOutput GetPoseDriverOutput()
	{
		CheckDestroyed();
		if (!GetPoseDriverOutput_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverOutput");
			return EPoseDriverOutput.DrivePoses;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPoseDriverOutput_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPoseDriverOutput_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPoseDriverOutput_FunctionAddress, intPtr, GetPoseDriverOutput_ParamsSize);
		return EnumMarshaler<EPoseDriverOutput>.FromNative(IntPtr.Add(intPtr, GetPoseDriverOutput_ReturnValue_Offset), 0, GetPoseDriverOutput_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetOnlyDriveSelectedBones")]
	public unsafe bool GetOnlyDriveSelectedBones()
	{
		CheckDestroyed();
		if (!GetOnlyDriveSelectedBones_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetOnlyDriveSelectedBones");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOnlyDriveSelectedBones_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOnlyDriveSelectedBones_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetOnlyDriveSelectedBones_FunctionAddress, intPtr, GetOnlyDriveSelectedBones_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetOnlyDriveSelectedBones_ReturnValue_Offset), 0, GetOnlyDriveSelectedBones_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 339870721u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetDrivingBoneNames")]
	public unsafe void GetDrivingBoneNames(out List<FName> BoneNames)
	{
		CheckDestroyed();
		if (!GetDrivingBoneNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetDrivingBoneNames");
			BoneNames = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDrivingBoneNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDrivingBoneNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDrivingBoneNames_FunctionAddress, intPtr, GetDrivingBoneNames_ParamsSize);
		BoneNames = new TArrayCopyMarshaler<FName>(1, GetDrivingBoneNames_BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetDrivingBoneNames_BoneNames_Offset));
		NativeReflection.DestroyValue_InContainer(GetDrivingBoneNames_BoneNames_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/AnimGraph.AnimGraphNode_PoseDriver:CopyTargetsFromPoseAsset")]
	public unsafe void CopyTargetsFromPoseAsset()
	{
		CheckDestroyed();
		if (!CopyTargetsFromPoseAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/AnimGraph.AnimGraphNode_PoseDriver:CopyTargetsFromPoseAsset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyTargetsFromPoseAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyTargetsFromPoseAsset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: CopyTargetsFromPoseAsset_FunctionAddress, argsSize: CopyTargetsFromPoseAsset_ParamsSize);
	}

	static UAnimGraphNode_PoseDriver()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimGraphNode_PoseDriver)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimGraphNode_PoseDriver));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/AnimGraph.AnimGraphNode_PoseDriver");
		Node_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Node");
		Node_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Node", Classes.FStructProperty);
		SetSourceBones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetSourceBones");
		SetSourceBones_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSourceBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSourceBones_BoneNames_PropertyAddress, SetSourceBones_FunctionAddress, "BoneNames");
		SetSourceBones_BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(SetSourceBones_FunctionAddress, "BoneNames");
		SetSourceBones_BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSourceBones_FunctionAddress, "BoneNames", Classes.FArrayProperty);
		SetSourceBones_IsValid = SetSourceBones_FunctionAddress != IntPtr.Zero && SetSourceBones_BoneNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetSourceBones", SetSourceBones_IsValid);
		SetRBFParameters_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetRBFParameters");
		SetRBFParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(SetRBFParameters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetRBFParameters_Parameters_PropertyAddress, SetRBFParameters_FunctionAddress, "Parameters");
		SetRBFParameters_Parameters_Offset = NativeReflectionCached.GetPropertyOffset(SetRBFParameters_FunctionAddress, "Parameters");
		SetRBFParameters_Parameters_IsValid = NativeReflectionCached.ValidatePropertyClass(SetRBFParameters_FunctionAddress, "Parameters", Classes.FStructProperty);
		SetRBFParameters_IsValid = SetRBFParameters_FunctionAddress != IntPtr.Zero && SetRBFParameters_Parameters_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetRBFParameters", SetRBFParameters_IsValid);
		SetPoseDriverSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPoseDriverSource");
		SetPoseDriverSource_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPoseDriverSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPoseDriverSource_DriverSource_PropertyAddress, SetPoseDriverSource_FunctionAddress, "DriverSource");
		SetPoseDriverSource_DriverSource_Offset = NativeReflectionCached.GetPropertyOffset(SetPoseDriverSource_FunctionAddress, "DriverSource");
		SetPoseDriverSource_DriverSource_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPoseDriverSource_FunctionAddress, "DriverSource", Classes.FEnumProperty);
		SetPoseDriverSource_IsValid = SetPoseDriverSource_FunctionAddress != IntPtr.Zero && SetPoseDriverSource_DriverSource_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverSource", SetPoseDriverSource_IsValid);
		SetPoseDriverOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPoseDriverOutput");
		SetPoseDriverOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPoseDriverOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPoseDriverOutput_DriverOutput_PropertyAddress, SetPoseDriverOutput_FunctionAddress, "DriverOutput");
		SetPoseDriverOutput_DriverOutput_Offset = NativeReflectionCached.GetPropertyOffset(SetPoseDriverOutput_FunctionAddress, "DriverOutput");
		SetPoseDriverOutput_DriverOutput_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPoseDriverOutput_FunctionAddress, "DriverOutput", Classes.FEnumProperty);
		SetPoseDriverOutput_IsValid = SetPoseDriverOutput_FunctionAddress != IntPtr.Zero && SetPoseDriverOutput_DriverOutput_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetPoseDriverOutput", SetPoseDriverOutput_IsValid);
		SetOnlyDriveSelectedBones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetOnlyDriveSelectedBones");
		SetOnlyDriveSelectedBones_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOnlyDriveSelectedBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_PropertyAddress, SetOnlyDriveSelectedBones_FunctionAddress, "bOnlyDriveSelectedBones");
		SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_Offset = NativeReflectionCached.GetPropertyOffset(SetOnlyDriveSelectedBones_FunctionAddress, "bOnlyDriveSelectedBones");
		SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOnlyDriveSelectedBones_FunctionAddress, "bOnlyDriveSelectedBones", Classes.FBoolProperty);
		SetOnlyDriveSelectedBones_IsValid = SetOnlyDriveSelectedBones_FunctionAddress != IntPtr.Zero && SetOnlyDriveSelectedBones_bOnlyDriveSelectedBones_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetOnlyDriveSelectedBones", SetOnlyDriveSelectedBones_IsValid);
		SetDrivingBones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetDrivingBones");
		SetDrivingBones_ParamsSize = NativeReflection.GetFunctionParamsSize(SetDrivingBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetDrivingBones_BoneNames_PropertyAddress, SetDrivingBones_FunctionAddress, "BoneNames");
		SetDrivingBones_BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(SetDrivingBones_FunctionAddress, "BoneNames");
		SetDrivingBones_BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(SetDrivingBones_FunctionAddress, "BoneNames", Classes.FArrayProperty);
		SetDrivingBones_IsValid = SetDrivingBones_FunctionAddress != IntPtr.Zero && SetDrivingBones_BoneNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:SetDrivingBones", SetDrivingBones_IsValid);
		GetSourceBoneNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSourceBoneNames");
		GetSourceBoneNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSourceBoneNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSourceBoneNames_BoneNames_PropertyAddress, GetSourceBoneNames_FunctionAddress, "BoneNames");
		GetSourceBoneNames_BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(GetSourceBoneNames_FunctionAddress, "BoneNames");
		GetSourceBoneNames_BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSourceBoneNames_FunctionAddress, "BoneNames", Classes.FArrayProperty);
		GetSourceBoneNames_IsValid = GetSourceBoneNames_FunctionAddress != IntPtr.Zero && GetSourceBoneNames_BoneNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetSourceBoneNames", GetSourceBoneNames_IsValid);
		GetRBFParameters_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetRBFParameters");
		GetRBFParameters_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRBFParameters_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRBFParameters_ReturnValue_PropertyAddress, GetRBFParameters_FunctionAddress, "ReturnValue");
		GetRBFParameters_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRBFParameters_FunctionAddress, "ReturnValue");
		GetRBFParameters_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRBFParameters_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetRBFParameters_IsValid = GetRBFParameters_FunctionAddress != IntPtr.Zero && GetRBFParameters_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetRBFParameters", GetRBFParameters_IsValid);
		GetPoseDriverSource_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPoseDriverSource");
		GetPoseDriverSource_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPoseDriverSource_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPoseDriverSource_ReturnValue_PropertyAddress, GetPoseDriverSource_FunctionAddress, "ReturnValue");
		GetPoseDriverSource_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPoseDriverSource_FunctionAddress, "ReturnValue");
		GetPoseDriverSource_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPoseDriverSource_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPoseDriverSource_IsValid = GetPoseDriverSource_FunctionAddress != IntPtr.Zero && GetPoseDriverSource_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverSource", GetPoseDriverSource_IsValid);
		GetPoseDriverOutput_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPoseDriverOutput");
		GetPoseDriverOutput_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPoseDriverOutput_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPoseDriverOutput_ReturnValue_PropertyAddress, GetPoseDriverOutput_FunctionAddress, "ReturnValue");
		GetPoseDriverOutput_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPoseDriverOutput_FunctionAddress, "ReturnValue");
		GetPoseDriverOutput_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPoseDriverOutput_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPoseDriverOutput_IsValid = GetPoseDriverOutput_FunctionAddress != IntPtr.Zero && GetPoseDriverOutput_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetPoseDriverOutput", GetPoseDriverOutput_IsValid);
		GetOnlyDriveSelectedBones_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetOnlyDriveSelectedBones");
		GetOnlyDriveSelectedBones_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOnlyDriveSelectedBones_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOnlyDriveSelectedBones_ReturnValue_PropertyAddress, GetOnlyDriveSelectedBones_FunctionAddress, "ReturnValue");
		GetOnlyDriveSelectedBones_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOnlyDriveSelectedBones_FunctionAddress, "ReturnValue");
		GetOnlyDriveSelectedBones_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOnlyDriveSelectedBones_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetOnlyDriveSelectedBones_IsValid = GetOnlyDriveSelectedBones_FunctionAddress != IntPtr.Zero && GetOnlyDriveSelectedBones_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetOnlyDriveSelectedBones", GetOnlyDriveSelectedBones_IsValid);
		GetDrivingBoneNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDrivingBoneNames");
		GetDrivingBoneNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDrivingBoneNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDrivingBoneNames_BoneNames_PropertyAddress, GetDrivingBoneNames_FunctionAddress, "BoneNames");
		GetDrivingBoneNames_BoneNames_Offset = NativeReflectionCached.GetPropertyOffset(GetDrivingBoneNames_FunctionAddress, "BoneNames");
		GetDrivingBoneNames_BoneNames_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDrivingBoneNames_FunctionAddress, "BoneNames", Classes.FArrayProperty);
		GetDrivingBoneNames_IsValid = GetDrivingBoneNames_FunctionAddress != IntPtr.Zero && GetDrivingBoneNames_BoneNames_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:GetDrivingBoneNames", GetDrivingBoneNames_IsValid);
		CopyTargetsFromPoseAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "CopyTargetsFromPoseAsset");
		CopyTargetsFromPoseAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyTargetsFromPoseAsset_FunctionAddress);
		CopyTargetsFromPoseAsset_IsValid = CopyTargetsFromPoseAsset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/AnimGraph.AnimGraphNode_PoseDriver:CopyTargetsFromPoseAsset", CopyTargetsFromPoseAsset_IsValid);
	}
}
