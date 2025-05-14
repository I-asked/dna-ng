using System;
using System.Runtime.InteropServices;
using static RlGl.rlShaderLocationIndex;

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
        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlMatrixMode(int mode);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlPushMatrix();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlPopMatrix();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadIdentity();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlTranslatef(float x, float y, float z);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlRotatef(float angle, float x, float y, float z);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlScalef(float x, float y, float z);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlMultMatrixf(float* matf);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlFrustum(double left, double right, double bottom, double top, double znear, double zfar);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlOrtho(double left, double right, double bottom, double top, double znear, double zfar);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlViewport(int x, int y, int width, int height);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetClipPlanes(double nearPlane, double farPlane);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double rlGetCullDistanceNear();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern double rlGetCullDistanceFar();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBegin(int mode);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnd();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlVertex2i(int x, int y);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlVertex2f(float x, float y);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlVertex3f(float x, float y, float z);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlTexCoord2f(float x, float y);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlNormal3f(float x, float y, float z);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColor4ub(byte r, byte g, byte b, byte a);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColor3f(float x, float y, float z);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColor4f(float x, float y, float z, float w);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlEnableVertexArray(uint vaoId);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexArray();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableVertexBuffer(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexBuffer();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableVertexBufferElement(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexBufferElement();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableVertexAttribute(uint index);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableVertexAttribute(uint index);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlActiveTextureSlot(int slot);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableTexture(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableTexture();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableTextureCubemap(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableTextureCubemap();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlTextureParameters(uint id, int param1, int value);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlCubemapParameters(uint id, int param1, int value);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableShader(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableShader();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableFramebuffer(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableFramebuffer();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetActiveFramebuffer();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlActiveDrawBuffers(int count);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBlitFramebuffer(int srcX, int srcY, int srcWidth, int srcHeight, int dstX, int dstY, int dstWidth, int dstHeight, int bufferMask);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBindFramebuffer(uint target, uint framebuffer);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableColorBlend();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableColorBlend();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableDepthTest();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableDepthTest();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableDepthMask();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableDepthMask();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableBackfaceCulling();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableBackfaceCulling();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlColorMask(byte r, byte g, byte b, byte a);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetCullFace(int mode);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableScissorTest();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableScissorTest();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlScissor(int x, int y, int width, int height);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnablePointMode();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisablePointMode();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableWireMode();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableWireMode();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetLineWidth(float width);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern float rlGetLineWidth();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableSmoothLines();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableSmoothLines();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlEnableStereoRender();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDisableStereoRender();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlIsStereoRenderEnabled();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlClearColor(byte r, byte g, byte b, byte a);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlClearScreenBuffers();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlCheckErrors();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetBlendMode(int mode);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetBlendFactors(int glSrcFactor, int glDstFactor, int glEquation);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetBlendFactorsSeparate(int glSrcRGB, int glDstRGB, int glSrcAlpha, int glDstAlpha, int glEqRGB, int glEqAlpha);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlglInit(int width, int height);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlglClose();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadExtensions(void* loader);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetVersion();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetFramebufferWidth(int width);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetFramebufferWidth();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetFramebufferHeight(int height);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetFramebufferHeight();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetTextureIdDefault();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetShaderIdDefault();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int* rlGetShaderLocsDefault();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern rlRenderBatch rlLoadRenderBatch(int numBuffers, int bufferElements);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadRenderBatch(rlRenderBatch batch);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawRenderBatch(rlRenderBatch* batch);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetRenderBatchActive(rlRenderBatch* batch);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawRenderBatchActive();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlCheckRenderBatchLimit(int vCount);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetTexture(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadVertexArray();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadVertexBuffer(void* buffer, int size, byte dynamic);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadVertexBufferElement(void* buffer, int size, byte dynamic);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateVertexBuffer(uint bufferId, void* data, int dataSize, int offset);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateVertexBufferElements(uint id, void* data, int dataSize, int offset);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadVertexArray(uint vaoId);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadVertexBuffer(uint vboId);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetVertexAttribute(uint index, int compSize, int type, byte normalized, int stride, int offset);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetVertexAttributeDivisor(uint index, int divisor);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetVertexAttributeDefault(int locIndex, void* value, int attribType, int count);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArray(int offset, int count);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArrayElements(int offset, int count, void* buffer);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArrayInstanced(int offset, int count, int instances);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlDrawVertexArrayElementsInstanced(int offset, int count, void* buffer, int instances);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadTexture(void* data, int width, int height, int format, int mipmapCount);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadTextureDepth(int width, int height, byte useRenderBuffer);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadTextureCubemap(void* data, int size, int format, int mipmapCount);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateTexture(uint id, int offsetX, int offsetY, int width, int height, int format, void* data);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlGetGlTextureFormats(int format, uint* glInternalFormat, uint* glFormat, uint* glType);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern string rlGetPixelFormatName(uint format);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadTexture(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlGenTextureMipmaps(uint id, int width, int height, int format, int* mipmaps);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void* rlReadTexturePixels(uint id, int width, int height, int format);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte* rlReadScreenPixels(int width, int height);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadFramebuffer();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlFramebufferAttach(uint fboId, uint texId, int attachType, int texType, int mipLevel);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte rlFramebufferComplete(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadFramebuffer(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadShaderCode(string vsCode, string fsCode);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlCompileShader(string shaderCode, int type);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadShaderProgram(uint vShaderId, uint fShaderId);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadShaderProgram(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetLocationUniform(uint shaderId, string uniformName);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern int rlGetLocationAttrib(uint shaderId, string attribName);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniform(int locIndex, void* value, int uniformType, int count);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniformMatrix(int locIndex, Matrix mat);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniformMatrices(int locIndex, Matrix* mat, int count);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetUniformSampler(int locIndex, uint textureId);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetShader(uint id, int* locs);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadComputeShaderProgram(uint shaderId);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlComputeShaderDispatch(uint groupX, uint groupY, uint groupZ);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlLoadShaderBuffer(uint size, void* data, int usageHint);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUnloadShaderBuffer(uint ssboId);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlUpdateShaderBuffer(uint id, void* data, uint dataSize, uint offset);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBindShaderBuffer(uint id, uint index);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlReadShaderBuffer(uint id, void* dest, uint count, uint offset);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlCopyShaderBuffer(uint destId, uint srcId, uint destOffset, uint srcOffset, uint count);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern uint rlGetShaderBufferSize(uint id);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlBindImageTexture(uint id, uint index, int format, byte @readonly);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixModelview();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixProjection();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixTransform();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixProjectionStereo(int eye);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern Matrix rlGetMatrixViewOffsetStereo(int eye);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixProjection(Matrix proj);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixModelview(Matrix view);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixProjectionStereo(Matrix right, Matrix left);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSetMatrixViewOffsetStereo(Matrix right, Matrix left);

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadDrawCube();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlLoadDrawQuad();

        [DllImport("RlGl", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void rlSdlLoadExtensions();


        public const int RL_DEFAULT_BATCH_BUFFER_ELEMENTS = 8192;

        public const int RL_DEFAULT_BATCH_BUFFERS = 1;

        public const int RL_DEFAULT_BATCH_DRAWCALLS = 256;

        public const int RL_DEFAULT_BATCH_MAX_TEXTURE_UNITS = 4;

        public const int RL_MAX_MATRIX_STACK_SIZE = 32;

        public const int RL_MAX_SHADER_LOCATIONS = 32;

        public const double RL_CULL_DISTANCE_NEAR = 0.05;

        public const double RL_CULL_DISTANCE_FAR = 4000.0;

        public const int RL_TEXTURE_WRAP_S = 0x2802;

        public const int RL_TEXTURE_WRAP_T = 0x2803;

        public const int RL_TEXTURE_MAG_FILTER = 0x2800;

        public const int RL_TEXTURE_MIN_FILTER = 0x2801;

        public const int RL_TEXTURE_FILTER_NEAREST = 0x2600;

        public const int RL_TEXTURE_FILTER_LINEAR = 0x2601;

        public const int RL_TEXTURE_FILTER_MIP_NEAREST = 0x2700;

        public const int RL_TEXTURE_FILTER_NEAREST_MIP_LINEAR = 0x2702;

        public const int RL_TEXTURE_FILTER_LINEAR_MIP_NEAREST = 0x2701;

        public const int RL_TEXTURE_FILTER_MIP_LINEAR = 0x2703;

        public const int RL_TEXTURE_FILTER_ANISOTROPIC = 0x3000;

        public const int RL_TEXTURE_MIPMAP_BIAS_RATIO = 0x4000;

        public const int RL_TEXTURE_WRAP_REPEAT = 0x2901;

        public const int RL_TEXTURE_WRAP_CLAMP = 0x812F;

        public const int RL_TEXTURE_WRAP_MIRROR_REPEAT = 0x8370;

        public const int RL_TEXTURE_WRAP_MIRROR_CLAMP = 0x8742;

        public const int RL_MODELVIEW = 0x1700;

        public const int RL_PROJECTION = 0x1701;

        public const int RL_TEXTURE = 0x1702;

        public const int RL_LINES = 0x0001;

        public const int RL_TRIANGLES = 0x0004;

        public const int RL_QUADS = 0x0007;

        public const int RL_UNSIGNED_BYTE = 0x1401;

        public const int RL_FLOAT = 0x1406;

        public const int RL_STREAM_DRAW = 0x88E0;

        public const int RL_STREAM_READ = 0x88E1;

        public const int RL_STREAM_COPY = 0x88E2;

        public const int RL_STATIC_DRAW = 0x88E4;

        public const int RL_STATIC_READ = 0x88E5;

        public const int RL_STATIC_COPY = 0x88E6;

        public const int RL_DYNAMIC_DRAW = 0x88E8;

        public const int RL_DYNAMIC_READ = 0x88E9;

        public const int RL_DYNAMIC_COPY = 0x88EA;

        public const int RL_FRAGMENT_SHADER = 0x8B30;

        public const int RL_VERTEX_SHADER = 0x8B31;

        public const int RL_COMPUTE_SHADER = 0x91B9;

        public const int RL_ZERO = 0;

        public const int RL_ONE = 1;

        public const int RL_SRC_COLOR = 0x0300;

        public const int RL_ONE_MINUS_SRC_COLOR = 0x0301;

        public const int RL_SRC_ALPHA = 0x0302;

        public const int RL_ONE_MINUS_SRC_ALPHA = 0x0303;

        public const int RL_DST_ALPHA = 0x0304;

        public const int RL_ONE_MINUS_DST_ALPHA = 0x0305;

        public const int RL_DST_COLOR = 0x0306;

        public const int RL_ONE_MINUS_DST_COLOR = 0x0307;

        public const int RL_SRC_ALPHA_SATURATE = 0x0308;

        public const int RL_CONSTANT_COLOR = 0x8001;

        public const int RL_ONE_MINUS_CONSTANT_COLOR = 0x8002;

        public const int RL_CONSTANT_ALPHA = 0x8003;

        public const int RL_ONE_MINUS_CONSTANT_ALPHA = 0x8004;

        public const int RL_FUNC_ADD = 0x8006;

        public const int RL_MIN = 0x8007;

        public const int RL_MAX = 0x8008;

        public const int RL_FUNC_SUBTRACT = 0x800A;

        public const int RL_FUNC_REVERSE_SUBTRACT = 0x800B;

        public const int RL_BLEND_EQUATION = 0x8009;

        public const int RL_BLEND_EQUATION_RGB = 0x8009;

        public const int RL_BLEND_EQUATION_ALPHA = 0x883D;

        public const int RL_BLEND_DST_RGB = 0x80C8;

        public const int RL_BLEND_SRC_RGB = 0x80C9;

        public const int RL_BLEND_DST_ALPHA = 0x80CA;

        public const int RL_BLEND_SRC_ALPHA = 0x80CB;

        public const int RL_BLEND_COLOR = 0x8005;

        public const int RL_READ_FRAMEBUFFER = 0x8CA8;

        public const int RL_DRAW_FRAMEBUFFER = 0x8CA9;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_POSITION = 0;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_TEXCOORD = 1;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_NORMAL = 2;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_COLOR = 3;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_TANGENT = 4;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_TEXCOORD2 = 5;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_INDICES = 6;

        public const int RL_DEFAULT_SHADER_ATTRIB_LOCATION_INSTANCE_TX = 9;

        public const rlShaderLocationIndex RL_SHADER_LOC_MAP_DIFFUSE = RL_SHADER_LOC_MAP_ALBEDO;

        public const rlShaderLocationIndex RL_SHADER_LOC_MAP_SPECULAR = RL_SHADER_LOC_MAP_METALNESS;
    }
}
