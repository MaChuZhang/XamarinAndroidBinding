using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']"
	[global::Android.Runtime.Register ("com/umeng/socialize/bean/UmengErrorCode", DoNotGenerateAcw=true)]
	public sealed partial class UmengErrorCode : global::Java.Lang.Enum {


		static IntPtr AuthorizeFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/field[@name='AuthorizeFailed']"
		[Register ("AuthorizeFailed")]
		public static global::Com.Umeng.Socialize.Bean.UmengErrorCode AuthorizeFailed {
			get {
				if (AuthorizeFailed_jfieldId == IntPtr.Zero)
					AuthorizeFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "AuthorizeFailed", "Lcom/umeng/socialize/bean/UmengErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, AuthorizeFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr NotInstall_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/field[@name='NotInstall']"
		[Register ("NotInstall")]
		public static global::Com.Umeng.Socialize.Bean.UmengErrorCode NotInstall {
			get {
				if (NotInstall_jfieldId == IntPtr.Zero)
					NotInstall_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "NotInstall", "Lcom/umeng/socialize/bean/UmengErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, NotInstall_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr RequestForUserProfileFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/field[@name='RequestForUserProfileFailed']"
		[Register ("RequestForUserProfileFailed")]
		public static global::Com.Umeng.Socialize.Bean.UmengErrorCode RequestForUserProfileFailed {
			get {
				if (RequestForUserProfileFailed_jfieldId == IntPtr.Zero)
					RequestForUserProfileFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "RequestForUserProfileFailed", "Lcom/umeng/socialize/bean/UmengErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, RequestForUserProfileFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ShareDataNil_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/field[@name='ShareDataNil']"
		[Register ("ShareDataNil")]
		public static global::Com.Umeng.Socialize.Bean.UmengErrorCode ShareDataNil {
			get {
				if (ShareDataNil_jfieldId == IntPtr.Zero)
					ShareDataNil_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ShareDataNil", "Lcom/umeng/socialize/bean/UmengErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ShareDataNil_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ShareDataTypeIllegal_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/field[@name='ShareDataTypeIllegal']"
		[Register ("ShareDataTypeIllegal")]
		public static global::Com.Umeng.Socialize.Bean.UmengErrorCode ShareDataTypeIllegal {
			get {
				if (ShareDataTypeIllegal_jfieldId == IntPtr.Zero)
					ShareDataTypeIllegal_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ShareDataTypeIllegal", "Lcom/umeng/socialize/bean/UmengErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ShareDataTypeIllegal_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr ShareFailed_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/field[@name='ShareFailed']"
		[Register ("ShareFailed")]
		public static global::Com.Umeng.Socialize.Bean.UmengErrorCode ShareFailed {
			get {
				if (ShareFailed_jfieldId == IntPtr.Zero)
					ShareFailed_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ShareFailed", "Lcom/umeng/socialize/bean/UmengErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ShareFailed_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr UnKnowCode_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/field[@name='UnKnowCode']"
		[Register ("UnKnowCode")]
		public static global::Com.Umeng.Socialize.Bean.UmengErrorCode UnKnowCode {
			get {
				if (UnKnowCode_jfieldId == IntPtr.Zero)
					UnKnowCode_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "UnKnowCode", "Lcom/umeng/socialize/bean/UmengErrorCode;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, UnKnowCode_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/bean/UmengErrorCode", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (UmengErrorCode); }
		}

		internal UmengErrorCode (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getMessage;
		public unsafe string Message {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/method[@name='getMessage' and count(parameter)=0]"
			[Register ("getMessage", "()Ljava/lang/String;", "GetGetMessageHandler")]
			get {
				if (id_getMessage == IntPtr.Zero)
					id_getMessage = JNIEnv.GetMethodID (class_ref, "getMessage", "()Ljava/lang/String;");
				try {
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMessage), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/bean/UmengErrorCode;", "")]
		public static unsafe global::Com.Umeng.Socialize.Bean.UmengErrorCode ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/bean/UmengErrorCode;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Umeng.Socialize.Bean.UmengErrorCode __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.UmengErrorCode> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='UmengErrorCode']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/umeng/socialize/bean/UmengErrorCode;", "")]
		public static unsafe global::Com.Umeng.Socialize.Bean.UmengErrorCode[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/bean/UmengErrorCode;");
			try {
				return (global::Com.Umeng.Socialize.Bean.UmengErrorCode[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Bean.UmengErrorCode));
			} finally {
			}
		}

	}
}
