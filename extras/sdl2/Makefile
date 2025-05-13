VPATH := $(dir $(abspath $(firstword $(MAKEFILE_LIST))))

TARGETNAME := SDL2
INCFLAGS := $(addprefix -I,$(shell $(CC) -xc /dev/null -E -Wp,-v 2>&1 |sed -n 's,^ ,,p'))

SDL_PREFIX ?= /usr/include/

INCLUDES_SDL2 := \
						$(SDL_PREFIX)SDL2/SDL.h \

INCLUDES_SDL2_ALL := \
						$(SDL_PREFIX)SDL2/SDL.h \
						$(SDL_PREFIX)SDL2/SDL_assert.h \
						$(SDL_PREFIX)SDL2/SDL_audio.h \
						$(SDL_PREFIX)SDL2/SDL_bits.h \
						$(SDL_PREFIX)SDL2/SDL_blendmode.h \
						$(SDL_PREFIX)SDL2/SDL_clipboard.h \
						$(SDL_PREFIX)SDL2/SDL_config.h \
						$(SDL_PREFIX)SDL2/SDL_cpuinfo.h \
						$(SDL_PREFIX)SDL2/SDL_error.h \
						$(SDL_PREFIX)SDL2/SDL_events.h \
						$(SDL_PREFIX)SDL2/SDL_gamecontroller.h \
						$(SDL_PREFIX)SDL2/SDL_gesture.h \
						$(SDL_PREFIX)SDL2/SDL_guid.h \
						$(SDL_PREFIX)SDL2/SDL_haptic.h \
						$(SDL_PREFIX)SDL2/SDL_hints.h \
						$(SDL_PREFIX)SDL2/SDL_joystick.h \
						$(SDL_PREFIX)SDL2/SDL_keyboard.h \
						$(SDL_PREFIX)SDL2/SDL_keycode.h \
						$(SDL_PREFIX)SDL2/SDL_loadso.h \
						$(SDL_PREFIX)SDL2/SDL_log.h \
						$(SDL_PREFIX)SDL2/SDL_main.h \
						$(SDL_PREFIX)SDL2/SDL_messagebox.h \
						$(SDL_PREFIX)SDL2/SDL_mouse.h \
						$(SDL_PREFIX)SDL2/SDL_mutex.h \
						$(SDL_PREFIX)SDL2/SDL_name.h \
						$(SDL_PREFIX)SDL2/SDL_opengles2.h \
						$(SDL_PREFIX)SDL2/SDL_opengles.h \
						$(SDL_PREFIX)SDL2/SDL_opengl.h \
						$(SDL_PREFIX)SDL2/SDL_pixels.h \
						$(SDL_PREFIX)SDL2/SDL_platform.h \
						$(SDL_PREFIX)SDL2/SDL_power.h \
						$(SDL_PREFIX)SDL2/SDL_quit.h \
						$(SDL_PREFIX)SDL2/SDL_rect.h \
						$(SDL_PREFIX)SDL2/SDL_render.h \
						$(SDL_PREFIX)SDL2/SDL_revision.h \
						$(SDL_PREFIX)SDL2/SDL_rwops.h \
						$(SDL_PREFIX)SDL2/SDL_scancode.h \
						$(SDL_PREFIX)SDL2/SDL_sensor.h \
						$(SDL_PREFIX)SDL2/SDL_shape.h \
						$(SDL_PREFIX)SDL2/SDL_surface.h \
						$(SDL_PREFIX)SDL2/SDL_system.h \
						$(SDL_PREFIX)SDL2/SDL_syswm.h \
						$(SDL_PREFIX)SDL2/SDL_thread.h \
						$(SDL_PREFIX)SDL2/SDL_timer.h \
						$(SDL_PREFIX)SDL2/SDL_touch.h \
						$(SDL_PREFIX)SDL2/SDL_types.h \
						$(SDL_PREFIX)SDL2/SDL_version.h \
						$(SDL_PREFIX)SDL2/SDL_video.h \
						$(SDL_PREFIX)SDL2/SDL_stdinc.h

CSPIG ?= $(shell command -v ClangSharpPInvokeGenerator)
ifeq ($(CSPIG),)
$(error ClangSharpPInvokeGenerator missing)
endif

SED ?= $(shell command -v sed)
ifeq ($(SED),)
$(error sed missing)
endif

CFLAGS += -fPIC -fvisibility=hidden
CFLAGS += -Iinclude

CSPIGFLAGS += -x c -std c99 -c generate-macro-bindings -c compatible-codegen -e SDL_memset4 -e SDL_memcpy4 -e SDL_vsscanf -e SDL_vasprintf -e SDL_vsnprintf -e SDL_LogMessageV -D FILE=void -D __FILE_defined=1 -e SDL_FRectEquals -e SDL_FRectEqualsEpsilon -e SDL_RectEquals -e _SDL_size_mul_overflow_builtin -e _SDL_size_add_overflow_builtin -e SDL_size_mul_overflow -e SDL_size_add_overflow -e SDL_BlitSurface -e SDL_BlitScaled -D CS_CODEGEN -a -include -a nointrin.h

LDLIBS += -ldl

.PHONY: all
all: SDL2.cs

SDL2.cs: $(INCLUDES_SDL2)
	$(CSPIG) $(CSPIGFLAGS) $(addprefix -t ,$(INCLUDES_SDL2_ALL)) $(addprefix -f ,$^) -o $@ -l $(TARGETNAME) -n SDL2 $(INCFLAGS) ||:
	$(SED) -i \
		-e '/NativeType\w*("#define/d' \
		-e 's/\(^\s*\)\?\[\(\w*:\s*\)\?NativeType\w*("[^"]*")\]\s*//g' \
		-e 's/SDL_SCANCODE\w*\s*|/(uint)&/g' \
		-e 's/sbyte\s*\*/string/g' \
		-e '/= ;$$/d' $@ \
		-e '/const U*IntPtr/d' \
		-e '/(nu*int)/d' \
		-e '/ReadOnlySpan</d'

.PHONY: clean distclean
clean:

distclean: clean
	$(RM) SDL2.cs
