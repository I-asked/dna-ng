VPATH := $(dir $(abspath $(firstword $(MAKEFILE_LIST))))

TARGETNAME := cgltf
TARGET := lib$(TARGETNAME).so
INCFLAGS := $(addprefix -I,$(shell $(CC) -xc /dev/null -E -Wp,-v 2>&1 |sed -n 's,^ ,,p'))

OBJS := cgltf.o

INCLUDES_CGLTF := \
								 cgltf.h

INCLUDES_CGLTF_ALL := \
										 cgltf.h

CSPIG ?= $(shell command -v ClangSharpPInvokeGenerator)
ifeq ($(CSPIG),)
$(error ClangSharpPInvokeGenerator missing)
endif

SED ?= $(shell command -v sed)
ifeq ($(SED),)
$(error sed missing)
endif

PKGCONFIG ?= $(shell command -v pkg-config)

CFLAGS += -fPIC -fvisibility=hidden

CFLAGS += -DBUILD_LIBTYPE_SHARED

CSPIGFLAGS += -x c -std c99 -c generate-macro-bindings -c compatible-codegen -D CS_CODEGEN

.PHONY: all
all: $(TARGET) cgltf.cs

cgltf.cs: $(INCLUDES_CGLTF)
	$(CSPIG) $(CSPIGFLAGS) $(addprefix -t ,$(INCLUDES_CGLTF_ALL)) $(addprefix -f ,$^) -o $@ -l $(TARGETNAME) -n cgltf $(INCFLAGS) ||:
	$(SED) -i \
		-e '/NativeType\w*("#define/d' \
		-e 's/\(^\s*\)\?\[\(\w*:\s*\)\?NativeType\w*("[^"]*")\]\s*//g' \
		-e 's/sbyte\s*\*/string/g' \
		-e '/= ;$$/d' $@ \
		-e '/const U*IntPtr/d' \
		-e '/(nu*int)/d' \
		-e '/ReadOnlySpan</d'

$(TARGET): $(OBJS)
	$(CC) $(LDFLAGS) $(CFLAGS) -shared -o $@ $^ $(LDLIBS)

.PHONY: clean distclean
clean:
	$(RM) $(OBJS)

distclean: clean
	$(RM) cgltf.cs $(TARGET)
