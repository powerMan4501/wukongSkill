using System;
using System.Runtime.InteropServices;

namespace b1.AutoQA;

public class QASimulateWindowsOperations
{
	[Flags]
	public enum MouseEventFlags
	{
		LeftDown = 2,
		LeftUp = 4,
		MiddleDown = 0x20,
		MiddleUp = 0x40,
		Move = 1,
		Absolute = 0x8000,
		RightDown = 8,
		RightUp = 0x10,
		Wheel = 0x800
	}

	public enum KeyCode : ushort
	{
		MEDIA_NEXT_TRACK = 176,
		MEDIA_PREV_TRACK = 177,
		MEDIA_STOP = 178,
		MEDIA_PLAY_PAUSE = 179,
		MULTIPLY = 106,
		ADD = 107,
		SUBTRACT = 109,
		DIVIDE = 111,
		BROWSER_BACK = 166,
		BROWSER_FORWARD = 167,
		BROWSER_REFRESH = 168,
		BROWSER_STOP = 169,
		BROWSER_SEARCH = 170,
		BROWSER_FAVORITES = 171,
		BROWSER_HOME = 172,
		NUMPAD0 = 96,
		NUMPAD1 = 97,
		NUMPAD2 = 98,
		NUMPAD3 = 99,
		NUMPAD4 = 100,
		NUMPAD5 = 101,
		NUMPAD6 = 102,
		NUMPAD7 = 103,
		NUMPAD8 = 104,
		NUMPAD9 = 105,
		F1 = 112,
		F2 = 113,
		F3 = 114,
		F4 = 115,
		F5 = 116,
		F6 = 117,
		F7 = 118,
		F8 = 119,
		F9 = 120,
		F10 = 121,
		F11 = 122,
		F12 = 123,
		F13 = 124,
		F14 = 125,
		F15 = 126,
		F16 = 127,
		F17 = 128,
		F18 = 129,
		F19 = 130,
		F20 = 131,
		F21 = 132,
		F22 = 133,
		F23 = 134,
		F24 = 135,
		OEM_COLON = 186,
		OEM_102 = 226,
		OEM_2 = 191,
		OEM_3 = 192,
		OEM_4 = 219,
		OEM_BACK_SLASH = 220,
		OEM_6 = 221,
		OEM_7 = 222,
		OEM_8 = 223,
		OEM_CLEAR = 254,
		OEM_COMMA = 188,
		OEM_MINUS = 189,
		OEM_PERIOD = 190,
		OEM_PLUS = 187,
		KEY_0 = 48,
		KEY_1 = 49,
		KEY_2 = 50,
		KEY_3 = 51,
		KEY_4 = 52,
		KEY_5 = 53,
		KEY_6 = 54,
		KEY_7 = 55,
		KEY_8 = 56,
		KEY_9 = 57,
		KEY_A = 65,
		KEY_B = 66,
		KEY_C = 67,
		KEY_D = 68,
		KEY_E = 69,
		KEY_F = 70,
		KEY_G = 71,
		KEY_H = 72,
		KEY_I = 73,
		KEY_J = 74,
		KEY_K = 75,
		KEY_L = 76,
		KEY_M = 77,
		KEY_N = 78,
		KEY_O = 79,
		KEY_P = 80,
		KEY_Q = 81,
		KEY_R = 82,
		KEY_S = 83,
		KEY_T = 84,
		KEY_U = 85,
		KEY_V = 86,
		KEY_W = 87,
		KEY_X = 88,
		KEY_Y = 89,
		KEY_Z = 90,
		VOLUME_MUTE = 173,
		VOLUME_DOWN = 174,
		VOLUME_UP = 175,
		SNAPSHOT = 44,
		RIGHT_CLICK = 93,
		BACKSPACE = 8,
		CANCEL = 3,
		CAPS_LOCK = 20,
		CONTROL = 17,
		ALT = 18,
		DECIMAL = 110,
		DELETE = 46,
		DOWN = 40,
		END = 35,
		ESC = 27,
		HOME = 36,
		INSERT = 45,
		LAUNCH_APP1 = 182,
		LAUNCH_APP2 = 183,
		LAUNCH_MAIL = 180,
		LAUNCH_MEDIA_SELECT = 181,
		LCONTROL = 162,
		LEFT = 37,
		LSHIFT = 160,
		LWIN = 91,
		PAGEDOWN = 34,
		NUMLOCK = 144,
		PAGE_UP = 33,
		RCONTROL = 163,
		ENTER = 13,
		RIGHT = 39,
		RSHIFT = 161,
		RWIN = 92,
		SHIFT = 16,
		SPACE_BAR = 32,
		TAB = 9,
		UP = 38
	}

	[Flags]
	public enum SendInputEventType : uint
	{
		InputMouse = 0u,
		InputKeyboard = 1u,
		InputHardware = 2u
	}

	public struct MOUSEINPUT
	{
		public int dx;

		public int dy;

		public uint mouseData;

		public MouseEventFlags dwFlags;

		public uint time;

		public IntPtr dwExtraInfo;
	}

	public struct KEYBOARDINPUT
	{
		public ushort wVk;

		public ushort wScan;

		public uint dwFlags;

		public uint time;

		public IntPtr dwExtraInfo;
	}

	public struct HARDWAREINPUT
	{
		public int uMsg;

		public short wParamL;

		public short wParamH;
	}

	[StructLayout(LayoutKind.Explicit)]
	public struct MOUSEANDKEYBOARDINPUT
	{
		[FieldOffset(0)]
		public MOUSEINPUT mi;

		[FieldOffset(0)]
		public KEYBOARDINPUT ki;

		[FieldOffset(0)]
		public HARDWAREINPUT hi;
	}

	public struct INPUT
	{
		public SendInputEventType type;

		public MOUSEANDKEYBOARDINPUT mkhi;
	}

	public struct MousePoint
	{
		public int X;

		public int Y;

		public MousePoint(int x, int y)
		{
			X = x;
			Y = y;
		}
	}

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool SetCursorPos(int x, int y);

	[DllImport("user32.dll")]
	[return: MarshalAs(UnmanagedType.Bool)]
	private static extern bool GetCursorPos(out MousePoint lpMousePoint);

	[DllImport("user32.dll")]
	public static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

	[DllImport("user32.dll", SetLastError = true)]
	public static extern uint SendInput(uint numberOfInputs, INPUT[] inputs, int sizeOfInputStructure);

	public static void KeyPress(KeyCode keyCode)
	{
		INPUT iNPUT = new INPUT
		{
			type = SendInputEventType.InputKeyboard,
			mkhi = new MOUSEANDKEYBOARDINPUT
			{
				ki = new KEYBOARDINPUT
				{
					wVk = (ushort)keyCode,
					wScan = 0,
					dwFlags = 0u,
					time = 0u,
					dwExtraInfo = IntPtr.Zero
				}
			}
		};
		INPUT iNPUT2 = new INPUT
		{
			type = SendInputEventType.InputKeyboard,
			mkhi = new MOUSEANDKEYBOARDINPUT
			{
				ki = new KEYBOARDINPUT
				{
					wVk = (ushort)keyCode,
					wScan = 0,
					dwFlags = 2u,
					time = 0u,
					dwExtraInfo = IntPtr.Zero
				}
			}
		};
		INPUT[] array = new INPUT[2] { iNPUT, iNPUT2 };
		SendInput((uint)array.Length, array, Marshal.SizeOf(typeof(INPUT)));
	}

	public static void SetCursorPosition(int x, int y)
	{
		SetCursorPos(x, y);
	}

	public static void SetCursorPosition(MousePoint point)
	{
		SetCursorPos(point.X, point.Y);
	}

	public static MousePoint GetCursorPosition()
	{
		if (!GetCursorPos(out var lpMousePoint))
		{
			lpMousePoint = new MousePoint(0, 0);
		}
		return lpMousePoint;
	}

	public static void MouseEvent(MouseEventFlags value)
	{
		MousePoint cursorPosition = GetCursorPosition();
		mouse_event((int)value, cursorPosition.X, cursorPosition.Y, 0, 0);
	}
}
