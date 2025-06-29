using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.NavigationSystem;

[UClass(Flags = (ClassFlags)821035174uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/NavigationSystem.NavModifierComponent", "NavigationSystem", UnrealModuleType.Engine)]
public class UNavModifierComponent : UNavRelevantComponent
{
	private static bool AreaClass_IsValid;

	private static int AreaClass_Offset;

	private static bool SetAreaClass_IsValid;

	private static IntPtr SetAreaClass_FunctionAddress;

	private static int SetAreaClass_ParamsSize;

	private static bool SetAreaClass_NewAreaClass_IsValid;

	private static FFieldAddress SetAreaClass_NewAreaClass_PropertyAddress;

	private static int SetAreaClass_NewAreaClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117461uL)]
	[UMetaPath("/Script/NavigationSystem.NavModifierComponent:AreaClass")]
	public TSubclassOf<UNavArea> AreaClass
	{
		get
		{
			CheckDestroyed();
			if (!AreaClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavModifierComponent:AreaClass");
				return default(TSubclassOf<UNavArea>);
			}
			return TSubclassOfMarshaler<UNavArea>.FromNative(IntPtr.Add(base.Address, AreaClass_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaClass_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/NavigationSystem.NavModifierComponent:AreaClass");
			}
			else
			{
				TSubclassOfMarshaler<UNavArea>.ToNative(IntPtr.Add(base.Address, AreaClass_Offset), value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/NavigationSystem.NavModifierComponent:SetAreaClass")]
	public unsafe void SetAreaClass(TSubclassOf<UNavArea> NewAreaClass)
	{
		CheckDestroyed();
		if (!SetAreaClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/NavigationSystem.NavModifierComponent:SetAreaClass");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAreaClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAreaClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		TSubclassOfMarshaler<UNavArea>.ToNative(IntPtr.Add(intPtr, SetAreaClass_NewAreaClass_Offset), 0, SetAreaClass_NewAreaClass_PropertyAddress.Address, NewAreaClass);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetAreaClass_FunctionAddress, intPtr, SetAreaClass_ParamsSize);
	}

	static UNavModifierComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UNavModifierComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UNavModifierComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/NavigationSystem.NavModifierComponent");
		AreaClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "AreaClass");
		AreaClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "AreaClass", Classes.FClassProperty);
		SetAreaClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetAreaClass");
		SetAreaClass_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAreaClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAreaClass_NewAreaClass_PropertyAddress, SetAreaClass_FunctionAddress, "NewAreaClass");
		SetAreaClass_NewAreaClass_Offset = NativeReflectionCached.GetPropertyOffset(SetAreaClass_FunctionAddress, "NewAreaClass");
		SetAreaClass_NewAreaClass_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAreaClass_FunctionAddress, "NewAreaClass", Classes.FClassProperty);
		SetAreaClass_IsValid = SetAreaClass_FunctionAddress != IntPtr.Zero && SetAreaClass_NewAreaClass_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/NavigationSystem.NavModifierComponent:SetAreaClass", SetAreaClass_IsValid);
	}
}
