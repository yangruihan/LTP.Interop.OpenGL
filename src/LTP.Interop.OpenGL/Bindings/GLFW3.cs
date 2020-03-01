#region License
/*
	Copyright (c) 2002-2006 Marcus Geelnard

	Copyright (c) 2006-2019 Camilla Löwy

	This software is provided 'as-is', without any express or implied
	warranty. In no event will the authors be held liable for any damages
	arising from the use of this software.

	Permission is granted to anyone to use this software for any purpose,
	including commercial applications, and to alter it and redistribute it
	freely, subject to the following restrictions:

	1. The origin of this software must not be misrepresented; you must not
	   claim that you wrote the original software. If you use this software
	   in a product, an acknowledgment in the product documentation would
	   be appreciated but is not required.

	2. Altered source versions must be plainly marked as such, and must not
	   be misrepresented as being the original software.

	3. This notice may not be removed or altered from any source
	   distribution. 
*/
#endregion

#region Using statements
using System;

using LTP.Interop.InteropServices;
#endregion

namespace LTP.Interop.OpenGL.Bindings
{
	[Library( "glfw3" )]
	public static unsafe class GLFW3
	{
		#region Fields / Properties
		private static IntPtr _handle;
		#endregion

		#region Constants
		public const int GLFW_VERSION_MAJOR = 3;
		public const int GLFW_VERSION_MINOR = 3;
		public const int GLFW_VERSION_REVISION = 2;
		public const int GLFW_TRUE = 1;
		public const int GLFW_FALSE = 0;
		public const int GLFW_RELEASE = 0;
		public const int GLFW_PRESS = 1;
		public const int GLFW_REPEAT = 2;
		public const int GLFW_HAT_CENTERED = 0;
		public const int GLFW_HAT_UP = 1;
		public const int GLFW_HAT_RIGHT = 2;
		public const int GLFW_HAT_DOWN = 4;
		public const int GLFW_HAT_LEFT = 8;
		public const int GLFW_HAT_RIGHT_UP = ( GLFW_HAT_RIGHT | GLFW_HAT_UP );
		public const int GLFW_HAT_RIGHT_DOWN = ( GLFW_HAT_RIGHT | GLFW_HAT_DOWN );
		public const int GLFW_HAT_LEFT_UP = ( GLFW_HAT_LEFT | GLFW_HAT_UP );
		public const int GLFW_HAT_LEFT_DOWN = ( GLFW_HAT_LEFT | GLFW_HAT_DOWN );
		public const int GLFW_KEY_UNKNOWN = -1;
		public const int GLFW_KEY_SPACE = 32;
		public const int GLFW_KEY_APOSTROPHE = 39;
		public const int GLFW_KEY_COMMA = 44;
		public const int GLFW_KEY_MINUS = 45;
		public const int GLFW_KEY_PERIOD = 46;
		public const int GLFW_KEY_SLASH = 47;
		public const int GLFW_KEY_0 = 48;
		public const int GLFW_KEY_1 = 49;
		public const int GLFW_KEY_2 = 50;
		public const int GLFW_KEY_3 = 51;
		public const int GLFW_KEY_4 = 52;
		public const int GLFW_KEY_5 = 53;
		public const int GLFW_KEY_6 = 54;
		public const int GLFW_KEY_7 = 55;
		public const int GLFW_KEY_8 = 56;
		public const int GLFW_KEY_9 = 57;
		public const int GLFW_KEY_SEMICOLON = 59;
		public const int GLFW_KEY_EQUAL = 61;
		public const int GLFW_KEY_A = 65;
		public const int GLFW_KEY_B = 66;
		public const int GLFW_KEY_C = 67;
		public const int GLFW_KEY_D = 68;
		public const int GLFW_KEY_E = 69;
		public const int GLFW_KEY_F = 70;
		public const int GLFW_KEY_G = 71;
		public const int GLFW_KEY_H = 72;
		public const int GLFW_KEY_I = 73;
		public const int GLFW_KEY_J = 74;
		public const int GLFW_KEY_K = 75;
		public const int GLFW_KEY_L = 76;
		public const int GLFW_KEY_M = 77;
		public const int GLFW_KEY_N = 78;
		public const int GLFW_KEY_O = 79;
		public const int GLFW_KEY_P = 80;
		public const int GLFW_KEY_Q = 81;
		public const int GLFW_KEY_R = 82;
		public const int GLFW_KEY_S = 83;
		public const int GLFW_KEY_T = 84;
		public const int GLFW_KEY_U = 85;
		public const int GLFW_KEY_V = 86;
		public const int GLFW_KEY_W = 87;
		public const int GLFW_KEY_X = 88;
		public const int GLFW_KEY_Y = 89;
		public const int GLFW_KEY_Z = 90;
		public const int GLFW_KEY_LEFT_BRACKET = 91;
		public const int GLFW_KEY_BACKSLASH = 92;
		public const int GLFW_KEY_RIGHT_BRACKET = 93;
		public const int GLFW_KEY_GRAVE_ACCENT = 96;
		public const int GLFW_KEY_WORLD_1 = 161;
		public const int GLFW_KEY_WORLD_2 = 162;
		public const int GLFW_KEY_ESCAPE = 256;
		public const int GLFW_KEY_ENTER = 257;
		public const int GLFW_KEY_TAB = 258;
		public const int GLFW_KEY_BACKSPACE = 259;
		public const int GLFW_KEY_INSERT = 260;
		public const int GLFW_KEY_DELETE = 261;
		public const int GLFW_KEY_RIGHT = 262;
		public const int GLFW_KEY_LEFT = 263;
		public const int GLFW_KEY_DOWN = 264;
		public const int GLFW_KEY_UP = 265;
		public const int GLFW_KEY_PAGE_UP = 266;
		public const int GLFW_KEY_PAGE_DOWN = 267;
		public const int GLFW_KEY_HOME = 268;
		public const int GLFW_KEY_END = 269;
		public const int GLFW_KEY_CAPS_LOCK = 280;
		public const int GLFW_KEY_SCROLL_LOCK = 281;
		public const int GLFW_KEY_NUM_LOCK = 282;
		public const int GLFW_KEY_PRINT_SCREEN = 283;
		public const int GLFW_KEY_PAUSE = 284;
		public const int GLFW_KEY_F1 = 290;
		public const int GLFW_KEY_F2 = 291;
		public const int GLFW_KEY_F3 = 292;
		public const int GLFW_KEY_F4 = 293;
		public const int GLFW_KEY_F5 = 294;
		public const int GLFW_KEY_F6 = 295;
		public const int GLFW_KEY_F7 = 296;
		public const int GLFW_KEY_F8 = 297;
		public const int GLFW_KEY_F9 = 298;
		public const int GLFW_KEY_F10 = 299;
		public const int GLFW_KEY_F11 = 300;
		public const int GLFW_KEY_F12 = 301;
		public const int GLFW_KEY_F13 = 302;
		public const int GLFW_KEY_F14 = 303;
		public const int GLFW_KEY_F15 = 304;
		public const int GLFW_KEY_F16 = 305;
		public const int GLFW_KEY_F17 = 306;
		public const int GLFW_KEY_F18 = 307;
		public const int GLFW_KEY_F19 = 308;
		public const int GLFW_KEY_F20 = 309;
		public const int GLFW_KEY_F21 = 310;
		public const int GLFW_KEY_F22 = 311;
		public const int GLFW_KEY_F23 = 312;
		public const int GLFW_KEY_F24 = 313;
		public const int GLFW_KEY_F25 = 314;
		public const int GLFW_KEY_KP_0 = 320;
		public const int GLFW_KEY_KP_1 = 321;
		public const int GLFW_KEY_KP_2 = 322;
		public const int GLFW_KEY_KP_3 = 323;
		public const int GLFW_KEY_KP_4 = 324;
		public const int GLFW_KEY_KP_5 = 325;
		public const int GLFW_KEY_KP_6 = 326;
		public const int GLFW_KEY_KP_7 = 327;
		public const int GLFW_KEY_KP_8 = 328;
		public const int GLFW_KEY_KP_9 = 329;
		public const int GLFW_KEY_KP_DECIMAL = 330;
		public const int GLFW_KEY_KP_DIVIDE = 331;
		public const int GLFW_KEY_KP_MULTIPLY = 332;
		public const int GLFW_KEY_KP_SUBTRACT = 333;
		public const int GLFW_KEY_KP_ADD = 334;
		public const int GLFW_KEY_KP_ENTER = 335;
		public const int GLFW_KEY_KP_EQUAL = 336;
		public const int GLFW_KEY_LEFT_SHIFT = 340;
		public const int GLFW_KEY_LEFT_CONTROL = 341;
		public const int GLFW_KEY_LEFT_ALT = 342;
		public const int GLFW_KEY_LEFT_SUPER = 343;
		public const int GLFW_KEY_RIGHT_SHIFT = 344;
		public const int GLFW_KEY_RIGHT_CONTROL = 345;
		public const int GLFW_KEY_RIGHT_ALT = 346;
		public const int GLFW_KEY_RIGHT_SUPER = 347;
		public const int GLFW_KEY_MENU = 348;
		public const int GLFW_KEY_LAST = GLFW_KEY_MENU;
		public const int GLFW_MOD_SHIFT = 0x0001;
		public const int GLFW_MOD_CONTROL = 0x0002;
		public const int GLFW_MOD_ALT = 0x0004;
		public const int GLFW_MOD_SUPER = 0x0008;
		public const int GLFW_MOD_CAPS_LOCK = 0x0010;
		public const int GLFW_MOD_NUM_LOCK = 0x0020;
		public const int GLFW_MOUSE_BUTTON_1 = 0;
		public const int GLFW_MOUSE_BUTTON_2 = 1;
		public const int GLFW_MOUSE_BUTTON_3 = 2;
		public const int GLFW_MOUSE_BUTTON_4 = 3;
		public const int GLFW_MOUSE_BUTTON_5 = 4;
		public const int GLFW_MOUSE_BUTTON_6 = 5;
		public const int GLFW_MOUSE_BUTTON_7 = 6;
		public const int GLFW_MOUSE_BUTTON_8 = 7;
		public const int GLFW_MOUSE_BUTTON_LAST = GLFW_MOUSE_BUTTON_8;
		public const int GLFW_MOUSE_BUTTON_LEFT = GLFW_MOUSE_BUTTON_1;
		public const int GLFW_MOUSE_BUTTON_RIGHT = GLFW_MOUSE_BUTTON_2;
		public const int GLFW_MOUSE_BUTTON_MIDDLE = GLFW_MOUSE_BUTTON_3;
		public const int GLFW_JOYSTICK_1 = 0;
		public const int GLFW_JOYSTICK_2 = 1;
		public const int GLFW_JOYSTICK_3 = 2;
		public const int GLFW_JOYSTICK_4 = 3;
		public const int GLFW_JOYSTICK_5 = 4;
		public const int GLFW_JOYSTICK_6 = 5;
		public const int GLFW_JOYSTICK_7 = 6;
		public const int GLFW_JOYSTICK_8 = 7;
		public const int GLFW_JOYSTICK_9 = 8;
		public const int GLFW_JOYSTICK_10 = 9;
		public const int GLFW_JOYSTICK_11 = 10;
		public const int GLFW_JOYSTICK_12 = 11;
		public const int GLFW_JOYSTICK_13 = 12;
		public const int GLFW_JOYSTICK_14 = 13;
		public const int GLFW_JOYSTICK_15 = 14;
		public const int GLFW_JOYSTICK_16 = 15;
		public const int GLFW_JOYSTICK_LAST = GLFW_JOYSTICK_16;
		public const int GLFW_GAMEPAD_BUTTON_A = 0;
		public const int GLFW_GAMEPAD_BUTTON_B = 1;
		public const int GLFW_GAMEPAD_BUTTON_X = 2;
		public const int GLFW_GAMEPAD_BUTTON_Y = 3;
		public const int GLFW_GAMEPAD_BUTTON_LEFT_BUMPER = 4;
		public const int GLFW_GAMEPAD_BUTTON_RIGHT_BUMPER = 5;
		public const int GLFW_GAMEPAD_BUTTON_BACK = 6;
		public const int GLFW_GAMEPAD_BUTTON_START = 7;
		public const int GLFW_GAMEPAD_BUTTON_GUIDE = 8;
		public const int GLFW_GAMEPAD_BUTTON_LEFT_THUMB = 9;
		public const int GLFW_GAMEPAD_BUTTON_RIGHT_THUMB = 10;
		public const int GLFW_GAMEPAD_BUTTON_DPAD_UP = 11;
		public const int GLFW_GAMEPAD_BUTTON_DPAD_RIGHT = 12;
		public const int GLFW_GAMEPAD_BUTTON_DPAD_DOWN = 13;
		public const int GLFW_GAMEPAD_BUTTON_DPAD_LEFT = 14;
		public const int GLFW_GAMEPAD_BUTTON_LAST = GLFW_GAMEPAD_BUTTON_DPAD_LEFT;
		public const int GLFW_GAMEPAD_BUTTON_CROSS = GLFW_GAMEPAD_BUTTON_A;
		public const int GLFW_GAMEPAD_BUTTON_CIRCLE = GLFW_GAMEPAD_BUTTON_B;
		public const int GLFW_GAMEPAD_BUTTON_SQUARE = GLFW_GAMEPAD_BUTTON_X;
		public const int GLFW_GAMEPAD_BUTTON_TRIANGLE = GLFW_GAMEPAD_BUTTON_Y;
		public const int GLFW_GAMEPAD_AXIS_LEFT_X = 0;
		public const int GLFW_GAMEPAD_AXIS_LEFT_Y = 1;
		public const int GLFW_GAMEPAD_AXIS_RIGHT_X = 2;
		public const int GLFW_GAMEPAD_AXIS_RIGHT_Y = 3;
		public const int GLFW_GAMEPAD_AXIS_LEFT_TRIGGER = 4;
		public const int GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER = 5;
		public const int GLFW_GAMEPAD_AXIS_LAST = GLFW_GAMEPAD_AXIS_RIGHT_TRIGGER;
		public const int GLFW_NO_ERROR = 0;
		public const int GLFW_NOT_INITIALIZED = 0x00010001;
		public const int GLFW_NO_CURRENT_CONTEXT = 0x00010002;
		public const int GLFW_INVALID_ENUM = 0x00010003;
		public const int GLFW_INVALID_VALUE = 0x00010004;
		public const int GLFW_OUT_OF_MEMORY = 0x00010005;
		public const int GLFW_API_UNAVAILABLE = 0x00010006;
		public const int GLFW_VERSION_UNAVAILABLE = 0x00010007;
		public const int GLFW_PLATFORM_ERROR = 0x00010008;
		public const int GLFW_FORMAT_UNAVAILABLE = 0x00010009;
		public const int GLFW_NO_WINDOW_CONTEXT = 0x0001000A;
		public const int GLFW_FOCUSED = 0x00020001;
		public const int GLFW_ICONIFIED = 0x00020002;
		public const int GLFW_RESIZABLE = 0x00020003;
		public const int GLFW_VISIBLE = 0x00020004;
		public const int GLFW_DECORATED = 0x00020005;
		public const int GLFW_AUTO_ICONIFY = 0x00020006;
		public const int GLFW_FLOATING = 0x00020007;
		public const int GLFW_MAXIMIZED = 0x00020008;
		public const int GLFW_CENTER_CURSOR = 0x00020009;
		public const int GLFW_TRANSPARENT_FRAMEBUFFER = 0x0002000A;
		public const int GLFW_HOVERED = 0x0002000B;
		public const int GLFW_FOCUS_ON_SHOW = 0x0002000C;
		public const int GLFW_RED_BITS = 0x00021001;
		public const int GLFW_GREEN_BITS = 0x00021002;
		public const int GLFW_BLUE_BITS = 0x00021003;
		public const int GLFW_ALPHA_BITS = 0x00021004;
		public const int GLFW_DEPTH_BITS = 0x00021005;
		public const int GLFW_STENCIL_BITS = 0x00021006;
		public const int GLFW_ACCUM_RED_BITS = 0x00021007;
		public const int GLFW_ACCUM_GREEN_BITS = 0x00021008;
		public const int GLFW_ACCUM_BLUE_BITS = 0x00021009;
		public const int GLFW_ACCUM_ALPHA_BITS = 0x0002100A;
		public const int GLFW_AUX_BUFFERS = 0x0002100B;
		public const int GLFW_STEREO = 0x0002100C;
		public const int GLFW_SAMPLES = 0x0002100D;
		public const int GLFW_SRGB_CAPABLE = 0x0002100E;
		public const int GLFW_REFRESH_RATE = 0x0002100F;
		public const int GLFW_DOUBLEBUFFER = 0x00021010;
		public const int GLFW_CLIENT_API = 0x00022001;
		public const int GLFW_CONTEXT_VERSION_MAJOR = 0x00022002;
		public const int GLFW_CONTEXT_VERSION_MINOR = 0x00022003;
		public const int GLFW_CONTEXT_REVISION = 0x00022004;
		public const int GLFW_CONTEXT_ROBUSTNESS = 0x00022005;
		public const int GLFW_OPENGL_FORWARD_COMPAT = 0x00022006;
		public const int GLFW_OPENGL_DEBUG_CONTEXT = 0x00022007;
		public const int GLFW_OPENGL_PROFILE = 0x00022008;
		public const int GLFW_CONTEXT_RELEASE_BEHAVIOR = 0x00022009;
		public const int GLFW_CONTEXT_NO_ERROR = 0x0002200A;
		public const int GLFW_CONTEXT_CREATION_API = 0x0002200B;
		public const int GLFW_SCALE_TO_MONITOR = 0x0002200C;
		public const int GLFW_COCOA_RETINA_FRAMEBUFFER = 0x00023001;
		public const int GLFW_COCOA_FRAME_NAME = 0x00023002;
		public const int GLFW_COCOA_GRAPHICS_SWITCHING = 0x00023003;
		public const int GLFW_X11_CLASS_NAME = 0x00024001;
		public const int GLFW_X11_INSTANCE_NAME = 0x00024002;
		public const int GLFW_NO_API = 0;
		public const int GLFW_OPENGL_API = 0x00030001;
		public const int GLFW_OPENGL_ES_API = 0x00030002;
		public const int GLFW_NO_ROBUSTNESS = 0;
		public const int GLFW_NO_RESET_NOTIFICATION = 0x00031001;
		public const int GLFW_LOSE_CONTEXT_ON_RESET = 0x00031002;
		public const int GLFW_OPENGL_ANY_PROFILE = 0;
		public const int GLFW_OPENGL_CORE_PROFILE = 0x00032001;
		public const int GLFW_OPENGL_COMPAT_PROFILE = 0x00032002;
		public const int GLFW_CURSOR = 0x00033001;
		public const int GLFW_STICKY_KEYS = 0x00033002;
		public const int GLFW_STICKY_MOUSE_BUTTONS = 0x00033003;
		public const int GLFW_LOCK_KEY_MODS = 0x00033004;
		public const int GLFW_RAW_MOUSE_MOTION = 0x00033005;
		public const int GLFW_CURSOR_NORMAL = 0x00034001;
		public const int GLFW_CURSOR_HIDDEN = 0x00034002;
		public const int GLFW_CURSOR_DISABLED = 0x00034003;
		public const int GLFW_ANY_RELEASE_BEHAVIOR = 0;
		public const int GLFW_RELEASE_BEHAVIOR_FLUSH = 0x00035001;
		public const int GLFW_RELEASE_BEHAVIOR_NONE = 0x00035002;
		public const int GLFW_NATIVE_CONTEXT_API = 0x00036001;
		public const int GLFW_EGL_CONTEXT_API = 0x00036002;
		public const int GLFW_OSMESA_CONTEXT_API = 0x00036003;
		public const int GLFW_ARROW_CURSOR = 0x00036001;
		public const int GLFW_IBEAM_CURSOR = 0x00036002;
		public const int GLFW_CROSSHAIR_CURSOR = 0x00036003;
		public const int GLFW_HAND_CURSOR = 0x00036004;
		public const int GLFW_HRESIZE_CURSOR = 0x00036005;
		public const int GLFW_VRESIZE_CURSOR = 0x00036006;
		public const int GLFW_CONNECTED = 0x00040001;
		public const int GLFW_DISCONNECTED = 0x00040002;
		public const int GLFW_JOYSTICK_HAT_BUTTONS = 0x00050001;
		public const int GLFW_COCOA_CHDIR_RESOURCES = 0x00051001;
		public const int GLFW_COCOA_MENUBAR = 0x00051002;
		public const int GLFW_DONT_CARE = -1;
		#endregion

		#region Structures
		public struct GLFWvidmode
		{
			public int width;
			public int height;
			public int redBits;
			public int greenBits;
			public int blueBits;
			public int refreshRate;
		}

		public struct GLFWgammaramp
		{
			public ushort* red;
			public ushort* green;
			public ushort* blue;

			public uint size;
		}

		public struct GLFWimage
		{
			public int width;
			public int height;

			public byte* pixels;
		}

		public struct GLFWgamepadstate
		{
			public fixed byte buttons[ 15 ];
			public fixed float axes[ 6 ];
		}
		#endregion

		#region Delegates
		public delegate void GLFWerrorfun( int error, byte* description );
		public delegate void GLFWwindowposfun( void* window, int xpos, int ypos );
		public delegate void GLFWwindowsizefun( void* window, int width, int height );
		public delegate void GLFWwindowclosefun( void* window );
		public delegate void GLFWwindowrefreshfun( void* window );
		public delegate void GLFWwindowfocusfun( void* window, int focused );
		public delegate void GLFWwindowiconifyfun( void* window, int iconified );
		public delegate void GLFWwindowmaximizefun( void* window, int maximized );
		public delegate void GLFWframebuffersizefun( void* window, int width, int height );
		public delegate void GLFWwindowcontentscalefun( void* window, float xscale, float yscale );
		public delegate void GLFWmousebuttonfun( void* window, int button, int action, int mods );
		public delegate void GLFWcursorposfun( void* window, double xpos, double ypos );
		public delegate void GLFWcursorenterfun( void* window, int entered );
		public delegate void GLFWscrollfun( void* window, double xoffset, double yoffset );
		public delegate void GLFWkeyfun( void* window, int key, int scancode, int action, int mods );
		public delegate void GLFWcharfun( void* window, uint codepoint );
		public delegate void GLFWcharmodsfun( void* window, uint codepoint, int mods );
		public delegate void GLFWdropfun( void* window, int path_count, byte** paths );
		public delegate void GLFWmonitorfun( void* monitor, int @event );
		public delegate void GLFWjoystickfun( int jid, int @event );

		public delegate int PFNGLFWINITPROC();
		public delegate void PFNGLFWTERMINATEPROC();
		public delegate void PFNGLFWINITHINTPROC( int hint, int value );
		public delegate void PFNGLFWGETVERSIONPROC( int* major, int* minor, int* rev );
		public delegate byte* PFNGLFWGETVERSIONSTRINGPROC();
		public delegate int PFNGLFWGETERRORPROC( byte* description );
		public delegate GLFWerrorfun PFNGLFWSETERRORCALLBACKPROC( GLFWerrorfun callback );
		public delegate void** PFNGLFWGETMONITORSPROC( int* count );
		public delegate void* PFNGLFWGETPRIMARYMONITORPROC();
		public delegate void PFNGLFWGETMONITORPOSPROC( void* monitor, int* xpos, int* ypos );
		public delegate void PFNGLFWGETMONITORWORKAREAPROC( void* monitor, int* xpos, int* ypos, int* width, int* height );
		public delegate void PFNGLFWGETMONITORPHYSICALSIZEPROC( void* monitor, int* widthMM, int* heightMM );
		public delegate void PFNGLFWGETMONITORCONTENTSCALEPROC( void* monitor, float* xscale, float* yscale );
		public delegate byte* PFNGLFWGETMONITORNAMEPROC( void* monitor );
		public delegate void PFNGLFWSETMONITORUSERPOINTERPROC( void* monitor, void* pointer );
		public delegate void* PFNGLFWGETMONITORUSERPOINTERPROC( void* monitor );
		public delegate GLFWmonitorfun PFNGLFWSETMONITORCALLBACKPROC( GLFWmonitorfun callback );
		public delegate GLFWvidmode* PFNGLFWGETVIDEOMODESPROC( void* monitor, int* count );
		public delegate GLFWvidmode* PFNGLFWGETVIDEOMODEPROC( void* monitor );
		public delegate void PFNGLFWSETGAMMAPROC( void* monitor, float gamma );
		public delegate GLFWgammaramp* PFNGLFWGETGAMMARAMPPROC( void* monitor );
		public delegate void PFNGLFWSETGAMMARAMPPROC( void* monitor, GLFWgammaramp* ramp );
		public delegate void PFNGLFWDEFAULTWINDOWHINTSPROC();
		public delegate void PFNGLFWWINDOWHINTPROC( int hint, int value );
		public delegate void PFNGLFWWINDOWHINTSTRINGPROC( int hint, byte* value );
		public delegate void* PFNGLFWCREATEWINDOWPROC( int width, int height, byte* title, void* monitor, void* share );
		public delegate void PFNGLFWDESTROYWINDOWPROC( void* window );
		public delegate int PFNGLFWWINDOWSHOULDCLOSEPROC( void* window );
		public delegate void PFNGLFWSETWINDOWSHOULDCLOSEPROC( void* window, int value );
		public delegate void PFNGLFWSETWINDOWTITLEPROC( void* window, byte* title );
		public delegate void PFNGLFWSETWINDOWICONPROC( void* window, int count, GLFWimage* images );
		public delegate void PFNGLFWGETWINDOWPOSPROC( void* window, int* xpos, int* ypos );
		public delegate void PFNGLFWSETWINDOWPOSPROC( void* window, int xpos, int ypos );
		public delegate void PFNGLFWGETWINDOWSIZEPROC( void* window, int* width, int* height );
		public delegate void PFNGLFWSETWINDOWSIZELIMITSPROC( void* window, int minwidth, int minheight, int maxwidth, int maxheight );
		public delegate void PFNGLFWSETWINDOWASPECTRATIOPROC( void* window, int numer, int denom );
		public delegate void PFNGLFWSETWINDOWSIZEPROC( void* window, int width, int height );
		public delegate void PFNGLFWGETFRAMEBUFFERSIZEPROC( void* window, int* width, int* height );
		public delegate void PFNGLFWGETWINDOWFRAMESIZEPROC( void* window, int* left, int* top, int* right, int* bottom );
		public delegate void PFNGLFWGETWINDOWCONTENTSCALEPROC( void* window, float* xscale, float* yscale );
		public delegate float PFNGLFWGETWINDOWOPACITYPROC( void* window );
		public delegate void PFNGLFWSETWINDOWOPACITYPROC( void* window, float opacity );
		public delegate void PFNGLFWICONIFYWINDOWPROC( void* window );
		public delegate void PFNGLFWRESTOREWINDOWPROC( void* window );
		public delegate void PFNGLFWMAXIMIZEWINDOWPROC( void* window );
		public delegate void PFNGLFWSHOWWINDOWPROC( void* window );
		public delegate void PFNGLFWHIDEWINDOWPROC( void* window );
		public delegate void PFNGLFWFOCUSWINDOWPROC( void* window );
		public delegate void PFNGLFWREQUESTWINDOWATTENTIONPROC( void* window );
		public delegate void* PFNGLFWGETWINDOWMONITORPROC( void* window );
		public delegate void PFNGLFWSETWINDOWMONITORPROC( void* window, void* monitor, int xpos, int ypos, int width, int height, int refreshRate );
		public delegate int PFNGLFWGETWINDOWATTRIBPROC( void* window, int attrib );
		public delegate void PFNGLFWSETWINDOWATTRIBPROC( void* window, int attrib, int value );
		public delegate void PFNGLFWSETWINDOWUSERPOINTERPROC( void* window, void* pointer );
		public delegate void* PFNGLFWGETWINDOWUSERPOINTERPROC( void* window );
		public delegate GLFWwindowposfun PFNGLFWSETWINDOWPOSCALLBACKPROC( void* window, GLFWwindowposfun callback );
		public delegate GLFWwindowsizefun PFNGLFWSETWINDOWSIZECALLBACKPROC( void* window, GLFWwindowsizefun callback );
		public delegate GLFWwindowclosefun PFNGLFWSETWINDOWCLOSECALLBACKPROC( void* window, GLFWwindowclosefun callback );
		public delegate GLFWwindowrefreshfun PFNGLFWSETWINDOWREFRESHCALLBACKPROC( void* window, GLFWwindowrefreshfun callback );
		public delegate GLFWwindowfocusfun PFNGLFWSETWINDOWFOCUSCALLBACKPROC( void* window, GLFWwindowfocusfun callback );
		public delegate GLFWwindowiconifyfun PFNGLFWSETWINDOWICONIFYCALLBACKPROC( void* window, GLFWwindowiconifyfun callback );
		public delegate GLFWwindowmaximizefun PFNGLFWSETWINDOWMAXIMIZECALLBACKPROC( void* window, GLFWwindowmaximizefun callback );
		public delegate GLFWframebuffersizefun PFNGLFWSETFRAMEBUFFERSIZECALLBACKPROC( void* window, GLFWframebuffersizefun callback );
		public delegate GLFWwindowcontentscalefun PFNGLFWSETWINDOWCONTENTSCALECALLBACKPROC( void* window, GLFWwindowcontentscalefun callback );
		public delegate void PFNGLFWPOLLEVENTSPROC();
		public delegate void PFNGLFWWAITEVENTSPROC();
		public delegate void PFNGLFWWAITEVENTSTIMEOUTPROC( double timeout );
		public delegate void PFNGLFWPOSTEMPTYEVENTPROC();
		public delegate int PFNGLFWGETINPUTMODEPROC( void* window, int mode );
		public delegate void PFNGLFWSETINPUTMODEPROC( void* window, int mode, int value );
		public delegate int PFNGLFWRAWMOUSEMOTIONSUPPORTEDPROC();
		public delegate byte* PFNGLFWGETKEYNAMEPROC( int key, int scancode );
		public delegate int PFNGLFWGETKEYSCANCODEPROC( int key );
		public delegate int PFNGLFWGETKEYPROC( void* window, int key );
		public delegate int PFNGLFWGETMOUSEBUTTONPROC( void* window, int button );
		public delegate void PFNGLFWGETCURSORPOSPROC( void* window, double* xpos, double* ypos );
		public delegate void PFNGLFWSETCURSORPOSPROC( void* window, double xpos, double ypos );
		public delegate void* PFNGLFWCREATECURSORPROC( GLFWimage* image, int xhot, int yhot );
		public delegate void* PFNGLFWCREATESTANDARDCURSORPROC( int shape );
		public delegate void PFNGLFWDESTROYCURSORPROC( void* cursor );
		public delegate void PFNGLFWSETCURSORPROC( void* window, void* cursor );
		public delegate GLFWkeyfun PFNGLFWSETKEYCALLBACKPROC( void* window, GLFWkeyfun callback );
		public delegate GLFWcharfun PFNGLFWSETCHARCALLBACKPROC( void* window, GLFWcharfun callback );
		public delegate GLFWcharmodsfun PFNGLFWSETCHARMODSCALLBACKPROC( void* window, GLFWcharmodsfun callback );
		public delegate GLFWmousebuttonfun PFNGLFWSETMOUSEBUTTONCALLBACKPROC( void* window, GLFWmousebuttonfun callback );
		public delegate GLFWcursorposfun PFNGLFWSETCURSORPOSCALLBACKPROC( void* window, GLFWcursorposfun callback );
		public delegate GLFWcursorenterfun PFNGLFWSETCURSORENTERCALLBACKPROC( void* window, GLFWcursorenterfun callback );
		public delegate GLFWscrollfun PFNGLFWSETSCROLLCALLBACKPROC( void* window, GLFWscrollfun callback );
		public delegate GLFWdropfun PFNGLFWSETDROPCALLBACKPROC( void* window, GLFWdropfun callback );
		public delegate int PFNGLFWJOYSTICKPRESENTPROC( int jid );
		public delegate float* PFNGLFWGETJOYSTICKAXESPROC( int jid, int* count );
		public delegate byte PFNGLFWGETJOYSTICKBUTTONSPROC( int jid, int* count );
		public delegate byte PFNGLFWGETJOYSTICKHATSPROC( int jid, int* count );
		public delegate byte* PFNGLFWGETJOYSTICKNAMEPROC( int jid );
		public delegate byte* PFNGLFWGETJOYSTICKGUIDPROC( int jid );
		public delegate void PFNGLFWSETJOYSTICKUSERPOINTERPROC( int jid, void* pointer );
		public delegate void* PFNGLFWGETJOYSTICKUSERPOINTERPROC( int jid );
		public delegate int PFNGLFWJOYSTICKISGAMEPADPROC( int jid );
		public delegate GLFWjoystickfun PFNGLFWSETJOYSTICKCALLBACKPROC( GLFWjoystickfun callback );
		public delegate int PFNGLFWUPDATEGAMEPADMAPPINGSPROC( byte* @string );
		public delegate byte* PFNGLFWGETGAMEPADNAMEPROC( int jid );
		public delegate int PFNGLFWGETGAMEPADSTATEPROC( int jid, GLFWgamepadstate* state );
		public delegate void PFNGLFWSETCLIPBOARDSTRINGPROC( void* window, byte* @string );
		public delegate byte* PFNGLFWGETCLIPBOARDSTRINGPROC( void* window );
		public delegate double PFNGLFWGETTIMEPROC();
		public delegate void PFNGLFWSETTIMEPROC( double time );
		public delegate ulong PFNGLFWGETTIMERVALUEPROC();
		public delegate ulong PFNGLFWGETTIMERFREQUENCYPROC();
		public delegate void PFNGLFWMAKECONTEXTCURRENTPROC( void* window );
		public delegate void* PFNGLFWGETCURRENTCONTEXTPROC();
		public delegate void PFNGLFWSWAPBUFFERSPROC( void* window );
		public delegate void PFNGLFWSWAPINTERVALPROC( int interval );
		public delegate int PFNGLFWEXTENSIONSUPPORTEDPROC( byte* extension );
		public delegate int* PFNGLFWGETPROCADDRESSPROC( byte* procname );
		public delegate int PFNGLFWVULKANSUPPORTEDPROC();
		public delegate byte* PFNGLFWGETREQUIREDINSTANCEEXTENSIONSPROC( uint* count );
		#endregion

		#region Constructors
		static GLFW3()
		{
			_handle = LibraryLoader.Load( typeof( GLFW3 ) );
			glfwInit();
		}
		#endregion

		#region Methods
		[ExternalMethod]
		public static PFNGLFWINITPROC glfwInit;
		[ExternalMethod]
		public static PFNGLFWTERMINATEPROC glfwTerminate;
		[ExternalMethod]
		public static PFNGLFWINITHINTPROC glfwInitHint;
		[ExternalMethod]
		public static PFNGLFWGETVERSIONPROC glfwGetVersion;
		[ExternalMethod]
		public static PFNGLFWGETVERSIONSTRINGPROC glfwGetVersionString;
		[ExternalMethod]
		public static PFNGLFWGETERRORPROC glfwGetError;
		[ExternalMethod]
		public static PFNGLFWSETERRORCALLBACKPROC glfwSetErrorCallback;
		[ExternalMethod]
		public static PFNGLFWGETMONITORSPROC glfwGetMonitors;
		[ExternalMethod]
		public static PFNGLFWGETPRIMARYMONITORPROC glfwGetPrimaryMonitor;
		[ExternalMethod]
		public static PFNGLFWGETMONITORPOSPROC glfwGetMonitorPos;
		[ExternalMethod]
		public static PFNGLFWGETMONITORWORKAREAPROC glfwGetMonitorWorkarea;
		[ExternalMethod]
		public static PFNGLFWGETMONITORPHYSICALSIZEPROC glfwGetMonitorPhysicalSize;
		[ExternalMethod]
		public static PFNGLFWGETMONITORCONTENTSCALEPROC glfwGetMonitorContentScale;
		[ExternalMethod]
		public static PFNGLFWGETMONITORNAMEPROC glfwGetMonitorName;
		[ExternalMethod]
		public static PFNGLFWSETMONITORUSERPOINTERPROC glfwSetMonitorUserPointer;
		[ExternalMethod]
		public static PFNGLFWGETMONITORUSERPOINTERPROC glfwGetMonitorUserPointer;
		[ExternalMethod]
		public static PFNGLFWSETMONITORCALLBACKPROC glfwSetMonitorCallback;
		[ExternalMethod]
		public static PFNGLFWGETVIDEOMODESPROC glfwGetVideoModes;
		[ExternalMethod]
		public static PFNGLFWGETVIDEOMODEPROC glfwGetVideoMode;
		[ExternalMethod]
		public static PFNGLFWSETGAMMAPROC glfwSetGamma;
		[ExternalMethod]
		public static PFNGLFWGETGAMMARAMPPROC glfwGetGammaRamp;
		[ExternalMethod]
		public static PFNGLFWSETGAMMARAMPPROC glfwSetGammaRamp;
		[ExternalMethod]
		public static PFNGLFWDEFAULTWINDOWHINTSPROC glfwDefaultWindowHints;
		[ExternalMethod]
		public static PFNGLFWWINDOWHINTPROC glfwWindowHint;
		[ExternalMethod]
		public static PFNGLFWWINDOWHINTSTRINGPROC glfwWindowHintString;
		[ExternalMethod]
		public static PFNGLFWCREATEWINDOWPROC glfwCreateWindow;
		[ExternalMethod]
		public static PFNGLFWDESTROYWINDOWPROC glfwDestroyWindow;
		[ExternalMethod]
		public static PFNGLFWWINDOWSHOULDCLOSEPROC glfwWindowShouldClose;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWSHOULDCLOSEPROC glfwSetWindowShouldClose;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWTITLEPROC glfwSetWindowTitle;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWICONPROC glfwSetWindowIcon;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWPOSPROC glfwGetWindowPos;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWPOSPROC glfwSetWindowPos;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWSIZEPROC glfwGetWindowSize;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWSIZELIMITSPROC glfwSetWindowSizeLimits;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWASPECTRATIOPROC glfwSetWindowAspectRatio;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWSIZEPROC glfwSetWindowSize;
		[ExternalMethod]
		public static PFNGLFWGETFRAMEBUFFERSIZEPROC glfwGetFramebufferSize;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWFRAMESIZEPROC glfwGetWindowFrameSize;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWCONTENTSCALEPROC glfwGetWindowContentScale;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWOPACITYPROC glfwGetWindowOpacity;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWOPACITYPROC glfwSetWindowOpacity;
		[ExternalMethod]
		public static PFNGLFWICONIFYWINDOWPROC glfwIconifyWindow;
		[ExternalMethod]
		public static PFNGLFWRESTOREWINDOWPROC glfwRestoreWindow;
		[ExternalMethod]
		public static PFNGLFWMAXIMIZEWINDOWPROC glfwMaximizeWindow;
		[ExternalMethod]
		public static PFNGLFWSHOWWINDOWPROC glfwShowWindow;
		[ExternalMethod]
		public static PFNGLFWHIDEWINDOWPROC glfwHideWindow;
		[ExternalMethod]
		public static PFNGLFWFOCUSWINDOWPROC glfwFocusWindow;
		[ExternalMethod]
		public static PFNGLFWREQUESTWINDOWATTENTIONPROC glfwRequestWindowAttention;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWMONITORPROC glfwGetWindowMonitor;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWMONITORPROC glfwSetWindowMonitor;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWATTRIBPROC glfwGetWindowAttrib;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWATTRIBPROC glfwSetWindowAttrib;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWUSERPOINTERPROC glfwSetWindowUserPointer;
		[ExternalMethod]
		public static PFNGLFWGETWINDOWUSERPOINTERPROC glfwGetWindowUserPointer;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWPOSCALLBACKPROC glfwSetWindowPosCallback;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWSIZECALLBACKPROC glfwSetWindowSizeCallback;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWCLOSECALLBACKPROC glfwSetWindowCloseCallback;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWREFRESHCALLBACKPROC glfwSetWindowRefreshCallback;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWFOCUSCALLBACKPROC glfwSetWindowFocusCallback;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWICONIFYCALLBACKPROC glfwSetWindowIconifyCallback;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWMAXIMIZECALLBACKPROC glfwSetWindowMaximizeCallback;
		[ExternalMethod]
		public static PFNGLFWSETFRAMEBUFFERSIZECALLBACKPROC glfwSetFramebufferSizeCallback;
		[ExternalMethod]
		public static PFNGLFWSETWINDOWCONTENTSCALECALLBACKPROC glfwSetWindowContentScaleCallback;
		[ExternalMethod]
		public static PFNGLFWPOLLEVENTSPROC glfwPollEvents;
		[ExternalMethod]
		public static PFNGLFWWAITEVENTSPROC glfwWaitEvents;
		[ExternalMethod]
		public static PFNGLFWWAITEVENTSTIMEOUTPROC glfwWaitEventsTimeout;
		[ExternalMethod]
		public static PFNGLFWPOSTEMPTYEVENTPROC glfwPostEmptyEvent;
		[ExternalMethod]
		public static PFNGLFWGETINPUTMODEPROC glfwGetInputMode;
		[ExternalMethod]
		public static PFNGLFWSETINPUTMODEPROC glfwSetInputMode;
		[ExternalMethod]
		public static PFNGLFWRAWMOUSEMOTIONSUPPORTEDPROC glfwRawMouseMotionSupported;
		[ExternalMethod]
		public static PFNGLFWGETKEYNAMEPROC glfwGetKeyName;
		[ExternalMethod]
		public static PFNGLFWGETKEYSCANCODEPROC glfwGetKeyScancode;
		[ExternalMethod]
		public static PFNGLFWGETKEYPROC glfwGetKey;
		[ExternalMethod]
		public static PFNGLFWGETMOUSEBUTTONPROC glfwGetMouseButton;
		[ExternalMethod]
		public static PFNGLFWGETCURSORPOSPROC glfwGetCursorPos;
		[ExternalMethod]
		public static PFNGLFWSETCURSORPOSPROC glfwSetCursorPos;
		[ExternalMethod]
		public static PFNGLFWCREATECURSORPROC glfwCreateCursor;
		[ExternalMethod]
		public static PFNGLFWCREATESTANDARDCURSORPROC glfwCreateStandardCursor;
		[ExternalMethod]
		public static PFNGLFWDESTROYCURSORPROC glfwDestroyCursor;
		[ExternalMethod]
		public static PFNGLFWSETCURSORPROC glfwSetCursor;
		[ExternalMethod]
		public static PFNGLFWSETKEYCALLBACKPROC glfwSetKeyCallback;
		[ExternalMethod]
		public static PFNGLFWSETCHARCALLBACKPROC glfwSetCharCallback;
		[ExternalMethod]
		public static PFNGLFWSETCHARMODSCALLBACKPROC glfwSetCharModsCallback;
		[ExternalMethod]
		public static PFNGLFWSETMOUSEBUTTONCALLBACKPROC glfwSetMouseButtonCallback;
		[ExternalMethod]
		public static PFNGLFWSETCURSORPOSCALLBACKPROC glfwSetCursorPosCallback;
		[ExternalMethod]
		public static PFNGLFWSETCURSORENTERCALLBACKPROC glfwSetCursorEnterCallback;
		[ExternalMethod]
		public static PFNGLFWSETSCROLLCALLBACKPROC glfwSetScrollCallback;
		[ExternalMethod]
		public static PFNGLFWSETDROPCALLBACKPROC glfwSetDropCallback;
		[ExternalMethod]
		public static PFNGLFWJOYSTICKPRESENTPROC glfwJoystickPresent;
		[ExternalMethod]
		public static PFNGLFWGETJOYSTICKAXESPROC glfwGetJoystickAxes;
		[ExternalMethod]
		public static PFNGLFWGETJOYSTICKBUTTONSPROC glfwGetJoystickButtons;
		[ExternalMethod]
		public static PFNGLFWGETJOYSTICKHATSPROC glfwGetJoystickHats;
		[ExternalMethod]
		public static PFNGLFWGETJOYSTICKNAMEPROC glfwGetJoystickName;
		[ExternalMethod]
		public static PFNGLFWGETJOYSTICKGUIDPROC glfwGetJoystickGUID;
		[ExternalMethod]
		public static PFNGLFWSETJOYSTICKUSERPOINTERPROC glfwSetJoystickUserPointer;
		[ExternalMethod]
		public static PFNGLFWGETJOYSTICKUSERPOINTERPROC glfwGetJoystickUserPointer;
		[ExternalMethod]
		public static PFNGLFWJOYSTICKISGAMEPADPROC glfwJoystickIsGamepad;
		[ExternalMethod]
		public static PFNGLFWSETJOYSTICKCALLBACKPROC glfwSetJoystickCallback;
		[ExternalMethod]
		public static PFNGLFWUPDATEGAMEPADMAPPINGSPROC glfwUpdateGamepadMappings;
		[ExternalMethod]
		public static PFNGLFWGETGAMEPADNAMEPROC glfwGetGamepadName;
		[ExternalMethod]
		public static PFNGLFWGETGAMEPADSTATEPROC glfwGetGamepadState;
		[ExternalMethod]
		public static PFNGLFWSETCLIPBOARDSTRINGPROC glfwSetClipboardString;
		[ExternalMethod]
		public static PFNGLFWGETCLIPBOARDSTRINGPROC glfwGetClipboardString;
		[ExternalMethod]
		public static PFNGLFWGETTIMEPROC glfwGetTime;
		[ExternalMethod]
		public static PFNGLFWSETTIMEPROC glfwSetTime;
		[ExternalMethod]
		public static PFNGLFWGETTIMERVALUEPROC glfwGetTimerValue;
		[ExternalMethod]
		public static PFNGLFWGETTIMERFREQUENCYPROC glfwGetTimerFrequency;
		[ExternalMethod]
		public static PFNGLFWMAKECONTEXTCURRENTPROC glfwMakeContextCurrent;
		[ExternalMethod]
		public static PFNGLFWGETCURRENTCONTEXTPROC glfwGetCurrentContext;
		[ExternalMethod]
		public static PFNGLFWSWAPBUFFERSPROC glfwSwapBuffers;
		[ExternalMethod]
		public static PFNGLFWSWAPINTERVALPROC glfwSwapInterval;
		[ExternalMethod]
		public static PFNGLFWEXTENSIONSUPPORTEDPROC glfwExtensionSupported;
		[ExternalMethod]
		public static PFNGLFWGETPROCADDRESSPROC glfwGetProcAddress;
		[ExternalMethod]
		public static PFNGLFWVULKANSUPPORTEDPROC glfwVulkanSupported;
		[ExternalMethod]
		public static PFNGLFWGETREQUIREDINSTANCEEXTENSIONSPROC glfwGetRequiredInstanceExtensions;
		#endregion
	}
}
