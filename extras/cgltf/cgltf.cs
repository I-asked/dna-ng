using System;
using System.Runtime.InteropServices;

namespace cgltf
{

    public enum cgltf_file_type : uint
    {
        cgltf_file_type_invalid,
        cgltf_file_type_gltf,
        cgltf_file_type_glb,
        cgltf_file_type_max_enum,
    }


    public enum cgltf_result : uint
    {
        cgltf_result_success,
        cgltf_result_data_too_short,
        cgltf_result_unknown_format,
        cgltf_result_invalid_json,
        cgltf_result_invalid_gltf,
        cgltf_result_invalid_options,
        cgltf_result_file_not_found,
        cgltf_result_io_error,
        cgltf_result_out_of_memory,
        cgltf_result_legacy_gltf,
        cgltf_result_max_enum,
    }

    public unsafe partial struct cgltf_memory_options
    {

        public IntPtr alloc_func;


        public IntPtr free_func;

        public void* user_data;
    }

    public unsafe partial struct cgltf_file_options
    {

        public IntPtr read;


        public IntPtr release;

        public void* user_data;
    }

    public partial struct cgltf_options
    {
        public cgltf_file_type type;


        public UIntPtr json_token_count;

        public cgltf_memory_options memory;

        public cgltf_file_options file;
    }


    public enum cgltf_buffer_view_type : uint
    {
        cgltf_buffer_view_type_invalid,
        cgltf_buffer_view_type_indices,
        cgltf_buffer_view_type_vertices,
        cgltf_buffer_view_type_max_enum,
    }


    public enum cgltf_attribute_type : uint
    {
        cgltf_attribute_type_invalid,
        cgltf_attribute_type_position,
        cgltf_attribute_type_normal,
        cgltf_attribute_type_tangent,
        cgltf_attribute_type_texcoord,
        cgltf_attribute_type_color,
        cgltf_attribute_type_joints,
        cgltf_attribute_type_weights,
        cgltf_attribute_type_custom,
        cgltf_attribute_type_max_enum,
    }


    public enum cgltf_component_type : uint
    {
        cgltf_component_type_invalid,
        cgltf_component_type_r_8,
        cgltf_component_type_r_8u,
        cgltf_component_type_r_16,
        cgltf_component_type_r_16u,
        cgltf_component_type_r_32u,
        cgltf_component_type_r_32f,
        cgltf_component_type_max_enum,
    }


    public enum cgltf_type : uint
    {
        cgltf_type_invalid,
        cgltf_type_scalar,
        cgltf_type_vec2,
        cgltf_type_vec3,
        cgltf_type_vec4,
        cgltf_type_mat2,
        cgltf_type_mat3,
        cgltf_type_mat4,
        cgltf_type_max_enum,
    }


    public enum cgltf_primitive_type : uint
    {
        cgltf_primitive_type_invalid,
        cgltf_primitive_type_points,
        cgltf_primitive_type_lines,
        cgltf_primitive_type_line_loop,
        cgltf_primitive_type_line_strip,
        cgltf_primitive_type_triangles,
        cgltf_primitive_type_triangle_strip,
        cgltf_primitive_type_triangle_fan,
        cgltf_primitive_type_max_enum,
    }


    public enum cgltf_alpha_mode : uint
    {
        cgltf_alpha_mode_opaque,
        cgltf_alpha_mode_mask,
        cgltf_alpha_mode_blend,
        cgltf_alpha_mode_max_enum,
    }


    public enum cgltf_animation_path_type : uint
    {
        cgltf_animation_path_type_invalid,
        cgltf_animation_path_type_translation,
        cgltf_animation_path_type_rotation,
        cgltf_animation_path_type_scale,
        cgltf_animation_path_type_weights,
        cgltf_animation_path_type_max_enum,
    }


    public enum cgltf_interpolation_type : uint
    {
        cgltf_interpolation_type_linear,
        cgltf_interpolation_type_step,
        cgltf_interpolation_type_cubic_spline,
        cgltf_interpolation_type_max_enum,
    }


    public enum cgltf_camera_type : uint
    {
        cgltf_camera_type_invalid,
        cgltf_camera_type_perspective,
        cgltf_camera_type_orthographic,
        cgltf_camera_type_max_enum,
    }


    public enum cgltf_light_type : uint
    {
        cgltf_light_type_invalid,
        cgltf_light_type_directional,
        cgltf_light_type_point,
        cgltf_light_type_spot,
        cgltf_light_type_max_enum,
    }


    public enum cgltf_data_free_method : uint
    {
        cgltf_data_free_method_none,
        cgltf_data_free_method_file_release,
        cgltf_data_free_method_memory_free,
        cgltf_data_free_method_max_enum,
    }

    public unsafe partial struct cgltf_extras
    {

        public UIntPtr start_offset;


        public UIntPtr end_offset;


        public string data;
    }

    public unsafe partial struct cgltf_extension
    {

        public string name;


        public string data;
    }

    public unsafe partial struct cgltf_buffer
    {

        public string name;


        public UIntPtr size;


        public string uri;

        public void* data;

        public cgltf_data_free_method data_free_method;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }


    public enum cgltf_meshopt_compression_mode : uint
    {
        cgltf_meshopt_compression_mode_invalid,
        cgltf_meshopt_compression_mode_attributes,
        cgltf_meshopt_compression_mode_triangles,
        cgltf_meshopt_compression_mode_indices,
        cgltf_meshopt_compression_mode_max_enum,
    }


    public enum cgltf_meshopt_compression_filter : uint
    {
        cgltf_meshopt_compression_filter_none,
        cgltf_meshopt_compression_filter_octahedral,
        cgltf_meshopt_compression_filter_quaternion,
        cgltf_meshopt_compression_filter_exponential,
        cgltf_meshopt_compression_filter_max_enum,
    }

    public unsafe partial struct cgltf_meshopt_compression
    {
        public cgltf_buffer* buffer;


        public UIntPtr offset;


        public UIntPtr size;


        public UIntPtr stride;


        public UIntPtr count;

        public cgltf_meshopt_compression_mode mode;

        public cgltf_meshopt_compression_filter filter;
    }

    public unsafe partial struct cgltf_buffer_view
    {

        public string name;

        public cgltf_buffer* buffer;


        public UIntPtr offset;


        public UIntPtr size;


        public UIntPtr stride;

        public cgltf_buffer_view_type type;

        public void* data;


        public int has_meshopt_compression;

        public cgltf_meshopt_compression meshopt_compression;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_accessor_sparse
    {

        public UIntPtr count;

        public cgltf_buffer_view* indices_buffer_view;


        public UIntPtr indices_byte_offset;

        public cgltf_component_type indices_component_type;

        public cgltf_buffer_view* values_buffer_view;


        public UIntPtr values_byte_offset;
    }

    public unsafe partial struct cgltf_accessor
    {

        public string name;

        public cgltf_component_type component_type;


        public int normalized;

        public cgltf_type type;


        public UIntPtr offset;


        public UIntPtr count;


        public UIntPtr stride;

        public cgltf_buffer_view* buffer_view;


        public int has_min;


        public fixed float min[16];


        public int has_max;


        public fixed float max[16];


        public int is_sparse;

        public cgltf_accessor_sparse sparse;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_attribute
    {

        public string name;

        public cgltf_attribute_type type;


        public int index;

        public cgltf_accessor* data;
    }

    public unsafe partial struct cgltf_image
    {

        public string name;


        public string uri;

        public cgltf_buffer_view* buffer_view;


        public string mime_type;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }


    public enum cgltf_filter_type : uint
    {
        cgltf_filter_type_undefined = 0,
        cgltf_filter_type_nearest = 9728,
        cgltf_filter_type_linear = 9729,
        cgltf_filter_type_nearest_mipmap_nearest = 9984,
        cgltf_filter_type_linear_mipmap_nearest = 9985,
        cgltf_filter_type_nearest_mipmap_linear = 9986,
        cgltf_filter_type_linear_mipmap_linear = 9987,
    }


    public enum cgltf_wrap_mode : uint
    {
        cgltf_wrap_mode_clamp_to_edge = 33071,
        cgltf_wrap_mode_mirrored_repeat = 33648,
        cgltf_wrap_mode_repeat = 10497,
    }

    public unsafe partial struct cgltf_sampler
    {

        public string name;

        public cgltf_filter_type mag_filter;

        public cgltf_filter_type min_filter;

        public cgltf_wrap_mode wrap_s;

        public cgltf_wrap_mode wrap_t;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_texture
    {

        public string name;

        public cgltf_image* image;

        public cgltf_sampler* sampler;


        public int has_basisu;

        public cgltf_image* basisu_image;


        public int has_webp;

        public cgltf_image* webp_image;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_texture_transform
    {

        public fixed float offset[2];


        public float rotation;


        public fixed float scale[2];


        public int has_texcoord;


        public int texcoord;
    }

    public unsafe partial struct cgltf_texture_view
    {
        public cgltf_texture* texture;


        public int texcoord;


        public float scale;


        public int has_transform;

        public cgltf_texture_transform transform;
    }

    public unsafe partial struct cgltf_pbr_metallic_roughness
    {
        public cgltf_texture_view base_color_texture;

        public cgltf_texture_view metallic_roughness_texture;


        public fixed float base_color_factor[4];


        public float metallic_factor;


        public float roughness_factor;
    }

    public unsafe partial struct cgltf_pbr_specular_glossiness
    {
        public cgltf_texture_view diffuse_texture;

        public cgltf_texture_view specular_glossiness_texture;


        public fixed float diffuse_factor[4];


        public fixed float specular_factor[3];


        public float glossiness_factor;
    }

    public partial struct cgltf_clearcoat
    {
        public cgltf_texture_view clearcoat_texture;

        public cgltf_texture_view clearcoat_roughness_texture;

        public cgltf_texture_view clearcoat_normal_texture;


        public float clearcoat_factor;


        public float clearcoat_roughness_factor;
    }

    public partial struct cgltf_transmission
    {
        public cgltf_texture_view transmission_texture;


        public float transmission_factor;
    }

    public partial struct cgltf_ior
    {

        public float ior;
    }

    public unsafe partial struct cgltf_specular
    {
        public cgltf_texture_view specular_texture;

        public cgltf_texture_view specular_color_texture;


        public fixed float specular_color_factor[3];


        public float specular_factor;
    }

    public unsafe partial struct cgltf_volume
    {
        public cgltf_texture_view thickness_texture;


        public float thickness_factor;


        public fixed float attenuation_color[3];


        public float attenuation_distance;
    }

    public unsafe partial struct cgltf_sheen
    {
        public cgltf_texture_view sheen_color_texture;


        public fixed float sheen_color_factor[3];

        public cgltf_texture_view sheen_roughness_texture;


        public float sheen_roughness_factor;
    }

    public partial struct cgltf_emissive_strength
    {

        public float emissive_strength;
    }

    public partial struct cgltf_iridescence
    {

        public float iridescence_factor;

        public cgltf_texture_view iridescence_texture;


        public float iridescence_ior;


        public float iridescence_thickness_min;


        public float iridescence_thickness_max;

        public cgltf_texture_view iridescence_thickness_texture;
    }

    public unsafe partial struct cgltf_diffuse_transmission
    {
        public cgltf_texture_view diffuse_transmission_texture;


        public float diffuse_transmission_factor;


        public fixed float diffuse_transmission_color_factor[3];

        public cgltf_texture_view diffuse_transmission_color_texture;
    }

    public partial struct cgltf_anisotropy
    {

        public float anisotropy_strength;


        public float anisotropy_rotation;

        public cgltf_texture_view anisotropy_texture;
    }

    public partial struct cgltf_dispersion
    {

        public float dispersion;
    }

    public unsafe partial struct cgltf_material
    {

        public string name;


        public int has_pbr_metallic_roughness;


        public int has_pbr_specular_glossiness;


        public int has_clearcoat;


        public int has_transmission;


        public int has_volume;


        public int has_ior;


        public int has_specular;


        public int has_sheen;


        public int has_emissive_strength;


        public int has_iridescence;


        public int has_diffuse_transmission;


        public int has_anisotropy;


        public int has_dispersion;

        public cgltf_pbr_metallic_roughness pbr_metallic_roughness;

        public cgltf_pbr_specular_glossiness pbr_specular_glossiness;

        public cgltf_clearcoat clearcoat;

        public cgltf_ior ior;

        public cgltf_specular specular;

        public cgltf_sheen sheen;

        public cgltf_transmission transmission;

        public cgltf_volume volume;

        public cgltf_emissive_strength emissive_strength;

        public cgltf_iridescence iridescence;

        public cgltf_diffuse_transmission diffuse_transmission;

        public cgltf_anisotropy anisotropy;

        public cgltf_dispersion dispersion;

        public cgltf_texture_view normal_texture;

        public cgltf_texture_view occlusion_texture;

        public cgltf_texture_view emissive_texture;


        public fixed float emissive_factor[3];

        public cgltf_alpha_mode alpha_mode;


        public float alpha_cutoff;


        public int double_sided;


        public int unlit;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_material_mapping
    {

        public UIntPtr variant;

        public cgltf_material* material;

        public cgltf_extras extras;
    }

    public unsafe partial struct cgltf_morph_target
    {
        public cgltf_attribute* attributes;


        public UIntPtr attributes_count;
    }

    public unsafe partial struct cgltf_draco_mesh_compression
    {
        public cgltf_buffer_view* buffer_view;

        public cgltf_attribute* attributes;


        public UIntPtr attributes_count;
    }

    public unsafe partial struct cgltf_mesh_gpu_instancing
    {
        public cgltf_attribute* attributes;


        public UIntPtr attributes_count;
    }

    public unsafe partial struct cgltf_primitive
    {
        public cgltf_primitive_type type;

        public cgltf_accessor* indices;

        public cgltf_material* material;

        public cgltf_attribute* attributes;


        public UIntPtr attributes_count;

        public cgltf_morph_target* targets;


        public UIntPtr targets_count;

        public cgltf_extras extras;


        public int has_draco_mesh_compression;

        public cgltf_draco_mesh_compression draco_mesh_compression;

        public cgltf_material_mapping* mappings;


        public UIntPtr mappings_count;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_mesh
    {

        public string name;

        public cgltf_primitive* primitives;


        public UIntPtr primitives_count;


        public float* weights;


        public UIntPtr weights_count;


        public string* target_names;


        public UIntPtr target_names_count;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_skin
    {

        public string name;

        public cgltf_node** joints;


        public UIntPtr joints_count;

        public cgltf_node* skeleton;

        public cgltf_accessor* inverse_bind_matrices;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public partial struct cgltf_camera_perspective
    {

        public int has_aspect_ratio;


        public float aspect_ratio;


        public float yfov;


        public int has_zfar;


        public float zfar;


        public float znear;

        public cgltf_extras extras;
    }

    public partial struct cgltf_camera_orthographic
    {

        public float xmag;


        public float ymag;


        public float zfar;


        public float znear;

        public cgltf_extras extras;
    }

    public unsafe partial struct cgltf_camera
    {

        public string name;

        public cgltf_camera_type type;


        public _data_e__Union data;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;

        [StructLayout(LayoutKind.Explicit)]
        public partial struct _data_e__Union
        {
            [FieldOffset(0)]
            public cgltf_camera_perspective perspective;

            [FieldOffset(0)]
            public cgltf_camera_orthographic orthographic;
        }
    }

    public unsafe partial struct cgltf_light
    {

        public string name;


        public fixed float color[3];


        public float intensity;

        public cgltf_light_type type;


        public float range;


        public float spot_inner_cone_angle;


        public float spot_outer_cone_angle;

        public cgltf_extras extras;
    }

    public unsafe partial struct cgltf_node
    {

        public string name;

        public cgltf_node* parent;

        public cgltf_node** children;


        public UIntPtr children_count;

        public cgltf_skin* skin;

        public cgltf_mesh* mesh;

        public cgltf_camera* camera;

        public cgltf_light* light;


        public float* weights;


        public UIntPtr weights_count;


        public int has_translation;


        public int has_rotation;


        public int has_scale;


        public int has_matrix;


        public fixed float translation[3];


        public fixed float rotation[4];


        public fixed float scale[3];


        public fixed float matrix[16];

        public cgltf_extras extras;


        public int has_mesh_gpu_instancing;

        public cgltf_mesh_gpu_instancing mesh_gpu_instancing;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_scene
    {

        public string name;

        public cgltf_node** nodes;


        public UIntPtr nodes_count;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_animation_sampler
    {
        public cgltf_accessor* input;

        public cgltf_accessor* output;

        public cgltf_interpolation_type interpolation;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_animation_channel
    {
        public cgltf_animation_sampler* sampler;

        public cgltf_node* target_node;

        public cgltf_animation_path_type target_path;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_animation
    {

        public string name;

        public cgltf_animation_sampler* samplers;


        public UIntPtr samplers_count;

        public cgltf_animation_channel* channels;


        public UIntPtr channels_count;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_material_variant
    {

        public string name;

        public cgltf_extras extras;
    }

    public unsafe partial struct cgltf_asset
    {

        public string copyright;


        public string generator;


        public string version;


        public string min_version;

        public cgltf_extras extras;


        public UIntPtr extensions_count;

        public cgltf_extension* extensions;
    }

    public unsafe partial struct cgltf_data
    {
        public cgltf_file_type file_type;

        public void* file_data;

        public cgltf_asset asset;

        public cgltf_mesh* meshes;


        public UIntPtr meshes_count;

        public cgltf_material* materials;


        public UIntPtr materials_count;

        public cgltf_accessor* accessors;


        public UIntPtr accessors_count;

        public cgltf_buffer_view* buffer_views;


        public UIntPtr buffer_views_count;

        public cgltf_buffer* buffers;


        public UIntPtr buffers_count;

        public cgltf_image* images;


        public UIntPtr images_count;

        public cgltf_texture* textures;


        public UIntPtr textures_count;

        public cgltf_sampler* samplers;


        public UIntPtr samplers_count;

        public cgltf_skin* skins;


        public UIntPtr skins_count;

        public cgltf_camera* cameras;


        public UIntPtr cameras_count;

        public cgltf_light* lights;


        public UIntPtr lights_count;

        public cgltf_node* nodes;


        public UIntPtr nodes_count;

        public cgltf_scene* scenes;


        public UIntPtr scenes_count;

        public cgltf_scene* scene;

        public cgltf_animation* animations;


        public UIntPtr animations_count;

        public cgltf_material_variant* variants;


        public UIntPtr variants_count;

        public cgltf_extras extras;


        public UIntPtr data_extensions_count;

        public cgltf_extension* data_extensions;


        public string* extensions_used;


        public UIntPtr extensions_used_count;


        public string* extensions_required;


        public UIntPtr extensions_required_count;


        public string json;


        public UIntPtr json_size;


        public void* bin;


        public UIntPtr bin_size;

        public cgltf_memory_options memory;

        public cgltf_file_options file;
    }

    public static unsafe partial class Methods
    {
        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern cgltf_result cgltf_parse(cgltf_options* options, void* data, UIntPtr size, cgltf_data** out_data);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern cgltf_result cgltf_parse_file(cgltf_options* options, string path, cgltf_data** out_data);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern cgltf_result cgltf_load_buffers(cgltf_options* options, cgltf_data* data, string gltf_path);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern cgltf_result cgltf_load_buffer_base64(cgltf_options* options, UIntPtr size, string base64, void** out_data);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_decode_string(string @string);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_decode_uri(string uri);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern cgltf_result cgltf_validate(cgltf_data* data);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cgltf_free(cgltf_data* data);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cgltf_node_transform_local(cgltf_node* node, float* out_matrix);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern void cgltf_node_transform_world(cgltf_node* node, float* out_matrix);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern byte* cgltf_buffer_view_data(cgltf_buffer_view* view);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern cgltf_accessor* cgltf_find_accessor(cgltf_primitive* prim, cgltf_attribute_type type, int index);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int cgltf_accessor_read_float(cgltf_accessor* accessor, UIntPtr index, float* @out, UIntPtr element_size);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern int cgltf_accessor_read_uint(cgltf_accessor* accessor, UIntPtr index, uint* @out, UIntPtr element_size);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_accessor_read_index(cgltf_accessor* accessor, UIntPtr index);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_num_components(cgltf_type type);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_component_size(cgltf_component_type component_type);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_calc_size(cgltf_type type, cgltf_component_type component_type);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_accessor_unpack_floats(cgltf_accessor* accessor, float* @out, UIntPtr float_count);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_accessor_unpack_indices(cgltf_accessor* accessor, void* @out, UIntPtr out_component_size, UIntPtr index_count);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]
        public static extern cgltf_result cgltf_copy_extras_json(cgltf_data* data, cgltf_extras* extras, string dest, UIntPtr* dest_size);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_mesh_index(cgltf_data* data, cgltf_mesh* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_material_index(cgltf_data* data, cgltf_material* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_accessor_index(cgltf_data* data, cgltf_accessor* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_buffer_view_index(cgltf_data* data, cgltf_buffer_view* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_buffer_index(cgltf_data* data, cgltf_buffer* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_image_index(cgltf_data* data, cgltf_image* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_texture_index(cgltf_data* data, cgltf_texture* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_sampler_index(cgltf_data* data, cgltf_sampler* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_skin_index(cgltf_data* data, cgltf_skin* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_camera_index(cgltf_data* data, cgltf_camera* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_light_index(cgltf_data* data, cgltf_light* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_node_index(cgltf_data* data, cgltf_node* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_scene_index(cgltf_data* data, cgltf_scene* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_animation_index(cgltf_data* data, cgltf_animation* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_animation_sampler_index(cgltf_animation* animation, cgltf_animation_sampler* @object);

        [DllImport("cgltf", CallingConvention = CallingConvention.Cdecl, ExactSpelling = true)]

        public static extern UIntPtr cgltf_animation_channel_index(cgltf_animation* animation, cgltf_animation_channel* @object);
    }
}
