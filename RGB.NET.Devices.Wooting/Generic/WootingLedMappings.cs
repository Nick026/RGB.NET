// ReSharper disable InconsistentNaming

using System.Collections.Generic;
using RGB.NET.Core;
using RGB.NET.Devices.Wooting.Enum;

namespace RGB.NET.Devices.Wooting.Generic;

/// <summary>
/// Contains all the hardware-id mappings for Wooting devices.
/// </summary>
internal static class WootingLedMappings
{
    #region Properties & Fields

    private static readonly Dictionary<LedId, (int row, int column)> TKL = new()
    {
        { LedId.Keyboard_Escape, (0, 0) },
        { LedId.Keyboard_F1, (0, 2) },
        { LedId.Keyboard_F2, (0, 3) },
        { LedId.Keyboard_F3, (0, 4) },
        { LedId.Keyboard_F4, (0, 5) },
        { LedId.Keyboard_F5, (0, 6) },
        { LedId.Keyboard_F6, (0, 7) },
        { LedId.Keyboard_F7, (0, 8) },
        { LedId.Keyboard_F8, (0, 9) },
        { LedId.Keyboard_F9, (0, 10) },
        { LedId.Keyboard_F10, (0, 11) },
        { LedId.Keyboard_F11, (0, 12) },
        { LedId.Keyboard_F12, (0, 13) },
        { LedId.Keyboard_PrintScreen, (0, 14) },
        { LedId.Keyboard_PauseBreak, (0, 15) },
        { LedId.Keyboard_Custom1, (0, 16) },

        { LedId.Keyboard_GraveAccentAndTilde, (1, 0) },
        { LedId.Keyboard_1, (1, 1) },
        { LedId.Keyboard_2, (1, 2) },
        { LedId.Keyboard_3, (1, 3) },
        { LedId.Keyboard_4, (1, 4) },
        { LedId.Keyboard_5, (1, 5) },
        { LedId.Keyboard_6, (1, 6) },
        { LedId.Keyboard_7, (1, 7) },
        { LedId.Keyboard_8, (1, 8) },
        { LedId.Keyboard_9, (1, 9) },
        { LedId.Keyboard_0, (1, 10) },
        { LedId.Keyboard_MinusAndUnderscore, (1, 11) },
        { LedId.Keyboard_EqualsAndPlus, (1, 12) },
        { LedId.Keyboard_Backspace, (1, 13) },
        { LedId.Keyboard_Insert, (1, 14) },
        { LedId.Keyboard_Home, (1, 15) },
        { LedId.Keyboard_PageUp, (1, 16) },

        { LedId.Keyboard_Tab, (2, 0) },
        { LedId.Keyboard_Q, (2, 1) },
        { LedId.Keyboard_W, (2, 2) },
        { LedId.Keyboard_E, (2, 3) },
        { LedId.Keyboard_R, (2, 4) },
        { LedId.Keyboard_T, (2, 5) },
        { LedId.Keyboard_Y, (2, 6) },
        { LedId.Keyboard_U, (2, 7) },
        { LedId.Keyboard_I, (2, 8) },
        { LedId.Keyboard_O, (2, 9) },
        { LedId.Keyboard_P, (2, 10) },
        { LedId.Keyboard_BracketLeft, (2, 11) },
        { LedId.Keyboard_BracketRight, (2, 12) },
        { LedId.Keyboard_Backslash, (2, 13) },
        { LedId.Keyboard_Delete, (2, 14) },
        { LedId.Keyboard_End, (2, 15) },
        { LedId.Keyboard_PageDown, (2, 16) },

        { LedId.Keyboard_CapsLock, (3, 0) },
        { LedId.Keyboard_A, (3, 1) },
        { LedId.Keyboard_S, (3, 2) },
        { LedId.Keyboard_D, (3, 3) },
        { LedId.Keyboard_F, (3, 4) },
        { LedId.Keyboard_G, (3, 5) },
        { LedId.Keyboard_H, (3, 6) },
        { LedId.Keyboard_J, (3, 7) },
        { LedId.Keyboard_K, (3, 8) },
        { LedId.Keyboard_L, (3, 9) },
        { LedId.Keyboard_SemicolonAndColon, (3, 10) },
        { LedId.Keyboard_ApostropheAndDoubleQuote, (3, 11) },
        { LedId.Keyboard_NonUsTilde, (3, 12) },
        { LedId.Keyboard_Enter, (3, 13) },

        { LedId.Keyboard_LeftShift, (4, 0) },
        { LedId.Keyboard_NonUsBackslash, (4, 1) },
        { LedId.Keyboard_Z, (4, 2) },
        { LedId.Keyboard_X, (4, 3) },
        { LedId.Keyboard_C, (4, 4) },
        { LedId.Keyboard_V, (4, 5) },
        { LedId.Keyboard_B, (4, 6) },
        { LedId.Keyboard_N, (4, 7) },
        { LedId.Keyboard_M, (4, 8) },
        { LedId.Keyboard_CommaAndLessThan, (4, 9) },
        { LedId.Keyboard_PeriodAndBiggerThan, (4, 10) },
        { LedId.Keyboard_SlashAndQuestionMark, (4, 11) },
        { LedId.Keyboard_RightShift, (4, 13) },
        { LedId.Keyboard_ArrowUp, (4, 15) },

        { LedId.Keyboard_LeftCtrl, (5, 0) },
        { LedId.Keyboard_LeftGui, (5, 1) },
        { LedId.Keyboard_LeftAlt, (5, 2) },
        { LedId.Keyboard_Space, (5, 6) },
        { LedId.Keyboard_RightAlt, (5, 10) },
        { LedId.Keyboard_RightGui, (5, 11) },
        { LedId.Keyboard_Function, (5, 12) },
        { LedId.Keyboard_RightCtrl, (5, 13) },
        { LedId.Keyboard_ArrowLeft, (5, 14) },
        { LedId.Keyboard_ArrowDown, (5, 15) },
        { LedId.Keyboard_ArrowRight, (5, 16) }
    };

    private static readonly Dictionary<LedId, (int row, int column)> Fullsize = new()
    {
        { LedId.Keyboard_Escape, (0, 0) },
        { LedId.Keyboard_F1, (0, 2) },
        { LedId.Keyboard_F2, (0, 3) },
        { LedId.Keyboard_F3, (0, 4) },
        { LedId.Keyboard_F4, (0, 5) },
        { LedId.Keyboard_F5, (0, 6) },
        { LedId.Keyboard_F6, (0, 7) },
        { LedId.Keyboard_F7, (0, 8) },
        { LedId.Keyboard_F8, (0, 9) },
        { LedId.Keyboard_F9, (0, 10) },
        { LedId.Keyboard_F10, (0, 11) },
        { LedId.Keyboard_F11, (0, 12) },
        { LedId.Keyboard_F12, (0, 13) },
        { LedId.Keyboard_PrintScreen, (0, 14) },
        { LedId.Keyboard_PauseBreak, (0, 15) },
        { LedId.Keyboard_ScrollLock, (0, 16) },
        { LedId.Keyboard_Custom1, (0, 17) },
        { LedId.Keyboard_Custom2, (0, 18) },
        { LedId.Keyboard_Custom3, (0, 19) },
        { LedId.Keyboard_Custom4, (0, 20) },

        { LedId.Keyboard_GraveAccentAndTilde, (1, 0) },
        { LedId.Keyboard_1, (1, 1) },
        { LedId.Keyboard_2, (1, 2) },
        { LedId.Keyboard_3, (1, 3) },
        { LedId.Keyboard_4, (1, 4) },
        { LedId.Keyboard_5, (1, 5) },
        { LedId.Keyboard_6, (1, 6) },
        { LedId.Keyboard_7, (1, 7) },
        { LedId.Keyboard_8, (1, 8) },
        { LedId.Keyboard_9, (1, 9) },
        { LedId.Keyboard_0, (1, 10) },
        { LedId.Keyboard_MinusAndUnderscore, (1, 11) },
        { LedId.Keyboard_EqualsAndPlus, (1, 12) },
        { LedId.Keyboard_Backspace, (1, 13) },
        { LedId.Keyboard_Insert, (1, 14) },
        { LedId.Keyboard_Home, (1, 15) },
        { LedId.Keyboard_PageUp, (1, 16) },
        { LedId.Keyboard_NumLock, (1, 17) },
        { LedId.Keyboard_NumSlash, (1, 18) },
        { LedId.Keyboard_NumAsterisk, (1, 19) },
        { LedId.Keyboard_NumMinus, (1, 20) },

        { LedId.Keyboard_Tab, (2, 0) },
        { LedId.Keyboard_Q, (2, 1) },
        { LedId.Keyboard_W, (2, 2) },
        { LedId.Keyboard_E, (2, 3) },
        { LedId.Keyboard_R, (2, 4) },
        { LedId.Keyboard_T, (2, 5) },
        { LedId.Keyboard_Y, (2, 6) },
        { LedId.Keyboard_U, (2, 7) },
        { LedId.Keyboard_I, (2, 8) },
        { LedId.Keyboard_O, (2, 9) },
        { LedId.Keyboard_P, (2, 10) },
        { LedId.Keyboard_BracketLeft, (2, 11) },
        { LedId.Keyboard_BracketRight, (2, 12) },
        { LedId.Keyboard_Backslash, (2, 13) },
        { LedId.Keyboard_Delete, (2, 14) },
        { LedId.Keyboard_End, (2, 15) },
        { LedId.Keyboard_PageDown, (2, 16) },
        { LedId.Keyboard_Num7, (2, 17) },
        { LedId.Keyboard_Num8, (2, 18) },
        { LedId.Keyboard_Num9, (2, 19) },
        { LedId.Keyboard_NumPlus, (2, 20) },

        { LedId.Keyboard_CapsLock, (3, 0) },
        { LedId.Keyboard_A, (3, 1) },
        { LedId.Keyboard_S, (3, 2) },
        { LedId.Keyboard_D, (3, 3) },
        { LedId.Keyboard_F, (3, 4) },
        { LedId.Keyboard_G, (3, 5) },
        { LedId.Keyboard_H, (3, 6) },
        { LedId.Keyboard_J, (3, 7) },
        { LedId.Keyboard_K, (3, 8) },
        { LedId.Keyboard_L, (3, 9) },
        { LedId.Keyboard_SemicolonAndColon, (3, 10) },
        { LedId.Keyboard_ApostropheAndDoubleQuote, (3, 11) },
        { LedId.Keyboard_NonUsTilde, (3, 12) },
        { LedId.Keyboard_Enter, (3, 13) },
        { LedId.Keyboard_Num4, (3, 17) },
        { LedId.Keyboard_Num5, (3, 18) },
        { LedId.Keyboard_Num6, (3, 19) },

        { LedId.Keyboard_LeftShift, (4, 0) },
        { LedId.Keyboard_NonUsBackslash, (4, 1) },
        { LedId.Keyboard_Z, (4, 2) },
        { LedId.Keyboard_X, (4, 3) },
        { LedId.Keyboard_C, (4, 4) },
        { LedId.Keyboard_V, (4, 5) },
        { LedId.Keyboard_B, (4, 6) },
        { LedId.Keyboard_N, (4, 7) },
        { LedId.Keyboard_M, (4, 8) },
        { LedId.Keyboard_CommaAndLessThan, (4, 9) },
        { LedId.Keyboard_PeriodAndBiggerThan, (4, 10) },
        { LedId.Keyboard_SlashAndQuestionMark, (4, 11) },
        { LedId.Keyboard_RightShift, (4, 13) },
        { LedId.Keyboard_ArrowUp, (4, 15) },
        { LedId.Keyboard_Num1, (4, 17) },
        { LedId.Keyboard_Num2, (4, 18) },
        { LedId.Keyboard_Num3, (4, 19) },
        { LedId.Keyboard_NumEnter, (4, 20) },

        { LedId.Keyboard_LeftCtrl, (5, 0) },
        { LedId.Keyboard_LeftGui, (5, 1) },
        { LedId.Keyboard_LeftAlt, (5, 2) },
        { LedId.Keyboard_Space, (5, 6) },
        { LedId.Keyboard_RightAlt, (5, 10) },
        { LedId.Keyboard_RightGui, (5, 11) },
        { LedId.Keyboard_Function, (5, 12) },
        { LedId.Keyboard_RightCtrl, (5, 13) },
        { LedId.Keyboard_ArrowLeft, (5, 14) },
        { LedId.Keyboard_ArrowDown, (5, 15) },
        { LedId.Keyboard_ArrowRight, (5, 16) },
        { LedId.Keyboard_Num0, (5, 18) },
        { LedId.Keyboard_NumPeriodAndDelete, (5, 19) }
    };

    private static readonly Dictionary<LedId, (int row, int column)> SixtyPercent = new()
    {
        { LedId.Keyboard_Escape, (1, 0) },
        { LedId.Keyboard_1, (1, 1) },
        { LedId.Keyboard_2, (1, 2) },
        { LedId.Keyboard_3, (1, 3) },
        { LedId.Keyboard_4, (1, 4) },
        { LedId.Keyboard_5, (1, 5) },
        { LedId.Keyboard_6, (1, 6) },
        { LedId.Keyboard_7, (1, 7) },
        { LedId.Keyboard_8, (1, 8) },
        { LedId.Keyboard_9, (1, 9) },
        { LedId.Keyboard_0, (1, 10) },
        { LedId.Keyboard_MinusAndUnderscore, (1, 11) },
        { LedId.Keyboard_EqualsAndPlus, (1, 12) },
        { LedId.Keyboard_Backspace, (1, 13) },

        { LedId.Keyboard_Tab, (2, 0) },
        { LedId.Keyboard_Q, (2, 1) },
        { LedId.Keyboard_W, (2, 2) },
        { LedId.Keyboard_E, (2, 3) },
        { LedId.Keyboard_R, (2, 4) },
        { LedId.Keyboard_T, (2, 5) },
        { LedId.Keyboard_Y, (2, 6) },
        { LedId.Keyboard_U, (2, 7) },
        { LedId.Keyboard_I, (2, 8) },
        { LedId.Keyboard_O, (2, 9) },
        { LedId.Keyboard_P, (2, 10) },
        { LedId.Keyboard_BracketLeft, (2, 11) },
        { LedId.Keyboard_BracketRight, (2, 12) },
        { LedId.Keyboard_Backslash, (2, 13) },

        { LedId.Keyboard_CapsLock, (3, 0) },
        { LedId.Keyboard_A, (3, 1) },
        { LedId.Keyboard_S, (3, 2) },
        { LedId.Keyboard_D, (3, 3) },
        { LedId.Keyboard_F, (3, 4) },
        { LedId.Keyboard_G, (3, 5) },
        { LedId.Keyboard_H, (3, 6) },
        { LedId.Keyboard_J, (3, 7) },
        { LedId.Keyboard_K, (3, 8) },
        { LedId.Keyboard_L, (3, 9) },
        { LedId.Keyboard_SemicolonAndColon, (3, 10) },
        { LedId.Keyboard_ApostropheAndDoubleQuote, (3, 11) },
        { LedId.Keyboard_NonUsTilde, (3, 12) },
        { LedId.Keyboard_Enter, (3, 13) },

        { LedId.Keyboard_LeftShift, (4, 0) },
        { LedId.Keyboard_NonUsBackslash, (4, 1) },
        { LedId.Keyboard_Z, (4, 2) },
        { LedId.Keyboard_X, (4, 3) },
        { LedId.Keyboard_C, (4, 4) },
        { LedId.Keyboard_V, (4, 5) },
        { LedId.Keyboard_B, (4, 6) },
        { LedId.Keyboard_N, (4, 7) },
        { LedId.Keyboard_M, (4, 8) },
        { LedId.Keyboard_CommaAndLessThan, (4, 9) },
        { LedId.Keyboard_PeriodAndBiggerThan, (4, 10) },
        { LedId.Keyboard_SlashAndQuestionMark, (4, 11) },
        { LedId.Keyboard_RightShift, (4, 13) },

        { LedId.Keyboard_LeftCtrl, (5, 0) },
        { LedId.Keyboard_LeftGui, (5, 1) },
        { LedId.Keyboard_LeftAlt, (5, 2) },
        { LedId.Keyboard_Custom1, (5, 4) },
        { LedId.Keyboard_Custom2, (5, 5) },
        { LedId.Keyboard_Space, (5, 6) },
        { LedId.Keyboard_Custom3, (5, 7) },
        { LedId.Keyboard_Custom4, (5, 8) },
        { LedId.Keyboard_RightAlt, (5, 10) },
        { LedId.Keyboard_Application, (5, 11) },
        { LedId.Keyboard_RightCtrl, (5, 12) },
        { LedId.Keyboard_Function, (5, 13) }
    };

    private static readonly Dictionary<LedId, (int row, int column)> ThreeKeyKeypad = new()
    {
        //left (from top to bottom)
        [LedId.LedStripe1] = (1, 0),
        [LedId.LedStripe2] = (2, 0),
        [LedId.LedStripe3] = (3, 0),
        
        //bottom (from left to right)
        [LedId.LedStripe4] = (4, 1),
        [LedId.LedStripe5] = (4, 2),
        [LedId.LedStripe6] = (4, 4),
        [LedId.LedStripe7] = (4, 5),
        
        //right (from bottom to top)
        [LedId.LedStripe8] = (3, 6),
        [LedId.LedStripe9] = (2, 6),
        [LedId.LedStripe10] = (1, 6),
        
        //top (from right to left)
        [LedId.LedStripe11] = (0, 6),
        [LedId.LedStripe12] = (0, 4),
        [LedId.LedStripe13] = (0, 2),
        [LedId.LedStripe14] = (0, 0),
        
        //analog keys
        [LedId.Keypad1] = (2, 1),
        [LedId.Keypad2] = (2, 3),
        [LedId.Keypad3] = (2, 5),
    };

    /// <summary>
    /// Contains all the hardware-id mappings for Wooting devices.
    /// </summary>
    public static readonly Dictionary<WootingDeviceType, Dictionary<LedId, (int row, int column)>> Mapping = new()
    {
        [WootingDeviceType.Keyboard] = Fullsize,
        [WootingDeviceType.KeyboardTKL] = TKL,
        [WootingDeviceType.KeyboardSixtyPercent] = SixtyPercent,
        [WootingDeviceType.Keypad3Keys] = ThreeKeyKeypad
    };

    #endregion
}
