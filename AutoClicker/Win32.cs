using System;
using System.Runtime.InteropServices;

namespace AutoClicker
{
    public class Win32
    {
        public const int WM_HOTKEY = 0x0312;

        public enum SendInputEventType
        {
            InputMouse    = 0x0000,
            InputKeyboard = 0x0001
        }

        public enum MouseEventFlags
        {
            Move       = 0x0001,
            LeftDown   = 0x0002,
            LeftUp     = 0x0004,
            RightDown  = 0x0008,
            RightUp    = 0x0010,
            MiddleDown = 0x0020,
            MiddleUp   = 0x0040,
            Wheel      = 0x0080,
            XDown      = 0x0100,
            XUp        = 0x0200,
            Absolute   = 0x8000
        }

        public enum SystemMetric
        {
            CXScreen = 0x0000,
            CYScreen = 0x0001,
        }

        public enum fsModifiers : uint
        {
            Alt = 0x0001,
            Control = 0x0002,
            Shift = 0x0004,
            Windows = 0x0008,
            NoRepeat = 0x4000
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct INPUT
        {
            public SendInputEventType type; // 0 = INPUT_MOUSE(デフォルト), 1 = INPUT_KEYBOARD 
            public MOUSEINPUT         mi;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MOUSEINPUT
        {
            public int             dx;
            public int             dy;
            public int             mouseData;
            public MouseEventFlags dwFlags;
            public int             time;
            public IntPtr          dwExtraInfo;
        }

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);
        [DllImport("user32.dll")]
        public static extern uint SendInput(
                uint nInputs,    // INPUT 構造体の数(イベント数)
                INPUT[] pInputs, // INPUT 構造体
                int cbSize       // INPUT 構造体のサイズ
        );

        [DllImport("user32.dll")]
        public static extern int GetSystemMetrics(SystemMetric smIndex);

        public static int CalculateAbsoluteCoordinateX(int x)
        {
            return (x * 65536) / GetSystemMetrics(SystemMetric.CXScreen);
        }

        public static int CalculateAbsoluteCoordinateY(int y)
        {
            return (y * 65536) / GetSystemMetrics(SystemMetric.CYScreen);
        }
    }
}
