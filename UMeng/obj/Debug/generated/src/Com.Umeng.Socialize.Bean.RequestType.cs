using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Umeng.Socialize.Bean {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='RequestType']"
	[global::Android.Runtime.Register ("com/umeng/socialize/bean/RequestType", DoNotGenerateAcw=true)]
	public partial class RequestType : global::Java.Lang.Enum {


		static IntPtr ANALYTICS_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='RequestType']/field[@name='ANALYTICS']"
		[Register ("ANALYTICS")]
		public static global::Com.Umeng.Socialize.Bean.RequestType Analytics {
			get {
				if (ANALYTICS_jfieldId == IntPtr.Zero)
					ANALYTICS_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "ANALYTICS", "Lcom/umeng/socialize/bean/RequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, ANALYTICS_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.RequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr API_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='RequestType']/field[@name='API']"
		[Register ("API")]
		public static global::Com.Umeng.Socialize.Bean.RequestType Api {
			get {
				if (API_jfieldId == IntPtr.Zero)
					API_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "API", "Lcom/umeng/socialize/bean/RequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, API_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.RequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}

		static IntPtr SOCIAL_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='RequestType']/field[@name='SOCIAL']"
		[Register ("SOCIAL")]
		public static global::Com.Umeng.Socialize.Bean.RequestType Social {
			get {
				if (SOCIAL_jfieldId == IntPtr.Zero)
					SOCIAL_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "SOCIAL", "Lcom/umeng/socialize/bean/RequestType;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, SOCIAL_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.RequestType> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/umeng/socialize/bean/RequestType", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (RequestType); }
		}

		protected RequestType (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_valueOf_Ljava_lang_String_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='RequestType']/method[@name='valueOf' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/bean/RequestType;", "")]
		public static unsafe global::Com.Umeng.Socialize.Bean.RequestType ValueOf (string p0)
		{
			if (id_valueOf_Ljava_lang_String_ == IntPtr.Zero)
				id_valueOf_Ljava_lang_String_ = JNIEnv.GetStaticMethodID (class_ref, "valueOf", "(Ljava/lang/String;)Lcom/umeng/socialize/bean/RequestType;");
			IntPtr native_p0 = JNIEnv.NewString (p0);
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (native_p0);
				global::Com.Umeng.Socialize.Bean.RequestType __ret = global::Java.Lang.Object.GetObject<global::Com.Umeng.Socialize.Bean.RequestType> (JNIEnv.CallStaticObjectMethod  (class_ref, id_valueOf_Ljava_lang_String_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
				JNIEnv.DeleteLocalRef (native_p0);
			}
		}

		static IntPtr id_values;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.umeng.socialize.bean']/class[@name='RequestType']/method[@name='values' and count(parameter)=0]"
		[Register ("values", "()[Lcom/umeng/socialize/bean/RequestType;", "")]
		public static unsafe global::Com.Umeng.Socialize.Bean.RequestType[] Values ()
		{
			if (id_values == IntPtr.Zero)
				id_values = JNIEnv.GetStaticMethodID (class_ref, "values", "()[Lcom/umeng/socialize/bean/RequestType;");
			try {
				return (global::Com.Umeng.Socialize.Bean.RequestType[]) JNIEnv.GetArray (JNIEnv.CallStaticObjectMethod  (class_ref, id_values), JniHandleOwnership.TransferLocalRef, typeof (global::Com.Umeng.Socialize.Bean.RequestType));
			} finally {
			}
		}

	}
}
