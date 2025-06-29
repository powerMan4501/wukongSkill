using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace UnrealEngine.Blutility;

[Abstract]
[UClass(Flags = (ClassFlags)821039269uL, Config = "Editor")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Blutility.EditorUtilityWidget", "Blutility", UnrealModuleType.Engine)]
public class UEditorUtilityWidget : UUserWidget
{
	private static bool HelpText_IsValid;

	private static int HelpText_Offset;

	private static bool AutoRunDefaultAction_IsValid;

	private static FFieldAddress AutoRunDefaultAction_PropertyAddress;

	private static int AutoRunDefaultAction_Offset;

	private static bool Run_IsValid;

	private IntPtr Run_InstanceFunctionAddress;

	private static IntPtr Run_FunctionAddress;

	private static int Run_ParamsSize;

	[UProperty(Flags = (PropFlags)11268894673142277uL)]
	[UMetaPath("/Script/Blutility.EditorUtilityWidget:HelpText")]
	protected string HelpText
	{
		get
		{
			CheckDestroyed();
			if (!HelpText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Blutility.EditorUtilityWidget:HelpText");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, HelpText_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HelpText_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Blutility.EditorUtilityWidget:HelpText");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, HelpText_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954733077uL)]
	[UMetaPath("/Script/Blutility.EditorUtilityWidget:bAutoRunDefaultAction")]
	protected bool AutoRunDefaultAction
	{
		get
		{
			CheckDestroyed();
			if (!AutoRunDefaultAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Blutility.EditorUtilityWidget:bAutoRunDefaultAction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoRunDefaultAction_Offset), 0, AutoRunDefaultAction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoRunDefaultAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Blutility.EditorUtilityWidget:bAutoRunDefaultAction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoRunDefaultAction_Offset), 0, AutoRunDefaultAction_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 201459712u)]
	[UMetaPath("/Script/Blutility.EditorUtilityWidget:Run")]
	public unsafe void Run()
	{
		CheckDestroyed();
		if (!Run_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityWidget:Run");
			return;
		}
		if (Run_InstanceFunctionAddress == IntPtr.Zero)
		{
			Run_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "Run");
		}
		byte* ptr = stackalloc byte[(int)(uint)(Run_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Run_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Run_InstanceFunctionAddress, argsSize: Run_ParamsSize);
	}

	protected unsafe virtual void Run_Implementation()
	{
		CheckDestroyed();
		if (!Run_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Blutility.EditorUtilityWidget:Run");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Run_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Run_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Run_FunctionAddress, argsSize: Run_ParamsSize);
	}

	static UEditorUtilityWidget()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorUtilityWidget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorUtilityWidget));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Blutility.EditorUtilityWidget");
		HelpText_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HelpText");
		HelpText_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HelpText", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoRunDefaultAction_PropertyAddress, intPtr, "bAutoRunDefaultAction");
		AutoRunDefaultAction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoRunDefaultAction");
		AutoRunDefaultAction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoRunDefaultAction", Classes.FBoolProperty);
		Run_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Run");
		Run_ParamsSize = NativeReflection.GetFunctionParamsSize(Run_FunctionAddress);
		Run_IsValid = Run_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Blutility.EditorUtilityWidget:Run", Run_IsValid);
	}
}
