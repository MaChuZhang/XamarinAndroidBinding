using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']"
	[global::Android.Runtime.Register ("com/umeng/socialize/common/SocializeConstants", DoNotGenerateAcw=true)]
	public partial class SocializeConstants : global::Java.Lang.Object {


		static IntPtr APPKEY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='APPKEY']"
		[Register ("APPKEY")]
		public static string Appkey {
			get {
				if (APPKEY_jfieldId == IntPtr.Zero)
					APPKEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPKEY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPKEY_jfieldId == IntPtr.Zero)
					APPKEY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPKEY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr BACKKEY_COMPLETE_CLOSE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='BACKKEY_COMPLETE_CLOSE']"
		[Register ("BACKKEY_COMPLETE_CLOSE")]
		public static bool BackkeyCompleteClose {
			get {
				if (BACKKEY_COMPLETE_CLOSE_jfieldId == IntPtr.Zero)
					BACKKEY_COMPLETE_CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKKEY_COMPLETE_CLOSE", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, BACKKEY_COMPLETE_CLOSE_jfieldId);
			}
			set {
				if (BACKKEY_COMPLETE_CLOSE_jfieldId == IntPtr.Zero)
					BACKKEY_COMPLETE_CLOSE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "BACKKEY_COMPLETE_CLOSE", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, BACKKEY_COMPLETE_CLOSE_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='CANCLE_RESULTCODE']"
		[Register ("CANCLE_RESULTCODE")]
		public const int CancleResultcode = (int) 1000;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='COMMON_TAG']"
		[Register ("COMMON_TAG")]
		public const string CommonTag = (string) "com.umeng.socialize";

		static IntPtr DEBUG_MODE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='DEBUG_MODE']"
		[Register ("DEBUG_MODE")]
		public static bool DebugMode {
			get {
				if (DEBUG_MODE_jfieldId == IntPtr.Zero)
					DEBUG_MODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG_MODE", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_MODE_jfieldId);
			}
			set {
				if (DEBUG_MODE_jfieldId == IntPtr.Zero)
					DEBUG_MODE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG_MODE", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, DEBUG_MODE_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='DOWN_URL_QQ']"
		[Register ("DOWN_URL_QQ")]
		public const string DownUrlQq = (string) "http://log.umsns.com/link/qq/download/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='DOWN_URL_WX']"
		[Register ("DOWN_URL_WX")]
		public const string DownUrlWx = (string) "http://log.umsns.com/link/weixin/download/";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='KEY_AT']"
		[Register ("KEY_AT")]
		public const string KeyAt = (string) "at";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='KEY_LOCATION']"
		[Register ("KEY_LOCATION")]
		public const string KeyLocation = (string) "location";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='KEY_PIC']"
		[Register ("KEY_PIC")]
		public const string KeyPic = (string) "pic";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='KEY_PLATFORM']"
		[Register ("KEY_PLATFORM")]
		public const string KeyPlatform = (string) "media";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='KEY_TEXT']"
		[Register ("KEY_TEXT")]
		public const string KeyText = (string) "txt";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='KEY_TITLE']"
		[Register ("KEY_TITLE")]
		public const string KeyTitle = (string) "title";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='OS']"
		[Register ("OS")]
		public const string Os = (string) "Android";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='PROTOCOL_VERSON']"
		[Register ("PROTOCOL_VERSON")]
		public const string ProtocolVerson = (string) "2.0";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='SDK_VERSION']"
		[Register ("SDK_VERSION")]
		public const string SdkVersion = (string) "6.4.5";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='SERVER_RETURN_PARAMS_ILLEGAL']"
		[Register ("SERVER_RETURN_PARAMS_ILLEGAL")]
		public const int ServerReturnParamsIllegal = (int) 1998;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='SOCIAL_LINK']"
		[Register ("SOCIAL_LINK")]
		public const string SocialLink = (string) "http://www.umeng.com/social";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='SOCIAL_PREFERENCE_NAME']"
		[Register ("SOCIAL_PREFERENCE_NAME")]
		public const string SocialPreferenceName = (string) "umeng_socialize";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='SP_KEY_IS_OPEN_SHARE_EDIT']"
		[Register ("SP_KEY_IS_OPEN_SHARE_EDIT")]
		public const string SpKeyIsOpenShareEdit = (string) "is_open_share_edit";

		static IntPtr SUPPORT_PAD_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='SUPPORT_PAD']"
		[Register ("SUPPORT_PAD")]
		public static bool SupportPad {
			get {
				if (SUPPORT_PAD_jfieldId == IntPtr.Zero)
					SUPPORT_PAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORT_PAD", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, SUPPORT_PAD_jfieldId);
			}
			set {
				if (SUPPORT_PAD_jfieldId == IntPtr.Zero)
					SUPPORT_PAD_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SUPPORT_PAD", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, SUPPORT_PAD_jfieldId, value);
				} finally {
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='TENCENT_UID']"
		[Register ("TENCENT_UID")]
		public const string TencentUid = (string) "user_id";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='TIME']"
		[Register ("TIME")]
		public const string Time = (string) "request_time";

		static IntPtr UID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='UID']"
		[Register ("UID")]
		public static string Uid {
			get {
				if (UID_jfieldId == IntPtr.Zero)
					UID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UID", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UID_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UID_jfieldId == IntPtr.Zero)
					UID_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UID", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, UID_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/field[@name='USHARETYPE']"
		[Register ("USHARETYPE")]
		public const string Usharetype = (string) "u_sharetype";
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/common/SocializeConstants", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SocializeConstants); }
		}

		protected SocializeConstants (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.common']/class[@name='SocializeConstants']/constructor[@name='SocializeConstants' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe SocializeConstants ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (SocializeConstants)) {
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

	}
}
