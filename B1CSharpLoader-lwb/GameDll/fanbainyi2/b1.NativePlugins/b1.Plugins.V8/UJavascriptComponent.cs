using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.Plugins.V8;

[UClass(Flags = (ClassFlags)821039268uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/V8.JavascriptComponent", "V8", UnrealModuleType.GamePlugin)]
public class UJavascriptComponent : UActorComponent
{
	[UDelegate]
	[UMetaPath("/Script/V8.JavascriptComponent:JavascriptTickSignature__DelegateSignature")]
	public class FJavascriptTickSignature : FDelegate<FJavascriptTickSignature.Signature>
	{
		public delegate void Signature(float DeltaSeconds);

		private static bool JavascriptTickSignature__DelegateSignature_IsValid;

		private static IntPtr JavascriptTickSignature__DelegateSignature_FunctionAddress;

		private static int JavascriptTickSignature__DelegateSignature_ParamsSize;

		private static bool JavascriptTickSignature__DelegateSignature_DeltaSeconds_IsValid;

		private static FFieldAddress JavascriptTickSignature__DelegateSignature_DeltaSeconds_PropertyAddress;

		private static int JavascriptTickSignature__DelegateSignature_DeltaSeconds_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptTickSignature()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptTickSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/V8.JavascriptComponent:JavascriptTickSignature__DelegateSignature");
			JavascriptTickSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptTickSignature__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptTickSignature__DelegateSignature_DeltaSeconds_PropertyAddress, JavascriptTickSignature__DelegateSignature_FunctionAddress, "DeltaSeconds");
			JavascriptTickSignature__DelegateSignature_DeltaSeconds_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptTickSignature__DelegateSignature_FunctionAddress, "DeltaSeconds");
			JavascriptTickSignature__DelegateSignature_DeltaSeconds_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptTickSignature__DelegateSignature_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
			JavascriptTickSignature__DelegateSignature_IsValid = JavascriptTickSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptTickSignature__DelegateSignature_DeltaSeconds_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:JavascriptTickSignature__DelegateSignature", JavascriptTickSignature__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(float DeltaSeconds)
		{
			if (!JavascriptTickSignature__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:JavascriptTickSignature__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptTickSignature__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptTickSignature__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, JavascriptTickSignature__DelegateSignature_DeltaSeconds_Offset), 0, JavascriptTickSignature__DelegateSignature_DeltaSeconds_PropertyAddress.Address, DeltaSeconds);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/V8.JavascriptComponent:JavascriptNoParamSignature__DelegateSignature")]
	public class FJavascriptNoParamSignature : FDelegate<FJavascriptNoParamSignature.Signature>
	{
		public delegate void Signature();

		private static bool JavascriptNoParamSignature__DelegateSignature_IsValid;

		private static IntPtr JavascriptNoParamSignature__DelegateSignature_FunctionAddress;

		private static int JavascriptNoParamSignature__DelegateSignature_ParamsSize;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptNoParamSignature()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptNoParamSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/V8.JavascriptComponent:JavascriptNoParamSignature__DelegateSignature");
			JavascriptNoParamSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptNoParamSignature__DelegateSignature_FunctionAddress);
			JavascriptNoParamSignature__DelegateSignature_IsValid = JavascriptNoParamSignature__DelegateSignature_FunctionAddress != IntPtr.Zero;
			NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:JavascriptNoParamSignature__DelegateSignature", JavascriptNoParamSignature__DelegateSignature_IsValid);
		}

		private unsafe void Invoker()
		{
			if (!JavascriptNoParamSignature__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:JavascriptNoParamSignature__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptNoParamSignature__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptNoParamSignature__DelegateSignature_ParamsSize);
				IntPtr parameters = new IntPtr(ptr2);
				ProcessDelegate(parameters);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/V8.JavascriptComponent:JavascriptNameSignature__DelegateSignature")]
	public class FJavascriptNameSignature : FDelegate<FJavascriptNameSignature.Signature>
	{
		public delegate void Signature(FName Name);

		private static bool JavascriptNameSignature__DelegateSignature_IsValid;

		private static IntPtr JavascriptNameSignature__DelegateSignature_FunctionAddress;

		private static int JavascriptNameSignature__DelegateSignature_ParamsSize;

		private static bool JavascriptNameSignature__DelegateSignature_Name_IsValid;

		private static FFieldAddress JavascriptNameSignature__DelegateSignature_Name_PropertyAddress;

		private static int JavascriptNameSignature__DelegateSignature_Name_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FJavascriptNameSignature()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			JavascriptNameSignature__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/V8.JavascriptComponent:JavascriptNameSignature__DelegateSignature");
			JavascriptNameSignature__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(JavascriptNameSignature__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref JavascriptNameSignature__DelegateSignature_Name_PropertyAddress, JavascriptNameSignature__DelegateSignature_FunctionAddress, "Name");
			JavascriptNameSignature__DelegateSignature_Name_Offset = NativeReflectionCached.GetPropertyOffset(JavascriptNameSignature__DelegateSignature_FunctionAddress, "Name");
			JavascriptNameSignature__DelegateSignature_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(JavascriptNameSignature__DelegateSignature_FunctionAddress, "Name", Classes.FNameProperty);
			JavascriptNameSignature__DelegateSignature_IsValid = JavascriptNameSignature__DelegateSignature_FunctionAddress != IntPtr.Zero && JavascriptNameSignature__DelegateSignature_Name_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:JavascriptNameSignature__DelegateSignature", JavascriptNameSignature__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FName Name)
		{
			if (!JavascriptNameSignature__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:JavascriptNameSignature__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(JavascriptNameSignature__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)JavascriptNameSignature__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, JavascriptNameSignature__DelegateSignature_Name_Offset), 0, JavascriptNameSignature__DelegateSignature_Name_PropertyAddress.Address, Name);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool ScriptSourceFile_IsValid;

	private static int ScriptSourceFile_Offset;

	private static bool ActiveWithinEditor_IsValid;

	private static FFieldAddress ActiveWithinEditor_PropertyAddress;

	private static int ActiveWithinEditor_Offset;

	private static bool ResolveClass_IsValid;

	private static IntPtr ResolveClass_FunctionAddress;

	private static int ResolveClass_ParamsSize;

	private static bool ResolveClass_Name_IsValid;

	private static FFieldAddress ResolveClass_Name_PropertyAddress;

	private static int ResolveClass_Name_Offset;

	private static bool ResolveClass_ReturnValue_IsValid;

	private static FFieldAddress ResolveClass_ReturnValue_PropertyAddress;

	private static int ResolveClass_ReturnValue_Offset;

	private static bool ResolveAsset_IsValid;

	private static IntPtr ResolveAsset_FunctionAddress;

	private static int ResolveAsset_ParamsSize;

	private static bool ResolveAsset_Name_IsValid;

	private static FFieldAddress ResolveAsset_Name_PropertyAddress;

	private static int ResolveAsset_Name_Offset;

	private static bool ResolveAsset_bTryLoad_IsValid;

	private static FFieldAddress ResolveAsset_bTryLoad_PropertyAddress;

	private static int ResolveAsset_bTryLoad_Offset;

	private static bool ResolveAsset_ReturnValue_IsValid;

	private static FFieldAddress ResolveAsset_ReturnValue_PropertyAddress;

	private static int ResolveAsset_ReturnValue_Offset;

	private static bool Invoke_IsValid;

	private static IntPtr Invoke_FunctionAddress;

	private static int Invoke_ParamsSize;

	private static bool Invoke_Name_IsValid;

	private static FFieldAddress Invoke_Name_PropertyAddress;

	private static int Invoke_Name_Offset;

	private static bool ForceGC_IsValid;

	private static IntPtr ForceGC_FunctionAddress;

	private static int ForceGC_ParamsSize;

	private static bool Expose_IsValid;

	private static IntPtr Expose_FunctionAddress;

	private static int Expose_ParamsSize;

	private static bool Expose_ExposedAs_IsValid;

	private static FFieldAddress Expose_ExposedAs_PropertyAddress;

	private static int Expose_ExposedAs_Offset;

	private static bool Expose_Object_IsValid;

	private static FFieldAddress Expose_Object_PropertyAddress;

	private static int Expose_Object_Offset;

	[UProperty(Flags = (PropFlags)6755399441056277uL)]
	[UMetaPath("/Script/V8.JavascriptComponent:ScriptSourceFile")]
	public string ScriptSourceFile
	{
		get
		{
			CheckDestroyed();
			if (!ScriptSourceFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/V8.JavascriptComponent:ScriptSourceFile");
				return FStringMarshaler.DefaultString;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, ScriptSourceFile_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ScriptSourceFile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/V8.JavascriptComponent:ScriptSourceFile");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, ScriptSourceFile_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/V8.JavascriptComponent:bActiveWithinEditor")]
	public bool ActiveWithinEditor
	{
		get
		{
			CheckDestroyed();
			if (!ActiveWithinEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/V8.JavascriptComponent:bActiveWithinEditor");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ActiveWithinEditor_Offset), 0, ActiveWithinEditor_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ActiveWithinEditor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/V8.JavascriptComponent:bActiveWithinEditor");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ActiveWithinEditor_Offset), 0, ActiveWithinEditor_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptComponent:ResolveClass")]
	public unsafe TSubclassOf<UObject> ResolveClass(FName Name)
	{
		CheckDestroyed();
		if (!ResolveClass_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:ResolveClass");
			return default(TSubclassOf<UObject>);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResolveClass_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResolveClass_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ResolveClass_Name_Offset), 0, ResolveClass_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResolveClass_FunctionAddress, intPtr, ResolveClass_ParamsSize);
		return TSubclassOfMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, ResolveClass_ReturnValue_Offset), 0, ResolveClass_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptComponent:ResolveAsset")]
	public unsafe UObject ResolveAsset(FName Name, bool bTryLoad = true)
	{
		CheckDestroyed();
		if (!ResolveAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:ResolveAsset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResolveAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResolveAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, ResolveAsset_Name_Offset), 0, ResolveAsset_Name_PropertyAddress.Address, Name);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ResolveAsset_bTryLoad_Offset), 0, ResolveAsset_bTryLoad_PropertyAddress.Address, bTryLoad);
		NativeReflection.InvokeFunctionOptimized(base.Address, ResolveAsset_FunctionAddress, intPtr, ResolveAsset_ParamsSize);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, ResolveAsset_ReturnValue_Offset), 0, ResolveAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptComponent:Invoke")]
	public unsafe void Invoke(FName Name)
	{
		CheckDestroyed();
		if (!Invoke_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:Invoke");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Invoke_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Invoke_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(intPtr, Invoke_Name_Offset), 0, Invoke_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeFunctionOptimized(base.Address, Invoke_FunctionAddress, intPtr, Invoke_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptComponent:ForceGC")]
	public unsafe void ForceGC()
	{
		CheckDestroyed();
		if (!ForceGC_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:ForceGC");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ForceGC_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ForceGC_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ForceGC_FunctionAddress, argsSize: ForceGC_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/V8.JavascriptComponent:Expose")]
	public unsafe void Expose(string ExposedAs, UObject Object)
	{
		CheckDestroyed();
		if (!Expose_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/V8.JavascriptComponent:Expose");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Expose_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Expose_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, Expose_ExposedAs_Offset), 0, Expose_ExposedAs_PropertyAddress.Address, ExposedAs);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, Expose_Object_Offset), 0, Expose_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeFunctionOptimized(base.Address, Expose_FunctionAddress, intPtr, Expose_ParamsSize);
		NativeReflection.DestroyValue_InContainer(Expose_ExposedAs_PropertyAddress.Address, intPtr);
	}

	static UJavascriptComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UJavascriptComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UJavascriptComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/V8.JavascriptComponent");
		ScriptSourceFile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScriptSourceFile");
		ScriptSourceFile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScriptSourceFile", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ActiveWithinEditor_PropertyAddress, intPtr, "bActiveWithinEditor");
		ActiveWithinEditor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bActiveWithinEditor");
		ActiveWithinEditor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bActiveWithinEditor", Classes.FBoolProperty);
		ResolveClass_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResolveClass");
		ResolveClass_ParamsSize = NativeReflection.GetFunctionParamsSize(ResolveClass_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResolveClass_Name_PropertyAddress, ResolveClass_FunctionAddress, "Name");
		ResolveClass_Name_Offset = NativeReflectionCached.GetPropertyOffset(ResolveClass_FunctionAddress, "Name");
		ResolveClass_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveClass_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveClass_ReturnValue_PropertyAddress, ResolveClass_FunctionAddress, "ReturnValue");
		ResolveClass_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResolveClass_FunctionAddress, "ReturnValue");
		ResolveClass_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveClass_FunctionAddress, "ReturnValue", Classes.FClassProperty);
		ResolveClass_IsValid = ResolveClass_FunctionAddress != IntPtr.Zero && ResolveClass_Name_IsValid && ResolveClass_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:ResolveClass", ResolveClass_IsValid);
		ResolveAsset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResolveAsset");
		ResolveAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(ResolveAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ResolveAsset_Name_PropertyAddress, ResolveAsset_FunctionAddress, "Name");
		ResolveAsset_Name_Offset = NativeReflectionCached.GetPropertyOffset(ResolveAsset_FunctionAddress, "Name");
		ResolveAsset_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveAsset_FunctionAddress, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveAsset_bTryLoad_PropertyAddress, ResolveAsset_FunctionAddress, "bTryLoad");
		ResolveAsset_bTryLoad_Offset = NativeReflectionCached.GetPropertyOffset(ResolveAsset_FunctionAddress, "bTryLoad");
		ResolveAsset_bTryLoad_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveAsset_FunctionAddress, "bTryLoad", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ResolveAsset_ReturnValue_PropertyAddress, ResolveAsset_FunctionAddress, "ReturnValue");
		ResolveAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ResolveAsset_FunctionAddress, "ReturnValue");
		ResolveAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ResolveAsset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		ResolveAsset_IsValid = ResolveAsset_FunctionAddress != IntPtr.Zero && ResolveAsset_Name_IsValid && ResolveAsset_bTryLoad_IsValid && ResolveAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:ResolveAsset", ResolveAsset_IsValid);
		Invoke_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Invoke");
		Invoke_ParamsSize = NativeReflection.GetFunctionParamsSize(Invoke_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Invoke_Name_PropertyAddress, Invoke_FunctionAddress, "Name");
		Invoke_Name_Offset = NativeReflectionCached.GetPropertyOffset(Invoke_FunctionAddress, "Name");
		Invoke_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(Invoke_FunctionAddress, "Name", Classes.FNameProperty);
		Invoke_IsValid = Invoke_FunctionAddress != IntPtr.Zero && Invoke_Name_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:Invoke", Invoke_IsValid);
		ForceGC_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ForceGC");
		ForceGC_ParamsSize = NativeReflection.GetFunctionParamsSize(ForceGC_FunctionAddress);
		ForceGC_IsValid = ForceGC_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:ForceGC", ForceGC_IsValid);
		Expose_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Expose");
		Expose_ParamsSize = NativeReflection.GetFunctionParamsSize(Expose_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Expose_ExposedAs_PropertyAddress, Expose_FunctionAddress, "ExposedAs");
		Expose_ExposedAs_Offset = NativeReflectionCached.GetPropertyOffset(Expose_FunctionAddress, "ExposedAs");
		Expose_ExposedAs_IsValid = NativeReflectionCached.ValidatePropertyClass(Expose_FunctionAddress, "ExposedAs", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref Expose_Object_PropertyAddress, Expose_FunctionAddress, "Object");
		Expose_Object_Offset = NativeReflectionCached.GetPropertyOffset(Expose_FunctionAddress, "Object");
		Expose_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(Expose_FunctionAddress, "Object", Classes.FObjectProperty);
		Expose_IsValid = Expose_FunctionAddress != IntPtr.Zero && Expose_ExposedAs_IsValid && Expose_Object_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/V8.JavascriptComponent:Expose", Expose_IsValid);
	}
}
