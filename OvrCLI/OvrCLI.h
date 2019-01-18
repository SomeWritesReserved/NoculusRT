#pragma once

#define DECL_STRUCT(name) struct name##_Native
#include "StructsCore.h"

namespace OvrCLI
{
#define DECL_STRUCT(name) public value struct name
#define IS_CLI
#include "StructsCore.h"
}
