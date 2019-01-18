// This header should not be used directly
// It defines structs that should be identical between native and managed code, it will be included
// twice by OvrCLI.h to create identical structures in both worlds.

DECL_STRUCT(HmdDescription)
{
public:
	byte a;
	short b;
	int c;

#ifdef IS_CLI
	void CopyTo(HmdDescription_Native &other)
	{
		other.a = this->a;
		other.b = this->b;
		other.c = this->c;
	}

	void CopyFrom(HmdDescription_Native &other)
	{
		this->a = other.a;
		this->b = other.b;
		this->c = other.c;
	}
#endif
};