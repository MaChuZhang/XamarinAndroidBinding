using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']"
	[global::Android.Runtime.Register ("com/umeng/socialize/Config", DoNotGenerateAcw=true)]
	public partial class Config : global::Java.Lang.Object {


		static IntPtr DEBUG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='DEBUG']"
		[Register ("DEBUG")]
		public static bool Debug {
			get {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, DEBUG_jfieldId);
			}
			set {
				if (DEBUG_jfieldId == IntPtr.Zero)
					DEBUG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEBUG", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, DEBUG_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr Descriptor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='Descriptor']"
		[Register ("Descriptor")]
		public static string Descriptor {
			get {
				if (Descriptor_jfieldId == IntPtr.Zero)
					Descriptor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Descriptor", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, Descriptor_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (Descriptor_jfieldId == IntPtr.Zero)
					Descriptor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "Descriptor", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, Descriptor_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EntityKey_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='EntityKey']"
		[Register ("EntityKey")]
		public static string EntityKey {
			get {
				if (EntityKey_jfieldId == IntPtr.Zero)
					EntityKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EntityKey", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EntityKey_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EntityKey_jfieldId == IntPtr.Zero)
					EntityKey_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EntityKey", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EntityKey_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EntityName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='EntityName']"
		[Register ("EntityName")]
		public static string EntityName {
			get {
				if (EntityName_jfieldId == IntPtr.Zero)
					EntityName_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EntityName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EntityName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EntityName_jfieldId == IntPtr.Zero)
					EntityName_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EntityName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EntityName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr KaKaoLoginType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='KaKaoLoginType']"
		[Register ("KaKaoLoginType")]
		public static int KaKaoLoginType {
			get {
				if (KaKaoLoginType_jfieldId == IntPtr.Zero)
					KaKaoLoginType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KaKaoLoginType", "I");
				return JNIEnv.GetStaticIntField (class_ref, KaKaoLoginType_jfieldId);
			}
			set {
				if (KaKaoLoginType_jfieldId == IntPtr.Zero)
					KaKaoLoginType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KaKaoLoginType", "I");
				try {
					JNIEnv.SetStaticField (class_ref, KaKaoLoginType_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr LinkedInProfileScope_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='LinkedInProfileScope']"
		[Register ("LinkedInProfileScope")]
		public static int LinkedInProfileScope {
			get {
				if (LinkedInProfileScope_jfieldId == IntPtr.Zero)
					LinkedInProfileScope_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LinkedInProfileScope", "I");
				return JNIEnv.GetStaticIntField (class_ref, LinkedInProfileScope_jfieldId);
			}
			set {
				if (LinkedInProfileScope_jfieldId == IntPtr.Zero)
					LinkedInProfileScope_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LinkedInProfileScope", "I");
				try {
					JNIEnv.SetStaticField (class_ref, LinkedInProfileScope_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr LinkedInShareCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='LinkedInShareCode']"
		[Register ("LinkedInShareCode")]
		public static int LinkedInShareCode {
			get {
				if (LinkedInShareCode_jfieldId == IntPtr.Zero)
					LinkedInShareCode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LinkedInShareCode", "I");
				return JNIEnv.GetStaticIntField (class_ref, LinkedInShareCode_jfieldId);
			}
			set {
				if (LinkedInShareCode_jfieldId == IntPtr.Zero)
					LinkedInShareCode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LinkedInShareCode", "I");
				try {
					JNIEnv.SetStaticField (class_ref, LinkedInShareCode_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr MORE_TITLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='MORE_TITLE']"
		[Register ("MORE_TITLE")]
		public static string MoreTitle {
			get {
				if (MORE_TITLE_jfieldId == IntPtr.Zero)
					MORE_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MORE_TITLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MORE_TITLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MORE_TITLE_jfieldId == IntPtr.Zero)
					MORE_TITLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MORE_TITLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, MORE_TITLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr OpenEditor_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='OpenEditor']"
		[Register ("OpenEditor")]
		public static bool OpenEditor {
			get {
				if (OpenEditor_jfieldId == IntPtr.Zero)
					OpenEditor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OpenEditor", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, OpenEditor_jfieldId);
			}
			set {
				if (OpenEditor_jfieldId == IntPtr.Zero)
					OpenEditor_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OpenEditor", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, OpenEditor_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr QQAPPNAME_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='QQAPPNAME']"
		[Register ("QQAPPNAME")]
		public static string Qqappname {
			get {
				if (QQAPPNAME_jfieldId == IntPtr.Zero)
					QQAPPNAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQAPPNAME", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QQAPPNAME_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QQAPPNAME_jfieldId == IntPtr.Zero)
					QQAPPNAME_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQAPPNAME", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, QQAPPNAME_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr QQWITHQZONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='QQWITHQZONE']"
		[Register ("QQWITHQZONE")]
		public static int Qqwithqzone {
			get {
				if (QQWITHQZONE_jfieldId == IntPtr.Zero)
					QQWITHQZONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQWITHQZONE", "I");
				return JNIEnv.GetStaticIntField (class_ref, QQWITHQZONE_jfieldId);
			}
			set {
				if (QQWITHQZONE_jfieldId == IntPtr.Zero)
					QQWITHQZONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQWITHQZONE", "I");
				try {
					JNIEnv.SetStaticField (class_ref, QQWITHQZONE_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr SessionId_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='SessionId']"
		[Register ("SessionId")]
		public static string SessionId {
			get {
				if (SessionId_jfieldId == IntPtr.Zero)
					SessionId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SessionId", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SessionId_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SessionId_jfieldId == IntPtr.Zero)
					SessionId_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SessionId", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SessionId_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr UID_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='UID']"
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

		static IntPtr appName_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='appName']"
		[Register ("appName")]
		public static string AppName {
			get {
				if (appName_jfieldId == IntPtr.Zero)
					appName_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "appName", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, appName_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (appName_jfieldId == IntPtr.Zero)
					appName_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "appName", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, appName_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr connectionTimeOut_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='connectionTimeOut']"
		[Register ("connectionTimeOut")]
		public static int ConnectionTimeOut {
			get {
				if (connectionTimeOut_jfieldId == IntPtr.Zero)
					connectionTimeOut_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "connectionTimeOut", "I");
				return JNIEnv.GetStaticIntField (class_ref, connectionTimeOut_jfieldId);
			}
			set {
				if (connectionTimeOut_jfieldId == IntPtr.Zero)
					connectionTimeOut_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "connectionTimeOut", "I");
				try {
					JNIEnv.SetStaticField (class_ref, connectionTimeOut_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isFacebookRead_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='isFacebookRead']"
		[Register ("isFacebookRead")]
		public static bool IsFacebookRead {
			get {
				if (isFacebookRead_jfieldId == IntPtr.Zero)
					isFacebookRead_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isFacebookRead", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isFacebookRead_jfieldId);
			}
			set {
				if (isFacebookRead_jfieldId == IntPtr.Zero)
					isFacebookRead_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isFacebookRead", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isFacebookRead_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isJumptoAppStore_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='isJumptoAppStore']"
		[Register ("isJumptoAppStore")]
		public static bool IsJumptoAppStore {
			get {
				if (isJumptoAppStore_jfieldId == IntPtr.Zero)
					isJumptoAppStore_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isJumptoAppStore", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isJumptoAppStore_jfieldId);
			}
			set {
				if (isJumptoAppStore_jfieldId == IntPtr.Zero)
					isJumptoAppStore_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isJumptoAppStore", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isJumptoAppStore_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isNeedAuth_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='isNeedAuth']"
		[Register ("isNeedAuth")]
		public static bool IsNeedAuth {
			get {
				if (isNeedAuth_jfieldId == IntPtr.Zero)
					isNeedAuth_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isNeedAuth", "Z");
				return JNIEnv.GetStaticBooleanField (class_ref, isNeedAuth_jfieldId);
			}
			set {
				if (isNeedAuth_jfieldId == IntPtr.Zero)
					isNeedAuth_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isNeedAuth", "Z");
				try {
					JNIEnv.SetStaticField (class_ref, isNeedAuth_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr isUmengQQ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='isUmengQQ']"
		[Register ("isUmengQQ")]
		public static global::Java.Lang.Boolean IsUmengQQ {
			get {
				if (isUmengQQ_jfieldId == IntPtr.Zero)
					isUmengQQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUmengQQ", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, isUmengQQ_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (isUmengQQ_jfieldId == IntPtr.Zero)
					isUmengQQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUmengQQ", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, isUmengQQ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr isUmengSina_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='isUmengSina']"
		[Register ("isUmengSina")]
		public static global::Java.Lang.Boolean IsUmengSina {
			get {
				if (isUmengSina_jfieldId == IntPtr.Zero)
					isUmengSina_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUmengSina", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, isUmengSina_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (isUmengSina_jfieldId == IntPtr.Zero)
					isUmengSina_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUmengSina", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, isUmengSina_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr isUmengWx_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='isUmengWx']"
		[Register ("isUmengWx")]
		public static global::Java.Lang.Boolean IsUmengWx {
			get {
				if (isUmengWx_jfieldId == IntPtr.Zero)
					isUmengWx_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUmengWx", "Ljava/lang/Boolean;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, isUmengWx_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Boolean> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (isUmengWx_jfieldId == IntPtr.Zero)
					isUmengWx_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "isUmengWx", "Ljava/lang/Boolean;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetStaticField (class_ref, isUmengWx_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='mEncrypt']"
		[Register ("mEncrypt")]
		public const bool MEncrypt = (bool) true;

		static IntPtr readSocketTimeOut_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='readSocketTimeOut']"
		[Register ("readSocketTimeOut")]
		public static int ReadSocketTimeOut {
			get {
				if (readSocketTimeOut_jfieldId == IntPtr.Zero)
					readSocketTimeOut_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "readSocketTimeOut", "I");
				return JNIEnv.GetStaticIntField (class_ref, readSocketTimeOut_jfieldId);
			}
			set {
				if (readSocketTimeOut_jfieldId == IntPtr.Zero)
					readSocketTimeOut_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "readSocketTimeOut", "I");
				try {
					JNIEnv.SetStaticField (class_ref, readSocketTimeOut_jfieldId, value);
				} finally {
				}
			}
		}

		static IntPtr shareType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/field[@name='shareType']"
		[Register ("shareType")]
		public static string ShareType {
			get {
				if (shareType_jfieldId == IntPtr.Zero)
					shareType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "shareType", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, shareType_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (shareType_jfieldId == IntPtr.Zero)
					shareType_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "shareType", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, shareType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/Config", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Config); }
		}

		protected Config (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize']/class[@name='Config']/constructor[@name='Config' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe Config ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (Config)) {
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
