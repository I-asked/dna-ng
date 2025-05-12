VPATH := $(dir $(abspath $(firstword $(MAKEFILE_LIST))))

TARGETNAME := rlgl
TARGET := lib$(TARGETNAME).so
OBJS := rlgl.o
INCFLAGS := $(addprefix -I,$(shell $(CC) -xc /dev/null -E -Wp,-v 2>&1 |sed -n 's,^ ,,p'))

CSPIG ?= $(shell command -v ClangSharpPInvokeGenerator)
ifeq ($(CSPIG),)
$(error ClangSharpPInvokeGenerator missing)
endif

SED ?= $(shell command -v sed)
ifeq ($(SED),)
$(error sed missing)
endif

CFLAGS += -fPIC -fvisibility=hidden

CFLAGS += -DGRAPHICS_API_OPENGL_33
CFLAGS += -DBUILD_LIBTYPE_SHARED

.PHONY: all
all: $(TARGET) RlGl.cs

RlGl.cs:
	$(CSPIG) -std c99 -x c -f rlgl.h -o $@ -l $(TARGETNAME) -n RlGl $(INCFLAGS)
	$(SED) -i 's/\(^\s*\)\?\[\(\w*:\s*\)\?NativeType\w*("[^"]*")\]\s*//g' $@

$(TARGET): $(OBJS)
	$(CC) $(LDFLAGS) $(CFLAGS) -shared -o $@ $^ $(LDLIBS)

.PHONY: clean distclean
clean:
	$(RM) $(OBJS)

distclean: clean
	$(RM) $(TARGET) RlGl.cs
