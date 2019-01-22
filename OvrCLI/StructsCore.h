// This header should not be used directly
// It defines structs that should be identical between native and managed code, it will be included
// twice by OvrCLI.h to create identical structures in both worlds.

DECL_STRUCT(ovrwSessionStatus)
{
public:
	/// True if the process has VR focus and thus is visible in the HMD.
	bool IsVisible;

	/// True if an HMD is present.
	bool HmdPresent;

	/// True if the HMD is on the user's head.
	bool HmdMounted;

	/// True if the session is in a display-lost state. See ovr_SubmitFrame.
	bool DisplayLost;

	/// True if the application should initiate shutdown.
	bool ShouldQuit;

	/// True if UX has requested re-centering. Must call ovr_ClearShouldRecenterFlag,
	/// ovr_RecenterTrackingOrigin or ovr_SpecifyTrackingOrigin.
	bool ShouldRecenter;

	/// True if the application is the foreground application and receives input (e.g. Touch
	/// controller state). If this is false then the application is in the background (but possibly
	/// still visible) should hide any input representations such as hands.
	bool HasInputFocus;

	/// True if a system overlay is present, such as a dashboard. In this case the application
	/// (if visible) should pause while still drawing, avoid drawing near-field graphics so they
	/// don't visually fight with the system overlay, and consume fewer CPU and GPU resources.
	bool OverlayPresent;

	/// True if runtime is requesting that the application provide depth buffers with projection
	/// layers.
	bool DepthRequested;

#ifdef IS_CLI
	const void CopyTo(ovrwSessionStatus_Native &other)
	{
		other.IsVisible = this->IsVisible;
		other.HmdMounted = this->HmdMounted;
		other.ShouldQuit = this->ShouldQuit;
	}

	void CopyFrom(const ovrwSessionStatus_Native &other)
	{
		this->IsVisible = other.IsVisible;
		this->HmdMounted = other.HmdMounted;
		this->ShouldQuit = other.ShouldQuit;
	}
#endif
};