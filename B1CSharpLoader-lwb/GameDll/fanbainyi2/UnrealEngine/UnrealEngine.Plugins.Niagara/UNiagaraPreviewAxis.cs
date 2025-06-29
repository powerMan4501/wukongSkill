using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.Niagara;

[Abstract]
[UClass(Flags = (ClassFlags)809504929uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Niagara.NiagaraPreviewAxis", "Niagara", UnrealModuleType.EnginePlugin)]
public class UNiagaraPreviewAxis : UObject
{
	private static bool Num_IsValid;

	private IntPtr Num_InstanceFunctionAddress;

	private static IntPtr Num_FunctionAddress;

	private static int Num_ParamsSize;

	private static bool Num_ReturnValue_IsValid;

	private static FFieldAddress Num_ReturnValue_PropertyAddress;

	private static int Num_ReturnValue_Offset;

	private static bool ApplyToPreview_IsValid;

	private IntPtr ApplyToPreview_InstanceFunctionAddress;

	private static IntPtr ApplyToPreview_FunctionAddress;

	private static int ApplyToPreview_ParamsSize;

	private static bool ApplyToPreview_PreviewComponent_IsValid;

	private static FFieldAddress ApplyToPreview_PreviewComponent_PropertyAddress;

	private static int ApplyToPreview_PreviewComponent_Offset;

	private static bool ApplyToPreview_PreviewIndex_IsValid;

	private static FFieldAddress ApplyToPreview_PreviewIndex_PropertyAddress;

	private static int ApplyToPreview_PreviewIndex_Offset;

	private static bool ApplyToPreview_bIsXAxis_IsValid;

	private static FFieldAddress ApplyToPreview_bIsXAxis_PropertyAddress;

	private static int ApplyToPreview_bIsXAxis_Offset;

	private static bool ApplyToPreview_OutLabelText_IsValid;

	private static FFieldAddress ApplyToPreview_OutLabelText_PropertyAddress;

	private static int ApplyToPreview_OutLabelText_Offset;

	[UFunction(Flags = 134351872u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewAxis:Num")]
	public unsafe int Num()
	{
		CheckDestroyed();
		if (!Num_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewAxis:Num");
			return 0;
		}
		if (Num_InstanceFunctionAddress == IntPtr.Zero)
		{
			Num_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Num");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Num_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Num_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Num_InstanceFunctionAddress, intPtr, Num_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Num_ReturnValue_Offset), 0, Num_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual int Num_Implementation()
	{
		CheckDestroyed();
		if (!Num_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewAxis:Num");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Num_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Num_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Num_FunctionAddress, intPtr, Num_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, Num_ReturnValue_Offset), 0, Num_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 138546176u)]
	[UMetaPath("/Script/Niagara.NiagaraPreviewAxis:ApplyToPreview")]
	public unsafe void ApplyToPreview(UNiagaraComponent PreviewComponent, int PreviewIndex, bool bIsXAxis, out string OutLabelText)
	{
		CheckDestroyed();
		if (!ApplyToPreview_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewAxis:ApplyToPreview");
			OutLabelText = FStringMarshaler.DefaultString;
			return;
		}
		if (ApplyToPreview_InstanceFunctionAddress == IntPtr.Zero)
		{
			ApplyToPreview_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ApplyToPreview");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyToPreview_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyToPreview_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, ApplyToPreview_PreviewComponent_Offset), 0, ApplyToPreview_PreviewComponent_PropertyAddress.Address, PreviewComponent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyToPreview_PreviewIndex_Offset), 0, ApplyToPreview_PreviewIndex_PropertyAddress.Address, PreviewIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyToPreview_bIsXAxis_Offset), 0, ApplyToPreview_bIsXAxis_PropertyAddress.Address, bIsXAxis);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyToPreview_InstanceFunctionAddress, intPtr, ApplyToPreview_ParamsSize);
		OutLabelText = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ApplyToPreview_OutLabelText_Offset), 0, ApplyToPreview_OutLabelText_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ApplyToPreview_OutLabelText_PropertyAddress.Address, intPtr);
	}

	protected unsafe virtual void ApplyToPreview_Implementation(UNiagaraComponent PreviewComponent, int PreviewIndex, bool bIsXAxis, out string OutLabelText)
	{
		CheckDestroyed();
		if (!ApplyToPreview_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Niagara.NiagaraPreviewAxis:ApplyToPreview");
			OutLabelText = FStringMarshaler.DefaultString;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyToPreview_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyToPreview_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UNiagaraComponent>.ToNative(IntPtr.Add(intPtr, ApplyToPreview_PreviewComponent_Offset), 0, ApplyToPreview_PreviewComponent_PropertyAddress.Address, PreviewComponent);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ApplyToPreview_PreviewIndex_Offset), 0, ApplyToPreview_PreviewIndex_PropertyAddress.Address, PreviewIndex);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyToPreview_bIsXAxis_Offset), 0, ApplyToPreview_bIsXAxis_PropertyAddress.Address, bIsXAxis);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyToPreview_FunctionAddress, intPtr, ApplyToPreview_ParamsSize);
		OutLabelText = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ApplyToPreview_OutLabelText_Offset), 0, ApplyToPreview_OutLabelText_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ApplyToPreview_OutLabelText_PropertyAddress.Address, intPtr);
	}

	static UNiagaraPreviewAxis()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNiagaraPreviewAxis)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNiagaraPreviewAxis));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Niagara.NiagaraPreviewAxis");
		Num_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Num");
		Num_ParamsSize = NativeReflection.GetFunctionParamsSize(Num_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Num_ReturnValue_PropertyAddress, Num_FunctionAddress, "ReturnValue");
		Num_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Num_FunctionAddress, "ReturnValue");
		Num_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Num_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		Num_IsValid = Num_FunctionAddress != IntPtr.Zero && Num_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewAxis:Num", Num_IsValid);
		ApplyToPreview_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ApplyToPreview");
		ApplyToPreview_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyToPreview_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyToPreview_PreviewComponent_PropertyAddress, ApplyToPreview_FunctionAddress, "PreviewComponent");
		ApplyToPreview_PreviewComponent_Offset = NativeReflectionCached.GetPropertyOffset(ApplyToPreview_FunctionAddress, "PreviewComponent");
		ApplyToPreview_PreviewComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyToPreview_FunctionAddress, "PreviewComponent", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyToPreview_PreviewIndex_PropertyAddress, ApplyToPreview_FunctionAddress, "PreviewIndex");
		ApplyToPreview_PreviewIndex_Offset = NativeReflectionCached.GetPropertyOffset(ApplyToPreview_FunctionAddress, "PreviewIndex");
		ApplyToPreview_PreviewIndex_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyToPreview_FunctionAddress, "PreviewIndex", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyToPreview_bIsXAxis_PropertyAddress, ApplyToPreview_FunctionAddress, "bIsXAxis");
		ApplyToPreview_bIsXAxis_Offset = NativeReflectionCached.GetPropertyOffset(ApplyToPreview_FunctionAddress, "bIsXAxis");
		ApplyToPreview_bIsXAxis_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyToPreview_FunctionAddress, "bIsXAxis", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyToPreview_OutLabelText_PropertyAddress, ApplyToPreview_FunctionAddress, "OutLabelText");
		ApplyToPreview_OutLabelText_Offset = NativeReflectionCached.GetPropertyOffset(ApplyToPreview_FunctionAddress, "OutLabelText");
		ApplyToPreview_OutLabelText_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyToPreview_FunctionAddress, "OutLabelText", Classes.FStrProperty);
		ApplyToPreview_IsValid = ApplyToPreview_FunctionAddress != IntPtr.Zero && ApplyToPreview_PreviewComponent_IsValid && ApplyToPreview_PreviewIndex_IsValid && ApplyToPreview_bIsXAxis_IsValid && ApplyToPreview_OutLabelText_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Niagara.NiagaraPreviewAxis:ApplyToPreview", ApplyToPreview_IsValid);
	}
}
