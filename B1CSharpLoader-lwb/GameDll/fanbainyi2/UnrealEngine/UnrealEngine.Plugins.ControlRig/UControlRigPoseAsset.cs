using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ControlRig;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ControlRig.ControlRigPoseAsset", "ControlRig", UnrealModuleType.EnginePlugin)]
public class UControlRigPoseAsset : UObject
{
	private static bool Pose_IsValid;

	private static int Pose_Offset;

	private static bool SelectControls_IsValid;

	private static IntPtr SelectControls_FunctionAddress;

	private static int SelectControls_ParamsSize;

	private static bool SelectControls_InControlRig_IsValid;

	private static FFieldAddress SelectControls_InControlRig_PropertyAddress;

	private static int SelectControls_InControlRig_Offset;

	private static bool SelectControls_bDoMirror_IsValid;

	private static FFieldAddress SelectControls_bDoMirror_PropertyAddress;

	private static int SelectControls_bDoMirror_Offset;

	private static bool SavePose_IsValid;

	private static IntPtr SavePose_FunctionAddress;

	private static int SavePose_ParamsSize;

	private static bool SavePose_InControlRig_IsValid;

	private static FFieldAddress SavePose_InControlRig_PropertyAddress;

	private static int SavePose_InControlRig_Offset;

	private static bool SavePose_bUseAll_IsValid;

	private static FFieldAddress SavePose_bUseAll_PropertyAddress;

	private static int SavePose_bUseAll_Offset;

	private static bool ReplaceControlName_IsValid;

	private static IntPtr ReplaceControlName_FunctionAddress;

	private static int ReplaceControlName_ParamsSize;

	private static bool ReplaceControlName_CurrentName_IsValid;

	private static FFieldAddress ReplaceControlName_CurrentName_PropertyAddress;

	private static int ReplaceControlName_CurrentName_Offset;

	private static bool ReplaceControlName_NewName_IsValid;

	private static FFieldAddress ReplaceControlName_NewName_PropertyAddress;

	private static int ReplaceControlName_NewName_Offset;

	private static bool PastePose_IsValid;

	private static IntPtr PastePose_FunctionAddress;

	private static int PastePose_ParamsSize;

	private static bool PastePose_InControlRig_IsValid;

	private static FFieldAddress PastePose_InControlRig_PropertyAddress;

	private static int PastePose_InControlRig_Offset;

	private static bool PastePose_bDoKey_IsValid;

	private static FFieldAddress PastePose_bDoKey_PropertyAddress;

	private static int PastePose_bDoKey_Offset;

	private static bool PastePose_bDoMirror_IsValid;

	private static FFieldAddress PastePose_bDoMirror_PropertyAddress;

	private static int PastePose_bDoMirror_Offset;

	private static bool GetCurrentPose_IsValid;

	private static IntPtr GetCurrentPose_FunctionAddress;

	private static int GetCurrentPose_ParamsSize;

	private static bool GetCurrentPose_InControlRig_IsValid;

	private static FFieldAddress GetCurrentPose_InControlRig_PropertyAddress;

	private static int GetCurrentPose_InControlRig_Offset;

	private static bool GetCurrentPose_OutPose_IsValid;

	private static FFieldAddress GetCurrentPose_OutPose_PropertyAddress;

	private static int GetCurrentPose_OutPose_Offset;

	private static bool GetControlNames_IsValid;

	private static IntPtr GetControlNames_FunctionAddress;

	private static int GetControlNames_ParamsSize;

	private static bool GetControlNames_ReturnValue_IsValid;

	private static FFieldAddress GetControlNames_ReturnValue_PropertyAddress;

	private static int GetControlNames_ReturnValue_Offset;

	private static bool DoesMirrorMatch_IsValid;

	private static IntPtr DoesMirrorMatch_FunctionAddress;

	private static int DoesMirrorMatch_ParamsSize;

	private static bool DoesMirrorMatch_ControlRig_IsValid;

	private static FFieldAddress DoesMirrorMatch_ControlRig_PropertyAddress;

	private static int DoesMirrorMatch_ControlRig_Offset;

	private static bool DoesMirrorMatch_ControlName_IsValid;

	private static FFieldAddress DoesMirrorMatch_ControlName_PropertyAddress;

	private static int DoesMirrorMatch_ControlName_Offset;

	private static bool DoesMirrorMatch_ReturnValue_IsValid;

	private static FFieldAddress DoesMirrorMatch_ReturnValue_PropertyAddress;

	private static int DoesMirrorMatch_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:Pose")]
	public FControlRigControlPose Pose
	{
		get
		{
			CheckDestroyed();
			if (!Pose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigPoseAsset:Pose");
				return default(FControlRigControlPose);
			}
			return FControlRigControlPose.FromNative(IntPtr.Add(base.Address, Pose_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Pose_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/ControlRig.ControlRigPoseAsset:Pose");
			}
			else
			{
				FControlRigControlPose.ToNative(IntPtr.Add(base.Address, Pose_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:SelectControls")]
	public unsafe void SelectControls(UControlRig InControlRig, bool bDoMirror = false)
	{
		CheckDestroyed();
		if (!SelectControls_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigPoseAsset:SelectControls");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SelectControls_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SelectControls_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, SelectControls_InControlRig_Offset), 0, SelectControls_InControlRig_PropertyAddress.Address, InControlRig);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SelectControls_bDoMirror_Offset), 0, SelectControls_bDoMirror_PropertyAddress.Address, bDoMirror);
		NativeReflection.InvokeFunctionOptimized(base.Address, SelectControls_FunctionAddress, intPtr, SelectControls_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:SavePose")]
	public unsafe void SavePose(UControlRig InControlRig, bool bUseAll)
	{
		CheckDestroyed();
		if (!SavePose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigPoseAsset:SavePose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SavePose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SavePose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, SavePose_InControlRig_Offset), 0, SavePose_InControlRig_PropertyAddress.Address, InControlRig);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SavePose_bUseAll_Offset), 0, SavePose_bUseAll_PropertyAddress.Address, bUseAll);
		NativeReflection.InvokeFunctionOptimized(base.Address, SavePose_FunctionAddress, intPtr, SavePose_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:ReplaceControlName")]
	public unsafe void ReplaceControlName(FName CurrentName, FName NewName)
	{
		CheckDestroyed();
		if (!ReplaceControlName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigPoseAsset:ReplaceControlName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReplaceControlName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReplaceControlName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReplaceControlName_CurrentName_Offset), 0, ReplaceControlName_CurrentName_PropertyAddress.Address, CurrentName);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ReplaceControlName_NewName_Offset), 0, ReplaceControlName_NewName_PropertyAddress.Address, NewName);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReplaceControlName_FunctionAddress, intPtr, ReplaceControlName_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:PastePose")]
	public unsafe void PastePose(UControlRig InControlRig, bool bDoKey = false, bool bDoMirror = false)
	{
		CheckDestroyed();
		if (!PastePose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigPoseAsset:PastePose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PastePose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PastePose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, PastePose_InControlRig_Offset), 0, PastePose_InControlRig_PropertyAddress.Address, InControlRig);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PastePose_bDoKey_Offset), 0, PastePose_bDoKey_PropertyAddress.Address, bDoKey);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, PastePose_bDoMirror_Offset), 0, PastePose_bDoMirror_PropertyAddress.Address, bDoMirror);
		NativeReflection.InvokeFunctionOptimized(base.Address, PastePose_FunctionAddress, intPtr, PastePose_ParamsSize);
	}

	[UFunction(Flags = 71435265u)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:GetCurrentPose")]
	public unsafe void GetCurrentPose(UControlRig InControlRig, out FControlRigControlPose OutPose)
	{
		CheckDestroyed();
		if (!GetCurrentPose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigPoseAsset:GetCurrentPose");
			OutPose = default(FControlRigControlPose);
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentPose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentPose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, GetCurrentPose_InControlRig_Offset), 0, GetCurrentPose_InControlRig_PropertyAddress.Address, InControlRig);
		NativeReflection.InitializeValue_InContainer(GetCurrentPose_OutPose_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetCurrentPose_FunctionAddress, intPtr, GetCurrentPose_ParamsSize);
		OutPose = FControlRigControlPose.FromNative(IntPtr.Add(intPtr, GetCurrentPose_OutPose_Offset), 0, GetCurrentPose_OutPose_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetCurrentPose_OutPose_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:GetControlNames")]
	public unsafe List<FName> GetControlNames()
	{
		CheckDestroyed();
		if (!GetControlNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigPoseAsset:GetControlNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetControlNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetControlNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetControlNames_FunctionAddress, intPtr, GetControlNames_ParamsSize);
		List<FName> result = new TArrayCopyMarshaler<FName>(1, GetControlNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative).FromNative(IntPtr.Add(intPtr, GetControlNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetControlNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/ControlRig.ControlRigPoseAsset:DoesMirrorMatch")]
	public unsafe bool DoesMirrorMatch(UControlRig ControlRig, FName ControlName)
	{
		CheckDestroyed();
		if (!DoesMirrorMatch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ControlRig.ControlRigPoseAsset:DoesMirrorMatch");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DoesMirrorMatch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DoesMirrorMatch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UControlRig>.ToNative(IntPtr.Add(intPtr, DoesMirrorMatch_ControlRig_Offset), 0, DoesMirrorMatch_ControlRig_PropertyAddress.Address, ControlRig);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, DoesMirrorMatch_ControlName_Offset), 0, DoesMirrorMatch_ControlName_PropertyAddress.Address, ControlName);
		NativeReflection.InvokeFunctionOptimized(base.Address, DoesMirrorMatch_FunctionAddress, intPtr, DoesMirrorMatch_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, DoesMirrorMatch_ReturnValue_Offset), 0, DoesMirrorMatch_ReturnValue_PropertyAddress.Address);
	}

	static UControlRigPoseAsset()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UControlRigPoseAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UControlRigPoseAsset));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/ControlRig.ControlRigPoseAsset");
		Pose_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Pose");
		Pose_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Pose", Classes.FStructProperty);
		SelectControls_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SelectControls");
		SelectControls_ParamsSize = NativeReflection.GetFunctionParamsSize(SelectControls_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SelectControls_InControlRig_PropertyAddress, SelectControls_FunctionAddress, "InControlRig");
		SelectControls_InControlRig_Offset = NativeReflectionCached.GetPropertyOffset(SelectControls_FunctionAddress, "InControlRig");
		SelectControls_InControlRig_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectControls_FunctionAddress, "InControlRig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SelectControls_bDoMirror_PropertyAddress, SelectControls_FunctionAddress, "bDoMirror");
		SelectControls_bDoMirror_Offset = NativeReflectionCached.GetPropertyOffset(SelectControls_FunctionAddress, "bDoMirror");
		SelectControls_bDoMirror_IsValid = NativeReflectionCached.ValidatePropertyClass(SelectControls_FunctionAddress, "bDoMirror", Classes.FBoolProperty);
		SelectControls_IsValid = SelectControls_FunctionAddress != IntPtr.Zero && SelectControls_InControlRig_IsValid && SelectControls_bDoMirror_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigPoseAsset:SelectControls", SelectControls_IsValid);
		SavePose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SavePose");
		SavePose_ParamsSize = NativeReflection.GetFunctionParamsSize(SavePose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SavePose_InControlRig_PropertyAddress, SavePose_FunctionAddress, "InControlRig");
		SavePose_InControlRig_Offset = NativeReflectionCached.GetPropertyOffset(SavePose_FunctionAddress, "InControlRig");
		SavePose_InControlRig_IsValid = NativeReflectionCached.ValidatePropertyClass(SavePose_FunctionAddress, "InControlRig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SavePose_bUseAll_PropertyAddress, SavePose_FunctionAddress, "bUseAll");
		SavePose_bUseAll_Offset = NativeReflectionCached.GetPropertyOffset(SavePose_FunctionAddress, "bUseAll");
		SavePose_bUseAll_IsValid = NativeReflectionCached.ValidatePropertyClass(SavePose_FunctionAddress, "bUseAll", Classes.FBoolProperty);
		SavePose_IsValid = SavePose_FunctionAddress != IntPtr.Zero && SavePose_InControlRig_IsValid && SavePose_bUseAll_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigPoseAsset:SavePose", SavePose_IsValid);
		ReplaceControlName_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReplaceControlName");
		ReplaceControlName_ParamsSize = NativeReflection.GetFunctionParamsSize(ReplaceControlName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReplaceControlName_CurrentName_PropertyAddress, ReplaceControlName_FunctionAddress, "CurrentName");
		ReplaceControlName_CurrentName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceControlName_FunctionAddress, "CurrentName");
		ReplaceControlName_CurrentName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceControlName_FunctionAddress, "CurrentName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ReplaceControlName_NewName_PropertyAddress, ReplaceControlName_FunctionAddress, "NewName");
		ReplaceControlName_NewName_Offset = NativeReflectionCached.GetPropertyOffset(ReplaceControlName_FunctionAddress, "NewName");
		ReplaceControlName_NewName_IsValid = NativeReflectionCached.ValidatePropertyClass(ReplaceControlName_FunctionAddress, "NewName", Classes.FNameProperty);
		ReplaceControlName_IsValid = ReplaceControlName_FunctionAddress != IntPtr.Zero && ReplaceControlName_CurrentName_IsValid && ReplaceControlName_NewName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigPoseAsset:ReplaceControlName", ReplaceControlName_IsValid);
		PastePose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PastePose");
		PastePose_ParamsSize = NativeReflection.GetFunctionParamsSize(PastePose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PastePose_InControlRig_PropertyAddress, PastePose_FunctionAddress, "InControlRig");
		PastePose_InControlRig_Offset = NativeReflectionCached.GetPropertyOffset(PastePose_FunctionAddress, "InControlRig");
		PastePose_InControlRig_IsValid = NativeReflectionCached.ValidatePropertyClass(PastePose_FunctionAddress, "InControlRig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref PastePose_bDoKey_PropertyAddress, PastePose_FunctionAddress, "bDoKey");
		PastePose_bDoKey_Offset = NativeReflectionCached.GetPropertyOffset(PastePose_FunctionAddress, "bDoKey");
		PastePose_bDoKey_IsValid = NativeReflectionCached.ValidatePropertyClass(PastePose_FunctionAddress, "bDoKey", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PastePose_bDoMirror_PropertyAddress, PastePose_FunctionAddress, "bDoMirror");
		PastePose_bDoMirror_Offset = NativeReflectionCached.GetPropertyOffset(PastePose_FunctionAddress, "bDoMirror");
		PastePose_bDoMirror_IsValid = NativeReflectionCached.ValidatePropertyClass(PastePose_FunctionAddress, "bDoMirror", Classes.FBoolProperty);
		PastePose_IsValid = PastePose_FunctionAddress != IntPtr.Zero && PastePose_InControlRig_IsValid && PastePose_bDoKey_IsValid && PastePose_bDoMirror_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigPoseAsset:PastePose", PastePose_IsValid);
		GetCurrentPose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetCurrentPose");
		GetCurrentPose_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentPose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPose_InControlRig_PropertyAddress, GetCurrentPose_FunctionAddress, "InControlRig");
		GetCurrentPose_InControlRig_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPose_FunctionAddress, "InControlRig");
		GetCurrentPose_InControlRig_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPose_FunctionAddress, "InControlRig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentPose_OutPose_PropertyAddress, GetCurrentPose_FunctionAddress, "OutPose");
		GetCurrentPose_OutPose_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentPose_FunctionAddress, "OutPose");
		GetCurrentPose_OutPose_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentPose_FunctionAddress, "OutPose", Classes.FStructProperty);
		GetCurrentPose_IsValid = GetCurrentPose_FunctionAddress != IntPtr.Zero && GetCurrentPose_InControlRig_IsValid && GetCurrentPose_OutPose_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigPoseAsset:GetCurrentPose", GetCurrentPose_IsValid);
		GetControlNames_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetControlNames");
		GetControlNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetControlNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetControlNames_ReturnValue_PropertyAddress, GetControlNames_FunctionAddress, "ReturnValue");
		GetControlNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetControlNames_FunctionAddress, "ReturnValue");
		GetControlNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetControlNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetControlNames_IsValid = GetControlNames_FunctionAddress != IntPtr.Zero && GetControlNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigPoseAsset:GetControlNames", GetControlNames_IsValid);
		DoesMirrorMatch_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoesMirrorMatch");
		DoesMirrorMatch_ParamsSize = NativeReflection.GetFunctionParamsSize(DoesMirrorMatch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref DoesMirrorMatch_ControlRig_PropertyAddress, DoesMirrorMatch_FunctionAddress, "ControlRig");
		DoesMirrorMatch_ControlRig_Offset = NativeReflectionCached.GetPropertyOffset(DoesMirrorMatch_FunctionAddress, "ControlRig");
		DoesMirrorMatch_ControlRig_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesMirrorMatch_FunctionAddress, "ControlRig", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesMirrorMatch_ControlName_PropertyAddress, DoesMirrorMatch_FunctionAddress, "ControlName");
		DoesMirrorMatch_ControlName_Offset = NativeReflectionCached.GetPropertyOffset(DoesMirrorMatch_FunctionAddress, "ControlName");
		DoesMirrorMatch_ControlName_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesMirrorMatch_FunctionAddress, "ControlName", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref DoesMirrorMatch_ReturnValue_PropertyAddress, DoesMirrorMatch_FunctionAddress, "ReturnValue");
		DoesMirrorMatch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(DoesMirrorMatch_FunctionAddress, "ReturnValue");
		DoesMirrorMatch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(DoesMirrorMatch_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		DoesMirrorMatch_IsValid = DoesMirrorMatch_FunctionAddress != IntPtr.Zero && DoesMirrorMatch_ControlRig_IsValid && DoesMirrorMatch_ControlName_IsValid && DoesMirrorMatch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ControlRig.ControlRigPoseAsset:DoesMirrorMatch", DoesMirrorMatch_IsValid);
	}
}
