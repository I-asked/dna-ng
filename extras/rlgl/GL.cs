using System.Runtime.InteropServices;

namespace GL
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLDRAWRANGEELEMENTSPROC(uint mode, uint start, uint end, int count, uint type, void* indices);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLTEXIMAGE3DPROC(uint target, int level, int internalformat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLTEXSUBIMAGE3DPROC(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLCOPYTEXSUBIMAGE3DPROC(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLACTIVETEXTUREPROC(uint texture);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLSAMPLECOVERAGEPROC(float value, byte invert);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOMPRESSEDTEXIMAGE3DPROC(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOMPRESSEDTEXIMAGE2DPROC(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOMPRESSEDTEXIMAGE1DPROC(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOMPRESSEDTEXSUBIMAGE3DPROC(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOMPRESSEDTEXSUBIMAGE2DPROC(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLCOMPRESSEDTEXSUBIMAGE1DPROC(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLGETCOMPRESSEDTEXIMAGEPROC(uint target, int level, void* img);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLACTIVETEXTUREARBPROC(uint texture);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLCLIENTACTIVETEXTUREARBPROC(uint texture);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD1DARBPROC(uint target, double s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD1DVARBPROC(uint target, double* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD1FARBPROC(uint target, float s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD1FVARBPROC(uint target, float* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD1IARBPROC(uint target, int s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD1IVARBPROC(uint target, int* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD1SARBPROC(uint target, short s);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD1SVARBPROC(uint target, short* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD2DARBPROC(uint target, double s, double t);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD2DVARBPROC(uint target, double* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD2FARBPROC(uint target, float s, float t);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD2FVARBPROC(uint target, float* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD2IARBPROC(uint target, int s, int t);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD2IVARBPROC(uint target, int* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD2SARBPROC(uint target, short s, short t);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD2SVARBPROC(uint target, short* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD3DARBPROC(uint target, double s, double t, double r);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD3DVARBPROC(uint target, double* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD3FARBPROC(uint target, float s, float t, float r);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD3FVARBPROC(uint target, float* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD3IARBPROC(uint target, int s, int t, int r);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD3IVARBPROC(uint target, int* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD3SARBPROC(uint target, short s, short t, short r);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD3SVARBPROC(uint target, short* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD4DARBPROC(uint target, double s, double t, double r, double q);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD4DVARBPROC(uint target, double* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD4FARBPROC(uint target, float s, float t, float r, float q);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD4FVARBPROC(uint target, float* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD4IARBPROC(uint target, int s, int t, int r, int q);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD4IVARBPROC(uint target, int* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLMULTITEXCOORD4SARBPROC(uint target, short s, short t, short r, short q);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLMULTITEXCOORD4SVARBPROC(uint target, short* v);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public delegate void PFNGLBLENDEQUATIONSEPARATEATIPROC(uint modeRGB, uint modeA);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLEGLIMAGETARGETTEXTURE2DOESPROC(uint target, void* image);

    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate void PFNGLEGLIMAGETARGETRENDERBUFFERSTORAGEOESPROC(uint target, void* image);

    public static unsafe partial class Methods
    {
        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearIndex(float c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearColor(float red, float green, float blue, float alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClear(uint mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexMask(uint mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorMask(byte red, byte green, byte blue, byte alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glAlphaFunc(uint func, float @ref);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBlendFunc(uint sfactor, uint dfactor);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLogicOp(uint opcode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCullFace(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFrontFace(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPointSize(float size);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLineWidth(float width);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLineStipple(int factor, ushort pattern);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPolygonMode(uint face, uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPolygonOffset(float factor, float units);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPolygonStipple(byte* mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPolygonStipple(byte* mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEdgeFlag(byte flag);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEdgeFlagv(byte* flag);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glScissor(int x, int y, int width, int height);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClipPlane(uint plane, double* equation);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetClipPlane(uint plane, double* equation);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawBuffer(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glReadBuffer(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEnable(uint cap);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDisable(uint cap);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte glIsEnabled(uint cap);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEnableClientState(uint cap);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDisableClientState(uint cap);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetBooleanv(uint pname, byte* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetDoublev(uint pname, double* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetFloatv(uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetIntegerv(uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushAttrib(uint mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopAttrib();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushClientAttrib(uint mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopClientAttrib();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int glRenderMode(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint glGetError();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte* glGetString(uint name);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFinish();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFlush();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glHint(uint target, uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearDepth(double depth);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDepthFunc(uint func);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDepthMask(byte flag);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDepthRange(double near_val, double far_val);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearAccum(float red, float green, float blue, float alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glAccum(uint op, float value);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMatrixMode(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glOrtho(double left, double right, double bottom, double top, double near_val, double far_val);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFrustum(double left, double right, double bottom, double top, double near_val, double far_val);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glViewport(int x, int y, int width, int height);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushMatrix();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopMatrix();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadIdentity();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadMatrixd(double* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadMatrixf(float* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultMatrixd(double* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultMatrixf(float* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRotated(double angle, double x, double y, double z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRotatef(float angle, float x, float y, float z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glScaled(double x, double y, double z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glScalef(float x, float y, float z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTranslated(double x, double y, double z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTranslatef(float x, float y, float z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte glIsList(uint list);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDeleteLists(uint list, int range);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint glGenLists(int range);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNewList(uint list, uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEndList();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCallList(uint list);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCallLists(int n, uint type, void* lists);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glListBase(uint @base);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBegin(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEnd();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2d(double x, double y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2f(float x, float y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2i(int x, int y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2s(short x, short y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3d(double x, double y, double z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3f(float x, float y, float z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3i(int x, int y, int z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3s(short x, short y, short z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4d(double x, double y, double z, double w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4f(float x, float y, float z, float w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4i(int x, int y, int z, int w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4s(short x, short y, short z, short w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex2sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex3sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertex4sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3b(sbyte nx, sbyte ny, sbyte nz);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3d(double nx, double ny, double nz);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3f(float nx, float ny, float nz);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3i(int nx, int ny, int nz);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3s(short nx, short ny, short nz);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3bv(string v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormal3sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexd(double c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexf(float c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexi(int c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexs(short c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexub(byte c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexdv(double* c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexfv(float* c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexiv(int* c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexsv(short* c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexubv(byte* c);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3b(sbyte red, sbyte green, sbyte blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3d(double red, double green, double blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3f(float red, float green, float blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3i(int red, int green, int blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3s(short red, short green, short blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3ub(byte red, byte green, byte blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3ui(uint red, uint green, uint blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3us(ushort red, ushort green, ushort blue);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4b(sbyte red, sbyte green, sbyte blue, sbyte alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4d(double red, double green, double blue, double alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4f(float red, float green, float blue, float alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4i(int red, int green, int blue, int alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4s(short red, short green, short blue, short alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4ub(byte red, byte green, byte blue, byte alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4ui(uint red, uint green, uint blue, uint alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4us(ushort red, ushort green, ushort blue, ushort alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3bv(string v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3ubv(byte* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3uiv(uint* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor3usv(ushort* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4bv(string v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4ubv(byte* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4uiv(uint* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColor4usv(ushort* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1d(double s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1f(float s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1i(int s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1s(short s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2d(double s, double t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2f(float s, float t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2i(int s, int t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2s(short s, short t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3d(double s, double t, double r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3f(float s, float t, float r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3i(int s, int t, int r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3s(short s, short t, short r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4d(double s, double t, double r, double q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4f(float s, float t, float r, float q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4i(int s, int t, int r, int q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4s(short s, short t, short r, short q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord1sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord2sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord3sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoord4sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2d(double x, double y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2f(float x, float y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2i(int x, int y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2s(short x, short y);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3d(double x, double y, double z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3f(float x, float y, float z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3i(int x, int y, int z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3s(short x, short y, short z);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4d(double x, double y, double z, double w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4f(float x, float y, float z, float w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4i(int x, int y, int z, int w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4s(short x, short y, short z, short w);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos2sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos3sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4dv(double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4fv(float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4iv(int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRasterPos4sv(short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectd(double x1, double y1, double x2, double y2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectf(float x1, float y1, float x2, float y2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRecti(int x1, int y1, int x2, int y2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRects(short x1, short y1, short x2, short y2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectdv(double* v1, double* v2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectfv(float* v1, float* v2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectiv(int* v1, int* v2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glRectsv(short* v1, short* v2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glVertexPointer(int size, uint type, int stride, void* ptr);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glNormalPointer(uint type, int stride, void* ptr);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorPointer(int size, uint type, int stride, void* ptr);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glIndexPointer(uint type, int stride, void* ptr);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexCoordPointer(int size, uint type, int stride, void* ptr);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEdgeFlagPointer(int stride, void* ptr);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPointerv(uint pname, void** @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glArrayElement(int i);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawArrays(uint mode, int first, int count);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawElements(uint mode, int count, uint type, void* indices);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glInterleavedArrays(uint format, int stride, void* pointer);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glShadeModel(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightf(uint light, uint pname, float param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLighti(uint light, uint pname, int param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightfv(uint light, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightiv(uint light, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetLightfv(uint light, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetLightiv(uint light, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModelf(uint pname, float param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModeli(uint pname, int param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModelfv(uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLightModeliv(uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMaterialf(uint face, uint pname, float param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMateriali(uint face, uint pname, int param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMaterialfv(uint face, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMaterialiv(uint face, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMaterialfv(uint face, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMaterialiv(uint face, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorMaterial(uint face, uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelZoom(float xfactor, float yfactor);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelStoref(uint pname, float param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelStorei(uint pname, int param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelTransferf(uint pname, float param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelTransferi(uint pname, int param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelMapfv(uint map, int mapsize, float* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelMapuiv(uint map, int mapsize, uint* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPixelMapusv(uint map, int mapsize, ushort* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPixelMapfv(uint map, float* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPixelMapuiv(uint map, uint* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetPixelMapusv(uint map, ushort* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBitmap(int width, int height, float xorig, float yorig, float xmove, float ymove, byte* bitmap);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glReadPixels(int x, int y, int width, int height, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawPixels(int width, int height, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyPixels(int x, int y, int width, int height, uint type);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glStencilFunc(uint func, int @ref, uint mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glStencilMask(uint mask);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glStencilOp(uint fail, uint zfail, uint zpass);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClearStencil(int s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGend(uint coord, uint pname, double param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGenf(uint coord, uint pname, float param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGeni(uint coord, uint pname, int param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGendv(uint coord, uint pname, double* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGenfv(uint coord, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexGeniv(uint coord, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexGendv(uint coord, uint pname, double* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexGenfv(uint coord, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexGeniv(uint coord, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnvf(uint target, uint pname, float param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnvi(uint target, uint pname, int param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnvfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexEnviv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexEnvfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexEnviv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameterf(uint target, uint pname, float param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameteri(uint target, uint pname, int param2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexLevelParameterfv(uint target, int level, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexLevelParameteriv(uint target, int level, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexImage1D(uint target, int level, int internalFormat, int width, int border, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexImage2D(uint target, int level, int internalFormat, int width, int height, int border, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetTexImage(uint target, int level, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGenTextures(int n, uint* textures);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDeleteTextures(int n, uint* textures);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBindTexture(uint target, uint texture);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPrioritizeTextures(int n, uint* textures, float* priorities);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte glAreTexturesResident(int n, uint* textures, byte* residences);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte glIsTexture(uint texture);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexSubImage1D(uint target, int level, int xoffset, int width, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexImage1D(uint target, int level, uint internalformat, int x, int y, int width, int border);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexImage2D(uint target, int level, uint internalformat, int x, int y, int width, int height, int border);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexSubImage1D(uint target, int level, int xoffset, int x, int y, int width);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexSubImage2D(uint target, int level, int xoffset, int yoffset, int x, int y, int width, int height);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap1d(uint target, double u1, double u2, int stride, int order, double* points);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap1f(uint target, float u1, float u2, int stride, int order, float* points);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap2d(uint target, double u1, double u2, int ustride, int uorder, double v1, double v2, int vstride, int vorder, double* points);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMap2f(uint target, float u1, float u2, int ustride, int uorder, float v1, float v2, int vstride, int vorder, float* points);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMapdv(uint target, uint query, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMapfv(uint target, uint query, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMapiv(uint target, uint query, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1d(double u);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1f(float u);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1dv(double* u);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord1fv(float* u);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2d(double u, double v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2f(float u, float v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2dv(double* u);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalCoord2fv(float* u);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid1d(int un, double u1, double u2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid1f(int un, float u1, float u2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid2d(int un, double u1, double u2, int vn, double v1, double v2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMapGrid2f(int un, float u1, float u2, int vn, float v1, float v2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalPoint1(int i);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalPoint2(int i, int j);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalMesh1(uint mode, int i1, int i2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glEvalMesh2(uint mode, int i1, int i2, int j1, int j2);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogf(uint pname, float param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogi(uint pname, int param1);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogfv(uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFogiv(uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glFeedbackBuffer(int size, uint type, float* buffer);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPassThrough(float token);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glSelectBuffer(int size, uint* buffer);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glInitNames();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadName(uint name);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPushName(uint name);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glPopName();

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glDrawRangeElements(uint mode, uint start, uint end, int count, uint type, void* indices);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexImage3D(uint target, int level, int internalFormat, int width, int height, int depth, int border, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, uint type, void* pixels);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int x, int y, int width, int height);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorTable(uint target, uint internalformat, int width, uint format, uint type, void* table);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorSubTable(uint target, int start, int count, uint format, uint type, void* data);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorTableParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glColorTableParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyColorSubTable(uint target, int start, int x, int y, int width);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyColorTable(uint target, uint internalformat, int x, int y, int width);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetColorTable(uint target, uint format, uint type, void* table);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetColorTableParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetColorTableParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBlendEquation(uint mode);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBlendColor(float red, float green, float blue, float alpha);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glHistogram(uint target, int width, uint internalformat, byte sink);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glResetHistogram(uint target);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetHistogram(uint target, byte reset, uint format, uint type, void* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetHistogramParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetHistogramParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMinmax(uint target, uint internalformat, byte sink);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glResetMinmax(uint target);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMinmax(uint target, byte reset, uint format, uint types, void* values);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMinmaxParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetMinmaxParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionFilter1D(uint target, uint internalformat, int width, uint format, uint type, void* image);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* image);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameterf(uint target, uint pname, float @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameteri(uint target, uint pname, int @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glConvolutionParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyConvolutionFilter1D(uint target, uint internalformat, int x, int y, int width);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCopyConvolutionFilter2D(uint target, uint internalformat, int x, int y, int width, int height);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetConvolutionFilter(uint target, uint format, uint type, void* image);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetConvolutionParameterfv(uint target, uint pname, float* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetConvolutionParameteriv(uint target, uint pname, int* @params);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glSeparableFilter2D(uint target, uint internalformat, int width, int height, uint format, uint type, void* row, void* column);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetSeparableFilter(uint target, uint format, uint type, void* row, void* column, void* span);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glActiveTexture(uint texture);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClientActiveTexture(uint texture);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexImage1D(uint target, int level, uint internalformat, int width, int border, int imageSize, void* data);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexImage2D(uint target, int level, uint internalformat, int width, int height, int border, int imageSize, void* data);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexImage3D(uint target, int level, uint internalformat, int width, int height, int depth, int border, int imageSize, void* data);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexSubImage1D(uint target, int level, int xoffset, int width, uint format, int imageSize, void* data);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexSubImage2D(uint target, int level, int xoffset, int yoffset, int width, int height, uint format, int imageSize, void* data);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glCompressedTexSubImage3D(uint target, int level, int xoffset, int yoffset, int zoffset, int width, int height, int depth, uint format, int imageSize, void* data);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glGetCompressedTexImage(uint target, int lod, void* img);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1d(uint target, double s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1dv(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1f(uint target, float s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1fv(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1i(uint target, int s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1iv(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1s(uint target, short s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1sv(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2d(uint target, double s, double t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2dv(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2f(uint target, float s, float t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2fv(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2i(uint target, int s, int t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2iv(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2s(uint target, short s, short t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2sv(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3d(uint target, double s, double t, double r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3dv(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3f(uint target, float s, float t, float r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3fv(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3i(uint target, int s, int t, int r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3iv(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3s(uint target, short s, short t, short r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3sv(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4d(uint target, double s, double t, double r, double q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4dv(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4f(uint target, float s, float t, float r, float q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4fv(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4i(uint target, int s, int t, int r, int q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4iv(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4s(uint target, short s, short t, short r, short q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4sv(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadTransposeMatrixd(double* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glLoadTransposeMatrixf(float* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultTransposeMatrixd(double* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultTransposeMatrixf(float* m);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glSampleCoverage(float value, byte invert);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glActiveTextureARB(uint texture);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glClientActiveTextureARB(uint texture);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1dARB(uint target, double s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1dvARB(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1fARB(uint target, float s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1fvARB(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1iARB(uint target, int s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1ivARB(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1sARB(uint target, short s);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord1svARB(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2dARB(uint target, double s, double t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2dvARB(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2fARB(uint target, float s, float t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2fvARB(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2iARB(uint target, int s, int t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2ivARB(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2sARB(uint target, short s, short t);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord2svARB(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3dARB(uint target, double s, double t, double r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3dvARB(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3fARB(uint target, float s, float t, float r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3fvARB(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3iARB(uint target, int s, int t, int r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3ivARB(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3sARB(uint target, short s, short t, short r);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord3svARB(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4dARB(uint target, double s, double t, double r, double q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4dvARB(uint target, double* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4fARB(uint target, float s, float t, float r, float q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4fvARB(uint target, float* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4iARB(uint target, int s, int t, int r, int q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4ivARB(uint target, int* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4sARB(uint target, short s, short t, short r, short q);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glMultiTexCoord4svARB(uint target, short* v);

        [DllImport("GL", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void glBlendEquationSeparateATI(uint modeRGB, uint modeA);

        public const int GL_VERSION_1_1 = 1;

        public const int GL_VERSION_1_2 = 1;

        public const int GL_VERSION_1_3 = 1;

        public const int GL_ARB_imaging = 1;

        public const int GL_FALSE = 0;

        public const int GL_TRUE = 1;

        public const int GL_BYTE = 0x1400;

        public const int GL_UNSIGNED_BYTE = 0x1401;

        public const int GL_SHORT = 0x1402;

        public const int GL_UNSIGNED_SHORT = 0x1403;

        public const int GL_INT = 0x1404;

        public const int GL_UNSIGNED_INT = 0x1405;

        public const int GL_FLOAT = 0x1406;

        public const int GL_2_BYTES = 0x1407;

        public const int GL_3_BYTES = 0x1408;

        public const int GL_4_BYTES = 0x1409;

        public const int GL_DOUBLE = 0x140A;

        public const int GL_POINTS = 0x0000;

        public const int GL_LINES = 0x0001;

        public const int GL_LINE_LOOP = 0x0002;

        public const int GL_LINE_STRIP = 0x0003;

        public const int GL_TRIANGLES = 0x0004;

        public const int GL_TRIANGLE_STRIP = 0x0005;

        public const int GL_TRIANGLE_FAN = 0x0006;

        public const int GL_QUADS = 0x0007;

        public const int GL_QUAD_STRIP = 0x0008;

        public const int GL_POLYGON = 0x0009;

        public const int GL_VERTEX_ARRAY = 0x8074;

        public const int GL_NORMAL_ARRAY = 0x8075;

        public const int GL_COLOR_ARRAY = 0x8076;

        public const int GL_INDEX_ARRAY = 0x8077;

        public const int GL_TEXTURE_COORD_ARRAY = 0x8078;

        public const int GL_EDGE_FLAG_ARRAY = 0x8079;

        public const int GL_VERTEX_ARRAY_SIZE = 0x807A;

        public const int GL_VERTEX_ARRAY_TYPE = 0x807B;

        public const int GL_VERTEX_ARRAY_STRIDE = 0x807C;

        public const int GL_NORMAL_ARRAY_TYPE = 0x807E;

        public const int GL_NORMAL_ARRAY_STRIDE = 0x807F;

        public const int GL_COLOR_ARRAY_SIZE = 0x8081;

        public const int GL_COLOR_ARRAY_TYPE = 0x8082;

        public const int GL_COLOR_ARRAY_STRIDE = 0x8083;

        public const int GL_INDEX_ARRAY_TYPE = 0x8085;

        public const int GL_INDEX_ARRAY_STRIDE = 0x8086;

        public const int GL_TEXTURE_COORD_ARRAY_SIZE = 0x8088;

        public const int GL_TEXTURE_COORD_ARRAY_TYPE = 0x8089;

        public const int GL_TEXTURE_COORD_ARRAY_STRIDE = 0x808A;

        public const int GL_EDGE_FLAG_ARRAY_STRIDE = 0x808C;

        public const int GL_VERTEX_ARRAY_POINTER = 0x808E;

        public const int GL_NORMAL_ARRAY_POINTER = 0x808F;

        public const int GL_COLOR_ARRAY_POINTER = 0x8090;

        public const int GL_INDEX_ARRAY_POINTER = 0x8091;

        public const int GL_TEXTURE_COORD_ARRAY_POINTER = 0x8092;

        public const int GL_EDGE_FLAG_ARRAY_POINTER = 0x8093;

        public const int GL_V2F = 0x2A20;

        public const int GL_V3F = 0x2A21;

        public const int GL_C4UB_V2F = 0x2A22;

        public const int GL_C4UB_V3F = 0x2A23;

        public const int GL_C3F_V3F = 0x2A24;

        public const int GL_N3F_V3F = 0x2A25;

        public const int GL_C4F_N3F_V3F = 0x2A26;

        public const int GL_T2F_V3F = 0x2A27;

        public const int GL_T4F_V4F = 0x2A28;

        public const int GL_T2F_C4UB_V3F = 0x2A29;

        public const int GL_T2F_C3F_V3F = 0x2A2A;

        public const int GL_T2F_N3F_V3F = 0x2A2B;

        public const int GL_T2F_C4F_N3F_V3F = 0x2A2C;

        public const int GL_T4F_C4F_N3F_V4F = 0x2A2D;

        public const int GL_MATRIX_MODE = 0x0BA0;

        public const int GL_MODELVIEW = 0x1700;

        public const int GL_PROJECTION = 0x1701;

        public const int GL_TEXTURE = 0x1702;

        public const int GL_POINT_SMOOTH = 0x0B10;

        public const int GL_POINT_SIZE = 0x0B11;

        public const int GL_POINT_SIZE_GRANULARITY = 0x0B13;

        public const int GL_POINT_SIZE_RANGE = 0x0B12;

        public const int GL_LINE_SMOOTH = 0x0B20;

        public const int GL_LINE_STIPPLE = 0x0B24;

        public const int GL_LINE_STIPPLE_PATTERN = 0x0B25;

        public const int GL_LINE_STIPPLE_REPEAT = 0x0B26;

        public const int GL_LINE_WIDTH = 0x0B21;

        public const int GL_LINE_WIDTH_GRANULARITY = 0x0B23;

        public const int GL_LINE_WIDTH_RANGE = 0x0B22;

        public const int GL_POINT = 0x1B00;

        public const int GL_LINE = 0x1B01;

        public const int GL_FILL = 0x1B02;

        public const int GL_CW = 0x0900;

        public const int GL_CCW = 0x0901;

        public const int GL_FRONT = 0x0404;

        public const int GL_BACK = 0x0405;

        public const int GL_POLYGON_MODE = 0x0B40;

        public const int GL_POLYGON_SMOOTH = 0x0B41;

        public const int GL_POLYGON_STIPPLE = 0x0B42;

        public const int GL_EDGE_FLAG = 0x0B43;

        public const int GL_CULL_FACE = 0x0B44;

        public const int GL_CULL_FACE_MODE = 0x0B45;

        public const int GL_FRONT_FACE = 0x0B46;

        public const int GL_POLYGON_OFFSET_FACTOR = 0x8038;

        public const int GL_POLYGON_OFFSET_UNITS = 0x2A00;

        public const int GL_POLYGON_OFFSET_POINT = 0x2A01;

        public const int GL_POLYGON_OFFSET_LINE = 0x2A02;

        public const int GL_POLYGON_OFFSET_FILL = 0x8037;

        public const int GL_COMPILE = 0x1300;

        public const int GL_COMPILE_AND_EXECUTE = 0x1301;

        public const int GL_LIST_BASE = 0x0B32;

        public const int GL_LIST_INDEX = 0x0B33;

        public const int GL_LIST_MODE = 0x0B30;

        public const int GL_NEVER = 0x0200;

        public const int GL_LESS = 0x0201;

        public const int GL_EQUAL = 0x0202;

        public const int GL_LEQUAL = 0x0203;

        public const int GL_GREATER = 0x0204;

        public const int GL_NOTEQUAL = 0x0205;

        public const int GL_GEQUAL = 0x0206;

        public const int GL_ALWAYS = 0x0207;

        public const int GL_DEPTH_TEST = 0x0B71;

        public const int GL_DEPTH_BITS = 0x0D56;

        public const int GL_DEPTH_CLEAR_VALUE = 0x0B73;

        public const int GL_DEPTH_FUNC = 0x0B74;

        public const int GL_DEPTH_RANGE = 0x0B70;

        public const int GL_DEPTH_WRITEMASK = 0x0B72;

        public const int GL_DEPTH_COMPONENT = 0x1902;

        public const int GL_LIGHTING = 0x0B50;

        public const int GL_LIGHT0 = 0x4000;

        public const int GL_LIGHT1 = 0x4001;

        public const int GL_LIGHT2 = 0x4002;

        public const int GL_LIGHT3 = 0x4003;

        public const int GL_LIGHT4 = 0x4004;

        public const int GL_LIGHT5 = 0x4005;

        public const int GL_LIGHT6 = 0x4006;

        public const int GL_LIGHT7 = 0x4007;

        public const int GL_SPOT_EXPONENT = 0x1205;

        public const int GL_SPOT_CUTOFF = 0x1206;

        public const int GL_CONSTANT_ATTENUATION = 0x1207;

        public const int GL_LINEAR_ATTENUATION = 0x1208;

        public const int GL_QUADRATIC_ATTENUATION = 0x1209;

        public const int GL_AMBIENT = 0x1200;

        public const int GL_DIFFUSE = 0x1201;

        public const int GL_SPECULAR = 0x1202;

        public const int GL_SHININESS = 0x1601;

        public const int GL_EMISSION = 0x1600;

        public const int GL_POSITION = 0x1203;

        public const int GL_SPOT_DIRECTION = 0x1204;

        public const int GL_AMBIENT_AND_DIFFUSE = 0x1602;

        public const int GL_COLOR_INDEXES = 0x1603;

        public const int GL_LIGHT_MODEL_TWO_SIDE = 0x0B52;

        public const int GL_LIGHT_MODEL_LOCAL_VIEWER = 0x0B51;

        public const int GL_LIGHT_MODEL_AMBIENT = 0x0B53;

        public const int GL_FRONT_AND_BACK = 0x0408;

        public const int GL_SHADE_MODEL = 0x0B54;

        public const int GL_FLAT = 0x1D00;

        public const int GL_SMOOTH = 0x1D01;

        public const int GL_COLOR_MATERIAL = 0x0B57;

        public const int GL_COLOR_MATERIAL_FACE = 0x0B55;

        public const int GL_COLOR_MATERIAL_PARAMETER = 0x0B56;

        public const int GL_NORMALIZE = 0x0BA1;

        public const int GL_CLIP_PLANE0 = 0x3000;

        public const int GL_CLIP_PLANE1 = 0x3001;

        public const int GL_CLIP_PLANE2 = 0x3002;

        public const int GL_CLIP_PLANE3 = 0x3003;

        public const int GL_CLIP_PLANE4 = 0x3004;

        public const int GL_CLIP_PLANE5 = 0x3005;

        public const int GL_ACCUM_RED_BITS = 0x0D58;

        public const int GL_ACCUM_GREEN_BITS = 0x0D59;

        public const int GL_ACCUM_BLUE_BITS = 0x0D5A;

        public const int GL_ACCUM_ALPHA_BITS = 0x0D5B;

        public const int GL_ACCUM_CLEAR_VALUE = 0x0B80;

        public const int GL_ACCUM = 0x0100;

        public const int GL_ADD = 0x0104;

        public const int GL_LOAD = 0x0101;

        public const int GL_MULT = 0x0103;

        public const int GL_RETURN = 0x0102;

        public const int GL_ALPHA_TEST = 0x0BC0;

        public const int GL_ALPHA_TEST_REF = 0x0BC2;

        public const int GL_ALPHA_TEST_FUNC = 0x0BC1;

        public const int GL_BLEND = 0x0BE2;

        public const int GL_BLEND_SRC = 0x0BE1;

        public const int GL_BLEND_DST = 0x0BE0;

        public const int GL_ZERO = 0;

        public const int GL_ONE = 1;

        public const int GL_SRC_COLOR = 0x0300;

        public const int GL_ONE_MINUS_SRC_COLOR = 0x0301;

        public const int GL_SRC_ALPHA = 0x0302;

        public const int GL_ONE_MINUS_SRC_ALPHA = 0x0303;

        public const int GL_DST_ALPHA = 0x0304;

        public const int GL_ONE_MINUS_DST_ALPHA = 0x0305;

        public const int GL_DST_COLOR = 0x0306;

        public const int GL_ONE_MINUS_DST_COLOR = 0x0307;

        public const int GL_SRC_ALPHA_SATURATE = 0x0308;

        public const int GL_FEEDBACK = 0x1C01;

        public const int GL_RENDER = 0x1C00;

        public const int GL_SELECT = 0x1C02;

        public const int GL_2D = 0x0600;

        public const int GL_3D = 0x0601;

        public const int GL_3D_COLOR = 0x0602;

        public const int GL_3D_COLOR_TEXTURE = 0x0603;

        public const int GL_4D_COLOR_TEXTURE = 0x0604;

        public const int GL_POINT_TOKEN = 0x0701;

        public const int GL_LINE_TOKEN = 0x0702;

        public const int GL_LINE_RESET_TOKEN = 0x0707;

        public const int GL_POLYGON_TOKEN = 0x0703;

        public const int GL_BITMAP_TOKEN = 0x0704;

        public const int GL_DRAW_PIXEL_TOKEN = 0x0705;

        public const int GL_COPY_PIXEL_TOKEN = 0x0706;

        public const int GL_PASS_THROUGH_TOKEN = 0x0700;

        public const int GL_FEEDBACK_BUFFER_POINTER = 0x0DF0;

        public const int GL_FEEDBACK_BUFFER_SIZE = 0x0DF1;

        public const int GL_FEEDBACK_BUFFER_TYPE = 0x0DF2;

        public const int GL_SELECTION_BUFFER_POINTER = 0x0DF3;

        public const int GL_SELECTION_BUFFER_SIZE = 0x0DF4;

        public const int GL_FOG = 0x0B60;

        public const int GL_FOG_MODE = 0x0B65;

        public const int GL_FOG_DENSITY = 0x0B62;

        public const int GL_FOG_COLOR = 0x0B66;

        public const int GL_FOG_INDEX = 0x0B61;

        public const int GL_FOG_START = 0x0B63;

        public const int GL_FOG_END = 0x0B64;

        public const int GL_LINEAR = 0x2601;

        public const int GL_EXP = 0x0800;

        public const int GL_EXP2 = 0x0801;

        public const int GL_LOGIC_OP = 0x0BF1;

        public const int GL_INDEX_LOGIC_OP = 0x0BF1;

        public const int GL_COLOR_LOGIC_OP = 0x0BF2;

        public const int GL_LOGIC_OP_MODE = 0x0BF0;

        public const int GL_CLEAR = 0x1500;

        public const int GL_SET = 0x150F;

        public const int GL_COPY = 0x1503;

        public const int GL_COPY_INVERTED = 0x150C;

        public const int GL_NOOP = 0x1505;

        public const int GL_INVERT = 0x150A;

        public const int GL_AND = 0x1501;

        public const int GL_NAND = 0x150E;

        public const int GL_OR = 0x1507;

        public const int GL_NOR = 0x1508;

        public const int GL_XOR = 0x1506;

        public const int GL_EQUIV = 0x1509;

        public const int GL_AND_REVERSE = 0x1502;

        public const int GL_AND_INVERTED = 0x1504;

        public const int GL_OR_REVERSE = 0x150B;

        public const int GL_OR_INVERTED = 0x150D;

        public const int GL_STENCIL_BITS = 0x0D57;

        public const int GL_STENCIL_TEST = 0x0B90;

        public const int GL_STENCIL_CLEAR_VALUE = 0x0B91;

        public const int GL_STENCIL_FUNC = 0x0B92;

        public const int GL_STENCIL_VALUE_MASK = 0x0B93;

        public const int GL_STENCIL_FAIL = 0x0B94;

        public const int GL_STENCIL_PASS_DEPTH_FAIL = 0x0B95;

        public const int GL_STENCIL_PASS_DEPTH_PASS = 0x0B96;

        public const int GL_STENCIL_REF = 0x0B97;

        public const int GL_STENCIL_WRITEMASK = 0x0B98;

        public const int GL_STENCIL_INDEX = 0x1901;

        public const int GL_KEEP = 0x1E00;

        public const int GL_REPLACE = 0x1E01;

        public const int GL_INCR = 0x1E02;

        public const int GL_DECR = 0x1E03;

        public const int GL_NONE = 0;

        public const int GL_LEFT = 0x0406;

        public const int GL_RIGHT = 0x0407;

        public const int GL_FRONT_LEFT = 0x0400;

        public const int GL_FRONT_RIGHT = 0x0401;

        public const int GL_BACK_LEFT = 0x0402;

        public const int GL_BACK_RIGHT = 0x0403;

        public const int GL_AUX0 = 0x0409;

        public const int GL_AUX1 = 0x040A;

        public const int GL_AUX2 = 0x040B;

        public const int GL_AUX3 = 0x040C;

        public const int GL_COLOR_INDEX = 0x1900;

        public const int GL_RED = 0x1903;

        public const int GL_GREEN = 0x1904;

        public const int GL_BLUE = 0x1905;

        public const int GL_ALPHA = 0x1906;

        public const int GL_LUMINANCE = 0x1909;

        public const int GL_LUMINANCE_ALPHA = 0x190A;

        public const int GL_ALPHA_BITS = 0x0D55;

        public const int GL_RED_BITS = 0x0D52;

        public const int GL_GREEN_BITS = 0x0D53;

        public const int GL_BLUE_BITS = 0x0D54;

        public const int GL_INDEX_BITS = 0x0D51;

        public const int GL_SUBPIXEL_BITS = 0x0D50;

        public const int GL_AUX_BUFFERS = 0x0C00;

        public const int GL_READ_BUFFER = 0x0C02;

        public const int GL_DRAW_BUFFER = 0x0C01;

        public const int GL_DOUBLEBUFFER = 0x0C32;

        public const int GL_STEREO = 0x0C33;

        public const int GL_BITMAP = 0x1A00;

        public const int GL_COLOR = 0x1800;

        public const int GL_DEPTH = 0x1801;

        public const int GL_STENCIL = 0x1802;

        public const int GL_DITHER = 0x0BD0;

        public const int GL_RGB = 0x1907;

        public const int GL_RGBA = 0x1908;

        public const int GL_MAX_LIST_NESTING = 0x0B31;

        public const int GL_MAX_EVAL_ORDER = 0x0D30;

        public const int GL_MAX_LIGHTS = 0x0D31;

        public const int GL_MAX_CLIP_PLANES = 0x0D32;

        public const int GL_MAX_TEXTURE_SIZE = 0x0D33;

        public const int GL_MAX_PIXEL_MAP_TABLE = 0x0D34;

        public const int GL_MAX_ATTRIB_STACK_DEPTH = 0x0D35;

        public const int GL_MAX_MODELVIEW_STACK_DEPTH = 0x0D36;

        public const int GL_MAX_NAME_STACK_DEPTH = 0x0D37;

        public const int GL_MAX_PROJECTION_STACK_DEPTH = 0x0D38;

        public const int GL_MAX_TEXTURE_STACK_DEPTH = 0x0D39;

        public const int GL_MAX_VIEWPORT_DIMS = 0x0D3A;

        public const int GL_MAX_CLIENT_ATTRIB_STACK_DEPTH = 0x0D3B;

        public const int GL_ATTRIB_STACK_DEPTH = 0x0BB0;

        public const int GL_CLIENT_ATTRIB_STACK_DEPTH = 0x0BB1;

        public const int GL_COLOR_CLEAR_VALUE = 0x0C22;

        public const int GL_COLOR_WRITEMASK = 0x0C23;

        public const int GL_CURRENT_INDEX = 0x0B01;

        public const int GL_CURRENT_COLOR = 0x0B00;

        public const int GL_CURRENT_NORMAL = 0x0B02;

        public const int GL_CURRENT_RASTER_COLOR = 0x0B04;

        public const int GL_CURRENT_RASTER_DISTANCE = 0x0B09;

        public const int GL_CURRENT_RASTER_INDEX = 0x0B05;

        public const int GL_CURRENT_RASTER_POSITION = 0x0B07;

        public const int GL_CURRENT_RASTER_TEXTURE_COORDS = 0x0B06;

        public const int GL_CURRENT_RASTER_POSITION_VALID = 0x0B08;

        public const int GL_CURRENT_TEXTURE_COORDS = 0x0B03;

        public const int GL_INDEX_CLEAR_VALUE = 0x0C20;

        public const int GL_INDEX_MODE = 0x0C30;

        public const int GL_INDEX_WRITEMASK = 0x0C21;

        public const int GL_MODELVIEW_MATRIX = 0x0BA6;

        public const int GL_MODELVIEW_STACK_DEPTH = 0x0BA3;

        public const int GL_NAME_STACK_DEPTH = 0x0D70;

        public const int GL_PROJECTION_MATRIX = 0x0BA7;

        public const int GL_PROJECTION_STACK_DEPTH = 0x0BA4;

        public const int GL_RENDER_MODE = 0x0C40;

        public const int GL_RGBA_MODE = 0x0C31;

        public const int GL_TEXTURE_MATRIX = 0x0BA8;

        public const int GL_TEXTURE_STACK_DEPTH = 0x0BA5;

        public const int GL_VIEWPORT = 0x0BA2;

        public const int GL_AUTO_NORMAL = 0x0D80;

        public const int GL_MAP1_COLOR_4 = 0x0D90;

        public const int GL_MAP1_INDEX = 0x0D91;

        public const int GL_MAP1_NORMAL = 0x0D92;

        public const int GL_MAP1_TEXTURE_COORD_1 = 0x0D93;

        public const int GL_MAP1_TEXTURE_COORD_2 = 0x0D94;

        public const int GL_MAP1_TEXTURE_COORD_3 = 0x0D95;

        public const int GL_MAP1_TEXTURE_COORD_4 = 0x0D96;

        public const int GL_MAP1_VERTEX_3 = 0x0D97;

        public const int GL_MAP1_VERTEX_4 = 0x0D98;

        public const int GL_MAP2_COLOR_4 = 0x0DB0;

        public const int GL_MAP2_INDEX = 0x0DB1;

        public const int GL_MAP2_NORMAL = 0x0DB2;

        public const int GL_MAP2_TEXTURE_COORD_1 = 0x0DB3;

        public const int GL_MAP2_TEXTURE_COORD_2 = 0x0DB4;

        public const int GL_MAP2_TEXTURE_COORD_3 = 0x0DB5;

        public const int GL_MAP2_TEXTURE_COORD_4 = 0x0DB6;

        public const int GL_MAP2_VERTEX_3 = 0x0DB7;

        public const int GL_MAP2_VERTEX_4 = 0x0DB8;

        public const int GL_MAP1_GRID_DOMAIN = 0x0DD0;

        public const int GL_MAP1_GRID_SEGMENTS = 0x0DD1;

        public const int GL_MAP2_GRID_DOMAIN = 0x0DD2;

        public const int GL_MAP2_GRID_SEGMENTS = 0x0DD3;

        public const int GL_COEFF = 0x0A00;

        public const int GL_ORDER = 0x0A01;

        public const int GL_DOMAIN = 0x0A02;

        public const int GL_PERSPECTIVE_CORRECTION_HINT = 0x0C50;

        public const int GL_POINT_SMOOTH_HINT = 0x0C51;

        public const int GL_LINE_SMOOTH_HINT = 0x0C52;

        public const int GL_POLYGON_SMOOTH_HINT = 0x0C53;

        public const int GL_FOG_HINT = 0x0C54;

        public const int GL_DONT_CARE = 0x1100;

        public const int GL_FASTEST = 0x1101;

        public const int GL_NICEST = 0x1102;

        public const int GL_SCISSOR_BOX = 0x0C10;

        public const int GL_SCISSOR_TEST = 0x0C11;

        public const int GL_MAP_COLOR = 0x0D10;

        public const int GL_MAP_STENCIL = 0x0D11;

        public const int GL_INDEX_SHIFT = 0x0D12;

        public const int GL_INDEX_OFFSET = 0x0D13;

        public const int GL_RED_SCALE = 0x0D14;

        public const int GL_RED_BIAS = 0x0D15;

        public const int GL_GREEN_SCALE = 0x0D18;

        public const int GL_GREEN_BIAS = 0x0D19;

        public const int GL_BLUE_SCALE = 0x0D1A;

        public const int GL_BLUE_BIAS = 0x0D1B;

        public const int GL_ALPHA_SCALE = 0x0D1C;

        public const int GL_ALPHA_BIAS = 0x0D1D;

        public const int GL_DEPTH_SCALE = 0x0D1E;

        public const int GL_DEPTH_BIAS = 0x0D1F;

        public const int GL_PIXEL_MAP_S_TO_S_SIZE = 0x0CB1;

        public const int GL_PIXEL_MAP_I_TO_I_SIZE = 0x0CB0;

        public const int GL_PIXEL_MAP_I_TO_R_SIZE = 0x0CB2;

        public const int GL_PIXEL_MAP_I_TO_G_SIZE = 0x0CB3;

        public const int GL_PIXEL_MAP_I_TO_B_SIZE = 0x0CB4;

        public const int GL_PIXEL_MAP_I_TO_A_SIZE = 0x0CB5;

        public const int GL_PIXEL_MAP_R_TO_R_SIZE = 0x0CB6;

        public const int GL_PIXEL_MAP_G_TO_G_SIZE = 0x0CB7;

        public const int GL_PIXEL_MAP_B_TO_B_SIZE = 0x0CB8;

        public const int GL_PIXEL_MAP_A_TO_A_SIZE = 0x0CB9;

        public const int GL_PIXEL_MAP_S_TO_S = 0x0C71;

        public const int GL_PIXEL_MAP_I_TO_I = 0x0C70;

        public const int GL_PIXEL_MAP_I_TO_R = 0x0C72;

        public const int GL_PIXEL_MAP_I_TO_G = 0x0C73;

        public const int GL_PIXEL_MAP_I_TO_B = 0x0C74;

        public const int GL_PIXEL_MAP_I_TO_A = 0x0C75;

        public const int GL_PIXEL_MAP_R_TO_R = 0x0C76;

        public const int GL_PIXEL_MAP_G_TO_G = 0x0C77;

        public const int GL_PIXEL_MAP_B_TO_B = 0x0C78;

        public const int GL_PIXEL_MAP_A_TO_A = 0x0C79;

        public const int GL_PACK_ALIGNMENT = 0x0D05;

        public const int GL_PACK_LSB_FIRST = 0x0D01;

        public const int GL_PACK_ROW_LENGTH = 0x0D02;

        public const int GL_PACK_SKIP_PIXELS = 0x0D04;

        public const int GL_PACK_SKIP_ROWS = 0x0D03;

        public const int GL_PACK_SWAP_BYTES = 0x0D00;

        public const int GL_UNPACK_ALIGNMENT = 0x0CF5;

        public const int GL_UNPACK_LSB_FIRST = 0x0CF1;

        public const int GL_UNPACK_ROW_LENGTH = 0x0CF2;

        public const int GL_UNPACK_SKIP_PIXELS = 0x0CF4;

        public const int GL_UNPACK_SKIP_ROWS = 0x0CF3;

        public const int GL_UNPACK_SWAP_BYTES = 0x0CF0;

        public const int GL_ZOOM_X = 0x0D16;

        public const int GL_ZOOM_Y = 0x0D17;

        public const int GL_TEXTURE_ENV = 0x2300;

        public const int GL_TEXTURE_ENV_MODE = 0x2200;

        public const int GL_TEXTURE_1D = 0x0DE0;

        public const int GL_TEXTURE_2D = 0x0DE1;

        public const int GL_TEXTURE_WRAP_S = 0x2802;

        public const int GL_TEXTURE_WRAP_T = 0x2803;

        public const int GL_TEXTURE_MAG_FILTER = 0x2800;

        public const int GL_TEXTURE_MIN_FILTER = 0x2801;

        public const int GL_TEXTURE_ENV_COLOR = 0x2201;

        public const int GL_TEXTURE_GEN_S = 0x0C60;

        public const int GL_TEXTURE_GEN_T = 0x0C61;

        public const int GL_TEXTURE_GEN_R = 0x0C62;

        public const int GL_TEXTURE_GEN_Q = 0x0C63;

        public const int GL_TEXTURE_GEN_MODE = 0x2500;

        public const int GL_TEXTURE_BORDER_COLOR = 0x1004;

        public const int GL_TEXTURE_WIDTH = 0x1000;

        public const int GL_TEXTURE_HEIGHT = 0x1001;

        public const int GL_TEXTURE_BORDER = 0x1005;

        public const int GL_TEXTURE_COMPONENTS = 0x1003;

        public const int GL_TEXTURE_RED_SIZE = 0x805C;

        public const int GL_TEXTURE_GREEN_SIZE = 0x805D;

        public const int GL_TEXTURE_BLUE_SIZE = 0x805E;

        public const int GL_TEXTURE_ALPHA_SIZE = 0x805F;

        public const int GL_TEXTURE_LUMINANCE_SIZE = 0x8060;

        public const int GL_TEXTURE_INTENSITY_SIZE = 0x8061;

        public const int GL_NEAREST_MIPMAP_NEAREST = 0x2700;

        public const int GL_NEAREST_MIPMAP_LINEAR = 0x2702;

        public const int GL_LINEAR_MIPMAP_NEAREST = 0x2701;

        public const int GL_LINEAR_MIPMAP_LINEAR = 0x2703;

        public const int GL_OBJECT_LINEAR = 0x2401;

        public const int GL_OBJECT_PLANE = 0x2501;

        public const int GL_EYE_LINEAR = 0x2400;

        public const int GL_EYE_PLANE = 0x2502;

        public const int GL_SPHERE_MAP = 0x2402;

        public const int GL_DECAL = 0x2101;

        public const int GL_MODULATE = 0x2100;

        public const int GL_NEAREST = 0x2600;

        public const int GL_REPEAT = 0x2901;

        public const int GL_CLAMP = 0x2900;

        public const int GL_S = 0x2000;

        public const int GL_T = 0x2001;

        public const int GL_R = 0x2002;

        public const int GL_Q = 0x2003;

        public const int GL_VENDOR = 0x1F00;

        public const int GL_RENDERER = 0x1F01;

        public const int GL_VERSION = 0x1F02;

        public const int GL_EXTENSIONS = 0x1F03;

        public const int GL_NO_ERROR = 0;

        public const int GL_INVALID_ENUM = 0x0500;

        public const int GL_INVALID_VALUE = 0x0501;

        public const int GL_INVALID_OPERATION = 0x0502;

        public const int GL_STACK_OVERFLOW = 0x0503;

        public const int GL_STACK_UNDERFLOW = 0x0504;

        public const int GL_OUT_OF_MEMORY = 0x0505;

        public const int GL_CURRENT_BIT = 0x00000001;

        public const int GL_POINT_BIT = 0x00000002;

        public const int GL_LINE_BIT = 0x00000004;

        public const int GL_POLYGON_BIT = 0x00000008;

        public const int GL_POLYGON_STIPPLE_BIT = 0x00000010;

        public const int GL_PIXEL_MODE_BIT = 0x00000020;

        public const int GL_LIGHTING_BIT = 0x00000040;

        public const int GL_FOG_BIT = 0x00000080;

        public const int GL_DEPTH_BUFFER_BIT = 0x00000100;

        public const int GL_ACCUM_BUFFER_BIT = 0x00000200;

        public const int GL_STENCIL_BUFFER_BIT = 0x00000400;

        public const int GL_VIEWPORT_BIT = 0x00000800;

        public const int GL_TRANSFORM_BIT = 0x00001000;

        public const int GL_ENABLE_BIT = 0x00002000;

        public const int GL_COLOR_BUFFER_BIT = 0x00004000;

        public const int GL_HINT_BIT = 0x00008000;

        public const int GL_EVAL_BIT = 0x00010000;

        public const int GL_LIST_BIT = 0x00020000;

        public const int GL_TEXTURE_BIT = 0x00040000;

        public const int GL_SCISSOR_BIT = 0x00080000;

        public const uint GL_ALL_ATTRIB_BITS = 0xFFFFFFFF;

        public const int GL_PROXY_TEXTURE_1D = 0x8063;

        public const int GL_PROXY_TEXTURE_2D = 0x8064;

        public const int GL_TEXTURE_PRIORITY = 0x8066;

        public const int GL_TEXTURE_RESIDENT = 0x8067;

        public const int GL_TEXTURE_BINDING_1D = 0x8068;

        public const int GL_TEXTURE_BINDING_2D = 0x8069;

        public const int GL_TEXTURE_INTERNAL_FORMAT = 0x1003;

        public const int GL_ALPHA4 = 0x803B;

        public const int GL_ALPHA8 = 0x803C;

        public const int GL_ALPHA12 = 0x803D;

        public const int GL_ALPHA16 = 0x803E;

        public const int GL_LUMINANCE4 = 0x803F;

        public const int GL_LUMINANCE8 = 0x8040;

        public const int GL_LUMINANCE12 = 0x8041;

        public const int GL_LUMINANCE16 = 0x8042;

        public const int GL_LUMINANCE4_ALPHA4 = 0x8043;

        public const int GL_LUMINANCE6_ALPHA2 = 0x8044;

        public const int GL_LUMINANCE8_ALPHA8 = 0x8045;

        public const int GL_LUMINANCE12_ALPHA4 = 0x8046;

        public const int GL_LUMINANCE12_ALPHA12 = 0x8047;

        public const int GL_LUMINANCE16_ALPHA16 = 0x8048;

        public const int GL_INTENSITY = 0x8049;

        public const int GL_INTENSITY4 = 0x804A;

        public const int GL_INTENSITY8 = 0x804B;

        public const int GL_INTENSITY12 = 0x804C;

        public const int GL_INTENSITY16 = 0x804D;

        public const int GL_R3_G3_B2 = 0x2A10;

        public const int GL_RGB4 = 0x804F;

        public const int GL_RGB5 = 0x8050;

        public const int GL_RGB8 = 0x8051;

        public const int GL_RGB10 = 0x8052;

        public const int GL_RGB12 = 0x8053;

        public const int GL_RGB16 = 0x8054;

        public const int GL_RGBA2 = 0x8055;

        public const int GL_RGBA4 = 0x8056;

        public const int GL_RGB5_A1 = 0x8057;

        public const int GL_RGBA8 = 0x8058;

        public const int GL_RGB10_A2 = 0x8059;

        public const int GL_RGBA12 = 0x805A;

        public const int GL_RGBA16 = 0x805B;

        public const int GL_CLIENT_PIXEL_STORE_BIT = 0x00000001;

        public const int GL_CLIENT_VERTEX_ARRAY_BIT = 0x00000002;

        public const uint GL_ALL_CLIENT_ATTRIB_BITS = 0xFFFFFFFF;

        public const uint GL_CLIENT_ALL_ATTRIB_BITS = 0xFFFFFFFF;

        public const int GL_RESCALE_NORMAL = 0x803A;

        public const int GL_CLAMP_TO_EDGE = 0x812F;

        public const int GL_MAX_ELEMENTS_VERTICES = 0x80E8;

        public const int GL_MAX_ELEMENTS_INDICES = 0x80E9;

        public const int GL_BGR = 0x80E0;

        public const int GL_BGRA = 0x80E1;

        public const int GL_UNSIGNED_BYTE_3_3_2 = 0x8032;

        public const int GL_UNSIGNED_BYTE_2_3_3_REV = 0x8362;

        public const int GL_UNSIGNED_SHORT_5_6_5 = 0x8363;

        public const int GL_UNSIGNED_SHORT_5_6_5_REV = 0x8364;

        public const int GL_UNSIGNED_SHORT_4_4_4_4 = 0x8033;

        public const int GL_UNSIGNED_SHORT_4_4_4_4_REV = 0x8365;

        public const int GL_UNSIGNED_SHORT_5_5_5_1 = 0x8034;

        public const int GL_UNSIGNED_SHORT_1_5_5_5_REV = 0x8366;

        public const int GL_UNSIGNED_INT_8_8_8_8 = 0x8035;

        public const int GL_UNSIGNED_INT_8_8_8_8_REV = 0x8367;

        public const int GL_UNSIGNED_INT_10_10_10_2 = 0x8036;

        public const int GL_UNSIGNED_INT_2_10_10_10_REV = 0x8368;

        public const int GL_LIGHT_MODEL_COLOR_CONTROL = 0x81F8;

        public const int GL_SINGLE_COLOR = 0x81F9;

        public const int GL_SEPARATE_SPECULAR_COLOR = 0x81FA;

        public const int GL_TEXTURE_MIN_LOD = 0x813A;

        public const int GL_TEXTURE_MAX_LOD = 0x813B;

        public const int GL_TEXTURE_BASE_LEVEL = 0x813C;

        public const int GL_TEXTURE_MAX_LEVEL = 0x813D;

        public const int GL_SMOOTH_POINT_SIZE_RANGE = 0x0B12;

        public const int GL_SMOOTH_POINT_SIZE_GRANULARITY = 0x0B13;

        public const int GL_SMOOTH_LINE_WIDTH_RANGE = 0x0B22;

        public const int GL_SMOOTH_LINE_WIDTH_GRANULARITY = 0x0B23;

        public const int GL_ALIASED_POINT_SIZE_RANGE = 0x846D;

        public const int GL_ALIASED_LINE_WIDTH_RANGE = 0x846E;

        public const int GL_PACK_SKIP_IMAGES = 0x806B;

        public const int GL_PACK_IMAGE_HEIGHT = 0x806C;

        public const int GL_UNPACK_SKIP_IMAGES = 0x806D;

        public const int GL_UNPACK_IMAGE_HEIGHT = 0x806E;

        public const int GL_TEXTURE_3D = 0x806F;

        public const int GL_PROXY_TEXTURE_3D = 0x8070;

        public const int GL_TEXTURE_DEPTH = 0x8071;

        public const int GL_TEXTURE_WRAP_R = 0x8072;

        public const int GL_MAX_3D_TEXTURE_SIZE = 0x8073;

        public const int GL_TEXTURE_BINDING_3D = 0x806A;

        public const int GL_CONSTANT_COLOR = 0x8001;

        public const int GL_ONE_MINUS_CONSTANT_COLOR = 0x8002;

        public const int GL_CONSTANT_ALPHA = 0x8003;

        public const int GL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;

        public const int GL_COLOR_TABLE = 0x80D0;

        public const int GL_POST_CONVOLUTION_COLOR_TABLE = 0x80D1;

        public const int GL_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D2;

        public const int GL_PROXY_COLOR_TABLE = 0x80D3;

        public const int GL_PROXY_POST_CONVOLUTION_COLOR_TABLE = 0x80D4;

        public const int GL_PROXY_POST_COLOR_MATRIX_COLOR_TABLE = 0x80D5;

        public const int GL_COLOR_TABLE_SCALE = 0x80D6;

        public const int GL_COLOR_TABLE_BIAS = 0x80D7;

        public const int GL_COLOR_TABLE_FORMAT = 0x80D8;

        public const int GL_COLOR_TABLE_WIDTH = 0x80D9;

        public const int GL_COLOR_TABLE_RED_SIZE = 0x80DA;

        public const int GL_COLOR_TABLE_GREEN_SIZE = 0x80DB;

        public const int GL_COLOR_TABLE_BLUE_SIZE = 0x80DC;

        public const int GL_COLOR_TABLE_ALPHA_SIZE = 0x80DD;

        public const int GL_COLOR_TABLE_LUMINANCE_SIZE = 0x80DE;

        public const int GL_COLOR_TABLE_INTENSITY_SIZE = 0x80DF;

        public const int GL_CONVOLUTION_1D = 0x8010;

        public const int GL_CONVOLUTION_2D = 0x8011;

        public const int GL_SEPARABLE_2D = 0x8012;

        public const int GL_CONVOLUTION_BORDER_MODE = 0x8013;

        public const int GL_CONVOLUTION_FILTER_SCALE = 0x8014;

        public const int GL_CONVOLUTION_FILTER_BIAS = 0x8015;

        public const int GL_REDUCE = 0x8016;

        public const int GL_CONVOLUTION_FORMAT = 0x8017;

        public const int GL_CONVOLUTION_WIDTH = 0x8018;

        public const int GL_CONVOLUTION_HEIGHT = 0x8019;

        public const int GL_MAX_CONVOLUTION_WIDTH = 0x801A;

        public const int GL_MAX_CONVOLUTION_HEIGHT = 0x801B;

        public const int GL_POST_CONVOLUTION_RED_SCALE = 0x801C;

        public const int GL_POST_CONVOLUTION_GREEN_SCALE = 0x801D;

        public const int GL_POST_CONVOLUTION_BLUE_SCALE = 0x801E;

        public const int GL_POST_CONVOLUTION_ALPHA_SCALE = 0x801F;

        public const int GL_POST_CONVOLUTION_RED_BIAS = 0x8020;

        public const int GL_POST_CONVOLUTION_GREEN_BIAS = 0x8021;

        public const int GL_POST_CONVOLUTION_BLUE_BIAS = 0x8022;

        public const int GL_POST_CONVOLUTION_ALPHA_BIAS = 0x8023;

        public const int GL_CONSTANT_BORDER = 0x8151;

        public const int GL_REPLICATE_BORDER = 0x8153;

        public const int GL_CONVOLUTION_BORDER_COLOR = 0x8154;

        public const int GL_COLOR_MATRIX = 0x80B1;

        public const int GL_COLOR_MATRIX_STACK_DEPTH = 0x80B2;

        public const int GL_MAX_COLOR_MATRIX_STACK_DEPTH = 0x80B3;

        public const int GL_POST_COLOR_MATRIX_RED_SCALE = 0x80B4;

        public const int GL_POST_COLOR_MATRIX_GREEN_SCALE = 0x80B5;

        public const int GL_POST_COLOR_MATRIX_BLUE_SCALE = 0x80B6;

        public const int GL_POST_COLOR_MATRIX_ALPHA_SCALE = 0x80B7;

        public const int GL_POST_COLOR_MATRIX_RED_BIAS = 0x80B8;

        public const int GL_POST_COLOR_MATRIX_GREEN_BIAS = 0x80B9;

        public const int GL_POST_COLOR_MATRIX_BLUE_BIAS = 0x80BA;

        public const int GL_POST_COLOR_MATRIX_ALPHA_BIAS = 0x80BB;

        public const int GL_HISTOGRAM = 0x8024;

        public const int GL_PROXY_HISTOGRAM = 0x8025;

        public const int GL_HISTOGRAM_WIDTH = 0x8026;

        public const int GL_HISTOGRAM_FORMAT = 0x8027;

        public const int GL_HISTOGRAM_RED_SIZE = 0x8028;

        public const int GL_HISTOGRAM_GREEN_SIZE = 0x8029;

        public const int GL_HISTOGRAM_BLUE_SIZE = 0x802A;

        public const int GL_HISTOGRAM_ALPHA_SIZE = 0x802B;

        public const int GL_HISTOGRAM_LUMINANCE_SIZE = 0x802C;

        public const int GL_HISTOGRAM_SINK = 0x802D;

        public const int GL_MINMAX = 0x802E;

        public const int GL_MINMAX_FORMAT = 0x802F;

        public const int GL_MINMAX_SINK = 0x8030;

        public const int GL_TABLE_TOO_LARGE = 0x8031;

        public const int GL_BLEND_EQUATION = 0x8009;

        public const int GL_MIN = 0x8007;

        public const int GL_MAX = 0x8008;

        public const int GL_FUNC_ADD = 0x8006;

        public const int GL_FUNC_SUBTRACT = 0x800A;

        public const int GL_FUNC_REVERSE_SUBTRACT = 0x800B;

        public const int GL_BLEND_COLOR = 0x8005;

        public const int GL_TEXTURE0 = 0x84C0;

        public const int GL_TEXTURE1 = 0x84C1;

        public const int GL_TEXTURE2 = 0x84C2;

        public const int GL_TEXTURE3 = 0x84C3;

        public const int GL_TEXTURE4 = 0x84C4;

        public const int GL_TEXTURE5 = 0x84C5;

        public const int GL_TEXTURE6 = 0x84C6;

        public const int GL_TEXTURE7 = 0x84C7;

        public const int GL_TEXTURE8 = 0x84C8;

        public const int GL_TEXTURE9 = 0x84C9;

        public const int GL_TEXTURE10 = 0x84CA;

        public const int GL_TEXTURE11 = 0x84CB;

        public const int GL_TEXTURE12 = 0x84CC;

        public const int GL_TEXTURE13 = 0x84CD;

        public const int GL_TEXTURE14 = 0x84CE;

        public const int GL_TEXTURE15 = 0x84CF;

        public const int GL_TEXTURE16 = 0x84D0;

        public const int GL_TEXTURE17 = 0x84D1;

        public const int GL_TEXTURE18 = 0x84D2;

        public const int GL_TEXTURE19 = 0x84D3;

        public const int GL_TEXTURE20 = 0x84D4;

        public const int GL_TEXTURE21 = 0x84D5;

        public const int GL_TEXTURE22 = 0x84D6;

        public const int GL_TEXTURE23 = 0x84D7;

        public const int GL_TEXTURE24 = 0x84D8;

        public const int GL_TEXTURE25 = 0x84D9;

        public const int GL_TEXTURE26 = 0x84DA;

        public const int GL_TEXTURE27 = 0x84DB;

        public const int GL_TEXTURE28 = 0x84DC;

        public const int GL_TEXTURE29 = 0x84DD;

        public const int GL_TEXTURE30 = 0x84DE;

        public const int GL_TEXTURE31 = 0x84DF;

        public const int GL_ACTIVE_TEXTURE = 0x84E0;

        public const int GL_CLIENT_ACTIVE_TEXTURE = 0x84E1;

        public const int GL_MAX_TEXTURE_UNITS = 0x84E2;

        public const int GL_NORMAL_MAP = 0x8511;

        public const int GL_REFLECTION_MAP = 0x8512;

        public const int GL_TEXTURE_CUBE_MAP = 0x8513;

        public const int GL_TEXTURE_BINDING_CUBE_MAP = 0x8514;

        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_X = 0x8515;

        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_X = 0x8516;

        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Y = 0x8517;

        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Y = 0x8518;

        public const int GL_TEXTURE_CUBE_MAP_POSITIVE_Z = 0x8519;

        public const int GL_TEXTURE_CUBE_MAP_NEGATIVE_Z = 0x851A;

        public const int GL_PROXY_TEXTURE_CUBE_MAP = 0x851B;

        public const int GL_MAX_CUBE_MAP_TEXTURE_SIZE = 0x851C;

        public const int GL_COMPRESSED_ALPHA = 0x84E9;

        public const int GL_COMPRESSED_LUMINANCE = 0x84EA;

        public const int GL_COMPRESSED_LUMINANCE_ALPHA = 0x84EB;

        public const int GL_COMPRESSED_INTENSITY = 0x84EC;

        public const int GL_COMPRESSED_RGB = 0x84ED;

        public const int GL_COMPRESSED_RGBA = 0x84EE;

        public const int GL_TEXTURE_COMPRESSION_HINT = 0x84EF;

        public const int GL_TEXTURE_COMPRESSED_IMAGE_SIZE = 0x86A0;

        public const int GL_TEXTURE_COMPRESSED = 0x86A1;

        public const int GL_NUM_COMPRESSED_TEXTURE_FORMATS = 0x86A2;

        public const int GL_COMPRESSED_TEXTURE_FORMATS = 0x86A3;

        public const int GL_MULTISAMPLE = 0x809D;

        public const int GL_SAMPLE_ALPHA_TO_COVERAGE = 0x809E;

        public const int GL_SAMPLE_ALPHA_TO_ONE = 0x809F;

        public const int GL_SAMPLE_COVERAGE = 0x80A0;

        public const int GL_SAMPLE_BUFFERS = 0x80A8;

        public const int GL_SAMPLES = 0x80A9;

        public const int GL_SAMPLE_COVERAGE_VALUE = 0x80AA;

        public const int GL_SAMPLE_COVERAGE_INVERT = 0x80AB;

        public const int GL_MULTISAMPLE_BIT = 0x20000000;

        public const int GL_TRANSPOSE_MODELVIEW_MATRIX = 0x84E3;

        public const int GL_TRANSPOSE_PROJECTION_MATRIX = 0x84E4;

        public const int GL_TRANSPOSE_TEXTURE_MATRIX = 0x84E5;

        public const int GL_TRANSPOSE_COLOR_MATRIX = 0x84E6;

        public const int GL_COMBINE = 0x8570;

        public const int GL_COMBINE_RGB = 0x8571;

        public const int GL_COMBINE_ALPHA = 0x8572;

        public const int GL_SOURCE0_RGB = 0x8580;

        public const int GL_SOURCE1_RGB = 0x8581;

        public const int GL_SOURCE2_RGB = 0x8582;

        public const int GL_SOURCE0_ALPHA = 0x8588;

        public const int GL_SOURCE1_ALPHA = 0x8589;

        public const int GL_SOURCE2_ALPHA = 0x858A;

        public const int GL_OPERAND0_RGB = 0x8590;

        public const int GL_OPERAND1_RGB = 0x8591;

        public const int GL_OPERAND2_RGB = 0x8592;

        public const int GL_OPERAND0_ALPHA = 0x8598;

        public const int GL_OPERAND1_ALPHA = 0x8599;

        public const int GL_OPERAND2_ALPHA = 0x859A;

        public const int GL_RGB_SCALE = 0x8573;

        public const int GL_ADD_SIGNED = 0x8574;

        public const int GL_INTERPOLATE = 0x8575;

        public const int GL_SUBTRACT = 0x84E7;

        public const int GL_CONSTANT = 0x8576;

        public const int GL_PRIMARY_COLOR = 0x8577;

        public const int GL_PREVIOUS = 0x8578;

        public const int GL_DOT3_RGB = 0x86AE;

        public const int GL_DOT3_RGBA = 0x86AF;

        public const int GL_CLAMP_TO_BORDER = 0x812D;

        public const int GL_ARB_multitexture = 1;

        public const int GL_TEXTURE0_ARB = 0x84C0;

        public const int GL_TEXTURE1_ARB = 0x84C1;

        public const int GL_TEXTURE2_ARB = 0x84C2;

        public const int GL_TEXTURE3_ARB = 0x84C3;

        public const int GL_TEXTURE4_ARB = 0x84C4;

        public const int GL_TEXTURE5_ARB = 0x84C5;

        public const int GL_TEXTURE6_ARB = 0x84C6;

        public const int GL_TEXTURE7_ARB = 0x84C7;

        public const int GL_TEXTURE8_ARB = 0x84C8;

        public const int GL_TEXTURE9_ARB = 0x84C9;

        public const int GL_TEXTURE10_ARB = 0x84CA;

        public const int GL_TEXTURE11_ARB = 0x84CB;

        public const int GL_TEXTURE12_ARB = 0x84CC;

        public const int GL_TEXTURE13_ARB = 0x84CD;

        public const int GL_TEXTURE14_ARB = 0x84CE;

        public const int GL_TEXTURE15_ARB = 0x84CF;

        public const int GL_TEXTURE16_ARB = 0x84D0;

        public const int GL_TEXTURE17_ARB = 0x84D1;

        public const int GL_TEXTURE18_ARB = 0x84D2;

        public const int GL_TEXTURE19_ARB = 0x84D3;

        public const int GL_TEXTURE20_ARB = 0x84D4;

        public const int GL_TEXTURE21_ARB = 0x84D5;

        public const int GL_TEXTURE22_ARB = 0x84D6;

        public const int GL_TEXTURE23_ARB = 0x84D7;

        public const int GL_TEXTURE24_ARB = 0x84D8;

        public const int GL_TEXTURE25_ARB = 0x84D9;

        public const int GL_TEXTURE26_ARB = 0x84DA;

        public const int GL_TEXTURE27_ARB = 0x84DB;

        public const int GL_TEXTURE28_ARB = 0x84DC;

        public const int GL_TEXTURE29_ARB = 0x84DD;

        public const int GL_TEXTURE30_ARB = 0x84DE;

        public const int GL_TEXTURE31_ARB = 0x84DF;

        public const int GL_ACTIVE_TEXTURE_ARB = 0x84E0;

        public const int GL_CLIENT_ACTIVE_TEXTURE_ARB = 0x84E1;

        public const int GL_MAX_TEXTURE_UNITS_ARB = 0x84E2;

        public const int GL_MESA_packed_depth_stencil = 1;

        public const int GL_DEPTH_STENCIL_MESA = 0x8750;

        public const int GL_UNSIGNED_INT_24_8_MESA = 0x8751;

        public const int GL_UNSIGNED_INT_8_24_REV_MESA = 0x8752;

        public const int GL_UNSIGNED_SHORT_15_1_MESA = 0x8753;

        public const int GL_UNSIGNED_SHORT_1_15_REV_MESA = 0x8754;

        public const int GL_ATI_blend_equation_separate = 1;

        public const int GL_ALPHA_BLEND_EQUATION_ATI = 0x883D;

        public const int GL_OES_EGL_image = 1;
    }
}
