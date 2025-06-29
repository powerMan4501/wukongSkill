using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.SplineMeshComponent", "Engine", UnrealModuleType.Engine)]
public class USplineMeshComponent : UStaticMeshComponent, IInterface_CollisionDataProvider, IInterface
{
	private static bool UpdateMesh_IsValid;

	private static IntPtr UpdateMesh_FunctionAddress;

	private static int UpdateMesh_ParamsSize;

	private static bool SetStartTangent_IsValid;

	private static IntPtr SetStartTangent_FunctionAddress;

	private static int SetStartTangent_ParamsSize;

	private static bool SetStartTangent_StartTangent_IsValid;

	private static FFieldAddress SetStartTangent_StartTangent_PropertyAddress;

	private static int SetStartTangent_StartTangent_Offset;

	private static bool SetStartTangent_bUpdateMesh_IsValid;

	private static FFieldAddress SetStartTangent_bUpdateMesh_PropertyAddress;

	private static int SetStartTangent_bUpdateMesh_Offset;

	private static bool SetStartScale_IsValid;

	private static IntPtr SetStartScale_FunctionAddress;

	private static int SetStartScale_ParamsSize;

	private static bool SetStartScale_StartScale_IsValid;

	private static FFieldAddress SetStartScale_StartScale_PropertyAddress;

	private static int SetStartScale_StartScale_Offset;

	private static bool SetStartScale_bUpdateMesh_IsValid;

	private static FFieldAddress SetStartScale_bUpdateMesh_PropertyAddress;

	private static int SetStartScale_bUpdateMesh_Offset;

	private static bool SetStartRoll_IsValid;

	private static IntPtr SetStartRoll_FunctionAddress;

	private static int SetStartRoll_ParamsSize;

	private static bool SetStartRoll_StartRoll_IsValid;

	private static FFieldAddress SetStartRoll_StartRoll_PropertyAddress;

	private static int SetStartRoll_StartRoll_Offset;

	private static bool SetStartRoll_bUpdateMesh_IsValid;

	private static FFieldAddress SetStartRoll_bUpdateMesh_PropertyAddress;

	private static int SetStartRoll_bUpdateMesh_Offset;

	private static bool SetStartPosition_IsValid;

	private static IntPtr SetStartPosition_FunctionAddress;

	private static int SetStartPosition_ParamsSize;

	private static bool SetStartPosition_StartPos_IsValid;

	private static FFieldAddress SetStartPosition_StartPos_PropertyAddress;

	private static int SetStartPosition_StartPos_Offset;

	private static bool SetStartPosition_bUpdateMesh_IsValid;

	private static FFieldAddress SetStartPosition_bUpdateMesh_PropertyAddress;

	private static int SetStartPosition_bUpdateMesh_Offset;

	private static bool SetStartOffset_IsValid;

	private static IntPtr SetStartOffset_FunctionAddress;

	private static int SetStartOffset_ParamsSize;

	private static bool SetStartOffset_StartOffset_IsValid;

	private static FFieldAddress SetStartOffset_StartOffset_PropertyAddress;

	private static int SetStartOffset_StartOffset_Offset;

	private static bool SetStartOffset_bUpdateMesh_IsValid;

	private static FFieldAddress SetStartOffset_bUpdateMesh_PropertyAddress;

	private static int SetStartOffset_bUpdateMesh_Offset;

	private static bool SetStartAndEnd_IsValid;

	private static IntPtr SetStartAndEnd_FunctionAddress;

	private static int SetStartAndEnd_ParamsSize;

	private static bool SetStartAndEnd_StartPos_IsValid;

	private static FFieldAddress SetStartAndEnd_StartPos_PropertyAddress;

	private static int SetStartAndEnd_StartPos_Offset;

	private static bool SetStartAndEnd_StartTangent_IsValid;

	private static FFieldAddress SetStartAndEnd_StartTangent_PropertyAddress;

	private static int SetStartAndEnd_StartTangent_Offset;

	private static bool SetStartAndEnd_EndPos_IsValid;

	private static FFieldAddress SetStartAndEnd_EndPos_PropertyAddress;

	private static int SetStartAndEnd_EndPos_Offset;

	private static bool SetStartAndEnd_EndTangent_IsValid;

	private static FFieldAddress SetStartAndEnd_EndTangent_PropertyAddress;

	private static int SetStartAndEnd_EndTangent_Offset;

	private static bool SetStartAndEnd_bUpdateMesh_IsValid;

	private static FFieldAddress SetStartAndEnd_bUpdateMesh_PropertyAddress;

	private static int SetStartAndEnd_bUpdateMesh_Offset;

	private static bool SetSplineUpDir_IsValid;

	private static IntPtr SetSplineUpDir_FunctionAddress;

	private static int SetSplineUpDir_ParamsSize;

	private static bool SetSplineUpDir_InSplineUpDir_IsValid;

	private static FFieldAddress SetSplineUpDir_InSplineUpDir_PropertyAddress;

	private static int SetSplineUpDir_InSplineUpDir_Offset;

	private static bool SetSplineUpDir_bUpdateMesh_IsValid;

	private static FFieldAddress SetSplineUpDir_bUpdateMesh_PropertyAddress;

	private static int SetSplineUpDir_bUpdateMesh_Offset;

	private static bool SetForwardAxis_IsValid;

	private static IntPtr SetForwardAxis_FunctionAddress;

	private static int SetForwardAxis_ParamsSize;

	private static bool SetForwardAxis_InForwardAxis_IsValid;

	private static FFieldAddress SetForwardAxis_InForwardAxis_PropertyAddress;

	private static int SetForwardAxis_InForwardAxis_Offset;

	private static bool SetForwardAxis_bUpdateMesh_IsValid;

	private static FFieldAddress SetForwardAxis_bUpdateMesh_PropertyAddress;

	private static int SetForwardAxis_bUpdateMesh_Offset;

	private static bool SetEndTangent_IsValid;

	private static IntPtr SetEndTangent_FunctionAddress;

	private static int SetEndTangent_ParamsSize;

	private static bool SetEndTangent_EndTangent_IsValid;

	private static FFieldAddress SetEndTangent_EndTangent_PropertyAddress;

	private static int SetEndTangent_EndTangent_Offset;

	private static bool SetEndTangent_bUpdateMesh_IsValid;

	private static FFieldAddress SetEndTangent_bUpdateMesh_PropertyAddress;

	private static int SetEndTangent_bUpdateMesh_Offset;

	private static bool SetEndScale_IsValid;

	private static IntPtr SetEndScale_FunctionAddress;

	private static int SetEndScale_ParamsSize;

	private static bool SetEndScale_EndScale_IsValid;

	private static FFieldAddress SetEndScale_EndScale_PropertyAddress;

	private static int SetEndScale_EndScale_Offset;

	private static bool SetEndScale_bUpdateMesh_IsValid;

	private static FFieldAddress SetEndScale_bUpdateMesh_PropertyAddress;

	private static int SetEndScale_bUpdateMesh_Offset;

	private static bool SetEndRoll_IsValid;

	private static IntPtr SetEndRoll_FunctionAddress;

	private static int SetEndRoll_ParamsSize;

	private static bool SetEndRoll_EndRoll_IsValid;

	private static FFieldAddress SetEndRoll_EndRoll_PropertyAddress;

	private static int SetEndRoll_EndRoll_Offset;

	private static bool SetEndRoll_bUpdateMesh_IsValid;

	private static FFieldAddress SetEndRoll_bUpdateMesh_PropertyAddress;

	private static int SetEndRoll_bUpdateMesh_Offset;

	private static bool SetEndPosition_IsValid;

	private static IntPtr SetEndPosition_FunctionAddress;

	private static int SetEndPosition_ParamsSize;

	private static bool SetEndPosition_EndPos_IsValid;

	private static FFieldAddress SetEndPosition_EndPos_PropertyAddress;

	private static int SetEndPosition_EndPos_Offset;

	private static bool SetEndPosition_bUpdateMesh_IsValid;

	private static FFieldAddress SetEndPosition_bUpdateMesh_PropertyAddress;

	private static int SetEndPosition_bUpdateMesh_Offset;

	private static bool SetEndOffset_IsValid;

	private static IntPtr SetEndOffset_FunctionAddress;

	private static int SetEndOffset_ParamsSize;

	private static bool SetEndOffset_EndOffset_IsValid;

	private static FFieldAddress SetEndOffset_EndOffset_PropertyAddress;

	private static int SetEndOffset_EndOffset_Offset;

	private static bool SetEndOffset_bUpdateMesh_IsValid;

	private static FFieldAddress SetEndOffset_bUpdateMesh_PropertyAddress;

	private static int SetEndOffset_bUpdateMesh_Offset;

	private static bool SetBoundaryMin_IsValid;

	private static IntPtr SetBoundaryMin_FunctionAddress;

	private static int SetBoundaryMin_ParamsSize;

	private static bool SetBoundaryMin_InBoundaryMin_IsValid;

	private static FFieldAddress SetBoundaryMin_InBoundaryMin_PropertyAddress;

	private static int SetBoundaryMin_InBoundaryMin_Offset;

	private static bool SetBoundaryMin_bUpdateMesh_IsValid;

	private static FFieldAddress SetBoundaryMin_bUpdateMesh_PropertyAddress;

	private static int SetBoundaryMin_bUpdateMesh_Offset;

	private static bool SetBoundaryMax_IsValid;

	private static IntPtr SetBoundaryMax_FunctionAddress;

	private static int SetBoundaryMax_ParamsSize;

	private static bool SetBoundaryMax_InBoundaryMax_IsValid;

	private static FFieldAddress SetBoundaryMax_InBoundaryMax_PropertyAddress;

	private static int SetBoundaryMax_InBoundaryMax_Offset;

	private static bool SetBoundaryMax_bUpdateMesh_IsValid;

	private static FFieldAddress SetBoundaryMax_bUpdateMesh_PropertyAddress;

	private static int SetBoundaryMax_bUpdateMesh_Offset;

	private static bool GetStartTangent_IsValid;

	private static IntPtr GetStartTangent_FunctionAddress;

	private static int GetStartTangent_ParamsSize;

	private static bool GetStartTangent_ReturnValue_IsValid;

	private static FFieldAddress GetStartTangent_ReturnValue_PropertyAddress;

	private static int GetStartTangent_ReturnValue_Offset;

	private static bool GetStartScale_IsValid;

	private static IntPtr GetStartScale_FunctionAddress;

	private static int GetStartScale_ParamsSize;

	private static bool GetStartScale_ReturnValue_IsValid;

	private static FFieldAddress GetStartScale_ReturnValue_PropertyAddress;

	private static int GetStartScale_ReturnValue_Offset;

	private static bool GetStartRoll_IsValid;

	private static IntPtr GetStartRoll_FunctionAddress;

	private static int GetStartRoll_ParamsSize;

	private static bool GetStartRoll_ReturnValue_IsValid;

	private static FFieldAddress GetStartRoll_ReturnValue_PropertyAddress;

	private static int GetStartRoll_ReturnValue_Offset;

	private static bool GetStartPosition_IsValid;

	private static IntPtr GetStartPosition_FunctionAddress;

	private static int GetStartPosition_ParamsSize;

	private static bool GetStartPosition_ReturnValue_IsValid;

	private static FFieldAddress GetStartPosition_ReturnValue_PropertyAddress;

	private static int GetStartPosition_ReturnValue_Offset;

	private static bool GetStartOffset_IsValid;

	private static IntPtr GetStartOffset_FunctionAddress;

	private static int GetStartOffset_ParamsSize;

	private static bool GetStartOffset_ReturnValue_IsValid;

	private static FFieldAddress GetStartOffset_ReturnValue_PropertyAddress;

	private static int GetStartOffset_ReturnValue_Offset;

	private static bool GetSplineUpDir_IsValid;

	private static IntPtr GetSplineUpDir_FunctionAddress;

	private static int GetSplineUpDir_ParamsSize;

	private static bool GetSplineUpDir_ReturnValue_IsValid;

	private static FFieldAddress GetSplineUpDir_ReturnValue_PropertyAddress;

	private static int GetSplineUpDir_ReturnValue_Offset;

	private static bool GetForwardAxis_IsValid;

	private static IntPtr GetForwardAxis_FunctionAddress;

	private static int GetForwardAxis_ParamsSize;

	private static bool GetForwardAxis_ReturnValue_IsValid;

	private static FFieldAddress GetForwardAxis_ReturnValue_PropertyAddress;

	private static int GetForwardAxis_ReturnValue_Offset;

	private static bool GetEndTangent_IsValid;

	private static IntPtr GetEndTangent_FunctionAddress;

	private static int GetEndTangent_ParamsSize;

	private static bool GetEndTangent_ReturnValue_IsValid;

	private static FFieldAddress GetEndTangent_ReturnValue_PropertyAddress;

	private static int GetEndTangent_ReturnValue_Offset;

	private static bool GetEndScale_IsValid;

	private static IntPtr GetEndScale_FunctionAddress;

	private static int GetEndScale_ParamsSize;

	private static bool GetEndScale_ReturnValue_IsValid;

	private static FFieldAddress GetEndScale_ReturnValue_PropertyAddress;

	private static int GetEndScale_ReturnValue_Offset;

	private static bool GetEndRoll_IsValid;

	private static IntPtr GetEndRoll_FunctionAddress;

	private static int GetEndRoll_ParamsSize;

	private static bool GetEndRoll_ReturnValue_IsValid;

	private static FFieldAddress GetEndRoll_ReturnValue_PropertyAddress;

	private static int GetEndRoll_ReturnValue_Offset;

	private static bool GetEndPosition_IsValid;

	private static IntPtr GetEndPosition_FunctionAddress;

	private static int GetEndPosition_ParamsSize;

	private static bool GetEndPosition_ReturnValue_IsValid;

	private static FFieldAddress GetEndPosition_ReturnValue_PropertyAddress;

	private static int GetEndPosition_ReturnValue_Offset;

	private static bool GetEndOffset_IsValid;

	private static IntPtr GetEndOffset_FunctionAddress;

	private static int GetEndOffset_ParamsSize;

	private static bool GetEndOffset_ReturnValue_IsValid;

	private static FFieldAddress GetEndOffset_ReturnValue_PropertyAddress;

	private static int GetEndOffset_ReturnValue_Offset;

	private static bool GetBoundaryMin_IsValid;

	private static IntPtr GetBoundaryMin_FunctionAddress;

	private static int GetBoundaryMin_ParamsSize;

	private static bool GetBoundaryMin_ReturnValue_IsValid;

	private static FFieldAddress GetBoundaryMin_ReturnValue_PropertyAddress;

	private static int GetBoundaryMin_ReturnValue_Offset;

	private static bool GetBoundaryMax_IsValid;

	private static IntPtr GetBoundaryMax_FunctionAddress;

	private static int GetBoundaryMax_ParamsSize;

	private static bool GetBoundaryMax_ReturnValue_IsValid;

	private static FFieldAddress GetBoundaryMax_ReturnValue_PropertyAddress;

	private static int GetBoundaryMax_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:UpdateMesh")]
	public unsafe void UpdateMesh()
	{
		CheckDestroyed();
		if (!UpdateMesh_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:UpdateMesh");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateMesh_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateMesh_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateMesh_FunctionAddress, argsSize: UpdateMesh_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetStartTangent")]
	public unsafe void SetStartTangent(FVector StartTangent, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetStartTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetStartTangent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetStartTangent_StartTangent_Offset), 0, SetStartTangent_StartTangent_PropertyAddress.Address, StartTangent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartTangent_bUpdateMesh_Offset), 0, SetStartTangent_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartTangent_FunctionAddress, intPtr, SetStartTangent_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetStartScale")]
	public unsafe void SetStartScale(FVector2D StartScale, bool bUpdateMesh)
	{
		CheckDestroyed();
		if (!SetStartScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetStartScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetStartScale_StartScale_Offset), 0, SetStartScale_StartScale_PropertyAddress.Address, StartScale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartScale_bUpdateMesh_Offset), 0, SetStartScale_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartScale_FunctionAddress, intPtr, SetStartScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetStartRoll")]
	public unsafe void SetStartRoll(float StartRoll, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetStartRoll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetStartRoll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartRoll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartRoll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetStartRoll_StartRoll_Offset), 0, SetStartRoll_StartRoll_PropertyAddress.Address, StartRoll);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartRoll_bUpdateMesh_Offset), 0, SetStartRoll_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartRoll_FunctionAddress, intPtr, SetStartRoll_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetStartPosition")]
	public unsafe void SetStartPosition(FVector StartPos, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetStartPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetStartPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetStartPosition_StartPos_Offset), 0, SetStartPosition_StartPos_PropertyAddress.Address, StartPos);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartPosition_bUpdateMesh_Offset), 0, SetStartPosition_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartPosition_FunctionAddress, intPtr, SetStartPosition_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetStartOffset")]
	public unsafe void SetStartOffset(FVector2D StartOffset, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetStartOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetStartOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetStartOffset_StartOffset_Offset), 0, SetStartOffset_StartOffset_PropertyAddress.Address, StartOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartOffset_bUpdateMesh_Offset), 0, SetStartOffset_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartOffset_FunctionAddress, intPtr, SetStartOffset_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetStartAndEnd")]
	public unsafe void SetStartAndEnd(FVector StartPos, FVector StartTangent, FVector EndPos, FVector EndTangent, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetStartAndEnd_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetStartAndEnd");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartAndEnd_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartAndEnd_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetStartAndEnd_StartPos_Offset), 0, SetStartAndEnd_StartPos_PropertyAddress.Address, StartPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetStartAndEnd_StartTangent_Offset), 0, SetStartAndEnd_StartTangent_PropertyAddress.Address, StartTangent);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetStartAndEnd_EndPos_Offset), 0, SetStartAndEnd_EndPos_PropertyAddress.Address, EndPos);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetStartAndEnd_EndTangent_Offset), 0, SetStartAndEnd_EndTangent_PropertyAddress.Address, EndTangent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartAndEnd_bUpdateMesh_Offset), 0, SetStartAndEnd_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetStartAndEnd_FunctionAddress, intPtr, SetStartAndEnd_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetSplineUpDir")]
	public unsafe void SetSplineUpDir(FVector InSplineUpDir, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetSplineUpDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetSplineUpDir");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetSplineUpDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetSplineUpDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetSplineUpDir_InSplineUpDir_Offset), 0, SetSplineUpDir_InSplineUpDir_PropertyAddress.Address, InSplineUpDir);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetSplineUpDir_bUpdateMesh_Offset), 0, SetSplineUpDir_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetSplineUpDir_FunctionAddress, intPtr, SetSplineUpDir_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetForwardAxis")]
	public unsafe void SetForwardAxis(ESplineMeshAxis InForwardAxis, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetForwardAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetForwardAxis");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetForwardAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetForwardAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ESplineMeshAxis>.ToNative(IntPtr.Add(intPtr, SetForwardAxis_InForwardAxis_Offset), 0, SetForwardAxis_InForwardAxis_PropertyAddress.Address, InForwardAxis);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetForwardAxis_bUpdateMesh_Offset), 0, SetForwardAxis_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetForwardAxis_FunctionAddress, intPtr, SetForwardAxis_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetEndTangent")]
	public unsafe void SetEndTangent(FVector EndTangent, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetEndTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetEndTangent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetEndTangent_EndTangent_Offset), 0, SetEndTangent_EndTangent_PropertyAddress.Address, EndTangent);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEndTangent_bUpdateMesh_Offset), 0, SetEndTangent_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEndTangent_FunctionAddress, intPtr, SetEndTangent_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetEndScale")]
	public unsafe void SetEndScale(FVector2D EndScale, bool bUpdateMesh)
	{
		CheckDestroyed();
		if (!SetEndScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetEndScale");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetEndScale_EndScale_Offset), 0, SetEndScale_EndScale_PropertyAddress.Address, EndScale);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEndScale_bUpdateMesh_Offset), 0, SetEndScale_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEndScale_FunctionAddress, intPtr, SetEndScale_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetEndRoll")]
	public unsafe void SetEndRoll(float EndRoll, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetEndRoll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetEndRoll");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndRoll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndRoll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetEndRoll_EndRoll_Offset), 0, SetEndRoll_EndRoll_PropertyAddress.Address, EndRoll);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEndRoll_bUpdateMesh_Offset), 0, SetEndRoll_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEndRoll_FunctionAddress, intPtr, SetEndRoll_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetEndPosition")]
	public unsafe void SetEndPosition(FVector EndPos, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetEndPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetEndPosition");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetEndPosition_EndPos_Offset), 0, SetEndPosition_EndPos_PropertyAddress.Address, EndPos);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEndPosition_bUpdateMesh_Offset), 0, SetEndPosition_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEndPosition_FunctionAddress, intPtr, SetEndPosition_ParamsSize);
	}

	[UFunction(Flags = 75629569u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetEndOffset")]
	public unsafe void SetEndOffset(FVector2D EndOffset, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetEndOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetEndOffset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEndOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEndOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, SetEndOffset_EndOffset_Offset), 0, SetEndOffset_EndOffset_PropertyAddress.Address, EndOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEndOffset_bUpdateMesh_Offset), 0, SetEndOffset_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetEndOffset_FunctionAddress, intPtr, SetEndOffset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetBoundaryMin")]
	public unsafe void SetBoundaryMin(float InBoundaryMin, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetBoundaryMin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetBoundaryMin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoundaryMin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoundaryMin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoundaryMin_InBoundaryMin_Offset), 0, SetBoundaryMin_InBoundaryMin_PropertyAddress.Address, InBoundaryMin);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoundaryMin_bUpdateMesh_Offset), 0, SetBoundaryMin_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoundaryMin_FunctionAddress, intPtr, SetBoundaryMin_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:SetBoundaryMax")]
	public unsafe void SetBoundaryMax(float InBoundaryMax, bool bUpdateMesh = true)
	{
		CheckDestroyed();
		if (!SetBoundaryMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:SetBoundaryMax");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBoundaryMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBoundaryMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetBoundaryMax_InBoundaryMax_Offset), 0, SetBoundaryMax_InBoundaryMax_PropertyAddress.Address, InBoundaryMax);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetBoundaryMax_bUpdateMesh_Offset), 0, SetBoundaryMax_bUpdateMesh_PropertyAddress.Address, bUpdateMesh);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetBoundaryMax_FunctionAddress, intPtr, SetBoundaryMax_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetStartTangent")]
	public unsafe FVector GetStartTangent()
	{
		CheckDestroyed();
		if (!GetStartTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetStartTangent");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartTangent_FunctionAddress, intPtr, GetStartTangent_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetStartTangent_ReturnValue_Offset), 0, GetStartTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetStartScale")]
	public unsafe FVector2D GetStartScale()
	{
		CheckDestroyed();
		if (!GetStartScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetStartScale");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartScale_FunctionAddress, intPtr, GetStartScale_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetStartScale_ReturnValue_Offset), 0, GetStartScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetStartRoll")]
	public unsafe float GetStartRoll()
	{
		CheckDestroyed();
		if (!GetStartRoll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetStartRoll");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartRoll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartRoll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartRoll_FunctionAddress, intPtr, GetStartRoll_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetStartRoll_ReturnValue_Offset), 0, GetStartRoll_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetStartPosition")]
	public unsafe FVector GetStartPosition()
	{
		CheckDestroyed();
		if (!GetStartPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetStartPosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartPosition_FunctionAddress, intPtr, GetStartPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetStartPosition_ReturnValue_Offset), 0, GetStartPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetStartOffset")]
	public unsafe FVector2D GetStartOffset()
	{
		CheckDestroyed();
		if (!GetStartOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetStartOffset");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetStartOffset_FunctionAddress, intPtr, GetStartOffset_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetStartOffset_ReturnValue_Offset), 0, GetStartOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetSplineUpDir")]
	public unsafe FVector GetSplineUpDir()
	{
		CheckDestroyed();
		if (!GetSplineUpDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetSplineUpDir");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSplineUpDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSplineUpDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetSplineUpDir_FunctionAddress, intPtr, GetSplineUpDir_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetSplineUpDir_ReturnValue_Offset), 0, GetSplineUpDir_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetForwardAxis")]
	public unsafe ESplineMeshAxis GetForwardAxis()
	{
		CheckDestroyed();
		if (!GetForwardAxis_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetForwardAxis");
			return ESplineMeshAxis.X;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetForwardAxis_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetForwardAxis_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetForwardAxis_FunctionAddress, intPtr, GetForwardAxis_ParamsSize);
		return EnumMarshaler<ESplineMeshAxis>.FromNative(IntPtr.Add(intPtr, GetForwardAxis_ReturnValue_Offset), 0, GetForwardAxis_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetEndTangent")]
	public unsafe FVector GetEndTangent()
	{
		CheckDestroyed();
		if (!GetEndTangent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetEndTangent");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndTangent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndTangent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndTangent_FunctionAddress, intPtr, GetEndTangent_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetEndTangent_ReturnValue_Offset), 0, GetEndTangent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetEndScale")]
	public unsafe FVector2D GetEndScale()
	{
		CheckDestroyed();
		if (!GetEndScale_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetEndScale");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndScale_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndScale_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndScale_FunctionAddress, intPtr, GetEndScale_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetEndScale_ReturnValue_Offset), 0, GetEndScale_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetEndRoll")]
	public unsafe float GetEndRoll()
	{
		CheckDestroyed();
		if (!GetEndRoll_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetEndRoll");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndRoll_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndRoll_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndRoll_FunctionAddress, intPtr, GetEndRoll_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetEndRoll_ReturnValue_Offset), 0, GetEndRoll_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetEndPosition")]
	public unsafe FVector GetEndPosition()
	{
		CheckDestroyed();
		if (!GetEndPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetEndPosition");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndPosition_FunctionAddress, intPtr, GetEndPosition_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetEndPosition_ReturnValue_Offset), 0, GetEndPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetEndOffset")]
	public unsafe FVector2D GetEndOffset()
	{
		CheckDestroyed();
		if (!GetEndOffset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetEndOffset");
			return default(FVector2D);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEndOffset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEndOffset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetEndOffset_FunctionAddress, intPtr, GetEndOffset_ParamsSize);
		return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetEndOffset_ReturnValue_Offset), 0, GetEndOffset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetBoundaryMin")]
	public unsafe float GetBoundaryMin()
	{
		CheckDestroyed();
		if (!GetBoundaryMin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetBoundaryMin");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundaryMin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundaryMin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundaryMin_FunctionAddress, intPtr, GetBoundaryMin_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBoundaryMin_ReturnValue_Offset), 0, GetBoundaryMin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.SplineMeshComponent:GetBoundaryMax")]
	public unsafe float GetBoundaryMax()
	{
		CheckDestroyed();
		if (!GetBoundaryMax_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.SplineMeshComponent:GetBoundaryMax");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBoundaryMax_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBoundaryMax_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetBoundaryMax_FunctionAddress, intPtr, GetBoundaryMax_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetBoundaryMax_ReturnValue_Offset), 0, GetBoundaryMax_ReturnValue_PropertyAddress.Address);
	}

	static USplineMeshComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(USplineMeshComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(USplineMeshComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.SplineMeshComponent");
		UpdateMesh_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "UpdateMesh");
		UpdateMesh_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateMesh_FunctionAddress);
		UpdateMesh_IsValid = UpdateMesh_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:UpdateMesh", UpdateMesh_IsValid);
		SetStartTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartTangent");
		SetStartTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartTangent_StartTangent_PropertyAddress, SetStartTangent_FunctionAddress, "StartTangent");
		SetStartTangent_StartTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetStartTangent_FunctionAddress, "StartTangent");
		SetStartTangent_StartTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartTangent_FunctionAddress, "StartTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartTangent_bUpdateMesh_PropertyAddress, SetStartTangent_FunctionAddress, "bUpdateMesh");
		SetStartTangent_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStartTangent_FunctionAddress, "bUpdateMesh");
		SetStartTangent_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartTangent_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetStartTangent_IsValid = SetStartTangent_FunctionAddress != IntPtr.Zero && SetStartTangent_StartTangent_IsValid && SetStartTangent_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetStartTangent", SetStartTangent_IsValid);
		SetStartScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartScale");
		SetStartScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartScale_StartScale_PropertyAddress, SetStartScale_FunctionAddress, "StartScale");
		SetStartScale_StartScale_Offset = NativeReflectionCached.GetPropertyOffset(SetStartScale_FunctionAddress, "StartScale");
		SetStartScale_StartScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartScale_FunctionAddress, "StartScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartScale_bUpdateMesh_PropertyAddress, SetStartScale_FunctionAddress, "bUpdateMesh");
		SetStartScale_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStartScale_FunctionAddress, "bUpdateMesh");
		SetStartScale_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartScale_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetStartScale_IsValid = SetStartScale_FunctionAddress != IntPtr.Zero && SetStartScale_StartScale_IsValid && SetStartScale_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetStartScale", SetStartScale_IsValid);
		SetStartRoll_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartRoll");
		SetStartRoll_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartRoll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartRoll_StartRoll_PropertyAddress, SetStartRoll_FunctionAddress, "StartRoll");
		SetStartRoll_StartRoll_Offset = NativeReflectionCached.GetPropertyOffset(SetStartRoll_FunctionAddress, "StartRoll");
		SetStartRoll_StartRoll_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartRoll_FunctionAddress, "StartRoll", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartRoll_bUpdateMesh_PropertyAddress, SetStartRoll_FunctionAddress, "bUpdateMesh");
		SetStartRoll_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStartRoll_FunctionAddress, "bUpdateMesh");
		SetStartRoll_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartRoll_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetStartRoll_IsValid = SetStartRoll_FunctionAddress != IntPtr.Zero && SetStartRoll_StartRoll_IsValid && SetStartRoll_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetStartRoll", SetStartRoll_IsValid);
		SetStartPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartPosition");
		SetStartPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartPosition_StartPos_PropertyAddress, SetStartPosition_FunctionAddress, "StartPos");
		SetStartPosition_StartPos_Offset = NativeReflectionCached.GetPropertyOffset(SetStartPosition_FunctionAddress, "StartPos");
		SetStartPosition_StartPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartPosition_FunctionAddress, "StartPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartPosition_bUpdateMesh_PropertyAddress, SetStartPosition_FunctionAddress, "bUpdateMesh");
		SetStartPosition_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStartPosition_FunctionAddress, "bUpdateMesh");
		SetStartPosition_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartPosition_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetStartPosition_IsValid = SetStartPosition_FunctionAddress != IntPtr.Zero && SetStartPosition_StartPos_IsValid && SetStartPosition_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetStartPosition", SetStartPosition_IsValid);
		SetStartOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartOffset");
		SetStartOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartOffset_StartOffset_PropertyAddress, SetStartOffset_FunctionAddress, "StartOffset");
		SetStartOffset_StartOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetStartOffset_FunctionAddress, "StartOffset");
		SetStartOffset_StartOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartOffset_FunctionAddress, "StartOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartOffset_bUpdateMesh_PropertyAddress, SetStartOffset_FunctionAddress, "bUpdateMesh");
		SetStartOffset_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStartOffset_FunctionAddress, "bUpdateMesh");
		SetStartOffset_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartOffset_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetStartOffset_IsValid = SetStartOffset_FunctionAddress != IntPtr.Zero && SetStartOffset_StartOffset_IsValid && SetStartOffset_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetStartOffset", SetStartOffset_IsValid);
		SetStartAndEnd_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetStartAndEnd");
		SetStartAndEnd_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartAndEnd_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartAndEnd_StartPos_PropertyAddress, SetStartAndEnd_FunctionAddress, "StartPos");
		SetStartAndEnd_StartPos_Offset = NativeReflectionCached.GetPropertyOffset(SetStartAndEnd_FunctionAddress, "StartPos");
		SetStartAndEnd_StartPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartAndEnd_FunctionAddress, "StartPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartAndEnd_StartTangent_PropertyAddress, SetStartAndEnd_FunctionAddress, "StartTangent");
		SetStartAndEnd_StartTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetStartAndEnd_FunctionAddress, "StartTangent");
		SetStartAndEnd_StartTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartAndEnd_FunctionAddress, "StartTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartAndEnd_EndPos_PropertyAddress, SetStartAndEnd_FunctionAddress, "EndPos");
		SetStartAndEnd_EndPos_Offset = NativeReflectionCached.GetPropertyOffset(SetStartAndEnd_FunctionAddress, "EndPos");
		SetStartAndEnd_EndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartAndEnd_FunctionAddress, "EndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartAndEnd_EndTangent_PropertyAddress, SetStartAndEnd_FunctionAddress, "EndTangent");
		SetStartAndEnd_EndTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetStartAndEnd_FunctionAddress, "EndTangent");
		SetStartAndEnd_EndTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartAndEnd_FunctionAddress, "EndTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetStartAndEnd_bUpdateMesh_PropertyAddress, SetStartAndEnd_FunctionAddress, "bUpdateMesh");
		SetStartAndEnd_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetStartAndEnd_FunctionAddress, "bUpdateMesh");
		SetStartAndEnd_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartAndEnd_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetStartAndEnd_IsValid = SetStartAndEnd_FunctionAddress != IntPtr.Zero && SetStartAndEnd_StartPos_IsValid && SetStartAndEnd_StartTangent_IsValid && SetStartAndEnd_EndPos_IsValid && SetStartAndEnd_EndTangent_IsValid && SetStartAndEnd_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetStartAndEnd", SetStartAndEnd_IsValid);
		SetSplineUpDir_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetSplineUpDir");
		SetSplineUpDir_ParamsSize = NativeReflection.GetFunctionParamsSize(SetSplineUpDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetSplineUpDir_InSplineUpDir_PropertyAddress, SetSplineUpDir_FunctionAddress, "InSplineUpDir");
		SetSplineUpDir_InSplineUpDir_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineUpDir_FunctionAddress, "InSplineUpDir");
		SetSplineUpDir_InSplineUpDir_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineUpDir_FunctionAddress, "InSplineUpDir", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetSplineUpDir_bUpdateMesh_PropertyAddress, SetSplineUpDir_FunctionAddress, "bUpdateMesh");
		SetSplineUpDir_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetSplineUpDir_FunctionAddress, "bUpdateMesh");
		SetSplineUpDir_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetSplineUpDir_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetSplineUpDir_IsValid = SetSplineUpDir_FunctionAddress != IntPtr.Zero && SetSplineUpDir_InSplineUpDir_IsValid && SetSplineUpDir_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetSplineUpDir", SetSplineUpDir_IsValid);
		SetForwardAxis_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetForwardAxis");
		SetForwardAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(SetForwardAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetForwardAxis_InForwardAxis_PropertyAddress, SetForwardAxis_FunctionAddress, "InForwardAxis");
		SetForwardAxis_InForwardAxis_Offset = NativeReflectionCached.GetPropertyOffset(SetForwardAxis_FunctionAddress, "InForwardAxis");
		SetForwardAxis_InForwardAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForwardAxis_FunctionAddress, "InForwardAxis", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref SetForwardAxis_bUpdateMesh_PropertyAddress, SetForwardAxis_FunctionAddress, "bUpdateMesh");
		SetForwardAxis_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetForwardAxis_FunctionAddress, "bUpdateMesh");
		SetForwardAxis_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetForwardAxis_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetForwardAxis_IsValid = SetForwardAxis_FunctionAddress != IntPtr.Zero && SetForwardAxis_InForwardAxis_IsValid && SetForwardAxis_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetForwardAxis", SetForwardAxis_IsValid);
		SetEndTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEndTangent");
		SetEndTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndTangent_EndTangent_PropertyAddress, SetEndTangent_FunctionAddress, "EndTangent");
		SetEndTangent_EndTangent_Offset = NativeReflectionCached.GetPropertyOffset(SetEndTangent_FunctionAddress, "EndTangent");
		SetEndTangent_EndTangent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndTangent_FunctionAddress, "EndTangent", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndTangent_bUpdateMesh_PropertyAddress, SetEndTangent_FunctionAddress, "bUpdateMesh");
		SetEndTangent_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetEndTangent_FunctionAddress, "bUpdateMesh");
		SetEndTangent_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndTangent_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetEndTangent_IsValid = SetEndTangent_FunctionAddress != IntPtr.Zero && SetEndTangent_EndTangent_IsValid && SetEndTangent_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetEndTangent", SetEndTangent_IsValid);
		SetEndScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEndScale");
		SetEndScale_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndScale_EndScale_PropertyAddress, SetEndScale_FunctionAddress, "EndScale");
		SetEndScale_EndScale_Offset = NativeReflectionCached.GetPropertyOffset(SetEndScale_FunctionAddress, "EndScale");
		SetEndScale_EndScale_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndScale_FunctionAddress, "EndScale", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndScale_bUpdateMesh_PropertyAddress, SetEndScale_FunctionAddress, "bUpdateMesh");
		SetEndScale_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetEndScale_FunctionAddress, "bUpdateMesh");
		SetEndScale_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndScale_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetEndScale_IsValid = SetEndScale_FunctionAddress != IntPtr.Zero && SetEndScale_EndScale_IsValid && SetEndScale_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetEndScale", SetEndScale_IsValid);
		SetEndRoll_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEndRoll");
		SetEndRoll_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndRoll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndRoll_EndRoll_PropertyAddress, SetEndRoll_FunctionAddress, "EndRoll");
		SetEndRoll_EndRoll_Offset = NativeReflectionCached.GetPropertyOffset(SetEndRoll_FunctionAddress, "EndRoll");
		SetEndRoll_EndRoll_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndRoll_FunctionAddress, "EndRoll", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndRoll_bUpdateMesh_PropertyAddress, SetEndRoll_FunctionAddress, "bUpdateMesh");
		SetEndRoll_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetEndRoll_FunctionAddress, "bUpdateMesh");
		SetEndRoll_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndRoll_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetEndRoll_IsValid = SetEndRoll_FunctionAddress != IntPtr.Zero && SetEndRoll_EndRoll_IsValid && SetEndRoll_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetEndRoll", SetEndRoll_IsValid);
		SetEndPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEndPosition");
		SetEndPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndPosition_EndPos_PropertyAddress, SetEndPosition_FunctionAddress, "EndPos");
		SetEndPosition_EndPos_Offset = NativeReflectionCached.GetPropertyOffset(SetEndPosition_FunctionAddress, "EndPos");
		SetEndPosition_EndPos_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndPosition_FunctionAddress, "EndPos", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndPosition_bUpdateMesh_PropertyAddress, SetEndPosition_FunctionAddress, "bUpdateMesh");
		SetEndPosition_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetEndPosition_FunctionAddress, "bUpdateMesh");
		SetEndPosition_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndPosition_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetEndPosition_IsValid = SetEndPosition_FunctionAddress != IntPtr.Zero && SetEndPosition_EndPos_IsValid && SetEndPosition_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetEndPosition", SetEndPosition_IsValid);
		SetEndOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetEndOffset");
		SetEndOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEndOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEndOffset_EndOffset_PropertyAddress, SetEndOffset_FunctionAddress, "EndOffset");
		SetEndOffset_EndOffset_Offset = NativeReflectionCached.GetPropertyOffset(SetEndOffset_FunctionAddress, "EndOffset");
		SetEndOffset_EndOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndOffset_FunctionAddress, "EndOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetEndOffset_bUpdateMesh_PropertyAddress, SetEndOffset_FunctionAddress, "bUpdateMesh");
		SetEndOffset_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetEndOffset_FunctionAddress, "bUpdateMesh");
		SetEndOffset_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEndOffset_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetEndOffset_IsValid = SetEndOffset_FunctionAddress != IntPtr.Zero && SetEndOffset_EndOffset_IsValid && SetEndOffset_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetEndOffset", SetEndOffset_IsValid);
		SetBoundaryMin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoundaryMin");
		SetBoundaryMin_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoundaryMin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoundaryMin_InBoundaryMin_PropertyAddress, SetBoundaryMin_FunctionAddress, "InBoundaryMin");
		SetBoundaryMin_InBoundaryMin_Offset = NativeReflectionCached.GetPropertyOffset(SetBoundaryMin_FunctionAddress, "InBoundaryMin");
		SetBoundaryMin_InBoundaryMin_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoundaryMin_FunctionAddress, "InBoundaryMin", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoundaryMin_bUpdateMesh_PropertyAddress, SetBoundaryMin_FunctionAddress, "bUpdateMesh");
		SetBoundaryMin_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetBoundaryMin_FunctionAddress, "bUpdateMesh");
		SetBoundaryMin_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoundaryMin_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetBoundaryMin_IsValid = SetBoundaryMin_FunctionAddress != IntPtr.Zero && SetBoundaryMin_InBoundaryMin_IsValid && SetBoundaryMin_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetBoundaryMin", SetBoundaryMin_IsValid);
		SetBoundaryMax_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetBoundaryMax");
		SetBoundaryMax_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBoundaryMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBoundaryMax_InBoundaryMax_PropertyAddress, SetBoundaryMax_FunctionAddress, "InBoundaryMax");
		SetBoundaryMax_InBoundaryMax_Offset = NativeReflectionCached.GetPropertyOffset(SetBoundaryMax_FunctionAddress, "InBoundaryMax");
		SetBoundaryMax_InBoundaryMax_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoundaryMax_FunctionAddress, "InBoundaryMax", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBoundaryMax_bUpdateMesh_PropertyAddress, SetBoundaryMax_FunctionAddress, "bUpdateMesh");
		SetBoundaryMax_bUpdateMesh_Offset = NativeReflectionCached.GetPropertyOffset(SetBoundaryMax_FunctionAddress, "bUpdateMesh");
		SetBoundaryMax_bUpdateMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBoundaryMax_FunctionAddress, "bUpdateMesh", Classes.FBoolProperty);
		SetBoundaryMax_IsValid = SetBoundaryMax_FunctionAddress != IntPtr.Zero && SetBoundaryMax_InBoundaryMax_IsValid && SetBoundaryMax_bUpdateMesh_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:SetBoundaryMax", SetBoundaryMax_IsValid);
		GetStartTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartTangent");
		GetStartTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartTangent_ReturnValue_PropertyAddress, GetStartTangent_FunctionAddress, "ReturnValue");
		GetStartTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartTangent_FunctionAddress, "ReturnValue");
		GetStartTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartTangent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStartTangent_IsValid = GetStartTangent_FunctionAddress != IntPtr.Zero && GetStartTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetStartTangent", GetStartTangent_IsValid);
		GetStartScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartScale");
		GetStartScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartScale_ReturnValue_PropertyAddress, GetStartScale_FunctionAddress, "ReturnValue");
		GetStartScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartScale_FunctionAddress, "ReturnValue");
		GetStartScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartScale_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStartScale_IsValid = GetStartScale_FunctionAddress != IntPtr.Zero && GetStartScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetStartScale", GetStartScale_IsValid);
		GetStartRoll_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartRoll");
		GetStartRoll_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartRoll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartRoll_ReturnValue_PropertyAddress, GetStartRoll_FunctionAddress, "ReturnValue");
		GetStartRoll_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartRoll_FunctionAddress, "ReturnValue");
		GetStartRoll_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartRoll_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetStartRoll_IsValid = GetStartRoll_FunctionAddress != IntPtr.Zero && GetStartRoll_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetStartRoll", GetStartRoll_IsValid);
		GetStartPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartPosition");
		GetStartPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartPosition_ReturnValue_PropertyAddress, GetStartPosition_FunctionAddress, "ReturnValue");
		GetStartPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartPosition_FunctionAddress, "ReturnValue");
		GetStartPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStartPosition_IsValid = GetStartPosition_FunctionAddress != IntPtr.Zero && GetStartPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetStartPosition", GetStartPosition_IsValid);
		GetStartOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetStartOffset");
		GetStartOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartOffset_ReturnValue_PropertyAddress, GetStartOffset_FunctionAddress, "ReturnValue");
		GetStartOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartOffset_FunctionAddress, "ReturnValue");
		GetStartOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetStartOffset_IsValid = GetStartOffset_FunctionAddress != IntPtr.Zero && GetStartOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetStartOffset", GetStartOffset_IsValid);
		GetSplineUpDir_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetSplineUpDir");
		GetSplineUpDir_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSplineUpDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSplineUpDir_ReturnValue_PropertyAddress, GetSplineUpDir_FunctionAddress, "ReturnValue");
		GetSplineUpDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSplineUpDir_FunctionAddress, "ReturnValue");
		GetSplineUpDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSplineUpDir_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetSplineUpDir_IsValid = GetSplineUpDir_FunctionAddress != IntPtr.Zero && GetSplineUpDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetSplineUpDir", GetSplineUpDir_IsValid);
		GetForwardAxis_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetForwardAxis");
		GetForwardAxis_ParamsSize = NativeReflection.GetFunctionParamsSize(GetForwardAxis_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetForwardAxis_ReturnValue_PropertyAddress, GetForwardAxis_FunctionAddress, "ReturnValue");
		GetForwardAxis_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetForwardAxis_FunctionAddress, "ReturnValue");
		GetForwardAxis_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetForwardAxis_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		GetForwardAxis_IsValid = GetForwardAxis_FunctionAddress != IntPtr.Zero && GetForwardAxis_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetForwardAxis", GetForwardAxis_IsValid);
		GetEndTangent_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEndTangent");
		GetEndTangent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndTangent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndTangent_ReturnValue_PropertyAddress, GetEndTangent_FunctionAddress, "ReturnValue");
		GetEndTangent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndTangent_FunctionAddress, "ReturnValue");
		GetEndTangent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndTangent_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEndTangent_IsValid = GetEndTangent_FunctionAddress != IntPtr.Zero && GetEndTangent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetEndTangent", GetEndTangent_IsValid);
		GetEndScale_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEndScale");
		GetEndScale_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndScale_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndScale_ReturnValue_PropertyAddress, GetEndScale_FunctionAddress, "ReturnValue");
		GetEndScale_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndScale_FunctionAddress, "ReturnValue");
		GetEndScale_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndScale_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEndScale_IsValid = GetEndScale_FunctionAddress != IntPtr.Zero && GetEndScale_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetEndScale", GetEndScale_IsValid);
		GetEndRoll_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEndRoll");
		GetEndRoll_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndRoll_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndRoll_ReturnValue_PropertyAddress, GetEndRoll_FunctionAddress, "ReturnValue");
		GetEndRoll_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndRoll_FunctionAddress, "ReturnValue");
		GetEndRoll_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndRoll_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetEndRoll_IsValid = GetEndRoll_FunctionAddress != IntPtr.Zero && GetEndRoll_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetEndRoll", GetEndRoll_IsValid);
		GetEndPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEndPosition");
		GetEndPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndPosition_ReturnValue_PropertyAddress, GetEndPosition_FunctionAddress, "ReturnValue");
		GetEndPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndPosition_FunctionAddress, "ReturnValue");
		GetEndPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndPosition_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEndPosition_IsValid = GetEndPosition_FunctionAddress != IntPtr.Zero && GetEndPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetEndPosition", GetEndPosition_IsValid);
		GetEndOffset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetEndOffset");
		GetEndOffset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEndOffset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEndOffset_ReturnValue_PropertyAddress, GetEndOffset_FunctionAddress, "ReturnValue");
		GetEndOffset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEndOffset_FunctionAddress, "ReturnValue");
		GetEndOffset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEndOffset_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetEndOffset_IsValid = GetEndOffset_FunctionAddress != IntPtr.Zero && GetEndOffset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetEndOffset", GetEndOffset_IsValid);
		GetBoundaryMin_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBoundaryMin");
		GetBoundaryMin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundaryMin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundaryMin_ReturnValue_PropertyAddress, GetBoundaryMin_FunctionAddress, "ReturnValue");
		GetBoundaryMin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundaryMin_FunctionAddress, "ReturnValue");
		GetBoundaryMin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundaryMin_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetBoundaryMin_IsValid = GetBoundaryMin_FunctionAddress != IntPtr.Zero && GetBoundaryMin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetBoundaryMin", GetBoundaryMin_IsValid);
		GetBoundaryMax_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetBoundaryMax");
		GetBoundaryMax_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBoundaryMax_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBoundaryMax_ReturnValue_PropertyAddress, GetBoundaryMax_FunctionAddress, "ReturnValue");
		GetBoundaryMax_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBoundaryMax_FunctionAddress, "ReturnValue");
		GetBoundaryMax_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBoundaryMax_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetBoundaryMax_IsValid = GetBoundaryMax_FunctionAddress != IntPtr.Zero && GetBoundaryMax_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.SplineMeshComponent:GetBoundaryMax", GetBoundaryMax_IsValid);
	}
}
