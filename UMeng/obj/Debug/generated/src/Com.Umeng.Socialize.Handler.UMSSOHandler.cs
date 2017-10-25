using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Handler {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']"
	[global::Android.Runtime.Register ("com/umeng/socialize/handler/UMSSOHandler", DoNotGenerateAcw=true)]
	public abstract partial class UMSSOHandler : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='ACCESSTOKEN']"
		[Register ("ACCESSTOKEN")]
		protected const string Accesstoken = (string) "accessToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='ACCESS_SECRET']"
		[Register ("ACCESS_SECRET")]
		protected const string AccessSecret = (string) "access_secret";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='ACCESS_TOKEN']"
		[Register ("ACCESS_TOKEN")]
		protected const string AccessToken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='CITY']"
		[Register ("CITY")]
		protected const string City = (string) "city";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='COUNTRY']"
		[Register ("COUNTRY")]
		protected const string Country = (string) "country";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='EMAIL']"
		[Register ("EMAIL")]
		protected const string Email = (string) "email";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='EXPIRATION']"
		[Register ("EXPIRATION")]
		protected const string Expiration = (string) "expiration";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='EXPIRES_IN']"
		[Register ("EXPIRES_IN")]
		protected const string ExpiresIn = (string) "expires_in";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='FIRST_NAME']"
		[Register ("FIRST_NAME")]
		protected const string FirstName = (string) "first_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='GENDER']"
		[Register ("GENDER")]
		protected const string Gender = (string) "gender";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='ICON']"
		[Register ("ICON")]
		protected const string Icon = (string) "iconurl";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='ID']"
		[Register ("ID")]
		protected const string Id = (string) "id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='JSON']"
		[Register ("JSON")]
		protected const string Json = (string) "json";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='LAST_NAME']"
		[Register ("LAST_NAME")]
		protected const string LastName = (string) "last_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='MIDDLE_NAME']"
		[Register ("MIDDLE_NAME")]
		protected const string MiddleName = (string) "middle_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='NAME']"
		[Register ("NAME")]
		protected const string Name = (string) "name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='OPENID']"
		[Register ("OPENID")]
		protected const string Openid = (string) "openid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='PROFILE_IMAGE_URL']"
		[Register ("PROFILE_IMAGE_URL")]
		[Obsolete ("deprecated")]
		protected const string ProfileImageUrl = (string) "profile_image_url";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='PROVINCE']"
		[Register ("PROVINCE")]
		protected const string Province = (string) "province";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='REFRESHTOKEN']"
		[Register ("REFRESHTOKEN")]
		protected const string Refreshtoken = (string) "refreshToken";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='REFRESH_TOKEN']"
		[Register ("REFRESH_TOKEN")]
		protected const string RefreshToken = (string) "refresh_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='SCREEN_NAME']"
		[Register ("SCREEN_NAME")]
		[Obsolete ("deprecated")]
		protected const string ScreenName = (string) "screen_name";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='UID']"
		[Register ("UID")]
		protected const string Uid = (string) "uid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='UNIONID']"
		[Register ("UNIONID")]
		protected const string Unionid = (string) "unionid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='USID']"
		[Register ("USID")]
		protected const string Usid = (string) "usid";

		static IntPtr mShareConfig_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='mShareConfig']"
		[Register ("mShareConfig")]
		protected global::Com.Umeng.Socialize.UMShareConfig MShareConfig {
			get {
				if (mShareConfig_jfieldId == IntPtr.Zero)
					mShareConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "mShareConfig", "Lcom/umeng/socialize/UMShareConfig;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mShareConfig_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mShareConfig_jfieldId == IntPtr.Zero)
					mShareConfig_jfieldId = JNIEnv.GetFieldID (class_ref, "mShareConfig", "Lcom/umeng/socialize/UMShareConfig;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mShareConfig_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mThumbLimit_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='mThumbLimit']"
		[Register ("mThumbLimit")]
		protected int MThumbLimit {
			get {
				if (mThumbLimit_jfieldId == IntPtr.Zero)
					mThumbLimit_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbLimit", "I");
				return JNIEnv.GetIntField (((global::Java.Lang.Object) this).Handle, mThumbLimit_jfieldId);
			}
			set {
				if (mThumbLimit_jfieldId == IntPtr.Zero)
					mThumbLimit_jfieldId = JNIEnv.GetFieldID (class_ref, "mThumbLimit", "I");
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mThumbLimit_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr mWeakAct_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/field[@name='mWeakAct']"
		[Register ("mWeakAct")]
		protected global::Java.Lang.Ref.WeakReference MWeakAct {
			get {
				if (mWeakAct_jfieldId == IntPtr.Zero)
					mWeakAct_jfieldId = JNIEnv.GetFieldID (class_ref, "mWeakAct", "Ljava/lang/ref/WeakReference;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mWeakAct_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Ref.WeakReference> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mWeakAct_jfieldId == IntPtr.Zero)
					mWeakAct_jfieldId = JNIEnv.GetFieldID (class_ref, "mWeakAct", "Ljava/lang/ref/WeakReference;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mWeakAct_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/handler/UMSSOHandler", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMSSOHandler); }
		}

		protected UMSSOHandler (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/constructor[@name='UMSSOHandler' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UMSSOHandler ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UMSSOHandler)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static Delegate cb_getConfig;
#pragma warning disable 0169
		static Delegate GetGetConfigHandler ()
		{
			if (cb_getConfig == null)
				cb_getConfig = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetConfig);
			return cb_getConfig;
		}

		static IntPtr n_GetConfig (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Config);
		}
#pragma warning restore 0169

		static IntPtr id_getConfig;
		public virtual unsafe global::Com.Umeng.Socialize.PlatformConfig.IPlatform Config {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getConfig' and count(parameter)=0]"
			[Register ("getConfig", "()Lcom/umeng/socialize/PlatformConfig$Platform;", "GetGetConfigHandler")]
			get {
				if (id_getConfig == IntPtr.Zero)
					id_getConfig = JNIEnv.GetMethodID (class_ref, "getConfig", "()Lcom/umeng/socialize/PlatformConfig$Platform;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.IPlatform> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getConfig), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.IPlatform> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getConfig", "()Lcom/umeng/socialize/PlatformConfig$Platform;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getContext;
#pragma warning disable 0169
		static Delegate GetGetContextHandler ()
		{
			if (cb_getContext == null)
				cb_getContext = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetContext);
			return cb_getContext;
		}

		static IntPtr n_GetContext (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.Context);
		}
#pragma warning restore 0169

		static IntPtr id_getContext;
		public virtual unsafe global::Android.Content.Context Context {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getContext' and count(parameter)=0]"
			[Register ("getContext", "()Landroid/content/Context;", "GetGetContextHandler")]
			get {
				if (id_getContext == IntPtr.Zero)
					id_getContext = JNIEnv.GetMethodID (class_ref, "getContext", "()Landroid/content/Context;");
				try {

					if (GetType () == ThresholdType)
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getContext), JniHandleOwnership.TransferLocalRef);
					else
						return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getContext", "()Landroid/content/Context;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isAuthorize;
#pragma warning disable 0169
		static Delegate GetIsAuthorizeHandler ()
		{
			if (cb_isAuthorize == null)
				cb_isAuthorize = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsAuthorize);
			return cb_isAuthorize;
		}

		static bool n_IsAuthorize (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsAuthorize;
		}
#pragma warning restore 0169

		static IntPtr id_isAuthorize;
		public virtual unsafe bool IsAuthorize {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='isAuthorize' and count(parameter)=0]"
			[Register ("isAuthorize", "()Z", "GetIsAuthorizeHandler")]
			get {
				if (id_isAuthorize == IntPtr.Zero)
					id_isAuthorize = JNIEnv.GetMethodID (class_ref, "isAuthorize", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isAuthorize);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isAuthorize", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isHasAuthListener;
#pragma warning disable 0169
		static Delegate GetIsHasAuthListenerHandler ()
		{
			if (cb_isHasAuthListener == null)
				cb_isHasAuthListener = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsHasAuthListener);
			return cb_isHasAuthListener;
		}

		static bool n_IsHasAuthListener (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsHasAuthListener;
		}
#pragma warning restore 0169

		static IntPtr id_isHasAuthListener;
		public virtual unsafe bool IsHasAuthListener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='isHasAuthListener' and count(parameter)=0]"
			[Register ("isHasAuthListener", "()Z", "GetIsHasAuthListenerHandler")]
			get {
				if (id_isHasAuthListener == IntPtr.Zero)
					id_isHasAuthListener = JNIEnv.GetMethodID (class_ref, "isHasAuthListener", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isHasAuthListener);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isHasAuthListener", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isInstall;
#pragma warning disable 0169
		static Delegate GetIsInstallHandler ()
		{
			if (cb_isInstall == null)
				cb_isInstall = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsInstall);
			return cb_isInstall;
		}

		static bool n_IsInstall (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsInstall;
		}
#pragma warning restore 0169

		static IntPtr id_isInstall;
		public virtual unsafe bool IsInstall {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='isInstall' and count(parameter)=0]"
			[Register ("isInstall", "()Z", "GetIsInstallHandler")]
			get {
				if (id_isInstall == IntPtr.Zero)
					id_isInstall = JNIEnv.GetMethodID (class_ref, "isInstall", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isInstall);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isInstall", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSupport;
#pragma warning disable 0169
		static Delegate GetIsSupportHandler ()
		{
			if (cb_isSupport == null)
				cb_isSupport = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupport);
			return cb_isSupport;
		}

		static bool n_IsSupport (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupport;
		}
#pragma warning restore 0169

		static IntPtr id_isSupport;
		public virtual unsafe bool IsSupport {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='isSupport' and count(parameter)=0]"
			[Register ("isSupport", "()Z", "GetIsSupportHandler")]
			get {
				if (id_isSupport == IntPtr.Zero)
					id_isSupport = JNIEnv.GetMethodID (class_ref, "isSupport", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupport);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupport", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isSupportAuth;
#pragma warning disable 0169
		static Delegate GetIsSupportAuthHandler ()
		{
			if (cb_isSupportAuth == null)
				cb_isSupportAuth = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsSupportAuth);
			return cb_isSupportAuth;
		}

		static bool n_IsSupportAuth (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsSupportAuth;
		}
#pragma warning restore 0169

		static IntPtr id_isSupportAuth;
		public virtual unsafe bool IsSupportAuth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='isSupportAuth' and count(parameter)=0]"
			[Register ("isSupportAuth", "()Z", "GetIsSupportAuthHandler")]
			get {
				if (id_isSupportAuth == IntPtr.Zero)
					id_isSupportAuth = JNIEnv.GetMethodID (class_ref, "isSupportAuth", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isSupportAuth);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isSupportAuth", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getRequestCode;
#pragma warning disable 0169
		static Delegate GetGetRequestCodeHandler ()
		{
			if (cb_getRequestCode == null)
				cb_getRequestCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetRequestCode);
			return cb_getRequestCode;
		}

		static int n_GetRequestCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.RequestCode;
		}
#pragma warning restore 0169

		static IntPtr id_getRequestCode;
		public virtual unsafe int RequestCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getRequestCode' and count(parameter)=0]"
			[Register ("getRequestCode", "()I", "GetGetRequestCodeHandler")]
			get {
				if (id_getRequestCode == IntPtr.Zero)
					id_getRequestCode = JNIEnv.GetMethodID (class_ref, "getRequestCode", "()I");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getRequestCode);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRequestCode", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSDKVersion;
#pragma warning disable 0169
		static Delegate GetGetSDKVersionHandler ()
		{
			if (cb_getSDKVersion == null)
				cb_getSDKVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSDKVersion);
			return cb_getSDKVersion;
		}

		static IntPtr n_GetSDKVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SDKVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getSDKVersion;
		public virtual unsafe string SDKVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getSDKVersion' and count(parameter)=0]"
			[Register ("getSDKVersion", "()Ljava/lang/String;", "GetGetSDKVersionHandler")]
			get {
				if (id_getSDKVersion == IntPtr.Zero)
					id_getSDKVersion = JNIEnv.GetMethodID (class_ref, "getSDKVersion", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSDKVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSDKVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_getShareConfig;
		protected unsafe global::Com.Umeng.Socialize.UMShareConfig ShareConfig {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getShareConfig' and count(parameter)=0]"
			[Register ("getShareConfig", "()Lcom/umeng/socialize/UMShareConfig;", "GetGetShareConfigHandler")]
			get {
				if (id_getShareConfig == IntPtr.Zero)
					id_getShareConfig = JNIEnv.GetMethodID (class_ref, "getShareConfig", "()Lcom/umeng/socialize/UMShareConfig;");
				try {
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.UMShareConfig> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShareConfig), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getToName;
#pragma warning disable 0169
		static Delegate GetGetToNameHandler ()
		{
			if (cb_getToName == null)
				cb_getToName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToName);
			return cb_getToName;
		}

		static IntPtr n_GetToName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToName);
		}
#pragma warning restore 0169

		static IntPtr id_getToName;
		protected virtual unsafe string ToName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getToName' and count(parameter)=0]"
			[Register ("getToName", "()Ljava/lang/String;", "GetGetToNameHandler")]
			get {
				if (id_getToName == IntPtr.Zero)
					id_getToName = JNIEnv.GetMethodID (class_ref, "getToName", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_authorize_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetAuthorize_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_authorize_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_authorize_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_Authorize_Lcom_umeng_socialize_UMAuthListener_);
			return cb_authorize_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_Authorize_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p0 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Authorize (p0);
		}
#pragma warning restore 0169

		static IntPtr id_authorize_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='authorize' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("authorize", "(Lcom/umeng/socialize/UMAuthListener;)V", "GetAuthorize_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void Authorize (global::Com.Umeng.Socialize.IUMAuthListener p0)
		{
			if (id_authorize_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_authorize_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "authorize", "(Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_authorize_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "authorize", "(Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_deleteAuth_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetDeleteAuth_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_deleteAuth_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_deleteAuth_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_DeleteAuth_Lcom_umeng_socialize_UMAuthListener_);
			return cb_deleteAuth_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_DeleteAuth_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p0 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.DeleteAuth (p0);
		}
#pragma warning restore 0169

		static IntPtr id_deleteAuth_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='deleteAuth' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("deleteAuth", "(Lcom/umeng/socialize/UMAuthListener;)V", "GetDeleteAuth_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void DeleteAuth (global::Com.Umeng.Socialize.IUMAuthListener p0)
		{
			if (id_deleteAuth_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_deleteAuth_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "deleteAuth", "(Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_deleteAuth_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "deleteAuth", "(Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getGender_Ljava_lang_Object_;
#pragma warning disable 0169
		static Delegate GetGetGender_Ljava_lang_Object_Handler ()
		{
			if (cb_getGender_Ljava_lang_Object_ == null)
				cb_getGender_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetGender_Ljava_lang_Object_);
			return cb_getGender_Ljava_lang_Object_;
		}

		static IntPtr n_GetGender_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Java.Lang.Object p0 = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetGender (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getGender_Ljava_lang_Object_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getGender' and count(parameter)=1 and parameter[1][@type='java.lang.Object']]"
		[Register ("getGender", "(Ljava/lang/Object;)Ljava/lang/String;", "GetGetGender_Ljava_lang_Object_Handler")]
		public virtual unsafe string GetGender (global::Java.Lang.Object p0)
		{
			if (id_getGender_Ljava_lang_Object_ == IntPtr.Zero)
				id_getGender_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "getGender", "(Ljava/lang/Object;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getGender_Ljava_lang_Object_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getGender", "(Ljava/lang/Object;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetGetPlatformInfo_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_GetPlatformInfo_Lcom_umeng_socialize_UMAuthListener_);
			return cb_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_GetPlatformInfo_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p0 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.GetPlatformInfo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='getPlatformInfo' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("getPlatformInfo", "(Lcom/umeng/socialize/UMAuthListener;)V", "GetGetPlatformInfo_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void GetPlatformInfo (global::Com.Umeng.Socialize.IUMAuthListener p0)
		{
			if (id_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "getPlatformInfo", "(Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_getPlatformInfo_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPlatformInfo", "(Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onActivityResult_IILandroid_content_Intent_;
#pragma warning disable 0169
		static Delegate GetOnActivityResult_IILandroid_content_Intent_Handler ()
		{
			if (cb_onActivityResult_IILandroid_content_Intent_ == null)
				cb_onActivityResult_IILandroid_content_Intent_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, IntPtr>) n_OnActivityResult_IILandroid_content_Intent_);
			return cb_onActivityResult_IILandroid_content_Intent_;
		}

		static void n_OnActivityResult_IILandroid_content_Intent_ (IntPtr jnienv, IntPtr native__this, int p0, int p1, IntPtr native_p2)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Intent p2 = global::Java.Lang.Object.GetObject<global::Android.Content.Intent> (native_p2, JniHandleOwnership.DoNotTransfer);
			__this.OnActivityResult (p0, p1, p2);
		}
#pragma warning restore 0169

		static IntPtr id_onActivityResult_IILandroid_content_Intent_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='onActivityResult' and count(parameter)=3 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='android.content.Intent']]"
		[Register ("onActivityResult", "(IILandroid/content/Intent;)V", "GetOnActivityResult_IILandroid_content_Intent_Handler")]
		public virtual unsafe void OnActivityResult (int p0, int p1, global::Android.Content.Intent p2)
		{
			if (id_onActivityResult_IILandroid_content_Intent_ == IntPtr.Zero)
				id_onActivityResult_IILandroid_content_Intent_ = JNIEnv.GetMethodID (class_ref, "onActivityResult", "(IILandroid/content/Intent;)V");
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onActivityResult_IILandroid_content_Intent_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onActivityResult", "(IILandroid/content/Intent;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_;
#pragma warning disable 0169
		static Delegate GetOnCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_Handler ()
		{
			if (cb_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_ == null)
				cb_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_);
			return cb_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_;
		}

		static void n_OnCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.PlatformConfig.IPlatform p1 = (global::Com.Umeng.Socialize.PlatformConfig.IPlatform)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.PlatformConfig.IPlatform> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnCreate (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='onCreate' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.umeng.socialize.PlatformConfig.Platform']]"
		[Register ("onCreate", "(Landroid/content/Context;Lcom/umeng/socialize/PlatformConfig$Platform;)V", "GetOnCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_Handler")]
		public virtual unsafe void OnCreate (global::Android.Content.Context p0, global::Com.Umeng.Socialize.PlatformConfig.IPlatform p1)
		{
			if (id_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_ == IntPtr.Zero)
				id_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_ = JNIEnv.GetMethodID (class_ref, "onCreate", "(Landroid/content/Context;Lcom/umeng/socialize/PlatformConfig$Platform;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreate_Landroid_content_Context_Lcom_umeng_socialize_PlatformConfig_Platform_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreate", "(Landroid/content/Context;Lcom/umeng/socialize/PlatformConfig$Platform;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onResume;
#pragma warning disable 0169
		static Delegate GetOnResumeHandler ()
		{
			if (cb_onResume == null)
				cb_onResume = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnResume);
			return cb_onResume;
		}

		static void n_OnResume (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnResume ();
		}
#pragma warning restore 0169

		static IntPtr id_onResume;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='onResume' and count(parameter)=0]"
		[Register ("onResume", "()V", "GetOnResumeHandler")]
		public virtual unsafe void OnResume ()
		{
			if (id_onResume == IntPtr.Zero)
				id_onResume = JNIEnv.GetMethodID (class_ref, "onResume", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onResume);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onResume", "()V"));
			} finally {
			}
		}

		static Delegate cb_release;
#pragma warning disable 0169
		static Delegate GetReleaseHandler ()
		{
			if (cb_release == null)
				cb_release = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Release);
			return cb_release;
		}

		static void n_Release (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Release ();
		}
#pragma warning restore 0169

		static IntPtr id_release;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='release' and count(parameter)=0]"
		[Register ("release", "()V", "GetReleaseHandler")]
		public virtual unsafe void Release ()
		{
			if (id_release == IntPtr.Zero)
				id_release = JNIEnv.GetMethodID (class_ref, "release", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_release);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "release", "()V"));
			} finally {
			}
		}

		static Delegate cb_setAuthListener_Lcom_umeng_socialize_UMAuthListener_;
#pragma warning disable 0169
		static Delegate GetSetAuthListener_Lcom_umeng_socialize_UMAuthListener_Handler ()
		{
			if (cb_setAuthListener_Lcom_umeng_socialize_UMAuthListener_ == null)
				cb_setAuthListener_Lcom_umeng_socialize_UMAuthListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAuthListener_Lcom_umeng_socialize_UMAuthListener_);
			return cb_setAuthListener_Lcom_umeng_socialize_UMAuthListener_;
		}

		static void n_SetAuthListener_Lcom_umeng_socialize_UMAuthListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMAuthListener p0 = (global::Com.Umeng.Socialize.IUMAuthListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMAuthListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetAuthListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAuthListener_Lcom_umeng_socialize_UMAuthListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='setAuthListener' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMAuthListener']]"
		[Register ("setAuthListener", "(Lcom/umeng/socialize/UMAuthListener;)V", "GetSetAuthListener_Lcom_umeng_socialize_UMAuthListener_Handler")]
		public virtual unsafe void SetAuthListener (global::Com.Umeng.Socialize.IUMAuthListener p0)
		{
			if (id_setAuthListener_Lcom_umeng_socialize_UMAuthListener_ == IntPtr.Zero)
				id_setAuthListener_Lcom_umeng_socialize_UMAuthListener_ = JNIEnv.GetMethodID (class_ref, "setAuthListener", "(Lcom/umeng/socialize/UMAuthListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAuthListener_Lcom_umeng_socialize_UMAuthListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAuthListener", "(Lcom/umeng/socialize/UMAuthListener;)V"), __args);
			} finally {
			}
		}

		static IntPtr id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='setShareConfig' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.UMShareConfig']]"
		[Register ("setShareConfig", "(Lcom/umeng/socialize/UMShareConfig;)V", "")]
		public unsafe void SetShareConfig (global::Com.Umeng.Socialize.UMShareConfig p0)
		{
			if (id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ == IntPtr.Zero)
				id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_ = JNIEnv.GetMethodID (class_ref, "setShareConfig", "(Lcom/umeng/socialize/UMShareConfig;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setShareConfig_Lcom_umeng_socialize_UMShareConfig_, __args);
			} finally {
			}
		}

		static Delegate cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
#pragma warning disable 0169
		static Delegate GetShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler ()
		{
			if (cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == null)
				cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, bool>) n_Share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_);
			return cb_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		}

		static bool n_Share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.ShareContent p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.ShareContent> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.IUMShareListener p1 = (global::Com.Umeng.Socialize.IUMShareListener)global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.IUMShareListener> (native_p1, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.Share (p0, p1);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='share' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z", "GetShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler")]
		public abstract bool Share (global::Com.Umeng.Socialize.ShareContent p0, global::Com.Umeng.Socialize.IUMShareListener p1);

		static Delegate cb_uploadAuthData_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetUploadAuthData_Landroid_os_Bundle_Handler ()
		{
			if (cb_uploadAuthData_Landroid_os_Bundle_ == null)
				cb_uploadAuthData_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_UploadAuthData_Landroid_os_Bundle_);
			return cb_uploadAuthData_Landroid_os_Bundle_;
		}

		static void n_UploadAuthData_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Handler.UMSSOHandler __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Handler.UMSSOHandler> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.UploadAuthData (p0);
		}
#pragma warning restore 0169

		static IntPtr id_uploadAuthData_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='uploadAuthData' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("uploadAuthData", "(Landroid/os/Bundle;)V", "GetUploadAuthData_Landroid_os_Bundle_Handler")]
		protected virtual unsafe void UploadAuthData (global::Android.OS.Bundle p0)
		{
			if (id_uploadAuthData_Landroid_os_Bundle_ == IntPtr.Zero)
				id_uploadAuthData_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "uploadAuthData", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_uploadAuthData_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "uploadAuthData", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Umeng.Socialize.IUMAuthListener"
		public event EventHandler<global::Com.Umeng.Socialize.AuthCancelEventArgs> AuthCancel {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						__CreateIUMAuthListenerImplementor,
						SetAuthListener,
						__h => __h.OnAuthCancelHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						global::Com.Umeng.Socialize.IUMAuthListenerImplementor.__IsEmpty,
						__v => SetAuthListener (null),
						__h => __h.OnAuthCancelHandler -= value);
			}
		}

		public event EventHandler<global::Com.Umeng.Socialize.AuthCompleteEventArgs> AuthComplete {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						__CreateIUMAuthListenerImplementor,
						SetAuthListener,
						__h => __h.OnAuthCompleteHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						global::Com.Umeng.Socialize.IUMAuthListenerImplementor.__IsEmpty,
						__v => SetAuthListener (null),
						__h => __h.OnAuthCompleteHandler -= value);
			}
		}

		public event EventHandler<global::Com.Umeng.Socialize.AuthErrorEventArgs> AuthError {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						__CreateIUMAuthListenerImplementor,
						SetAuthListener,
						__h => __h.OnAuthErrorHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						global::Com.Umeng.Socialize.IUMAuthListenerImplementor.__IsEmpty,
						__v => SetAuthListener (null),
						__h => __h.OnAuthErrorHandler -= value);
			}
		}

		public event EventHandler<global::Com.Umeng.Socialize.AuthStartEventArgs> AuthStart {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						__CreateIUMAuthListenerImplementor,
						SetAuthListener,
						__h => __h.OnAuthStartHandler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Umeng.Socialize.IUMAuthListener, global::Com.Umeng.Socialize.IUMAuthListenerImplementor>(
						ref weak_implementor_SetAuthListener,
						global::Com.Umeng.Socialize.IUMAuthListenerImplementor.__IsEmpty,
						__v => SetAuthListener (null),
						__h => __h.OnAuthStartHandler -= value);
			}
		}

		WeakReference weak_implementor_SetAuthListener;

		global::Com.Umeng.Socialize.IUMAuthListenerImplementor __CreateIUMAuthListenerImplementor ()
		{
			return new global::Com.Umeng.Socialize.IUMAuthListenerImplementor (this);
		}
#endregion
	}

	[global::Android.Runtime.Register ("com/umeng/socialize/handler/UMSSOHandler", DoNotGenerateAcw=true)]
	internal partial class UMSSOHandlerInvoker : UMSSOHandler {

		public UMSSOHandlerInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (UMSSOHandlerInvoker); }
		}

		static IntPtr id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.handler']/class[@name='UMSSOHandler']/method[@name='share' and count(parameter)=2 and parameter[1][@type='com.umeng.socialize.ShareContent'] and parameter[2][@type='com.umeng.socialize.UMShareListener']]"
		[Register ("share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z", "GetShare_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_Handler")]
		public override unsafe bool Share (global::Com.Umeng.Socialize.ShareContent p0, global::Com.Umeng.Socialize.IUMShareListener p1)
		{
			if (id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ == IntPtr.Zero)
				id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_ = JNIEnv.GetMethodID (class_ref, "share", "(Lcom/umeng/socialize/ShareContent;Lcom/umeng/socialize/UMShareListener;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_share_Lcom_umeng_socialize_ShareContent_Lcom_umeng_socialize_UMShareListener_, __args);
				return __ret;
			} finally {
			}
		}

	}

}
