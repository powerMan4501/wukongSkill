using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace System.Net;

internal abstract class SafeDeleteContext : SafeHandle
{
	private const string dummyStr = " ";

	private static readonly byte[] dummyBytes = new byte[1];

	internal SSPIHandle _handle;

	protected SafeFreeCredentials _EffectiveCredential;

	public override bool IsInvalid
	{
		get
		{
			if (!base.IsClosed)
			{
				return _handle.IsZero;
			}
			return true;
		}
	}

	protected SafeDeleteContext()
		: base(IntPtr.Zero, ownsHandle: true)
	{
		_handle = default(SSPIHandle);
	}

	public override string ToString()
	{
		return _handle.ToString();
	}

	internal unsafe static int InitializeSecurityContext(SecurDll dll, ref SafeFreeCredentials inCredentials, ref SafeDeleteContext refContext, string targetName, ContextFlags inFlags, Endianness endianness, SecurityBuffer inSecBuffer, SecurityBuffer[] inSecBuffers, SecurityBuffer outSecBuffer, ref ContextFlags outFlags)
	{
		if (inCredentials == null)
		{
			throw new ArgumentNullException("inCredentials");
		}
		SecurityBufferDescriptor securityBufferDescriptor = null;
		if (inSecBuffer != null)
		{
			securityBufferDescriptor = new SecurityBufferDescriptor(1);
		}
		else if (inSecBuffers != null)
		{
			securityBufferDescriptor = new SecurityBufferDescriptor(inSecBuffers.Length);
		}
		SecurityBufferDescriptor securityBufferDescriptor2 = new SecurityBufferDescriptor(1);
		bool flag = (((inFlags & ContextFlags.AllocateMemory) != ContextFlags.Zero) ? true : false);
		int result = -1;
		bool flag2 = true;
		if (refContext != null)
		{
			flag2 = refContext._handle.IsZero;
		}
		GCHandle[] array = null;
		GCHandle gCHandle = default(GCHandle);
		SafeFreeContextBuffer safeFreeContextBuffer = null;
		try
		{
			gCHandle = GCHandle.Alloc(outSecBuffer.token, GCHandleType.Pinned);
			SecurityBufferStruct[] array2 = new SecurityBufferStruct[securityBufferDescriptor?.Count ?? 1];
			fixed (SecurityBufferStruct* ptr = array2)
			{
				void* unmanagedPointer = ptr;
				if (securityBufferDescriptor != null)
				{
					securityBufferDescriptor.UnmanagedPointer = unmanagedPointer;
					array = new GCHandle[securityBufferDescriptor.Count];
					for (int i = 0; i < securityBufferDescriptor.Count; i++)
					{
						SecurityBuffer securityBuffer = ((inSecBuffer != null) ? inSecBuffer : inSecBuffers[i]);
						if (securityBuffer != null)
						{
							array2[i].count = securityBuffer.size;
							array2[i].type = securityBuffer.type;
							if (securityBuffer.unmanagedToken != null)
							{
								array2[i].token = securityBuffer.unmanagedToken.DangerousGetHandle();
								continue;
							}
							if (securityBuffer.token == null || securityBuffer.token.Length == 0)
							{
								array2[i].token = IntPtr.Zero;
								continue;
							}
							array[i] = GCHandle.Alloc(securityBuffer.token, GCHandleType.Pinned);
							array2[i].token = Marshal.UnsafeAddrOfPinnedArrayElement((Array)securityBuffer.token, securityBuffer.offset);
						}
					}
				}
				SecurityBufferStruct[] array3 = new SecurityBufferStruct[1];
				fixed (SecurityBufferStruct* ptr2 = array3)
				{
					void* unmanagedPointer2 = ptr2;
					securityBufferDescriptor2.UnmanagedPointer = unmanagedPointer2;
					array3[0].count = outSecBuffer.size;
					array3[0].type = outSecBuffer.type;
					if (outSecBuffer.token == null || outSecBuffer.token.Length == 0)
					{
						array3[0].token = IntPtr.Zero;
					}
					else
					{
						array3[0].token = Marshal.UnsafeAddrOfPinnedArrayElement((Array)outSecBuffer.token, outSecBuffer.offset);
					}
					if (flag)
					{
						safeFreeContextBuffer = SafeFreeContextBuffer.CreateEmptyHandle(dll);
					}
					if (dll != SecurDll.SECURITY)
					{
						throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
					}
					if ((refContext == null || refContext.IsInvalid) && flag2)
					{
						refContext = new SafeDeleteContext_SECURITY();
					}
					if (targetName == null || targetName.Length == 0)
					{
						targetName = " ";
					}
					fixed (char* ptr3 = targetName)
					{
						result = MustRunInitializeSecurityContext_SECURITY(ref inCredentials, flag2, (byte*)(((object)targetName == " ") ? null : ptr3), inFlags, endianness, securityBufferDescriptor, refContext, securityBufferDescriptor2, ref outFlags, safeFreeContextBuffer);
					}
					outSecBuffer.size = array3[0].count;
					outSecBuffer.type = array3[0].type;
					if (outSecBuffer.size > 0)
					{
						outSecBuffer.token = new byte[outSecBuffer.size];
						Marshal.Copy(array3[0].token, outSecBuffer.token, 0, outSecBuffer.size);
					}
					else
					{
						outSecBuffer.token = null;
					}
				}
			}
		}
		finally
		{
			if (array != null)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].IsAllocated)
					{
						array[j].Free();
					}
				}
			}
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			safeFreeContextBuffer?.Close();
		}
		return result;
	}

	private unsafe static int MustRunInitializeSecurityContext_SECURITY(ref SafeFreeCredentials inCredentials, bool isContextAbsent, byte* targetName, ContextFlags inFlags, Endianness endianness, SecurityBufferDescriptor inputBuffer, SafeDeleteContext outContext, SecurityBufferDescriptor outputBuffer, ref ContextFlags attributes, SafeFreeContextBuffer handleTemplate)
	{
		int num = -2146893055;
		bool success = false;
		bool success2 = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			inCredentials.DangerousAddRef(ref success);
			outContext.DangerousAddRef(ref success2);
		}
		catch (Exception ex)
		{
			if (success)
			{
				inCredentials.DangerousRelease();
				success = false;
			}
			if (success2)
			{
				outContext.DangerousRelease();
				success2 = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			SSPIHandle credentialHandle = inCredentials._handle;
			if (!success)
			{
				inCredentials = null;
			}
			else if (success && success2)
			{
				SSPIHandle sSPIHandle = outContext._handle;
				void* ptr = (sSPIHandle.IsZero ? null : (&sSPIHandle));
				isContextAbsent = ptr == null;
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.InitializeSecurityContextW(ref credentialHandle, ptr, targetName, inFlags, 0, endianness, inputBuffer, 0, ref outContext._handle, outputBuffer, ref attributes, out var _);
				if (outContext._EffectiveCredential != inCredentials && (num & 0x80000000u) == 0L)
				{
					if (outContext._EffectiveCredential != null)
					{
						outContext._EffectiveCredential.DangerousRelease();
					}
					outContext._EffectiveCredential = inCredentials;
				}
				else
				{
					inCredentials.DangerousRelease();
				}
				outContext.DangerousRelease();
				if (handleTemplate != null)
				{
					handleTemplate.Set(((SecurityBufferStruct*)outputBuffer.UnmanagedPointer)->token);
					if (handleTemplate.IsInvalid)
					{
						handleTemplate.SetHandleAsInvalid();
					}
				}
			}
			if (isContextAbsent && (num & 0x80000000u) != 0L)
			{
				outContext._handle.SetToInvalid();
			}
		}
		return num;
	}

	internal unsafe static int AcceptSecurityContext(SecurDll dll, ref SafeFreeCredentials inCredentials, ref SafeDeleteContext refContext, ContextFlags inFlags, Endianness endianness, SecurityBuffer inSecBuffer, SecurityBuffer[] inSecBuffers, SecurityBuffer outSecBuffer, ref ContextFlags outFlags)
	{
		if (inCredentials == null)
		{
			throw new ArgumentNullException("inCredentials");
		}
		SecurityBufferDescriptor securityBufferDescriptor = null;
		if (inSecBuffer != null)
		{
			securityBufferDescriptor = new SecurityBufferDescriptor(1);
		}
		else if (inSecBuffers != null)
		{
			securityBufferDescriptor = new SecurityBufferDescriptor(inSecBuffers.Length);
		}
		SecurityBufferDescriptor securityBufferDescriptor2 = new SecurityBufferDescriptor(1);
		bool flag = (((inFlags & ContextFlags.AllocateMemory) != ContextFlags.Zero) ? true : false);
		int result = -1;
		bool flag2 = true;
		if (refContext != null)
		{
			flag2 = refContext._handle.IsZero;
		}
		GCHandle[] array = null;
		GCHandle gCHandle = default(GCHandle);
		SafeFreeContextBuffer safeFreeContextBuffer = null;
		try
		{
			gCHandle = GCHandle.Alloc(outSecBuffer.token, GCHandleType.Pinned);
			SecurityBufferStruct[] array2 = new SecurityBufferStruct[securityBufferDescriptor?.Count ?? 1];
			fixed (SecurityBufferStruct* ptr = array2)
			{
				void* unmanagedPointer = ptr;
				if (securityBufferDescriptor != null)
				{
					securityBufferDescriptor.UnmanagedPointer = unmanagedPointer;
					array = new GCHandle[securityBufferDescriptor.Count];
					for (int i = 0; i < securityBufferDescriptor.Count; i++)
					{
						SecurityBuffer securityBuffer = ((inSecBuffer != null) ? inSecBuffer : inSecBuffers[i]);
						if (securityBuffer != null)
						{
							array2[i].count = securityBuffer.size;
							array2[i].type = securityBuffer.type;
							if (securityBuffer.unmanagedToken != null)
							{
								array2[i].token = securityBuffer.unmanagedToken.DangerousGetHandle();
								continue;
							}
							if (securityBuffer.token == null || securityBuffer.token.Length == 0)
							{
								array2[i].token = IntPtr.Zero;
								continue;
							}
							array[i] = GCHandle.Alloc(securityBuffer.token, GCHandleType.Pinned);
							array2[i].token = Marshal.UnsafeAddrOfPinnedArrayElement((Array)securityBuffer.token, securityBuffer.offset);
						}
					}
				}
				SecurityBufferStruct[] array3 = new SecurityBufferStruct[1];
				fixed (SecurityBufferStruct* ptr2 = array3)
				{
					void* unmanagedPointer2 = ptr2;
					securityBufferDescriptor2.UnmanagedPointer = unmanagedPointer2;
					array3[0].count = outSecBuffer.size;
					array3[0].type = outSecBuffer.type;
					if (outSecBuffer.token == null || outSecBuffer.token.Length == 0)
					{
						array3[0].token = IntPtr.Zero;
					}
					else
					{
						array3[0].token = Marshal.UnsafeAddrOfPinnedArrayElement((Array)outSecBuffer.token, outSecBuffer.offset);
					}
					if (flag)
					{
						safeFreeContextBuffer = SafeFreeContextBuffer.CreateEmptyHandle(dll);
					}
					if (dll != SecurDll.SECURITY)
					{
						throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
					}
					if ((refContext == null || refContext.IsInvalid) && flag2)
					{
						refContext = new SafeDeleteContext_SECURITY();
					}
					result = MustRunAcceptSecurityContext_SECURITY(ref inCredentials, flag2, securityBufferDescriptor, inFlags, endianness, refContext, securityBufferDescriptor2, ref outFlags, safeFreeContextBuffer);
					outSecBuffer.size = array3[0].count;
					outSecBuffer.type = array3[0].type;
					if (outSecBuffer.size > 0)
					{
						outSecBuffer.token = new byte[outSecBuffer.size];
						Marshal.Copy(array3[0].token, outSecBuffer.token, 0, outSecBuffer.size);
					}
					else
					{
						outSecBuffer.token = null;
					}
				}
			}
		}
		finally
		{
			if (array != null)
			{
				for (int j = 0; j < array.Length; j++)
				{
					if (array[j].IsAllocated)
					{
						array[j].Free();
					}
				}
			}
			if (gCHandle.IsAllocated)
			{
				gCHandle.Free();
			}
			safeFreeContextBuffer?.Close();
		}
		return result;
	}

	private unsafe static int MustRunAcceptSecurityContext_SECURITY(ref SafeFreeCredentials inCredentials, bool isContextAbsent, SecurityBufferDescriptor inputBuffer, ContextFlags inFlags, Endianness endianness, SafeDeleteContext outContext, SecurityBufferDescriptor outputBuffer, ref ContextFlags outFlags, SafeFreeContextBuffer handleTemplate)
	{
		int num = -2146893055;
		bool success = false;
		bool success2 = false;
		RuntimeHelpers.PrepareConstrainedRegions();
		try
		{
			inCredentials.DangerousAddRef(ref success);
			outContext.DangerousAddRef(ref success2);
		}
		catch (Exception ex)
		{
			if (success)
			{
				inCredentials.DangerousRelease();
				success = false;
			}
			if (success2)
			{
				outContext.DangerousRelease();
				success2 = false;
			}
			if (!(ex is ObjectDisposedException))
			{
				throw;
			}
		}
		finally
		{
			SSPIHandle credentialHandle = inCredentials._handle;
			if (!success)
			{
				inCredentials = null;
			}
			else if (success && success2)
			{
				SSPIHandle sSPIHandle = outContext._handle;
				void* ptr = (sSPIHandle.IsZero ? null : (&sSPIHandle));
				isContextAbsent = ptr == null;
				num = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.AcceptSecurityContext(ref credentialHandle, ptr, inputBuffer, inFlags, endianness, ref outContext._handle, outputBuffer, ref outFlags, out var _);
				if (outContext._EffectiveCredential != inCredentials && (num & 0x80000000u) == 0L)
				{
					if (outContext._EffectiveCredential != null)
					{
						outContext._EffectiveCredential.DangerousRelease();
					}
					outContext._EffectiveCredential = inCredentials;
				}
				else
				{
					inCredentials.DangerousRelease();
				}
				outContext.DangerousRelease();
				if (handleTemplate != null)
				{
					handleTemplate.Set(((SecurityBufferStruct*)outputBuffer.UnmanagedPointer)->token);
					if (handleTemplate.IsInvalid)
					{
						handleTemplate.SetHandleAsInvalid();
					}
				}
			}
			if (isContextAbsent && (num & 0x80000000u) != 0L)
			{
				outContext._handle.SetToInvalid();
			}
		}
		return num;
	}

	internal unsafe static int CompleteAuthToken(SecurDll dll, ref SafeDeleteContext refContext, SecurityBuffer[] inSecBuffers)
	{
		SecurityBufferDescriptor securityBufferDescriptor = new SecurityBufferDescriptor(inSecBuffers.Length);
		int result = -2146893055;
		GCHandle[] array = null;
		SecurityBufferStruct[] array2 = new SecurityBufferStruct[securityBufferDescriptor.Count];
		fixed (SecurityBufferStruct* ptr = array2)
		{
			void* unmanagedPointer = ptr;
			securityBufferDescriptor.UnmanagedPointer = unmanagedPointer;
			array = new GCHandle[securityBufferDescriptor.Count];
			for (int i = 0; i < securityBufferDescriptor.Count; i++)
			{
				SecurityBuffer securityBuffer = inSecBuffers[i];
				if (securityBuffer != null)
				{
					array2[i].count = securityBuffer.size;
					array2[i].type = securityBuffer.type;
					if (securityBuffer.unmanagedToken != null)
					{
						array2[i].token = securityBuffer.unmanagedToken.DangerousGetHandle();
						continue;
					}
					if (securityBuffer.token == null || securityBuffer.token.Length == 0)
					{
						array2[i].token = IntPtr.Zero;
						continue;
					}
					array[i] = GCHandle.Alloc(securityBuffer.token, GCHandleType.Pinned);
					array2[i].token = Marshal.UnsafeAddrOfPinnedArrayElement((Array)securityBuffer.token, securityBuffer.offset);
				}
			}
			SSPIHandle sSPIHandle = default(SSPIHandle);
			if (refContext != null)
			{
				sSPIHandle = refContext._handle;
			}
			try
			{
				if (dll != SecurDll.SECURITY)
				{
					throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
				}
				if ((refContext == null || refContext.IsInvalid) && sSPIHandle.IsZero)
				{
					refContext = new SafeDeleteContext_SECURITY();
				}
				bool success = false;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
					refContext.DangerousAddRef(ref success);
				}
				catch (Exception ex)
				{
					if (success)
					{
						refContext.DangerousRelease();
						success = false;
					}
					if (!(ex is ObjectDisposedException))
					{
						throw;
					}
				}
				finally
				{
					if (success)
					{
						result = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.CompleteAuthToken(sSPIHandle.IsZero ? null : (&sSPIHandle), securityBufferDescriptor);
						refContext.DangerousRelease();
					}
				}
			}
			finally
			{
				if (array != null)
				{
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j].IsAllocated)
						{
							array[j].Free();
						}
					}
				}
			}
		}
		return result;
	}

	internal unsafe static int ApplyControlToken(SecurDll dll, ref SafeDeleteContext refContext, SecurityBuffer[] inSecBuffers)
	{
		SecurityBufferDescriptor securityBufferDescriptor = new SecurityBufferDescriptor(inSecBuffers.Length);
		int result = -2146893055;
		GCHandle[] array = null;
		SecurityBufferStruct[] array2 = new SecurityBufferStruct[securityBufferDescriptor.Count];
		fixed (SecurityBufferStruct* ptr = array2)
		{
			void* unmanagedPointer = ptr;
			securityBufferDescriptor.UnmanagedPointer = unmanagedPointer;
			array = new GCHandle[securityBufferDescriptor.Count];
			for (int i = 0; i < securityBufferDescriptor.Count; i++)
			{
				SecurityBuffer securityBuffer = inSecBuffers[i];
				if (securityBuffer != null)
				{
					array2[i].count = securityBuffer.size;
					array2[i].type = securityBuffer.type;
					if (securityBuffer.unmanagedToken != null)
					{
						array2[i].token = securityBuffer.unmanagedToken.DangerousGetHandle();
						continue;
					}
					if (securityBuffer.token == null || securityBuffer.token.Length == 0)
					{
						array2[i].token = IntPtr.Zero;
						continue;
					}
					array[i] = GCHandle.Alloc(securityBuffer.token, GCHandleType.Pinned);
					array2[i].token = Marshal.UnsafeAddrOfPinnedArrayElement((Array)securityBuffer.token, securityBuffer.offset);
				}
			}
			SSPIHandle sSPIHandle = default(SSPIHandle);
			if (refContext != null)
			{
				sSPIHandle = refContext._handle;
			}
			try
			{
				if (dll != SecurDll.SECURITY)
				{
					throw new ArgumentException(SR.GetString("net_invalid_enum", "SecurDll"), "Dll");
				}
				if ((refContext == null || refContext.IsInvalid) && sSPIHandle.IsZero)
				{
					refContext = new SafeDeleteContext_SECURITY();
				}
				bool success = false;
				RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
					refContext.DangerousAddRef(ref success);
				}
				catch (Exception ex)
				{
					if (success)
					{
						refContext.DangerousRelease();
						success = false;
					}
					if (!(ex is ObjectDisposedException))
					{
						throw;
					}
				}
				finally
				{
					if (success)
					{
						result = UnsafeNclNativeMethods.SafeNetHandles_SECURITY.ApplyControlToken(sSPIHandle.IsZero ? null : (&sSPIHandle), securityBufferDescriptor);
						refContext.DangerousRelease();
					}
				}
			}
			finally
			{
				if (array != null)
				{
					for (int j = 0; j < array.Length; j++)
					{
						if (array[j].IsAllocated)
						{
							array[j].Free();
						}
					}
				}
			}
		}
		return result;
	}
}
