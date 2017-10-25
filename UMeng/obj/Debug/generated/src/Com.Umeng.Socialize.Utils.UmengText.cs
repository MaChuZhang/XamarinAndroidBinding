using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']"
	[global::Android.Runtime.Register ("com/umeng/socialize/utils/UmengText", DoNotGenerateAcw=true)]
	public partial class UmengText : global::Java.Lang.Object {


		static IntPtr ALIPAY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='ALIPAY']"
		[Register ("ALIPAY")]
		public static string Alipay {
			get {
				if (ALIPAY_jfieldId == IntPtr.Zero)
					ALIPAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIPAY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ALIPAY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (ALIPAY_jfieldId == IntPtr.Zero)
					ALIPAY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ALIPAY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, ALIPAY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APPKEY_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='APPKEY_ERROR']"
		[Register ("APPKEY_ERROR")]
		public static string AppkeyError {
			get {
				if (APPKEY_ERROR_jfieldId == IntPtr.Zero)
					APPKEY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPKEY_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPKEY_ERROR_jfieldId == IntPtr.Zero)
					APPKEY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPKEY_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APPKEY_NOT_FOUND_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='APPKEY_NOT_FOUND']"
		[Register ("APPKEY_NOT_FOUND")]
		public static string AppkeyNotFound {
			get {
				if (APPKEY_NOT_FOUND_jfieldId == IntPtr.Zero)
					APPKEY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY_NOT_FOUND", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPKEY_NOT_FOUND_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPKEY_NOT_FOUND_jfieldId == IntPtr.Zero)
					APPKEY_NOT_FOUND_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY_NOT_FOUND", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPKEY_NOT_FOUND_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr APPKEY_NOT_REAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='APPKEY_NOT_REAL']"
		[Register ("APPKEY_NOT_REAL")]
		public static string AppkeyNotReal {
			get {
				if (APPKEY_NOT_REAL_jfieldId == IntPtr.Zero)
					APPKEY_NOT_REAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY_NOT_REAL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPKEY_NOT_REAL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPKEY_NOT_REAL_jfieldId == IntPtr.Zero)
					APPKEY_NOT_REAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPKEY_NOT_REAL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPKEY_NOT_REAL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr AUTH_DENIED_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='AUTH_DENIED']"
		[Register ("AUTH_DENIED")]
		public static string AuthDenied {
			get {
				if (AUTH_DENIED_jfieldId == IntPtr.Zero)
					AUTH_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_DENIED", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_DENIED_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTH_DENIED_jfieldId == IntPtr.Zero)
					AUTH_DENIED_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_DENIED", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, AUTH_DENIED_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr AUTH_FAIL_LOG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='AUTH_FAIL_LOG']"
		[Register ("AUTH_FAIL_LOG")]
		public static string AuthFailLog {
			get {
				if (AUTH_FAIL_LOG_jfieldId == IntPtr.Zero)
					AUTH_FAIL_LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_FAIL_LOG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AUTH_FAIL_LOG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (AUTH_FAIL_LOG_jfieldId == IntPtr.Zero)
					AUTH_FAIL_LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AUTH_FAIL_LOG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, AUTH_FAIL_LOG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CHECK_FORMAT_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='CHECK_FORMAT_ERROR']"
		[Register ("CHECK_FORMAT_ERROR")]
		public static string CheckFormatError {
			get {
				if (CHECK_FORMAT_ERROR_jfieldId == IntPtr.Zero)
					CHECK_FORMAT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECK_FORMAT_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CHECK_FORMAT_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CHECK_FORMAT_ERROR_jfieldId == IntPtr.Zero)
					CHECK_FORMAT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CHECK_FORMAT_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CHECK_FORMAT_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CLEAN_CACHE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='CLEAN_CACHE_ERROR']"
		[Register ("CLEAN_CACHE_ERROR")]
		public static string CleanCacheError {
			get {
				if (CLEAN_CACHE_ERROR_jfieldId == IntPtr.Zero)
					CLEAN_CACHE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLEAN_CACHE_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CLEAN_CACHE_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CLEAN_CACHE_ERROR_jfieldId == IntPtr.Zero)
					CLEAN_CACHE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CLEAN_CACHE_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CLEAN_CACHE_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONTEXT_EMPTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='CONTEXT_EMPTY']"
		[Register ("CONTEXT_EMPTY")]
		public static string ContextEmpty {
			get {
				if (CONTEXT_EMPTY_jfieldId == IntPtr.Zero)
					CONTEXT_EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_EMPTY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTEXT_EMPTY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONTEXT_EMPTY_jfieldId == IntPtr.Zero)
					CONTEXT_EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_EMPTY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONTEXT_EMPTY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONTEXT_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='CONTEXT_ERROR']"
		[Register ("CONTEXT_ERROR")]
		public static string ContextError {
			get {
				if (CONTEXT_ERROR_jfieldId == IntPtr.Zero)
					CONTEXT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTEXT_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONTEXT_ERROR_jfieldId == IntPtr.Zero)
					CONTEXT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONTEXT_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr CONTEXT_LONG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='CONTEXT_LONG']"
		[Register ("CONTEXT_LONG")]
		public static string ContextLong {
			get {
				if (CONTEXT_LONG_jfieldId == IntPtr.Zero)
					CONTEXT_LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_LONG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CONTEXT_LONG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (CONTEXT_LONG_jfieldId == IntPtr.Zero)
					CONTEXT_LONG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CONTEXT_LONG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, CONTEXT_LONG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DATA_EMPTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='DATA_EMPTY']"
		[Register ("DATA_EMPTY")]
		public static string DataEmpty {
			get {
				if (DATA_EMPTY_jfieldId == IntPtr.Zero)
					DATA_EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_EMPTY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DATA_EMPTY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DATA_EMPTY_jfieldId == IntPtr.Zero)
					DATA_EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DATA_EMPTY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, DATA_EMPTY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DECRPT_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='DECRPT_ERROR']"
		[Register ("DECRPT_ERROR")]
		public static string DecrptError {
			get {
				if (DECRPT_ERROR_jfieldId == IntPtr.Zero)
					DECRPT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECRPT_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DECRPT_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DECRPT_ERROR_jfieldId == IntPtr.Zero)
					DECRPT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DECRPT_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, DECRPT_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DINGTALK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='DINGTALK']"
		[Register ("DINGTALK")]
		public static string Dingtalk {
			get {
				if (DINGTALK_jfieldId == IntPtr.Zero)
					DINGTALK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DINGTALK", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DINGTALK_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DINGTALK_jfieldId == IntPtr.Zero)
					DINGTALK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DINGTALK", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, DINGTALK_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DOUBAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='DOUBAN']"
		[Register ("DOUBAN")]
		public static string Douban {
			get {
				if (DOUBAN_jfieldId == IntPtr.Zero)
					DOUBAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBAN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DOUBAN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DOUBAN_jfieldId == IntPtr.Zero)
					DOUBAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DOUBAN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, DOUBAN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr DROPBOX_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='DROPBOX']"
		[Register ("DROPBOX")]
		public static string Dropbox {
			get {
				if (DROPBOX_jfieldId == IntPtr.Zero)
					DROPBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DROPBOX", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DROPBOX_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (DROPBOX_jfieldId == IntPtr.Zero)
					DROPBOX_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DROPBOX", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, DROPBOX_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EMAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='EMAIL']"
		[Register ("EMAIL")]
		public static string Email {
			get {
				if (EMAIL_jfieldId == IntPtr.Zero)
					EMAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMAIL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMAIL_jfieldId == IntPtr.Zero)
					EMAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMAIL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EMAIL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EMPTY_TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='EMPTY_TEXT']"
		[Register ("EMPTY_TEXT")]
		public static string EmptyText {
			get {
				if (EMPTY_TEXT_jfieldId == IntPtr.Zero)
					EMPTY_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_TEXT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_TEXT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMPTY_TEXT_jfieldId == IntPtr.Zero)
					EMPTY_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_TEXT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EMPTY_TEXT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EMPTY_WEB_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='EMPTY_WEB_URL']"
		[Register ("EMPTY_WEB_URL")]
		public static string EmptyWebUrl {
			get {
				if (EMPTY_WEB_URL_jfieldId == IntPtr.Zero)
					EMPTY_WEB_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_WEB_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EMPTY_WEB_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EMPTY_WEB_URL_jfieldId == IntPtr.Zero)
					EMPTY_WEB_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EMPTY_WEB_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EMPTY_WEB_URL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr EVERNOTE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='EVERNOTE']"
		[Register ("EVERNOTE")]
		public static string Evernote {
			get {
				if (EVERNOTE_jfieldId == IntPtr.Zero)
					EVERNOTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVERNOTE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, EVERNOTE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (EVERNOTE_jfieldId == IntPtr.Zero)
					EVERNOTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "EVERNOTE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, EVERNOTE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FACEBOOK_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FACEBOOK']"
		[Register ("FACEBOOK")]
		public static string Facebook {
			get {
				if (FACEBOOK_jfieldId == IntPtr.Zero)
					FACEBOOK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACEBOOK_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FACEBOOK_jfieldId == IntPtr.Zero)
					FACEBOOK_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FACEBOOK_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FACEBOOK_MESSAGER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FACEBOOK_MESSAGER']"
		[Register ("FACEBOOK_MESSAGER")]
		public static string FacebookMessager {
			get {
				if (FACEBOOK_MESSAGER_jfieldId == IntPtr.Zero)
					FACEBOOK_MESSAGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_MESSAGER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACEBOOK_MESSAGER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FACEBOOK_MESSAGER_jfieldId == IntPtr.Zero)
					FACEBOOK_MESSAGER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_MESSAGER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FACEBOOK_MESSAGER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FACEBOOK_NET_SUPPORT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FACEBOOK_NET_SUPPORT']"
		[Register ("FACEBOOK_NET_SUPPORT")]
		public static string FacebookNetSupport {
			get {
				if (FACEBOOK_NET_SUPPORT_jfieldId == IntPtr.Zero)
					FACEBOOK_NET_SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_NET_SUPPORT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FACEBOOK_NET_SUPPORT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FACEBOOK_NET_SUPPORT_jfieldId == IntPtr.Zero)
					FACEBOOK_NET_SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FACEBOOK_NET_SUPPORT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FACEBOOK_NET_SUPPORT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FET_CACHE_PATH_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FET_CACHE_PATH_ERROR']"
		[Register ("FET_CACHE_PATH_ERROR")]
		public static string FetCachePathError {
			get {
				if (FET_CACHE_PATH_ERROR_jfieldId == IntPtr.Zero)
					FET_CACHE_PATH_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FET_CACHE_PATH_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FET_CACHE_PATH_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FET_CACHE_PATH_ERROR_jfieldId == IntPtr.Zero)
					FET_CACHE_PATH_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FET_CACHE_PATH_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FET_CACHE_PATH_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FILE_TO_BINARY_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FILE_TO_BINARY_ERROR']"
		[Register ("FILE_TO_BINARY_ERROR")]
		public static string FileToBinaryError {
			get {
				if (FILE_TO_BINARY_ERROR_jfieldId == IntPtr.Zero)
					FILE_TO_BINARY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_TO_BINARY_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FILE_TO_BINARY_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FILE_TO_BINARY_ERROR_jfieldId == IntPtr.Zero)
					FILE_TO_BINARY_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FILE_TO_BINARY_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FILE_TO_BINARY_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FLICKR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FLICKR']"
		[Register ("FLICKR")]
		public static string Flickr {
			get {
				if (FLICKR_jfieldId == IntPtr.Zero)
					FLICKR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLICKR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FLICKR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FLICKR_jfieldId == IntPtr.Zero)
					FLICKR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FLICKR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FLICKR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FOURSQUARE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FOURSQUARE']"
		[Register ("FOURSQUARE")]
		public static string Foursquare {
			get {
				if (FOURSQUARE_jfieldId == IntPtr.Zero)
					FOURSQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOURSQUARE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FOURSQUARE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FOURSQUARE_jfieldId == IntPtr.Zero)
					FOURSQUARE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FOURSQUARE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FOURSQUARE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr FULL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='FULL']"
		[Register ("FULL")]
		public static string Full {
			get {
				if (FULL_jfieldId == IntPtr.Zero)
					FULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, FULL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (FULL_jfieldId == IntPtr.Zero)
					FULL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "FULL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, FULL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr GET_FAIL_BY_EMPTY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='GET_FAIL_BY_EMPTY']"
		[Register ("GET_FAIL_BY_EMPTY")]
		public static string GetFailByEmpty {
			get {
				if (GET_FAIL_BY_EMPTY_jfieldId == IntPtr.Zero)
					GET_FAIL_BY_EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_FAIL_BY_EMPTY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_FAIL_BY_EMPTY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GET_FAIL_BY_EMPTY_jfieldId == IntPtr.Zero)
					GET_FAIL_BY_EMPTY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_FAIL_BY_EMPTY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, GET_FAIL_BY_EMPTY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr GET_FAIL_LOG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='GET_FAIL_LOG']"
		[Register ("GET_FAIL_LOG")]
		public static string GetFailLog {
			get {
				if (GET_FAIL_LOG_jfieldId == IntPtr.Zero)
					GET_FAIL_LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_FAIL_LOG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_FAIL_LOG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GET_FAIL_LOG_jfieldId == IntPtr.Zero)
					GET_FAIL_LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_FAIL_LOG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, GET_FAIL_LOG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr GET_FILE_FROM_BINARY_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='GET_FILE_FROM_BINARY']"
		[Register ("GET_FILE_FROM_BINARY")]
		public static string GetFileFromBinary {
			get {
				if (GET_FILE_FROM_BINARY_jfieldId == IntPtr.Zero)
					GET_FILE_FROM_BINARY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_FILE_FROM_BINARY", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_FILE_FROM_BINARY_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GET_FILE_FROM_BINARY_jfieldId == IntPtr.Zero)
					GET_FILE_FROM_BINARY_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_FILE_FROM_BINARY", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, GET_FILE_FROM_BINARY_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr GET_IMAGE_SCALE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='GET_IMAGE_SCALE_ERROR']"
		[Register ("GET_IMAGE_SCALE_ERROR")]
		public static string GetImageScaleError {
			get {
				if (GET_IMAGE_SCALE_ERROR_jfieldId == IntPtr.Zero)
					GET_IMAGE_SCALE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_IMAGE_SCALE_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_IMAGE_SCALE_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GET_IMAGE_SCALE_ERROR_jfieldId == IntPtr.Zero)
					GET_IMAGE_SCALE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET_IMAGE_SCALE_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, GET_IMAGE_SCALE_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr IMAGE_DOWNLOAD_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='IMAGE_DOWNLOAD_ERROR']"
		[Register ("IMAGE_DOWNLOAD_ERROR")]
		public static string ImageDownloadError {
			get {
				if (IMAGE_DOWNLOAD_ERROR_jfieldId == IntPtr.Zero)
					IMAGE_DOWNLOAD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE_DOWNLOAD_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, IMAGE_DOWNLOAD_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (IMAGE_DOWNLOAD_ERROR_jfieldId == IntPtr.Zero)
					IMAGE_DOWNLOAD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "IMAGE_DOWNLOAD_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, IMAGE_DOWNLOAD_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr INSTAGRAM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='INSTAGRAM']"
		[Register ("INSTAGRAM")]
		public static string Instagram {
			get {
				if (INSTAGRAM_jfieldId == IntPtr.Zero)
					INSTAGRAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTAGRAM", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, INSTAGRAM_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (INSTAGRAM_jfieldId == IntPtr.Zero)
					INSTAGRAM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "INSTAGRAM", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, INSTAGRAM_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr KAKAO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='KAKAO']"
		[Register ("KAKAO")]
		public static string Kakao {
			get {
				if (KAKAO_jfieldId == IntPtr.Zero)
					KAKAO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KAKAO", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, KAKAO_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (KAKAO_jfieldId == IntPtr.Zero)
					KAKAO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "KAKAO", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, KAKAO_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr LAIWANG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='LAIWANG']"
		[Register ("LAIWANG")]
		public static string Laiwang {
			get {
				if (LAIWANG_jfieldId == IntPtr.Zero)
					LAIWANG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAIWANG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAIWANG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LAIWANG_jfieldId == IntPtr.Zero)
					LAIWANG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAIWANG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, LAIWANG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr LAIWANG_DYNAMIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='LAIWANG_DYNAMIC']"
		[Register ("LAIWANG_DYNAMIC")]
		public static string LaiwangDynamic {
			get {
				if (LAIWANG_DYNAMIC_jfieldId == IntPtr.Zero)
					LAIWANG_DYNAMIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAIWANG_DYNAMIC", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LAIWANG_DYNAMIC_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LAIWANG_DYNAMIC_jfieldId == IntPtr.Zero)
					LAIWANG_DYNAMIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LAIWANG_DYNAMIC", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, LAIWANG_DYNAMIC_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr LINE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='LINE']"
		[Register ("LINE")]
		public static string Line {
			get {
				if (LINE_jfieldId == IntPtr.Zero)
					LINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LINE_jfieldId == IntPtr.Zero)
					LINE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, LINE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr LINKEDIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='LINKEDIN']"
		[Register ("LINKEDIN")]
		public static string Linkedin {
			get {
				if (LINKEDIN_jfieldId == IntPtr.Zero)
					LINKEDIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINKEDIN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LINKEDIN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LINKEDIN_jfieldId == IntPtr.Zero)
					LINKEDIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LINKEDIN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, LINKEDIN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr LONG_TEXT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='LONG_TEXT']"
		[Register ("LONG_TEXT")]
		public static string LongText {
			get {
				if (LONG_TEXT_jfieldId == IntPtr.Zero)
					LONG_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG_TEXT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_TEXT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LONG_TEXT_jfieldId == IntPtr.Zero)
					LONG_TEXT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG_TEXT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, LONG_TEXT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr LONG_URL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='LONG_URL']"
		[Register ("LONG_URL")]
		public static string LongUrl {
			get {
				if (LONG_URL_jfieldId == IntPtr.Zero)
					LONG_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG_URL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, LONG_URL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (LONG_URL_jfieldId == IntPtr.Zero)
					LONG_URL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "LONG_URL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, LONG_URL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr MAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='MAN']"
		[Register ("MAN")]
		public static string Man {
			get {
				if (MAN_jfieldId == IntPtr.Zero)
					MAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MAN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MAN_jfieldId == IntPtr.Zero)
					MAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MAN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, MAN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr MORE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='MORE']"
		[Register ("MORE")]
		public static string More {
			get {
				if (MORE_jfieldId == IntPtr.Zero)
					MORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MORE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MORE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MORE_jfieldId == IntPtr.Zero)
					MORE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MORE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, MORE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr NET_AGAIN_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='NET_AGAIN_ERROR']"
		[Register ("NET_AGAIN_ERROR")]
		public static string NetAgainError {
			get {
				if (NET_AGAIN_ERROR_jfieldId == IntPtr.Zero)
					NET_AGAIN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NET_AGAIN_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NET_AGAIN_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NET_AGAIN_ERROR_jfieldId == IntPtr.Zero)
					NET_AGAIN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NET_AGAIN_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, NET_AGAIN_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr NET_INAVALIBLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='NET_INAVALIBLE']"
		[Register ("NET_INAVALIBLE")]
		public static string NetInavalible {
			get {
				if (NET_INAVALIBLE_jfieldId == IntPtr.Zero)
					NET_INAVALIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NET_INAVALIBLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NET_INAVALIBLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NET_INAVALIBLE_jfieldId == IntPtr.Zero)
					NET_INAVALIBLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NET_INAVALIBLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, NET_INAVALIBLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr NOT_SUPPORT_PLATFROM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='NOT_SUPPORT_PLATFROM']"
		[Register ("NOT_SUPPORT_PLATFROM")]
		public static string NotSupportPlatfrom {
			get {
				if (NOT_SUPPORT_PLATFROM_jfieldId == IntPtr.Zero)
					NOT_SUPPORT_PLATFROM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SUPPORT_PLATFROM", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NOT_SUPPORT_PLATFROM_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (NOT_SUPPORT_PLATFROM_jfieldId == IntPtr.Zero)
					NOT_SUPPORT_PLATFROM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NOT_SUPPORT_PLATFROM", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, NOT_SUPPORT_PLATFROM_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr OOM_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='OOM']"
		[Register ("OOM")]
		public static string Oom {
			get {
				if (OOM_jfieldId == IntPtr.Zero)
					OOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OOM", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, OOM_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (OOM_jfieldId == IntPtr.Zero)
					OOM_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "OOM", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, OOM_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr PINTEREST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='PINTEREST']"
		[Register ("PINTEREST")]
		public static string Pinterest {
			get {
				if (PINTEREST_jfieldId == IntPtr.Zero)
					PINTEREST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PINTEREST", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, PINTEREST_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (PINTEREST_jfieldId == IntPtr.Zero)
					PINTEREST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "PINTEREST", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, PINTEREST_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr POCKET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='POCKET']"
		[Register ("POCKET")]
		public static string Pocket {
			get {
				if (POCKET_jfieldId == IntPtr.Zero)
					POCKET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POCKET", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POCKET_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POCKET_jfieldId == IntPtr.Zero)
					POCKET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POCKET", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, POCKET_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr QQ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='QQ']"
		[Register ("QQ")]
		public static string Qq {
			get {
				if (QQ_jfieldId == IntPtr.Zero)
					QQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QQ_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QQ_jfieldId == IntPtr.Zero)
					QQ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, QQ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr QQ_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='QQ_ERROR']"
		[Register ("QQ_ERROR")]
		public static string QqError {
			get {
				if (QQ_ERROR_jfieldId == IntPtr.Zero)
					QQ_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QQ_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QQ_ERROR_jfieldId == IntPtr.Zero)
					QQ_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, QQ_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr QQ_MUSIC_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='QQ_MUSIC']"
		[Register ("QQ_MUSIC")]
		public static string QqMusic {
			get {
				if (QQ_MUSIC_jfieldId == IntPtr.Zero)
					QQ_MUSIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_MUSIC", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QQ_MUSIC_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QQ_MUSIC_jfieldId == IntPtr.Zero)
					QQ_MUSIC_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_MUSIC", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, QQ_MUSIC_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr QQ_PERMISSION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='QQ_PERMISSION']"
		[Register ("QQ_PERMISSION")]
		public static string QqPermission {
			get {
				if (QQ_PERMISSION_jfieldId == IntPtr.Zero)
					QQ_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_PERMISSION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QQ_PERMISSION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QQ_PERMISSION_jfieldId == IntPtr.Zero)
					QQ_PERMISSION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_PERMISSION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, QQ_PERMISSION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr QQ_TENCENT_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='QQ_TENCENT_ERROR']"
		[Register ("QQ_TENCENT_ERROR")]
		public static string QqTencentError {
			get {
				if (QQ_TENCENT_ERROR_jfieldId == IntPtr.Zero)
					QQ_TENCENT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_TENCENT_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QQ_TENCENT_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QQ_TENCENT_ERROR_jfieldId == IntPtr.Zero)
					QQ_TENCENT_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QQ_TENCENT_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, QQ_TENCENT_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr QZONE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='QZONE']"
		[Register ("QZONE")]
		public static string Qzone {
			get {
				if (QZONE_jfieldId == IntPtr.Zero)
					QZONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QZONE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, QZONE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (QZONE_jfieldId == IntPtr.Zero)
					QZONE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "QZONE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, QZONE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr READ_IMAGE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='READ_IMAGE_ERROR']"
		[Register ("READ_IMAGE_ERROR")]
		public static string ReadImageError {
			get {
				if (READ_IMAGE_ERROR_jfieldId == IntPtr.Zero)
					READ_IMAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ_IMAGE_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, READ_IMAGE_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (READ_IMAGE_ERROR_jfieldId == IntPtr.Zero)
					READ_IMAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "READ_IMAGE_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, READ_IMAGE_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr RENREN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='RENREN']"
		[Register ("RENREN")]
		public static string Renren {
			get {
				if (RENREN_jfieldId == IntPtr.Zero)
					RENREN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RENREN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RENREN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (RENREN_jfieldId == IntPtr.Zero)
					RENREN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RENREN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, RENREN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SD_NOT_FOUNT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SD_NOT_FOUNT']"
		[Register ("SD_NOT_FOUNT")]
		public static string SdNotFount {
			get {
				if (SD_NOT_FOUNT_jfieldId == IntPtr.Zero)
					SD_NOT_FOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SD_NOT_FOUNT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SD_NOT_FOUNT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SD_NOT_FOUNT_jfieldId == IntPtr.Zero)
					SD_NOT_FOUNT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SD_NOT_FOUNT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SD_NOT_FOUNT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SHARECONTENT_IMAGE_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SHARECONTENT_IMAGE_ERROR']"
		[Register ("SHARECONTENT_IMAGE_ERROR")]
		public static string SharecontentImageError {
			get {
				if (SHARECONTENT_IMAGE_ERROR_jfieldId == IntPtr.Zero)
					SHARECONTENT_IMAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARECONTENT_IMAGE_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHARECONTENT_IMAGE_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SHARECONTENT_IMAGE_ERROR_jfieldId == IntPtr.Zero)
					SHARECONTENT_IMAGE_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARECONTENT_IMAGE_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SHARECONTENT_IMAGE_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SHARECONTENT_THUMB_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SHARECONTENT_THUMB_ERROR']"
		[Register ("SHARECONTENT_THUMB_ERROR")]
		public static string SharecontentThumbError {
			get {
				if (SHARECONTENT_THUMB_ERROR_jfieldId == IntPtr.Zero)
					SHARECONTENT_THUMB_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARECONTENT_THUMB_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHARECONTENT_THUMB_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SHARECONTENT_THUMB_ERROR_jfieldId == IntPtr.Zero)
					SHARECONTENT_THUMB_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARECONTENT_THUMB_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SHARECONTENT_THUMB_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SHARE_CONTENT_FAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SHARE_CONTENT_FAIL']"
		[Register ("SHARE_CONTENT_FAIL")]
		public static string ShareContentFail {
			get {
				if (SHARE_CONTENT_FAIL_jfieldId == IntPtr.Zero)
					SHARE_CONTENT_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_CONTENT_FAIL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHARE_CONTENT_FAIL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SHARE_CONTENT_FAIL_jfieldId == IntPtr.Zero)
					SHARE_CONTENT_FAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_CONTENT_FAIL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SHARE_CONTENT_FAIL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SHARE_FAIL_LOG_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SHARE_FAIL_LOG']"
		[Register ("SHARE_FAIL_LOG")]
		public static string ShareFailLog {
			get {
				if (SHARE_FAIL_LOG_jfieldId == IntPtr.Zero)
					SHARE_FAIL_LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_FAIL_LOG", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHARE_FAIL_LOG_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SHARE_FAIL_LOG_jfieldId == IntPtr.Zero)
					SHARE_FAIL_LOG_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_FAIL_LOG", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SHARE_FAIL_LOG_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SHARE_STYLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SHARE_STYLE']"
		[Register ("SHARE_STYLE")]
		public static string ShareStyle {
			get {
				if (SHARE_STYLE_jfieldId == IntPtr.Zero)
					SHARE_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_STYLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHARE_STYLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SHARE_STYLE_jfieldId == IntPtr.Zero)
					SHARE_STYLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_STYLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SHARE_STYLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SHARE_TO_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SHARE_TO']"
		[Register ("SHARE_TO")]
		public static string ShareTo {
			get {
				if (SHARE_TO_jfieldId == IntPtr.Zero)
					SHARE_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_TO", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SHARE_TO_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SHARE_TO_jfieldId == IntPtr.Zero)
					SHARE_TO_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SHARE_TO", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SHARE_TO_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SIMPLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SIMPLE']"
		[Register ("SIMPLE")]
		public static string Simple {
			get {
				if (SIMPLE_jfieldId == IntPtr.Zero)
					SIMPLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIMPLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SIMPLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SIMPLE_jfieldId == IntPtr.Zero)
					SIMPLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SIMPLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SIMPLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SINA_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SINA']"
		[Register ("SINA")]
		public static string Sina {
			get {
				if (SINA_jfieldId == IntPtr.Zero)
					SINA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINA_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SINA_jfieldId == IntPtr.Zero)
					SINA_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SINA_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SINA_AID_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SINA_AID_ERROR']"
		[Register ("SINA_AID_ERROR")]
		public static string SinaAidError {
			get {
				if (SINA_AID_ERROR_jfieldId == IntPtr.Zero)
					SINA_AID_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_AID_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINA_AID_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SINA_AID_ERROR_jfieldId == IntPtr.Zero)
					SINA_AID_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_AID_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SINA_AID_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SINA_GET_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SINA_GET_ERROR']"
		[Register ("SINA_GET_ERROR")]
		public static string SinaGetError {
			get {
				if (SINA_GET_ERROR_jfieldId == IntPtr.Zero)
					SINA_GET_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_GET_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINA_GET_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SINA_GET_ERROR_jfieldId == IntPtr.Zero)
					SINA_GET_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_GET_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SINA_GET_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SINA_SIGN_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SINA_SIGN_ERROR']"
		[Register ("SINA_SIGN_ERROR")]
		public static string SinaSignError {
			get {
				if (SINA_SIGN_ERROR_jfieldId == IntPtr.Zero)
					SINA_SIGN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_SIGN_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINA_SIGN_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SINA_SIGN_ERROR_jfieldId == IntPtr.Zero)
					SINA_SIGN_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_SIGN_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SINA_SIGN_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SINA_THUMB_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SINA_THUMB_ERROR']"
		[Register ("SINA_THUMB_ERROR")]
		public static string SinaThumbError {
			get {
				if (SINA_THUMB_ERROR_jfieldId == IntPtr.Zero)
					SINA_THUMB_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_THUMB_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINA_THUMB_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SINA_THUMB_ERROR_jfieldId == IntPtr.Zero)
					SINA_THUMB_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_THUMB_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SINA_THUMB_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SINA_UPLOAD_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SINA_UPLOAD_ERROR']"
		[Register ("SINA_UPLOAD_ERROR")]
		public static string SinaUploadError {
			get {
				if (SINA_UPLOAD_ERROR_jfieldId == IntPtr.Zero)
					SINA_UPLOAD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_UPLOAD_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SINA_UPLOAD_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SINA_UPLOAD_ERROR_jfieldId == IntPtr.Zero)
					SINA_UPLOAD_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SINA_UPLOAD_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SINA_UPLOAD_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SMS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SMS']"
		[Register ("SMS")]
		public static string Sms {
			get {
				if (SMS_jfieldId == IntPtr.Zero)
					SMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMS", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SMS_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SMS_jfieldId == IntPtr.Zero)
					SMS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SMS", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SMS_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr SOLVE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='SOLVE']"
		[Register ("SOLVE")]
		public static string Solve {
			get {
				if (SOLVE_jfieldId == IntPtr.Zero)
					SOLVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOLVE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOLVE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (SOLVE_jfieldId == IntPtr.Zero)
					SOLVE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOLVE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, SOLVE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr TENCENT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='TENCENT']"
		[Register ("TENCENT")]
		public static string Tencent {
			get {
				if (TENCENT_jfieldId == IntPtr.Zero)
					TENCENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TENCENT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TENCENT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TENCENT_jfieldId == IntPtr.Zero)
					TENCENT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TENCENT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, TENCENT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr THUMB_ERROR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='THUMB_ERROR']"
		[Register ("THUMB_ERROR")]
		public static string ThumbError {
			get {
				if (THUMB_ERROR_jfieldId == IntPtr.Zero)
					THUMB_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THUMB_ERROR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, THUMB_ERROR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (THUMB_ERROR_jfieldId == IntPtr.Zero)
					THUMB_ERROR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "THUMB_ERROR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, THUMB_ERROR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr TUMBLR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='TUMBLR']"
		[Register ("TUMBLR")]
		public static string Tumblr {
			get {
				if (TUMBLR_jfieldId == IntPtr.Zero)
					TUMBLR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TUMBLR", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TUMBLR_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TUMBLR_jfieldId == IntPtr.Zero)
					TUMBLR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TUMBLR", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, TUMBLR_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr TWITTER_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='TWITTER']"
		[Register ("TWITTER")]
		public static string Twitter {
			get {
				if (TWITTER_jfieldId == IntPtr.Zero)
					TWITTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWITTER", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, TWITTER_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (TWITTER_jfieldId == IntPtr.Zero)
					TWITTER_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "TWITTER", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, TWITTER_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr UNKNOW_SHARE_TYPE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='UNKNOW_SHARE_TYPE']"
		[Register ("UNKNOW_SHARE_TYPE")]
		public static string UnknowShareType {
			get {
				if (UNKNOW_SHARE_TYPE_jfieldId == IntPtr.Zero)
					UNKNOW_SHARE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOW_SHARE_TYPE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOW_SHARE_TYPE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNKNOW_SHARE_TYPE_jfieldId == IntPtr.Zero)
					UNKNOW_SHARE_TYPE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOW_SHARE_TYPE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, UNKNOW_SHARE_TYPE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr UNKNOW_UMIMAGE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='UNKNOW_UMIMAGE']"
		[Register ("UNKNOW_UMIMAGE")]
		public static string UnknowUmimage {
			get {
				if (UNKNOW_UMIMAGE_jfieldId == IntPtr.Zero)
					UNKNOW_UMIMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOW_UMIMAGE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UNKNOW_UMIMAGE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UNKNOW_UMIMAGE_jfieldId == IntPtr.Zero)
					UNKNOW_UMIMAGE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UNKNOW_UMIMAGE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, UNKNOW_UMIMAGE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr UPLOADFAIL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='UPLOADFAIL']"
		[Register ("UPLOADFAIL")]
		public static string Uploadfail {
			get {
				if (UPLOADFAIL_jfieldId == IntPtr.Zero)
					UPLOADFAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOADFAIL", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UPLOADFAIL_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (UPLOADFAIL_jfieldId == IntPtr.Zero)
					UPLOADFAIL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UPLOADFAIL", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, UPLOADFAIL_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr VERSION_NOT_SUPPORT_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='VERSION_NOT_SUPPORT']"
		[Register ("VERSION_NOT_SUPPORT")]
		public static string VersionNotSupport {
			get {
				if (VERSION_NOT_SUPPORT_jfieldId == IntPtr.Zero)
					VERSION_NOT_SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_NOT_SUPPORT", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VERSION_NOT_SUPPORT_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VERSION_NOT_SUPPORT_jfieldId == IntPtr.Zero)
					VERSION_NOT_SUPPORT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VERSION_NOT_SUPPORT", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, VERSION_NOT_SUPPORT_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr VKONTAKTE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='VKONTAKTE']"
		[Register ("VKONTAKTE")]
		public static string Vkontakte {
			get {
				if (VKONTAKTE_jfieldId == IntPtr.Zero)
					VKONTAKTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VKONTAKTE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, VKONTAKTE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (VKONTAKTE_jfieldId == IntPtr.Zero)
					VKONTAKTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "VKONTAKTE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, VKONTAKTE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WEB_HTTP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WEB_HTTP']"
		[Register ("WEB_HTTP")]
		public static string WebHttp {
			get {
				if (WEB_HTTP_jfieldId == IntPtr.Zero)
					WEB_HTTP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_HTTP", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEB_HTTP_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WEB_HTTP_jfieldId == IntPtr.Zero)
					WEB_HTTP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEB_HTTP", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WEB_HTTP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WEIXIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WEIXIN']"
		[Register ("WEIXIN")]
		public static string Weixin {
			get {
				if (WEIXIN_jfieldId == IntPtr.Zero)
					WEIXIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEIXIN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEIXIN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WEIXIN_jfieldId == IntPtr.Zero)
					WEIXIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEIXIN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WEIXIN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WEIXIN_CIRCLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WEIXIN_CIRCLE']"
		[Register ("WEIXIN_CIRCLE")]
		public static string WeixinCircle {
			get {
				if (WEIXIN_CIRCLE_jfieldId == IntPtr.Zero)
					WEIXIN_CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEIXIN_CIRCLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEIXIN_CIRCLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WEIXIN_CIRCLE_jfieldId == IntPtr.Zero)
					WEIXIN_CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEIXIN_CIRCLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WEIXIN_CIRCLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WEIXIN_FAVORITE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WEIXIN_FAVORITE']"
		[Register ("WEIXIN_FAVORITE")]
		public static string WeixinFavorite {
			get {
				if (WEIXIN_FAVORITE_jfieldId == IntPtr.Zero)
					WEIXIN_FAVORITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEIXIN_FAVORITE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WEIXIN_FAVORITE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WEIXIN_FAVORITE_jfieldId == IntPtr.Zero)
					WEIXIN_FAVORITE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WEIXIN_FAVORITE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WEIXIN_FAVORITE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WHATSAPP_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WHATSAPP']"
		[Register ("WHATSAPP")]
		public static string Whatsapp {
			get {
				if (WHATSAPP_jfieldId == IntPtr.Zero)
					WHATSAPP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WHATSAPP", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WHATSAPP_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WHATSAPP_jfieldId == IntPtr.Zero)
					WHATSAPP_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WHATSAPP", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WHATSAPP_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WOMAN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WOMAN']"
		[Register ("WOMAN")]
		public static string Woman {
			get {
				if (WOMAN_jfieldId == IntPtr.Zero)
					WOMAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WOMAN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WOMAN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WOMAN_jfieldId == IntPtr.Zero)
					WOMAN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WOMAN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WOMAN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WX_CIRCLE_NOT_SUPPORT_EMOJ_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WX_CIRCLE_NOT_SUPPORT_EMOJ']"
		[Register ("WX_CIRCLE_NOT_SUPPORT_EMOJ")]
		public static string WxCircleNotSupportEmoj {
			get {
				if (WX_CIRCLE_NOT_SUPPORT_EMOJ_jfieldId == IntPtr.Zero)
					WX_CIRCLE_NOT_SUPPORT_EMOJ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WX_CIRCLE_NOT_SUPPORT_EMOJ", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WX_CIRCLE_NOT_SUPPORT_EMOJ_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WX_CIRCLE_NOT_SUPPORT_EMOJ_jfieldId == IntPtr.Zero)
					WX_CIRCLE_NOT_SUPPORT_EMOJ_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WX_CIRCLE_NOT_SUPPORT_EMOJ", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WX_CIRCLE_NOT_SUPPORT_EMOJ_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr WX_CIRCLE_NOT_SUPPORT_MIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='WX_CIRCLE_NOT_SUPPORT_MIN']"
		[Register ("WX_CIRCLE_NOT_SUPPORT_MIN")]
		public static string WxCircleNotSupportMin {
			get {
				if (WX_CIRCLE_NOT_SUPPORT_MIN_jfieldId == IntPtr.Zero)
					WX_CIRCLE_NOT_SUPPORT_MIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WX_CIRCLE_NOT_SUPPORT_MIN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, WX_CIRCLE_NOT_SUPPORT_MIN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (WX_CIRCLE_NOT_SUPPORT_MIN_jfieldId == IntPtr.Zero)
					WX_CIRCLE_NOT_SUPPORT_MIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "WX_CIRCLE_NOT_SUPPORT_MIN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, WX_CIRCLE_NOT_SUPPORT_MIN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr YIXIN_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='YIXIN']"
		[Register ("YIXIN")]
		public static string Yixin {
			get {
				if (YIXIN_jfieldId == IntPtr.Zero)
					YIXIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YIXIN", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YIXIN_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (YIXIN_jfieldId == IntPtr.Zero)
					YIXIN_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YIXIN", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, YIXIN_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr YIXIN_CIRCLE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='YIXIN_CIRCLE']"
		[Register ("YIXIN_CIRCLE")]
		public static string YixinCircle {
			get {
				if (YIXIN_CIRCLE_jfieldId == IntPtr.Zero)
					YIXIN_CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YIXIN_CIRCLE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YIXIN_CIRCLE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (YIXIN_CIRCLE_jfieldId == IntPtr.Zero)
					YIXIN_CIRCLE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YIXIN_CIRCLE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, YIXIN_CIRCLE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr YNOTE_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/field[@name='YNOTE']"
		[Register ("YNOTE")]
		public static string Ynote {
			get {
				if (YNOTE_jfieldId == IntPtr.Zero)
					YNOTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YNOTE", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, YNOTE_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (YNOTE_jfieldId == IntPtr.Zero)
					YNOTE_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "YNOTE", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, YNOTE_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/utils/UmengText", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengText); }
		}

		protected UmengText (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/constructor[@name='UmengText' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe UmengText ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				if (GetType () != typeof (UmengText)) {
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

		static IntPtr id_errorWithUrl_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='errorWithUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("errorWithUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ErrorWithUrl (string p0, string p1)
		{
			if (id_errorWithUrl_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_errorWithUrl_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "errorWithUrl", "(Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_errorWithUrl_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_netMethodError_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='netMethodError' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("netMethodError", "(Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string NetMethodError (string p0)
		{
			if (id_netMethodError_Ljava_lang_String_ == IntPtr.Zero)
				id_netMethodError_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "netMethodError", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_netMethodError_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_noJar_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='noJar' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("noJar", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;", "")]
		public static unsafe string NoJar (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_noJar_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_noJar_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetStaticMethodID (class_ref, "noJar", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_noJar_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_noKey_Lcom_umeng_socialize_bean_SHARE_MEDIA_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='noKey' and count(parameter)=1 and parameter[1][@type='com.umeng.socialize.bean.SHARE_MEDIA']]"
		[Register ("noKey", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;", "")]
		public static unsafe string NoKey (global::Com.Umeng.Socialize.Bean.SHARE_MEDIA p0)
		{
			if (id_noKey_Lcom_umeng_socialize_bean_SHARE_MEDIA_ == IntPtr.Zero)
				id_noKey_Lcom_umeng_socialize_bean_SHARE_MEDIA_ = JNIEnv.GetStaticMethodID (class_ref, "noKey", "(Lcom/umeng/socialize/bean/SHARE_MEDIA;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_noKey_Lcom_umeng_socialize_bean_SHARE_MEDIA_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_resError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='resError' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register ("resError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string ResError (string p0, string p1, string p2)
		{
			if (id_resError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_resError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "resError", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			IntPtr native_p2 = JNIEnv.NewString (p2);
			try {
				JValue* __args = stackalloc JValue [3];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_resError_Ljava_lang_String_Ljava_lang_String_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
				JNIEnv.DeleteLocalRef (native_p2);
			}
		}

		static IntPtr id_supportStyle_ZLjava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='supportStyle' and count(parameter)=2 and parameter[1][@type='boolean'] and parameter[2][@type='java.lang.String']]"
		[Register ("supportStyle", "(ZLjava/lang/String;)Ljava/lang/String;", "")]
		public static unsafe string SupportStyle (bool p0, string p1)
		{
			if (id_supportStyle_ZLjava_lang_String_ == IntPtr.Zero)
				id_supportStyle_ZLjava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "supportStyle", "(ZLjava/lang/String;)Ljava/lang/String;");
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (native_p1);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_supportStyle_ZLjava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_tencentEmpty_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='tencentEmpty' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("tencentEmpty", "(Z)Ljava/lang/String;", "")]
		public static unsafe string TencentEmpty (bool p0)
		{
			if (id_tencentEmpty_Z == IntPtr.Zero)
				id_tencentEmpty_Z = JNIEnv.GetStaticMethodID (class_ref, "tencentEmpty", "(Z)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_tencentEmpty_Z, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_urlEmpty_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.utils']/class[@name='UmengText']/method[@name='urlEmpty' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("urlEmpty", "(I)Ljava/lang/String;", "")]
		public static unsafe string UrlEmpty (int p0)
		{
			if (id_urlEmpty_I == IntPtr.Zero)
				id_urlEmpty_I = JNIEnv.GetStaticMethodID (class_ref, "urlEmpty", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_urlEmpty_I, __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
