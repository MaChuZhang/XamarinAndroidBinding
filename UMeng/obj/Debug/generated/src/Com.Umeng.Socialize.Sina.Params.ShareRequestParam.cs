using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Sina.Params {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']"
	[global::Android.Runtime.Register ("com/umeng/socialize/sina/params/ShareRequestParam", DoNotGenerateAcw=true)]
	public partial class ShareRequestParam : global::Com.Umeng.Socialize.Sina.Params.BrowserRequestParamBase {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_AID']"
		[Register ("REQ_PARAM_AID")]
		public const string ReqParamAid = (string) "aid";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_KEY_HASH']"
		[Register ("REQ_PARAM_KEY_HASH")]
		public const string ReqParamKeyHash = (string) "key_hash";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_PACKAGENAME']"
		[Register ("REQ_PARAM_PACKAGENAME")]
		public const string ReqParamPackagename = (string) "packagename";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_PICINFO']"
		[Register ("REQ_PARAM_PICINFO")]
		public const string ReqParamPicinfo = (string) "picinfo";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_SOURCE']"
		[Register ("REQ_PARAM_SOURCE")]
		public const string ReqParamSource = (string) "source";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_TITLE']"
		[Register ("REQ_PARAM_TITLE")]
		public const string ReqParamTitle = (string) "title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_TOKEN']"
		[Register ("REQ_PARAM_TOKEN")]
		public const string ReqParamToken = (string) "access_token";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_PARAM_VERSION']"
		[Register ("REQ_PARAM_VERSION")]
		public const string ReqParamVersion = (string) "version";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='REQ_UPLOAD_PIC_PARAM_IMG']"
		[Register ("REQ_UPLOAD_PIC_PARAM_IMG")]
		public const string ReqUploadPicParamImg = (string) "img";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='RESP_UPLOAD_PIC_PARAM_CODE']"
		[Register ("RESP_UPLOAD_PIC_PARAM_CODE")]
		public const string RespUploadPicParamCode = (string) "code";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='RESP_UPLOAD_PIC_PARAM_DATA']"
		[Register ("RESP_UPLOAD_PIC_PARAM_DATA")]
		public const string RespUploadPicParamData = (string) "data";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='RESP_UPLOAD_PIC_SUCC_CODE']"
		[Register ("RESP_UPLOAD_PIC_SUCC_CODE")]
		public const int RespUploadPicSuccCode = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/field[@name='UPLOAD_PIC_URL']"
		[Register ("UPLOAD_PIC_URL")]
		public const string UploadPicUrl = (string) "http://service.weibo.com/share/mobilesdk_uppic.php";
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam.UploadPicResult']"
		[global::Android.Runtime.Register ("com/umeng/socialize/sina/params/ShareRequestParam$UploadPicResult", DoNotGenerateAcw=true)]
		public partial class UploadPicResult : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/sina/params/ShareRequestParam$UploadPicResult", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (UploadPicResult); }
			}

			protected UploadPicResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static Delegate cb_getCode;
#pragma warning disable 0169
			static Delegate GetGetCodeHandler ()
			{
				if (cb_getCode == null)
					cb_getCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetCode);
				return cb_getCode;
			}

			static int n_GetCode (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam.UploadPicResult __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam.UploadPicResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.Code;
			}
#pragma warning restore 0169

			static IntPtr id_getCode;
			public virtual unsafe int Code {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam.UploadPicResult']/method[@name='getCode' and count(parameter)=0]"
				[Register ("getCode", "()I", "GetGetCodeHandler")]
				get {
					if (id_getCode == IntPtr.Zero)
						id_getCode = JNIEnv.GetMethodID (class_ref, "getCode", "()I");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getCode);
						else
							return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCode", "()I"));
					} finally {
					}
				}
			}

			static Delegate cb_getPicId;
#pragma warning disable 0169
			static Delegate GetGetPicIdHandler ()
			{
				if (cb_getPicId == null)
					cb_getPicId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetPicId);
				return cb_getPicId;
			}

			static IntPtr n_GetPicId (IntPtr jnienv, IntPtr native__this)
			{
				global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam.UploadPicResult __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam.UploadPicResult> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.PicId);
			}
#pragma warning restore 0169

			static IntPtr id_getPicId;
			public virtual unsafe string PicId {
				// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam.UploadPicResult']/method[@name='getPicId' and count(parameter)=0]"
				[Register ("getPicId", "()Ljava/lang/String;", "GetGetPicIdHandler")]
				get {
					if (id_getPicId == IntPtr.Zero)
						id_getPicId = JNIEnv.GetMethodID (class_ref, "getPicId", "()Ljava/lang/String;");
					try {

						if (GetType () == ThresholdType)
							return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getPicId), JniHandleOwnership.TransferLocalRef);
						else
							return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPicId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
					} finally {
					}
				}
			}

			static IntPtr id_parse_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam.UploadPicResult']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("parse", "(Ljava/lang/String;)Lcom/umeng/socialize/sina/params/ShareRequestParam$UploadPicResult;", "")]
			public static unsafe global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam.UploadPicResult Parse (string p0)
			{
				if (id_parse_Ljava_lang_String_ == IntPtr.Zero)
					id_parse_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "parse", "(Ljava/lang/String;)Lcom/umeng/socialize/sina/params/ShareRequestParam$UploadPicResult;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam.UploadPicResult __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam.UploadPicResult> (JNIEnv.CallStaticObjectMethod  (class_ref, id_parse_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/sina/params/ShareRequestParam", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ShareRequestParam); }
		}

		protected ShareRequestParam (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/constructor[@name='ShareRequestParam' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public unsafe ShareRequestParam (global::Android.Content.Context p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (GetType () != typeof (ShareRequestParam)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/content/Context;)V", __args);
					return;
				}

				if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
					id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_content_Context_, __args);
			} finally {
			}
		}

		static Delegate cb_getAppKey;
#pragma warning disable 0169
		static Delegate GetGetAppKeyHandler ()
		{
			if (cb_getAppKey == null)
				cb_getAppKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppKey);
			return cb_getAppKey;
		}

		static IntPtr n_GetAppKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppKey);
		}
#pragma warning restore 0169

		static Delegate cb_setAppKey_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppKey_Ljava_lang_String_Handler ()
		{
			if (cb_setAppKey_Ljava_lang_String_ == null)
				cb_setAppKey_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppKey_Ljava_lang_String_);
			return cb_setAppKey_Ljava_lang_String_;
		}

		static void n_SetAppKey_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppKey = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppKey;
		static IntPtr id_setAppKey_Ljava_lang_String_;
		public virtual unsafe string AppKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='getAppKey' and count(parameter)=0]"
			[Register ("getAppKey", "()Ljava/lang/String;", "GetGetAppKeyHandler")]
			get {
				if (id_getAppKey == IntPtr.Zero)
					id_getAppKey = JNIEnv.GetMethodID (class_ref, "getAppKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='setAppKey' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppKey", "(Ljava/lang/String;)V", "GetSetAppKey_Ljava_lang_String_Handler")]
			set {
				if (id_setAppKey_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppKey_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppKey", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppKey_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppKey", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAppPackage;
#pragma warning disable 0169
		static Delegate GetGetAppPackageHandler ()
		{
			if (cb_getAppPackage == null)
				cb_getAppPackage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAppPackage);
			return cb_getAppPackage;
		}

		static IntPtr n_GetAppPackage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AppPackage);
		}
#pragma warning restore 0169

		static Delegate cb_setAppPackage_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetAppPackage_Ljava_lang_String_Handler ()
		{
			if (cb_setAppPackage_Ljava_lang_String_ == null)
				cb_setAppPackage_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetAppPackage_Ljava_lang_String_);
			return cb_setAppPackage_Ljava_lang_String_;
		}

		static void n_SetAppPackage_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AppPackage = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getAppPackage;
		static IntPtr id_setAppPackage_Ljava_lang_String_;
		public virtual unsafe string AppPackage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='getAppPackage' and count(parameter)=0]"
			[Register ("getAppPackage", "()Ljava/lang/String;", "GetGetAppPackageHandler")]
			get {
				if (id_getAppPackage == IntPtr.Zero)
					id_getAppPackage = JNIEnv.GetMethodID (class_ref, "getAppPackage", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAppPackage), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAppPackage", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='setAppPackage' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setAppPackage", "(Ljava/lang/String;)V", "GetSetAppPackage_Ljava_lang_String_Handler")]
			set {
				if (id_setAppPackage_Ljava_lang_String_ == IntPtr.Zero)
					id_setAppPackage_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setAppPackage", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setAppPackage_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAppPackage", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getAuthListenerKey;
#pragma warning disable 0169
		static Delegate GetGetAuthListenerKeyHandler ()
		{
			if (cb_getAuthListenerKey == null)
				cb_getAuthListenerKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetAuthListenerKey);
			return cb_getAuthListenerKey;
		}

		static IntPtr n_GetAuthListenerKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.AuthListenerKey);
		}
#pragma warning restore 0169

		static IntPtr id_getAuthListenerKey;
		public virtual unsafe string AuthListenerKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='getAuthListenerKey' and count(parameter)=0]"
			[Register ("getAuthListenerKey", "()Ljava/lang/String;", "GetGetAuthListenerKeyHandler")]
			get {
				if (id_getAuthListenerKey == IntPtr.Zero)
					id_getAuthListenerKey = JNIEnv.GetMethodID (class_ref, "getAuthListenerKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getAuthListenerKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getAuthListenerKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_hasImage;
#pragma warning disable 0169
		static Delegate GetHasImageHandler ()
		{
			if (cb_hasImage == null)
				cb_hasImage = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_HasImage);
			return cb_hasImage;
		}

		static bool n_HasImage (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.HasImage;
		}
#pragma warning restore 0169

		static IntPtr id_hasImage;
		public virtual unsafe bool HasImage {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='hasImage' and count(parameter)=0]"
			[Register ("hasImage", "()Z", "GetHasImageHandler")]
			get {
				if (id_hasImage == IntPtr.Zero)
					id_hasImage = JNIEnv.GetMethodID (class_ref, "hasImage", "()Z");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_hasImage);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "hasImage", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getHashKey;
#pragma warning disable 0169
		static Delegate GetGetHashKeyHandler ()
		{
			if (cb_getHashKey == null)
				cb_getHashKey = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHashKey);
			return cb_getHashKey;
		}

		static IntPtr n_GetHashKey (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HashKey);
		}
#pragma warning restore 0169

		static IntPtr id_getHashKey;
		public virtual unsafe string HashKey {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='getHashKey' and count(parameter)=0]"
			[Register ("getHashKey", "()Ljava/lang/String;", "GetGetHashKeyHandler")]
			get {
				if (id_getHashKey == IntPtr.Zero)
					id_getHashKey = JNIEnv.GetMethodID (class_ref, "getHashKey", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHashKey), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHashKey", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getShareContent;
#pragma warning disable 0169
		static Delegate GetGetShareContentHandler ()
		{
			if (cb_getShareContent == null)
				cb_getShareContent = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetShareContent);
			return cb_getShareContent;
		}

		static IntPtr n_GetShareContent (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ShareContent);
		}
#pragma warning restore 0169

		static IntPtr id_getShareContent;
		public virtual unsafe string ShareContent {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='getShareContent' and count(parameter)=0]"
			[Register ("getShareContent", "()Ljava/lang/String;", "GetGetShareContentHandler")]
			get {
				if (id_getShareContent == IntPtr.Zero)
					id_getShareContent = JNIEnv.GetMethodID (class_ref, "getShareContent", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getShareContent), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getShareContent", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getToken;
#pragma warning disable 0169
		static Delegate GetGetTokenHandler ()
		{
			if (cb_getToken == null)
				cb_getToken = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetToken);
			return cb_getToken;
		}

		static IntPtr n_GetToken (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Token);
		}
#pragma warning restore 0169

		static Delegate cb_setToken_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetToken_Ljava_lang_String_Handler ()
		{
			if (cb_setToken_Ljava_lang_String_ == null)
				cb_setToken_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetToken_Ljava_lang_String_);
			return cb_setToken_Ljava_lang_String_;
		}

		static void n_SetToken_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Token = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getToken;
		static IntPtr id_setToken_Ljava_lang_String_;
		public virtual unsafe string Token {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='getToken' and count(parameter)=0]"
			[Register ("getToken", "()Ljava/lang/String;", "GetGetTokenHandler")]
			get {
				if (id_getToken == IntPtr.Zero)
					id_getToken = JNIEnv.GetMethodID (class_ref, "getToken", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getToken), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getToken", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='setToken' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setToken", "(Ljava/lang/String;)V", "GetSetToken_Ljava_lang_String_Handler")]
			set {
				if (id_setToken_Ljava_lang_String_ == IntPtr.Zero)
					id_setToken_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setToken", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setToken_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setToken", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_;
#pragma warning disable 0169
		static Delegate GetBuildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_Handler ()
		{
			if (cb_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_ == null)
				cb_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_);
			return cb_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_;
		}

		static IntPtr n_BuildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Params.WeiboParameters p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.ToLocalJniHandle (__this.BuildUploadPicParam (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='buildUploadPicParam' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.sina.params.WeiboParameters']]"
		[Register ("buildUploadPicParam", "(Lcom/umeng/socialize/sina/params/WeiboParameters;)Lcom/umeng/socialize/sina/params/WeiboParameters;", "GetBuildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_Handler")]
		public virtual unsafe global::Com.Umeng.Socialize.Sina.Params.WeiboParameters BuildUploadPicParam (global::Com.Umeng.Socialize.Sina.Params.WeiboParameters p0)
		{
			if (id_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_ == IntPtr.Zero)
				id_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_ = JNIEnv.GetMethodID (class_ref, "buildUploadPicParam", "(Lcom/umeng/socialize/sina/params/WeiboParameters;)Lcom/umeng/socialize/sina/params/WeiboParameters;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				global::Com.Umeng.Socialize.Sina.Params.WeiboParameters __ret;
				if (GetType () == ThresholdType)
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildUploadPicParam_Lcom_umeng_socialize_sina_params_WeiboParameters_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.WeiboParameters> (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildUploadPicParam", "(Lcom/umeng/socialize/sina/params/WeiboParameters;)Lcom/umeng/socialize/sina/params/WeiboParameters;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static Delegate cb_buildUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetBuildUrl_Ljava_lang_String_Handler ()
		{
			if (cb_buildUrl_Ljava_lang_String_ == null)
				cb_buildUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildUrl_Ljava_lang_String_);
			return cb_buildUrl_Ljava_lang_String_;
		}

		static IntPtr n_BuildUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.BuildUrl (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildUrl_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='buildUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("buildUrl", "(Ljava/lang/String;)Ljava/lang/String;", "GetBuildUrl_Ljava_lang_String_Handler")]
		public virtual unsafe string BuildUrl (string p0)
		{
			if (id_buildUrl_Ljava_lang_String_ == IntPtr.Zero)
				id_buildUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "buildUrl", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildUrl_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildUrl", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_execRequest_Landroid_app_Activity_I;
#pragma warning disable 0169
		static Delegate GetExecRequest_Landroid_app_Activity_IHandler ()
		{
			if (cb_execRequest_Landroid_app_Activity_I == null)
				cb_execRequest_Landroid_app_Activity_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_ExecRequest_Landroid_app_Activity_I);
			return cb_execRequest_Landroid_app_Activity_I;
		}

		static void n_ExecRequest_Landroid_app_Activity_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ExecRequest (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_execRequest_Landroid_app_Activity_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='execRequest' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='int']]"
		[Register ("execRequest", "(Landroid/app/Activity;I)V", "GetExecRequest_Landroid_app_Activity_IHandler")]
		public override unsafe void ExecRequest (global::Android.App.Activity p0, int p1)
		{
			if (id_execRequest_Landroid_app_Activity_I == IntPtr.Zero)
				id_execRequest_Landroid_app_Activity_I = JNIEnv.GetMethodID (class_ref, "execRequest", "(Landroid/app/Activity;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_execRequest_Landroid_app_Activity_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "execRequest", "(Landroid/app/Activity;I)V"), __args);
			} finally {
			}
		}

		static Delegate cb_getBase64ImgData;
#pragma warning disable 0169
		static Delegate GetGetBase64ImgDataHandler ()
		{
			if (cb_getBase64ImgData == null)
				cb_getBase64ImgData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBase64ImgData);
			return cb_getBase64ImgData;
		}

		static IntPtr n_GetBase64ImgData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetBase64ImgData ());
		}
#pragma warning restore 0169

		static IntPtr id_getBase64ImgData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='getBase64ImgData' and count(parameter)=0]"
		[Register ("getBase64ImgData", "()[B", "GetGetBase64ImgDataHandler")]
		public virtual unsafe byte[] GetBase64ImgData ()
		{
			if (id_getBase64ImgData == IntPtr.Zero)
				id_getBase64ImgData = JNIEnv.GetMethodID (class_ref, "getBase64ImgData", "()[B");
			try {

				if (GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBase64ImgData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBase64ImgData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_onCreateRequestParamBundle_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnCreateRequestParamBundle_Landroid_os_Bundle_Handler ()
		{
			if (cb_onCreateRequestParamBundle_Landroid_os_Bundle_ == null)
				cb_onCreateRequestParamBundle_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnCreateRequestParamBundle_Landroid_os_Bundle_);
			return cb_onCreateRequestParamBundle_Landroid_os_Bundle_;
		}

		static void n_OnCreateRequestParamBundle_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnCreateRequestParamBundle (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onCreateRequestParamBundle_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='onCreateRequestParamBundle' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onCreateRequestParamBundle", "(Landroid/os/Bundle;)V", "GetOnCreateRequestParamBundle_Landroid_os_Bundle_Handler")]
		public override unsafe void OnCreateRequestParamBundle (global::Android.OS.Bundle p0)
		{
			if (id_onCreateRequestParamBundle_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onCreateRequestParamBundle_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onCreateRequestParamBundle", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onCreateRequestParamBundle_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onCreateRequestParamBundle", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onSetupRequestParam_Landroid_os_Bundle_;
#pragma warning disable 0169
		static Delegate GetOnSetupRequestParam_Landroid_os_Bundle_Handler ()
		{
			if (cb_onSetupRequestParam_Landroid_os_Bundle_ == null)
				cb_onSetupRequestParam_Landroid_os_Bundle_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_OnSetupRequestParam_Landroid_os_Bundle_);
			return cb_onSetupRequestParam_Landroid_os_Bundle_;
		}

		static void n_OnSetupRequestParam_Landroid_os_Bundle_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Bundle p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Bundle> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.OnSetupRequestParam (p0);
		}
#pragma warning restore 0169

		static IntPtr id_onSetupRequestParam_Landroid_os_Bundle_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='onSetupRequestParam' and count(parameter)=1 and parameter[1][@type='android.os.Bundle']]"
		[Register ("onSetupRequestParam", "(Landroid/os/Bundle;)V", "GetOnSetupRequestParam_Landroid_os_Bundle_Handler")]
		protected override unsafe void OnSetupRequestParam (global::Android.OS.Bundle p0)
		{
			if (id_onSetupRequestParam_Landroid_os_Bundle_ == IntPtr.Zero)
				id_onSetupRequestParam_Landroid_os_Bundle_ = JNIEnv.GetMethodID (class_ref, "onSetupRequestParam", "(Landroid/os/Bundle;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onSetupRequestParam_Landroid_os_Bundle_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onSetupRequestParam", "(Landroid/os/Bundle;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendSdkCancleResponse_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSendSdkCancleResponse_Landroid_app_Activity_Handler ()
		{
			if (cb_sendSdkCancleResponse_Landroid_app_Activity_ == null)
				cb_sendSdkCancleResponse_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendSdkCancleResponse_Landroid_app_Activity_);
			return cb_sendSdkCancleResponse_Landroid_app_Activity_;
		}

		static void n_SendSdkCancleResponse_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendSdkCancleResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendSdkCancleResponse_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='sendSdkCancleResponse' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("sendSdkCancleResponse", "(Landroid/app/Activity;)V", "GetSendSdkCancleResponse_Landroid_app_Activity_Handler")]
		public virtual unsafe void SendSdkCancleResponse (global::Android.App.Activity p0)
		{
			if (id_sendSdkCancleResponse_Landroid_app_Activity_ == IntPtr.Zero)
				id_sendSdkCancleResponse_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "sendSdkCancleResponse", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSdkCancleResponse_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSdkCancleResponse", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_Handler ()
		{
			if (cb_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_ == null)
				cb_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_SendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_);
			return cb_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_;
		}

		static void n_SendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.SendSdkErrorResponse (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='sendSdkErrorResponse' and count(parameter)=2 and parameter[1][@type='android.app.Activity'] and parameter[2][@type='java.lang.String']]"
		[Register ("sendSdkErrorResponse", "(Landroid/app/Activity;Ljava/lang/String;)V", "GetSendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_Handler")]
		public virtual unsafe void SendSdkErrorResponse (global::Android.App.Activity p0, string p1)
		{
			if (id_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_ == IntPtr.Zero)
				id_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "sendSdkErrorResponse", "(Landroid/app/Activity;Ljava/lang/String;)V");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSdkErrorResponse_Landroid_app_Activity_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSdkErrorResponse", "(Landroid/app/Activity;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_sendSdkOkResponse_Landroid_app_Activity_;
#pragma warning disable 0169
		static Delegate GetSendSdkOkResponse_Landroid_app_Activity_Handler ()
		{
			if (cb_sendSdkOkResponse_Landroid_app_Activity_ == null)
				cb_sendSdkOkResponse_Landroid_app_Activity_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SendSdkOkResponse_Landroid_app_Activity_);
			return cb_sendSdkOkResponse_Landroid_app_Activity_;
		}

		static void n_SendSdkOkResponse_Landroid_app_Activity_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.App.Activity p0 = global::Java.Lang.Object.GetObject<global::Android.App.Activity> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SendSdkOkResponse (p0);
		}
#pragma warning restore 0169

		static IntPtr id_sendSdkOkResponse_Landroid_app_Activity_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='sendSdkOkResponse' and count(parameter)=1 and parameter[1][@type='android.app.Activity']]"
		[Register ("sendSdkOkResponse", "(Landroid/app/Activity;)V", "GetSendSdkOkResponse_Landroid_app_Activity_Handler")]
		public virtual unsafe void SendSdkOkResponse (global::Android.App.Activity p0)
		{
			if (id_sendSdkOkResponse_Landroid_app_Activity_ == IntPtr.Zero)
				id_sendSdkOkResponse_Landroid_app_Activity_ = JNIEnv.GetMethodID (class_ref, "sendSdkOkResponse", "(Landroid/app/Activity;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_sendSdkOkResponse_Landroid_app_Activity_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "sendSdkOkResponse", "(Landroid/app/Activity;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_;
#pragma warning disable 0169
		static Delegate GetSetBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_Handler ()
		{
			if (cb_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_ == null)
				cb_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_);
			return cb_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_;
		}

		static void n_SetBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Params.ShareRequestParam> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Umeng.Socialize.Sina.Message.BaseRequest p0 = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Sina.Message.BaseRequest> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetBaseRequest (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.sina.params']/class[@name='ShareRequestParam']/method[@name='setBaseRequest' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.sina.message.BaseRequest']]"
		[Register ("setBaseRequest", "(Lcom/umeng/socialize/sina/message/BaseRequest;)V", "GetSetBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_Handler")]
		public virtual unsafe void SetBaseRequest (global::Com.Umeng.Socialize.Sina.Message.BaseRequest p0)
		{
			if (id_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_ == IntPtr.Zero)
				id_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_ = JNIEnv.GetMethodID (class_ref, "setBaseRequest", "(Lcom/umeng/socialize/sina/message/BaseRequest;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBaseRequest_Lcom_umeng_socialize_sina_message_BaseRequest_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaseRequest", "(Lcom/umeng/socialize/sina/message/BaseRequest;)V"), __args);
			} finally {
			}
		}

	}
}
