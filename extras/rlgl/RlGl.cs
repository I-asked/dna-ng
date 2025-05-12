using System.Runtime.InteropServices;

namespace RlGl
{
    public partial struct Matrix
    {
        public float m0;

        public float m4;

        public float m8;

        public float m12;

        public float m1;

        public float m5;

        public float m9;

        public float m13;

        public float m2;

        public float m6;

        public float m10;

        public float m14;

        public float m3;

        public float m7;

        public float m11;

        public float m15;
    }

    public unsafe partial struct rlVertexBuffer
    {
        public int elementCount;

        public float* vertices;

        public float* texcoords;

        public float* normals;


        public byte* colors;


        public uint* indices;


        public uint vaoId;


        public fixed uint vboId[5];
    }

    public partial struct rlDrawCall
    {
        public int mode;

        public int vertexCount;

        public int vertexAlignment;


        public uint textureId;
    }

    public unsafe partial struct rlRenderBatch
    {
        public int bufferCount;

        public int currentBuffer;

        public rlVertexBuffer* vertexBuffer;

        public rlDrawCall* draws;

        public int drawCounter;

        public float currentDepth;
    }


    public enum rlGlVersion : uint
    {
        RL_OPENGL_11 = 1,
        RL_OPENGL_21,
        RL_OPENGL_33,
        RL_OPENGL_43,
        RL_OPENGL_ES_20,
        RL_OPENGL_ES_30,
    }


    public enum rlTraceLogLevel : uint
    {
        RL_LOG_ALL = 0,
        RL_LOG_TRACE,
        RL_LOG_DEBUG,
        RL_LOG_INFO,
        RL_LOG_WARNING,
        RL_LOG_ERROR,
        RL_LOG_FATAL,
        RL_LOG_NONE,
    }


    public enum rlPixelFormat : uint
    {
        RL_PIXELFORMAT_UNCOMPRESSED_GRAYSCALE = 1,
        RL_PIXELFORMAT_UNCOMPRESSED_GRAY_ALPHA,
        RL_PIXELFORMAT_UNCOMPRESSED_R5G6B5,
        RL_PIXELFORMAT_UNCOMPRESSED_R8G8B8,
        RL_PIXELFORMAT_UNCOMPRESSED_R5G5B5A1,
        RL_PIXELFORMAT_UNCOMPRESSED_R4G4B4A4,
        RL_PIXELFORMAT_UNCOMPRESSED_R8G8B8A8,
        RL_PIXELFORMAT_UNCOMPRESSED_R32,
        RL_PIXELFORMAT_UNCOMPRESSED_R32G32B32,
        RL_PIXELFORMAT_UNCOMPRESSED_R32G32B32A32,
        RL_PIXELFORMAT_UNCOMPRESSED_R16,
        RL_PIXELFORMAT_UNCOMPRESSED_R16G16B16,
        RL_PIXELFORMAT_UNCOMPRESSED_R16G16B16A16,
        RL_PIXELFORMAT_COMPRESSED_DXT1_RGB,
        RL_PIXELFORMAT_COMPRESSED_DXT1_RGBA,
        RL_PIXELFORMAT_COMPRESSED_DXT3_RGBA,
        RL_PIXELFORMAT_COMPRESSED_DXT5_RGBA,
        RL_PIXELFORMAT_COMPRESSED_ETC1_RGB,
        RL_PIXELFORMAT_COMPRESSED_ETC2_RGB,
        RL_PIXELFORMAT_COMPRESSED_ETC2_EAC_RGBA,
        RL_PIXELFORMAT_COMPRESSED_PVRT_RGB,
        RL_PIXELFORMAT_COMPRESSED_PVRT_RGBA,
        RL_PIXELFORMAT_COMPRESSED_ASTC_4x4_RGBA,
        RL_PIXELFORMAT_COMPRESSED_ASTC_8x8_RGBA,
    }


    public enum rlTextureFilter : uint
    {
        RL_TEXTURE_FILTER_POINT = 0,
        RL_TEXTURE_FILTER_BILINEAR,
        RL_TEXTURE_FILTER_TRILINEAR,
        RL_TEXTURE_FILTER_ANISOTROPIC_4X,
        RL_TEXTURE_FILTER_ANISOTROPIC_8X,
        RL_TEXTURE_FILTER_ANISOTROPIC_16X,
    }


    public enum rlBlendMode : uint
    {
        RL_BLEND_ALPHA = 0,
        RL_BLEND_ADDITIVE,
        RL_BLEND_MULTIPLIED,
        RL_BLEND_ADD_COLORS,
        RL_BLEND_SUBTRACT_COLORS,
        RL_BLEND_ALPHA_PREMULTIPLY,
        RL_BLEND_CUSTOM,
        RL_BLEND_CUSTOM_SEPARATE,
    }


    public enum rlShaderLocationIndex : uint
    {
        RL_SHADER_LOC_VERTEX_POSITION = 0,
        RL_SHADER_LOC_VERTEX_TEXCOORD01,
        RL_SHADER_LOC_VERTEX_TEXCOORD02,
        RL_SHADER_LOC_VERTEX_NORMAL,
        RL_SHADER_LOC_VERTEX_TANGENT,
        RL_SHADER_LOC_VERTEX_COLOR,
        RL_SHADER_LOC_MATRIX_MVP,
        RL_SHADER_LOC_MATRIX_VIEW,
        RL_SHADER_LOC_MATRIX_PROJECTION,
        RL_SHADER_LOC_MATRIX_MODEL,
        RL_SHADER_LOC_MATRIX_NORMAL,
        RL_SHADER_LOC_VECTOR_VIEW,
        RL_SHADER_LOC_COLOR_DIFFUSE,
        RL_SHADER_LOC_COLOR_SPECULAR,
        RL_SHADER_LOC_COLOR_AMBIENT,
        RL_SHADER_LOC_MAP_ALBEDO,
        RL_SHADER_LOC_MAP_METALNESS,
        RL_SHADER_LOC_MAP_NORMAL,
        RL_SHADER_LOC_MAP_ROUGHNESS,
        RL_SHADER_LOC_MAP_OCCLUSION,
        RL_SHADER_LOC_MAP_EMISSION,
        RL_SHADER_LOC_MAP_HEIGHT,
        RL_SHADER_LOC_MAP_CUBEMAP,
        RL_SHADER_LOC_MAP_IRRADIANCE,
        RL_SHADER_LOC_MAP_PREFILTER,
        RL_SHADER_LOC_MAP_BRDF,
    }


    public enum rlShaderUniformDataType : uint
    {
        RL_SHADER_UNIFORM_FLOAT = 0,
        RL_SHADER_UNIFORM_VEC2,
        RL_SHADER_UNIFORM_VEC3,
        RL_SHADER_UNIFORM_VEC4,
        RL_SHADER_UNIFORM_INT,
        RL_SHADER_UNIFORM_IVEC2,
        RL_SHADER_UNIFORM_IVEC3,
        RL_SHADER_UNIFORM_IVEC4,
        RL_SHADER_UNIFORM_UINT,
        RL_SHADER_UNIFORM_UIVEC2,
        RL_SHADER_UNIFORM_UIVEC3,
        RL_SHADER_UNIFORM_UIVEC4,
        RL_SHADER_UNIFORM_SAMPLER2D,
    }


    public enum rlShaderAttributeDataType : uint
    {
        RL_SHADER_ATTRIB_FLOAT = 0,
        RL_SHADER_ATTRIB_VEC2,
        RL_SHADER_ATTRIB_VEC3,
        RL_SHADER_ATTRIB_VEC4,
    }


    public enum rlFramebufferAttachType : uint
    {
        RL_ATTACHMENT_COLOR_CHANNEL0 = 0,
        RL_ATTACHMENT_COLOR_CHANNEL1 = 1,
        RL_ATTACHMENT_COLOR_CHANNEL2 = 2,
        RL_ATTACHMENT_COLOR_CHANNEL3 = 3,
        RL_ATTACHMENT_COLOR_CHANNEL4 = 4,
        RL_ATTACHMENT_COLOR_CHANNEL5 = 5,
        RL_ATTACHMENT_COLOR_CHANNEL6 = 6,
        RL_ATTACHMENT_COLOR_CHANNEL7 = 7,
        RL_ATTACHMENT_DEPTH = 100,
        RL_ATTACHMENT_STENCIL = 200,
    }


    public enum rlFramebufferAttachTextureType : uint
    {
        RL_ATTACHMENT_CUBEMAP_POSITIVE_X = 0,
        RL_ATTACHMENT_CUBEMAP_NEGATIVE_X = 1,
        RL_ATTACHMENT_CUBEMAP_POSITIVE_Y = 2,
        RL_ATTACHMENT_CUBEMAP_NEGATIVE_Y = 3,
        RL_ATTACHMENT_CUBEMAP_POSITIVE_Z = 4,
        RL_ATTACHMENT_CUBEMAP_NEGATIVE_Z = 5,
        RL_ATTACHMENT_TEXTURE2D = 100,
        RL_ATTACHMENT_RENDERBUFFER = 200,
    }


    public enum rlCullMode : uint
    {
        RL_CULL_FACE_FRONT = 0,
        RL_CULL_FACE_BACK,
    }

    public static unsafe partial class Methods
    {
        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlMatrixMode(int mode);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlPushMatrix();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlPopMatrix();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadIdentity();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlTranslatef(float x, float y, float z);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlRotatef(float angle, float x, float y, float z);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlScalef(float x, float y, float z);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlMultMatrixf(float* matf);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlFrustum(double left, double right, double bottom, double top, double znear, double zfar);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlOrtho(double left, double right, double bottom, double top, double znear, double zfar);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlViewport(int x, int y, int width, int height);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetClipPlanes(double nearPlane, double farPlane);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double rlGetCullDistanceNear();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double rlGetCullDistanceFar();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBegin(int mode);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnd();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlVertex2i(int x, int y);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlVertex2f(float x, float y);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlVertex3f(float x, float y, float z);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlTexCoord2f(float x, float y);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlNormal3f(float x, float y, float z);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColor4ub(byte r, byte g, byte b, byte a);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColor3f(float x, float y, float z);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColor4f(float x, float y, float z, float w);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlEnableVertexArray(uint vaoId);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexArray();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableVertexBuffer(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexBuffer();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableVertexBufferElement(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexBufferElement();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableVertexAttribute(uint index);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexAttribute(uint index);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlActiveTextureSlot(int slot);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableTexture(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableTexture();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableTextureCubemap(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableTextureCubemap();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlTextureParameters(uint id, int param1, int value);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlCubemapParameters(uint id, int param1, int value);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableShader(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableShader();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableFramebuffer(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableFramebuffer();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetActiveFramebuffer();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlActiveDrawBuffers(int count);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBlitFramebuffer(int srcX, int srcY, int srcWidth, int srcHeight, int dstX, int dstY, int dstWidth, int dstHeight, int bufferMask);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBindFramebuffer(uint target, uint framebuffer);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableColorBlend();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableColorBlend();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableDepthTest();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableDepthTest();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableDepthMask();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableDepthMask();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableBackfaceCulling();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableBackfaceCulling();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColorMask(byte r, byte g, byte b, byte a);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetCullFace(int mode);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableScissorTest();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableScissorTest();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlScissor(int x, int y, int width, int height);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnablePointMode();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisablePointMode();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableWireMode();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableWireMode();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetLineWidth(float width);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float rlGetLineWidth();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableSmoothLines();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableSmoothLines();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableStereoRender();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableStereoRender();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlIsStereoRenderEnabled();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlClearColor(byte r, byte g, byte b, byte a);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlClearScreenBuffers();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlCheckErrors();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetBlendMode(int mode);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetBlendFactors(int glSrcFactor, int glDstFactor, int glEquation);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetBlendFactorsSeparate(int glSrcRGB, int glDstRGB, int glSrcAlpha, int glDstAlpha, int glEqRGB, int glEqAlpha);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlglInit(int width, int height);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlglClose();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadExtensions(void* loader);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetVersion();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetFramebufferWidth(int width);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetFramebufferWidth();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetFramebufferHeight(int height);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetFramebufferHeight();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetTextureIdDefault();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetShaderIdDefault();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* rlGetShaderLocsDefault();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern rlRenderBatch rlLoadRenderBatch(int numBuffers, int bufferElements);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadRenderBatch(rlRenderBatch batch);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawRenderBatch(rlRenderBatch* batch);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetRenderBatchActive(rlRenderBatch* batch);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawRenderBatchActive();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlCheckRenderBatchLimit(int vCount);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetTexture(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadVertexArray();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadVertexBuffer(void* buffer, int size, byte dynamic);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadVertexBufferElement(void* buffer, int size, byte dynamic);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateVertexBuffer(uint bufferId, void* data, int dataSize, int offset);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateVertexBufferElements(uint id, void* data, int dataSize, int offset);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadVertexArray(uint vaoId);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadVertexBuffer(uint vboId);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetVertexAttribute(uint index, int compSize, int type, byte normalized, int stride, int offset);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetVertexAttributeDivisor(uint index, int divisor);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetVertexAttributeDefault(int locIndex, void* value, int attribType, int count);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArray(int offset, int count);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArrayElements(int offset, int count, void* buffer);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArrayInstanced(int offset, int count, int instances);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArrayElementsInstanced(int offset, int count, void* buffer, int instances);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadTexture(void* data, int width, int height, int format, int mipmapCount);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadTextureDepth(int width, int height, byte useRenderBuffer);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadTextureCubemap(void* data, int size, int format, int mipmapCount);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateTexture(uint id, int offsetX, int offsetY, int width, int height, int format, void* data);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlGetGlTextureFormats(int format, uint* glInternalFormat, uint* glFormat, uint* glType);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern sbyte* rlGetPixelFormatName(uint format);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadTexture(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlGenTextureMipmaps(uint id, int width, int height, int format, int* mipmaps);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* rlReadTexturePixels(uint id, int width, int height, int format);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte* rlReadScreenPixels(int width, int height);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadFramebuffer();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlFramebufferAttach(uint fboId, uint texId, int attachType, int texType, int mipLevel);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlFramebufferComplete(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadFramebuffer(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadShaderCode(sbyte* vsCode, sbyte* fsCode);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlCompileShader(sbyte* shaderCode, int type);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadShaderProgram(uint vShaderId, uint fShaderId);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadShaderProgram(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetLocationUniform(uint shaderId, sbyte* uniformName);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetLocationAttrib(uint shaderId, sbyte* attribName);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniform(int locIndex, void* value, int uniformType, int count);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniformMatrix(int locIndex, Matrix mat);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniformMatrices(int locIndex, Matrix* mat, int count);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniformSampler(int locIndex, uint textureId);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetShader(uint id, int* locs);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadComputeShaderProgram(uint shaderId);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlComputeShaderDispatch(uint groupX, uint groupY, uint groupZ);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadShaderBuffer(uint size, void* data, int usageHint);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadShaderBuffer(uint ssboId);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateShaderBuffer(uint id, void* data, uint dataSize, uint offset);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBindShaderBuffer(uint id, uint index);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlReadShaderBuffer(uint id, void* dest, uint count, uint offset);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlCopyShaderBuffer(uint destId, uint srcId, uint destOffset, uint srcOffset, uint count);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetShaderBufferSize(uint id);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBindImageTexture(uint id, uint index, int format, byte @readonly);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixModelview();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixProjection();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixTransform();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixProjectionStereo(int eye);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixViewOffsetStereo(int eye);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixProjection(Matrix proj);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixModelview(Matrix view);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixProjectionStereo(Matrix right, Matrix left);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixViewOffsetStereo(Matrix right, Matrix left);

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadDrawCube();

        [DllImport("rlgl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadDrawQuad();
    }
}
