using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938020uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil", "FuncLibEditor", UnrealModuleType.Game)]
public class AGSNiagaraBatchingEditorUtil : AGSEditorUtilActor
{
	private static bool GSFxBatchingEditableInfo_IsValid;

	private static FFieldAddress GSFxBatchingEditableInfo_PropertyAddress;

	private static int GSFxBatchingEditableInfo_Offset;

	private TArrayReadWriteMarshaler<FGSNiagaraParticleEditableInfo> GSFxBatchingEditableInfo_MarshalerCached;

	private static bool VisualizeAllBatchingFx_IsValid;

	private IntPtr VisualizeAllBatchingFx_InstanceFunctionAddress;

	private static IntPtr VisualizeAllBatchingFx_FunctionAddress;

	private static int VisualizeAllBatchingFx_ParamsSize;

	private static bool UpdateFxBatchingAppearanceInEditor_IsValid;

	private IntPtr UpdateFxBatchingAppearanceInEditor_InstanceFunctionAddress;

	private static IntPtr UpdateFxBatchingAppearanceInEditor_FunctionAddress;

	private static int UpdateFxBatchingAppearanceInEditor_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599627371013uL)]
	[UMetaPath("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:GSFxBatchingEditableInfo")]
	public TArrayReadWrite<FGSNiagaraParticleEditableInfo> GSFxBatchingEditableInfo
	{
		get
		{
			CheckDestroyed();
			if (!GSFxBatchingEditableInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:GSFxBatchingEditableInfo");
				return null;
			}
			if (GSFxBatchingEditableInfo_MarshalerCached == null)
			{
				GSFxBatchingEditableInfo_MarshalerCached = new TArrayReadWriteMarshaler<FGSNiagaraParticleEditableInfo>(1, GSFxBatchingEditableInfo_PropertyAddress, CachedMarshalingDelegates<FGSNiagaraParticleEditableInfo, FGSNiagaraParticleEditableInfo>.FromNative, CachedMarshalingDelegates<FGSNiagaraParticleEditableInfo, FGSNiagaraParticleEditableInfo>.ToNative);
			}
			return GSFxBatchingEditableInfo_MarshalerCached.FromNative(IntPtr.Add(base.Address, GSFxBatchingEditableInfo_Offset));
		}
	}

	[UFunction(Flags = 671221760u)]
	[UMetaPath("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:VisualizeAllBatchingFx")]
	public unsafe void VisualizeAllBatchingFx()
	{
		CheckDestroyed();
		if (!VisualizeAllBatchingFx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:VisualizeAllBatchingFx");
			return;
		}
		if (VisualizeAllBatchingFx_InstanceFunctionAddress == IntPtr.Zero)
		{
			VisualizeAllBatchingFx_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "VisualizeAllBatchingFx");
		}
		byte* ptr = stackalloc byte[(int)(uint)(VisualizeAllBatchingFx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VisualizeAllBatchingFx_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: VisualizeAllBatchingFx_InstanceFunctionAddress, argsSize: VisualizeAllBatchingFx_ParamsSize);
	}

	protected unsafe virtual void VisualizeAllBatchingFx_Implementation()
	{
		CheckDestroyed();
		if (!VisualizeAllBatchingFx_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:VisualizeAllBatchingFx");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(VisualizeAllBatchingFx_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)VisualizeAllBatchingFx_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: VisualizeAllBatchingFx_FunctionAddress, argsSize: VisualizeAllBatchingFx_ParamsSize);
	}

	[UFunction(Flags = 671221760u)]
	[UMetaPath("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:UpdateFxBatchingAppearanceInEditor")]
	public unsafe void UpdateFxBatchingAppearanceInEditor()
	{
		CheckDestroyed();
		if (!UpdateFxBatchingAppearanceInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:UpdateFxBatchingAppearanceInEditor");
			return;
		}
		if (UpdateFxBatchingAppearanceInEditor_InstanceFunctionAddress == IntPtr.Zero)
		{
			UpdateFxBatchingAppearanceInEditor_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "UpdateFxBatchingAppearanceInEditor");
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateFxBatchingAppearanceInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateFxBatchingAppearanceInEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateFxBatchingAppearanceInEditor_InstanceFunctionAddress, argsSize: UpdateFxBatchingAppearanceInEditor_ParamsSize);
	}

	protected unsafe virtual void UpdateFxBatchingAppearanceInEditor_Implementation()
	{
		CheckDestroyed();
		if (!UpdateFxBatchingAppearanceInEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:UpdateFxBatchingAppearanceInEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UpdateFxBatchingAppearanceInEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UpdateFxBatchingAppearanceInEditor_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: UpdateFxBatchingAppearanceInEditor_FunctionAddress, argsSize: UpdateFxBatchingAppearanceInEditor_ParamsSize);
	}

	static AGSNiagaraBatchingEditorUtil()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(AGSNiagaraBatchingEditorUtil)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AGSNiagaraBatchingEditorUtil));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil");
		NativeReflectionCached.GetPropertyRef(ref GSFxBatchingEditableInfo_PropertyAddress, intPtr, "GSFxBatchingEditableInfo");
		GSFxBatchingEditableInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GSFxBatchingEditableInfo");
		GSFxBatchingEditableInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GSFxBatchingEditableInfo", Classes.FArrayProperty);
		VisualizeAllBatchingFx_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "VisualizeAllBatchingFx");
		VisualizeAllBatchingFx_ParamsSize = NativeReflection.GetFunctionParamsSize(VisualizeAllBatchingFx_FunctionAddress);
		VisualizeAllBatchingFx_IsValid = VisualizeAllBatchingFx_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:VisualizeAllBatchingFx", VisualizeAllBatchingFx_IsValid);
		UpdateFxBatchingAppearanceInEditor_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "UpdateFxBatchingAppearanceInEditor");
		UpdateFxBatchingAppearanceInEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(UpdateFxBatchingAppearanceInEditor_FunctionAddress);
		UpdateFxBatchingAppearanceInEditor_IsValid = UpdateFxBatchingAppearanceInEditor_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/FuncLibEditor.GSNiagaraBatchingEditorUtil:UpdateFxBatchingAppearanceInEditor", UpdateFxBatchingAppearanceInEditor_IsValid);
	}
}
