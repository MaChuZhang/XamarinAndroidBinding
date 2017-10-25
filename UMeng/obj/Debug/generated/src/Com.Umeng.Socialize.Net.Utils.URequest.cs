using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Net.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']"
	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/URequest", DoNotGenerateAcw=true)]
	public abstract partial class URequest : global::Java.Lang.Object {


		static IntPtr APPLICATION_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='APPLICATION']"
		[Register ("APPLICATION")]
		protected static string Application {
			get {
				if (APPLICATION_jfieldId == IntPtr.Zero)
					APPLICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (APPLICATION_jfieldId == IntPtr.Zero)
					APPLICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, APPLICATION_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr GET_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='GET']"
		[Register ("GET")]
		protected static string Get {
			get {
				if (GET_jfieldId == IntPtr.Zero)
					GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (GET_jfieldId == IntPtr.Zero)
					GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, GET_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr MULTIPART_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='MULTIPART']"
		[Register ("MULTIPART")]
		protected static string Multipart {
			get {
				if (MULTIPART_jfieldId == IntPtr.Zero)
					MULTIPART_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTIPART", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTIPART_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (MULTIPART_jfieldId == IntPtr.Zero)
					MULTIPART_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTIPART", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, MULTIPART_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr POST_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='POST']"
		[Register ("POST")]
		protected static string Post {
			get {
				if (POST_jfieldId == IntPtr.Zero)
					POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POST_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (POST_jfieldId == IntPtr.Zero)
					POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetStaticField (class_ref, POST_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mBaseUrl_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='mBaseUrl']"
		[Register ("mBaseUrl")]
		protected string MBaseUrl {
			get {
				if (mBaseUrl_jfieldId == IntPtr.Zero)
					mBaseUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseUrl", "Ljava/lang/String;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mBaseUrl_jfieldId);
				return JNIEnv.GetString (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mBaseUrl_jfieldId == IntPtr.Zero)
					mBaseUrl_jfieldId = JNIEnv.GetFieldID (class_ref, "mBaseUrl", "Ljava/lang/String;");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mBaseUrl_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mContext_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='mContext']"
		[Register ("mContext")]
		public global::Android.Content.Context MContext {
			get {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Content.Context> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mContext_jfieldId == IntPtr.Zero)
					mContext_jfieldId = JNIEnv.GetFieldID (class_ref, "mContext", "Landroid/content/Context;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mContext_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mHeaders_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='mHeaders']"
		[Register ("mHeaders")]
		public global::System.Collections.IDictionary MHeaders {
			get {
				if (mHeaders_jfieldId == IntPtr.Zero)
					mHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaders", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mHeaders_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mHeaders_jfieldId == IntPtr.Zero)
					mHeaders_jfieldId = JNIEnv.GetFieldID (class_ref, "mHeaders", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mHeaders_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMethod_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='mMethod']"
		[Register ("mMethod")]
		public global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod MMethod {
			get {
				if (mMethod_jfieldId == IntPtr.Zero)
					mMethod_jfieldId = JNIEnv.GetFieldID (class_ref, "mMethod", "Lcom/umeng/socialize/net/utils/URequest$RequestMethod;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMethod_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMethod_jfieldId == IntPtr.Zero)
					mMethod_jfieldId = JNIEnv.GetFieldID (class_ref, "mMethod", "Lcom/umeng/socialize/net/utils/URequest$RequestMethod;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMethod_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mMimeType_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='mMimeType']"
		[Register ("mMimeType")]
		protected global::Com.Umeng.Socialize.Net.Utils.URequest.MIME MMimeType {
			get {
				if (mMimeType_jfieldId == IntPtr.Zero)
					mMimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMimeType", "Lcom/umeng/socialize/net/utils/URequest$MIME;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mMimeType_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.MIME> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mMimeType_jfieldId == IntPtr.Zero)
					mMimeType_jfieldId = JNIEnv.GetFieldID (class_ref, "mMimeType", "Lcom/umeng/socialize/net/utils/URequest$MIME;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mMimeType_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mParams_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='mParams']"
		[Register ("mParams")]
		public global::System.Collections.IDictionary MParams {
			get {
				if (mParams_jfieldId == IntPtr.Zero)
					mParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mParams", "Ljava/util/Map;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mParams_jfieldId);
				return global::Android.Runtime.JavaDictionary.FromJniHandle (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mParams_jfieldId == IntPtr.Zero)
					mParams_jfieldId = JNIEnv.GetFieldID (class_ref, "mParams", "Ljava/util/Map;");
				IntPtr native_value = global::Android.Runtime.JavaDictionary.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mParams_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static IntPtr mResponseClz_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/field[@name='mResponseClz']"
		[Register ("mResponseClz")]
		public global::Java.Lang.Class MResponseClz {
			get {
				if (mResponseClz_jfieldId == IntPtr.Zero)
					mResponseClz_jfieldId = JNIEnv.GetFieldID (class_ref, "mResponseClz", "Ljava/lang/Class;");
				IntPtr __ret = JNIEnv.GetObjectField (((global::Java.Lang.Object) this).Handle, mResponseClz_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mResponseClz_jfieldId == IntPtr.Zero)
					mResponseClz_jfieldId = JNIEnv.GetFieldID (class_ref, "mResponseClz", "Ljava/lang/Class;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				try {
					JNIEnv.SetField (((global::Java.Lang.Object) this).Handle, mResponseClz_jfieldId, native_value);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}
		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.FilePair']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/URequest$FilePair", DoNotGenerateAcw=true)]
		public partial class FilePair : global::Java.Lang.Object {

			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/utils/URequest$FilePair", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (FilePair); }
			}

			protected FilePair (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_ctor_Ljava_lang_String_arrayB;
			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.FilePair']/constructor[@name='URequest.FilePair' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='byte[]']]"
			[Register (".ctor", "(Ljava/lang/String;[B)V", "")]
			public unsafe FilePair (string p0, byte[] p1)
				: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
			{
				if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
					return;

				IntPtr native_p0 = JNIEnv.NewString (p0);
				IntPtr native_p1 = JNIEnv.NewArray (p1);
				try {
					JValue* __args = stackalloc JValue [2];
					__args [0] = new JValue (native_p0);
					__args [1] = new JValue (native_p1);
					if (GetType () != typeof (FilePair)) {
						SetHandle (
								global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;[B)V", __args),
								JniHandleOwnership.TransferLocalRef);
						global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;[B)V", __args);
						return;
					}

					if (id_ctor_Ljava_lang_String_arrayB == IntPtr.Zero)
						id_ctor_Ljava_lang_String_arrayB = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;[B)V");
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_arrayB, __args),
							JniHandleOwnership.TransferLocalRef);
					JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_arrayB, __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
					if (p1 != null) {
						JNIEnv.CopyArray (native_p1, p1);
						JNIEnv.DeleteLocalRef (native_p1);
					}
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.MIME']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/URequest$MIME", DoNotGenerateAcw=true)]
		protected internal sealed partial class MIME : global::Java.Lang.Enum {


			static IntPtr DEFAULT_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.MIME']/field[@name='DEFAULT']"
			[Register ("DEFAULT")]
			public static global::Com.Umeng.Socialize.Net.Utils.URequest.MIME Default {
				get {
					if (DEFAULT_jfieldId == IntPtr.Zero)
						DEFAULT_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "DEFAULT", "Lcom/umeng/socialize/net/utils/URequest$MIME;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, DEFAULT_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.MIME> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr JSON_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.MIME']/field[@name='JSON']"
			[Register ("JSON")]
			public static global::Com.Umeng.Socialize.Net.Utils.URequest.MIME Json {
				get {
					if (JSON_jfieldId == IntPtr.Zero)
						JSON_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "JSON", "Lcom/umeng/socialize/net/utils/URequest$MIME;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, JSON_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.MIME> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/utils/URequest$MIME", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (MIME); }
			}

			internal MIME (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.MIME']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/utils/URequest$MIME;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Utils.URequest.MIME ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/utils/URequest$MIME;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Net.Utils.URequest.MIME __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.MIME> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.MIME']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/socialize/net/utils/URequest$MIME;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Utils.URequest.MIME[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/net/utils/URequest$MIME;");
				try {
					return (global::Com.Umeng.Socialize.Net.Utils.URequest.MIME[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Net.Utils.URequest.MIME));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.PostStyle']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/URequest$PostStyle", DoNotGenerateAcw=true)]
		public partial class PostStyle : global::Java.Lang.Enum {


			static IntPtr APPLICATION_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.PostStyle']/field[@name='APPLICATION']"
			[Register ("APPLICATION")]
			public static global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle Application {
				get {
					if (APPLICATION_jfieldId == IntPtr.Zero)
						APPLICATION_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "APPLICATION", "Lcom/umeng/socialize/net/utils/URequest$PostStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, APPLICATION_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr MULTIPART_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.PostStyle']/field[@name='MULTIPART']"
			[Register ("MULTIPART")]
			public static global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle Multipart {
				get {
					if (MULTIPART_jfieldId == IntPtr.Zero)
						MULTIPART_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "MULTIPART", "Lcom/umeng/socialize/net/utils/URequest$PostStyle;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, MULTIPART_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/utils/URequest$PostStyle", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (PostStyle); }
			}

			protected PostStyle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.PostStyle']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/utils/URequest$PostStyle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/utils/URequest$PostStyle;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.PostStyle']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/socialize/net/utils/URequest$PostStyle;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/net/utils/URequest$PostStyle;");
				try {
					return (global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Net.Utils.URequest.PostStyle));
				} finally {
				}
			}

		}

		// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.RequestMethod']"
		[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/URequest$RequestMethod", DoNotGenerateAcw=true)]
		public partial class RequestMethod : global::Java.Lang.Enum {


			static IntPtr GET_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.RequestMethod']/field[@name='GET']"
			[Register ("GET")]
			public static global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod Get {
				get {
					if (GET_jfieldId == IntPtr.Zero)
						GET_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "GET", "Lcom/umeng/socialize/net/utils/URequest$RequestMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, GET_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}

			static IntPtr POST_jfieldId;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.RequestMethod']/field[@name='POST']"
			[Register ("POST")]
			public static global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod Post {
				get {
					if (POST_jfieldId == IntPtr.Zero)
						POST_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "POST", "Lcom/umeng/socialize/net/utils/URequest$RequestMethod;");
					IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, POST_jfieldId);
					return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod> (__ret, JniHandleOwnership.TransferLocalRef);
				}
			}
			internal static IntPtr java_class_handle;
			internal static IntPtr class_ref {
				get {
					return JNIEnv.FindClass ("com/umeng/socialize/net/utils/URequest$RequestMethod", ref java_class_handle);
				}
			}

			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			protected override global::System.Type ThresholdType {
				get { return typeof (RequestMethod); }
			}

			protected RequestMethod (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

			static IntPtr id_valueOf_Ljava_lang_String_;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.RequestMethod']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/utils/URequest$RequestMethod;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod ValueOf (string p0)
			{
				if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
					id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/net/utils/URequest$RequestMethod;");
				IntPtr native_p0 = JNIEnv.NewString (p0);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_p0);
					global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
					return __ret;
				} finally {
					JNIEnv.DeleteLocalRef (native_p0);
				}
			}

			static IntPtr id_values;
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest.RequestMethod']/method[@name='values' and count(parameter)=0]"
			[Register ("values", "()[Lcom/umeng/socialize/net/utils/URequest$RequestMethod;", "")]
			public static unsafe global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod[] Values ()
			{
				if (id_values == IntPtr.Zero)
					id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/net/utils/URequest$RequestMethod;");
				try {
					return (global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Net.Utils.URequest.RequestMethod));
				} finally {
				}
			}

		}

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/net/utils/URequest", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (URequest); }
		}

		protected URequest (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_String_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/constructor[@name='URequest' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe URequest (string p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				if (GetType () != typeof (URequest)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Ljava/lang/String;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Ljava/lang/String;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_String_ == IntPtr.Zero)
					id_ctor_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/String;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_String_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Ljava_lang_String_, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getBaseUrl;
#pragma warning disable 0169
		static Delegate GetGetBaseUrlHandler ()
		{
			if (cb_getBaseUrl == null)
				cb_getBaseUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBaseUrl);
			return cb_getBaseUrl;
		}

		static IntPtr n_GetBaseUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.BaseUrl);
		}
#pragma warning restore 0169

		static Delegate cb_setBaseUrl_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetSetBaseUrl_Ljava_lang_String_Handler ()
		{
			if (cb_setBaseUrl_Ljava_lang_String_ == null)
				cb_setBaseUrl_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetBaseUrl_Ljava_lang_String_);
			return cb_setBaseUrl_Ljava_lang_String_;
		}

		static void n_SetBaseUrl_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.BaseUrl = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getBaseUrl;
		static IntPtr id_setBaseUrl_Ljava_lang_String_;
		public virtual unsafe string BaseUrl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='getBaseUrl' and count(parameter)=0]"
			[Register ("getBaseUrl", "()Ljava/lang/String;", "GetGetBaseUrlHandler")]
			get {
				if (id_getBaseUrl == IntPtr.Zero)
					id_getBaseUrl = JNIEnv.GetMethodID (class_ref, "getBaseUrl", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBaseUrl), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBaseUrl", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='setBaseUrl' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("setBaseUrl", "(Ljava/lang/String;)V", "GetSetBaseUrl_Ljava_lang_String_Handler")]
			set {
				if (id_setBaseUrl_Ljava_lang_String_ == IntPtr.Zero)
					id_setBaseUrl_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "setBaseUrl", "(Ljava/lang/String;)V");
				IntPtr native_value = JNIEnv.NewString (value);
				try {
					JValue* __args = stackalloc JValue [1];
					__args [0] = new JValue (native_value);

					if (GetType () == ThresholdType)
						JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_setBaseUrl_Ljava_lang_String_, __args);
					else
						JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setBaseUrl", "(Ljava/lang/String;)V"), __args);
				} finally {
					JNIEnv.DeleteLocalRef (native_value);
				}
			}
		}

		static Delegate cb_getBodyPair;
#pragma warning disable 0169
		static Delegate GetGetBodyPairHandler ()
		{
			if (cb_getBodyPair == null)
				cb_getBodyPair = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetBodyPair);
			return cb_getBodyPair;
		}

		static IntPtr n_GetBodyPair (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.BodyPair);
		}
#pragma warning restore 0169

		static IntPtr id_getBodyPair;
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> BodyPair {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='getBodyPair' and count(parameter)=0]"
			[Register ("getBodyPair", "()Ljava/util/Map;", "GetGetBodyPairHandler")]
			get {
				if (id_getBodyPair == IntPtr.Zero)
					id_getBodyPair = JNIEnv.GetMethodID (class_ref, "getBodyPair", "()Ljava/util/Map;");
				try {

					if (GetType () == ThresholdType)
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getBodyPair), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBodyPair", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getHttpMethod;
#pragma warning disable 0169
		static Delegate GetGetHttpMethodHandler ()
		{
			if (cb_getHttpMethod == null)
				cb_getHttpMethod = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetHttpMethod);
			return cb_getHttpMethod;
		}

		static IntPtr n_GetHttpMethod (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.HttpMethod);
		}
#pragma warning restore 0169

		static IntPtr id_getHttpMethod;
		protected virtual unsafe string HttpMethod {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='getHttpMethod' and count(parameter)=0]"
			[Register ("getHttpMethod", "()Ljava/lang/String;", "GetGetHttpMethodHandler")]
			get {
				if (id_getHttpMethod == IntPtr.Zero)
					id_getHttpMethod = JNIEnv.GetMethodID (class_ref, "getHttpMethod", "()Ljava/lang/String;");
				try {

					if (GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getHttpMethod), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getHttpMethod", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_addStringParams_Ljava_lang_String_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetAddStringParams_Ljava_lang_String_Ljava_lang_String_Handler ()
		{
			if (cb_addStringParams_Ljava_lang_String_Ljava_lang_String_ == null)
				cb_addStringParams_Ljava_lang_String_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_AddStringParams_Ljava_lang_String_Ljava_lang_String_);
			return cb_addStringParams_Ljava_lang_String_Ljava_lang_String_;
		}

		static void n_AddStringParams_Ljava_lang_String_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			string p1 = JNIEnv.GetString (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.AddStringParams (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_addStringParams_Ljava_lang_String_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='addStringParams' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String']]"
		[Register ("addStringParams", "(Ljava/lang/String;Ljava/lang/String;)V", "GetAddStringParams_Ljava_lang_String_Ljava_lang_String_Handler")]
		public virtual unsafe void AddStringParams (string p0, string p1)
		{
			if (id_addStringParams_Ljava_lang_String_Ljava_lang_String_ == IntPtr.Zero)
				id_addStringParams_Ljava_lang_String_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "addStringParams", "(Ljava/lang/String;Ljava/lang/String;)V");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = JNIEnv.NewString (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addStringParams_Ljava_lang_String_Ljava_lang_String_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addStringParams", "(Ljava/lang/String;Ljava/lang/String;)V"), __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static IntPtr id_buildGetParams_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='buildGetParams' and count(parameter)=1 and parameter[1][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("buildGetParams", "(Ljava/util/Map;)Ljava/lang/String;", "")]
		public static unsafe string BuildGetParams (global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p0)
		{
			if (id_buildGetParams_Ljava_util_Map_ == IntPtr.Zero)
				id_buildGetParams_Ljava_util_Map_ = JNIEnv.GetStaticMethodID (class_ref, "buildGetParams", "(Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_buildGetParams_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_buildGetUrl_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetBuildGetUrl_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_buildGetUrl_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_buildGetUrl_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_BuildGetUrl_Ljava_lang_String_Ljava_util_Map_);
			return cb_buildGetUrl_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_BuildGetUrl_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.BuildGetUrl (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_buildGetUrl_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='buildGetUrl' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("buildGetUrl", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "GetBuildGetUrl_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe string BuildGetUrl (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_buildGetUrl_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_buildGetUrl_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "buildGetUrl", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildGetUrl_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "buildGetUrl", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_buildParams;
#pragma warning disable 0169
		static Delegate GetBuildParamsHandler ()
		{
			if (cb_buildParams == null)
				cb_buildParams = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_BuildParams);
			return cb_buildParams;
		}

		static IntPtr n_BuildParams (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (__this.BuildParams ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='buildParams' and count(parameter)=0]"
		[Register ("buildParams", "()Ljava/util/Map;", "GetBuildParamsHandler")]
		public abstract global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> BuildParams ();

		static Delegate cb_generateGetURL_Ljava_lang_String_Ljava_util_Map_;
#pragma warning disable 0169
		static Delegate GetGenerateGetURL_Ljava_lang_String_Ljava_util_Map_Handler ()
		{
			if (cb_generateGetURL_Ljava_lang_String_Ljava_util_Map_ == null)
				cb_generateGetURL_Ljava_lang_String_Ljava_util_Map_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr, IntPtr>) n_GenerateGetURL_Ljava_lang_String_Ljava_util_Map_);
			return cb_generateGetURL_Ljava_lang_String_Ljava_util_Map_;
		}

		static IntPtr n_GenerateGetURL_Ljava_lang_String_Ljava_util_Map_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			var p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (native_p1, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GenerateGetURL (p0, p1));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_generateGetURL_Ljava_lang_String_Ljava_util_Map_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='generateGetURL' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.util.Map&lt;java.lang.String, java.lang.Object&gt;']]"
		[Register ("generateGetURL", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;", "GetGenerateGetURL_Ljava_lang_String_Ljava_util_Map_Handler")]
		public virtual unsafe string GenerateGetURL (string p0, global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> p1)
		{
			if (id_generateGetURL_Ljava_lang_String_Ljava_util_Map_ == IntPtr.Zero)
				id_generateGetURL_Ljava_lang_String_Ljava_util_Map_ = JNIEnv.GetMethodID (class_ref, "generateGetURL", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			IntPtr native_p1 = global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.ToLocalJniHandle (p1);
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_generateGetURL_Ljava_lang_String_Ljava_util_Map_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "generateGetURL", "(Ljava/lang/String;Ljava/util/Map;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
				JNIEnv.DeleteLocalRef (native_p1);
			}
		}

		static Delegate cb_getDecryptString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetDecryptString_Ljava_lang_String_Handler ()
		{
			if (cb_getDecryptString_Ljava_lang_String_ == null)
				cb_getDecryptString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetDecryptString_Ljava_lang_String_);
			return cb_getDecryptString_Ljava_lang_String_;
		}

		static IntPtr n_GetDecryptString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetDecryptString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getDecryptString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='getDecryptString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getDecryptString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetDecryptString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetDecryptString (string p0)
		{
			if (id_getDecryptString_Ljava_lang_String_ == IntPtr.Zero)
				id_getDecryptString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getDecryptString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDecryptString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDecryptString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getEcryptString_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetGetEcryptString_Ljava_lang_String_Handler ()
		{
			if (cb_getEcryptString_Ljava_lang_String_ == null)
				cb_getEcryptString_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, IntPtr>) n_GetEcryptString_Ljava_lang_String_);
			return cb_getEcryptString_Ljava_lang_String_;
		}

		static IntPtr n_GetEcryptString_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			string p0 = JNIEnv.GetString (native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewString (__this.GetEcryptString (p0));
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_getEcryptString_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='getEcryptString' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("getEcryptString", "(Ljava/lang/String;)Ljava/lang/String;", "GetGetEcryptString_Ljava_lang_String_Handler")]
		public virtual unsafe string GetEcryptString (string p0)
		{
			if (id_getEcryptString_Ljava_lang_String_ == IntPtr.Zero)
				id_getEcryptString_Ljava_lang_String_ = JNIEnv.GetMethodID (class_ref, "getEcryptString", "(Ljava/lang/String;)Ljava/lang/String;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);

				string __ret;
				if (GetType () == ThresholdType)
					__ret = JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEcryptString_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				else
					__ret = JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEcryptString", "(Ljava/lang/String;)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static Delegate cb_getFilePair;
#pragma warning disable 0169
		static Delegate GetGetFilePairHandler ()
		{
			if (cb_getFilePair == null)
				cb_getFilePair = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFilePair);
			return cb_getFilePair;
		}

		static IntPtr n_GetFilePair (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.JavaDictionary<string, global::Com.Umeng.Socialize.Net.Utils.URequest.FilePair>.ToLocalJniHandle (__this.GetFilePair ());
		}
#pragma warning restore 0169

		static IntPtr id_getFilePair;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='getFilePair' and count(parameter)=0]"
		[Register ("getFilePair", "()Ljava/util/Map;", "GetGetFilePairHandler")]
		public virtual unsafe global::System.Collections.Generic.IDictionary<string, global::Com.Umeng.Socialize.Net.Utils.URequest.FilePair> GetFilePair ()
		{
			if (id_getFilePair == IntPtr.Zero)
				id_getFilePair = JNIEnv.GetMethodID (class_ref, "getFilePair", "()Ljava/util/Map;");
			try {

				if (GetType () == ThresholdType)
					return global::Android.Runtime.JavaDictionary<string, global::Com.Umeng.Socialize.Net.Utils.URequest.FilePair>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFilePair), JniHandleOwnership.TransferLocalRef);
				else
					return global::Android.Runtime.JavaDictionary<string, global::Com.Umeng.Socialize.Net.Utils.URequest.FilePair>.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFilePair", "()Ljava/util/Map;")), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_onPrepareRequest;
#pragma warning disable 0169
		static Delegate GetOnPrepareRequestHandler ()
		{
			if (cb_onPrepareRequest == null)
				cb_onPrepareRequest = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_OnPrepareRequest);
			return cb_onPrepareRequest;
		}

		static void n_OnPrepareRequest (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.OnPrepareRequest ();
		}
#pragma warning restore 0169

		static IntPtr id_onPrepareRequest;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='onPrepareRequest' and count(parameter)=0]"
		[Register ("onPrepareRequest", "()V", "GetOnPrepareRequestHandler")]
		public virtual unsafe void OnPrepareRequest ()
		{
			if (id_onPrepareRequest == IntPtr.Zero)
				id_onPrepareRequest = JNIEnv.GetMethodID (class_ref, "onPrepareRequest", "()V");
			try {

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onPrepareRequest);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onPrepareRequest", "()V"));
			} finally {
			}
		}

		static Delegate cb_toGetUrl;
#pragma warning disable 0169
		static Delegate GetToGetUrlHandler ()
		{
			if (cb_toGetUrl == null)
				cb_toGetUrl = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToGetUrl);
			return cb_toGetUrl;
		}

		static IntPtr n_ToGetUrl (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ToGetUrl ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='toGetUrl' and count(parameter)=0]"
		[Register ("toGetUrl", "()Ljava/lang/String;", "GetToGetUrlHandler")]
		public abstract string ToGetUrl ();

		static Delegate cb_toJson;
#pragma warning disable 0169
		static Delegate GetToJsonHandler ()
		{
			if (cb_toJson == null)
				cb_toJson = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_ToJson);
			return cb_toJson;
		}

		static IntPtr n_ToJson (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Umeng.Socialize.Net.Utils.URequest __this = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Net.Utils.URequest> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.ToJson ());
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public abstract global::Org.Json.JSONObject ToJson ();

	}

	[global::Android.Runtime.Register ("com/umeng/socialize/net/utils/URequest", DoNotGenerateAcw=true)]
	internal partial class URequestInvoker : URequest {

		public URequestInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer) {}

		protected override global::System.Type ThresholdType {
			get { return typeof (URequestInvoker); }
		}

		static IntPtr id_buildParams;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='buildParams' and count(parameter)=0]"
		[Register ("buildParams", "()Ljava/util/Map;", "GetBuildParamsHandler")]
		public override unsafe global::System.Collections.Generic.IDictionary<string, global::Java.Lang.Object> BuildParams ()
		{
			if (id_buildParams == IntPtr.Zero)
				id_buildParams = JNIEnv.GetMethodID (class_ref, "buildParams", "()Ljava/util/Map;");
			try {
				return global::Android.Runtime.JavaDictionary<string, global::Java.Lang.Object>.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_buildParams), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toGetUrl;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='toGetUrl' and count(parameter)=0]"
		[Register ("toGetUrl", "()Ljava/lang/String;", "GetToGetUrlHandler")]
		public override unsafe string ToGetUrl ()
		{
			if (id_toGetUrl == IntPtr.Zero)
				id_toGetUrl = JNIEnv.GetMethodID (class_ref, "toGetUrl", "()Ljava/lang/String;");
			try {
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toGetUrl), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static IntPtr id_toJson;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.net.utils']/class[@name='URequest']/method[@name='toJson' and count(parameter)=0]"
		[Register ("toJson", "()Lorg/json/JSONObject;", "GetToJsonHandler")]
		public override unsafe global::Org.Json.JSONObject ToJson ()
		{
			if (id_toJson == IntPtr.Zero)
				id_toJson = JNIEnv.GetMethodID (class_ref, "toJson", "()Lorg/json/JSONObject;");
			try {
				return global::Java.Lang.Object.GetObject<global::Org.Json.JSONObject> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toJson), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}

}
