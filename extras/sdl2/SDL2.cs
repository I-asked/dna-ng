using System;
using System.Runtime.InteropServices;
using static SDL2.SDL_ArrayOrder;
using static SDL2.SDL_BitmapOrder;
using static SDL2.SDL_PackedLayout;
using static SDL2.SDL_PackedOrder;
using static SDL2.SDL_PixelType;
using static SDL2.SDL_Scancode;
using static SDL2.SDL_bool;

namespace SDL2
{

    public enum SDL_bool : uint
    {
        SDL_FALSE = 0,
        SDL_TRUE = 1,
    }


    public enum SDL_DUMMY_ENUM : uint
    {
        DUMMY_ENUM_VALUE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* SDL_malloc_func(UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* SDL_calloc_func(UIntPtr nmemb, UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void* SDL_realloc_func(void* mem, UIntPtr size);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_free_func(void* mem);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_CompareCallback(void* param0, void* param1);

    public partial struct _SDL_iconv_t
    {
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_main_func(int argc, string* argv);


    public enum SDL_AssertState : uint
    {
        SDL_ASSERTION_RETRY,
        SDL_ASSERTION_BREAK,
        SDL_ASSERTION_ABORT,
        SDL_ASSERTION_IGNORE,
        SDL_ASSERTION_ALWAYS_IGNORE,
    }

    public unsafe partial struct SDL_AssertData
    {
        public int always_ignore;


        public uint trigger_count;


        public string condition;


        public string filename;

        public int linenum;


        public string function;


        public SDL_AssertData* next;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_AssertState SDL_AssertionHandler(SDL_AssertData* data, void* userdata);


    public enum SDL_errorcode : uint
    {
        SDL_ENOMEM,
        SDL_EFREAD,
        SDL_EFWRITE,
        SDL_EFSEEK,
        SDL_UNSUPPORTED,
        SDL_LASTERROR,
    }

    public partial struct SDL_mutex
    {
    }

    public partial struct SDL_semaphore
    {
    }

    public partial struct SDL_cond
    {
    }

    public partial struct SDL_Thread
    {
    }


    public enum SDL_ThreadPriority : uint
    {
        SDL_THREAD_PRIORITY_LOW,
        SDL_THREAD_PRIORITY_NORMAL,
        SDL_THREAD_PRIORITY_HIGH,
        SDL_THREAD_PRIORITY_TIME_CRITICAL,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_ThreadFunction(void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_TLSDestructorCallback(void* param0);

    public unsafe partial struct SDL_RWops
    {

        public IntPtr size;


        public IntPtr seek;


        public IntPtr read;


        public IntPtr write;


        public IntPtr close;


        public uint type;


        public _hidden_e__Union hidden;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _hidden_e__Union
        {
            [FieldOffset(0)]

            public _stdio_e__Struct stdio;

            [FieldOffset(0)]

            public _mem_e__Struct mem;

            [FieldOffset(0)]

            public _unknown_e__Struct unknown;

            public unsafe partial struct _stdio_e__Struct
            {
                public SDL_bool autoclose;

                public void* fp;
            }

            public unsafe partial struct _mem_e__Struct
            {

                public byte* @base;


                public byte* here;


                public byte* stop;
            }

            public unsafe partial struct _unknown_e__Struct
            {
                public void* data1;

                public void* data2;
            }
        }
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_AudioCallback(void* userdata, byte* stream, int len);

    public unsafe partial struct SDL_AudioSpec
    {
        public int freq;


        public ushort format;


        public byte channels;


        public byte silence;


        public ushort samples;


        public ushort padding;


        public uint size;


        public IntPtr callback;

        public void* userdata;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_AudioFilter(SDL_AudioCVT* cvt, ushort format);

    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    public unsafe partial struct SDL_AudioCVT
    {
        public int needed;


        public ushort src_format;


        public ushort dst_format;

        public double rate_incr;


        public byte* buf;

        public int len;

        public int len_cvt;

        public int len_mult;

        public double len_ratio;


        public _filters_e__FixedBuffer filters;

        public int filter_index;

        [StructLayout(LayoutKind.Sequential, Pack = 1)]
        public partial struct _filters_e__FixedBuffer
        {
            public IntPtr e0;
            public IntPtr e1;
            public IntPtr e2;
            public IntPtr e3;
            public IntPtr e4;
            public IntPtr e5;
            public IntPtr e6;
            public IntPtr e7;
            public IntPtr e8;
            public IntPtr e9;

            public unsafe ref IntPtr this[int index]
            {
                get
                {
                    fixed (IntPtr* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }


    public enum SDL_AudioStatus : uint
    {
        SDL_AUDIO_STOPPED = 0,
        SDL_AUDIO_PLAYING,
        SDL_AUDIO_PAUSED,
    }

    public partial struct _SDL_AudioStream
    {
    }


    public enum SDL_PixelType : uint
    {
        SDL_PIXELTYPE_UNKNOWN,
        SDL_PIXELTYPE_INDEX1,
        SDL_PIXELTYPE_INDEX4,
        SDL_PIXELTYPE_INDEX8,
        SDL_PIXELTYPE_PACKED8,
        SDL_PIXELTYPE_PACKED16,
        SDL_PIXELTYPE_PACKED32,
        SDL_PIXELTYPE_ARRAYU8,
        SDL_PIXELTYPE_ARRAYU16,
        SDL_PIXELTYPE_ARRAYU32,
        SDL_PIXELTYPE_ARRAYF16,
        SDL_PIXELTYPE_ARRAYF32,
        SDL_PIXELTYPE_INDEX2,
    }


    public enum SDL_BitmapOrder : uint
    {
        SDL_BITMAPORDER_NONE,
        SDL_BITMAPORDER_4321,
        SDL_BITMAPORDER_1234,
    }


    public enum SDL_PackedOrder : uint
    {
        SDL_PACKEDORDER_NONE,
        SDL_PACKEDORDER_XRGB,
        SDL_PACKEDORDER_RGBX,
        SDL_PACKEDORDER_ARGB,
        SDL_PACKEDORDER_RGBA,
        SDL_PACKEDORDER_XBGR,
        SDL_PACKEDORDER_BGRX,
        SDL_PACKEDORDER_ABGR,
        SDL_PACKEDORDER_BGRA,
    }


    public enum SDL_ArrayOrder : uint
    {
        SDL_ARRAYORDER_NONE,
        SDL_ARRAYORDER_RGB,
        SDL_ARRAYORDER_RGBA,
        SDL_ARRAYORDER_ARGB,
        SDL_ARRAYORDER_BGR,
        SDL_ARRAYORDER_BGRA,
        SDL_ARRAYORDER_ABGR,
    }


    public enum SDL_PackedLayout : uint
    {
        SDL_PACKEDLAYOUT_NONE,
        SDL_PACKEDLAYOUT_332,
        SDL_PACKEDLAYOUT_4444,
        SDL_PACKEDLAYOUT_1555,
        SDL_PACKEDLAYOUT_5551,
        SDL_PACKEDLAYOUT_565,
        SDL_PACKEDLAYOUT_8888,
        SDL_PACKEDLAYOUT_2101010,
        SDL_PACKEDLAYOUT_1010102,
    }


    public enum SDL_PixelFormatEnum : uint
    {
        SDL_PIXELFORMAT_UNKNOWN,
        SDL_PIXELFORMAT_INDEX1LSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX1) << 24) | ((SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((1) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX1MSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX1) << 24) | ((SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((1) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX2LSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX2) << 24) | ((SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((2) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX2MSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX2) << 24) | ((SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((2) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX4LSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX4) << 24) | ((SDL_BITMAPORDER_4321) << 20) | ((0) << 16) | ((4) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX4MSB = ((1 << 28) | ((SDL_PIXELTYPE_INDEX4) << 24) | ((SDL_BITMAPORDER_1234) << 20) | ((0) << 16) | ((4) << 8) | ((0) << 0)),
        SDL_PIXELFORMAT_INDEX8 = ((1 << 28) | ((SDL_PIXELTYPE_INDEX8) << 24) | ((0) << 20) | ((0) << 16) | ((8) << 8) | ((1) << 0)),
        SDL_PIXELFORMAT_RGB332 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED8) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_332) << 16) | ((8) << 8) | ((1) << 0)),
        SDL_PIXELFORMAT_XRGB4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((12) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB444 = SDL_PIXELFORMAT_XRGB4444,
        SDL_PIXELFORMAT_XBGR4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((12) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGR444 = SDL_PIXELFORMAT_XBGR4444,
        SDL_PIXELFORMAT_XRGB1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((15) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB555 = SDL_PIXELFORMAT_XRGB1555,
        SDL_PIXELFORMAT_XBGR1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((15) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGR555 = SDL_PIXELFORMAT_XBGR1555,
        SDL_PIXELFORMAT_ARGB4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGBA4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_RGBA) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_ABGR4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ABGR) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGRA4444 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_BGRA) << 20) | ((SDL_PACKEDLAYOUT_4444) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_ARGB1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGBA5551 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_RGBA) << 20) | ((SDL_PACKEDLAYOUT_5551) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_ABGR1555 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_ABGR) << 20) | ((SDL_PACKEDLAYOUT_1555) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGRA5551 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_BGRA) << 20) | ((SDL_PACKEDLAYOUT_5551) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB565 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_565) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_BGR565 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED16) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_565) << 16) | ((16) << 8) | ((2) << 0)),
        SDL_PIXELFORMAT_RGB24 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU8) << 24) | ((SDL_ARRAYORDER_RGB) << 20) | ((0) << 16) | ((24) << 8) | ((3) << 0)),
        SDL_PIXELFORMAT_BGR24 = ((1 << 28) | ((SDL_PIXELTYPE_ARRAYU8) << 24) | ((SDL_ARRAYORDER_BGR) << 20) | ((0) << 16) | ((24) << 8) | ((3) << 0)),
        SDL_PIXELFORMAT_XRGB8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_XRGB) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_RGB888 = SDL_PIXELFORMAT_XRGB8888,
        SDL_PIXELFORMAT_RGBX8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_RGBX) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_XBGR8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_XBGR) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_BGR888 = SDL_PIXELFORMAT_XBGR8888,
        SDL_PIXELFORMAT_BGRX8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_BGRX) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((24) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_ARGB8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_RGBA8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_RGBA) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_ABGR8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_ABGR) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_BGRA8888 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_BGRA) << 20) | ((SDL_PACKEDLAYOUT_8888) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_ARGB2101010 = ((1 << 28) | ((SDL_PIXELTYPE_PACKED32) << 24) | ((SDL_PACKEDORDER_ARGB) << 20) | ((SDL_PACKEDLAYOUT_2101010) << 16) | ((32) << 8) | ((4) << 0)),
        SDL_PIXELFORMAT_RGBA32 = SDL_PIXELFORMAT_ABGR8888,
        SDL_PIXELFORMAT_ARGB32 = SDL_PIXELFORMAT_BGRA8888,
        SDL_PIXELFORMAT_BGRA32 = SDL_PIXELFORMAT_ARGB8888,
        SDL_PIXELFORMAT_ABGR32 = SDL_PIXELFORMAT_RGBA8888,
        SDL_PIXELFORMAT_RGBX32 = SDL_PIXELFORMAT_XBGR8888,
        SDL_PIXELFORMAT_XRGB32 = SDL_PIXELFORMAT_BGRX8888,
        SDL_PIXELFORMAT_BGRX32 = SDL_PIXELFORMAT_XRGB8888,
        SDL_PIXELFORMAT_XBGR32 = SDL_PIXELFORMAT_RGBX8888,
        SDL_PIXELFORMAT_YV12 = (unchecked((((uint)(((byte)(('Y'))))) << 0) | (((uint)(((byte)(('V'))))) << 8) | (((uint)(((byte)(('1'))))) << 16) | (((uint)(((byte)(('2'))))) << 24))),
        SDL_PIXELFORMAT_IYUV = (unchecked((((uint)(((byte)(('I'))))) << 0) | (((uint)(((byte)(('Y'))))) << 8) | (((uint)(((byte)(('U'))))) << 16) | (((uint)(((byte)(('V'))))) << 24))),
        SDL_PIXELFORMAT_YUY2 = (unchecked((((uint)(((byte)(('Y'))))) << 0) | (((uint)(((byte)(('U'))))) << 8) | (((uint)(((byte)(('Y'))))) << 16) | (((uint)(((byte)(('2'))))) << 24))),
        SDL_PIXELFORMAT_UYVY = (unchecked((((uint)(((byte)(('U'))))) << 0) | (((uint)(((byte)(('Y'))))) << 8) | (((uint)(((byte)(('V'))))) << 16) | (((uint)(((byte)(('Y'))))) << 24))),
        SDL_PIXELFORMAT_YVYU = (unchecked((((uint)(((byte)(('Y'))))) << 0) | (((uint)(((byte)(('V'))))) << 8) | (((uint)(((byte)(('Y'))))) << 16) | (((uint)(((byte)(('U'))))) << 24))),
        SDL_PIXELFORMAT_NV12 = (unchecked((((uint)(((byte)(('N'))))) << 0) | (((uint)(((byte)(('V'))))) << 8) | (((uint)(((byte)(('1'))))) << 16) | (((uint)(((byte)(('2'))))) << 24))),
        SDL_PIXELFORMAT_NV21 = (unchecked((((uint)(((byte)(('N'))))) << 0) | (((uint)(((byte)(('V'))))) << 8) | (((uint)(((byte)(('2'))))) << 16) | (((uint)(((byte)(('1'))))) << 24))),
        SDL_PIXELFORMAT_EXTERNAL_OES = (unchecked((((uint)(((byte)(('O'))))) << 0) | (((uint)(((byte)(('E'))))) << 8) | (((uint)(((byte)(('S'))))) << 16) | (((uint)(((byte)((' '))))) << 24))),
    }

    public partial struct SDL_Color
    {

        public byte r;


        public byte g;


        public byte b;


        public byte a;
    }

    public unsafe partial struct SDL_Palette
    {
        public int ncolors;

        public SDL_Color* colors;


        public uint version;

        public int refcount;
    }

    public unsafe partial struct SDL_PixelFormat
    {

        public uint format;

        public SDL_Palette* palette;


        public byte BitsPerPixel;


        public byte BytesPerPixel;


        public fixed byte padding[2];


        public uint Rmask;


        public uint Gmask;


        public uint Bmask;


        public uint Amask;


        public byte Rloss;


        public byte Gloss;


        public byte Bloss;


        public byte Aloss;


        public byte Rshift;


        public byte Gshift;


        public byte Bshift;


        public byte Ashift;

        public int refcount;


        public SDL_PixelFormat* next;
    }

    public partial struct SDL_Point
    {
        public int x;

        public int y;
    }

    public partial struct SDL_FPoint
    {
        public float x;

        public float y;
    }

    public partial struct SDL_Rect
    {
        public int x;

        public int y;

        public int w;

        public int h;
    }

    public partial struct SDL_FRect
    {
        public float x;

        public float y;

        public float w;

        public float h;
    }


    public enum SDL_BlendMode : uint
    {
        SDL_BLENDMODE_NONE = 0x00000000,
        SDL_BLENDMODE_BLEND = 0x00000001,
        SDL_BLENDMODE_ADD = 0x00000002,
        SDL_BLENDMODE_MOD = 0x00000004,
        SDL_BLENDMODE_MUL = 0x00000008,
        SDL_BLENDMODE_INVALID = 0x7FFFFFFF,
    }


    public enum SDL_BlendOperation : uint
    {
        SDL_BLENDOPERATION_ADD = 0x1,
        SDL_BLENDOPERATION_SUBTRACT = 0x2,
        SDL_BLENDOPERATION_REV_SUBTRACT = 0x3,
        SDL_BLENDOPERATION_MINIMUM = 0x4,
        SDL_BLENDOPERATION_MAXIMUM = 0x5,
    }


    public enum SDL_BlendFactor : uint
    {
        SDL_BLENDFACTOR_ZERO = 0x1,
        SDL_BLENDFACTOR_ONE = 0x2,
        SDL_BLENDFACTOR_SRC_COLOR = 0x3,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_COLOR = 0x4,
        SDL_BLENDFACTOR_SRC_ALPHA = 0x5,
        SDL_BLENDFACTOR_ONE_MINUS_SRC_ALPHA = 0x6,
        SDL_BLENDFACTOR_DST_COLOR = 0x7,
        SDL_BLENDFACTOR_ONE_MINUS_DST_COLOR = 0x8,
        SDL_BLENDFACTOR_DST_ALPHA = 0x9,
        SDL_BLENDFACTOR_ONE_MINUS_DST_ALPHA = 0xA,
    }

    public partial struct SDL_BlitMap
    {
    }

    public unsafe partial struct SDL_Surface
    {

        public uint flags;

        public SDL_PixelFormat* format;

        public int w;

        public int h;

        public int pitch;

        public void* pixels;

        public void* userdata;

        public int locked;

        public void* list_blitmap;

        public SDL_Rect clip_rect;

        public SDL_BlitMap* map;

        public int refcount;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_blit(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);


    public enum SDL_YUV_CONVERSION_MODE : uint
    {
        SDL_YUV_CONVERSION_JPEG,
        SDL_YUV_CONVERSION_BT601,
        SDL_YUV_CONVERSION_BT709,
        SDL_YUV_CONVERSION_AUTOMATIC,
    }

    public unsafe partial struct SDL_DisplayMode
    {

        public uint format;

        public int w;

        public int h;

        public int refresh_rate;

        public void* driverdata;
    }

    public partial struct SDL_Window
    {
    }


    public enum SDL_WindowFlags : uint
    {
        SDL_WINDOW_FULLSCREEN = 0x00000001,
        SDL_WINDOW_OPENGL = 0x00000002,
        SDL_WINDOW_SHOWN = 0x00000004,
        SDL_WINDOW_HIDDEN = 0x00000008,
        SDL_WINDOW_BORDERLESS = 0x00000010,
        SDL_WINDOW_RESIZABLE = 0x00000020,
        SDL_WINDOW_MINIMIZED = 0x00000040,
        SDL_WINDOW_MAXIMIZED = 0x00000080,
        SDL_WINDOW_MOUSE_GRABBED = 0x00000100,
        SDL_WINDOW_INPUT_FOCUS = 0x00000200,
        SDL_WINDOW_MOUSE_FOCUS = 0x00000400,
        SDL_WINDOW_FULLSCREEN_DESKTOP = (SDL_WINDOW_FULLSCREEN | 0x00001000),
        SDL_WINDOW_FOREIGN = 0x00000800,
        SDL_WINDOW_ALLOW_HIGHDPI = 0x00002000,
        SDL_WINDOW_MOUSE_CAPTURE = 0x00004000,
        SDL_WINDOW_ALWAYS_ON_TOP = 0x00008000,
        SDL_WINDOW_SKIP_TASKBAR = 0x00010000,
        SDL_WINDOW_UTILITY = 0x00020000,
        SDL_WINDOW_TOOLTIP = 0x00040000,
        SDL_WINDOW_POPUP_MENU = 0x00080000,
        SDL_WINDOW_KEYBOARD_GRABBED = 0x00100000,
        SDL_WINDOW_VULKAN = 0x10000000,
        SDL_WINDOW_METAL = 0x20000000,
        SDL_WINDOW_INPUT_GRABBED = SDL_WINDOW_MOUSE_GRABBED,
    }


    public enum SDL_WindowEventID : uint
    {
        SDL_WINDOWEVENT_NONE,
        SDL_WINDOWEVENT_SHOWN,
        SDL_WINDOWEVENT_HIDDEN,
        SDL_WINDOWEVENT_EXPOSED,
        SDL_WINDOWEVENT_MOVED,
        SDL_WINDOWEVENT_RESIZED,
        SDL_WINDOWEVENT_SIZE_CHANGED,
        SDL_WINDOWEVENT_MINIMIZED,
        SDL_WINDOWEVENT_MAXIMIZED,
        SDL_WINDOWEVENT_RESTORED,
        SDL_WINDOWEVENT_ENTER,
        SDL_WINDOWEVENT_LEAVE,
        SDL_WINDOWEVENT_FOCUS_GAINED,
        SDL_WINDOWEVENT_FOCUS_LOST,
        SDL_WINDOWEVENT_CLOSE,
        SDL_WINDOWEVENT_TAKE_FOCUS,
        SDL_WINDOWEVENT_HIT_TEST,
        SDL_WINDOWEVENT_ICCPROF_CHANGED,
        SDL_WINDOWEVENT_DISPLAY_CHANGED,
    }


    public enum SDL_DisplayEventID : uint
    {
        SDL_DISPLAYEVENT_NONE,
        SDL_DISPLAYEVENT_ORIENTATION,
        SDL_DISPLAYEVENT_CONNECTED,
        SDL_DISPLAYEVENT_DISCONNECTED,
        SDL_DISPLAYEVENT_MOVED,
    }


    public enum SDL_DisplayOrientation : uint
    {
        SDL_ORIENTATION_UNKNOWN,
        SDL_ORIENTATION_LANDSCAPE,
        SDL_ORIENTATION_LANDSCAPE_FLIPPED,
        SDL_ORIENTATION_PORTRAIT,
        SDL_ORIENTATION_PORTRAIT_FLIPPED,
    }


    public enum SDL_FlashOperation : uint
    {
        SDL_FLASH_CANCEL,
        SDL_FLASH_BRIEFLY,
        SDL_FLASH_UNTIL_FOCUSED,
    }


    public enum SDL_GLattr : uint
    {
        SDL_GL_RED_SIZE,
        SDL_GL_GREEN_SIZE,
        SDL_GL_BLUE_SIZE,
        SDL_GL_ALPHA_SIZE,
        SDL_GL_BUFFER_SIZE,
        SDL_GL_DOUBLEBUFFER,
        SDL_GL_DEPTH_SIZE,
        SDL_GL_STENCIL_SIZE,
        SDL_GL_ACCUM_RED_SIZE,
        SDL_GL_ACCUM_GREEN_SIZE,
        SDL_GL_ACCUM_BLUE_SIZE,
        SDL_GL_ACCUM_ALPHA_SIZE,
        SDL_GL_STEREO,
        SDL_GL_MULTISAMPLEBUFFERS,
        SDL_GL_MULTISAMPLESAMPLES,
        SDL_GL_ACCELERATED_VISUAL,
        SDL_GL_RETAINED_BACKING,
        SDL_GL_CONTEXT_MAJOR_VERSION,
        SDL_GL_CONTEXT_MINOR_VERSION,
        SDL_GL_CONTEXT_EGL,
        SDL_GL_CONTEXT_FLAGS,
        SDL_GL_CONTEXT_PROFILE_MASK,
        SDL_GL_SHARE_WITH_CURRENT_CONTEXT,
        SDL_GL_FRAMEBUFFER_SRGB_CAPABLE,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR,
        SDL_GL_CONTEXT_RESET_NOTIFICATION,
        SDL_GL_CONTEXT_NO_ERROR,
        SDL_GL_FLOATBUFFERS,
    }


    public enum SDL_GLprofile : uint
    {
        SDL_GL_CONTEXT_PROFILE_CORE = 0x0001,
        SDL_GL_CONTEXT_PROFILE_COMPATIBILITY = 0x0002,
        SDL_GL_CONTEXT_PROFILE_ES = 0x0004,
    }


    public enum SDL_GLcontextFlag : uint
    {
        SDL_GL_CONTEXT_DEBUG_FLAG = 0x0001,
        SDL_GL_CONTEXT_FORWARD_COMPATIBLE_FLAG = 0x0002,
        SDL_GL_CONTEXT_ROBUST_ACCESS_FLAG = 0x0004,
        SDL_GL_CONTEXT_RESET_ISOLATION_FLAG = 0x0008,
    }


    public enum SDL_GLcontextReleaseFlag : uint
    {
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR_NONE = 0x0000,
        SDL_GL_CONTEXT_RELEASE_BEHAVIOR_FLUSH = 0x0001,
    }


    public enum SDL_GLContextResetNotification : uint
    {
        SDL_GL_CONTEXT_RESET_NO_NOTIFICATION = 0x0000,
        SDL_GL_CONTEXT_RESET_LOSE_CONTEXT = 0x0001,
    }


    public enum SDL_HitTestResult : uint
    {
        SDL_HITTEST_NORMAL,
        SDL_HITTEST_DRAGGABLE,
        SDL_HITTEST_RESIZE_TOPLEFT,
        SDL_HITTEST_RESIZE_TOP,
        SDL_HITTEST_RESIZE_TOPRIGHT,
        SDL_HITTEST_RESIZE_RIGHT,
        SDL_HITTEST_RESIZE_BOTTOMRIGHT,
        SDL_HITTEST_RESIZE_BOTTOM,
        SDL_HITTEST_RESIZE_BOTTOMLEFT,
        SDL_HITTEST_RESIZE_LEFT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate SDL_HitTestResult SDL_HitTest(SDL_Window* win, SDL_Point* area, void* data);


    public enum SDL_Scancode : uint
    {
        SDL_SCANCODE_UNKNOWN = 0,
        SDL_SCANCODE_A = 4,
        SDL_SCANCODE_B = 5,
        SDL_SCANCODE_C = 6,
        SDL_SCANCODE_D = 7,
        SDL_SCANCODE_E = 8,
        SDL_SCANCODE_F = 9,
        SDL_SCANCODE_G = 10,
        SDL_SCANCODE_H = 11,
        SDL_SCANCODE_I = 12,
        SDL_SCANCODE_J = 13,
        SDL_SCANCODE_K = 14,
        SDL_SCANCODE_L = 15,
        SDL_SCANCODE_M = 16,
        SDL_SCANCODE_N = 17,
        SDL_SCANCODE_O = 18,
        SDL_SCANCODE_P = 19,
        SDL_SCANCODE_Q = 20,
        SDL_SCANCODE_R = 21,
        SDL_SCANCODE_S = 22,
        SDL_SCANCODE_T = 23,
        SDL_SCANCODE_U = 24,
        SDL_SCANCODE_V = 25,
        SDL_SCANCODE_W = 26,
        SDL_SCANCODE_X = 27,
        SDL_SCANCODE_Y = 28,
        SDL_SCANCODE_Z = 29,
        SDL_SCANCODE_1 = 30,
        SDL_SCANCODE_2 = 31,
        SDL_SCANCODE_3 = 32,
        SDL_SCANCODE_4 = 33,
        SDL_SCANCODE_5 = 34,
        SDL_SCANCODE_6 = 35,
        SDL_SCANCODE_7 = 36,
        SDL_SCANCODE_8 = 37,
        SDL_SCANCODE_9 = 38,
        SDL_SCANCODE_0 = 39,
        SDL_SCANCODE_RETURN = 40,
        SDL_SCANCODE_ESCAPE = 41,
        SDL_SCANCODE_BACKSPACE = 42,
        SDL_SCANCODE_TAB = 43,
        SDL_SCANCODE_SPACE = 44,
        SDL_SCANCODE_MINUS = 45,
        SDL_SCANCODE_EQUALS = 46,
        SDL_SCANCODE_LEFTBRACKET = 47,
        SDL_SCANCODE_RIGHTBRACKET = 48,
        SDL_SCANCODE_BACKSLASH = 49,
        SDL_SCANCODE_NONUSHASH = 50,
        SDL_SCANCODE_SEMICOLON = 51,
        SDL_SCANCODE_APOSTROPHE = 52,
        SDL_SCANCODE_GRAVE = 53,
        SDL_SCANCODE_COMMA = 54,
        SDL_SCANCODE_PERIOD = 55,
        SDL_SCANCODE_SLASH = 56,
        SDL_SCANCODE_CAPSLOCK = 57,
        SDL_SCANCODE_F1 = 58,
        SDL_SCANCODE_F2 = 59,
        SDL_SCANCODE_F3 = 60,
        SDL_SCANCODE_F4 = 61,
        SDL_SCANCODE_F5 = 62,
        SDL_SCANCODE_F6 = 63,
        SDL_SCANCODE_F7 = 64,
        SDL_SCANCODE_F8 = 65,
        SDL_SCANCODE_F9 = 66,
        SDL_SCANCODE_F10 = 67,
        SDL_SCANCODE_F11 = 68,
        SDL_SCANCODE_F12 = 69,
        SDL_SCANCODE_PRINTSCREEN = 70,
        SDL_SCANCODE_SCROLLLOCK = 71,
        SDL_SCANCODE_PAUSE = 72,
        SDL_SCANCODE_INSERT = 73,
        SDL_SCANCODE_HOME = 74,
        SDL_SCANCODE_PAGEUP = 75,
        SDL_SCANCODE_DELETE = 76,
        SDL_SCANCODE_END = 77,
        SDL_SCANCODE_PAGEDOWN = 78,
        SDL_SCANCODE_RIGHT = 79,
        SDL_SCANCODE_LEFT = 80,
        SDL_SCANCODE_DOWN = 81,
        SDL_SCANCODE_UP = 82,
        SDL_SCANCODE_NUMLOCKCLEAR = 83,
        SDL_SCANCODE_KP_DIVIDE = 84,
        SDL_SCANCODE_KP_MULTIPLY = 85,
        SDL_SCANCODE_KP_MINUS = 86,
        SDL_SCANCODE_KP_PLUS = 87,
        SDL_SCANCODE_KP_ENTER = 88,
        SDL_SCANCODE_KP_1 = 89,
        SDL_SCANCODE_KP_2 = 90,
        SDL_SCANCODE_KP_3 = 91,
        SDL_SCANCODE_KP_4 = 92,
        SDL_SCANCODE_KP_5 = 93,
        SDL_SCANCODE_KP_6 = 94,
        SDL_SCANCODE_KP_7 = 95,
        SDL_SCANCODE_KP_8 = 96,
        SDL_SCANCODE_KP_9 = 97,
        SDL_SCANCODE_KP_0 = 98,
        SDL_SCANCODE_KP_PERIOD = 99,
        SDL_SCANCODE_NONUSBACKSLASH = 100,
        SDL_SCANCODE_APPLICATION = 101,
        SDL_SCANCODE_POWER = 102,
        SDL_SCANCODE_KP_EQUALS = 103,
        SDL_SCANCODE_F13 = 104,
        SDL_SCANCODE_F14 = 105,
        SDL_SCANCODE_F15 = 106,
        SDL_SCANCODE_F16 = 107,
        SDL_SCANCODE_F17 = 108,
        SDL_SCANCODE_F18 = 109,
        SDL_SCANCODE_F19 = 110,
        SDL_SCANCODE_F20 = 111,
        SDL_SCANCODE_F21 = 112,
        SDL_SCANCODE_F22 = 113,
        SDL_SCANCODE_F23 = 114,
        SDL_SCANCODE_F24 = 115,
        SDL_SCANCODE_EXECUTE = 116,
        SDL_SCANCODE_HELP = 117,
        SDL_SCANCODE_MENU = 118,
        SDL_SCANCODE_SELECT = 119,
        SDL_SCANCODE_STOP = 120,
        SDL_SCANCODE_AGAIN = 121,
        SDL_SCANCODE_UNDO = 122,
        SDL_SCANCODE_CUT = 123,
        SDL_SCANCODE_COPY = 124,
        SDL_SCANCODE_PASTE = 125,
        SDL_SCANCODE_FIND = 126,
        SDL_SCANCODE_MUTE = 127,
        SDL_SCANCODE_VOLUMEUP = 128,
        SDL_SCANCODE_VOLUMEDOWN = 129,
        SDL_SCANCODE_KP_COMMA = 133,
        SDL_SCANCODE_KP_EQUALSAS400 = 134,
        SDL_SCANCODE_INTERNATIONAL1 = 135,
        SDL_SCANCODE_INTERNATIONAL2 = 136,
        SDL_SCANCODE_INTERNATIONAL3 = 137,
        SDL_SCANCODE_INTERNATIONAL4 = 138,
        SDL_SCANCODE_INTERNATIONAL5 = 139,
        SDL_SCANCODE_INTERNATIONAL6 = 140,
        SDL_SCANCODE_INTERNATIONAL7 = 141,
        SDL_SCANCODE_INTERNATIONAL8 = 142,
        SDL_SCANCODE_INTERNATIONAL9 = 143,
        SDL_SCANCODE_LANG1 = 144,
        SDL_SCANCODE_LANG2 = 145,
        SDL_SCANCODE_LANG3 = 146,
        SDL_SCANCODE_LANG4 = 147,
        SDL_SCANCODE_LANG5 = 148,
        SDL_SCANCODE_LANG6 = 149,
        SDL_SCANCODE_LANG7 = 150,
        SDL_SCANCODE_LANG8 = 151,
        SDL_SCANCODE_LANG9 = 152,
        SDL_SCANCODE_ALTERASE = 153,
        SDL_SCANCODE_SYSREQ = 154,
        SDL_SCANCODE_CANCEL = 155,
        SDL_SCANCODE_CLEAR = 156,
        SDL_SCANCODE_PRIOR = 157,
        SDL_SCANCODE_RETURN2 = 158,
        SDL_SCANCODE_SEPARATOR = 159,
        SDL_SCANCODE_OUT = 160,
        SDL_SCANCODE_OPER = 161,
        SDL_SCANCODE_CLEARAGAIN = 162,
        SDL_SCANCODE_CRSEL = 163,
        SDL_SCANCODE_EXSEL = 164,
        SDL_SCANCODE_KP_00 = 176,
        SDL_SCANCODE_KP_000 = 177,
        SDL_SCANCODE_THOUSANDSSEPARATOR = 178,
        SDL_SCANCODE_DECIMALSEPARATOR = 179,
        SDL_SCANCODE_CURRENCYUNIT = 180,
        SDL_SCANCODE_CURRENCYSUBUNIT = 181,
        SDL_SCANCODE_KP_LEFTPAREN = 182,
        SDL_SCANCODE_KP_RIGHTPAREN = 183,
        SDL_SCANCODE_KP_LEFTBRACE = 184,
        SDL_SCANCODE_KP_RIGHTBRACE = 185,
        SDL_SCANCODE_KP_TAB = 186,
        SDL_SCANCODE_KP_BACKSPACE = 187,
        SDL_SCANCODE_KP_A = 188,
        SDL_SCANCODE_KP_B = 189,
        SDL_SCANCODE_KP_C = 190,
        SDL_SCANCODE_KP_D = 191,
        SDL_SCANCODE_KP_E = 192,
        SDL_SCANCODE_KP_F = 193,
        SDL_SCANCODE_KP_XOR = 194,
        SDL_SCANCODE_KP_POWER = 195,
        SDL_SCANCODE_KP_PERCENT = 196,
        SDL_SCANCODE_KP_LESS = 197,
        SDL_SCANCODE_KP_GREATER = 198,
        SDL_SCANCODE_KP_AMPERSAND = 199,
        SDL_SCANCODE_KP_DBLAMPERSAND = 200,
        SDL_SCANCODE_KP_VERTICALBAR = 201,
        SDL_SCANCODE_KP_DBLVERTICALBAR = 202,
        SDL_SCANCODE_KP_COLON = 203,
        SDL_SCANCODE_KP_HASH = 204,
        SDL_SCANCODE_KP_SPACE = 205,
        SDL_SCANCODE_KP_AT = 206,
        SDL_SCANCODE_KP_EXCLAM = 207,
        SDL_SCANCODE_KP_MEMSTORE = 208,
        SDL_SCANCODE_KP_MEMRECALL = 209,
        SDL_SCANCODE_KP_MEMCLEAR = 210,
        SDL_SCANCODE_KP_MEMADD = 211,
        SDL_SCANCODE_KP_MEMSUBTRACT = 212,
        SDL_SCANCODE_KP_MEMMULTIPLY = 213,
        SDL_SCANCODE_KP_MEMDIVIDE = 214,
        SDL_SCANCODE_KP_PLUSMINUS = 215,
        SDL_SCANCODE_KP_CLEAR = 216,
        SDL_SCANCODE_KP_CLEARENTRY = 217,
        SDL_SCANCODE_KP_BINARY = 218,
        SDL_SCANCODE_KP_OCTAL = 219,
        SDL_SCANCODE_KP_DECIMAL = 220,
        SDL_SCANCODE_KP_HEXADECIMAL = 221,
        SDL_SCANCODE_LCTRL = 224,
        SDL_SCANCODE_LSHIFT = 225,
        SDL_SCANCODE_LALT = 226,
        SDL_SCANCODE_LGUI = 227,
        SDL_SCANCODE_RCTRL = 228,
        SDL_SCANCODE_RSHIFT = 229,
        SDL_SCANCODE_RALT = 230,
        SDL_SCANCODE_RGUI = 231,
        SDL_SCANCODE_MODE = 257,
        SDL_SCANCODE_AUDIONEXT = 258,
        SDL_SCANCODE_AUDIOPREV = 259,
        SDL_SCANCODE_AUDIOSTOP = 260,
        SDL_SCANCODE_AUDIOPLAY = 261,
        SDL_SCANCODE_AUDIOMUTE = 262,
        SDL_SCANCODE_MEDIASELECT = 263,
        SDL_SCANCODE_WWW = 264,
        SDL_SCANCODE_MAIL = 265,
        SDL_SCANCODE_CALCULATOR = 266,
        SDL_SCANCODE_COMPUTER = 267,
        SDL_SCANCODE_AC_SEARCH = 268,
        SDL_SCANCODE_AC_HOME = 269,
        SDL_SCANCODE_AC_BACK = 270,
        SDL_SCANCODE_AC_FORWARD = 271,
        SDL_SCANCODE_AC_STOP = 272,
        SDL_SCANCODE_AC_REFRESH = 273,
        SDL_SCANCODE_AC_BOOKMARKS = 274,
        SDL_SCANCODE_BRIGHTNESSDOWN = 275,
        SDL_SCANCODE_BRIGHTNESSUP = 276,
        SDL_SCANCODE_DISPLAYSWITCH = 277,
        SDL_SCANCODE_KBDILLUMTOGGLE = 278,
        SDL_SCANCODE_KBDILLUMDOWN = 279,
        SDL_SCANCODE_KBDILLUMUP = 280,
        SDL_SCANCODE_EJECT = 281,
        SDL_SCANCODE_SLEEP = 282,
        SDL_SCANCODE_APP1 = 283,
        SDL_SCANCODE_APP2 = 284,
        SDL_SCANCODE_AUDIOREWIND = 285,
        SDL_SCANCODE_AUDIOFASTFORWARD = 286,
        SDL_SCANCODE_SOFTLEFT = 287,
        SDL_SCANCODE_SOFTRIGHT = 288,
        SDL_SCANCODE_CALL = 289,
        SDL_SCANCODE_ENDCALL = 290,
        SDL_NUM_SCANCODES = 512,
    }


    public enum SDL_KeyCode : uint
    {
        SDLK_UNKNOWN = 0,
        SDLK_RETURN = '\r',
        SDLK_ESCAPE = '',
        SDLK_BACKSPACE = '',
        SDLK_TAB = '\t',
        SDLK_SPACE = ' ',
        SDLK_EXCLAIM = '!',
        SDLK_QUOTEDBL = '"',
        SDLK_HASH = '#',
        SDLK_PERCENT = '%',
        SDLK_DOLLAR = '$',
        SDLK_AMPERSAND = '&',
        SDLK_QUOTE = '\'',
        SDLK_LEFTPAREN = '(',
        SDLK_RIGHTPAREN = ')',
        SDLK_ASTERISK = '*',
        SDLK_PLUS = '+',
        SDLK_COMMA = ',',
        SDLK_MINUS = '-',
        SDLK_PERIOD = '.',
        SDLK_SLASH = '/',
        SDLK_0 = '0',
        SDLK_1 = '1',
        SDLK_2 = '2',
        SDLK_3 = '3',
        SDLK_4 = '4',
        SDLK_5 = '5',
        SDLK_6 = '6',
        SDLK_7 = '7',
        SDLK_8 = '8',
        SDLK_9 = '9',
        SDLK_COLON = ':',
        SDLK_SEMICOLON = ';',
        SDLK_LESS = '<',
        SDLK_EQUALS = '=',
        SDLK_GREATER = '>',
        SDLK_QUESTION = '?',
        SDLK_AT = '@',
        SDLK_LEFTBRACKET = '[',
        SDLK_BACKSLASH = '\\',
        SDLK_RIGHTBRACKET = ']',
        SDLK_CARET = '^',
        SDLK_UNDERSCORE = '_',
        SDLK_BACKQUOTE = '`',
        SDLK_a = 'a',
        SDLK_b = 'b',
        SDLK_c = 'c',
        SDLK_d = 'd',
        SDLK_e = 'e',
        SDLK_f = 'f',
        SDLK_g = 'g',
        SDLK_h = 'h',
        SDLK_i = 'i',
        SDLK_j = 'j',
        SDLK_k = 'k',
        SDLK_l = 'l',
        SDLK_m = 'm',
        SDLK_n = 'n',
        SDLK_o = 'o',
        SDLK_p = 'p',
        SDLK_q = 'q',
        SDLK_r = 'r',
        SDLK_s = 's',
        SDLK_t = 't',
        SDLK_u = 'u',
        SDLK_v = 'v',
        SDLK_w = 'w',
        SDLK_x = 'x',
        SDLK_y = 'y',
        SDLK_z = 'z',
        SDLK_CAPSLOCK = ((uint)SDL_SCANCODE_CAPSLOCK | (1 << 30)),
        SDLK_F1 = ((uint)SDL_SCANCODE_F1 | (1 << 30)),
        SDLK_F2 = ((uint)SDL_SCANCODE_F2 | (1 << 30)),
        SDLK_F3 = ((uint)SDL_SCANCODE_F3 | (1 << 30)),
        SDLK_F4 = ((uint)SDL_SCANCODE_F4 | (1 << 30)),
        SDLK_F5 = ((uint)SDL_SCANCODE_F5 | (1 << 30)),
        SDLK_F6 = ((uint)SDL_SCANCODE_F6 | (1 << 30)),
        SDLK_F7 = ((uint)SDL_SCANCODE_F7 | (1 << 30)),
        SDLK_F8 = ((uint)SDL_SCANCODE_F8 | (1 << 30)),
        SDLK_F9 = ((uint)SDL_SCANCODE_F9 | (1 << 30)),
        SDLK_F10 = ((uint)SDL_SCANCODE_F10 | (1 << 30)),
        SDLK_F11 = ((uint)SDL_SCANCODE_F11 | (1 << 30)),
        SDLK_F12 = ((uint)SDL_SCANCODE_F12 | (1 << 30)),
        SDLK_PRINTSCREEN = ((uint)SDL_SCANCODE_PRINTSCREEN | (1 << 30)),
        SDLK_SCROLLLOCK = ((uint)SDL_SCANCODE_SCROLLLOCK | (1 << 30)),
        SDLK_PAUSE = ((uint)SDL_SCANCODE_PAUSE | (1 << 30)),
        SDLK_INSERT = ((uint)SDL_SCANCODE_INSERT | (1 << 30)),
        SDLK_HOME = ((uint)SDL_SCANCODE_HOME | (1 << 30)),
        SDLK_PAGEUP = ((uint)SDL_SCANCODE_PAGEUP | (1 << 30)),
        SDLK_DELETE = '',
        SDLK_END = ((uint)SDL_SCANCODE_END | (1 << 30)),
        SDLK_PAGEDOWN = ((uint)SDL_SCANCODE_PAGEDOWN | (1 << 30)),
        SDLK_RIGHT = ((uint)SDL_SCANCODE_RIGHT | (1 << 30)),
        SDLK_LEFT = ((uint)SDL_SCANCODE_LEFT | (1 << 30)),
        SDLK_DOWN = ((uint)SDL_SCANCODE_DOWN | (1 << 30)),
        SDLK_UP = ((uint)SDL_SCANCODE_UP | (1 << 30)),
        SDLK_NUMLOCKCLEAR = ((uint)SDL_SCANCODE_NUMLOCKCLEAR | (1 << 30)),
        SDLK_KP_DIVIDE = ((uint)SDL_SCANCODE_KP_DIVIDE | (1 << 30)),
        SDLK_KP_MULTIPLY = ((uint)SDL_SCANCODE_KP_MULTIPLY | (1 << 30)),
        SDLK_KP_MINUS = ((uint)SDL_SCANCODE_KP_MINUS | (1 << 30)),
        SDLK_KP_PLUS = ((uint)SDL_SCANCODE_KP_PLUS | (1 << 30)),
        SDLK_KP_ENTER = ((uint)SDL_SCANCODE_KP_ENTER | (1 << 30)),
        SDLK_KP_1 = ((uint)SDL_SCANCODE_KP_1 | (1 << 30)),
        SDLK_KP_2 = ((uint)SDL_SCANCODE_KP_2 | (1 << 30)),
        SDLK_KP_3 = ((uint)SDL_SCANCODE_KP_3 | (1 << 30)),
        SDLK_KP_4 = ((uint)SDL_SCANCODE_KP_4 | (1 << 30)),
        SDLK_KP_5 = ((uint)SDL_SCANCODE_KP_5 | (1 << 30)),
        SDLK_KP_6 = ((uint)SDL_SCANCODE_KP_6 | (1 << 30)),
        SDLK_KP_7 = ((uint)SDL_SCANCODE_KP_7 | (1 << 30)),
        SDLK_KP_8 = ((uint)SDL_SCANCODE_KP_8 | (1 << 30)),
        SDLK_KP_9 = ((uint)SDL_SCANCODE_KP_9 | (1 << 30)),
        SDLK_KP_0 = ((uint)SDL_SCANCODE_KP_0 | (1 << 30)),
        SDLK_KP_PERIOD = ((uint)SDL_SCANCODE_KP_PERIOD | (1 << 30)),
        SDLK_APPLICATION = ((uint)SDL_SCANCODE_APPLICATION | (1 << 30)),
        SDLK_POWER = ((uint)SDL_SCANCODE_POWER | (1 << 30)),
        SDLK_KP_EQUALS = ((uint)SDL_SCANCODE_KP_EQUALS | (1 << 30)),
        SDLK_F13 = ((uint)SDL_SCANCODE_F13 | (1 << 30)),
        SDLK_F14 = ((uint)SDL_SCANCODE_F14 | (1 << 30)),
        SDLK_F15 = ((uint)SDL_SCANCODE_F15 | (1 << 30)),
        SDLK_F16 = ((uint)SDL_SCANCODE_F16 | (1 << 30)),
        SDLK_F17 = ((uint)SDL_SCANCODE_F17 | (1 << 30)),
        SDLK_F18 = ((uint)SDL_SCANCODE_F18 | (1 << 30)),
        SDLK_F19 = ((uint)SDL_SCANCODE_F19 | (1 << 30)),
        SDLK_F20 = ((uint)SDL_SCANCODE_F20 | (1 << 30)),
        SDLK_F21 = ((uint)SDL_SCANCODE_F21 | (1 << 30)),
        SDLK_F22 = ((uint)SDL_SCANCODE_F22 | (1 << 30)),
        SDLK_F23 = ((uint)SDL_SCANCODE_F23 | (1 << 30)),
        SDLK_F24 = ((uint)SDL_SCANCODE_F24 | (1 << 30)),
        SDLK_EXECUTE = ((uint)SDL_SCANCODE_EXECUTE | (1 << 30)),
        SDLK_HELP = ((uint)SDL_SCANCODE_HELP | (1 << 30)),
        SDLK_MENU = ((uint)SDL_SCANCODE_MENU | (1 << 30)),
        SDLK_SELECT = ((uint)SDL_SCANCODE_SELECT | (1 << 30)),
        SDLK_STOP = ((uint)SDL_SCANCODE_STOP | (1 << 30)),
        SDLK_AGAIN = ((uint)SDL_SCANCODE_AGAIN | (1 << 30)),
        SDLK_UNDO = ((uint)SDL_SCANCODE_UNDO | (1 << 30)),
        SDLK_CUT = ((uint)SDL_SCANCODE_CUT | (1 << 30)),
        SDLK_COPY = ((uint)SDL_SCANCODE_COPY | (1 << 30)),
        SDLK_PASTE = ((uint)SDL_SCANCODE_PASTE | (1 << 30)),
        SDLK_FIND = ((uint)SDL_SCANCODE_FIND | (1 << 30)),
        SDLK_MUTE = ((uint)SDL_SCANCODE_MUTE | (1 << 30)),
        SDLK_VOLUMEUP = ((uint)SDL_SCANCODE_VOLUMEUP | (1 << 30)),
        SDLK_VOLUMEDOWN = ((uint)SDL_SCANCODE_VOLUMEDOWN | (1 << 30)),
        SDLK_KP_COMMA = ((uint)SDL_SCANCODE_KP_COMMA | (1 << 30)),
        SDLK_KP_EQUALSAS400 = ((uint)SDL_SCANCODE_KP_EQUALSAS400 | (1 << 30)),
        SDLK_ALTERASE = ((uint)SDL_SCANCODE_ALTERASE | (1 << 30)),
        SDLK_SYSREQ = ((uint)SDL_SCANCODE_SYSREQ | (1 << 30)),
        SDLK_CANCEL = ((uint)SDL_SCANCODE_CANCEL | (1 << 30)),
        SDLK_CLEAR = ((uint)SDL_SCANCODE_CLEAR | (1 << 30)),
        SDLK_PRIOR = ((uint)SDL_SCANCODE_PRIOR | (1 << 30)),
        SDLK_RETURN2 = ((uint)SDL_SCANCODE_RETURN2 | (1 << 30)),
        SDLK_SEPARATOR = ((uint)SDL_SCANCODE_SEPARATOR | (1 << 30)),
        SDLK_OUT = ((uint)SDL_SCANCODE_OUT | (1 << 30)),
        SDLK_OPER = ((uint)SDL_SCANCODE_OPER | (1 << 30)),
        SDLK_CLEARAGAIN = ((uint)SDL_SCANCODE_CLEARAGAIN | (1 << 30)),
        SDLK_CRSEL = ((uint)SDL_SCANCODE_CRSEL | (1 << 30)),
        SDLK_EXSEL = ((uint)SDL_SCANCODE_EXSEL | (1 << 30)),
        SDLK_KP_00 = ((uint)SDL_SCANCODE_KP_00 | (1 << 30)),
        SDLK_KP_000 = ((uint)SDL_SCANCODE_KP_000 | (1 << 30)),
        SDLK_THOUSANDSSEPARATOR = ((uint)SDL_SCANCODE_THOUSANDSSEPARATOR | (1 << 30)),
        SDLK_DECIMALSEPARATOR = ((uint)SDL_SCANCODE_DECIMALSEPARATOR | (1 << 30)),
        SDLK_CURRENCYUNIT = ((uint)SDL_SCANCODE_CURRENCYUNIT | (1 << 30)),
        SDLK_CURRENCYSUBUNIT = ((uint)SDL_SCANCODE_CURRENCYSUBUNIT | (1 << 30)),
        SDLK_KP_LEFTPAREN = ((uint)SDL_SCANCODE_KP_LEFTPAREN | (1 << 30)),
        SDLK_KP_RIGHTPAREN = ((uint)SDL_SCANCODE_KP_RIGHTPAREN | (1 << 30)),
        SDLK_KP_LEFTBRACE = ((uint)SDL_SCANCODE_KP_LEFTBRACE | (1 << 30)),
        SDLK_KP_RIGHTBRACE = ((uint)SDL_SCANCODE_KP_RIGHTBRACE | (1 << 30)),
        SDLK_KP_TAB = ((uint)SDL_SCANCODE_KP_TAB | (1 << 30)),
        SDLK_KP_BACKSPACE = ((uint)SDL_SCANCODE_KP_BACKSPACE | (1 << 30)),
        SDLK_KP_A = ((uint)SDL_SCANCODE_KP_A | (1 << 30)),
        SDLK_KP_B = ((uint)SDL_SCANCODE_KP_B | (1 << 30)),
        SDLK_KP_C = ((uint)SDL_SCANCODE_KP_C | (1 << 30)),
        SDLK_KP_D = ((uint)SDL_SCANCODE_KP_D | (1 << 30)),
        SDLK_KP_E = ((uint)SDL_SCANCODE_KP_E | (1 << 30)),
        SDLK_KP_F = ((uint)SDL_SCANCODE_KP_F | (1 << 30)),
        SDLK_KP_XOR = ((uint)SDL_SCANCODE_KP_XOR | (1 << 30)),
        SDLK_KP_POWER = ((uint)SDL_SCANCODE_KP_POWER | (1 << 30)),
        SDLK_KP_PERCENT = ((uint)SDL_SCANCODE_KP_PERCENT | (1 << 30)),
        SDLK_KP_LESS = ((uint)SDL_SCANCODE_KP_LESS | (1 << 30)),
        SDLK_KP_GREATER = ((uint)SDL_SCANCODE_KP_GREATER | (1 << 30)),
        SDLK_KP_AMPERSAND = ((uint)SDL_SCANCODE_KP_AMPERSAND | (1 << 30)),
        SDLK_KP_DBLAMPERSAND = ((uint)SDL_SCANCODE_KP_DBLAMPERSAND | (1 << 30)),
        SDLK_KP_VERTICALBAR = ((uint)SDL_SCANCODE_KP_VERTICALBAR | (1 << 30)),
        SDLK_KP_DBLVERTICALBAR = ((uint)SDL_SCANCODE_KP_DBLVERTICALBAR | (1 << 30)),
        SDLK_KP_COLON = ((uint)SDL_SCANCODE_KP_COLON | (1 << 30)),
        SDLK_KP_HASH = ((uint)SDL_SCANCODE_KP_HASH | (1 << 30)),
        SDLK_KP_SPACE = ((uint)SDL_SCANCODE_KP_SPACE | (1 << 30)),
        SDLK_KP_AT = ((uint)SDL_SCANCODE_KP_AT | (1 << 30)),
        SDLK_KP_EXCLAM = ((uint)SDL_SCANCODE_KP_EXCLAM | (1 << 30)),
        SDLK_KP_MEMSTORE = ((uint)SDL_SCANCODE_KP_MEMSTORE | (1 << 30)),
        SDLK_KP_MEMRECALL = ((uint)SDL_SCANCODE_KP_MEMRECALL | (1 << 30)),
        SDLK_KP_MEMCLEAR = ((uint)SDL_SCANCODE_KP_MEMCLEAR | (1 << 30)),
        SDLK_KP_MEMADD = ((uint)SDL_SCANCODE_KP_MEMADD | (1 << 30)),
        SDLK_KP_MEMSUBTRACT = ((uint)SDL_SCANCODE_KP_MEMSUBTRACT | (1 << 30)),
        SDLK_KP_MEMMULTIPLY = ((uint)SDL_SCANCODE_KP_MEMMULTIPLY | (1 << 30)),
        SDLK_KP_MEMDIVIDE = ((uint)SDL_SCANCODE_KP_MEMDIVIDE | (1 << 30)),
        SDLK_KP_PLUSMINUS = ((uint)SDL_SCANCODE_KP_PLUSMINUS | (1 << 30)),
        SDLK_KP_CLEAR = ((uint)SDL_SCANCODE_KP_CLEAR | (1 << 30)),
        SDLK_KP_CLEARENTRY = ((uint)SDL_SCANCODE_KP_CLEARENTRY | (1 << 30)),
        SDLK_KP_BINARY = ((uint)SDL_SCANCODE_KP_BINARY | (1 << 30)),
        SDLK_KP_OCTAL = ((uint)SDL_SCANCODE_KP_OCTAL | (1 << 30)),
        SDLK_KP_DECIMAL = ((uint)SDL_SCANCODE_KP_DECIMAL | (1 << 30)),
        SDLK_KP_HEXADECIMAL = ((uint)SDL_SCANCODE_KP_HEXADECIMAL | (1 << 30)),
        SDLK_LCTRL = ((uint)SDL_SCANCODE_LCTRL | (1 << 30)),
        SDLK_LSHIFT = ((uint)SDL_SCANCODE_LSHIFT | (1 << 30)),
        SDLK_LALT = ((uint)SDL_SCANCODE_LALT | (1 << 30)),
        SDLK_LGUI = ((uint)SDL_SCANCODE_LGUI | (1 << 30)),
        SDLK_RCTRL = ((uint)SDL_SCANCODE_RCTRL | (1 << 30)),
        SDLK_RSHIFT = ((uint)SDL_SCANCODE_RSHIFT | (1 << 30)),
        SDLK_RALT = ((uint)SDL_SCANCODE_RALT | (1 << 30)),
        SDLK_RGUI = ((uint)SDL_SCANCODE_RGUI | (1 << 30)),
        SDLK_MODE = ((uint)SDL_SCANCODE_MODE | (1 << 30)),
        SDLK_AUDIONEXT = ((uint)SDL_SCANCODE_AUDIONEXT | (1 << 30)),
        SDLK_AUDIOPREV = ((uint)SDL_SCANCODE_AUDIOPREV | (1 << 30)),
        SDLK_AUDIOSTOP = ((uint)SDL_SCANCODE_AUDIOSTOP | (1 << 30)),
        SDLK_AUDIOPLAY = ((uint)SDL_SCANCODE_AUDIOPLAY | (1 << 30)),
        SDLK_AUDIOMUTE = ((uint)SDL_SCANCODE_AUDIOMUTE | (1 << 30)),
        SDLK_MEDIASELECT = ((uint)SDL_SCANCODE_MEDIASELECT | (1 << 30)),
        SDLK_WWW = ((uint)SDL_SCANCODE_WWW | (1 << 30)),
        SDLK_MAIL = ((uint)SDL_SCANCODE_MAIL | (1 << 30)),
        SDLK_CALCULATOR = ((uint)SDL_SCANCODE_CALCULATOR | (1 << 30)),
        SDLK_COMPUTER = ((uint)SDL_SCANCODE_COMPUTER | (1 << 30)),
        SDLK_AC_SEARCH = ((uint)SDL_SCANCODE_AC_SEARCH | (1 << 30)),
        SDLK_AC_HOME = ((uint)SDL_SCANCODE_AC_HOME | (1 << 30)),
        SDLK_AC_BACK = ((uint)SDL_SCANCODE_AC_BACK | (1 << 30)),
        SDLK_AC_FORWARD = ((uint)SDL_SCANCODE_AC_FORWARD | (1 << 30)),
        SDLK_AC_STOP = ((uint)SDL_SCANCODE_AC_STOP | (1 << 30)),
        SDLK_AC_REFRESH = ((uint)SDL_SCANCODE_AC_REFRESH | (1 << 30)),
        SDLK_AC_BOOKMARKS = ((uint)SDL_SCANCODE_AC_BOOKMARKS | (1 << 30)),
        SDLK_BRIGHTNESSDOWN = ((uint)SDL_SCANCODE_BRIGHTNESSDOWN | (1 << 30)),
        SDLK_BRIGHTNESSUP = ((uint)SDL_SCANCODE_BRIGHTNESSUP | (1 << 30)),
        SDLK_DISPLAYSWITCH = ((uint)SDL_SCANCODE_DISPLAYSWITCH | (1 << 30)),
        SDLK_KBDILLUMTOGGLE = ((uint)SDL_SCANCODE_KBDILLUMTOGGLE | (1 << 30)),
        SDLK_KBDILLUMDOWN = ((uint)SDL_SCANCODE_KBDILLUMDOWN | (1 << 30)),
        SDLK_KBDILLUMUP = ((uint)SDL_SCANCODE_KBDILLUMUP | (1 << 30)),
        SDLK_EJECT = ((uint)SDL_SCANCODE_EJECT | (1 << 30)),
        SDLK_SLEEP = ((uint)SDL_SCANCODE_SLEEP | (1 << 30)),
        SDLK_APP1 = ((uint)SDL_SCANCODE_APP1 | (1 << 30)),
        SDLK_APP2 = ((uint)SDL_SCANCODE_APP2 | (1 << 30)),
        SDLK_AUDIOREWIND = ((uint)SDL_SCANCODE_AUDIOREWIND | (1 << 30)),
        SDLK_AUDIOFASTFORWARD = ((uint)SDL_SCANCODE_AUDIOFASTFORWARD | (1 << 30)),
        SDLK_SOFTLEFT = ((uint)SDL_SCANCODE_SOFTLEFT | (1 << 30)),
        SDLK_SOFTRIGHT = ((uint)SDL_SCANCODE_SOFTRIGHT | (1 << 30)),
        SDLK_CALL = ((uint)SDL_SCANCODE_CALL | (1 << 30)),
        SDLK_ENDCALL = ((uint)SDL_SCANCODE_ENDCALL | (1 << 30)),
    }


    public enum SDL_Keymod : uint
    {
        KMOD_NONE = 0x0000,
        KMOD_LSHIFT = 0x0001,
        KMOD_RSHIFT = 0x0002,
        KMOD_LCTRL = 0x0040,
        KMOD_RCTRL = 0x0080,
        KMOD_LALT = 0x0100,
        KMOD_RALT = 0x0200,
        KMOD_LGUI = 0x0400,
        KMOD_RGUI = 0x0800,
        KMOD_NUM = 0x1000,
        KMOD_CAPS = 0x2000,
        KMOD_MODE = 0x4000,
        KMOD_SCROLL = 0x8000,
        KMOD_CTRL = KMOD_LCTRL | KMOD_RCTRL,
        KMOD_SHIFT = KMOD_LSHIFT | KMOD_RSHIFT,
        KMOD_ALT = KMOD_LALT | KMOD_RALT,
        KMOD_GUI = KMOD_LGUI | KMOD_RGUI,
        KMOD_RESERVED = KMOD_SCROLL,
    }

    public partial struct SDL_Keysym
    {
        public SDL_Scancode scancode;


        public int sym;


        public ushort mod;


        public uint unused;
    }

    public partial struct SDL_Cursor
    {
    }


    public enum SDL_SystemCursor : uint
    {
        SDL_SYSTEM_CURSOR_ARROW,
        SDL_SYSTEM_CURSOR_IBEAM,
        SDL_SYSTEM_CURSOR_WAIT,
        SDL_SYSTEM_CURSOR_CROSSHAIR,
        SDL_SYSTEM_CURSOR_WAITARROW,
        SDL_SYSTEM_CURSOR_SIZENWSE,
        SDL_SYSTEM_CURSOR_SIZENESW,
        SDL_SYSTEM_CURSOR_SIZEWE,
        SDL_SYSTEM_CURSOR_SIZENS,
        SDL_SYSTEM_CURSOR_SIZEALL,
        SDL_SYSTEM_CURSOR_NO,
        SDL_SYSTEM_CURSOR_HAND,
        SDL_NUM_SYSTEM_CURSORS,
    }


    public enum SDL_MouseWheelDirection : uint
    {
        SDL_MOUSEWHEEL_NORMAL,
        SDL_MOUSEWHEEL_FLIPPED,
    }

    public unsafe partial struct SDL_GUID
    {

        public fixed byte data[16];
    }

    public partial struct _SDL_Joystick
    {
    }


    public enum SDL_JoystickType : uint
    {
        SDL_JOYSTICK_TYPE_UNKNOWN,
        SDL_JOYSTICK_TYPE_GAMECONTROLLER,
        SDL_JOYSTICK_TYPE_WHEEL,
        SDL_JOYSTICK_TYPE_ARCADE_STICK,
        SDL_JOYSTICK_TYPE_FLIGHT_STICK,
        SDL_JOYSTICK_TYPE_DANCE_PAD,
        SDL_JOYSTICK_TYPE_GUITAR,
        SDL_JOYSTICK_TYPE_DRUM_KIT,
        SDL_JOYSTICK_TYPE_ARCADE_PAD,
        SDL_JOYSTICK_TYPE_THROTTLE,
    }

    public enum SDL_JoystickPowerLevel
    {
        SDL_JOYSTICK_POWER_UNKNOWN = -1,
        SDL_JOYSTICK_POWER_EMPTY,
        SDL_JOYSTICK_POWER_LOW,
        SDL_JOYSTICK_POWER_MEDIUM,
        SDL_JOYSTICK_POWER_FULL,
        SDL_JOYSTICK_POWER_WIRED,
        SDL_JOYSTICK_POWER_MAX,
    }

    public unsafe partial struct SDL_VirtualJoystickDesc
    {

        public ushort version;


        public ushort type;


        public ushort naxes;


        public ushort nbuttons;


        public ushort nhats;


        public ushort vendor_id;


        public ushort product_id;


        public ushort padding;


        public uint button_mask;


        public uint axis_mask;


        public string name;

        public void* userdata;


        public IntPtr Update;


        public IntPtr SetPlayerIndex;


        public IntPtr Rumble;


        public IntPtr RumbleTriggers;


        public IntPtr SetLED;


        public IntPtr SendEffect;
    }

    public partial struct _SDL_Sensor
    {
    }

    public enum SDL_SensorType
    {
        SDL_SENSOR_INVALID = -1,
        SDL_SENSOR_UNKNOWN,
        SDL_SENSOR_ACCEL,
        SDL_SENSOR_GYRO,
        SDL_SENSOR_ACCEL_L,
        SDL_SENSOR_GYRO_L,
        SDL_SENSOR_ACCEL_R,
        SDL_SENSOR_GYRO_R,
    }

    public partial struct _SDL_GameController
    {
    }


    public enum SDL_GameControllerType : uint
    {
        SDL_CONTROLLER_TYPE_UNKNOWN = 0,
        SDL_CONTROLLER_TYPE_XBOX360,
        SDL_CONTROLLER_TYPE_XBOXONE,
        SDL_CONTROLLER_TYPE_PS3,
        SDL_CONTROLLER_TYPE_PS4,
        SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_PRO,
        SDL_CONTROLLER_TYPE_VIRTUAL,
        SDL_CONTROLLER_TYPE_PS5,
        SDL_CONTROLLER_TYPE_AMAZON_LUNA,
        SDL_CONTROLLER_TYPE_GOOGLE_STADIA,
        SDL_CONTROLLER_TYPE_NVIDIA_SHIELD,
        SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_LEFT,
        SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_RIGHT,
        SDL_CONTROLLER_TYPE_NINTENDO_SWITCH_JOYCON_PAIR,
        SDL_CONTROLLER_TYPE_MAX,
    }


    public enum SDL_GameControllerBindType : uint
    {
        SDL_CONTROLLER_BINDTYPE_NONE = 0,
        SDL_CONTROLLER_BINDTYPE_BUTTON,
        SDL_CONTROLLER_BINDTYPE_AXIS,
        SDL_CONTROLLER_BINDTYPE_HAT,
    }

    public unsafe partial struct SDL_GameControllerButtonBind
    {
        public SDL_GameControllerBindType bindType;


        public _value_e__Union value;

        [StructLayout(LayoutKind.Explicit)]
        public unsafe partial struct _value_e__Union
        {
            [FieldOffset(0)]
            public int button;

            [FieldOffset(0)]
            public int axis;

            [FieldOffset(0)]

            public _hat_e__Struct hat;

            public partial struct _hat_e__Struct
            {
                public int hat;

                public int hat_mask;
            }
        }
    }

    public enum SDL_GameControllerAxis
    {
        SDL_CONTROLLER_AXIS_INVALID = -1,
        SDL_CONTROLLER_AXIS_LEFTX,
        SDL_CONTROLLER_AXIS_LEFTY,
        SDL_CONTROLLER_AXIS_RIGHTX,
        SDL_CONTROLLER_AXIS_RIGHTY,
        SDL_CONTROLLER_AXIS_TRIGGERLEFT,
        SDL_CONTROLLER_AXIS_TRIGGERRIGHT,
        SDL_CONTROLLER_AXIS_MAX,
    }

    public enum SDL_GameControllerButton
    {
        SDL_CONTROLLER_BUTTON_INVALID = -1,
        SDL_CONTROLLER_BUTTON_A,
        SDL_CONTROLLER_BUTTON_B,
        SDL_CONTROLLER_BUTTON_X,
        SDL_CONTROLLER_BUTTON_Y,
        SDL_CONTROLLER_BUTTON_BACK,
        SDL_CONTROLLER_BUTTON_GUIDE,
        SDL_CONTROLLER_BUTTON_START,
        SDL_CONTROLLER_BUTTON_LEFTSTICK,
        SDL_CONTROLLER_BUTTON_RIGHTSTICK,
        SDL_CONTROLLER_BUTTON_LEFTSHOULDER,
        SDL_CONTROLLER_BUTTON_RIGHTSHOULDER,
        SDL_CONTROLLER_BUTTON_DPAD_UP,
        SDL_CONTROLLER_BUTTON_DPAD_DOWN,
        SDL_CONTROLLER_BUTTON_DPAD_LEFT,
        SDL_CONTROLLER_BUTTON_DPAD_RIGHT,
        SDL_CONTROLLER_BUTTON_MISC1,
        SDL_CONTROLLER_BUTTON_PADDLE1,
        SDL_CONTROLLER_BUTTON_PADDLE2,
        SDL_CONTROLLER_BUTTON_PADDLE3,
        SDL_CONTROLLER_BUTTON_PADDLE4,
        SDL_CONTROLLER_BUTTON_TOUCHPAD,
        SDL_CONTROLLER_BUTTON_MAX,
    }

    public enum SDL_TouchDeviceType
    {
        SDL_TOUCH_DEVICE_INVALID = -1,
        SDL_TOUCH_DEVICE_DIRECT,
        SDL_TOUCH_DEVICE_INDIRECT_ABSOLUTE,
        SDL_TOUCH_DEVICE_INDIRECT_RELATIVE,
    }

    public partial struct SDL_Finger
    {

        public IntPtr id;

        public float x;

        public float y;

        public float pressure;
    }


    public enum SDL_EventType : uint
    {
        SDL_FIRSTEVENT = 0,
        SDL_QUIT = 0x100,
        SDL_APP_TERMINATING,
        SDL_APP_LOWMEMORY,
        SDL_APP_WILLENTERBACKGROUND,
        SDL_APP_DIDENTERBACKGROUND,
        SDL_APP_WILLENTERFOREGROUND,
        SDL_APP_DIDENTERFOREGROUND,
        SDL_LOCALECHANGED,
        SDL_DISPLAYEVENT = 0x150,
        SDL_WINDOWEVENT = 0x200,
        SDL_SYSWMEVENT,
        SDL_KEYDOWN = 0x300,
        SDL_KEYUP,
        SDL_TEXTEDITING,
        SDL_TEXTINPUT,
        SDL_KEYMAPCHANGED,
        SDL_TEXTEDITING_EXT,
        SDL_MOUSEMOTION = 0x400,
        SDL_MOUSEBUTTONDOWN,
        SDL_MOUSEBUTTONUP,
        SDL_MOUSEWHEEL,
        SDL_JOYAXISMOTION = 0x600,
        SDL_JOYBALLMOTION,
        SDL_JOYHATMOTION,
        SDL_JOYBUTTONDOWN,
        SDL_JOYBUTTONUP,
        SDL_JOYDEVICEADDED,
        SDL_JOYDEVICEREMOVED,
        SDL_JOYBATTERYUPDATED,
        SDL_CONTROLLERAXISMOTION = 0x650,
        SDL_CONTROLLERBUTTONDOWN,
        SDL_CONTROLLERBUTTONUP,
        SDL_CONTROLLERDEVICEADDED,
        SDL_CONTROLLERDEVICEREMOVED,
        SDL_CONTROLLERDEVICEREMAPPED,
        SDL_CONTROLLERTOUCHPADDOWN,
        SDL_CONTROLLERTOUCHPADMOTION,
        SDL_CONTROLLERTOUCHPADUP,
        SDL_CONTROLLERSENSORUPDATE,
        SDL_CONTROLLERUPDATECOMPLETE_RESERVED_FOR_SDL3,
        SDL_CONTROLLERSTEAMHANDLEUPDATED,
        SDL_FINGERDOWN = 0x700,
        SDL_FINGERUP,
        SDL_FINGERMOTION,
        SDL_DOLLARGESTURE = 0x800,
        SDL_DOLLARRECORD,
        SDL_MULTIGESTURE,
        SDL_CLIPBOARDUPDATE = 0x900,
        SDL_DROPFILE = 0x1000,
        SDL_DROPTEXT,
        SDL_DROPBEGIN,
        SDL_DROPCOMPLETE,
        SDL_AUDIODEVICEADDED = 0x1100,
        SDL_AUDIODEVICEREMOVED,
        SDL_SENSORUPDATE = 0x1200,
        SDL_RENDER_TARGETS_RESET = 0x2000,
        SDL_RENDER_DEVICE_RESET,
        SDL_POLLSENTINEL = 0x7F00,
        SDL_USEREVENT = 0x8000,
        SDL_LASTEVENT = 0xFFFF,
    }

    public partial struct SDL_CommonEvent
    {

        public uint type;


        public uint timestamp;
    }

    public partial struct SDL_DisplayEvent
    {

        public uint type;


        public uint timestamp;


        public uint display;


        public byte @event;


        public byte padding1;


        public byte padding2;


        public byte padding3;


        public int data1;
    }

    public partial struct SDL_WindowEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public byte @event;


        public byte padding1;


        public byte padding2;


        public byte padding3;


        public int data1;


        public int data2;
    }

    public partial struct SDL_KeyboardEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public byte state;


        public byte repeat;


        public byte padding2;


        public byte padding3;

        public SDL_Keysym keysym;
    }

    public unsafe partial struct SDL_TextEditingEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public fixed sbyte text[32];


        public int start;


        public int length;
    }

    public unsafe partial struct SDL_TextEditingExtEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public string text;


        public int start;


        public int length;
    }

    public unsafe partial struct SDL_TextInputEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public fixed sbyte text[32];
    }

    public partial struct SDL_MouseMotionEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public uint which;


        public uint state;


        public int x;


        public int y;


        public int xrel;


        public int yrel;
    }

    public partial struct SDL_MouseButtonEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public uint which;


        public byte button;


        public byte state;


        public byte clicks;


        public byte padding1;


        public int x;


        public int y;
    }

    public partial struct SDL_MouseWheelEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public uint which;


        public int x;


        public int y;


        public uint direction;

        public float preciseX;

        public float preciseY;


        public int mouseX;


        public int mouseY;
    }

    public partial struct SDL_JoyAxisEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public byte axis;


        public byte padding1;


        public byte padding2;


        public byte padding3;


        public short value;


        public ushort padding4;
    }

    public partial struct SDL_JoyBallEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public byte ball;


        public byte padding1;


        public byte padding2;


        public byte padding3;


        public short xrel;


        public short yrel;
    }

    public partial struct SDL_JoyHatEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public byte hat;


        public byte value;


        public byte padding1;


        public byte padding2;
    }

    public partial struct SDL_JoyButtonEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public byte button;


        public byte state;


        public byte padding1;


        public byte padding2;
    }

    public partial struct SDL_JoyDeviceEvent
    {

        public uint type;


        public uint timestamp;


        public int which;
    }

    public partial struct SDL_JoyBatteryEvent
    {

        public uint type;


        public uint timestamp;


        public int which;

        public SDL_JoystickPowerLevel level;
    }

    public partial struct SDL_ControllerAxisEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public byte axis;


        public byte padding1;


        public byte padding2;


        public byte padding3;


        public short value;


        public ushort padding4;
    }

    public partial struct SDL_ControllerButtonEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public byte button;


        public byte state;


        public byte padding1;


        public byte padding2;
    }

    public partial struct SDL_ControllerDeviceEvent
    {

        public uint type;


        public uint timestamp;


        public int which;
    }

    public partial struct SDL_ControllerTouchpadEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public int touchpad;


        public int finger;

        public float x;

        public float y;

        public float pressure;
    }

    public unsafe partial struct SDL_ControllerSensorEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public int sensor;


        public fixed float data[3];


        public UIntPtr timestamp_us;
    }

    public partial struct SDL_AudioDeviceEvent
    {

        public uint type;


        public uint timestamp;


        public uint which;


        public byte iscapture;


        public byte padding1;


        public byte padding2;


        public byte padding3;
    }

    public partial struct SDL_TouchFingerEvent
    {

        public uint type;


        public uint timestamp;


        public IntPtr touchId;


        public IntPtr fingerId;

        public float x;

        public float y;

        public float dx;

        public float dy;

        public float pressure;


        public uint windowID;
    }

    public partial struct SDL_MultiGestureEvent
    {

        public uint type;


        public uint timestamp;


        public IntPtr touchId;

        public float dTheta;

        public float dDist;

        public float x;

        public float y;


        public ushort numFingers;


        public ushort padding;
    }

    public partial struct SDL_DollarGestureEvent
    {

        public uint type;


        public uint timestamp;


        public IntPtr touchId;


        public IntPtr gestureId;


        public uint numFingers;

        public float error;

        public float x;

        public float y;
    }

    public unsafe partial struct SDL_DropEvent
    {

        public uint type;


        public uint timestamp;


        public string file;


        public uint windowID;
    }

    public unsafe partial struct SDL_SensorEvent
    {

        public uint type;


        public uint timestamp;


        public int which;


        public fixed float data[6];


        public UIntPtr timestamp_us;
    }

    public partial struct SDL_QuitEvent
    {

        public uint type;


        public uint timestamp;
    }

    public unsafe partial struct SDL_UserEvent
    {

        public uint type;


        public uint timestamp;


        public uint windowID;


        public int code;

        public void* data1;

        public void* data2;
    }

    public partial struct SDL_SysWMmsg
    {
    }

    public unsafe partial struct SDL_SysWMEvent
    {

        public uint type;


        public uint timestamp;

        public SDL_SysWMmsg* msg;
    }

    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SDL_Event
    {
        [FieldOffset(0)]

        public uint type;

        [FieldOffset(0)]
        public SDL_CommonEvent common;

        [FieldOffset(0)]
        public SDL_DisplayEvent display;

        [FieldOffset(0)]
        public SDL_WindowEvent window;

        [FieldOffset(0)]
        public SDL_KeyboardEvent key;

        [FieldOffset(0)]
        public SDL_TextEditingEvent edit;

        [FieldOffset(0)]
        public SDL_TextEditingExtEvent editExt;

        [FieldOffset(0)]
        public SDL_TextInputEvent text;

        [FieldOffset(0)]
        public SDL_MouseMotionEvent motion;

        [FieldOffset(0)]
        public SDL_MouseButtonEvent button;

        [FieldOffset(0)]
        public SDL_MouseWheelEvent wheel;

        [FieldOffset(0)]
        public SDL_JoyAxisEvent jaxis;

        [FieldOffset(0)]
        public SDL_JoyBallEvent jball;

        [FieldOffset(0)]
        public SDL_JoyHatEvent jhat;

        [FieldOffset(0)]
        public SDL_JoyButtonEvent jbutton;

        [FieldOffset(0)]
        public SDL_JoyDeviceEvent jdevice;

        [FieldOffset(0)]
        public SDL_JoyBatteryEvent jbattery;

        [FieldOffset(0)]
        public SDL_ControllerAxisEvent caxis;

        [FieldOffset(0)]
        public SDL_ControllerButtonEvent cbutton;

        [FieldOffset(0)]
        public SDL_ControllerDeviceEvent cdevice;

        [FieldOffset(0)]
        public SDL_ControllerTouchpadEvent ctouchpad;

        [FieldOffset(0)]
        public SDL_ControllerSensorEvent csensor;

        [FieldOffset(0)]
        public SDL_AudioDeviceEvent adevice;

        [FieldOffset(0)]
        public SDL_SensorEvent sensor;

        [FieldOffset(0)]
        public SDL_QuitEvent quit;

        [FieldOffset(0)]
        public SDL_UserEvent user;

        [FieldOffset(0)]
        public SDL_SysWMEvent syswm;

        [FieldOffset(0)]
        public SDL_TouchFingerEvent tfinger;

        [FieldOffset(0)]
        public SDL_MultiGestureEvent mgesture;

        [FieldOffset(0)]
        public SDL_DollarGestureEvent dgesture;

        [FieldOffset(0)]
        public SDL_DropEvent drop;

        [FieldOffset(0)]

        public fixed byte padding[56];
    }


    public enum SDL_eventaction : uint
    {
        SDL_ADDEVENT,
        SDL_PEEKEVENT,
        SDL_GETEVENT,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int SDL_EventFilter(void* userdata, SDL_Event* @event);

    public partial struct _SDL_Haptic
    {
    }

    public unsafe partial struct SDL_HapticDirection
    {

        public byte type;


        public fixed int dir[3];
    }

    public partial struct SDL_HapticConstant
    {

        public ushort type;

        public SDL_HapticDirection direction;


        public uint length;


        public ushort delay;


        public ushort button;


        public ushort interval;


        public short level;


        public ushort attack_length;


        public ushort attack_level;


        public ushort fade_length;


        public ushort fade_level;
    }

    public partial struct SDL_HapticPeriodic
    {

        public ushort type;

        public SDL_HapticDirection direction;


        public uint length;


        public ushort delay;


        public ushort button;


        public ushort interval;


        public ushort period;


        public short magnitude;


        public short offset;


        public ushort phase;


        public ushort attack_length;


        public ushort attack_level;


        public ushort fade_length;


        public ushort fade_level;
    }

    public unsafe partial struct SDL_HapticCondition
    {

        public ushort type;

        public SDL_HapticDirection direction;


        public uint length;


        public ushort delay;


        public ushort button;


        public ushort interval;


        public fixed ushort right_sat[3];


        public fixed ushort left_sat[3];


        public fixed short right_coeff[3];


        public fixed short left_coeff[3];


        public fixed ushort deadband[3];


        public fixed short center[3];
    }

    public partial struct SDL_HapticRamp
    {

        public ushort type;

        public SDL_HapticDirection direction;


        public uint length;


        public ushort delay;


        public ushort button;


        public ushort interval;


        public short start;


        public short end;


        public ushort attack_length;


        public ushort attack_level;


        public ushort fade_length;


        public ushort fade_level;
    }

    public partial struct SDL_HapticLeftRight
    {

        public ushort type;


        public uint length;


        public ushort large_magnitude;


        public ushort small_magnitude;
    }

    public unsafe partial struct SDL_HapticCustom
    {

        public ushort type;

        public SDL_HapticDirection direction;


        public uint length;


        public ushort delay;


        public ushort button;


        public ushort interval;


        public byte channels;


        public ushort period;


        public ushort samples;


        public ushort* data;


        public ushort attack_length;


        public ushort attack_level;


        public ushort fade_length;


        public ushort fade_level;
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_HapticEffect
    {
        [FieldOffset(0)]

        public ushort type;

        [FieldOffset(0)]
        public SDL_HapticConstant constant;

        [FieldOffset(0)]
        public SDL_HapticPeriodic periodic;

        [FieldOffset(0)]
        public SDL_HapticCondition condition;

        [FieldOffset(0)]
        public SDL_HapticRamp ramp;

        [FieldOffset(0)]
        public SDL_HapticLeftRight leftright;

        [FieldOffset(0)]
        public SDL_HapticCustom custom;
    }


    public enum SDL_HintPriority : uint
    {
        SDL_HINT_DEFAULT,
        SDL_HINT_NORMAL,
        SDL_HINT_OVERRIDE,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_HintCallback(void* userdata, string name, string oldValue, string newValue);


    public enum SDL_LogCategory : uint
    {
        SDL_LOG_CATEGORY_APPLICATION,
        SDL_LOG_CATEGORY_ERROR,
        SDL_LOG_CATEGORY_ASSERT,
        SDL_LOG_CATEGORY_SYSTEM,
        SDL_LOG_CATEGORY_AUDIO,
        SDL_LOG_CATEGORY_VIDEO,
        SDL_LOG_CATEGORY_RENDER,
        SDL_LOG_CATEGORY_INPUT,
        SDL_LOG_CATEGORY_TEST,
        SDL_LOG_CATEGORY_RESERVED1,
        SDL_LOG_CATEGORY_RESERVED2,
        SDL_LOG_CATEGORY_RESERVED3,
        SDL_LOG_CATEGORY_RESERVED4,
        SDL_LOG_CATEGORY_RESERVED5,
        SDL_LOG_CATEGORY_RESERVED6,
        SDL_LOG_CATEGORY_RESERVED7,
        SDL_LOG_CATEGORY_RESERVED8,
        SDL_LOG_CATEGORY_RESERVED9,
        SDL_LOG_CATEGORY_RESERVED10,
        SDL_LOG_CATEGORY_CUSTOM,
    }


    public enum SDL_LogPriority : uint
    {
        SDL_LOG_PRIORITY_VERBOSE = 1,
        SDL_LOG_PRIORITY_DEBUG,
        SDL_LOG_PRIORITY_INFO,
        SDL_LOG_PRIORITY_WARN,
        SDL_LOG_PRIORITY_ERROR,
        SDL_LOG_PRIORITY_CRITICAL,
        SDL_NUM_LOG_PRIORITIES,
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void SDL_LogOutputFunction(void* userdata, int category, SDL_LogPriority priority, string message);


    public enum SDL_MessageBoxFlags : uint
    {
        SDL_MESSAGEBOX_ERROR = 0x00000010,
        SDL_MESSAGEBOX_WARNING = 0x00000020,
        SDL_MESSAGEBOX_INFORMATION = 0x00000040,
        SDL_MESSAGEBOX_BUTTONS_LEFT_TO_RIGHT = 0x00000080,
        SDL_MESSAGEBOX_BUTTONS_RIGHT_TO_LEFT = 0x00000100,
    }


    public enum SDL_MessageBoxButtonFlags : uint
    {
        SDL_MESSAGEBOX_BUTTON_RETURNKEY_DEFAULT = 0x00000001,
        SDL_MESSAGEBOX_BUTTON_ESCAPEKEY_DEFAULT = 0x00000002,
    }

    public unsafe partial struct SDL_MessageBoxButtonData
    {

        public uint flags;

        public int buttonid;


        public string text;
    }

    public partial struct SDL_MessageBoxColor
    {

        public byte r;


        public byte g;


        public byte b;
    }


    public enum SDL_MessageBoxColorType : uint
    {
        SDL_MESSAGEBOX_COLOR_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_TEXT,
        SDL_MESSAGEBOX_COLOR_BUTTON_BORDER,
        SDL_MESSAGEBOX_COLOR_BUTTON_BACKGROUND,
        SDL_MESSAGEBOX_COLOR_BUTTON_SELECTED,
        SDL_MESSAGEBOX_COLOR_MAX,
    }

    public partial struct SDL_MessageBoxColorScheme
    {

        public _colors_e__FixedBuffer colors;

        public partial struct _colors_e__FixedBuffer
        {
            public SDL_MessageBoxColor e0;
            public SDL_MessageBoxColor e1;
            public SDL_MessageBoxColor e2;
            public SDL_MessageBoxColor e3;
            public SDL_MessageBoxColor e4;

            public unsafe ref SDL_MessageBoxColor this[int index]
            {
                get
                {
                    fixed (SDL_MessageBoxColor* pThis = &e0)
                    {
                        return ref pThis[index];
                    }
                }
            }
        }
    }

    public unsafe partial struct SDL_MessageBoxData
    {

        public uint flags;

        public SDL_Window* window;


        public string title;


        public string message;

        public int numbuttons;


        public SDL_MessageBoxButtonData* buttons;


        public SDL_MessageBoxColorScheme* colorScheme;
    }


    public enum SDL_PowerState : uint
    {
        SDL_POWERSTATE_UNKNOWN,
        SDL_POWERSTATE_ON_BATTERY,
        SDL_POWERSTATE_NO_BATTERY,
        SDL_POWERSTATE_CHARGING,
        SDL_POWERSTATE_CHARGED,
    }


    public enum SDL_RendererFlags : uint
    {
        SDL_RENDERER_SOFTWARE = 0x00000001,
        SDL_RENDERER_ACCELERATED = 0x00000002,
        SDL_RENDERER_PRESENTVSYNC = 0x00000004,
        SDL_RENDERER_TARGETTEXTURE = 0x00000008,
    }

    public unsafe partial struct SDL_RendererInfo
    {

        public string name;


        public uint flags;


        public uint num_texture_formats;


        public fixed uint texture_formats[16];

        public int max_texture_width;

        public int max_texture_height;
    }

    public partial struct SDL_Vertex
    {
        public SDL_FPoint position;

        public SDL_Color color;

        public SDL_FPoint tex_coord;
    }


    public enum SDL_ScaleMode : uint
    {
        SDL_ScaleModeNearest,
        SDL_ScaleModeLinear,
        SDL_ScaleModeBest,
    }


    public enum SDL_TextureAccess : uint
    {
        SDL_TEXTUREACCESS_STATIC,
        SDL_TEXTUREACCESS_STREAMING,
        SDL_TEXTUREACCESS_TARGET,
    }


    public enum SDL_TextureModulate : uint
    {
        SDL_TEXTUREMODULATE_NONE = 0x00000000,
        SDL_TEXTUREMODULATE_COLOR = 0x00000001,
        SDL_TEXTUREMODULATE_ALPHA = 0x00000002,
    }


    public enum SDL_RendererFlip : uint
    {
        SDL_FLIP_NONE = 0x00000000,
        SDL_FLIP_HORIZONTAL = 0x00000001,
        SDL_FLIP_VERTICAL = 0x00000002,
    }

    public partial struct SDL_Renderer
    {
    }

    public partial struct SDL_Texture
    {
    }


    public enum WindowShapeMode : uint
    {
        ShapeModeDefault,
        ShapeModeBinarizeAlpha,
        ShapeModeReverseBinarizeAlpha,
        ShapeModeColorKey,
    }

    [StructLayout(LayoutKind.Explicit)]
    public partial struct SDL_WindowShapeParams
    {
        [FieldOffset(0)]

        public byte binarizationCutoff;

        [FieldOffset(0)]
        public SDL_Color colorKey;
    }

    public partial struct SDL_WindowShapeMode
    {
        public WindowShapeMode mode;

        public SDL_WindowShapeParams parameters;
    }

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]

    public unsafe delegate uint SDL_TimerCallback(uint interval, void* param1);

    public partial struct SDL_version
    {

        public byte major;


        public byte minor;


        public byte patch;
    }

    public static unsafe partial class Methods
    {
        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetPlatform();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_malloc(UIntPtr size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_calloc(UIntPtr nmemb, UIntPtr size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_realloc(void* mem, UIntPtr size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_free(void* mem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetOriginalMemoryFunctions(IntPtr* malloc_func, IntPtr* calloc_func, IntPtr* realloc_func, IntPtr* free_func);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetMemoryFunctions(IntPtr* malloc_func, IntPtr* calloc_func, IntPtr* realloc_func, IntPtr* free_func);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetMemoryFunctions(IntPtr malloc_func, IntPtr calloc_func, IntPtr realloc_func, IntPtr free_func);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumAllocations();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_getenv(string name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_setenv(string name, string value, int overwrite);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_qsort(void* @base, UIntPtr nmemb, UIntPtr size, IntPtr compare);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_bsearch(void* key, void* @base, UIntPtr nmemb, UIntPtr size, IntPtr compare);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_abs(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isalpha(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isalnum(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isblank(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_iscntrl(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isdigit(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isxdigit(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ispunct(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isspace(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isupper(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_islower(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isprint(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_isgraph(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_toupper(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_tolower(int x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_crc16(ushort crc, void* data, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_crc32(uint crc, void* data, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memset(void* dst, int c, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memcpy(void* dst, void* src, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_memmove(void* dst, void* src, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_memcmp(void* s1, void* s2, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_wcslen(int* wstr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_wcslcpy(int* dst, int* src, UIntPtr maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_wcslcat(int* dst, int* src, UIntPtr maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int* SDL_wcsdup(int* wstr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int* SDL_wcsstr(int* haystack, int* needle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcscmp(int* str1, int* str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcsncmp(int* str1, int* str2, UIntPtr maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcscasecmp(int* str1, int* str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_wcsncasecmp(int* str1, int* str2, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_strlen(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_strlcpy(string dst, string src, UIntPtr maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_utf8strlcpy(string dst, string src, UIntPtr dst_bytes);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_strlcat(string dst, string src, UIntPtr maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strdup(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strrev(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strupr(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strlwr(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strchr(string str, int c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strrchr(string str, int c);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strstr(string haystack, string needle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strcasestr(string haystack, string needle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_strtokr(string s1, string s2, string* saveptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_utf8strlen(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_utf8strnlen(string str, UIntPtr bytes);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_itoa(int value, string str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_uitoa(uint value, string str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_ltoa(IntPtr value, string str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_ultoa(UIntPtr value, string str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_lltoa(IntPtr value, string str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_ulltoa(UIntPtr value, string str, int radix);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_atoi(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atof(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_strtol(string str, string* endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_strtoul(string str, string* endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_strtoll(string str, string* endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_strtoull(string str, string* endp, int @base);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_strtod(string str, string* endp);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strcmp(string str1, string str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strncmp(string str1, string str2, UIntPtr maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strcasecmp(string str1, string str2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_strncasecmp(string str1, string str2, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_sscanf(string text, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_snprintf(string text, UIntPtr maxlen, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_asprintf(string* strp, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_acos(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_acosf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_asin(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_asinf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atan(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_atanf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_atan2(double y, double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_atan2f(float y, float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_ceil(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_ceilf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_copysign(double x, double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_copysignf(float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_cos(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_cosf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_exp(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_expf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_fabs(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_fabsf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_floor(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_floorf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_trunc(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_truncf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_fmod(double x, double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_fmodf(float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_log(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_logf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_log10(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_log10f(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_pow(double x, double y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_powf(float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_round(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_roundf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_lround(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_lroundf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_scalbn(double x, int n);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_scalbnf(float x, int n);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_sin(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_sinf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_sqrt(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_sqrtf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double SDL_tan(double x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_tanf(float x);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_iconv_t* SDL_iconv_open(string tocode, string fromcode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_iconv_close(_SDL_iconv_t* cd);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_iconv(_SDL_iconv_t* cd, string* inbuf, UIntPtr* inbytesleft, string* outbuf, UIntPtr* outbytesleft);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_iconv_string(string tocode, string fromcode, string inbuf, UIntPtr inbytesleft);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_main(int argc, string* argv);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetMainReady();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AssertState SDL_ReportAssertion(SDL_AssertData* param0, string param1, string param2, int param3);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetAssertionHandler(IntPtr handler, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_GetDefaultAssertionHandler();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_GetAssertionHandler(void** puserdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern SDL_AssertData* SDL_GetAssertionReport();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ResetAssertionReport();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetError(string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetError();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetErrorMsg(string errstr, int maxlen);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ClearError();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_Error(SDL_errorcode code);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_mutex* SDL_CreateMutex();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LockMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_TryLockMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UnlockMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyMutex(SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern SDL_semaphore* SDL_CreateSemaphore(uint initial_value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroySemaphore(SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SemWait(SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SemTryWait(SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SemWaitTimeout(SDL_semaphore* sem, uint timeout);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SemPost(SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_SemValue(SDL_semaphore* sem);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_cond* SDL_CreateCond();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyCond(SDL_cond* cond);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CondSignal(SDL_cond* cond);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CondBroadcast(SDL_cond* cond);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CondWait(SDL_cond* cond, SDL_mutex* mutex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CondWaitTimeout(SDL_cond* cond, SDL_mutex* mutex, uint ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Thread* SDL_CreateThread(IntPtr fn, string name, void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Thread* SDL_CreateThreadWithStackSize(IntPtr fn, string name, UIntPtr stacksize, void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetThreadName(SDL_Thread* thread);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_ThreadID();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_GetThreadID(SDL_Thread* thread);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetThreadPriority(SDL_ThreadPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_WaitThread(SDL_Thread* thread, int* status);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DetachThread(SDL_Thread* thread);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_TLSCreate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_TLSGet(uint id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_TLSSet(uint id, void* value, IntPtr destructor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_TLSCleanup();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_RWops* SDL_RWFromFile(string file, string mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_RWops* SDL_RWFromFP(void* fp, SDL_bool autoclose);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_RWops* SDL_RWFromMem(void* mem, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_RWops* SDL_RWFromConstMem(void* mem, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_RWops* SDL_AllocRW();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FreeRW(SDL_RWops* area);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_RWsize(SDL_RWops* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_RWseek(SDL_RWops* context, IntPtr offset, int whence);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_RWtell(SDL_RWops* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_RWread(SDL_RWops* context, void* ptr, UIntPtr size, UIntPtr maxnum);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_RWwrite(SDL_RWops* context, void* ptr, UIntPtr size, UIntPtr num);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RWclose(SDL_RWops* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_LoadFile_RW(SDL_RWops* src, UIntPtr* datasize, int freesrc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_LoadFile(string file, UIntPtr* datasize);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte SDL_ReadU8(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_ReadLE16(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_ReadBE16(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_ReadLE32(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_ReadBE32(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_ReadLE64(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_ReadBE64(SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_WriteU8(SDL_RWops* dst, byte value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_WriteLE16(SDL_RWops* dst, ushort value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_WriteBE16(SDL_RWops* dst, ushort value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_WriteLE32(SDL_RWops* dst, uint value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_WriteBE32(SDL_RWops* dst, uint value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_WriteLE64(SDL_RWops* dst, UIntPtr value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_WriteBE64(SDL_RWops* dst, UIntPtr value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumAudioDrivers();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetAudioDriver(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AudioInit(string driver_name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_AudioQuit();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetCurrentAudioDriver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_OpenAudio(SDL_AudioSpec* desired, SDL_AudioSpec* obtained);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumAudioDevices(int iscapture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetAudioDeviceName(int index, int iscapture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetAudioDeviceSpec(int index, int iscapture, SDL_AudioSpec* spec);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDefaultAudioInfo(string* name, SDL_AudioSpec* spec, int iscapture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_OpenAudioDevice(string device, int iscapture, SDL_AudioSpec* desired, SDL_AudioSpec* obtained, int allowed_changes);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioStatus SDL_GetAudioStatus();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioStatus SDL_GetAudioDeviceStatus(uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PauseAudio(int pause_on);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PauseAudioDevice(uint dev, int pause_on);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_AudioSpec* SDL_LoadWAV_RW(SDL_RWops* src, int freesrc, SDL_AudioSpec* spec, byte** audio_buf, uint* audio_len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FreeWAV(byte* audio_buf);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_BuildAudioCVT(SDL_AudioCVT* cvt, ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ConvertAudio(SDL_AudioCVT* cvt);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_AudioStream* SDL_NewAudioStream(ushort src_format, byte src_channels, int src_rate, ushort dst_format, byte dst_channels, int dst_rate);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AudioStreamPut(_SDL_AudioStream* stream, void* buf, int len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AudioStreamGet(_SDL_AudioStream* stream, void* buf, int len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AudioStreamAvailable(_SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_AudioStreamFlush(_SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_AudioStreamClear(_SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FreeAudioStream(_SDL_AudioStream* stream);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MixAudio(byte* dst, byte* src, uint len, int volume);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MixAudioFormat(byte* dst, byte* src, ushort format, uint len, int volume);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_QueueAudio(uint dev, void* data, uint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_DequeueAudio(uint dev, void* data, uint len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetQueuedAudioSize(uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ClearQueuedAudio(uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockAudio();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockAudioDevice(uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockAudio();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockAudioDevice(uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseAudio();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CloseAudioDevice(uint dev);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetClipboardText(string text);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetClipboardText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasClipboardText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetPrimarySelectionText(string text);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetPrimarySelectionText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasPrimarySelectionText();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetCPUCount();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetCPUCacheLineSize();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasRDTSC();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasAltiVec();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasMMX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_Has3DNow();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasSSE();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasSSE2();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasSSE3();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasSSE41();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasSSE42();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasAVX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasAVX2();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasAVX512F();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasARMSIMD();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasNEON();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasLSX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasLASX();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSystemRAM();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_SIMDGetAlignment();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_SIMDAlloc(UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_SIMDRealloc(void* mem, UIntPtr len);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SIMDFree(void* ptr);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetPixelFormatName(uint format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_PixelFormatEnumToMasks(uint format, int* bpp, uint* Rmask, uint* Gmask, uint* Bmask, uint* Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_MasksToPixelFormatEnum(int bpp, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PixelFormat* SDL_AllocFormat(uint pixel_format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FreeFormat(SDL_PixelFormat* format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Palette* SDL_AllocPalette(int ncolors);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetPixelFormatPalette(SDL_PixelFormat* format, SDL_Palette* palette);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetPaletteColors(SDL_Palette* palette, SDL_Color* colors, int firstcolor, int ncolors);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FreePalette(SDL_Palette* palette);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_MapRGB(SDL_PixelFormat* format, byte r, byte g, byte b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_MapRGBA(SDL_PixelFormat* format, byte r, byte g, byte b, byte a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetRGB(uint pixel, SDL_PixelFormat* format, byte* r, byte* g, byte* b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetRGBA(uint pixel, SDL_PixelFormat* format, byte* r, byte* g, byte* b, byte* a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_CalculateGammaRamp(float gamma, ushort* ramp);

        public static SDL_bool SDL_PointInRect(SDL_Point* p, SDL_Rect* r)
        {
            return ((p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? SDL_TRUE : SDL_FALSE;
        }

        public static SDL_bool SDL_RectEmpty(SDL_Rect* r)
        {
            return ((r == null) || (r->w <= 0) || (r->h <= 0)) ? SDL_TRUE : SDL_FALSE;
        }

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasIntersection(SDL_Rect* A, SDL_Rect* B);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IntersectRect(SDL_Rect* A, SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnionRect(SDL_Rect* A, SDL_Rect* B, SDL_Rect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_EnclosePoints(SDL_Point* points, int count, SDL_Rect* clip, SDL_Rect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IntersectRectAndLine(SDL_Rect* rect, int* X1, int* Y1, int* X2, int* Y2);

        public static SDL_bool SDL_PointInFRect(SDL_FPoint* p, SDL_FRect* r)
        {
            return ((p->x >= r->x) && (p->x < (r->x + r->w)) && (p->y >= r->y) && (p->y < (r->y + r->h))) ? SDL_TRUE : SDL_FALSE;
        }

        public static SDL_bool SDL_FRectEmpty(SDL_FRect* r)
        {
            return ((r == null) || (r->w <= 0.0f) || (r->h <= 0.0f)) ? SDL_TRUE : SDL_FALSE;
        }

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasIntersectionF(SDL_FRect* A, SDL_FRect* B);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IntersectFRect(SDL_FRect* A, SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnionFRect(SDL_FRect* A, SDL_FRect* B, SDL_FRect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_EncloseFPoints(SDL_FPoint* points, int count, SDL_FRect* clip, SDL_FRect* result);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IntersectFRectAndLine(SDL_FRect* rect, float* X1, float* Y1, float* X2, float* Y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_BlendMode SDL_ComposeCustomBlendMode(SDL_BlendFactor srcColorFactor, SDL_BlendFactor dstColorFactor, SDL_BlendOperation colorOperation, SDL_BlendFactor srcAlphaFactor, SDL_BlendFactor dstAlphaFactor, SDL_BlendOperation alphaOperation);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateRGBSurface(uint flags, int width, int height, int depth, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateRGBSurfaceWithFormat(uint flags, int width, int height, int depth, uint format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateRGBSurfaceFrom(void* pixels, int width, int height, int depth, int pitch, uint Rmask, uint Gmask, uint Bmask, uint Amask);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_CreateRGBSurfaceWithFormatFrom(void* pixels, int width, int height, int depth, int pitch, uint format);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FreeSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetSurfacePalette(SDL_Surface* surface, SDL_Palette* palette);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LockSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_LoadBMP_RW(SDL_RWops* src, int freesrc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SaveBMP_RW(SDL_Surface* surface, SDL_RWops* dst, int freedst);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetSurfaceRLE(SDL_Surface* surface, int flag);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasSurfaceRLE(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetColorKey(SDL_Surface* surface, int flag, uint key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasColorKey(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetColorKey(SDL_Surface* surface, uint* key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetSurfaceColorMod(SDL_Surface* surface, byte r, byte g, byte b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSurfaceColorMod(SDL_Surface* surface, byte* r, byte* g, byte* b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetSurfaceAlphaMod(SDL_Surface* surface, byte alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSurfaceAlphaMod(SDL_Surface* surface, byte* alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetSurfaceBlendMode(SDL_Surface* surface, SDL_BlendMode* blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetClipRect(SDL_Surface* surface, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetClipRect(SDL_Surface* surface, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_DuplicateSurface(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ConvertSurface(SDL_Surface* src, SDL_PixelFormat* fmt, uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_ConvertSurfaceFormat(SDL_Surface* src, uint pixel_format, uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ConvertPixels(int width, int height, uint src_format, void* src, int src_pitch, uint dst_format, void* dst, int dst_pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_PremultiplyAlpha(int width, int height, uint src_format, void* src, int src_pitch, uint dst_format, void* dst, int dst_pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_FillRect(SDL_Surface* dst, SDL_Rect* rect, uint color);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_FillRects(SDL_Surface* dst, SDL_Rect* rects, int count, uint color);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpperBlit(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LowerBlit(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SoftStretch(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SoftStretchLinear(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpperBlitScaled(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LowerBlitScaled(SDL_Surface* src, SDL_Rect* srcrect, SDL_Surface* dst, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetYUVConversionMode(SDL_YUV_CONVERSION_MODE mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_YUV_CONVERSION_MODE SDL_GetYUVConversionMode();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_YUV_CONVERSION_MODE SDL_GetYUVConversionModeForResolution(int width, int height);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumVideoDrivers();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetVideoDriver(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_VideoInit(string driver_name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_VideoQuit();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetCurrentVideoDriver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumVideoDisplays();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetDisplayName(int displayIndex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDisplayBounds(int displayIndex, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDisplayUsableBounds(int displayIndex, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDisplayDPI(int displayIndex, float* ddpi, float* hdpi, float* vdpi);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_DisplayOrientation SDL_GetDisplayOrientation(int displayIndex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumDisplayModes(int displayIndex);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDisplayMode(int displayIndex, int modeIndex, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetDesktopDisplayMode(int displayIndex, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetCurrentDisplayMode(int displayIndex, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_DisplayMode* SDL_GetClosestDisplayMode(int displayIndex, SDL_DisplayMode* mode, SDL_DisplayMode* closest);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetPointDisplayIndex(SDL_Point* point);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRectDisplayIndex(SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetWindowDisplayIndex(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowDisplayMode(SDL_Window* window, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetWindowDisplayMode(SDL_Window* window, SDL_DisplayMode* mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetWindowICCProfile(SDL_Window* window, UIntPtr* size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetWindowPixelFormat(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_CreateWindow(string title, int x, int y, int w, int h, uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_CreateWindowFrom(void* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetWindowID(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetWindowFromID(uint id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetWindowFlags(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowTitle(SDL_Window* window, string title);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetWindowTitle(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowIcon(SDL_Window* window, SDL_Surface* icon);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_SetWindowData(SDL_Window* window, string name, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetWindowData(SDL_Window* window, string name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowPosition(SDL_Window* window, int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetWindowPosition(SDL_Window* window, int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowSize(SDL_Window* window, int w, int h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetWindowSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetWindowBordersSize(SDL_Window* window, int* top, int* left, int* bottom, int* right);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetWindowSizeInPixels(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowMinimumSize(SDL_Window* window, int min_w, int min_h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetWindowMinimumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowMaximumSize(SDL_Window* window, int max_w, int max_h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetWindowMaximumSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowBordered(SDL_Window* window, SDL_bool bordered);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowResizable(SDL_Window* window, SDL_bool resizable);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowAlwaysOnTop(SDL_Window* window, SDL_bool on_top);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ShowWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_HideWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RaiseWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MaximizeWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_MinimizeWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RestoreWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowFullscreen(SDL_Window* window, uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasWindowSurface(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Surface* SDL_GetWindowSurface(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateWindowSurface(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateWindowSurfaceRects(SDL_Window* window, SDL_Rect* rects, int numrects);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_DestroyWindowSurface(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowGrab(SDL_Window* window, SDL_bool grabbed);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowKeyboardGrab(SDL_Window* window, SDL_bool grabbed);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetWindowMouseGrab(SDL_Window* window, SDL_bool grabbed);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetWindowGrab(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetWindowKeyboardGrab(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetWindowMouseGrab(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetGrabbedWindow();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowMouseRect(SDL_Window* window, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern SDL_Rect* SDL_GetWindowMouseRect(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowBrightness(SDL_Window* window, float brightness);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GetWindowBrightness(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowOpacity(SDL_Window* window, float opacity);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetWindowOpacity(SDL_Window* window, float* out_opacity);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowModalFor(SDL_Window* modal_window, SDL_Window* parent_window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowInputFocus(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowGammaRamp(SDL_Window* window, ushort* red, ushort* green, ushort* blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetWindowGammaRamp(SDL_Window* window, ushort* red, ushort* green, ushort* blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowHitTest(SDL_Window* window, IntPtr callback, void* callback_data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_FlashWindow(SDL_Window* window, SDL_FlashOperation operation);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsScreenSaverEnabled();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_EnableScreenSaver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DisableScreenSaver();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_LoadLibrary(string path);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GL_GetProcAddress(string proc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GL_UnloadLibrary();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GL_ExtensionSupported(string extension);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GL_ResetAttributes();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_SetAttribute(SDL_GLattr attr, int value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_GetAttribute(SDL_GLattr attr, int* value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern void* SDL_GL_CreateContext(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_MakeCurrent(SDL_Window* window, void* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GL_GetCurrentWindow();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern void* SDL_GL_GetCurrentContext();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GL_GetDrawableSize(SDL_Window* window, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_SetSwapInterval(int interval);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_GetSwapInterval();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GL_SwapWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GL_DeleteContext(void* context);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetKeyboardFocus();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte* SDL_GetKeyboardState(int* numkeys);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ResetKeyboard();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Keymod SDL_GetModState();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetModState(SDL_Keymod modstate);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int SDL_GetKeyFromScancode(SDL_Scancode scancode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Scancode SDL_GetScancodeFromKey(int key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetScancodeName(SDL_Scancode scancode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Scancode SDL_GetScancodeFromName(string name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetKeyName(int key);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int SDL_GetKeyFromName(string name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_StartTextInput();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsTextInputActive();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_StopTextInput();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ClearComposition();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsTextInputShown();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetTextInputRect(SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasScreenKeyboardSupport();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsScreenKeyboardShown(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_GetMouseFocus();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetMouseState(int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetGlobalMouseState(int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetRelativeMouseState(int* x, int* y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_WarpMouseInWindow(SDL_Window* window, int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WarpMouseGlobal(int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRelativeMouseMode(SDL_bool enabled);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CaptureMouse(SDL_bool enabled);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetRelativeMouseMode();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_CreateCursor(byte* data, byte* mask, int w, int h, int hot_x, int hot_y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_CreateColorCursor(SDL_Surface* surface, int hot_x, int hot_y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_CreateSystemCursor(SDL_SystemCursor id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetCursor(SDL_Cursor* cursor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_GetCursor();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Cursor* SDL_GetDefaultCursor();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FreeCursor(SDL_Cursor* cursor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ShowCursor(int toggle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GUIDToString(SDL_GUID guid, string pszGUID, int cbGUID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GUID SDL_GUIDFromString(string pchGUID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockJoysticks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockJoysticks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_NumJoysticks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_JoystickNameForIndex(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_JoystickPathForIndex(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickGetDevicePlayerIndex(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern SDL_GUID SDL_JoystickGetDeviceGUID(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_JoystickGetDeviceVendor(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_JoystickGetDeviceProduct(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_JoystickGetDeviceProductVersion(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickType SDL_JoystickGetDeviceType(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int SDL_JoystickGetDeviceInstanceID(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Joystick* SDL_JoystickOpen(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Joystick* SDL_JoystickFromInstanceID(int instance_id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Joystick* SDL_JoystickFromPlayerIndex(int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickAttachVirtual(SDL_JoystickType type, int naxes, int nbuttons, int nhats);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickAttachVirtualEx(SDL_VirtualJoystickDesc* desc);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickDetachVirtual(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickIsVirtual(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickSetVirtualAxis(_SDL_Joystick* joystick, int axis, short value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickSetVirtualButton(_SDL_Joystick* joystick, int button, byte value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickSetVirtualHat(_SDL_Joystick* joystick, int hat, byte value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_JoystickName(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_JoystickPath(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickGetPlayerIndex(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_JoystickSetPlayerIndex(_SDL_Joystick* joystick, int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern SDL_GUID SDL_JoystickGetGUID(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_JoystickGetVendor(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_JoystickGetProduct(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_JoystickGetProductVersion(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_JoystickGetFirmwareVersion(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_JoystickGetSerial(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickType SDL_JoystickGetType(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_JoystickGetGUIDString(SDL_GUID guid, string pszGUID, int cbGUID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern SDL_GUID SDL_JoystickGetGUIDFromString(string pchGUID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetJoystickGUIDInfo(SDL_GUID guid, ushort* vendor, ushort* product, ushort* version, ushort* crc16);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickGetAttached(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int SDL_JoystickInstanceID(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickNumAxes(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickNumBalls(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickNumHats(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickNumButtons(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_JoystickUpdate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickEventState(int state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern short SDL_JoystickGetAxis(_SDL_Joystick* joystick, int axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickGetAxisInitialState(_SDL_Joystick* joystick, int axis, short* state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte SDL_JoystickGetHat(_SDL_Joystick* joystick, int hat);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickGetBall(_SDL_Joystick* joystick, int ball, int* dx, int* dy);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte SDL_JoystickGetButton(_SDL_Joystick* joystick, int button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickRumble(_SDL_Joystick* joystick, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickRumbleTriggers(_SDL_Joystick* joystick, ushort left_rumble, ushort right_rumble, uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickHasLED(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickHasRumble(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_JoystickHasRumbleTriggers(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickSetLED(_SDL_Joystick* joystick, byte red, byte green, byte blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickSendEffect(_SDL_Joystick* joystick, void* data, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_JoystickClose(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_JoystickPowerLevel SDL_JoystickCurrentPowerLevel(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LockSensors();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockSensors();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_NumSensors();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_SensorGetDeviceName(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SensorType SDL_SensorGetDeviceType(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SensorGetDeviceNonPortableType(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int SDL_SensorGetDeviceInstanceID(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Sensor* SDL_SensorOpen(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Sensor* SDL_SensorFromInstanceID(int instance_id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_SensorGetName(_SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_SensorType SDL_SensorGetType(_SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SensorGetNonPortableType(_SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int SDL_SensorGetInstanceID(_SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SensorGetData(_SDL_Sensor* sensor, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SensorGetDataWithTimestamp(_SDL_Sensor* sensor, UIntPtr* timestamp, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SensorClose(_SDL_Sensor* sensor);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SensorUpdate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerAddMappingsFromRW(SDL_RWops* rw, int freerw);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerAddMapping(string mappingString);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerNumMappings();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerMappingForIndex(int mapping_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerMappingForGUID(SDL_GUID guid);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerMapping(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsGameController(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerNameForIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerPathForIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GameControllerType SDL_GameControllerTypeForIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerMappingForDeviceIndex(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_GameController* SDL_GameControllerOpen(int joystick_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_GameController* SDL_GameControllerFromInstanceID(int joyid);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_GameController* SDL_GameControllerFromPlayerIndex(int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerName(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerPath(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GameControllerType SDL_GameControllerGetType(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerGetPlayerIndex(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GameControllerSetPlayerIndex(_SDL_GameController* gamecontroller, int player_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_GameControllerGetVendor(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_GameControllerGetProduct(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_GameControllerGetProductVersion(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern ushort SDL_GameControllerGetFirmwareVersion(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerGetSerial(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_GameControllerGetSteamHandle(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerGetAttached(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Joystick* SDL_GameControllerGetJoystick(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerEventState(int state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GameControllerUpdate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GameControllerAxis SDL_GameControllerGetAxisFromString(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerGetStringForAxis(SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GameControllerButtonBind SDL_GameControllerGetBindForAxis(_SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerHasAxis(_SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern short SDL_GameControllerGetAxis(_SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GameControllerButton SDL_GameControllerGetButtonFromString(string str);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerGetStringForButton(SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_GameControllerButtonBind SDL_GameControllerGetBindForButton(_SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerHasButton(_SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte SDL_GameControllerGetButton(_SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerGetNumTouchpads(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerGetNumTouchpadFingers(_SDL_GameController* gamecontroller, int touchpad);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerGetTouchpadFinger(_SDL_GameController* gamecontroller, int touchpad, int finger, byte* state, float* x, float* y, float* pressure);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerHasSensor(_SDL_GameController* gamecontroller, SDL_SensorType type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerSetSensorEnabled(_SDL_GameController* gamecontroller, SDL_SensorType type, SDL_bool enabled);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerIsSensorEnabled(_SDL_GameController* gamecontroller, SDL_SensorType type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float SDL_GameControllerGetSensorDataRate(_SDL_GameController* gamecontroller, SDL_SensorType type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerGetSensorData(_SDL_GameController* gamecontroller, SDL_SensorType type, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerGetSensorDataWithTimestamp(_SDL_GameController* gamecontroller, SDL_SensorType type, UIntPtr* timestamp, float* data, int num_values);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerRumble(_SDL_GameController* gamecontroller, ushort low_frequency_rumble, ushort high_frequency_rumble, uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerRumbleTriggers(_SDL_GameController* gamecontroller, ushort left_rumble, ushort right_rumble, uint duration_ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerHasLED(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerHasRumble(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GameControllerHasRumbleTriggers(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerSetLED(_SDL_GameController* gamecontroller, byte red, byte green, byte blue);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GameControllerSendEffect(_SDL_GameController* gamecontroller, void* data, int size);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GameControllerClose(_SDL_GameController* gamecontroller);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerGetAppleSFSymbolsNameForButton(_SDL_GameController* gamecontroller, SDL_GameControllerButton button);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GameControllerGetAppleSFSymbolsNameForAxis(_SDL_GameController* gamecontroller, SDL_GameControllerAxis axis);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumTouchDevices();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern IntPtr SDL_GetTouchDevice(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetTouchName(int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_TouchDeviceType SDL_GetTouchDeviceType(IntPtr touchID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumTouchFingers(IntPtr touchID);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Finger* SDL_GetTouchFinger(IntPtr touchID, int index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RecordGesture(IntPtr touchId);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SaveAllDollarTemplates(SDL_RWops* dst);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SaveDollarTemplate(IntPtr gestureId, SDL_RWops* dst);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LoadDollarTemplates(IntPtr touchId, SDL_RWops* src);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_PumpEvents();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_PeepEvents(SDL_Event* events, int numevents, SDL_eventaction action, uint minType, uint maxType);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasEvent(uint type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_HasEvents(uint minType, uint maxType);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FlushEvent(uint type);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FlushEvents(uint minType, uint maxType);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_PollEvent(SDL_Event* @event);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WaitEvent(SDL_Event* @event);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_WaitEventTimeout(SDL_Event* @event, int timeout);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_PushEvent(SDL_Event* @event);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_SetEventFilter(IntPtr filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetEventFilter(IntPtr* filter, void** userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_AddEventWatch(IntPtr filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DelEventWatch(IntPtr filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_FilterEvents(IntPtr filter, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte SDL_EventState(uint type, int state);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_RegisterEvents(int numevents);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_NumHaptics();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_HapticName(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Haptic* SDL_HapticOpen(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticOpened(int device_index);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticIndex(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_MouseIsHaptic();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Haptic* SDL_HapticOpenFromMouse();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_JoystickIsHaptic(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern _SDL_Haptic* SDL_HapticOpenFromJoystick(_SDL_Joystick* joystick);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_HapticClose(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticNumEffects(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticNumEffectsPlaying(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_HapticQuery(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticNumAxes(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticEffectSupported(_SDL_Haptic* haptic, SDL_HapticEffect* effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticNewEffect(_SDL_Haptic* haptic, SDL_HapticEffect* effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticUpdateEffect(_SDL_Haptic* haptic, int effect, SDL_HapticEffect* data);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticRunEffect(_SDL_Haptic* haptic, int effect, uint iterations);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticStopEffect(_SDL_Haptic* haptic, int effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_HapticDestroyEffect(_SDL_Haptic* haptic, int effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticGetEffectStatus(_SDL_Haptic* haptic, int effect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticSetGain(_SDL_Haptic* haptic, int gain);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticSetAutocenter(_SDL_Haptic* haptic, int autocenter);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticPause(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticUnpause(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticStopAll(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticRumbleSupported(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticRumbleInit(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticRumblePlay(_SDL_Haptic* haptic, float strength, uint length);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_HapticRumbleStop(_SDL_Haptic* haptic);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetHintWithPriority(string name, string value, SDL_HintPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_SetHint(string name, string value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_ResetHint(string name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ResetHints();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetHint(string name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_GetHintBoolean(string name, SDL_bool default_value);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_AddHintCallback(string name, IntPtr callback, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DelHintCallback(string name, IntPtr callback, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_ClearHints();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_LoadObject(string sofile);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_LoadFunction(void* handle, string name);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnloadObject(void* handle);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogSetAllPriority(SDL_LogPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogSetPriority(int category, SDL_LogPriority priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_LogPriority SDL_LogGetPriority(int category);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogResetPriorities();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Log(string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogVerbose(int category, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogDebug(int category, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogInfo(int category, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogWarn(int category, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogError(int category, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogCritical(int category, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogMessage(int category, SDL_LogPriority priority, string fmt, __arglist);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogGetOutputFunction(IntPtr* callback, void** userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_LogSetOutputFunction(IntPtr callback, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ShowMessageBox(SDL_MessageBoxData* messageboxdata, int* buttonid);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_ShowSimpleMessageBox(uint flags, string title, string message, SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_PowerState SDL_GetPowerInfo(int* seconds, int* percent);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetNumRenderDrivers();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderDriverInfo(int index, SDL_RendererInfo* info);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_CreateWindowAndRenderer(int width, int height, uint window_flags, SDL_Window** window, SDL_Renderer** renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateRenderer(SDL_Window* window, int index, uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_CreateSoftwareRenderer(SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Renderer* SDL_GetRenderer(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_RenderGetWindow(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRendererInfo(SDL_Renderer* renderer, SDL_RendererInfo* info);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRendererOutputSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTexture(SDL_Renderer* renderer, uint format, int access, int w, int h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_CreateTextureFromSurface(SDL_Renderer* renderer, SDL_Surface* surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_QueryTexture(SDL_Texture* texture, uint* format, int* access, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureColorMod(SDL_Texture* texture, byte r, byte g, byte b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureColorMod(SDL_Texture* texture, byte* r, byte* g, byte* b);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureAlphaMod(SDL_Texture* texture, byte alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureAlphaMod(SDL_Texture* texture, byte* alpha);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureBlendMode(SDL_Texture* texture, SDL_BlendMode* blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode scaleMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetTextureScaleMode(SDL_Texture* texture, SDL_ScaleMode* scaleMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetTextureUserData(SDL_Texture* texture, void* userdata);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_GetTextureUserData(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateTexture(SDL_Texture* texture, SDL_Rect* rect, void* pixels, int pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateYUVTexture(SDL_Texture* texture, SDL_Rect* rect, byte* Yplane, int Ypitch, byte* Uplane, int Upitch, byte* Vplane, int Vpitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_UpdateNVTexture(SDL_Texture* texture, SDL_Rect* rect, byte* Yplane, int Ypitch, byte* UVplane, int UVpitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LockTexture(SDL_Texture* texture, SDL_Rect* rect, void** pixels, int* pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LockTextureToSurface(SDL_Texture* texture, SDL_Rect* rect, SDL_Surface** surface);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_UnlockTexture(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_RenderTargetSupported(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderTarget(SDL_Renderer* renderer, SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Texture* SDL_GetRenderTarget(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderSetLogicalSize(SDL_Renderer* renderer, int w, int h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RenderGetLogicalSize(SDL_Renderer* renderer, int* w, int* h);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderSetIntegerScale(SDL_Renderer* renderer, SDL_bool enable);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_RenderGetIntegerScale(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderSetViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RenderGetViewport(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderSetClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RenderGetClipRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_RenderIsClipEnabled(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderSetScale(SDL_Renderer* renderer, float scaleX, float scaleY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RenderGetScale(SDL_Renderer* renderer, float* scaleX, float* scaleY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RenderWindowToLogical(SDL_Renderer* renderer, int windowX, int windowY, float* logicalX, float* logicalY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RenderLogicalToWindow(SDL_Renderer* renderer, float logicalX, float logicalY, int* windowX, int* windowY);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderDrawColor(SDL_Renderer* renderer, byte r, byte g, byte b, byte a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderDrawColor(SDL_Renderer* renderer, byte* r, byte* g, byte* b, byte* a);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetRenderDrawBlendMode(SDL_Renderer* renderer, SDL_BlendMode* blendMode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderClear(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawPoint(SDL_Renderer* renderer, int x, int y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawPoints(SDL_Renderer* renderer, SDL_Point* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawLine(SDL_Renderer* renderer, int x1, int y1, int x2, int y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawLines(SDL_Renderer* renderer, SDL_Point* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawRects(SDL_Renderer* renderer, SDL_Rect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderFillRect(SDL_Renderer* renderer, SDL_Rect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderFillRects(SDL_Renderer* renderer, SDL_Rect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderCopy(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Rect* srcrect, SDL_Rect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderCopyEx(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Rect* srcrect, SDL_Rect* dstrect, double angle, SDL_Point* center, SDL_RendererFlip flip);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawPointF(SDL_Renderer* renderer, float x, float y);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawPointsF(SDL_Renderer* renderer, SDL_FPoint* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawLineF(SDL_Renderer* renderer, float x1, float y1, float x2, float y2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawLinesF(SDL_Renderer* renderer, SDL_FPoint* points, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawRectF(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderDrawRectsF(SDL_Renderer* renderer, SDL_FRect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderFillRectF(SDL_Renderer* renderer, SDL_FRect* rect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderFillRectsF(SDL_Renderer* renderer, SDL_FRect* rects, int count);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderCopyF(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Rect* srcrect, SDL_FRect* dstrect);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderCopyExF(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Rect* srcrect, SDL_FRect* dstrect, double angle, SDL_FPoint* center, SDL_RendererFlip flip);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderGeometry(SDL_Renderer* renderer, SDL_Texture* texture, SDL_Vertex* vertices, int num_vertices, int* indices, int num_indices);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderGeometryRaw(SDL_Renderer* renderer, SDL_Texture* texture, float* xy, int xy_stride, SDL_Color* color, int color_stride, float* uv, int uv_stride, int num_vertices, void* indices, int num_indices, int size_indices);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderReadPixels(SDL_Renderer* renderer, SDL_Rect* rect, uint format, void* pixels, int pitch);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_RenderPresent(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyTexture(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_DestroyRenderer(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderFlush(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_BindTexture(SDL_Texture* texture, float* texw, float* texh);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GL_UnbindTexture(SDL_Texture* texture);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_RenderGetMetalLayer(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* SDL_RenderGetMetalCommandEncoder(SDL_Renderer* renderer);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_RenderSetVSync(SDL_Renderer* renderer, int vsync);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_Window* SDL_CreateShapedWindow(string title, uint x, uint y, uint w, uint h, uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsShapedWindow(SDL_Window* window);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_SetWindowShape(SDL_Window* window, SDL_Surface* shape, SDL_WindowShapeMode* shape_mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_GetShapedWindowMode(SDL_Window* window, SDL_WindowShapeMode* shape_mode);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LinuxSetThreadPriority(IntPtr threadID, int priority);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_LinuxSetThreadPriorityAndPolicy(IntPtr threadID, int sdlPriority, int schedPolicy);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_IsTablet();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationWillTerminate();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationDidReceiveMemoryWarning();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationWillResignActive();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationDidEnterBackground();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationWillEnterForeground();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_OnApplicationDidBecomeActive();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_GetTicks();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_GetTicks64();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_GetPerformanceCounter();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr SDL_GetPerformanceFrequency();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Delay(uint ms);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int SDL_AddTimer(uint interval, IntPtr callback, void* param2);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern SDL_bool SDL_RemoveTimer(int id);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_GetVersion(SDL_version* ver);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string SDL_GetRevision();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        [Obsolete]
        public static extern int SDL_GetRevisionNumber();

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_Init(uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int SDL_InitSubSystem(uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_QuitSubSystem(uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint SDL_WasInit(uint flags);

        [DllImport("SDL2", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void SDL_Quit();

        public const int __LINUX__ = 1;


        public const sbyte SDL_MAX_SINT8 = ((sbyte)(0x7F));

        public const sbyte SDL_MIN_SINT8 = ((sbyte)(~0x7F));

        public const byte SDL_MAX_UINT8 = ((byte)(0xFF));

        public const byte SDL_MIN_UINT8 = ((byte)(0x00));

        public const short SDL_MAX_SINT16 = ((short)(0x7FFF));

        public const short SDL_MIN_SINT16 = ((short)(~0x7FFF));

        public const ushort SDL_MAX_UINT16 = ((ushort)(0xFFFF));

        public const ushort SDL_MIN_UINT16 = ((ushort)(0x0000));

        public const int SDL_MAX_SINT32 = ((int)(0x7FFFFFFF));

        public const int SDL_MIN_SINT32 = ((int)(~0x7FFFFFFF));

        public const uint SDL_MAX_UINT32 = ((uint)(0xFFFFFFFFU));

        public const uint SDL_MIN_UINT32 = ((uint)(0x00000000));





        public const float SDL_FLT_EPSILON = 1.19209290e-7F;













        public const int SDL_ASSERT_LEVEL = 2;



        public const int SDL_LINE = 304;

        public const int SDL_NULL_WHILE_LOOP_CONDITION = (0);

        public const int SDL_MUTEX_TIMEDOUT = 1;

        public const uint SDL_MUTEX_MAXWAIT = (~(uint)(0));

        public const uint SDL_RWOPS_UNKNOWN = 0U;

        public const uint SDL_RWOPS_WINFILE = 1U;

        public const uint SDL_RWOPS_STDFILE = 2U;

        public const uint SDL_RWOPS_JNIFILE = 3U;

        public const uint SDL_RWOPS_MEMORY = 4U;

        public const uint SDL_RWOPS_MEMORY_RO = 5U;

        public const int RW_SEEK_SET = 0;

        public const int RW_SEEK_CUR = 1;

        public const int RW_SEEK_END = 2;

        public const int SDL_AUDIO_MASK_BITSIZE = (0xFF);

        public const int SDL_AUDIO_MASK_DATATYPE = (1 << 8);

        public const int SDL_AUDIO_MASK_ENDIAN = (1 << 12);

        public const int SDL_AUDIO_MASK_SIGNED = (1 << 15);

        public const int AUDIO_U8 = 0x0008;

        public const int AUDIO_S8 = 0x8008;

        public const int AUDIO_U16LSB = 0x0010;

        public const int AUDIO_S16LSB = 0x8010;

        public const int AUDIO_U16MSB = 0x1010;

        public const int AUDIO_S16MSB = 0x9010;

        public const int AUDIO_U16 = 0x0010;

        public const int AUDIO_S16 = 0x8010;

        public const int AUDIO_S32LSB = 0x8020;

        public const int AUDIO_S32MSB = 0x9020;

        public const int AUDIO_S32 = 0x8020;

        public const int AUDIO_F32LSB = 0x8120;

        public const int AUDIO_F32MSB = 0x9120;

        public const int AUDIO_F32 = 0x8120;

        public const int AUDIO_U16SYS = 0x0010;

        public const int AUDIO_S16SYS = 0x8010;

        public const int AUDIO_S32SYS = 0x8020;

        public const int AUDIO_F32SYS = 0x8120;

        public const int SDL_AUDIO_ALLOW_FREQUENCY_CHANGE = 0x00000001;

        public const int SDL_AUDIO_ALLOW_FORMAT_CHANGE = 0x00000002;

        public const int SDL_AUDIO_ALLOW_CHANNELS_CHANGE = 0x00000004;

        public const int SDL_AUDIO_ALLOW_SAMPLES_CHANGE = 0x00000008;

        public const int SDL_AUDIO_ALLOW_ANY_CHANGE = (0x00000001 | 0x00000002 | 0x00000004 | 0x00000008);

        public const int SDL_AUDIOCVT_MAX_FILTERS = 9;

        public const int SDL_MIX_MAXVOLUME = 128;

        public const int SDL_CACHELINE_SIZE = 128;

        public const int SDL_ALPHA_OPAQUE = 255;

        public const int SDL_ALPHA_TRANSPARENT = 0;

        public const int SDL_SWSURFACE = 0;

        public const int SDL_PREALLOC = 0x00000001;

        public const int SDL_RLEACCEL = 0x00000002;

        public const int SDL_DONTFREE = 0x00000004;

        public const int SDL_SIMD_ALIGNED = 0x00000008;

        public const uint SDL_WINDOWPOS_UNDEFINED_MASK = 0x1FFF0000U;

        public const uint SDL_WINDOWPOS_UNDEFINED = (0x1FFF0000U | (0));

        public const uint SDL_WINDOWPOS_CENTERED_MASK = 0x2FFF0000U;

        public const uint SDL_WINDOWPOS_CENTERED = (0x2FFF0000U | (0));

        public const int SDLK_SCANCODE_MASK = (1 << 30);

        public const int SDL_BUTTON_LEFT = 1;

        public const int SDL_BUTTON_MIDDLE = 2;

        public const int SDL_BUTTON_RIGHT = 3;

        public const int SDL_BUTTON_X1 = 4;

        public const int SDL_BUTTON_X2 = 5;

        public const int SDL_BUTTON_LMASK = (1 << ((1) - 1));

        public const int SDL_BUTTON_MMASK = (1 << ((2) - 1));

        public const int SDL_BUTTON_RMASK = (1 << ((3) - 1));

        public const int SDL_BUTTON_X1MASK = (1 << ((4) - 1));

        public const int SDL_BUTTON_X2MASK = (1 << ((5) - 1));

        public const double SDL_IPHONE_MAX_GFORCE = 5.0;

        public const int SDL_VIRTUAL_JOYSTICK_DESC_VERSION = 1;

        public const int SDL_JOYSTICK_AXIS_MAX = 32767;

        public const int SDL_JOYSTICK_AXIS_MIN = -32768;

        public const int SDL_HAT_CENTERED = 0x00;

        public const int SDL_HAT_UP = 0x01;

        public const int SDL_HAT_RIGHT = 0x02;

        public const int SDL_HAT_DOWN = 0x04;

        public const int SDL_HAT_LEFT = 0x08;

        public const int SDL_HAT_RIGHTUP = (0x02 | 0x01);

        public const int SDL_HAT_RIGHTDOWN = (0x02 | 0x04);

        public const int SDL_HAT_LEFTUP = (0x08 | 0x01);

        public const int SDL_HAT_LEFTDOWN = (0x08 | 0x04);

        public const float SDL_STANDARD_GRAVITY = 9.80665f;

        public const uint SDL_TOUCH_MOUSEID = unchecked((uint)(-1));


        public const int SDL_RELEASED = 0;

        public const int SDL_PRESSED = 1;

        public const int SDL_TEXTEDITINGEVENT_TEXT_SIZE = (32);

        public const int SDL_TEXTINPUTEVENT_TEXT_SIZE = (32);

        public const int SDL_QUERY = -1;

        public const int SDL_IGNORE = 0;

        public const int SDL_DISABLE = 0;

        public const int SDL_ENABLE = 1;

        public const uint SDL_HAPTIC_CONSTANT = (1U << 0);

        public const uint SDL_HAPTIC_SINE = (1U << 1);

        public const uint SDL_HAPTIC_LEFTRIGHT = (1U << 2);

        public const uint SDL_HAPTIC_TRIANGLE = (1U << 3);

        public const uint SDL_HAPTIC_SAWTOOTHUP = (1U << 4);

        public const uint SDL_HAPTIC_SAWTOOTHDOWN = (1U << 5);

        public const uint SDL_HAPTIC_RAMP = (1U << 6);

        public const uint SDL_HAPTIC_SPRING = (1U << 7);

        public const uint SDL_HAPTIC_DAMPER = (1U << 8);

        public const uint SDL_HAPTIC_INERTIA = (1U << 9);

        public const uint SDL_HAPTIC_FRICTION = (1U << 10);

        public const uint SDL_HAPTIC_CUSTOM = (1U << 11);

        public const uint SDL_HAPTIC_GAIN = (1U << 12);

        public const uint SDL_HAPTIC_AUTOCENTER = (1U << 13);

        public const uint SDL_HAPTIC_STATUS = (1U << 14);

        public const uint SDL_HAPTIC_PAUSE = (1U << 15);

        public const int SDL_HAPTIC_POLAR = 0;

        public const int SDL_HAPTIC_CARTESIAN = 1;

        public const int SDL_HAPTIC_SPHERICAL = 2;

        public const int SDL_HAPTIC_STEERING_AXIS = 3;

        public const uint SDL_HAPTIC_INFINITY = 4294967295U;







































































































































































































        public const int SDL_MAX_LOG_MESSAGE = 4096;

        public const int SDL_NONSHAPEABLE_WINDOW = -1;

        public const int SDL_INVALID_SHAPE_ARGUMENT = -2;

        public const int SDL_WINDOW_LACKS_SHAPE = -3;

        public const int SDL_MAJOR_VERSION = 2;

        public const int SDL_MINOR_VERSION = 32;

        public const int SDL_PATCHLEVEL = 54;

        public const int SDL_COMPILEDVERSION = ((2) * 1000 + (32) * 100 + (54));

        public const uint SDL_INIT_TIMER = 0x00000001U;

        public const uint SDL_INIT_AUDIO = 0x00000010U;

        public const uint SDL_INIT_VIDEO = 0x00000020U;

        public const uint SDL_INIT_JOYSTICK = 0x00000200U;

        public const uint SDL_INIT_HAPTIC = 0x00001000U;

        public const uint SDL_INIT_GAMECONTROLLER = 0x00002000U;

        public const uint SDL_INIT_EVENTS = 0x00004000U;

        public const uint SDL_INIT_SENSOR = 0x00008000U;

        public const uint SDL_INIT_NOPARACHUTE = 0x00100000U;

        public const uint SDL_INIT_EVERYTHING = (0x00000001U | 0x00000010U | 0x00000020U | 0x00004000U | 0x00000200U | 0x00001000U | 0x00002000U | 0x00008000U);
    }
}
