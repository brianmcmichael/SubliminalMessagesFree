using System;

public class Mouse
{
    [System.Runtime.InteropServices.DllImport("user32.dll")]
    private static extern void mouse_event(UInt32 dwFlags, UInt32 dx, UInt32 dy, UInt32 dwData, IntPtr dwExtraInfo);

    private const UInt32 MouseEventLeftDown = 0x0002;
    private const UInt32 MouseEventLeftUp = 0x0004;

    public static void SendDoubleClick(uint X, uint Y)
    {
        mouse_event(MouseEventLeftDown, X, Y, 0, new System.IntPtr());
        mouse_event(MouseEventLeftUp, X, Y, 0, new System.IntPtr());
    }
}